<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaCliente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TB_Comentarios = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.numFact = New System.Windows.Forms.NumericUpDown()
        Me.cbOperador = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BTN_ALTA_GRUPO = New System.Windows.Forms.Button()
        Me.CB_GRUPO = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_WEB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TB_CORREO = New System.Windows.Forms.TextBox()
        Me.TB_TLF = New System.Windows.Forms.TextBox()
        Me.TB_CP = New System.Windows.Forms.TextBox()
        Me.LB_CP = New System.Windows.Forms.Label()
        Me.LB_CORREO = New System.Windows.Forms.Label()
        Me.LB_TELEFONO = New System.Windows.Forms.Label()
        Me.TB_PAIS = New System.Windows.Forms.TextBox()
        Me.LB_PAIS = New System.Windows.Forms.Label()
        Me.TB_PROVINCIA = New System.Windows.Forms.TextBox()
        Me.TB_PISO = New System.Windows.Forms.TextBox()
        Me.LB_LETRA = New System.Windows.Forms.Label()
        Me.LB_NUMERO = New System.Windows.Forms.Label()
        Me.LB_PISO = New System.Windows.Forms.Label()
        Me.LB_PROVINCIA = New System.Windows.Forms.Label()
        Me.TB_LETRA = New System.Windows.Forms.TextBox()
        Me.TB_NUMERO_VIA = New System.Windows.Forms.TextBox()
        Me.CB_TIPO_VIA = New System.Windows.Forms.ComboBox()
        Me.LB_LOCALIDAD = New System.Windows.Forms.Label()
        Me.LB_DIRECCION = New System.Windows.Forms.Label()
        Me.LB_CIF = New System.Windows.Forms.Label()
        Me.LB_NOMBRE_COMERCIAL = New System.Windows.Forms.Label()
        Me.LB_NOMBRE_FISCAL = New System.Windows.Forms.Label()
        Me.TB_NOMBRE_COMERCIAL = New System.Windows.Forms.TextBox()
        Me.TB_CIF = New System.Windows.Forms.TextBox()
        Me.TB_NOMBRE_VIA = New System.Windows.Forms.TextBox()
        Me.TB_LOCALIDAD = New System.Windows.Forms.TextBox()
        Me.TB_NOMBRE_FISCAL = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvActividades = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbSector = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numFact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvActividades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(299, 54)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(138, 17)
        Me.CheckBox1.TabIndex = 72
        Me.CheckBox1.Text = "CONTRATO FIRMADO"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TB_Comentarios
        '
        Me.TB_Comentarios.Location = New System.Drawing.Point(25, 307)
        Me.TB_Comentarios.Multiline = True
        Me.TB_Comentarios.Name = "TB_Comentarios"
        Me.TB_Comentarios.Size = New System.Drawing.Size(706, 292)
        Me.TB_Comentarios.TabIndex = 94
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbEstado)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.numFact)
        Me.GroupBox1.Controls.Add(Me.cbOperador)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(621, 65)
        Me.GroupBox1.TabIndex = 107
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'cbEstado
        '
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Location = New System.Drawing.Point(6, 35)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(245, 21)
        Me.cbEstado.TabIndex = 116
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = "Estado"
        '
        'numFact
        '
        Me.numFact.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numFact.Location = New System.Drawing.Point(501, 35)
        Me.numFact.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numFact.Name = "numFact"
        Me.numFact.Size = New System.Drawing.Size(114, 20)
        Me.numFact.TabIndex = 1
        '
        'cbOperador
        '
        Me.cbOperador.FormattingEnabled = True
        Me.cbOperador.Location = New System.Drawing.Point(270, 34)
        Me.cbOperador.Name = "cbOperador"
        Me.cbOperador.Size = New System.Drawing.Size(216, 21)
        Me.cbOperador.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(267, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Operador"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(497, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Facturación (millones €)"
        '
        'BTN_ALTA_GRUPO
        '
        Me.BTN_ALTA_GRUPO.Location = New System.Drawing.Point(212, 32)
        Me.BTN_ALTA_GRUPO.Name = "BTN_ALTA_GRUPO"
        Me.BTN_ALTA_GRUPO.Size = New System.Drawing.Size(65, 21)
        Me.BTN_ALTA_GRUPO.TabIndex = 19
        Me.BTN_ALTA_GRUPO.Text = "Alta Grupo"
        Me.BTN_ALTA_GRUPO.UseVisualStyleBackColor = True
        '
        'CB_GRUPO
        '
        Me.CB_GRUPO.FormattingEnabled = True
        Me.CB_GRUPO.Location = New System.Drawing.Point(5, 32)
        Me.CB_GRUPO.Name = "CB_GRUPO"
        Me.CB_GRUPO.Size = New System.Drawing.Size(201, 21)
        Me.CB_GRUPO.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Grupo"
        '
        'TB_WEB
        '
        Me.TB_WEB.Location = New System.Drawing.Point(820, 241)
        Me.TB_WEB.Name = "TB_WEB"
        Me.TB_WEB.Size = New System.Drawing.Size(771, 20)
        Me.TB_WEB.TabIndex = 93
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(817, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "Web"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Comentarios"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(24, 616)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(259, 49)
        Me.Button1.TabIndex = 96
        Me.Button1.Text = "GUARDAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TB_CORREO
        '
        Me.TB_CORREO.Location = New System.Drawing.Point(260, 241)
        Me.TB_CORREO.Name = "TB_CORREO"
        Me.TB_CORREO.Size = New System.Drawing.Size(542, 20)
        Me.TB_CORREO.TabIndex = 92
        '
        'TB_TLF
        '
        Me.TB_TLF.Location = New System.Drawing.Point(25, 241)
        Me.TB_TLF.Name = "TB_TLF"
        Me.TB_TLF.Size = New System.Drawing.Size(212, 20)
        Me.TB_TLF.TabIndex = 91
        '
        'TB_CP
        '
        Me.TB_CP.Location = New System.Drawing.Point(24, 164)
        Me.TB_CP.Name = "TB_CP"
        Me.TB_CP.Size = New System.Drawing.Size(121, 20)
        Me.TB_CP.TabIndex = 83
        '
        'LB_CP
        '
        Me.LB_CP.AutoSize = True
        Me.LB_CP.Location = New System.Drawing.Point(23, 148)
        Me.LB_CP.Name = "LB_CP"
        Me.LB_CP.Size = New System.Drawing.Size(21, 13)
        Me.LB_CP.TabIndex = 105
        Me.LB_CP.Text = "CP"
        '
        'LB_CORREO
        '
        Me.LB_CORREO.AutoSize = True
        Me.LB_CORREO.Location = New System.Drawing.Point(257, 224)
        Me.LB_CORREO.Name = "LB_CORREO"
        Me.LB_CORREO.Size = New System.Drawing.Size(38, 13)
        Me.LB_CORREO.TabIndex = 104
        Me.LB_CORREO.Text = "Correo"
        '
        'LB_TELEFONO
        '
        Me.LB_TELEFONO.AutoSize = True
        Me.LB_TELEFONO.Location = New System.Drawing.Point(22, 224)
        Me.LB_TELEFONO.Name = "LB_TELEFONO"
        Me.LB_TELEFONO.Size = New System.Drawing.Size(49, 13)
        Me.LB_TELEFONO.TabIndex = 103
        Me.LB_TELEFONO.Text = "Teléfono"
        '
        'TB_PAIS
        '
        Me.TB_PAIS.Location = New System.Drawing.Point(1335, 164)
        Me.TB_PAIS.Name = "TB_PAIS"
        Me.TB_PAIS.Size = New System.Drawing.Size(256, 20)
        Me.TB_PAIS.TabIndex = 90
        '
        'LB_PAIS
        '
        Me.LB_PAIS.AutoSize = True
        Me.LB_PAIS.Location = New System.Drawing.Point(1332, 148)
        Me.LB_PAIS.Name = "LB_PAIS"
        Me.LB_PAIS.Size = New System.Drawing.Size(29, 13)
        Me.LB_PAIS.TabIndex = 102
        Me.LB_PAIS.Text = "País"
        '
        'TB_PROVINCIA
        '
        Me.TB_PROVINCIA.Location = New System.Drawing.Point(747, 164)
        Me.TB_PROVINCIA.Name = "TB_PROVINCIA"
        Me.TB_PROVINCIA.Size = New System.Drawing.Size(572, 20)
        Me.TB_PROVINCIA.TabIndex = 88
        '
        'TB_PISO
        '
        Me.TB_PISO.Location = New System.Drawing.Point(820, 98)
        Me.TB_PISO.Name = "TB_PISO"
        Me.TB_PISO.Size = New System.Drawing.Size(55, 20)
        Me.TB_PISO.TabIndex = 80
        '
        'LB_LETRA
        '
        Me.LB_LETRA.AutoSize = True
        Me.LB_LETRA.Location = New System.Drawing.Point(888, 81)
        Me.LB_LETRA.Name = "LB_LETRA"
        Me.LB_LETRA.Size = New System.Drawing.Size(31, 13)
        Me.LB_LETRA.TabIndex = 100
        Me.LB_LETRA.Text = "Letra"
        '
        'LB_NUMERO
        '
        Me.LB_NUMERO.AutoSize = True
        Me.LB_NUMERO.Location = New System.Drawing.Point(744, 81)
        Me.LB_NUMERO.Name = "LB_NUMERO"
        Me.LB_NUMERO.Size = New System.Drawing.Size(44, 13)
        Me.LB_NUMERO.TabIndex = 99
        Me.LB_NUMERO.Text = "Número"
        '
        'LB_PISO
        '
        Me.LB_PISO.AutoSize = True
        Me.LB_PISO.Location = New System.Drawing.Point(817, 81)
        Me.LB_PISO.Name = "LB_PISO"
        Me.LB_PISO.Size = New System.Drawing.Size(27, 13)
        Me.LB_PISO.TabIndex = 97
        Me.LB_PISO.Text = "Piso"
        '
        'LB_PROVINCIA
        '
        Me.LB_PROVINCIA.AutoSize = True
        Me.LB_PROVINCIA.Location = New System.Drawing.Point(744, 148)
        Me.LB_PROVINCIA.Name = "LB_PROVINCIA"
        Me.LB_PROVINCIA.Size = New System.Drawing.Size(51, 13)
        Me.LB_PROVINCIA.TabIndex = 95
        Me.LB_PROVINCIA.Text = "Provincia"
        '
        'TB_LETRA
        '
        Me.TB_LETRA.Location = New System.Drawing.Point(891, 98)
        Me.TB_LETRA.Name = "TB_LETRA"
        Me.TB_LETRA.Size = New System.Drawing.Size(55, 20)
        Me.TB_LETRA.TabIndex = 81
        '
        'TB_NUMERO_VIA
        '
        Me.TB_NUMERO_VIA.Location = New System.Drawing.Point(747, 98)
        Me.TB_NUMERO_VIA.Name = "TB_NUMERO_VIA"
        Me.TB_NUMERO_VIA.Size = New System.Drawing.Size(55, 20)
        Me.TB_NUMERO_VIA.TabIndex = 78
        '
        'CB_TIPO_VIA
        '
        Me.CB_TIPO_VIA.FormattingEnabled = True
        Me.CB_TIPO_VIA.Location = New System.Drawing.Point(24, 98)
        Me.CB_TIPO_VIA.Name = "CB_TIPO_VIA"
        Me.CB_TIPO_VIA.Size = New System.Drawing.Size(121, 21)
        Me.CB_TIPO_VIA.TabIndex = 76
        '
        'LB_LOCALIDAD
        '
        Me.LB_LOCALIDAD.AutoSize = True
        Me.LB_LOCALIDAD.Location = New System.Drawing.Point(159, 148)
        Me.LB_LOCALIDAD.Name = "LB_LOCALIDAD"
        Me.LB_LOCALIDAD.Size = New System.Drawing.Size(53, 13)
        Me.LB_LOCALIDAD.TabIndex = 89
        Me.LB_LOCALIDAD.Text = "Localidad"
        '
        'LB_DIRECCION
        '
        Me.LB_DIRECCION.AutoSize = True
        Me.LB_DIRECCION.Location = New System.Drawing.Point(22, 82)
        Me.LB_DIRECCION.Name = "LB_DIRECCION"
        Me.LB_DIRECCION.Size = New System.Drawing.Size(52, 13)
        Me.LB_DIRECCION.TabIndex = 86
        Me.LB_DIRECCION.Text = "Dirección"
        '
        'LB_CIF
        '
        Me.LB_CIF.AutoSize = True
        Me.LB_CIF.Location = New System.Drawing.Point(159, 12)
        Me.LB_CIF.Name = "LB_CIF"
        Me.LB_CIF.Size = New System.Drawing.Size(23, 13)
        Me.LB_CIF.TabIndex = 84
        Me.LB_CIF.Text = "CIF"
        '
        'LB_NOMBRE_COMERCIAL
        '
        Me.LB_NOMBRE_COMERCIAL.AutoSize = True
        Me.LB_NOMBRE_COMERCIAL.Location = New System.Drawing.Point(933, 12)
        Me.LB_NOMBRE_COMERCIAL.Name = "LB_NOMBRE_COMERCIAL"
        Me.LB_NOMBRE_COMERCIAL.Size = New System.Drawing.Size(93, 13)
        Me.LB_NOMBRE_COMERCIAL.TabIndex = 82
        Me.LB_NOMBRE_COMERCIAL.Text = "Nombre Comercial"
        '
        'LB_NOMBRE_FISCAL
        '
        Me.LB_NOMBRE_FISCAL.AutoSize = True
        Me.LB_NOMBRE_FISCAL.Location = New System.Drawing.Point(296, 12)
        Me.LB_NOMBRE_FISCAL.Name = "LB_NOMBRE_FISCAL"
        Me.LB_NOMBRE_FISCAL.Size = New System.Drawing.Size(74, 13)
        Me.LB_NOMBRE_FISCAL.TabIndex = 79
        Me.LB_NOMBRE_FISCAL.Text = "Nombre Fiscal"
        '
        'TB_NOMBRE_COMERCIAL
        '
        Me.TB_NOMBRE_COMERCIAL.Location = New System.Drawing.Point(936, 28)
        Me.TB_NOMBRE_COMERCIAL.Name = "TB_NOMBRE_COMERCIAL"
        Me.TB_NOMBRE_COMERCIAL.Size = New System.Drawing.Size(655, 20)
        Me.TB_NOMBRE_COMERCIAL.TabIndex = 75
        '
        'TB_CIF
        '
        Me.TB_CIF.Location = New System.Drawing.Point(162, 28)
        Me.TB_CIF.Name = "TB_CIF"
        Me.TB_CIF.Size = New System.Drawing.Size(121, 20)
        Me.TB_CIF.TabIndex = 73
        '
        'TB_NOMBRE_VIA
        '
        Me.TB_NOMBRE_VIA.Location = New System.Drawing.Point(162, 99)
        Me.TB_NOMBRE_VIA.Name = "TB_NOMBRE_VIA"
        Me.TB_NOMBRE_VIA.Size = New System.Drawing.Size(569, 20)
        Me.TB_NOMBRE_VIA.TabIndex = 77
        '
        'TB_LOCALIDAD
        '
        Me.TB_LOCALIDAD.Location = New System.Drawing.Point(162, 164)
        Me.TB_LOCALIDAD.Name = "TB_LOCALIDAD"
        Me.TB_LOCALIDAD.Size = New System.Drawing.Size(569, 20)
        Me.TB_LOCALIDAD.TabIndex = 85
        '
        'TB_NOMBRE_FISCAL
        '
        Me.TB_NOMBRE_FISCAL.Location = New System.Drawing.Point(299, 28)
        Me.TB_NOMBRE_FISCAL.Name = "TB_NOMBRE_FISCAL"
        Me.TB_NOMBRE_FISCAL.Size = New System.Drawing.Size(615, 20)
        Me.TB_NOMBRE_FISCAL.TabIndex = 74
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(744, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "Actividades"
        '
        'dgvActividades
        '
        Me.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActividades.Location = New System.Drawing.Point(747, 307)
        Me.dgvActividades.Name = "dgvActividades"
        Me.dgvActividades.Size = New System.Drawing.Size(853, 292)
        Me.dgvActividades.TabIndex = 110
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.Button2.Location = New System.Drawing.Point(747, 616)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(259, 49)
        Me.Button2.TabIndex = 111
        Me.Button2.Text = "NUEVA ACTIVIDAD"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(962, 54)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(629, 91)
        Me.TabControl1.TabIndex = 113
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(621, 65)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(621, 65)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTN_ALTA_GRUPO)
        Me.GroupBox2.Controls.Add(Me.tbSector)
        Me.GroupBox2.Controls.Add(Me.CB_GRUPO)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(615, 58)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'tbSector
        '
        Me.tbSector.Location = New System.Drawing.Point(296, 32)
        Me.tbSector.Name = "tbSector"
        Me.tbSector.Size = New System.Drawing.Size(313, 20)
        Me.tbSector.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(293, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Sector"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 13)
        Me.Label9.TabIndex = 115
        Me.Label9.Text = "ID"
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(25, 28)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(120, 20)
        Me.tbID.TabIndex = 114
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(1341, 616)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(259, 49)
        Me.btnBuscar.TabIndex = 116
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'AltaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1612, 677)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbID)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dgvActividades)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TB_WEB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
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
        Me.Controls.Add(Me.TB_LETRA)
        Me.Controls.Add(Me.TB_NUMERO_VIA)
        Me.Controls.Add(Me.CB_TIPO_VIA)
        Me.Controls.Add(Me.LB_LOCALIDAD)
        Me.Controls.Add(Me.LB_DIRECCION)
        Me.Controls.Add(Me.LB_CIF)
        Me.Controls.Add(Me.LB_NOMBRE_COMERCIAL)
        Me.Controls.Add(Me.LB_NOMBRE_FISCAL)
        Me.Controls.Add(Me.TB_NOMBRE_COMERCIAL)
        Me.Controls.Add(Me.TB_CIF)
        Me.Controls.Add(Me.TB_NOMBRE_VIA)
        Me.Controls.Add(Me.TB_LOCALIDAD)
        Me.Controls.Add(Me.TB_NOMBRE_FISCAL)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TB_Comentarios)
        Me.Name = "AltaCliente"
        Me.Text = "AltaCliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numFact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvActividades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TB_Comentarios As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BTN_ALTA_GRUPO As Button
    Friend WithEvents CB_GRUPO As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_WEB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TB_CORREO As TextBox
    Friend WithEvents TB_TLF As TextBox
    Friend WithEvents TB_CP As TextBox
    Friend WithEvents LB_CP As Label
    Friend WithEvents LB_CORREO As Label
    Friend WithEvents LB_TELEFONO As Label
    Friend WithEvents TB_PAIS As TextBox
    Friend WithEvents LB_PAIS As Label
    Friend WithEvents TB_PROVINCIA As TextBox
    Friend WithEvents TB_PISO As TextBox
    Friend WithEvents LB_LETRA As Label
    Friend WithEvents LB_NUMERO As Label
    Friend WithEvents LB_PISO As Label
    Friend WithEvents LB_PROVINCIA As Label
    Friend WithEvents TB_LETRA As TextBox
    Friend WithEvents TB_NUMERO_VIA As TextBox
    Friend WithEvents CB_TIPO_VIA As ComboBox
    Friend WithEvents LB_LOCALIDAD As Label
    Friend WithEvents LB_DIRECCION As Label
    Friend WithEvents LB_CIF As Label
    Friend WithEvents LB_NOMBRE_COMERCIAL As Label
    Friend WithEvents LB_NOMBRE_FISCAL As Label
    Friend WithEvents TB_NOMBRE_COMERCIAL As TextBox
    Friend WithEvents TB_CIF As TextBox
    Friend WithEvents TB_NOMBRE_VIA As TextBox
    Friend WithEvents TB_LOCALIDAD As TextBox
    Friend WithEvents TB_NOMBRE_FISCAL As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvActividades As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents cbOperador As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbSector As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents numFact As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbID As TextBox
    Friend WithEvents btnBuscar As Button
End Class
