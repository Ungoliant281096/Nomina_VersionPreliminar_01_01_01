<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NOM_EdicionDePersonal
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
        ArcivoToolStripMenuItem = New ToolStripMenuItem()
        OrdenarToolStripMenuItem = New ToolStripMenuItem()
        NuméricamenteToolStripMenuItem = New ToolStripMenuItem()
        AlfabéticamenteToolStripMenuItem = New ToolStripMenuItem()
        SalidaToolStripMenuItem = New ToolStripMenuItem()
        EdiciónToolStripMenuItem = New ToolStripMenuItem()
        CopiarToolStripMenuItem = New ToolStripMenuItem()
        PegarToolStripMenuItem = New ToolStripMenuItem()
        IntegrarSalarioDiarioToolStripMenuItem = New ToolStripMenuItem()
        SeleccionarTodoToolStripMenuItem = New ToolStripMenuItem()
        SuprimirTitulosToolStripMenuItem = New ToolStripMenuItem()
        ImprimirToolStripMenuItem = New ToolStripMenuItem()
        PantallaToolStripMenuItem = New ToolStripMenuItem()
        TotalToolStripMenuItem = New ToolStripMenuItem()
        DataGridView1 = New DataGridView()
        idEmpleado = New DataGridViewTextBoxColumn()
        nombreEmpleado = New DataGridViewTextBoxColumn()
        rfcEmpleado = New DataGridViewTextBoxColumn()
        curpEmpleado = New DataGridViewTextBoxColumn()
        imssEmpleado = New DataGridViewTextBoxColumn()
        fechaAltaEmpleado = New DataGridViewTextBoxColumn()
        fechaBajaEmpleado = New DataGridViewTextBoxColumn()
        salarioDiarioEmpleado = New DataGridViewTextBoxColumn()
        viaticosEmpleado = New DataGridViewTextBoxColumn()
        otrosDiariosEmpleado = New DataGridViewTextBoxColumn()
        salarioDiarioIntegradoEmpleado = New DataGridViewTextBoxColumn()
        numeroTarjetaEmpleado = New DataGridViewTextBoxColumn()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ArcivoToolStripMenuItem, EdiciónToolStripMenuItem, ImprimirToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 3, 0, 3)
        MenuStrip1.Size = New Size(928, 30)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ArcivoToolStripMenuItem
        ' 
        ArcivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {OrdenarToolStripMenuItem, SalidaToolStripMenuItem})
        ArcivoToolStripMenuItem.Name = "ArcivoToolStripMenuItem"
        ArcivoToolStripMenuItem.Size = New Size(73, 24)
        ArcivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' OrdenarToolStripMenuItem
        ' 
        OrdenarToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NuméricamenteToolStripMenuItem, AlfabéticamenteToolStripMenuItem})
        OrdenarToolStripMenuItem.Name = "OrdenarToolStripMenuItem"
        OrdenarToolStripMenuItem.Size = New Size(146, 26)
        OrdenarToolStripMenuItem.Text = "Ordenar"
        ' 
        ' NuméricamenteToolStripMenuItem
        ' 
        NuméricamenteToolStripMenuItem.Name = "NuméricamenteToolStripMenuItem"
        NuméricamenteToolStripMenuItem.Size = New Size(202, 26)
        NuméricamenteToolStripMenuItem.Text = "Numéricamente"
        ' 
        ' AlfabéticamenteToolStripMenuItem
        ' 
        AlfabéticamenteToolStripMenuItem.Name = "AlfabéticamenteToolStripMenuItem"
        AlfabéticamenteToolStripMenuItem.Size = New Size(202, 26)
        AlfabéticamenteToolStripMenuItem.Text = "Alfabéticamente"
        ' 
        ' SalidaToolStripMenuItem
        ' 
        SalidaToolStripMenuItem.Name = "SalidaToolStripMenuItem"
        SalidaToolStripMenuItem.Size = New Size(146, 26)
        SalidaToolStripMenuItem.Text = "Salida"
        ' 
        ' EdiciónToolStripMenuItem
        ' 
        EdiciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CopiarToolStripMenuItem, PegarToolStripMenuItem, IntegrarSalarioDiarioToolStripMenuItem, SeleccionarTodoToolStripMenuItem, SuprimirTitulosToolStripMenuItem})
        EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        EdiciónToolStripMenuItem.Size = New Size(72, 24)
        EdiciónToolStripMenuItem.Text = "Edición"
        ' 
        ' CopiarToolStripMenuItem
        ' 
        CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        CopiarToolStripMenuItem.Size = New Size(235, 26)
        CopiarToolStripMenuItem.Text = "Copiar"
        ' 
        ' PegarToolStripMenuItem
        ' 
        PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        PegarToolStripMenuItem.Size = New Size(235, 26)
        PegarToolStripMenuItem.Text = "Pegar"
        ' 
        ' IntegrarSalarioDiarioToolStripMenuItem
        ' 
        IntegrarSalarioDiarioToolStripMenuItem.Name = "IntegrarSalarioDiarioToolStripMenuItem"
        IntegrarSalarioDiarioToolStripMenuItem.Size = New Size(235, 26)
        IntegrarSalarioDiarioToolStripMenuItem.Text = "Integrar salario diario"
        ' 
        ' SeleccionarTodoToolStripMenuItem
        ' 
        SeleccionarTodoToolStripMenuItem.Name = "SeleccionarTodoToolStripMenuItem"
        SeleccionarTodoToolStripMenuItem.Size = New Size(235, 26)
        SeleccionarTodoToolStripMenuItem.Text = "Seleccionar todo"
        ' 
        ' SuprimirTitulosToolStripMenuItem
        ' 
        SuprimirTitulosToolStripMenuItem.Name = "SuprimirTitulosToolStripMenuItem"
        SuprimirTitulosToolStripMenuItem.Size = New Size(235, 26)
        SuprimirTitulosToolStripMenuItem.Text = "Suprimir titulos"
        ' 
        ' ImprimirToolStripMenuItem
        ' 
        ImprimirToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PantallaToolStripMenuItem, TotalToolStripMenuItem})
        ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        ImprimirToolStripMenuItem.Size = New Size(80, 24)
        ImprimirToolStripMenuItem.Text = "Imprimir"
        ' 
        ' PantallaToolStripMenuItem
        ' 
        PantallaToolStripMenuItem.Name = "PantallaToolStripMenuItem"
        PantallaToolStripMenuItem.Size = New Size(144, 26)
        PantallaToolStripMenuItem.Text = "Pantalla"
        ' 
        ' TotalToolStripMenuItem
        ' 
        TotalToolStripMenuItem.Name = "TotalToolStripMenuItem"
        TotalToolStripMenuItem.Size = New Size(144, 26)
        TotalToolStripMenuItem.Text = "Total"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {idEmpleado, nombreEmpleado, rfcEmpleado, curpEmpleado, imssEmpleado, fechaAltaEmpleado, fechaBajaEmpleado, salarioDiarioEmpleado, viaticosEmpleado, otrosDiariosEmpleado, salarioDiarioIntegradoEmpleado, numeroTarjetaEmpleado})
        DataGridView1.Location = New Point(14, 36)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(882, 535)
        DataGridView1.TabIndex = 2
        ' 
        ' idEmpleado
        ' 
        idEmpleado.HeaderText = "Id"
        idEmpleado.MinimumWidth = 6
        idEmpleado.Name = "idEmpleado"
        idEmpleado.Width = 125
        ' 
        ' nombreEmpleado
        ' 
        nombreEmpleado.HeaderText = "Nombre"
        nombreEmpleado.MinimumWidth = 6
        nombreEmpleado.Name = "nombreEmpleado"
        nombreEmpleado.Width = 125
        ' 
        ' rfcEmpleado
        ' 
        rfcEmpleado.HeaderText = "RFC"
        rfcEmpleado.MinimumWidth = 6
        rfcEmpleado.Name = "rfcEmpleado"
        rfcEmpleado.Width = 125
        ' 
        ' curpEmpleado
        ' 
        curpEmpleado.HeaderText = "CURP"
        curpEmpleado.MinimumWidth = 6
        curpEmpleado.Name = "curpEmpleado"
        curpEmpleado.Width = 125
        ' 
        ' imssEmpleado
        ' 
        imssEmpleado.HeaderText = "IMSS"
        imssEmpleado.MinimumWidth = 6
        imssEmpleado.Name = "imssEmpleado"
        imssEmpleado.Width = 125
        ' 
        ' fechaAltaEmpleado
        ' 
        fechaAltaEmpleado.HeaderText = "Fecha alta"
        fechaAltaEmpleado.MinimumWidth = 6
        fechaAltaEmpleado.Name = "fechaAltaEmpleado"
        fechaAltaEmpleado.Width = 125
        ' 
        ' fechaBajaEmpleado
        ' 
        fechaBajaEmpleado.HeaderText = "Fecha baja"
        fechaBajaEmpleado.MinimumWidth = 6
        fechaBajaEmpleado.Name = "fechaBajaEmpleado"
        fechaBajaEmpleado.Width = 125
        ' 
        ' salarioDiarioEmpleado
        ' 
        salarioDiarioEmpleado.HeaderText = "Salario diario"
        salarioDiarioEmpleado.MinimumWidth = 6
        salarioDiarioEmpleado.Name = "salarioDiarioEmpleado"
        salarioDiarioEmpleado.Width = 125
        ' 
        ' viaticosEmpleado
        ' 
        viaticosEmpleado.HeaderText = "Viáticos diarios"
        viaticosEmpleado.MinimumWidth = 6
        viaticosEmpleado.Name = "viaticosEmpleado"
        viaticosEmpleado.Width = 125
        ' 
        ' otrosDiariosEmpleado
        ' 
        otrosDiariosEmpleado.HeaderText = "Otros diarios"
        otrosDiariosEmpleado.MinimumWidth = 6
        otrosDiariosEmpleado.Name = "otrosDiariosEmpleado"
        otrosDiariosEmpleado.Width = 125
        ' 
        ' salarioDiarioIntegradoEmpleado
        ' 
        salarioDiarioIntegradoEmpleado.HeaderText = "SDI"
        salarioDiarioIntegradoEmpleado.MinimumWidth = 6
        salarioDiarioIntegradoEmpleado.Name = "salarioDiarioIntegradoEmpleado"
        salarioDiarioIntegradoEmpleado.Width = 125
        ' 
        ' numeroTarjetaEmpleado
        ' 
        numeroTarjetaEmpleado.HeaderText = "Numero tarjeta"
        numeroTarjetaEmpleado.MinimumWidth = 6
        numeroTarjetaEmpleado.Name = "numeroTarjetaEmpleado"
        numeroTarjetaEmpleado.Width = 125
        ' 
        ' NOM_EdicionDePersonal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(928, 600)
        Controls.Add(DataGridView1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 4, 3, 4)
        Name = "NOM_EdicionDePersonal"
        Text = "EdicionDePersonal"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArcivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdenarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuméricamenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlfabéticamenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntegrarSalarioDiarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeleccionarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuprimirTitulosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PantallaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TotalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents idEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents nombreEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents rfcEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents curpEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents imssEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents fechaAltaEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents fechaBajaEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents salarioDiarioEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents viaticosEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents otrosDiariosEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents salarioDiarioIntegradoEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents numeroTarjetaEmpleado As DataGridViewTextBoxColumn
End Class
