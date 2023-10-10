Public Class CAP_SubCuentas


    Private Sub CAP_SubCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imprimirAuxiliar(DataGridView1, largoCatalogoAuxiliar)
        DataGridView1.Width = Me.Width * 0.9
        DataGridView1.Height = Me.Height * 0.85

    End Sub
    Public Sub CAP_SubCuentas_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        If DataGridView1.ColumnCount > 0 And DataGridView1.RowCount > 0 Then
            DataGridView1.DefaultCellStyle.BackColor = Color.Cyan
        End If

    End Sub

    Private Sub CAP_SubCuentas_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        DataGridView1.Width = Me.Width * 0.9
        DataGridView1.Height = Me.Height * 0.85
    End Sub
    Public Sub CAP_SubCuentas_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        If DataGridView1.ColumnCount > 0 And DataGridView1.RowCount > 0 Then
            DataGridView1.DefaultCellStyle.BackColor = Color.White

        End If

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        DataGridView1.Rows(0).Cells(0).Value = TextBox1.Text

    End Sub

    Private Sub NuméricamenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuméricamenteToolStripMenuItem.Click
        DataGridView1.ColumnCount = 0
        DataGridView1.RowCount = 1
        DataGridView1.Sort(DataGridView1.Columns(3), System.ComponentModel.ListSortDirection.Ascending)


    End Sub

    Private Sub AlfabéticamenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlfabéticamenteToolStripMenuItem.Click
        CAP_SubCuentas_Leave(sender, e)
        DataGridView1.ColumnCount = 1
        DataGridView1.RowCount = 1
        CAP_SubCuentas_Enter(sender, e)
        DataGridView1.Sort(DataGridView1.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        CAP_SubCuentas_Leave(sender, e)
        DataGridView1.ColumnCount = 1
        DataGridView1.RowCount = 1
        CAP_SubCuentas_Enter(sender, e)


    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()

    End Sub
End Class