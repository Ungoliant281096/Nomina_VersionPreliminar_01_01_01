Imports System.Data.SqlClient
Imports System.Data.Odbc
Imports System.Drawing.Text

Public Class Form1
    Private Sub CapturaPersonalToolStripMenuItem_Click(sender As Object, e As EventArgs)
        NOM_CapturaPersonal.Show()
    End Sub

    Private Sub EdiciónToolStripMenuItem_Click(sender As Object, e As EventArgs)
        NOM_EdicionDePersonal.Show()
    End Sub

    Private Sub CapturaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        NOM_CapturarNominaQuincenal.Show()
    End Sub

    Private Sub CFDIComplementoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        NOM_DatosCompPersonal.Show()
    End Sub

    Private Sub ImpresiónToolStripMenuItem_Click(sender As Object, e As EventArgs)
        NOM_AjusteMilimetrosImpresionCheques.Show()
    End Sub

    Private Sub ImpresiónToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Opción no habilitada")
        mostrarDatosEmpresa()
    End Sub

    Private Sub DatosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        NOM_DatosEmpresa.Show()
    End Sub

    Private Sub ComplementariosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        NOM_DatosComplementarios.Show()
    End Sub
    Private Sub DirectorioDeTarifasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        NOM_Tarifas.Show()
    End Sub
    Private Sub SubdirectorioToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Aun no se puede crear un subdirectorio")
    End Sub

    Private Sub Articulo113ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        NOM_TablaArticulo.Show()
    End Sub

    Private Sub Arítuclo114ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        NOM_TablaArticulo.Show()
    End Sub

    Private Sub CréditoSalarioToolStripMenuItem_Click(sender As Object, e As EventArgs)
        NOM_CreditoSalario.Show()
    End Sub

    Private Sub ISRAnual177ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        NOM_TablaArticulo.Show()
    End Sub

    Private Sub SubsudioAnual178ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        NOM_TablaSubsidio.Show()
    End Sub

    Private Sub CreditoSalarioToolStripMenuItem_Click(sender As Object, e As EventArgs)
        NOM_CreditoSalario.Show()
    End Sub

    Private Sub VersiónToolStripMenuItem_Click(sender As Object, e As EventArgs)
        NOM_InformacionPrograma.Show()
    End Sub

    Private Sub mostrarDatosEmpresa()
        Label1.Text = "Empresa: "
        Label4.Text = "Año: " + "Subsidio: " + "Salario minimio x dia: $"
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        MENÚ.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Hide()
        MENÚ.Show()
    End Sub
End Class