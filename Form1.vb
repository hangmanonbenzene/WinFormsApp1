Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = ""

        Dim stAusgabe As String = ""
        Dim iCount As Integer

        For iCount = nBox1.Value To nBox2.Value Step 1
            stAusgabe = stAusgabe & iCount ^ 2 & vbCrLf
        Next

        Label1.Text = stAusgabe
    End Sub
End Class