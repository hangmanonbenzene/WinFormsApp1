Public Class Form1

    Private gridSize As Integer = 5
    Private Feld(gridSize, gridSize) As Label
    Private Spielfigur As Figur

    Private Sub Form1_Load() Handles MyBase.Load
        SpielfeldErstellen()

        Spielfigur = New Figur(Me)
    End Sub

    Private Sub Vorwärts() Handles Button1.Click
        Spielfigur.Laufen(1)
    End Sub

    Private Sub Rückwärts() Handles Button4.Click
        Spielfigur.Laufen(-1)
    End Sub

    Private Sub Rechts() Handles Button3.Click
        Spielfigur.Drehen(1)
    End Sub

    Private Sub Links() Handles Button2.Click
        Spielfigur.Drehen(-1)
    End Sub


    Public Sub ChangeBoard(x As Integer, y As Integer, Figur As String)
        Feld(x, y).Text = Figur
    End Sub

    Private Sub SpielfeldErstellen()
        For i As Integer = 0 To gridSize - 1
            For j As Integer = 0 To gridSize - 1
                Feld(i, j) = New Label
                Feld(i, j).Location = New Point(10 + i * 100, 10 + j * 100)
                Feld(i, j).Size = New Size(100, 100)
                Feld(i, j).BorderStyle = BorderStyle.FixedSingle
                Feld(i, j).TextAlign = ContentAlignment.MiddleCenter
                Feld(i, j).Font = New Font(Feld(i, j).Font.FontFamily, 40)
                Me.Controls.Add(Feld(i, j))
            Next
        Next
    End Sub

End Class
