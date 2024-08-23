Public Class Datenbank

    Private DateienListe As New List(Of Datei)

    Public Sub Speichern(Name As String, Text As String)

        Dim PositionInListe As Integer = WoInListe(Name)

        If PositionInListe >= 0 Then
            DateienListe.ElementAt(PositionInListe).SetText(Text)
        Else
            DateienListe.Add(New Datei(Name, Text))
        End If

    End Sub

    Public Function Öffnen(Name As String) As String

        Dim PositionInListe As Integer = WoInListe(Name)

        If PositionInListe >= 0 Then
            Return DateienListe.ElementAt(PositionInListe).GetText()
        Else
            Return ""
        End If

    End Function

    Private Function WoInListe(Name As String) As Integer

        For Zähler = 0 To DateienListe.Count - 1

            If Name.Equals(DateienListe.ElementAt(Zähler).GetName) Then

                Return Zähler

            End If

        Next

        Return -1

    End Function

End Class
