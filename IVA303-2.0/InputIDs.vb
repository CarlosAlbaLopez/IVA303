Imports MySql.Data.MySqlClient

Public Class InputIDs

    Dim connection As New MySqlConnection("Server=192.168.0.178;Database=iva303;Uid=jairo;Pwd=test;Convert Zero Datetime=True")
    Dim rs As New Resizer

    Private Sub InputIDs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Public Function DbNullOrStringValue(ByVal value As String) As Object
        If String.IsNullOrEmpty(value) Then
            Return DBNull.Value
        Else
            Return value
        End If
    End Function

    Private Sub BTN_Search_Click(sender As Object, e As EventArgs) Handles BTN_Search.Click

        For Each Line As String In TextBox1.Lines

            Dim searchQuery As String = "SELECT ID,CIF,FECHA,REFERENCIA,SUMA_BASE,SUMA_IVA,SUMA_TOTAL,RUTA From DOCUMENTOS where ID = @ID"

            Dim command As New MySqlCommand(searchQuery, connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()

            command.Parameters.AddWithValue("@ID", DbNullOrStringValue(Line))

            adapter.Fill(table)

            Analisis.DataGridView1.AllowUserToAddRows = False

            Analisis.DataGridView1.RowTemplate.Height = 100
            Dim imgc As New DataGridViewImageColumn
            Analisis.DataGridView1.DataSource = table

        Next

    End Sub
End Class