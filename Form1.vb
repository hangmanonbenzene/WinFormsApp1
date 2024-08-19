Imports System.Diagnostics.Tracing

Public Class Form1
    Dim astListe As String() = {"Null", "Eins", "Zwei", "Drei", "Vier", "Fünf", "Sechs", "Sieben", "Acht", "Neun"}

    Private Sub NumericUpDown1_ValueChanged() Handles NumericUpDown1.ValueChanged

        Dim iPosition As Integer
        Dim stListenText As String

        iPosition = NumericUpDown1.Value
        stListenText = astListe(iPosition)

        TextBox1.Text = stListenText

    End Sub

    Private Sub TextBox1_TextChanged() Handles TextBox1.TextChanged

        Dim iPosition As Integer
        Dim stText As String

        iPosition = NumericUpDown1.Value
        stText = TextBox1.Text

        astListe(iPosition) = stText

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim stText As String

        For iStelle = 0 To astListe.Length - 1

            stText = stText & astListe(iStelle) & vbCrLf

        Next

        MsgBox(stText)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumericUpDown1_ValueChanged()
    End Sub
End Class