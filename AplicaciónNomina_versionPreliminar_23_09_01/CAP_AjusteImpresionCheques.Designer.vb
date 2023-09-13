<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAP_AjusteImpresionCheques
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(CAP_AjusteImpresionCheques))
        MenuStrip1 = New MenuStrip()
        ArchivoToolStripMenuItem = New ToolStripMenuItem()
        ArchivarToolStripMenuItem = New ToolStripMenuItem()
        ImpresiónDatosToolStripMenuItem = New ToolStripMenuItem()
        PruebaImpresiónToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        TextBox1 = New TextBox()
        DataGridView1 = New DataGridView()
        ColFecha = New DataGridViewTextBoxColumn()
        ColBenef = New DataGridViewTextBoxColumn()
        ColImpteNum = New DataGridViewTextBoxColumn()
        ColImpteLetra = New DataGridViewTextBoxColumn()
        ColConcep = New DataGridViewTextBoxColumn()
        ColInicioApli = New DataGridViewTextBoxColumn()
        ColSumasI = New DataGridViewTextBoxColumn()
        ColCta = New DataGridViewTextBoxColumn()
        ColSubCta = New DataGridViewTextBoxColumn()
        ColNomCtaSubcta = New DataGridViewTextBoxColumn()
        ColParc = New DataGridViewTextBoxColumn()
        ColDebe = New DataGridViewTextBoxColumn()
        ColHaber = New DataGridViewTextBoxColumn()
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
        MenuStrip1.Size = New Size(460, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ArchivarToolStripMenuItem, ImpresiónDatosToolStripMenuItem, PruebaImpresiónToolStripMenuItem, SalirToolStripMenuItem})
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(73, 24)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' ArchivarToolStripMenuItem
        ' 
        ArchivarToolStripMenuItem.Name = "ArchivarToolStripMenuItem"
        ArchivarToolStripMenuItem.Size = New Size(208, 26)
        ArchivarToolStripMenuItem.Text = "Archivar"
        ' 
        ' ImpresiónDatosToolStripMenuItem
        ' 
        ImpresiónDatosToolStripMenuItem.Name = "ImpresiónDatosToolStripMenuItem"
        ImpresiónDatosToolStripMenuItem.Size = New Size(208, 26)
        ImpresiónDatosToolStripMenuItem.Text = "Impresión datos"
        ' 
        ' PruebaImpresiónToolStripMenuItem
        ' 
        PruebaImpresiónToolStripMenuItem.Name = "PruebaImpresiónToolStripMenuItem"
        PruebaImpresiónToolStripMenuItem.Size = New Size(208, 26)
        PruebaImpresiónToolStripMenuItem.Text = "Prueba impresión"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(208, 26)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 40)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ColFecha, ColBenef, ColImpteNum, ColImpteLetra, ColConcep, ColInicioApli, ColSumasI, ColCta, ColSubCta, ColNomCtaSubcta, ColParc, ColDebe, ColHaber})
        DataGridView1.Location = New Point(24, 95)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(408, 452)
        DataGridView1.TabIndex = 2
        ' 
        ' ColFecha
        ' 
        ColFecha.HeaderText = "FECHA"
        ColFecha.MinimumWidth = 6
        ColFecha.Name = "ColFecha"
        ColFecha.Width = 125
        ' 
        ' ColBenef
        ' 
        ColBenef.HeaderText = "BENEFICIARIO "
        ColBenef.MinimumWidth = 6
        ColBenef.Name = "ColBenef"
        ColBenef.Width = 125
        ' 
        ' ColImpteNum
        ' 
        ColImpteNum.HeaderText = "IMPORTE EN NÚMERO"
        ColImpteNum.MinimumWidth = 6
        ColImpteNum.Name = "ColImpteNum"
        ColImpteNum.Width = 125
        ' 
        ' ColImpteLetra
        ' 
        ColImpteLetra.HeaderText = "IMPORTE EN LETRA"
        ColImpteLetra.MinimumWidth = 6
        ColImpteLetra.Name = "ColImpteLetra"
        ColImpteLetra.Width = 125
        ' 
        ' ColConcep
        ' 
        ColConcep.HeaderText = "CONCEPTO"
        ColConcep.MinimumWidth = 6
        ColConcep.Name = "ColConcep"
        ColConcep.Width = 125
        ' 
        ' ColInicioApli
        ' 
        ColInicioApli.HeaderText = "INICIO APLICACIÓN"
        ColInicioApli.MinimumWidth = 6
        ColInicioApli.Name = "ColInicioApli"
        ColInicioApli.Width = 125
        ' 
        ' ColSumasI
        ' 
        ColSumasI.HeaderText = "SUMAS IGUALES"
        ColSumasI.MinimumWidth = 6
        ColSumasI.Name = "ColSumasI"
        ColSumasI.Width = 125
        ' 
        ' ColCta
        ' 
        ColCta.HeaderText = "CUENTA"
        ColCta.MinimumWidth = 6
        ColCta.Name = "ColCta"
        ColCta.Width = 125
        ' 
        ' ColSubCta
        ' 
        ColSubCta.HeaderText = "SUBCUENTA"
        ColSubCta.MinimumWidth = 6
        ColSubCta.Name = "ColSubCta"
        ColSubCta.Width = 125
        ' 
        ' ColNomCtaSubcta
        ' 
        ColNomCtaSubcta.HeaderText = "NOMBRE CTA-SUBCTA"
        ColNomCtaSubcta.MinimumWidth = 6
        ColNomCtaSubcta.Name = "ColNomCtaSubcta"
        ColNomCtaSubcta.Width = 125
        ' 
        ' ColParc
        ' 
        ColParc.HeaderText = "PARCIAL"
        ColParc.MinimumWidth = 6
        ColParc.Name = "ColParc"
        ColParc.Width = 125
        ' 
        ' ColDebe
        ' 
        ColDebe.HeaderText = "DEBE"
        ColDebe.MinimumWidth = 6
        ColDebe.Name = "ColDebe"
        ColDebe.Width = 125
        ' 
        ' ColHaber
        ' 
        ColHaber.HeaderText = "HABER"
        ColHaber.MinimumWidth = 6
        ColHaber.Name = "ColHaber"
        ColHaber.Width = 125
        ' 
        ' CAP_AjusteImpresionCheques
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(460, 579)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox1)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "CAP_AjusteImpresionCheques"
        Text = "CAP_AjusteImpresionCheques"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArchivarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImpresiónDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PruebaImpresiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ColFecha As DataGridViewTextBoxColumn
    Friend WithEvents ColBenef As DataGridViewTextBoxColumn
    Friend WithEvents ColImpteNum As DataGridViewTextBoxColumn
    Friend WithEvents ColImpteLetra As DataGridViewTextBoxColumn
    Friend WithEvents ColConcep As DataGridViewTextBoxColumn
    Friend WithEvents ColInicioApli As DataGridViewTextBoxColumn
    Friend WithEvents ColSumasI As DataGridViewTextBoxColumn
    Friend WithEvents ColCta As DataGridViewTextBoxColumn
    Friend WithEvents ColSubCta As DataGridViewTextBoxColumn
    Friend WithEvents ColNomCtaSubcta As DataGridViewTextBoxColumn
    Friend WithEvents ColParc As DataGridViewTextBoxColumn
    Friend WithEvents ColDebe As DataGridViewTextBoxColumn
    Friend WithEvents ColHaber As DataGridViewTextBoxColumn
End Class
