Imports MySql.Data.MySqlClient

Public Class CambiarTipoDoc

    Dim connection As New MySqlConnection("Server=192.168.0.178;Database=iva303;Uid=jairo;Pwd=test;Convert Zero Datetime=True")
    Dim i = Certificacion3.DGV_Tickets.CurrentRow.Index
    Dim j = 0
    Dim id = Certificacion3.DGV_Tickets.Item(j, i).Value
    Dim rs As New Resizer

    Private Sub CambiarTipoDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_simplificada.Click

        Dim UpdateDocState As New MySqlCommand("Update DOCUMENTOS set ID_TIPO = 1 where ID = @ID", connection)

        UpdateDocState.Parameters.AddWithValue("@ID", DbNullOrStringValue(id))

        connection.Open()
        UpdateDocState.ExecuteNonQuery()
        connection.Close()

        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_incompleta.Click

        Dim UpdateDocState As New MySqlCommand("Update DOCUMENTOS set ID_TIPO = 2 where ID = @ID", connection)

        UpdateDocState.Parameters.AddWithValue("@ID", DbNullOrStringValue(id))

        connection.Open()
        UpdateDocState.ExecuteNonQuery()
        connection.Close()

        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_completa.Click

        Dim UpdateDocState As New MySqlCommand("Update DOCUMENTOS set ID_TIPO = 3 where ID = @ID", connection)

        UpdateDocState.Parameters.AddWithValue("@ID", DbNullOrStringValue(id))

        connection.Open()
        UpdateDocState.ExecuteNonQuery()
        connection.Close()

        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_canje.Click

        Dim UpdateDocState As New MySqlCommand("Update DOCUMENTOS set ID_TIPO = 4 where ID = @ID", connection)

        UpdateDocState.Parameters.AddWithValue("@ID", DbNullOrStringValue(id))

        connection.Open()
        UpdateDocState.ExecuteNonQuery()
        connection.Close()

        Me.Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_noFactura.Click

        Dim UpdateDocState As New MySqlCommand("Update DOCUMENTOS set ID_TIPO = 5 where ID = @ID", connection)

        UpdateDocState.Parameters.AddWithValue("@ID", DbNullOrStringValue(id))

        connection.Open()
        UpdateDocState.ExecuteNonQuery()
        connection.Close()

        Me.Close()

    End Sub
End Class