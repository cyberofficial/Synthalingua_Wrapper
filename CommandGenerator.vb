Imports System.Text
Imports System.IO

Public Class CommandGenerator
    Private ReadOnly builder As StringBuilder
    Private ReadOnly settings As MainUI

    Public Sub New(mainForm As MainUI)
        builder = New StringBuilder()
        settings = mainForm
    End Sub

    Public Function Generate() As String
        If String.IsNullOrEmpty(settings.ScriptFileLocation.Text) Then
            Throw New Exception("Please select the program file.")
        End If
        If String.IsNullOrEmpty(settings.StreamLanguage.Text) Then
            Throw New Exception("No Stream language was set.")
        End If

        Dim validModels As New List(Of String) From {
            "htdemucs", "htdemucs_ft", "htdemucs_6s", "hdemucs_mmi", "mdx", "mdx_extra", "mdx_q", "mdx_extra_q", "hdemucs", "demucs", "DEFAULT"
        }
        If Not validModels.Contains(settings.demucs_model.Text) Then
            MessageBox.Show($"'{settings.demucs_model.Text}' is not a model that is known.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Throw New Exception($"Unknown demucs model: {settings.demucs_model.Text}")
        End If

        settings.ShortCutType = If(settings.ScriptFileLocation.Text.Contains("transcribe_audio.py"), "Source", "Portable")
        settings.PrimaryFolder = Path.GetDirectoryName(settings.ScriptFileLocation.Text)

        ' Basic setup
        builder.Clear()
        builder.AppendLine("chcp 65001")
        builder.AppendLine("set PYTHONIOENCODING=utf-8")
        builder.AppendLine().AppendLine("cls").AppendLine("@echo off").AppendLine("Echo Loading Script")
        builder.AppendLine($"""{settings.PrimaryFolder}\set_up_env.exe""")
        builder.AppendLine($"call ""{settings.PrimaryFolder}\ffmpeg_path.bat""")

        ' Script execution command
        If settings.ShortCutType = "Source" Then
            builder.AppendLine($"call ""{settings.PrimaryFolder}\data_whisper\Scripts\activate.bat""")
            builder.Append($"python ""{settings.PrimaryFolder}\transcribe_audio.py"" ")
        Else
            builder.Append($"""{settings.PrimaryFolder}\transcribe_audio.exe"" ")
        End If

        AppendRamSettings()
        AppendAudioSourceSettings()
        AppendLanguageSettings()
        AppendDeviceSettings()
        AppendAdditionalSettings()

        builder.AppendLine().AppendLine("pause")
        Return builder.ToString()
    End Function

    Private Sub AppendRamSettings()
        builder.Append($"--ram {settings.RamSize.Text} ")
        If settings.ForceRam.Checked Then builder.Append("--ramforce ")
    End Sub

    Private Sub AppendAudioSourceSettings()
        If settings.CAP_RadioButton.Checked Then
            ' If compare_mode is checked, append "--makecaptions compare", else just "--makecaptions"
            If settings.compare_mode IsNot Nothing AndAlso settings.compare_mode.Checked Then
                builder.Append($"--makecaptions compare --file_input=""{settings.CaptionsInput.Text}"" --file_output=""{settings.CaptionsOutput.Text}"" --file_output_name=""{settings.CaptionsName.Text}"" ")
            Else
                builder.Append($"--makecaptions --file_input=""{settings.CaptionsInput.Text}"" --file_output=""{settings.CaptionsOutput.Text}"" --file_output_name=""{settings.CaptionsName.Text}"" ")
            End If
            ' Add this block for print_srt_to_console
            If settings.print_srt_to_console IsNot Nothing AndAlso settings.print_srt_to_console.Checked Then
                builder.Append("--print_srt_to_console ")
            End If
            If settings.silent_detect.Checked Then builder.Append("--silent_detect ")
            If settings.silent_threshold.Value <> -35 Then builder.Append($"--silent_threshold {settings.silent_threshold.Value} ")
            If settings.silent_duration.Value <> 0.5 Then builder.Append($"--silent_duration {settings.silent_duration.Value} ")
            ' if "silent_detect" is checked and value from "demucs_model" is not DEFAULT then we add the value from the dropdown "demucs_model" to the command builder and it'll be "--demucs_model {value}"
            If settings.silent_detect.Checked AndAlso settings.demucs_model.Text <> "DEFAULT" Then
                builder.Append($"--demucs_model {settings.demucs_model.Text} ")
            End If
        ElseIf settings.MIC_RadioButton.Checked Then
            builder.Append("--microphone_enabled true ")
            If settings.MicEnCheckBox.Checked Then builder.Append($"--energy_threshold {settings.EnThreshValue.Value} ")
            If settings.MicCaliCheckBox.Checked Then builder.Append($"--mic_calibration_time {settings.MicCaliTime.Value} ")
            If settings.RecordTimeOutCHeckBox.Checked Then builder.Append($"--record_timeout {settings.RecordTimeout.Value} ")
            If settings.PhraseTimeOutCheckbox.Checked Then builder.Append($"--phrase_timeout {settings.PhraseTimeout.Value} ")
            builder.Append($"--set_microphone {settings.MicID.Value} ")
            builder.Append($"--mic_chunk_size {settings.mic_chunk_size.Value} ")
            If settings.paddedaudio.Checked Then builder.Append($"--paddedaudio {settings.paddedaudio_value.Value} ")
        ElseIf settings.HSL_RadioButton.Checked Then
            If settings.ShowOriginalText.Checked Then builder.Append("--stream_original_text ")
            builder.Append($"--stream ""{settings.HLS_URL.Text}"" ")
            builder.Append($"--stream_chunks {settings.ChunkSizeTrackBar.Value} ")
            If settings.paddedaudio.Checked Then builder.Append($"--paddedaudio {settings.paddedaudio_value.Value} ")
        End If
    End Sub

    Private Sub AppendLanguageSettings()
        Dim prefix = If(settings.HSL_RadioButton.Checked, "stream_", "")
        If settings.StreamLanguage.Text <> "--Auto Detect--" Then
            builder.Append($"--{prefix}language {settings.StreamLanguage.Text} ")
        End If

        If settings.EnglishTranslationCheckBox.Checked Then
            builder.Append($"--{prefix}translate ")
        End If
        If settings.SecondaryTranslation.Checked Then
            builder.Append($"--{prefix}transcribe ")
            builder.Append($"--{prefix}target_language {settings.SecondaryTranslationLanguage.Text} ")
        End If
    End Sub

    Private Sub AppendDeviceSettings()
        If settings.CUDA_RadioButton.Checked Then
            builder.Append("--device cuda ")
        ElseIf settings.CPU_RadioButton.Checked Then
            builder.Append("--device cpu ")
        End If
    End Sub

    Private Sub AppendAdditionalSettings()
        If Not String.IsNullOrEmpty(settings.CookiesName.Text) Then builder.Append($"--cookies {settings.CookiesName.Text} ")
        If settings.WordBlockList.Checked Then builder.Append($"--ignorelist ""{settings.WordBlockListLocation}"" ")
        If settings.WebServerButton.Checked Then builder.Append($"--portnumber {settings.PortNumber.Value} ")
        If settings.RepeatProtection.Checked Then builder.Append("--condition_on_previous_text ")
        If settings.cb_halspassword.Checked Then builder.Append($"--remote_hls_password_id {settings.hlspassid.Text} --remote_hls_password {settings.hlspassword.Text} ")
        If Not String.IsNullOrEmpty(settings.DiscordWebHook.Text) Then builder.Append($"--discord_webhook ""{settings.DiscordWebHook.Text}"" ")
        If Not String.IsNullOrEmpty(settings.modelDIr.Text) Then builder.Append($"--model_dir ""{settings.modelDIr.Text}"" ")
        If settings.PrecisionCheckBox.Checked Then builder.Append("--fp16 ")
        If settings.AutoHLS_Checkbox.Checked Then builder.Append("--auto_hls ")
        If settings.auto_blocklist.Checked Then builder.Append("--auto_blocklist ")
        If settings.SelectSource.Checked Then builder.Append("--selectsource ")
        If settings.word_timestamps.Checked Then builder.Append("--word_timestamps ")
        If settings.isolate_vocals.Checked Then
            builder.Append("--isolate_vocals ")
            ' Add demucs_model_jobs value if greater than 0, directly after --isolate_vocals
            If settings.demucs_model_jobs.Value > 0 Then
                builder.Append($"{settings.demucs_model_jobs.Value} ")
            End If
        End If
    End Sub
End Class