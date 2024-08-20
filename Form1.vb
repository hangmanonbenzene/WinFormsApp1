Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim iLängeliste As Integer = InputBox("Länge der Liste ?")

        Dim astlistederelemente(iLängeliste - 1) As String




        Dim iElementnummer As Integer = 1
        Dim stElementliste As String = ""

        For iListe = 0 To iLängeliste - 1



            astlistederelemente(iListe) = InputBox(iElementnummer & " Element der Liste ")


            stElementliste = stElementliste & astlistederelemente(iListe) & vbCrLf



            iElementnummer += 1
        Next

        MsgBox(stElementliste.Substring(0, stElementliste.Length - 2))

    End Sub

End Class