Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim min As Integer = 0
        Dim max As Integer = 101
        Dim gesuchteZahl As Integer = New Random().Next(min + 1, max)
        Dim iCount As Integer
        Dim BoxZahl As Integer

        Do

            iCount = iCount + 1

            BoxZahl = InputBox("Die gesuchte Zahl liegt zwischen " & min + 1 & " und " & max - 1 & ".")

            Select Case BoxZahl
                Case Is = gesuchteZahl
                    MsgBox(BoxZahl & " war die gesuchte Zahl.")

                Case Is < gesuchteZahl
                    MsgBox(BoxZahl & " ist kleiner als die gesuchte Zahl.")
                    If BoxZahl > min Then min = BoxZahl

                Case Is > gesuchteZahl
                    MsgBox(BoxZahl & " ist größer als die gesuchte Zahl.")
                    If BoxZahl < max Then max = BoxZahl

            End Select

        Loop Until BoxZahl = gesuchteZahl

        Dim stName As String
        stName = txtName.Text

        lstScores.Items.Add(stName & " " & iCount)

    End Sub
End Class