
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            ' Ouvrir la deuxième interface (Form2)
            Dim form2 As New Form2()
            form2.Show()
            Me.Hide() ' Masquer Form1
        ElseIf RadioButton2.Checked Then
            ' Ouvrir la troisième interface (Form3)
            Dim form3 As New Form3()
            form3.Show()
            Me.Hide() ' Masquer Form1
        Else
            MessageBox.Show("Veuillez sélectionner une option.")
        End If
    End Sub
End Class
