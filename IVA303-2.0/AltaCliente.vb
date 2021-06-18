Imports MySql.Data.MySqlClient

Public Class AltaCliente

    Dim connection As New MySqlConnection("Server=192.168.0.178;Database=iva303;Uid=jairo;Pwd=test;Convert Zero Datetime=True")
    Dim rs As New Resizer

    Private Sub AltaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Llena el ComboBox Tipo de Vía
        Dim viacommand As New MySqlCommand("select * from TIPOS_VIAS", connection)
        Dim viaadapter As New MySqlDataAdapter(viacommand)
        Dim viatable As New DataTable()
        viaadapter.Fill(viatable)
        CB_TIPO_VIA.DataSource = viatable
        CB_TIPO_VIA.DisplayMember = "NOMBRE"
        CB_TIPO_VIA.ValueMember = "ID"

        'Llena el ComboBox Operador
        Dim opcommand As New MySqlCommand("select * from USUARIOS", connection)
        Dim opadapter As New MySqlDataAdapter(opcommand)
        Dim optable As New DataTable()
        opadapter.Fill(optable)
        cbOperador.DataSource = optable
        cbOperador.DisplayMember = "NOMBRE"
        cbOperador.ValueMember = "ID"

        'Llena el ComboBox Estado
        Dim escommand As New MySqlCommand("select * from ESTADOS_CLIENTES", connection)
        Dim esadapter As New MySqlDataAdapter(escommand)
        Dim estable As New DataTable()
        esadapter.Fill(estable)
        cbEstado.DataSource = estable
        cbEstado.DisplayMember = "NOMBRE"
        cbEstado.ValueMember = "ID"

        If Application.OpenForms().OfType(Of CRM).Any Then

            Dim i = CRM.DGV_CRM.CurrentRow.Index
            Dim j = 0
            Dim nombreFiscal = CRM.DGV_CRM.Item(j, i).Value

            Dim findData As New MySqlCommand("SELECT ID, CIF, NOMBRE_COMERCIAL, ID_TIPO_VIA, NOMBRE_VIA, NUMERO_VIA, ID_USUARIO, ID_ESTADO, COMENTARIOS,
                                            PISO, LETRA_PISO, LOCALIDAD, PROVINCIA, PAIS, CP, TELEFONO, EMAIL, WEB, ACTIVO, SECTOR, FACTURACION
                                            FROM CLIENTES WHERE NOMBRE_FISCAL = @NOMBRE_FISCAL", connection)

            findData.Parameters.AddWithValue("@NOMBRE_FISCAL", DbNullOrStringValue(nombreFiscal))

            Dim findAdapter As New MySqlDataAdapter(findData)

            Dim findTable As New DataTable()

            findAdapter.Fill(findTable)

            tbID.Text = findTable.Rows(0)("ID").ToString()
            TB_CIF.Text = findTable.Rows(0)("CIF").ToString()
            TB_NOMBRE_FISCAL.Text = nombreFiscal
            TB_NOMBRE_COMERCIAL.Text = findTable.Rows(0)("NOMBRE_COMERCIAL").ToString()
            CB_TIPO_VIA.SelectedValue = findTable.Rows(0)("ID_TIPO_VIA").ToString()
            cbOperador.SelectedValue = findTable.Rows(0)("ID_USUARIO").ToString()
            TB_NOMBRE_VIA.Text = findTable.Rows(0)("NOMBRE_VIA").ToString()
            TB_NUMERO_VIA.Text = findTable.Rows(0)("NUMERO_VIA").ToString()
            TB_PISO.Text = findTable.Rows(0)("PISO").ToString()
            TB_LETRA.Text = findTable.Rows(0)("LETRA_PISO").ToString()
            TB_LOCALIDAD.Text = findTable.Rows(0)("LOCALIDAD").ToString()
            TB_PROVINCIA.Text = findTable.Rows(0)("PROVINCIA").ToString()
            TB_PAIS.Text = findTable.Rows(0)("PAIS").ToString()
            TB_CP.Text = findTable.Rows(0)("CP").ToString()
            TB_TLF.Text = findTable.Rows(0)("TELEFONO").ToString()
            TB_CORREO.Text = findTable.Rows(0)("EMAIL").ToString()
            TB_WEB.Text = findTable.Rows(0)("WEB").ToString()
            tbSector.Text = findTable.Rows(0)("SECTOR").ToString()
            numFact.Value = findTable.Rows(0)("FACTURACION").ToString()
            cbEstado.SelectedValue = findTable.Rows(0)("ID_ESTADO").ToString()
            TB_Comentarios.Text = findTable.Rows(0)("COMENTARIOS").ToString()
            CheckBox1.Checked = False

        End If

        populate_dgv_actividades()
        rs.FindAllControls(Me)

    End Sub

    Private Sub AltaCliente_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Public Function DbNullOrStringValue(ByVal value As String) As Object
        If String.IsNullOrEmpty(value) Then
            Return DBNull.Value
        Else
            Return value
        End If
    End Function

    Private Sub BTN_ALTA_CLIENTE_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim RowsReturned As Integer
        Dim CheckID As New MySqlCommand("SELECT ID FROM CLIENTES WHERE ID = @ID", connection)
        CheckID.Parameters.AddWithValue("@ID", DbNullOrStringValue(tbID.Text))
        CheckID.CommandType = CommandType.Text
        connection.Open()
        RowsReturned = CheckID.ExecuteScalar()
        connection.Close()

        If RowsReturned = 0 Then
            Dim insertQuery As New MySqlCommand("INSERT INTO CLIENTES (CIF, NOMBRE_FISCAL, NOMBRE_COMERCIAL, ID_TIPO_VIA, NOMBRE_VIA, NUMERO_VIA, PISO, LETRA_PISO, LOCALIDAD, PROVINCIA, PAIS, CP, TELEFONO, EMAIL, WEB, ACTIVO, SECTOR, FACTURACION, ID_USUARIO, ID_ESTADO, COMENTARIOS)
                                        VALUES (@CIF, @NOMBRE_FISCAL, @NOMBRE_COMERCIAL, @ID_TIPO_VIA, @NOMBRE_VIA, @NUMERO_VIA, @PISO, @LETRA_PISO, @LOCALIDAD, @PROVINCIA, @PAIS, @CP, @TELEFONO, @EMAIL, @WEB, @ACTIVO, @SECTOR, @FACTURACION, @ID_USUARIO, @ID_ESTADO, @COMENTARIOS)", connection)

            insertQuery.Parameters.AddWithValue("@CIF", DbNullOrStringValue(TB_CIF.Text))
            insertQuery.Parameters.AddWithValue("@NOMBRE_FISCAL", DbNullOrStringValue(TB_NOMBRE_FISCAL.Text))
            insertQuery.Parameters.AddWithValue("@NOMBRE_COMERCIAL", DbNullOrStringValue(TB_NOMBRE_COMERCIAL.Text))
            insertQuery.Parameters.AddWithValue("@ID_TIPO_VIA", DbNullOrStringValue(CB_TIPO_VIA.SelectedValue))
            insertQuery.Parameters.AddWithValue("@NOMBRE_VIA", DbNullOrStringValue(TB_NOMBRE_VIA.Text))
            insertQuery.Parameters.AddWithValue("@NUMERO_VIA", DbNullOrStringValue(TB_NUMERO_VIA.Text))
            insertQuery.Parameters.AddWithValue("@PISO", DbNullOrStringValue(TB_PISO.Text))
            insertQuery.Parameters.AddWithValue("@LETRA_PISO", DbNullOrStringValue(TB_LETRA.Text))
            insertQuery.Parameters.AddWithValue("@LOCALIDAD", DbNullOrStringValue(TB_LOCALIDAD.Text))
            insertQuery.Parameters.AddWithValue("@PROVINCIA", DbNullOrStringValue(TB_PROVINCIA.Text))
            insertQuery.Parameters.AddWithValue("@PAIS", DbNullOrStringValue(TB_PAIS.Text))
            insertQuery.Parameters.AddWithValue("@CP", DbNullOrStringValue(TB_CP.Text))
            insertQuery.Parameters.AddWithValue("@TELEFONO", DbNullOrStringValue(TB_TLF.Text))
            insertQuery.Parameters.AddWithValue("@EMAIL", DbNullOrStringValue(TB_CORREO.Text))
            insertQuery.Parameters.AddWithValue("@WEB", DbNullOrStringValue(TB_WEB.Text))
            insertQuery.Parameters.AddWithValue("SECTOR", DbNullOrStringValue(tbSector.Text))
            insertQuery.Parameters.AddWithValue("FACTURACION", DbNullOrStringValue(numFact.Value.ToString))
            insertQuery.Parameters.AddWithValue("ID_USUARIO", DbNullOrStringValue(cbOperador.SelectedValue))
            insertQuery.Parameters.AddWithValue("ID_ESTADO", DbNullOrStringValue(cbEstado.SelectedValue))
            insertQuery.Parameters.AddWithValue("COMENTARIOS", DbNullOrStringValue(TB_Comentarios.Text))

            If CheckBox1.Checked Then
                insertQuery.Parameters.AddWithValue("@ACTIVO", DbNullOrStringValue("SI"))
            Else
                insertQuery.Parameters.AddWithValue("@ACTIVO", DbNullOrStringValue("NO"))
            End If

            connection.Open()

            insertQuery.ExecuteNonQuery()

            connection.Close()
        Else
            Dim updateQuery As New MySqlCommand("UPDATE CLIENTES SET CIF = @CIF, NOMBRE_FISCAL = @NOMBRE_FISCAL, NOMBRE_COMERCIAL = @NOMBRE_COMERCIAL, 
                                                ID_TIPO_VIA = @ID_TIPO_VIA, NOMBRE_VIA = @NOMBRE_VIA, NUMERO_VIA = @NUMERO_VIA, PISO = @PISO, COMENTARIOS = @COMENTARIOS,
                                                LETRA_PISO = @LETRA_PISO, LOCALIDAD = @LOCALIDAD, PROVINCIA = @PROVINCIA, PAIS = @PAIS, CP = @CP, 
                                                TELEFONO = @TELEFONO, EMAIL = @EMAIL, WEB = @WEB, ACTIVO = @ACTIVO, SECTOR = @SECTOR, FACTURACION = @FACTURACION,
                                                ID_USUARIO = @ID_USUARIO, ID_ESTADO = @ID_ESTADO WHERE ID = @ID", connection)

            updateQuery.Parameters.AddWithValue("@ID", DbNullOrStringValue(tbID.Text))
            updateQuery.Parameters.AddWithValue("@CIF", DbNullOrStringValue(TB_CIF.Text))
            updateQuery.Parameters.AddWithValue("@NOMBRE_FISCAL", DbNullOrStringValue(TB_NOMBRE_FISCAL.Text))
            updateQuery.Parameters.AddWithValue("@NOMBRE_COMERCIAL", DbNullOrStringValue(TB_NOMBRE_COMERCIAL.Text))
            updateQuery.Parameters.AddWithValue("@ID_TIPO_VIA", DbNullOrStringValue(CB_TIPO_VIA.SelectedValue))
            updateQuery.Parameters.AddWithValue("@NOMBRE_VIA", DbNullOrStringValue(TB_NOMBRE_VIA.Text))
            updateQuery.Parameters.AddWithValue("@NUMERO_VIA", DbNullOrStringValue(TB_NUMERO_VIA.Text))
            updateQuery.Parameters.AddWithValue("@PISO", DbNullOrStringValue(TB_PISO.Text))
            updateQuery.Parameters.AddWithValue("@LETRA_PISO", DbNullOrStringValue(TB_LETRA.Text))
            updateQuery.Parameters.AddWithValue("@LOCALIDAD", DbNullOrStringValue(TB_LOCALIDAD.Text))
            updateQuery.Parameters.AddWithValue("@PROVINCIA", DbNullOrStringValue(TB_PROVINCIA.Text))
            updateQuery.Parameters.AddWithValue("@PAIS", DbNullOrStringValue(TB_PAIS.Text))
            updateQuery.Parameters.AddWithValue("@CP", DbNullOrStringValue(TB_CP.Text))
            updateQuery.Parameters.AddWithValue("@TELEFONO", DbNullOrStringValue(TB_TLF.Text))
            updateQuery.Parameters.AddWithValue("@EMAIL", DbNullOrStringValue(TB_CORREO.Text))
            updateQuery.Parameters.AddWithValue("@WEB", DbNullOrStringValue(TB_WEB.Text))
            updateQuery.Parameters.AddWithValue("SECTOR", DbNullOrStringValue(tbSector.Text))
            updateQuery.Parameters.AddWithValue("FACTURACION", DbNullOrStringValue(numFact.Value.ToString))
            updateQuery.Parameters.AddWithValue("ID_USUARIO", DbNullOrStringValue(cbOperador.SelectedValue))
            updateQuery.Parameters.AddWithValue("ID_ESTADO", DbNullOrStringValue(cbEstado.SelectedValue))
            updateQuery.Parameters.AddWithValue("COMENTARIOS", DbNullOrStringValue(TB_Comentarios.Text))

            If CheckBox1.Checked Then
                updateQuery.Parameters.AddWithValue("@ACTIVO", DbNullOrStringValue("SI"))
            Else
                updateQuery.Parameters.AddWithValue("@ACTIVO", DbNullOrStringValue("NO"))
            End If

            connection.Open()
            updateQuery.ExecuteNonQuery()
            connection.Close()
            MsgBox("Datos actualizados")
        End If
    End Sub

    Public Sub populate_dgv_actividades()

        Dim searchQuery As New MySqlCommand("SELECT A.TIPO, A.FECHA, A.INFO
                                            FROM ACTIVIDADES A
                                            LEFT JOIN CLIENTES E ON A.ID_CLIENTE = E.ID
                                            WHERE CIF = @CIF
                                            ORDER BY A.FECHA DESC", connection)

        searchQuery.Parameters.AddWithValue("@CIF", DbNullOrStringValue(TB_CIF.Text))

        Dim adapter As New MySqlDataAdapter(searchQuery)
        Dim table As New DataTable()
        adapter.Fill(table)

        dgvActividades.AllowUserToAddRows = False

        dgvActividades.RowTemplate.Height = 100
        Dim imgc As New DataGridViewImageColumn
        dgvActividades.DataSource = table

        For i As Integer = 0 To dgvActividades.ColumnCount - 1
            dgvActividades.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next

        dgvActividades.AutoResizeRows()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NuevaActividad.Show()
    End Sub

    Private Sub dgvActividades_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActividades.CellDoubleClick

        Dim deleteQuery As New MySqlCommand("delete from ACTIVIDADES where ID = @ID", connection)
        Dim i = dgvActividades.CurrentRow.Index
        Dim j = 0
        deleteQuery.Parameters.AddWithValue("@ID", DbNullOrStringValue(dgvActividades.Item(j, i).Value))
        connection.Open()
        deleteQuery.ExecuteNonQuery()
        populate_dgv_actividades()
        connection.Close()

    End Sub

    Private Sub DgvActividades_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActividades.CellDoubleClick
        ModificarActividad.Show()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim direccionWeb As String = "https://empresite.eleconomista.es/"
        Process.Start("firefox", direccionWeb)
    End Sub
End Class