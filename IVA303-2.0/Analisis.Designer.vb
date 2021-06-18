<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Analisis
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Analisis))
        Me.TBTIPOIVA = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBFECHA = New System.Windows.Forms.TextBox()
        Me.TBREFERENCIA = New System.Windows.Forms.TextBox()
        Me.TBCIF = New System.Windows.Forms.TextBox()
        Me.BTN_UPDATE = New System.Windows.Forms.Button()
        Me.TBIMPORTE = New System.Windows.Forms.TextBox()
        Me.IMPORTEBASE = New System.Windows.Forms.CheckBox()
        Me.DGV_LINEAS_IVA = New System.Windows.Forms.DataGridView()
        Me.BTN_CALCULAR = New System.Windows.Forms.Button()
        Me.TB_SUMA_BASE = New System.Windows.Forms.TextBox()
        Me.TB_SUMA_IVA = New System.Windows.Forms.TextBox()
        Me.TB_SUMA_TOTAL = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBRECONOCIMIENTOCIF = New System.Windows.Forms.TextBox()
        Me.CB_Cliente = New System.Windows.Forms.ComboBox()
        Me.CB_Tipo_Doc = New System.Windows.Forms.ComboBox()
        Me.BT_Buscar = New System.Windows.Forms.Button()
        Me.TBRECONOCIMIENTOCIF2 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTN_BuscarLista = New System.Windows.Forms.Button()
        Me.DOCUMENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DGV_LINEAS_IVA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DOCUMENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBTIPOIVA
        '
        resources.ApplyResources(Me.TBTIPOIVA, "TBTIPOIVA")
        Me.TBTIPOIVA.Name = "TBTIPOIVA"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'TBFECHA
        '
        resources.ApplyResources(Me.TBFECHA, "TBFECHA")
        Me.TBFECHA.Name = "TBFECHA"
        '
        'TBREFERENCIA
        '
        resources.ApplyResources(Me.TBREFERENCIA, "TBREFERENCIA")
        Me.TBREFERENCIA.Name = "TBREFERENCIA"
        '
        'TBCIF
        '
        resources.ApplyResources(Me.TBCIF, "TBCIF")
        Me.TBCIF.Name = "TBCIF"
        '
        'BTN_UPDATE
        '
        resources.ApplyResources(Me.BTN_UPDATE, "BTN_UPDATE")
        Me.BTN_UPDATE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_UPDATE.Name = "BTN_UPDATE"
        Me.BTN_UPDATE.UseVisualStyleBackColor = True
        '
        'TBIMPORTE
        '
        resources.ApplyResources(Me.TBIMPORTE, "TBIMPORTE")
        Me.TBIMPORTE.Name = "TBIMPORTE"
        '
        'IMPORTEBASE
        '
        resources.ApplyResources(Me.IMPORTEBASE, "IMPORTEBASE")
        Me.IMPORTEBASE.Name = "IMPORTEBASE"
        Me.IMPORTEBASE.UseVisualStyleBackColor = True
        '
        'DGV_LINEAS_IVA
        '
        resources.ApplyResources(Me.DGV_LINEAS_IVA, "DGV_LINEAS_IVA")
        Me.DGV_LINEAS_IVA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_LINEAS_IVA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_LINEAS_IVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_LINEAS_IVA.Name = "DGV_LINEAS_IVA"
        '
        'BTN_CALCULAR
        '
        resources.ApplyResources(Me.BTN_CALCULAR, "BTN_CALCULAR")
        Me.BTN_CALCULAR.Name = "BTN_CALCULAR"
        Me.BTN_CALCULAR.UseVisualStyleBackColor = True
        '
        'TB_SUMA_BASE
        '
        resources.ApplyResources(Me.TB_SUMA_BASE, "TB_SUMA_BASE")
        Me.TB_SUMA_BASE.Name = "TB_SUMA_BASE"
        '
        'TB_SUMA_IVA
        '
        resources.ApplyResources(Me.TB_SUMA_IVA, "TB_SUMA_IVA")
        Me.TB_SUMA_IVA.Name = "TB_SUMA_IVA"
        '
        'TB_SUMA_TOTAL
        '
        resources.ApplyResources(Me.TB_SUMA_TOTAL, "TB_SUMA_TOTAL")
        Me.TB_SUMA_TOTAL.Name = "TB_SUMA_TOTAL"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowTemplate.Height = 10
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'TBRECONOCIMIENTOCIF
        '
        resources.ApplyResources(Me.TBRECONOCIMIENTOCIF, "TBRECONOCIMIENTOCIF")
        Me.TBRECONOCIMIENTOCIF.Name = "TBRECONOCIMIENTOCIF"
        Me.TBRECONOCIMIENTOCIF.ReadOnly = True
        '
        'CB_Cliente
        '
        Me.CB_Cliente.FormattingEnabled = True
        resources.ApplyResources(Me.CB_Cliente, "CB_Cliente")
        Me.CB_Cliente.Name = "CB_Cliente"
        '
        'CB_Tipo_Doc
        '
        Me.CB_Tipo_Doc.FormattingEnabled = True
        resources.ApplyResources(Me.CB_Tipo_Doc, "CB_Tipo_Doc")
        Me.CB_Tipo_Doc.Name = "CB_Tipo_Doc"
        '
        'BT_Buscar
        '
        resources.ApplyResources(Me.BT_Buscar, "BT_Buscar")
        Me.BT_Buscar.Name = "BT_Buscar"
        Me.BT_Buscar.UseVisualStyleBackColor = True
        '
        'TBRECONOCIMIENTOCIF2
        '
        resources.ApplyResources(Me.TBRECONOCIMIENTOCIF2, "TBRECONOCIMIENTOCIF2")
        Me.TBRECONOCIMIENTOCIF2.Name = "TBRECONOCIMIENTOCIF2"
        Me.TBRECONOCIMIENTOCIF2.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AxAcroPDF1)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'AxAcroPDF1
        '
        resources.ApplyResources(Me.AxAcroPDF1, "AxAcroPDF1")
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        '
        'Panel2
        '
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'BTN_BuscarLista
        '
        resources.ApplyResources(Me.BTN_BuscarLista, "BTN_BuscarLista")
        Me.BTN_BuscarLista.Name = "BTN_BuscarLista"
        Me.BTN_BuscarLista.UseVisualStyleBackColor = True
        '
        'DOCUMENTOSBindingSource
        '
        Me.DOCUMENTOSBindingSource.DataMember = "DOCUMENTOS"
        '
        'Analisis
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BTN_BuscarLista)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TBRECONOCIMIENTOCIF2)
        Me.Controls.Add(Me.BT_Buscar)
        Me.Controls.Add(Me.CB_Tipo_Doc)
        Me.Controls.Add(Me.CB_Cliente)
        Me.Controls.Add(Me.TBRECONOCIMIENTOCIF)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
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
        Me.Controls.Add(Me.Panel2)
        Me.KeyPreview = True
        Me.Name = "Analisis"
        CType(Me.DGV_LINEAS_IVA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DOCUMENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DOCUMENTOSBindingSource As BindingSource

    Friend WithEvents TBTIPOIVA As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TBFECHA As TextBox
    Friend WithEvents TBREFERENCIA As TextBox
    Friend WithEvents TBCIF As TextBox
    Friend WithEvents BTN_UPDATE As Button
    Friend WithEvents TBIMPORTE As TextBox
    Friend WithEvents IMPORTEBASE As CheckBox
    Friend WithEvents DGV_LINEAS_IVA As DataGridView
    Friend WithEvents BTN_CALCULAR As Button
    Friend WithEvents TB_SUMA_BASE As TextBox
    Friend WithEvents TB_SUMA_IVA As TextBox
    Friend WithEvents TB_SUMA_TOTAL As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TBRECONOCIMIENTOCIF As TextBox
    Friend WithEvents CB_Cliente As ComboBox
    Friend WithEvents CB_Tipo_Doc As ComboBox
    Friend WithEvents BT_Buscar As Button
    Friend WithEvents TBRECONOCIMIENTOCIF2 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BTN_BuscarLista As Button
End Class
