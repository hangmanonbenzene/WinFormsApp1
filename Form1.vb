Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim iBox1 As Integer = InputBox(" Bis Welche Nummer willst du zählen ? ")
        Dim stBox2 As String = InputBox(" Gerade oder ungerade Zahlen ? ")
        Dim iCount As Integer

        If stBox2 = "ungerade" Then

            iCount = 1
            Do While iCount <= iBox1
                MsgBox(iCount)

                iCount = iCount + 2
            Loop

            'For iCount = 1 To iBox1 Step 2
            '   MsgBox(iCount)
            'Next

        ElseIf stBox2 = "gerade" Then
            For iCount = 2 To iBox1 Step 2
                MsgBox(iCount)
            Next
        End If


    End Sub
End Class