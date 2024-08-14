Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iErtsezahl As Integer
        Dim iZweitezahl As Integer

        iErtsezahl = NumericUpDown1.Value
        iZweitezahl = NumericUpDown2.Value

        Dim iErgebnis As Integer

        iErgebnis = iErtsezahl + iZweitezahl

        Ergebnis.Text = iErtsezahl & " + " & iZweitezahl & " = " & iErgebnis
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim blBox As Boolean
        blBox = CheckBox1.Checked
        Label1.Text = "Box gescheckt: " & blBox
    End Sub
End Class