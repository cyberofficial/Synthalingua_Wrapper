Imports System.Windows.Forms

Public Class DisclaimerForm
    Inherits Form

    Private ReadOnly titleLabel As New Label()
    Private ReadOnly introLabel As New Label()
    Private ReadOnly guidelinesLabel As New Label()
    Private ReadOnly guideline1Label As New Label()
    Private ReadOnly guideline2Label As New Label()
    Private ReadOnly guideline3Label As New Label()
    Private ReadOnly guideline4Label As New Label()
    Private ReadOnly guideline5Label As New Label()
    Private ReadOnly guideline6Label As New Label()
    Private ReadOnly goodUseLabel As New Label()
    Private ReadOnly goodUse1Label As New Label()
    Private ReadOnly goodUse2Label As New Label()
    Private ReadOnly goodUse3Label As New Label()
    Private ReadOnly goodUse4Label As New Label()
    Private ReadOnly dontUseLabel As New Label()
    Private ReadOnly dontUse1Label As New Label()
    Private ReadOnly dontUse2Label As New Label()
    Private ReadOnly dontUse3Label As New Label()
    Private ReadOnly dontUse4Label As New Label()
    Private ReadOnly agreementLabel As New Label()
    Private ReadOnly agreeButton As New Button()
    Private ReadOnly disagreeButton As New Button()

    Public Sub New()
        InitializeComponent()
        AddHandler agreeButton.Click, AddressOf AgreeButton_Click
        AddHandler disagreeButton.Click, AddressOf DisagreeButton_Click
    End Sub

    Private Sub InitializeComponent()
        SuspendLayout()

        ' Title Label
        titleLabel.AutoSize = True
        titleLabel.Font = New Font("Segoe UI", 14.0!, FontStyle.Bold)
        titleLabel.ForeColor = Color.FromArgb(33, 37, 41)
        titleLabel.Location = New Point(20, 20)
        titleLabel.Name = "titleLabel"
        titleLabel.Size = New Size(200, 25)
        titleLabel.TabIndex = 0
        titleLabel.Text = "Legal & Friendly Disclaimer"

        ' Intro Label
        introLabel.AutoSize = True
        introLabel.Font = New Font("Segoe UI", 9.0!)
        introLabel.ForeColor = Color.FromArgb(73, 80, 87)
        introLabel.Location = New Point(20, 55)
        introLabel.Name = "introLabel"
        introLabel.Size = New Size(640, 30)
        introLabel.TabIndex = 1
        introLabel.Text = "Hey there! Synthalingua is a fun and powerful tool for exploring languages, learning, and enjoying live translations." & vbCrLf & "But just like any tool, it comes with a few important guidelines to keep things safe, legal, and friendly for everyone."

        ' Guidelines Header
        guidelinesLabel.AutoSize = True
        guidelinesLabel.Font = New Font("Segoe UI", 11.0!, FontStyle.Bold)
        guidelinesLabel.ForeColor = Color.FromArgb(33, 37, 41)
        guidelinesLabel.Location = New Point(20, 100)
        guidelinesLabel.Name = "guidelinesLabel"
        guidelinesLabel.Size = New Size(100, 18)
        guidelinesLabel.TabIndex = 2
        guidelinesLabel.Text = "Important Guidelines:"

        ' Guideline 1
        guideline1Label.AutoSize = True
        guideline1Label.Font = New Font("Segoe UI", 9.0!)
        guideline1Label.ForeColor = Color.FromArgb(52, 58, 64)
        guideline1Label.Location = New Point(35, 125)
        guideline1Label.Name = "guideline1Label"
        guideline1Label.Size = New Size(625, 15)
        guideline1Label.TabIndex = 3
        guideline1Label.Text = "• Synthalingua is a tool, not a service. You run it on your own computer, and you are in control."

        ' Guideline 2
        guideline2Label.AutoSize = True
        guideline2Label.Font = New Font("Segoe UI", 9.0!)
        guideline2Label.ForeColor = Color.FromArgb(52, 58, 64)
        guideline2Label.Location = New Point(35, 145)
        guideline2Label.Name = "guideline2Label"
        guideline2Label.Size = New Size(625, 15)
        guideline2Label.TabIndex = 4
        guideline2Label.Text = "• For fun, learning, and curiosity! Use Synthalingua to practice languages, understand foreign content, or experiment with AI audio."

        ' Guideline 3
        guideline3Label.AutoSize = True
        guideline3Label.Font = New Font("Segoe UI", 9.0!)
        guideline3Label.ForeColor = Color.FromArgb(52, 58, 64)
        guideline3Label.Location = New Point(35, 165)
        guideline3Label.Name = "guideline3Label"
        guideline3Label.Size = New Size(625, 15)
        guideline3Label.TabIndex = 5
        guideline3Label.Text = "• Not for official or critical use. Please don't rely on Synthalingua for legal, medical, business, or other important communications."

        ' Guideline 4
        guideline4Label.AutoSize = True
        guideline4Label.Font = New Font("Segoe UI", 9.0!)
        guideline4Label.ForeColor = Color.FromArgb(52, 58, 64)
        guideline4Label.Location = New Point(35, 185)
        guideline4Label.Name = "guideline4Label"
        guideline4Label.Size = New Size(625, 15)
        guideline4Label.TabIndex = 6
        guideline4Label.Text = "• Be kind and ethical. Don't use Synthalingua to spread misinformation, harass others, or break the law."

        ' Guideline 5
        guideline5Label.AutoSize = True
        guideline5Label.Font = New Font("Segoe UI", 9.0!)
        guideline5Label.ForeColor = Color.FromArgb(52, 58, 64)
        guideline5Label.Location = New Point(35, 205)
        guideline5Label.Name = "guideline5Label"
        guideline5Label.Size = New Size(625, 15)
        guideline5Label.TabIndex = 7
        guideline5Label.Text = "• Respect privacy and copyright. Only process audio or video you have the right to use."

        ' Guideline 6
        guideline6Label.AutoSize = True
        guideline6Label.Font = New Font("Segoe UI", 9.0!)
        guideline6Label.ForeColor = Color.FromArgb(52, 58, 64)
        guideline6Label.Location = New Point(35, 225)
        guideline6Label.Name = "guideline6Label"
        guideline6Label.Size = New Size(625, 15)
        guideline6Label.TabIndex = 8
        guideline6Label.Text = "• No warranty or liability. I built Synthalingua for the community, but I can't take responsibility for how it's used."

        ' Good Use Header
        goodUseLabel.AutoSize = True
        goodUseLabel.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        goodUseLabel.ForeColor = Color.FromArgb(25, 135, 84)
        goodUseLabel.Location = New Point(20, 255)
        goodUseLabel.Name = "goodUseLabel"
        goodUseLabel.Size = New Size(150, 17)
        goodUseLabel.TabIndex = 9
        goodUseLabel.Text = "✅ Examples of Good Use"

        ' Good Use 1
        goodUse1Label.AutoSize = True
        goodUse1Label.Font = New Font("Segoe UI", 9.0!)
        goodUse1Label.ForeColor = Color.FromArgb(52, 58, 64)
        goodUse1Label.Location = New Point(35, 280)
        goodUse1Label.Name = "goodUse1Label"
        goodUse1Label.Size = New Size(625, 15)
        goodUse1Label.TabIndex = 10
        goodUse1Label.Text = "• Translating a livestream for your own understanding"

        ' Good Use 2
        goodUse2Label.AutoSize = True
        goodUse2Label.Font = New Font("Segoe UI", 9.0!)
        goodUse2Label.ForeColor = Color.FromArgb(52, 58, 64)
        goodUse2Label.Location = New Point(35, 300)
        goodUse2Label.Name = "goodUse2Label"
        goodUse2Label.Size = New Size(625, 15)
        goodUse2Label.TabIndex = 11
        goodUse2Label.Text = "• Practicing a new language by listening to foreign media"

        ' Good Use 3
        goodUse3Label.AutoSize = True
        goodUse3Label.Font = New Font("Segoe UI", 9.0!)
        goodUse3Label.ForeColor = Color.FromArgb(52, 58, 64)
        goodUse3Label.Location = New Point(35, 320)
        goodUse3Label.Name = "goodUse3Label"
        goodUse3Label.Size = New Size(625, 15)
        goodUse3Label.TabIndex = 12
        goodUse3Label.Text = "• Making fun subtitles for a YouTube video you have rights to"

        ' Good Use 4
        goodUse4Label.AutoSize = True
        goodUse4Label.Font = New Font("Segoe UI", 9.0!)
        goodUse4Label.ForeColor = Color.FromArgb(52, 58, 64)
        goodUse4Label.Location = New Point(35, 340)
        goodUse4Label.Name = "goodUse4Label"
        goodUse4Label.Size = New Size(625, 15)
        goodUse4Label.TabIndex = 13
        goodUse4Label.Text = "• Learning how AI models handle different accents or languages"

        ' Don't Use Header
        dontUseLabel.AutoSize = True
        dontUseLabel.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        dontUseLabel.ForeColor = Color.FromArgb(220, 53, 69)
        dontUseLabel.Location = New Point(20, 370)
        dontUseLabel.Name = "dontUseLabel"
        dontUseLabel.Size = New Size(100, 17)
        dontUseLabel.TabIndex = 14
        dontUseLabel.Text = "❌ Please Don't"

        ' Don't Use 1
        dontUse1Label.AutoSize = True
        dontUse1Label.Font = New Font("Segoe UI", 9.0!)
        dontUse1Label.ForeColor = Color.FromArgb(52, 58, 64)
        dontUse1Label.Location = New Point(35, 395)
        dontUse1Label.Name = "dontUse1Label"
        dontUse1Label.Size = New Size(625, 15)
        dontUse1Label.TabIndex = 15
        dontUse1Label.Text = "• Use Synthalingua to translate confidential work meetings or private calls without consent"

        ' Don't Use 2
        dontUse2Label.AutoSize = True
        dontUse2Label.Font = New Font("Segoe UI", 9.0!)
        dontUse2Label.ForeColor = Color.FromArgb(52, 58, 64)
        dontUse2Label.Location = New Point(35, 415)
        dontUse2Label.Name = "dontUse2Label"
        dontUse2Label.Size = New Size(625, 15)
        dontUse2Label.TabIndex = 16
        dontUse2Label.Text = "• Rely on it for medical, legal, or business decisions"

        ' Don't Use 3
        dontUse3Label.AutoSize = True
        dontUse3Label.Font = New Font("Segoe UI", 9.0!)
        dontUse3Label.ForeColor = Color.FromArgb(52, 58, 64)
        dontUse3Label.Location = New Point(35, 435)
        dontUse3Label.Name = "dontUse3Label"
        dontUse3Label.Size = New Size(625, 15)
        dontUse3Label.TabIndex = 17
        dontUse3Label.Text = "• Use it to bypass paywalls, copyright, or platform rules"

        ' Don't Use 4
        dontUse4Label.AutoSize = True
        dontUse4Label.Font = New Font("Segoe UI", 9.0!)
        dontUse4Label.ForeColor = Color.FromArgb(52, 58, 64)
        dontUse4Label.Location = New Point(35, 455)
        dontUse4Label.Name = "dontUse4Label"
        dontUse4Label.Size = New Size(625, 15)
        dontUse4Label.TabIndex = 18
        dontUse4Label.Text = "• Share or publish AI-generated translations as if they are 100% accurate or official"

        ' Agreement Label
        agreementLabel.AutoSize = True
        agreementLabel.Font = New Font("Segoe UI", 9.0!, FontStyle.Italic)
        agreementLabel.ForeColor = Color.FromArgb(108, 117, 125)
        agreementLabel.Location = New Point(20, 485)
        agreementLabel.Name = "agreementLabel"
        agreementLabel.Size = New Size(640, 15)
        agreementLabel.TabIndex = 19
        agreementLabel.Text = "By using Synthalingua, you agree to use it responsibly and accept full responsibility for your actions. Let's keep it fun, safe, and positive for everyone!"

        ' Agree Button
        agreeButton.BackColor = Color.FromArgb(25, 135, 84)
        agreeButton.FlatStyle = FlatStyle.Flat
        agreeButton.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        agreeButton.ForeColor = Color.White
        agreeButton.Location = New Point(472, 520)
        agreeButton.Name = "agreeButton"
        agreeButton.Size = New Size(100, 35)
        agreeButton.TabIndex = 20
        agreeButton.Text = "I Agree"
        agreeButton.UseVisualStyleBackColor = False

        ' Disagree Button
        disagreeButton.BackColor = Color.FromArgb(220, 53, 69)
        disagreeButton.FlatStyle = FlatStyle.Flat
        disagreeButton.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        disagreeButton.ForeColor = Color.White
        disagreeButton.Location = New Point(580, 520)
        disagreeButton.Name = "disagreeButton"
        disagreeButton.Size = New Size(100, 35)
        disagreeButton.TabIndex = 21
        disagreeButton.Text = "I Disagree"
        disagreeButton.UseVisualStyleBackColor = False

        ' DisclaimerForm
        AcceptButton = agreeButton
        AutoScaleDimensions = New SizeF(6.0!, 13.0!)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        CancelButton = disagreeButton
        ClientSize = New Size(700, 570)
        Controls.Add(agreementLabel)
        Controls.Add(dontUse4Label)
        Controls.Add(dontUse3Label)
        Controls.Add(dontUse2Label)
        Controls.Add(dontUse1Label)
        Controls.Add(dontUseLabel)
        Controls.Add(goodUse4Label)
        Controls.Add(goodUse3Label)
        Controls.Add(goodUse2Label)
        Controls.Add(goodUse1Label)
        Controls.Add(goodUseLabel)
        Controls.Add(guideline6Label)
        Controls.Add(guideline5Label)
        Controls.Add(guideline4Label)
        Controls.Add(guideline3Label)
        Controls.Add(guideline2Label)
        Controls.Add(guideline1Label)
        Controls.Add(guidelinesLabel)
        Controls.Add(introLabel)
        Controls.Add(titleLabel)
        Controls.Add(disagreeButton)
        Controls.Add(agreeButton)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "DisclaimerForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Synthalingua Disclaimer Agreement"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private Sub AgreeButton_Click(sender As Object, e As EventArgs)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub DisagreeButton_Click(sender As Object, e As EventArgs)
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class