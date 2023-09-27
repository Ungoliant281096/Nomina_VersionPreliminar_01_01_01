Public Class CAP_CapturaPorOtrosMedios
    Private Sub CopiarTodoCtrlSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarTodoCtrlSToolStripMenuItem.Click

    End Sub

    Private Sub CuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentasToolStripMenuItem.Click
        CAP_CatCuentasMayor.Show()


    End Sub

    Private Sub SubCuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubCuentasToolStripMenuItem.Click
        CAP_SubCuentas.Show()

    End Sub


    Private Sub CAP_CapturaPorOtrosMedios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColCta.Width = 70
        ColSubCta.Width = 70
        ColNom.Width = 200
        ColParcial.Width = 80
        ColDebe.Width = 80
        ColHaber.Width = 80
        ColReda.Width = 160
        ColFolioFis.Width = 200
    End Sub
End Class