Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class NOM_EdicionDePersonal

    Private Sub NOM_EdicionDePersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Funcion que imprime al personal
        imprimirEmpleados(DataGridView1, largoPersonal)

        '   Iterar a través de las filas del ultimo al primero
        For i As Integer = DataGridView1.Rows.Count - 1 To 0 Step -1

            '   Obtenemos el valor de la fila en la columna 6 (Fecha de baja)
            Dim miVariable As String = DataGridView1.Rows(i).Cells(6).Value.ToString()

            '   Manipulamos la variable para reducirla a un espacio en blanco
            miVariable = miVariable.Trim()

            '   Si la fila contiene una fecha de baja la alimina
            If miVariable <> "" Then
                DataGridView1.Rows.RemoveAt(i)
            End If
        Next

        ' Da el largo y ancho de la grid
        DataGridView1.Width = Me.Width * 0.9
        DataGridView1.Height = Me.Height * 0.85

        ' establece el ancho de las columnas
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

    End Sub

    Private Sub NOM_EdicionDePersonal_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        DataGridView1.Width = Me.Width * 0.9
        DataGridView1.Height = Me.Height * 0.85
    End Sub

    Private Sub DataGridView1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DataGridView1.KeyPress
        If Keys.Enter Then
            Dim valor As Integer = DataGridView1.Rows(DataGridView1.CurrentRow.Index - 1).Cells(0).Value.ToString()

            NOM_CapturaPersonal.obtenerPersonal(valor)

            NOM_CapturaPersonal.Show()

        End If
    End Sub
End Class
