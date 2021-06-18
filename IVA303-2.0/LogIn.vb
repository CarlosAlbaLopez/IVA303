Imports MySql.Data.MySqlClient

Public Class LogIn

    Dim connection As New MySqlConnection("Server=192.168.0.178;Database=iva303;Uid=jairo;Pwd=test;Convert Zero Datetime=True")
    Dim rs As New Resizer

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True
        rs.FindAllControls(Me)
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Trim(TextBox1.Text) = "" Or Trim(TextBox2.Text) = "" Then
            MsgBox("Introduce tus datos mamarracho", vbExclamation, "Empty Fields Found")
        Else
            connection.Open()
            Dim userQuery = "Select * from USUARIOS where NOMBRE = '" & TextBox1.Text & "' and CONTRASEÑA = '" & TextBox2.Text & "'"
            Dim cmd = New MySqlCommand(userQuery, connection)
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            Try
                If dr.Read = False Then
                    MsgBox("Datos incorrectos", vbCritical, "Invalid Login")
                Else
                    MsgBox("Bien hecho", vbInformation, "Login Succeeded")
                    Main.Show()
                    Me.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            connection.Close()
        End If
    End Sub
End Class