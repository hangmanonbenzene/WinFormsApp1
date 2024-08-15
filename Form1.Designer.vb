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
        bisAus = New NumericUpDown()
        bisAn = New NumericUpDown()
        schrittweite = New NumericUpDown()
        cbAnAus = New CheckBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        CType(bisAus, ComponentModel.ISupportInitialize).BeginInit()
        CType(bisAn, ComponentModel.ISupportInitialize).BeginInit()
        CType(schrittweite, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(360, 113)
        Button1.Name = "Button1"
        Button1.Size = New Size(92, 52)
        Button1.TabIndex = 0
        Button1.Text = "Ausgabe"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' bisAus
        ' 
        bisAus.Location = New Point(216, 113)
        bisAus.Name = "bisAus"
        bisAus.Size = New Size(120, 23)
        bisAus.TabIndex = 2
        ' 
        ' bisAn
        ' 
        bisAn.Location = New Point(216, 142)
        bisAn.Name = "bisAn"
        bisAn.Size = New Size(120, 23)
        bisAn.TabIndex = 3
        ' 
        ' schrittweite
        ' 
        schrittweite.Location = New Point(216, 84)
        schrittweite.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        schrittweite.Name = "schrittweite"
        schrittweite.Size = New Size(120, 23)
        schrittweite.TabIndex = 4
        schrittweite.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' cbAnAus
        ' 
        cbAnAus.AutoSize = True
        cbAnAus.Location = New Point(360, 84)
        cbAnAus.Name = "cbAnAus"
        cbAnAus.Size = New Size(66, 19)
        cbAnAus.TabIndex = 5
        cbAnAus.Text = "Aus/An"
        cbAnAus.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(141, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 15)
        Label1.TabIndex = 6
        Label1.Text = "Schrittweite"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(183, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(27, 15)
        Label2.TabIndex = 7
        Label2.Text = "Aus"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(188, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(22, 15)
        Label3.TabIndex = 8
        Label3.Text = "An"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(747, 409)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cbAnAus)
        Controls.Add(schrittweite)
        Controls.Add(bisAn)
        Controls.Add(bisAus)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        Text = "Form1"
        CType(bisAus, ComponentModel.ISupportInitialize).EndInit()
        CType(bisAn, ComponentModel.ISupportInitialize).EndInit()
        CType(schrittweite, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents bisAus As NumericUpDown
    Friend WithEvents bisAn As NumericUpDown
    Friend WithEvents schrittweite As NumericUpDown
    Friend WithEvents cbAnAus As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
