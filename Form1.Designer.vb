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
        txtText = New TextBox()
        txtDateiname = New TextBox()
        Button1 = New Button()
        ltbGespeicherteDateien = New ListBox()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' txtText
        ' 
        txtText.Location = New Point(12, 12)
        txtText.Multiline = True
        txtText.Name = "txtText"
        txtText.Size = New Size(394, 390)
        txtText.TabIndex = 0
        ' 
        ' txtDateiname
        ' 
        txtDateiname.Location = New Point(412, 12)
        txtDateiname.Name = "txtDateiname"
        txtDateiname.Size = New Size(323, 23)
        txtDateiname.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(412, 41)
        Button1.Name = "Button1"
        Button1.Size = New Size(323, 51)
        Button1.TabIndex = 2
        Button1.Text = "Speichern und Schließen"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ltbGespeicherteDateien
        ' 
        ltbGespeicherteDateien.FormattingEnabled = True
        ltbGespeicherteDateien.ItemHeight = 15
        ltbGespeicherteDateien.Location = New Point(412, 98)
        ltbGespeicherteDateien.Name = "ltbGespeicherteDateien"
        ltbGespeicherteDateien.Size = New Size(323, 244)
        ltbGespeicherteDateien.TabIndex = 3
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(412, 351)
        Button2.Name = "Button2"
        Button2.Size = New Size(323, 51)
        Button2.TabIndex = 4
        Button2.Text = "Öffnen"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(747, 409)
        Controls.Add(Button2)
        Controls.Add(ltbGespeicherteDateien)
        Controls.Add(Button1)
        Controls.Add(txtDateiname)
        Controls.Add(txtText)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtText As TextBox
    Friend WithEvents txtDateiname As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ltbGespeicherteDateien As ListBox
    Friend WithEvents Button2 As Button

End Class
