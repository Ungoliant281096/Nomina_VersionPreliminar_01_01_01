<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NOM_TablaSubsidio
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
        ImprimirToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        SeleccionarTodoToolStripMenuItem = New ToolStripMenuItem()
        CopiarCtrCToolStripMenuItem = New ToolStripMenuItem()
        PegarToolStripMenuItem = New ToolStripMenuItem()
        EliminarToolStripMenuItem = New ToolStripMenuItem()
        InsertarToolStripMenuItem = New ToolStripMenuItem()
        TextBox1 = New TextBox()
        DataGridView1 = New DataGridView()
        VScrollBar1 = New VScrollBar()
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
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {GuardarToolStripMenuItem, ImprimirToolStripMenuItem, SalirToolStripMenuItem})
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(73, 24)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' EdiciónToolStripMenuItem
        ' 
        EdiciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SeleccionarTodoToolStripMenuItem, CopiarCtrCToolStripMenuItem, PegarToolStripMenuItem, EliminarToolStripMenuItem, InsertarToolStripMenuItem})
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
        ' ImprimirToolStripMenuItem
        ' 
        ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        ImprimirToolStripMenuItem.Size = New Size(224, 26)
        ImprimirToolStripMenuItem.Text = "Imprimir"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(224, 26)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' SeleccionarTodoToolStripMenuItem
        ' 
        SeleccionarTodoToolStripMenuItem.Name = "SeleccionarTodoToolStripMenuItem"
        SeleccionarTodoToolStripMenuItem.Size = New Size(259, 26)
        SeleccionarTodoToolStripMenuItem.Text = "Seleccionar todo"
        ' 
        ' CopiarCtrCToolStripMenuItem
        ' 
        CopiarCtrCToolStripMenuItem.Name = "CopiarCtrCToolStripMenuItem"
        CopiarCtrCToolStripMenuItem.Size = New Size(259, 26)
        CopiarCtrCToolStripMenuItem.Text = "Copiar                     Ctr+C"
        ' 
        ' PegarToolStripMenuItem
        ' 
        PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        PegarToolStripMenuItem.Size = New Size(259, 26)
        PegarToolStripMenuItem.Text = "Pegar                       Ctr+V"
        ' 
        ' EliminarToolStripMenuItem
        ' 
        EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        EliminarToolStripMenuItem.Size = New Size(259, 26)
        EliminarToolStripMenuItem.Text = "Eliminar"
        ' 
        ' InsertarToolStripMenuItem
        ' 
        InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        InsertarToolStripMenuItem.Size = New Size(259, 26)
        InsertarToolStripMenuItem.Text = "Insertar"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(79, 63)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(264, 27)
        TextBox1.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(83, 139)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(618, 354)
        DataGridView1.TabIndex = 2
        ' 
        ' VScrollBar1
        ' 
        VScrollBar1.Location = New Point(682, 139)
        VScrollBar1.Name = "VScrollBar1"
        VScrollBar1.Size = New Size(19, 403)
        VScrollBar1.TabIndex = 3
        ' 
        ' NOM_TablaSubsidio
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(VScrollBar1)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "NOM_TablaSubsidio"
        Text = "NOM_TablaSubsidio"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeleccionarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarCtrCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents VScrollBar1 As VScrollBar
End Class
