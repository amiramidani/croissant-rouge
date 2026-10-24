<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Label1 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        ListBox1 = New ListBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Red
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(85, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(662, 38)
        Label1.TabIndex = 6
        Label1.Text = "consult and update the records of people in need"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Bisque
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label9.Location = New Point(468, 156)
        Label9.Name = "Label9"
        Label9.Size = New Size(98, 28)
        Label9.TabIndex = 28
        Label9.Text = "ADRESSE"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Bisque
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label8.Location = New Point(24, 208)
        Label8.Name = "Label8"
        Label8.Size = New Size(167, 28)
        Label8.TabIndex = 27
        Label8.Text = "BIRTHDAY DATE"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Bisque
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label6.Location = New Point(468, 103)
        Label6.Name = "Label6"
        Label6.Size = New Size(46, 28)
        Label6.TabIndex = 26
        Label6.Text = "CIN"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Bisque
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label5.Location = New Point(193, 258)
        Label5.Name = "Label5"
        Label5.Size = New Size(202, 28)
        Label5.TabIndex = 25
        Label5.Text = "CHILDREN NUMBER"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Bisque
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label4.Location = New Point(468, 208)
        Label4.Name = "Label4"
        Label4.Size = New Size(173, 28)
        Label4.TabIndex = 24
        Label4.Text = "PHONE NUMBER"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Bisque
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.Location = New Point(24, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 28)
        Label3.TabIndex = 23
        Label3.Text = "FIRST NAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Bisque
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.Location = New Point(24, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 28)
        Label2.TabIndex = 22
        Label2.Text = "LAST NAME"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(173, 156)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(191, 27)
        TextBox1.TabIndex = 29
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(538, 104)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(173, 27)
        TextBox2.TabIndex = 30
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(584, 157)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(180, 27)
        TextBox3.TabIndex = 31
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(663, 209)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(165, 27)
        TextBox4.TabIndex = 32
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(173, 107)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(191, 27)
        TextBox5.TabIndex = 33
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(427, 258)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(187, 27)
        TextBox6.TabIndex = 34
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(197, 207)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 35
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(24, 362)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(490, 104)
        ListBox1.TabIndex = 40
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(24, 319)
        Button1.Name = "Button1"
        Button1.Size = New Size(174, 37)
        Button1.TabIndex = 41
        Button1.Text = "show list"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(340, 319)
        Button2.Name = "Button2"
        Button2.Size = New Size(174, 37)
        Button2.TabIndex = 42
        Button2.Text = "search"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Red
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.ButtonHighlight
        Button3.Location = New Point(538, 362)
        Button3.Name = "Button3"
        Button3.Size = New Size(174, 37)
        Button3.TabIndex = 43
        Button3.Text = "remove"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Red
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = SystemColors.ButtonHighlight
        Button4.Location = New Point(547, 416)
        Button4.Name = "Button4"
        Button4.Size = New Size(174, 37)
        Button4.TabIndex = 44
        Button4.Text = "modify"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(778, 459)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 45
        Button5.Text = "BACK"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(884, 500)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ListBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form5"
        Text = "Form5"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
