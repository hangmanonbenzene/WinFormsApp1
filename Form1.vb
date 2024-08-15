Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim gesuchteZahl As Integer = New Random().Next(1, 101)

        Dim BoxZahl As Integer
        Do
            Dim iCount

            BoxZahl = InputBox("Die gesuchte Zahl liegt zwischen 1 und 100.")

            Select Case BoxZahl
                Case Is = gesuchteZahl
                    MsgBox(BoxZahl & " war die gesuchte Zahl.")

                Case Is < gesuchteZahl
                    MsgBox(BoxZahl & " ist kleiner als die gesuchte Zahl.")

                Case Is > gesuchteZahl
                    MsgBox(BoxZahl & " ist größer als die gesuchte Zahl.")

            End Select

        Loop Until BoxZahl = gesuchteZahl

        Dim stName As String
        stName = txtName.Text

        Dim iVersuchAnzahl As Integer
        'iVersuchAnzahl = 
        lstScores.Items.Add(stName)

    End Sub
End Class