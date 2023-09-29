Public Class CAP_Actualizacion
    Dim num_ro As Long, finaux As Long, s_do As Long
    Dim fec_ha, p_ol As Long, rgtro As Long, r As Long, mensaje
    Private Sub CAP_Actualizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.InitializeComponent()


    End Sub
    Private Sub Button1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Button1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()



        End If

    End Sub
End Class