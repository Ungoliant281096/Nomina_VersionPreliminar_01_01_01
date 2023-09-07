<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NOM_TraspasoBanamexExcel
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
        GenerarBxnToolStripMenuItem = New ToolStripMenuItem()
        GenerarTXTToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        SeleccionarTodoToolStripMenuItem = New ToolStripMenuItem()
        CopiarCtrlCToolStripMenuItem = New ToolStripMenuItem()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        DataGridView2 = New DataGridView()
        HScrollBar1 = New HScrollBar()
        VScrollBar1 = New VScrollBar()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem, EdiciónToolStripMenuItem, GenerarBxnToolStripMenuItem, GenerarTXTToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(991, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SalirToolStripMenuItem})
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(73, 24)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' EdiciónToolStripMenuItem
        ' 
        EdiciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SeleccionarTodoToolStripMenuItem, CopiarCtrlCToolStripMenuItem})
        EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        EdiciónToolStripMenuItem.Size = New Size(72, 24)
        EdiciónToolStripMenuItem.Text = "Edición"
        ' 
        ' GenerarBxnToolStripMenuItem
        ' 
        GenerarBxnToolStripMenuItem.Name = "GenerarBxnToolStripMenuItem"
        GenerarBxnToolStripMenuItem.Size = New Size(103, 24)
        GenerarBxnToolStripMenuItem.Text = "Generar Bxn"
        ' 
        ' GenerarTXTToolStripMenuItem
        ' 
        GenerarTXTToolStripMenuItem.Name = "GenerarTXTToolStripMenuItem"
        GenerarTXTToolStripMenuItem.Size = New Size(104, 24)
        GenerarTXTToolStripMenuItem.Text = "Generar TXT"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(224, 26)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' SeleccionarTodoToolStripMenuItem
        ' 
        SeleccionarTodoToolStripMenuItem.Name = "SeleccionarTodoToolStripMenuItem"
        SeleccionarTodoToolStripMenuItem.Size = New Size(262, 26)
        SeleccionarTodoToolStripMenuItem.Text = "Seleccionar todo"
        ' 
        ' CopiarCtrlCToolStripMenuItem
        ' 
        CopiarCtrlCToolStripMenuItem.Name = "CopiarCtrlCToolStripMenuItem"
        CopiarCtrlCToolStripMenuItem.Size = New Size(262, 26)
        CopiarCtrlCToolStripMenuItem.Text = "Copiar                   Ctrl + C"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 52)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(967, 369)
        DataGridView1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(34, 449)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 20)
        Label1.TabIndex = 2
        Label1.Text = "Secuencial 4 digítos"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(230, 449)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 20)
        Label2.TabIndex = 3
        Label2.Text = "Fecha:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(343, 449)
        Label3.Name = "Label3"
        Label3.Size = New Size(138, 20)
        Label3.TabIndex = 4
        Label3.Text = "# Cliente 12 digítos"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(561, 449)
        Label4.Name = "Label4"
        Label4.Size = New Size(203, 20)
        Label4.TabIndex = 5
        Label4.Text = "Nombre de cliente 36 digítos"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(817, 449)
        Label5.Name = "Label5"
        Label5.Size = New Size(142, 20)
        Label5.TabIndex = 6
        Label5.Text = "# Usuario 12 digítos"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(34, 487)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(203, 487)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(112, 27)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(343, 487)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(162, 27)
        TextBox3.TabIndex = 9
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(534, 487)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(251, 27)
        TextBox4.TabIndex = 10
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(817, 487)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(162, 27)
        TextBox5.TabIndex = 11
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(21, 542)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.RowTemplate.Height = 29
        DataGridView2.Size = New Size(956, 210)
        DataGridView2.TabIndex = 12
        ' 
        ' HScrollBar1
        ' 
        HScrollBar1.Location = New Point(21, 741)
        HScrollBar1.Name = "HScrollBar1"
        HScrollBar1.Size = New Size(954, 11)
        HScrollBar1.TabIndex = 13
        ' 
        ' VScrollBar1
        ' 
        VScrollBar1.Location = New Point(975, 29)
        VScrollBar1.Name = "VScrollBar1"
        VScrollBar1.Size = New Size(20, 723)
        VScrollBar1.TabIndex = 14
        ' 
        ' NOM_TraspasoBanamexExcel
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(991, 772)
        Controls.Add(VScrollBar1)
        Controls.Add(HScrollBar1)
        Controls.Add(DataGridView2)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "NOM_TraspasoBanamexExcel"
        Text = "NOM_TraspasoBanamexExcel"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeleccionarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarCtrlCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerarBxnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerarTXTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents VScrollBar1 As VScrollBar
End Class
