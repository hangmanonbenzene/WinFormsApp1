Public Class AccountDatenbank

    Private AccountListe As New List(Of Account)

    Public Sub AccountErstellen(Benutzername As String, Passwort As String)

        AccountListe.Add(New Account(Benutzername, Passwort))

    End Sub

    Public Function AccountExistiert(Benutzername As String) As Boolean

        For Zähler = 0 To AccountListe.Count - 1

            If Benutzername.Equals(AccountListe(Zähler).GetBenutername) Then
                Return True
            End If

        Next

        Return False

    End Function

    Public Function RichtigesPasswort(Benutzername As String, Passwort As String) As Boolean

        For Zähler = 0 To AccountListe.Count - 1

            If Benutzername.Equals(AccountListe(Zähler).GetBenutername) Then
                Return Passwort.Equals(AccountListe(Zähler).GetPasswort)
            End If

        Next

        Return False

    End Function

End Class
