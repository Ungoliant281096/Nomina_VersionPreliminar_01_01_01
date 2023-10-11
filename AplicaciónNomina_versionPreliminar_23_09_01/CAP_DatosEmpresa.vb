Imports System.ComponentModel

Public Class CAP_DatosEmpresa
    Dim Modif_General As Integer

    Private Sub CAP_DatosEmpresa_Activated(sender As Object, e As EventArgs) Handles Me.Activated


        If TextBox1.Text <> "" Then
            Dim result As Integer
            result = MessageBox.Show("Esta a punto de modificar los datos de la empresa" & Environment.NewLine & "¿Desea continuar?", "Confirmación", MessageBoxButtons.OKCancel)
            If result = MessageBoxButtons.OKCancel Then
                Me.Hide()
                Exit Sub
            End If
            'Dim result As DialogResult
            'result = MessageBox.Show("Esta a punto de modificar los datos de la empresa" & Environment.NewLine & "¿Desea continuar?", "Confirmación", MessageBoxButtons.OKCancel)
            'If result = DialogResult.Cancel Then
            '    Me.Close()
            '    Exit Sub
            'End If
            TextBox1_GotFocus(sender, e)


        End If


    End Sub
    Private Sub CAP_DatosEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LOF(1) > 1 Then
            FileGet(1, DATOS, 1)
            TextBox1.Text = Trim(DATOS.D1)
            TextBox2.Text = Trim(DATOS.D2)
            TextBox3.Text = Trim(DATOS.a_o)
            TextBox4.Text = Trim(DATOS.No_arch)

        End If
    End Sub


    'Private Sub CAP_DatosEmpresa_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    '    Dim Grb As Integer
    '    If Modif_General = 1 Then
    '        'Dim result As DialogResult = MessageBox.Show("¿Los datos de la empresa fueron modificados?" & Environment.NewLine & "¿Desea guardar los cambios", MessageBoxButtons.YesNo)
    '        Grb = MsgBox("¿Los datos de la empresa fueron modificados?" & Environment.NewLine & "¿Desea guardar los cambios", MessageBoxButtons.YesNo)
    '        If Grb = vbYesNo Then
    '            FileGet(1, DATOS, 1)
    '            DATOS.D1 = TextBox1.Text : DATOS.D2 = TextBox2.Text : DATOS.a_o = TextBox3.Text
    '            DATOS.No_arch = TextBox4.Text
    '            FilePut(1, DATOS, 1)
    '            Modif_General = 0

    '        End If
    '    End If
    'End Sub

    Public Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        Modif_General = 1

    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text <> "" Then
            TextBox1.Text = UCase(TextBox1.Text)
        End If

    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        If TextBox2.Text <> "" Then
            TextBox2.Text = UCase(TextBox2.Text)
        End If
    End Sub

    Private Sub CAP_DatosEmpresa_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim Grb As Integer
        If Modif_General = 1 Then
            'Dim result As DialogResult = MessageBox.Show("¿Los datos de la empresa fueron modificados?" & Environment.NewLine & "¿Desea guardar los cambios", MessageBoxButtons.YesNo)
            Grb = MsgBox("¿Los datos de la empresa fueron modificados?" & Environment.NewLine & "¿Desea guardar los cambios", MessageBoxButtons.YesNo)
            If Grb = vbYesNo Then
                FileGet(1, DATOS, 1)
                DATOS.D1 = TextBox1.Text : DATOS.D2 = TextBox2.Text : DATOS.a_o = TextBox3.Text
                DATOS.No_arch = TextBox4.Text
                FilePut(1, DATOS, 1)
                Modif_General = 0

            End If
        End If
    End Sub
End Class