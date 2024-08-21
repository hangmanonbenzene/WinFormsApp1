Public Class Spielfeld

    Dim Startfeld As Feld

    Public Sub New()

        Startfeld = New Feld(Form1.LabelListe(0))
        Dim temp = Startfeld

        For Zähler As Integer = 1 To 11
            Dim Feld As Feld = New Feld(Form1.LabelListe(Zähler))
            temp.setNächstesFeld(Feld)
            temp = Feld
        Next

        temp.setNächstesFeld(Startfeld)

    End Sub

    Public Function getStartfeld() As Feld
        Return Startfeld
    End Function

End Class
