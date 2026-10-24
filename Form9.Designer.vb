<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Label1 = New Label()
        Label2 = New Label()
        Button6 = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Button5 = New Button()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Red
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(187, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(412, 38)
        Label1.TabIndex = 84
        Label1.Text = "ACCOUNTING MANAGEMENT"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Bisque
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.Location = New Point(76, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(716, 28)
        Label2.TabIndex = 85
        Label2.Text = "THE SUM OF THE AMOUNTS COLLECTED FROM ACTIONS AND DONATION"
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Red
        Button6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = SystemColors.ButtonHighlight
        Button6.Location = New Point(311, 175)
        Button6.Name = "Button6"
        Button6.Size = New Size(174, 37)
        Button6.TabIndex = 103
        Button6.Text = "calculate"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Bisque
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.Location = New Point(78, 222)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 28)
        Label3.TabIndex = 104
        Label3.Text = "the amount ="
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(270, 229)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 20)
        Label4.TabIndex = 105
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(752, 420)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 106
        Button5.Text = "BACK"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Red
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(120, 336)
        Label5.Name = "Label5"
        Label5.Size = New Size(609, 56)
        Label5.TabIndex = 107
        Label5.Text = "وَإِن كَانَ ذُو عُسۡرَةٖ فَنَظِرَةٌ إِلَىٰ مَيۡسَرَةٖۚ وَأَن تَصَدَّقُواْ خَيۡرٞ لَّكُمۡ إِن كُنتُمۡ تَعۡلَمُون""َ" & vbCrLf & """"
        ' 
        ' Form9
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(873, 472)
        Controls.Add(Label5)
        Controls.Add(Button5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Button6)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form9"
        Text = "Form9"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label5 As Label
End Class
