Imports System.Reflection

Public Class CAP_PolizasDiario


    'FileOpen(3, Ruta_Acceso_Contr & "\Gcont.Arr", OpenMode.Random, OpenAccess.ReadWrite, OpenShare.LockReadWrite, Len(SCont))




    Private Sub VerListasDePólizasCtrlZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerListasDePólizasCtrlZToolStripMenuItem.Click
        CAP_LocalizarPolizas.Show()

    End Sub

    Private Sub CAP_PolizasDiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Visible = False

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

    Private Sub AbrirCtrlRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirCtrlRToolStripMenuItem.Click
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = DialogResult.Cancel Then

            Dim dialog As New OpenFileDialog()
            dialog.InitialDirectory = Trim(Modulo_EstructurasDeDatos.SCont.guarda)
            dialog.Filter = "All Files (*.*)|*.*"
            DATOS.No_arch = Trim(DATOS.No_arch)
            dialog.FileName = "midir" + RTrim(DATOS.No_arch) + "*.*"

        End If

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        AbrirCtrlRToolStripMenuItem_Click(sender, e)

    End Sub

    Private Sub CambioDirectorioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambioDirectorioToolStripMenuItem.Click
        MsgBox("No puedes cambiar el subdirectorio.")

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MsgBox("No existe póliza para imprimir")

    End Sub
End Class