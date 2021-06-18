Public Class Main

    Dim rs As New Resizer

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub Alta_Click(sender As System.Object, e As System.EventArgs) Handles Alta.Click
        mAlta.Show()
    End Sub

    Private Sub Análisis_Click(sender As Object, e As EventArgs) Handles Análisis.Click
        Analisis.Show()
    End Sub

    Private Sub Empresas_Click(sender As Object, e As EventArgs) Handles btnEmpresas.Click
        Empresas.Show()
    End Sub

    Private Sub CRMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CRMToolStripMenuItem.Click
        CRM.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Clientes.Show()
    End Sub

    Private Sub MailingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MailingToolStripMenuItem.Click
        SendEmails.Show()
    End Sub
End Class