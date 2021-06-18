Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class AltaEmpresa

    Dim connection As New MySqlConnection("Server=192.168.0.178;Database=iva303;Uid=jairo;Pwd=test;Convert Zero Datetime=True")
    Dim rs As New Resizer

    Private Sub TBCIF_JUMP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TB_CIF.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            TB_NOMBRE_FISCAL.Focus()
        End If
    End Sub

    Private Sub TBNOMBREFISCAL_JUMP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TB_NOMBRE_FISCAL.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            TB_NOMBRE_COMERCIAL.Focus()
        End If
    End Sub

    Private Sub TBNOMBRECOMERCIAL_JUMP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TB_NOMBRE_COMERCIAL.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            LB_DIRECCION.Focus()
        End If
    End Sub

    Private Sub LB_DIRECCION_JUMP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LB_DIRECCION.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            TB_NOMBRE_VIA.Focus()
        End If
    End Sub

    Private Sub TB_NOMBRE_VIA_JUMP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TB_NOMBRE_VIA.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            TB_NUMERO_VIA.Focus()
        End If
    End Sub

    Private Sub TB_NUMERO_VIA_JUMP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TB_NUMERO_VIA.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            TB_PISO.Focus()
        End If
    End Sub

    Private Sub TB_PISO_JUMP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TB_PISO.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            TB_LETRA.Focus()
        End If
    End Sub

    Private Sub TB_LETRA_JUMP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TB_LETRA.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            TB_CP.Focus()
        End If
    End Sub

    Private Sub TB_CP_JUMP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TB_CP.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            TB_LOCALIDAD.Focus()
        End If
    End Sub

    Private Sub TB_LOCALIDAD_JUMP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TB_LOCALIDAD.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            TB_PROVINCIA.Focus()
        End If
    End Sub

    Private Sub TB_PROVINCIA_JUMP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TB_PROVINCIA.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            TB_PAIS.Focus()
        End If
    End Sub

    Private Sub TB_PAIS_JUMP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TB_PAIS.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            TB_TLF.Focus()
        End If
    End Sub

    Private Sub TB_TLF_JUMP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TB_TLF.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            TB_CORREO.Focus()
        End If
    End Sub

    Private Sub TB_CORREO_JUMP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TB_CORREO.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            TB_WEB.Focus()
        End If
    End Sub

    Private Sub TB_WEB_JUMP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TB_WEB.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            btnEvento.Focus()
        End If
    End Sub

    Private Sub TB_Comentarios_JUMP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnEvento.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            BTN_ALTA_EMPRESA.Focus()
        End If
    End Sub
    Private Sub AltaEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Llena el ComboBox Tipo de Empresa
        Dim tipocommand As New MySqlCommand("select * from TIPOS_EMPRESAS", connection)

        Dim tipoadapter As New MySqlDataAdapter(tipocommand)

        Dim tipotable As New DataTable()

        tipoadapter.Fill(tipotable)

        CB_TIPO.DataSource = tipotable

        CB_TIPO.DisplayMember = "NOMBRE"
        CB_TIPO.ValueMember = "ID"

        'Llena el ComboBox Tipo de Vía
        Dim viacommand As New MySqlCommand("select * from TIPOS_VIAS", connection)

        Dim viaadapter As New MySqlDataAdapter(viacommand)

        Dim viatable As New DataTable()

        viaadapter.Fill(viatable)

        CB_TIPO_VIA.DataSource = viatable

        CB_TIPO_VIA.DisplayMember = "NOMBRE"
        CB_TIPO_VIA.ValueMember = "ID"

        'Llena el ComboBox Estado de Empresa
        Dim estadocommand As New MySqlCommand("select * from ESTADOS_EMPRESAS", connection)

        Dim estadoadapter As New MySqlDataAdapter(estadocommand)

        Dim estadotable As New DataTable()

        estadoadapter.Fill(estadotable)

        cbEstado.DataSource = estadotable

        cbEstado.DisplayMember = "NOMBRE"
        cbEstado.ValueMember = "ID"

        If Application.OpenForms().OfType(Of Analisis).Any Then

            'Llena el campo CIF
            TB_CIF.Text = Analisis.TBCIF.Text

        Else
            Try

                Dim i = Empresas.DGV_Empresas.CurrentRow.Index
                Dim j = 1
                Dim cif = Empresas.DGV_Empresas.Item(j, i).Value

                TB_CIF.Text = cif

                Dim findData As New MySqlCommand("SELECT ID_TIPO, NOMBRE_FISCAL, NOMBRE_COMERCIAL, ID_TIPO_VIA, NOMBRE_VIA, NUMERO_VIA, PISO, LETRA_PISO,
                                            LOCALIDAD, PROVINCIA, PAIS, CP, TELEFONO, EMAIL, WEB, COMENTARIOS, ID_ESTADO
                                            FROM EMPRESAS WHERE CIF = @CIF", connection)

                findData.Parameters.AddWithValue("@CIF", DbNullOrStringValue(TB_CIF.Text))

                Dim findAdapter As New MySqlDataAdapter(findData)

                Dim findTable As New DataTable()

                findAdapter.Fill(findTable)

                CB_TIPO.SelectedValue = findTable.Rows(0)("ID_TIPO").ToString()
                TB_NOMBRE_FISCAL.Text = findTable.Rows(0)("NOMBRE_FISCAL").ToString()
                TB_NOMBRE_COMERCIAL.Text = findTable.Rows(0)("NOMBRE_COMERCIAL").ToString()
                CB_TIPO_VIA.SelectedValue = findTable.Rows(0)("ID_TIPO_VIA").ToString()
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
                btnEvento.Text = findTable.Rows(0)("COMENTARIOS").ToString()
                cbEstado.SelectedValue = findTable.Rows(0)("ID_ESTADO").ToString()

            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try

        End If

        populate_dgvActividades()
        populate_dgvIVAestado()
        populate_dgvIVAcliente()
        populate_dgvContactos()

        rs.FindAllControls(Me)

    End Sub

    Private Sub AltaEmpresa_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub populate_dgvIVAestado()

        Dim VATQuery As New MySqlCommand("select COUNT(D.ID) AS TICKETS, E.NOMBRE AS ESTADO, SUM(SUMA_IVA) AS IVA
                                        FROM DOCUMENTOS D
                                        LEFT JOIN ESTADOS_DOCUMENTOS E ON D.ID_ESTADO = E.ID
                                        WHERE CIF = @CIF AND ID_ESTADO <> 5
                                        GROUP BY ID_ESTADO", connection)

        VATQuery.Parameters.AddWithValue("@CIF", DbNullOrStringValue(TB_CIF.Text))

        Dim adapter As New MySqlDataAdapter(VATQuery)
        Dim table As New DataTable()
        adapter.Fill(table)
        dgvVAT.DataSource = table

    End Sub

    Private Sub populate_dgvIVAcliente()

        Dim IVAQuery As New MySqlCommand("select COUNT(D.ID) AS TICKETS, C.NOMBRE_FISCAL AS CLIENTE, SUM(SUMA_IVA) AS IVA
                                        FROM DOCUMENTOS D
                                        LEFT JOIN CLIENTES C ON D.ID_CLIENTE = C.ID
                                        WHERE D.CIF = @CIF AND D.ID_ESTADO <> 5
                                        GROUP BY C.NOMBRE_FISCAL", connection)

        IVAQuery.Parameters.AddWithValue("@CIF", DbNullOrStringValue(TB_CIF.Text))

        Dim adapter As New MySqlDataAdapter(IVAQuery)
        Dim table As New DataTable()
        adapter.Fill(table)
        dgvIVAcliente.DataSource = table

    End Sub

    Public Sub populate_dgvContactos()

        Dim ContactosQuery As New MySqlCommand("select C.ID, C.CONTACTO, C.CARGO, C.TELEFONO, C.EMAIL
                                                FROM CONTACTOS_EMPRESAS C
                                                LEFT JOIN EMPRESAS E ON C.ID_EMPRESA = E.ID
                                                WHERE E.CIF = @CIF", connection)

        ContactosQuery.Parameters.AddWithValue("@CIF", DbNullOrStringValue(TB_CIF.Text))

        Dim adapter As New MySqlDataAdapter(ContactosQuery)
        Dim table As New DataTable()
        adapter.Fill(table)
        dgvContactos.DataSource = table

    End Sub

    Public Function DbNullOrStringValue(ByVal value As String) As Object
        If String.IsNullOrEmpty(value) Then
            Return DBNull.Value
        Else
            Return value
        End If
    End Function

    Private Sub BTN_ALTA_EMPRESA_Click(sender As Object, e As EventArgs) Handles BTN_ALTA_EMPRESA.Click

        Dim RowsReturned As Integer
        Dim CheckCIF As New MySqlCommand("SELECT ID FROM EMPRESAS WHERE CIF = @CIF", connection)
        CheckCIF.Parameters.AddWithValue("@CIF", DbNullOrStringValue(TB_CIF.Text))
        CheckCIF.CommandType = CommandType.Text
        connection.Open()
        RowsReturned = CheckCIF.ExecuteScalar()
        connection.Close()

        If RowsReturned = 0 Then

            Dim insertQuery As New MySqlCommand("INSERT INTO EMPRESAS (ID_TIPO, ID_ESTADO, CIF, NOMBRE_FISCAL, NOMBRE_COMERCIAL, ID_TIPO_VIA, NOMBRE_VIA, NUMERO_VIA, PISO, LETRA_PISO, LOCALIDAD, PROVINCIA, PAIS, CP, TELEFONO, EMAIL, WEB, COMENTARIOS, ULTIMA_FACTURA)
                                        VALUES (@ID_TIPO, @ID_ESTADO, @CIF, @NOMBRE_FISCAL, @NOMBRE_COMERCIAL, @ID_TIPO_VIA, @NOMBRE_VIA, @NUMERO_VIA, @PISO, @LETRA_PISO, @LOCALIDAD, @PROVINCIA, @PAIS, @CP, @TELEFONO, @EMAIL, @WEB, @COMENTARIOS, @ULTIMA_FACTURA)", connection)

            insertQuery.Parameters.Add("@ID_TIPO", MySqlDbType.Int16).Value = CB_TIPO.SelectedValue
            insertQuery.Parameters.Add("@ID_ESTADO", MySqlDbType.Int16).Value = cbEstado.SelectedValue
            insertQuery.Parameters.AddWithValue("@CIF", DbNullOrStringValue(TB_CIF.Text))
            insertQuery.Parameters.AddWithValue("@NOMBRE_FISCAL", DbNullOrStringValue(TB_NOMBRE_FISCAL.Text))
            insertQuery.Parameters.AddWithValue("@NOMBRE_COMERCIAL", DbNullOrStringValue(TB_NOMBRE_COMERCIAL.Text))
            insertQuery.Parameters.Add("@ID_TIPO_VIA", MySqlDbType.Int16).Value = CB_TIPO_VIA.SelectedValue
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
            insertQuery.Parameters.AddWithValue("@COMENTARIOS", DbNullOrStringValue(btnEvento.Text))
            insertQuery.Parameters.AddWithValue("@ULTIMA_FACTURA", DbNullOrStringValue("0"))

            connection.Open()

            insertQuery.ExecuteNonQuery()

            connection.Close()

            Empresas.Empresas_Load(sender, e)

            Me.Close()

        Else

            Dim updateQuery As New MySqlCommand("UPDATE EMPRESAS SET ID_TIPO = @ID_TIPO, ID_ESTADO = @ID_ESTADO, NOMBRE_FISCAL = @NOMBRE_FISCAL, NOMBRE_COMERCIAL = @NOMBRE_COMERCIAL, 
                                                ID_TIPO_VIA = @ID_TIPO_VIA, NOMBRE_VIA = @NOMBRE_VIA, NUMERO_VIA = @NUMERO_VIA, PISO = @PISO, 
                                                LETRA_PISO = @LETRA_PISO, LOCALIDAD = @LOCALIDAD, PROVINCIA = @PROVINCIA, PAIS = @PAIS, CP = @CP, 
                                                TELEFONO = @TELEFONO, EMAIL = @EMAIL, WEB = @WEB, COMENTARIOS = @COMENTARIOS
                                                WHERE CIF = @CIF", connection)

            updateQuery.Parameters.Add("@ID_TIPO", MySqlDbType.Int16).Value = CB_TIPO.SelectedValue
            updateQuery.Parameters.Add("@ID_ESTADO", MySqlDbType.Int16).Value = cbEstado.SelectedValue
            updateQuery.Parameters.AddWithValue("@CIF", DbNullOrStringValue(TB_CIF.Text))
            updateQuery.Parameters.AddWithValue("@NOMBRE_FISCAL", DbNullOrStringValue(TB_NOMBRE_FISCAL.Text))
            updateQuery.Parameters.AddWithValue("@NOMBRE_COMERCIAL", DbNullOrStringValue(TB_NOMBRE_COMERCIAL.Text))
            updateQuery.Parameters.Add("@ID_TIPO_VIA", MySqlDbType.Int16).Value = CB_TIPO_VIA.SelectedValue
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
            updateQuery.Parameters.AddWithValue("@COMENTARIOS", DbNullOrStringValue(btnEvento.Text))

            connection.Open()

            updateQuery.ExecuteNonQuery()

            connection.Close()

        End If

    End Sub

    Private Sub BTN_VerDocumentos_Click(sender As Object, e As EventArgs) Handles BTN_VerDocumentos.Click

        Certificacion3.Show()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Process.Start("firefox", "https://www.einforma.com/servlet/app/prod/ETIQUETA_EMPRESA/nif/" + TB_CIF.Text)
    End Sub

    Public Sub populate_dgvActividades()

        Dim searchQuery As New MySqlCommand("SELECT A.ID, A.TIPO, A.FECHA, A.INFO
                                            FROM ACTIVIDADES_EMPRESAS A
                                            LEFT JOIN EMPRESAS E ON A.ID_EMPRESA = E.ID
                                            WHERE CIF = @CIF
                                            ORDER BY A.FECHA DESC", connection)

        searchQuery.Parameters.AddWithValue("@CIF", DbNullOrStringValue(TB_CIF.Text))

        Dim adapter As New MySqlDataAdapter(searchQuery)
        Dim table As New DataTable()
        adapter.Fill(table)
        dgvActividades.DataSource = table

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        NuevaActividad.Show()
    End Sub

    Private Sub BtnAddContact_Click(sender As Object, e As EventArgs) Handles btnAddContact.Click
        AñadirContacto.Show()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        ModificarActividad.Show()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim result As Integer = MessageBox.Show("¿Eliminar actividad?", "Mensaje de confirmación", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Dim i = dgvActividades.CurrentRow.Index
            Dim ID = dgvActividades.Item(0, i).Value

            Dim deleteActivity As New MySqlCommand("DELETE FROM ACTIVIDADES_EMPRESAS WHERE ID = @ID", connection)
            deleteActivity.Parameters.AddWithValue("@ID", DbNullOrStringValue(ID))

            connection.Open()
            deleteActivity.ExecuteNonQuery()
            connection.Close()

            populate_dgvActividades()
        End If
    End Sub

    Private Sub ModificarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem1.Click
        ModificarContacto.Show()
    End Sub

    Private Sub EliminarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem1.Click
        Dim result As Integer = MessageBox.Show("¿Eliminar contacto?", "Mensaje de confirmación", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Dim i = dgvActividades.CurrentRow.Index
            Dim ID = dgvActividades.Item(0, i).Value

            Dim deleteContact As New MySqlCommand("DELETE FROM CONTACTOS_EMPRESAS WHERE ID = @ID", connection)
            deleteContact.Parameters.AddWithValue("@ID", DbNullOrStringValue(ID))

            connection.Open()
            deleteContact.ExecuteNonQuery()
            connection.Close()

            populate_dgvContactos()
        End If
    End Sub
End Class