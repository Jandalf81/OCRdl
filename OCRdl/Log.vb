Public Class Log
    Private Property control As TextBox

    Public Property printDEBUG As Boolean
    Public Property printSUCC As Boolean
    Public Property printINFO As Boolean
    Public Property printWARN As Boolean
    Public Property printERROR As Boolean

    Private Delegate Sub DEL_print(logmessage As logmessage)

    Public Enum MessageLevel
        DEBUG
        SUCC
        INFO
        WARN
        [ERROR]
    End Enum

    Public Sub New(control As TextBox)
        Me.control = control
    End Sub

    Public Sub New(control As TextBox, printDEBUG As Boolean, printSUCC As Boolean, printINFO As Boolean, printWARN As Boolean, printERROR As Boolean)
        Me.control = control

        Me.printDEBUG = printDEBUG
        Me.printSUCC = printSUCC
        Me.printINFO = printINFO
        Me.printWARN = printWARN
        Me.printERROR = printERROR
    End Sub

    Public Sub add(messageLevel As MessageLevel, message As String)
        add(messageLevel, message, 0)
    End Sub

    Public Sub add(messageLevel As MessageLevel, message As String, nestLevel As Integer)
        Select Case messageLevel
            Case MessageLevel.DEBUG
                If (Me.printDEBUG = True) Then print(messageLevel, message, nestLevel)
            Case MessageLevel.SUCC
                If (Me.printSUCC = True) Then print(messageLevel, message, nestLevel)
            Case MessageLevel.INFO
                If (Me.printINFO = True) Then print(messageLevel, message, nestLevel)
            Case MessageLevel.WARN
                If (Me.printWARN = True) Then print(messageLevel, message, nestLevel)
            Case MessageLevel.ERROR
                If (Me.printERROR = True) Then print(messageLevel, message, nestLevel)
        End Select
    End Sub

    Private Sub print(messageLevel As MessageLevel, message As String, nestLevel As Integer)
        If (control.InvokeRequired = True) Then
            Dim logmessage As New logmessage(messageLevel, message, nestLevel)

            control.Invoke(New DEL_print(AddressOf print), logmessage)
        Else
            Dim timestamp As String
            Dim nest As String

            timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            nest = ""

            For i As Integer = 0 To nestLevel - 1
                nest &= vbTab
            Next

            control.AppendText(timestamp & vbTab & messageLevel.ToString & vbTab & nest & message & vbCrLf)
        End If
    End Sub

    Private Sub print(logmessage As logmessage)
        print(logmessage.messagelevel, logmessage.message, logmessage.nestlevel)
    End Sub

    Private Class logmessage
        Public Property messagelevel As MessageLevel
        Public Property message As String
        Public Property nestlevel As Integer

        Public Sub New(messagelevel As MessageLevel, message As String, nestlevel As Integer)
            Me.messagelevel = messagelevel
            Me.message = message
            Me.nestlevel = nestlevel
        End Sub
    End Class
End Class


