Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            ' Ouvrir la deuxième interface (Form2)
            Dim form5 As New Form5()
            form5.Show()
            Me.Hide() ' Masquer Form1
        ElseIf RadioButton2.Checked Then
            ' Ouvrir la troisième interface (Form3)
            Dim form6 As New Form6()
            form6.Show()
            Me.Hide() ' Masquer Form1
        ElseIf RadioButton3.Checked Then
            Dim form7 As New Form7()
            form7.Show()
            Me.Hide()
        ElseIf RadioButton4.Checked Then
            Dim form8 As New Form8()
            form8.Show()
            Me.Hide()
        ElseIf RadioButton5.Checked Then
            Dim form9 As New Form9()
            form9.Show()
            Me.Hide()
        Else
            MessageBox.Show("Please select an option.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Vérifiez si le formulaire Form1 existe déjà
        Dim form3 As New Form3

        ' Afficher Form1
        form3.Show()

        ' Masquer le formulaire actuel (Form2)
        Me.Hide()
    End Sub
End Class