Public Class frm_Main
    Public mySettings As New Settings()
    Public myOCRemix As OCRemix
    Public myLog As Log

    Friend WithEvents bgw_Download As New System.ComponentModel.BackgroundWorker()
    Public Delegate Sub DEL_addToLog(newMessage As String)


#Region "GUI events"
    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        bgw_Download.WorkerReportsProgress = True
        bgw_Download.WorkerSupportsCancellation = True

        mySettings.Load()
        cmb_Settings_DownloadFrom.SelectedItem = mySettings.DownloadFrom
        txt_Settings_DownloadTo.Text = mySettings.DownloadTo
        txt_Settings_CreateSubdirectories.Text = mySettings.CreateSubdirectories
        num_Settings_MaxErrors.Value = mySettings.MaxErrors
    End Sub

    Private Sub frm_Main_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        mySettings.CreateSubdirectories = txt_Settings_CreateSubdirectories.Text

        mySettings.Save()
    End Sub
#End Region

#Region "GUI controls"
    Private Sub btn_Settings_DownloadTo_Click(sender As Object, e As EventArgs) Handles btn_Settings_DownloadTo.Click
        Dim fbd As New FolderBrowserDialog()

        With fbd
            .Description = "Set the destination directory"
            .RootFolder = System.Environment.SpecialFolder.MyComputer
            .ShowNewFolderButton = True
        End With

        If (fbd.ShowDialog() = DialogResult.OK) Then
            mySettings.DownloadTo = fbd.SelectedPath
            txt_Settings_DownloadTo.Text = mySettings.DownloadTo
            txt_Settings_CreateSubdirectories.Text = mySettings.CreateSubdirectories
        End If
    End Sub

    Private Sub cmb_Settings_DownloadFrom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Settings_DownloadFrom.SelectedIndexChanged
        mySettings.DownloadFrom = cmb_Settings_DownloadFrom.SelectedItem
    End Sub

    Private Sub btn_Settings_CreateSubdirectories_Click(sender As Object, e As EventArgs) Handles btn_Settings_CreateSubdirectories.Click
        ctx_Settings_CreateSubdirectories.Show(btn_Settings_CreateSubdirectories, New Point(16, 16))
    End Sub

    Private Sub mnu_Item_Click(sender As Object, e As EventArgs) Handles _
            mnu_mp3file.Click,
            mnu_GameComposer.Click,
            mnu_GameName.Click,
            mnu_GameOrganisation.Click,
            mnu_GameSong.Click,
            mnu_GameSystem.Click,
            mnu_GameYear.Click,
            mnu_RemixId.Click,
            mnu_RemixName.Click,
            mnu_RemixPosted.Click,
            mnu_RemixRemixer.Click,
            mnu_TagsInstrument.Click,
            mnu_TagsMood.Click,
            mnu_Tags_Genre.Click
        Dim mnu_Item As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)

        txt_Settings_CreateSubdirectories.AppendText(mnu_Item.Text)
        txt_Settings_CreateSubdirectories.Select()
    End Sub

    Private Sub num_Settings_MaxErrors_ValueChanged(sender As Object, e As EventArgs) Handles num_Settings_MaxErrors.ValueChanged
        mySettings.MaxErrors = num_Settings_MaxErrors.Value
    End Sub

    Private Sub btn_Download_Click(sender As Object, e As EventArgs) Handles btn_Download.Click
        btn_Download.Enabled = False
        btn_Cancel.Enabled = True

        mySettings.CreateSubdirectories = txt_Settings_CreateSubdirectories.Text
        mySettings.Save()

        bgw_Download.RunWorkerAsync()
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        btn_Cancel.Text = "Canceling..."

        bgw_Download.CancelAsync()
    End Sub
#End Region

#Region "Background Worker"
    Private Sub bgw_Download_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgw_Download.DoWork
        Dim currentOCR As Integer = mySettings.LastSuccess + 1
        Dim currentErrors As Integer = 0

        Do
            Try
                If bgw_Download.CancellationPending = True Then
                    addToLog("INFO" & vbTab & "Operation canceled by user")
                    Exit Sub
                End If

                If (currentErrors >= mySettings.MaxErrors) Then
                    addToLog("ERROR" & vbTab & "max errors reached!")
                    Exit Sub
                End If

                addToLog("INFO" & vbTab & "now looking for OCR" & Strings.Right("00000" & currentOCR, 5) & "...")

                myOCRemix = New OCRemix(currentOCR)

                addToLog("INFO" & vbTab & vbTab & "trying to get HTML page from " & myOCRemix.Url & "...")
                myOCRemix.getHTMLSource()
                addToLog("SUCC" & vbTab & vbTab & "HTML page found!")

                addToLog("INFO" & vbTab & vbTab & "trying to get metadata from HTML page...")
                myOCRemix.getMetadata(mySettings)
                addToLog("SUCC" & vbTab & vbTab & "got metadata from HTML page!")

                addToLog("INFO" & vbTab & vbTab & "trying to download file from " & myOCRemix.Mp3Url & "...")
                myOCRemix.download(mySettings)
                addToLog("SUCC" & vbTab & vbTab & "download successful!")

                addToLog("INFO" & vbTab & vbTab & "trying to save the metadata...")
                myOCRemix.saveMetadata()
                addToLog("SUCC" & vbTab & vbTab & "metadata saved successfully!")
            Catch ex As GetHTMLException
                currentErrors += 1

                addToLog("WARN" & vbTab & vbTab & ex.Message & "(" & currentErrors & " / " & mySettings.MaxErrors & ")")
            Catch ex As GetMetadataException
                addToLog("ERROR" & vbTab & vbTab & ex.Message)
            Catch ex As DownloadException
                addToLog("ERROR" & vbTab & vbTab & ex.Message)
            Catch ex As SaveMetadataException
                addToLog("ERROR" & vbTab & vbTab & ex.Message)
            Finally
                System.Threading.Thread.Sleep(1000)

                currentOCR += 1
            End Try
        Loop
    End Sub

    Private Sub bgw_Download_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgw_Download.ProgressChanged
        'addToLog("Progress: " & e.ProgressPercentage)
    End Sub

    Private Sub bgw_Download_Completed(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgw_Download.RunWorkerCompleted
        btn_Download.Enabled = True
        btn_Cancel.Enabled = False
    End Sub
#End Region


    Private Sub addToLog(newMessage As String)
        If Me.txt_Log.InvokeRequired Then
            Me.Invoke(New DEL_addToLog(AddressOf _functions.addToLog), newMessage)
        Else
            _functions.addToLog(newMessage)
        End If
    End Sub
End Class
