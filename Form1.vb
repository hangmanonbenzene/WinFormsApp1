Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim My2DArray(3, 3) As Integer

        My2DArray(0, 0) = 1
        My2DArray(0, 1) = 2
        My2DArray(0, 2) = 3
        My2DArray(0, 3) = 4
        My2DArray(1, 0) = 5
        My2DArray(1, 1) = 6
        My2DArray(1, 2) = 7
        My2DArray(1, 3) = 8
        My2DArray(2, 0) = 9
        My2DArray(2, 1) = 10
        My2DArray(2, 2) = 11
        My2DArray(2, 3) = 12
        My2DArray(3, 0) = 13
        My2DArray(3, 1) = 14
        My2DArray(3, 2) = 15
        My2DArray(3, 3) = 16

        For iCount = 0 To 3 Step 1

            MsgBox(My2DArray(3 - iCount, 3))

        Next

    End Sub

End Class