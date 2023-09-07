<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NOM_EdicionEspecial
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
        ImprimirToolStripMenuItem = New ToolStripMenuItem()
        OrdenarToolStripMenuItem = New ToolStripMenuItem()
        SalidaToolStripMenuItem = New ToolStripMenuItem()
        AlfabeticamenteToolStripMenuItem = New ToolStripMenuItem()
        NuméricamenteToolStripMenuItem = New ToolStripMenuItem()
        CopiarCtrCToolStripMenuItem = New ToolStripMenuItem()
        PegarCtrVToolStripMenuItem = New ToolStripMenuItem()
        IntegrarSalarioToolStripMenuItem = New ToolStripMenuItem()
        SeleccionarTodoToolStripMenuItem = New ToolStripMenuItem()
        SuprimirTitulosToolStripMenuItem = New ToolStripMenuItem()
        PantallaToolStripMenuItem = New ToolStripMenuItem()
        TotalToolStripMenuItem = New ToolStripMenuItem()
        TextBox1 = New TextBox()
        DataGridView1 = New DataGridView()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem, EdiciónToolStripMenuItem, ImprimirToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {OrdenarToolStripMenuItem, SalidaToolStripMenuItem})
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(73, 24)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' EdiciónToolStripMenuItem
        ' 
        EdiciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CopiarCtrCToolStripMenuItem, PegarCtrVToolStripMenuItem, IntegrarSalarioToolStripMenuItem, SeleccionarTodoToolStripMenuItem, SuprimirTitulosToolStripMenuItem})
        EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        EdiciónToolStripMenuItem.Size = New Size(72, 24)
        EdiciónToolStripMenuItem.Text = "Edición"
        ' 
        ' ImprimirToolStripMenuItem
        ' 
        ImprimirToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PantallaToolStripMenuItem, TotalToolStripMenuItem})
        ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        ImprimirToolStripMenuItem.Size = New Size(80, 24)
        ImprimirToolStripMenuItem.Text = "Imprimir"
        ' 
        ' OrdenarToolStripMenuItem
        ' 
        OrdenarToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AlfabeticamenteToolStripMenuItem, NuméricamenteToolStripMenuItem})
        OrdenarToolStripMenuItem.Name = "OrdenarToolStripMenuItem"
        OrdenarToolStripMenuItem.Size = New Size(224, 26)
        OrdenarToolStripMenuItem.Text = "Ordenar"
        ' 
        ' SalidaToolStripMenuItem
        ' 
        SalidaToolStripMenuItem.Name = "SalidaToolStripMenuItem"
        SalidaToolStripMenuItem.Size = New Size(224, 26)
        SalidaToolStripMenuItem.Text = "Salida"
        ' 
        ' AlfabeticamenteToolStripMenuItem
        ' 
        AlfabeticamenteToolStripMenuItem.Name = "AlfabeticamenteToolStripMenuItem"
        AlfabeticamenteToolStripMenuItem.Size = New Size(224, 26)
        AlfabeticamenteToolStripMenuItem.Text = "Alfabeticamente"
        ' 
        ' NuméricamenteToolStripMenuItem
        ' 
        NuméricamenteToolStripMenuItem.Name = "NuméricamenteToolStripMenuItem"
        NuméricamenteToolStripMenuItem.Size = New Size(224, 26)
        NuméricamenteToolStripMenuItem.Text = "Numéricamente"
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
        ' IntegrarSalarioToolStripMenuItem
        ' 
        IntegrarSalarioToolStripMenuItem.Name = "IntegrarSalarioToolStripMenuItem"
        IntegrarSalarioToolStripMenuItem.Size = New Size(259, 26)
        IntegrarSalarioToolStripMenuItem.Text = "Integrar Salario Diario"
        ' 
        ' SeleccionarTodoToolStripMenuItem
        ' 
        SeleccionarTodoToolStripMenuItem.Name = "SeleccionarTodoToolStripMenuItem"
        SeleccionarTodoToolStripMenuItem.Size = New Size(259, 26)
        SeleccionarTodoToolStripMenuItem.Text = "Seleccionar todo"
        ' 
        ' SuprimirTitulosToolStripMenuItem
        ' 
        SuprimirTitulosToolStripMenuItem.Name = "SuprimirTitulosToolStripMenuItem"
        SuprimirTitulosToolStripMenuItem.Size = New Size(259, 26)
        SuprimirTitulosToolStripMenuItem.Text = "Suprimir titulos"
        ' 
        ' PantallaToolStripMenuItem
        ' 
        PantallaToolStripMenuItem.Name = "PantallaToolStripMenuItem"
        PantallaToolStripMenuItem.Size = New Size(224, 26)
        PantallaToolStripMenuItem.Text = "Pantalla"
        ' 
        ' TotalToolStripMenuItem
        ' 
        TotalToolStripMenuItem.Name = "TotalToolStripMenuItem"
        TotalToolStripMenuItem.Size = New Size(224, 26)
        TotalToolStripMenuItem.Text = "Total"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 40)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(776, 27)
        TextBox1.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(16, 85)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(770, 406)
        DataGridView1.TabIndex = 2
        ' 
        ' NOM_EdicionEspecial
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "NOM_EdicionEspecial"
        Text = "NOM_EdicionEspecial"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdenarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlfabeticamenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuméricamenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarCtrCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PegarCtrVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntegrarSalarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeleccionarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuprimirTitulosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PantallaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TotalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
