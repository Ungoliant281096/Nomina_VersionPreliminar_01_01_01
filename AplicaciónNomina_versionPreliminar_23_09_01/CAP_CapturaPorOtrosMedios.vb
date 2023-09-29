Public Class CAP_CapturaPorOtrosMedios
    Dim impor_te As Long
    Private Sub CopiarTodoCtrlSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarTodoCtrlSToolStripMenuItem.Click

    End Sub

    Private Sub CuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentasToolStripMenuItem.Click
        'If DataGridView1.Rows(i).Cells(9).Value = 0 Then
        CAP_CatCuentasMayor.Show()
        If ultimo.Ubi = 1 Then
            'LTXT.Text = trcta.num
        End If

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
    Sub apli()
        OPER.CTA = OPER.CTA.Replace(" ", "") + Str(ultimo.poliza)
        OPER.descr = Trim(TextBox3.Text)
        OPER.indenti = "A"
        OPER.fe = LTrim(RTrim(TextBox1.Text))
        fin_oper = fin_oper + 1
        FilePut(3, OPER, fin_oper)
        Dim i As Integer
        FileOpen(18, "fiscal", OpenMode.Random,,, Len(fiscal))
        For i = 1 To DataGridView1.Rows(-1).Cells(0).Value
            Select Case DataGridView1.Rows(i).Cells(9).Value
                Case "B"
                    OPER.CTA =
                    OPER.descr = ""
                    OPER.fe = ""

                    If DataGridView1.Rows(i).Cells(5).Value = "" Then
                        impor_te = DataGridView1.Rows(i).Cells(4).Value
                    Else
                        impor_te = DataGridView1.Rows(i).Cells(5).Value
                    End If


                    OPER.indenti = DataGridView1.Rows(i).Cells(9).Value
                    OPER.impte = Str(impor_te)
                    OPER.real = DataGridView1.Rows(i).Cells(6).Value
                    fin_oper = fin_oper + 1

                    FilePut(3, OPER, fin_oper)

                Case "C"
                    'OPER.CTA = (6 - Len(Str(DataGridView1.Rows(i).Cells(9).Value), " ") + Str(DataGridView1.Rows(i).Cells(9).Value)
                    OPER.descr = Trim(DataGridView1.Rows(i).Cells(10).Value)

                    If Trim(DataGridView1.Rows(i).Cells(11).Value) <> "" Then
                        fiscal.estado = True
                    Else
                        fiscal.estado = False
                    End If

                    OPER.fe = ""
                    impor_te = DataGridView1.Rows(i).Cells(3).Value
                    OPER.indenti = Str(impor_te)
                    OPER.real = DataGridView1.Rows(i).Cells(1).Value
                    fin_oper = fin_oper + 1

                    FilePut(3, OPER, fin_oper)
                    FilePut(18, fiscal, fin_oper)

                Case ""
                    Exit For
            End Select
        Next i
        Label6.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        FileClose(18)


    End Sub

    Private Sub GuardarPólizaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarPólizaToolStripMenuItem.Click
        Dim TemPOraL, Temporal1, InIPGr As Long, InIPGc As Long, LLevaT As String
        Dim Zi As Integer, Rgtro_Validacion As Integer, Mess As Integer
        Dim Suma_Corr As Integer
        Dim imprimir As Boolean
        Select Case Rgtro_Validacion
            Case 1
                If Suma_Corr = 1 Then
                    Close()
                    FileOpen(3, Arch_Oper, OpenMode.Random,,, Len(OPER))
                    fin_oper = LOF(3) / Len(OPER)
                    ultimo.poliza = 0

                    If fin_oper <= 0 Then
                        ultimo.poliza = 1
                    Else
                        For i = fin_oper To 1 Step -1
                            FileGet(3, OPER, i)
                            If OPER.indenti = "A" Then
                                ultimo.poliza = Val(OPER.CTA) + 1
                                Exit For
                            End If
                        Next i
                    End If

                End If
                'apli()
                DataGridView1.ClearSelection()

        End Select
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()

    End Sub
End Class