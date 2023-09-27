Imports System.IO

Public Class NOM_CapturarNominaQuincenal
    Private Sub CFDIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CFDIToolStripMenuItem.Click
        NOM_GeneracionCFDI.Show()
    End Sub

    Private Sub DistribuciónNóminaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DistribuciónNóminaToolStripMenuItem.Click
        NOM_PolizaAplicacion.Show()
    End Sub
    Private Sub AjustesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjustesToolStripMenuItem.Click
        NOM_AjusteMilimetrosImpresionCheques.Show()
    End Sub

    Private Sub NOM_CapturarNominaQuincenal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Width = Me.Width * 0.95
        DataGridView1.Height = Me.Height * 0.65
    End Sub

    Private Sub NOM_CapturarNominaQuincenal_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        DataGridView1.Width = Me.Width * 0.95
        DataGridView1.Height = Me.Height * 0.65
    End Sub
    Private Sub IniciarCapturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IniciarCapturaToolStripMenuItem.Click
        Dim archivo As String
        Dim mesComboBox As Integer
        Dim añoBajaEmpleado As Integer
        Dim mesBajaEmpleado As Integer
        Dim diaBajaEmpleado As Integer
        Dim archivoPrimeraQuincena As String
        Dim archivoSegundaQuincena As String
        Dim fechaDeQuincena As String
        Dim diasDePago As Integer

        ' pregunta si se trata de una nomina normal o una especial
        If optionNominaNormal.Checked = True Then
            If optionPrimeraQuincena.Checked = True Then
                ' debe crear dos archivos que almacenan las nominas primera
                archivoPrimeraQuincena = UCase(Mid(ComboBox1.Text, 1, 3) + "1" + LTrim(Str(datosEmpresa.añoEmpresa))) + ".NOM"
                archivoPrimeraQuincena = UCase(Mid(ComboBox1.Text, 1, 3) + "1" + LTrim(Str(datosEmpresa.añoEmpresa))) + ".cmp"
                diasDePago = 14
            Else
                ' y segunda quincena del mes
                archivoSegundaQuincena = UCase(Mid(ComboBox1.Text, 1, 3) + "2" + LTrim(Str(datosEmpresa.añoEmpresa))) + ".NOM"
                archivoSegundaQuincena = UCase(Mid(ComboBox1.Text, 1, 3) + "2" + LTrim(Str(datosEmpresa.añoEmpresa))) + ".cmp"
            End If
            ' en caso de que sea una nomina normal
        Else
            ' crea un archivo nomina especial a partir del nombre almacenado en el textbox1
            archivo = Trim(TextBox1.Text) + ".NOM"
            archivo = Trim(TextBox1.Text) + ".cmp"
        End If

        mesComboBox = ComboBox1.SelectedIndex
        If mesComboBox = -1 Then
            mesComboBox = 0
        End If

        If mesComboBox < 10 Then
            fechaDeQuincena = LTrim(Str(diasDePago)) + "/0" + LTrim(Str(mesComboBox)) + "/" + LTrim(Str(datosEmpresa.añoEmpresa))
        End If
        If mesComboBox > 9 Then
            fechaDeQuincena = LTrim(Str(diasDePago)) + "/" + LTrim(Str(mesComboBox)) + "/" + LTrim(Str(datosEmpresa.añoEmpresa))
        End If

        ' Aqui debe llamar la funcion checarFecha
        ' cehcarFecha()

        'FileOpen(numeroNominaQuincenal, rutaDelEjecutable + archivoPrimeraQuincena, OpenMode.Random,,, Len(archivoNominaQuincenal))
        'largoNominaQuincenal = LOF(numeroNominaQuincenal) \ Len(archivoNominaQuincenal)

        'FileOpen(numeroNominaQuincenal, rutaDelEjecutable + archivoSegundaQuincena, OpenMode.Random,,, Len(archivoNominaQuincenal))
        'largoNominaQuincenal = LOF(numeroNominaQuincenal) \ Len(archivoNominaQuincenal)

        'FileOpen(numeronominaCompleta, rutaDelEjecutable + archivo, OpenMode.Random,,, Len(nominaCompleta))
        'largoNominaCompleta = LOF(numeronominaCompleta) \ Len(nominaCompleta)

        For i As Integer = 1 To largoPersonal
            'FileGet(numeroNomina, archivoNomina, i)
            FileGet(numeroPersonal, personal, i)
            FileGet(numeroBancos, cuentasDeBanco, i)
            FileGet(numeroMaestro, maestro, i)

            'If optionPrimeraQuincena.Checked = True Then
            '    If (añoBajaEmpleado > 0) And (añoBajaEmpleado < (datosEmpresa.añoEmpresa - 1)) Then
            '        ' llamada a funcion
            '    End If
            'Else
            '    If (añoBajaEmpleado > 0) And (añoBajaEmpleado < (datosEmpresa.añoEmpresa)) Then
            '        ' llamda a funcion
            '    End If
            'End If

            'If optionPrimeraQuincena.Checked = True Then
            'If (mesBajaEmpleado > 0 And (mesBajaEmpleado <= mesComboBox) And (añoBajaEmpleado = (datosEmpresa.añoEmpresa))) Then
            ' Llamada a funcion
            'Dim renglon As Integer
            ' renglon = renglon + 1
            'DataGridView1.RowCount = renglon
            ' DataGridView1.ColumnCount = 0

            DataGridView1.Rows.Add(personal.nom + personal.ape1)
            ' Llamada a funcion carganom
            '    End If
            'Else
            'If (mesBajaEmpleado > 0 And (mesBajaEmpleado <= mesComboBox) And (añoBajaEmpleado = (datosEmpresa.añoEmpresa))) Then
            ' Llamada a funcion
            ' End If
            ' End If
        Next i
    End Sub
End Class