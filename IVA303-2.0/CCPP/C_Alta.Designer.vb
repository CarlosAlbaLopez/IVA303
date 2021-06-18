<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnviosProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnviosProveedor))
        Me.TBEMPRESA = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBX_TIPOS_DOC = New System.Windows.Forms.ComboBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.CBX_CLIENTES = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBX_LOCALES = New System.Windows.Forms.ComboBox()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBEMPRESA
        '
        Me.TBEMPRESA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TBEMPRESA.Location = New System.Drawing.Point(503, 270)
        Me.TBEMPRESA.Name = "TBEMPRESA"
        Me.TBEMPRESA.Size = New System.Drawing.Size(296, 20)
        Me.TBEMPRESA.TabIndex = 57
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(577, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 33)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Proveedor"
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(922, -1)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(476, 660)
        Me.AxAcroPDF1.TabIndex = 55
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(410, 634)
        Me.DataGridView1.TabIndex = 54
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Location = New System.Drawing.Point(640, 623)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(54, 24)
        Me.Button3.TabIndex = 53
        Me.Button3.Text = "borrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(434, 423)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(473, 72)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "ACTUALIZAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.25!)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(435, 527)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(472, 72)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = "DAR DE ALTA"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(598, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 33)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Cliente"
        '
        'CBX_TIPOS_DOC
        '
        Me.CBX_TIPOS_DOC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.CBX_TIPOS_DOC.FormattingEnabled = True
        Me.CBX_TIPOS_DOC.Location = New System.Drawing.Point(503, 349)
        Me.CBX_TIPOS_DOC.Name = "CBX_TIPOS_DOC"
        Me.CBX_TIPOS_DOC.Size = New System.Drawing.Size(296, 21)
        Me.CBX_TIPOS_DOC.TabIndex = 41
        '
        'lblCliente
        '
        Me.lblCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(562, 303)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(179, 33)
        Me.lblCliente.TabIndex = 40
        Me.lblCliente.Text = "Tipo Factura"
        '
        'CBX_CLIENTES
        '
        Me.CBX_CLIENTES.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.CBX_CLIENTES.FormattingEnabled = True
        Me.CBX_CLIENTES.Location = New System.Drawing.Point(503, 110)
        Me.CBX_CLIENTES.Name = "CBX_CLIENTES"
        Me.CBX_CLIENTES.Size = New System.Drawing.Size(296, 21)
        Me.CBX_CLIENTES.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(609, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(85, 33)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Local"
        '
        'CBX_LOCALES
        '
        Me.CBX_LOCALES.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.CBX_LOCALES.FormattingEnabled = True
        Me.CBX_LOCALES.Location = New System.Drawing.Point(503, 190)
        Me.CBX_LOCALES.Name = "CBX_LOCALES"
        Me.CBX_LOCALES.Size = New System.Drawing.Size(296, 21)
        Me.CBX_LOCALES.TabIndex = 58
        '
        'C_Alta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1404, 659)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CBX_LOCALES)
        Me.Controls.Add(Me.TBEMPRESA)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBX_TIPOS_DOC)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.CBX_CLIENTES)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "C_Alta"
        Me.Text = "C_Alta"
        Me.TopMost = True
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBEMPRESA As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CBX_TIPOS_DOC As ComboBox
    Friend WithEvents lblCliente As Label
    Friend WithEvents CBX_CLIENTES As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CBX_LOCALES As ComboBox
End Class
