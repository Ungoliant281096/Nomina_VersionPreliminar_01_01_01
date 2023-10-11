<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAP_AjusteImpresionCheques
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(CAP_AjusteImpresionCheques))
        MenuStrip1 = New MenuStrip()
        ArchivoToolStripMenuItem = New ToolStripMenuItem()
        ArchivarToolStripMenuItem = New ToolStripMenuItem()
        ImpresiónDatosToolStripMenuItem = New ToolStripMenuItem()
        PruebaImpresiónToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        TextBox1 = New TextBox()
        DataGridView1 = New DataGridView()
        ColConcep = New DataGridViewTextBoxColumn()
        ColReng = New DataGridViewTextBoxColumn()
        ColCol = New DataGridViewTextBoxColumn()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(460, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ArchivarToolStripMenuItem, ImpresiónDatosToolStripMenuItem, PruebaImpresiónToolStripMenuItem, SalirToolStripMenuItem})
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(73, 24)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' ArchivarToolStripMenuItem
        ' 
        ArchivarToolStripMenuItem.Name = "ArchivarToolStripMenuItem"
        ArchivarToolStripMenuItem.Size = New Size(224, 26)
        ArchivarToolStripMenuItem.Text = "Archivar"
        ' 
        ' ImpresiónDatosToolStripMenuItem
        ' 
        ImpresiónDatosToolStripMenuItem.Name = "ImpresiónDatosToolStripMenuItem"
        ImpresiónDatosToolStripMenuItem.Size = New Size(224, 26)
        ImpresiónDatosToolStripMenuItem.Text = "Impresión datos"
        ' 
        ' PruebaImpresiónToolStripMenuItem
        ' 
        PruebaImpresiónToolStripMenuItem.Name = "PruebaImpresiónToolStripMenuItem"
        PruebaImpresiónToolStripMenuItem.Size = New Size(224, 26)
        PruebaImpresiónToolStripMenuItem.Text = "Prueba impresión"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(224, 26)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 40)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ColConcep, ColReng, ColCol})
        DataGridView1.Location = New Point(24, 95)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(408, 452)
        DataGridView1.TabIndex = 2
        ' 
        ' ColConcep
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        ColConcep.DefaultCellStyle = DataGridViewCellStyle1
        ColConcep.HeaderText = "CONCEPTO"
        ColConcep.MinimumWidth = 6
        ColConcep.Name = "ColConcep"
        ColConcep.Width = 125
        ' 
        ' ColReng
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        ColReng.DefaultCellStyle = DataGridViewCellStyle2
        ColReng.HeaderText = "RENGLONES"
        ColReng.MinimumWidth = 6
        ColReng.Name = "ColReng"
        ColReng.Width = 125
        ' 
        ' ColCol
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        ColCol.DefaultCellStyle = DataGridViewCellStyle3
        ColCol.HeaderText = "COLUMNAS"
        ColCol.MinimumWidth = 6
        ColCol.Name = "ColCol"
        ColCol.Width = 125
        ' 
        ' CAP_AjusteImpresionCheques
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(460, 579)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox1)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "CAP_AjusteImpresionCheques"
        Text = "CAP_AjusteImpresionCheques"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArchivarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImpresiónDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PruebaImpresiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ColConcep As DataGridViewTextBoxColumn
    Friend WithEvents ColReng As DataGridViewTextBoxColumn
    Friend WithEvents ColCol As DataGridViewTextBoxColumn
End Class
