Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim iLängeliste As Integer = InputBox("Länge der Liste ?")

        Dim astlistederelemente(iLängeliste - 1) As String




        Dim iElementnummer As Integer = 1


        For iListe = 0 To iLängeliste - 1



            InputBox(iElementnummer & " Element der Liste ")

            iElementnummer += 1

        Next























    End Sub
End Class