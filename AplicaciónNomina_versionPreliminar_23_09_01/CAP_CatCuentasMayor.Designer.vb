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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CAP_CatCuentasMayor))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlfabéticamenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuméricamenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdiciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarSelecciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarCuentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ColCta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerToolStripMenuItem, Me.EdiciónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(529, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlfabéticamenteToolStripMenuItem, Me.NuméricamenteToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'AlfabéticamenteToolStripMenuItem
        '
        Me.AlfabéticamenteToolStripMenuItem.Name = "AlfabéticamenteToolStripMenuItem"
        Me.AlfabéticamenteToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.AlfabéticamenteToolStripMenuItem.Text = "Alfabéticamente"
        '
        'NuméricamenteToolStripMenuItem
        '
        Me.NuméricamenteToolStripMenuItem.Name = "NuméricamenteToolStripMenuItem"
        Me.NuméricamenteToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.NuméricamenteToolStripMenuItem.Text = "Numéricamente"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'EdiciónToolStripMenuItem
        '
        Me.EdiciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarSelecciónToolStripMenuItem, Me.CopiarTodoToolStripMenuItem, Me.EditarCuentasToolStripMenuItem})
        Me.EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        Me.EdiciónToolStripMenuItem.Size = New System.Drawing.Size(72, 24)
        Me.EdiciónToolStripMenuItem.Text = "Edición"
        '
        'CopiarSelecciónToolStripMenuItem
        '
        Me.CopiarSelecciónToolStripMenuItem.Name = "CopiarSelecciónToolStripMenuItem"
        Me.CopiarSelecciónToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.CopiarSelecciónToolStripMenuItem.Text = "Copiar selección"
        '
        'CopiarTodoToolStripMenuItem
        '
        Me.CopiarTodoToolStripMenuItem.Name = "CopiarTodoToolStripMenuItem"
        Me.CopiarTodoToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.CopiarTodoToolStripMenuItem.Text = "Copiar todo "
        '
        'EditarCuentasToolStripMenuItem
        '
        Me.EditarCuentasToolStripMenuItem.Name = "EditarCuentasToolStripMenuItem"
        Me.EditarCuentasToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.EditarCuentasToolStripMenuItem.Text = "Editar cuentas"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColCta, Me.ColNom})
        Me.DataGridView1.Location = New System.Drawing.Point(25, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(483, 343)
        Me.DataGridView1.TabIndex = 1
        '
        'ColCta
        '
        Me.ColCta.HeaderText = "Cuenta"
        Me.ColCta.MinimumWidth = 6
        Me.ColCta.Name = "ColCta"
        Me.ColCta.Width = 125
        '
        'ColNom
        '
        Me.ColNom.HeaderText = "Nombre"
        Me.ColNom.MinimumWidth = 6
        Me.ColNom.Name = "ColNom"
        Me.ColNom.Width = 125
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HScrollBar1.Location = New System.Drawing.Point(0, 427)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(529, 15)
        Me.HScrollBar1.TabIndex = 2
        '
        'CAP_CatCuentasMayor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 438)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CAP_CatCuentasMayor"
        Me.Text = "CAP_CatCuentasMayor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
