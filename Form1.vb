Public Class Form1

    Dim Spiel As New Spiel
    Public LabelListe(11) As Label

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Spiel.start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Spiel.nächsterZug()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Spiel.stopp()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelListe(0) = Label1
        LabelListe(1) = Label2
        LabelListe(2) = Label3
        LabelListe(3) = Label4
        LabelListe(4) = Label5
        LabelListe(5) = Label6
        LabelListe(6) = Label7
        LabelListe(7) = Label8
        LabelListe(8) = Label9
        LabelListe(9) = Label10
        LabelListe(10) = Label11
        LabelListe(11) = Label12
    End Sub

End Class
