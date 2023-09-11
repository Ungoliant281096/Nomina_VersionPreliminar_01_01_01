Imports System.IO

Public Class NOM_CapturarNominaQuincenal


    Private Sub CFDIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CFDIToolStripMenuItem.Click
        NOM_GeneracionCFDI.Show()
    End Sub

    Private Sub DistribuciónNóminaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DistribuciónNóminaToolStripMenuItem.Click
        NOM_PolizaAplicacion.Show()
    End Sub
    Private Sub AjustesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjustesToolStripMenuItem.Click
        NOM_AjusteMilimetrosImpresionCheques.Show()
    End Sub

    Private Sub IniciarCapturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IniciarCapturaToolStripMenuItem.Click
        'imprimirPersonal(DataGridView1)
        'imprimirAuxiliar(DataGridView1)
        imprimirMayor(DataGridView1)
    End Sub



End Class