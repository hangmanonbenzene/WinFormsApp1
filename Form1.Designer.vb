<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnPlus = New Button()
        txtErsteZahl = New TextBox()
        txtZweiteZahl = New TextBox()
        btnMinus = New Button()
        btnGeteilt = New Button()
        btnMal = New Button()
        lblErgebnis = New Label()
        btnModulo = New Button()
        btnPotenz = New Button()
        lsbErgebnisse = New ListBox()
        SuspendLayout()
        ' 
        ' btnPlus
        ' 
        btnPlus.Location = New Point(109, 80)
        btnPlus.Name = "btnPlus"
        btnPlus.Size = New Size(100, 47)
        btnPlus.TabIndex = 0
        btnPlus.Text = "Plus"
        btnPlus.UseVisualStyleBackColor = True
        ' 
        ' txtErsteZahl
        ' 
        txtErsteZahl.Location = New Point(109, 51)
        txtErsteZahl.Name = "txtErsteZahl"
        txtErsteZahl.Size = New Size(100, 23)
        txtErsteZahl.TabIndex = 1
        txtErsteZahl.Text = "0"
        ' 
        ' txtZweiteZahl
        ' 
        txtZweiteZahl.Location = New Point(215, 51)
        txtZweiteZahl.Name = "txtZweiteZahl"
        txtZweiteZahl.Size = New Size(100, 23)
        txtZweiteZahl.TabIndex = 2
        txtZweiteZahl.Text = "0"
        ' 
        ' btnMinus
        ' 
        btnMinus.Location = New Point(215, 80)
        btnMinus.Name = "btnMinus"
        btnMinus.Size = New Size(100, 47)
        btnMinus.TabIndex = 3
        btnMinus.Text = "Minus"
        btnMinus.UseVisualStyleBackColor = True
        ' 
        ' btnGeteilt
        ' 
        btnGeteilt.Location = New Point(215, 133)
        btnGeteilt.Name = "btnGeteilt"
        btnGeteilt.Size = New Size(100, 47)
        btnGeteilt.TabIndex = 5
        btnGeteilt.Text = "Geteilt"
        btnGeteilt.UseVisualStyleBackColor = True
        ' 
        ' btnMal
        ' 
        btnMal.Location = New Point(109, 133)
        btnMal.Name = "btnMal"
        btnMal.Size = New Size(100, 47)
        btnMal.TabIndex = 4
        btnMal.Text = "Mal"
        btnMal.UseVisualStyleBackColor = True
        ' 
        ' lblErgebnis
        ' 
        lblErgebnis.BorderStyle = BorderStyle.FixedSingle
        lblErgebnis.Location = New Point(321, 51)
        lblErgebnis.Name = "lblErgebnis"
        lblErgebnis.Size = New Size(221, 23)
        lblErgebnis.TabIndex = 6
        ' 
        ' btnModulo
        ' 
        btnModulo.Location = New Point(109, 186)
        btnModulo.Name = "btnModulo"
        btnModulo.Size = New Size(100, 48)
        btnModulo.TabIndex = 7
        btnModulo.Text = "Division mit Rest"
        btnModulo.UseVisualStyleBackColor = True
        ' 
        ' btnPotenz
        ' 
        btnPotenz.Location = New Point(215, 186)
        btnPotenz.Name = "btnPotenz"
        btnPotenz.Size = New Size(100, 48)
        btnPotenz.TabIndex = 8
        btnPotenz.Text = "Hoch"
        btnPotenz.UseVisualStyleBackColor = True
        ' 
        ' lsbErgebnisse
        ' 
        lsbErgebnisse.FormattingEnabled = True
        lsbErgebnisse.ItemHeight = 15
        lsbErgebnisse.Location = New Point(321, 80)
        lsbErgebnisse.Name = "lsbErgebnisse"
        lsbErgebnisse.Size = New Size(221, 154)
        lsbErgebnisse.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lsbErgebnisse)
        Controls.Add(btnPotenz)
        Controls.Add(btnModulo)
        Controls.Add(lblErgebnis)
        Controls.Add(btnGeteilt)
        Controls.Add(btnMal)
        Controls.Add(btnMinus)
        Controls.Add(txtZweiteZahl)
        Controls.Add(txtErsteZahl)
        Controls.Add(btnPlus)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnPlus As Button
    Friend WithEvents txtErsteZahl As TextBox
    Friend WithEvents txtZweiteZahl As TextBox
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnGeteilt As Button
    Friend WithEvents btnMal As Button
    Friend WithEvents lblErgebnis As Label
    Friend WithEvents btnModulo As Button
    Friend WithEvents btnPotenz As Button
    Friend WithEvents lsbErgebnisse As ListBox

End Class
