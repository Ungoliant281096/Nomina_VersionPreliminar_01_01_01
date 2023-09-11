<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAP_Actualizacion
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(CAP_Actualizacion))
        ProgressBar1 = New ProgressBar()
        Button1 = New Button()
        Button2 = New Button()
        Timer1 = New Timer(components)
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(21, 85)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(456, 57)
        ProgressBar1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(106, 173)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 1
        Button1.Text = "Actualizar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(273, 173)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 2
        Button2.Text = "Cerrar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ControlLight
        Label1.Location = New Point(76, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(342, 54)
        Label1.TabIndex = 3
        ' 
        ' CAP_Actualizacion
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(497, 268)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ProgressBar1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "CAP_Actualizacion"
        Text = "CAP_Actualizacion"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
End Class
