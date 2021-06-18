<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambiarTipoDoc
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
        Me.btn_simplificada = New System.Windows.Forms.Button()
        Me.btn_incompleta = New System.Windows.Forms.Button()
        Me.btn_completa = New System.Windows.Forms.Button()
        Me.btn_canje = New System.Windows.Forms.Button()
        Me.btn_noFactura = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_simplificada
        '
        Me.btn_simplificada.Location = New System.Drawing.Point(12, 12)
        Me.btn_simplificada.Name = "btn_simplificada"
        Me.btn_simplificada.Size = New System.Drawing.Size(110, 238)
        Me.btn_simplificada.TabIndex = 0
        Me.btn_simplificada.Text = "SIMPLIFICADA"
        Me.btn_simplificada.UseVisualStyleBackColor = True
        '
        'btn_incompleta
        '
        Me.btn_incompleta.Location = New System.Drawing.Point(128, 12)
        Me.btn_incompleta.Name = "btn_incompleta"
        Me.btn_incompleta.Size = New System.Drawing.Size(115, 238)
        Me.btn_incompleta.TabIndex = 1
        Me.btn_incompleta.Text = "INCOMPLETA"
        Me.btn_incompleta.UseVisualStyleBackColor = True
        '
        'btn_completa
        '
        Me.btn_completa.Location = New System.Drawing.Point(249, 12)
        Me.btn_completa.Name = "btn_completa"
        Me.btn_completa.Size = New System.Drawing.Size(103, 238)
        Me.btn_completa.TabIndex = 2
        Me.btn_completa.Text = "COMPLETA"
        Me.btn_completa.UseVisualStyleBackColor = True
        '
        'btn_canje
        '
        Me.btn_canje.Location = New System.Drawing.Point(12, 256)
        Me.btn_canje.Name = "btn_canje"
        Me.btn_canje.Size = New System.Drawing.Size(162, 90)
        Me.btn_canje.TabIndex = 3
        Me.btn_canje.Text = "DE CANJE"
        Me.btn_canje.UseVisualStyleBackColor = True
        '
        'btn_noFactura
        '
        Me.btn_noFactura.Location = New System.Drawing.Point(180, 256)
        Me.btn_noFactura.Name = "btn_noFactura"
        Me.btn_noFactura.Size = New System.Drawing.Size(172, 90)
        Me.btn_noFactura.TabIndex = 4
        Me.btn_noFactura.Text = "NO FACTURA"
        Me.btn_noFactura.UseVisualStyleBackColor = True
        '
        'CambiarTipoDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 358)
        Me.Controls.Add(Me.btn_noFactura)
        Me.Controls.Add(Me.btn_canje)
        Me.Controls.Add(Me.btn_completa)
        Me.Controls.Add(Me.btn_incompleta)
        Me.Controls.Add(Me.btn_simplificada)
        Me.Name = "CambiarTipoDoc"
        Me.Text = "CambiarTipoDoc"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_simplificada As Button
    Friend WithEvents btn_incompleta As Button
    Friend WithEvents btn_completa As Button
    Friend WithEvents btn_canje As Button
    Friend WithEvents btn_noFactura As Button
End Class
