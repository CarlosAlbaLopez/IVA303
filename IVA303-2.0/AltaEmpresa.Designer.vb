<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AltaEmpresa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TB_NOMBRE_FISCAL = New System.Windows.Forms.TextBox()
        Me.TB_LOCALIDAD = New System.Windows.Forms.TextBox()
        Me.TB_NOMBRE_VIA = New System.Windows.Forms.TextBox()
        Me.TB_CIF = New System.Windows.Forms.TextBox()
        Me.TB_NOMBRE_COMERCIAL = New System.Windows.Forms.TextBox()
        Me.LB_NOMBRE_FISCAL = New System.Windows.Forms.Label()
        Me.LB_NOMBRE_COMERCIAL = New System.Windows.Forms.Label()
        Me.LB_CIF = New System.Windows.Forms.Label()
        Me.LB_DIRECCION = New System.Windows.Forms.Label()
        Me.LB_TIPO = New System.Windows.Forms.Label()
        Me.LB_LOCALIDAD = New System.Windows.Forms.Label()
        Me.CB_TIPO_VIA = New System.Windows.Forms.ComboBox()
        Me.CB_TIPO = New System.Windows.Forms.ComboBox()
        Me.LB_PROVINCIA = New System.Windows.Forms.Label()
        Me.TB_PROVINCIA = New System.Windows.Forms.TextBox()
        Me.TB_PAIS = New System.Windows.Forms.TextBox()
        Me.LB_PAIS = New System.Windows.Forms.Label()
        Me.LB_TELEFONO = New System.Windows.Forms.Label()
        Me.LB_CORREO = New System.Windows.Forms.Label()
        Me.LB_CP = New System.Windows.Forms.Label()
        Me.TB_CP = New System.Windows.Forms.TextBox()
        Me.TB_TLF = New System.Windows.Forms.TextBox()
        Me.TB_CORREO = New System.Windows.Forms.TextBox()
        Me.BTN_ALTA_EMPRESA = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_GRUPO = New System.Windows.Forms.ComboBox()
        Me.BTN_ALTA_GRUPO = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_WEB = New System.Windows.Forms.TextBox()
        Me.TB_NUMERO_VIA = New System.Windows.Forms.TextBox()
        Me.TB_LETRA = New System.Windows.Forms.TextBox()
        Me.LB_PISO = New System.Windows.Forms.Label()
        Me.LB_NUMERO = New System.Windows.Forms.Label()
        Me.LB_LETRA = New System.Windows.Forms.Label()
        Me.TB_PISO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.btnEvento = New System.Windows.Forms.TextBox()
        Me.BTN_VerDocumentos = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvVAT = New System.Windows.Forms.DataGridView()
        Me.dgvContactos = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModificarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAddContact = New System.Windows.Forms.Button()
        Me.dgvIVAcliente = New System.Windows.Forms.DataGridView()
        Me.dgvActividades = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TIPOSEMPRESASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvVAT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContactos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.dgvIVAcliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvActividades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.TIPOSEMPRESASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TB_NOMBRE_FISCAL
        '
        Me.TB_NOMBRE_FISCAL.Location = New System.Drawing.Point(300, 30)
        Me.TB_NOMBRE_FISCAL.Name = "TB_NOMBRE_FISCAL"
        Me.TB_NOMBRE_FISCAL.Size = New System.Drawing.Size(615, 20)
        Me.TB_NOMBRE_FISCAL.TabIndex = 1
        '
        'TB_LOCALIDAD
        '
        Me.TB_LOCALIDAD.Location = New System.Drawing.Point(163, 153)
        Me.TB_LOCALIDAD.Name = "TB_LOCALIDAD"
        Me.TB_LOCALIDAD.Size = New System.Drawing.Size(569, 20)
        Me.TB_LOCALIDAD.TabIndex = 9
        '
        'TB_NOMBRE_VIA
        '
        Me.TB_NOMBRE_VIA.Location = New System.Drawing.Point(163, 93)
        Me.TB_NOMBRE_VIA.Name = "TB_NOMBRE_VIA"
        Me.TB_NOMBRE_VIA.Size = New System.Drawing.Size(569, 20)
        Me.TB_NOMBRE_VIA.TabIndex = 4
        '
        'TB_CIF
        '
        Me.TB_CIF.Location = New System.Drawing.Point(163, 30)
        Me.TB_CIF.Name = "TB_CIF"
        Me.TB_CIF.Size = New System.Drawing.Size(121, 20)
        Me.TB_CIF.TabIndex = 0
        '
        'TB_NOMBRE_COMERCIAL
        '
        Me.TB_NOMBRE_COMERCIAL.Location = New System.Drawing.Point(937, 30)
        Me.TB_NOMBRE_COMERCIAL.Name = "TB_NOMBRE_COMERCIAL"
        Me.TB_NOMBRE_COMERCIAL.Size = New System.Drawing.Size(655, 20)
        Me.TB_NOMBRE_COMERCIAL.TabIndex = 2
        '
        'LB_NOMBRE_FISCAL
        '
        Me.LB_NOMBRE_FISCAL.AutoSize = True
        Me.LB_NOMBRE_FISCAL.Location = New System.Drawing.Point(297, 14)
        Me.LB_NOMBRE_FISCAL.Name = "LB_NOMBRE_FISCAL"
        Me.LB_NOMBRE_FISCAL.Size = New System.Drawing.Size(74, 13)
        Me.LB_NOMBRE_FISCAL.TabIndex = 6
        Me.LB_NOMBRE_FISCAL.Text = "Nombre Fiscal"
        '
        'LB_NOMBRE_COMERCIAL
        '
        Me.LB_NOMBRE_COMERCIAL.AutoSize = True
        Me.LB_NOMBRE_COMERCIAL.Location = New System.Drawing.Point(934, 14)
        Me.LB_NOMBRE_COMERCIAL.Name = "LB_NOMBRE_COMERCIAL"
        Me.LB_NOMBRE_COMERCIAL.Size = New System.Drawing.Size(93, 13)
        Me.LB_NOMBRE_COMERCIAL.TabIndex = 7
        Me.LB_NOMBRE_COMERCIAL.Text = "Nombre Comercial"
        '
        'LB_CIF
        '
        Me.LB_CIF.AutoSize = True
        Me.LB_CIF.Location = New System.Drawing.Point(160, 14)
        Me.LB_CIF.Name = "LB_CIF"
        Me.LB_CIF.Size = New System.Drawing.Size(23, 13)
        Me.LB_CIF.TabIndex = 8
        Me.LB_CIF.Text = "CIF"
        '
        'LB_DIRECCION
        '
        Me.LB_DIRECCION.AutoSize = True
        Me.LB_DIRECCION.Location = New System.Drawing.Point(23, 76)
        Me.LB_DIRECCION.Name = "LB_DIRECCION"
        Me.LB_DIRECCION.Size = New System.Drawing.Size(52, 13)
        Me.LB_DIRECCION.TabIndex = 9
        Me.LB_DIRECCION.Text = "Dirección"
        '
        'LB_TIPO
        '
        Me.LB_TIPO.AutoSize = True
        Me.LB_TIPO.Location = New System.Drawing.Point(22, 14)
        Me.LB_TIPO.Name = "LB_TIPO"
        Me.LB_TIPO.Size = New System.Drawing.Size(28, 13)
        Me.LB_TIPO.TabIndex = 10
        Me.LB_TIPO.Text = "Tipo"
        '
        'LB_LOCALIDAD
        '
        Me.LB_LOCALIDAD.AutoSize = True
        Me.LB_LOCALIDAD.Location = New System.Drawing.Point(160, 137)
        Me.LB_LOCALIDAD.Name = "LB_LOCALIDAD"
        Me.LB_LOCALIDAD.Size = New System.Drawing.Size(53, 13)
        Me.LB_LOCALIDAD.TabIndex = 11
        Me.LB_LOCALIDAD.Text = "Localidad"
        '
        'CB_TIPO_VIA
        '
        Me.CB_TIPO_VIA.FormattingEnabled = True
        Me.CB_TIPO_VIA.Location = New System.Drawing.Point(25, 92)
        Me.CB_TIPO_VIA.Name = "CB_TIPO_VIA"
        Me.CB_TIPO_VIA.Size = New System.Drawing.Size(121, 21)
        Me.CB_TIPO_VIA.TabIndex = 3
        '
        'CB_TIPO
        '
        Me.CB_TIPO.FormattingEnabled = True
        Me.CB_TIPO.Location = New System.Drawing.Point(25, 30)
        Me.CB_TIPO.Name = "CB_TIPO"
        Me.CB_TIPO.Size = New System.Drawing.Size(121, 21)
        Me.CB_TIPO.TabIndex = 17
        '
        'LB_PROVINCIA
        '
        Me.LB_PROVINCIA.AutoSize = True
        Me.LB_PROVINCIA.Location = New System.Drawing.Point(745, 137)
        Me.LB_PROVINCIA.Name = "LB_PROVINCIA"
        Me.LB_PROVINCIA.Size = New System.Drawing.Size(51, 13)
        Me.LB_PROVINCIA.TabIndex = 16
        Me.LB_PROVINCIA.Text = "Provincia"
        '
        'TB_PROVINCIA
        '
        Me.TB_PROVINCIA.Location = New System.Drawing.Point(748, 153)
        Me.TB_PROVINCIA.Name = "TB_PROVINCIA"
        Me.TB_PROVINCIA.Size = New System.Drawing.Size(572, 20)
        Me.TB_PROVINCIA.TabIndex = 10
        '
        'TB_PAIS
        '
        Me.TB_PAIS.Location = New System.Drawing.Point(1336, 153)
        Me.TB_PAIS.Name = "TB_PAIS"
        Me.TB_PAIS.Size = New System.Drawing.Size(256, 20)
        Me.TB_PAIS.TabIndex = 11
        '
        'LB_PAIS
        '
        Me.LB_PAIS.AutoSize = True
        Me.LB_PAIS.Location = New System.Drawing.Point(1333, 137)
        Me.LB_PAIS.Name = "LB_PAIS"
        Me.LB_PAIS.Size = New System.Drawing.Size(29, 13)
        Me.LB_PAIS.TabIndex = 22
        Me.LB_PAIS.Text = "País"
        '
        'LB_TELEFONO
        '
        Me.LB_TELEFONO.AutoSize = True
        Me.LB_TELEFONO.Location = New System.Drawing.Point(23, 197)
        Me.LB_TELEFONO.Name = "LB_TELEFONO"
        Me.LB_TELEFONO.Size = New System.Drawing.Size(49, 13)
        Me.LB_TELEFONO.TabIndex = 24
        Me.LB_TELEFONO.Text = "Teléfono"
        '
        'LB_CORREO
        '
        Me.LB_CORREO.AutoSize = True
        Me.LB_CORREO.Location = New System.Drawing.Point(258, 197)
        Me.LB_CORREO.Name = "LB_CORREO"
        Me.LB_CORREO.Size = New System.Drawing.Size(38, 13)
        Me.LB_CORREO.TabIndex = 25
        Me.LB_CORREO.Text = "Correo"
        '
        'LB_CP
        '
        Me.LB_CP.AutoSize = True
        Me.LB_CP.Location = New System.Drawing.Point(24, 137)
        Me.LB_CP.Name = "LB_CP"
        Me.LB_CP.Size = New System.Drawing.Size(21, 13)
        Me.LB_CP.TabIndex = 26
        Me.LB_CP.Text = "CP"
        '
        'TB_CP
        '
        Me.TB_CP.Location = New System.Drawing.Point(25, 153)
        Me.TB_CP.Name = "TB_CP"
        Me.TB_CP.Size = New System.Drawing.Size(116, 20)
        Me.TB_CP.TabIndex = 8
        '
        'TB_TLF
        '
        Me.TB_TLF.Location = New System.Drawing.Point(25, 214)
        Me.TB_TLF.Name = "TB_TLF"
        Me.TB_TLF.Size = New System.Drawing.Size(212, 20)
        Me.TB_TLF.TabIndex = 12
        '
        'TB_CORREO
        '
        Me.TB_CORREO.Location = New System.Drawing.Point(261, 214)
        Me.TB_CORREO.Name = "TB_CORREO"
        Me.TB_CORREO.Size = New System.Drawing.Size(686, 20)
        Me.TB_CORREO.TabIndex = 13
        '
        'BTN_ALTA_EMPRESA
        '
        Me.BTN_ALTA_EMPRESA.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ALTA_EMPRESA.Location = New System.Drawing.Point(25, 609)
        Me.BTN_ALTA_EMPRESA.Name = "BTN_ALTA_EMPRESA"
        Me.BTN_ALTA_EMPRESA.Size = New System.Drawing.Size(437, 49)
        Me.BTN_ALTA_EMPRESA.TabIndex = 16
        Me.BTN_ALTA_EMPRESA.Text = "GUARDAR"
        Me.BTN_ALTA_EMPRESA.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(991, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Grupo"
        '
        'CB_GRUPO
        '
        Me.CB_GRUPO.FormattingEnabled = True
        Me.CB_GRUPO.Location = New System.Drawing.Point(992, 92)
        Me.CB_GRUPO.Name = "CB_GRUPO"
        Me.CB_GRUPO.Size = New System.Drawing.Size(201, 21)
        Me.CB_GRUPO.TabIndex = 18
        '
        'BTN_ALTA_GRUPO
        '
        Me.BTN_ALTA_GRUPO.Location = New System.Drawing.Point(1199, 92)
        Me.BTN_ALTA_GRUPO.Name = "BTN_ALTA_GRUPO"
        Me.BTN_ALTA_GRUPO.Size = New System.Drawing.Size(121, 21)
        Me.BTN_ALTA_GRUPO.TabIndex = 19
        Me.BTN_ALTA_GRUPO.Text = "Alta Grupo"
        Me.BTN_ALTA_GRUPO.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(960, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Web"
        '
        'TB_WEB
        '
        Me.TB_WEB.Location = New System.Drawing.Point(963, 214)
        Me.TB_WEB.Name = "TB_WEB"
        Me.TB_WEB.Size = New System.Drawing.Size(629, 20)
        Me.TB_WEB.TabIndex = 14
        '
        'TB_NUMERO_VIA
        '
        Me.TB_NUMERO_VIA.Location = New System.Drawing.Point(748, 93)
        Me.TB_NUMERO_VIA.Name = "TB_NUMERO_VIA"
        Me.TB_NUMERO_VIA.Size = New System.Drawing.Size(55, 20)
        Me.TB_NUMERO_VIA.TabIndex = 5
        '
        'TB_LETRA
        '
        Me.TB_LETRA.Location = New System.Drawing.Point(892, 93)
        Me.TB_LETRA.Name = "TB_LETRA"
        Me.TB_LETRA.Size = New System.Drawing.Size(55, 20)
        Me.TB_LETRA.TabIndex = 7
        '
        'LB_PISO
        '
        Me.LB_PISO.AutoSize = True
        Me.LB_PISO.Location = New System.Drawing.Point(818, 76)
        Me.LB_PISO.Name = "LB_PISO"
        Me.LB_PISO.Size = New System.Drawing.Size(27, 13)
        Me.LB_PISO.TabIndex = 17
        Me.LB_PISO.Text = "Piso"
        '
        'LB_NUMERO
        '
        Me.LB_NUMERO.AutoSize = True
        Me.LB_NUMERO.Location = New System.Drawing.Point(745, 76)
        Me.LB_NUMERO.Name = "LB_NUMERO"
        Me.LB_NUMERO.Size = New System.Drawing.Size(44, 13)
        Me.LB_NUMERO.TabIndex = 18
        Me.LB_NUMERO.Text = "Número"
        '
        'LB_LETRA
        '
        Me.LB_LETRA.AutoSize = True
        Me.LB_LETRA.Location = New System.Drawing.Point(889, 76)
        Me.LB_LETRA.Name = "LB_LETRA"
        Me.LB_LETRA.Size = New System.Drawing.Size(31, 13)
        Me.LB_LETRA.TabIndex = 19
        Me.LB_LETRA.Text = "Letra"
        '
        'TB_PISO
        '
        Me.TB_PISO.Location = New System.Drawing.Point(821, 93)
        Me.TB_PISO.Name = "TB_PISO"
        Me.TB_PISO.Size = New System.Drawing.Size(55, 20)
        Me.TB_PISO.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1333, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Estado"
        '
        'cbEstado
        '
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Location = New System.Drawing.Point(1336, 92)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(256, 21)
        Me.cbEstado.TabIndex = 32
        '
        'btnEvento
        '
        Me.btnEvento.Location = New System.Drawing.Point(25, 415)
        Me.btnEvento.Multiline = True
        Me.btnEvento.Name = "btnEvento"
        Me.btnEvento.Size = New System.Drawing.Size(437, 188)
        Me.btnEvento.TabIndex = 15
        '
        'BTN_VerDocumentos
        '
        Me.BTN_VerDocumentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VerDocumentos.Location = New System.Drawing.Point(1272, 609)
        Me.BTN_VerDocumentos.Name = "BTN_VerDocumentos"
        Me.BTN_VerDocumentos.Size = New System.Drawing.Size(324, 49)
        Me.BTN_VerDocumentos.TabIndex = 20
        Me.BTN_VerDocumentos.Text = "VER DOCUMENTOS"
        Me.BTN_VerDocumentos.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(888, 609)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(378, 49)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "EVENTO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(468, 609)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(414, 49)
        Me.btnBuscar.TabIndex = 40
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(885, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Actividades"
        '
        'dgvVAT
        '
        Me.dgvVAT.AllowUserToAddRows = False
        Me.dgvVAT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVAT.Location = New System.Drawing.Point(468, 415)
        Me.dgvVAT.Name = "dgvVAT"
        Me.dgvVAT.RowTemplate.Height = 30
        Me.dgvVAT.Size = New System.Drawing.Size(204, 188)
        Me.dgvVAT.TabIndex = 43
        '
        'dgvContactos
        '
        Me.dgvContactos.AllowUserToAddRows = False
        Me.dgvContactos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvContactos.ContextMenuStrip = Me.ContextMenuStrip2
        Me.dgvContactos.Location = New System.Drawing.Point(25, 275)
        Me.dgvContactos.Name = "dgvContactos"
        Me.dgvContactos.Size = New System.Drawing.Size(857, 134)
        Me.dgvContactos.TabIndex = 44
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarToolStripMenuItem1, Me.EliminarToolStripMenuItem1})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(126, 48)
        '
        'ModificarToolStripMenuItem1
        '
        Me.ModificarToolStripMenuItem1.Name = "ModificarToolStripMenuItem1"
        Me.ModificarToolStripMenuItem1.Size = New System.Drawing.Size(125, 22)
        Me.ModificarToolStripMenuItem1.Text = "Modificar"
        '
        'EliminarToolStripMenuItem1
        '
        Me.EliminarToolStripMenuItem1.Name = "EliminarToolStripMenuItem1"
        Me.EliminarToolStripMenuItem1.Size = New System.Drawing.Size(125, 22)
        Me.EliminarToolStripMenuItem1.Text = "Eliminar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Contactos"
        '
        'btnAddContact
        '
        Me.btnAddContact.Location = New System.Drawing.Point(859, 386)
        Me.btnAddContact.Name = "btnAddContact"
        Me.btnAddContact.Size = New System.Drawing.Size(21, 21)
        Me.btnAddContact.TabIndex = 46
        Me.btnAddContact.Text = "+"
        Me.btnAddContact.UseVisualStyleBackColor = True
        '
        'dgvIVAcliente
        '
        Me.dgvIVAcliente.AllowUserToAddRows = False
        Me.dgvIVAcliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvIVAcliente.Location = New System.Drawing.Point(678, 415)
        Me.dgvIVAcliente.Name = "dgvIVAcliente"
        Me.dgvIVAcliente.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvIVAcliente.RowTemplate.Height = 30
        Me.dgvIVAcliente.Size = New System.Drawing.Size(204, 188)
        Me.dgvIVAcliente.TabIndex = 47
        '
        'dgvActividades
        '
        Me.dgvActividades.AllowUserToAddRows = False
        Me.dgvActividades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvActividades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvActividades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvActividades.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvActividades.Location = New System.Drawing.Point(892, 275)
        Me.dgvActividades.Name = "dgvActividades"
        Me.dgvActividades.Size = New System.Drawing.Size(704, 328)
        Me.dgvActividades.TabIndex = 48
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(126, 48)
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'TIPOSEMPRESASBindingSource
        '
        Me.TIPOSEMPRESASBindingSource.DataMember = "TIPOS_EMPRESAS"
        '
        'AltaEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1618, 665)
        Me.Controls.Add(Me.dgvActividades)
        Me.Controls.Add(Me.dgvIVAcliente)
        Me.Controls.Add(Me.btnAddContact)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvContactos)
        Me.Controls.Add(Me.cbEstado)
        Me.Controls.Add(Me.BTN_ALTA_GRUPO)
        Me.Controls.Add(Me.dgvVAT)
        Me.Controls.Add(Me.CB_GRUPO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTN_VerDocumentos)
        Me.Controls.Add(Me.btnEvento)
        Me.Controls.Add(Me.TB_WEB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTN_ALTA_EMPRESA)
        Me.Controls.Add(Me.TB_CORREO)
        Me.Controls.Add(Me.TB_TLF)
        Me.Controls.Add(Me.TB_CP)
        Me.Controls.Add(Me.LB_CP)
        Me.Controls.Add(Me.LB_CORREO)
        Me.Controls.Add(Me.LB_TELEFONO)
        Me.Controls.Add(Me.TB_PAIS)
        Me.Controls.Add(Me.LB_PAIS)
        Me.Controls.Add(Me.TB_PROVINCIA)
        Me.Controls.Add(Me.TB_PISO)
        Me.Controls.Add(Me.LB_LETRA)
        Me.Controls.Add(Me.LB_NUMERO)
        Me.Controls.Add(Me.LB_PISO)
        Me.Controls.Add(Me.LB_PROVINCIA)
        Me.Controls.Add(Me.CB_TIPO)
        Me.Controls.Add(Me.TB_LETRA)
        Me.Controls.Add(Me.TB_NUMERO_VIA)
        Me.Controls.Add(Me.CB_TIPO_VIA)
        Me.Controls.Add(Me.LB_LOCALIDAD)
        Me.Controls.Add(Me.LB_TIPO)
        Me.Controls.Add(Me.LB_DIRECCION)
        Me.Controls.Add(Me.LB_CIF)
        Me.Controls.Add(Me.LB_NOMBRE_COMERCIAL)
        Me.Controls.Add(Me.LB_NOMBRE_FISCAL)
        Me.Controls.Add(Me.TB_NOMBRE_COMERCIAL)
        Me.Controls.Add(Me.TB_CIF)
        Me.Controls.Add(Me.TB_NOMBRE_VIA)
        Me.Controls.Add(Me.TB_LOCALIDAD)
        Me.Controls.Add(Me.TB_NOMBRE_FISCAL)
        Me.Name = "AltaEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AltaEmpresa"
        CType(Me.dgvVAT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContactos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.dgvIVAcliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvActividades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.TIPOSEMPRESASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TB_NOMBRE_FISCAL As TextBox
    Friend WithEvents TB_LOCALIDAD As TextBox
    Friend WithEvents TB_NOMBRE_VIA As TextBox
    Friend WithEvents TB_CIF As TextBox
    Friend WithEvents TB_NOMBRE_COMERCIAL As TextBox
    Friend WithEvents LB_NOMBRE_FISCAL As Label
    Friend WithEvents LB_NOMBRE_COMERCIAL As Label
    Friend WithEvents LB_CIF As Label
    Friend WithEvents LB_DIRECCION As Label
    Friend WithEvents LB_TIPO As Label
    Friend WithEvents LB_LOCALIDAD As Label
    Friend WithEvents CB_TIPO_VIA As ComboBox
    Friend WithEvents CB_TIPO As ComboBox

    Friend WithEvents TIPOSEMPRESASBindingSource As BindingSource

    Friend WithEvents LB_PROVINCIA As Label
    Friend WithEvents TB_PROVINCIA As TextBox
    Friend WithEvents TB_PAIS As TextBox
    Friend WithEvents LB_PAIS As Label
    Friend WithEvents LB_TELEFONO As Label
    Friend WithEvents LB_CORREO As Label
    Friend WithEvents LB_CP As Label
    Friend WithEvents TB_CP As TextBox
    Friend WithEvents TB_TLF As TextBox
    Friend WithEvents TB_CORREO As TextBox
    Friend WithEvents BTN_ALTA_EMPRESA As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_GRUPO As ComboBox
    Friend WithEvents BTN_ALTA_GRUPO As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_WEB As TextBox
    Friend WithEvents TB_NUMERO_VIA As TextBox
    Friend WithEvents TB_LETRA As TextBox
    Friend WithEvents LB_PISO As Label
    Friend WithEvents LB_NUMERO As Label
    Friend WithEvents LB_LETRA As Label
    Friend WithEvents TB_PISO As TextBox
    Friend WithEvents btnEvento As TextBox
    Friend WithEvents BTN_VerDocumentos As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvVAT As DataGridView
    Friend WithEvents dgvContactos As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAddContact As Button
    Friend WithEvents dgvIVAcliente As DataGridView
    Friend WithEvents dgvActividades As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents ModificarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem1 As ToolStripMenuItem
End Class
