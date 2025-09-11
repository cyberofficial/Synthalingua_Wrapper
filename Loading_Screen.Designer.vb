<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loading_Screen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loading_Screen))
        Copyright = New Label()
        Version = New Label()
        SuspendLayout()
        ' 
        ' Copyright
        ' 
        Copyright.AutoSize = True
        Copyright.BackColor = Color.Transparent
        Copyright.Font = New Font("Segoe UI", 12F)
        Copyright.ForeColor = Color.Magenta
        Copyright.Location = New Point(12, 9)
        Copyright.Name = "Copyright"
        Copyright.Size = New Size(81, 21)
        Copyright.TabIndex = 1
        Copyright.Text = "Build Date"
        ' 
        ' Version
        ' 
        Version.AutoSize = True
        Version.BackColor = Color.Transparent
        Version.Font = New Font("Segoe UI", 15F)
        Version.ForeColor = Color.Magenta
        Version.Location = New Point(12, 261)
        Version.Name = "Version"
        Version.Size = New Size(76, 28)
        Version.TabIndex = 2
        Version.Text = "Version"
        ' 
        ' Loading_Screen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImage = My.Resources.Resources.Synthalingua_chan_logo_512x512
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(298, 298)
        ControlBox = False
        Controls.Add(Version)
        Controls.Add(Copyright)
        DoubleBuffered = True
        ForeColor = Color.Black
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Loading_Screen"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        TransparencyKey = SystemColors.ActiveCaption
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents Copyright As Label
    Friend WithEvents Version As Label

End Class
