Public Class CAP_AjusteImpresionCheques
    Public Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If (e.RowIndex >= 0) AndAlso (e.ColumnIndex >= 0) Then
            DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Color.Green

        End If

    End Sub
    Public Sub CAP_AjusteImpresionCheques_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ColConcep.Width = 200 : ColConcep.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft : ColConcep.HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        ColReng.Width = 80 : ColReng.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft : ColReng.HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        ColCol.Width = 80 : ColCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft : ColCol.HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Rows.Add("Total de renglones de la forma") : DataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridView1.Rows.Add("Fecha")
        DataGridView1.Rows.Add("Beneficiario")
        DataGridView1.Rows.Add("Importe en número")
        DataGridView1.Rows.Add("Importe en letra")
        DataGridView1.Rows.Add("Concepto")
        DataGridView1.Rows.Add("Inicio aplicación")
        DataGridView1.Rows.Add("Sumas iguales")
        DataGridView1.Rows.Add("Cuenta")
        DataGridView1.Rows.Add("Subcuenta")
        DataGridView1.Rows.Add("Nombre Cta-Subcta")
        DataGridView1.Rows.Add("Parcial")
        DataGridView1.Rows.Add("Debe")
        DataGridView1.Rows.Add("Haber")
        DataGridView1.GridColor = Color.Red

        'DataGridView1_CellClick(sender, e)



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Hide()

    End Sub


End Class