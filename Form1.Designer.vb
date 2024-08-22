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
        btnAnmelden = New Button()
        txtBenutzername = New TextBox()
        txtPasswort = New TextBox()
        txtNeuPasswort = New TextBox()
        txtNeuBenutzername = New TextBox()
        txtNeuPasswortWiederholen = New TextBox()
        btnRegistrieren = New Button()
        SuspendLayout()
        ' 
        ' btnAnmelden
        ' 
        btnAnmelden.Location = New Point(88, 92)
        btnAnmelden.Name = "btnAnmelden"
        btnAnmelden.Size = New Size(205, 35)
        btnAnmelden.TabIndex = 0
        btnAnmelden.Text = "Anmelden"
        btnAnmelden.UseVisualStyleBackColor = True
        ' 
        ' txtBenutzername
        ' 
        txtBenutzername.Location = New Point(88, 34)
        txtBenutzername.Name = "txtBenutzername"
        txtBenutzername.Size = New Size(205, 23)
        txtBenutzername.TabIndex = 1
        ' 
        ' txtPasswort
        ' 
        txtPasswort.Location = New Point(88, 63)
        txtPasswort.Name = "txtPasswort"
        txtPasswort.PasswordChar = "*"c
        txtPasswort.Size = New Size(205, 23)
        txtPasswort.TabIndex = 2
        ' 
        ' txtNeuPasswort
        ' 
        txtNeuPasswort.Location = New Point(88, 200)
        txtNeuPasswort.Name = "txtNeuPasswort"
        txtNeuPasswort.PasswordChar = "*"c
        txtNeuPasswort.Size = New Size(205, 23)
        txtNeuPasswort.TabIndex = 5
        ' 
        ' txtNeuBenutzername
        ' 
        txtNeuBenutzername.Location = New Point(88, 171)
        txtNeuBenutzername.Name = "txtNeuBenutzername"
        txtNeuBenutzername.Size = New Size(205, 23)
        txtNeuBenutzername.TabIndex = 4
        ' 
        ' txtNeuPasswortWiederholen
        ' 
        txtNeuPasswortWiederholen.Location = New Point(88, 229)
        txtNeuPasswortWiederholen.Name = "txtNeuPasswortWiederholen"
        txtNeuPasswortWiederholen.PasswordChar = "*"c
        txtNeuPasswortWiederholen.Size = New Size(205, 23)
        txtNeuPasswortWiederholen.TabIndex = 6
        ' 
        ' btnRegistrieren
        ' 
        btnRegistrieren.Location = New Point(88, 258)
        btnRegistrieren.Name = "btnRegistrieren"
        btnRegistrieren.Size = New Size(205, 35)
        btnRegistrieren.TabIndex = 7
        btnRegistrieren.Text = "Registrieren"
        btnRegistrieren.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(747, 409)
        Controls.Add(btnRegistrieren)
        Controls.Add(txtNeuPasswortWiederholen)
        Controls.Add(txtNeuPasswort)
        Controls.Add(txtNeuBenutzername)
        Controls.Add(txtPasswort)
        Controls.Add(txtBenutzername)
        Controls.Add(btnAnmelden)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAnmelden As Button
    Friend WithEvents txtBenutzername As TextBox
    Friend WithEvents txtPasswort As TextBox
    Friend WithEvents txtNeuPasswort As TextBox
    Friend WithEvents txtNeuBenutzername As TextBox
    Friend WithEvents txtNeuPasswortWiederholen As TextBox
    Friend WithEvents btnRegistrieren As Button

End Class
