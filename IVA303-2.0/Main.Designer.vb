<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Alta = New System.Windows.Forms.ToolStripMenuItem()
        Me.Análisis = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEmpresas = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CRMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MailingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Alta, Me.Análisis, Me.btnEmpresas, Me.ClientesToolStripMenuItem, Me.CRMToolStripMenuItem, Me.MailingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Alta
        '
        Me.Alta.AutoToolTip = True
        Me.Alta.Name = "Alta"
        Me.Alta.Size = New System.Drawing.Size(40, 20)
        Me.Alta.Text = "Alta"
        '
        'Análisis
        '
        Me.Análisis.Name = "Análisis"
        Me.Análisis.Size = New System.Drawing.Size(59, 20)
        Me.Análisis.Text = "Análisis"
        '
        'btnEmpresas
        '
        Me.btnEmpresas.Name = "btnEmpresas"
        Me.btnEmpresas.Size = New System.Drawing.Size(69, 20)
        Me.btnEmpresas.Text = "Empresas"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'CRMToolStripMenuItem
        '
        Me.CRMToolStripMenuItem.Name = "CRMToolStripMenuItem"
        Me.CRMToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.CRMToolStripMenuItem.Text = "CRM"
        '
        'MailingToolStripMenuItem
        '
        Me.MailingToolStripMenuItem.Name = "MailingToolStripMenuItem"
        Me.MailingToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.MailingToolStripMenuItem.Text = "Mailing"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BackgroundImage = Global.IVA303_2._0.My.Resources.Resources.dddd
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Alta As ToolStripMenuItem
    Friend WithEvents Análisis As ToolStripMenuItem
    Friend WithEvents btnEmpresas As ToolStripMenuItem
    Friend WithEvents CRMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MailingToolStripMenuItem As ToolStripMenuItem
End Class
