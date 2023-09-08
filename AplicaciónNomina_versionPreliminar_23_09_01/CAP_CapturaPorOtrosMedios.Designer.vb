<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAP_CapturaPorOtrosMedios
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
        GuardarPólizaToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        EdiciónToolStripMenuItem = New ToolStripMenuItem()
        DeshacerToolStripMenuItem = New ToolStripMenuItem()
        CopiarToolStripMenuItem = New ToolStripMenuItem()
        CopiarToolStripMenuItem1 = New ToolStripMenuItem()
        CopiarTodoCtrlSToolStripMenuItem = New ToolStripMenuItem()
        EliminarToolStripMenuItem = New ToolStripMenuItem()
        ValidaciónToolStripMenuItem = New ToolStripMenuItem()
        SumarPólizaToolStripMenuItem = New ToolStripMenuItem()
        MesesToolStripMenuItem = New ToolStripMenuItem()
        IncorporaciónToolStripMenuItem = New ToolStripMenuItem()
        EneroToolStripMenuItem = New ToolStripMenuItem()
        FebreroToolStripMenuItem = New ToolStripMenuItem()
        MarzoToolStripMenuItem = New ToolStripMenuItem()
        AbrilToolStripMenuItem = New ToolStripMenuItem()
        MayoToolStripMenuItem = New ToolStripMenuItem()
        JunioToolStripMenuItem = New ToolStripMenuItem()
        JulioToolStripMenuItem = New ToolStripMenuItem()
        AgostoToolStripMenuItem = New ToolStripMenuItem()
        SeptiembreToolStripMenuItem = New ToolStripMenuItem()
        OctubreToolStripMenuItem = New ToolStripMenuItem()
        NoviembreToolStripMenuItem = New ToolStripMenuItem()
        DiciembreToolStripMenuItem = New ToolStripMenuItem()
        VerToolStripMenuItem = New ToolStripMenuItem()
        CuentasToolStripMenuItem = New ToolStripMenuItem()
        SubCuentasToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label4 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        OpenFileDialog2 = New OpenFileDialog()
        OpenFileDialog3 = New OpenFileDialog()
        Label5 = New Label()
        TextBox5 = New TextBox()
        Label6 = New Label()
        DataGridView1 = New DataGridView()
        ColCta = New DataGridViewTextBoxColumn()
        ColSubCta = New DataGridViewTextBoxColumn()
        ColNom = New DataGridViewTextBoxColumn()
        ColParcial = New DataGridViewTextBoxColumn()
        ColDebe = New DataGridViewTextBoxColumn()
        ColHaber = New DataGridViewTextBoxColumn()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem, EdiciónToolStripMenuItem, ValidaciónToolStripMenuItem, SumarPólizaToolStripMenuItem, MesesToolStripMenuItem, VerToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1281, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {GuardarPólizaToolStripMenuItem, SalirToolStripMenuItem})
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(73, 24)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' GuardarPólizaToolStripMenuItem
        ' 
        GuardarPólizaToolStripMenuItem.Name = "GuardarPólizaToolStripMenuItem"
        GuardarPólizaToolStripMenuItem.Size = New Size(188, 26)
        GuardarPólizaToolStripMenuItem.Text = "Guardar Póliza"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(188, 26)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' EdiciónToolStripMenuItem
        ' 
        EdiciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DeshacerToolStripMenuItem, CopiarToolStripMenuItem, CopiarToolStripMenuItem1, CopiarTodoCtrlSToolStripMenuItem, EliminarToolStripMenuItem})
        EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        EdiciónToolStripMenuItem.Size = New Size(76, 24)
        EdiciónToolStripMenuItem.Text = "Edición "
        ' 
        ' DeshacerToolStripMenuItem
        ' 
        DeshacerToolStripMenuItem.Name = "DeshacerToolStripMenuItem"
        DeshacerToolStripMenuItem.Size = New Size(301, 26)
        DeshacerToolStripMenuItem.Text = "Deshacer"
        ' 
        ' CopiarToolStripMenuItem
        ' 
        CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        CopiarToolStripMenuItem.Size = New Size(301, 26)
        CopiarToolStripMenuItem.Text = "Pegar                              Ctrl + V"
        ' 
        ' CopiarToolStripMenuItem1
        ' 
        CopiarToolStripMenuItem1.Name = "CopiarToolStripMenuItem1"
        CopiarToolStripMenuItem1.Size = New Size(301, 26)
        CopiarToolStripMenuItem1.Text = "Copiar Selección            Ctrl + C"
        ' 
        ' CopiarTodoCtrlSToolStripMenuItem
        ' 
        CopiarTodoCtrlSToolStripMenuItem.Name = "CopiarTodoCtrlSToolStripMenuItem"
        CopiarTodoCtrlSToolStripMenuItem.Size = New Size(301, 26)
        CopiarTodoCtrlSToolStripMenuItem.Text = "Copiar todo                    Ctrl + S"
        ' 
        ' EliminarToolStripMenuItem
        ' 
        EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        EliminarToolStripMenuItem.Size = New Size(301, 26)
        EliminarToolStripMenuItem.Text = "Eliminar"
        ' 
        ' ValidaciónToolStripMenuItem
        ' 
        ValidaciónToolStripMenuItem.Name = "ValidaciónToolStripMenuItem"
        ValidaciónToolStripMenuItem.Size = New Size(92, 24)
        ValidaciónToolStripMenuItem.Text = "Validación"
        ' 
        ' SumarPólizaToolStripMenuItem
        ' 
        SumarPólizaToolStripMenuItem.Name = "SumarPólizaToolStripMenuItem"
        SumarPólizaToolStripMenuItem.Size = New Size(108, 24)
        SumarPólizaToolStripMenuItem.Text = "Sumar Póliza"
        ' 
        ' MesesToolStripMenuItem
        ' 
        MesesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {IncorporaciónToolStripMenuItem, EneroToolStripMenuItem, FebreroToolStripMenuItem, MarzoToolStripMenuItem, AbrilToolStripMenuItem, MayoToolStripMenuItem, JunioToolStripMenuItem, JulioToolStripMenuItem, AgostoToolStripMenuItem, SeptiembreToolStripMenuItem, OctubreToolStripMenuItem, NoviembreToolStripMenuItem, DiciembreToolStripMenuItem})
        MesesToolStripMenuItem.Name = "MesesToolStripMenuItem"
        MesesToolStripMenuItem.Size = New Size(64, 24)
        MesesToolStripMenuItem.Text = "Meses"
        ' 
        ' IncorporaciónToolStripMenuItem
        ' 
        IncorporaciónToolStripMenuItem.Name = "IncorporaciónToolStripMenuItem"
        IncorporaciónToolStripMenuItem.Size = New Size(184, 26)
        IncorporaciónToolStripMenuItem.Text = "Incorporación"
        ' 
        ' EneroToolStripMenuItem
        ' 
        EneroToolStripMenuItem.Name = "EneroToolStripMenuItem"
        EneroToolStripMenuItem.Size = New Size(184, 26)
        EneroToolStripMenuItem.Text = "Enero"
        ' 
        ' FebreroToolStripMenuItem
        ' 
        FebreroToolStripMenuItem.Name = "FebreroToolStripMenuItem"
        FebreroToolStripMenuItem.Size = New Size(184, 26)
        FebreroToolStripMenuItem.Text = "Febrero"
        ' 
        ' MarzoToolStripMenuItem
        ' 
        MarzoToolStripMenuItem.Name = "MarzoToolStripMenuItem"
        MarzoToolStripMenuItem.Size = New Size(184, 26)
        MarzoToolStripMenuItem.Text = "Marzo"
        ' 
        ' AbrilToolStripMenuItem
        ' 
        AbrilToolStripMenuItem.Name = "AbrilToolStripMenuItem"
        AbrilToolStripMenuItem.Size = New Size(184, 26)
        AbrilToolStripMenuItem.Text = "Abril"
        ' 
        ' MayoToolStripMenuItem
        ' 
        MayoToolStripMenuItem.Name = "MayoToolStripMenuItem"
        MayoToolStripMenuItem.Size = New Size(184, 26)
        MayoToolStripMenuItem.Text = "Mayo"
        ' 
        ' JunioToolStripMenuItem
        ' 
        JunioToolStripMenuItem.Name = "JunioToolStripMenuItem"
        JunioToolStripMenuItem.Size = New Size(184, 26)
        JunioToolStripMenuItem.Text = "Junio"
        ' 
        ' JulioToolStripMenuItem
        ' 
        JulioToolStripMenuItem.Name = "JulioToolStripMenuItem"
        JulioToolStripMenuItem.Size = New Size(184, 26)
        JulioToolStripMenuItem.Text = "Julio"
        ' 
        ' AgostoToolStripMenuItem
        ' 
        AgostoToolStripMenuItem.Name = "AgostoToolStripMenuItem"
        AgostoToolStripMenuItem.Size = New Size(184, 26)
        AgostoToolStripMenuItem.Text = "Agosto"
        ' 
        ' SeptiembreToolStripMenuItem
        ' 
        SeptiembreToolStripMenuItem.Name = "SeptiembreToolStripMenuItem"
        SeptiembreToolStripMenuItem.Size = New Size(184, 26)
        SeptiembreToolStripMenuItem.Text = "Septiembre"
        ' 
        ' OctubreToolStripMenuItem
        ' 
        OctubreToolStripMenuItem.Name = "OctubreToolStripMenuItem"
        OctubreToolStripMenuItem.Size = New Size(184, 26)
        OctubreToolStripMenuItem.Text = "Octubre"
        ' 
        ' NoviembreToolStripMenuItem
        ' 
        NoviembreToolStripMenuItem.Name = "NoviembreToolStripMenuItem"
        NoviembreToolStripMenuItem.Size = New Size(184, 26)
        NoviembreToolStripMenuItem.Text = "Noviembre"
        ' 
        ' DiciembreToolStripMenuItem
        ' 
        DiciembreToolStripMenuItem.Name = "DiciembreToolStripMenuItem"
        DiciembreToolStripMenuItem.Size = New Size(184, 26)
        DiciembreToolStripMenuItem.Text = "Diciembre"
        ' 
        ' VerToolStripMenuItem
        ' 
        VerToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CuentasToolStripMenuItem, SubCuentasToolStripMenuItem})
        VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        VerToolStripMenuItem.Size = New Size(44, 24)
        VerToolStripMenuItem.Text = "Ver"
        ' 
        ' CuentasToolStripMenuItem
        ' 
        CuentasToolStripMenuItem.Name = "CuentasToolStripMenuItem"
        CuentasToolStripMenuItem.Size = New Size(169, 26)
        CuentasToolStripMenuItem.Text = "Cuentas"
        ' 
        ' SubCuentasToolStripMenuItem
        ' 
        SubCuentasToolStripMenuItem.Name = "SubCuentasToolStripMenuItem"
        SubCuentasToolStripMenuItem.Size = New Size(169, 26)
        SubCuentasToolStripMenuItem.Text = "SubCuentas"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(36, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 23)
        Label1.TabIndex = 1
        Label1.Text = "Día:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(99, 43)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(62, 27)
        TextBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.BackColor = SystemColors.ActiveBorder
        Label2.Location = New Point(184, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 25)
        Label2.TabIndex = 3
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.BackColor = SystemColors.ActiveBorder
        Label3.Location = New Point(315, 43)
        Label3.Name = "Label3"
        Label3.Size = New Size(316, 25)
        Label3.TabIndex = 4
        Label3.Text = "Redacción:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(36, 89)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(287, 27)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(344, 89)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(287, 27)
        TextBox3.TabIndex = 6
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(648, 89)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(287, 27)
        TextBox4.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(648, 47)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 23)
        Label4.TabIndex = 8
        Label4.Text = "RFC:"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' OpenFileDialog2
        ' 
        OpenFileDialog2.FileName = "OpenFileDialog2"
        ' 
        ' OpenFileDialog3
        ' 
        OpenFileDialog3.FileName = "OpenFileDialog3"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(958, 47)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 23)
        Label5.TabIndex = 9
        Label5.Text = "FOLIO: "
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(958, 89)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(287, 27)
        TextBox5.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.BackColor = SystemColors.ActiveBorder
        Label6.Location = New Point(943, 364)
        Label6.Name = "Label6"
        Label6.Size = New Size(302, 35)
        Label6.TabIndex = 11
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ColCta, ColSubCta, ColNom, ColParcial, ColDebe, ColHaber})
        DataGridView1.Location = New Point(29, 163)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(609, 450)
        DataGridView1.TabIndex = 12
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
        ColSubCta.HeaderText = "SubCuenta"
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
        ' CAP_CapturaPorOtrosMedios
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1281, 600)
        Controls.Add(DataGridView1)
        Controls.Add(Label6)
        Controls.Add(TextBox5)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "CAP_CapturaPorOtrosMedios"
        Text = "CAP_CapturaPorOtrosMedios"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ValidaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SumarPólizaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MesesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents OpenFileDialog3 As OpenFileDialog
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GuardarPólizaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeshacerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CopiarTodoCtrlSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IncorporaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EneroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FebreroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarzoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MayoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JunioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JulioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgostoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeptiembreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OctubreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NoviembreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiciembreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubCuentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColCta As DataGridViewTextBoxColumn
    Friend WithEvents ColSubCta As DataGridViewTextBoxColumn
    Friend WithEvents ColNom As DataGridViewTextBoxColumn
    Friend WithEvents ColParcial As DataGridViewTextBoxColumn
    Friend WithEvents ColDebe As DataGridViewTextBoxColumn
    Friend WithEvents ColHaber As DataGridViewTextBoxColumn
End Class
