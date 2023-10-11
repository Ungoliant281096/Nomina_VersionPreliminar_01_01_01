Public Class CAP_ArchivosPdf

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Dir(Trim(Modulo_EstructurasDeDatos.SCont.guarda) + "Archivos PDF", vbDirectory) = "" Then
            MkDir(Trim(Modulo_EstructurasDeDatos.SCont.guarda) + "Archivos PDF")
        End If

        month = Format(Trim(Val(Arch_act.Trim().Substring(Arch_act.Trim().Length - 2))), "00")
        Dim rutaCompleta As Integer = Trim(CStr(Modulo_EstructurasDeDatos.SCont.guarda))

        Erase routesPdf
        Erase archivos1Pdf

        Dim valor As Integer
        Dim flag As Long

        rutArchi = rutaCompleta + "Archivos PDF\" + CStr(Trim(DATOS.a_o)) + "" + month + "" + polizaiden + "" + nombreArchivo + CStr(0) + ".pdf"

        OpenFileDialog1 = New OpenFileDialog
        OpenFileDialog1.Multiselect = True : OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.ReadOnlyChecked = True : OpenFileDialog1.Title = "Abrir archivo(s)"

        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            'aqui vamos a acceder a los archivos selecciondos

            'String[] selectedFiles = openFileDialog.FileNames
            '    foreach(String file In selectedFiles)


        End If





    End Sub
End Class