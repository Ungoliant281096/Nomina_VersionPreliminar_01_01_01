<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAP_SubCuentas
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
        VerToolStripMenuItem = New ToolStripMenuItem()
        AlfabéticamenteToolStripMenuItem = New ToolStripMenuItem()
        NuméricamenteToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        EdiciónToolStripMenuItem = New ToolStripMenuItem()
        CopiarSelecciónCtrlCToolStripMenuItem = New ToolStripMenuItem()
        CopiarTodoCtrlSToolStripMenuItem = New ToolStripMenuItem()
        TextBox1 = New TextBox()
        DataGridView1 = New DataGridView()
        ColSubCta = New DataGridViewTextBoxColumn()
        ColNom = New DataGridViewTextBoxColumn()
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
        MenuStrip1.Size = New Size(446, 28)
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
        EdiciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CopiarSelecciónCtrlCToolStripMenuItem, CopiarTodoCtrlSToolStripMenuItem})
        EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        EdiciónToolStripMenuItem.Size = New Size(72, 24)
        EdiciónToolStripMenuItem.Text = "Edición"
        ' 
        ' CopiarSelecciónCtrlCToolStripMenuItem
        ' 
        CopiarSelecciónCtrlCToolStripMenuItem.Name = "CopiarSelecciónCtrlCToolStripMenuItem"
        CopiarSelecciónCtrlCToolStripMenuItem.Size = New Size(289, 26)
        CopiarSelecciónCtrlCToolStripMenuItem.Text = "Copiar selección        Ctrl + C"
        ' 
        ' CopiarTodoCtrlSToolStripMenuItem
        ' 
        CopiarTodoCtrlSToolStripMenuItem.Name = "CopiarTodoCtrlSToolStripMenuItem"
        CopiarTodoCtrlSToolStripMenuItem.Size = New Size(289, 26)
        CopiarTodoCtrlSToolStripMenuItem.Text = "Copiar todo                 Ctrl + S"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 31)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(416, 27)
        TextBox1.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ColSubCta, ColNom})
        DataGridView1.Location = New Point(12, 92)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(416, 315)
        DataGridView1.TabIndex = 2
        ' 
        ' ColSubCta
        ' 
        ColSubCta.HeaderText = "SubCuenta"
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
        ' CAP_SubCuentas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(446, 368)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "CAP_SubCuentas"
        Text = "CAP_SubCuentas"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlfabéticamenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuméricamenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarSelecciónCtrlCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarTodoCtrlSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ColSubCta As DataGridViewTextBoxColumn
    Friend WithEvents ColNom As DataGridViewTextBoxColumn
End Class
