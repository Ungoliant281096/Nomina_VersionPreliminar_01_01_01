Imports System.Data.SqlClient
Public Class NOM_EdicionDePersonal
    Private Sub SalidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidaToolStripMenuItem.Click
        ImprimirCtasBanco(DataGridView1)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
