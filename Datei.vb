Public Class Datei

    Private stName As String
    Private stText As String

    Public Sub New(Name As String, Text As String)
        stName = Name
        stText = Text
    End Sub

    Public Function GetName() As String
        Return stName
    End Function

    Public Function GetText() As String
        Return stText
    End Function

    Public Sub SetText(Text As String)
        stText = Text
    End Sub

End Class
