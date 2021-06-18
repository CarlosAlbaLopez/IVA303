<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class C_AltaAdministrador
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
        Me.components = New System.ComponentModel.Container()
        Me.TB_WEB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_ALTA_EMPRESA = New System.Windows.Forms.Button()
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
        Me.TB_CIF = New System.Windows.Forms.TextBox()
        Me.TB_NOMBRE_VIA = New System.Windows.Forms.TextBox()
        Me.TB_LOCALIDAD = New System.Windows.Forms.TextBox()

        Me.TIPOSEMPRESASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TB_NOMBRE_COMERCIAL = New System.Windows.Forms.TextBox()
        Me.TB_NOMBRE_FISCAL = New System.Windows.Forms.TextBox()
        CType(Me.TIPOSEMPRESASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TB_WEB
        '
        Me.TB_WEB.Location = New System.Drawing.Point(463, 391)
        Me.TB_WEB.Name = "TB_WEB"
        Me.TB_WEB.Size = New System.Drawing.Size(766, 20)
        Me.TB_WEB.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(419, 394)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Web"
        '
        'BTN_ALTA_EMPRESA
        '
        Me.BTN_ALTA_EMPRESA.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ALTA_EMPRESA.Location = New System.Drawing.Point(54, 375)
        Me.BTN_ALTA_EMPRESA.Name = "BTN_ALTA_EMPRESA"
        Me.BTN_ALTA_EMPRESA.Size = New System.Drawing.Size(359, 46)
        Me.BTN_ALTA_EMPRESA.TabIndex = 65
        Me.BTN_ALTA_EMPRESA.Text = "ALTA ADMINISTRADOR"
        Me.BTN_ALTA_EMPRESA.UseVisualStyleBackColor = True
        '
        'TB_CORREO
        '
        Me.TB_CORREO.Location = New System.Drawing.Point(463, 333)
        Me.TB_CORREO.Name = "TB_CORREO"
        Me.TB_CORREO.Size = New System.Drawing.Size(766, 20)
        Me.TB_CORREO.TabIndex = 64
        '
        'TB_TLF
        '
        Me.TB_TLF.Location = New System.Drawing.Point(112, 331)
        Me.TB_TLF.Name = "TB_TLF"
        Me.TB_TLF.Size = New System.Drawing.Size(212, 20)
        Me.TB_TLF.TabIndex = 63
        '
        'TB_CP
        '
        Me.TB_CP.Location = New System.Drawing.Point(463, 274)
        Me.TB_CP.Name = "TB_CP"
        Me.TB_CP.Size = New System.Drawing.Size(116, 20)
        Me.TB_CP.TabIndex = 62
        '
        'LB_CP
        '
        Me.LB_CP.AutoSize = True
        Me.LB_CP.Location = New System.Drawing.Point(419, 278)
        Me.LB_CP.Name = "LB_CP"
        Me.LB_CP.Size = New System.Drawing.Size(21, 13)
        Me.LB_CP.TabIndex = 61
        Me.LB_CP.Text = "CP"
        '
        'LB_CORREO
        '
        Me.LB_CORREO.AutoSize = True
        Me.LB_CORREO.Location = New System.Drawing.Point(419, 336)
        Me.LB_CORREO.Name = "LB_CORREO"
        Me.LB_CORREO.Size = New System.Drawing.Size(38, 13)
        Me.LB_CORREO.TabIndex = 60
        Me.LB_CORREO.Text = "Correo"
        '
        'LB_TELEFONO
        '
        Me.LB_TELEFONO.AutoSize = True
        Me.LB_TELEFONO.Location = New System.Drawing.Point(51, 336)
        Me.LB_TELEFONO.Name = "LB_TELEFONO"
        Me.LB_TELEFONO.Size = New System.Drawing.Size(49, 13)
        Me.LB_TELEFONO.TabIndex = 59
        Me.LB_TELEFONO.Text = "Teléfono"
        '
        'TB_PAIS
        '
        Me.TB_PAIS.Location = New System.Drawing.Point(112, 273)
        Me.TB_PAIS.Name = "TB_PAIS"
        Me.TB_PAIS.Size = New System.Drawing.Size(212, 20)
        Me.TB_PAIS.TabIndex = 58
        '
        'LB_PAIS
        '
        Me.LB_PAIS.AutoSize = True
        Me.LB_PAIS.Location = New System.Drawing.Point(51, 277)
        Me.LB_PAIS.Name = "LB_PAIS"
        Me.LB_PAIS.Size = New System.Drawing.Size(29, 13)
        Me.LB_PAIS.TabIndex = 57
        Me.LB_PAIS.Text = "País"
        '
        'TB_PROVINCIA
        '
        Me.TB_PROVINCIA.Location = New System.Drawing.Point(778, 215)
        Me.TB_PROVINCIA.Name = "TB_PROVINCIA"
        Me.TB_PROVINCIA.Size = New System.Drawing.Size(451, 20)
        Me.TB_PROVINCIA.TabIndex = 56
        '
        'TB_PISO
        '
        Me.TB_PISO.Location = New System.Drawing.Point(1039, 156)
        Me.TB_PISO.Name = "TB_PISO"
        Me.TB_PISO.Size = New System.Drawing.Size(55, 20)
        Me.TB_PISO.TabIndex = 55
        '
        'LB_LETRA
        '
        Me.LB_LETRA.AutoSize = True
        Me.LB_LETRA.Location = New System.Drawing.Point(1138, 158)
        Me.LB_LETRA.Name = "LB_LETRA"
        Me.LB_LETRA.Size = New System.Drawing.Size(31, 13)
        Me.LB_LETRA.TabIndex = 54
        Me.LB_LETRA.Text = "Letra"
        '
        'LB_NUMERO
        '
        Me.LB_NUMERO.AutoSize = True
        Me.LB_NUMERO.Location = New System.Drawing.Point(859, 158)
        Me.LB_NUMERO.Name = "LB_NUMERO"
        Me.LB_NUMERO.Size = New System.Drawing.Size(44, 13)
        Me.LB_NUMERO.TabIndex = 53
        Me.LB_NUMERO.Text = "Número"
        '
        'LB_PISO
        '
        Me.LB_PISO.AutoSize = True
        Me.LB_PISO.Location = New System.Drawing.Point(1007, 159)
        Me.LB_PISO.Name = "LB_PISO"
        Me.LB_PISO.Size = New System.Drawing.Size(27, 13)
        Me.LB_PISO.TabIndex = 52
        Me.LB_PISO.Text = "Piso"
        '
        'LB_PROVINCIA
        '
        Me.LB_PROVINCIA.AutoSize = True
        Me.LB_PROVINCIA.Location = New System.Drawing.Point(721, 218)
        Me.LB_PROVINCIA.Name = "LB_PROVINCIA"
        Me.LB_PROVINCIA.Size = New System.Drawing.Size(51, 13)
        Me.LB_PROVINCIA.TabIndex = 51
        Me.LB_PROVINCIA.Text = "Provincia"
        '
        'TB_LETRA
        '
        Me.TB_LETRA.Location = New System.Drawing.Point(1174, 156)
        Me.TB_LETRA.Name = "TB_LETRA"
        Me.TB_LETRA.Size = New System.Drawing.Size(55, 20)
        Me.TB_LETRA.TabIndex = 49
        '
        'TB_NUMERO_VIA
        '
        Me.TB_NUMERO_VIA.Location = New System.Drawing.Point(904, 155)
        Me.TB_NUMERO_VIA.Name = "TB_NUMERO_VIA"
        Me.TB_NUMERO_VIA.Size = New System.Drawing.Size(55, 20)
        Me.TB_NUMERO_VIA.TabIndex = 48
        '
        'CB_TIPO_VIA
        '
        Me.CB_TIPO_VIA.FormattingEnabled = True
        Me.CB_TIPO_VIA.Location = New System.Drawing.Point(112, 155)
        Me.CB_TIPO_VIA.Name = "CB_TIPO_VIA"
        Me.CB_TIPO_VIA.Size = New System.Drawing.Size(121, 21)
        Me.CB_TIPO_VIA.TabIndex = 47
        '
        'LB_LOCALIDAD
        '
        Me.LB_LOCALIDAD.AutoSize = True
        Me.LB_LOCALIDAD.Location = New System.Drawing.Point(50, 218)
        Me.LB_LOCALIDAD.Name = "LB_LOCALIDAD"
        Me.LB_LOCALIDAD.Size = New System.Drawing.Size(53, 13)
        Me.LB_LOCALIDAD.TabIndex = 46
        Me.LB_LOCALIDAD.Text = "Localidad"
        '
        'LB_DIRECCION
        '
        Me.LB_DIRECCION.AutoSize = True
        Me.LB_DIRECCION.Location = New System.Drawing.Point(51, 158)
        Me.LB_DIRECCION.Name = "LB_DIRECCION"
        Me.LB_DIRECCION.Size = New System.Drawing.Size(52, 13)
        Me.LB_DIRECCION.TabIndex = 44
        Me.LB_DIRECCION.Text = "Dirección"
        '
        'LB_CIF
        '
        Me.LB_CIF.AutoSize = True
        Me.LB_CIF.Location = New System.Drawing.Point(83, 15)
        Me.LB_CIF.Name = "LB_CIF"
        Me.LB_CIF.Size = New System.Drawing.Size(23, 13)
        Me.LB_CIF.TabIndex = 43
        Me.LB_CIF.Text = "CIF"
        '
        'LB_NOMBRE_COMERCIAL
        '
        Me.LB_NOMBRE_COMERCIAL.AutoSize = True
        Me.LB_NOMBRE_COMERCIAL.Location = New System.Drawing.Point(13, 106)
        Me.LB_NOMBRE_COMERCIAL.Name = "LB_NOMBRE_COMERCIAL"
        Me.LB_NOMBRE_COMERCIAL.Size = New System.Drawing.Size(93, 13)
        Me.LB_NOMBRE_COMERCIAL.TabIndex = 42
        Me.LB_NOMBRE_COMERCIAL.Text = "Nombre Comercial"
        '
        'LB_NOMBRE_FISCAL
        '
        Me.LB_NOMBRE_FISCAL.AutoSize = True
        Me.LB_NOMBRE_FISCAL.Location = New System.Drawing.Point(32, 57)
        Me.LB_NOMBRE_FISCAL.Name = "LB_NOMBRE_FISCAL"
        Me.LB_NOMBRE_FISCAL.Size = New System.Drawing.Size(74, 13)
        Me.LB_NOMBRE_FISCAL.TabIndex = 41
        Me.LB_NOMBRE_FISCAL.Text = "Nombre Fiscal"
        '
        'TB_CIF
        '
        Me.TB_CIF.Location = New System.Drawing.Point(112, 12)
        Me.TB_CIF.Name = "TB_CIF"
        Me.TB_CIF.Size = New System.Drawing.Size(121, 20)
        Me.TB_CIF.TabIndex = 39
        '
        'TB_NOMBRE_VIA
        '
        Me.TB_NOMBRE_VIA.Location = New System.Drawing.Point(239, 155)
        Me.TB_NOMBRE_VIA.Name = "TB_NOMBRE_VIA"
        Me.TB_NOMBRE_VIA.Size = New System.Drawing.Size(569, 20)
        Me.TB_NOMBRE_VIA.TabIndex = 38
        '
        'TB_LOCALIDAD
        '
        Me.TB_LOCALIDAD.Location = New System.Drawing.Point(112, 215)
        Me.TB_LOCALIDAD.Name = "TB_LOCALIDAD"
        Me.TB_LOCALIDAD.Size = New System.Drawing.Size(554, 20)
        Me.TB_LOCALIDAD.TabIndex = 37
        '
        'TIPOS_EMPRESASTableAdapter
        '
        '
        'Iva303DataSet4
        '
        '
        'TIPOSEMPRESASBindingSource
        '
        Me.TIPOSEMPRESASBindingSource.DataMember = "TIPOS_EMPRESAS"
        '
        'TB_NOMBRE_COMERCIAL
        '
        Me.TB_NOMBRE_COMERCIAL.Location = New System.Drawing.Point(112, 103)
        Me.TB_NOMBRE_COMERCIAL.Name = "TB_NOMBRE_COMERCIAL"
        Me.TB_NOMBRE_COMERCIAL.Size = New System.Drawing.Size(659, 20)
        Me.TB_NOMBRE_COMERCIAL.TabIndex = 40
        '
        'TB_NOMBRE_FISCAL
        '
        Me.TB_NOMBRE_FISCAL.Location = New System.Drawing.Point(112, 54)
        Me.TB_NOMBRE_FISCAL.Name = "TB_NOMBRE_FISCAL"
        Me.TB_NOMBRE_FISCAL.Size = New System.Drawing.Size(659, 20)
        Me.TB_NOMBRE_FISCAL.TabIndex = 36
        '
        'C_AltaAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 450)
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
        Me.Controls.Add(Me.TB_LETRA)
        Me.Controls.Add(Me.TB_NUMERO_VIA)
        Me.Controls.Add(Me.CB_TIPO_VIA)
        Me.Controls.Add(Me.LB_LOCALIDAD)
        Me.Controls.Add(Me.LB_DIRECCION)
        Me.Controls.Add(Me.LB_CIF)
        Me.Controls.Add(Me.LB_NOMBRE_COMERCIAL)
        Me.Controls.Add(Me.LB_NOMBRE_FISCAL)
        Me.Controls.Add(Me.TB_CIF)
        Me.Controls.Add(Me.TB_NOMBRE_VIA)
        Me.Controls.Add(Me.TB_LOCALIDAD)
        Me.Controls.Add(Me.TB_NOMBRE_COMERCIAL)
        Me.Controls.Add(Me.TB_NOMBRE_FISCAL)
        Me.Name = "C_AltaAdministrador"
        Me.Text = "C_AltaAdministrador"
        CType(Me.TIPOSEMPRESASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TB_WEB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BTN_ALTA_EMPRESA As Button
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
    Friend WithEvents TB_CIF As TextBox
    Friend WithEvents TB_NOMBRE_VIA As TextBox
    Friend WithEvents TB_LOCALIDAD As TextBox

    Friend WithEvents TIPOSEMPRESASBindingSource As BindingSource
    Friend WithEvents TB_NOMBRE_COMERCIAL As TextBox
    Friend WithEvents TB_NOMBRE_FISCAL As TextBox
End Class
