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
        ProgressBar1 = New ProgressBar()
        btnStart = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(77, 175)
        ProgressBar1.Maximum = 1000
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(350, 23)
        ProgressBar1.Step = 1
        ProgressBar1.TabIndex = 0
        ' 
        ' btnStart
        ' 
        btnStart.Location = New Point(268, 30)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(159, 95)
        btnStart.TabIndex = 1
        btnStart.Text = "Start"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(433, 183)
        Label1.Name = "Label1"
        Label1.Size = New Size(23, 15)
        Label1.TabIndex = 2
        Label1.Text = "0%"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(747, 409)
        Controls.Add(Label1)
        Controls.Add(btnStart)
        Controls.Add(ProgressBar1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnStart As Button
    Friend WithEvents Label1 As Label

End Class
