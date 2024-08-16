Public Class Form1

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnPlus.Click, btnMinus.Click, btnMal.Click, btnGeteilt.Click, btnModulo.Click, btnPotenz.Click

        Dim stErstezahl As Decimal
        stErstezahl = txtErsteZahl.Text

        Dim stZweitezahl As Decimal
        stZweitezahl = txtZweiteZahl.Text

        Dim stErgebnis As String

        If sender.Equals(btnPlus) Then
            stErgebnis = stErstezahl + stZweitezahl

        ElseIf sender.Equals(btnMinus) Then
            stErgebnis = stErstezahl - stZweitezahl

        ElseIf sender.Equals(btnMal) Then
            stErgebnis = stErstezahl * stZweitezahl

        ElseIf sender.Equals(btnGeteilt) Then
            If stZweitezahl = 0 Then
                lblErgebnis.Text = "Division durch 0 nicht möglich"
                Exit Sub
            End If
            stErgebnis = stErstezahl / stZweitezahl

        ElseIf sender.Equals(btnModulo) Then
            If stZweitezahl = 0 Then
                lblErgebnis.Text = "Division durch 0 nicht möglich"
                Exit Sub
            End If
            stErgebnis = stErstezahl \ stZweitezahl & " Rest " & stErstezahl Mod stZweitezahl

        ElseIf sender.Equals(btnPotenz) Then
            stErgebnis = stErstezahl ^ stZweitezahl

        End If

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

        lsbErgebnisse.Items.Insert(0, stErgebnis)

    End Sub
End Class