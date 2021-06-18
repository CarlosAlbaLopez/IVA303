<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empresas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empresas))
        Me.BTN_LLAMAR = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DGV_Empresas = New System.Windows.Forms.DataGridView()
        Me.CB_cliente = New System.Windows.Forms.ComboBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.btn_Filtro_Cliente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_Estado = New System.Windows.Forms.ComboBox()
        Me.btn_Filtro_Estado = New System.Windows.Forms.Button()
        Me.BTN_FILTRO_DOBLE = New System.Windows.Forms.Button()
        Me.btnGenera = New System.Windows.Forms.Button()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbCIF = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbComercial = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbFiscal = New System.Windows.Forms.TextBox()
        CType(Me.DGV_Empresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_LLAMAR
        '
        Me.BTN_LLAMAR.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_LLAMAR.Location = New System.Drawing.Point(1131, 504)
        Me.BTN_LLAMAR.Name = "BTN_LLAMAR"
        Me.BTN_LLAMAR.Size = New System.Drawing.Size(178, 39)
        Me.BTN_LLAMAR.TabIndex = 3
        Me.BTN_LLAMAR.Text = "Abrir Ficha"
        Me.BTN_LLAMAR.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1131, 545)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(178, 39)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Revisar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DGV_Empresas
        '
        Me.DGV_Empresas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_Empresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Empresas.Location = New System.Drawing.Point(0, 0)
        Me.DGV_Empresas.Name = "DGV_Empresas"
        Me.DGV_Empresas.RowTemplate.Height = 30
        Me.DGV_Empresas.Size = New System.Drawing.Size(1125, 584)
        Me.DGV_Empresas.TabIndex = 0
        '
        'CB_cliente
        '
        Me.CB_cliente.FormattingEnabled = True
        Me.CB_cliente.Location = New System.Drawing.Point(1130, 305)
        Me.CB_cliente.Name = "CB_cliente"
        Me.CB_cliente.Size = New System.Drawing.Size(178, 21)
        Me.CB_cliente.TabIndex = 4
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(1128, 289)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(39, 13)
        Me.lblCliente.TabIndex = 5
        Me.lblCliente.Text = "Cliente"
        '
        'btn_Filtro_Cliente
        '
        Me.btn_Filtro_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_Filtro_Cliente.Location = New System.Drawing.Point(1130, 332)
        Me.btn_Filtro_Cliente.Name = "btn_Filtro_Cliente"
        Me.btn_Filtro_Cliente.Size = New System.Drawing.Size(75, 22)
        Me.btn_Filtro_Cliente.TabIndex = 6
        Me.btn_Filtro_Cliente.Text = "Filtrar"
        Me.btn_Filtro_Cliente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1127, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Estado"
        '
        'cb_Estado
        '
        Me.cb_Estado.FormattingEnabled = True
        Me.cb_Estado.Location = New System.Drawing.Point(1130, 226)
        Me.cb_Estado.Name = "cb_Estado"
        Me.cb_Estado.Size = New System.Drawing.Size(178, 21)
        Me.cb_Estado.TabIndex = 8
        '
        'btn_Filtro_Estado
        '
        Me.btn_Filtro_Estado.Location = New System.Drawing.Point(1130, 253)
        Me.btn_Filtro_Estado.Name = "btn_Filtro_Estado"
        Me.btn_Filtro_Estado.Size = New System.Drawing.Size(75, 22)
        Me.btn_Filtro_Estado.TabIndex = 10
        Me.btn_Filtro_Estado.Text = "Filtrar"
        Me.btn_Filtro_Estado.UseVisualStyleBackColor = True
        '
        'BTN_FILTRO_DOBLE
        '
        Me.BTN_FILTRO_DOBLE.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.BTN_FILTRO_DOBLE.Location = New System.Drawing.Point(1130, 369)
        Me.BTN_FILTRO_DOBLE.Name = "BTN_FILTRO_DOBLE"
        Me.BTN_FILTRO_DOBLE.Size = New System.Drawing.Size(178, 39)
        Me.BTN_FILTRO_DOBLE.TabIndex = 11
        Me.BTN_FILTRO_DOBLE.Text = "Filtro Doble"
        Me.BTN_FILTRO_DOBLE.UseVisualStyleBackColor = True
        '
        'btnGenera
        '
        Me.btnGenera.BackgroundImage = Global.IVA303_2._0.My.Resources.Resources.DOCUM
        Me.btnGenera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGenera.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnGenera.Location = New System.Drawing.Point(1193, 459)
        Me.btnGenera.Name = "btnGenera"
        Me.btnGenera.Size = New System.Drawing.Size(53, 39)
        Me.btnGenera.TabIndex = 7
        Me.btnGenera.UseVisualStyleBackColor = True
        '
        'tbTelefono
        '
        Me.tbTelefono.Location = New System.Drawing.Point(1130, 25)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(178, 20)
        Me.tbTelefono.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1127, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Teléfono"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.Button1.Location = New System.Drawing.Point(1130, 414)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 39)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Pendiente Revisión"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1128, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "CIF"
        '
        'tbCIF
        '
        Me.tbCIF.Location = New System.Drawing.Point(1130, 73)
        Me.tbCIF.Name = "tbCIF"
        Me.tbCIF.Size = New System.Drawing.Size(178, 20)
        Me.tbCIF.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1127, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Nombre Comercial"
        '
        'tbComercial
        '
        Me.tbComercial.Location = New System.Drawing.Point(1130, 123)
        Me.tbComercial.Name = "tbComercial"
        Me.tbComercial.Size = New System.Drawing.Size(178, 20)
        Me.tbComercial.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1127, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Nombre Fiscal"
        '
        'tbFiscal
        '
        Me.tbFiscal.Location = New System.Drawing.Point(1130, 175)
        Me.tbFiscal.Name = "tbFiscal"
        Me.tbFiscal.Size = New System.Drawing.Size(178, 20)
        Me.tbFiscal.TabIndex = 19
        '
        'Empresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(1310, 585)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbFiscal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbComercial)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbCIF)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbTelefono)
        Me.Controls.Add(Me.btn_Filtro_Estado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_Estado)
        Me.Controls.Add(Me.btnGenera)
        Me.Controls.Add(Me.btn_Filtro_Cliente)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.CB_cliente)
        Me.Controls.Add(Me.BTN_LLAMAR)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DGV_Empresas)
        Me.Controls.Add(Me.BTN_FILTRO_DOBLE)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Empresas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empresas"
        CType(Me.DGV_Empresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents BTN_LLAMAR As Button
    Friend WithEvents DGV_Empresas As DataGridView
    Friend WithEvents CB_cliente As ComboBox
    Friend WithEvents lblCliente As Label
    Friend WithEvents btn_Filtro_Cliente As Button
    Friend WithEvents btnGenera As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_Estado As ComboBox
    Friend WithEvents btn_Filtro_Estado As Button
    Friend WithEvents BTN_FILTRO_DOBLE As Button
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tbCIF As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbComercial As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbFiscal As TextBox
End Class
