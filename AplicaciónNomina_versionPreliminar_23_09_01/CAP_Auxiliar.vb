Public Class CAP_Auxiliar
    Dim MientraS As Integer
    Private Sub CopiarSelecciónCtrlCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarSelecciónCtrlCToolStripMenuItem.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub CAP_Auxiliar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColFecha.Width = 80
        ColPol.Width = 80
        ColDesc.Width = 120
        ColDebe.Width = 80
        ColHaber.Width = 80
        ColSaldo.Width = 80

    End Sub
End Class