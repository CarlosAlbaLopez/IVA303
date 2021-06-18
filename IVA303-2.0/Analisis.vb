Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Globalization
Imports MySql.Data.MySqlClient
Imports WinSCP

Public Class Analisis

    Dim connection As New MySqlConnection("Server=192.168.0.178;Database=iva303;Uid=jairo;Pwd=test;Convert Zero Datetime=True")
    Dim rs As New Resizer

    Private Sub F1CIF(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            e.Handled = True
            TBCIF.Focus()
            TBCIF.SelectAll()
        End If
    End Sub
    Private Sub F2REFERENCIA(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            e.Handled = True
            TBREFERENCIA.Focus()
            TBREFERENCIA.SelectAll()
        End If
    End Sub
    Private Sub F3FECHA(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F3 Then
            e.Handled = True
            TBFECHA.Focus()
            TBFECHA.SelectAll()
        End If
    End Sub
    Private Sub TBCIF_JUMP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBCIF.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            TBREFERENCIA.Focus()
            BuscaCIF()
        End If
    End Sub
    Private Sub TBREFERENCIA_JUMP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBREFERENCIA.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            TBFECHA.Focus()
        End If
    End Sub
    Private Sub TBFECHA_JUMP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBFECHA.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            TBTIPOIVA.Focus()
        End If
    End Sub
    Private Sub TBTIPOIVA_JUMP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBTIPOIVA.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            TBIMPORTE.Focus()
        End If
    End Sub
    Private Sub TBIMPORTE_JUMP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBIMPORTE.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            BTN_CALCULAR.Focus()
        End If
    End Sub

    Private Sub Analisis_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim clientescommand As New MySqlCommand("select * from CLIENTES WHERE ACTIVO = 'SI'", connection)

        Dim clientesadapter As New MySqlDataAdapter(clientescommand)

        Dim clientestable As New DataTable()

        clientesadapter.Fill(clientestable)

        CB_Cliente.DataSource = clientestable

        CB_Cliente.DisplayMember = "NOMBRE_FISCAL"
        CB_Cliente.ValueMember = "ID"

        Dim tiposdoccommand As New MySqlCommand("select * from TIPOS_DOCUMENTOS", connection)

        Dim tiposdocadapter As New MySqlDataAdapter(tiposdoccommand)

        Dim tiposdoctable As New DataTable()

        tiposdocadapter.Fill(tiposdoctable)

        CB_Tipo_Doc.DataSource = tiposdoctable

        CB_Tipo_Doc.DisplayMember = "NOMBRE"
        CB_Tipo_Doc.ValueMember = "ID"

        Dim estadoscommand As New MySqlCommand("select * from ESTADOS_DOCUMENTOS", connection)

        Dim estadosadapter As New MySqlDataAdapter(estadoscommand)

        Dim estadostable As New DataTable()

        clientesadapter.Fill(estadostable)

        CB_Cliente.DataSource = estadostable

        CB_Cliente.DisplayMember = "NOMBRE"
        CB_Cliente.ValueMember = "ID"

        CB_Cliente.SelectedIndex = 0
        CB_Tipo_Doc.SelectedIndex = 0

        populateDatagridview()

        populateDGV_LINEAS_IVA()

        Application.CurrentCulture = New CultureInfo("es-ES")

        rs.FindAllControls(Me)

    End Sub

    Private Sub Analisis_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter

        Try
            Dim index As Integer

            index = e.RowIndex

            Dim selectedRow As DataGridViewRow

            selectedRow = DataGridView1.Rows(index)


            If System.IO.File.Exists("S:\img\" & selectedRow.Cells(7).Value.ToString()) Then

                Dim AbRuta As String = "S:\img\" & selectedRow.Cells(7).Value.ToString()
                AxAcroPDF1.LoadFile(AbRuta)

            Else

                MsgBox("No se encuentra la imagen")


            End If


            Try

                Panel1.Enabled = False
                'TBCIF.Focus()

            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try


            Try

                populateDGV_LINEAS_IVA()
                DatosLoad()

            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try



    End Sub

    Public Function DbNullOrStringValue(ByVal value As String) As Object
        If String.IsNullOrEmpty(value) Then
            Return DBNull.Value
        Else
            Return value
        End If
    End Function

    Private Sub DatosLoad()

        Dim i = DataGridView1.CurrentRow.Index
        Dim j = DataGridView1.CurrentCell.ColumnIndex

        If DataGridView1.Item(j + 1, i).Value Is DBNull.Value Then
            TBCIF.Text = ""
        Else
            TBCIF.Text = DataGridView1.Item(j + 1, i).Value

        End If

        If DataGridView1.Item(j + 3, i).Value Is DBNull.Value Then
            TBREFERENCIA.Text = ""
        Else
            TBREFERENCIA.Text = DataGridView1.Item(j + 3, i).Value

        End If

        If DataGridView1.Item(j + 2, i).Value Is DBNull.Value Then
            TBFECHA.Text = ""
        Else
            Dim MyCultureInfo As CultureInfo = New CultureInfo("es-ES")
            Dim MyDateTime As Date = Date.Parse(DataGridView1.Item(j + 2, i).Value, MyCultureInfo)

            TBFECHA.Text = MyDateTime

        End If

        If DataGridView1.Item(j + 4, i).Value Is DBNull.Value Then
            TB_SUMA_BASE.Text = ""
        Else
            TB_SUMA_BASE.Text = DataGridView1.Item(j + 4, i).Value

        End If

        If DataGridView1.Item(j + 5, i).Value Is DBNull.Value Then
            TB_SUMA_IVA.Text = ""
        Else
            TB_SUMA_IVA.Text = DataGridView1.Item(j + 5, i).Value

        End If

        If DataGridView1.Item(j + 6, i).Value Is DBNull.Value Then
            TB_SUMA_TOTAL.Text = ""
        Else
            TB_SUMA_TOTAL.Text = DataGridView1.Item(j + 6, i).Value

        End If

        Dim searchQuery As New MySqlCommand("SELECT ID_TIPO From DOCUMENTOS where ID = @ID", connection)

        searchQuery.Parameters.AddWithValue("@ID", DbNullOrStringValue(DataGridView1.Item(j, i).Value))

        connection.Close()

        connection.Open()

        connection.Close()
        TBCIF.Focus()
    End Sub

    Public Sub ExecuteMyQuery(MyCommand As MySqlCommand, MyMessage As String)

        connection.Open()

        If MyCommand.ExecuteNonQuery = 1 Then

            MessageBox.Show(MyMessage)

        Else

            MessageBox.Show("Query Not Executed")

        End If

        connection.Close()

        populateDatagridview()

    End Sub

    Public Sub populateDatagridview()

        If Application.OpenForms().OfType(Of Certificacion3).Any Then

            Dim i = Certificacion3.DGV_Tickets.CurrentRow.Index
            Dim j = Certificacion3.DGV_Tickets.CurrentCell.ColumnIndex
            Dim id = Certificacion3.DGV_Tickets.Item(j, i).Value

            Try

                Dim searchQuery As String = "SELECT ID,CIF,FECHA,REFERENCIA,SUMA_BASE,SUMA_IVA,SUMA_TOTAL,RUTA From DOCUMENTOS where ID = @ID"

                Dim command As New MySqlCommand(searchQuery, connection)
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()

                command.Parameters.AddWithValue("@ID", DbNullOrStringValue(id))

                adapter.Fill(table)

                DataGridView1.AllowUserToAddRows = False

                DataGridView1.RowTemplate.Height = 100
                Dim imgc As New DataGridViewImageColumn
                DataGridView1.DataSource = table


            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try

        Else

            Try

                Dim searchQuery As String = "SELECT ID,CIF,FECHA,REFERENCIA,SUMA_BASE,SUMA_IVA,SUMA_TOTAL,RUTA From DOCUMENTOS where ID_ESTADO in (1,2) AND ID_CLIENTE = @ID_CLIENTE AND ID_TIPO = @ID_TIPO"

                Dim command As New MySqlCommand(searchQuery, connection)
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()

                command.Parameters.AddWithValue("@ID_CLIENTE", DbNullOrStringValue(CB_Cliente.SelectedValue))
                command.Parameters.AddWithValue("@ID_TIPO", DbNullOrStringValue(CB_Tipo_Doc.SelectedValue))

                adapter.Fill(table)

                DataGridView1.AllowUserToAddRows = False

                DataGridView1.RowTemplate.Height = 100
                Dim imgc As New DataGridViewImageColumn
                DataGridView1.DataSource = table


            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try

        End If

    End Sub

    Public Sub populateDGV_LINEAS_IVA()

        Try

            'Solamente actualiza datos si está seleccionado el campo ID en la DGV
            Dim i = DataGridView1.CurrentRow.Index
            Dim j = DataGridView1.CurrentCell.ColumnIndex


            Dim command As New MySqlCommand("SELECT ID, TIPO, BASE, IVA, TOTAL FROM LINEAS_IVA WHERE ID_DOCUMENTO = @ID", connection)
            command.Parameters.AddWithValue("@ID", DbNullOrStringValue(DataGridView1.Item(j, i).Value))
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            DGV_LINEAS_IVA.AllowUserToAddRows = False

            DGV_LINEAS_IVA.RowTemplate.Height = 100
            Dim imgc As New DataGridViewImageColumn
            DGV_LINEAS_IVA.DataSource = table

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Public Sub GUARDAR_GRID_en_sql()

        Dim dt As DataTable = DirectCast(DGV_LINEAS_IVA.DataSource, DataTable)

    End Sub

    Private Sub BTN_CALCULAR_Click(sender As Object, e As EventArgs) Handles BTN_CALCULAR.Click

        Dim ms As New MemoryStream

        Dim img() As Byte
        img = ms.ToArray()
        Dim insertQuery As New MySqlCommand("INSERT INTO LINEAS_IVA (ID_DOCUMENTO, TIPO, BASE, IVA, TOTAL)
                                        VALUES (@ID, @TIPO, @BASE, @IVA, @TOTAL)", connection)

        'Solamente actualiza datos si está seleccionado el campo ID en la DGV
        Dim i = DataGridView1.CurrentRow.Index
        Dim j = DataGridView1.CurrentCell.ColumnIndex
        Dim ID = DataGridView1.Item(j, i).Value

        insertQuery.Parameters.AddWithValue("@ID", DbNullOrStringValue(ID))
        insertQuery.Parameters.AddWithValue("@TIPO", DbNullOrStringValue(TBTIPOIVA.Text))

        Dim ImporteConPunto = TBIMPORTE.Text.Replace(".", ",")

        If IMPORTEBASE.Checked Then
            insertQuery.Parameters.Add("@BASE", MySqlDbType.Decimal).Value = ImporteConPunto
            insertQuery.Parameters.Add("@IVA", MySqlDbType.Decimal).Value = ImporteConPunto * TBTIPOIVA.Text / 100
            insertQuery.Parameters.Add("@TOTAL", MySqlDbType.Decimal).Value = ImporteConPunto + (ImporteConPunto * TBTIPOIVA.Text / 100)
        Else
            insertQuery.Parameters.Add("@TOTAL", MySqlDbType.Decimal).Value = ImporteConPunto
            insertQuery.Parameters.Add("@IVA", MySqlDbType.Decimal).Value = ImporteConPunto - (ImporteConPunto / (1 + (TBTIPOIVA.Text / 100)))
            insertQuery.Parameters.Add("@BASE", MySqlDbType.Decimal).Value = ImporteConPunto / (1 + (TBTIPOIVA.Text / 100))
        End If

        connection.Open()

        insertQuery.ExecuteNonQuery()

        connection.Close()

        'Volver a poner en blanco los campos
        TBTIPOIVA.Text = ""
        TBIMPORTE.Text = ""

        populateDGV_LINEAS_IVA()

        '' SUMA DE LAS BASES
        Try

            Using cnn As New MySqlConnection("Server=192.168.0.178;Database=iva303;Uid=jairo;Pwd=test")

                ' Creamos un comando
                Dim cmd As MySqlCommand = cnn.CreateCommand()

                ' Indicamos la consulta que vamos a ejecutar
                cmd.CommandText = "SELECT SUM(BASE) FROM LINEAS_IVA WHERE ID_DOCUMENTO = @ID_IVA"

                ' Abrimos la conexión
                cnn.Open()

                cmd.Parameters.AddWithValue("@ID_IVA", DbNullOrStringValue(DataGridView1.Item(j, i).Value))

                ' Ejecutamos la consulta
                Dim suma As Object = cmd.ExecuteScalar()

                ' Mostramos el resultado formateado en un control TextBox
                TB_SUMA_BASE.Text = String.Format("{0:0.00}", suma)

            End Using

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        '' SUMA DE LOS IVAS
        Try

            Using cnn As New MySqlConnection("Server=192.168.0.178;Database=iva303;Uid=jairo;Pwd=test")

                ' Creamos un comando
                Dim cmd As MySqlCommand = cnn.CreateCommand()

                ' Indicamos la consulta que vamos a ejecutar
                cmd.CommandText = "SELECT SUM(IVA) FROM LINEAS_IVA WHERE ID_DOCUMENTO = @ID_IVA"

                ' Abrimos la conexión
                cnn.Open()

                cmd.Parameters.AddWithValue("@ID_IVA", DbNullOrStringValue(DataGridView1.Item(j, i).Value))

                ' Ejecutamos la consulta
                Dim suma As Object = cmd.ExecuteScalar()

                ' Mostramos el resultado formateado en un control TextBox
                TB_SUMA_IVA.Text = String.Format("{0:0.00}", suma)

            End Using

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        '' SUMA DE LOS TOTALES
        Try

            Using cnn As New MySqlConnection("Server=192.168.0.178;Database=iva303;Uid=jairo;Pwd=test")

                ' Creamos un comando
                Dim cmd As MySqlCommand = cnn.CreateCommand()

                ' Indicamos la consulta que vamos a ejecutar
                cmd.CommandText = "SELECT SUM(TOTAL) FROM LINEAS_IVA WHERE ID_DOCUMENTO = @ID_IVA"

                ' Abrimos la conexión
                cnn.Open()

                cmd.Parameters.AddWithValue("@ID_IVA", DbNullOrStringValue(DataGridView1.Item(j, i).Value))

                ' Ejecutamos la consulta
                Dim suma As Object = cmd.ExecuteScalar()

                ' Mostramos el resultado formateado en un control TextBox
                TB_SUMA_TOTAL.Text = String.Format("{0:0.00}", suma)

            End Using

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        BTN_UPDATE.Focus()

    End Sub

    Private Sub BTN_UPDATE_Click_1(sender As Object, e As EventArgs) Handles BTN_UPDATE.Click

        Clipboard.SetText(TBCIF.Text.ToUpper)

        Dim ms As New MemoryStream

        Dim img() As Byte
        img = ms.ToArray()
        Dim updateQuery As New MySqlCommand("UPDATE DOCUMENTOS
                                        SET CIF = @CIF, FECHA = @FECHA, REFERENCIA = @REFERENCIA, SUMA_BASE = @SUMA_BASE, SUMA_IVA = @SUMA_IVA, SUMA_TOTAL = @SUMA_TOTAL
                                        WHERE ID = @ID", connection)

        Dim sumabase As New MySqlCommand("SELECT SUM(BASE) FROM LINEAS_IVA WHERE ID_DOCUMENTO = @ID", connection)
        Dim sumaiva As New MySqlCommand("SELECT SUM(IVA) FROM LINEAS_IVA WHERE ID_DOCUMENTO = @ID", connection)
        Dim sumatotal As New MySqlCommand("SELECT SUM(TOTAL) FROM LINEAS_IVA WHERE ID_DOCUMENTO = @ID", connection)

        'Solamente actualiza datos si está seleccionado el campo ID en la DGV
        Dim i = DataGridView1.CurrentRow.Index
        Dim j = DataGridView1.CurrentCell.ColumnIndex
        Dim ID = DataGridView1.Item(j, i).Value

        Dim base As String = "SELECT SUM(BASE) FROM LINEAS_IVA WHERE ID_DOCUMENTO = @ID"

        Dim MyCultureInfo As CultureInfo = New CultureInfo("en-EN")
        Dim MyDateTime = Convert.ToDateTime(TBFECHA.Text).ToString("yyyy-MM-dd")


        updateQuery.Parameters.AddWithValue("@ID", DbNullOrStringValue(ID))
        updateQuery.Parameters.AddWithValue("@CIF", DbNullOrStringValue(TBCIF.Text))
        updateQuery.Parameters.Add("@FECHA", MySqlDbType.Date).Value = (MyDateTime)
        updateQuery.Parameters.AddWithValue("@REFERENCIA", DbNullOrStringValue(TBREFERENCIA.Text))
        updateQuery.Parameters.AddWithValue("@SUMA_BASE", DbNullOrStringValue(Replace(TB_SUMA_BASE.Text, ",", ".")))
        updateQuery.Parameters.AddWithValue("@SUMA_IVA", DbNullOrStringValue(Replace(TB_SUMA_IVA.Text, ",", ".")))
        updateQuery.Parameters.AddWithValue("@SUMA_TOTAL", DbNullOrStringValue(Replace(TB_SUMA_TOTAL.Text, ",", ".")))

        connection.Open()
        updateQuery.ExecuteNonQuery()
        connection.Close()

        'UPDATE ESTADO SOLO SI EL DOCUMENTOS ESTÁ EN NUEVO
        Dim updateEstadoQuery As New MySqlCommand("UPDATE DOCUMENTOS SET ID_ESTADO = 2 WHERE ID= @ID AND ID_ESTADO = 1", connection)
        updateEstadoQuery.Parameters.AddWithValue("@ID", DbNullOrStringValue(ID))
        connection.Open()
        updateEstadoQuery.ExecuteNonQuery()

        ' Get the index of the last row. 
        ' a) Subtract 1 for the extra row at the end of the DataGridView (BORRADO)
        ' b) Subtract another 1 for the zero based indexing of VB
        Dim maxRowIndex As Integer =
        (Me.DataGridView1.Rows.Count - 1)

        ' Compute the index of the current row
        Dim curDataGridViewRow As DataGridViewRow =
        DataGridView1.CurrentRow
        Dim curRowIndex As Integer = curDataGridViewRow.Index

        'populateDatagridview()

        ' See if the last row has been passed
        If (curRowIndex >= maxRowIndex) Then
            'populateDatagridview()
        Else
            ' There is another row after the current row, retreive that 
            ' next row and store it for later use
            Dim nextRow As DataGridViewRow =
            DataGridView1.Rows(curRowIndex + 1)

            ' Move the Glyph arrow to the next row
            DataGridView1.CurrentCell = nextRow.Cells(0)

            ' Select the next row
            nextRow.Selected = True
        End If

        DatosLoad()

        connection.Close()

        populateDGV_LINEAS_IVA()

    End Sub

    Private Sub DGV_LINEAS_IVA_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_LINEAS_IVA.CellDoubleClick

        Dim deleteQuery As New MySqlCommand("delete from LINEAS_IVA where id = @id", connection)

        Dim i = DGV_LINEAS_IVA.CurrentRow.Index
        Dim j = DGV_LINEAS_IVA.CurrentCell.ColumnIndex

        deleteQuery.Parameters.AddWithValue("@ID", DbNullOrStringValue(DGV_LINEAS_IVA.Item(j, i).Value))

        connection.Open()

        deleteQuery.ExecuteNonQuery()

        populateDGV_LINEAS_IVA()

        connection.Close()
    End Sub

    Private Sub BuscaCIF()

        Dim BuscaCIFQuery As New MySqlCommand("SELECT * FROM EMPRESAS WHERE CIF = @CIF", connection)
        Dim BuscaNombreFiscalQuery As New MySqlCommand("SELECT NOMBRE_FISCAL FROM EMPRESAS WHERE CIF = @CIF", connection)
        Dim BuscaNombreComercialQuery As New MySqlCommand("SELECT NOMBRE_COMERCIAL FROM EMPRESAS WHERE CIF = @CIF", connection)
        Dim RowsReturned As Integer
        Dim nombrefiscal As String
        Dim nombrecomercial As String

        connection.Open()


        'EJECUCION CONSULTA CIF

        BuscaCIFQuery.Parameters.AddWithValue("@CIF", DbNullOrStringValue(TBCIF.Text))
        BuscaCIFQuery.ExecuteNonQuery()
        BuscaCIFQuery.CommandType = CommandType.Text


        'EJECUCION CONSULTA NOMBRE FISCAL
        BuscaNombreFiscalQuery.Parameters.AddWithValue("@CIF", DbNullOrStringValue(TBCIF.Text))
        BuscaNombreFiscalQuery.ExecuteNonQuery()
        BuscaNombreFiscalQuery.CommandType = CommandType.Text

        RowsReturned = BuscaCIFQuery.ExecuteScalar()


        'EJECUCION CONSULTA NOMBRE COMERCIAL
        BuscaNombreComercialQuery.Parameters.AddWithValue("@CIF", DbNullOrStringValue(TBCIF.Text))
        BuscaNombreComercialQuery.ExecuteNonQuery()
        BuscaNombreComercialQuery.CommandType = CommandType.Text

        RowsReturned = BuscaCIFQuery.ExecuteScalar()

        'CONVIERTE A TIPO STRING POR SI RESULTADO ES NULL (TIPO NULL)

        nombrefiscal = Convert.ToString(BuscaNombreFiscalQuery.ExecuteScalar())
        nombrecomercial = Convert.ToString(BuscaNombreComercialQuery.ExecuteScalar())


        'ABRE ALTA EMPRESA SI NO EXISTE Y RELLENA CAMPOS SI EXISTE

        If RowsReturned = 0 Then
            AltaEmpresa.Show()
        Else
            TBRECONOCIMIENTOCIF.Text = nombrefiscal
            TBRECONOCIMIENTOCIF2.Text = nombrecomercial
        End If


        connection.Close()

    End Sub

    Private Sub BT_Buscar_Click(sender As Object, e As EventArgs) Handles BT_Buscar.Click

        populateDatagridview()

        DataGridView1.Columns(2).DefaultCellStyle.Format = "dd/MM/yyyy"

    End Sub


    Private Sub Panel2_MouseHover(sender As Object, e As System.EventArgs) Handles Panel2.MouseHover

        Panel1.Enabled = True

    End Sub

    Public Sub x()

        populateDatagridview()

    End Sub

    Private Sub BTN_BuscarLista_Click(sender As Object, e As EventArgs) Handles BTN_BuscarLista.Click

        InputIDs.Show()

    End Sub

End Class