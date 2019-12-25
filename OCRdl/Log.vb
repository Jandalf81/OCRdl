Public Class Log
    Public Property control As TextBox

    Public Property printDEBUG As Boolean
    Public Property printSUCC As Boolean
    Public Property printINFO As Boolean
    Public Property printWARN As Boolean
    Public Property printERROR As Boolean

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
        Dim timestamp As String
        timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

        Select Case messageLevel
            Case MessageLevel.DEBUG
                If (Me.printDEBUG = True) Then GoTo Print Else
            Case MessageLevel.SUCC
                If (Me.printSUCC = True) Then GoTo Print Else
            Case MessageLevel.INFO
                If (Me.printINFO = True) Then GoTo Print Else
            Case MessageLevel.WARN
                If (Me.printWARN = True) Then GoTo Print Else
            Case MessageLevel.ERROR
                If (Me.printERROR = True) Then GoTo Print Else
        End Select

        Exit Sub
Print:
        control.AppendText(timestamp & vbTab & messageLevel.ToString & vbTab & message)
    End Sub
End Class