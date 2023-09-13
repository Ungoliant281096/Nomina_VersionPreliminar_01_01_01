Imports System.Data.SqlClient
Public Class NOM_EdicionDePersonal

    Private Sub NOM_EdicionDePersonal_Load(sender As Object, e As EventArgs) Handles Me.Load

        ImprimirCtasBanco(DataGridView1)

        DataGridView1.Width = Me.Width * 0.99
        DataGridView1.Height = Me.Height * 0.85
    End Sub

    Private Sub PantallaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PantallaToolStripMenuItem.Click
        imprimirOtrasCh(DataGridView1)
    End Sub

    Private Sub NOM_EdicionDePersonal_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        DataGridView1.Width = Me.Width * 0.99
        DataGridView1.Height = Me.Height * 0.85
    End Sub
End Class
