<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NOM_ExentosGravados
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
        EdiciónToolStripMenuItem = New ToolStripMenuItem()
        RevisarToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        TextBox1 = New TextBox()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        VScrollBar1 = New VScrollBar()
        HScrollBar1 = New HScrollBar()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem, EdiciónToolStripMenuItem, RevisarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1031, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(73, 24)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' EdiciónToolStripMenuItem
        ' 
        EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        EdiciónToolStripMenuItem.Size = New Size(62, 24)
        EdiciónToolStripMenuItem.Text = "Editar"
        ' 
        ' RevisarToolStripMenuItem
        ' 
        RevisarToolStripMenuItem.Name = "RevisarToolStripMenuItem"
        RevisarToolStripMenuItem.Size = New Size(70, 24)
        RevisarToolStripMenuItem.Text = "Revisar"
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ActiveBorder
        Label1.Location = New Point(25, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 39)
        Label1.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(149, 61)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(456, 27)
        TextBox1.TabIndex = 2
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(25, 122)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(994, 335)
        DataGridView1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonShadow
        Button1.Location = New Point(856, 49)
        Button1.Name = "Button1"
        Button1.Size = New Size(101, 35)
        Button1.TabIndex = 4
        Button1.Text = "Guardar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' VScrollBar1
        ' 
        VScrollBar1.Location = New Point(1014, 28)
        VScrollBar1.Name = "VScrollBar1"
        VScrollBar1.Size = New Size(17, 578)
        VScrollBar1.TabIndex = 5
        ' 
        ' HScrollBar1
        ' 
        HScrollBar1.Location = New Point(4, 586)
        HScrollBar1.Name = "HScrollBar1"
        HScrollBar1.Size = New Size(1010, 20)
        HScrollBar1.TabIndex = 6
        ' 
        ' NOM_ExentosGravados
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1031, 491)
        Controls.Add(HScrollBar1)
        Controls.Add(VScrollBar1)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "NOM_ExentosGravados"
        Text = "NOM_ExentosGravados"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RevisarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents HScrollBar1 As HScrollBar
End Class
