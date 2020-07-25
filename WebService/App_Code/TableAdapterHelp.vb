Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Reflection
Imports Microsoft.VisualBasic

'Origem: http://weblogs.asp.net/ryanw/archive/2006/03/30/441529.aspx
Public Class TableAdapterHelper

    Public Function BeginTransaction(ByVal MyTableAdapter As Object) As SqlTransaction

        Return BeginTransaction(MyTableAdapter, IsolationLevel.ReadUncommitted)

    End Function

    Public Function BeginTransaction(ByVal MyTableAdapter As Object, ByVal MyIsolationLevel As IsolationLevel) As SqlTransaction
        Dim TAType As Type = MyTableAdapter.GetType
        Dim Conn As SqlConnection = GetConnection(MyTableAdapter)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
        Dim Tran As SqlTransaction = Conn.BeginTransaction(MyIsolationLevel)
        SetTransaction(MyTableAdapter, Tran)
        Return Tran
    End Function

    'Meu jeito, mesclado do ryan, roberto e damo
    Public Sub SetTransaction(ByVal MyTableAdapter As Object, ByVal MyTransaction As SqlTransaction)
        Dim MyType As Type = MyTableAdapter.GetType

        'Original Ryan method
        'Este método so coloca a transação nas queries/comandos
        'Entrentanto não coloca a transação nos comandos de Delete, Inset e Update
        'O bloco abaixo, sugerido pelo Roberto(f) faz este trabalho
        Dim CommandsProperty As PropertyInfo = MyType.GetProperty("CommandCollection", BindingFlags.NonPublic Or BindingFlags.Instance)
        Dim Commands() As SqlCommand = CType(CommandsProperty.GetValue(MyTableAdapter, Nothing), SqlCommand())
        For Each Command As SqlCommand In Commands
            If Command.CommandText <> "" Then
                Command.Transaction = MyTransaction
            End If
        Next Command

        'Roberto(F) 's alternative suggestion...
        Dim AdapterProperty As PropertyInfo = MyType.GetProperty("Adapter", BindingFlags.NonPublic Or BindingFlags.Instance)
        Dim MyDataAdapter As SqlDataAdapter = CType(AdapterProperty.GetValue(MyTableAdapter, Nothing), SqlDataAdapter)
        With MyDataAdapter
            If Not .DeleteCommand Is Nothing Then .DeleteCommand.Transaction = MyTransaction
            If Not .InsertCommand Is Nothing Then .InsertCommand.Transaction = MyTransaction
            If Not .UpdateCommand Is Nothing Then .UpdateCommand.Transaction = MyTransaction
        End With
        'Damo veio sugerir depois que ele teve que corrigir o método para incluir queries
        'Na verdade não precisa, o código que ele gerou é quase identico ao do Ryan e faz a mesma coisa
        'O que precisava era unir os dois métodos

        SetConnection(MyTableAdapter, MyTransaction.Connection)

    End Sub

    Private Function GetConnection(ByVal MyTableAdapter As Object) As SqlConnection
        Dim MyType As Type = MyTableAdapter.GetType
        Dim ConnProperty As PropertyInfo = MyType.GetProperty("Connection", BindingFlags.NonPublic Or BindingFlags.Instance)
        Dim Conn As SqlConnection = CType(ConnProperty.GetValue(MyTableAdapter, Nothing), SqlConnection)
        Return Conn
    End Function

    Private Sub SetConnection(ByVal MyTableAdapter As Object, ByVal MyConnection As SqlConnection)
        Dim MyType As Type = MyTableAdapter.GetType
        Dim ConnProperty As PropertyInfo = MyType.GetProperty("Connection", BindingFlags.NonPublic Or BindingFlags.Instance)
        ConnProperty.SetValue(MyTableAdapter, MyConnection, Nothing)
    End Sub

End Class