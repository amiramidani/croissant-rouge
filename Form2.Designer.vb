<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Button3 = New Button()
        Label7 = New Label()
        TextBox7 = New TextBox()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(196, 132)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(259, 27)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(196, 194)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(259, 27)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(219, 242)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(259, 27)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(240, 299)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(259, 27)
        TextBox4.TabIndex = 3
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(196, 349)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(259, 27)
        TextBox5.TabIndex = 4
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(583, 299)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(258, 27)
        TextBox6.TabIndex = 9
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(583, 197)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(359, 415)
        Button1.Name = "Button1"
        Button1.Size = New Size(173, 51)
        Button1.TabIndex = 11
        Button1.Text = "INSCRIPTION"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Red
        Label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(334, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(236, 46)
        Label1.TabIndex = 13
        Label1.Text = "INSCRIPTION"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Bisque
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.Location = New Point(30, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 28)
        Label2.TabIndex = 14
        Label2.Text = "LAST NAME"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Bisque
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.Location = New Point(30, 193)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 28)
        Label3.TabIndex = 15
        Label3.Text = "FIRST NAME"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Bisque
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label4.Location = New Point(30, 242)
        Label4.Name = "Label4"
        Label4.Size = New Size(173, 28)
        Label4.TabIndex = 16
        Label4.Text = "PHONE NUMBER"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Bisque
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label5.Location = New Point(30, 299)
        Label5.Name = "Label5"
        Label5.Size = New Size(202, 28)
        Label5.TabIndex = 17
        Label5.Text = "CHILDREN NUMBER"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Bisque
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label6.Location = New Point(30, 345)
        Label6.Name = "Label6"
        Label6.Size = New Size(46, 28)
        Label6.TabIndex = 18
        Label6.Text = "CIN"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Bisque
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label8.Location = New Point(565, 147)
        Label8.Name = "Label8"
        Label8.Size = New Size(167, 28)
        Label8.TabIndex = 20
        Label8.Text = "BIRTHDAY DATE"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Bisque
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label9.Location = New Point(565, 256)
        Label9.Name = "Label9"
        Label9.Size = New Size(98, 28)
        Label9.TabIndex = 21
        Label9.Text = "ADRESSE"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(714, 500)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 22
        Button3.Text = "NEXT"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Bisque
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label7.Location = New Point(565, 345)
        Label7.Name = "Label7"
        Label7.Size = New Size(114, 28)
        Label7.TabIndex = 23
        Label7.Text = "civil status"
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(583, 386)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(259, 27)
        TextBox7.TabIndex = 24
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(824, 500)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 12
        Button2.Text = "BACK"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(930, 541)
        Controls.Add(TextBox7)
        Controls.Add(Label7)
        Controls.Add(Button3)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Button2 As Button
End Class
