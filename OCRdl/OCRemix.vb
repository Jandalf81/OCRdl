Imports System.Text.RegularExpressions

Public Class OCRemix
    Private Const baseUrl As String = "https://ocremix.org/remix/OCR"

    Private _number As Integer
    Private _url As String
    Private _HTMLSource As String

    Private _mp3Url As String

    Private _GameName As String
    Private _RemixName As String
    Private _RemixRemixer() As String
    Private _RemixPosted As Date
    Private _GameSong() As String
    Private _GameOrganisation As String
    Private _GameYear As Integer
    Private _GameSystem As String
    Private _GameComposer() As String
    Private _TagsGenre() As String
    Private _TagsMood() As String
    Private _TagsInstrumentation() As String

    Public Property Number As Integer
        Get
            Return _number
        End Get
        Set(value As Integer)
            _number = value
            _url = baseUrl & Strings.Right("00000" & _number, 5)
        End Set
    End Property
    Public ReadOnly Property Url As String
        Get
            Return _url
        End Get
    End Property
    Public ReadOnly Property HTMLSource As String
        Get
            Return _HTMLSource
        End Get
    End Property

    Public ReadOnly Property Mp3Url As String
        Get
            Return _mp3Url
        End Get
    End Property

    Public ReadOnly Property GameName As String
        Get
            Return _GameName
        End Get
    End Property
    Public ReadOnly Property RemixName As String
        Get
            Return _RemixName
        End Get
    End Property
    Public ReadOnly Property RemixRemixer As String()
        Get
            Return _RemixRemixer
        End Get
    End Property
    Public ReadOnly Property RemixPosted As Date
        Get
            Return _RemixPosted
        End Get
    End Property
    Public ReadOnly Property GameSong As String()
        Get
            Return _GameSong
        End Get
    End Property
    Public ReadOnly Property GameOrganisation As String
        Get
            Return _GameOrganisation
        End Get
    End Property
    Public ReadOnly Property GameYear As Integer
        Get
            Return _GameYear
        End Get
    End Property
    Public ReadOnly Property GameSystem As String
        Get
            Return _GameSystem
        End Get
    End Property
    Public ReadOnly Property GameComposer As String()
        Get
            Return _GameComposer
        End Get
    End Property
    Public ReadOnly Property TagsGenre As String()
        Get
            Return _TagsGenre
        End Get
    End Property
    Public ReadOnly Property TagsMood As String()
        Get
            Return _TagsMood
        End Get
    End Property
    Public ReadOnly Property TagsInstrumentation As String()
        Get
            Return _TagsInstrumentation
        End Get
    End Property

    Public Sub New(INnumber As Integer)
        Me.Number = INnumber
    End Sub

    Public Function getHTMLSource() As Boolean
        Dim wc As Net.WebClient = New Net.WebClient()
        Dim retval As String = ""

        wc.Encoding = System.Text.Encoding.UTF8

        ' test security protocols
        Try
            retval = wc.DownloadString(Url)

            GoTo finish
        Catch ex As Exception

        End Try

        Try
            Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Ssl3
            retval = wc.DownloadString(Url)

            GoTo finish
        Catch ex As Exception

        End Try

        Try
            Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Tls
            retval = wc.DownloadString(Url)

            GoTo finish
        Catch ex As Exception

        End Try

        Try
            Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Tls11
            retval = wc.DownloadString(Url)

            GoTo finish
        Catch ex As Exception

        End Try

        Try
            Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Tls12
            retval = wc.DownloadString(Url)

            GoTo finish
        Catch ex As Exception

        End Try

finish:
        retval = System.Text.RegularExpressions.Regex.Replace(retval, "\r\n|\r|\n", "")
        _HTMLSource = retval

        If retval <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub getMetadata(INmySettings As Settings)
        ' metadata = Regex.Match(_HTMLSource, "", RegexOptions.IgnoreCase).Groups(1).Value

        _mp3Url = Regex.Match(_HTMLSource, "<dt class=""col-sm-3 text-right"">Name:<\/dt>\s?<dd class=""col-sm-9""><span class=""single-line-item"">(?'mp3'.*?\.mp3)<\/span><\/dd>\s?<dt class=""col-sm-3 text-right"">Size:<\/dt>", RegexOptions.IgnoreCase).Groups(1).Value
        If _mp3Url <> "" Then
            _mp3Url = INmySettings.DownloadFrom & "/" & _mp3Url
        End If

        _GameName = Regex.Match(_HTMLSource, "<h1>\s?<span class=""color-secondary"">ReMix: <\/span><a href=""\/game\/.*?"">(?'game'.*?)<\/a> "".*?"" <span class=""subtext"">\d{1,2}:\d{2}<\/span>\s*?<\/h1>", RegexOptions.IgnoreCase).Groups(1).Value

        _RemixName = Regex.Match(_HTMLSource, "<h1>\s?<span class=""color-secondary"">ReMix: <\/span><a href=""\/game\/.*?"">.*?<\/a> ""(?'remixname'.*?)"" <span class=""subtext"">\d{1,2}:\d{2}<\/span>\s*?<\/h1>", RegexOptions.IgnoreCase).Groups(1).Value

        ' TODO get remixer names, there can be more than one. see OCR00204
        ' tags: Regex repeated capture groups 
        Dim temp As String = Regex.Match(_HTMLSource, "<h2>By <a href=""\/artist\/.*"">.*<\/a>\s*?<\/h2>", RegexOptions.IgnoreCase).Value
        Dim mc As MatchCollection = Regex.Matches(temp, "<a href=""\/artist\/.*?"">(?'artist'.*?)<\/a>")

        MsgBox("MP3url: " & Mp3Url & vbCrLf &
            "GameName: " & _GameName & vbCrLf &
            "RemixName: " & _RemixName)
    End Sub
End Class
