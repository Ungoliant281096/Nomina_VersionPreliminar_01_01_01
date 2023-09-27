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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.idEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rfcEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.curpEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.imssEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaAltaEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaBajaEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salarioDiarioEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.viaticosEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.otrosDiariosEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salarioDiarioIntegradoEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numeroTarjetaEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.OrdenarToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
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
        Me.SalidaToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
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
        Me.PantallaToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.PantallaToolStripMenuItem.Text = "Pantalla"
        '
        'TotalToolStripMenuItem
        '
        Me.TotalToolStripMenuItem.Name = "TotalToolStripMenuItem"
        Me.TotalToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.TotalToolStripMenuItem.Text = "Total"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idEmpleado, Me.nombreEmpleado, Me.rfcEmpleado, Me.curpEmpleado, Me.imssEmpleado, Me.fechaAltaEmpleado, Me.fechaBajaEmpleado, Me.salarioDiarioEmpleado, Me.viaticosEmpleado, Me.otrosDiariosEmpleado, Me.salarioDiarioIntegradoEmpleado, Me.numeroTarjetaEmpleado})
        Me.DataGridView1.Location = New System.Drawing.Point(14, 36)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(882, 535)
        Me.DataGridView1.TabIndex = 2
        '
        'idEmpleado
        '
        Me.idEmpleado.HeaderText = "Id"
        Me.idEmpleado.MinimumWidth = 6
        Me.idEmpleado.Name = "idEmpleado"
        Me.idEmpleado.Width = 125
        '
        'nombreEmpleado
        '
        Me.nombreEmpleado.HeaderText = "Nombre"
        Me.nombreEmpleado.MinimumWidth = 6
        Me.nombreEmpleado.Name = "nombreEmpleado"
        Me.nombreEmpleado.Width = 125
        '
        'rfcEmpleado
        '
        Me.rfcEmpleado.HeaderText = "RFC"
        Me.rfcEmpleado.MinimumWidth = 6
        Me.rfcEmpleado.Name = "rfcEmpleado"
        Me.rfcEmpleado.Width = 125
        '
        'curpEmpleado
        '
        Me.curpEmpleado.HeaderText = "CURP"
        Me.curpEmpleado.MinimumWidth = 6
        Me.curpEmpleado.Name = "curpEmpleado"
        Me.curpEmpleado.Width = 125
        '
        'imssEmpleado
        '
        Me.imssEmpleado.HeaderText = "IMSS"
        Me.imssEmpleado.MinimumWidth = 6
        Me.imssEmpleado.Name = "imssEmpleado"
        Me.imssEmpleado.Width = 125
        '
        'fechaAltaEmpleado
        '
        Me.fechaAltaEmpleado.HeaderText = "Fecha alta"
        Me.fechaAltaEmpleado.MinimumWidth = 6
        Me.fechaAltaEmpleado.Name = "fechaAltaEmpleado"
        Me.fechaAltaEmpleado.Width = 125
        '
        'fechaBajaEmpleado
        '
        Me.fechaBajaEmpleado.HeaderText = "Fecha baja"
        Me.fechaBajaEmpleado.MinimumWidth = 6
        Me.fechaBajaEmpleado.Name = "fechaBajaEmpleado"
        Me.fechaBajaEmpleado.Width = 125
        '
        'salarioDiarioEmpleado
        '
        Me.salarioDiarioEmpleado.HeaderText = "Salario diario"
        Me.salarioDiarioEmpleado.MinimumWidth = 6
        Me.salarioDiarioEmpleado.Name = "salarioDiarioEmpleado"
        Me.salarioDiarioEmpleado.Width = 125
        '
        'viaticosEmpleado
        '
        Me.viaticosEmpleado.HeaderText = "Viáticos diarios"
        Me.viaticosEmpleado.MinimumWidth = 6
        Me.viaticosEmpleado.Name = "viaticosEmpleado"
        Me.viaticosEmpleado.Width = 125
        '
        'otrosDiariosEmpleado
        '
        Me.otrosDiariosEmpleado.HeaderText = "Otros diarios"
        Me.otrosDiariosEmpleado.MinimumWidth = 6
        Me.otrosDiariosEmpleado.Name = "otrosDiariosEmpleado"
        Me.otrosDiariosEmpleado.Width = 125
        '
        'salarioDiarioIntegradoEmpleado
        '
        Me.salarioDiarioIntegradoEmpleado.HeaderText = "SDI"
        Me.salarioDiarioIntegradoEmpleado.MinimumWidth = 6
        Me.salarioDiarioIntegradoEmpleado.Name = "salarioDiarioIntegradoEmpleado"
        Me.salarioDiarioIntegradoEmpleado.Width = 125
        '
        'numeroTarjetaEmpleado
        '
        Me.numeroTarjetaEmpleado.HeaderText = "Numero tarjeta"
        Me.numeroTarjetaEmpleado.MinimumWidth = 6
        Me.numeroTarjetaEmpleado.Name = "numeroTarjetaEmpleado"
        Me.numeroTarjetaEmpleado.Width = 125
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
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
