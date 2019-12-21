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
        Me.grp_Settings = New System.Windows.Forms.GroupBox()
        Me.cmb_Settings_DownloadFrom = New System.Windows.Forms.ComboBox()
        Me.lbl_Settings_DownloadFrom = New System.Windows.Forms.Label()
        Me.btn_Settings_DownloadTo = New System.Windows.Forms.Button()
        Me.lbl_Settings_DownloadTo = New System.Windows.Forms.Label()
        Me.txt_Settings_DownloadTo = New System.Windows.Forms.TextBox()
        Me.txt_Log = New System.Windows.Forms.TextBox()
        Me.btn_Download = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.grp_Settings.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_Settings
        '
        Me.grp_Settings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_Settings.Controls.Add(Me.cmb_Settings_DownloadFrom)
        Me.grp_Settings.Controls.Add(Me.lbl_Settings_DownloadFrom)
        Me.grp_Settings.Controls.Add(Me.btn_Settings_DownloadTo)
        Me.grp_Settings.Controls.Add(Me.lbl_Settings_DownloadTo)
        Me.grp_Settings.Controls.Add(Me.txt_Settings_DownloadTo)
        Me.grp_Settings.Location = New System.Drawing.Point(12, 12)
        Me.grp_Settings.Name = "grp_Settings"
        Me.grp_Settings.Size = New System.Drawing.Size(618, 81)
        Me.grp_Settings.TabIndex = 0
        Me.grp_Settings.TabStop = False
        Me.grp_Settings.Text = "Settings"
        '
        'cmb_Settings_DownloadFrom
        '
        Me.cmb_Settings_DownloadFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Settings_DownloadFrom.FormattingEnabled = True
        Me.cmb_Settings_DownloadFrom.Items.AddRange(New Object() {"http://ocr.blueblue.fr/files/music/remixes", "http://iterations.org/files/music/remixes", "http://ocrmirror.org/files/music/remixes"})
        Me.cmb_Settings_DownloadFrom.Location = New System.Drawing.Point(105, 40)
        Me.cmb_Settings_DownloadFrom.Name = "cmb_Settings_DownloadFrom"
        Me.cmb_Settings_DownloadFrom.Size = New System.Drawing.Size(506, 21)
        Me.cmb_Settings_DownloadFrom.TabIndex = 4
        '
        'lbl_Settings_DownloadFrom
        '
        Me.lbl_Settings_DownloadFrom.AutoSize = True
        Me.lbl_Settings_DownloadFrom.Location = New System.Drawing.Point(6, 43)
        Me.lbl_Settings_DownloadFrom.Name = "lbl_Settings_DownloadFrom"
        Me.lbl_Settings_DownloadFrom.Size = New System.Drawing.Size(87, 13)
        Me.lbl_Settings_DownloadFrom.TabIndex = 3
        Me.lbl_Settings_DownloadFrom.Text = "Download from..."
        '
        'btn_Settings_DownloadTo
        '
        Me.btn_Settings_DownloadTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Settings_DownloadTo.Location = New System.Drawing.Point(546, 11)
        Me.btn_Settings_DownloadTo.Name = "btn_Settings_DownloadTo"
        Me.btn_Settings_DownloadTo.Size = New System.Drawing.Size(66, 23)
        Me.btn_Settings_DownloadTo.TabIndex = 2
        Me.btn_Settings_DownloadTo.Text = "Set"
        Me.btn_Settings_DownloadTo.UseVisualStyleBackColor = True
        '
        'lbl_Settings_DownloadTo
        '
        Me.lbl_Settings_DownloadTo.AutoSize = True
        Me.lbl_Settings_DownloadTo.Location = New System.Drawing.Point(6, 16)
        Me.lbl_Settings_DownloadTo.Name = "lbl_Settings_DownloadTo"
        Me.lbl_Settings_DownloadTo.Size = New System.Drawing.Size(76, 13)
        Me.lbl_Settings_DownloadTo.TabIndex = 1
        Me.lbl_Settings_DownloadTo.Text = "Download to..."
        '
        'txt_Settings_DownloadTo
        '
        Me.txt_Settings_DownloadTo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Settings_DownloadTo.Location = New System.Drawing.Point(105, 13)
        Me.txt_Settings_DownloadTo.Name = "txt_Settings_DownloadTo"
        Me.txt_Settings_DownloadTo.ReadOnly = True
        Me.txt_Settings_DownloadTo.Size = New System.Drawing.Size(435, 20)
        Me.txt_Settings_DownloadTo.TabIndex = 0
        '
        'txt_Log
        '
        Me.txt_Log.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Log.Location = New System.Drawing.Point(12, 151)
        Me.txt_Log.Multiline = True
        Me.txt_Log.Name = "txt_Log"
        Me.txt_Log.Size = New System.Drawing.Size(618, 307)
        Me.txt_Log.TabIndex = 1
        Me.txt_Log.WordWrap = False
        '
        'btn_Download
        '
        Me.btn_Download.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Download.Location = New System.Drawing.Point(12, 99)
        Me.btn_Download.Name = "btn_Download"
        Me.btn_Download.Size = New System.Drawing.Size(491, 46)
        Me.btn_Download.TabIndex = 2
        Me.btn_Download.Text = "Download"
        Me.btn_Download.UseVisualStyleBackColor = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancel.Location = New System.Drawing.Point(509, 99)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(114, 46)
        Me.btn_Cancel.TabIndex = 3
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 470)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Download)
        Me.Controls.Add(Me.txt_Log)
        Me.Controls.Add(Me.grp_Settings)
        Me.Name = "frm_Main"
        Me.Text = "OCRdl"
        Me.grp_Settings.ResumeLayout(False)
        Me.grp_Settings.PerformLayout()
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
End Class
