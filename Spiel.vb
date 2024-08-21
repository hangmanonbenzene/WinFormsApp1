Public Class Spiel

    Dim Spielfeld As Spielfeld
    Dim Figur1 As Figur
    Dim Figur2 As Figur
    Dim gestartet As Boolean = False
    Dim SpielerEinsDran As Boolean = True

    Public Sub start()
        If Not gestartet Then
            Spielfeld = New Spielfeld
            Figur1 = New Figur("X")
            Figur2 = New Figur("O")
            Figur1.setFeld(Spielfeld.getStartfeld)
            Figur2.setFeld(Spielfeld.getStartfeld.getNächstesFeld)
            gestartet = True
        End If
    End Sub

    Public Sub stopp()
        If gestartet Then
            Figur1.getFeld.removeFigur()
            Figur2.getFeld.removeFigur()
            Spielfeld = Nothing
            Figur1 = Nothing
            Figur2 = Nothing
            gestartet = False
        End If
    End Sub

    Public Sub nächsterZug()
        If gestartet Then

            Dim Würfelergebnis As Integer = würfeln()

            MsgBox("Du hast eine " & Würfelergebnis & " gewürfelt")

            If SpielerEinsDran Then
                Figurlaufen(Figur1, Würfelergebnis)
            Else
                Figurlaufen(Figur2, Würfelergebnis)
            End If

            SpielerEinsDran = Not SpielerEinsDran

        End If
    End Sub

    Private Sub Figurlaufen(Figur As Figur, Würfelergebnis As Integer)
        For Zähler As Integer = 1 To Würfelergebnis
            Dim nächstesFeld As Feld = Figur.getFeld.getNächstesFeld
            If nächstesFeld.getFeldBesetzt Then
                nächstesFeld = nächstesFeld.getNächstesFeld
            End If
            Figur.setFeld(nächstesFeld)
        Next
    End Sub

End Class
