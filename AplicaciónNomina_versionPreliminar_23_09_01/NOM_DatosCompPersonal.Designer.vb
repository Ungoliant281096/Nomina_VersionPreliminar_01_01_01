<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NOM_DatosCompPersonal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdiciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarCtrCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarCtrCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeleccionarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EdiciónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.SalidaToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(145, 26)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(145, 26)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'SalidaToolStripMenuItem
        '
        Me.SalidaToolStripMenuItem.Name = "SalidaToolStripMenuItem"
        Me.SalidaToolStripMenuItem.Size = New System.Drawing.Size(145, 26)
        Me.SalidaToolStripMenuItem.Text = "Salida"
        '
        'EdiciónToolStripMenuItem
        '
        Me.EdiciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarCtrCToolStripMenuItem, Me.PegarCtrCToolStripMenuItem, Me.InsertarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.SeleccionarTodoToolStripMenuItem})
        Me.EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        Me.EdiciónToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.EdiciónToolStripMenuItem.Text = "Editar"
        '
        'CopiarCtrCToolStripMenuItem
        '
        Me.CopiarCtrCToolStripMenuItem.Name = "CopiarCtrCToolStripMenuItem"
        Me.CopiarCtrCToolStripMenuItem.Size = New System.Drawing.Size(259, 26)
        Me.CopiarCtrCToolStripMenuItem.Text = "Copiar                     Ctr+C"
        '
        'PegarCtrCToolStripMenuItem
        '
        Me.PegarCtrCToolStripMenuItem.Name = "PegarCtrCToolStripMenuItem"
        Me.PegarCtrCToolStripMenuItem.Size = New System.Drawing.Size(259, 26)
        Me.PegarCtrCToolStripMenuItem.Text = "Pegar                       Ctr+V"
        '
        'InsertarToolStripMenuItem
        '
        Me.InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        Me.InsertarToolStripMenuItem.Size = New System.Drawing.Size(259, 26)
        Me.InsertarToolStripMenuItem.Text = "Insertar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(259, 26)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'SeleccionarTodoToolStripMenuItem
        '
        Me.SeleccionarTodoToolStripMenuItem.Name = "SeleccionarTodoToolStripMenuItem"
        Me.SeleccionarTodoToolStripMenuItem.Size = New System.Drawing.Size(259, 26)
        Me.SeleccionarTodoToolStripMenuItem.Text = "Seleccionar todo"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 31)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(748, 367)
        Me.DataGridView1.TabIndex = 2
        '
        'NOM_DatosCompPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "NOM_DatosCompPersonal"
        Me.Text = "NOM_DatosCompPersonal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarCtrCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PegarCtrCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeleccionarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
End Class
