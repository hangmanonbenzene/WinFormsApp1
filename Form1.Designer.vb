﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        CheckBox1 = New CheckBox()
        Button1 = New Button()
        Label1 = New Label()
        NumericUpDown1 = New NumericUpDown()
        NumericUpDown2 = New NumericUpDown()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(207, 88)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(41, 19)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "An"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(207, 55)
        Button1.Name = "Button1"
        Button1.Size = New Size(85, 23)
        Button1.TabIndex = 1
        Button1.Text = "Addieren"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Location = New Point(67, 110)
        Label1.Name = "Label1"
        Label1.Size = New Size(225, 23)
        Label1.TabIndex = 2
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(67, 55)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(120, 23)
        NumericUpDown1.TabIndex = 3
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.Location = New Point(67, 84)
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(120, 23)
        NumericUpDown2.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(747, 409)
        Controls.Add(NumericUpDown2)
        Controls.Add(NumericUpDown1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(CheckBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        Text = "Form1"
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown

End Class
