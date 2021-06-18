<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Certificacion3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Certificacion3))
        Me.DGV_Tickets = New System.Windows.Forms.DataGridView()
        Me.CB_TipoDoc = New System.Windows.Forms.ComboBox()
        Me.CB_EstadoDoc = New System.Windows.Forms.ComboBox()
        Me.BTN_Buscar = New System.Windows.Forms.Button()
        Me.TB_id = New System.Windows.Forms.TextBox()
        Me.BTN_Cambiar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DGV_Tickets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_Tickets
        '
        Me.DGV_Tickets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_Tickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.DGV_Tickets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_Tickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Tickets.Location = New System.Drawing.Point(12, 33)
        Me.DGV_Tickets.Name = "DGV_Tickets"
        Me.DGV_Tickets.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Tickets.RowTemplate.Height = 12
        Me.DGV_Tickets.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Tickets.Size = New System.Drawing.Size(568, 663)
        Me.DGV_Tickets.TabIndex = 5
        '
        'CB_TipoDoc
        '
        Me.CB_TipoDoc.FormattingEnabled = True
        Me.CB_TipoDoc.Location = New System.Drawing.Point(119, 7)
        Me.CB_TipoDoc.Name = "CB_TipoDoc"
        Me.CB_TipoDoc.Size = New System.Drawing.Size(121, 21)
        Me.CB_TipoDoc.TabIndex = 7
        '
        'CB_EstadoDoc
        '
        Me.CB_EstadoDoc.FormattingEnabled = True
        Me.CB_EstadoDoc.Location = New System.Drawing.Point(246, 6)
        Me.CB_EstadoDoc.Name = "CB_EstadoDoc"
        Me.CB_EstadoDoc.Size = New System.Drawing.Size(121, 21)
        Me.CB_EstadoDoc.TabIndex = 8
        '
        'BTN_Buscar
        '
        Me.BTN_Buscar.Location = New System.Drawing.Point(373, 5)
        Me.BTN_Buscar.Name = "BTN_Buscar"
        Me.BTN_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Buscar.TabIndex = 9
        Me.BTN_Buscar.Text = "Buscar"
        Me.BTN_Buscar.UseVisualStyleBackColor = True
        '
        'TB_id
        '
        Me.TB_id.Location = New System.Drawing.Point(13, 7)
        Me.TB_id.Name = "TB_id"
        Me.TB_id.Size = New System.Drawing.Size(100, 20)
        Me.TB_id.TabIndex = 10
        '
        'BTN_Cambiar
        '
        Me.BTN_Cambiar.Location = New System.Drawing.Point(454, 5)
        Me.BTN_Cambiar.Name = "BTN_Cambiar"
        Me.BTN_Cambiar.Size = New System.Drawing.Size(126, 23)
        Me.BTN_Cambiar.TabIndex = 12
        Me.BTN_Cambiar.Text = "Cambiar Tipo Documento"
        Me.BTN_Cambiar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.AxAcroPDF1)
        Me.Panel1.Location = New System.Drawing.Point(603, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(643, 696)
        Me.Panel1.TabIndex = 13
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(6, 0)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(637, 696)
        Me.AxAcroPDF1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Location = New System.Drawing.Point(573, -12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(698, 753)
        Me.Panel2.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Location = New System.Drawing.Point(0, -12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(580, 766)
        Me.Panel3.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(13, 714)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(227, 28)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Procesar Lista"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Certificacion3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1270, 742)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTN_Cambiar)
        Me.Controls.Add(Me.TB_id)
        Me.Controls.Add(Me.BTN_Buscar)
        Me.Controls.Add(Me.CB_EstadoDoc)
        Me.Controls.Add(Me.CB_TipoDoc)
        Me.Controls.Add(Me.DGV_Tickets)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Certificacion3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Certificacion3"
        Me.TopMost = True
        CType(Me.DGV_Tickets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV_Tickets As DataGridView
    Friend WithEvents CB_TipoDoc As ComboBox
    Friend WithEvents CB_EstadoDoc As ComboBox
    Friend WithEvents BTN_Buscar As Button
    Friend WithEvents TB_id As TextBox
    Friend WithEvents BTN_Cambiar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
End Class
