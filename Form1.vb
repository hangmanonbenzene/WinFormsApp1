Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim decErgebnis As Decimal
        Dim iNummerEins As Integer = NumericUpDown1.Value
        Dim iNummerZwei As Integer = NumericUpDown2.Value

        If CheckBox1.Checked Then
            decErgebnis = iNummerEins + iNummerZwei
            Label1.Text = decErgebnis

        ElseIf CheckBox2.Checked Then
            decErgebnis = iNummerEins - iNummerZwei
            Label1.Text = decErgebnis

        ElseIf CheckBox3.Checked Then
            decErgebnis = iNummerEins * iNummerZwei
            Label1.Text = decErgebnis

        ElseIf CheckBox4.Checked And Not iNummerZwei = 0 Then
            decErgebnis = iNummerEins / iNummerZwei
            Label1.Text = decErgebnis

        Else
            Label1.Text = ""
        End If


    End Sub
End Class