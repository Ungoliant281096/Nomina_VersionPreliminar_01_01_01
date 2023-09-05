<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NOM_DatosComplementarios
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
        MenuStrip1 = New MenuStrip()
        ArchivoToolStripMenuItem = New ToolStripMenuItem()
        GuardarToolStripMenuItem = New ToolStripMenuItem()
        SalidaToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        TextBox10 = New TextBox()
        TextBox11 = New TextBox()
        CheckBox1 = New CheckBox()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {GuardarToolStripMenuItem, SalidaToolStripMenuItem})
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(73, 24)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' GuardarToolStripMenuItem
        ' 
        GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        GuardarToolStripMenuItem.Size = New Size(224, 26)
        GuardarToolStripMenuItem.Text = "Guardar"
        ' 
        ' SalidaToolStripMenuItem
        ' 
        SalidaToolStripMenuItem.Name = "SalidaToolStripMenuItem"
        SalidaToolStripMenuItem.Size = New Size(224, 26)
        SalidaToolStripMenuItem.Text = "Salida"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(99, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 20)
        Label1.TabIndex = 1
        Label1.Text = "RFC Empresa:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(122, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 20)
        Label2.TabIndex = 2
        Label2.Text = "Dirección:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(10, 167)
        Label3.Name = "Label3"
        Label3.Size = New Size(187, 40)
        Label3.TabIndex = 3
        Label3.Text = "Representate Legal A. " & vbCrLf & "Paterno, Materno, Nombre:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(81, 244)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 20)
        Label4.TabIndex = 4
        Label4.Text = "RFC Rep. Legal:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(75, 300)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 20)
        Label5.TabIndex = 5
        Label5.Text = "Curp Rep. Legal:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(43, 341)
        Label6.Name = "Label6"
        Label6.Size = New Size(154, 40)
        Label6.TabIndex = 6
        Label6.Text = "No. Cta Banamex," & vbCrLf & "Sucursal, No y Cliente."
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(235, 67)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(181, 27)
        TextBox1.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(235, 125)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(516, 27)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(235, 180)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(157, 27)
        TextBox3.TabIndex = 9
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(414, 180)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(157, 27)
        TextBox4.TabIndex = 10
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(594, 180)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(157, 27)
        TextBox5.TabIndex = 11
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(235, 241)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(157, 27)
        TextBox6.TabIndex = 12
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(235, 297)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(157, 27)
        TextBox8.TabIndex = 14
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(235, 354)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(127, 27)
        TextBox9.TabIndex = 15
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(398, 354)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(125, 27)
        TextBox10.TabIndex = 16
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(557, 354)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(125, 27)
        TextBox11.TabIndex = 17
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Yellow
        CheckBox1.Location = New Point(414, 244)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(216, 24)
        CheckBox1.TabIndex = 18
        CheckBox1.Text = "Pago 2da. Quincena 16 días."
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' NOM_DatosComplementarios
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(CheckBox1)
        Controls.Add(TextBox11)
        Controls.Add(TextBox10)
        Controls.Add(TextBox9)
        Controls.Add(TextBox8)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "NOM_DatosComplementarios"
        Text = "NOM_DatosComplementarios"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
