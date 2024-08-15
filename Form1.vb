Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iSWzahl As Integer
        Dim iAusZahl As Integer
        Dim iAnZahl As Integer
        Dim blAusAn As Boolean

        iSWzahl = schrittweite.Value
        iAusZahl = bisAus.Value
        iAnZahl = bisAn.Value
        blAusAn = cbAnAus.Checked

        If blAusAn = True Then

            For iCount = 0 To iAnZahl Step iSWzahl
                MsgBox(iCount)
            Next

        ElseIf blAusAn = False Then

            For iCount = 0 To iAusZahl Step iSWzahl
                MsgBox(iCount)
            Next

        End If

    End Sub
End Class