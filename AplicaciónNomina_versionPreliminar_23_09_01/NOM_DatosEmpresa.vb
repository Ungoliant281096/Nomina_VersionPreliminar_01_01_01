Public Class NOM_DatosEmpresa
    Private Sub NOM_DatosEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FileGet(numeroEmprsa, datosEmpresa, largoEmpresa)

        TextBox1.Text = datosEmpresa.name.Trim()
        TextBox2.Text = datosEmpresa.añoEmpresa
        TextBox3.Text = datosEmpresa.sm
        TextBox4.Text = datosEmpresa.fecha.Trim()
        TextBox5.Text = datosEmpresa.psub

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text = datosEmpresa.name.Trim()
        TextBox2.Text = datosEmpresa.añoEmpresa
        TextBox3.Text = datosEmpresa.sm
        TextBox4.Text = datosEmpresa.fecha.Trim()
        TextBox5.Text = datosEmpresa.psub

        FilePut(numeroEmprsa, datosEmpresa)

    End Sub
End Class