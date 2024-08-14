Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim decErgebnis As Decimal

        If CheckBox1.Checked Then
            decErgebnis = NumericUpDown1.Value - NumericUpDown2.Value
            Label1.Text = decErgebnis

        ElseIf CheckBox2.Checked Then
            decErgebnis = NumericUpDown1.Value + NumericUpDown2.Value
            Label1.Text = decErgebnis
        Else
            Label1.Text = ""
        End If


    End Sub
End Class