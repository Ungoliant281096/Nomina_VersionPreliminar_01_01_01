<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAP_ArchivosPdf
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        ListBox1 = New ListBox()
        VScrollBar1 = New VScrollBar()
        Button1 = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(831, 27)
        TextBox1.TabIndex = 0
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 20
        ListBox1.Location = New Point(19, 68)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(188, 584)
        ListBox1.TabIndex = 1
        ' 
        ' VScrollBar1
        ' 
        VScrollBar1.Location = New Point(916, 4)
        VScrollBar1.Name = "VScrollBar1"
        VScrollBar1.Size = New Size(15, 709)
        VScrollBar1.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(19, 672)
        Button1.Name = "Button1"
        Button1.Size = New Size(188, 27)
        Button1.TabIndex = 3
        Button1.Text = "Agregar archivos"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(230, 68)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(667, 673)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' CAP_ArchivosPdf
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(932, 765)
        Controls.Add(PictureBox1)
        Controls.Add(Button1)
        Controls.Add(VScrollBar1)
        Controls.Add(ListBox1)
        Controls.Add(TextBox1)
        Name = "CAP_ArchivosPdf"
        Text = "CAP_ArchivosPdf"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBox1 As PictureBox
End Class
