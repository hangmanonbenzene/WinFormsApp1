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
        Label1 = New Label()
        nBox1 = New NumericUpDown()
        nBox2 = New NumericUpDown()
        CType(nBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(nBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(129, 165)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 64)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Location = New Point(384, 165)
        Label1.Name = "Label1"
        Label1.Size = New Size(2, 17)
        Label1.TabIndex = 1
        ' 
        ' nBox1
        ' 
        nBox1.Location = New Point(121, 67)
        nBox1.Name = "nBox1"
        nBox1.Size = New Size(120, 23)
        nBox1.TabIndex = 2
        nBox1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' nBox2
        ' 
        nBox2.Location = New Point(301, 67)
        nBox2.Name = "nBox2"
        nBox2.Size = New Size(120, 23)
        nBox2.TabIndex = 3
        nBox2.Value = New Decimal(New Integer() {10, 0, 0, 0})
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(747, 409)
        Controls.Add(nBox2)
        Controls.Add(nBox1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        MaximizeBox = False
        Name = "Form1"
        Text = "Form1"
        CType(nBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(nBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents nBox1 As NumericUpDown
    Friend WithEvents nBox2 As NumericUpDown

End Class
