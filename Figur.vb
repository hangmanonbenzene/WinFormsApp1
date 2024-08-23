Public Class Figur

    Private Blickrichtung As Integer
    Private X As Integer
    Private Y As Integer
    Private Spielfeld As Form1

    Public Sub New(Feld As Form1)
        Spielfeld = Feld
        X = 2
        Y = 3
        Blickrichtung = 0

        Spielfeld.ChangeBoard(X, Y, "/\")
    End Sub

    Public Sub Drehen(Richtung As Integer)

        Blickrichtung = (Blickrichtung + Richtung + 4) Mod 4

        Dim NeueFigur As String
        Select Case Blickrichtung
            Case 0
                NeueFigur = "/\"
            Case 1
                NeueFigur = ">"
            Case 2
                NeueFigur = "\/"
            Case 3
                NeueFigur = "<"
            Case Else
                NeueFigur = ""
        End Select

        Spielfeld.ChangeBoard(X, Y, NeueFigur)

    End Sub

    Public Sub Laufen(Richtung As Integer)

        Spielfeld.ChangeBoard(X, Y, "")

        Dim NeueFigur As String
        Select Case Blickrichtung
            Case 0
                Y -= Richtung
                NeueFigur = "/\"
            Case 1
                X += Richtung
                NeueFigur = ">"
            Case 2
                Y += Richtung
                NeueFigur = "\/"
            Case 3
                X -= Richtung
                NeueFigur = "<"
            Case Else
                NeueFigur = ""
        End Select

        Spielfeld.ChangeBoard(X, Y, NeueFigur)

    End Sub

End Class
