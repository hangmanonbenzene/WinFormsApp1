Public Class Form1

    Private Daten As New Datenbank

    Private Sub Speichern() Handles Button1.Click

        Dim Text As String
        Dim Name As String

        Text = txtText.Text
        Name = txtDateiname.Text

        Daten.Speichern(Name, Text)

        txtText.Text = ""
        txtDateiname.Text = ""

        If Not ltbGespeicherteDateien.Items.Contains(Name) Then
            ltbGespeicherteDateien.Items.Add(Name)
        End If

    End Sub

    Private Sub Öffnen() Handles Button2.Click

    End Sub

End Class