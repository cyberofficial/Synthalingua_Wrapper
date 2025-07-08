<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainUI
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainUI))
        GroupBox1 = New GroupBox()
        CAP_RadioButton = New RadioButton()
        MIC_RadioButton = New RadioButton()
        HSL_RadioButton = New RadioButton()
        SaveConfigToFileButton = New Button()
        Label1 = New Label()
        ScriptFileLocation = New TextBox()
        SearchForProgramBTN = New Button()
        Label2 = New Label()
        RamSize = New ComboBox()
        ForceRam = New CheckBox()
        GroupBox2 = New GroupBox()
        SelectSource = New CheckBox()
        AutoHLS_Checkbox = New CheckBox()
        Label14 = New Label()
        hlspassword = New TextBox()
        hlspassid = New TextBox()
        cb_halspassword = New CheckBox()
        ShowOriginalText = New CheckBox()
        ChunkSizeTrackBarValue = New Label()
        ChunkSizeTrackBar = New TrackBar()
        Label6 = New Label()
        HLS_URL = New TextBox()
        Label3 = New Label()
        EnglishTranslationCheckBox = New CheckBox()
        Label7 = New Label()
        SecondaryTranslation = New CheckBox()
        Label5 = New Label()
        SecondaryTranslationLanguage = New ComboBox()
        StreamLanguage = New ComboBox()
        Label4 = New Label()
        GroupBox3 = New GroupBox()
        CPU_RadioButton = New RadioButton()
        CUDA_RadioButton = New RadioButton()
        OpenScriptDiag = New OpenFileDialog()
        ConfigTextBox = New TextBox()
        GenerateConfigButton = New Button()
        Label8 = New Label()
        SaveFileDialog = New SaveFileDialog()
        PortNumber = New NumericUpDown()
        WebServerButton = New CheckBox()
        Label10 = New Label()
        GroupBox4 = New GroupBox()
        SettingsTabs = New TabControl()
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        mic_chunk_size = New NumericUpDown()
        SetMicChunkSizeLbl = New Label()
        PhraseTimeOutCheckbox = New CheckBox()
        RecordTimeOutCHeckBox = New CheckBox()
        MicCaliCheckBox = New CheckBox()
        MicEnCheckBox = New CheckBox()
        microphone_id_button = New Button()
        SetMicLbl = New Label()
        MicID = New NumericUpDown()
        PhraseTimeout = New NumericUpDown()
        RecordTimeout = New NumericUpDown()
        MicCaliTime = New NumericUpDown()
        PhraseTimeOutlbl = New Label()
        EnThreshValue = New NumericUpDown()
        RecordTimeoutLbl = New Label()
        MicCaliLbl = New Label()
        Energy_Threshold = New Label()
        TabPage3 = New TabPage()
        WhatModelsBtn = New Label()
        demucs_model = New ComboBox()
        silent_duration = New NumericUpDown()
        silent_duration_lbl = New Label()
        Label18 = New Label()
        silent_threshold = New NumericUpDown()
        silent_detect = New CheckBox()
        word_timestamps = New CheckBox()
        CaptionsName = New TextBox()
        CaptionsOutput = New TextBox()
        Label12 = New Label()
        CaptionsInput = New TextBox()
        Label11 = New Label()
        CaptionsOutputBtn = New Button()
        Label9 = New Label()
        CaptionsInputBtn = New Button()
        TabPage4 = New TabPage()
        Label17 = New Label()
        PrecisionCheckBox = New CheckBox()
        Label16 = New Label()
        modelDIr = New TextBox()
        modelDirPicker = New Button()
        isolate_vocals = New CheckBox()
        MicIDs = New Button()
        RunScript = New Button()
        Label13 = New Label()
        DiscordWebHook = New TextBox()
        GroupBox5 = New GroupBox()
        Button3 = New Button()
        Label15 = New Label()
        WebLinkOG = New Button()
        WebLinkT1 = New Button()
        WebLinkT2 = New Button()
        SubWindow = New Button()
        CookiesName = New ComboBox()
        CookiesRefresh = New Button()
        ToolTip1 = New ToolTip(components)
        PictureItch = New PictureBox()
        GitHubPicture = New PictureBox()
        SaveConfig = New Button()
        WipeSettings = New Button()
        KoFiPicture = New PictureBox()
        CheckBoxCMDBLock = New CheckBox()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        CaptionsInputFile = New OpenFileDialog()
        EraseCheckBox = New CheckBox()
        WordBlockList = New CheckBox()
        EditBlockList = New Button()
        GroupBox6 = New GroupBox()
        auto_blocklist = New CheckBox()
        RepeatProtection = New CheckBox()
        Button1 = New Button()
        FolderBrowserDialog2 = New FolderBrowserDialog()
        paddedaudio = New CheckBox()
        paddedaudio_value = New TrackBar()
        paddedaudio_nvalue = New Label()
        PictureBox1 = New PictureBox()
        Label19 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(ChunkSizeTrackBar, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        CType(PortNumber, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox4.SuspendLayout()
        SettingsTabs.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        CType(mic_chunk_size, ComponentModel.ISupportInitialize).BeginInit()
        CType(MicID, ComponentModel.ISupportInitialize).BeginInit()
        CType(PhraseTimeout, ComponentModel.ISupportInitialize).BeginInit()
        CType(RecordTimeout, ComponentModel.ISupportInitialize).BeginInit()
        CType(MicCaliTime, ComponentModel.ISupportInitialize).BeginInit()
        CType(EnThreshValue, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        CType(silent_duration, ComponentModel.ISupportInitialize).BeginInit()
        CType(silent_threshold, ComponentModel.ISupportInitialize).BeginInit()
        TabPage4.SuspendLayout()
        GroupBox5.SuspendLayout()
        CType(PictureItch, ComponentModel.ISupportInitialize).BeginInit()
        CType(GitHubPicture, ComponentModel.ISupportInitialize).BeginInit()
        CType(KoFiPicture, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox6.SuspendLayout()
        CType(paddedaudio_value, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.DarkSlateBlue
        GroupBox1.Controls.Add(CAP_RadioButton)
        GroupBox1.Controls.Add(MIC_RadioButton)
        GroupBox1.Controls.Add(HSL_RadioButton)
        GroupBox1.ForeColor = Color.FloralWhite
        GroupBox1.Location = New Point(10, 9)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(137, 101)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Audio Soruce"
        ' 
        ' CAP_RadioButton
        ' 
        CAP_RadioButton.AutoSize = True
        CAP_RadioButton.Location = New Point(5, 65)
        CAP_RadioButton.Margin = New Padding(3, 2, 3, 2)
        CAP_RadioButton.Name = "CAP_RadioButton"
        CAP_RadioButton.Size = New Size(122, 19)
        CAP_RadioButton.TabIndex = 1
        CAP_RadioButton.TabStop = True
        CAP_RadioButton.Text = "Generate Captions"
        CAP_RadioButton.UseVisualStyleBackColor = True
        ' 
        ' MIC_RadioButton
        ' 
        MIC_RadioButton.AutoSize = True
        MIC_RadioButton.Location = New Point(5, 42)
        MIC_RadioButton.Margin = New Padding(3, 2, 3, 2)
        MIC_RadioButton.Name = "MIC_RadioButton"
        MIC_RadioButton.Size = New Size(90, 19)
        MIC_RadioButton.TabIndex = 1
        MIC_RadioButton.TabStop = True
        MIC_RadioButton.Text = "Microphone"
        MIC_RadioButton.UseVisualStyleBackColor = True
        ' 
        ' HSL_RadioButton
        ' 
        HSL_RadioButton.AutoSize = True
        HSL_RadioButton.Checked = True
        HSL_RadioButton.Location = New Point(5, 20)
        HSL_RadioButton.Margin = New Padding(3, 2, 3, 2)
        HSL_RadioButton.Name = "HSL_RadioButton"
        HSL_RadioButton.Size = New Size(86, 19)
        HSL_RadioButton.TabIndex = 0
        HSL_RadioButton.TabStop = True
        HSL_RadioButton.Text = "HLS Stream"
        HSL_RadioButton.UseVisualStyleBackColor = True
        ' 
        ' SaveConfigToFileButton
        ' 
        SaveConfigToFileButton.FlatAppearance.MouseDownBackColor = Color.Indigo
        SaveConfigToFileButton.FlatAppearance.MouseOverBackColor = Color.SlateBlue
        SaveConfigToFileButton.FlatStyle = FlatStyle.Popup
        SaveConfigToFileButton.Font = New Font("Segoe UI", 12.0F)
        SaveConfigToFileButton.Location = New Point(631, 578)
        SaveConfigToFileButton.Margin = New Padding(3, 2, 3, 2)
        SaveConfigToFileButton.Name = "SaveConfigToFileButton"
        SaveConfigToFileButton.Size = New Size(113, 32)
        SaveConfigToFileButton.TabIndex = 1
        SaveConfigToFileButton.Text = "Save to File"
        SaveConfigToFileButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(167, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 15)
        Label1.TabIndex = 2
        Label1.Text = "Script or Portable Location:"
        ' 
        ' ScriptFileLocation
        ' 
        ScriptFileLocation.Location = New Point(323, 7)
        ScriptFileLocation.Margin = New Padding(3, 2, 3, 2)
        ScriptFileLocation.Name = "ScriptFileLocation"
        ScriptFileLocation.PlaceholderText = "C:\Somelocation"
        ScriptFileLocation.Size = New Size(256, 23)
        ScriptFileLocation.TabIndex = 3
        ' 
        ' SearchForProgramBTN
        ' 
        SearchForProgramBTN.BackColor = Color.DodgerBlue
        SearchForProgramBTN.FlatAppearance.MouseDownBackColor = Color.Indigo
        SearchForProgramBTN.FlatAppearance.MouseOverBackColor = Color.SlateBlue
        SearchForProgramBTN.FlatStyle = FlatStyle.Popup
        SearchForProgramBTN.Location = New Point(585, 6)
        SearchForProgramBTN.Margin = New Padding(3, 2, 3, 2)
        SearchForProgramBTN.Name = "SearchForProgramBTN"
        SearchForProgramBTN.Size = New Size(35, 22)
        SearchForProgramBTN.TabIndex = 4
        SearchForProgramBTN.Text = "..."
        SearchForProgramBTN.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.DarkSlateBlue
        Label2.Location = New Point(6, 8)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 5
        Label2.Text = "RAM Size:"
        ' 
        ' RamSize
        ' 
        RamSize.AutoCompleteMode = AutoCompleteMode.Append
        RamSize.AutoCompleteSource = AutoCompleteSource.ListItems
        RamSize.DropDownStyle = ComboBoxStyle.DropDownList
        RamSize.FormattingEnabled = True
        RamSize.Items.AddRange(New Object() {"1gb", "2gb", "3gb", "6gb", "7gb", "11gb-v2", "11gb-v3"})
        RamSize.Location = New Point(71, 5)
        RamSize.Margin = New Padding(3, 2, 3, 2)
        RamSize.Name = "RamSize"
        RamSize.Size = New Size(72, 23)
        RamSize.TabIndex = 6
        ' 
        ' ForceRam
        ' 
        ForceRam.AutoSize = True
        ForceRam.Location = New Point(153, 7)
        ForceRam.Margin = New Padding(3, 2, 3, 2)
        ForceRam.Name = "ForceRam"
        ForceRam.Size = New Size(82, 19)
        ForceRam.TabIndex = 7
        ForceRam.Text = "Force Ram"
        ForceRam.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.DarkSlateBlue
        GroupBox2.Controls.Add(SelectSource)
        GroupBox2.Controls.Add(AutoHLS_Checkbox)
        GroupBox2.Controls.Add(Label14)
        GroupBox2.Controls.Add(hlspassword)
        GroupBox2.Controls.Add(hlspassid)
        GroupBox2.Controls.Add(cb_halspassword)
        GroupBox2.Controls.Add(ShowOriginalText)
        GroupBox2.Controls.Add(ChunkSizeTrackBarValue)
        GroupBox2.Controls.Add(ChunkSizeTrackBar)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(HLS_URL)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.ForeColor = Color.FloralWhite
        GroupBox2.Location = New Point(5, 9)
        GroupBox2.Margin = New Padding(3, 2, 3, 2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 2, 3, 2)
        GroupBox2.Size = New Size(450, 255)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "HLS Info"
        ' 
        ' SelectSource
        ' 
        SelectSource.AutoSize = True
        SelectSource.Location = New Point(258, 70)
        SelectSource.Name = "SelectSource"
        SelectSource.Size = New Size(96, 19)
        SelectSource.TabIndex = 29
        SelectSource.Text = "Select Source"
        SelectSource.UseVisualStyleBackColor = True
        ' 
        ' AutoHLS_Checkbox
        ' 
        AutoHLS_Checkbox.AutoSize = True
        AutoHLS_Checkbox.Location = New Point(128, 70)
        AutoHLS_Checkbox.Name = "AutoHLS_Checkbox"
        AutoHLS_Checkbox.Size = New Size(124, 19)
        AutoHLS_Checkbox.TabIndex = 28
        AutoHLS_Checkbox.Text = "Detect HLS Length"
        AutoHLS_Checkbox.UseVisualStyleBackColor = True
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 10.0F)
        Label14.Location = New Point(5, 154)
        Label14.Name = "Label14"
        Label14.Size = New Size(423, 95)
        Label14.TabIndex = 27
        Label14.Text = resources.GetString("Label14.Text")
        ' 
        ' hlspassword
        ' 
        hlspassword.Location = New Point(134, 128)
        hlspassword.Name = "hlspassword"
        hlspassword.PasswordChar = "*"c
        hlspassword.PlaceholderText = "password/key"
        hlspassword.Size = New Size(311, 23)
        hlspassword.TabIndex = 26
        ' 
        ' hlspassid
        ' 
        hlspassid.Location = New Point(5, 128)
        hlspassid.Name = "hlspassid"
        hlspassid.PlaceholderText = "id type"
        hlspassid.Size = New Size(124, 23)
        hlspassid.TabIndex = 25
        ' 
        ' cb_halspassword
        ' 
        cb_halspassword.AutoSize = True
        cb_halspassword.Location = New Point(6, 103)
        cb_halspassword.Name = "cb_halspassword"
        cb_halspassword.Size = New Size(340, 19)
        cb_halspassword.TabIndex = 24
        cb_halspassword.Text = "HLS Stream has Password (Check before pasting stream url)"
        cb_halspassword.UseVisualStyleBackColor = True
        ' 
        ' ShowOriginalText
        ' 
        ShowOriginalText.AutoSize = True
        ShowOriginalText.Location = New Point(5, 70)
        ShowOriginalText.Margin = New Padding(3, 2, 3, 2)
        ShowOriginalText.Name = "ShowOriginalText"
        ShowOriginalText.Size = New Size(124, 19)
        ShowOriginalText.TabIndex = 23
        ShowOriginalText.Text = "Show Original Text"
        ShowOriginalText.UseVisualStyleBackColor = True
        ' 
        ' ChunkSizeTrackBarValue
        ' 
        ChunkSizeTrackBarValue.AutoSize = True
        ChunkSizeTrackBarValue.Location = New Point(128, 46)
        ChunkSizeTrackBarValue.Name = "ChunkSizeTrackBarValue"
        ChunkSizeTrackBarValue.Size = New Size(59, 15)
        ChunkSizeTrackBarValue.TabIndex = 11
        ChunkSizeTrackBarValue.Text = "Chunks: 5"
        ' 
        ' ChunkSizeTrackBar
        ' 
        ChunkSizeTrackBar.Location = New Point(194, 46)
        ChunkSizeTrackBar.Margin = New Padding(3, 2, 3, 2)
        ChunkSizeTrackBar.Maximum = 30
        ChunkSizeTrackBar.Minimum = 1
        ChunkSizeTrackBar.Name = "ChunkSizeTrackBar"
        ChunkSizeTrackBar.Size = New Size(250, 45)
        ChunkSizeTrackBar.TabIndex = 10
        ChunkSizeTrackBar.Value = 5
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(5, 46)
        Label6.Name = "Label6"
        Label6.Size = New Size(108, 15)
        Label6.TabIndex = 9
        Label6.Text = "Stream Chunk Size:"
        ' 
        ' HLS_URL
        ' 
        HLS_URL.Location = New Point(88, 15)
        HLS_URL.Margin = New Padding(3, 2, 3, 2)
        HLS_URL.Name = "HLS_URL"
        HLS_URL.PlaceholderText = "Stream URL"
        HLS_URL.Size = New Size(357, 23)
        HLS_URL.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(5, 17)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 15)
        Label3.TabIndex = 0
        Label3.Text = "Stream URL:"
        ' 
        ' EnglishTranslationCheckBox
        ' 
        EnglishTranslationCheckBox.AutoSize = True
        EnglishTranslationCheckBox.Location = New Point(323, 91)
        EnglishTranslationCheckBox.Margin = New Padding(3, 2, 3, 2)
        EnglishTranslationCheckBox.Name = "EnglishTranslationCheckBox"
        EnglishTranslationCheckBox.Size = New Size(267, 19)
        EnglishTranslationCheckBox.TabIndex = 8
        EnglishTranslationCheckBox.Text = "Enable | Use if Stream language is not english."
        EnglishTranslationCheckBox.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(166, 92)
        Label7.Name = "Label7"
        Label7.Size = New Size(151, 15)
        Label7.TabIndex = 7
        Label7.Text = "English Translated Captions"
        ' 
        ' SecondaryTranslation
        ' 
        SecondaryTranslation.AutoSize = True
        SecondaryTranslation.Location = New Point(501, 115)
        SecondaryTranslation.Margin = New Padding(3, 2, 3, 2)
        SecondaryTranslation.Name = "SecondaryTranslation"
        SecondaryTranslation.Size = New Size(119, 19)
        SecondaryTranslation.TabIndex = 5
        SecondaryTranslation.Text = "Enable Secondary"
        SecondaryTranslation.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(192, 116)
        Label5.Name = "Label5"
        Label5.Size = New Size(125, 15)
        Label5.TabIndex = 4
        Label5.Text = "Secondary Translation:"
        ' 
        ' SecondaryTranslationLanguage
        ' 
        SecondaryTranslationLanguage.DisplayMember = "1"
        SecondaryTranslationLanguage.DropDownStyle = ComboBoxStyle.DropDownList
        SecondaryTranslationLanguage.FormattingEnabled = True
        SecondaryTranslationLanguage.Items.AddRange(New Object() {"Afrikaans", "Albanian", "Amharic", "Arabic", "Armenian", "Assamese", "Azerbaijani", "Bashkir", "Basque", "Belarusian", "Bengali", "Bosnian", "Breton", "Bulgarian", "Burmese", "Castilian", "Catalan", "Chinese", "Croatian", "Czech", "Danish", "Dutch", "English", "Estonian", "Faroese", "Finnish", "Flemish", "French", "Galician", "Georgian", "German", "Greek", "Gujarati", "Haitian", "Haitian Creole", "Hausa", "Hawaiian", "Hebrew", "Hindi", "Hungarian", "Icelandic", "Indonesian", "Italian", "Japanese", "Javanese", "Kannada", "Kazakh", "Khmer", "Korean", "Lao", "Latin", "Latvian", "Letzeburgesch", "Lingala", "Lithuanian", "Luxembourgish", "Macedonian", "Malagasy", "Malay", "Malayalam", "Maltese", "Maori", "Marathi", "Moldavian", "Moldovan", "Mongolian", "Myanmar", "Nepali", "Norwegian", "Nynorsk", "Occitan", "Panjabi", "Pashto", "Persian", "Polish", "Portuguese", "Punjabi", "Pushto", "Romanian", "Russian", "Sanskrit", "Serbian", "Shona", "Sindhi", "Sinhala", "Sinhalese", "Slovak", "Slovenian", "Somali", "Spanish", "Sundanese", "Swahili", "Swedish", "Tagalog", "Tajik", "Tamil", "Tatar", "Telugu", "Thai", "Tibetan", "Turkish", "Turkmen", "Ukrainian", "Urdu", "Uzbek", "Valencian", "Vietnamese", "Welsh", "Yiddish", "Yoruba"})
        SecondaryTranslationLanguage.Location = New Point(323, 113)
        SecondaryTranslationLanguage.Margin = New Padding(3, 2, 3, 2)
        SecondaryTranslationLanguage.Name = "SecondaryTranslationLanguage"
        SecondaryTranslationLanguage.Size = New Size(172, 23)
        SecondaryTranslationLanguage.Sorted = True
        SecondaryTranslationLanguage.TabIndex = 3
        ' 
        ' StreamLanguage
        ' 
        StreamLanguage.DisplayMember = "1"
        StreamLanguage.DropDownStyle = ComboBoxStyle.DropDownList
        StreamLanguage.FormattingEnabled = True
        StreamLanguage.Items.AddRange(New Object() {"--Auto Detect--", "Afrikaans", "Albanian", "Amharic", "Arabic", "Armenian", "Assamese", "Azerbaijani", "Bashkir", "Basque", "Belarusian", "Bengali", "Bosnian", "Breton", "Bulgarian", "Burmese", "Castilian", "Catalan", "Chinese", "Croatian", "Czech", "Danish", "Dutch", "English", "Estonian", "Faroese", "Finnish", "Flemish", "French", "Galician", "Georgian", "German", "Greek", "Gujarati", "Haitian", "Haitian Creole", "Hausa", "Hawaiian", "Hebrew", "Hindi", "Hungarian", "Icelandic", "Indonesian", "Italian", "Japanese", "Javanese", "Kannada", "Kazakh", "Khmer", "Korean", "Lao", "Latin", "Latvian", "Letzeburgesch", "Lingala", "Lithuanian", "Luxembourgish", "Macedonian", "Malagasy", "Malay", "Malayalam", "Maltese", "Maori", "Marathi", "Moldavian", "Moldovan", "Mongolian", "Myanmar", "Nepali", "Norwegian", "Nynorsk", "Occitan", "Panjabi", "Pashto", "Persian", "Polish", "Portuguese", "Punjabi", "Pushto", "Romanian", "Russian", "Sanskrit", "Serbian", "Shona", "Sindhi", "Sinhala", "Sinhalese", "Slovak", "Slovenian", "Somali", "Spanish", "Sundanese", "Swahili", "Swedish", "Tagalog", "Tajik", "Tamil", "Tatar", "Telugu", "Thai", "Tibetan", "Turkish", "Turkmen", "Ukrainian", "Urdu", "Uzbek", "Valencian", "Vietnamese", "Welsh", "Yiddish", "Yoruba"})
        StreamLanguage.Location = New Point(323, 65)
        StreamLanguage.Margin = New Padding(3, 2, 3, 2)
        StreamLanguage.Name = "StreamLanguage"
        StreamLanguage.Size = New Size(258, 23)
        StreamLanguage.Sorted = True
        StreamLanguage.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(212, 68)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 15)
        Label4.TabIndex = 2
        Label4.Text = "Stream Language: "
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(CPU_RadioButton)
        GroupBox3.Controls.Add(CUDA_RadioButton)
        GroupBox3.ForeColor = Color.FloralWhite
        GroupBox3.Location = New Point(10, 114)
        GroupBox3.Margin = New Padding(3, 2, 3, 2)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(3, 2, 3, 2)
        GroupBox3.Size = New Size(137, 70)
        GroupBox3.TabIndex = 9
        GroupBox3.TabStop = False
        GroupBox3.Text = "Proc Device"
        ' 
        ' CPU_RadioButton
        ' 
        CPU_RadioButton.AutoSize = True
        CPU_RadioButton.Location = New Point(5, 42)
        CPU_RadioButton.Margin = New Padding(3, 2, 3, 2)
        CPU_RadioButton.Name = "CPU_RadioButton"
        CPU_RadioButton.Size = New Size(45, 19)
        CPU_RadioButton.TabIndex = 0
        CPU_RadioButton.Text = "cpu"
        CPU_RadioButton.UseVisualStyleBackColor = True
        ' 
        ' CUDA_RadioButton
        ' 
        CUDA_RadioButton.AutoSize = True
        CUDA_RadioButton.Checked = True
        CUDA_RadioButton.Location = New Point(5, 20)
        CUDA_RadioButton.Margin = New Padding(3, 2, 3, 2)
        CUDA_RadioButton.Name = "CUDA_RadioButton"
        CUDA_RadioButton.Size = New Size(51, 19)
        CUDA_RadioButton.TabIndex = 0
        CUDA_RadioButton.TabStop = True
        CUDA_RadioButton.Text = "cuda"
        CUDA_RadioButton.UseVisualStyleBackColor = True
        ' 
        ' OpenScriptDiag
        ' 
        OpenScriptDiag.FileName = "transcribe_audio.exe"
        OpenScriptDiag.Filter = "EXE (*.exe)|*.exe|py Files (*.py)|*.py"
        ' 
        ' ConfigTextBox
        ' 
        ConfigTextBox.BackColor = Color.SlateBlue
        ConfigTextBox.BorderStyle = BorderStyle.FixedSingle
        ConfigTextBox.Font = New Font("Segoe UI", 13.0F)
        ConfigTextBox.Location = New Point(157, 222)
        ConfigTextBox.Margin = New Padding(3, 2, 3, 2)
        ConfigTextBox.Multiline = True
        ConfigTextBox.Name = "ConfigTextBox"
        ConfigTextBox.ReadOnly = True
        ConfigTextBox.RightToLeft = RightToLeft.No
        ConfigTextBox.ScrollBars = ScrollBars.Vertical
        ConfigTextBox.Size = New Size(463, 388)
        ConfigTextBox.TabIndex = 10
        ConfigTextBox.Visible = False
        ' 
        ' GenerateConfigButton
        ' 
        GenerateConfigButton.FlatAppearance.MouseDownBackColor = Color.Indigo
        GenerateConfigButton.FlatAppearance.MouseOverBackColor = Color.SlateBlue
        GenerateConfigButton.FlatStyle = FlatStyle.Popup
        GenerateConfigButton.Font = New Font("Segoe UI", 13.0F)
        GenerateConfigButton.Location = New Point(631, 371)
        GenerateConfigButton.Margin = New Padding(3, 2, 3, 2)
        GenerateConfigButton.Name = "GenerateConfigButton"
        GenerateConfigButton.Size = New Size(467, 32)
        GenerateConfigButton.TabIndex = 11
        GenerateConfigButton.Text = "Generate Config"
        GenerateConfigButton.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(214, 37)
        Label8.Name = "Label8"
        Label8.Size = New Size(103, 15)
        Label8.TabIndex = 12
        Label8.Text = "Cookie File Name:"
        ' 
        ' PortNumber
        ' 
        PortNumber.Location = New Point(6, 52)
        PortNumber.Margin = New Padding(3, 2, 3, 2)
        PortNumber.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        PortNumber.Name = "PortNumber"
        PortNumber.Size = New Size(83, 23)
        PortNumber.TabIndex = 15
        PortNumber.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        ' 
        ' WebServerButton
        ' 
        WebServerButton.AutoSize = True
        WebServerButton.ForeColor = Color.FloralWhite
        WebServerButton.Location = New Point(5, 14)
        WebServerButton.Margin = New Padding(3, 2, 3, 2)
        WebServerButton.Name = "WebServerButton"
        WebServerButton.Size = New Size(61, 19)
        WebServerButton.TabIndex = 16
        WebServerButton.Text = "Enable"
        WebServerButton.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(5, 34)
        Label10.Name = "Label10"
        Label10.Size = New Size(79, 15)
        Label10.TabIndex = 17
        Label10.Text = "Port Number:"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(Label10)
        GroupBox4.Controls.Add(PortNumber)
        GroupBox4.Controls.Add(WebServerButton)
        GroupBox4.ForeColor = Color.FloralWhite
        GroupBox4.Location = New Point(10, 188)
        GroupBox4.Margin = New Padding(3, 2, 3, 2)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(3, 2, 3, 2)
        GroupBox4.Size = New Size(137, 82)
        GroupBox4.TabIndex = 18
        GroupBox4.TabStop = False
        GroupBox4.Text = "Web Server"
        ' 
        ' SettingsTabs
        ' 
        SettingsTabs.Appearance = TabAppearance.FlatButtons
        SettingsTabs.Controls.Add(TabPage1)
        SettingsTabs.Controls.Add(TabPage2)
        SettingsTabs.Controls.Add(TabPage3)
        SettingsTabs.Controls.Add(TabPage4)
        SettingsTabs.HotTrack = True
        SettingsTabs.Location = New Point(627, 6)
        SettingsTabs.Margin = New Padding(3, 2, 3, 2)
        SettingsTabs.Name = "SettingsTabs"
        SettingsTabs.SelectedIndex = 0
        SettingsTabs.Size = New Size(467, 343)
        SettingsTabs.TabIndex = 19
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.DarkSlateBlue
        TabPage1.Controls.Add(GroupBox2)
        TabPage1.Location = New Point(4, 27)
        TabPage1.Margin = New Padding(3, 2, 3, 2)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3, 2, 3, 2)
        TabPage1.Size = New Size(459, 312)
        TabPage1.TabIndex = 0
        TabPage1.Text = "HLS Settings"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.DarkSlateBlue
        TabPage2.Controls.Add(mic_chunk_size)
        TabPage2.Controls.Add(SetMicChunkSizeLbl)
        TabPage2.Controls.Add(PhraseTimeOutCheckbox)
        TabPage2.Controls.Add(RecordTimeOutCHeckBox)
        TabPage2.Controls.Add(MicCaliCheckBox)
        TabPage2.Controls.Add(MicEnCheckBox)
        TabPage2.Controls.Add(microphone_id_button)
        TabPage2.Controls.Add(SetMicLbl)
        TabPage2.Controls.Add(MicID)
        TabPage2.Controls.Add(PhraseTimeout)
        TabPage2.Controls.Add(RecordTimeout)
        TabPage2.Controls.Add(MicCaliTime)
        TabPage2.Controls.Add(PhraseTimeOutlbl)
        TabPage2.Controls.Add(EnThreshValue)
        TabPage2.Controls.Add(RecordTimeoutLbl)
        TabPage2.Controls.Add(MicCaliLbl)
        TabPage2.Controls.Add(Energy_Threshold)
        TabPage2.Location = New Point(4, 27)
        TabPage2.Margin = New Padding(3, 2, 3, 2)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3, 2, 3, 2)
        TabPage2.Size = New Size(459, 312)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Microphone Settings"
        ' 
        ' mic_chunk_size
        ' 
        mic_chunk_size.Location = New Point(204, 136)
        mic_chunk_size.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        mic_chunk_size.Name = "mic_chunk_size"
        mic_chunk_size.Size = New Size(76, 23)
        mic_chunk_size.TabIndex = 26
        mic_chunk_size.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' SetMicChunkSizeLbl
        ' 
        SetMicChunkSizeLbl.AutoSize = True
        SetMicChunkSizeLbl.Location = New Point(46, 138)
        SetMicChunkSizeLbl.Name = "SetMicChunkSizeLbl"
        SetMicChunkSizeLbl.Size = New Size(152, 15)
        SetMicChunkSizeLbl.TabIndex = 25
        SetMicChunkSizeLbl.Text = "Microhpone Chunk Size (?):"
        ' 
        ' PhraseTimeOutCheckbox
        ' 
        PhraseTimeOutCheckbox.AutoSize = True
        PhraseTimeOutCheckbox.Location = New Point(285, 82)
        PhraseTimeOutCheckbox.Margin = New Padding(3, 2, 3, 2)
        PhraseTimeOutCheckbox.Name = "PhraseTimeOutCheckbox"
        PhraseTimeOutCheckbox.Size = New Size(61, 19)
        PhraseTimeOutCheckbox.TabIndex = 24
        PhraseTimeOutCheckbox.Text = "Enable"
        PhraseTimeOutCheckbox.UseVisualStyleBackColor = True
        ' 
        ' RecordTimeOutCHeckBox
        ' 
        RecordTimeOutCHeckBox.AutoSize = True
        RecordTimeOutCHeckBox.Location = New Point(285, 55)
        RecordTimeOutCHeckBox.Margin = New Padding(3, 2, 3, 2)
        RecordTimeOutCHeckBox.Name = "RecordTimeOutCHeckBox"
        RecordTimeOutCHeckBox.Size = New Size(61, 19)
        RecordTimeOutCHeckBox.TabIndex = 24
        RecordTimeOutCHeckBox.Text = "Enable"
        RecordTimeOutCHeckBox.UseVisualStyleBackColor = True
        ' 
        ' MicCaliCheckBox
        ' 
        MicCaliCheckBox.AutoSize = True
        MicCaliCheckBox.Location = New Point(285, 30)
        MicCaliCheckBox.Margin = New Padding(3, 2, 3, 2)
        MicCaliCheckBox.Name = "MicCaliCheckBox"
        MicCaliCheckBox.Size = New Size(61, 19)
        MicCaliCheckBox.TabIndex = 24
        MicCaliCheckBox.Text = "Enable"
        MicCaliCheckBox.UseVisualStyleBackColor = True
        ' 
        ' MicEnCheckBox
        ' 
        MicEnCheckBox.AutoSize = True
        MicEnCheckBox.Location = New Point(285, 5)
        MicEnCheckBox.Margin = New Padding(3, 2, 3, 2)
        MicEnCheckBox.Name = "MicEnCheckBox"
        MicEnCheckBox.Size = New Size(61, 19)
        MicEnCheckBox.TabIndex = 24
        MicEnCheckBox.Text = "Enable"
        MicEnCheckBox.UseVisualStyleBackColor = True
        ' 
        ' microphone_id_button
        ' 
        microphone_id_button.FlatAppearance.MouseDownBackColor = Color.DarkSlateBlue
        microphone_id_button.FlatAppearance.MouseOverBackColor = Color.DarkSlateBlue
        microphone_id_button.FlatStyle = FlatStyle.Popup
        microphone_id_button.Location = New Point(285, 106)
        microphone_id_button.Margin = New Padding(3, 2, 3, 2)
        microphone_id_button.Name = "microphone_id_button"
        microphone_id_button.Size = New Size(82, 22)
        microphone_id_button.TabIndex = 4
        microphone_id_button.Text = "Get IDs"
        microphone_id_button.UseVisualStyleBackColor = True
        ' 
        ' SetMicLbl
        ' 
        SetMicLbl.AutoSize = True
        SetMicLbl.Location = New Point(88, 110)
        SetMicLbl.Name = "SetMicLbl"
        SetMicLbl.Size = New Size(110, 15)
        SetMicLbl.TabIndex = 3
        SetMicLbl.Text = "Set Microphone (?):"
        ' 
        ' MicID
        ' 
        MicID.Location = New Point(204, 108)
        MicID.Margin = New Padding(3, 2, 3, 2)
        MicID.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        MicID.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        MicID.Name = "MicID"
        MicID.Size = New Size(76, 23)
        MicID.TabIndex = 2
        MicID.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' PhraseTimeout
        ' 
        PhraseTimeout.Location = New Point(204, 81)
        PhraseTimeout.Margin = New Padding(3, 2, 3, 2)
        PhraseTimeout.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        PhraseTimeout.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        PhraseTimeout.Name = "PhraseTimeout"
        PhraseTimeout.Size = New Size(76, 23)
        PhraseTimeout.TabIndex = 2
        PhraseTimeout.Value = New Decimal(New Integer() {5, 0, 0, 0})
        ' 
        ' RecordTimeout
        ' 
        RecordTimeout.Location = New Point(204, 54)
        RecordTimeout.Margin = New Padding(3, 2, 3, 2)
        RecordTimeout.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        RecordTimeout.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        RecordTimeout.Name = "RecordTimeout"
        RecordTimeout.Size = New Size(76, 23)
        RecordTimeout.TabIndex = 2
        RecordTimeout.Value = New Decimal(New Integer() {5, 0, 0, 0})
        ' 
        ' MicCaliTime
        ' 
        MicCaliTime.Location = New Point(204, 29)
        MicCaliTime.Margin = New Padding(3, 2, 3, 2)
        MicCaliTime.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        MicCaliTime.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        MicCaliTime.Name = "MicCaliTime"
        MicCaliTime.Size = New Size(76, 23)
        MicCaliTime.TabIndex = 2
        MicCaliTime.Value = New Decimal(New Integer() {5, 0, 0, 0})
        ' 
        ' PhraseTimeOutlbl
        ' 
        PhraseTimeOutlbl.AutoSize = True
        PhraseTimeOutlbl.Location = New Point(90, 83)
        PhraseTimeOutlbl.Name = "PhraseTimeOutlbl"
        PhraseTimeOutlbl.Size = New Size(108, 15)
        PhraseTimeOutlbl.TabIndex = 1
        PhraseTimeOutlbl.Text = "Phrase Timeout (?):"
        ' 
        ' EnThreshValue
        ' 
        EnThreshValue.Location = New Point(204, 4)
        EnThreshValue.Margin = New Padding(3, 2, 3, 2)
        EnThreshValue.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        EnThreshValue.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        EnThreshValue.Name = "EnThreshValue"
        EnThreshValue.Size = New Size(76, 23)
        EnThreshValue.TabIndex = 2
        EnThreshValue.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' RecordTimeoutLbl
        ' 
        RecordTimeoutLbl.AutoSize = True
        RecordTimeoutLbl.Location = New Point(88, 56)
        RecordTimeoutLbl.Name = "RecordTimeoutLbl"
        RecordTimeoutLbl.Size = New Size(110, 15)
        RecordTimeoutLbl.TabIndex = 1
        RecordTimeoutLbl.Text = "Record Timeout (?):"
        ' 
        ' MicCaliLbl
        ' 
        MicCaliLbl.AutoSize = True
        MicCaliLbl.Location = New Point(17, 31)
        MicCaliLbl.Name = "MicCaliLbl"
        MicCaliLbl.Size = New Size(181, 15)
        MicCaliLbl.TabIndex = 1
        MicCaliLbl.Text = "Microphone Calibration Time (?):"
        ' 
        ' Energy_Threshold
        ' 
        Energy_Threshold.AutoSize = True
        Energy_Threshold.Location = New Point(81, 6)
        Energy_Threshold.Name = "Energy_Threshold"
        Energy_Threshold.Size = New Size(117, 15)
        Energy_Threshold.TabIndex = 1
        Energy_Threshold.Text = "Energy Threshold (?):"
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.DarkSlateBlue
        TabPage3.Controls.Add(WhatModelsBtn)
        TabPage3.Controls.Add(demucs_model)
        TabPage3.Controls.Add(silent_duration)
        TabPage3.Controls.Add(silent_duration_lbl)
        TabPage3.Controls.Add(Label18)
        TabPage3.Controls.Add(silent_threshold)
        TabPage3.Controls.Add(silent_detect)
        TabPage3.Controls.Add(word_timestamps)
        TabPage3.Controls.Add(CaptionsName)
        TabPage3.Controls.Add(CaptionsOutput)
        TabPage3.Controls.Add(Label12)
        TabPage3.Controls.Add(CaptionsInput)
        TabPage3.Controls.Add(Label11)
        TabPage3.Controls.Add(CaptionsOutputBtn)
        TabPage3.Controls.Add(Label9)
        TabPage3.Controls.Add(CaptionsInputBtn)
        TabPage3.Location = New Point(4, 27)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(459, 312)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Generate Captions"
        ' 
        ' WhatModelsBtn
        ' 
        WhatModelsBtn.AutoSize = True
        WhatModelsBtn.Location = New Point(418, 121)
        WhatModelsBtn.Name = "WhatModelsBtn"
        WhatModelsBtn.Size = New Size(12, 15)
        WhatModelsBtn.TabIndex = 12
        WhatModelsBtn.Text = "?"
        ' 
        ' demucs_model
        ' 
        demucs_model.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        demucs_model.AutoCompleteSource = AutoCompleteSource.ListItems
        demucs_model.FormattingEnabled = True
        demucs_model.Items.AddRange(New Object() {"DEFAULT", "htdemucs", "htdemucs_ft", "htdemucs_6s", "hdemucs_mmi", "mdx", "mdx_extra", "mdx_q", "mdx_extra_q", "hdemucs", "demucs"})
        demucs_model.Location = New Point(249, 115)
        demucs_model.Name = "demucs_model"
        demucs_model.Size = New Size(163, 23)
        demucs_model.TabIndex = 11
        demucs_model.Text = "DEFAULT"
        ' 
        ' silent_duration
        ' 
        silent_duration.DecimalPlaces = 1
        silent_duration.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        silent_duration.Location = New Point(116, 145)
        silent_duration.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        silent_duration.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        silent_duration.Name = "silent_duration"
        silent_duration.Size = New Size(120, 23)
        silent_duration.TabIndex = 10
        silent_duration.ThousandsSeparator = True
        silent_duration.Value = New Decimal(New Integer() {5, 0, 0, 65536})
        ' 
        ' silent_duration_lbl
        ' 
        silent_duration_lbl.AutoSize = True
        silent_duration_lbl.Location = New Point(26, 147)
        silent_duration_lbl.Name = "silent_duration_lbl"
        silent_duration_lbl.Size = New Size(84, 15)
        silent_duration_lbl.TabIndex = 9
        silent_duration_lbl.Text = "Silent duration"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(179, 120)
        Label18.Name = "Label18"
        Label18.Size = New Size(64, 15)
        Label18.TabIndex = 8
        Label18.Text = "dB   Model"
        ' 
        ' silent_threshold
        ' 
        silent_threshold.Location = New Point(116, 116)
        silent_threshold.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        silent_threshold.Minimum = New Decimal(New Integer() {500, 0, 0, Integer.MinValue})
        silent_threshold.Name = "silent_threshold"
        silent_threshold.Size = New Size(57, 23)
        silent_threshold.TabIndex = 7
        silent_threshold.Value = New Decimal(New Integer() {35, 0, 0, Integer.MinValue})
        ' 
        ' silent_detect
        ' 
        silent_detect.AutoSize = True
        silent_detect.Location = New Point(10, 117)
        silent_detect.Name = "silent_detect"
        silent_detect.Size = New Size(100, 19)
        silent_detect.TabIndex = 6
        silent_detect.Text = "Detect Silence"
        silent_detect.UseVisualStyleBackColor = True
        ' 
        ' word_timestamps
        ' 
        word_timestamps.AutoSize = True
        word_timestamps.Location = New Point(10, 90)
        word_timestamps.Name = "word_timestamps"
        word_timestamps.Size = New Size(126, 19)
        word_timestamps.TabIndex = 5
        word_timestamps.Text = "Word Time Stamps"
        word_timestamps.UseVisualStyleBackColor = True
        ' 
        ' CaptionsName
        ' 
        CaptionsName.Location = New Point(92, 61)
        CaptionsName.Name = "CaptionsName"
        CaptionsName.PlaceholderText = "CaptionFile (just name not name.txt, etc)"
        CaptionsName.Size = New Size(320, 23)
        CaptionsName.TabIndex = 1
        ' 
        ' CaptionsOutput
        ' 
        CaptionsOutput.Location = New Point(92, 32)
        CaptionsOutput.Name = "CaptionsOutput"
        CaptionsOutput.PlaceholderText = "C:\SomeLocation"
        CaptionsOutput.Size = New Size(320, 23)
        CaptionsOutput.TabIndex = 1
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(10, 64)
        Label12.Name = "Label12"
        Label12.Size = New Size(76, 15)
        Label12.TabIndex = 0
        Label12.Text = "Export Name"
        ' 
        ' CaptionsInput
        ' 
        CaptionsInput.Location = New Point(92, 3)
        CaptionsInput.Name = "CaptionsInput"
        CaptionsInput.PlaceholderText = "C:\SomeLocation\file.mp4"
        CaptionsInput.Size = New Size(320, 23)
        CaptionsInput.TabIndex = 1
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(6, 35)
        Label11.Name = "Label11"
        Label11.Size = New Size(80, 15)
        Label11.TabIndex = 0
        Label11.Text = "Save Location"
        ' 
        ' CaptionsOutputBtn
        ' 
        CaptionsOutputBtn.FlatStyle = FlatStyle.Popup
        CaptionsOutputBtn.Location = New Point(418, 33)
        CaptionsOutputBtn.Margin = New Padding(3, 2, 3, 2)
        CaptionsOutputBtn.Name = "CaptionsOutputBtn"
        CaptionsOutputBtn.Size = New Size(35, 22)
        CaptionsOutputBtn.TabIndex = 4
        CaptionsOutputBtn.Text = "..."
        CaptionsOutputBtn.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(30, 8)
        Label9.Name = "Label9"
        Label9.Size = New Size(56, 15)
        Label9.TabIndex = 0
        Label9.Text = "Input File"
        ' 
        ' CaptionsInputBtn
        ' 
        CaptionsInputBtn.FlatStyle = FlatStyle.Popup
        CaptionsInputBtn.Location = New Point(418, 4)
        CaptionsInputBtn.Margin = New Padding(3, 2, 3, 2)
        CaptionsInputBtn.Name = "CaptionsInputBtn"
        CaptionsInputBtn.Size = New Size(35, 22)
        CaptionsInputBtn.TabIndex = 4
        CaptionsInputBtn.Text = "..."
        CaptionsInputBtn.UseVisualStyleBackColor = True
        ' 
        ' TabPage4
        ' 
        TabPage4.BackColor = Color.DarkSlateBlue
        TabPage4.Controls.Add(Label17)
        TabPage4.Controls.Add(PrecisionCheckBox)
        TabPage4.Controls.Add(Label16)
        TabPage4.Controls.Add(Label2)
        TabPage4.Controls.Add(RamSize)
        TabPage4.Controls.Add(ForceRam)
        TabPage4.Controls.Add(modelDIr)
        TabPage4.Controls.Add(modelDirPicker)
        TabPage4.Location = New Point(4, 27)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(459, 312)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Model Settings"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 12.0F)
        Label17.Location = New Point(6, 88)
        Label17.Name = "Label17"
        Label17.Size = New Size(443, 189)
        Label17.TabIndex = 9
        Label17.Text = resources.GetString("Label17.Text")
        ' 
        ' PrecisionCheckBox
        ' 
        PrecisionCheckBox.AutoSize = True
        PrecisionCheckBox.Location = New Point(241, 7)
        PrecisionCheckBox.Name = "PrecisionCheckBox"
        PrecisionCheckBox.Size = New Size(82, 19)
        PrecisionCheckBox.TabIndex = 8
        PrecisionCheckBox.Text = "Half Mode"
        PrecisionCheckBox.UseVisualStyleBackColor = True
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.DarkSlateBlue
        Label16.Location = New Point(6, 47)
        Label16.Name = "Label16"
        Label16.Size = New Size(59, 15)
        Label16.TabIndex = 5
        Label16.Text = "Model Dir"
        ' 
        ' modelDIr
        ' 
        modelDIr.Location = New Point(71, 44)
        modelDIr.Margin = New Padding(3, 2, 3, 2)
        modelDIr.Name = "modelDIr"
        modelDIr.PlaceholderText = "C:\Somelocation"
        modelDIr.Size = New Size(341, 23)
        modelDIr.TabIndex = 3
        ' 
        ' modelDirPicker
        ' 
        modelDirPicker.BackColor = Color.DodgerBlue
        modelDirPicker.FlatAppearance.MouseDownBackColor = Color.Indigo
        modelDirPicker.FlatAppearance.MouseOverBackColor = Color.SlateBlue
        modelDirPicker.FlatStyle = FlatStyle.Popup
        modelDirPicker.Location = New Point(418, 43)
        modelDirPicker.Margin = New Padding(3, 2, 3, 2)
        modelDirPicker.Name = "modelDirPicker"
        modelDirPicker.Size = New Size(35, 22)
        modelDirPicker.TabIndex = 4
        modelDirPicker.Text = "..."
        modelDirPicker.UseVisualStyleBackColor = False
        ' 
        ' isolate_vocals
        ' 
        isolate_vocals.AutoSize = True
        isolate_vocals.Dock = DockStyle.Bottom
        isolate_vocals.Location = New Point(3, 15)
        isolate_vocals.Name = "isolate_vocals"
        isolate_vocals.Size = New Size(131, 19)
        isolate_vocals.TabIndex = 6
        isolate_vocals.Text = "Isolate Vocals First"
        isolate_vocals.UseVisualStyleBackColor = True
        ' 
        ' MicIDs
        ' 
        MicIDs.Location = New Point(308, 131)
        MicIDs.Name = "MicIDs"
        MicIDs.Size = New Size(94, 29)
        MicIDs.TabIndex = 4
        MicIDs.Text = "Get IDs"
        MicIDs.UseVisualStyleBackColor = True
        ' 
        ' RunScript
        ' 
        RunScript.FlatAppearance.MouseDownBackColor = Color.Indigo
        RunScript.FlatAppearance.MouseOverBackColor = Color.SlateBlue
        RunScript.FlatStyle = FlatStyle.Popup
        RunScript.Font = New Font("Segoe UI", 15.0F)
        RunScript.Location = New Point(631, 443)
        RunScript.Margin = New Padding(3, 2, 3, 2)
        RunScript.Name = "RunScript"
        RunScript.Size = New Size(467, 44)
        RunScript.TabIndex = 20
        RunScript.Text = "Run"
        RunScript.UseVisualStyleBackColor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(205, 153)
        Label13.Name = "Label13"
        Label13.Size = New Size(112, 15)
        Label13.TabIndex = 21
        Label13.Text = "Discord Web Hook: "
        ' 
        ' DiscordWebHook
        ' 
        DiscordWebHook.Location = New Point(323, 150)
        DiscordWebHook.Margin = New Padding(3, 2, 3, 2)
        DiscordWebHook.Name = "DiscordWebHook"
        DiscordWebHook.PasswordChar = "*"c
        DiscordWebHook.PlaceholderText = "<--- Discord WebHook URL --->"
        DiscordWebHook.Size = New Size(298, 23)
        DiscordWebHook.TabIndex = 22
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(Button3)
        GroupBox5.Controls.Add(Label15)
        GroupBox5.Controls.Add(WebLinkOG)
        GroupBox5.Controls.Add(WebLinkT1)
        GroupBox5.Controls.Add(WebLinkT2)
        GroupBox5.Controls.Add(SubWindow)
        GroupBox5.ForeColor = Color.FloralWhite
        GroupBox5.Location = New Point(10, 274)
        GroupBox5.Margin = New Padding(3, 2, 3, 2)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Padding = New Padding(3, 2, 3, 2)
        GroupBox5.Size = New Size(137, 169)
        GroupBox5.TabIndex = 25
        GroupBox5.TabStop = False
        GroupBox5.Text = "Browser Source"
        ' 
        ' Button3
        ' 
        Button3.Dock = DockStyle.Bottom
        Button3.FlatAppearance.MouseDownBackColor = Color.Indigo
        Button3.FlatAppearance.MouseOverBackColor = Color.SlateBlue
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Location = New Point(3, 15)
        Button3.Name = "Button3"
        Button3.Size = New Size(131, 23)
        Button3.TabIndex = 30
        Button3.Text = "Use Web Browser"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Dock = DockStyle.Bottom
        Label15.Location = New Point(3, 38)
        Label15.Name = "Label15"
        Label15.Size = New Size(78, 15)
        Label15.TabIndex = 0
        Label15.Text = "Click to Copy"
        ' 
        ' WebLinkOG
        ' 
        WebLinkOG.Dock = DockStyle.Bottom
        WebLinkOG.FlatAppearance.MouseDownBackColor = Color.Indigo
        WebLinkOG.FlatAppearance.MouseOverBackColor = Color.SlateBlue
        WebLinkOG.FlatStyle = FlatStyle.Popup
        WebLinkOG.Location = New Point(3, 53)
        WebLinkOG.Margin = New Padding(3, 2, 3, 2)
        WebLinkOG.Name = "WebLinkOG"
        WebLinkOG.Size = New Size(131, 22)
        WebLinkOG.TabIndex = 1
        WebLinkOG.Text = "Original Text"
        WebLinkOG.UseVisualStyleBackColor = True
        ' 
        ' WebLinkT1
        ' 
        WebLinkT1.Dock = DockStyle.Bottom
        WebLinkT1.FlatAppearance.MouseDownBackColor = Color.Indigo
        WebLinkT1.FlatAppearance.MouseOverBackColor = Color.SlateBlue
        WebLinkT1.FlatStyle = FlatStyle.Popup
        WebLinkT1.Location = New Point(3, 75)
        WebLinkT1.Margin = New Padding(3, 2, 3, 2)
        WebLinkT1.Name = "WebLinkT1"
        WebLinkT1.Size = New Size(131, 22)
        WebLinkT1.TabIndex = 1
        WebLinkT1.Text = "Translation"
        WebLinkT1.UseVisualStyleBackColor = True
        ' 
        ' WebLinkT2
        ' 
        WebLinkT2.Dock = DockStyle.Bottom
        WebLinkT2.FlatAppearance.MouseDownBackColor = Color.Indigo
        WebLinkT2.FlatAppearance.MouseOverBackColor = Color.SlateBlue
        WebLinkT2.FlatStyle = FlatStyle.Popup
        WebLinkT2.Location = New Point(3, 97)
        WebLinkT2.Margin = New Padding(3, 2, 3, 2)
        WebLinkT2.Name = "WebLinkT2"
        WebLinkT2.Size = New Size(131, 22)
        WebLinkT2.TabIndex = 1
        WebLinkT2.Text = "Translation 2"
        WebLinkT2.UseVisualStyleBackColor = True
        ' 
        ' SubWindow
        ' 
        SubWindow.Dock = DockStyle.Bottom
        SubWindow.FlatAppearance.MouseDownBackColor = Color.Indigo
        SubWindow.FlatAppearance.MouseOverBackColor = Color.SlateBlue
        SubWindow.FlatStyle = FlatStyle.Popup
        SubWindow.Location = New Point(3, 119)
        SubWindow.Name = "SubWindow"
        SubWindow.Size = New Size(131, 48)
        SubWindow.TabIndex = 29
        SubWindow.Text = "Show Sub Title Window"
        SubWindow.UseVisualStyleBackColor = True
        ' 
        ' CookiesName
        ' 
        CookiesName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        CookiesName.AutoCompleteSource = AutoCompleteSource.ListItems
        CookiesName.DropDownStyle = ComboBoxStyle.DropDownList
        CookiesName.FormattingEnabled = True
        CookiesName.Location = New Point(323, 34)
        CookiesName.Margin = New Padding(3, 2, 3, 2)
        CookiesName.Name = "CookiesName"
        CookiesName.Size = New Size(256, 23)
        CookiesName.TabIndex = 26
        ' 
        ' CookiesRefresh
        ' 
        CookiesRefresh.FlatStyle = FlatStyle.Flat
        CookiesRefresh.Font = New Font("Segoe UI", 8.0F)
        CookiesRefresh.ImageAlign = ContentAlignment.TopLeft
        CookiesRefresh.Location = New Point(585, 34)
        CookiesRefresh.Margin = New Padding(3, 2, 3, 2)
        CookiesRefresh.Name = "CookiesRefresh"
        CookiesRefresh.Size = New Size(22, 21)
        CookiesRefresh.TabIndex = 27
        CookiesRefresh.Text = "🔃"
        CookiesRefresh.UseVisualStyleBackColor = True
        ' 
        ' PictureItch
        ' 
        PictureItch.Image = My.Resources.Resources.itch_io_icon_256x256_0aig5hor
        PictureItch.Location = New Point(1046, 587)
        PictureItch.Name = "PictureItch"
        PictureItch.Size = New Size(48, 48)
        PictureItch.SizeMode = PictureBoxSizeMode.Zoom
        PictureItch.TabIndex = 34
        PictureItch.TabStop = False
        ToolTip1.SetToolTip(PictureItch, "Open itch.Io Page")
        ' 
        ' GitHubPicture
        ' 
        GitHubPicture.Image = My.Resources.Resources._25231
        GitHubPicture.Location = New Point(992, 587)
        GitHubPicture.Name = "GitHubPicture"
        GitHubPicture.Size = New Size(48, 48)
        GitHubPicture.SizeMode = PictureBoxSizeMode.Zoom
        GitHubPicture.TabIndex = 35
        GitHubPicture.TabStop = False
        ToolTip1.SetToolTip(GitHubPicture, "Open Github Page")
        ' 
        ' SaveConfig
        ' 
        SaveConfig.FlatAppearance.MouseDownBackColor = Color.Indigo
        SaveConfig.FlatAppearance.MouseOverBackColor = Color.SlateBlue
        SaveConfig.FlatStyle = FlatStyle.Popup
        SaveConfig.Font = New Font("Segoe UI", 12.0F)
        SaveConfig.Location = New Point(631, 407)
        SaveConfig.Margin = New Padding(3, 2, 3, 2)
        SaveConfig.Name = "SaveConfig"
        SaveConfig.Size = New Size(467, 32)
        SaveConfig.TabIndex = 1
        SaveConfig.Text = "Quick Save"
        ToolTip1.SetToolTip(SaveConfig, "Save's the current state of the gui." & vbCrLf)
        SaveConfig.UseVisualStyleBackColor = True
        ' 
        ' WipeSettings
        ' 
        WipeSettings.FlatAppearance.MouseDownBackColor = Color.Indigo
        WipeSettings.FlatAppearance.MouseOverBackColor = Color.SlateBlue
        WipeSettings.FlatStyle = FlatStyle.Popup
        WipeSettings.Location = New Point(25, 616)
        WipeSettings.Name = "WipeSettings"
        WipeSettings.Size = New Size(123, 23)
        WipeSettings.TabIndex = 29
        WipeSettings.Text = "Wipe Settings"
        ToolTip1.SetToolTip(WipeSettings, "[DANGER] Wipes the Settings,")
        WipeSettings.UseVisualStyleBackColor = True
        ' 
        ' KoFiPicture
        ' 
        KoFiPicture.Image = CType(resources.GetObject("KoFiPicture.Image"), Image)
        KoFiPicture.Location = New Point(938, 587)
        KoFiPicture.Name = "KoFiPicture"
        KoFiPicture.Size = New Size(48, 48)
        KoFiPicture.SizeMode = PictureBoxSizeMode.Zoom
        KoFiPicture.TabIndex = 35
        KoFiPicture.TabStop = False
        ToolTip1.SetToolTip(KoFiPicture, "Open K-Fi Support Page")
        ' 
        ' CheckBoxCMDBLock
        ' 
        CheckBoxCMDBLock.AutoSize = True
        CheckBoxCMDBLock.CheckAlign = ContentAlignment.MiddleRight
        CheckBoxCMDBLock.Location = New Point(162, 616)
        CheckBoxCMDBLock.Margin = New Padding(3, 2, 3, 2)
        CheckBoxCMDBLock.Name = "CheckBoxCMDBLock"
        CheckBoxCMDBLock.RightToLeft = RightToLeft.No
        CheckBoxCMDBLock.Size = New Size(419, 19)
        CheckBoxCMDBLock.TabIndex = 28
        CheckBoxCMDBLock.Text = "Unhide command block | If you have a weebhook set, best to keep hidden."
        CheckBoxCMDBLock.UseVisualStyleBackColor = True
        ' 
        ' CaptionsInputFile
        ' 
        CaptionsInputFile.FileName = "OpenFileDialog1"
        ' 
        ' EraseCheckBox
        ' 
        EraseCheckBox.AutoSize = True
        EraseCheckBox.Location = New Point(10, 621)
        EraseCheckBox.Name = "EraseCheckBox"
        EraseCheckBox.Size = New Size(15, 14)
        EraseCheckBox.TabIndex = 30
        EraseCheckBox.UseVisualStyleBackColor = True
        ' 
        ' WordBlockList
        ' 
        WordBlockList.AutoSize = True
        WordBlockList.Dock = DockStyle.Bottom
        WordBlockList.Location = New Point(3, 72)
        WordBlockList.Name = "WordBlockList"
        WordBlockList.Size = New Size(131, 19)
        WordBlockList.TabIndex = 31
        WordBlockList.Text = "Use Word Block List"
        WordBlockList.UseVisualStyleBackColor = True
        ' 
        ' EditBlockList
        ' 
        EditBlockList.Dock = DockStyle.Bottom
        EditBlockList.FlatAppearance.MouseDownBackColor = Color.Indigo
        EditBlockList.FlatAppearance.MouseOverBackColor = Color.SlateBlue
        EditBlockList.FlatStyle = FlatStyle.Popup
        EditBlockList.Location = New Point(3, 91)
        EditBlockList.Name = "EditBlockList"
        EditBlockList.Size = New Size(131, 24)
        EditBlockList.TabIndex = 32
        EditBlockList.Text = "Edit Block List"
        EditBlockList.UseVisualStyleBackColor = True
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(isolate_vocals)
        GroupBox6.Controls.Add(auto_blocklist)
        GroupBox6.Controls.Add(RepeatProtection)
        GroupBox6.Controls.Add(WordBlockList)
        GroupBox6.Controls.Add(EditBlockList)
        GroupBox6.Controls.Add(Button1)
        GroupBox6.ForeColor = Color.FloralWhite
        GroupBox6.Location = New Point(10, 448)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(137, 141)
        GroupBox6.TabIndex = 33
        GroupBox6.TabStop = False
        GroupBox6.Text = "Features"
        ' 
        ' auto_blocklist
        ' 
        auto_blocklist.AutoSize = True
        auto_blocklist.Dock = DockStyle.Bottom
        auto_blocklist.Location = New Point(3, 34)
        auto_blocklist.Name = "auto_blocklist"
        auto_blocklist.Size = New Size(131, 19)
        auto_blocklist.TabIndex = 35
        auto_blocklist.Text = "Auto Blocklist"
        auto_blocklist.UseVisualStyleBackColor = True
        ' 
        ' RepeatProtection
        ' 
        RepeatProtection.AutoSize = True
        RepeatProtection.Checked = True
        RepeatProtection.CheckState = CheckState.Checked
        RepeatProtection.Dock = DockStyle.Bottom
        RepeatProtection.Location = New Point(3, 53)
        RepeatProtection.Name = "RepeatProtection"
        RepeatProtection.Size = New Size(131, 19)
        RepeatProtection.TabIndex = 33
        RepeatProtection.Text = "Repeat Protection"
        RepeatProtection.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Dock = DockStyle.Bottom
        Button1.FlatAppearance.MouseDownBackColor = Color.Indigo
        Button1.FlatAppearance.MouseOverBackColor = Color.SlateBlue
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Location = New Point(3, 115)
        Button1.Name = "Button1"
        Button1.Size = New Size(131, 23)
        Button1.TabIndex = 34
        Button1.Text = "Load Word Blocklist"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' paddedaudio
        ' 
        paddedaudio.AutoSize = True
        paddedaudio.CheckAlign = ContentAlignment.MiddleRight
        paddedaudio.Location = New Point(171, 178)
        paddedaudio.Name = "paddedaudio"
        paddedaudio.Size = New Size(146, 34)
        paddedaudio.TabIndex = 36
        paddedaudio.Text = "Enabled Padded Audio" & vbCrLf & "(Hover for info)"
        paddedaudio.UseVisualStyleBackColor = True
        ' 
        ' paddedaudio_value
        ' 
        paddedaudio_value.LargeChange = 1
        paddedaudio_value.Location = New Point(323, 178)
        paddedaudio_value.Minimum = 1
        paddedaudio_value.Name = "paddedaudio_value"
        paddedaudio_value.Size = New Size(267, 45)
        paddedaudio_value.TabIndex = 37
        paddedaudio_value.Value = 1
        ' 
        ' paddedaudio_nvalue
        ' 
        paddedaudio_nvalue.AutoSize = True
        paddedaudio_nvalue.Location = New Point(596, 187)
        paddedaudio_nvalue.Name = "paddedaudio_nvalue"
        paddedaudio_nvalue.Size = New Size(13, 15)
        paddedaudio_nvalue.TabIndex = 38
        paddedaudio_nvalue.Text = "1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.PyCharm_Icon_svg
        PictureBox1.Location = New Point(1046, 533)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(48, 48)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 39
        PictureBox1.TabStop = False
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(855, 533)
        Label19.Name = "Label19"
        Label19.Size = New Size(185, 30)
        Label19.TabIndex = 40
        Label19.Text = "Thanks to Jetbrains for providing" & vbCrLf & "PyCharm with their OSS Program."
        Label19.TextAlign = ContentAlignment.TopCenter
        ' 
        ' MainUI
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateBlue
        ClientSize = New Size(1102, 647)
        Controls.Add(Label19)
        Controls.Add(PictureBox1)
        Controls.Add(paddedaudio_nvalue)
        Controls.Add(ConfigTextBox)
        Controls.Add(paddedaudio_value)
        Controls.Add(paddedaudio)
        Controls.Add(KoFiPicture)
        Controls.Add(GitHubPicture)
        Controls.Add(PictureItch)
        Controls.Add(GroupBox6)
        Controls.Add(EraseCheckBox)
        Controls.Add(WipeSettings)
        Controls.Add(CheckBoxCMDBLock)
        Controls.Add(CookiesRefresh)
        Controls.Add(CookiesName)
        Controls.Add(GroupBox5)
        Controls.Add(DiscordWebHook)
        Controls.Add(Label13)
        Controls.Add(RunScript)
        Controls.Add(SettingsTabs)
        Controls.Add(GroupBox4)
        Controls.Add(EnglishTranslationCheckBox)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(GenerateConfigButton)
        Controls.Add(SecondaryTranslation)
        Controls.Add(Label5)
        Controls.Add(GroupBox3)
        Controls.Add(SecondaryTranslationLanguage)
        Controls.Add(StreamLanguage)
        Controls.Add(Label4)
        Controls.Add(SearchForProgramBTN)
        Controls.Add(ScriptFileLocation)
        Controls.Add(Label1)
        Controls.Add(SaveConfig)
        Controls.Add(SaveConfigToFileButton)
        Controls.Add(GroupBox1)
        ForeColor = Color.FloralWhite
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        Name = "MainUI"
        Opacity = 0.99R
        StartPosition = FormStartPosition.CenterScreen
        Text = "Synthalingua GUI"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(ChunkSizeTrackBar, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(PortNumber, ComponentModel.ISupportInitialize).EndInit()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        SettingsTabs.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(mic_chunk_size, ComponentModel.ISupportInitialize).EndInit()
        CType(MicID, ComponentModel.ISupportInitialize).EndInit()
        CType(PhraseTimeout, ComponentModel.ISupportInitialize).EndInit()
        CType(RecordTimeout, ComponentModel.ISupportInitialize).EndInit()
        CType(MicCaliTime, ComponentModel.ISupportInitialize).EndInit()
        CType(EnThreshValue, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        CType(silent_duration, ComponentModel.ISupportInitialize).EndInit()
        CType(silent_threshold, ComponentModel.ISupportInitialize).EndInit()
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        CType(PictureItch, ComponentModel.ISupportInitialize).EndInit()
        CType(GitHubPicture, ComponentModel.ISupportInitialize).EndInit()
        CType(KoFiPicture, ComponentModel.ISupportInitialize).EndInit()
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        CType(paddedaudio_value, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MIC_RadioButton As RadioButton
    Friend WithEvents HSL_RadioButton As RadioButton
    Friend WithEvents SaveConfigToFileButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ScriptFileLocation As TextBox
    Friend WithEvents SearchForProgramBTN As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents RamSize As ComboBox
    Friend WithEvents ForceRam As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents HLS_URL As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CPU_RadioButton As RadioButton
    Friend WithEvents CUDA_RadioButton As RadioButton
    Friend WithEvents StreamLanguage As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SecondaryTranslationLanguage As ComboBox
    Friend WithEvents SecondaryTranslation As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents EnglishTranslationCheckBox As CheckBox
    Friend WithEvents ChunkSizeTrackBar As TrackBar
    Friend WithEvents Label6 As Label
    Friend WithEvents ChunkSizeTrackBarValue As Label
    Friend WithEvents OpenScriptDiag As OpenFileDialog
    Friend WithEvents ConfigTextBox As TextBox
    Friend WithEvents GenerateConfigButton As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents PortNumber As NumericUpDown
    Friend WithEvents WebServerButton As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents SettingsTabs As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents RunScript As Button
    Friend WithEvents Energy_Threshold As Label
    Friend WithEvents PhraseTimeout As NumericUpDown
    Friend WithEvents RecordTimeout As NumericUpDown
    Friend WithEvents MicCaliTime As NumericUpDown
    Friend WithEvents PhraseTimeOutlbl As Label
    Friend WithEvents EnThreshValue As NumericUpDown
    Friend WithEvents RecordTimeoutLbl As Label
    Friend WithEvents MicCaliLbl As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents DiscordWebHook As TextBox
    Friend WithEvents SetMicLbl As Label
    Friend WithEvents MicID As NumericUpDown
    Friend WithEvents MicIDs As Button
    Friend WithEvents microphone_id_button As Button
    Friend WithEvents PhraseTimeOutCheckbox As CheckBox
    Friend WithEvents RecordTimeOutCHeckBox As CheckBox
    Friend WithEvents MicCaliCheckBox As CheckBox
    Friend WithEvents MicEnCheckBox As CheckBox
    Friend WithEvents ShowOriginalText As CheckBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents WebLinkT1 As Button
    Friend WithEvents WebLinkOG As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents WebLinkT2 As Button
    Friend WithEvents CookiesName As ComboBox
    Friend WithEvents CookiesRefresh As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CheckBoxCMDBLock As CheckBox
    Friend WithEvents SubWindow As Button
    Friend WithEvents CAP_RadioButton As RadioButton
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents CaptionsName As TextBox
    Friend WithEvents CaptionsOutput As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CaptionsInput As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CaptionsOutputBtn As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents CaptionsInputBtn As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents CaptionsInputFile As OpenFileDialog
    Friend WithEvents SaveConfig As Button
    Friend WithEvents WipeSettings As Button
    Friend WithEvents EraseCheckBox As CheckBox
    Friend WithEvents WordBlockList As CheckBox
    Friend WithEvents EditBlockList As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents RepeatProtection As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents hlspassword As TextBox
    Friend WithEvents hlspassid As TextBox
    Friend WithEvents cb_halspassword As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureItch As PictureBox
    Friend WithEvents GitHubPicture As PictureBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents modelDIr As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents modelDirPicker As Button
    Friend WithEvents FolderBrowserDialog2 As FolderBrowserDialog
    Friend WithEvents PrecisionCheckBox As CheckBox
    Friend WithEvents Label17 As Label
    Friend WithEvents KoFiPicture As PictureBox
    Friend WithEvents AutoHLS_Checkbox As CheckBox
    Friend WithEvents auto_blocklist As CheckBox
    Friend WithEvents SelectSource As CheckBox
    Friend WithEvents isolate_vocals As CheckBox
    Friend WithEvents word_timestamps As CheckBox
    Friend WithEvents mic_chunk_size As NumericUpDown
    Friend WithEvents SetMicChunkSizeLbl As Label
    Friend WithEvents paddedaudio As CheckBox
    Friend WithEvents paddedaudio_value As TrackBar
    Friend WithEvents paddedaudio_nvalue As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents silent_threshold As NumericUpDown
    Friend WithEvents silent_detect As CheckBox
    Friend WithEvents silent_duration As NumericUpDown
    Friend WithEvents silent_duration_lbl As Label
    Friend WithEvents demucs_model As ComboBox
    Friend WithEvents WhatModelsBtn As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label19 As Label

End Class
