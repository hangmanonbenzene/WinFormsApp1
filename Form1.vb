Public Class Form1

    Dim aiData() As Integer = {5, 7, 33, 22, 8}

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For iListe = 0 To aiData.Length - 1

            MsgBox(aiData(iListe))

        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim stAusgabe As String = ""

        For iCounter = 0 To aiData.Length - 1

            stAusgabe += aiData(iCounter) & vbCrLf

        Next

        MsgBox(stAusgabe)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim iErgebnis As Integer

        For iCount = 0 To aiData.Length - 1

            iErgebnis += aiData(iCount)

        Next

        MsgBox("Das Ergebnis ist " & iErgebnis)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim iErgebnis As Integer
        Dim iDurchschnitt As Integer

        For iCount = 0 To aiData.Length - 1

            iErgebnis += aiData(iCount)

        Next

        iDurchschnitt = iErgebnis / aiData.Length
        MsgBox("Der Durchschnitt ist " & iDurchschnitt)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim iErgebnis As Integer

        For iCount = 0 To aiData.Length - 1

            If aiData(iCount) > 20 Then

                iErgebnis += aiData(iCount)

            End If

        Next

        MsgBox("Die Summe aller Zahlen über 20 ist " & iErgebnis)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim iErgebnis As Integer
        iErgebnis = Integer.MinValue

        For iCount = 0 To aiData.Length - 1

            If iErgebnis < aiData(iCount) Then

                iErgebnis = aiData(iCount)

            End If

        Next

        MsgBox("Die grösste Zahl ist " & iErgebnis)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim iErgebnis As Integer
        iErgebnis = Integer.MaxValue

        For iCount = 0 To aiData.Length - 1

            If iErgebnis > aiData(iCount) Then

                iErgebnis = aiData(iCount)

            End If

        Next

        MsgBox("Die kleinste Zahl ist " & iErgebnis)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Dim stAusgabe As String = ""

        For iCounter = 0 To aiData.Length - 1

            aiData(iCounter) = aiData(iCounter) * 2

            stAusgabe += aiData(iCounter) & vbCrLf

        Next

        MsgBox(stAusgabe)

    End Sub
End Class