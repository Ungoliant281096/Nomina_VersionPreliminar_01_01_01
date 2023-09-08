<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAP_ArchivosActualizados
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
        CopiarSelecciónCtrlTToolStripMenuItem = New ToolStripMenuItem()
        CopiarToolStripMenuItem = New ToolStripMenuItem()
        DataGridView1 = New DataGridView()
        ColMes = New DataGridViewTextBoxColumn()
        ColRegistros = New DataGridViewTextBoxColumn()
        ColPoliza = New DataGridViewTextBoxColumn()
        ColEstado = New DataGridViewTextBoxColumn()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(417, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CopiarSelecciónCtrlTToolStripMenuItem, CopiarToolStripMenuItem})
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(62, 24)
        ArchivoToolStripMenuItem.Text = "Editar"
        ' 
        ' CopiarSelecciónCtrlTToolStripMenuItem
        ' 
        CopiarSelecciónCtrlTToolStripMenuItem.Name = "CopiarSelecciónCtrlTToolStripMenuItem"
        CopiarSelecciónCtrlTToolStripMenuItem.Size = New Size(267, 26)
        CopiarSelecciónCtrlTToolStripMenuItem.Text = "Copiar selección    Ctrl + C"
        ' 
        ' CopiarToolStripMenuItem
        ' 
        CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        CopiarToolStripMenuItem.Size = New Size(267, 26)
        CopiarToolStripMenuItem.Text = "Copiar todo           Ctrl + S"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ColMes, ColRegistros, ColPoliza, ColEstado})
        DataGridView1.Location = New Point(17, 50)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(379, 364)
        DataGridView1.TabIndex = 1
        ' 
        ' ColMes
        ' 
        ColMes.HeaderText = "Mes"
        ColMes.MinimumWidth = 6
        ColMes.Name = "ColMes"
        ColMes.Width = 125
        ' 
        ' ColRegistros
        ' 
        ColRegistros.HeaderText = "Registros"
        ColRegistros.MinimumWidth = 6
        ColRegistros.Name = "ColRegistros"
        ColRegistros.Width = 125
        ' 
        ' ColPoliza
        ' 
        ColPoliza.HeaderText = "Póliza"
        ColPoliza.MinimumWidth = 6
        ColPoliza.Name = "ColPoliza"
        ColPoliza.Width = 125
        ' 
        ' ColEstado
        ' 
        ColEstado.HeaderText = "Estado"
        ColEstado.MinimumWidth = 6
        ColEstado.Name = "ColEstado"
        ColEstado.Width = 125
        ' 
        ' CAP_ArchivosActualizados
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(417, 457)
        Controls.Add(DataGridView1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "CAP_ArchivosActualizados"
        Text = "CAP_ArchivosActualizados"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarSelecciónCtrlTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ColMes As DataGridViewTextBoxColumn
    Friend WithEvents ColRegistros As DataGridViewTextBoxColumn
    Friend WithEvents ColPoliza As DataGridViewTextBoxColumn
    Friend WithEvents ColEstado As DataGridViewTextBoxColumn
End Class
