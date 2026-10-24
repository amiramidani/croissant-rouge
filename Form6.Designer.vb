<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Label1 = New Label()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        ListBox1 = New ListBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Button6 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Red
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(164, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(546, 38)
        Label1.TabIndex = 7
        Label1.Text = "consult and update the managers sheets"
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(787, 449)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 57
        Button5.Text = "BACK"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Red
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = SystemColors.ButtonHighlight
        Button4.Location = New Point(707, 406)
        Button4.Name = "Button4"
        Button4.Size = New Size(174, 37)
        Button4.TabIndex = 56
        Button4.Text = "modify"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Red
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.ButtonHighlight
        Button3.Location = New Point(707, 352)
        Button3.Name = "Button3"
        Button3.Size = New Size(174, 37)
        Button3.TabIndex = 55
        Button3.Text = "remove"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(493, 283)
        Button2.Name = "Button2"
        Button2.Size = New Size(174, 37)
        Button2.TabIndex = 54
        Button2.Text = "search"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(282, 283)
        Button1.Name = "Button1"
        Button1.Size = New Size(174, 37)
        Button1.TabIndex = 53
        Button1.Text = "show list"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(61, 352)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(606, 104)
        ListBox1.TabIndex = 52
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(182, 97)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(191, 27)
        TextBox5.TabIndex = 51
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(251, 199)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(165, 27)
        TextBox4.TabIndex = 50
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(182, 146)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(191, 27)
        TextBox1.TabIndex = 49
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Bisque
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label4.Location = New Point(34, 199)
        Label4.Name = "Label4"
        Label4.Size = New Size(173, 28)
        Label4.TabIndex = 48
        Label4.Text = "PHONE NUMBER"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Bisque
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.Location = New Point(33, 146)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 28)
        Label3.TabIndex = 47
        Label3.Text = "FIRST NAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Bisque
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.Location = New Point(33, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 28)
        Label2.TabIndex = 46
        Label2.Text = "LAST NAME"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(547, 97)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(191, 27)
        TextBox2.TabIndex = 61
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(547, 147)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(191, 27)
        TextBox3.TabIndex = 60
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Bisque
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label5.Location = New Point(443, 142)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 28)
        Label5.TabIndex = 59
        Label5.Text = "POST"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Bisque
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label6.Location = New Point(443, 89)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 28)
        Label6.TabIndex = 58
        Label6.Text = "E-MAIL"
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Red
        Button6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = SystemColors.ButtonHighlight
        Button6.Location = New Point(73, 283)
        Button6.Name = "Button6"
        Button6.Size = New Size(174, 37)
        Button6.TabIndex = 62
        Button6.Text = "add"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(928, 506)
        Controls.Add(Button6)
        Controls.Add(TextBox2)
        Controls.Add(TextBox3)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ListBox1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form6"
        Text = "Form6"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button6 As Button
End Class
