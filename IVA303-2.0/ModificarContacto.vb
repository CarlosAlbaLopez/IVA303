Imports MySql.Data.MySqlClient

Public Class ModificarContacto

    Dim connection As New MySqlConnection("Server=192.168.0.178;Database=iva303;Uid=jairo;Pwd=test;Convert Zero Datetime=True")
    Dim rs As New Resizer
    Dim i = AltaEmpresa.dgvContactos.CurrentRow.Index
    Dim ID = AltaEmpresa.dgvContactos.Item(0, i).Value

    Private Sub ModificarContacto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim findContacto As New MySqlCommand("SELECT * FROM CONTACTOS_EMPRESAS WHERE ID = @ID", connection)
        findContacto.Parameters.AddWithValue("@ID", DbNullOrStringValue(ID))
        Dim findAdapter As New MySqlDataAdapter(findContacto)
        Dim findTable As New DataTable()
        findAdapter.Fill(findTable)

        Dim contacto = findTable.Rows(0)("CONTACTO").ToString()
        Dim cargo = findTable.Rows(0)("CARGO").ToString()
        Dim tlf = findTable.Rows(0)("TELEFONO").ToString()
        Dim email = findTable.Rows(0)("EMAIL").ToString()

        tbNombre.Text = contacto
        tbCargo.Text = cargo
        tbTelefono.Text = tlf
        tbEmail.Text = email

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

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim findContacto As New MySqlCommand("SELECT * FROM CONTACTOS_EMPRESAS WHERE ID = @ID", connection)
        findContacto.Parameters.AddWithValue("@ID", DbNullOrStringValue(ID))
        Dim findAdapter As New MySqlDataAdapter(findContacto)
        Dim findTable As New DataTable()
        findAdapter.Fill(findTable)
        Dim nombre = findTable.Rows(0)("CONTACTO").ToString()
        Dim cargo = findTable.Rows(0)("CARGO").ToString()
        Dim tlf = findTable.Rows(0)("TELEFONO").ToString()
        Dim email = findTable.Rows(0)("EMAIL").ToString()

        Dim updateContactQuery As New MySqlCommand("UPDATE CONTACTOS_EMPRESAS SET CONTACTO = @CONTACTO, CARGO = @CARGO, TELEFONO = @TELEFONO, EMAIL = @EMAIL
                                                    WHERE ID = @ID", connection)

        updateContactQuery.Parameters.AddWithValue("@ID", DbNullOrStringValue(ID))
        updateContactQuery.Parameters.AddWithValue("@CONTACTO", DbNullOrStringValue(tbNombre.Text))
        updateContactQuery.Parameters.AddWithValue("@CARGO", DbNullOrStringValue(tbCargo.Text))
        updateContactQuery.Parameters.AddWithValue("@TELEFONO", DbNullOrStringValue(tbTelefono.Text))
        updateContactQuery.Parameters.AddWithValue("@EMAIL", DbNullOrStringValue(tbEmail.Text))

        connection.Open()
        updateContactQuery.ExecuteNonQuery()
        connection.Close()

        AltaEmpresa.populate_dgvContactos()

        Me.Close()
    End Sub
End Class