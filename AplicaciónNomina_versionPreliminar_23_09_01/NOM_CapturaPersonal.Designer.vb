<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NOM_CapturaPersonal
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
        Label7 = New Label()
        Label8 = New Label()
        Label13 = New Label()
        Label15 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        TextBox10 = New TextBox()
        TextBox11 = New TextBox()
        TextBox12 = New TextBox()
        TextBox13 = New TextBox()
        TextBox14 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        DateTimePicker1 = New DateTimePicker()
        GroupBox3 = New GroupBox()
        TextBox6 = New TextBox()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(6, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(31, 27)
        Label1.TabIndex = 0
        Label1.Text = "Id:"
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(3, 61)
        Label7.Name = "Label7"
        Label7.Size = New Size(135, 29)
        Label7.TabIndex = 6
        Label7.Text = "FECHA INGRESO:" & vbCrLf
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(310, 56)
        Label8.Name = "Label8"
        Label8.Size = New Size(134, 29)
        Label8.TabIndex = 7
        Label8.Text = "FECHA DE BAJA :"
        ' 
        ' Label13
        ' 
        Label13.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(6, 193)
        Label13.Name = "Label13"
        Label13.Size = New Size(92, 60)
        Label13.TabIndex = 12
        Label13.Text = "Obra: num, " & vbCrLf & "porcentaje" & vbCrLf & " (100%):"
        ' 
        ' Label15
        ' 
        Label15.BackColor = Color.Gold
        Label15.Location = New Point(33, 60)
        Label15.Name = "Label15"
        Label15.Size = New Size(59, 27)
        Label15.TabIndex = 14
        ' 
        ' TextBox1
        ' 
        TextBox1.CharacterCasing = CharacterCasing.Upper
        TextBox1.Cursor = Cursors.IBeam
        TextBox1.Location = New Point(310, 62)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "RFC"
        TextBox1.Size = New Size(289, 27)
        TextBox1.TabIndex = 15
        ' 
        ' TextBox2
        ' 
        TextBox2.CharacterCasing = CharacterCasing.Upper
        TextBox2.Cursor = Cursors.IBeam
        TextBox2.Location = New Point(6, 106)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "CURP"
        TextBox2.Size = New Size(289, 27)
        TextBox2.TabIndex = 16
        ' 
        ' TextBox3
        ' 
        TextBox3.CharacterCasing = CharacterCasing.Upper
        TextBox3.Cursor = Cursors.IBeam
        TextBox3.Location = New Point(310, 106)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "NOMBRE"
        TextBox3.Size = New Size(291, 27)
        TextBox3.TabIndex = 17
        ' 
        ' TextBox4
        ' 
        TextBox4.CharacterCasing = CharacterCasing.Upper
        TextBox4.Cursor = Cursors.IBeam
        TextBox4.Location = New Point(6, 152)
        TextBox4.Name = "TextBox4"
        TextBox4.PlaceholderText = "APELLIDO PATERNO"
        TextBox4.Size = New Size(289, 27)
        TextBox4.TabIndex = 18
        ' 
        ' TextBox5
        ' 
        TextBox5.CharacterCasing = CharacterCasing.Upper
        TextBox5.Cursor = Cursors.IBeam
        TextBox5.Location = New Point(310, 152)
        TextBox5.Name = "TextBox5"
        TextBox5.PlaceholderText = "APELLIDO MATERNO"
        TextBox5.Size = New Size(291, 27)
        TextBox5.TabIndex = 19
        ' 
        ' TextBox8
        ' 
        TextBox8.Cursor = Cursors.IBeam
        TextBox8.Location = New Point(6, 103)
        TextBox8.Name = "TextBox8"
        TextBox8.PlaceholderText = "Ingreso diario normal"
        TextBox8.Size = New Size(289, 27)
        TextBox8.TabIndex = 22
        ' 
        ' TextBox9
        ' 
        TextBox9.Cursor = Cursors.IBeam
        TextBox9.Location = New Point(310, 103)
        TextBox9.Name = "TextBox9"
        TextBox9.PlaceholderText = "Viáticos diarios"
        TextBox9.Size = New Size(289, 27)
        TextBox9.TabIndex = 23
        ' 
        ' TextBox10
        ' 
        TextBox10.Cursor = Cursors.IBeam
        TextBox10.Location = New Point(6, 143)
        TextBox10.Name = "TextBox10"
        TextBox10.PlaceholderText = "Otros diarios"
        TextBox10.Size = New Size(289, 27)
        TextBox10.TabIndex = 24
        ' 
        ' TextBox11
        ' 
        TextBox11.Cursor = Cursors.IBeam
        TextBox11.Location = New Point(310, 143)
        TextBox11.Name = "TextBox11"
        TextBox11.PlaceholderText = "Registro  IMSS"
        TextBox11.Size = New Size(289, 27)
        TextBox11.TabIndex = 25
        ' 
        ' TextBox12
        ' 
        TextBox12.Cursor = Cursors.IBeam
        TextBox12.Location = New Point(115, 193)
        TextBox12.Name = "TextBox12"
        TextBox12.PlaceholderText = "Obra"
        TextBox12.Size = New Size(95, 27)
        TextBox12.TabIndex = 26
        ' 
        ' TextBox13
        ' 
        TextBox13.Cursor = Cursors.IBeam
        TextBox13.Location = New Point(115, 226)
        TextBox13.Name = "TextBox13"
        TextBox13.PlaceholderText = "%"
        TextBox13.Size = New Size(95, 27)
        TextBox13.TabIndex = 27
        ' 
        ' TextBox14
        ' 
        TextBox14.Cursor = Cursors.IBeam
        TextBox14.Location = New Point(310, 188)
        TextBox14.Name = "TextBox14"
        TextBox14.PlaceholderText = "Salario Diario Integrado"
        TextBox14.Size = New Size(289, 27)
        TextBox14.TabIndex = 28
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(386, 573)
        Button1.Name = "Button1"
        Button1.Size = New Size(233, 46)
        Button1.TabIndex = 29
        Button1.Text = "ARCHIVAR"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(170, 573)
        Button2.Name = "Button2"
        Button2.Size = New Size(102, 46)
        Button2.TabIndex = 30
        Button2.Text = "SALIDA"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(278, 573)
        Button3.Name = "Button3"
        Button3.Size = New Size(102, 46)
        Button3.TabIndex = 31
        Button3.Text = "LIMPIAR"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.Location = New Point(12, 505)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(607, 47)
        GroupBox1.TabIndex = 32
        GroupBox1.TabStop = False
        GroupBox1.Text = "ANTERIOR"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(TextBox5)
        GroupBox2.Controls.Add(TextBox4)
        GroupBox2.Controls.Add(TextBox3)
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.Controls.Add(TextBox1)
        GroupBox2.Controls.Add(Label15)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Location = New Point(12, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(607, 197)
        GroupBox2.TabIndex = 33
        GroupBox2.TabStop = False
        GroupBox2.Text = "Datos personales"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(144, 54)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(128, 27)
        DateTimePicker1.TabIndex = 34
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(TextBox6)
        GroupBox3.Controls.Add(DateTimePicker1)
        GroupBox3.Controls.Add(TextBox14)
        GroupBox3.Controls.Add(TextBox13)
        GroupBox3.Controls.Add(TextBox12)
        GroupBox3.Controls.Add(TextBox11)
        GroupBox3.Controls.Add(TextBox10)
        GroupBox3.Controls.Add(Label13)
        GroupBox3.Controls.Add(TextBox9)
        GroupBox3.Controls.Add(TextBox8)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Location = New Point(12, 226)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(607, 273)
        GroupBox3.TabIndex = 35
        GroupBox3.TabStop = False
        GroupBox3.Text = "Datos empleado"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(450, 54)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(149, 27)
        TextBox6.TabIndex = 35
        ' 
        ' NOM_CapturaPersonal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(641, 639)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "NOM_CapturaPersonal"
        Text = "NOM_CapturaPersonal"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox6 As TextBox
End Class
