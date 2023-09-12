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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID_empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rfcEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.curpEmpelado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.seguroSocialEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaAltaEmplado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaBajaEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salarioDiarioEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViaticosDiaEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.otrosDiariosEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salarioDiarioIntegradoEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numTarjetaEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArcivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuméricamenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlfabéticamenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdiciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntegrarSalarioDiarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeleccionarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuprimirTitulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PantallaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_empleado, Me.nombreEmpleado, Me.rfcEmpleado, Me.curpEmpelado, Me.seguroSocialEmpleado, Me.fechaAltaEmplado, Me.fechaBajaEmpleado, Me.salarioDiarioEmpleado, Me.ViaticosDiaEmpleado, Me.otrosDiariosEmpleado, Me.salarioDiarioIntegradoEmpleado, Me.numTarjetaEmpleado})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 30)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(914, 558)
        Me.DataGridView1.TabIndex = 1
        '
        'ID_empleado
        '
        Me.ID_empleado.Frozen = True
        Me.ID_empleado.HeaderText = "ID"
        Me.ID_empleado.MinimumWidth = 6
        Me.ID_empleado.Name = "ID_empleado"
        Me.ID_empleado.Width = 53
        '
        'nombreEmpleado
        '
        Me.nombreEmpleado.Frozen = True
        Me.nombreEmpleado.HeaderText = "Nombre"
        Me.nombreEmpleado.MinimumWidth = 6
        Me.nombreEmpleado.Name = "nombreEmpleado"
        Me.nombreEmpleado.Width = 93
        '
        'rfcEmpleado
        '
        Me.rfcEmpleado.Frozen = True
        Me.rfcEmpleado.HeaderText = "RFC"
        Me.rfcEmpleado.MinimumWidth = 6
        Me.rfcEmpleado.Name = "rfcEmpleado"
        Me.rfcEmpleado.Width = 63
        '
        'curpEmpelado
        '
        Me.curpEmpelado.Frozen = True
        Me.curpEmpelado.HeaderText = "CURP"
        Me.curpEmpelado.MinimumWidth = 6
        Me.curpEmpelado.Name = "curpEmpelado"
        Me.curpEmpelado.Width = 74
        '
        'seguroSocialEmpleado
        '
        Me.seguroSocialEmpleado.Frozen = True
        Me.seguroSocialEmpleado.HeaderText = "IMSS"
        Me.seguroSocialEmpleado.MinimumWidth = 6
        Me.seguroSocialEmpleado.Name = "seguroSocialEmpleado"
        Me.seguroSocialEmpleado.Width = 71
        '
        'fechaAltaEmplado
        '
        Me.fechaAltaEmplado.Frozen = True
        Me.fechaAltaEmplado.HeaderText = "Fecha Alta"
        Me.fechaAltaEmplado.MinimumWidth = 6
        Me.fechaAltaEmplado.Name = "fechaAltaEmplado"
        Me.fechaAltaEmplado.Width = 107
        '
        'fechaBajaEmpleado
        '
        Me.fechaBajaEmpleado.Frozen = True
        Me.fechaBajaEmpleado.HeaderText = "Fecha Baja"
        Me.fechaBajaEmpleado.MinimumWidth = 6
        Me.fechaBajaEmpleado.Name = "fechaBajaEmpleado"
        Me.fechaBajaEmpleado.Width = 109
        '
        'salarioDiarioEmpleado
        '
        Me.salarioDiarioEmpleado.Frozen = True
        Me.salarioDiarioEmpleado.HeaderText = "Salario Diario"
        Me.salarioDiarioEmpleado.MinimumWidth = 6
        Me.salarioDiarioEmpleado.Name = "salarioDiarioEmpleado"
        Me.salarioDiarioEmpleado.Width = 129
        '
        'ViaticosDiaEmpleado
        '
        Me.ViaticosDiaEmpleado.Frozen = True
        Me.ViaticosDiaEmpleado.HeaderText = "Viáticos diarios"
        Me.ViaticosDiaEmpleado.MinimumWidth = 6
        Me.ViaticosDiaEmpleado.Name = "ViaticosDiaEmpleado"
        Me.ViaticosDiaEmpleado.Width = 139
        '
        'otrosDiariosEmpleado
        '
        Me.otrosDiariosEmpleado.Frozen = True
        Me.otrosDiariosEmpleado.HeaderText = "Otros diários"
        Me.otrosDiariosEmpleado.MinimumWidth = 6
        Me.otrosDiariosEmpleado.Name = "otrosDiariosEmpleado"
        Me.otrosDiariosEmpleado.Width = 123
        '
        'salarioDiarioIntegradoEmpleado
        '
        Me.salarioDiarioIntegradoEmpleado.Frozen = True
        Me.salarioDiarioIntegradoEmpleado.HeaderText = "SDI"
        Me.salarioDiarioIntegradoEmpleado.MinimumWidth = 6
        Me.salarioDiarioIntegradoEmpleado.Name = "salarioDiarioIntegradoEmpleado"
        Me.salarioDiarioIntegradoEmpleado.Width = 61
        '
        'numTarjetaEmpleado
        '
        Me.numTarjetaEmpleado.Frozen = True
        Me.numTarjetaEmpleado.HeaderText = "Número tarjeta"
        Me.numTarjetaEmpleado.MinimumWidth = 6
        Me.numTarjetaEmpleado.Name = "numTarjetaEmpleado"
        Me.numTarjetaEmpleado.Width = 139
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArcivoToolStripMenuItem, Me.EdiciónToolStripMenuItem, Me.ImprimirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(928, 30)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArcivoToolStripMenuItem
        '
        Me.ArcivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrdenarToolStripMenuItem, Me.SalidaToolStripMenuItem})
        Me.ArcivoToolStripMenuItem.Name = "ArcivoToolStripMenuItem"
        Me.ArcivoToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.ArcivoToolStripMenuItem.Text = "Archivo"
        '
        'OrdenarToolStripMenuItem
        '
        Me.OrdenarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuméricamenteToolStripMenuItem, Me.AlfabéticamenteToolStripMenuItem})
        Me.OrdenarToolStripMenuItem.Name = "OrdenarToolStripMenuItem"
        Me.OrdenarToolStripMenuItem.Size = New System.Drawing.Size(146, 26)
        Me.OrdenarToolStripMenuItem.Text = "Ordenar"
        '
        'NuméricamenteToolStripMenuItem
        '
        Me.NuméricamenteToolStripMenuItem.Name = "NuméricamenteToolStripMenuItem"
        Me.NuméricamenteToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.NuméricamenteToolStripMenuItem.Text = "Numéricamente"
        '
        'AlfabéticamenteToolStripMenuItem
        '
        Me.AlfabéticamenteToolStripMenuItem.Name = "AlfabéticamenteToolStripMenuItem"
        Me.AlfabéticamenteToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.AlfabéticamenteToolStripMenuItem.Text = "Alfabéticamente"
        '
        'SalidaToolStripMenuItem
        '
        Me.SalidaToolStripMenuItem.Name = "SalidaToolStripMenuItem"
        Me.SalidaToolStripMenuItem.Size = New System.Drawing.Size(146, 26)
        Me.SalidaToolStripMenuItem.Text = "Salida"
        '
        'EdiciónToolStripMenuItem
        '
        Me.EdiciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItem, Me.PegarToolStripMenuItem, Me.IntegrarSalarioDiarioToolStripMenuItem, Me.SeleccionarTodoToolStripMenuItem, Me.SuprimirTitulosToolStripMenuItem})
        Me.EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        Me.EdiciónToolStripMenuItem.Size = New System.Drawing.Size(72, 24)
        Me.EdiciónToolStripMenuItem.Text = "Edición"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.PegarToolStripMenuItem.Text = "Pegar"
        '
        'IntegrarSalarioDiarioToolStripMenuItem
        '
        Me.IntegrarSalarioDiarioToolStripMenuItem.Name = "IntegrarSalarioDiarioToolStripMenuItem"
        Me.IntegrarSalarioDiarioToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.IntegrarSalarioDiarioToolStripMenuItem.Text = "Integrar salario diario"
        '
        'SeleccionarTodoToolStripMenuItem
        '
        Me.SeleccionarTodoToolStripMenuItem.Name = "SeleccionarTodoToolStripMenuItem"
        Me.SeleccionarTodoToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.SeleccionarTodoToolStripMenuItem.Text = "Seleccionar todo"
        '
        'SuprimirTitulosToolStripMenuItem
        '
        Me.SuprimirTitulosToolStripMenuItem.Name = "SuprimirTitulosToolStripMenuItem"
        Me.SuprimirTitulosToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.SuprimirTitulosToolStripMenuItem.Text = "Suprimir titulos"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PantallaToolStripMenuItem, Me.TotalToolStripMenuItem})
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'PantallaToolStripMenuItem
        '
        Me.PantallaToolStripMenuItem.Name = "PantallaToolStripMenuItem"
        Me.PantallaToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.PantallaToolStripMenuItem.Text = "Pantalla"
        '
        'TotalToolStripMenuItem
        '
        Me.TotalToolStripMenuItem.Name = "TotalToolStripMenuItem"
        Me.TotalToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.TotalToolStripMenuItem.Text = "Total"
        '
        'NOM_EdicionDePersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 600)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "NOM_EdicionDePersonal"
        Me.Text = "EdicionDePersonal"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
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
    Friend WithEvents ID_empleado As DataGridViewTextBoxColumn
    Friend WithEvents nombreEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents rfcEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents curpEmpelado As DataGridViewTextBoxColumn
    Friend WithEvents seguroSocialEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents fechaAltaEmplado As DataGridViewTextBoxColumn
    Friend WithEvents fechaBajaEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents salarioDiarioEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents ViaticosDiaEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents otrosDiariosEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents salarioDiarioIntegradoEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents numTarjetaEmpleado As DataGridViewTextBoxColumn
End Class
