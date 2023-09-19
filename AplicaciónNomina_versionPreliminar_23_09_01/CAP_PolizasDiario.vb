Public Class CAP_PolizasDiario


    'FileOpen(3, Ruta_Acceso_Contr & "\Gcont.Arr", OpenMode.Random, OpenAccess.ReadWrite, OpenShare.LockReadWrite, Len(SCont))




    Private Sub VerListasDePólizasCtrlZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerListasDePólizasCtrlZToolStripMenuItem.Click
        CAP_LocalizarPolizas.Show()

    End Sub

    Private Sub CAP_PolizasDiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class