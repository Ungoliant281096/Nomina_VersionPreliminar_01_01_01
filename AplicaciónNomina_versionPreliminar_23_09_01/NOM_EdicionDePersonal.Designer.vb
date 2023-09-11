<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NOM_EdicionDePersonal
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArcivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuméricamenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlfabéticamenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdiciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntegrarSalarioDiarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeleccionarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuprimirTitulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PantallaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 59)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(887, 525)
        Me.DataGridView1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArcivoToolStripMenuItem, Me.EdiciónToolStripMenuItem, Me.ImprimirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(914, 30)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArcivoToolStripMenuItem
        '
        Me.ArcivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrdenarToolStripMenuItem, Me.SalidaToolStripMenuItem})
        Me.ArcivoToolStripMenuItem.Name = "ArcivoToolStripMenuItem"
        Me.ArcivoToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.ArcivoToolStripMenuItem.Text = "Arcivo"
        '
        'OrdenarToolStripMenuItem
        '
        Me.OrdenarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuméricamenteToolStripMenuItem, Me.AlfabéticamenteToolStripMenuItem})
        Me.OrdenarToolStripMenuItem.Name = "OrdenarToolStripMenuItem"
        Me.OrdenarToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.OrdenarToolStripMenuItem.Text = "Ordenar"
        '
        'NuméricamenteToolStripMenuItem
        '
        Me.NuméricamenteToolStripMenuItem.Name = "NuméricamenteToolStripMenuItem"
        Me.NuméricamenteToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.NuméricamenteToolStripMenuItem.Text = "Numéricamente"
        '
        'AlfabéticamenteToolStripMenuItem
        '
        Me.AlfabéticamenteToolStripMenuItem.Name = "AlfabéticamenteToolStripMenuItem"
        Me.AlfabéticamenteToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.AlfabéticamenteToolStripMenuItem.Text = "Alfabéticamente"
        '
        'SalidaToolStripMenuItem
        '
        Me.SalidaToolStripMenuItem.Name = "SalidaToolStripMenuItem"
        Me.SalidaToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SalidaToolStripMenuItem.Text = "Salida"
        '
        'EdiciónToolStripMenuItem
        '
        Me.EdiciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItem, Me.PegarToolStripMenuItem, Me.IntegrarSalarioDiarioToolStripMenuItem, Me.SeleccionarTodoToolStripMenuItem, Me.SuprimirTitulosToolStripMenuItem})
        Me.EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        Me.EdiciónToolStripMenuItem.Size = New System.Drawing.Size(72, 24)
        Me.EdiciónToolStripMenuItem.Text = "Edición"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.PegarToolStripMenuItem.Text = "Pegar"
        '
        'IntegrarSalarioDiarioToolStripMenuItem
        '
        Me.IntegrarSalarioDiarioToolStripMenuItem.Name = "IntegrarSalarioDiarioToolStripMenuItem"
        Me.IntegrarSalarioDiarioToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.IntegrarSalarioDiarioToolStripMenuItem.Text = "Integrar salario diario"
        '
        'SeleccionarTodoToolStripMenuItem
        '
        Me.SeleccionarTodoToolStripMenuItem.Name = "SeleccionarTodoToolStripMenuItem"
        Me.SeleccionarTodoToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.SeleccionarTodoToolStripMenuItem.Text = "Seleccionar todo"
        '
        'SuprimirTitulosToolStripMenuItem
        '
        Me.SuprimirTitulosToolStripMenuItem.Name = "SuprimirTitulosToolStripMenuItem"
        Me.SuprimirTitulosToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.SuprimirTitulosToolStripMenuItem.Text = "Suprimir titulos"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PantallaToolStripMenuItem, Me.TotalToolStripMenuItem})
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'PantallaToolStripMenuItem
        '
        Me.PantallaToolStripMenuItem.Name = "PantallaToolStripMenuItem"
        Me.PantallaToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.PantallaToolStripMenuItem.Text = "Pantalla"
        '
        'TotalToolStripMenuItem
        '
        Me.TotalToolStripMenuItem.Name = "TotalToolStripMenuItem"
        Me.TotalToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.TotalToolStripMenuItem.Text = "Total"
        '
        'NOM_EdicionDePersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 600)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "NOM_EdicionDePersonal"
        Me.Text = "EdicionDePersonal"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArcivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdenarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuméricamenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlfabéticamenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntegrarSalarioDiarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeleccionarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuprimirTitulosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PantallaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TotalToolStripMenuItem As ToolStripMenuItem
End Class
