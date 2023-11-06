Imports System.Diagnostics.Eventing.Reader
Imports System.Drawing.Printing
Imports System.IO
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml
Imports MSXML2
Imports AplicaciónNomina_versionPreliminar_23_09_01.Modulo_EstructurasDeDatos


Public Class CAP_Cheques
    Dim anuncio As String
    Dim Archivo As String
    Dim Arch_act As String
    Dim midir As String
    Dim MientraS As String
    Dim nom_arch As String
    Dim tope As String
    Dim nombreEmpresa As String
    Dim numcheque As String
    Dim numpoliza As String
    Dim mensaje As String
    Dim mesXml As String
    Dim respuesta As String
    Dim concepto As String
    Dim currentdir As String
    Dim mi_entr As String
    Dim rgtro As Integer
    Dim Ok_che As Integer
    Dim no_Se_Mofifica As Integer
    Dim impor_te As Long
    Dim c_ambiar As Integer
    Dim donde As Integer
    Dim Sal_do As Long
    Dim sumaDebe As Long
    Dim sumaHaber As Long
    Dim flag As Long
    Dim valida As Integer
    Dim verct_a As Integer
    Dim contadorXml As Integer
    Dim difer As Integer
    Dim importe As Integer
    Dim miArchivo As String

    Private Sub CAP_Cheques_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        contadorXml = 0
        miArchivo = Dir(numeroGConta, vbDirectory)
        If miArchivo = "" Then
            MkDir(numeroGConta)
        End If
        Dim appPath As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)

        Ruta_Acceso_Contr = numeroGConta
        Ruta_Acceso = appPath

        Label4.Visible = False
        Label5.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        GroupBox1.Visible = True
        GroupBox2.Visible = True
        Label3.Text = ""
        Label13.Visible = False
        ColReda.Visible = False
        Label2.BackColor = Color.White
        CAP_LocalizarPolizas.Visible = False


        Dim helpProvider As New HelpProvider()
        helpProvider.HelpNamespace = Ruta_Acceso + "\payuda2.hlp"



        'inicio()

        z1 = "##,###,##0.00"

        MesCheque(1) = " ENERO"
        MesCheque(2) = " FEBRERO"
        MesCheque(3) = " MARZO"
        MesCheque(4) = " ABRIL"
        MesCheque(5) = " MAYO"
        MesCheque(6) = " JUNIO"
        MesCheque(7) = " JULIO"
        MesCheque(8) = " AGOSTO"
        MesCheque(9) = " SEPTIEMBRE"
        MesCheque(10) = " OCTUBRE"
        MesCheque(11) = " NOVIEMBRE"
        MesCheque(12) = " DICIEMBRE"

        MesCheque(13) = " INCORPORACIÓN"

        dd(1) = 31 : dd(2) = 28 : dd(3) = 31 : dd(4) = 30
        dd(5) = 31 : dd(6) = 30 : dd(7) = 31 : dd(8) = 31
        dd(9) = 30 : dd(10) = 31 : dd(11) = 30 : dd(12) = 31
        dd(13) = 3

        DataGridView1.ColumnCount = 9
        DataGridView1.RowCount = 250

        DataGridView1.Columns(0).Width = 75 : DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(0).HeaderText = "Cuenta" : DataGridView1.Columns(0).HeaderCell.Style.BackColor = Color.Yellow : DataGridView1.Columns(0).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Columns(1).Width = 75 : DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(1).HeaderText = "Subcta" : DataGridView1.Columns(1).HeaderCell.Style.BackColor = Color.Yellow : DataGridView1.Columns(1).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Columns(2).Width = 400 : DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(2).HeaderText = "Nombre" : DataGridView1.Columns(2).HeaderCell.Style.BackColor = Color.Yellow : DataGridView1.Columns(2).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Columns(3).Width = 100 : DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(3).HeaderText = "Parcial" : DataGridView1.Columns(3).HeaderCell.Style.BackColor = Color.Yellow : DataGridView1.Columns(3).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Columns(4).Width = 100 : DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(4).HeaderText = "Debe " : DataGridView1.Columns(4).HeaderCell.Style.BackColor = Color.Yellow : DataGridView1.Columns(4).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Columns(5).Width = 100 : DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(5).HeaderText = "Haber" : DataGridView1.Columns(5).HeaderCell.Style.BackColor = Color.Yellow : DataGridView1.Columns(5).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Columns(6).Width = 200 : DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(6).HeaderText = "Redacción" : DataGridView1.Columns(6).HeaderCell.Style.BackColor = Color.Yellow : DataGridView1.Columns(6).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Columns(7).Width = 200 : DataGridView1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(7).HeaderText = "Folio Fiscal" : DataGridView1.Columns(7).HeaderCell.Style.BackColor = Color.Yellow : DataGridView1.Columns(7).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)





        ReDim archivos1(0)
        ' sigpaso()


        incluirMes()
        CAP_LocalizarPolizas.Visible = False


    End Sub


    Private Sub EstadosFinancierosCtrlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadosFinancierosCtrlToolStripMenuItem.Click
        CAP_Balance.Show()
    End Sub


    Sub sigpaso()

        If cm < 1 Then
            MsgBox("No Existe Datos de Contabilidad Cambie subdirectorio ")

            FileClose(1)
        Else
            FileGet(numeroDatos, DATOS, 1)
            Label2.BackColor = Color.Yellow

            mespoliza = 1
            Label2.Text = "de" + RTrim(MesCheque(mespoliza)) + "de" + DATOS.a_o
            Me.Text = Mid(DATOS.D1, 1, 32) & "  Captura de cheques"
            nombreEmpresa = Trim(DATOS.D2)
            ultimo.texto = RTrim(DATOS.No_arch)
        End If

    End Sub
    Sub inicio()

        Dim checar As String

        Try
            'abrirRandomNominaCaptura()
            FileGet(numeroGConta, SCont, 1)

            If SCont.guarda.Substring(0, 1) <= " " Then
                ChDrive("C:\")
            Else
                If Not SCont.guarda.StartsWith("C") Then
                    ChDrive(SCont.guarda.Substring(0, 1))
                End If

                ChDir(SCont.guarda.Trim())




                FileGet(numeroGConta, SCont, 2) : Dir_Costos = SCont.guarda.Trim()

                FileGet(numeroGConta, SCont, 1)

                'FileClose(numeroGConta)


                Archivo = "DATOS"

                cm = LOF(1) / Len(DATOS)
                FileGet(1, DATOS, 1)
                checar = Trim(DATOS.No_arch)


                ' Bloquea la grid si se esta usando costos

                If checar = "COS" Then
                    MsgBox("Actualmente estás en el Directorio de costos " + Trim(SCont.guarda) + " Recuerda que no puedes capturar costos con este programa, utiliza el programa de costos")
                    Me.DataGridView1.Enabled = False
                    DataGridView1.Enabled = False
                Else

                    Me.DataGridView1.Enabled = True
                    DataGridView1.Enabled = True

                End If
            End If
            ' Cerrar el archivo
            ' FileClose(numeroGConta)

        Catch
            MsgBox(Err.Description)
        End Try

    End Sub
    Sub recupera()
        Select Case DataGridView1.Rows(-1).Cells(9).Value
            Case "B"
                trscta.refer = DataGridView1.Rows(-1).Cells(0).Value
                trcta.incia = DataGridView1.Rows(trscta.refer).Cells(7).Value
                trcta.termina = DataGridView1.Rows(trscta.refer).Cells(8).Value


            Case "C"
                trscta.refer = DataGridView1.Rows(-1).Cells(7).Value
                trcta.incia = DataGridView1.Rows(trscta.refer).Cells(7).Value
                trcta.termina = DataGridView1.Rows(trscta.refer).Cells(8).Value

        End Select
    End Sub
    Sub aplicacion()
        Dim i As Integer
        'abrirRandomNominaCaptura()
        OPER.CTA = String.Format("{0}{1}", New String("", 6 - ultimo.poliza.ToString().Length), ultimo.poliza)

        'OPER.CTA = (6 - Len(Str(ultimo.poliza)), " ") + Str(ultimo.poliza)
        If ultimo.TipoCap = 0 Then
            OPER.descr = String.Concat(TextBox5.Text.Trim(), TextBox4.Text.Trim().Substring(0, 8))

            'OPER.descr = LTrim(RTrim(TextBox5.Text)) + "" + Left(TextBox4.Text, 8)
        Else
            OPER.descr = RTrim(TextBox4.Text)
        End If

        OPER.indenti = "A"
        OPER.fe = LTrim(RTrim(TextBox1.Text))
        OPER.impte = ""
        OPER.real = ""
        fin_oper = fin_oper + 1
        FilePut(3, OPER, fin_oper)

        'Incluir aquí RFC y Folio Fiscal
        OPER.indenti = "D"

        If ultimo.TipoCap = 0 Then
            OPER.CTA = Trim(TextBox11.Text.Trim().Substring(0, 6))
            OPER.descr = TextBox11.Text.Trim().Substring(TextBox11.Text.Length - 30)
            OPER.fe = ""
            OPER.impte = Trim(TextBox10.Text)
            OPER.real = ""
            fin_oper = fin_oper + 1
            FilePut(3, OPER, fin_oper)
        Else

            OPER.CTA = Trim(TextBox5.Text.Trim().Substring(0, 6))
            OPER.descr = TextBox5.Text.Trim().Substring(TextBox5.Text.Length - 30)
            OPER.fe = ""
            OPER.impte = Trim(TextBox3.Text)
            OPER.real = ""
            fin_oper = fin_oper + 1
            FilePut(3, OPER, fin_oper)

        End If

        For i = 1 To DataGridView1.RowCount - 1
            Select Case DataGridView1.Rows(i).Cells(9).Value
                Case "B"
                    OPER.CTA = StrDup(6 - Len(DataGridView1.Rows(i).Cells(0).Value), " ") & DataGridView1.Rows(i).Cells(0).Value
                    OPER.descr = ""
                    OPER.fe = ""

                    If DataGridView1.Rows(i).Cells(5).Value = "" Then
                        impor_te = DataGridView1.Rows(i).Cells(4).Value
                    Else
                        impor_te = DataGridView1.Rows(i).Cells(5).Value
                    End If

                    OPER.indenti = DataGridView1.Rows(i).Cells(9).Value
                    OPER.impte = Str(impor_te)
                    OPER.real = DataGridView1.Rows(i).Cells(6).Value
                    fin_oper = fin_oper + 1
                    FilePut(3, OPER, fin_oper)

                Case "C"
                    OPER.CTA = StrDup(6 - Len(DataGridView1.Rows(i).Cells(6).Value), " ") & DataGridView1.Rows(i).Cells(6).Value
                    If ultimo.TipoCap = 0 Then

                        OPER.descr = TextBox9.Text.TrimEnd() & " " & TextBox6.Text.Substring(0, Math.Min(TextBox6.Text.Length, 20)) & " " & TextBox8.Text.Substring(0, Math.Min(TextBox8.Text.Length, 8))
                    Else
                        OPER.descr = RTrim(DataGridView1.Rows(i).Cells(10).Value)
                    End If
                    If (Not String.IsNullOrEmpty(Trim(DataGridView1.Rows(i).Cells(10).Value)) OrElse LCase(Trim(DataGridView1.Rows(i).Cells(10).Value)) = "doble clic para seleccionar folio fiscal") AndAlso change = False Then
                        fiscal.folio = Trim(DataGridView1.Rows(i).Cells(10).Value)
                        fiscal.estado = True
                    Else
                        fiscal.estado = False

                    End If

                    If change = True Then
                        If (Not String.IsNullOrEmpty(DataGridView1.Rows(i).Cells(11).Value) OrElse LCase(Trim(DataGridView1.Rows(i).Cells(10).Value)) = "doble clic para seleccionar folio fiscal") Then
                            fiscal.folio = Trim(DataGridView1.Rows(i).Cells(11).Value)
                            fiscal.estado = True
                        Else
                            fiscal.estado = False

                        End If
                    End If

                    OPER.fe = ""
                    impor_te = DataGridView1.Rows(i).Cells(3).Value
                    OPER.indenti = DataGridView1.Rows(i).Cells(9).Value
                    OPER.impte = Str(impor_te)
                    OPER.real = DataGridView1.Rows(i).Cells(1).Value
                    fin_oper = fin_oper + 1
                    FilePut(18, fiscal, fin_oper)
                    FilePut(3, OPER, fin_oper)

            End Select

        Next i

        'BorrarChequeToolStripMenuItem_Click()



        'editaplic

        Close()

    End Sub
    Sub reiniciarAplicacion()

    End Sub

    Sub cam_saldo()


        If DataGridView1.Rows(trscta.refer).Cells(4).Value <> "" Or DataGridView1.Rows(trscta.refer).Cells(5).Value <> "" Then
            If DataGridView1.Rows(trscta.refer).Cells(5).Value = "" Then
                Sal_do = DataGridView1.Rows(trscta.refer).Cells(4).Value
            Else
                Sal_do = DataGridView1.Rows(trscta.refer).Cells(5).Value
            End If
        End If
        If valcelant = "" Then valcelant = 0
        If c_ambiar = 1 Then Sal_do = Sal_do - valcelant : 
        Sal_do = Sal_do + impor_te
        'Dim resul As String = Strings.Format(Sal_do, "z1")
        'Dim resutl As String = Strings.Format(impor_te, "z1")
        If Sal_do > 0 Then 'Cuando "saldo" en (n,4) de como resultado un valor mayor a cero entrara en esta función

            DataGridView1.Rows(trscta.refer).Cells(4).Value = Format(Sal_do, z1)
            DataGridView1.Rows(trscta.refer).Cells(5).Value = ""
            Alarma.Imt = Sal_do
            VerSumas()
        Else

            DataGridView1.Rows(trscta.refer).Cells(5).Value = Format(Sal_do, z1)
            DataGridView1.Rows(trscta.refer).Cells(4).Value = ""
            Alarma.Imt = Sal_do
            VerSumas()

            If impor_te > 0 Then
                DataGridView1.Rows(trscta.refer).Cells(4).Value = Format(impor_te, z1)
                DataGridView1.Rows(trscta.refer).Cells(5).Value = ""
                Alarma.Imt = impor_te
                VerSumas()
            Else
                DataGridView1.Rows(trscta.refer).Cells(5).Value = Format(impor_te, z1)
                DataGridView1.Rows(trscta.refer).Cells(4).Value = ""
                Alarma.Imt = impor_te
                VerSumas()
            End If


        End If

    End Sub

    Sub VerSumas()
        Dim i As Integer
        sumaDebe = 0 : sumaHaber = 0 : Ok_che = 0
        For i = 1 To ultimo.renglon
            If DataGridView1.Rows(i).Cells(4).Value <> "" Then
                sumaDebe = sumaDebe + DataGridView1.Rows(i).Cells(4).Value
            End If
            If DataGridView1.Rows(i).Cells(5).Value <> "" Then
                sumaDebe = sumaDebe + DataGridView1.Rows(i).Cells(5).Value
            End If
        Next i
        'Dim resultado As Integer = Strings.Format(sumaDebe, "###,###,##0.00")
        DataGridView1.Rows(0).Cells(4).Value = Format(sumaDebe, "###,###,##0.00")
        DataGridView1.Rows(0).Cells(5).Value = Format(sumaDebe, "###,###,##0.00")


    End Sub
    Sub depura(elemento As Integer)

        If elemento > 57 Then
            MsgBox("Solo se aceptan valores númericos")
            valida = 1

        End If


    End Sub

    Sub Actualizacion()
        Dim i As Integer
        Close()
        'abrirRandomNominaCaptura()
        FileGet(1, DATOS, 1)
        If DATOS.No_arch = "" Then
            Archivo = InputBox("Teclee el nombre del archivo de datos ")
            If Len(Archivo) > 6 Then
                MsgBox("Nombre de archivo no valido ", vbCritical)
                Exit Sub
            Else
                DATOS.No_arch = Archivo
                FilePut(1, DATOS, 1)
            End If
        End If

        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.ReadOnlyChecked = True
        openFileDialog.ShowReadOnly = False
        openFileDialog.CheckPathExists = False

        midir = System.IO.Directory.GetCurrentDirectory()
        midir = midir.TrimEnd()

        If midir.EndsWith("\") Then
            midir = midir.Substring(0, midir.Length - 1)
        End If

        DATOS.No_arch = RTrim(DATOS.No_arch)
        OpenFileDialog1.FileName = midir + "\" + RTrim(DATOS.No_arch) + "*.*"
        anuncio = ""
        anuncio = "Archivos de Operaciones (" + RTrim(DATOS.No_arch) + "*.*)|" + RTrim(DATOS.No_arch) + "*.*|Todos los archivos (*.*)|*.*"
        'OpenFileDialog1 = anuncio
        OpenFileDialog1.ShowDialog()
        donde = Len(RTrim(DATOS.No_arch)) + 1
        Arch_act = OpenFileDialog1.Title.TrimEnd()
        Mes_Act = 0
        For i = 1 To Len(Arch_act)
            If (Mid(Arch_act, i, 1) >= Chr(48)) AndAlso (Mid(Arch_act, i, 1) <= Chr(57)) Then
                Mes_Act = Val((RTrim(Arch_act), 2))
            End If
            If (Mid(Arch_act, i + 2, 1)) = "." Then
                MsgBox("Archivo no Valido ", vbCritical)
                Exit Sub
            End If
            Exit For
        Next i


    End Sub

    Private Sub ActualizarSaldosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarSaldosToolStripMenuItem.Click
        If (Mes_Act > 0) And (Mes_Act < 14) Then
            FileGet(1, DATOS, Mes_Act)
            rgtro = Val(DATOS.ultimaOperacionReg)

            'abrirRandomNominaCaptura()


            tope = Val(DATOS.ultimaOperacionReg)
            If rgtro >= Dm Then
                MsgBox(RTrim(Arch_act) + " No es posible DesActualizar ", vbCritical, "Actualizacion de Saldos")
                FileClose(1, 12)
            Else
                ultimo.num = 2
                ultimo.Ubi = tope + 1
                CAP_Actualizacion.Show()
                'Me.Show()
                ultimo.num = 0
                ultimo.Ubi = 0
                Mes_Act = 0
            End If
        End If

    End Sub

    Private Sub DirectorioDeCostosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DirectorioDeCostosToolStripMenuItem.Click

        Dim mi_ent As String
        mi_entr = ultimo.texto

        FileGet(numeroGConta, SCont, 2)
        CAP_Entrada.Text = Trim(SCont.guarda)
        CAP_Entrada.Label1.Text = "Ubicación de directorios"
        CAP_Entrada.Text = "Cg-Contabilidad"
        CAP_Entrada.Show()


        If ultimo.texto <> "" Then
            If ultimo.texto.EndsWith("\") Then
                ultimo.texto = ultimo.texto & "\"

            End If
            SCont.guarda = ultimo.texto
        End If
        ultimo.texto = mi_ent

        If SCont.guarda <> "" Then
            'abrirRandomNominaCaptura()


            Dir_Costos = Trim(SCont.guarda)
            mi_ent = Dir(Dir_Costos)
            If mi_ent <> "" Then
                FilePut(numeroGConta, SCont.guarda, 2)
                Close()
            Else
                MessageBox.Show("NO EXISTE EL DIRECTORIO", "Error")
                Close()

            End If
            'MessageBox.Show("NO EXISTE EL DIRECTORIO", "Error")
            'Close()

        End If


    End Sub
    Private Sub DesactualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesactualizarToolStripMenuItem.Click
        Actualizacion()
        If Mes_Act > 0 And Mes_Act < 14 Then
            FileGet(1, DATOS, Mes_Act)
            rgtro = Val(DATOS.ultimaOperacionReg)

            tope = Val(DATOS.ultimaOperacionReg)
            If rgtro <> Dm Then
                MsgBox(RTrim(Arch_act) + "No es posible Desactualizar", vbCritical)
            Else
                ultimo.num = 3
                ultimo.Ubi = 1
                CAP_Actualizacion.Show()
                ultimo.num = 0
                ultimo.Ubi = 0
                Mes_Act = 0

            End If

        End If
    End Sub
    Private Sub GuardarAplicaciónCtrlGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarAplicaciónCtrlGToolStripMenuItem.Click
        Dim i As Integer
        If (validatePdfArchives < 1 And change = False) Then
            MessageBox.Show("No se puede guardar cheque sin archivo PDF", "Error")
            Exit Sub
        End If

        For i = 0 To DataGridView1.Rows(0).Cells(0).Value = -1
            If DataGridView1.Rows(0).Cells(0).Value <> "" Then
                ultimo.renglon = i + 1
            End If
        Next i

        mesXml = Mid(Label2.Text, 4, 3)
        Dim beneficiario As String = TextBox6.Text.Substring(0, 20)
        currentdir = Trim(Modulo_EstructurasDeDatos.SCont.guarda)
        currentdir = Mid(currentdir, 1, 2)
        concepto = TextBox8.Text.Trim().Substring(0, 8) & TextBox4.Text.Trim().Substring(0, 30)
        numcheque = LTrim(RTrim(TextBox8.Text))

        If ultimo.renglon <= 3 Then
            MsgBox("No se puede guardar la aplicación", vbCritical, "Captura de cheques")
            Exit Sub
        End If

        If ultimo.TipoCap = 0 Then
            If (ultimo.Impresion = 0) And (ultimo.TipoCap = 0) Then
                MsgBox("El cheque no se ha impreso.")
                Exit Sub
            End If
            inicio()
            archivooper()
            Dim nom_arch As Integer = FreeFile()
            Close()
            'abrirRandomNominaCaptura()
            fin_oper = LOF(3) / Len(OPER)
            ultimo.poliza = 0

            If fin_oper <= 0 Then
                ultimo.poliza = 1
            Else
                For i = fin_oper To 1 Step -1
                    FileGet(3, OPER, i)
                    If OPER.indenti = "A" Then
                        ultimo.poliza = Val(OPER.CTA) + 1
                        Label3.Text = "Poliza No. " + Str(ultimo.poliza)
                        numpoliza = Trim(Str(ultimo.poliza))
                        Exit For
                    End If
                Next
            End If


            'chkux()

            If ultimo.renglon <= 3 Then
                MsgBox("No se puede archivar la aplicación", vbCritical, "Captura de cheques.")
                Exit Sub
            End If
            aplicacion()
            ultimo.poliza = 0
        End If

        If ultimo.TipoCap = 1 Then
            FileClose(3)
            'abrirRandomNominaCaptura()
            fin_oper = LOF(3) / Len(OPER)
            Ok_che = 0
            verificar(0, 0, Ok_che)

            If Ok_che = 1 Then
                ultimo.poliza = 0

                If fin_oper <= 0 Then
                    ultimo.poliza = 1
                Else
                    For i = fin_oper To 1 Step -1
                        FileGet(3, OPER, i)
                        If OPER.indenti = "A" Then
                            ultimo.poliza = Val(OPER.CTA) + 1
                            Label3.Text = "Poliza No. " + Str(ultimo.poliza)
                            numpoliza = Trim(Str(ultimo.poliza))
                            Exit For
                        End If
                    Next i
                End If
                'chkaux
                If ultimo.renglon <= 3 Then
                    MsgBox("No se puede archivar la aplicación", vbCritical, "Captura de cheques")
                    Exit Sub
                End If
                aplicacion()

                ultimo.poliza = ultimo.poliza + 1
                Label3.Text = "Poliza No. " + Str(ultimo.poliza)
            End If
            FileClose(3)

        End If
        dir1 = Trim(SCont.guarda)


    End Sub


    Sub limpiar()
        verct_a = 0
        trcta.clave = 0 : trcta.donde = 0 : trcta.incia = 0
        trscta.nombre = 0 : trscta.num = 0 : trcta.termina = 0
        ultimo.renglon = 0

    End Sub
    Sub archivooper()
        If RTrim(ultimo.texto) <= "" Then
            CAP_Entrada.Text = ""
            CAP_Entrada.Text = "Captura de cheques"
            CAP_Entrada.Text = "No existe nombre de archivo de operaciones" & Environment.NewLine & "Use máximo 6 caracteres"
            CAP_Entrada.Width = 180 * 6
            CAP_Entrada.Show()
            DATOS.No_arch = ultimo.texto

            If RTrim(ultimo.texto) = "" Then
                Exit Sub
            End If
            FilePut(1, DATOS, 1)
        End If
        If mespoliza = 10 Then
            nom_arch = UCase(RTrim(ultimo.texto)) + "0" + LTrim(Str(mespoliza))
        Else
            nom_arch = UCase(RTrim(ultimo.texto)) + LTrim(Str(mespoliza))
        End If

    End Sub


    Sub localizarpoliza()
        Dim i As Integer
        archivooper()
        Dim nom_arch As Integer = FreeFile()

        'abrirRandomNominaCaptura()
        'FileOpen(nom_arch, "ruta_del_archivo", OpenMode.Random, OpenAccess.ReadWrite, OpenShare.Shared, Len(OPER))
        'fin_oper = LOF(nom_arch) / Len(OPER)
        ultimo.poliza = 0
        If fin_oper <= 0 Then
            ultimo.poliza = 1
            Label3.Text = "Poliza No. " + Str(ultimo.poliza)
        Else
            For i = fin_oper To 1 Step -1
                FileGet(3, OPER, 1)
                If OPER.indenti = "A" Then
                    ultimo.poliza = Val(OPER.CTA) + 1
                    Label3.Text = "Poliza No. " + Str(ultimo.poliza)
                    Exit For
                End If
            Next i


        End If
        limpiar()


    End Sub

    Private Sub CambioSubdirectorioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambioSubdirectorioToolStripMenuItem.Click


        'FileClose(1)

        'MientraS = ""
        'Ruta_Acceso_Contr = ""


        Try

            midir = System.IO.Directory.GetCurrentDirectory()
            midir = midir.TrimEnd()
            Dim dir1 As New System.IO.DirectoryInfo(System.IO.Directory.GetCurrentDirectory())
            If midir.EndsWith("\") Then
                midir = midir.Substring(0, midir.Length - 1)

            End If


            Dim openFileDialog1 As New OpenFileDialog With {
            .InitialDirectory = "midir",
            .CheckFileExists = True,
            .ShowReadOnly = False,
            .Filter = "Archivos de Nomina(Dat*.*)|Dat*.*",
            .Title = "Seleccionar archivo"
        }
            If openFileDialog1.ShowDialog() = DialogResult.OK Then

                ' Realiza alguna acción con el archivo seleccionado.
                If openFileDialog1.FileName <> "" Then

                    Dim tope As Integer = openFileDialog1.FileName.LastIndexOf("\")



                    MientraS = (openFileDialog1.FileName.Substring(0, tope))

                    ChDir(MientraS)

                    FileClose(numeroGConta)

                    ' abrirRandomNominaCaptura()
                    SCont.guarda = MientraS
                    FilePut(numeroGConta, MientraS, 1)

                    'FileClose(numeroGConta)

                    cm = 0
                    inicio()
                    sigpaso()
                    ''MeEne_Click 1
                End If
            End If

            Exit Sub
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        If ultimo.renglon > 1 And ultimo.poliza = 0 Then
            mensaje = "Va a salir sin archivar la póliza"
            respuesta = MsgBox(mensaje, vbYesNo + vbCritical + vbDefaultButton2, "Captura de datos ")

        End If

        If respuesta = vbYesNo Then
            Close()

        End If

        MENÚ.Show()
        Me.Hide()

    End Sub

    Sub verificar(sumaDebe, sumaHaber, Ok_che)
        Dim i As Integer

        'Inician variables en 0
        sumaDebe = 0
        sumaHaber = 0
        Ok_che = 0

        If ultimo.TipoCap = 1 Then
            Ok_che = 1

        End If

        For i = 1 To ultimo.renglon
            If DataGridView1.Rows(i).Cells(4).Value <> "" Then
                sumaDebe = sumaDebe + DataGridView1.Rows(i).Cells(4).Value
            End If
            If DataGridView1.Rows(i).Cells(5).Value <> "" Then
                sumaDebe = sumaDebe + DataGridView1.Rows(i).Cells(5).Value

                If TextBox7.Text <> "" Then
                    If TextBox7.Text = (DataGridView1.Rows(i).Cells(5).Value * -1) Then
                        Ok_che = 1
                    End If
                End If
            End If
        Next i
        ' Establece las sumas dentro de la Grid
        'DataGridView1.Rows(ultimo.renglon + 1, 2).Value = " sumas"
        'DataGridView1.Rows(ultimo.renglon + 1, 4).Value = (sumaDebe, z1)
        'DataGridView1.Rows(ultimo.renglon + 1, 5).Value = (sumaHaber, z1)



    End Sub
    Sub verifica_edicion()

        no_Se_Mofifica = 1
        If DataGridView1.Rows(DataGridView1.Rows.Count).Cells(7).Value <> 0 Then
            no_Se_Mofifica = 1
        Else
            no_Se_Mofifica = 0

        End If

    End Sub
    Private Sub VerificarActualizacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarActualizacionesToolStripMenuItem.Click
        CAP_ArchivosActualizados.Show()

    End Sub

    Private Sub AjustarChequeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjustarChequeToolStripMenuItem.Click
        CAP_AjusteImpresionCheques.Show()

    End Sub


    'Sub recorrerGrid(inicio, fin) 'lin_che
    '    Dim antes As Integer
    '    Dim largoPapel As Integer
    '    Dim anchoPapel As Integer
    '    Dim numCheque As Integer
    '    Dim operacion As Integer
    '    Dim ancho2 As Integer


    'End Sub
    Sub mostrar_Cta()


        If trcta.num > 0 Then
            If DataGridView1.Rows.Count < 1 Then DataGridView1.RowCount = 1

            DataGridView1.Rows(DataGridView1.Rows.Count).Cells(0).Value = trcta.num
            DataGridView1.Rows(DataGridView1.Rows.Count).Cells(1).Value = ""
            DataGridView1.Rows(DataGridView1.Rows.Count).Cells(2).Value = "" + trcta.nombre
            DataGridView1.Rows(DataGridView1.Rows.Count).Cells(6).Value = trcta.donde
            DataGridView1.Rows(DataGridView1.Rows.Count).Cells(7).Value = trcta.incia
            DataGridView1.Rows(DataGridView1.Rows.Count).Cells(8).Value = trcta.termina
            DataGridView1.Rows(DataGridView1.Rows.Count).Cells(9).Value = "B"
            trscta.refer = DataGridView1.Rows.Count


            If trcta.incia > 0 Then
                If ultimo.TipoCap = 1 Then DataGridView1.Rows(DataGridView1.Rows.Count).Cells(10).Value = TextBox4.Text
                DataGridView1.Rows(DataGridView1.Rows.Count + 1).Cells(7).Value = DataGridView1.Rows.Count
                DataGridView1.Rows(DataGridView1.Rows.Count + 1).Cells(9).Value = "C"



            End If


        End If

    End Sub

    Sub mostrarSubcta()

        DataGridView1.Rows(DataGridView1.Rows.Count).Cells(0).Value = ""
        DataGridView1.Rows(DataGridView1.Rows.Count).Cells(1).Value = trscta.num
        DataGridView1.Rows(DataGridView1.Rows.Count).Cells(2).Value = " " + trscta.nombre
        DataGridView1.Rows(DataGridView1.Rows.Count).Cells(4).Value = ""
        DataGridView1.Rows(DataGridView1.Rows.Count).Cells(5).Value = ""
        DataGridView1.Rows(DataGridView1.Rows.Count).Cells(6).Value = trscta.donde
        DataGridView1.Rows(DataGridView1.Rows.Count).Cells(7).Value = trscta.refer
        DataGridView1.Rows(DataGridView1.Rows.Count).Cells(9).Value = "C"

        If ultimo.TipoCap = 1 Then DataGridView1.Rows(DataGridView1.Rows.Count).Cells(10).Value = ultimo.redaccion


    End Sub
    Private Sub ChequeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChequeToolStripMenuItem.Click
        'Dim anterior As Integer
        'Dim actual As Integer

        If ultimo.TipoCap <= 1 Then
            MsgBox("No existe el cheque", vbCritical, "Captura de cheques")
        Else
            verificar(sumaDebe, sumaHaber, Ok_che)
            If Ok_che = 1 Then
                Dim result As DialogResult = OpenFileDialog1.ShowDialog()
                If result = DialogResult.Cancel Then
                    MsgBox("Lo siento ocurrio un error al intentar imprimir" & Err.Description, vbCritical, "Error")

                    Dim printDialog As New PrintDialog()
                    If printDialog.ShowDialog() = DialogResult.OK Then
                        Dim printerSettings As PrinterSettings = printDialog.PrinterSettings
                        printerSettings.DefaultPageSettings.Landscape = True
                        Dim font As New Font("Arial", 10)
                        Dim printDocument As New PrintDocument()
                        'AddHandler printDocument.PrintPage, Sub(sender, e)
                        '                                        e.Graphics.DrawString("Hello, world!", font, Brushes.Black, 0, 0)
                        '                                    End Sub
                        printDocument.PrinterSettings = printerSettings
                        printDocument.Print()
                    End If


                End If

            End If


        End If
    End Sub

    Private Sub SubcuentasCtrlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubcuentasCtrlToolStripMenuItem.Click
        Close()
        'If trcta.incia <= 0 Then
        '    MsgBox("Verifique la cuenta")
        'Else
        '    ultimo.Ubi = 0

        CAP_SubCuentas.Show()


        'End If
        'If ultimo.Ubi > 0 Then mostrarSubcta()

        Clipboard.Clear()



    End Sub

    Private Sub CuentasCtrlMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentasCtrlMToolStripMenuItem.Click
        CAP_CatCuentasMayor.Show()

    End Sub

    Private Sub PólizasCtrlFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PólizasCtrlFToolStripMenuItem.Click
        CAP_PolizasDiario.Show()
    End Sub

    Private Sub AuxiliarDeMayorCtrlAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuxiliarDeMayorCtrlAToolStripMenuItem.Click
        CAP_AuxiliarMayor.Show()

    End Sub

    Private Sub DatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosToolStripMenuItem.Click
        CAP_DatosEmpresa.Show()



    End Sub

    Private Sub OtrosProgramasCtrlOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtrosProgramasCtrlOToolStripMenuItem.Click
        CAP_CapturaPorOtrosMedios.Show()

    End Sub

    Private Sub VersiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VersiónToolStripMenuItem.Click
        CAP_InformacionPrograma.Show()

    End Sub

    Private Sub CAP_Cheques_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        MENÚ.Show()
    End Sub
    Private Sub ChequeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ChequeToolStripMenuItem1.Click
        change = False
        contadorXml = 0
        validateXMLArchives = 0
        validatePdfArchives = 0
        Erase archivos1
        Erase archivos1Pdf
        Erase routes
        Erase routesPdf

        Label4.Visible = False
        Label5.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        GroupBox1.Visible = True
        GroupBox2.Visible = True
        Label13.Visible = False
        Label3.Text = ""
        DataGridView1.Size = New Size(900, 271)

        ultimo.TipoCap = 0
        DataGridView1.ClearSelection()


        TextBox1.Focus()





    End Sub
    Private Sub PólizaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PólizaToolStripMenuItem.Click
        DataGridView1.Size = New Size(1350, 800)

        Label4.Visible = True
        Label5.Visible = True
        TextBox3.Visible = True
        TextBox4.Visible = True
        TextBox5.Visible = True
        Label13.Visible = True
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        Label3.Text = "Poliza No."
        ColReda.Visible = True


    End Sub
    Sub ENTRCTA()
        Dim NoEncontrada As Integer
        Dim Y1 As Integer
        Dim Zi As Integer

        FileClose(2)
        'abrirRandomNominaCaptura()

        NoEncontrada = 0
        For Y1 = 1 To cm : FileGet(2, CATMAY, Y1)

            If Val(CATMAY.B1) = Label6.Text Then
                trcta.incia = Y1
                DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value = Val(CATMAY.B1)

                DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value = Trim(CATMAY.B2)

                DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(6).Value = Y1

                DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(7).Value = Val(CATMAY.B4)

                DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(8).Value = Val(CATMAY.B5)

                DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(9).Value = "B"

                DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(10).Value = ""

                trcta.incia = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(7).Value
                trcta.termina = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(8).Value

                If DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(7).Value = 0 Then
                    DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(7).Value = ""
                    DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(8).Value = ""
                End If
                NoEncontrada = 1

                If IsNumeric(DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(7).Value) Then
                    DataGridView1.Rows(0).Cells(0).Value = DataGridView1.Rows(0).Cells(0).Value + 1 = DataGridView1.Rows(0).Cells(0).Value
                Else
                    DataGridView1.Rows(0).Cells(0).Value = 4
                End If
                Exit For
            End If
        Next Y1

        If NoEncontrada = 0 Then
            MsgBox("La cuenta no existe " + DataGridView1.Rows(0).Cells(0).Value + DataGridView1.Rows(2).Cells(0).Value)
            'DataGridView1.Item.Remove(DataGridView: Zi = z1 - 1)
            'CHECAP.Items.RemoveAt(CHECAP.Row)
            'DataGridView1.Item.Remove

        End If
    End Sub

    Sub analizaBalanceCtas()
        Dim suma As Long, suma1 As Long, suma2 As Long, rr As Integer, ImpMay As Long
        Dim inicio As Long, final As Long, alarma As Integer, alarma1 As Integer, alarma2 As Integer
        Dim UbMay As Integer
        Dim r
        Dim CUENTON
        Dim NOCTA$
        Dim CTA$
        Dim SUBCTA

        For r = 1 To DataGridView1.Rows.Count - 1
            If IsNumeric(DataGridView1.Rows(r).Cells(0).Value) Or IsNumeric(DataGridView1.Rows(r).Cells(1).Value) Then

                If DataGridView1.Rows(r).Cells(9).Value = "B" Then
                    If IsNumeric(DataGridView1.Rows(r).Cells(7).Value) Then
                        inicio = DataGridView1.Rows(r).Cells(7).Value
                    Else
                        inicio = 0
                    End If
                    If IsNumeric(DataGridView1.Rows(r).Cells(7).Value) Then
                        final = DataGridView1.Rows(r).Cells(8).Value
                    End If
                Else
                    final = 0

                End If
                CUENTON = DataGridView1.Rows(r).Cells(0).Value : NOCTA = DataGridView1.Rows(r).Cells(2).Value
                CTA = "C" : rr = r
                If IsNumeric(DataGridView1.Rows(r).Cells(4).Value) Then
                    suma = suma + DataGridView1.Rows(r).Cells(4).Value
                    ImpMay = DataGridView1.Rows(r).Cells(4).Value
                    UbMay = r
                Else
                    suma2 = suma2 + DataGridView1.Rows(r).Cells(5).Value
                    ImpMay = DataGridView1.Rows(r).Cells(5).Value
                End If
                If (inicio = 0) Then


                End If
            End If

        Next r





    End Sub



    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            DataGridView1.Focus()
        End If
    End Sub

    Sub sustraccionDebeHaber()
        Try
            Dim sumaDebe As Integer
            Dim sumaHaber As Integer
            Dim diferenciaHaber As Integer
            sumaDebe = Convert.ToDecimal(DataGridView1.Rows(0).Cells(4).Value)
            sumaHaber = Convert.ToDecimal(DataGridView1.Rows(0).Cells(5).Value)
            diferenciaHaber = sumaDebe + sumaHaber

            If diferenciaHaber >= 0 Then
                TextBox2.Text = (ToString(diferenciaHaber))
                DataGridView1.Focus()

            End If
        Catch
            MsgBox("Realiza un cheque e ingresa los montos correspondientes.")
        End Try

    End Sub
    Public Sub EneroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EneroToolStripMenuItem.Click
        Label2.Text = "de" + RTrim(MesCheque(1)) + " de " + DATOS.a_o
        mespoliza = 1
        Label2.BackColor = Color.Red
        CAP_LocalizarPolizas.Show()

    End Sub

    Public Sub FebreroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FebreroToolStripMenuItem.Click
        Label2.Text = "de" + RTrim(MesCheque(2)) + " de" + DATOS.a_o
        mespoliza = 2
        Label2.BackColor = Color.Red
        CAP_LocalizarPolizas.Show()

    End Sub

    Public Sub MarzoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarzoToolStripMenuItem.Click
        Label2.Text = "de" + RTrim(MesCheque(3)) + " de" + DATOS.a_o
        mespoliza = 3
        Label2.BackColor = Color.Red
        CAP_LocalizarPolizas.Show()
    End Sub

    Public Sub AbrilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrilToolStripMenuItem.Click
        Label2.Text = "de" + RTrim(MesCheque(4)) + " de" + DATOS.a_o
        mespoliza = 4
        Label2.BackColor = Color.Red
        CAP_LocalizarPolizas.Show()
    End Sub

    Public Sub MayoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MayoToolStripMenuItem.Click
        Label2.Text = "de" + RTrim(MesCheque(5)) + " de" + DATOS.a_o
        mespoliza = 5
        Label2.BackColor = Color.Red
        CAP_LocalizarPolizas.Show()
    End Sub

    Public Sub JunioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JunioToolStripMenuItem.Click
        Label2.Text = "de" + RTrim(MesCheque(6)) + " de" + DATOS.a_o
        mespoliza = 6
        Label2.BackColor = Color.Red
        CAP_LocalizarPolizas.Show()
    End Sub

    Public Sub JulioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JulioToolStripMenuItem.Click
        Label2.Text = "de" + RTrim(MesCheque(7)) + " de" + DATOS.a_o
        mespoliza = 7
        Label2.BackColor = Color.Red
        CAP_LocalizarPolizas.Show()
    End Sub

    Public Sub AgostoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgostoToolStripMenuItem.Click
        Label2.Text = "de" + RTrim(MesCheque(8)) + " de" + DATOS.a_o
        mespoliza = 8
        Label2.BackColor = Color.Red
        CAP_LocalizarPolizas.Show()
    End Sub

    Public Sub SeptiembreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeptiembreToolStripMenuItem.Click
        Label2.Text = "de" + RTrim(MesCheque(9)) + " de" + DATOS.a_o
        mespoliza = 9
        Label2.BackColor = Color.Red
        CAP_LocalizarPolizas.Show()
    End Sub

    Public Sub OctubreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OctubreToolStripMenuItem.Click
        Label2.Text = "de" + RTrim(MesCheque(10)) + " de" + DATOS.a_o
        mespoliza = 10
        Label2.BackColor = Color.Red
        'CAP_LocalizarPolizas.Show()
    End Sub

    Public Sub NoviembreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoviembreToolStripMenuItem.Click
        Label2.Text = "de" + RTrim(MesCheque(11)) + " de" + DATOS.a_o
        mespoliza = 11
        Label2.BackColor = Color.Red
        CAP_LocalizarPolizas.Show()
    End Sub

    Public Sub DiciembreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiciembreToolStripMenuItem.Click
        Label2.Text = "de" + RTrim(MesCheque(12)) + " de" + DATOS.a_o
        mespoliza = 12
        Label2.BackColor = Color.Red
        CAP_LocalizarPolizas.Show()
    End Sub

    Public Sub IncorporaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncorporaciónToolStripMenuItem.Click
        Label2.Text = RTrim(MesCheque(13)) + "de saldos " + (DATOS.a_o)
        mespoliza = 13
        Label2.BackColor = Color.Red
        CAP_LocalizarPolizas.Show()

    End Sub
    Public Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            ' Código para manejar la pulsación de la tecla Enter
        End If
    End Sub
    Sub incluirMes()
        Dim mes As String
        Dim sender As Object = Nothing
        Dim e As New KeyPressEventArgs(ChrW(Keys.Enter))

        mes = DateTime.Now.ToString("MM")

        TextBox1.Text = DateTime.Now.Day.ToString()

        If TextBox1.Text = DateTime.Now.Day.ToString() Then
            TextBox1_KeyPress(sender, e)

        End If


        Select Case mes
            Case "01"
                EneroToolStripMenuItem_Click(sender, e)
            Case "02"
                FebreroToolStripMenuItem_Click(sender, e)
            Case "03"
                MarzoToolStripMenuItem_Click(sender, e)
            Case "04"
                AbrilToolStripMenuItem_Click(sender, e)
            Case "05"
                MayoToolStripMenuItem_Click(sender, e)
            Case "06"
                JunioToolStripMenuItem_Click(sender, e)
            Case "07"
                JulioToolStripMenuItem_Click(sender, e)
            Case "08"
                AgostoToolStripMenuItem_Click(sender, e)
            Case "09"
                SeptiembreToolStripMenuItem_Click(sender, e)
            Case "10"
                OctubreToolStripMenuItem_Click(sender, e)
            Case "11"
                NoviembreToolStripMenuItem_Click(sender, e)
            Case "12"
                DiciembreToolStripMenuItem_Click(sender, e)
        End Select

    End Sub

    Public Sub BorrarChequeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarChequeToolStripMenuItem.Click
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        If ultimo.TipoCap = 1 Then TextBox4.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""

    End Sub

    Private Sub SumaDebeYHaberCtrlLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SumaDebeYHaberCtrlLToolStripMenuItem.Click
        sustraccionDebeHaber()

    End Sub

    Private Sub BorrarAplicaciónCtrlBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarAplicaciónCtrlBToolStripMenuItem.Click
        DataGridView1.ClearSelection()

        DataGridView1.RowCount = 100
        DataGridView1.Columns(0).Width = 75 : DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(0).HeaderText = "Cuenta" : DataGridView1.Columns(0).HeaderCell.Style.BackColor = Color.Yellow : DataGridView1.Columns(0).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Columns(1).Width = 75 : DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(1).HeaderText = "Subcta" : DataGridView1.Columns(1).HeaderCell.Style.BackColor = Color.Yellow : DataGridView1.Columns(1).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Columns(2).Width = 400 : DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(2).HeaderText = "Nombre" : DataGridView1.Columns(2).HeaderCell.Style.BackColor = Color.Yellow : DataGridView1.Columns(2).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Columns(3).Width = 100 : DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(3).HeaderText = "Parcial" : DataGridView1.Columns(3).HeaderCell.Style.BackColor = Color.Yellow : DataGridView1.Columns(3).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Columns(4).Width = 100 : DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(4).HeaderText = "Debe " : DataGridView1.Columns(4).HeaderCell.Style.BackColor = Color.Yellow : DataGridView1.Columns(4).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Columns(5).Width = 100 : DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(5).HeaderText = "Haber" : DataGridView1.Columns(5).HeaderCell.Style.BackColor = Color.Yellow : DataGridView1.Columns(5).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Columns(6).Width = 200 : DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(6).HeaderText = "Redacción" : DataGridView1.Columns(6).HeaderCell.Style.BackColor = Color.Yellow : DataGridView1.Columns(6).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Columns(7).Width = 200 : DataGridView1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(7).HeaderText = "Folio Fiscal" : DataGridView1.Columns(7).HeaderCell.Style.BackColor = Color.Yellow : DataGridView1.Columns(7).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)



        If change = True Then
            DataGridView1.Columns(7).Width = 200 : DataGridView1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(7).HeaderText = "Folio Fiscal" : DataGridView1.Columns(7).HeaderCell.Style.BackColor = Color.Yellow : DataGridView1.Columns(7).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
            DataGridView1.Columns(8).Width = 200 : DataGridView1.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(8).HeaderText = "Folio Fiscal" : DataGridView1.Columns(7).HeaderCell.Style.BackColor = Color.Yellow : DataGridView1.Columns(7).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)



            DataGridView1.Rows(0).Cells(0).Value = 1
            DataGridView1.Rows(0).Cells(0).Value = "" : trcta.clave = "" : trcta.donde = "" : trcta.incia = ""
            trcta.nombre = "" : trcta.num = "" : trcta.termina = "" : ultimo.renglon = ""
            Alarma.Cos = "" : TextBox4.Text = "" : TextBox3.Text = "" : TextBox5.Text = ""
            TextBox8.Text = "" : TextBox6.Text = "" : TextBox7.Text = "" : TextBox9.Text = ""
            TextBox10.Text = "" : TextBox11.Text = ""


        End If
    End Sub
    Public Sub DataGridView1_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellLeave



        If DataGridView1.Rows(0).Cells(0).Value > 0 Then
            DataGridView1.DefaultCellStyle.BackColor = Color.White

        End If

    End Sub
    Public Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        'Dim respuesta As String


        ' Dim valcelant As String = DataGridView1.CurrentCell().Tag.ToString()



        If DataGridView1.Rows(0).Cells(0).Value > 0 Then
            DataGridView1.DefaultCellStyle.BackColor = Color.LimeGreen

        End If
    End Sub


    Private Sub AgregarSubctaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarSubctaToolStripMenuItem.Click
        Dim cambiar As String
        Dim r As Integer
        Dim com As String

        If DataGridView1.Rows(DataGridView1.Rows.Count).Cells(9).Value = "C" Then  'problema

            If DataGridView1.Rows(DataGridView1.Rows.Count).Cells(7).Value <> "" Then

                'RaiseEvent.DataGridView1_CellLeave()
                trscta.refer = DataGridView1.Rows(7).Cells(0).Value
                trcta.incia = DataGridView1.Rows(trscta.refer).Cells(7).Value
                trcta.termina = DataGridView1.Rows(trscta.refer).Cells(8).Value
                'DataGridView1.Rows.Add, DataGridView1.Rows : ultimo.renglon + 1
                'RaiseEvent.DataGridView1_CellLeave()
                'RaiseEvent.DataGridView1_CellEnter()
                cambiar = 0

                For r = DataGridView1.Rows.Count + 1 To DataGridView1.Rows.Count - 1
                    If DataGridView1.Rows(r).Cells(9).Value = "B" Then cambiar = 1
                    If DataGridView1.Rows(r).Cells(9).Value = "C" And cambiar = 1 Then
                        com = DataGridView1.Rows(r).Cells(7).Value + 1
                        DataGridView1.Rows(r).Cells(7).Value = com
                    End If
                Next r
                cambiar = 0
                'RaiseEvent.DataGridView1_CellLeave()
                'RaiseEvent.DataGridView1_CellEnter()

            End If
        End If


    End Sub

    Private Sub EliminarSubctaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarSubctaToolStripMenuItem.Click
        Dim cambiar As String
        Dim r As Integer
        Dim comodin As String

        'If (DataGridView1.CurrentRow.Index) = "C" Then

        'End If

        If DataGridView1.Rows(DataGridView1.Rows.Count).Cells(9).Value = "C" Then ''
            impor_te = DataGridView1.Rows(DataGridView1.Rows.Count).Cells(3).Value
            trscta.refer = DataGridView1.Rows(DataGridView1.Rows.Count).Cells(7).Value
            'Index was out of range. Must be non-negative and less than the size of the collection. Arg_ParamName_Name'

            If (DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(9).Value) = "B" And DataGridView1.Rows(DataGridView1.Rows.Count + 1).Cells(9).Value <> "C" Then
                MsgBox("Es necesario borrar la cuenta") : Exit Sub

            End If

            If (DataGridView1.Rows(trscta.refer).Cells(4).Value) <> "" Then
                Sal_do = DataGridView1.Rows(trscta.refer).Cells(4).Value - impor_te
            Else
                Sal_do = DataGridView1.Rows(trscta.refer).Cells(5).Value - impor_te

            End If
            If Sal_do > 0 Then
                Sal_do = DataGridView1.Rows(trscta.refer).Cells(4).Value = Format(Sal_do, z1)
            Else
                Sal_do = DataGridView1.Rows(trscta.refer).Cells(5).Value = Format(Sal_do, z1)
            End If

            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            ultimo.renglon = ultimo.renglon - 1

            'DataGridView1_CellLeave()

            'RaiseEvent.DataGridView1_CellEnter()

            cambiar = 0

            For r = DataGridView1.Rows.Count + 1 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(r).Cells(9).Value = "B" Then cambiar = 1 : comodin = r
                If DataGridView1.Rows(r).Cells(9).Value = "C" And cambiar = 1 Then
                    DataGridView1.Rows(r).Cells(7).Value = comodin

                End If
            Next r
            cambiar = 0


        End If



    End Sub

    Private Sub BorrarCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarCuentaToolStripMenuItem.Click
        Dim cambio As String
        Dim r As Integer
        Dim cambiar As String
        Dim comodin As String
        Dim currentCell As DataGridViewCell = DataGridView1.CurrentCell
        Dim row As Integer = currentCell.RowIndex
        Dim col As Integer = currentCell.ColumnIndex


        cambio = DataGridView1.Rows.Count

        If DataGridView1.Rows(cambio).Cells(9).Value = "B" Then  '
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            ultimo.renglon = ultimo.renglon - 1

            Do Until cambio <> DataGridView1.Rows(DataGridView1.Rows.Count).Cells(7).Value Or DataGridView1.Rows(DataGridView1.Rows.Count).Cells(9).Value <> "C"
                ultimo.renglon = ultimo.renglon - 1
                DataGridView1.Rows.Remove(DataGridView1.CurrentRow)

            Loop

            'If col = 7 AndAlso cambio <> DataGridView1.Item(col, row).Value Then
            '    ' Código para el caso en que cambio no sea igual al valor de la celda en la columna 7
            'End If

            'If col = 9 AndAlso DataGridView1.Item(col, row).Value <> "C" Then
            '    ' Código para el caso en que el valor de la celda en la columna 9 no sea igual a "C"
            '    ultimo.renglon = ultimo.renglon - 1
            '    DataGridView1.Rows.Remove(DataGridView1.CurrentRow)

            'End If

            For r = DataGridView1.Rows.Count To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(r).Cells(9).Value = "B" Then cambiar = 1 : comodin = DataGridView1.Rows.Count
                If DataGridView1.Rows(r).Cells(9).Value = "C" And (cambiar = 1) Then
                    DataGridView1.Rows(r).Cells(7).Value = comodin
                End If
            Next r

            cambiar = 0
            trcta.incia = 0
            If ultimo.renglon < 1 Then ultimo.renglon = 1


        End If

    End Sub

    Private Sub VerificarSumasF6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarSumasF6ToolStripMenuItem.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        PólizasCtrlFToolStripMenuItem_Click(sender, e)


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        CambioSubdirectorioToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        GuardarAplicaciónCtrlGToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        EliminarSubctaToolStripMenuItem_Click(sender, e)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        ChequeToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Dim archivoXml As New XmlDocument()
        Dim nodelist As XmlNodeList
        Dim nodelist2 As XmlNodeList
        Dim nodo As XmlNode
        Dim nodo1 As XmlNode
        Dim rutaArchivos1

        currentdir = Trim(Modulo_EstructurasDeDatos.SCont.guarda)
        currentdir = Mid(currentdir, 1, 2)
        rutaArchivos1 = ""
        TextBox3.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""

        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.FileName = ""
        openFileDialog1.Multiselect = True
        openFileDialog1.ReadOnlyChecked = False
        openFileDialog1.SupportMultiDottedExtensions = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            With openFileDialog1
                .Filter = "Archivos XML|*.xml"
                .Title = "Selecccionar Archivo(s) XML"
                .FileName = ""
            End With
        End If



    End Sub

    Sub DatosAnteriores()

    End Sub
    Sub DatosActuales()

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Dim archivosPDF As Integer
        Dim i As Integer
        currentdir = Trim(Modulo_EstructurasDeDatos.SCont.guarda)
        currentdir = Mid(currentdir, 1, 2)
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.FileName = ""
        openFileDialog1.Multiselect = True
        openFileDialog1.ReadOnlyChecked = False
        openFileDialog1.SupportMultiDottedExtensions = True
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            With openFileDialog1
                .Filter = "Archivos PDF|*.pdf"
                .Title = "Selecccionar Archivo(s) PDF"
                .FileName = ""
            End With
        End If



    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        If trcta.incia <= 0 Then
            MsgBox("Verifique la cuenta.")
        Else
            ultimo.Ubi = 0
            'abrirRandomNominaCaptura()
            CAP_SubCuentas.Show()
        End If
        If ultimo.Ubi > 0 Then 'mostrar_trsct

            Clipboard.Clear()

        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        AgregarSubctaToolStripMenuItem_Click(sender, e)

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        BorrarCuentaToolStripMenuItem_Click(sender, e)

    End Sub
    'Sub mostrarCta()
    '    If trcta.num > 0 Then
    '        If DataGridView1.Rows.Count < 1 Then DataGridView1.RowCount = 1

    'End If

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim verCol As Integer

        verCol = DataGridView1.Rows.Count - 1
        If verCol Then verCol = 1 : ultimo.renglon = qm

        If DataGridView1.Rows(verCol).Cells(0).Value <> "" And trcta.incia > 0 Then
            MsgBox("La anterior es una cuenta")
            DataGridView1.ColumnCount = 1
        Else
            Close()
            ultimo.Ubi = 0
            CAP_CatCuentasMayor.Show()
            If ultimo.Ubi = 1 Then
                'mostrarCta()
            End If
        End If
        Clipboard.Clear()

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        ' CÓDIGO PARA CARMAR XML EN LA COLUMNA DE FOLIOS Y ABRIR VISOR PDF'
        Dim i As Integer
        Dim archivoXml As New MSXML2.DOMDocument60
        Dim nodelist As MSXML2.IXMLDOMNodeList
        Dim nodo As MSXML2.IXMLDOMNode
        Dim nodo1 As MSXML2.IXMLDOMNode
        Dim nodelist2 As MSXML2.IXMLDOMNodeList
        Dim strLinea As String
        Dim rutaPdf : rutaPdf = ""
        Dim rfc, rs, folio, mensaje, rutaXm, rutaPdf1, acortar As Integer
        ReDim Preserve archivos1(contadorXml)
        ReDim Preserve archivos1Pdf(contadorXml)



        If DataGridView1.Columns.Count = 10 And change = False Then
            OpenFileDialog1.FileName = ""
            With OpenFileDialog1
                .Filter = "Archivos XML | *.xml"
                .Title = "Select File"

            End With
        End If
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            OpenFileDialog1.ShowDialog()

        End If

    End Sub


End Class
