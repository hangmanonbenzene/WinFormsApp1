Public Class Feld

    Dim nächstesFeld As Feld
    Dim Bild As Label
    Dim feldBesetzt As Boolean

    Public Sub New(bild As Label)
        Me.Bild = bild
    End Sub

    Public Sub setFigur(figur As Figur)
        Bild.Text = figur.getFarbe
        feldBesetzt = True
    End Sub

    Public Sub removeFigur()
        Bild.Text = ""
        feldBesetzt = False
    End Sub

    Public Sub setNächstesFeld(feld As Feld)
        nächstesFeld = feld
    End Sub

    Public Function getNächstesFeld() As Feld
        Return nächstesFeld
    End Function

    Public Function getFeldBesetzt() As Boolean
        Return feldBesetzt
    End Function

End Class
