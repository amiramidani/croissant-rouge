Imports System.IO

Public Class Form9

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' Chemins des fichiers
        Dim dossier As String = "C:\projet"
        Dim fichierAdherants As String = Path.Combine(dossier, "adherant.txt")
        Dim fichierDonneurs As String = Path.Combine(dossier, "donneurs.txt")

        Dim sommeAdherants As Double = 0
        Dim sommeDonneurs As Double = 0

        ' Vérifiez si le fichier "adherants.txt" existe
        If File.Exists(fichierAdherants) Then
            ' Lire les lignes du fichier "adherants.txt"
            Dim lignesAdherants As String() = File.ReadAllLines(fichierAdherants)
            For Each ligne In lignesAdherants
                ' Trouver la partie "Valeur collecté:"
                If ligne.Contains("Value collected:") Then
                    Dim montantStr As String = ligne.Split("Value collected:")(1).Trim()
                    MessageBox.Show("Amount collected found : " & montantStr)
                    Dim montant As Double
                    If Double.TryParse(montantStr, montant) Then
                        sommeAdherants += montant
                    End If
                End If
            Next
        Else
            MessageBox.Show("The file adherents.txt does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Vérifiez si le fichier "donneurs.txt" existe
        If File.Exists(fichierDonneurs) Then
            ' Lire les lignes du fichier "donneurs.txt"
            Dim lignesDonneurs As String() = File.ReadAllLines(fichierDonneurs)
            For Each ligne In lignesDonneurs
                ' Trouver la partie "La valeur de don:"
                If ligne.Contains("The value of the donation:") Then
                    Dim valeurStr As String = ligne.Split("La valeur du don:")(1).Trim()
                    MessageBox.Show("Donation value found: " & valeurStr)
                    Dim valeur As Double
                    If Double.TryParse(valeurStr, valeur) Then
                        sommeDonneurs += valeur
                    End If
                End If
            Next
        Else
            MessageBox.Show("The file donors.txt does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Calculer la somme totale
        Dim sommeTotale As Double = sommeAdherants + sommeDonneurs
        ' Afficher la somme dans le Label ou TextBox "Montant"
        Label3.Text = "amount = " & sommeTotale.ToString("F2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Vérifiez si le formulaire Form1 existe déjà
        Dim form1 As New Form1

        ' Afficher Form1
        form1.Show()

        ' Masquer le formulaire actuel (Form9)
        Me.Hide()
    End Sub
End Class