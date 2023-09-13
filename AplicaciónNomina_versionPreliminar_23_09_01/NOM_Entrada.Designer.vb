<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NOM_Entrada
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
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.AppWorkspace
        Label1.Location = New Point(37, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(164, 74)
        Label1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(260, 33)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 1
        Button1.Text = "Aceptar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(260, 78)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 2
        Button2.Text = "Cancelar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(37, 152)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(347, 27)
        TextBox1.TabIndex = 3
        ' 
        ' NOM_Entrada
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(425, 207)
        Controls.Add(TextBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "NOM_Entrada"
        Text = "NOM_Entrada"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
