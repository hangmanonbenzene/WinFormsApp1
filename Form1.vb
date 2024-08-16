Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim iZiehwert As Integer
        Dim iAktwert As Integer
        Dim stEingabe As String
        Dim aiZufallszahlen(21) As Integer
        Dim iCount As Integer


        Do

            stEingabe = InputBox("Dein aktueller Wert ist " & iAktwert & vbCrLf & "Willst du eine weitere Zahl ziehen?")

            If stEingabe.ToLower = "ja" Then

                iZiehwert = neueZahl()
                MsgBox("Du ziehst " & iZiehwert & ".")

                aiZufallszahlen(iCount) = iZiehwert

                iAktwert += iZiehwert

                Select Case iAktwert

                    Case Is > 21
                        MsgBox("Verloren mit dem Wert " & iAktwert & ".")
                        Exit Sub

                    Case Is = 21
                        MsgBox("Gewonnen mit dem Wert " & iAktwert & ".")
                        Exit Sub

                End Select

            ElseIf stEingabe.ToLower = "nein" Then

                MsgBox("Du hast das Spiel mit dem Wert " & iAktwert & " beendet.")

            End If
            iCount += 1
        Loop Until stEingabe.ToLower = "nein"

    End Sub






    Public Function neueZahl() As Integer
        Return New Random().Next(1, 11)
    End Function

End Class