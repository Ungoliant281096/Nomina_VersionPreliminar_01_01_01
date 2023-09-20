Imports System.Diagnostics.Eventing.Reader
Imports AplicaciónNomina_versionPreliminar_23_09_01.Modulo_EstructurasDeDatos

Public Class CAP_Cheques
    Dim midir As String
    Dim MientraS As String
    Dim tope As String
    Dim Archivo As String
    Dim nombreEmpresa As String
    Dim KeyPress As Integer
    Dim mi_entr As String

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
            Label3.Text = "de" + RTrim(Mm(mespoliza)) + "de" + DATOS.a_o
            Me.Text = Mid(DATOS.D1, 1, 32) & "  Captura de cheques"
            nombreEmpresa = Trim(DATOS.D2)
            ultimo.texto = RTrim(DATOS.No_arch)
        End If

    End Sub
    Sub inicio()
        Dim checar As Integer
        FileOpen(3, Ruta_Acceso_Contr & "Gcont_Arr", OpenMode.Random, , , Len(SCont))
        FileGet(3, SCont, 1)
        If SCont.guarda.Substring(0, 1) <= " " Then
            ChDrive("C:\")
        Else
            If Not SCont.guarda.StartsWith("C") Then
                ChDrive(SCont.guarda.Substring(0, 1))
            End If

            ChDir(SCont.guarda.Trim())

        End If

        FileGet(3, SCont, 2)
        Dir_Costos = SCont.guarda.Trim()

        FileGet(3, SCont, 1)

        FileClose(3)
        FileClose(1)

        Archivo = "DATOS"
        FileOpen(1, Archivo, OpenMode.Random,,, Len(DATOS))
        cm = LOF(1) / Len(DATOS)
        FileGet(1, DATOS, 1)
        checar = Trim(DATOS.No_arch)


        ' Bloquea la grid si se esta usando costos



        ' Cerrar el archivo
        FileClose(3)

    End Sub

    Private Sub CambioSubdirectorioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambioSubdirectorioToolStripMenuItem.Click


        FileClose(1)

        MientraS = ""
        Ruta_Acceso_Contr = ""

        Try

            midir = System.IO.Directory.GetCurrentDirectory()
            midir = midir.TrimEnd()
            Dim dir1 As New System.IO.DirectoryInfo(System.IO.Directory.GetCurrentDirectory())
            If midir.EndsWith("\") Then
                midir = midir.Substring(0, midir.Length - 1)
            End If
            'OpenFileDialog1.InitialDirectory = "midir"

            'OpenFileDialog1.CheckFileExists = True
            'OpenFileDialog1.ShowReadOnly = False 

            Dim openFileDialog1 As New OpenFileDialog With {
            .InitialDirectory = "midir",
            .CheckFileExists = True,
            .ShowReadOnly = False,
            .Filter = "Archivos de Nomina(Dat*.*)|Dat*.*",
            .Title = "Seleccionar archivo"
        }
            If openFileDialog1.ShowDialog() = DialogResult.OK Then
                Show()
                ' Realiza alguna acción con el archivo seleccionado.


            ElseIf openFileDialog1.FileName <> "" Then
                Dim tope As Integer = openFileDialog1.FileName.LastIndexOf("\")
                MientraS = openFileDialog1.FileName


                openFileDialog1.FileName.Substring(0, tope)


                ChDir("MientraS")

                FileOpen(3, Ruta_Acceso_Contr & "\Gcont.Arr", OpenMode.Random, OpenAccess.ReadWrite, OpenShare.LockRead, Len(SCont))
                SCont.guarda = MientraS
                FilePut(3, SCont, 1)
                FileClose(3)

                cm = 0
                inicio()
                sigpaso()
                'MeEne_Click 1
            End If
        Catch ex As Exception
            MsgBox("Error", "Captura")
        End Try
    End Sub



    Private Sub AjustarChequeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjustarChequeToolStripMenuItem.Click
        CAP_AjusteImpresionCheques.Show()

    End Sub

    Private Sub DirectorioDeCostosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DirectorioDeCostosToolStripMenuItem.Click
        Dim mi_ent As String
        mi_entr = ultimo.texto
        FileOpen(3, Ruta_Acceso_Contr & "\Gcont.Arr", OpenMode.Random, OpenAccess.ReadWrite, OpenShare.LockRead, Len(SCont))
        FileGet(3, SCont, 2)



        CAP_Entrada.Show()

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

        'If mes = "01" Then
        '    EneroToolStripMenuItem(1)
        'ElseIf mes = "02" Then
        '    FebreroToolStripMenuItem(2)

        'ElseIf mes = "03" Then
        '    MarzoToolStripMenuItem(3)

        'ElseIf mes = "04" Then
        '    AbrilToolStripMenuItem(4)

        'ElseIf mes = "05" Then
        '    MayoToolStripMenuItem(5)

        'ElseIf mes = "06" Then
        '    JunioToolStripMenuItem(6)

        'ElseIf mes = "07" Then
        '    JulioToolStripMenuItem(7)

        'ElseIf mes = "08" Then
        '    AgostoToolStripMenuItem(8)

        'ElseIf mes = "07" Then
        '    SeptiembreToolStripMenuItem(9)

        'ElseIf mes = "08" Then
        '    OctubreToolStripMenuItem(10)

        'ElseIf mes = "07" Then
        '    NoviembreToolStripMenuItem(11)

        'ElseIf mes = "08" Then
        '    DiciembreToolStripMenuItem(12)

        'End If


        Select Case mes
            Case "01"
                EneroToolStripMenuItem(1)
            Case "02"
                FebreroToolStripMenuItem(2)
            Case "03"
                MarzoToolStripMenuItem(3)
            Case "04"
                AbrilToolStripMenuItem(4)
            Case "05"
                MayoToolStripMenuItem(5)
            Case "06"
                JunioToolStripMenuItem(6)
            Case "07"
                JulioToolStripMenuItem(7)
            Case "08"
                AgostoToolStripMenuItem(8)
            Case "09"
                SeptiembreToolStripMenuItem(9)
            Case "10"
                OctubreToolStripMenuItem(10)
            Case "11"
                NoviembreToolStripMenuItem(11)
            Case "12"
                DiciembreToolStripMenuItem(12)
        End Select







    End Sub
    Private Sub EneroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EneroToolStripMenuItem.Click
        Dim m_m As Integer = 1

        Label2.Text = "de" + RTrim(Mm(1)) + "de" + DATOS.a_o
        m_m = MenuStrip1.GetItemAt(,)
        Label2.BackColor = Color.Red
        CAP_LocalizarPolizas.Show()

    End Sub
End Class