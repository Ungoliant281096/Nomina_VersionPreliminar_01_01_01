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

    End Sub

    Private Sub NOM_CapturarNominaQuincenal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Width = Me.Width * 0.95
        DataGridView1.Height = Me.Height * 0.65
    End Sub

    Private Sub NOM_CapturarNominaQuincenal_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        DataGridView1.Width = Me.Width * 0.95
        DataGridView1.Height = Me.Height * 0.65
    End Sub
End Class