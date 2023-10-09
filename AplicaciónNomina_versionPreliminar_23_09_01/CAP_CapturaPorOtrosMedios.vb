﻿Imports System.Linq.Expressions
Imports System.Text
Imports Microsoft.SqlServer.Server

Public Class CAP_CapturaPorOtrosMedios
    Dim impor_te As Long
    Dim Zi As Integer, Rgtro_Validacion As Integer, Mess As Integer
    Dim Suma_Corr As Integer
    Dim imprimir As Boolean
    Dim infoTemp As Long
    Dim InIPGr As Long, InIPGc As Long
    Dim infoSeleccionadaTemp As Integer
    Dim filasSeleccionadas As Integer

    Sub apli()
        OPER.CTA = OPER.CTA.Replace(" ", "") + Str(ultimo.poliza)
        OPER.descr = Trim(TextBox3.Text)
        OPER.indenti = "A"
        OPER.fe = LTrim(RTrim(TextBox1.Text))
        fin_oper = fin_oper + 1
        FilePut(3, OPER, fin_oper)
        Dim i As Integer
        abrirRandomNominaCaptura()
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
    Private Sub CuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentasToolStripMenuItem.Click
        'If DataGridView1.Rows(i).Cells(9).Value = 0 Then
        CAP_CatCuentasMayor.Show()
        If ultimo.Ubi = 1 Then
            TextBox2.Text = trcta.num
        End If

    End Sub

    Private Sub SubCuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubCuentasToolStripMenuItem.Click
        CAP_SubCuentas.Show()

    End Sub


    Private Sub CAP_CapturaPorOtrosMedios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = 1
        Mess = 1 : TextBox3.Text = ""
        Label2.Text = "de Enero de" + Trim(DATOS.a_o)
        Me.Text = Me.Text + "" + Trim(DATOS.D1)
        Rgtro_Validacion = 0

        DataGridView1.Columns(0).Width = 800 : DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(0).HeaderText = "Cuenta" : DataGridView1.Columns(0).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Columns(1).Width = 800 : DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(0).HeaderText = "SubCta" : DataGridView1.Columns(0).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Columns(2).Width = 3350 : DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(0).HeaderText = "Nombre" : DataGridView1.Columns(0).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Columns(3).Width = 1400 : DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(0).HeaderText = "Parcial" : DataGridView1.Columns(0).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Columns(4).Width = 1400 : DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(0).HeaderText = "Debe" : DataGridView1.Columns(0).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Columns(5).Width = 1400 : DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(0).HeaderText = "Haber" : DataGridView1.Columns(0).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        'DataGridView1.Columns(6).Width = 800 : DataGridView1.Columns(7).Width = 800 : DataGridView1.Columns(8).Width = 800 : DataGridView1.Columns(9).Width = 800 : DataGridView1.Columns(10).Width = 3200

        Me.Text = "REDACCIÓN"





        'ColCta.Width = 70
        'ColSubCta.Width = 70
        'ColNom.Width = 200
        'ColParcial.Width = 80
        'ColDebe.Width = 80
        'ColHaber.Width = 80
        'ColReda.Width = 160
        'ColFolioFis.Width = 200



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

    Sub verificar(sumaDebe, sumaHaber, cheque)
        sumaDebe = 0 : sumaHaber = 0 : cheque = 0
        If ultimo.TipoCap = 1 Then cheque = 1
        For i = 1 To (DataGridView1.Rows(-1).Cells(0).Value)
            If (DataGridView1.Rows(i).Cells(4).Value) <> "" Then
                sumaDebe = sumaDebe + (DataGridView1.Rows(i).Cells(4).Value)
            End If
            If (DataGridView1.Rows(i).Cells(5).Value) <> "" Then
                sumaHaber = sumaHaber + (DataGridView1.Rows(i).Cells(5).Value)



            End If

        Next i

    End Sub


    Sub Redacc()
        For i = 1 To DataGridView1.Rows.Count - 1
            If IsNumeric(DataGridView1.Rows(i).Cells(1).Value) Then
                If (DataGridView1.Rows(i).Cells(10).Value) = "" Then
                    DataGridView1.Rows(i).Cells(10).Value = Trim(TextBox2.Text)
                End If
            End If
            If (DataGridView1.Rows(i).Cells(0).Value) = "" AndAlso (DataGridView1.Rows(i).Cells(1).Value) Then
                Exit For
            End If
        Next i

    End Sub

    Sub validacion()
        Dim a As Integer
        For Zi = 1 To (DataGridView1.Rows.Count - 1)
            a = 3
            If Zi > (DataGridView1.Rows(-2).Cells(0).Value) Then Zi = DataGridView1.Rows(-1).Cells(0).Value
            Exit For

            DataGridView1.RowCount = Zi : DataGridView1.ColumnCount = 0
            If IsNumeric(DataGridView1.Rows(Zi).Cells(0).Value) Then a = 1
            If IsNumeric(DataGridView1.Rows(Zi).Cells(1).Value) Then a = "a2"
            Select Case a
                Case 1
                    TextBox1.Text = (DataGridView1.Rows(Zi).Cells(0).Value)
                    ENTRCTA()

                Case 2
                    TextBox1.Text = (DataGridView1.Rows(Zi).Cells(1).Value)

                Case Else

                    Zi = Zi




            End Select









        Next Zi

    End Sub


    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()

    End Sub



    Private Sub CopiarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem1.Click
        Dim infoSeleccionada As Integer
        Dim i, j As Integer
        Dim filasSeleccionadas As Integer
        Clipboard.Clear()
        ' Obtener el índice de la primera fila seleccionada
        Dim primerFila As Integer = DataGridView1.CurrentRow.Index
        ' Obtener el índice de la última fila seleccionada
        Dim ultimoFila As Integer = DataGridView1.RowCount - 1
        ' Obtener el índice de la primera columna seleccionada
        Dim primerColumna As Integer = DataGridView1.SelectedColumns(0).Index
        ' Obtener el índice de la última columna seleccionada
        Dim ultimoColumna As Integer = DataGridView1.SelectedColumns(DataGridView1.SelectedColumns.Count - 1).Index

        filasSeleccionadas = ultimoFila - primerFila
        For i = primerFila To ultimoFila
            For j = primerColumna To ultimoColumna
                infoSeleccionada = infoSeleccionada + DataGridView1.Rows(i).Cells(j).Value

                If j < ultimoColumna Then
                    infoSeleccionada = infoSeleccionada & Chr(9)
                End If
            Next j
            infoSeleccionada = infoSeleccionada & Chr(13) & Chr(10)
        Next i
        Clipboard.SetText(infoSeleccionada)
    End Sub

    Private Sub CopiarTodoCtrlSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarTodoCtrlSToolStripMenuItem.Click


        ' Obtener el índice de la primera fila seleccionada
        Dim primerFila As Integer = DataGridView1.CurrentRow.Index
        ' Obtener el índice de la última fila seleccionada
        Dim ultimoFila As Integer = DataGridView1.RowCount - 1
        ' Obtener el índice de la primera columna seleccionada
        Dim primerColumna As Integer = DataGridView1.SelectedColumns(0).Index
        ' Obtener el índice de la última columna seleccionada
        Dim ultimoColumna As Integer = DataGridView1.SelectedColumns(DataGridView1.SelectedColumns.Count - 1).Index

        Clipboard.Clear()
        filasSeleccionadas = ultimoFila - primerFila

        For i = primerFila To ultimoFila
            For j = ultimoColumna To primerColumna
                infoSeleccionadaTemp = infoSeleccionadaTemp + DataGridView1.Rows(i).Cells(j).Value
                If j < primerColumna Then
                    infoSeleccionadaTemp = infoSeleccionadaTemp & Chr(9)
                End If
            Next j
            infoSeleccionadaTemp = infoSeleccionadaTemp & Chr(13) & Chr(10)
        Next i
        Clipboard.SetText(infoSeleccionadaTemp)
    End Sub

    Private Sub DeshacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeshacerToolStripMenuItem.Click
        Dim inicio As Integer
        Dim retornoCarro As Long
        Dim inicioCopia As Long
        infoTemp = ""
        Dim primerFila As Integer = DataGridView1.CurrentRow.Index
        Dim ultimoFila As Integer = DataGridView1.RowCount - 1
        Dim primerColumna As Integer = DataGridView1.SelectedColumns(0).Index
        Dim ultimoColumna As Integer = DataGridView1.SelectedColumns(DataGridView1.SelectedColumns.Count - 1).Index
        retornoCarro = InIPGc
        inicioCopia = InIPGr

        primerFila = inicioCopia : primerColumna = retornoCarro
        If infoSeleccionadaTemp <> "" Then
            Clipboard.Clear()
            inicio = 1

            For i = 1 To Len(infoSeleccionadaTemp)
                Select Case Mid(infoSeleccionadaTemp, i, 1)
                    Case Chr(9)
                        TextBox2.Text = Mid(infoSeleccionadaTemp, inicio, (i - inicio))
                        infoTemp = infoTemp + TextBox2.Text & Chr(9)
                        DataGridView1.Rows(0).Cells(0).Value = Text(Mid(infoTemp, inicio, i - inicio))
                        DataGridView1.ColumnCount = DataGridView1.ColumnCount + 1
                        inicio = i + 1
                    Case Chr(13)
                        TextBox2.Text = Mid(infoSeleccionadaTemp, inicio, (i - inicio))
                        infoTemp = infoTemp + TextBox2.Text & Chr(13)
                        DataGridView1.Rows(0).Cells(0).Value = Text(Mid(infoTemp, inicio, i - inicio))
                        If primerFila - 1 <= ultimoFila Then
                            primerFila = primerFila + 100 : ultimoFila = ultimoFila + 1
                            inicio = i + 1

                        End If
                    Case Chr(10)
                        infoTemp = infoTemp & Chr(10)
                        primerColumna = retornoCarro
                        inicio = i + 1

                End Select
            Next i
            primerFila = inicioCopia : primerColumna = retornoCarro

        End If
        Clipboard.Clear()

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim primerFila As Integer = DataGridView1.CurrentRow.Index
        Dim ultimoFila As Integer = DataGridView1.RowCount - 1
        Dim primerColumna As Integer = DataGridView1.SelectedColumns(0).Index
        Dim ultimoColumna As Integer = DataGridView1.SelectedColumns(DataGridView1.SelectedColumns.Count - 1).Index
        For i = primerFila To ultimoFila
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
        Next i
        sumaToPoliza()

    End Sub

    Sub sumaToPoliza()
        Dim sumaDt As Integer
        Dim primerFila As Integer = DataGridView1.CurrentRow.Index
        Dim ultimoFila As Integer = DataGridView1.RowCount - 1
        Dim primerColumna As Integer = DataGridView1.SelectedColumns(0).Index
        Dim ultimoColumna As Integer = DataGridView1.SelectedColumns(DataGridView1.SelectedColumns.Count - 1).Index
        Su_ma.Parcial = 0 : Su_ma.Debe = 0 : Su_ma.Haber = 0
        For s = 1 To primerFila - 1
            If DataGridView1.Rows(s).Cells(9).Value = "C" Then
                Do Until DataGridView1.Rows(s).Cells(9).Value <> "C"
                    sumaDt = DataGridView1.Rows(s).Cells(7).Value

                    If (IsNumeric(DataGridView1.Rows(s).Cells(3).Value)) Then
                        Rgtro_Validacion = 1
                        'DataGridView1.Rows(s).Cells(3).Value = Format(DataGridView1.Rows(s).Cells(3).Value, z1)
                        Su_ma.Parcial = Su_ma.Parcial + DataGridView1.Rows(s).Cells(3).Value
                        'DataGridView1.Rows(s).Cells(3).Value = Format(DataGridView1.Rows(s).Cells(3).Value, z1)

                    End If
                    s = s + 1
                Loop

                If Su_ma.Parcial >= 0 Then
                    DataGridView1.Rows(sumaDt).Cells(5).Value = ""
                    'DataGridView1.Rows(sumaDt).Cells(4).Value = Format(Su_ma.Parcial, z1)
                    Su_ma.Parcial = 0
                Else
                    DataGridView1.Rows(sumaDt).Cells(4).Value = ""
                    'DataGridView1.Rows(sumaDt).Cells(5).Value = Format(Su_ma.Parcial, z1)
                    Su_ma.Parcial = 0
                End If
            End If
            If DataGridView1.Rows(s).Cells(9).Value = "" Then Exit For
        Next s
    End Sub

    Sub sumaPoliza()
        For sm = 1 To DataGridView1.Rows.Count - 1
            If IsNumeric(DataGridView1.Rows(sm).Cells(4).Value) Then
                Su_ma.Debe = Su_ma.Debe + (DataGridView1.Rows(sm).Cells(4).Value)
                'DataGridView1.Rows(sm).Cells(4).Value = Format(DataGridView1.Rows(sm).Cells(4).Value, z1)

            End If
        Next

    End Sub



    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        DataGridView1.DefaultCellStyle.BackColor = Color.Yellow

        TextBox2.Text = valcelant
    End Sub

    Private Sub DataGridView1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DataGridView1.KeyPress
        'TextBox2.Text &= Chr(ASCIIEncoding)

    End Sub

    Private Sub DataGridView1_Leave(sender As Object, e As EventArgs) Handles DataGridView1.Leave
        DataGridView1.DefaultCellStyle.BackColor = Color.White

    End Sub
End Class