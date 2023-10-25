Imports System.Data.SqlClient
Imports System.Data.Odbc
Imports System.Drawing.Text
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        LlenarTreeView("C:\NOMINAS")

        'FileGet(numeroEmprsa, datosEmpresa, largoEmpresa)

        'Label1.Text = datosEmpresa.name.Trim()
        'Label2.Text = datosEmpresa.añoEmpresa
        'Label3.Text = datosEmpresa.psub
        'Label4.Text = datosEmpresa.sm

    End Sub
    Private Sub CapturaPersonalToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CapturaPersonalToolStripMenuItem.Click
        NOM_CapturaPersonal.Show()

    End Sub

    Private Sub EdiciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EdiciónToolStripMenuItem.Click
        NOM_EdicionDePersonal.Show()

    End Sub

    Private Sub CapturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapturaToolStripMenuItem.Click
        NOM_CapturarNominaQuincenal.Show()
    End Sub

    Private Sub CFDIComplementoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CFDIComplementoToolStripMenuItem.Click
        NOM_DatosCompPersonal.Show()
    End Sub

    Private Sub ImpresiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImpresiónToolStripMenuItem.Click
        NOM_AjusteMilimetrosImpresionCheques.Show()
    End Sub

    Private Sub ImpresiónToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ImpresiónToolStripMenuItem1.Click
        MessageBox.Show("Opción no habilitada")
        mostrarDatosEmpresa()
    End Sub

    Private Sub DatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosToolStripMenuItem.Click
        NOM_DatosEmpresa.Show()
    End Sub

    Private Sub ComplementariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComplementariosToolStripMenuItem.Click
        NOM_DatosComplementarios.Show()
    End Sub
    Private Sub DirectorioDeTarifasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DirectorioDeTarifasToolStripMenuItem.Click
        NOM_Tarifas.Show()
    End Sub
    Private Sub SubdirectorioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubdirectorioToolStripMenuItem.Click
        MessageBox.Show("Aún no se puede crear un subdirectorio")
    End Sub

    Private Sub Articulo113ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Articulo113ToolStripMenuItem.Click
        NOM_TablaArticulo.Show()
    End Sub
    Private Sub Arítuclo114ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles Arítuclo114ToolStripMenuItem.Click
        NOM_TablaArticulo.Show()
    End Sub

    Private Sub CréditoSalarioToolStripMenuItem_Click(sender As Object, e As EventArgs)
        NOM_CreditoSalario.Show()
    End Sub

    Private Sub ISRAnual177ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ISRAnual177ToolStripMenuItem.Click
        NOM_TablaArticulo.Show()
    End Sub

    Private Sub SubsudioAnual178ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubsudioAnual178ToolStripMenuItem.Click
        NOM_TablaSubsidio.Show()
    End Sub

    Private Sub CréditoSalarioToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CréditoSalarioToolStripMenuItem.Click
        NOM_CreditoSalario.Show()
    End Sub


    Private Sub VersiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VersiónToolStripMenuItem.Click
        NOM_InformacionPrograma.Show()
    End Sub

    Private Sub mostrarDatosEmpresa()
        Label1.Text = "Empresa: "
        Label4.Text = "Año: " + "Subsidio: " + "Salario minimio x dia: $"
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        MENÚ.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Hide()
        MENÚ.Show()
    End Sub

    Private Sub cambioDirectorioNomina()
        ' Mostrar el diálogo para seleccionar un directorio
        Dim dialogoDirectorio As New FolderBrowserDialog()
        If dialogoDirectorio.ShowDialog() = DialogResult.OK Then
            ' Limpiar el árbol actual antes de llenarlo con nuevos datos
            TreeView1.Nodes.Clear()
            ' Obtener el directorio seleccionado
            Dim directorioSeleccionado As String = dialogoDirectorio.SelectedPath
            ' Llenar el árbol con las carpetas y archivos del directorio
            LlenarTreeView(directorioSeleccionado)
        End If
    End Sub

    Private Sub LlenarTreeView(directorio As String)
        ' Crear un nodo raíz con el nombre del directorio
        Dim nodoRaiz As New TreeNode(Path.GetFileName(directorio))
        nodoRaiz.Tag = directorio
        TreeView1.Nodes.Add(nodoRaiz)
        ' Llenar el árbol con las carpetas y archivos
        LlenarNodo(nodoRaiz)
    End Sub

    Private Sub LlenarNodo(nodoPadre As TreeNode)
        Try
            ' Obtener la ruta del directorio o archivo asociado con este nodo
            Dim ruta As String = DirectCast(nodoPadre.Tag, String)
            ' Obtener la lista de subdirectorios
            Dim subdirectorios As String() = Directory.GetDirectories(ruta)
            For Each subdirectorio As String In subdirectorios
                Dim nodo As New TreeNode(Path.GetFileName(subdirectorio))
                nodo.Tag = subdirectorio
                nodoPadre.Nodes.Add(nodo)
                ' Llamar recursivamente para llenar los subnodos
                LlenarNodo(nodo)
            Next
            ' Obtener la lista de archivos
            Dim archivos As String() = Directory.GetFiles(ruta)
            For Each archivo As String In archivos
                Dim nodo As New TreeNode(Path.GetFileName(archivo))
                nodo.Tag = archivo
                nodoPadre.Nodes.Add(nodo)
            Next
        Catch ex As Exception
            ' Manejar cualquier error que pueda ocurrir
            MessageBox.Show("Error al acceder al directorio: " & ex.Message)
        End Try
    End Sub

    Private Sub CambioDeNominaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambioDeNominaToolStripMenuItem.Click
        cambioDirectorioNomina()
    End Sub

    Public Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim ruta As String = e.Node.FullPath
        MsgBox("La ruta seleccionada es: " & ruta)
    End Sub
End Class