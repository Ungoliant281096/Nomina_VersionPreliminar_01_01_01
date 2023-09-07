<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAP_Balance
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
        ImprimirToolStripMenuItem = New ToolStripMenuItem()
        EdiciónToolStripMenuItem = New ToolStripMenuItem()
        FormatoToolStripMenuItem = New ToolStripMenuItem()
        BalanceToolStripMenuItem = New ToolStripMenuItem()
        GeneraArchivoToolStripMenuItem = New ToolStripMenuItem()
        CopiarSelecciónToolStripMenuItem = New ToolStripMenuItem()
        CopiarTodoCtrlTToolStripMenuItem = New ToolStripMenuItem()
        FormatoYTipoDeLetraToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        Label2 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        DataGridView1 = New DataGridView()
        VScrollBar1 = New VScrollBar()
        HScrollBar1 = New HScrollBar()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ImprimirToolStripMenuItem, EdiciónToolStripMenuItem, FormatoToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ImprimirToolStripMenuItem
        ' 
        ImprimirToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BalanceToolStripMenuItem, GeneraArchivoToolStripMenuItem})
        ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        ImprimirToolStripMenuItem.Size = New Size(80, 24)
        ImprimirToolStripMenuItem.Text = "Imprimir"
        ' 
        ' EdiciónToolStripMenuItem
        ' 
        EdiciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CopiarSelecciónToolStripMenuItem, CopiarTodoCtrlTToolStripMenuItem})
        EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        EdiciónToolStripMenuItem.Size = New Size(72, 24)
        EdiciónToolStripMenuItem.Text = "Edición"
        ' 
        ' FormatoToolStripMenuItem
        ' 
        FormatoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FormatoYTipoDeLetraToolStripMenuItem})
        FormatoToolStripMenuItem.Name = "FormatoToolStripMenuItem"
        FormatoToolStripMenuItem.Size = New Size(79, 24)
        FormatoToolStripMenuItem.Text = "Formato"
        ' 
        ' BalanceToolStripMenuItem
        ' 
        BalanceToolStripMenuItem.Name = "BalanceToolStripMenuItem"
        BalanceToolStripMenuItem.Size = New Size(224, 26)
        BalanceToolStripMenuItem.Text = "Balance"
        ' 
        ' GeneraArchivoToolStripMenuItem
        ' 
        GeneraArchivoToolStripMenuItem.Name = "GeneraArchivoToolStripMenuItem"
        GeneraArchivoToolStripMenuItem.Size = New Size(224, 26)
        GeneraArchivoToolStripMenuItem.Text = "Genera archivo"
        ' 
        ' CopiarSelecciónToolStripMenuItem
        ' 
        CopiarSelecciónToolStripMenuItem.Name = "CopiarSelecciónToolStripMenuItem"
        CopiarSelecciónToolStripMenuItem.Size = New Size(283, 26)
        CopiarSelecciónToolStripMenuItem.Text = "Copiar selección        Ctrl + C"
        ' 
        ' CopiarTodoCtrlTToolStripMenuItem
        ' 
        CopiarTodoCtrlTToolStripMenuItem.Name = "CopiarTodoCtrlTToolStripMenuItem"
        CopiarTodoCtrlTToolStripMenuItem.Size = New Size(283, 26)
        CopiarTodoCtrlTToolStripMenuItem.Text = "Copiar todo               Ctrl + S"
        ' 
        ' FormatoYTipoDeLetraToolStripMenuItem
        ' 
        FormatoYTipoDeLetraToolStripMenuItem.Name = "FormatoYTipoDeLetraToolStripMenuItem"
        FormatoYTipoDeLetraToolStripMenuItem.Size = New Size(245, 26)
        FormatoYTipoDeLetraToolStripMenuItem.Text = "Formato y tipo de letra"
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ActiveBorder
        Label1.Location = New Point(88, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(628, 33)
        Label1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.BackColor = SystemColors.ActiveBorder
        Label2.Location = New Point(88, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(628, 34)
        Label2.TabIndex = 2
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(89, 146)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(635, 508)
        DataGridView1.TabIndex = 3
        ' 
        ' VScrollBar1
        ' 
        VScrollBar1.Location = New Point(707, 146)
        VScrollBar1.Name = "VScrollBar1"
        VScrollBar1.Size = New Size(17, 491)
        VScrollBar1.TabIndex = 4
        ' 
        ' HScrollBar1
        ' 
        HScrollBar1.Location = New Point(88, 637)
        HScrollBar1.Name = "HScrollBar1"
        HScrollBar1.Size = New Size(636, 17)
        HScrollBar1.TabIndex = 5
        ' 
        ' CAP_Balance
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 732)
        Controls.Add(HScrollBar1)
        Controls.Add(VScrollBar1)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "CAP_Balance"
        Text = "CAP_Balance"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BalanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeneraArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarSelecciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarTodoCtrlTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatoYTipoDeLetraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents HScrollBar1 As HScrollBar
End Class
