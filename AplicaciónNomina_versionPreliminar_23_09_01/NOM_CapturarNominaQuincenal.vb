Public Class NOM_CapturarNominaQuincenal
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub CFDIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CFDIToolStripMenuItem.Click
        NOM_GeneracionCFDI.Show()
    End Sub

    Private Sub DistribuciónNóminaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DistribuciónNóminaToolStripMenuItem.Click
        NOM_PolizaAplicacion.Show()
    End Sub
    Private Sub AjustesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjustesToolStripMenuItem.Click
        NOM_AjusteMilimetrosImpresionCheques.Show()
    End Sub
End Class