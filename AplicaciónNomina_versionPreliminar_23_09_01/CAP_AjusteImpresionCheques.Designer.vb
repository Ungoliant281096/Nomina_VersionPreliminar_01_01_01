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
        MenuStrip1 = New MenuStrip()
        ArchivoToolStripMenuItem = New ToolStripMenuItem()
        ArchivarToolStripMenuItem = New ToolStripMenuItem()
        ImpresiónDatosToolStripMenuItem = New ToolStripMenuItem()
        PruebaImpresiónToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
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
        ArchivarToolStripMenuItem.Size = New Size(224, 26)
        ArchivarToolStripMenuItem.Text = "Archivar"
        ' 
        ' ImpresiónDatosToolStripMenuItem
        ' 
        ImpresiónDatosToolStripMenuItem.Name = "ImpresiónDatosToolStripMenuItem"
        ImpresiónDatosToolStripMenuItem.Size = New Size(224, 26)
        ImpresiónDatosToolStripMenuItem.Text = "Impresión datos"
        ' 
        ' PruebaImpresiónToolStripMenuItem
        ' 
        PruebaImpresiónToolStripMenuItem.Name = "PruebaImpresiónToolStripMenuItem"
        PruebaImpresiónToolStripMenuItem.Size = New Size(224, 26)
        PruebaImpresiónToolStripMenuItem.Text = "Prueba impresión"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(224, 26)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' CAP_AjusteImpresionCheques
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(460, 579)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "CAP_AjusteImpresionCheques"
        Text = "CAP_AjusteImpresionCheques"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArchivarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImpresiónDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PruebaImpresiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
