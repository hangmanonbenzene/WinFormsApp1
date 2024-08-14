Public Class Form1
    Dim SpielerEins = "X"
    Dim SpielerZwei = "O"
    Dim EinsIstDran = True
    Dim Felder As New List(Of Label)
    Private Sub Feld_Click(sender As Object, e As EventArgs) Handles EinsEins.Click, EinsZwei.Click, EinsDrei.Click, ZweiEins.Click, ZweiZwei.Click, ZweiDrei.Click, DreiEins.Click, DreiZwei.Click, DreiDrei.Click
        If EinsIstDran Then
            sender.Text = SpielerEins
        Else
            sender.Text = SpielerZwei
        End If
        EinsIstDran = Not EinsIstDran
        sender.Enabled = False
        CheckEnde()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Felder.Add(EinsEins)
        Felder.Add(EinsZwei)
        Felder.Add(EinsDrei)
        Felder.Add(ZweiEins)
        Felder.Add(ZweiZwei)
        Felder.Add(ZweiDrei)
        Felder.Add(DreiEins)
        Felder.Add(DreiZwei)
        Felder.Add(DreiDrei)
    End Sub

    Private Sub Reset()
        For Each Feld In Felder
            Feld.Text = ""
            Feld.Enabled = True
        Next
    End Sub

    Private Sub CheckEnde()

        If (EinsEins.Text = SpielerEins And EinsZwei.Text = SpielerEins And EinsDrei.Text = SpielerEins) Or
            (ZweiEins.Text = SpielerEins And ZweiZwei.Text = SpielerEins And ZweiDrei.Text = SpielerEins) Or
            (DreiEins.Text = SpielerEins And DreiZwei.Text = SpielerEins And DreiDrei.Text = SpielerEins) Or
            (EinsEins.Text = SpielerEins And ZweiEins.Text = SpielerEins And DreiEins.Text = SpielerEins) Or
            (EinsZwei.Text = SpielerEins And ZweiZwei.Text = SpielerEins And DreiZwei.Text = SpielerEins) Or
            (EinsDrei.Text = SpielerEins And ZweiDrei.Text = SpielerEins And DreiDrei.Text = SpielerEins) Or
            (EinsEins.Text = SpielerEins And ZweiZwei.Text = SpielerEins And DreiDrei.Text = SpielerEins) Or
            (EinsDrei.Text = SpielerEins And ZweiZwei.Text = SpielerEins And DreiEins.Text = SpielerEins) Then
            MsgBox("Spieler Eins hat gewonnen!")
            Reset()
        End If

        If (EinsEins.Text = SpielerZwei And EinsZwei.Text = SpielerZwei And EinsDrei.Text = SpielerZwei) Or
            (ZweiEins.Text = SpielerZwei And ZweiZwei.Text = SpielerZwei And ZweiDrei.Text = SpielerZwei) Or
            (DreiEins.Text = SpielerZwei And DreiZwei.Text = SpielerZwei And DreiDrei.Text = SpielerZwei) Or
            (EinsEins.Text = SpielerZwei And ZweiEins.Text = SpielerZwei And DreiEins.Text = SpielerZwei) Or
            (EinsZwei.Text = SpielerZwei And ZweiZwei.Text = SpielerZwei And DreiZwei.Text = SpielerZwei) Or
            (EinsDrei.Text = SpielerZwei And ZweiDrei.Text = SpielerZwei And DreiDrei.Text = SpielerZwei) Or
            (EinsEins.Text = SpielerZwei And ZweiZwei.Text = SpielerZwei And DreiDrei.Text = SpielerZwei) Or
            (EinsDrei.Text = SpielerZwei And ZweiZwei.Text = SpielerZwei And DreiEins.Text = SpielerZwei) Then
            MsgBox("Spieler Zwei hat gewonnen!")
            Reset()
        End If

        Dim Unentschieden = True
        For Each Feld In Felder
            If Feld.Text = "" Then
                Unentschieden = False
                Exit For
            End If
        Next
        If Unentschieden Then
            MsgBox("Unentschieden!")
            Reset()
        End If
    End Sub
End Class