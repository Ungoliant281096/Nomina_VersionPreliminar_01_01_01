Public Class NOM_DatosEmpresa
    Private Sub NOM_DatosEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FileGet(numeroEmprsa, datosEmpresa, largoEmpresa)

        TextBox1.Text = datosEmpresa.name
        TextBox2.Text = datosEmpresa.añoEmpresa
        TextBox3.Text = datosEmpresa.sm
        TextBox4.Text = datosEmpresa.fecha
        TextBox5.Text = datosEmpresa.psub
    End Sub
End Class