﻿Imports System.Diagnostics.Eventing.Reader
Imports System.IO
Imports AplicaciónNomina_versionPreliminar_23_09_01.Modulo_EstructurasDeDatos

Public Class CAP_Cheques
    Dim anuncio As String
    Dim Archivo As String
    Dim Arch_act As String
    Dim midir As String
    Dim MientraS As String
    Dim tope As String
    Dim nombreEmpresa As String
    Dim KeyPress As Integer
    Dim mi_entr As String
    Dim rgtro As Integer



    Dim donde As Integer

    Private Sub EstadosFinancierosCtrlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadosFinancierosCtrlToolStripMenuItem.Click
        CAP_Balance.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
    Sub sigpaso()
        Dim cm As Integer
        If cm < 1 Then
            MsgBox("No Existe Datos de Contabilidad Cambie subdirectorio ")

            FileClose(1)
        Else
            FileGet(1, DATOS, 1)
            Label2.BackColor = Color.Yellow

            mespoliza = 1
            Label2.Text = "de" + RTrim(Mm(mespoliza)) + "de" + DATOS.a_o
            Me.Text = Mid(DATOS.D1, 1, 32) & "  Captura de cheques"
            nombreEmpresa = Trim(DATOS.D2)
            ultimo.texto = RTrim(DATOS.No_arch)
        End If

    End Sub
    Sub inicio()

        Dim checar As String

        Try
            FileOpen(numeroGConta, "C:\GconTA\Gcont.Arr", OpenMode.Random, , , Len(SCont))
            FileGet(numeroGConta, SCont, 1)

            If SCont.guarda.Substring(0, 1) <= " " Then
                ChDrive("C:\")
            Else
                If Not SCont.guarda.StartsWith("C") Then
                    ChDrive(SCont.guarda.Substring(0, 1))
                End If

                ChDir(SCont.guarda.Trim())

            End If


            FileGet(numeroGConta, SCont, 2)
            Dir_Costos = SCont.guarda.Trim()

            FileGet(numeroGConta, SCont, 1)

            FileClose(numeroGConta)
            FileClose(1)

            Archivo = "DATOS"
            FileOpen(1, Archivo, OpenMode.Random,,, Len(DATOS))
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




            ' Cerrar el archivo
            FileClose(numeroGConta)

        Catch
            MsgBox(Err.Description)
        End Try

    End Sub

    Private Sub CambioSubdirectorioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambioSubdirectorioToolStripMenuItem.Click


        FileClose(1)

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


                    FileOpen(numeroGConta, "C:\GconTA\Gcont.Arr", OpenMode.Random,,, Len(SCont))
                    SCont.guarda = MientraS
                    FilePut(numeroGConta, MientraS, 1)
                    FileClose(numeroGConta)

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
    Sub Actualizacion()
        Dim i As Integer
        Close()

        FileOpen(1, "DATOS", OpenMode.Random,,, Len(DATOS))
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


    Private Sub AjustarChequeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjustarChequeToolStripMenuItem.Click
        CAP_AjusteImpresionCheques.Show()

    End Sub

    Private Sub DirectorioDeCostosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DirectorioDeCostosToolStripMenuItem.Click
        Dim mi_ent As String = ultimo.texto
        mi_entr = ultimo.texto
        FileOpen(numeroGConta, "C:\GconTA\Gcont.Arr", OpenMode.Random,,, Len(SCont))
        FileGet(numeroGConta, SCont, 2)
        CAP_Entrada.Text = Trim(SCont.guarda)
        CAP_Entrada.Label1.Text = "Ubicación de directorios"
        CAP_Entrada.Text = "Cg-Contabilidad"
        'CAP_Entrada.Show()

        If ultimo.texto <> "" Then
            If ultimo.texto.EndsWith("\") Then
                ultimo.texto = ultimo.texto & "\"
            End If
            SCont.guarda = ultimo.texto
        End If
        CAP_Entrada.Show()
        ultimo.texto = mi_ent
        If SCont.guarda <> "" Then
            Dir_Costos = Trim(SCont.guarda)
            mi_ent = Dir(Dir_Costos)
            If mi_ent <> "" Then
                FilePut(numeroGConta, SCont.guarda, 2)

                Close()

            Else
                Threading.Thread.Sleep(5000)
                MessageBox.Show("NO EXISTE EL DIRECTORIO", "Error")
                Close()
            End If
        End If

    End Sub

    Private Sub ChequeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChequeToolStripMenuItem.Click

    End Sub

    Private Sub SubcuentasCtrlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubcuentasCtrlToolStripMenuItem.Click
        CAP_SubCuentas.Show()


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

    Private Sub VerificarActualizacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarActualizacionesToolStripMenuItem.Click
        CAP_ArchivosActualizados.Show()

    End Sub

    Private Sub ActualizarSaldosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarSaldosToolStripMenuItem.Click
        If (Mes_Act > 0) And (Mes_Act < 14) Then
            FileGet(1, DATOS, Arch_act)
            rgtro = Val(DATOS.ultimoReg)
            Close()

            'FileOpen(Arch_act, OpenMode.Random,,, Len(OPER))
            Dm = LOF(12) / Len(OPER)
            tope = Val(DATOS.ultimoReg)
            If rgtro <> Dm Then
                MsgBox(RTrim(Arch_act) + " No es posible DesActualizar ", vbCritical, "Actualizacion de Saldos")
                Close()

            End If

        End If
        CAP_Actualizacion.Show()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        MENÚ.Show()
        Me.Hide()

    End Sub
    Private Sub CAP_Cheques_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        MENÚ.Show()
    End Sub
    Private Sub ChequeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ChequeToolStripMenuItem1.Click
        Me.Show()
        Label4.Visible = False
        Label5.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        GroupBox1.Visible = True
        GroupBox2.Visible = True
        Label3.Text = ""
        DataGridView1.Size = New Size(900, 271)
    End Sub
    Private Sub PólizaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PólizaToolStripMenuItem.Click
        DataGridView1.Size = New Size(1350, 800)

        Label4.Visible = True
        Label5.Visible = True
        TextBox3.Visible = True
        TextBox4.Visible = True
        TextBox5.Visible = True
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        Label3.Text = "Poliza No."
        ColReda.Visible = True


    End Sub

    Private Sub CAP_Cheques_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label4.Visible = False
        Label5.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        GroupBox1.Visible = True
        GroupBox2.Visible = True
        Label3.Text = ""
        ColReda.Visible = False
        ColCuenta.Width = 55
        ColSubCta.Width = 55
        ColNom.Width = 250
        ColParcial.Width = 60
        ColDebe.Width = 60
        ColHaber.Width = 60
        ColReda.Width = 200
        ColFolioFis.Width = 310

    End Sub
    Sub incluirMes()

        Dim mes As String

        mes = DateTime.Now.ToString("MM")
        TextBox1.Text = DateTime.Now.Day.ToString()

        If TextBox1.Text = DateTime.Now.Day.ToString() Then
            KeyPress = Keys.Enter

        End If


        'Select Case mes
        '    Case "01"
        '        EneroToolStripMenuItem(1)
        '    Case "02"
        '        FebreroToolStripMenuItem(2)
        '    Case "03"
        '        MarzoToolStripMenuItem(3)
        '    Case "04"
        '        AbrilToolStripMenuItem(4)
        '    Case "05"
        '        MayoToolStripMenuItem(5)
        '    Case "06"
        '        JunioToolStripMenuItem(6)
        '    Case "07"
        '        JulioToolStripMenuItem(7)
        '    Case "08"
        '        AgostoToolStripMenuItem(8)
        '    Case "09"
        '        SeptiembreToolStripMenuItem(9)
        '    Case "10"
        '        OctubreToolStripMenuItem(10)
        '    Case "11"
        '        NoviembreToolStripMenuItem(11)
        '    Case "12"
        '        DiciembreToolStripMenuItem(12)
        'End Select







    End Sub
    Private Sub EneroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EneroToolStripMenuItem.Click
        Label2.Text = "de" + RTrim(Mm(1)) + "de" + DATOS.a_o
        mespoliza = 1
        Label2.BackColor = Color.Red
        CAP_LocalizarPolizas.Show()

    End Sub

    Private Sub FebreroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FebreroToolStripMenuItem.Click
        Label2.Text = "de" + RTrim(Mm(2)) + "de" + DATOS.a_o
        mespoliza = 2
        Label2.BackColor = Color.Red
        CAP_LocalizarPolizas.Show()

    End Sub

    Private Sub MarzoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarzoToolStripMenuItem.Click
        Label2.Text = "de" + RTrim(Mm(3)) + "de" + DATOS.a_o
        mespoliza = 3
        Label2.BackColor = Color.Red
        CAP_LocalizarPolizas.Show()
    End Sub

    Private Sub AbrilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrilToolStripMenuItem.Click
        Label2.Text = "de" + RTrim(Mm(4)) + "de" + DATOS.a_o
        mespoliza = 4
        Label2.BackColor = Color.Red
        CAP_LocalizarPolizas.Show()
    End Sub

    Private Sub MayoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MayoToolStripMenuItem.Click
        Label2.Text = "de" + RTrim(Mm(5)) + "de" + DATOS.a_o
        mespoliza = 5
        Label2.BackColor = Color.Red
        CAP_LocalizarPolizas.Show()
    End Sub

    Private Sub JunioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JunioToolStripMenuItem.Click
        Label2.Text = "de" + RTrim(Mm(6)) + "de" + DATOS.a_o
        mespoliza = 6
        Label2.BackColor = Color.Red
        CAP_LocalizarPolizas.Show()
    End Sub

    Private Sub JulioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JulioToolStripMenuItem.Click
        Label2.Text = "de" + RTrim(Mm(7)) + "de" + DATOS.a_o
        mespoliza = 7
        Label2.BackColor = Color.Red
        CAP_LocalizarPolizas.Show()
    End Sub

    Private Sub AgostoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgostoToolStripMenuItem.Click
        Label2.Text = "de" + RTrim(Mm(8)) + "de" + DATOS.a_o
        mespoliza = 8
        Label2.BackColor = Color.Red
        CAP_LocalizarPolizas.Show()
    End Sub

    Private Sub SeptiembreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeptiembreToolStripMenuItem.Click
        Label2.Text = "de" + RTrim(Mm(9)) + "de" + DATOS.a_o
        mespoliza = 9
        Label2.BackColor = Color.Red
        CAP_LocalizarPolizas.Show()
    End Sub

    Private Sub OctubreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OctubreToolStripMenuItem.Click
        Label2.Text = "de" + RTrim(Mm(10)) + "de" + DATOS.a_o
        mespoliza = 10
        Label2.BackColor = Color.Red
        CAP_LocalizarPolizas.Show()
    End Sub

    Private Sub NoviembreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoviembreToolStripMenuItem.Click
        Label2.Text = "de" + RTrim(Mm(11)) + "de" + DATOS.a_o
        mespoliza = 11
        Label2.BackColor = Color.Red
        CAP_LocalizarPolizas.Show()
    End Sub

    Private Sub DiciembreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiciembreToolStripMenuItem.Click
        Label2.Text = "de" + RTrim(Mm(12)) + "de" + DATOS.a_o
        mespoliza = 12
        Label2.BackColor = Color.Red
        CAP_LocalizarPolizas.Show()
    End Sub

    Private Sub IncorporaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncorporaciónToolStripMenuItem.Click
        Label2.Text = RTrim(Mm(13)) + "de saldos " + (DATOS.a_o)
        mespoliza = 13
        Label2.BackColor = Color.Red
        CAP_LocalizarPolizas.Show()

    End Sub

End Class