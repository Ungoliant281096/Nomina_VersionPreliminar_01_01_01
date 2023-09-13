<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAP_EstadoResultados
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
        ImpresiónToolStripMenuItem = New ToolStripMenuItem()
        EdiciónToolStripMenuItem = New ToolStripMenuItem()
        EstadoDeResultadosToolStripMenuItem = New ToolStripMenuItem()
        CopiarToolStripMenuItem = New ToolStripMenuItem()
        CopiarSelecciónCtrlCToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        VScrollBar1 = New VScrollBar()
        HScrollBar1 = New HScrollBar()
        OpenFileDialog1 = New OpenFileDialog()
        ColCta = New DataGridViewTextBoxColumn()
        ColPar = New DataGridViewTextBoxColumn()
        ColImpte = New DataGridViewTextBoxColumn()
        ColDin = New DataGridViewTextBoxColumn()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ImpresiónToolStripMenuItem, EdiciónToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(549, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ImpresiónToolStripMenuItem
        ' 
        ImpresiónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {EstadoDeResultadosToolStripMenuItem})
        ImpresiónToolStripMenuItem.Name = "ImpresiónToolStripMenuItem"
        ImpresiónToolStripMenuItem.Size = New Size(89, 24)
        ImpresiónToolStripMenuItem.Text = "Impresión"
        ' 
        ' EdiciónToolStripMenuItem
        ' 
        EdiciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CopiarToolStripMenuItem, CopiarSelecciónCtrlCToolStripMenuItem})
        EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        EdiciónToolStripMenuItem.Size = New Size(72, 24)
        EdiciónToolStripMenuItem.Text = "Edición"
        ' 
        ' EstadoDeResultadosToolStripMenuItem
        ' 
        EstadoDeResultadosToolStripMenuItem.Name = "EstadoDeResultadosToolStripMenuItem"
        EstadoDeResultadosToolStripMenuItem.Size = New Size(230, 26)
        EstadoDeResultadosToolStripMenuItem.Text = "Estado de resultados"
        ' 
        ' CopiarToolStripMenuItem
        ' 
        CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        CopiarToolStripMenuItem.Size = New Size(291, 26)
        CopiarToolStripMenuItem.Text = "Copiar "
        ' 
        ' CopiarSelecciónCtrlCToolStripMenuItem
        ' 
        CopiarSelecciónCtrlCToolStripMenuItem.Name = "CopiarSelecciónCtrlCToolStripMenuItem"
        CopiarSelecciónCtrlCToolStripMenuItem.Size = New Size(311, 26)
        CopiarSelecciónCtrlCToolStripMenuItem.Text = "Copiar selección               Ctrl + C"
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ActiveBorder
        Label1.Location = New Point(62, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(426, 41)
        Label1.TabIndex = 1
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.BackColor = SystemColors.ActiveBorder
        Label2.Location = New Point(62, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(426, 43)
        Label2.TabIndex = 2
        Label2.Text = "Label2"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ColCta, ColPar, ColImpte, ColDin})
        DataGridView1.Location = New Point(58, 165)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(436, 443)
        DataGridView1.TabIndex = 3
        ' 
        ' VScrollBar1
        ' 
        VScrollBar1.Location = New Point(473, 165)
        VScrollBar1.Name = "VScrollBar1"
        VScrollBar1.Size = New Size(21, 445)
        VScrollBar1.TabIndex = 4
        ' 
        ' HScrollBar1
        ' 
        HScrollBar1.Location = New Point(58, 592)
        HScrollBar1.Name = "HScrollBar1"
        HScrollBar1.Size = New Size(415, 16)
        HScrollBar1.TabIndex = 5
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' ColCta
        ' 
        ColCta.HeaderText = "CUENTA"
        ColCta.MinimumWidth = 6
        ColCta.Name = "ColCta"
        ColCta.Width = 125
        ' 
        ' ColPar
        ' 
        ColPar.HeaderText = "PARCIAL"
        ColPar.MinimumWidth = 6
        ColPar.Name = "ColPar"
        ColPar.Width = 125
        ' 
        ' ColImpte
        ' 
        ColImpte.HeaderText = "IMPORTE"
        ColImpte.MinimumWidth = 6
        ColImpte.Name = "ColImpte"
        ColImpte.Width = 125
        ' 
        ' ColDin
        ' 
        ColDin.HeaderText = "$"
        ColDin.MinimumWidth = 6
        ColDin.Name = "ColDin"
        ColDin.Width = 125
        ' 
        ' CAP_EstadoResultados
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(549, 692)
        Controls.Add(HScrollBar1)
        Controls.Add(VScrollBar1)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "CAP_EstadoResultados"
        Text = "CAP_EstadoResultados"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ImpresiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadoDeResultadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarSelecciónCtrlCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ColCta As DataGridViewTextBoxColumn
    Friend WithEvents ColPar As DataGridViewTextBoxColumn
    Friend WithEvents ColImpte As DataGridViewTextBoxColumn
    Friend WithEvents ColDin As DataGridViewTextBoxColumn
End Class
