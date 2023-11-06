Public Class CAP_CatCuentasMayor


    Private Sub CAP_CatCuentasMayor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.ColumnCount = 5

        For i As Integer = 1 To largoCatalogoMayor
            FileGet(numeroMayor, CATMAY, i)

            DataGridView1.Rows.Add(CATMAY.B1, CATMAY.B2, CATMAY.B3, CATMAY.B4, CATMAY.B5)
        Next i

        DataGridView1.Focus()

        DataGridView1.Width = Me.Width * 0.9
        DataGridView1.Height = Me.Height * 0.85

        DataGridView1.Columns(0).Width = 75 : DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(0).HeaderText = "Cuenta" : DataGridView1.Columns(0).HeaderCell.Style.BackColor = Color.Yellow : DataGridView1.Columns(0).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Columns(1).Width = 75 : DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(1).HeaderText = "Nombre" : DataGridView1.Columns(1).HeaderCell.Style.BackColor = Color.Yellow : DataGridView1.Columns(1).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)


    End Sub

    Private Sub CAP_CatCuentasMayor_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        DataGridView1.Width = Me.Width * 0.9
        DataGridView1.Height = Me.Height * 0.85

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        Me.Close()

    End Sub
End Class