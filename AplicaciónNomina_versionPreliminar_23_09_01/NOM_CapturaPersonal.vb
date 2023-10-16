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
        'Dim añoAlta As Integer = Left()
        'Dim mesAlta As Integer = Left(fecha, 4)
        'Dim diaAlta As Integer = Left(fecha, 4)


        Label15.Text = idEmpleado
        TextBox1.Text = personal.RFC.Trim()
        TextBox2.Text = otrosCampos.CURP.Trim()
        TextBox3.Text = personal.nom.Trim()
        TextBox4.Text = personal.ape1.Trim()
        TextBox5.Text = personal.ape2.Trim()
        DateTimePicker1.Value = New DateTime(2022, 5, 3)
        TextBox8.Text = personal.ingr
        TextBox9.Text = personal.viat
        TextBox10.Text = personal.otras
        TextBox11.Text = personal.imss.Trim()
        TextBox14.Text = personal.integrado
    End Sub
End Class