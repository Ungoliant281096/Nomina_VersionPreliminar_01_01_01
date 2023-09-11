<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENÚ
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MENÚ))
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(189, 154)
        Button1.Name = "Button1"
        Button1.Size = New Size(146, 139)
        Button1.TabIndex = 0
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(431, 154)
        Button2.Name = "Button2"
        Button2.Size = New Size(146, 139)
        Button2.TabIndex = 1
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.Location = New Point(653, 342)
        Button3.Name = "Button3"
        Button3.Size = New Size(123, 73)
        Button3.TabIndex = 2
        Button3.UseVisualStyleBackColor = True
        ' 
        ' MENÚ
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "MENÚ"
        Text = "MENÚ"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
