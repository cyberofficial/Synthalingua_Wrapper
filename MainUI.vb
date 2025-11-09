Imports System.IO
Imports System.Diagnostics
Imports System.Threading
Imports System.Text
Imports System.ComponentModel
Imports System.Security.Principal

Public Class MainUI
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property PrimaryFolder As String
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property ShortCutType As String
    Private Shared appMutex As Mutex
    Private ReadOnly toolTipManager As ToolTipManager
    Public WordBlockListLocation As String = "blacklist.txt"

    ' JetBrains legal notice template
    Private Const JetBrainsLegalNotice As String = "Copyright © 2025 JetBrains s.r.o. PyCharm and the PyCharm logo are trademarks of JetBrains s.r.o."
    Private Const JetBrainsUrl As String = "https://www.jetbrains.com/pycharm/"
    Private Const JetBrainsTrackingUrl As String = "https://www.jetbrains.com/pycharm/?from=Synthalingua"

    Public Sub New()
        InitializeComponent()
        toolTipManager = New ToolTipManager(ToolTip1)

        ' Attach event handlers for JetBrainsLogoImg
        AddHandler JetBrainsLogoImg.MouseHover, AddressOf JetBrainsLogoImg_MouseHover
        AddHandler JetBrainsLogoImg.Click, AddressOf JetBrainsLogoImg_Click

        ' Attach event handler for GitHubSponsorPicture
        AddHandler GitHubSponsorPicture.MouseHover, AddressOf GitHubSponsorPicture_MouseHover

        ' Attach event handlers for DisableSynthalinguaChan hover effects
        AddHandler DisableSynthalinguaChan.MouseEnter, AddressOf DisableSynthalinguaChan_MouseEnter
        AddHandler DisableSynthalinguaChan.MouseLeave, AddressOf DisableSynthalinguaChan_MouseLeave
    End Sub

    Private Function IsRunningAsAdmin() As Boolean
        Dim identity = WindowsIdentity.GetCurrent()
        Dim principal = New WindowsPrincipal(identity)
        Return principal.IsInRole(WindowsBuiltInRole.Administrator)
    End Function

    Private Function ValidatePortNumber() As Boolean
        If PortNumber.Value < 8000 AndAlso Not IsRunningAsAdmin() Then
            MessageBox.Show("Port numbers below 8000 are reserved for Windows administrators. Please select a port number of 8000 or higher, or run the application as administrator.", "Port Number Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function
    ' Show legal notice on hover
    Private Sub JetBrainsLogoImg_MouseHover(sender As Object, e As EventArgs)
        ToolTip1.SetToolTip(JetBrainsLogoImg, JetBrainsLegalNotice)
    End Sub

    ' Show legal notice and open URL on click
    Private Sub JetBrainsLogoImg_Click(sender As Object, e As EventArgs)
        Dim result = MessageBox.Show(JetBrainsLegalNotice & vbCrLf & vbCrLf & "Click OK to open the PyCharm website, or Cancel to stay.", "JetBrains Legal Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If result = DialogResult.OK Then
            Try
                Process.Start(New ProcessStartInfo With {
                    .FileName = JetBrainsTrackingUrl,
                    .UseShellExecute = True
                })
            Catch ex As Exception
                MessageBox.Show("Unable to open the web page: " & ex.Message)
            End Try
        End If
    End Sub

    ' Show GitHub Sponsors tooltip on hover
    Private Sub GitHubSponsorPicture_MouseHover(sender As Object, e As EventArgs)
        ToolTip1.SetToolTip(GitHubSponsorPicture, "Will open to https://github.com/sponsors/cyberofficial")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles SearchForProgramBTN.Click
        If Label1.ForeColor = Color.Red Then
            Label1.ForeColor = Color.Black
        End If

        Dim result = OpenScriptDiag.ShowDialog

        If result = DialogResult.Cancel Then
            MessageBox.Show("Action Canceled")
            Return
        End If

        ScriptFileLocation.Text = OpenScriptDiag.FileName
        PrimaryFolder = Path.GetDirectoryName(OpenScriptDiag.FileName)
        ShortCutType = If(Path.GetExtension(OpenScriptDiag.FileName) = ".py", "Source", "Portable")
    End Sub

    Private Sub ChunkSizeTrackBar_ValueChanged(sender As Object, e As EventArgs) Handles ChunkSizeTrackBar.ValueChanged
        ChunkSizeTrackBarValue.Text = "Chunks: " & ChunkSizeTrackBar.Value
    End Sub

    Private Sub paddedaudio_value_ValueChanged(sender As Object, e As EventArgs) Handles paddedaudio_value.ValueChanged
        paddedaudio_nvalue.Text = paddedaudio_value.Value.ToString()
    End Sub

    <Obsolete>
    Private Sub GenerateConfigButton_Click(sender As Object, e As EventArgs) Handles GenerateConfigButton.Click
        ' Validate port number
        If Not ValidatePortNumber() Then
            Exit Sub
        End If

        ' Validate StreamLanguage and SecondaryTranslationLanguage
        If Not StreamLanguage.Items.Contains(StreamLanguage.Text) Then
            MessageBox.Show($"The language '{StreamLanguage.Text}' doesn't exist in the item list.", "Invalid Language", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If SecondaryTranslation.Checked AndAlso Not SecondaryTranslationLanguage.Items.Contains(SecondaryTranslationLanguage.Text) Then
            MessageBox.Show($"The language '{SecondaryTranslationLanguage.Text}' doesn't exist in the item list.", "Invalid Language", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        ' AutoHLS_Checkbox is now handled in config and command generation
        Try
            Dim generator As New CommandGenerator(Me)
            ConfigTextBox.Text = generator.Generate()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SaveConfigToFileButton_Click(sender As Object, e As EventArgs) Handles SaveConfigToFileButton.Click
        SaveFileDialog.Filter = "Batch File|*.bat"
        SaveFileDialog.Title = "Save Config File"
        Dim result = SaveFileDialog.ShowDialog
        If SaveFileDialog.FileName <> "" Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog.FileName, ConfigTextBox.Text, False)
        End If
    End Sub

    Private Sub RunScript_Click(sender As Object, e As EventArgs) Handles RunScript.Click
        ' Validate StreamLanguage and SecondaryTranslationLanguage
        If Not StreamLanguage.Items.Contains(StreamLanguage.Text) Then
            MessageBox.Show($"The language '{StreamLanguage.Text}' doesn't exist in the item list.", "Invalid Language", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If SecondaryTranslation.Checked AndAlso Not SecondaryTranslationLanguage.Items.Contains(SecondaryTranslationLanguage.Text) Then
            MessageBox.Show($"The language '{SecondaryTranslationLanguage.Text}' doesn't exist in the item list.", "Invalid Language", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If String.IsNullOrEmpty(ScriptFileLocation.Text) Then
            MessageBox.Show("Please select the program file.")
            Exit Sub
        End If
        If String.IsNullOrEmpty(ConfigTextBox.Text) Then
            MessageBox.Show("Click generate first.")
            Exit Sub
        End If
        If CAP_RadioButton.Checked AndAlso (String.IsNullOrEmpty(CaptionsName.Text) OrElse
                                          String.IsNullOrEmpty(CaptionsOutput.Text) OrElse
                                          String.IsNullOrEmpty(CaptionsInput.Text)) Then
            MessageBox.Show("Please set all caption-related fields.")
            Exit Sub
        End If

        Try
            If My.Settings.PrimaryFolder IsNot Nothing AndAlso My.Settings.PrimaryFolder <> "" Then
                PrimaryFolder = My.Settings.PrimaryFolder
            End If
        Catch ex As Exception
        End Try

        If String.IsNullOrEmpty(PrimaryFolder) Then
            MessageBox.Show("Primary folder is not set.")
            Exit Sub
        End If

        Dim tmpBatFile As String = Path.Combine(PrimaryFolder, "tmp.bat")
        File.WriteAllText(tmpBatFile, ConfigTextBox.Text)
        Process.Start(tmpBatFile)
    End Sub

    Private Sub microphone_id_button_Click(sender As Object, e As EventArgs) Handles microphone_id_button.Click
        If Not MIC_RadioButton.Checked Then
            MessageBox.Show("Please select the microphone option")
            Return
        End If

        If String.IsNullOrEmpty(ScriptFileLocation.Text) Then
            MessageBox.Show("Please select the program file.")
            Return
        End If

        'If ScriptFileLocation.Text.Contains(" ") Then
        '    MessageBox.Show("Please select a program file that does not have spaces in the file path.")
        '    Return
        'End If

        Try
            Dim tmpBatFile As String = Path.Combine(PrimaryFolder, "tmp.bat")
            Dim command As String

            If ScriptFileLocation.Text.Contains(".py") Then
                command = $"call ""{PrimaryFolder}\data_whisper\Scripts\activate.bat"" {vbCrLf}python ""{ScriptFileLocation.Text}"" --microphone_enabled true --list_microphones"
            Else
                MessageBox.Show($"Running command: {ScriptFileLocation.Text} --microphone_enabled true --list_microphones")
                command = $"""{ScriptFileLocation.Text}"" --microphone_enabled true --list_microphones{vbCrLf}pause"
            End If

            File.WriteAllText(tmpBatFile, command)
            Process.Start(tmpBatFile)
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}{vbCrLf}Make sure the program path is valid and all required files are present.")
        End Try
    End Sub

    Private Sub WebLinkOG_Click(sender As Object, e As EventArgs) Handles WebLinkOG.Click
        WebManager.CopyWebLinkToClipboard(PortNumber.Value, "original")
    End Sub

    Private Sub WebLinkT1_Click(sender As Object, e As EventArgs) Handles WebLinkT1.Click
        WebManager.CopyWebLinkToClipboard(PortNumber.Value, "translation")
    End Sub

    Private Sub WebLinkT2_Click(sender As Object, e As EventArgs) Handles WebLinkT2.Click
        WebManager.CopyWebLinkToClipboard(PortNumber.Value, "transcription")
    End Sub

    Private Sub MainUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & " v" & My.Application.Info.Version.ToString()

        ' Check terms acceptance
        Dim termsFile As String = Path.Combine(Application.StartupPath, "accepted_terms.txt")
        If Not File.Exists(termsFile) OrElse Not File.ReadAllText(termsFile).Trim().Equals("accepted=true", StringComparison.OrdinalIgnoreCase) Then
            Using disclaimerForm As New DisclaimerForm()
                If disclaimerForm.ShowDialog() = DialogResult.OK Then
                    File.WriteAllText(termsFile, "accepted=true")
                Else
                    Application.Exit()
                    Return
                End If
            End Using
        End If

        Dim createdNew As Boolean
        appMutex = New Mutex(True, "Synthalingua_Wrapper", createdNew)

        ConfigManager.LoadConfig(Me)
        FileOperations.InitializeCookiesFolder(System.IO.Directory.GetCurrentDirectory())
        FileOperations.RefreshCookiesList(CookiesName)

        Dim cpuCores As Integer = Environment.ProcessorCount

        ' Set demucs_model_jobs minimum to 1 and maximum to CPU core count
        Try
            demucs_model_jobs.Minimum = 0
            demucs_model_jobs.Maximum = cpuCores
        Catch ex As Exception
            demucs_model_jobs.Minimum = 0
            demucs_model_jobs.Maximum = 1 ' fallback default
        End Try

        ' Set batchjobs minimum to 1 and maximum to CPU core count
        Try
            batchjobs.Minimum = 1
            batchjobs.Maximum = cpuCores
        Catch ex As Exception
            batchjobs.Minimum = 1
            batchjobs.Maximum = 4
        End Try

        ' Load saved value from user settings if available
        If My.Settings.demucs_model_jobs >= demucs_model_jobs.Minimum AndAlso My.Settings.demucs_model_jobs <= demucs_model_jobs.Maximum Then
            demucs_model_jobs.Value = My.Settings.demucs_model_jobs
        Else
            demucs_model_jobs.Value = demucs_model_jobs.Minimum
        End If

        If String.IsNullOrEmpty(ScriptFileLocation.Text) Then
            ' First try to find synthalingua.exe in the current running directory
            Dim currentDir As String = System.IO.Directory.GetCurrentDirectory()
            Dim synthalinguaExePath As String = Path.Combine(currentDir, "synthalingua.exe")

            If File.Exists(synthalinguaExePath) Then
                ScriptFileLocation.Text = synthalinguaExePath
                PrimaryFolder = currentDir
                ShortCutType = "Portable"
            Else
                ' Fallback to the existing FileOperations.FindScriptFile logic
                Dim scriptInfo = FileOperations.FindScriptFile(currentDir)
                If Not String.IsNullOrEmpty(scriptInfo.ScriptPath) Then
                    ScriptFileLocation.Text = scriptInfo.ScriptPath
                    PrimaryFolder = scriptInfo.FolderPath
                    ShortCutType = scriptInfo.ShortcutType
                End If
            End If
        End If

        toolTipManager.SetupTooltips(Me)

        ' Check if the folder 'fonts' exists in the current directory, if not create it
        Dim fontsFolder As String = Path.Combine(System.IO.Directory.GetCurrentDirectory(), "fonts")

        ' Check the fonts folder and add to "substyle_fontname" drop down each filename with extension
        If Not Directory.Exists(fontsFolder) Then
            Directory.CreateDirectory(fontsFolder)
        Else
            Dim fontFiles = Directory.GetFiles(fontsFolder, "*.*").Select(Function(f) Path.GetFileName(f)).ToArray()
            substyle_fontname.Items.Clear()
            substyle_fontname.Items.AddRange(fontFiles)
            If fontFiles.Length > 0 Then
                substyle_fontname.SelectedIndex = 0 ' Select the first font by default if available
            End If
        End If

        ' if settings for "substyle_color" is not set, make the dropdown item "white"
        If String.IsNullOrEmpty(substyle_color.Text) Then
            substyle_color.Text = "white"
        End If

        If Not createdNew Then
            MessageBox.Show("This application is already running. Please change the port number if you plan to use multiple instances.", "Instance Already Running", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub CookiesRefresh_Click(sender As Object, e As EventArgs) Handles CookiesRefresh.Click
        FileOperations.RefreshCookiesList(CookiesName)
    End Sub

    Private Sub WebLinkOG_MouseHover(sender As Object, e As EventArgs) Handles WebLinkOG.MouseHover
        toolTipManager.SetWebLinkToolTip(WebLinkOG, PortNumber.Value, "original")
    End Sub

    Private Sub WebLinkT1_MouseHover(sender As Object, e As EventArgs) Handles WebLinkT1.MouseHover
        toolTipManager.SetWebLinkToolTip(WebLinkT1, PortNumber.Value, "translation")
    End Sub

    Private Sub WebLinkT2_MouseHover(sender As Object, e As EventArgs) Handles WebLinkT2.MouseHover
        toolTipManager.SetWebLinkToolTip(WebLinkT2, PortNumber.Value, "transcription")
    End Sub

    Private Sub CheckBoxCMDBLock_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCMDBLock.CheckedChanged
        ConfigTextBox.Visible = CheckBoxCMDBLock.Checked
        ' Show or hide "SynthalinguaChan_IMG_10" based on CheckBoxCMDBLock state if checked then hide the image
        If CheckBoxCMDBLock.Checked Then
            SynthalinguaChan_IMG_10.Visible = False
        Else
            If Not DisableSynthalinguaChan.Checked Then
                SynthalinguaChan_IMG_10.Visible = True
            End If
        End If
    End Sub

    Private Sub Energy_Threshold_MouseClick(sender As Object, e As MouseEventArgs) Handles Energy_Threshold.MouseClick
        toolTipManager.ShowMicrophoneSettingsHelp("Energy_Threshold")
    End Sub

    Private Sub MicCaliLbl_MouseClick(sender As Object, e As MouseEventArgs) Handles MicCaliLbl.MouseClick
        toolTipManager.ShowMicrophoneSettingsHelp("MicCaliLbl")
    End Sub

    Private Sub RecordTimeoutLbl_MouseClick(sender As Object, e As MouseEventArgs) Handles RecordTimeoutLbl.MouseClick
        toolTipManager.ShowMicrophoneSettingsHelp("RecordTimeoutLbl")
    End Sub

    Private Sub PhraseTimeOutlbl_MouseClick(sender As Object, e As MouseEventArgs) Handles PhraseTimeOutlbl.MouseClick
        toolTipManager.ShowMicrophoneSettingsHelp("PhraseTimeOutlbl")
    End Sub

    Private Sub SetMicLbl_MouseClick(sender As Object, e As MouseEventArgs) Handles SetMicLbl.MouseClick
        toolTipManager.ShowMicrophoneSettingsHelp("SetMicLbl")
    End Sub

    Private Sub SetMicChunkSizeLbl_MouseClick(sender As Object, e As MouseEventArgs) Handles SetMicChunkSizeLbl.MouseClick
        toolTipManager.ShowMicrophoneSettingsHelp("SetMicChunkSizeLbl")
    End Sub

    Private Sub SubWindow_Click(sender As Object, e As EventArgs) Handles SubWindow.Click
        WebManager.ShowSubtitleWindow(WebServerButton.Checked, subtitlewindow)
    End Sub

    Private Sub CaptionsInputBtn_Click(sender As Object, e As EventArgs) Handles CaptionsInputBtn.Click
        Dim result = CaptionsInputFile.ShowDialog
        CaptionsInput.Text = CaptionsInputFile.FileName
        CaptionsName.Text = Path.GetFileNameWithoutExtension(CaptionsInputFile.SafeFileName)
        ' Set CaptionsOutput.Text to the folder of the selected file, without trailing backslash
        If Not String.IsNullOrEmpty(CaptionsInputFile.FileName) Then
            Dim folderPath As String = Path.GetDirectoryName(CaptionsInputFile.FileName)
            If Not String.IsNullOrEmpty(folderPath) Then
                CaptionsOutput.Text = folderPath
            End If
        End If
    End Sub

    Private Sub CaptionsOutputBtn_Click(sender As Object, e As EventArgs) Handles CaptionsOutputBtn.Click
        Dim result = FolderBrowserDialog1.ShowDialog
        CaptionsOutput.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub SaveConfig_Click(sender As Object, e As EventArgs) Handles SaveConfig.Click
        ConfigManager.SaveConfig(Me)
    End Sub

    Private Sub WipeSettings_Click(sender As Object, e As EventArgs) Handles WipeSettings.Click
        Dim confirmResult = MessageBox.Show("Are you sure you want to wipe all settings? This will reset all application settings and close the application.", "Confirm Wipe", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If confirmResult = DialogResult.Yes Then
            If EraseCheckBox.Checked Then
                Dim warningResult = MessageBox.Show("This action will clear all settings and close the application. Are you really sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If warningResult = DialogResult.Yes Then
                    My.Settings.Reset()
                    My.Settings.Save()
                    MessageBox.Show("All settings have been cleared. Application will close now.", "Settings Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Application.Exit()
                Else
                    EraseCheckBox.Checked = False
                End If
            Else
                MessageBox.Show("If you want to clear settings, click the checkbox first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub EditBlockList_Click(sender As Object, e As EventArgs) Handles EditBlockList.Click
        FileOperations.EditWordBlockList(ScriptFileLocation.Text, WordBlockListLocation)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using dialog As New OpenFileDialog With {
            .Filter = "Text File (*.txt)|*.txt",
            .Title = "Load a Word Block list."
        }
            dialog.ShowDialog()
            If dialog.FileName = "" Then
                MessageBox.Show("Word list not set", "Nothing was set.")
                Exit Sub
            End If
            WordBlockListLocation = dialog.FileName
            MessageBox.Show($"Loaded: {WordBlockListLocation}")
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowserConfig.ShowDialog()
    End Sub

    Private Sub cb_halspassword_CheckedChanged(sender As Object, e As EventArgs) Handles cb_halspassword.CheckedChanged
        HLS_URL.PasswordChar = If(cb_halspassword.Checked, "*"c, Nothing)
    End Sub

    Private Sub PictureItch_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureItch.MouseClick
        WebManager.OpenSocialLink("https://cyberofficial.itch.io/synthalingua")
    End Sub

    Private Sub GitHubPicture_MouseClick(sender As Object, e As MouseEventArgs) Handles GitHubPicture.MouseClick
        WebManager.OpenSocialLink("https://github.com/cyberofficial/Synthalingua")
    End Sub

    Private Sub KoFiPicture_MouseClick(sender As Object, e As MouseEventArgs) Handles KoFiPicture.MouseClick
        WebManager.OpenSocialLink("https://ko-fi.com/cyberofficial")
    End Sub

    Private Sub modelDirPicker_Click(sender As Object, e As EventArgs) Handles modelDirPicker.Click
        Using dialog As New FolderBrowserDialog()
            If dialog.ShowDialog() = DialogResult.OK Then
                modelDIr.Text = dialog.SelectedPath
            End If
        End Using
    End Sub

    Private Sub WhatModelsBtn_Click(sender As Object, e As EventArgs) Handles WhatModelsBtn.Click
        Dim info As String =
            "Model Name: htdemucs" & vbCrLf &
            "  Description: Latest Hybrid Transformer (default)" & vbCrLf &
            "  Recommended for: General music separation" & vbCrLf & vbCrLf &
            "Model Name: htdemucs_ft" & vbCrLf &
            "  Description: Fine-tuned for better quality" & vbCrLf &
            "  Recommended for: Highest quality separation" & vbCrLf & vbCrLf &
            "Model Name: htdemucs_6s" & vbCrLf &
            "  Description: 6-source separation (piano/guitar)" & vbCrLf &
            "  Recommended for: Detailed instrument separation" & vbCrLf & vbCrLf &
            "Model Name: hdemucs_mmi" & vbCrLf &
            "  Description: Hybrid v3, expanded dataset" & vbCrLf &
            "  Recommended for: Legacy compatibility" & vbCrLf & vbCrLf &
            "Model Name: mdx" & vbCrLf &
            "  Description: Frequency-domain MDX winner" & vbCrLf &
            "  Recommended for: Good quality, fast separation" & vbCrLf & vbCrLf &
            "Model Name: mdx_extra" & vbCrLf &
            "  Description: Enhanced with extra training data" & vbCrLf &
            "  Recommended for: Balanced quality and speed" & vbCrLf & vbCrLf &
            "Model Name: mdx_q" & vbCrLf &
            "  Description: Quantized MDX (faster)" & vbCrLf &
            "  Recommended for: Fastest separation" & vbCrLf & vbCrLf &
            "Model Name: mdx_extra_q" & vbCrLf &
            "  Description: Quantized MDX Extra" & vbCrLf &
            "  Recommended for: Fastest separation (extra data)" & vbCrLf & vbCrLf &
            "Model Name: hdemucs" & vbCrLf &
            "  Description: Original Hybrid Demucs v3" & vbCrLf &
            "  Recommended for: Legacy compatibility" & vbCrLf & vbCrLf &
            "Model Name: demucs" & vbCrLf &
            "  Description: Original time-domain" & vbCrLf &
            "  Recommended for: Legacy compatibility"
        MessageBox.Show(info, "Model Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub batchjobs_ValueChanged(sender As Object, e As EventArgs) Handles batchjobs.ValueChanged
        batchjobs_lbl.Text = "Batch Jobs (" + batchjobs.Value.ToString + ")"
        ' if batchjobs's value is greater than 1, then enable timeout, if 0 disable
        If batchjobs.Value > 1 Then
            timeout.Enabled = True
        Else
            timeout.Enabled = False
            If BatchModeAuto.Checked Then
                batchjobs_lbl.Text = "Batch Jobs (1)"
            Else
                batchjobs_lbl.Text = "Batch Jobs (disabled)"
            End If
        End If
    End Sub

    Private Sub substyle_fontname_refresh_Click(sender As Object, e As EventArgs) Handles substyle_fontname_refresh.Click
        ' Refresh the font list from the fonts folder
        Dim fontsFolder As String = Path.Combine(System.IO.Directory.GetCurrentDirectory(), "fonts")
        If Directory.Exists(fontsFolder) Then
            Dim fontFiles = Directory.GetFiles(fontsFolder, "*.*").Select(Function(f) Path.GetFileName(f)).ToArray()
            substyle_fontname.Items.Clear()
            substyle_fontname.Items.AddRange(fontFiles)
            If fontFiles.Length > 0 Then
                substyle_fontname.SelectedIndex = 0 ' Select the first font by default if available
            End If
        Else
            MessageBox.Show("Fonts folder does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DisableSynthalinguaChan_CheckedChanged(sender As Object, e As EventArgs) Handles DisableSynthalinguaChan.CheckedChanged
        If DisableSynthalinguaChan.Checked Then
            ' Hide all "SynthalinguaChan_IMG_" images 1 through 9
            SynthalinguaChan_IMG_1.Visible = False
            SynthalinguaChan_IMG_2.Visible = False
            SynthalinguaChan_IMG_3.Visible = False
            SynthalinguaChan_IMG_4.Visible = False
            SynthalinguaChan_IMG_5.Visible = False
            SynthalinguaChan_IMG_6.Visible = False
            SynthalinguaChan_IMG_7.Visible = False
            SynthalinguaChan_IMG_8.Visible = False
            SynthalinguaChan_IMG_9.Visible = False
            SynthalinguaChan_IMG_10.Visible = False
        Else
            ' Show all "SynthalinguaChan_IMG_" images 1 through 9
            SynthalinguaChan_IMG_1.Visible = True
            SynthalinguaChan_IMG_2.Visible = True
            SynthalinguaChan_IMG_3.Visible = True
            SynthalinguaChan_IMG_4.Visible = True
            SynthalinguaChan_IMG_5.Visible = True
            SynthalinguaChan_IMG_6.Visible = True
            SynthalinguaChan_IMG_7.Visible = True
            SynthalinguaChan_IMG_8.Visible = True
            SynthalinguaChan_IMG_9.Visible = False ' IMG_9 should be hidden by default when showing, IMG_8 is the happy one
            SynthalinguaChan_IMG_10.Visible = False
            If CheckBoxCMDBLock.Checked Then
                SynthalinguaChan_IMG_10.Visible = False
            Else
                If Not DisableSynthalinguaChan.Checked Then
                    SynthalinguaChan_IMG_10.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub DisableSynthalinguaChan_MouseEnter(sender As Object, e As EventArgs)
        ' Only show the scared face (IMG_9) if the checkbox is not checked (images are visible)
        If Not DisableSynthalinguaChan.Checked Then
            SynthalinguaChan_IMG_8.Visible = False ' Hide happy face
            SynthalinguaChan_IMG_9.Visible = True  ' Show scared face
        End If
    End Sub

    Private Sub DisableSynthalinguaChan_MouseLeave(sender As Object, e As EventArgs)
        ' Restore the happy face (IMG_8) if the checkbox is not checked (images are visible)
        If Not DisableSynthalinguaChan.Checked Then
            SynthalinguaChan_IMG_9.Visible = False ' Hide scared face
            SynthalinguaChan_IMG_8.Visible = True  ' Show happy face
        End If
    End Sub

    Private Sub GitHubSponsorPicture_MouseClick(sender As Object, e As MouseEventArgs) Handles GitHubSponsorPicture.MouseClick
        WebManager.OpenSocialLink("https://github.com/sponsors/cyberofficial")
    End Sub

    Private Sub ServerIP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ServerIP.KeyPress
        If Char.IsControl(e.KeyChar) OrElse Char.IsDigit(e.KeyChar) OrElse e.KeyChar = "."c OrElse Char.IsWhiteSpace(e.KeyChar) Then
            Return
        End If

        e.Handled = True
    End Sub

    Private Sub ServerIP_LostFocus(sender As Object, e As EventArgs) Handles ServerIP.LostFocus
        Dim digitsOnly = New String(ServerIP.Text.Where(Function(c) Char.IsDigit(c)).ToArray())
        If digitsOnly.Length = 0 Then
            ServerIP.Text = String.Empty
            Return
        End If

        Dim cleaned = ServerIP.Text.Replace(" ", String.Empty).Replace("_", String.Empty)
        Dim segments = cleaned.Split("."c, StringSplitOptions.RemoveEmptyEntries)
        If segments.Length <> 4 Then
            ShowInvalidIpMessage()
            Return
        End If

        Dim values As New List(Of Integer)
        For Each segment In segments
            Dim value As Integer
            If Not Integer.TryParse(segment, value) OrElse value < 0 OrElse value > 255 Then
                ShowInvalidIpMessage()
                Return
            End If
            values.Add(value)
        Next

        ServerIP.Text = String.Format("{0:000}.{1:000}.{2:000}.{3:000}", values(0), values(1), values(2), values(3))
    End Sub

    Private Sub ShowInvalidIpMessage()
        MessageBox.Show("Server IP address must be in the form XXX.XXX.XXX.XXX with values between 0 and 255.", "Invalid IP Address", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ServerIP.Focus()
        ServerIP.SelectionStart = 0
        ServerIP.SelectionLength = ServerIP.Text.Length
    End Sub

    Private Sub BatchModeManual_CheckedChanged(sender As Object, e As EventArgs) Handles BatchModeManual.CheckedChanged
        ' if batchjobs_lbl.Text = "Batch Jobs (1)" then set it to "Batch Jobs (disabled)" if not dont do anything
        If True = BatchModeManual.Checked Then
            If batchjobs_lbl.Text = "Batch Jobs (1)" Then
                batchjobs_lbl.Text = "Batch Jobs (disabled)"
            End If
        End If
    End Sub

    Private Sub ModelSizeInfoLblForCaptions_Click(sender As Object, e As EventArgs) Handles ModelSizeInfoLblForCaptions.Click
        ' Show a simple message box explaining the model sizes
        ' It's suggested to have the user do a test run with 4 see how much vram is used then adjust accordingly, its recommended to to add 0.5GB to the value they see used. So if they see 3.86GB used, they should set 4.5GB in the config. We should note that faster whisper normally uses about 3.8 to 4.2 depending on the audio segments.
        Dim info As String =
            "Model Size Information for Captions:" & vbCrLf & vbCrLf &
            "Note: Actual VRAM usage may vary based on audio length and system configuration. " &
            "It's recommended to monitor VRAM usage during initial runs and adjust settings accordingly." & vbCrLf & vbCrLf &
            "Faster Whisper 12GB-v3 typically uses between 3.8 to 4.2 GB of VRAM depending on audio segments."

        MessageBox.Show(info, "Model Size Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub max_cpu_time_label_Click(sender As Object, e As EventArgs) Handles max_cpu_time_label.Click
        ' Show a message box explaining max CPU time
        ' Maximum time in seconds that a single job can run on CPU during adaptive batch processing. Jobs predicted to exceed this time will wait for GPU instead. Default: 300 seconds (5 minutes). Lower values prioritize GPU for longer jobs, higher values allow more CPU usage. Recommended: 60-600. Only used with --adaptive_batch.
        Dim info As String =
            "Maximum CPU Time Explanation:" & vbCrLf & vbCrLf &
            "The 'Maximum CPU Time' setting defines the maximum duration (in seconds) that a single job is allowed to run on the CPU during adaptive batch processing." & vbCrLf & vbCrLf &
            "If a job is predicted to exceed this time limit, it will be queued to wait for GPU processing instead." & vbCrLf & vbCrLf &
            "Default Value: 300 seconds (5 minutes)" & vbCrLf & vbCrLf &
            "Guidelines:" & vbCrLf &
            "- Lower Values (e.g., 60-120 seconds): Prioritize GPU usage for longer jobs, reducing CPU load but potentially increasing wait times for GPU availability." & vbCrLf &
            "- Higher Values (e.g., 300-600 seconds): Allow more extensive CPU processing, which may reduce GPU wait times but increase overall CPU usage." & vbCrLf & vbCrLf &
            "Recommended Range: 300-600 seconds (5-10 minutes), depending on your system's capabilities and workload."
        MessageBox.Show(info, "Maximum CPU Time Explanation", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub TimeoutLabel_Click(sender As Object, e As EventArgs) Handles TimeoutLabel.Click
        ' Show message box with info: Maximum time in seconds allowed for individual transcription jobs to complete before being terminated. Set to 0 (default) for no timeout - jobs run until completion. Useful for preventing stuck jobs in batch processing, setting time limits for large files, or ensuring predictable completion times. Example: --timeout 600 allows 10 minutes per job. Jobs exceeding this limit are killed and marked as failed. Only affects file processing modes, not real-time streaming or microphone input.
        Dim info As String =
            "Timeout Explanation:" & vbCrLf & vbCrLf &
            "The 'Timeout' setting specifies the maximum duration (in seconds) allowed for individual transcription jobs to complete before they are automatically terminated." & vbCrLf & vbCrLf &
            "Setting this value to 0 (the default) means there is no timeout, and jobs will run until they finish." & vbCrLf & vbCrLf &
            "This setting is particularly useful for:" & vbCrLf &
            "- Preventing Stuck Jobs: Ensures that jobs that hang or take excessively long do not block the processing queue." & vbCrLf &
            "- Managing Large Files: Allows you to set time limits for processing large audio files, helping to maintain workflow efficiency." & vbCrLf &
            "- Predictable Completion Times: Helps in scenarios where you need to ensure that jobs complete within a certain timeframe." & vbCrLf & vbCrLf &
            "Example Usage: --timeout 600 allows each job a maximum of 10 minutes to complete." & vbCrLf & vbCrLf &
            "Recommended Range: 300-600 seconds (5-10 minutes), depending on your system's capabilities and workload. For systems with at least 6 CPU cores, 10 minutes (600 seconds) is recommended. For systems with 12 or more cores, 5 minutes (300 seconds) may be sufficient." & vbCrLf & vbCrLf &
            "Jobs that exceed this time limit will be terminated and marked as failed." & vbCrLf &
            "Note: Failed jobs will automatically retry at the end of other operations, so work will continue." & vbCrLf & vbCrLf &
            "Note: This setting only affects file processing modes and does not apply to real-time streaming or microphone input."
        MessageBox.Show(info, "Timeout Explanation", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LaunchWebUIBtn_Click(sender As Object, e As EventArgs) Handles LaunchWebUIBtn.Click
        ' Validate port number
        If Not ValidatePortNumber() Then
            Return
        End If

        If String.IsNullOrEmpty(ScriptFileLocation.Text) Then
            MessageBox.Show("Please select the program file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            If My.Settings.PrimaryFolder IsNot Nothing AndAlso My.Settings.PrimaryFolder <> "" Then
                PrimaryFolder = My.Settings.PrimaryFolder
            End If
        Catch ex As Exception
        End Try

        If String.IsNullOrEmpty(PrimaryFolder) Then
            PrimaryFolder = Path.GetDirectoryName(ScriptFileLocation.Text)
        End If

        If String.IsNullOrEmpty(PrimaryFolder) Then
            MessageBox.Show("Primary folder is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim tmpBatFile As String = Path.Combine(PrimaryFolder, "tmp_webui.bat")
            Dim command As New StringBuilder()

            ' Basic setup
            command.AppendLine("chcp 65001")
            command.AppendLine("set PYTHONIOENCODING=utf-8")
            command.AppendLine("SET TORCHAUDIO_USE_BACKEND_DISPATCHER=1")
            command.AppendLine("SET TORIO_USE_FFMPEG=0")
            command.AppendLine()
            command.AppendLine("cls")
            command.AppendLine("@echo off")
            command.AppendLine("Echo Loading Script")
            command.AppendLine($"""{PrimaryFolder}\set_up_env.exe""")
            command.AppendLine($"call ""{PrimaryFolder}\ffmpeg_path.bat""")

            ' Script execution command
            If ScriptFileLocation.Text.Contains(".py") Then
                command.Append($"python ""{ScriptFileLocation.Text}"" --launchui --portnumber {PortNumber.Value} --debug")
            Else
                command.Append($"""{ScriptFileLocation.Text}"" --launchui --portnumber {PortNumber.Value} --debug")
            End If

            ' Add model directory if set
            If Not String.IsNullOrEmpty(modelDIr.Text) Then
                command.Append($" --model_dir ""{modelDIr.Text}""")
            End If

            command.AppendLine()
            command.AppendLine()
            command.AppendLine("pause")

            File.WriteAllText(tmpBatFile, command.ToString())
            Process.Start(tmpBatFile)
        Catch ex As Exception
            MessageBox.Show($"Error launching Web UI: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
