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

        If stZweitezahl = 0 Then
            lblErgebnis.Text = "Division durch 0 nicht möglich"
            Exit Sub
        End If

        Dim stErgebnis As Decimal
        stErgebnis = stErstezahl / stZweitezahl
        lblErgebnis.Text = stErgebnis

    End Sub

    Private Sub btnModulo_Click(sender As Object, e As EventArgs) Handles btnModulo.Click

        Dim stErstezahl As Decimal
        stErstezahl = txtErsteZahl.Text

        Dim stZweitezahl As Decimal
        stZweitezahl = txtZweiteZahl.Text

        If stZweitezahl = 0 Then
            lblErgebnis.Text = "Division durch 0 nicht möglich"
            Exit Sub
        End If

        Dim stErgebnis1 As Decimal
        stErgebnis1 = stErstezahl \ stZweitezahl

        Dim stErgebnis2 As Decimal
        stErgebnis2 = stErstezahl Mod stZweitezahl

        lblErgebnis.Text = stErgebnis1 & " Rest " & stErgebnis2

    End Sub

    Private Sub btnPotenz_Click(sender As Object, e As EventArgs) Handles btnPotenz.Click

        Dim stErstezahl As Decimal
        stErstezahl = txtErsteZahl.Text

        Dim stZweitezahl As Decimal
        stZweitezahl = txtZweiteZahl.Text

        Dim stErgebnis As Decimal
        stErgebnis = stErstezahl ^ stZweitezahl
        lblErgebnis.Text = stErgebnis

    End Sub

    Dim previousValue1 As Decimal = 0
    Dim previousValue2 As Decimal = 0
    Private Sub zahlenEinlesen(sender As Object, e As EventArgs) Handles txtErsteZahl.TextChanged, txtZweiteZahl.TextChanged

        Dim txt As TextBox = CType(sender, TextBox)
        Dim stZahl As Decimal

        If Not Decimal.TryParse(txt.Text, stZahl) Then
            If txt.Name Is "txtErsteZahl" Then
                txtErsteZahl.Text = previousValue1
            Else
                txtZweiteZahl.Text = previousValue2
            End If
        Else
            If txt.Name Is "txtErsteZahl" Then
                previousValue1 = stZahl
            Else
                previousValue2 = stZahl
            End If
        End If

    End Sub
    Private Sub alteErgebnisseInListeEintragen(sender As Object, e As EventArgs) Handles lblErgebnis.TextChanged

        Dim stErgebnis As Decimal
        If Not Decimal.TryParse(lblErgebnis.Text, stErgebnis) Then
            Exit Sub
        End If

        ' Eintrag in Liste als erstes Element
        lsbErgebnisse.Items.Insert(0, stErgebnis)

    End Sub
End Class