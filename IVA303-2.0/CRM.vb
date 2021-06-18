Imports System.Data.OleDb
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class CRM

    Dim connection As New MySqlConnection("Server=192.168.0.178;Database=iva303;Uid=jairo;Pwd=test;Convert Zero Datetime=True")
    Dim rs As New Resizer
    Private Excel03ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0;HDR=YES'"
    Private Excel07ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0;HDR=YES'"

    Private Sub CRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Llena el ComboBox Operador
        Dim opcommand As New MySqlCommand("select * from USUARIOS", connection)
        Dim opadapter As New MySqlDataAdapter(opcommand)
        Dim optable As New DataTable()
        opadapter.Fill(optable)
        SendKeys.Send("{ENTER}")
        cbOperador.DataSource = optable
        SendKeys.Send("{ENTER}")
        cbOperador.DisplayMember = "NOMBRE"
        SendKeys.Send("{ENTER}")
        cbOperador.ValueMember = "ID"

        'Llena el ComboBox Estado
        Dim escommand As New MySqlCommand("select * from ESTADOS_CLIENTES", connection)
        Dim esadapter As New MySqlDataAdapter(escommand)
        Dim estable As New DataTable()
        esadapter.Fill(estable)
        SendKeys.Send("{ENTER}")
        cbEstado.DataSource = estable
        SendKeys.Send("{ENTER}")
        cbEstado.DisplayMember = "NOMBRE"
        SendKeys.Send("{ENTER}")
        cbEstado.ValueMember = "ID"

        populateDatagridview()
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

    Private Sub populateDatagridview()

        Try
            Dim searchQuery As String = "SELECT NOMBRE_FISCAL, SECTOR, CP, TELEFONO, EMAIL, E.NOMBRE AS ESTADO,
                                        (SELECT MAX(FECHA) FROM ACTIVIDADES WHERE ID_CLIENTE = C.ID) AS ULTIMA_ACTIVIDAD
                                        FROM CLIENTES C LEFT JOIN ESTADOS_CLIENTES E ON C.ID_ESTADO = E.ID
                                        WHERE ACTIVO = 'NO' LIMIT 50"

            Dim command As New MySqlCommand(searchQuery, connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGV_CRM.DataSource = table
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

    Private Sub AbrirFichaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirFichaToolStripMenuItem.Click
        AltaCliente.Show()
    End Sub

    Private Sub AltaClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaClienteToolStripMenuItem.Click
        Me.Close()
        AltaCliente.Show()
    End Sub

    Private Sub OpenExcel()

        Dim OpenFileDialog As New OpenFileDialog

        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "All Files (*.*)|*.*|Excel Files (*.xlsx)|*.xlsx|Xls Files (*.xls)|*.xls"
        If OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            Dim filePath As String = OpenFileDialog.FileName
            Dim extension As String = Path.GetExtension(filePath)
            Dim header As String = "=YES"
            Dim conStr As String, sheetName As String

            conStr = String.Empty
            Select Case extension
                Case "*.xls"
                    'excel 97-03
                    conStr = String.Format(Excel03ConString, filePath, header)
                    Exit Select
                Case ".xlsx"
                    conStr = String.Format(Excel07ConString, filePath, header)
                    Exit Select
            End Select

            Using con As New OleDbConnection(conStr)
                Using cmd As New OleDbCommand()
                    cmd.Connection = con
                    con.Open()
                    Dim dtExcelSchema As DataTable = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
                    sheetName = dtExcelSchema.Rows(0)("TABLE_NAME").ToString()
                    con.Close()
                End Using
            End Using

            Using con As New OleDbConnection(conStr)
                Using cmd As New OleDbCommand()
                    Using oda As New OleDbDataAdapter()
                        Dim dt As New DataTable()
                        cmd.CommandText = (Convert.ToString("SELECT * FROM [") & sheetName) + "]"
                        cmd.Connection = con
                        con.Open()
                        oda.SelectCommand = cmd
                        oda.Fill(dt)
                        con.Close()
                        DGV_CRM.DataSource = dt
                    End Using
                End Using
            End Using

        End If

    End Sub

    Private Sub ImportarExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarExcelToolStripMenuItem.Click
        OpenExcel()

        Try
            Dim cmd As MySqlCommand
            connection.Open()
            For i As Integer = 0 To DGV_CRM.Rows.Count - 1 Step +1
                cmd = New MySqlCommand("INSERT INTO CLIENTES (NOMBRE_FISCAL, SECTOR, FACTURACION, CP, TELEFONO, EMAIL, ACTIVO, CIF, ID_USUARIO, PROVINCIA)
                                        VALUES (@NOMBRE_FISCAL, @SECTOR, @FACTURACION, @CP, @TELEFONO, @EMAIL, @ACTIVO, @CIF, @ID_USUARIO, @PROVINCIA)", connection)
                cmd.Parameters.AddWithValue("@NOMBRE_FISCAL", DbNullOrStringValue(DGV_CRM.Rows(i).Cells(0).Value.ToString()))
                cmd.Parameters.AddWithValue("@FACTURACION", DbNullOrStringValue(DGV_CRM.Rows(i).Cells(1).Value.ToString()))
                cmd.Parameters.AddWithValue("@SECTOR", DbNullOrStringValue(DGV_CRM.Rows(i).Cells(2).Value.ToString()))
                cmd.Parameters.AddWithValue("@CP", DbNullOrStringValue(DGV_CRM.Rows(i).Cells(3).Value.ToString()))
                cmd.Parameters.AddWithValue("@TELEFONO", DbNullOrStringValue(DGV_CRM.Rows(i).Cells(4).Value.ToString()))
                cmd.Parameters.AddWithValue("@EMAIL", DbNullOrStringValue(DGV_CRM.Rows(i).Cells(5).Value.ToString()))
                cmd.Parameters.AddWithValue("@ACTIVO", DbNullOrStringValue("NO"))
                cmd.Parameters.AddWithValue("@CIF", DbNullOrStringValue(DGV_CRM.Rows(i).Cells(6).Value.ToString()))
                cmd.Parameters.AddWithValue("@ID_USUARIO", DbNullOrStringValue(27))
                cmd.Parameters.AddWithValue("@PROVINCIA", DbNullOrStringValue("Pendiente de definir"))
                cmd.ExecuteNonQuery()
            Next
            connection.Close()
            MsgBox("Todo crema")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tbNombre_TextChanged(sender As Object, e As EventArgs) Handles tbNombre.TextChanged
        updateGrid()
    End Sub

    Private Sub cbEstado_TextChanged(sender As Object, e As EventArgs) Handles cbEstado.TextChanged
        updateGrid()
    End Sub

    Private Sub cbOperador_TextChanged(sender As Object, e As EventArgs) Handles cbOperador.SelectedIndexChanged
        updateGrid()
    End Sub

    Private Sub numLimit_TextChanged(sender As Object, e As EventArgs) Handles numLimit.ValueChanged
        updateGrid()
    End Sub

    Public Sub updateGrid()
        Try
            Dim specificQuery As New MySqlCommand("SELECT NOMBRE_FISCAL, SECTOR, CP, TELEFONO, EMAIL, E.NOMBRE AS ESTADO,
                                                  (SELECT MAX(FECHA) FROM ACTIVIDADES WHERE ID_CLIENTE = C.ID) AS ULTIMA_ACTIVIDAD
                                                  FROM CLIENTES C LEFT JOIN ESTADOS_CLIENTES E ON C.ID_ESTADO = E.ID
                                                  WHERE ACTIVO = 'NO' AND NOMBRE_FISCAL LIKE '%" & tbNombre.Text & "%' AND
                                                  ID_USUARIO = @ID_USUARIO AND ID_ESTADO = @ID_ESTADO LIMIT " & numLimit.Text & "", connection)

            specificQuery.Parameters.AddWithValue("@ID_USUARIO", DbNullOrStringValue(cbOperador.SelectedValue))
            specificQuery.Parameters.AddWithValue("@ID_ESTADO", DbNullOrStringValue(cbEstado.SelectedValue))

            Dim adapter As New MySqlDataAdapter(specificQuery)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGV_CRM.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim ALLQuery As New MySqlCommand("SELECT NOMBRE_FISCAL, SECTOR, CP, TELEFONO, EMAIL, E.NOMBRE AS ESTADO, 
                                             (SELECT MAX(FECHA) FROM ACTIVIDADES WHERE ID_CLIENTE = C.ID) AS ULTIMA_ACTIVIDAD
                                             FROM CLIENTES C LEFT JOIN ESTADOS_CLIENTES E ON C.ID_ESTADO = E.ID
                                             WHERE ACTIVO = 'NO' AND NOMBRE_FISCAL LIKE '%" & tbNombre.Text & "%' LIMIT " & numLimit.Text & "", connection)

            Dim adapter As New MySqlDataAdapter(ALLQuery)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGV_CRM.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class