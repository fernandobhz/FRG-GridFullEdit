Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class WebService
    Inherits System.Web.Services.WebService

    Private Tah As New TableAdapterHelper

    <WebMethod()> _
    Function Modifica(ByVal DS As MascaraTeste) As MascaraTeste.MSK_FORNECEDORDataTable
        DS.Tables(0).Rows(0).Item("NM_CONTATO") = "TESTE"
        Return DS.MSK_FORNECEDOR.GetChanges(DataRowState.Modified)
    End Function

    <WebMethod()> _
    Public Sub fillMascara(ByRef x As MascaraTeste)
        Dim TA As New MascaraTesteTableAdapters.MSK_FORNECEDORTableAdapter
        TA.Fill(x.MSK_FORNECEDOR)
    End Sub

    <WebMethod()> _
    Public Function getMascara() As MascaraTeste.MSK_FORNECEDORDataTable
        Dim TA As New MascaraTesteTableAdapters.MSK_FORNECEDORTableAdapter
        Return TA.GetData
    End Function
    <WebMethod()> _
   Public Function setMascara(ByVal DS As MascaraTeste) As Integer
        For Each R As MascaraTeste.MSK_FORNECEDORRow In DS.MSK_FORNECEDOR
            If (R.RowState = DataRowState.Modified) Or (R.RowState = DataRowState.Added) Then
                If Not R.IsTE_CONTATONull Then R.TE_CONTATO = OnlyNumbers(R.TE_CONTATO)
                If Not R.IsTE_CORPORATIVONull Then R.TE_CORPORATIVO = OnlyNumbers(R.TE_CORPORATIVO)
                If Not R.IsTE_FAXNull Then R.TE_FAX = OnlyNumbers(R.TE_FAX)
            End If
        Next

        Dim TA As New MascaraTesteTableAdapters.MSK_FORNECEDORTableAdapter
        Dim Tran As SqlTransaction = Tah.BeginTransaction(TA)
        Try
            Dim Ret As Integer = TA.Update(DS)
            Tran.Commit()
            Return Ret
        Catch ex As Exception
            Tran.Rollback()
            Throw New Exception(ex.Message)
        Finally
            Tran.Dispose()
        End Try

    End Function

    <WebMethod()> _
   Public Function updateMascara(ByRef DS As MascaraTeste) As Integer
        For Each R As MascaraTeste.MSK_FORNECEDORRow In DS.MSK_FORNECEDOR
            If (R.RowState = DataRowState.Modified) Or (R.RowState = DataRowState.Added) Then
                If Not R.IsTE_CONTATONull Then R.TE_CONTATO = OnlyNumbers(R.TE_CONTATO)
                If Not R.IsTE_CORPORATIVONull Then R.TE_CORPORATIVO = OnlyNumbers(R.TE_CORPORATIVO)
                If Not R.IsTE_FAXNull Then R.TE_FAX = OnlyNumbers(R.TE_FAX)
            End If
        Next

        Dim TA As New MascaraTesteTableAdapters.MSK_FORNECEDORTableAdapter
        Dim Tran As SqlTransaction = Tah.BeginTransaction(TA)
        Try
            Dim Ret As Integer = TA.Update(DS)
            Tran.Commit()
            Return Ret
        Catch ex As Exception
            Tran.Rollback()
            Throw New Exception(ex.Message)
        Finally
            Tran.Dispose()
        End Try

    End Function

    Private Function OnlyNumbers(ByVal S As Object) As String
        If IsDBNull(S) Then Return Nothing

        Dim Ret As String = String.Empty

        For Each C As Char In S
            If Char.IsNumber(C) Then Ret &= C
        Next

        Return Ret
    End Function

End Class
