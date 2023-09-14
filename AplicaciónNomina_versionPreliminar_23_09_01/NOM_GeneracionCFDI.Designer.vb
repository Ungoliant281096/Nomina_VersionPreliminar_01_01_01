<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NOM_GeneracionCFDI
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
        CopiarCtrCToolStripMenuItem = New ToolStripMenuItem()
        PegarCtrVToolStripMenuItem = New ToolStripMenuItem()
        CAPTIONToolStripMenuItem = New ToolStripMenuItem()
        SeleccionarTodoCtrEToolStripMenuItem = New ToolStripMenuItem()
        SeleccionarYCopiarPrimerPlantillaToolStripMenuItem = New ToolStripMenuItem()
        SeleccionarYCopiarSegundaTablaToolStripMenuItem = New ToolStripMenuItem()
        QuitarTitúlosToolStripMenuItem = New ToolStripMenuItem()
        FijarTítulosCtrlToolStripMenuItem = New ToolStripMenuItem()
        EliminarToolStripMenuItem = New ToolStripMenuItem()
        GenerarExcelToolStripMenuItem = New ToolStripMenuItem()
        TextBox1 = New TextBox()
        DataGridView1 = New DataGridView()
        DataGridView2 = New DataGridView()
        OpenFileDialog1 = New OpenFileDialog()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {EdiciónToolStripMenuItem, EliminarToolStripMenuItem, GenerarExcelToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(884, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' EdiciónToolStripMenuItem
        ' 
        EdiciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CopiarCtrCToolStripMenuItem, PegarCtrVToolStripMenuItem, CAPTIONToolStripMenuItem, SeleccionarTodoCtrEToolStripMenuItem, SeleccionarYCopiarPrimerPlantillaToolStripMenuItem, SeleccionarYCopiarSegundaTablaToolStripMenuItem, QuitarTitúlosToolStripMenuItem, FijarTítulosCtrlToolStripMenuItem})
        EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        EdiciónToolStripMenuItem.Size = New Size(72, 24)
        EdiciónToolStripMenuItem.Text = "Edición"
        ' 
        ' CopiarCtrCToolStripMenuItem
        ' 
        CopiarCtrCToolStripMenuItem.Name = "CopiarCtrCToolStripMenuItem"
        CopiarCtrCToolStripMenuItem.Size = New Size(345, 26)
        CopiarCtrCToolStripMenuItem.Text = "Copiar                                         Ctr+C"
        ' 
        ' PegarCtrVToolStripMenuItem
        ' 
        PegarCtrVToolStripMenuItem.Name = "PegarCtrVToolStripMenuItem"
        PegarCtrVToolStripMenuItem.Size = New Size(345, 26)
        PegarCtrVToolStripMenuItem.Text = "Pegar                                           Ctr+V"
        ' 
        ' CAPTIONToolStripMenuItem
        ' 
        CAPTIONToolStripMenuItem.Name = "CAPTIONToolStripMenuItem"
        CAPTIONToolStripMenuItem.Size = New Size(345, 26)
        CAPTIONToolStripMenuItem.Text = "CAPTION"
        ' 
        ' SeleccionarTodoCtrEToolStripMenuItem
        ' 
        SeleccionarTodoCtrEToolStripMenuItem.Name = "SeleccionarTodoCtrEToolStripMenuItem"
        SeleccionarTodoCtrEToolStripMenuItem.Size = New Size(345, 26)
        SeleccionarTodoCtrEToolStripMenuItem.Text = "Seleccionar todo                          Ctr+E"
        ' 
        ' SeleccionarYCopiarPrimerPlantillaToolStripMenuItem
        ' 
        SeleccionarYCopiarPrimerPlantillaToolStripMenuItem.Name = "SeleccionarYCopiarPrimerPlantillaToolStripMenuItem"
        SeleccionarYCopiarPrimerPlantillaToolStripMenuItem.Size = New Size(345, 26)
        SeleccionarYCopiarPrimerPlantillaToolStripMenuItem.Text = "Seleccionar y copiar primer plantilla"
        ' 
        ' SeleccionarYCopiarSegundaTablaToolStripMenuItem
        ' 
        SeleccionarYCopiarSegundaTablaToolStripMenuItem.Name = "SeleccionarYCopiarSegundaTablaToolStripMenuItem"
        SeleccionarYCopiarSegundaTablaToolStripMenuItem.Size = New Size(345, 26)
        SeleccionarYCopiarSegundaTablaToolStripMenuItem.Text = "Seleccionar y copiar segunda tabla"
        ' 
        ' QuitarTitúlosToolStripMenuItem
        ' 
        QuitarTitúlosToolStripMenuItem.Name = "QuitarTitúlosToolStripMenuItem"
        QuitarTitúlosToolStripMenuItem.Size = New Size(345, 26)
        QuitarTitúlosToolStripMenuItem.Text = "Quitar títulos                    Ctrl + Q"
        ' 
        ' FijarTítulosCtrlToolStripMenuItem
        ' 
        FijarTítulosCtrlToolStripMenuItem.Name = "FijarTítulosCtrlToolStripMenuItem"
        FijarTítulosCtrlToolStripMenuItem.Size = New Size(345, 26)
        FijarTítulosCtrlToolStripMenuItem.Text = "Fijar títulos                       Ctrl + T"
        ' 
        ' EliminarToolStripMenuItem
        ' 
        EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        EliminarToolStripMenuItem.Size = New Size(77, 24)
        EliminarToolStripMenuItem.Text = "Eliminar"
        ' 
        ' GenerarExcelToolStripMenuItem
        ' 
        GenerarExcelToolStripMenuItem.Name = "GenerarExcelToolStripMenuItem"
        GenerarExcelToolStripMenuItem.Size = New Size(113, 24)
        GenerarExcelToolStripMenuItem.Text = "Generar Excel"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(24, 34)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(836, 27)
        TextBox1.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(28, 73)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(831, 255)
        DataGridView1.TabIndex = 2
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(35, 407)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.RowTemplate.Height = 29
        DataGridView2.Size = New Size(552, 125)
        DataGridView2.TabIndex = 3
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' NOM_GeneracionCFDI
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 619)
        Controls.Add(DataGridView2)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "NOM_GeneracionCFDI"
        Text = "NOM_GeneracionCFDI"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarCtrCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PegarCtrVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CAPTIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeleccionarTodoCtrEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerarExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeleccionarYCopiarPrimerPlantillaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeleccionarYCopiarSegundaTablaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitarTitúlosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FijarTítulosCtrlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
