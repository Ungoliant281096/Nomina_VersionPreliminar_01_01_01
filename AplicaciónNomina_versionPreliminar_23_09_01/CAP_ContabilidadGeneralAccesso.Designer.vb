<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAP_ContabilidadGeneralAccesso
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
        AnexoToolStripMenuItem = New ToolStripMenuItem()
        OrdenarToolStripMenuItem = New ToolStripMenuItem()
        AlfabéticamenteToolStripMenuItem = New ToolStripMenuItem()
        NuméricamenteToolStripMenuItem = New ToolStripMenuItem()
        ImprimirToolStripMenuItem = New ToolStripMenuItem()
        EdiciónToolStripMenuItem = New ToolStripMenuItem()
        CopiarTodoToolStripMenuItem = New ToolStripMenuItem()
        SeleccionarTodoToolStripMenuItem = New ToolStripMenuItem()
        DataGridView1 = New DataGridView()
        ColSubCta = New DataGridViewTextBoxColumn()
        ColNom = New DataGridViewTextBoxColumn()
        ColImpte = New DataGridViewTextBoxColumn()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {AnexoToolStripMenuItem, EdiciónToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(626, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AnexoToolStripMenuItem
        ' 
        AnexoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {OrdenarToolStripMenuItem, ImprimirToolStripMenuItem})
        AnexoToolStripMenuItem.Name = "AnexoToolStripMenuItem"
        AnexoToolStripMenuItem.Size = New Size(65, 24)
        AnexoToolStripMenuItem.Text = "Anexo"
        ' 
        ' OrdenarToolStripMenuItem
        ' 
        OrdenarToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AlfabéticamenteToolStripMenuItem, NuméricamenteToolStripMenuItem})
        OrdenarToolStripMenuItem.Name = "OrdenarToolStripMenuItem"
        OrdenarToolStripMenuItem.Size = New Size(149, 26)
        OrdenarToolStripMenuItem.Text = "Ordenar"
        ' 
        ' AlfabéticamenteToolStripMenuItem
        ' 
        AlfabéticamenteToolStripMenuItem.Name = "AlfabéticamenteToolStripMenuItem"
        AlfabéticamenteToolStripMenuItem.Size = New Size(202, 26)
        AlfabéticamenteToolStripMenuItem.Text = "Alfabéticamente"
        ' 
        ' NuméricamenteToolStripMenuItem
        ' 
        NuméricamenteToolStripMenuItem.Name = "NuméricamenteToolStripMenuItem"
        NuméricamenteToolStripMenuItem.Size = New Size(202, 26)
        NuméricamenteToolStripMenuItem.Text = "Numéricamente"
        ' 
        ' ImprimirToolStripMenuItem
        ' 
        ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        ImprimirToolStripMenuItem.Size = New Size(149, 26)
        ImprimirToolStripMenuItem.Text = "Imprimir"
        ' 
        ' EdiciónToolStripMenuItem
        ' 
        EdiciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CopiarTodoToolStripMenuItem, SeleccionarTodoToolStripMenuItem})
        EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        EdiciónToolStripMenuItem.Size = New Size(72, 24)
        EdiciónToolStripMenuItem.Text = "Edición"
        ' 
        ' CopiarTodoToolStripMenuItem
        ' 
        CopiarTodoToolStripMenuItem.Name = "CopiarTodoToolStripMenuItem"
        CopiarTodoToolStripMenuItem.Size = New Size(291, 26)
        CopiarTodoToolStripMenuItem.Text = "Copiar todo                 Ctrl + S"
        ' 
        ' SeleccionarTodoToolStripMenuItem
        ' 
        SeleccionarTodoToolStripMenuItem.Name = "SeleccionarTodoToolStripMenuItem"
        SeleccionarTodoToolStripMenuItem.Size = New Size(291, 26)
        SeleccionarTodoToolStripMenuItem.Text = "Copiar selección          Ctrl + C"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ColSubCta, ColNom, ColImpte})
        DataGridView1.Location = New Point(33, 54)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(543, 437)
        DataGridView1.TabIndex = 1
        ' 
        ' ColSubCta
        ' 
        ColSubCta.HeaderText = "SubCta"
        ColSubCta.MinimumWidth = 6
        ColSubCta.Name = "ColSubCta"
        ColSubCta.Width = 125
        ' 
        ' ColNom
        ' 
        ColNom.HeaderText = "Nombre"
        ColNom.MinimumWidth = 6
        ColNom.Name = "ColNom"
        ColNom.Width = 125
        ' 
        ' ColImpte
        ' 
        ColImpte.HeaderText = "Importe"
        ColImpte.MinimumWidth = 6
        ColImpte.Name = "ColImpte"
        ColImpte.Width = 125
        ' 
        ' CAP_ContabilidadGeneralAccesso
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(626, 554)
        Controls.Add(DataGridView1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "CAP_ContabilidadGeneralAccesso"
        Text = "CAP_ContabilidadGeneralAccesso"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AnexoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdenarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeleccionarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlfabéticamenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuméricamenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ColSubCta As DataGridViewTextBoxColumn
    Friend WithEvents ColNom As DataGridViewTextBoxColumn
    Friend WithEvents ColImpte As DataGridViewTextBoxColumn
End Class
