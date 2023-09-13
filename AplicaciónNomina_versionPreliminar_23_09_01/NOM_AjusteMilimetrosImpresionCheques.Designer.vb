<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NOM_AjusteMilimetrosImpresionCheques
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
        MenuStrip1 = New MenuStrip()
        ArchivoToolStripMenuItem = New ToolStripMenuItem()
        EdiciónToolStripMenuItem = New ToolStripMenuItem()
        GuardarToolStripMenuItem = New ToolStripMenuItem()
        ImpresiónDatosToolStripMenuItem = New ToolStripMenuItem()
        PruebaImpresiónToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        CopiarCtrlCToolStripMenuItem = New ToolStripMenuItem()
        TextBox1 = New TextBox()
        DataGridView1 = New DataGridView()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem, EdiciónToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(554, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {GuardarToolStripMenuItem, ImpresiónDatosToolStripMenuItem, PruebaImpresiónToolStripMenuItem, SalirToolStripMenuItem})
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(73, 24)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' EdiciónToolStripMenuItem
        ' 
        EdiciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CopiarCtrlCToolStripMenuItem})
        EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        EdiciónToolStripMenuItem.Size = New Size(72, 24)
        EdiciónToolStripMenuItem.Text = "Edición"
        ' 
        ' GuardarToolStripMenuItem
        ' 
        GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        GuardarToolStripMenuItem.Size = New Size(224, 26)
        GuardarToolStripMenuItem.Text = "Guardar"
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
        ' CopiarCtrlCToolStripMenuItem
        ' 
        CopiarCtrlCToolStripMenuItem.Name = "CopiarCtrlCToolStripMenuItem"
        CopiarCtrlCToolStripMenuItem.Size = New Size(246, 26)
        CopiarCtrlCToolStripMenuItem.Text = "Copiar               Ctrl + C"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 47)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(19, 94)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(510, 388)
        DataGridView1.TabIndex = 2
        ' 
        ' NOM_AjusteMilimetrosImpresionCheques
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(554, 507)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "NOM_AjusteMilimetrosImpresionCheques"
        Text = "NOM_AjusteMilimetrosImpresionCheques"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImpresiónDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PruebaImpresiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarCtrlCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
