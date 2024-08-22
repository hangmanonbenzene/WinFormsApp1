Public Class Account

    Private stBenutzername As String
    Private stPasswort As String

    Public Sub New(Benutzername As String, Passwort As String)
        stBenutzername = Benutzername
        stPasswort = Passwort
    End Sub

    Public Function GetBenutername()
        Return stBenutzername
    End Function

    Public Function GetPasswort()
        Return stPasswort
    End Function

End Class
