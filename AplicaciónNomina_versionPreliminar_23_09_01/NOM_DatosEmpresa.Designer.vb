<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NOM_DatosEmpresa
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
        EmpresaToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TextBox4 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        TextBox5 = New TextBox()
        Button1 = New Button()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {EmpresaToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(709, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' EmpresaToolStripMenuItem
        ' 
        EmpresaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SalirToolStripMenuItem})
        EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        EmpresaToolStripMenuItem.Size = New Size(80, 24)
        EmpresaToolStripMenuItem.Text = "Empresa"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(224, 26)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(35, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 35)
        Label1.TabIndex = 1
        Label1.Text = "Empresa:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(35, 78)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(405, 27)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(549, 120)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(549, 193)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(466, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 28)
        Label2.TabIndex = 5
        Label2.Text = "Año:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(380, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(150, 56)
        Label3.TabIndex = 6
        Label3.Text = "Salario Minímo " & vbCrLf & "            Vigente:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(549, 261)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(125, 27)
        TextBox4.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(314, 242)
        Label4.Name = "Label4"
        Label4.Size = New Size(216, 56)
        Label4.TabIndex = 8
        Label4.Text = "Porcentaje de Subsidio " & vbCrLf & "                         Vigente:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(369, 326)
        Label5.Name = "Label5"
        Label5.Size = New Size(161, 56)
        Label5.TabIndex = 9
        Label5.Text = "Fecha del ultimo " & vbCrLf & "               cambio:"
        ' 
        ' TextBox5
        ' 
        TextBox5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        TextBox5.Location = New Point(549, 330)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(125, 27)
        TextBox5.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button1.Location = New Point(186, 402)
        Button1.Name = "Button1"
        Button1.Size = New Size(309, 80)
        Button1.TabIndex = 11
        Button1.Text = "Archivar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' NOM_DatosEmpresa
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(709, 520)
        Controls.Add(Button1)
        Controls.Add(TextBox5)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TextBox4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "NOM_DatosEmpresa"
        Text = "NOM_DatosEmpresa"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
End Class
