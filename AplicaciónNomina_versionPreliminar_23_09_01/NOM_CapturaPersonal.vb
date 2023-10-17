Public Class NOM_CapturaPersonal
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
    End Sub

    Public Sub obtenerPersonal(idEmpleado As Integer)
        FileGet(numeroPersonal, personal, idEmpleado)
        FileGet(numeroOtros, otrosCampos, idEmpleado)

        Dim fecha As String = personal.fal

        ' Dividir la fecha en año, mes y día
        Dim partes() As String = fecha.Split("/"c)
        Dim diaAlta As String = partes(0)
        Dim mesAlta As String = partes(1)
        Dim añoAlta As String = partes(2)

        ' Validar que los valores son números y están dentro de rangos válidos
        If IsNumeric(añoAlta) AndAlso IsNumeric(mesAlta) AndAlso IsNumeric(diaAlta) Then
            Dim añoNum As Integer = Convert.ToInt32(añoAlta)
            Dim mesNum As Integer = Convert.ToInt32(mesAlta)
            Dim diaNum As Integer = Convert.ToInt32(diaAlta)

            If añoNum >= 1 AndAlso añoNum <= 9999 AndAlso mesNum >= 1 AndAlso mesNum <= 12 AndAlso diaNum >= 1 AndAlso diaNum <= DateTime.DaysInMonth(añoNum, mesNum) Then
                ' Asignar la fecha al DateTimePicker
                DateTimePicker1.Value = New DateTime(añoNum, mesNum, diaNum)
            End If
        End If

        Label15.Text = idEmpleado
        TextBox1.Text = personal.RFC.Trim()
        TextBox2.Text = otrosCampos.CURP.Trim()
        TextBox3.Text = personal.nom.Trim()
        TextBox4.Text = personal.ape1.Trim()
        TextBox5.Text = personal.ape2.Trim()
        TextBox8.Text = personal.ingr / 10000
        TextBox9.Text = personal.viat / 10000
        TextBox10.Text = personal.otras / 10000
        TextBox11.Text = personal.imss.Trim()
        TextBox14.Text = personal.integrado / 10000
    End Sub
End Class