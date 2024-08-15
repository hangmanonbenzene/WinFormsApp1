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
        btnStart = New Button()
        lstScores = New ListBox()
        txtName = New TextBox()
        SuspendLayout()
        ' 
        ' btnStart
        ' 
        btnStart.Location = New Point(12, 38)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(271, 54)
        btnStart.TabIndex = 0
        btnStart.Text = "Start"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' lstScores
        ' 
        lstScores.FormattingEnabled = True
        lstScores.ItemHeight = 15
        lstScores.Location = New Point(12, 98)
        lstScores.Name = "lstScores"
        lstScores.Size = New Size(271, 304)
        lstScores.TabIndex = 5
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(12, 11)
        txtName.MaxLength = 44
        txtName.Name = "txtName"
        txtName.Size = New Size(271, 23)
        txtName.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(747, 409)
        Controls.Add(txtName)
        Controls.Add(lstScores)
        Controls.Add(btnStart)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents lstScores As ListBox
    Friend WithEvents txtName As TextBox

End Class
