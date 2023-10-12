Imports System.Linq.Expressions
Imports System.Net.Http.Headers
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


                    apli()
                    DataGridView1.ClearSelection()
                    DataGridView1.RowCount = 1 : DataGridView1.ColumnCount = 0
                    DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.RowCount - 1
                    DataGridView1.Rows(DataGridView1.RowCount - 1).Selected = True

                    DataGridView1_CellEnter(sender, e)

                    DataGridView1.RowCount = 100

                    DataGridView1.Columns(0).Width = 100 : DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(0).HeaderText = "Cuenta" = True
                    DataGridView1.Columns(1).Width = 100 : DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(1).HeaderText = "SubCta" = True
                    DataGridView1.Columns(2).Width = 300 : DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(2).HeaderText = "Nombre" = True
                    DataGridView1.Columns(3).Width = 150 : DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(3).HeaderText = "Parcial" = True
                    DataGridView1.Columns(4).Width = 150 : DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(4).HeaderText = "Debe" = True
                    DataGridView1.Columns(5).Width = 150 : DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(5).HeaderText = "Haber" = True

                    DataGridView1.Columns(6).Width = 10 : DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(6).HeaderText = "  " : DataGridView1.Columns(6).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
                    DataGridView1.Columns(7).Width = 10 : DataGridView1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(7).HeaderText = "  " : DataGridView1.Columns(7).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
                    DataGridView1.Columns(8).Width = 10 : DataGridView1.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(8).HeaderText = "  " : DataGridView1.Columns(8).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
                    DataGridView1.Columns(9).Width = 200 : DataGridView1.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(9).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
                    DataGridView1.Columns(10).Width = 200 : DataGridView1.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(10).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
                Else
                    MsgBox("Las sumas no se han verificado", vbCritical)
                End If
            Case Else

                MessageBox.Show("ESTA PÓLIZA NO SE PUEDE ARCHIVAR, " & Chr(13) & "NO ESTA VALIDADA", "CAPTURA", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End Select
        Exit Sub
        MsgBox("NO SE ELIGIO EL MES EN EL QUE SE DEBE DE APLICAR LA PÓLIZA" & Chr(13) & "INTENTE DE NUEVO", vbCritical)
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
    Sub verificar(sumaDebe, sumaHaber, cheque)
        sumaDebe = 0 : sumaHaber = 0 : cheque = 0
        If ultimo.TipoCap = 1 Then cheque = 1
        For i = 1 To (DataGridView1.Rows(-1).Cells(0).Value)
            If (DataGridView1.Rows(i).Cells(4).Value) <> "" Then
                sumaDebe = sumaDebe + (DataGridView1.Rows(i).Cells(4).Value)
            End If
            If (DataGridView1.Rows(i).Cells(5).Value) <> "" Then
                sumaHaber = sumaHaber + (DataGridView1.Rows(i).Cells(5).Value)
                If TextBox2.Text <> "" Then
                    If TextBox2.Text = (DataGridView1.Rows(i).Cells(5).Value) * -1 Then cheque = 1
                End If
            End If
        Next i

        DataGridView1.Rows(ultimo.renglon + 1).Cells(2).Value = "  sumas"
        'DataGridView1.Rows(ultimo.renglon + 1).Cells(4).Value = Format(sumaDebe, z1)
        'DataGridView1.Rows(ultimo.renglon + 1).Cells(5).Value = Format(sumaHaber, z1)
        Dim result As Decimal
        If Decimal.TryParse(sumaDebe + sumaHaber, result) AndAlso result <> 0 Then
            cheque = 0
        End If

        If cheque = 0 Then
            MsgBox("El importe del cheque no es correcto o las sumas no son iguales")
            DataGridView1.Rows(ultimo.renglon + 1).Cells(2).Value = ""
            DataGridView1.Rows(ultimo.renglon + 1).Cells(4).Value = ""
            DataGridView1.Rows(ultimo.renglon + 1).Cells(5).Value = ""
        End If

    End Sub


    Private Sub CAP_CapturaPorOtrosMedios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = 1
        Mess = 1 : TextBox3.Text = ""
        Label2.Text = "de Enero de" + Trim(DATOS.a_o)
        Me.Text = Me.Text + "" + Trim(DATOS.D1)
        Rgtro_Validacion = 0

        DataGridView1.Columns(0).Width = 100 : DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(0).HeaderText = "Cuenta" : DataGridView1.Columns(0).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Columns(1).Width = 100 : DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(1).HeaderText = "SubCta" : DataGridView1.Columns(1).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Columns(2).Width = 300 : DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(2).HeaderText = "Nombre" : DataGridView1.Columns(2).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Columns(3).Width = 150 : DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(3).HeaderText = "Parcial" : DataGridView1.Columns(3).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Columns(4).Width = 150 : DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(4).HeaderText = "Debe" : DataGridView1.Columns(4).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Columns(5).Width = 150 : DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(5).HeaderText = "Haber" : DataGridView1.Columns(5).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)

        DataGridView1.Columns(6).Width = 10 : DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(6).HeaderText = "  " : DataGridView1.Columns(6).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Columns(7).Width = 10 : DataGridView1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(7).HeaderText = "  " : DataGridView1.Columns(7).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Columns(8).Width = 10 : DataGridView1.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(8).HeaderText = "  " : DataGridView1.Columns(8).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Columns(9).Width = 200 : DataGridView1.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(9).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Columns(10).Width = 200 : DataGridView1.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : DataGridView1.Columns(10).HeaderCell.Style.Font = New Font(DataGridView1.Font, FontStyle.Bold)

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
    Sub LocEsp(IC As Integer, Fl As Integer, Rto As Integer)
        abrirRandomNominaCaptura()

        For i = IC To Fl : FileGet(3, CATAUX, i)
            If Val(CATAUX.C1) = 0 And Val(CATAUX.C3) = 0 Then
                Rto = i
                Exit For
            End If

        Next i

    End Sub
    Sub CalificaSubCta()
        Dim op1 As Integer, califPrimero As Integer, califSegundo As Integer
        Dim op2 As Integer, aplicado As Integer, nuevo As Integer
        Dim registroIncio As Integer, registroFin As Integer

        op2 = 0
        If (DataGridView1.Rows(-1).Cells(9).Value) = "B" Then op2 = DataGridView1.RowCount = -1
        If (DataGridView1.Rows(-1).Cells(9).Value) = "C" Then op2 = (DataGridView1.Rows(-1).Cells(7).Value)

        If op2 > 0 Then
            op1 = DataGridView1.RowCount : aplicado = 0
            If IsNumeric(DataGridView1.Rows(op2).Cells(1).Value) Then
                registroIncio = (DataGridView1.Rows(op2).Cells(7).Value)
                registroFin = (DataGridView1.Rows(op2).Cells(8).Value)

                Do Until (DataGridView1.Rows(op2).Cells(1).Value) = ""
                    califPrimero = (DataGridView1.Rows(op2).Cells(1).Value)
                    abrirRandomNominaCaptura()
                    For i = registroIncio To registroFin : FileGet(numeroAuxiliar, i, 2)
                        califSegundo = Val(CATAUX.C1)
                        If califSegundo = califPrimero Then
                            aplicado = 1
                            DataGridView1.ColumnCount = 2 : DataGridView1.Rows(0).Cells(0).Value = Trim(CATAUX.C2)
                            DataGridView1.ColumnCount = 6 : DataGridView1.Rows(0).Cells(0).Value = i
                            DataGridView1.ColumnCount = 7 : DataGridView1.Rows(0).Cells(0).Value = op2
                            DataGridView1.ColumnCount = 9 : DataGridView1.Rows(0).Cells(0).Value = "C"
                            Exit For
                        End If
                    Next i

                    If aplicado = 0 Then
                        CATAUX.C1 = Str(califPrimero)
                        DataGridView1.ColumnCount = 2
                        If DataGridView1.CurrentCell.Value = "" Then
                            DataGridView1.CurrentCell.Value = "No existe" + Str(califPrimero)
                        End If
                        CATAUX.C2 = LTrim(DataGridView1.CurrentCell.Value)

                        CATAUX.C3 = ""
                        CATAUX.C4 = "" : CATAUX.C5 = "" : FilePut(3, CATAUX, nuevo)
                        DataGridView1.ColumnCount = 6 : DataGridView1.CurrentCell.Value = nuevo
                        DataGridView1.ColumnCount = 7 : DataGridView1.CurrentCell.Value = op2
                        DataGridView1.ColumnCount = 9 : DataGridView1.CurrentCell.Value = "C"
                    End If
                    op1 = op1 + 1 : DataGridView1.RowCount = op1
                Loop
            Else
                DataGridView1.ColumnCount = 0
                DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
                Zi = Zi - 1
                DataGridView1.ColumnCount = DataGridView1.ColumnCount + 1
            End If
        End If

    End Sub
    Sub validacion()
        Dim a As Integer
        For Zi = 1 To (DataGridView1.Rows.Count - 1)
            a = 3
            If Zi > (DataGridView1.Rows(-2).Cells(0).Value) Then Zi = DataGridView1.Rows(-1).Cells(0).Value
            Exit For

            DataGridView1.RowCount = Zi : DataGridView1.ColumnCount = 0
            If IsNumeric(DataGridView1.Rows(Zi).Cells(0).Value) Then a = 1
            If IsNumeric(DataGridView1.Rows(Zi).Cells(1).Value) Then a = 2
            Select Case a
                Case 1
                    TextBox1.Text = (DataGridView1.Rows(Zi).Cells(0).Value)
                    ENTRCTA()

                Case 2
                    CalificaSubCta()


                Case Else

                    DataGridView1.Rows.RemoveAt(Zi)


                    Zi = Zi
            End Select
        Next Zi
        Rgtro_Validacion = 1

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

        Dim primerFila As Integer = DataGridView1.CurrentRow.Index
        Dim ultimoFila As Integer = DataGridView1.RowCount - 1
        Dim primerColumna As Integer = DataGridView1.SelectedColumns(0).Index
        Dim ultimoColumna As Integer = DataGridView1.SelectedColumns(DataGridView1.SelectedColumns.Count - 1).Index
        retornoCarro = InIPGc
        inicioCopia = InIPGr
        infoTemp = ""
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


    Private Sub EneroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EneroToolStripMenuItem.Click
        Dim Index As Integer
        Close()
        abrirRandomNominaCaptura()
        FileGet(1, DATOS, 1)
        Arch_Oper = Trim(DATOS.No_arch)

        Select Case Index
            Case 0
                Mess = 13
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + 13

            Case 1 To 9
                Mess = Index
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + "0" + Trim(Str(Mess))

            Case 10 To 12
                Mess = Index
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + Trim(Str(Mess))


        End Select


    End Sub

    Private Sub FebreroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FebreroToolStripMenuItem.Click
        Dim Index As Integer
        Close()
        abrirRandomNominaCaptura()
        FileGet(1, DATOS, 1)
        Arch_Oper = Trim(DATOS.No_arch)

        Select Case Index
            Case 0
                Mess = 13
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + 13

            Case 1 To 9
                Mess = Index
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + "0" + Trim(Str(Mess))

            Case 10 To 12
                Mess = Index
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + Trim(Str(Mess))


        End Select
    End Sub

    Private Sub MarzoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarzoToolStripMenuItem.Click
        Dim Index As Integer
        Close()
        abrirRandomNominaCaptura()
        FileGet(1, DATOS, 1)
        Arch_Oper = Trim(DATOS.No_arch)

        Select Case Index
            Case 0
                Mess = 13
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + 13

            Case 1 To 9
                Mess = Index
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + "0" + Trim(Str(Mess))

            Case 10 To 12
                Mess = Index
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + Trim(Str(Mess))


        End Select
    End Sub

    Private Sub AbrilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrilToolStripMenuItem.Click
        Dim Index As Integer
        Close()
        abrirRandomNominaCaptura()
        FileGet(1, DATOS, 1)
        Arch_Oper = Trim(DATOS.No_arch)

        Select Case Index
            Case 0
                Mess = 13
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + 13

            Case 1 To 9
                Mess = Index
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + "0" + Trim(Str(Mess))

            Case 10 To 12
                Mess = Index
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + Trim(Str(Mess))


        End Select
    End Sub

    Private Sub MayoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MayoToolStripMenuItem.Click
        Dim Index As Integer
        Close()
        abrirRandomNominaCaptura()
        FileGet(1, DATOS, 1)
        Arch_Oper = Trim(DATOS.No_arch)

        Select Case Index
            Case 0
                Mess = 13
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + 13

            Case 1 To 9
                Mess = Index
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + "0" + Trim(Str(Mess))

            Case 10 To 12
                Mess = Index
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + Trim(Str(Mess))


        End Select
    End Sub

    Private Sub JunioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JunioToolStripMenuItem.Click
        Dim Index As Integer
        Close()
        abrirRandomNominaCaptura()
        FileGet(1, DATOS, 1)
        Arch_Oper = Trim(DATOS.No_arch)

        Select Case Index
            Case 0
                Mess = 13
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + 13

            Case 1 To 9
                Mess = Index
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + "0" + Trim(Str(Mess))

            Case 10 To 12
                Mess = Index
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + Trim(Str(Mess))


        End Select

    End Sub

    Private Sub JulioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JulioToolStripMenuItem.Click
        Dim Index As Integer
        Close()
        abrirRandomNominaCaptura()
        FileGet(1, DATOS, 1)
        Arch_Oper = Trim(DATOS.No_arch)

        Select Case Index
            Case 0
                Mess = 13
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + 13

            Case 1 To 9
                Mess = Index
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + "0" + Trim(Str(Mess))

            Case 10 To 12
                Mess = Index
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + Trim(Str(Mess))


        End Select
    End Sub

    Private Sub AgostoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgostoToolStripMenuItem.Click
        Dim Index As Integer
        Close()
        abrirRandomNominaCaptura()
        FileGet(1, DATOS, 1)
        Arch_Oper = Trim(DATOS.No_arch)

        Select Case Index
            Case 0
                Mess = 13
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + 13

            Case 1 To 9
                Mess = Index
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + "0" + Trim(Str(Mess))

            Case 10 To 12
                Mess = Index
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + Trim(Str(Mess))


        End Select
    End Sub

    Private Sub SeptiembreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeptiembreToolStripMenuItem.Click
        Dim Index As Integer
        Close()
        abrirRandomNominaCaptura()
        FileGet(1, DATOS, 1)
        Arch_Oper = Trim(DATOS.No_arch)

        Select Case Index
            Case 0
                Mess = 13
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + 13

            Case 1 To 9
                Mess = Index
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + "0" + Trim(Str(Mess))

            Case 10 To 12
                Mess = Index
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + Trim(Str(Mess))


        End Select
    End Sub

    Private Sub OctubreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OctubreToolStripMenuItem.Click
        Dim Index As Integer
        Close()
        abrirRandomNominaCaptura()
        FileGet(1, DATOS, 1)
        Arch_Oper = Trim(DATOS.No_arch)

        Select Case Index
            Case 0
                Mess = 13
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + 13

            Case 1 To 9
                Mess = Index
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + "0" + Trim(Str(Mess))

            Case 10 To 12
                Mess = Index
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + Trim(Str(Mess))


        End Select
    End Sub

    Private Sub NoviembreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoviembreToolStripMenuItem.Click
        Dim Index As Integer
        Close()
        abrirRandomNominaCaptura()
        FileGet(1, DATOS, 1)
        Arch_Oper = Trim(DATOS.No_arch)

        Select Case Index
            Case 0
                Mess = 13
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + 13

            Case 1 To 9
                Mess = Index
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + "0" + Trim(Str(Mess))

            Case 10 To 12
                Mess = Index
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + Trim(Str(Mess))


        End Select
    End Sub

    Private Sub DiciembreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiciembreToolStripMenuItem.Click
        Dim Index As Integer
        FileClose()
        abrirRandomNominaCaptura()
        FileGet(1, DATOS, 1)
        Arch_Oper = Trim(DATOS.No_arch)

        Select Case Index
            Case 0
                Mess = 13
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + 13

            Case 1 To 9
                Mess = Index
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + "0" + Trim(Str(Mess))

            Case 10 To 12
                Mess = Index
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + Trim(Str(Mess))


        End Select
    End Sub

    Private Sub IncorporaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncorporaciónToolStripMenuItem.Click
        Dim Index As Integer
        Close()
        abrirRandomNominaCaptura()
        FileGet(1, DATOS, 1)
        Arch_Oper = Trim(DATOS.No_arch)

        Select Case Index
            Case 0
                Mess = 13
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + 13

            Case 1 To 9
                Mess = Index
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + "0" + Trim(Str(Mess))

            Case 10 To 12
                Mess = Index
                Label2.Text = "de" + Trim(MesCheque(Mess)) + "de" + Trim(DATOS.a_o)
                Arch_Oper = Trim(DATOS.No_arch) + Trim(Str(Mess))


        End Select
    End Sub

    Private Sub ValidaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValidaciónToolStripMenuItem.Click

    End Sub



    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        On Error Resume Next

        TextBox2.SelectionStart = Len(TextBox2.Text)

    End Sub


    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then

        End If

    End Sub
End Class