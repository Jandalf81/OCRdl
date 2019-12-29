<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.grp_Settings = New System.Windows.Forms.GroupBox()
        Me.chk_Settings_UseLongSystemInTag = New System.Windows.Forms.CheckBox()
        Me.num_Settings_MaxErrors = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Settings_MaxErrors = New System.Windows.Forms.Label()
        Me.btn_Settings_CreateSubdirectories = New System.Windows.Forms.Button()
        Me.txt_Settings_CreateSubdirectories = New System.Windows.Forms.TextBox()
        Me.lbl_Settings_CreateSubdirectories = New System.Windows.Forms.Label()
        Me.cmb_Settings_DownloadFrom = New System.Windows.Forms.ComboBox()
        Me.lbl_Settings_DownloadFrom = New System.Windows.Forms.Label()
        Me.btn_Settings_DownloadTo = New System.Windows.Forms.Button()
        Me.lbl_Settings_DownloadTo = New System.Windows.Forms.Label()
        Me.txt_Settings_DownloadTo = New System.Windows.Forms.TextBox()
        Me.btn_Download = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.ctx_Settings_CreateSubdirectories = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnu_mp3file = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_GameComposer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_GameName = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_GameSong = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_GameSystem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_GameSystemLong = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_GameOrganisation = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_GameYear = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_RemixId = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_RemixName = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_RemixPosted = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_RemixRemixer = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_Tags_Genre = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_TagsInstrument = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_TagsMood = New System.Windows.Forms.ToolStripMenuItem()
        Me.grp_Log = New System.Windows.Forms.GroupBox()
        Me.chk_Log_DEBUG = New System.Windows.Forms.CheckBox()
        Me.chk_Log_ERROR = New System.Windows.Forms.CheckBox()
        Me.chk_Log_WARN = New System.Windows.Forms.CheckBox()
        Me.chk_Log_INFO = New System.Windows.Forms.CheckBox()
        Me.chk_Log_SUCC = New System.Windows.Forms.CheckBox()
        Me.txt_Log = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.status_lbl_Errors = New System.Windows.Forms.ToolStripStatusLabel()
        Me.status_prg_Errors = New System.Windows.Forms.ToolStripProgressBar()
        Me.grp_Settings.SuspendLayout()
        CType(Me.num_Settings_MaxErrors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctx_Settings_CreateSubdirectories.SuspendLayout()
        Me.grp_Log.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_Settings
        '
        Me.grp_Settings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_Settings.Controls.Add(Me.chk_Settings_UseLongSystemInTag)
        Me.grp_Settings.Controls.Add(Me.num_Settings_MaxErrors)
        Me.grp_Settings.Controls.Add(Me.lbl_Settings_MaxErrors)
        Me.grp_Settings.Controls.Add(Me.btn_Settings_CreateSubdirectories)
        Me.grp_Settings.Controls.Add(Me.txt_Settings_CreateSubdirectories)
        Me.grp_Settings.Controls.Add(Me.lbl_Settings_CreateSubdirectories)
        Me.grp_Settings.Controls.Add(Me.cmb_Settings_DownloadFrom)
        Me.grp_Settings.Controls.Add(Me.lbl_Settings_DownloadFrom)
        Me.grp_Settings.Controls.Add(Me.btn_Settings_DownloadTo)
        Me.grp_Settings.Controls.Add(Me.lbl_Settings_DownloadTo)
        Me.grp_Settings.Controls.Add(Me.txt_Settings_DownloadTo)
        Me.grp_Settings.Location = New System.Drawing.Point(12, 12)
        Me.grp_Settings.Name = "grp_Settings"
        Me.grp_Settings.Size = New System.Drawing.Size(560, 139)
        Me.grp_Settings.TabIndex = 0
        Me.grp_Settings.TabStop = False
        Me.grp_Settings.Text = "Settings"
        '
        'chk_Settings_UseLongSystemInTag
        '
        Me.chk_Settings_UseLongSystemInTag.AutoSize = True
        Me.chk_Settings_UseLongSystemInTag.Location = New System.Drawing.Point(154, 118)
        Me.chk_Settings_UseLongSystemInTag.Name = "chk_Settings_UseLongSystemInTag"
        Me.chk_Settings_UseLongSystemInTag.Size = New System.Drawing.Size(263, 17)
        Me.chk_Settings_UseLongSystemInTag.TabIndex = 10
        Me.chk_Settings_UseLongSystemInTag.Text = "use long System name in Tag %ALBUM ARTIST%"
        Me.chk_Settings_UseLongSystemInTag.UseVisualStyleBackColor = True
        '
        'num_Settings_MaxErrors
        '
        Me.num_Settings_MaxErrors.Location = New System.Drawing.Point(154, 91)
        Me.num_Settings_MaxErrors.Name = "num_Settings_MaxErrors"
        Me.num_Settings_MaxErrors.Size = New System.Drawing.Size(120, 20)
        Me.num_Settings_MaxErrors.TabIndex = 9
        '
        'lbl_Settings_MaxErrors
        '
        Me.lbl_Settings_MaxErrors.AutoSize = True
        Me.lbl_Settings_MaxErrors.Location = New System.Drawing.Point(6, 93)
        Me.lbl_Settings_MaxErrors.Name = "lbl_Settings_MaxErrors"
        Me.lbl_Settings_MaxErrors.Size = New System.Drawing.Size(120, 13)
        Me.lbl_Settings_MaxErrors.TabIndex = 8
        Me.lbl_Settings_MaxErrors.Text = "Max consecutive errors:"
        '
        'btn_Settings_CreateSubdirectories
        '
        Me.btn_Settings_CreateSubdirectories.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Settings_CreateSubdirectories.Location = New System.Drawing.Point(489, 64)
        Me.btn_Settings_CreateSubdirectories.Name = "btn_Settings_CreateSubdirectories"
        Me.btn_Settings_CreateSubdirectories.Size = New System.Drawing.Size(65, 23)
        Me.btn_Settings_CreateSubdirectories.TabIndex = 7
        Me.btn_Settings_CreateSubdirectories.Text = "Add..."
        Me.btn_Settings_CreateSubdirectories.UseVisualStyleBackColor = True
        '
        'txt_Settings_CreateSubdirectories
        '
        Me.txt_Settings_CreateSubdirectories.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Settings_CreateSubdirectories.Location = New System.Drawing.Point(154, 66)
        Me.txt_Settings_CreateSubdirectories.Name = "txt_Settings_CreateSubdirectories"
        Me.txt_Settings_CreateSubdirectories.Size = New System.Drawing.Size(328, 20)
        Me.txt_Settings_CreateSubdirectories.TabIndex = 6
        '
        'lbl_Settings_CreateSubdirectories
        '
        Me.lbl_Settings_CreateSubdirectories.AutoSize = True
        Me.lbl_Settings_CreateSubdirectories.Location = New System.Drawing.Point(6, 69)
        Me.lbl_Settings_CreateSubdirectories.Name = "lbl_Settings_CreateSubdirectories"
        Me.lbl_Settings_CreateSubdirectories.Size = New System.Drawing.Size(118, 13)
        Me.lbl_Settings_CreateSubdirectories.TabIndex = 5
        Me.lbl_Settings_CreateSubdirectories.Text = "Create sub directories..."
        '
        'cmb_Settings_DownloadFrom
        '
        Me.cmb_Settings_DownloadFrom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_Settings_DownloadFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Settings_DownloadFrom.FormattingEnabled = True
        Me.cmb_Settings_DownloadFrom.Items.AddRange(New Object() {"http://ocr.blueblue.fr/files/music/remixes", "http://iterations.org/files/music/remixes", "http://ocrmirror.org/files/music/remixes"})
        Me.cmb_Settings_DownloadFrom.Location = New System.Drawing.Point(154, 13)
        Me.cmb_Settings_DownloadFrom.Name = "cmb_Settings_DownloadFrom"
        Me.cmb_Settings_DownloadFrom.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Settings_DownloadFrom.TabIndex = 4
        '
        'lbl_Settings_DownloadFrom
        '
        Me.lbl_Settings_DownloadFrom.AutoSize = True
        Me.lbl_Settings_DownloadFrom.Location = New System.Drawing.Point(6, 16)
        Me.lbl_Settings_DownloadFrom.Name = "lbl_Settings_DownloadFrom"
        Me.lbl_Settings_DownloadFrom.Size = New System.Drawing.Size(87, 13)
        Me.lbl_Settings_DownloadFrom.TabIndex = 3
        Me.lbl_Settings_DownloadFrom.Text = "Download from..."
        '
        'btn_Settings_DownloadTo
        '
        Me.btn_Settings_DownloadTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Settings_DownloadTo.Location = New System.Drawing.Point(489, 37)
        Me.btn_Settings_DownloadTo.Name = "btn_Settings_DownloadTo"
        Me.btn_Settings_DownloadTo.Size = New System.Drawing.Size(66, 23)
        Me.btn_Settings_DownloadTo.TabIndex = 2
        Me.btn_Settings_DownloadTo.Text = "Set..."
        Me.btn_Settings_DownloadTo.UseVisualStyleBackColor = True
        '
        'lbl_Settings_DownloadTo
        '
        Me.lbl_Settings_DownloadTo.AutoSize = True
        Me.lbl_Settings_DownloadTo.Location = New System.Drawing.Point(6, 43)
        Me.lbl_Settings_DownloadTo.Name = "lbl_Settings_DownloadTo"
        Me.lbl_Settings_DownloadTo.Size = New System.Drawing.Size(76, 13)
        Me.lbl_Settings_DownloadTo.TabIndex = 1
        Me.lbl_Settings_DownloadTo.Text = "Download to..."
        '
        'txt_Settings_DownloadTo
        '
        Me.txt_Settings_DownloadTo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Settings_DownloadTo.Location = New System.Drawing.Point(154, 40)
        Me.txt_Settings_DownloadTo.Name = "txt_Settings_DownloadTo"
        Me.txt_Settings_DownloadTo.ReadOnly = True
        Me.txt_Settings_DownloadTo.Size = New System.Drawing.Size(328, 20)
        Me.txt_Settings_DownloadTo.TabIndex = 0
        '
        'btn_Download
        '
        Me.btn_Download.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Download.Location = New System.Drawing.Point(12, 157)
        Me.btn_Download.Name = "btn_Download"
        Me.btn_Download.Size = New System.Drawing.Size(433, 46)
        Me.btn_Download.TabIndex = 2
        Me.btn_Download.Text = "Download"
        Me.btn_Download.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancel.Location = New System.Drawing.Point(458, 157)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(114, 46)
        Me.btn_Cancel.TabIndex = 3
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'ctx_Settings_CreateSubdirectories
        '
        Me.ctx_Settings_CreateSubdirectories.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_mp3file, Me.ToolStripSeparator1, Me.mnu_GameComposer, Me.mnu_GameName, Me.mnu_GameSong, Me.mnu_GameSystem, Me.mnu_GameSystemLong, Me.mnu_GameOrganisation, Me.mnu_GameYear, Me.ToolStripSeparator2, Me.mnu_RemixId, Me.mnu_RemixName, Me.mnu_RemixPosted, Me.mnu_RemixRemixer, Me.ToolStripSeparator3, Me.mnu_Tags_Genre, Me.mnu_TagsInstrument, Me.mnu_TagsMood})
        Me.ctx_Settings_CreateSubdirectories.Name = "ctx_Settings_CreateSubdirectories"
        Me.ctx_Settings_CreateSubdirectories.Size = New System.Drawing.Size(196, 352)
        '
        'mnu_mp3file
        '
        Me.mnu_mp3file.Name = "mnu_mp3file"
        Me.mnu_mp3file.Size = New System.Drawing.Size(195, 22)
        Me.mnu_mp3file.Text = "%mp3file%"
        Me.mnu_mp3file.ToolTipText = "File name of the MP3"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(192, 6)
        '
        'mnu_GameComposer
        '
        Me.mnu_GameComposer.Name = "mnu_GameComposer"
        Me.mnu_GameComposer.Size = New System.Drawing.Size(195, 22)
        Me.mnu_GameComposer.Text = "%game_composer%"
        '
        'mnu_GameName
        '
        Me.mnu_GameName.Name = "mnu_GameName"
        Me.mnu_GameName.Size = New System.Drawing.Size(195, 22)
        Me.mnu_GameName.Text = "%game_name%"
        Me.mnu_GameName.ToolTipText = "Name of the Game"
        '
        'mnu_GameSong
        '
        Me.mnu_GameSong.Name = "mnu_GameSong"
        Me.mnu_GameSong.Size = New System.Drawing.Size(195, 22)
        Me.mnu_GameSong.Text = "%game_song%"
        Me.mnu_GameSong.ToolTipText = "Name of the original Track"
        '
        'mnu_GameSystem
        '
        Me.mnu_GameSystem.Name = "mnu_GameSystem"
        Me.mnu_GameSystem.Size = New System.Drawing.Size(195, 22)
        Me.mnu_GameSystem.Text = "%game_system%"
        Me.mnu_GameSystem.ToolTipText = "The system the game was released on"
        '
        'mnu_GameSystemLong
        '
        Me.mnu_GameSystemLong.Name = "mnu_GameSystemLong"
        Me.mnu_GameSystemLong.Size = New System.Drawing.Size(195, 22)
        Me.mnu_GameSystemLong.Text = "%game_system_long%"
        '
        'mnu_GameOrganisation
        '
        Me.mnu_GameOrganisation.Name = "mnu_GameOrganisation"
        Me.mnu_GameOrganisation.Size = New System.Drawing.Size(195, 22)
        Me.mnu_GameOrganisation.Text = "%game_organisation%"
        Me.mnu_GameOrganisation.ToolTipText = "Creator of the Game"
        '
        'mnu_GameYear
        '
        Me.mnu_GameYear.Name = "mnu_GameYear"
        Me.mnu_GameYear.Size = New System.Drawing.Size(195, 22)
        Me.mnu_GameYear.Text = "%game_year%"
        Me.mnu_GameYear.ToolTipText = "Year of the game release"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(192, 6)
        '
        'mnu_RemixId
        '
        Me.mnu_RemixId.Name = "mnu_RemixId"
        Me.mnu_RemixId.Size = New System.Drawing.Size(195, 22)
        Me.mnu_RemixId.Text = "%remix_id%"
        Me.mnu_RemixId.ToolTipText = "ID of the remix"
        '
        'mnu_RemixName
        '
        Me.mnu_RemixName.Name = "mnu_RemixName"
        Me.mnu_RemixName.Size = New System.Drawing.Size(195, 22)
        Me.mnu_RemixName.Text = "%remix_name%"
        Me.mnu_RemixName.ToolTipText = "Name of the remix"
        '
        'mnu_RemixPosted
        '
        Me.mnu_RemixPosted.Name = "mnu_RemixPosted"
        Me.mnu_RemixPosted.Size = New System.Drawing.Size(195, 22)
        Me.mnu_RemixPosted.Text = "%remix_posted%"
        Me.mnu_RemixPosted.ToolTipText = "Date when the remix was posted"
        '
        'mnu_RemixRemixer
        '
        Me.mnu_RemixRemixer.Name = "mnu_RemixRemixer"
        Me.mnu_RemixRemixer.Size = New System.Drawing.Size(195, 22)
        Me.mnu_RemixRemixer.Text = "%remix_remixer%"
        Me.mnu_RemixRemixer.ToolTipText = "Name of the remixer"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(192, 6)
        '
        'mnu_Tags_Genre
        '
        Me.mnu_Tags_Genre.Name = "mnu_Tags_Genre"
        Me.mnu_Tags_Genre.Size = New System.Drawing.Size(195, 22)
        Me.mnu_Tags_Genre.Text = "%tags_genre%"
        '
        'mnu_TagsInstrument
        '
        Me.mnu_TagsInstrument.Name = "mnu_TagsInstrument"
        Me.mnu_TagsInstrument.Size = New System.Drawing.Size(195, 22)
        Me.mnu_TagsInstrument.Text = "%tags_instrument%"
        '
        'mnu_TagsMood
        '
        Me.mnu_TagsMood.Name = "mnu_TagsMood"
        Me.mnu_TagsMood.Size = New System.Drawing.Size(195, 22)
        Me.mnu_TagsMood.Text = "%tags_mood%"
        '
        'grp_Log
        '
        Me.grp_Log.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_Log.Controls.Add(Me.chk_Log_DEBUG)
        Me.grp_Log.Controls.Add(Me.chk_Log_ERROR)
        Me.grp_Log.Controls.Add(Me.chk_Log_WARN)
        Me.grp_Log.Controls.Add(Me.chk_Log_INFO)
        Me.grp_Log.Controls.Add(Me.chk_Log_SUCC)
        Me.grp_Log.Controls.Add(Me.txt_Log)
        Me.grp_Log.Location = New System.Drawing.Point(12, 209)
        Me.grp_Log.Name = "grp_Log"
        Me.grp_Log.Size = New System.Drawing.Size(560, 327)
        Me.grp_Log.TabIndex = 4
        Me.grp_Log.TabStop = False
        Me.grp_Log.Text = "Log"
        '
        'chk_Log_DEBUG
        '
        Me.chk_Log_DEBUG.AutoSize = True
        Me.chk_Log_DEBUG.Location = New System.Drawing.Point(439, 20)
        Me.chk_Log_DEBUG.Name = "chk_Log_DEBUG"
        Me.chk_Log_DEBUG.Size = New System.Drawing.Size(64, 17)
        Me.chk_Log_DEBUG.TabIndex = 7
        Me.chk_Log_DEBUG.Text = "DEBUG"
        Me.chk_Log_DEBUG.UseVisualStyleBackColor = True
        '
        'chk_Log_ERROR
        '
        Me.chk_Log_ERROR.AutoSize = True
        Me.chk_Log_ERROR.Location = New System.Drawing.Point(328, 20)
        Me.chk_Log_ERROR.Name = "chk_Log_ERROR"
        Me.chk_Log_ERROR.Size = New System.Drawing.Size(65, 17)
        Me.chk_Log_ERROR.TabIndex = 6
        Me.chk_Log_ERROR.Text = "ERROR"
        Me.chk_Log_ERROR.UseVisualStyleBackColor = True
        '
        'chk_Log_WARN
        '
        Me.chk_Log_WARN.AutoSize = True
        Me.chk_Log_WARN.Location = New System.Drawing.Point(218, 20)
        Me.chk_Log_WARN.Name = "chk_Log_WARN"
        Me.chk_Log_WARN.Size = New System.Drawing.Size(74, 17)
        Me.chk_Log_WARN.TabIndex = 5
        Me.chk_Log_WARN.Text = "WARNing"
        Me.chk_Log_WARN.UseVisualStyleBackColor = True
        '
        'chk_Log_INFO
        '
        Me.chk_Log_INFO.AutoSize = True
        Me.chk_Log_INFO.Location = New System.Drawing.Point(125, 20)
        Me.chk_Log_INFO.Name = "chk_Log_INFO"
        Me.chk_Log_INFO.Size = New System.Drawing.Size(51, 17)
        Me.chk_Log_INFO.TabIndex = 4
        Me.chk_Log_INFO.Text = "INFO"
        Me.chk_Log_INFO.UseVisualStyleBackColor = True
        '
        'chk_Log_SUCC
        '
        Me.chk_Log_SUCC.AutoSize = True
        Me.chk_Log_SUCC.Location = New System.Drawing.Point(9, 20)
        Me.chk_Log_SUCC.Name = "chk_Log_SUCC"
        Me.chk_Log_SUCC.Size = New System.Drawing.Size(71, 17)
        Me.chk_Log_SUCC.TabIndex = 3
        Me.chk_Log_SUCC.Text = "SUCCess"
        Me.chk_Log_SUCC.UseVisualStyleBackColor = True
        '
        'txt_Log
        '
        Me.txt_Log.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Log.Location = New System.Drawing.Point(6, 43)
        Me.txt_Log.Multiline = True
        Me.txt_Log.Name = "txt_Log"
        Me.txt_Log.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_Log.Size = New System.Drawing.Size(548, 278)
        Me.txt_Log.TabIndex = 2
        Me.txt_Log.WordWrap = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.status_lbl_Errors, Me.status_prg_Errors})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(584, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'status_lbl_Errors
        '
        Me.status_lbl_Errors.Name = "status_lbl_Errors"
        Me.status_lbl_Errors.Size = New System.Drawing.Size(117, 17)
        Me.status_lbl_Errors.Text = "Consecutive Errors: 0"
        '
        'status_prg_Errors
        '
        Me.status_prg_Errors.Name = "status_prg_Errors"
        Me.status_prg_Errors.Size = New System.Drawing.Size(100, 16)
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 561)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.grp_Log)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Download)
        Me.Controls.Add(Me.grp_Settings)
        Me.MinimumSize = New System.Drawing.Size(600, 600)
        Me.Name = "frm_Main"
        Me.Text = "OCRdl"
        Me.grp_Settings.ResumeLayout(False)
        Me.grp_Settings.PerformLayout()
        CType(Me.num_Settings_MaxErrors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctx_Settings_CreateSubdirectories.ResumeLayout(False)
        Me.grp_Log.ResumeLayout(False)
        Me.grp_Log.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grp_Settings As GroupBox
    Friend WithEvents btn_Settings_DownloadTo As Button
    Friend WithEvents lbl_Settings_DownloadTo As Label
    Friend WithEvents txt_Settings_DownloadTo As TextBox
    Friend WithEvents btn_Download As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents cmb_Settings_DownloadFrom As ComboBox
    Friend WithEvents lbl_Settings_DownloadFrom As Label
    Friend WithEvents btn_Settings_CreateSubdirectories As Button
    Friend WithEvents txt_Settings_CreateSubdirectories As TextBox
    Friend WithEvents lbl_Settings_CreateSubdirectories As Label
    Friend WithEvents ctx_Settings_CreateSubdirectories As ContextMenuStrip
    Friend WithEvents mnu_mp3file As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnu_GameName As ToolStripMenuItem
    Friend WithEvents mnu_GameSong As ToolStripMenuItem
    Friend WithEvents mnu_GameComposer As ToolStripMenuItem
    Friend WithEvents mnu_GameSystem As ToolStripMenuItem
    Friend WithEvents mnu_GameOrganisation As ToolStripMenuItem
    Friend WithEvents mnu_GameYear As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents mnu_RemixId As ToolStripMenuItem
    Friend WithEvents mnu_RemixName As ToolStripMenuItem
    Friend WithEvents mnu_RemixPosted As ToolStripMenuItem
    Friend WithEvents mnu_RemixRemixer As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents mnu_Tags_Genre As ToolStripMenuItem
    Friend WithEvents mnu_TagsInstrument As ToolStripMenuItem
    Friend WithEvents mnu_TagsMood As ToolStripMenuItem
    Friend WithEvents num_Settings_MaxErrors As NumericUpDown
    Friend WithEvents lbl_Settings_MaxErrors As Label
    Friend WithEvents grp_Log As GroupBox
    Friend WithEvents chk_Log_DEBUG As CheckBox
    Friend WithEvents chk_Log_ERROR As CheckBox
    Friend WithEvents chk_Log_WARN As CheckBox
    Friend WithEvents chk_Log_INFO As CheckBox
    Friend WithEvents chk_Log_SUCC As CheckBox
    Friend WithEvents txt_Log As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents status_lbl_Errors As ToolStripStatusLabel
    Friend WithEvents status_prg_Errors As ToolStripProgressBar
    Friend WithEvents mnu_GameSystemLong As ToolStripMenuItem
    Friend WithEvents chk_Settings_UseLongSystemInTag As CheckBox
End Class
