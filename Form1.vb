Public Class Form1

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click

        Dim stErstezahl As Decimal
        stErstezahl = txtErsteZahl.Text

        Dim stZweitezahl As Decimal
        stZweitezahl = txtZweiteZahl.Text

        Dim stErgebnis As Decimal
        stErgebnis = stErstezahl + stZweitezahl
        lblErgebnis.Text = stErgebnis

    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click

        Dim stErstezahl As Decimal
        stErstezahl = txtErsteZahl.Text

        Dim stZweitezahl As Decimal
        stZweitezahl = txtZweiteZahl.Text

        Dim stErgebnis As Decimal
        stErgebnis = stErstezahl - stZweitezahl
        lblErgebnis.Text = stErgebnis

    End Sub

    Private Sub btnMal_Click(sender As Object, e As EventArgs) Handles btnMal.Click

        Dim stErstezahl As Decimal
        stErstezahl = txtErsteZahl.Text

        Dim stZweitezahl As Decimal
        stZweitezahl = txtZweiteZahl.Text

        Dim stErgebnis As Decimal
        stErgebnis = stErstezahl * stZweitezahl
        lblErgebnis.Text = stErgebnis

    End Sub

    Private Sub btnGeteilt_Click(sender As Object, e As EventArgs) Handles btnGeteilt.Click

        Dim stErstezahl As Decimal
        stErstezahl = txtErsteZahl.Text

        Dim stZweitezahl As Decimal
        stZweitezahl = txtZweiteZahl.Text

        Dim stErgebnis As Decimal
        stErgebnis = stErstezahl / stZweitezahl
        lblErgebnis.Text = stErgebnis

    End Sub

    Private Sub btnModulo_Click(sender As Object, e As EventArgs) Handles btnModulo.Click

        Dim stErstezahl As Decimal
        stErstezahl = txtErsteZahl.Text

        Dim stZweitezahl As Decimal
        stZweitezahl = txtZweiteZahl.Text

        Dim stErgebnis1 As Decimal
        stErgebnis1 = stErstezahl \ stZweitezahl

        Dim stErgebnis2 As Decimal
        stErgebnis2 = stErstezahl Mod stZweitezahl

        lblErgebnis.Text = stErgebnis1 & " Rest " & stErgebnis2

    End Sub

End Class