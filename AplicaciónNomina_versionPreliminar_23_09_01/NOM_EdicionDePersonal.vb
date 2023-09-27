Imports System.Data.SqlClient
Public Class NOM_EdicionDePersonal

    Private Sub NOM_EdicionDePersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ImprimirCtasBanco(DataGridView1, largoPersonal)

        DataGridView1.Width = Me.Width * 0.9
        DataGridView1.Height = Me.Height * 0.85
    End Sub

    Private Sub PantallaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        imprimirOtrasCh(DataGridView1, largoOtrosCammpos)
    End Sub

    Private Sub NOM_EdicionDePersonal_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        DataGridView1.Width = Me.Width * 0.9
        DataGridView1.Height = Me.Height * 0.85
    End Sub

    Private Sub TotalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalToolStripMenuItem.Click
        ' Iterar a través de las filas en reversa para evitar problemas con el índice al eliminar filas
        For i As Integer = DataGridView1.Rows.Count - 1 To 0 Step -1
            Dim miVariable As String = DataGridView1.Rows(i).Cells(6).Value.ToString()
            ' Si la fila está vacía, eliminarla
            If miVariable = "" Then
                DataGridView1.Rows.RemoveAt(i)
            End If
        Next
    End Sub
End Class
