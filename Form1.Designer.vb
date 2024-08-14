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
        EinsEins = New Label()
        EinsZwei = New Label()
        DreiEins = New Label()
        ZweiEins = New Label()
        ZweiZwei = New Label()
        EinsDrei = New Label()
        ZweiDrei = New Label()
        DreiZwei = New Label()
        DreiDrei = New Label()
        SuspendLayout()
        ' 
        ' EinsEins
        ' 
        EinsEins.BorderStyle = BorderStyle.FixedSingle
        EinsEins.Font = New Font("Segoe UI", 20F)
        EinsEins.ForeColor = SystemColors.Control
        EinsEins.Location = New Point(12, 9)
        EinsEins.Name = "EinsEins"
        EinsEins.Size = New Size(50, 50)
        EinsEins.TabIndex = 0
        EinsEins.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' EinsZwei
        ' 
        EinsZwei.BorderStyle = BorderStyle.FixedSingle
        EinsZwei.Font = New Font("Segoe UI", 20F)
        EinsZwei.ForeColor = SystemColors.Control
        EinsZwei.Location = New Point(112, 9)
        EinsZwei.Name = "EinsZwei"
        EinsZwei.Size = New Size(50, 50)
        EinsZwei.TabIndex = 1
        EinsZwei.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DreiEins
        ' 
        DreiEins.BorderStyle = BorderStyle.FixedSingle
        DreiEins.Font = New Font("Segoe UI", 20F)
        DreiEins.ForeColor = SystemColors.Control
        DreiEins.Location = New Point(12, 209)
        DreiEins.Name = "DreiEins"
        DreiEins.Size = New Size(50, 50)
        DreiEins.TabIndex = 2
        DreiEins.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ZweiEins
        ' 
        ZweiEins.BorderStyle = BorderStyle.FixedSingle
        ZweiEins.Font = New Font("Segoe UI", 20F)
        ZweiEins.ForeColor = SystemColors.Control
        ZweiEins.Location = New Point(12, 109)
        ZweiEins.Name = "ZweiEins"
        ZweiEins.Size = New Size(50, 50)
        ZweiEins.TabIndex = 3
        ZweiEins.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ZweiZwei
        ' 
        ZweiZwei.BorderStyle = BorderStyle.FixedSingle
        ZweiZwei.Font = New Font("Segoe UI", 20F)
        ZweiZwei.ForeColor = SystemColors.Control
        ZweiZwei.Location = New Point(112, 109)
        ZweiZwei.Name = "ZweiZwei"
        ZweiZwei.Size = New Size(50, 50)
        ZweiZwei.TabIndex = 4
        ZweiZwei.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' EinsDrei
        ' 
        EinsDrei.BorderStyle = BorderStyle.FixedSingle
        EinsDrei.Font = New Font("Segoe UI", 20F)
        EinsDrei.ForeColor = SystemColors.Control
        EinsDrei.Location = New Point(212, 9)
        EinsDrei.Name = "EinsDrei"
        EinsDrei.Size = New Size(50, 50)
        EinsDrei.TabIndex = 5
        EinsDrei.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ZweiDrei
        ' 
        ZweiDrei.BorderStyle = BorderStyle.FixedSingle
        ZweiDrei.Font = New Font("Segoe UI", 20F)
        ZweiDrei.ForeColor = SystemColors.Control
        ZweiDrei.Location = New Point(212, 109)
        ZweiDrei.Name = "ZweiDrei"
        ZweiDrei.Size = New Size(50, 50)
        ZweiDrei.TabIndex = 6
        ZweiDrei.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DreiZwei
        ' 
        DreiZwei.BorderStyle = BorderStyle.FixedSingle
        DreiZwei.Font = New Font("Segoe UI", 20F)
        DreiZwei.ForeColor = SystemColors.Control
        DreiZwei.Location = New Point(112, 209)
        DreiZwei.Name = "DreiZwei"
        DreiZwei.Size = New Size(50, 50)
        DreiZwei.TabIndex = 7
        DreiZwei.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DreiDrei
        ' 
        DreiDrei.BorderStyle = BorderStyle.FixedSingle
        DreiDrei.Font = New Font("Segoe UI", 20F)
        DreiDrei.ForeColor = SystemColors.Control
        DreiDrei.Location = New Point(212, 209)
        DreiDrei.Name = "DreiDrei"
        DreiDrei.Size = New Size(50, 50)
        DreiDrei.TabIndex = 8
        DreiDrei.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(281, 273)
        Controls.Add(DreiDrei)
        Controls.Add(DreiZwei)
        Controls.Add(ZweiDrei)
        Controls.Add(EinsDrei)
        Controls.Add(ZweiZwei)
        Controls.Add(ZweiEins)
        Controls.Add(DreiEins)
        Controls.Add(EinsZwei)
        Controls.Add(EinsEins)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents EinsEins As Label
    Friend WithEvents EinsZwei As Label
    Friend WithEvents DreiEins As Label
    Friend WithEvents ZweiEins As Label
    Friend WithEvents ZweiZwei As Label
    Friend WithEvents EinsDrei As Label
    Friend WithEvents ZweiDrei As Label
    Friend WithEvents DreiZwei As Label
    Friend WithEvents DreiDrei As Label

End Class
