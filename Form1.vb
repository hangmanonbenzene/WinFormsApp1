Public Class Form1
    Dim astMeineListe(9) As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim stEingabe As String
        Dim iStelle As Integer



        stEingabe = eingabe.Text
        iStelle = stelle.Value


        astMeineListe(iStelle) = stEingabe







    End Sub










    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        For count = 0 To astMeineListe.Length - 1
            MsgBox(astMeineListe(count))
        Next







    End Sub
End Class