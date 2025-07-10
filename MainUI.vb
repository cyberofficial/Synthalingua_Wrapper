Imports System.IO
Imports System.Diagnostics
Imports System.Threading

Public Class MainUI
    Public Property PrimaryFolder As String
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
    End Sub
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

        If ScriptFileLocation.Text.Contains(" ") Then
            MessageBox.Show("Please select a program file that does not have spaces in the file path.")
            Return
        End If

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

        Dim createdNew As Boolean
        appMutex = New Mutex(True, "Synthalingua_Wrapper", createdNew)

        ConfigManager.LoadConfig(Me)
        FileOperations.InitializeCookiesFolder(System.IO.Directory.GetCurrentDirectory())
        FileOperations.RefreshCookiesList(CookiesName)

        ' Set demucs_model_jobs minimum to 1 and maximum to CPU core count
        Try
            Dim cpuCores As Integer = Environment.ProcessorCount
            demucs_model_jobs.Minimum = 0
            demucs_model_jobs.Maximum = cpuCores
        Catch ex As Exception
            demucs_model_jobs.Minimum = 0
            demucs_model_jobs.Maximum = 1 ' fallback default
        End Try

        ' Load saved value from user settings if available
        If My.Settings.demucs_model_jobs >= demucs_model_jobs.Minimum AndAlso My.Settings.demucs_model_jobs <= demucs_model_jobs.Maximum Then
            demucs_model_jobs.Value = My.Settings.demucs_model_jobs
        Else
            demucs_model_jobs.Value = demucs_model_jobs.Minimum
        End If

        If String.IsNullOrEmpty(ScriptFileLocation.Text) Then
            Dim scriptInfo = FileOperations.FindScriptFile(System.IO.Directory.GetCurrentDirectory())
            If Not String.IsNullOrEmpty(scriptInfo.ScriptPath) Then
                ScriptFileLocation.Text = scriptInfo.ScriptPath
                PrimaryFolder = scriptInfo.FolderPath
                ShortCutType = scriptInfo.ShortcutType
            End If
        End If

        toolTipManager.SetupTooltips(Me)

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
End Class
