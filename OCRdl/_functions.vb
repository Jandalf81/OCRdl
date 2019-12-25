Module _functions
    Public Sub addToLog(newMessage As String)

        Dim timestamp As String
        timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

        frm_Main.txt_Log.AppendText(timestamp & vbTab & newMessage & vbCrLf)
    End Sub
End Module