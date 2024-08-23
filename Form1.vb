Public Class Form1

    Private Daten As New Datenbank

    Private Sub Speichern() Handles Button1.Click

        Dim Text As String = txtText.Text
        Dim Name As String = txtDateiname.Text

        Daten.Speichern(Name, Text)

        txtText.Text = ""
        txtDateiname.Text = ""

        If Not ltbGespeicherteDateien.Items.Contains(Name) Then
            ltbGespeicherteDateien.Items.Add(Name)
        End If

    End Sub

    Private Sub Öffnen() Handles Button2.Click

        Dim Name As String = ltbGespeicherteDateien.SelectedItem

        If Name = Nothing Then
            Exit Sub
        End If

        Dim Text As String = Daten.Öffnen(Name)

        txtDateiname.Text = Name
        txtText.Text = Text

    End Sub

End Class
