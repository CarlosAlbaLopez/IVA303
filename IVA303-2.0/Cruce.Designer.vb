<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cruce
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cruce))
        Me.DGV_CRUCE = New System.Windows.Forms.DataGridView()
        Me.BTN_CRUCE = New System.Windows.Forms.Button()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        CType(Me.DGV_CRUCE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_CRUCE
        '
        Me.DGV_CRUCE.AllowUserToAddRows = False
        Me.DGV_CRUCE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_CRUCE.Location = New System.Drawing.Point(13, 13)
        Me.DGV_CRUCE.Name = "DGV_CRUCE"
        Me.DGV_CRUCE.Size = New System.Drawing.Size(396, 388)
        Me.DGV_CRUCE.TabIndex = 0
        '
        'BTN_CRUCE
        '
        Me.BTN_CRUCE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_CRUCE.Location = New System.Drawing.Point(13, 408)
        Me.BTN_CRUCE.Name = "BTN_CRUCE"
        Me.BTN_CRUCE.Size = New System.Drawing.Size(396, 30)
        Me.BTN_CRUCE.TabIndex = 1
        Me.BTN_CRUCE.Text = "CRUZAR"
        Me.BTN_CRUCE.UseVisualStyleBackColor = True
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Dock = System.Windows.Forms.DockStyle.Right
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(416, 0)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(384, 450)
        Me.AxAcroPDF1.TabIndex = 2
        '
        'Cruce
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.Controls.Add(Me.BTN_CRUCE)
        Me.Controls.Add(Me.DGV_CRUCE)
        Me.Name = "Cruce"
        Me.Text = "Clase"
        Me.TopMost = True
        CType(Me.DGV_CRUCE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV_CRUCE As DataGridView
    Friend WithEvents BTN_CRUCE As Button
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
End Class
