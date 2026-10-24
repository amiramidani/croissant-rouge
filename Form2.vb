Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Définir le chemin du fichier où les données seront enregistrées
        Dim dossier As String = "C:\projet"
        Dim fichier As String = Path.Combine(dossier, "Inscription.txt")

        ' Vérifiez si le dossier existe, sinon créez-le
        If Not Directory.Exists(dossier) Then
            Directory.CreateDirectory(dossier)
        End If

        ' Récupérer les données des champs du formulaire
        Dim nom As String = TextBox1.Text
        Dim prenom As String = TextBox2.Text
        Dim ncin As String = TextBox5.Text
        Dim adresse As String = TextBox6.Text
        Dim telephone As String = TextBox3.Text
        Dim dateNaissance As String = DateTimePicker1.Text
        Dim nombreEnfants As String = TextBox4.Text
        Dim etatCivil As String = TextBox7.Text

        ' Vérifiez que tous les champs obligatoires sont remplis
        If String.IsNullOrWhiteSpace(nom) OrElse
   String.IsNullOrWhiteSpace(prenom) OrElse
   String.IsNullOrWhiteSpace(ncin) OrElse
   String.IsNullOrWhiteSpace(adresse) OrElse
   String.IsNullOrWhiteSpace(telephone) OrElse
   String.IsNullOrWhiteSpace(nombreEnfants) OrElse
   String.IsNullOrWhiteSpace(etatCivil) Then
            MessageBox.Show("All required fields must be completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        ' Vérification que le NCIN et le téléphone ont une longueur de 8 chiffres
        If ncin.Length <> 8 OrElse Not IsNumeric(ncin) Then
            MessageBox.Show("NCIN must be 8 digits long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If telephone.Length <> 8 OrElse Not IsNumeric(telephone) Then
            MessageBox.Show("Phone number must be 8 digits long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Format des données à enregistrer
        Dim lignes As String = $"last name : {nom}{Environment.NewLine}" &
                               $"first name : {prenom}{Environment.NewLine}" &
                               $"NCIN : {ncin}{Environment.NewLine}" &
                               $"Adresse : {adresse}{Environment.NewLine}" &
                               $"phone number : {telephone}{Environment.NewLine}" &
                               $"birthday date : {dateNaissance}{Environment.NewLine}" &
                               $"children number : {nombreEnfants}{Environment.NewLine}" &
                               $"civil statu : {etatCivil}{Environment.NewLine}" &
                               "---------------------------------------" & Environment.NewLine

        ' Ajouter les données dans le fichier texte
        File.AppendAllText(fichier, lignes)

        ' Message de confirmation
        MessageBox.Show("Data was saved successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Réinitialiser les champs
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        DateTimePicker1.Value = DateTime.Now
        TextBox7.Clear()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Vérifiez si le formulaire Form1 existe déjà
        Dim form3 As New Form3

        ' Afficher Form1
        form3.Show()

        ' Masquer le formulaire actuel (Form2)
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Vérifiez si le formulaire Form1 existe déjà
        Dim form1 As New Form1

        ' Afficher Form1
        form1.Show()

        ' Masquer le formulaire actuel (Form2)
        Me.Hide()
    End Sub
End Class