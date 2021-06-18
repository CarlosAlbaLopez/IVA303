Public Class Comunidades
    Private Sub Alta_Click(sender As System.Object, e As System.EventArgs) Handles AltaToolStripMenuItem.Click
        EnviosProveedor.Show()
    End Sub

    Private Sub Análisis_Click(sender As Object, e As EventArgs) Handles AnálisisToolStripMenuItem.Click
        C_Analisis.show()
    End Sub

    Private Sub Empresas_Click(sender As Object, e As EventArgs) Handles EmpresasToolStripMenuItem.Click
        C_Empresas.Show()
    End Sub

    Private Sub Clientes_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        C_Clientes.Show()
    End Sub

    Private Sub AdministradoresToolStripMenuItem_Click(sender As Object, e As EventArgs)
        C_Administradores.Show()
    End Sub


End Class