Public Class Form1

    Private Datenbank As New AccountDatenbank

    Private stBenutzername As String
    Private stPasswort As String
    Private stNeuBenutzername As String
    Private stNeuPasswort As String
    Private stNeuPasswortWdh As String

    Private Sub btnAnmelden_Click() Handles btnAnmelden.Click

        If Not Datenbank.AccountExistiert(stBenutzername) Then

            MsgBox("Account " & stBenutzername & " existiert nicht.")

        ElseIf Not Datenbank.RichtigesPasswort(stBenutzername, stPasswort) Then

            MsgBox("Passwort ist falsch.")

        Else

            MsgBox("Anmeldung erflogreich.")

        End If

    End Sub

    Private Sub btnRegistrieren_Click() Handles btnRegistrieren.Click

        If Datenbank.AccountExistiert(stNeuBenutzername) Then

            MsgBox("Account " & stNeuBenutzername & " existiert schon.")

        ElseIf Not PasswörterGleich(stNeuPasswort, stNeuPasswortWdh) Then

            MsgBox("Passwörter sind nicht gleich.")

        Else

            Datenbank.AccountErstellen(stNeuBenutzername, stNeuPasswort)
            MsgBox("Account " & stNeuBenutzername & " erfolgreich registriert.")

        End If

    End Sub

    Private Function PasswörterGleich(Passwort1 As String, Passwort2 As String) As Boolean

        Return Passwort1.Equals(Passwort2)

    End Function

    Private Sub txtBenutzername_TextChanged(sender As Object, e As EventArgs) Handles txtBenutzername.TextChanged
        stBenutzername = txtBenutzername.Text
    End Sub

    Private Sub txtPasswort_TextChanged(sender As Object, e As EventArgs) Handles txtPasswort.TextChanged
        stPasswort = txtPasswort.Text
    End Sub

    Private Sub txtNeuBenutzername_TextChanged(sender As Object, e As EventArgs) Handles txtNeuBenutzername.TextChanged
        stNeuBenutzername = txtNeuBenutzername.Text
    End Sub

    Private Sub txtNeuPasswort_TextChanged(sender As Object, e As EventArgs) Handles txtNeuPasswort.TextChanged
        stNeuPasswort = txtNeuPasswort.Text
    End Sub

    Private Sub txtNeuPasswortWiederholen_TextChanged(sender As Object, e As EventArgs) Handles txtNeuPasswortWiederholen.TextChanged
        stNeuPasswortWdh = txtNeuPasswortWiederholen.Text
    End Sub

End Class
