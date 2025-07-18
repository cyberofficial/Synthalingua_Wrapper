Imports System.IO

Public Class ConfigManager
    Public Shared Function SaveConfig(settings As MainUI) As Boolean
        Dim savePassword As Boolean = True
        Try
            With My.Settings
                ' Script Location
                .MainScriptLocation = settings.ScriptFileLocation.Text

                ' Audio Source
                .AudioSource = If(settings.HSL_RadioButton.Checked, 1, If(settings.MIC_RadioButton.Checked, 2, 3))

                ' Processor Device
                .ProcDevice = If(settings.CUDA_RadioButton.Checked, 1, 2)

                ' Web Server
                .WebServerEnabled = If(settings.WebServerButton.Checked, 1, 0)
                .WebServerPort = settings.PortNumber.Value

                ' RAM Size
                .RamSize = settings.RamSize.Text

                ' Model Location
                .modelDIr = settings.modelDIr.Text

                ' Force RAM
                .ForceRam = settings.ForceRam.Checked

                ' Cookie Name
                .CookieName = settings.CookiesName.Text

                ' Stream Language
                .StreamLanguage = settings.StreamLanguage.Text

                ' English Translation
                .EnglishTranslationEnabled = settings.EnglishTranslationCheckBox.Checked

                ' Secondary Translation
                .SecondaryTranslationLang = settings.SecondaryTranslationLanguage.Text
                .SecondaryTranslationEnabled = settings.SecondaryTranslation.Checked

                ' HLS URL
                .HLSurl = settings.HLS_URL.Text

                ' Stream Chunk Size
                .StreamChunkSize = settings.ChunkSizeTrackBar.Value

                ' Show Original Text
                .HLSShowOriginal = settings.ShowOriginalText.Checked

                ' Microphone Energy Threshold
                .MicrophoneEnergyThreshold = settings.EnThreshValue.Value
                .MicrophoneEnergyThresholdEnabled = settings.MicEnCheckBox.Checked

                ' Microphone Calibration Time
                .MicCalTime = settings.MicCaliTime.Value
                .MicCalTImeEnabled = settings.MicCaliCheckBox.Checked

                ' Microphone Record Timeout
                .MicRecTimeout = settings.RecordTimeout.Value
                .MicRecTimeoutEnabled = settings.RecordTimeOutCHeckBox.Checked

                ' Phrase Timeout
                .PhraseTimeOut = settings.PhraseTimeout.Value
                .PhraseTimeOutEnabled = settings.PhraseTimeOutCheckbox.Checked

                ' Microphone Chunk Size
                .mic_chunk_size = settings.mic_chunk_size.Value

                ' Padded Audio
                .paddedaudio = settings.paddedaudio.Checked
                .paddedaudio_value = settings.paddedaudio_value.Value

                ' Word Block List
                .WordBlockListEnabled = settings.WordBlockList.Checked
                .WordBlockListLocation = settings.WordBlockListLocation.ToString

                ' Repeat Protection
                .RepeatProtection = settings.RepeatProtection.Checked

                ' Command Block
                .PrimaryFolder = settings.PrimaryFolder
                .ShortCutType = settings.ShortCutType
                .CommandBlock = settings.ConfigTextBox.Text

                'hls info
                .hlspassid = settings.hlspassid.Text

                ' HLS Password
                If Not String.IsNullOrEmpty(settings.hlspassword.Text) Then
                    Dim result = MessageBox.Show("Do you want to save the HLS password?", "Save Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    savePassword = (result = DialogResult.Yes)
                End If
                .hlspassword = If(savePassword, settings.hlspassword.Text, "")
                .cb_halspassword = settings.cb_halspassword.Checked

                'Precision Mode
                .fp16 = settings.PrecisionCheckBox.Checked

                ' Auto HLS
                .auto_hls = settings.AutoHLS_Checkbox.Checked

                ' Auto Blocklist
                .auto_blocklist = settings.auto_blocklist.Checked

                ' Select Source
                .SelectSource = settings.SelectSource.Checked

                ' Word Timestamps
                .word_timestamps = settings.word_timestamps.Checked

                ' Isolate Vocals
                .isolate_vocals = settings.isolate_vocals.Checked

                ' Silent Detection
                .silent_detect = settings.silent_detect.Checked
                .silent_threshold = settings.silent_threshold.Value.ToString()
                .silent_duration = settings.silent_duration.Value.ToString()

                ' Model Name
                .demucs_model = settings.demucs_model.Text
                .demucs_model_jobs = settings.demucs_model_jobs.Value

                ' Print SRT to Console
                .print_srt_to_console = settings.print_srt_to_console.Checked
            End With
            My.Settings.Save()
            If Not String.IsNullOrEmpty(settings.hlspassword.Text) Then
                If savePassword Then
                    MessageBox.Show("Settings saved with password.", "Config Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Settings saved without password.", "Config Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function LoadConfig(form As MainUI) As Boolean
        Try
            With My.Settings
                If String.IsNullOrEmpty(.MainScriptLocation) Then
                    ' No script location set yet
                Else
                    form.ScriptFileLocation.Text = .MainScriptLocation
                End If

                form.HSL_RadioButton.Checked = (.AudioSource = 1)
                form.MIC_RadioButton.Checked = (.AudioSource = 2)
                form.CAP_RadioButton.Checked = (.AudioSource = 3)

                form.CUDA_RadioButton.Checked = (.ProcDevice = 1)
                form.CPU_RadioButton.Checked = Not (.ProcDevice = 1)

                form.PortNumber.Value = .WebServerPort
                form.WebServerButton.Checked = .WebServerEnabled
                form.RamSize.Text = .RamSize
                form.ForceRam.Checked = .ForceRam
                form.CookiesName.Text = .CookieName
                form.StreamLanguage.Text = .StreamLanguage
                form.EnglishTranslationCheckBox.Checked = .EnglishTranslationEnabled
                form.SecondaryTranslationLanguage.Text = .SecondaryTranslationLang
                form.SecondaryTranslation.Checked = .SecondaryTranslationEnabled
                form.HLS_URL.Text = .HLSurl
                form.ChunkSizeTrackBar.Value = .StreamChunkSize
                form.ShowOriginalText.Checked = .HLSShowOriginal
                form.EnThreshValue.Value = .MicrophoneEnergyThreshold
                form.MicEnCheckBox.Checked = .MicrophoneEnergyThresholdEnabled
                form.MicCaliTime.Value = .MicCalTime
                form.MicCaliCheckBox.Checked = .MicCalTImeEnabled
                form.RecordTimeout.Value = .MicRecTimeout
                form.RecordTimeOutCHeckBox.Checked = .MicRecTimeoutEnabled
                form.PhraseTimeout.Value = .PhraseTimeOut
                form.PhraseTimeOutCheckbox.Checked = .PhraseTimeOutEnabled
                form.mic_chunk_size.Value = .mic_chunk_size
                form.paddedaudio.Checked = .paddedaudio
                form.paddedaudio_value.Value = .paddedaudio_value
                form.WordBlockListLocation = .WordBlockListLocation
                form.WordBlockList.Checked = .WordBlockListEnabled
                form.RepeatProtection.Checked = .RepeatProtection
                form.ConfigTextBox.Text = .CommandBlock
                form.ShortCutType = .ShortCutType
                form.hlspassid.Text = .hlspassid
                form.hlspassword.Text = .hlspassword
                form.cb_halspassword.Checked = .cb_halspassword
                form.modelDIr.Text = .modelDIr
                form.PrecisionCheckBox.Checked = .fp16
                form.AutoHLS_Checkbox.Checked = .auto_hls
                form.auto_blocklist.Checked = .auto_blocklist
                form.SelectSource.Checked = .SelectSource
                form.word_timestamps.Checked = .word_timestamps
                form.isolate_vocals.Checked = .isolate_vocals
                form.silent_detect.Checked = .silent_detect
                form.silent_threshold.Value = CInt(.silent_threshold)
                form.silent_duration.Value = CDec(.silent_duration)
                form.demucs_model.Text = .demucs_model
                form.demucs_model_jobs.Value = .demucs_model_jobs
                form.print_srt_to_console.Checked = .print_srt_to_console

                Try
                    form.PrimaryFolder = .PrimaryFolder
                Catch ex As Exception
                    form.PrimaryFolder = ""
                End Try
            End With
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class