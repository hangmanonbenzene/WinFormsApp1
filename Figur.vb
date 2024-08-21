Public Class Figur

    Dim Farbe As String
    Dim Feld As Feld

    Public Sub New(Farbe As String)
        Me.Farbe = Farbe
    End Sub

    Public Sub setFeld(Feld As Feld)
        If Me.Feld IsNot Nothing Then
            Me.Feld.removeFigur()
        End If
        Me.Feld = Feld
        Feld.setFigur(Me)
    End Sub

    Public Function getFeld() As Feld
        Return Feld
    End Function

    Public Function getFarbe() As String
        Return Farbe
    End Function

End Class
