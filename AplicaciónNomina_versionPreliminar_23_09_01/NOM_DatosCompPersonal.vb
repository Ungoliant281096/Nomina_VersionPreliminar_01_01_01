Public Class NOM_DatosCompPersonal

    Private Sub NOM_DatosCompPersonal_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        DataGridView1.Width = Me.Width * 0.95
        DataGridView1.Height = Me.Height * 0.75
    End Sub

    Private Sub NOM_DatosCompPersonal_Load(sender As Object, e As EventArgs) Handles Me.Load
        DataGridView1.Width = Me.Width * 0.95
        DataGridView1.Height = Me.Height * 0.75
    End Sub
End Class