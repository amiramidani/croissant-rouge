Public Class Form3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim form1 As New Form1


        form1.Show()


        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Validate the email address format
        Dim email As String = TextBox1.Text
        If Not (email.Contains("@") AndAlso email.Contains(".")) Then
            MsgBox("Adresse email invalide", vbCritical, "Attention!")
            TextBox1.Focus()
            Return
        End If

        ' Validate the password length and content
        Dim password As String = TextBox2.Text
        If password.Length < 6 OrElse password <> "bonjour" Then
            MsgBox("Mot de passe invalide", vbCritical, "Attention!")
            TextBox2.Focus()
            Return
        End If

        ' Check the specific user credentials
        If email = "eyabah1@gmail.com" AndAlso password = "bonjour" Then
            Form4.Show()
            Me.Hide()
        Else
            MsgBox("Adresse ou mot de passe incorrect", vbCritical, "Attention!")
            TextBox1.Focus()
        End If
    End Sub
End Class