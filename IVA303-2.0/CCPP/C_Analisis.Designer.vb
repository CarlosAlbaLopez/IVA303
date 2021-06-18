<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class C_Analisis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(C_Analisis))
        Me.TBRECONOCIMIENTOCIF = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.BTNREFRESCAR = New System.Windows.Forms.Button()
        Me.TB_SUMA_TOTAL = New System.Windows.Forms.TextBox()
        Me.TB_SUMA_IVA = New System.Windows.Forms.TextBox()
        Me.TB_SUMA_BASE = New System.Windows.Forms.TextBox()
        Me.BTN_CALCULAR = New System.Windows.Forms.Button()
        Me.DGV_LINEAS_IVA = New System.Windows.Forms.DataGridView()
        Me.IMPORTEBASE = New System.Windows.Forms.CheckBox()
        Me.BTN_UPDATE = New System.Windows.Forms.Button()
        Me.TBIMPORTE = New System.Windows.Forms.TextBox()
        Me.TBTIPOIVA = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBFECHA = New System.Windows.Forms.TextBox()
        Me.TBREFERENCIA = New System.Windows.Forms.TextBox()
        Me.TBCIF = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_LINEAS_IVA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBRECONOCIMIENTOCIF
        '
        Me.TBRECONOCIMIENTOCIF.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TBRECONOCIMIENTOCIF.Location = New System.Drawing.Point(8, 170)
        Me.TBRECONOCIMIENTOCIF.Name = "TBRECONOCIMIENTOCIF"
        Me.TBRECONOCIMIENTOCIF.ReadOnly = True
        Me.TBRECONOCIMIENTOCIF.Size = New System.Drawing.Size(396, 20)
        Me.TBRECONOCIMIENTOCIF.TabIndex = 82
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(113, 718)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 24)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "BASE"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(232, 718)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 24)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "IVA"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(321, 718)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 24)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "TOTAL"
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(428, 0)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(521, 988)
        Me.AxAcroPDF1.TabIndex = 78
        '
        'BTNREFRESCAR
        '
        Me.BTNREFRESCAR.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTNREFRESCAR.Location = New System.Drawing.Point(259, 494)
        Me.BTNREFRESCAR.Name = "BTNREFRESCAR"
        Me.BTNREFRESCAR.Size = New System.Drawing.Size(75, 23)
        Me.BTNREFRESCAR.TabIndex = 77
        Me.BTNREFRESCAR.Text = "REFRESCAR"
        Me.BTNREFRESCAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTNREFRESCAR.UseVisualStyleBackColor = True
        '
        'TB_SUMA_TOTAL
        '
        Me.TB_SUMA_TOTAL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TB_SUMA_TOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_SUMA_TOTAL.Location = New System.Drawing.Point(316, 745)
        Me.TB_SUMA_TOTAL.Name = "TB_SUMA_TOTAL"
        Me.TB_SUMA_TOTAL.Size = New System.Drawing.Size(88, 38)
        Me.TB_SUMA_TOTAL.TabIndex = 76
        '
        'TB_SUMA_IVA
        '
        Me.TB_SUMA_IVA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TB_SUMA_IVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_SUMA_IVA.Location = New System.Drawing.Point(208, 745)
        Me.TB_SUMA_IVA.Name = "TB_SUMA_IVA"
        Me.TB_SUMA_IVA.Size = New System.Drawing.Size(88, 38)
        Me.TB_SUMA_IVA.TabIndex = 75
        '
        'TB_SUMA_BASE
        '
        Me.TB_SUMA_BASE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TB_SUMA_BASE.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_SUMA_BASE.Location = New System.Drawing.Point(103, 745)
        Me.TB_SUMA_BASE.Name = "TB_SUMA_BASE"
        Me.TB_SUMA_BASE.Size = New System.Drawing.Size(88, 38)
        Me.TB_SUMA_BASE.TabIndex = 74
        '
        'BTN_CALCULAR
        '
        Me.BTN_CALCULAR.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_CALCULAR.Location = New System.Drawing.Point(8, 718)
        Me.BTN_CALCULAR.Name = "BTN_CALCULAR"
        Me.BTN_CALCULAR.Size = New System.Drawing.Size(89, 65)
        Me.BTN_CALCULAR.TabIndex = 73
        Me.BTN_CALCULAR.Text = "CALCULAR"
        Me.BTN_CALCULAR.UseVisualStyleBackColor = True
        '
        'DGV_LINEAS_IVA
        '
        Me.DGV_LINEAS_IVA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DGV_LINEAS_IVA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_LINEAS_IVA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_LINEAS_IVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_LINEAS_IVA.Location = New System.Drawing.Point(103, 567)
        Me.DGV_LINEAS_IVA.Name = "DGV_LINEAS_IVA"
        Me.DGV_LINEAS_IVA.RowHeadersWidth = 50
        Me.DGV_LINEAS_IVA.Size = New System.Drawing.Size(301, 145)
        Me.DGV_LINEAS_IVA.TabIndex = 72
        '
        'IMPORTEBASE
        '
        Me.IMPORTEBASE.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IMPORTEBASE.AutoSize = True
        Me.IMPORTEBASE.Location = New System.Drawing.Point(103, 544)
        Me.IMPORTEBASE.Name = "IMPORTEBASE"
        Me.IMPORTEBASE.Size = New System.Drawing.Size(115, 17)
        Me.IMPORTEBASE.TabIndex = 71
        Me.IMPORTEBASE.Text = "IMPORTE = BASE"
        Me.IMPORTEBASE.UseVisualStyleBackColor = True
        '
        'BTN_UPDATE
        '
        Me.BTN_UPDATE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_UPDATE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_UPDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_UPDATE.Location = New System.Drawing.Point(8, 789)
        Me.BTN_UPDATE.Name = "BTN_UPDATE"
        Me.BTN_UPDATE.Size = New System.Drawing.Size(396, 199)
        Me.BTN_UPDATE.TabIndex = 70
        Me.BTN_UPDATE.Text = "ACTUALIZAR"
        Me.BTN_UPDATE.UseVisualStyleBackColor = True
        '
        'TBIMPORTE
        '
        Me.TBIMPORTE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TBIMPORTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBIMPORTE.Location = New System.Drawing.Point(9, 670)
        Me.TBIMPORTE.Name = "TBIMPORTE"
        Me.TBIMPORTE.Size = New System.Drawing.Size(88, 38)
        Me.TBIMPORTE.TabIndex = 69
        '
        'TBTIPOIVA
        '
        Me.TBTIPOIVA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TBTIPOIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBTIPOIVA.Location = New System.Drawing.Point(9, 590)
        Me.TBTIPOIVA.Name = "TBTIPOIVA"
        Me.TBTIPOIVA.Size = New System.Drawing.Size(88, 38)
        Me.TBTIPOIVA.TabIndex = 68
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 643)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 24)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "IMPORTE"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 563)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 24)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "TIPO IVA"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(132, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 24)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "REFERENCIA"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(160, 380)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 24)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "FECHA"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(178, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 24)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "CIF"
        '
        'TBFECHA
        '
        Me.TBFECHA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TBFECHA.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBFECHA.Location = New System.Drawing.Point(8, 407)
        Me.TBFECHA.Name = "TBFECHA"
        Me.TBFECHA.Size = New System.Drawing.Size(396, 80)
        Me.TBFECHA.TabIndex = 62
        '
        'TBREFERENCIA
        '
        Me.TBREFERENCIA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TBREFERENCIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBREFERENCIA.Location = New System.Drawing.Point(8, 245)
        Me.TBREFERENCIA.Name = "TBREFERENCIA"
        Me.TBREFERENCIA.Size = New System.Drawing.Size(396, 80)
        Me.TBREFERENCIA.TabIndex = 61
        '
        'TBCIF
        '
        Me.TBCIF.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TBCIF.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBCIF.Location = New System.Drawing.Point(8, 83)
        Me.TBCIF.Name = "TBCIF"
        Me.TBCIF.Size = New System.Drawing.Size(396, 80)
        Me.TBCIF.TabIndex = 60
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DataGridView1.Location = New System.Drawing.Point(952, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 40
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowTemplate.Height = 10
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(752, 989)
        Me.DataGridView1.TabIndex = 59
        '
        'C_Analisis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1708, 989)
        Me.Controls.Add(Me.TBRECONOCIMIENTOCIF)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.Controls.Add(Me.BTNREFRESCAR)
        Me.Controls.Add(Me.TB_SUMA_TOTAL)
        Me.Controls.Add(Me.TB_SUMA_IVA)
        Me.Controls.Add(Me.TB_SUMA_BASE)
        Me.Controls.Add(Me.BTN_CALCULAR)
        Me.Controls.Add(Me.DGV_LINEAS_IVA)
        Me.Controls.Add(Me.IMPORTEBASE)
        Me.Controls.Add(Me.BTN_UPDATE)
        Me.Controls.Add(Me.TBIMPORTE)
        Me.Controls.Add(Me.TBTIPOIVA)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBFECHA)
        Me.Controls.Add(Me.TBREFERENCIA)
        Me.Controls.Add(Me.TBCIF)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "C_Analisis"
        Me.Text = "C_Analisis"
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_LINEAS_IVA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBRECONOCIMIENTOCIF As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents BTNREFRESCAR As Button
    Friend WithEvents TB_SUMA_TOTAL As TextBox
    Friend WithEvents TB_SUMA_IVA As TextBox
    Friend WithEvents TB_SUMA_BASE As TextBox
    Friend WithEvents BTN_CALCULAR As Button
    Friend WithEvents DGV_LINEAS_IVA As DataGridView
    Friend WithEvents IMPORTEBASE As CheckBox
    Friend WithEvents BTN_UPDATE As Button
    Friend WithEvents TBIMPORTE As TextBox
    Friend WithEvents TBTIPOIVA As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TBFECHA As TextBox
    Friend WithEvents TBREFERENCIA As TextBox
    Friend WithEvents TBCIF As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
