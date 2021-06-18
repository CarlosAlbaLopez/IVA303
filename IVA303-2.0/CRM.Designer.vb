<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRM
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
        Me.DGV_CRM = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AbrirFichaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.numLimit = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbOperador = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DGV_CRM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.numLimit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_CRM
        '
        Me.DGV_CRM.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_CRM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_CRM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_CRM.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DGV_CRM.Location = New System.Drawing.Point(0, 0)
        Me.DGV_CRM.Name = "DGV_CRM"
        Me.DGV_CRM.RowTemplate.Height = 30
        Me.DGV_CRM.Size = New System.Drawing.Size(1088, 585)
        Me.DGV_CRM.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirFichaToolStripMenuItem, Me.AltaClienteToolStripMenuItem, Me.ConsultaToolStripMenuItem, Me.ImportarExcelToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(150, 92)
        '
        'AbrirFichaToolStripMenuItem
        '
        Me.AbrirFichaToolStripMenuItem.Name = "AbrirFichaToolStripMenuItem"
        Me.AbrirFichaToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.AbrirFichaToolStripMenuItem.Text = "Abrir Ficha"
        '
        'AltaClienteToolStripMenuItem
        '
        Me.AltaClienteToolStripMenuItem.Name = "AltaClienteToolStripMenuItem"
        Me.AltaClienteToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.AltaClienteToolStripMenuItem.Text = "Alta Cliente"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ConsultaToolStripMenuItem.Text = "Filtrar"
        '
        'ImportarExcelToolStripMenuItem
        '
        Me.ImportarExcelToolStripMenuItem.Name = "ImportarExcelToolStripMenuItem"
        Me.ImportarExcelToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ImportarExcelToolStripMenuItem.Text = "Importar Excel"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1090, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(220, 30)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Buscar solo por nombre"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'numLimit
        '
        Me.numLimit.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numLimit.Location = New System.Drawing.Point(1092, 174)
        Me.numLimit.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numLimit.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numLimit.Name = "numLimit"
        Me.numLimit.Size = New System.Drawing.Size(112, 20)
        Me.numLimit.TabIndex = 2
        Me.numLimit.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1098, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Resultados"
        '
        'cbEstado
        '
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Location = New System.Drawing.Point(1092, 132)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(217, 21)
        Me.cbEstado.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1098, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Estado"
        '
        'cbOperador
        '
        Me.cbOperador.FormattingEnabled = True
        Me.cbOperador.Location = New System.Drawing.Point(1092, 90)
        Me.cbOperador.Name = "cbOperador"
        Me.cbOperador.Size = New System.Drawing.Size(217, 21)
        Me.cbOperador.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1098, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Operador"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(1091, 51)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(218, 20)
        Me.tbNombre.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1097, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nombre"
        '
        'CRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(1310, 585)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.numLimit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DGV_CRM)
        Me.Controls.Add(Me.cbEstado)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbOperador)
        Me.Name = "CRM"
        Me.Text = "CRM"
        CType(Me.DGV_CRM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.numLimit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_CRM As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AbrirFichaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportarExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PropertyGrid1 As PropertyGrid
    Friend WithEvents cbOperador As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents numLimit As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
End Class
