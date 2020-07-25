Imports System.Data.SqlClient

Public Class Form1

    Dim WSGrid As New GridFullEdit.WSGrid.WebService
    'Método Fill
    'Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    WSGrid.fillMascara(Me.MascaraTeste)
    '    Me.MSK_FORNECEDORBindingSource.DataSource = Me.MascaraTeste
    'End Sub

    'Private Sub btnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta.Click
    '    WSGrid.fillMascara(Me.MascaraTeste)
    '    Me.MSK_FORNECEDORBindingSource.DataSource = Me.MascaraTeste
    'End Sub

    'Private Sub btnModifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifica.Click
    '    Me.MascaraTeste.Merge(WSGrid.Modifica(Me.MascaraTeste))
    '    Me.MSK_FORNECEDORBindingSource.DataSource = Me.MascaraTeste
    'End Sub

    'Private Sub btnSalva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalva.Click
    '    Me.Validate()
    '    Me.MSK_FORNECEDORBindingSource.EndEdit()
    '    WSGrid.updateMascara(Me.MascaraTeste)

    '    Me.MSK_FORNECEDORBindingSource.DataSource = Me.MascaraTeste
    'End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MascaraTeste.Merge(WSGrid.getMascara)
    End Sub

    Private Sub btnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta.Click
        Me.MascaraTeste.Merge(WSGrid.getMascara)
    End Sub

    Private Sub btnModifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifica.Click
        Me.MascaraTeste.Merge(WSGrid.Modifica(Me.MascaraTeste))
    End Sub

    Private Sub btnSalva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalva.Click
        Me.Validate()
        Me.MSK_FORNECEDORBindingSource.EndEdit()
        'Aqui está o segredo, o data set é passado por REFERÊNCIA
        'Lá ele é atualizado com os valores identity e default do banco de dados
        WSGrid.updateMascara(Me.MascaraTeste)
        'Isso aqui é uma adaptação para um "bug" do componente
        'Ele não enxerga a modificação efetuada no dataset no webservice
        Me.MSK_FORNECEDORBindingSource.DataSource = Me.MascaraTeste
    End Sub

End Class