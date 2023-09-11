Public Class MENÚ



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim form2 As New CAP_Cheques

        form2.Show()


        Me.Hide()




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub




End Class