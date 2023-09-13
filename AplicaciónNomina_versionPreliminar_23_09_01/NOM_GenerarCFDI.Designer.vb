<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NOM_GenerarCFDI
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
        GenToolStripMenuItem = New ToolStripMenuItem()
        CopiarCtrCToolStripMenuItem = New ToolStripMenuItem()
        SeleccionarTodoCtrCToolStripMenuItem = New ToolStripMenuItem()
        TextBox1 = New TextBox()
        DataGridView1 = New DataGridView()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem, GenToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CopiarCtrCToolStripMenuItem, SeleccionarTodoCtrCToolStripMenuItem})
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(73, 24)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' GenToolStripMenuItem
        ' 
        GenToolStripMenuItem.Name = "GenToolStripMenuItem"
        GenToolStripMenuItem.Size = New Size(113, 24)
        GenToolStripMenuItem.Text = "Generar Excel"
        ' 
        ' CopiarCtrCToolStripMenuItem
        ' 
        CopiarCtrCToolStripMenuItem.Name = "CopiarCtrCToolStripMenuItem"
        CopiarCtrCToolStripMenuItem.Size = New Size(318, 26)
        CopiarCtrCToolStripMenuItem.Text = "Copiar                                    Ctr+C"
        ' 
        ' SeleccionarTodoCtrCToolStripMenuItem
        ' 
        SeleccionarTodoCtrCToolStripMenuItem.Name = "SeleccionarTodoCtrCToolStripMenuItem"
        SeleccionarTodoCtrCToolStripMenuItem.Size = New Size(318, 26)
        SeleccionarTodoCtrCToolStripMenuItem.Text = "Seleccionar todo                   Ctr+E"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(18, 30)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(208, 27)
        TextBox1.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(24, 79)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(765, 348)
        DataGridView1.TabIndex = 2
        ' 
        ' NOM_GenerarCFDI
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "NOM_GenerarCFDI"
        Text = "NOM_GenerarCFDI"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarCtrCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeleccionarTodoCtrCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
