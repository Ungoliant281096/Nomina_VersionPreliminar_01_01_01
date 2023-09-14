Public Class CAP_CatCuentasMayor


    Private Sub CAP_CatCuentasMayor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imprimirCtasMayor(DataGridView1)
        DataGridView1.Width = Me.Width * 0.9
        DataGridView1.Height = Me.Height * 0.85
    End Sub

    Private Sub CAP_CatCuentasMayor_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        DataGridView1.Width = Me.Width * 0.9
        DataGridView1.Height = Me.Height * 0.85
    End Sub
End Class