Public Class CAP_ArchivosActualizados
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub CAP_ArchivosActualizados_Load(sender As Object, e As EventArgs) Handles Me.Load
        ColMes.Width = 50
        ColRegistros.Width = 70
        ColPoliza.Width = 80
        ColEstado.Width = 80

    End Sub
End Class