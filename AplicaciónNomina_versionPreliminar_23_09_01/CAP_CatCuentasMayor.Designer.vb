<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAP_CatCuentasMayor
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(CAP_CatCuentasMayor))
        MenuStrip1 = New MenuStrip()
        VerToolStripMenuItem = New ToolStripMenuItem()
        AlfabéticamenteToolStripMenuItem = New ToolStripMenuItem()
        NuméricamenteToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        EdiciónToolStripMenuItem = New ToolStripMenuItem()
        CopiarSelecciónToolStripMenuItem = New ToolStripMenuItem()
        CopiarTodoToolStripMenuItem = New ToolStripMenuItem()
        EditarCuentasToolStripMenuItem = New ToolStripMenuItem()
        DataGridView1 = New DataGridView()
        ColCta = New DataGridViewTextBoxColumn()
        ColNom = New DataGridViewTextBoxColumn()
        HScrollBar1 = New HScrollBar()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {VerToolStripMenuItem, EdiciónToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(688, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' VerToolStripMenuItem
        ' 
        VerToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AlfabéticamenteToolStripMenuItem, NuméricamenteToolStripMenuItem, SalirToolStripMenuItem})
        VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        VerToolStripMenuItem.Size = New Size(44, 24)
        VerToolStripMenuItem.Text = "Ver"
        ' 
        ' AlfabéticamenteToolStripMenuItem
        ' 
        AlfabéticamenteToolStripMenuItem.Name = "AlfabéticamenteToolStripMenuItem"
        AlfabéticamenteToolStripMenuItem.Size = New Size(224, 26)
        AlfabéticamenteToolStripMenuItem.Text = "Alfabéticamente"
        ' 
        ' NuméricamenteToolStripMenuItem
        ' 
        NuméricamenteToolStripMenuItem.Name = "NuméricamenteToolStripMenuItem"
        NuméricamenteToolStripMenuItem.Size = New Size(224, 26)
        NuméricamenteToolStripMenuItem.Text = "Numéricamente"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(224, 26)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' EdiciónToolStripMenuItem
        ' 
        EdiciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CopiarSelecciónToolStripMenuItem, CopiarTodoToolStripMenuItem, EditarCuentasToolStripMenuItem})
        EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        EdiciónToolStripMenuItem.Size = New Size(72, 24)
        EdiciónToolStripMenuItem.Text = "Edición"
        ' 
        ' CopiarSelecciónToolStripMenuItem
        ' 
        CopiarSelecciónToolStripMenuItem.Name = "CopiarSelecciónToolStripMenuItem"
        CopiarSelecciónToolStripMenuItem.Size = New Size(201, 26)
        CopiarSelecciónToolStripMenuItem.Text = "Copiar selección"
        ' 
        ' CopiarTodoToolStripMenuItem
        ' 
        CopiarTodoToolStripMenuItem.Name = "CopiarTodoToolStripMenuItem"
        CopiarTodoToolStripMenuItem.Size = New Size(201, 26)
        CopiarTodoToolStripMenuItem.Text = "Copiar todo "
        ' 
        ' EditarCuentasToolStripMenuItem
        ' 
        EditarCuentasToolStripMenuItem.Name = "EditarCuentasToolStripMenuItem"
        EditarCuentasToolStripMenuItem.Size = New Size(201, 26)
        EditarCuentasToolStripMenuItem.Text = "Editar cuentas"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ColCta, ColNom})
        DataGridView1.Location = New Point(25, 58)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(618, 343)
        DataGridView1.TabIndex = 1
        ' 
        ' ColCta
        ' 
        ColCta.HeaderText = "Cuenta"
        ColCta.MinimumWidth = 6
        ColCta.Name = "ColCta"
        ColCta.Width = 125
        ' 
        ' ColNom
        ' 
        ColNom.HeaderText = "Nombre"
        ColNom.MinimumWidth = 6
        ColNom.Name = "ColNom"
        ColNom.Width = 125
        ' 
        ' HScrollBar1
        ' 
        HScrollBar1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        HScrollBar1.Location = New Point(0, 427)
        HScrollBar1.Name = "HScrollBar1"
        HScrollBar1.Size = New Size(688, 15)
        HScrollBar1.TabIndex = 2
        ' 
        ' CAP_CatCuentasMayor
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(688, 438)
        Controls.Add(HScrollBar1)
        Controls.Add(DataGridView1)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "CAP_CatCuentasMayor"
        Text = "CAP_CatCuentasMayor"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlfabéticamenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuméricamenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarSelecciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarCuentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents ColCta As DataGridViewTextBoxColumn
    Friend WithEvents ColNom As DataGridViewTextBoxColumn
End Class
