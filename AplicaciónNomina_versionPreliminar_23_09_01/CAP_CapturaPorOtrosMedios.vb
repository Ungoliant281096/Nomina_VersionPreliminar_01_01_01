Public Class CAP_CapturaPorOtrosMedios
    Dim impor_te As Long
    Dim Zi As Integer, Rgtro_Validacion As Integer, Mess As Integer
    Dim Suma_Corr As Integer
    Dim imprimir As Boolean
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

                    OPER.CTA = (StrDup(6 - Len(DataGridView1.Rows(i).Cells(9).Value), " ") + Str(DataGridView1.Rows(i).Cells(9).Value))
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


        Select Case Rgtro_Validacion
            Case 1
                If Suma_Corr = 1 Then
                    Close()
                    abrirRandomNominaCaptura()
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
                apli()
                DataGridView1.ClearSelection()

        End Select
    End Sub
    Sub ENTRCTA()
        Dim NoEncontrada As Integer
        Dim Y1 As Integer
        Dim Zi As Integer

        FileClose(2)
        abrirRandomNominaCaptura()
        cm = LOF(2) / Len(CATMAY)
        NoEncontrada = 0
        For Y1 = 1 To cm : FileGet(2, CATMAY, Y1)

            If Val(CATMAY.B1) = Label6.Text Then
                trcta.incia = Y1
                DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value = Val(CATMAY.B1)

                DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value = Trim(CATMAY.B2)

                DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(6).Value = Y1

                DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(7).Value = Val(CATMAY.B4)

                DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(8).Value = Val(CATMAY.B5)

                DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(9).Value = "B"

                DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(10).Value = ""

                trcta.incia = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(7).Value
                trcta.termina = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(8).Value

                If DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(7).Value = 0 Then
                    DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(7).Value = ""
                    DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(8).Value = ""
                End If
                NoEncontrada = 1

                If IsNumeric(DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(7).Value) Then
                    DataGridView1.Rows(0).Cells(0).Value = DataGridView1.Rows(0).Cells(0).Value + 1 = DataGridView1.Rows(0).Cells(0).Value
                Else
                    DataGridView1.Rows(0).Cells(0).Value = 4
                End If
                Exit For
            End If
        Next Y1

        If NoEncontrada = 0 Then
            MsgBox("La cuenta no existe " + DataGridView1.Rows(0).Cells(0).Value + DataGridView1.Rows(2).Cells(0).Value)
            'DataGridView1.Item.Remove(DataGridView: Zi = z1 - 1)
            'CHECAP.Items.RemoveAt(CHECAP.Row)
            'DataGridView1.Item.Remove

        End If



    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()

    End Sub


End Class