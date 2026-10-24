Imports System.IO

Public Class Form7
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'AJOUTER 
        ' Chemin du dossier et fichier
        Dim dossier As String = "C:\projet"
        Dim fichier As String = Path.Combine(dossier, "adherant.txt")
        ' Vérifiez si le dossier existe, sinon créez-le
        If Not Directory.Exists(dossier) Then
            Directory.CreateDirectory(dossier)
        End If
        ' Récupérer les données des TextBox
        Dim nom As String = TextBox1.Text
        Dim prenom As String = TextBox2.Text
        Dim telephone As String = TextBox3.Text
        Dim email As String = TextBox4.Text
        Dim action As String = TextBox5.Text
        Dim valeuraction As String = TextBox6.Text
        ' Vérification si tous les champs sont remplis
        If String.IsNullOrEmpty(nom) OrElse String.IsNullOrEmpty(prenom) OrElse String.IsNullOrEmpty(telephone) OrElse
           String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(action) OrElse String.IsNullOrEmpty(valeuraction) Then
            MessageBox.Show("Please fill in all fields before registering.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        ' Enregistrer les données dans le fichier texte
        Dim lignes As String = "last name: " & nom & ", first name: " & prenom & ", phone number: " & telephone &
                       ", Email " & email & ",  Actions: " & action & ", collected amount: " & valeuraction &
                       Environment.NewLine
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
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'AFFICHER LA LISTE 
        ' Chemin du fichier
        Dim fichier As String = "C:\projet\adherant.txt"

        ' Vérifiez si le fichier existe
        If Not File.Exists(fichier) Then
            MessageBox.Show("The data file does not exist yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Effacer la liste actuelle
        ListBox1.Items.Clear()

        ' Lire le fichier ligne par ligne et ajouter chaque ligne à la ListBox
        Dim lignes As String() = File.ReadAllLines(fichier)
        For Each ligne As String In lignes
            ListBox1.Items.Add(ligne)
        Next

        ' Message de confirmation
        MessageBox.Show("List displayed successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'CHERCHER
        ' Chemin du fichier
        Dim fichier As String = "C:\projet\adherant.txt"

        ' Vérifiez si le fichier existe
        If Not File.Exists(fichier) Then
            MessageBox.Show("The data file does not yet exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Récupérer le critère de recherche (nom uniquement dans ce cas)
        Dim critereNom As String = TextBox1.Text.Trim()

        ' Vérifier que le champ Nom n'est pas vide
        If String.IsNullOrEmpty(critereNom) Then
            MessageBox.Show("Please enter a name to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Lire le fichier ligne par ligne
        Dim lignes As String() = File.ReadAllLines(fichier)
        Dim trouve As Boolean = False

        ' Effacer la ListBox
        ListBox1.Items.Clear()

        ' Rechercher les lignes contenant le nom
        For Each ligne As String In lignes
            If ligne.Contains("last name: " & critereNom) Then
                ' Ajouter la ligne trouvée dans la ListBox
                ListBox1.Items.Add(ligne)
                trouve = True
            End If
        Next
        ' Vérifier si une personne a été trouvée
        If Not trouve Then
            MessageBox.Show("No person with this name was found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Results found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'SUPPRIMER
        ' Vérifiez si une ligne est sélectionnée
        If ListBox1.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Récupérer la ligne sélectionnée
        Dim ligneASupprimer As String = ListBox1.SelectedItem.ToString()

        ' Chemin du fichier
        Dim fichier As String = "C:\projet\adherant.txt"

        ' Vérifiez si le fichier existe
        If Not File.Exists(fichier) Then
            MessageBox.Show("Data file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Lire toutes les lignes du fichier
        Dim lignes As List(Of String) = File.ReadAllLines(fichier).ToList()

        ' Supprimer la ligne correspondante
        If lignes.Contains(ligneASupprimer) Then
            lignes.Remove(ligneASupprimer)
            ' Réécrire le fichier sans la ligne supprimée
            File.WriteAllLines(fichier, lignes)
            MessageBox.Show("The line was successfully deleted.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Mettre à jour la ListBox
            ListBox1.Items.Remove(ligneASupprimer)
        Else
            MessageBox.Show("Unable to find the line to delete in the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'MISE A JOUR 
        ' Vérifiez si une ligne est sélectionnée
        If ListBox1.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Récupérer la ligne sélectionnée
        Dim ligneAModifier As String = ListBox1.SelectedItem.ToString()

        ' Récupérer les nouvelles données des TextBox
        Dim nom As String = TextBox1.Text.Trim()
        Dim prenom As String = TextBox2.Text.Trim()
        Dim telephone As String = TextBox3.Text.Trim()
        Dim email As String = TextBox4.Text.Trim()
        Dim action As String = TextBox5.Text.Trim()
        Dim valeuraction As String = TextBox6.Text.Trim()
        ' Vérifier que tous les champs sont remplis
        If String.IsNullOrEmpty(nom) OrElse String.IsNullOrEmpty(prenom) OrElse String.IsNullOrEmpty(telephone) OrElse
           String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(action) OrElse String.IsNullOrEmpty(valeuraction) Then
            MessageBox.Show("Veuillez remplir tous les champs avant de mettre à jour.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Construire la nouvelle ligne avec les données mises à jour
        Dim nouvelleLigne As String = "last name: " & nom & ", first name: " & prenom & ", phone number: " & telephone &
                                      ", Email: " & email & ", Actions: " & action & ",collected amount: " & valeuraction
        ' Chemin du fichier
        Dim fichier As String = "C:\projet\responsables.txt"

        ' Vérifiez si le fichier existe
        If Not File.Exists(fichier) Then
            MessageBox.Show("Data file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Lire toutes les lignes du fichier
        Dim lignes As List(Of String) = File.ReadAllLines(fichier).ToList()

        ' Remplacer la ligne dans le fichier
        Dim index As Integer = lignes.IndexOf(ligneAModifier)
        If index >= 0 Then
            lignes(index) = nouvelleLigne
            ' Réécrire le fichier avec la ligne mise à jour
            File.WriteAllLines(fichier, lignes)

            ' Mettre à jour la ListBox
            ListBox1.Items(ListBox1.SelectedIndex) = nouvelleLigne

            MessageBox.Show("The line was updated successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Unable to find the line to update in the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim form4 As New Form4
        Me.Hide()
        form4.Show()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim telephone As String = TextBox3.Text.Trim()
        If telephone.Length <> 8 OrElse Not IsNumeric(telephone) Then
            MessageBox.Show("Phone number must be 8 digits long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
    End Sub
End Class