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
        'Dim archivo As String
        'Dim mesComboBox As Integer
        'Dim añoBajaEmpleado As Integer
        'Dim mesBajaEmpleado As Integer
        'Dim diaBajaEmpleado As Integer
        'Dim datosEmpresa As Integer
        '' pregunta si se trata de una nomina normal o una especial
        'If RadioButton1.Checked = True Then
        '    If RadioButton2.Checked = True Then
        '        ' debe crear dos archivos que almacenan las nominas primera
        '    Else
        '        ' y segunda quincena del mes
        '    End If
        '    ' en caso de que sea una nomina normal
        'Else
        '    ' crea un archivo nomina especial a partir del nombre almacenado en el textbox1
        '    archivo = Trim(TextBox1.Text) + ".NOM"
        '    archivo = Trim(TextBox1.Text) + ".cmp"
        'End If

        'mesComboBox = ComboBox1.SelectedIndex

        '' Si el comboBox no tiene seleccionado ningun mes selecciona enero por defecto
        'If mesComboBox = -1 Then
        '    MessageBox.Show("Debes elegir un mes para calcular la nomina")
        'End If

        'If mesComboBox < 10 Then
        '    ' asigna el nombre de la quincena
        '    ' dias paagados/mesElegido/añoEmpresa
        'End If

        'If mesComboBox > 9 Then
        '    ' asigna el nombre de la quincena
        '    ' dias paagados/mesElegido/añoEmpresa
        'End If

        'For i As Integer = 1 To largoPersonal
        '    FileGet(numeroNomina, archivoNomina, i)
        '    FileGet(numeroPersonal, personal, i)
        '    FileGet(numeroBancos, cuentasDeBanco, i)
        '    FileGet(numeroMaestro, maestro, i)

        '    If RadioButton3.Checked = True Then
        '        If (añoBajaEmpleado > 0) And (añoBajaEmpleado < (datosEmpresa.añoEmpresa - 1)) Then
        '            ' llamada a funcion
        '        End If
        '    Else
        '        If (añoBajaEmpleado > 0) And (añoBajaEmpleado < (datosEmpresa.añoEmpresa)) Then
        '            ' llamda a funcion

        '        End If
        '    End If

        '    If RadioButton3.Checked = True Then
        '        If (mesBajaEmpleado > 0 And (mesBajaEmpleado <= mesComboBox) And (añoBajaEmpleado = (datosEmpresa.añoEmpresa))) Then
        '            ' Llamada a funcion
        '            Dim renglon As Integer
        '            renglon = renglon + 1
        '            DataGridView1.RowCount = renglon
        '            DataGridView1.ColumnCount = 0
        '            DataGridView1.Rows.Add(i)
        '            ' Llamada a funcion carganom
        '        End If
        '    Else
        '        If (mesBajaEmpleado > 0 And (mesBajaEmpleado <= mesComboBox) And (añoBajaEmpleado = (datosEmpresa.añoEmpresa))) Then
        '            ' Llamada a funcion
        '        End If

        '    End If


        'Next i
    End Sub
End Class