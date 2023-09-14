Public Class CAP_SubCuentas


    Private Sub CAP_SubCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imprimirAuxiliar(DataGridView1, largoCatalogoAuxiliar)
        DataGridView1.Width = Me.Width * 0.9
        DataGridView1.Height = Me.Height * 0.85

    End Sub

    Private Sub CAP_SubCuentas_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        DataGridView1.Width = Me.Width * 0.9
        DataGridView1.Height = Me.Height * 0.85
    End Sub
End Class