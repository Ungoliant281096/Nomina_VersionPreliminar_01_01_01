<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAP_PolizasDiario
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(CAP_PolizasDiario))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        MenuStrip1 = New MenuStrip()
        ArchivoToolStripMenuItem = New ToolStripMenuItem()
        CambioDirectorioToolStripMenuItem = New ToolStripMenuItem()
        VerListasDePólizasCtrlZToolStripMenuItem = New ToolStripMenuItem()
        AbrirCtrlRToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        EdiciónToolStripMenuItem = New ToolStripMenuItem()
        CopiarSelecciónCtrlCToolStripMenuItem = New ToolStripMenuItem()
        CopiarCtrlCToolStripMenuItem = New ToolStripMenuItem()
        ImprimirToolStripMenuItem = New ToolStripMenuItem()
        RangoToolStripMenuItem = New ToolStripMenuItem()
        TodasToolStripMenuItem = New ToolStripMenuItem()
        GroupBox1 = New GroupBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox8 = New PictureBox()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        ColCta = New DataGridViewTextBoxColumn()
        ColSubCta = New DataGridViewTextBoxColumn()
        ColNom = New DataGridViewTextBoxColumn()
        ColParcial = New DataGridViewTextBoxColumn()
        ColDebe = New DataGridViewTextBoxColumn()
        ColHaber = New DataGridViewTextBoxColumn()
        ColRedac = New DataGridViewTextBoxColumn()
        ColFolioFis = New DataGridViewTextBoxColumn()
        VScrollBar1 = New VScrollBar()
        OpenFileDialog1 = New OpenFileDialog()
        OpenFileDialog2 = New OpenFileDialog()
        MenuStrip1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem, EdiciónToolStripMenuItem, ImprimirToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1147, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CambioDirectorioToolStripMenuItem, VerListasDePólizasCtrlZToolStripMenuItem, AbrirCtrlRToolStripMenuItem, SalirToolStripMenuItem})
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(73, 24)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' CambioDirectorioToolStripMenuItem
        ' 
        CambioDirectorioToolStripMenuItem.Name = "CambioDirectorioToolStripMenuItem"
        CambioDirectorioToolStripMenuItem.Size = New Size(319, 26)
        CambioDirectorioToolStripMenuItem.Text = "Cambio Directorio"
        ' 
        ' VerListasDePólizasCtrlZToolStripMenuItem
        ' 
        VerListasDePólizasCtrlZToolStripMenuItem.Name = "VerListasDePólizasCtrlZToolStripMenuItem"
        VerListasDePólizasCtrlZToolStripMenuItem.Size = New Size(319, 26)
        VerListasDePólizasCtrlZToolStripMenuItem.Text = "Ver listas de pólizas           Ctrl + Z"
        ' 
        ' AbrirCtrlRToolStripMenuItem
        ' 
        AbrirCtrlRToolStripMenuItem.Name = "AbrirCtrlRToolStripMenuItem"
        AbrirCtrlRToolStripMenuItem.Size = New Size(319, 26)
        AbrirCtrlRToolStripMenuItem.Text = "Abrir                                    Ctrl + R"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(319, 26)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' EdiciónToolStripMenuItem
        ' 
        EdiciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CopiarSelecciónCtrlCToolStripMenuItem, CopiarCtrlCToolStripMenuItem})
        EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        EdiciónToolStripMenuItem.Size = New Size(72, 24)
        EdiciónToolStripMenuItem.Text = "Edición"
        ' 
        ' CopiarSelecciónCtrlCToolStripMenuItem
        ' 
        CopiarSelecciónCtrlCToolStripMenuItem.Name = "CopiarSelecciónCtrlCToolStripMenuItem"
        CopiarSelecciónCtrlCToolStripMenuItem.Size = New Size(274, 26)
        CopiarSelecciónCtrlCToolStripMenuItem.Text = "Copiar selección      "
        ' 
        ' CopiarCtrlCToolStripMenuItem
        ' 
        CopiarCtrlCToolStripMenuItem.Name = "CopiarCtrlCToolStripMenuItem"
        CopiarCtrlCToolStripMenuItem.Size = New Size(274, 26)
        CopiarCtrlCToolStripMenuItem.Text = "Copiar                      Ctrl + C"
        ' 
        ' ImprimirToolStripMenuItem
        ' 
        ImprimirToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RangoToolStripMenuItem, TodasToolStripMenuItem})
        ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        ImprimirToolStripMenuItem.Size = New Size(80, 24)
        ImprimirToolStripMenuItem.Text = "Imprimir"
        ' 
        ' RangoToolStripMenuItem
        ' 
        RangoToolStripMenuItem.Name = "RangoToolStripMenuItem"
        RangoToolStripMenuItem.Size = New Size(135, 26)
        RangoToolStripMenuItem.Text = "Rango"
        ' 
        ' TodasToolStripMenuItem
        ' 
        TodasToolStripMenuItem.Name = "TodasToolStripMenuItem"
        TodasToolStripMenuItem.Size = New Size(135, 26)
        TodasToolStripMenuItem.Text = "Todas"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ActiveBorder
        GroupBox1.Controls.Add(PictureBox2)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(PictureBox8)
        GroupBox1.Location = New Point(26, 46)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(313, 33)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(161, 5)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(25, 24)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 38
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(89, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(25, 24)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 37
        PictureBox1.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(19, 5)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(25, 24)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 36
        PictureBox8.TabStop = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(376, 51)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(302, 28)
        ComboBox1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ActiveBorder
        Label1.Location = New Point(30, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(723, 29)
        Label1.TabIndex = 3
        Label1.Text = "Label1"
        ' 
        ' DataGridView1
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ColCta, ColSubCta, ColNom, ColParcial, ColDebe, ColHaber, ColRedac, ColFolioFis})
        DataGridView1.Location = New Point(12, 85)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(1086, 719)
        DataGridView1.TabIndex = 4
        ' 
        ' ColCta
        ' 
        ColCta.HeaderText = "Cuenta"
        ColCta.MinimumWidth = 6
        ColCta.Name = "ColCta"
        ColCta.Width = 125
        ' 
        ' ColSubCta
        ' 
        ColSubCta.HeaderText = "SubCta"
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
        ' ColParcial
        ' 
        ColParcial.HeaderText = "Parcial"
        ColParcial.MinimumWidth = 6
        ColParcial.Name = "ColParcial"
        ColParcial.Width = 125
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
        ' ColRedac
        ' 
        ColRedac.HeaderText = "Redacción"
        ColRedac.MinimumWidth = 6
        ColRedac.Name = "ColRedac"
        ColRedac.Width = 125
        ' 
        ' ColFolioFis
        ' 
        ColFolioFis.HeaderText = "Folio Fiscal"
        ColFolioFis.MinimumWidth = 6
        ColFolioFis.Name = "ColFolioFis"
        ColFolioFis.Width = 125
        ' 
        ' VScrollBar1
        ' 
        VScrollBar1.Location = New Point(1135, 28)
        VScrollBar1.Name = "VScrollBar1"
        VScrollBar1.Size = New Size(12, 635)
        VScrollBar1.TabIndex = 5
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' OpenFileDialog2
        ' 
        OpenFileDialog2.FileName = "OpenFileDialog2"
        ' 
        ' CAP_PolizasDiario
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1147, 629)
        Controls.Add(VScrollBar1)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "CAP_PolizasDiario"
        Text = "CAP_PolizasDiario"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CambioDirectorioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerListasDePólizasCtrlZToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirCtrlRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarSelecciónCtrlCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarCtrlCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RangoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TodasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ColCta As DataGridViewTextBoxColumn
    Friend WithEvents ColSubCta As DataGridViewTextBoxColumn
    Friend WithEvents ColNom As DataGridViewTextBoxColumn
    Friend WithEvents ColParcial As DataGridViewTextBoxColumn
    Friend WithEvents ColDebe As DataGridViewTextBoxColumn
    Friend WithEvents ColHaber As DataGridViewTextBoxColumn
    Friend WithEvents ColRedac As DataGridViewTextBoxColumn
    Friend WithEvents ColFolioFis As DataGridViewTextBoxColumn
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
End Class
