<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambioTipoDocumento
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
        Me.btnSIMPLIFICADA = New System.Windows.Forms.Button()
        Me.btnINCOMPLETA = New System.Windows.Forms.Button()
        Me.btnCOMPLETA = New System.Windows.Forms.Button()
        Me.btnDECANJE = New System.Windows.Forms.Button()
        Me.btnNOFACTURA = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSIMPLIFICADA
        '
        Me.btnSIMPLIFICADA.Location = New System.Drawing.Point(12, 12)
        Me.btnSIMPLIFICADA.Name = "btnSIMPLIFICADA"
        Me.btnSIMPLIFICADA.Size = New System.Drawing.Size(142, 269)
        Me.btnSIMPLIFICADA.TabIndex = 0
        Me.btnSIMPLIFICADA.Text = "SIMPLIFICADA"
        Me.btnSIMPLIFICADA.UseVisualStyleBackColor = True
        '
        'btnINCOMPLETA
        '
        Me.btnINCOMPLETA.Location = New System.Drawing.Point(160, 12)
        Me.btnINCOMPLETA.Name = "btnINCOMPLETA"
        Me.btnINCOMPLETA.Size = New System.Drawing.Size(152, 269)
        Me.btnINCOMPLETA.TabIndex = 1
        Me.btnINCOMPLETA.Text = "INCOMPLETA"
        Me.btnINCOMPLETA.UseVisualStyleBackColor = True
        '
        'btnCOMPLETA
        '
        Me.btnCOMPLETA.Location = New System.Drawing.Point(318, 12)
        Me.btnCOMPLETA.Name = "btnCOMPLETA"
        Me.btnCOMPLETA.Size = New System.Drawing.Size(155, 269)
        Me.btnCOMPLETA.TabIndex = 2
        Me.btnCOMPLETA.Text = "COMPLETA"
        Me.btnCOMPLETA.UseVisualStyleBackColor = True
        '
        'btnDECANJE
        '
        Me.btnDECANJE.Location = New System.Drawing.Point(12, 287)
        Me.btnDECANJE.Name = "btnDECANJE"
        Me.btnDECANJE.Size = New System.Drawing.Size(220, 72)
        Me.btnDECANJE.TabIndex = 3
        Me.btnDECANJE.Text = "DE CANJE"
        Me.btnDECANJE.UseVisualStyleBackColor = True
        '
        'btnNOFACTURA
        '
        Me.btnNOFACTURA.Location = New System.Drawing.Point(238, 287)
        Me.btnNOFACTURA.Name = "btnNOFACTURA"
        Me.btnNOFACTURA.Size = New System.Drawing.Size(235, 72)
        Me.btnNOFACTURA.TabIndex = 4
        Me.btnNOFACTURA.Text = "NO FACTURA"
        Me.btnNOFACTURA.UseVisualStyleBackColor = True
        '
        'CambioTipoDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 371)
        Me.Controls.Add(Me.btnNOFACTURA)
        Me.Controls.Add(Me.btnDECANJE)
        Me.Controls.Add(Me.btnCOMPLETA)
        Me.Controls.Add(Me.btnINCOMPLETA)
        Me.Controls.Add(Me.btnSIMPLIFICADA)
        Me.Name = "CambioTipoDocumento"
        Me.Text = "CambioTipoDocumento"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSIMPLIFICADA As Button
    Friend WithEvents btnINCOMPLETA As Button
    Friend WithEvents btnCOMPLETA As Button
    Friend WithEvents btnDECANJE As Button
    Friend WithEvents btnNOFACTURA As Button
End Class
