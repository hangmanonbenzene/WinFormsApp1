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
        NumericUpDown2 = New NumericUpDown()
        Button1 = New Button()
        Ergebnis = New Label()
        CheckBox1 = New CheckBox()
        Label1 = New Label()
        Button2 = New Button()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(80, 58)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(120, 23)
        NumericUpDown1.TabIndex = 0
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.Location = New Point(80, 87)
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(120, 23)
        NumericUpDown2.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(206, 58)
        Button1.Name = "Button1"
        Button1.Size = New Size(120, 23)
        Button1.TabIndex = 2
        Button1.Text = "Plus"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Ergebnis
        ' 
        Ergebnis.BorderStyle = BorderStyle.FixedSingle
        Ergebnis.Location = New Point(206, 87)
        Ergebnis.Name = "Ergebnis"
        Ergebnis.Size = New Size(241, 23)
        Ergebnis.TabIndex = 3
        Ergebnis.Text = "0 + 0 = 0"
        Ergebnis.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(185, 173)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(15, 14)
        CheckBox1.TabIndex = 4
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Location = New Point(206, 168)
        Label1.Name = "Label1"
        Label1.Size = New Size(241, 23)
        Label1.TabIndex = 5
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(80, 168)
        Button2.Name = "Button2"
        Button2.Size = New Size(99, 23)
        Button2.TabIndex = 6
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(747, 409)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Controls.Add(CheckBox1)
        Controls.Add(Ergebnis)
        Controls.Add(Button1)
        Controls.Add(NumericUpDown2)
        Controls.Add(NumericUpDown1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        Text = "Form1"
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents Ergebnis As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button

End Class
