Public Class Form1
    Dim alblSpielfeld(11) As Label
    Dim iSpielerposition As Integer = 0
    Dim würfel As New Random


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim iWürfelergebnis As Integer

        iWürfelergebnis = würfel.Next(1, 7)

        MsgBox("Würfelergebnis war " & iWürfelergebnis)

        alblSpielfeld(iSpielerposition).Text = ""

        iSpielerposition = (iSpielerposition + iWürfelergebnis) Mod 12

        alblSpielfeld(iSpielerposition).Text = "X"










    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alblSpielfeld(0) = Label1
        alblSpielfeld(1) = Label2
        alblSpielfeld(2) = Label3
        alblSpielfeld(3) = Label4
        alblSpielfeld(4) = Label5
        alblSpielfeld(5) = Label6
        alblSpielfeld(6) = Label7
        alblSpielfeld(7) = Label8
        alblSpielfeld(8) = Label9
        alblSpielfeld(9) = Label10
        alblSpielfeld(10) = Label11
        alblSpielfeld(11) = Label12
    End Sub

End Class