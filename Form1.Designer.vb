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
        Button1 = New Button()
        eingabe = New TextBox()
        Button2 = New Button()
        stelle = New NumericUpDown()
        CType(stelle, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(206, 67)
        Button1.Name = "Button1"
        Button1.Size = New Size(132, 75)
        Button1.TabIndex = 0
        Button1.Text = "Hinzufügen"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' eingabe
        ' 
        eingabe.Location = New Point(75, 67)
        eingabe.Name = "eingabe"
        eingabe.Size = New Size(100, 23)
        eingabe.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(75, 174)
        Button2.Name = "Button2"
        Button2.Size = New Size(263, 23)
        Button2.TabIndex = 2
        Button2.Text = "Liste ausgeben"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' stelle
        ' 
        stelle.Location = New Point(75, 119)
        stelle.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        stelle.Name = "stelle"
        stelle.Size = New Size(100, 23)
        stelle.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(747, 409)
        Controls.Add(stelle)
        Controls.Add(Button2)
        Controls.Add(eingabe)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        Text = "Form1"
        CType(stelle, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents eingabe As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents stelle As NumericUpDown

End Class
