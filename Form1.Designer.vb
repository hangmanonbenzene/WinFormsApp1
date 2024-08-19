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
        NumericUpDown1 = New NumericUpDown()
        TextBox1 = New TextBox()
        Button1 = New Button()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(76, 72)
        NumericUpDown1.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(120, 23)
        NumericUpDown1.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(76, 101)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(120, 23)
        TextBox1.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(230, 72)
        Button1.Name = "Button1"
        Button1.Size = New Size(127, 52)
        Button1.TabIndex = 5
        Button1.Text = "Komplette Liste ausgeben"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(747, 409)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(NumericUpDown1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        Text = "Form1"
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button

End Class
