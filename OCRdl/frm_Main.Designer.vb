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
        Me.btn_Settings_CreateSubdirectories = New System.Windows.Forms.Button()
        Me.txt_Settings_CreateSubdirectories = New System.Windows.Forms.TextBox()
        Me.lbl_Settings_CreateSubdirectories = New System.Windows.Forms.Label()
        Me.cmb_Settings_DownloadFrom = New System.Windows.Forms.ComboBox()
        Me.lbl_Settings_DownloadFrom = New System.Windows.Forms.Label()
        Me.btn_Settings_DownloadTo = New System.Windows.Forms.Button()
        Me.lbl_Settings_DownloadTo = New System.Windows.Forms.Label()
        Me.txt_Settings_DownloadTo = New System.Windows.Forms.TextBox()
        Me.txt_Log = New System.Windows.Forms.TextBox()
        Me.btn_Download = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.ctx_Settings_CreateSubdirectories = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnu_mp3file = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_GameComposer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_GameName = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_GameSong = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_GameSystem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.grp_Settings.SuspendLayout()
        Me.ctx_Settings_CreateSubdirectories.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_Settings
        '
        Me.grp_Settings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.grp_Settings.Size = New System.Drawing.Size(798, 95)
        Me.grp_Settings.TabIndex = 0
        Me.grp_Settings.TabStop = False
        Me.grp_Settings.Text = "Settings"
        '
        'btn_Settings_CreateSubdirectories
        '
        Me.btn_Settings_CreateSubdirectories.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Settings_CreateSubdirectories.Location = New System.Drawing.Point(727, 64)
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
        Me.txt_Settings_CreateSubdirectories.Size = New System.Drawing.Size(566, 20)
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
        Me.cmb_Settings_DownloadFrom.Size = New System.Drawing.Size(638, 21)
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
        Me.btn_Settings_DownloadTo.Location = New System.Drawing.Point(727, 37)
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
        Me.txt_Settings_DownloadTo.Size = New System.Drawing.Size(566, 20)
        Me.txt_Settings_DownloadTo.TabIndex = 0
        '
        'txt_Log
        '
        Me.txt_Log.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Log.Location = New System.Drawing.Point(12, 283)
        Me.txt_Log.Multiline = True
        Me.txt_Log.Name = "txt_Log"
        Me.txt_Log.Size = New System.Drawing.Size(798, 301)
        Me.txt_Log.TabIndex = 1
        Me.txt_Log.WordWrap = False
        '
        'btn_Download
        '
        Me.btn_Download.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Download.Location = New System.Drawing.Point(12, 196)
        Me.btn_Download.Name = "btn_Download"
        Me.btn_Download.Size = New System.Drawing.Size(671, 46)
        Me.btn_Download.TabIndex = 2
        Me.btn_Download.Text = "Download"
        Me.btn_Download.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancel.Location = New System.Drawing.Point(690, 196)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(114, 46)
        Me.btn_Cancel.TabIndex = 3
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'ctx_Settings_CreateSubdirectories
        '
        Me.ctx_Settings_CreateSubdirectories.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_mp3file, Me.ToolStripSeparator1, Me.mnu_GameComposer, Me.mnu_GameName, Me.mnu_GameSong, Me.mnu_GameSystem, Me.mnu_GameOrganisation, Me.mnu_GameYear, Me.ToolStripSeparator2, Me.mnu_RemixId, Me.mnu_RemixName, Me.mnu_RemixPosted, Me.mnu_RemixRemixer, Me.ToolStripSeparator3, Me.mnu_Tags_Genre, Me.mnu_TagsInstrument, Me.mnu_TagsMood})
        Me.ctx_Settings_CreateSubdirectories.Name = "ctx_Settings_CreateSubdirectories"
        Me.ctx_Settings_CreateSubdirectories.Size = New System.Drawing.Size(196, 330)
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
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 596)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Download)
        Me.Controls.Add(Me.txt_Log)
        Me.Controls.Add(Me.grp_Settings)
        Me.Name = "frm_Main"
        Me.Text = "OCRdl"
        Me.grp_Settings.ResumeLayout(False)
        Me.grp_Settings.PerformLayout()
        Me.ctx_Settings_CreateSubdirectories.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grp_Settings As GroupBox
    Friend WithEvents btn_Settings_DownloadTo As Button
    Friend WithEvents lbl_Settings_DownloadTo As Label
    Friend WithEvents txt_Settings_DownloadTo As TextBox
    Friend WithEvents txt_Log As TextBox
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
End Class
