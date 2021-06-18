<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class C_Clientes
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
        Me.CLIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)

        Me.BTN_EXPORTAR_DATOS = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CLIENTESBindingSource
        '
        Me.CLIENTESBindingSource.DataMember = "CLIENTES"

        '
        'Iva303DataSet10
        '

        '
        'CLIENTESTableAdapter
        '

        '
        'BTN_EXPORTAR_DATOS
        '
        Me.BTN_EXPORTAR_DATOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.BTN_EXPORTAR_DATOS.Location = New System.Drawing.Point(12, 736)
        Me.BTN_EXPORTAR_DATOS.Name = "BTN_EXPORTAR_DATOS"
        Me.BTN_EXPORTAR_DATOS.Size = New System.Drawing.Size(191, 41)
        Me.BTN_EXPORTAR_DATOS.TabIndex = 4
        Me.BTN_EXPORTAR_DATOS.Text = "EXPORTAR DATOS"
        Me.BTN_EXPORTAR_DATOS.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1272, 681)
        Me.DataGridView1.TabIndex = 3
        '
        'C_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1297, 789)
        Me.Controls.Add(Me.BTN_EXPORTAR_DATOS)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "C_Clientes"
        Me.Text = "C_Clientes"
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CLIENTESBindingSource As BindingSource

    Friend WithEvents BTN_EXPORTAR_DATOS As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
