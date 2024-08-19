Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim rand As New Random
        For i As Integer = 0 To 990
            ProgressBar1.Value = i
            Label1.Text = i.ToString().Substring(0, i.ToString().Length - 1) & "%"
            Threading.Thread.Sleep(rand.Next(0, i * i / 2500))
            Application.DoEvents()
        Next
    End Sub
End Class