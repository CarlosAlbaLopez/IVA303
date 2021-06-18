'Imports System.Data.SqlClient
'Imports System.IO
'Public Class C_AltaAdministrador

'    Private Sub frm_Activated(sender As Object, e As EventArgs) Handles Me.Activated

'        Me.TopMost = True
'    End Sub

'    Dim connection As New SqlConnection("Server=(LocalDB)\303;Database=iva303;User=VISUAL;Pwd=303")
'    Private Sub AltaEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        'TODO: This line of code loads data into the 'Iva303DataSet4.TIPOS_EMPRESAS' table. You can move, or remove it, as needed.

'        'Llena el campo CIF
'        TB_CIF.Text = Analisis.TBCIF.Text

'        'Llena el ComboBox Tipo de Empresa
'        Dim tipoconnection As New SqlConnection("Server=(LocalDB)\303;Database=iva303;User=VISUAL;Pwd=303")

'        Dim tipocommand As New SqlCommand("select * from TIPOS_EMPRESAS", tipoconnection)

'        Dim tipoadapter As New SqlDataAdapter(tipocommand)

'        Dim tipotable As New DataTable()

'        tipoadapter.Fill(tipotable)


'        'Llena el ComboBox Tipo de Vía
'        Dim viaconnection As New SqlConnection("Server=(LocalDB)\303;Database=iva303;User=VISUAL;Pwd=303")

'        Dim viacommand As New SqlCommand("select * from TIPOS_VIAS", viaconnection)

'        Dim viaadapter As New SqlDataAdapter(viacommand)

'        Dim viatable As New DataTable()

'        viaadapter.Fill(viatable)

'        CB_TIPO_VIA.DataSource = viatable

'        CB_TIPO_VIA.DisplayMember = "NOMBRE"
'        CB_TIPO_VIA.ValueMember = "ID"
'    End Sub

'    Private Sub BTN_ALTA_EMPRESA_Click(sender As Object, e As EventArgs) Handles BTN_ALTA_EMPRESA.Click

'        Dim insertQuery As New SqlCommand("INSERT INTO EMPRESAS (ID_TIPO, CIF, NOMBRE_FISCAL, NOMBRE_COMERCIAL, ID_TIPO_VIA, NOMBRE_VIA, NUMERO_VIA, PISO, LETRA_PISO, LOCALIDAD, PROVINCIA, PAIS, CP, TELEFONO, EMAIL, WEB)
'                                        VALUES (@ID_TIPO, @CIF, @NOMBRE_FISCAL, @NOMBRE_COMERCIAL, @ID_TIPO_VIA, @NOMBRE_VIA, @NUMERO_VIA, @PISO, @LETRA_PISO, @LOCALIDAD, @PROVINCIA, @PAIS, @CP, @TELEFONO, @EMAIL, @WEB)", connection)


'        insertQuery.Parameters.Add("@CIF", SqlDbType.VarChar).Value = TB_CIF.Text
'        insertQuery.Parameters.Add("@NOMBRE_FISCAL", SqlDbType.VarChar).Value = TB_NOMBRE_FISCAL.Text
'        insertQuery.Parameters.Add("@NOMBRE_COMERCIAL", SqlDbType.VarChar).Value = TB_NOMBRE_COMERCIAL.Text
'        insertQuery.Parameters.Add("@ID_TIPO_VIA", SqlDbType.SmallInt).Value = CB_TIPO_VIA.SelectedValue
'        insertQuery.Parameters.Add("@NOMBRE_VIA", SqlDbType.VarChar).Value = TB_NOMBRE_VIA.Text
'        insertQuery.Parameters.Add("@NUMERO_VIA", SqlDbType.SmallInt).Value = TB_NUMERO_VIA.Text
'        insertQuery.Parameters.Add("@PISO", SqlDbType.TinyInt).Value = TB_PISO.Text
'        insertQuery.Parameters.Add("@LETRA_PISO", SqlDbType.VarChar).Value = TB_LETRA.Text
'        insertQuery.Parameters.Add("@LOCALIDAD", SqlDbType.VarChar).Value = TB_LOCALIDAD.Text
'        insertQuery.Parameters.Add("@PROVINCIA", SqlDbType.VarChar).Value = TB_PROVINCIA.Text
'        insertQuery.Parameters.Add("@PAIS", SqlDbType.VarChar).Value = TB_PAIS.Text
'        insertQuery.Parameters.Add("@CP", SqlDbType.VarChar).Value = TB_CP.Text
'        insertQuery.Parameters.Add("@TELEFONO", SqlDbType.VarChar).Value = TB_TLF.Text
'        insertQuery.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = TB_CORREO.Text
'        insertQuery.Parameters.Add("@WEB", SqlDbType.VarChar).Value = TB_WEB.Text

'        connection.Open()

'        insertQuery.ExecuteNonQuery()

'        connection.Close()

'        Empresas.Empresas_Load(sender, e)

'        Me.Close()
'    End Sub
'End Class