<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAP_AuxiliarMayor
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
        AToolStripMenuItem = New ToolStripMenuItem()
        MenúToolStripMenuItem = New ToolStripMenuItem()
        EdiciónToolStripMenuItem = New ToolStripMenuItem()
        EligirCtrlMToolStripMenuItem = New ToolStripMenuItem()
        ImprimirCtrlPToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        InicioToolStripMenuItem = New ToolStripMenuItem()
        FinalToolStripMenuItem = New ToolStripMenuItem()
        IncorporaciónToolStripMenuItem = New ToolStripMenuItem()
        EneroToolStripMenuItem = New ToolStripMenuItem()
        CopiarSelecciónCtrlCToolStripMenuItem = New ToolStripMenuItem()
        CopiarToolStripMenuItem = New ToolStripMenuItem()
        CopiarTodoCtrlSToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        ColFecha = New DataGridViewTextBoxColumn()
        ColPol = New DataGridViewTextBoxColumn()
        ColRFC = New DataGridViewTextBoxColumn()
        ColFOLIO = New DataGridViewTextBoxColumn()
        ColCONCEP = New DataGridViewTextBoxColumn()
        ColDEBE = New DataGridViewTextBoxColumn()
        ColHABER = New DataGridViewTextBoxColumn()
        ColSALDO = New DataGridViewTextBoxColumn()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {AToolStripMenuItem, MenúToolStripMenuItem, EdiciónToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AToolStripMenuItem
        ' 
        AToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {EligirCtrlMToolStripMenuItem, ImprimirCtrlPToolStripMenuItem, SalirToolStripMenuItem})
        AToolStripMenuItem.Name = "AToolStripMenuItem"
        AToolStripMenuItem.Size = New Size(69, 24)
        AToolStripMenuItem.Text = "Cuenta"
        ' 
        ' MenúToolStripMenuItem
        ' 
        MenúToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {InicioToolStripMenuItem, FinalToolStripMenuItem})
        MenúToolStripMenuItem.Name = "MenúToolStripMenuItem"
        MenúToolStripMenuItem.Size = New Size(50, 24)
        MenúToolStripMenuItem.Text = "Mes"
        ' 
        ' EdiciónToolStripMenuItem
        ' 
        EdiciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CopiarSelecciónCtrlCToolStripMenuItem, CopiarToolStripMenuItem, CopiarTodoCtrlSToolStripMenuItem})
        EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        EdiciónToolStripMenuItem.Size = New Size(72, 24)
        EdiciónToolStripMenuItem.Text = "Edición"
        ' 
        ' EligirCtrlMToolStripMenuItem
        ' 
        EligirCtrlMToolStripMenuItem.Name = "EligirCtrlMToolStripMenuItem"
        EligirCtrlMToolStripMenuItem.Size = New Size(260, 26)
        EligirCtrlMToolStripMenuItem.Text = "Eligir                    Ctrl + M"
        ' 
        ' ImprimirCtrlPToolStripMenuItem
        ' 
        ImprimirCtrlPToolStripMenuItem.Name = "ImprimirCtrlPToolStripMenuItem"
        ImprimirCtrlPToolStripMenuItem.Size = New Size(260, 26)
        ImprimirCtrlPToolStripMenuItem.Text = "Imprimir              Ctrl + P"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(260, 26)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' InicioToolStripMenuItem
        ' 
        InicioToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {IncorporaciónToolStripMenuItem})
        InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        InicioToolStripMenuItem.Size = New Size(224, 26)
        InicioToolStripMenuItem.Text = "Inicio"
        ' 
        ' FinalToolStripMenuItem
        ' 
        FinalToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {EneroToolStripMenuItem})
        FinalToolStripMenuItem.Name = "FinalToolStripMenuItem"
        FinalToolStripMenuItem.Size = New Size(224, 26)
        FinalToolStripMenuItem.Text = "Final"
        ' 
        ' IncorporaciónToolStripMenuItem
        ' 
        IncorporaciónToolStripMenuItem.Name = "IncorporaciónToolStripMenuItem"
        IncorporaciónToolStripMenuItem.Size = New Size(224, 26)
        IncorporaciónToolStripMenuItem.Text = "Incorporación"
        ' 
        ' EneroToolStripMenuItem
        ' 
        EneroToolStripMenuItem.Name = "EneroToolStripMenuItem"
        EneroToolStripMenuItem.Size = New Size(224, 26)
        EneroToolStripMenuItem.Text = "Enero"
        ' 
        ' CopiarSelecciónCtrlCToolStripMenuItem
        ' 
        CopiarSelecciónCtrlCToolStripMenuItem.Name = "CopiarSelecciónCtrlCToolStripMenuItem"
        CopiarSelecciónCtrlCToolStripMenuItem.Size = New Size(299, 26)
        CopiarSelecciónCtrlCToolStripMenuItem.Text = "Copiar selección            Ctrl + C"
        ' 
        ' CopiarToolStripMenuItem
        ' 
        CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        CopiarToolStripMenuItem.Size = New Size(299, 26)
        CopiarToolStripMenuItem.Text = "Copiar"
        ' 
        ' CopiarTodoCtrlSToolStripMenuItem
        ' 
        CopiarTodoCtrlSToolStripMenuItem.Name = "CopiarTodoCtrlSToolStripMenuItem"
        CopiarTodoCtrlSToolStripMenuItem.Size = New Size(299, 26)
        CopiarTodoCtrlSToolStripMenuItem.Text = "Seleccionar todo           Ctrl + S"
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ActiveBorder
        Label1.Location = New Point(23, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(587, 41)
        Label1.TabIndex = 1
        Label1.Text = "Label1"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ColFecha, ColPol, ColRFC, ColFOLIO, ColCONCEP, ColDEBE, ColHABER, ColSALDO})
        DataGridView1.Location = New Point(26, 106)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(732, 412)
        DataGridView1.TabIndex = 2
        ' 
        ' ColFecha
        ' 
        ColFecha.HeaderText = "FECHA"
        ColFecha.MinimumWidth = 6
        ColFecha.Name = "ColFecha"
        ColFecha.Width = 125
        ' 
        ' ColPol
        ' 
        ColPol.HeaderText = "POL."
        ColPol.MinimumWidth = 6
        ColPol.Name = "ColPol"
        ColPol.Width = 125
        ' 
        ' ColRFC
        ' 
        ColRFC.HeaderText = "RFC"
        ColRFC.MinimumWidth = 6
        ColRFC.Name = "ColRFC"
        ColRFC.Width = 125
        ' 
        ' ColFOLIO
        ' 
        ColFOLIO.HeaderText = "FOLIO"
        ColFOLIO.MinimumWidth = 6
        ColFOLIO.Name = "ColFOLIO"
        ColFOLIO.Width = 125
        ' 
        ' ColCONCEP
        ' 
        ColCONCEP.HeaderText = "CONCEPTO"
        ColCONCEP.MinimumWidth = 6
        ColCONCEP.Name = "ColCONCEP"
        ColCONCEP.Width = 125
        ' 
        ' ColDEBE
        ' 
        ColDEBE.HeaderText = "DEBE"
        ColDEBE.MinimumWidth = 6
        ColDEBE.Name = "ColDEBE"
        ColDEBE.Width = 125
        ' 
        ' ColHABER
        ' 
        ColHABER.HeaderText = "HABER"
        ColHABER.MinimumWidth = 6
        ColHABER.Name = "ColHABER"
        ColHABER.Width = 125
        ' 
        ' ColSALDO
        ' 
        ColSALDO.HeaderText = "SALDO"
        ColSALDO.MinimumWidth = 6
        ColSALDO.Name = "ColSALDO"
        ColSALDO.Width = 125
        ' 
        ' CAP_AuxiliarMayor
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "CAP_AuxiliarMayor"
        Text = "CAP_AuxiliarMayor"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EligirCtrlMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirCtrlPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenúToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IncorporaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FinalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EneroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarSelecciónCtrlCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarTodoCtrlSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ColFecha As DataGridViewTextBoxColumn
    Friend WithEvents ColPol As DataGridViewTextBoxColumn
    Friend WithEvents ColRFC As DataGridViewTextBoxColumn
    Friend WithEvents ColFOLIO As DataGridViewTextBoxColumn
    Friend WithEvents ColCONCEP As DataGridViewTextBoxColumn
    Friend WithEvents ColDEBE As DataGridViewTextBoxColumn
    Friend WithEvents ColHABER As DataGridViewTextBoxColumn
    Friend WithEvents ColSALDO As DataGridViewTextBoxColumn
End Class
