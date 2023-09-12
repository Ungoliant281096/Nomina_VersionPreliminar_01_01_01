Imports System.Data.SqlClient
Imports System.Data.Odbc
Imports System.Drawing.Text

Public Class Form1
    Private Sub CapturaPersonalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapturaPersonalToolStripMenuItem.Click
        NOM_CapturaPersonal.Show()
    End Sub

    Private Sub EdiciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EdiciónToolStripMenuItem.Click
        NOM_EdicionDePersonal.Show()
    End Sub

    Private Sub CapturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapturaToolStripMenuItem.Click
        NOM_CapturarNominaQuincenal.Show()
    End Sub

    Private Sub CFDIComplementoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CFDIComplementoToolStripMenuItem.Click
        NOM_CapturaEmitirCFDI.Show()
    End Sub

    Private Sub ImpresiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImpresiónToolStripMenuItem.Click
        NOM_AjusteMilimetrosImpresionCheques.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        MENÚ.Show()
        Me.Hide()
    End Sub

    Private Sub ImpresiónToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ImpresiónToolStripMenuItem1.Click
        MessageBox.Show("Opción no habilitada")
        mostrarDatosEmpresa()
    End Sub

    Private Sub DatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosToolStripMenuItem.Click
        NOM_DatosEmpresa.Show()
    End Sub

    Private Sub ComplementariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComplementariosToolStripMenuItem.Click
        NOM_DatosComplementarios.Show()
    End Sub
    Private Sub DirectorioDeTarifasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DirectorioDeTarifasToolStripMenuItem.Click
        NOM_Tarifas.Show()
    End Sub
    Private Sub SubdirectorioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubdirectorioToolStripMenuItem.Click
        MessageBox.Show("Aun no se puede crear un subdirectorio")
    End Sub

    Private Sub Articulo113ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Articulo113ToolStripMenuItem.Click
        NOM_TablaArticulo.Show()
    End Sub

    Private Sub Arítuclo114ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Arítuclo114ToolStripMenuItem.Click
        NOM_TablaArticulo.Show()
    End Sub

    Private Sub CréditoSalarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CréditoSalarioToolStripMenuItem.Click
        NOM_CreditoSalario.Show()
    End Sub

    Private Sub ISRAnual177ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ISRAnual177ToolStripMenuItem.Click
        NOM_TablaArticulo.Show()
    End Sub

    Private Sub SubsudioAnual178ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubsudioAnual178ToolStripMenuItem.Click
        NOM_TablaSubsidio.Show()
    End Sub

    Private Sub CreditoSalarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreditoSalarioToolStripMenuItem.Click
        NOM_CreditoSalario.Show()
    End Sub

    Private Sub VersiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VersiónToolStripMenuItem.Click
        NOM_InformacionPrograma.Show()
    End Sub

    Private Sub mostrarDatosEmpresa()
        Label1.Text = "Empresa: "
        Label4.Text = "Año: " + "Subsidio: " + "Salario minimio x dia: $"
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MENÚ.Show()
    End Sub
End Class