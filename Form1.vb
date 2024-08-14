Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim blAnBox As Boolean

        blAnBox = CheckBox1.Checked

        If blAnBox Then
            Dim iErstezahl As Integer
            Dim iZweitezahl As Integer
            Dim iErgebnis As Integer

            iErstezahl = NumericUpDown1.Value
            iZweitezahl = NumericUpDown2.Value

            iErgebnis = iErstezahl + iZweitezahl

            Label1.Text = iErgebnis
        End If

    End Sub



End Class
