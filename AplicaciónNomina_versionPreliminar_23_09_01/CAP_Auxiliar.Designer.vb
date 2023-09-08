<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAP_Auxiliar
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
        ImpreToolStripMenuItem = New ToolStripMenuItem()
        ImprimirToolStripMenuItem = New ToolStripMenuItem()
        EdiciónToolStripMenuItem = New ToolStripMenuItem()
        CopiarSelecciónCtrlCToolStripMenuItem = New ToolStripMenuItem()
        SeleccionarTodoCtrlSToolStripMenuItem = New ToolStripMenuItem()
        DepurarToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        ColFecha = New DataGridViewTextBoxColumn()
        ColPol = New DataGridViewTextBoxColumn()
        ColDesc = New DataGridViewTextBoxColumn()
        ColDebe = New DataGridViewTextBoxColumn()
        ColHaber = New DataGridViewTextBoxColumn()
        ColSaldo = New DataGridViewTextBoxColumn()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ImpreToolStripMenuItem, EdiciónToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ImpreToolStripMenuItem
        ' 
        ImpreToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ImprimirToolStripMenuItem})
        ImpreToolStripMenuItem.Name = "ImpreToolStripMenuItem"
        ImpreToolStripMenuItem.Size = New Size(89, 24)
        ImpreToolStripMenuItem.Text = "Impresión"
        ' 
        ' ImprimirToolStripMenuItem
        ' 
        ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        ImprimirToolStripMenuItem.Size = New Size(149, 26)
        ImprimirToolStripMenuItem.Text = "Imprimir"
        ' 
        ' EdiciónToolStripMenuItem
        ' 
        EdiciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CopiarSelecciónCtrlCToolStripMenuItem, SeleccionarTodoCtrlSToolStripMenuItem, DepurarToolStripMenuItem})
        EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        EdiciónToolStripMenuItem.Size = New Size(72, 24)
        EdiciónToolStripMenuItem.Text = "Edición"
        ' 
        ' CopiarSelecciónCtrlCToolStripMenuItem
        ' 
        CopiarSelecciónCtrlCToolStripMenuItem.Name = "CopiarSelecciónCtrlCToolStripMenuItem"
        CopiarSelecciónCtrlCToolStripMenuItem.Size = New Size(281, 26)
        CopiarSelecciónCtrlCToolStripMenuItem.Text = "Copiar selección       Ctrl + C"
        ' 
        ' SeleccionarTodoCtrlSToolStripMenuItem
        ' 
        SeleccionarTodoCtrlSToolStripMenuItem.Name = "SeleccionarTodoCtrlSToolStripMenuItem"
        SeleccionarTodoCtrlSToolStripMenuItem.Size = New Size(281, 26)
        SeleccionarTodoCtrlSToolStripMenuItem.Text = "Seleccionar todo       Ctrl + S"
        ' 
        ' DepurarToolStripMenuItem
        ' 
        DepurarToolStripMenuItem.Name = "DepurarToolStripMenuItem"
        DepurarToolStripMenuItem.Size = New Size(281, 26)
        DepurarToolStripMenuItem.Text = "Depurar"
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ActiveBorder
        Label1.Location = New Point(27, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(347, 59)
        Label1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.BackColor = SystemColors.ActiveBorder
        Label2.Location = New Point(397, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(378, 59)
        Label2.TabIndex = 2
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ColFecha, ColPol, ColDesc, ColDebe, ColHaber, ColSaldo})
        DataGridView1.Location = New Point(30, 138)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(744, 423)
        DataGridView1.TabIndex = 3
        ' 
        ' ColFecha
        ' 
        ColFecha.HeaderText = "Fecha"
        ColFecha.MinimumWidth = 6
        ColFecha.Name = "ColFecha"
        ColFecha.Width = 125
        ' 
        ' ColPol
        ' 
        ColPol.HeaderText = "Póliza"
        ColPol.MinimumWidth = 6
        ColPol.Name = "ColPol"
        ColPol.Width = 125
        ' 
        ' ColDesc
        ' 
        ColDesc.HeaderText = "Descripción"
        ColDesc.MinimumWidth = 6
        ColDesc.Name = "ColDesc"
        ColDesc.Width = 125
        ' 
        ' ColDebe
        ' 
        ColDebe.HeaderText = "Debe"
        ColDebe.MinimumWidth = 6
        ColDebe.Name = "ColDebe"
        ColDebe.Width = 125
        ' 
        ' ColHaber
        ' 
        ColHaber.HeaderText = "Haber"
        ColHaber.MinimumWidth = 6
        ColHaber.Name = "ColHaber"
        ColHaber.Width = 125
        ' 
        ' ColSaldo
        ' 
        ColSaldo.HeaderText = "Saldo"
        ColSaldo.MinimumWidth = 6
        ColSaldo.Name = "ColSaldo"
        ColSaldo.Width = 125
        ' 
        ' CAP_Auxiliar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "CAP_Auxiliar"
        Text = "CAP_Auxiliar"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ImpreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarSelecciónCtrlCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeleccionarTodoCtrlSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepurarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ColFecha As DataGridViewTextBoxColumn
    Friend WithEvents ColPol As DataGridViewTextBoxColumn
    Friend WithEvents ColDesc As DataGridViewTextBoxColumn
    Friend WithEvents ColDebe As DataGridViewTextBoxColumn
    Friend WithEvents ColHaber As DataGridViewTextBoxColumn
    Friend WithEvents ColSaldo As DataGridViewTextBoxColumn
End Class
