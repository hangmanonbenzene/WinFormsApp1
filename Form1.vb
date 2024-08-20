Public Class Form1
    Dim astObstkorb As String() = {"Apfel", "Birne", "Banane", "Orange", "Kiwi", "Mango", "Pfirsich", "Erdbeere", "Kirsche", "Zitrone"}

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim blIstInListe As Boolean
        Dim stObstsuche As String


        blIstInListe = False
        stObstsuche = InputBox("Nach welchem Obst suchen?")


        For iObstkorbposition = 0 To astObstkorb.Length - 1

            If stObstsuche = astObstkorb(iObstkorbposition) Then

                blIstInListe = True
                Exit For

            End If

        Next


        If blIstInListe = True Then
            MsgBox("Obst ist im Korb")
        Else
            MsgBox("Obst ist nicht im Korb")
        End If


    End Sub
End Class