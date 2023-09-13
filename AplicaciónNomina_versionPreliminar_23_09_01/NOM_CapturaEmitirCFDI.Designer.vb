<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NOM_CapturaEmitirCFDI
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
        EdiciónToolStripMenuItem = New ToolStripMenuItem()
        CopiarCtrCToolStripMenuItem = New ToolStripMenuItem()
        PegarCtrVToolStripMenuItem = New ToolStripMenuItem()
        SalidaToolStripMenuItem = New ToolStripMenuItem()
        TextBox1 = New TextBox()
        DataGridView1 = New DataGridView()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {EdiciónToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(961, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' EdiciónToolStripMenuItem
        ' 
        EdiciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CopiarCtrCToolStripMenuItem, PegarCtrVToolStripMenuItem, SalidaToolStripMenuItem})
        EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        EdiciónToolStripMenuItem.Size = New Size(72, 24)
        EdiciónToolStripMenuItem.Text = "Edición"
        ' 
        ' CopiarCtrCToolStripMenuItem
        ' 
        CopiarCtrCToolStripMenuItem.Name = "CopiarCtrCToolStripMenuItem"
        CopiarCtrCToolStripMenuItem.Size = New Size(259, 26)
        CopiarCtrCToolStripMenuItem.Text = "Copiar                     Ctr+C"
        ' 
        ' PegarCtrVToolStripMenuItem
        ' 
        PegarCtrVToolStripMenuItem.Name = "PegarCtrVToolStripMenuItem"
        PegarCtrVToolStripMenuItem.Size = New Size(259, 26)
        PegarCtrVToolStripMenuItem.Text = "Pegar                       Ctr+V"
        ' 
        ' SalidaToolStripMenuItem
        ' 
        SalidaToolStripMenuItem.Name = "SalidaToolStripMenuItem"
        SalidaToolStripMenuItem.Size = New Size(259, 26)
        SalidaToolStripMenuItem.Text = "Seleccionar Todo"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(21, 39)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(559, 27)
        TextBox1.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(24, 89)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(911, 512)
        DataGridView1.TabIndex = 2
        ' 
        ' NOM_CapturaEmitirCFDI
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(961, 611)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "NOM_CapturaEmitirCFDI"
        Text = "NOM_CapturaEmitirCFDI"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarCtrCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PegarCtrVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
