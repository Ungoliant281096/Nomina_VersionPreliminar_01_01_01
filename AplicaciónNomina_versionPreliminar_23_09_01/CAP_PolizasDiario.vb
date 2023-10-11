Public Class CAP_PolizasDiario


    'FileOpen(3, Ruta_Acceso_Contr & "\Gcont.Arr", OpenMode.Random, OpenAccess.ReadWrite, OpenShare.LockReadWrite, Len(SCont))




    Private Sub VerListasDePólizasCtrlZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerListasDePólizasCtrlZToolStripMenuItem.Click
        CAP_LocalizarPolizas.Show()

    End Sub

    Private Sub CAP_PolizasDiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColCta.Width = 80
        ColSubCta.Width = 80
        ColNom.Width = 150
        ColParcial.Width = 70
        ColDebe.Width = 70
        ColHaber.Width = 70
        ColRedac.Width = 200
        ColFolioFis.Width = 180
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Hide()

    End Sub
End Class