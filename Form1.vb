Public Class Form1
    Dim stName As String = "admin"
    Dim stPassword As String = "12345"



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stBenutzername As String
        Dim stPasswort As String
        Dim iCount As Integer

        Do
            iCount += 1

            stBenutzername = InputBox("Benutzername einegeben")
            stPasswort = InputBox("Passwort eingeben")

            If stBenutzername <> stName Or stPasswort <> stPassword Then

                MsgBox("Benutzername oder Passwort falsch")

            End If

            If iCount >= 3 Then

                MsgBox("Account blockiert")
                Exit Sub
            End If

        Loop While stBenutzername <> stName Or stPasswort <> stPassword

        MsgBox("Anmeldung erfolgreich")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim stBenutzername As String
        Dim stPasswort As String

        For iCount = 0 To 2

            stBenutzername = InputBox("Benutzername einegeben")
            stPasswort = InputBox("Passwort eingeben")

            If stBenutzername <> stName Or stPasswort <> stPassword Then

                MsgBox("Benutzername oder Passwort falsch")

            ElseIf stBenutzername = stName And stPasswort = stPassword Then

                MsgBox("Anmeldung erfolgreich")
                Exit Sub

            End If

        Next

        MsgBox("Account blockiert")

    End Sub

End Class