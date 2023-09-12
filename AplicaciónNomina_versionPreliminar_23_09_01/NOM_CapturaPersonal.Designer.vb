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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(6, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(3, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 29)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "FECHA INGRESO:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(310, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 29)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "FECHA DE BAJA :"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(6, 193)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 60)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Obra: num, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "porcentaje" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " (100%):"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Gold
        Me.Label15.Location = New System.Drawing.Point(33, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 27)
        Me.Label15.TabIndex = 14
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox1.Location = New System.Drawing.Point(310, 62)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PlaceholderText = "RFC"
        Me.TextBox1.Size = New System.Drawing.Size(289, 27)
        Me.TextBox1.TabIndex = 15
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox2.Location = New System.Drawing.Point(6, 106)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PlaceholderText = "CURP"
        Me.TextBox2.Size = New System.Drawing.Size(289, 27)
        Me.TextBox2.TabIndex = 16
        '
        'TextBox3
        '
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox3.Location = New System.Drawing.Point(310, 106)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PlaceholderText = "NOMBRE"
        Me.TextBox3.Size = New System.Drawing.Size(291, 27)
        Me.TextBox3.TabIndex = 17
        '
        'TextBox4
        '
        Me.TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox4.Location = New System.Drawing.Point(6, 152)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.PlaceholderText = "APELLIDO PATERNO"
        Me.TextBox4.Size = New System.Drawing.Size(289, 27)
        Me.TextBox4.TabIndex = 18
        '
        'TextBox5
        '
        Me.TextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox5.Location = New System.Drawing.Point(310, 152)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.PlaceholderText = "APELLIDO MATERNO"
        Me.TextBox5.Size = New System.Drawing.Size(291, 27)
        Me.TextBox5.TabIndex = 19
        '
        'TextBox8
        '
        Me.TextBox8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox8.Location = New System.Drawing.Point(6, 103)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.PlaceholderText = "Ingreso diario normal"
        Me.TextBox8.Size = New System.Drawing.Size(289, 27)
        Me.TextBox8.TabIndex = 22
        '
        'TextBox9
        '
        Me.TextBox9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox9.Location = New System.Drawing.Point(310, 103)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.PlaceholderText = "Viáticos diarios"
        Me.TextBox9.Size = New System.Drawing.Size(289, 27)
        Me.TextBox9.TabIndex = 23
        '
        'TextBox10
        '
        Me.TextBox10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox10.Location = New System.Drawing.Point(6, 143)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.PlaceholderText = "Otros diarios"
        Me.TextBox10.Size = New System.Drawing.Size(289, 27)
        Me.TextBox10.TabIndex = 24
        '
        'TextBox11
        '
        Me.TextBox11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox11.Location = New System.Drawing.Point(310, 143)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.PlaceholderText = "Registro  IMSS"
        Me.TextBox11.Size = New System.Drawing.Size(289, 27)
        Me.TextBox11.TabIndex = 25
        '
        'TextBox12
        '
        Me.TextBox12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox12.Location = New System.Drawing.Point(115, 193)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.PlaceholderText = "Obra"
        Me.TextBox12.Size = New System.Drawing.Size(95, 27)
        Me.TextBox12.TabIndex = 26
        '
        'TextBox13
        '
        Me.TextBox13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox13.Location = New System.Drawing.Point(115, 226)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.PlaceholderText = "%"
        Me.TextBox13.Size = New System.Drawing.Size(95, 27)
        Me.TextBox13.TabIndex = 27
        '
        'TextBox14
        '
        Me.TextBox14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox14.Location = New System.Drawing.Point(310, 188)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.PlaceholderText = "Salario Diario Integrado"
        Me.TextBox14.Size = New System.Drawing.Size(289, 27)
        Me.TextBox14.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(386, 573)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(233, 46)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "ARCHIVAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(170, 573)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 46)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "SALIDA"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(278, 573)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 46)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "LIMPIAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 505)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(607, 47)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ANTERIOR"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(607, 197)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos personales"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(144, 54)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(128, 27)
        Me.DateTimePicker1.TabIndex = 34
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox6)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(Me.TextBox14)
        Me.GroupBox3.Controls.Add(Me.TextBox13)
        Me.GroupBox3.Controls.Add(Me.TextBox12)
        Me.GroupBox3.Controls.Add(Me.TextBox11)
        Me.GroupBox3.Controls.Add(Me.TextBox10)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.TextBox9)
        Me.GroupBox3.Controls.Add(Me.TextBox8)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 226)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(607, 273)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos empleado"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(450, 54)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(149, 27)
        Me.TextBox6.TabIndex = 35
        '
        'NOM_CapturaPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 639)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "NOM_CapturaPersonal"
        Me.Text = "NOM_CapturaPersonal"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

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
