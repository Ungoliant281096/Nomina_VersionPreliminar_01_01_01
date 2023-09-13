<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NOM_RegistroOperaciones
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
        RecalcularToolStripMenuItem = New ToolStripMenuItem()
        CorreguirAplicaciónToolStripMenuItem = New ToolStripMenuItem()
        ImprimirToolStripMenuItem = New ToolStripMenuItem()
        ResumenToolStripMenuItem = New ToolStripMenuItem()
        TotalToolStripMenuItem = New ToolStripMenuItem()
        EdiciónToolStripMenuItem = New ToolStripMenuItem()
        CopiarCtrCToolStripMenuItem = New ToolStripMenuItem()
        SeleccionarTodoToolStripMenuItem = New ToolStripMenuItem()
        OrdenarToolStripMenuItem = New ToolStripMenuItem()
        GenerarPolizaToolStripMenuItem = New ToolStripMenuItem()
        AlfabeticoToolStripMenuItem = New ToolStripMenuItem()
        NumericoToolStripMenuItem = New ToolStripMenuItem()
        AplicaciónPolizaToolStripMenuItem = New ToolStripMenuItem()
        DataGridView1 = New DataGridView()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem, EdiciónToolStripMenuItem, OrdenarToolStripMenuItem, GenerarPolizaToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RecalcularToolStripMenuItem, CorreguirAplicaciónToolStripMenuItem, ImprimirToolStripMenuItem})
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(73, 24)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' RecalcularToolStripMenuItem
        ' 
        RecalcularToolStripMenuItem.Name = "RecalcularToolStripMenuItem"
        RecalcularToolStripMenuItem.Size = New Size(327, 26)
        RecalcularToolStripMenuItem.Text = "Recalcular"
        ' 
        ' CorreguirAplicaciónToolStripMenuItem
        ' 
        CorreguirAplicaciónToolStripMenuItem.Name = "CorreguirAplicaciónToolStripMenuItem"
        CorreguirAplicaciónToolStripMenuItem.Size = New Size(327, 26)
        CorreguirAplicaciónToolStripMenuItem.Text = "Correguir Aplicación            Ctrl + A"
        ' 
        ' ImprimirToolStripMenuItem
        ' 
        ImprimirToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ResumenToolStripMenuItem, TotalToolStripMenuItem})
        ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        ImprimirToolStripMenuItem.Size = New Size(327, 26)
        ImprimirToolStripMenuItem.Text = "Imprimir"
        ' 
        ' ResumenToolStripMenuItem
        ' 
        ResumenToolStripMenuItem.Name = "ResumenToolStripMenuItem"
        ResumenToolStripMenuItem.Size = New Size(224, 26)
        ResumenToolStripMenuItem.Text = "Resumen"
        ' 
        ' TotalToolStripMenuItem
        ' 
        TotalToolStripMenuItem.Name = "TotalToolStripMenuItem"
        TotalToolStripMenuItem.Size = New Size(224, 26)
        TotalToolStripMenuItem.Text = "Total"
        ' 
        ' EdiciónToolStripMenuItem
        ' 
        EdiciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CopiarCtrCToolStripMenuItem, SeleccionarTodoToolStripMenuItem})
        EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        EdiciónToolStripMenuItem.Size = New Size(72, 24)
        EdiciónToolStripMenuItem.Text = "Edición"
        ' 
        ' CopiarCtrCToolStripMenuItem
        ' 
        CopiarCtrCToolStripMenuItem.Name = "CopiarCtrCToolStripMenuItem"
        CopiarCtrCToolStripMenuItem.Size = New Size(258, 26)
        CopiarCtrCToolStripMenuItem.Text = "Copiar                     Ctr+C"
        ' 
        ' SeleccionarTodoToolStripMenuItem
        ' 
        SeleccionarTodoToolStripMenuItem.Name = "SeleccionarTodoToolStripMenuItem"
        SeleccionarTodoToolStripMenuItem.Size = New Size(258, 26)
        SeleccionarTodoToolStripMenuItem.Text = "Seleccionar todo"
        ' 
        ' OrdenarToolStripMenuItem
        ' 
        OrdenarToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AlfabeticoToolStripMenuItem, NumericoToolStripMenuItem})
        OrdenarToolStripMenuItem.Name = "OrdenarToolStripMenuItem"
        OrdenarToolStripMenuItem.Size = New Size(77, 24)
        OrdenarToolStripMenuItem.Text = "Ordenar"
        ' 
        ' GenerarPolizaToolStripMenuItem
        ' 
        GenerarPolizaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AplicaciónPolizaToolStripMenuItem})
        GenerarPolizaToolStripMenuItem.Name = "GenerarPolizaToolStripMenuItem"
        GenerarPolizaToolStripMenuItem.Size = New Size(118, 24)
        GenerarPolizaToolStripMenuItem.Text = "Generar Póliza"
        ' 
        ' AlfabeticoToolStripMenuItem
        ' 
        AlfabeticoToolStripMenuItem.Name = "AlfabeticoToolStripMenuItem"
        AlfabeticoToolStripMenuItem.Size = New Size(224, 26)
        AlfabeticoToolStripMenuItem.Text = "Alfabéticamente"
        ' 
        ' NumericoToolStripMenuItem
        ' 
        NumericoToolStripMenuItem.Name = "NumericoToolStripMenuItem"
        NumericoToolStripMenuItem.Size = New Size(224, 26)
        NumericoToolStripMenuItem.Text = "Numéricamente"
        ' 
        ' AplicaciónPolizaToolStripMenuItem
        ' 
        AplicaciónPolizaToolStripMenuItem.Name = "AplicaciónPolizaToolStripMenuItem"
        AplicaciónPolizaToolStripMenuItem.Size = New Size(224, 26)
        AplicaciónPolizaToolStripMenuItem.Text = "Aplicación Póliza"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(31, 53)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(743, 362)
        DataGridView1.TabIndex = 1
        ' 
        ' NOM_RegistroOperaciones
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "NOM_RegistroOperaciones"
        Text = "NOM_RegistroOperaciones"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CorreguirAplicaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdenarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerarPolizaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResumenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TotalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarCtrCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeleccionarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlfabeticoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NumericoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AplicaciónPolizaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
End Class
