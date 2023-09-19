<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAP_Cheques
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(CAP_Cheques))
        MenuStrip1 = New MenuStrip()
        ArchivoToolStripMenuItem = New ToolStripMenuItem()
        CambioSubdirectorioToolStripMenuItem = New ToolStripMenuItem()
        GuardarAplicaciónCtrlGToolStripMenuItem = New ToolStripMenuItem()
        DirectorioDeCostosToolStripMenuItem = New ToolStripMenuItem()
        ImpresiónToolStripMenuItem = New ToolStripMenuItem()
        ChequeToolStripMenuItem = New ToolStripMenuItem()
        AjustarChequeToolStripMenuItem = New ToolStripMenuItem()
        VerificarActualizacionesToolStripMenuItem = New ToolStripMenuItem()
        ActualizarSaldosToolStripMenuItem = New ToolStripMenuItem()
        DesactualizarToolStripMenuItem = New ToolStripMenuItem()
        ReiniciarToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        CapturaToolStripMenuItem = New ToolStripMenuItem()
        DatosToolStripMenuItem = New ToolStripMenuItem()
        PólizaToolStripMenuItem = New ToolStripMenuItem()
        ChequeToolStripMenuItem1 = New ToolStripMenuItem()
        OtrosProgramasCtrlOToolStripMenuItem = New ToolStripMenuItem()
        EdiciónToolStripMenuItem = New ToolStripMenuItem()
        PegarCtrlVToolStripMenuItem = New ToolStripMenuItem()
        CopiarCtrlCToolStripMenuItem = New ToolStripMenuItem()
        CopiarTodoCtrlSToolStripMenuItem = New ToolStripMenuItem()
        AgregarSubctaToolStripMenuItem = New ToolStripMenuItem()
        EliminarSubctaToolStripMenuItem = New ToolStripMenuItem()
        BorrarCuentaToolStripMenuItem = New ToolStripMenuItem()
        ValidarMovimientoCtrlGToolStripMenuItem = New ToolStripMenuItem()
        VerificarSumasF6ToolStripMenuItem = New ToolStripMenuItem()
        BorrarAplicaciónCtrlBToolStripMenuItem = New ToolStripMenuItem()
        BorrarChequeToolStripMenuItem = New ToolStripMenuItem()
        SumaDebeYHaberCtrlLToolStripMenuItem = New ToolStripMenuItem()
        MesToolStripMenuItem = New ToolStripMenuItem()
        CuentasCtrlMToolStripMenuItem = New ToolStripMenuItem()
        SubcuentasCtrlToolStripMenuItem = New ToolStripMenuItem()
        SumasToolStripMenuItem = New ToolStripMenuItem()
        PólizasCtrlFToolStripMenuItem = New ToolStripMenuItem()
        AuxiliarDeMayorCtrlAToolStripMenuItem = New ToolStripMenuItem()
        EstadosFinancierosCtrlToolStripMenuItem = New ToolStripMenuItem()
        AyudaToolStripMenuItem = New ToolStripMenuItem()
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
        AyudaToolStripMenuItem1 = New ToolStripMenuItem()
        ÍndiceToolStripMenuItem = New ToolStripMenuItem()
        VersiónToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        CheckBox1 = New CheckBox()
        TextBox2 = New TextBox()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Label5 = New Label()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        OpenFileDialog1 = New OpenFileDialog()
        OpenFileDialog2 = New OpenFileDialog()
        Label6 = New Label()
        DataGridView1 = New DataGridView()
        Label7 = New Label()
        TextBox6 = New TextBox()
        Label8 = New Label()
        TextBox7 = New TextBox()
        Label9 = New Label()
        TextBox8 = New TextBox()
        Label10 = New Label()
        TextBox9 = New TextBox()
        Label11 = New Label()
        Label12 = New Label()
        TextBox10 = New TextBox()
        TextBox11 = New TextBox()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        CheckBox2 = New CheckBox()
        OpenFileDialog3 = New OpenFileDialog()
        OpenFileDialog4 = New OpenFileDialog()
        ColCuenta = New DataGridViewTextBoxColumn()
        ColSubCta = New DataGridViewTextBoxColumn()
        ColNom = New DataGridViewTextBoxColumn()
        ColParcial = New DataGridViewTextBoxColumn()
        ColDebe = New DataGridViewTextBoxColumn()
        ColHaber = New DataGridViewTextBoxColumn()
        ColReda = New DataGridViewTextBoxColumn()
        ColFolioFis = New DataGridViewTextBoxColumn()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem, CapturaToolStripMenuItem, EdiciónToolStripMenuItem, MesToolStripMenuItem, AyudaToolStripMenuItem, AyudaToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1307, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CambioSubdirectorioToolStripMenuItem, GuardarAplicaciónCtrlGToolStripMenuItem, DirectorioDeCostosToolStripMenuItem, ImpresiónToolStripMenuItem, VerificarActualizacionesToolStripMenuItem, ActualizarSaldosToolStripMenuItem, DesactualizarToolStripMenuItem, ReiniciarToolStripMenuItem, SalirToolStripMenuItem})
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(73, 24)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' CambioSubdirectorioToolStripMenuItem
        ' 
        CambioSubdirectorioToolStripMenuItem.Name = "CambioSubdirectorioToolStripMenuItem"
        CambioSubdirectorioToolStripMenuItem.Size = New Size(292, 26)
        CambioSubdirectorioToolStripMenuItem.Text = "Cambio subdirectorio"
        ' 
        ' GuardarAplicaciónCtrlGToolStripMenuItem
        ' 
        GuardarAplicaciónCtrlGToolStripMenuItem.Name = "GuardarAplicaciónCtrlGToolStripMenuItem"
        GuardarAplicaciónCtrlGToolStripMenuItem.Size = New Size(292, 26)
        GuardarAplicaciónCtrlGToolStripMenuItem.Text = "Guardar aplicación      Ctrl + G"
        ' 
        ' DirectorioDeCostosToolStripMenuItem
        ' 
        DirectorioDeCostosToolStripMenuItem.Name = "DirectorioDeCostosToolStripMenuItem"
        DirectorioDeCostosToolStripMenuItem.Size = New Size(292, 26)
        DirectorioDeCostosToolStripMenuItem.Text = "Directorio de costos"
        ' 
        ' ImpresiónToolStripMenuItem
        ' 
        ImpresiónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ChequeToolStripMenuItem, AjustarChequeToolStripMenuItem})
        ImpresiónToolStripMenuItem.Name = "ImpresiónToolStripMenuItem"
        ImpresiónToolStripMenuItem.Size = New Size(292, 26)
        ImpresiónToolStripMenuItem.Text = "Impresión"
        ' 
        ' ChequeToolStripMenuItem
        ' 
        ChequeToolStripMenuItem.Name = "ChequeToolStripMenuItem"
        ChequeToolStripMenuItem.Size = New Size(190, 26)
        ChequeToolStripMenuItem.Text = "Cheque"
        ' 
        ' AjustarChequeToolStripMenuItem
        ' 
        AjustarChequeToolStripMenuItem.Name = "AjustarChequeToolStripMenuItem"
        AjustarChequeToolStripMenuItem.Size = New Size(190, 26)
        AjustarChequeToolStripMenuItem.Text = "Ajustar cheque"
        ' 
        ' VerificarActualizacionesToolStripMenuItem
        ' 
        VerificarActualizacionesToolStripMenuItem.Name = "VerificarActualizacionesToolStripMenuItem"
        VerificarActualizacionesToolStripMenuItem.Size = New Size(292, 26)
        VerificarActualizacionesToolStripMenuItem.Text = "Verificar actualizaciones"
        ' 
        ' ActualizarSaldosToolStripMenuItem
        ' 
        ActualizarSaldosToolStripMenuItem.Name = "ActualizarSaldosToolStripMenuItem"
        ActualizarSaldosToolStripMenuItem.Size = New Size(292, 26)
        ActualizarSaldosToolStripMenuItem.Text = "Actualizar saldos"
        ' 
        ' DesactualizarToolStripMenuItem
        ' 
        DesactualizarToolStripMenuItem.Name = "DesactualizarToolStripMenuItem"
        DesactualizarToolStripMenuItem.Size = New Size(292, 26)
        DesactualizarToolStripMenuItem.Text = "Desactualizar"
        ' 
        ' ReiniciarToolStripMenuItem
        ' 
        ReiniciarToolStripMenuItem.Name = "ReiniciarToolStripMenuItem"
        ReiniciarToolStripMenuItem.Size = New Size(292, 26)
        ReiniciarToolStripMenuItem.Text = "Reiniciar"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(292, 26)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' CapturaToolStripMenuItem
        ' 
        CapturaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DatosToolStripMenuItem, PólizaToolStripMenuItem, ChequeToolStripMenuItem1, OtrosProgramasCtrlOToolStripMenuItem})
        CapturaToolStripMenuItem.Name = "CapturaToolStripMenuItem"
        CapturaToolStripMenuItem.Size = New Size(75, 24)
        CapturaToolStripMenuItem.Text = "Captura"
        ' 
        ' DatosToolStripMenuItem
        ' 
        DatosToolStripMenuItem.Name = "DatosToolStripMenuItem"
        DatosToolStripMenuItem.Size = New Size(287, 26)
        DatosToolStripMenuItem.Text = "Datos"
        ' 
        ' PólizaToolStripMenuItem
        ' 
        PólizaToolStripMenuItem.Name = "PólizaToolStripMenuItem"
        PólizaToolStripMenuItem.Size = New Size(287, 26)
        PólizaToolStripMenuItem.Text = "Pólizas                         Ctrl + R"
        ' 
        ' ChequeToolStripMenuItem1
        ' 
        ChequeToolStripMenuItem1.Name = "ChequeToolStripMenuItem1"
        ChequeToolStripMenuItem1.Size = New Size(287, 26)
        ChequeToolStripMenuItem1.Text = "Cheque"
        ' 
        ' OtrosProgramasCtrlOToolStripMenuItem
        ' 
        OtrosProgramasCtrlOToolStripMenuItem.Name = "OtrosProgramasCtrlOToolStripMenuItem"
        OtrosProgramasCtrlOToolStripMenuItem.Size = New Size(287, 26)
        OtrosProgramasCtrlOToolStripMenuItem.Text = "Otros programas       Ctrl + O"
        ' 
        ' EdiciónToolStripMenuItem
        ' 
        EdiciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PegarCtrlVToolStripMenuItem, CopiarCtrlCToolStripMenuItem, CopiarTodoCtrlSToolStripMenuItem, AgregarSubctaToolStripMenuItem, EliminarSubctaToolStripMenuItem, BorrarCuentaToolStripMenuItem, ValidarMovimientoCtrlGToolStripMenuItem, VerificarSumasF6ToolStripMenuItem, BorrarAplicaciónCtrlBToolStripMenuItem, BorrarChequeToolStripMenuItem, SumaDebeYHaberCtrlLToolStripMenuItem})
        EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        EdiciónToolStripMenuItem.Size = New Size(72, 24)
        EdiciónToolStripMenuItem.Text = "Edición"
        ' 
        ' PegarCtrlVToolStripMenuItem
        ' 
        PegarCtrlVToolStripMenuItem.Name = "PegarCtrlVToolStripMenuItem"
        PegarCtrlVToolStripMenuItem.Size = New Size(320, 26)
        PegarCtrlVToolStripMenuItem.Text = "Pegar                                   Ctrl + V"
        ' 
        ' CopiarCtrlCToolStripMenuItem
        ' 
        CopiarCtrlCToolStripMenuItem.Name = "CopiarCtrlCToolStripMenuItem"
        CopiarCtrlCToolStripMenuItem.Size = New Size(320, 26)
        CopiarCtrlCToolStripMenuItem.Text = "Copiar selección                 Ctrl + C"
        ' 
        ' CopiarTodoCtrlSToolStripMenuItem
        ' 
        CopiarTodoCtrlSToolStripMenuItem.Name = "CopiarTodoCtrlSToolStripMenuItem"
        CopiarTodoCtrlSToolStripMenuItem.Size = New Size(320, 26)
        CopiarTodoCtrlSToolStripMenuItem.Text = "Copiar todo                        Ctrl + S"
        ' 
        ' AgregarSubctaToolStripMenuItem
        ' 
        AgregarSubctaToolStripMenuItem.Name = "AgregarSubctaToolStripMenuItem"
        AgregarSubctaToolStripMenuItem.Size = New Size(320, 26)
        AgregarSubctaToolStripMenuItem.Text = "Agregar Subcta"
        ' 
        ' EliminarSubctaToolStripMenuItem
        ' 
        EliminarSubctaToolStripMenuItem.Name = "EliminarSubctaToolStripMenuItem"
        EliminarSubctaToolStripMenuItem.Size = New Size(320, 26)
        EliminarSubctaToolStripMenuItem.Text = "Eliminar Subcta"
        ' 
        ' BorrarCuentaToolStripMenuItem
        ' 
        BorrarCuentaToolStripMenuItem.Name = "BorrarCuentaToolStripMenuItem"
        BorrarCuentaToolStripMenuItem.Size = New Size(320, 26)
        BorrarCuentaToolStripMenuItem.Text = "Borrar cuenta"
        ' 
        ' ValidarMovimientoCtrlGToolStripMenuItem
        ' 
        ValidarMovimientoCtrlGToolStripMenuItem.Name = "ValidarMovimientoCtrlGToolStripMenuItem"
        ValidarMovimientoCtrlGToolStripMenuItem.Size = New Size(320, 26)
        ValidarMovimientoCtrlGToolStripMenuItem.Text = "Validar movimiento                F5"
        ' 
        ' VerificarSumasF6ToolStripMenuItem
        ' 
        VerificarSumasF6ToolStripMenuItem.Name = "VerificarSumasF6ToolStripMenuItem"
        VerificarSumasF6ToolStripMenuItem.Size = New Size(320, 26)
        VerificarSumasF6ToolStripMenuItem.Text = "Verificar sumas                       F6"
        ' 
        ' BorrarAplicaciónCtrlBToolStripMenuItem
        ' 
        BorrarAplicaciónCtrlBToolStripMenuItem.Name = "BorrarAplicaciónCtrlBToolStripMenuItem"
        BorrarAplicaciónCtrlBToolStripMenuItem.Size = New Size(320, 26)
        BorrarAplicaciónCtrlBToolStripMenuItem.Text = "Borrar aplicación                Ctrl + B"
        ' 
        ' BorrarChequeToolStripMenuItem
        ' 
        BorrarChequeToolStripMenuItem.Name = "BorrarChequeToolStripMenuItem"
        BorrarChequeToolStripMenuItem.Size = New Size(320, 26)
        BorrarChequeToolStripMenuItem.Text = "Borrar cheque"
        ' 
        ' SumaDebeYHaberCtrlLToolStripMenuItem
        ' 
        SumaDebeYHaberCtrlLToolStripMenuItem.Name = "SumaDebeYHaberCtrlLToolStripMenuItem"
        SumaDebeYHaberCtrlLToolStripMenuItem.Size = New Size(320, 26)
        SumaDebeYHaberCtrlLToolStripMenuItem.Text = "Suma debe y haber             Ctrl + L"
        ' 
        ' MesToolStripMenuItem
        ' 
        MesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CuentasCtrlMToolStripMenuItem, SubcuentasCtrlToolStripMenuItem, SumasToolStripMenuItem, PólizasCtrlFToolStripMenuItem, AuxiliarDeMayorCtrlAToolStripMenuItem, EstadosFinancierosCtrlToolStripMenuItem})
        MesToolStripMenuItem.Name = "MesToolStripMenuItem"
        MesToolStripMenuItem.Size = New Size(44, 24)
        MesToolStripMenuItem.Text = "Ver"
        ' 
        ' CuentasCtrlMToolStripMenuItem
        ' 
        CuentasCtrlMToolStripMenuItem.Name = "CuentasCtrlMToolStripMenuItem"
        CuentasCtrlMToolStripMenuItem.Size = New Size(314, 26)
        CuentasCtrlMToolStripMenuItem.Text = "Cuentas                             Ctrl + M"
        ' 
        ' SubcuentasCtrlToolStripMenuItem
        ' 
        SubcuentasCtrlToolStripMenuItem.Name = "SubcuentasCtrlToolStripMenuItem"
        SubcuentasCtrlToolStripMenuItem.Size = New Size(314, 26)
        SubcuentasCtrlToolStripMenuItem.Text = "Subcuentas                       Ctrl + N"
        ' 
        ' SumasToolStripMenuItem
        ' 
        SumasToolStripMenuItem.Name = "SumasToolStripMenuItem"
        SumasToolStripMenuItem.Size = New Size(314, 26)
        SumasToolStripMenuItem.Text = "Sumas"
        ' 
        ' PólizasCtrlFToolStripMenuItem
        ' 
        PólizasCtrlFToolStripMenuItem.Name = "PólizasCtrlFToolStripMenuItem"
        PólizasCtrlFToolStripMenuItem.Size = New Size(314, 26)
        PólizasCtrlFToolStripMenuItem.Text = "Pólizas                              Ctrl + D"
        ' 
        ' AuxiliarDeMayorCtrlAToolStripMenuItem
        ' 
        AuxiliarDeMayorCtrlAToolStripMenuItem.Name = "AuxiliarDeMayorCtrlAToolStripMenuItem"
        AuxiliarDeMayorCtrlAToolStripMenuItem.Size = New Size(314, 26)
        AuxiliarDeMayorCtrlAToolStripMenuItem.Text = "Auxiliar de mayor            Ctrl + A"
        ' 
        ' EstadosFinancierosCtrlToolStripMenuItem
        ' 
        EstadosFinancierosCtrlToolStripMenuItem.Name = "EstadosFinancierosCtrlToolStripMenuItem"
        EstadosFinancierosCtrlToolStripMenuItem.Size = New Size(314, 26)
        EstadosFinancierosCtrlToolStripMenuItem.Text = "Estados financieros          Ctrl + E"
        ' 
        ' AyudaToolStripMenuItem
        ' 
        AyudaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {IncorporaciónToolStripMenuItem, EneroToolStripMenuItem, FebreroToolStripMenuItem, MarzoToolStripMenuItem, AbrilToolStripMenuItem, MayoToolStripMenuItem, JunioToolStripMenuItem, JulioToolStripMenuItem, AgostoToolStripMenuItem, SeptiembreToolStripMenuItem, OctubreToolStripMenuItem, NoviembreToolStripMenuItem, DiciembreToolStripMenuItem})
        AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        AyudaToolStripMenuItem.Size = New Size(50, 24)
        AyudaToolStripMenuItem.Text = "Mes"
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
        FebreroToolStripMenuItem.Text = "Febrero "
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
        ' AyudaToolStripMenuItem1
        ' 
        AyudaToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {ÍndiceToolStripMenuItem, VersiónToolStripMenuItem})
        AyudaToolStripMenuItem1.Name = "AyudaToolStripMenuItem1"
        AyudaToolStripMenuItem1.Size = New Size(65, 24)
        AyudaToolStripMenuItem1.Text = "Ayuda"
        ' 
        ' ÍndiceToolStripMenuItem
        ' 
        ÍndiceToolStripMenuItem.Name = "ÍndiceToolStripMenuItem"
        ÍndiceToolStripMenuItem.Size = New Size(140, 26)
        ÍndiceToolStripMenuItem.Text = "Índice"
        ' 
        ' VersiónToolStripMenuItem
        ' 
        VersiónToolStripMenuItem.Name = "VersiónToolStripMenuItem"
        VersiónToolStripMenuItem.Size = New Size(140, 26)
        VersiónToolStripMenuItem.Text = "Versión"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(24, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 23)
        Label1.TabIndex = 1
        Label1.Text = "Día: "
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(74, 62)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(65, 27)
        TextBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.BackColor = SystemColors.ActiveBorder
        Label2.Location = New Point(156, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(281, 25)
        Label2.TabIndex = 3
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Yellow
        Label3.Location = New Point(467, 62)
        Label3.Name = "Label3"
        Label3.Size = New Size(155, 25)
        Label3.TabIndex = 4
        Label3.Text = "Label3"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(642, 63)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(75, 24)
        CheckBox1.TabIndex = 5
        CheckBox1.Text = "Costos"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(74, 95)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(171, 27)
        TextBox2.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(24, 145)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 23)
        Label4.TabIndex = 7
        Label4.Text = "RFC:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(75, 145)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(319, 27)
        TextBox3.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(412, 146)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 23)
        Label5.TabIndex = 9
        Label5.Text = "Folio Fiscal"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(511, 109)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(251, 27)
        TextBox4.TabIndex = 10
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(511, 142)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(251, 27)
        TextBox5.TabIndex = 11
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' OpenFileDialog2
        ' 
        OpenFileDialog2.FileName = "OpenFileDialog2"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.AppWorkspace
        Label6.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label6.Location = New Point(237, 201)
        Label6.Name = "Label6"
        Label6.Size = New Size(385, 23)
        Label6.TabIndex = 12
        Label6.Text = "Recuerda Cargar el Pdf y Xml antes de Capturar"
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
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ColCuenta, ColSubCta, ColNom, ColParcial, ColDebe, ColHaber, ColReda, ColFolioFis})
        DataGridView1.GridColor = SystemColors.ActiveBorder
        DataGridView1.Location = New Point(24, 250)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(1177, 271)
        DataGridView1.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(15, 19)
        Label7.Name = "Label7"
        Label7.Size = New Size(103, 23)
        Label7.TabIndex = 14
        Label7.Text = "Beneficiario:"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(136, 16)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(194, 27)
        TextBox6.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(356, 19)
        Label8.Name = "Label8"
        Label8.Size = New Size(19, 23)
        Label8.TabIndex = 16
        Label8.Text = "$"
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(393, 19)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(97, 27)
        TextBox7.TabIndex = 17
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(15, 64)
        Label9.Name = "Label9"
        Label9.Size = New Size(88, 23)
        Label9.TabIndex = 18
        Label9.Text = "Concepto:"
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(15, 106)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(334, 27)
        TextBox8.TabIndex = 19
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(393, 64)
        Label10.Name = "Label10"
        Label10.Size = New Size(77, 23)
        Label10.TabIndex = 20
        Label10.Text = "Número:"
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(393, 106)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(184, 27)
        TextBox9.TabIndex = 21
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(15, 158)
        Label11.Name = "Label11"
        Label11.Size = New Size(46, 23)
        Label11.TabIndex = 22
        Label11.Text = "RFC:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(244, 158)
        Label12.Name = "Label12"
        Label12.Size = New Size(166, 23)
        Label12.TabIndex = 23
        Label12.Text = "FOLIO(S) FISCALES:"
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(15, 194)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(185, 27)
        TextBox10.TabIndex = 24
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(244, 194)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(327, 27)
        TextBox11.TabIndex = 25
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox11)
        GroupBox1.Controls.Add(TextBox10)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(TextBox9)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(TextBox8)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(TextBox7)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(TextBox6)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Location = New Point(91, 634)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(610, 251)
        GroupBox1.TabIndex = 26
        GroupBox1.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(CheckBox2)
        GroupBox2.Location = New Point(720, 650)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(120, 101)
        GroupBox2.TabIndex = 27
        GroupBox2.TabStop = False
        GroupBox2.Text = "No. Cheque"
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(17, 47)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(88, 24)
        CheckBox2.TabIndex = 0
        CheckBox2.Text = "Imprimir"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog3
        ' 
        OpenFileDialog3.FileName = "OpenFileDialog3"
        ' 
        ' OpenFileDialog4
        ' 
        OpenFileDialog4.FileName = "OpenFileDialog4"
        ' 
        ' ColCuenta
        ' 
        ColCuenta.HeaderText = "Cuenta"
        ColCuenta.MinimumWidth = 6
        ColCuenta.Name = "ColCuenta"
        ColCuenta.Width = 125
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
        ' ColReda
        ' 
        ColReda.HeaderText = "Redacción"
        ColReda.MinimumWidth = 6
        ColReda.Name = "ColReda"
        ColReda.Width = 125
        ' 
        ' ColFolioFis
        ' 
        ColFolioFis.HeaderText = "Folio Fiscal"
        ColFolioFis.MinimumWidth = 6
        ColFolioFis.Name = "ColFolioFis"
        ColFolioFis.Width = 125
        ' 
        ' CAP_Cheques
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1307, 1034)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(DataGridView1)
        Controls.Add(Label6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(Label5)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(CheckBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "CAP_Cheques"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CAP_Cheques"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CambioSubdirectorioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarAplicaciónCtrlGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DirectorioDeCostosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImpresiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CapturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChequeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjustarChequeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerificarActualizacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarSaldosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesactualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReiniciarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PólizaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChequeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OtrosProgramasCtrlOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PegarCtrlVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarCtrlCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarTodoCtrlSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarSubctaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarSubctaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrarCuentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ValidarMovimientoCtrlGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerificarSumasF6ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrarAplicaciónCtrlBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrarChequeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SumaDebeYHaberCtrlLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuentasCtrlMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubcuentasCtrlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SumasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PólizasCtrlFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AuxiliarDeMayorCtrlAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadosFinancierosCtrlToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents AyudaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ÍndiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VersiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents OpenFileDialog3 As OpenFileDialog
    Friend WithEvents OpenFileDialog4 As OpenFileDialog
    Friend WithEvents ColCuenta As DataGridViewTextBoxColumn
    Friend WithEvents ColSubCta As DataGridViewTextBoxColumn
    Friend WithEvents ColNom As DataGridViewTextBoxColumn
    Friend WithEvents ColParcial As DataGridViewTextBoxColumn
    Friend WithEvents ColDebe As DataGridViewTextBoxColumn
    Friend WithEvents ColHaber As DataGridViewTextBoxColumn
    Friend WithEvents ColReda As DataGridViewTextBoxColumn
    Friend WithEvents ColFolioFis As DataGridViewTextBoxColumn
End Class
