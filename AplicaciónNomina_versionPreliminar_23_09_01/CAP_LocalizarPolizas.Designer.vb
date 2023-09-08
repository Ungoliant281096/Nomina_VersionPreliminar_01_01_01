<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAP_LocalizarPolizas
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
        EdiciónToolStripMenuItem = New ToolStripMenuItem()
        GenerarPólizasEnXMLToolStripMenuItem = New ToolStripMenuItem()
        CopiarSelecciónCtrlCToolStripMenuItem = New ToolStripMenuItem()
        CopiarTodoCtrlSToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        ColPoliza = New DataGridViewTextBoxColumn()
        ColConcp = New DataGridViewTextBoxColumn()
        ColRef = New DataGridViewTextBoxColumn()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {EdiciónToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(445, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' EdiciónToolStripMenuItem
        ' 
        EdiciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {GenerarPólizasEnXMLToolStripMenuItem, CopiarSelecciónCtrlCToolStripMenuItem, CopiarTodoCtrlSToolStripMenuItem})
        EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        EdiciónToolStripMenuItem.Size = New Size(72, 24)
        EdiciónToolStripMenuItem.Text = "Edición"
        ' 
        ' GenerarPólizasEnXMLToolStripMenuItem
        ' 
        GenerarPólizasEnXMLToolStripMenuItem.Name = "GenerarPólizasEnXMLToolStripMenuItem"
        GenerarPólizasEnXMLToolStripMenuItem.Size = New Size(339, 26)
        GenerarPólizasEnXMLToolStripMenuItem.Text = "Generar Pólizas del mes a XML"
        ' 
        ' CopiarSelecciónCtrlCToolStripMenuItem
        ' 
        CopiarSelecciónCtrlCToolStripMenuItem.Name = "CopiarSelecciónCtrlCToolStripMenuItem"
        CopiarSelecciónCtrlCToolStripMenuItem.Size = New Size(339, 26)
        CopiarSelecciónCtrlCToolStripMenuItem.Text = "Copiar selección                      Ctrl + C"
        ' 
        ' CopiarTodoCtrlSToolStripMenuItem
        ' 
        CopiarTodoCtrlSToolStripMenuItem.Name = "CopiarTodoCtrlSToolStripMenuItem"
        CopiarTodoCtrlSToolStripMenuItem.Size = New Size(339, 26)
        CopiarTodoCtrlSToolStripMenuItem.Text = "Copiar todo                             Ctrl + S"
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ActiveBorder
        Label1.Location = New Point(132, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(193, 32)
        Label1.TabIndex = 1
        Label1.Text = "Label1"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ColPoliza, ColConcp, ColRef})
        DataGridView1.Location = New Point(18, 90)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(408, 382)
        DataGridView1.TabIndex = 2
        ' 
        ' ColPoliza
        ' 
        ColPoliza.HeaderText = "Póliza"
        ColPoliza.MinimumWidth = 6
        ColPoliza.Name = "ColPoliza"
        ColPoliza.Width = 125
        ' 
        ' ColConcp
        ' 
        ColConcp.HeaderText = "Concepto"
        ColConcp.MinimumWidth = 6
        ColConcp.Name = "ColConcp"
        ColConcp.Width = 125
        ' 
        ' ColRef
        ' 
        ColRef.HeaderText = "Ref."
        ColRef.MinimumWidth = 6
        ColRef.Name = "ColRef"
        ColRef.Width = 125
        ' 
        ' CAP_LocalizarPolizas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(445, 490)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "CAP_LocalizarPolizas"
        Text = "CAP_LocalizarPolizas"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerarPólizasEnXMLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarSelecciónCtrlCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarTodoCtrlSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ColPoliza As DataGridViewTextBoxColumn
    Friend WithEvents ColConcp As DataGridViewTextBoxColumn
    Friend WithEvents ColRef As DataGridViewTextBoxColumn
End Class
