Imports System.Text.RegularExpressions

Public Class OCRemix
    Private Const baseUrl As String = "https://ocremix.org/remix/OCR"

    Private _number As Integer                          'Constructor
    Private _url As String                              'SET Number
    Private _HTMLSource As String                       'getHTMLSource()

    Private _mp3Url As String                           'getMetadata()

    Private _GameName As String                         'getMetadata()
    Private _RemixName As String                        'getMetadata()
    Private _RemixRemixer As New List(Of String)        'getMetadata()
    Private _RemixPosted As Date                        'getMetadata()
    Private _GameSong As New List(Of String)            'getMetadata()
    Private _GameOrganisation As String                 'getMetadata()
    Private _GameYear As Integer                        'getMetadata()
    Private _GameSystem As String                       'getMetadata()
    Private _GameComposer As New List(Of String)        'getMetadata()
    Private _TagsGenre As New List(Of String)           'getMetadata()
    Private _TagsMood As New List(Of String)            'getMetadata()
    Private _TagsInstrumentation As New List(Of String) 'getMetadata()

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
    Public ReadOnly Property RemixRemixer As List(Of String)
        Get
            Return _RemixRemixer
        End Get
    End Property
    Public ReadOnly Property RemixPosted As Date
        Get
            Return _RemixPosted
        End Get
    End Property
    Public ReadOnly Property GameSong As List(Of String)
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
    Public ReadOnly Property GameComposer As List(Of String)
        Get
            Return _GameComposer
        End Get
    End Property
    Public ReadOnly Property TagsGenre As List(Of String)
        Get
            Return _TagsGenre
        End Get
    End Property
    Public ReadOnly Property TagsMood As List(Of String)
        Get
            Return _TagsMood
        End Get
    End Property
    Public ReadOnly Property TagsInstrumentation As List(Of String)
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
        Dim mc As MatchCollection
        Dim temp As String

        ' metadata = Regex.Match(_HTMLSource, "", RegexOptions.IgnoreCase).Groups(1).Value

        ' _mp3url
        _mp3Url = Regex.Match(_HTMLSource, "<dt class=""col-sm-3 text-right"">Name:<\/dt>\s?<dd class=""col-sm-9""><span class=""single-line-item"">(?'mp3'.*?\.mp3)<\/span><\/dd>\s?<dt class=""col-sm-3 text-right"">Size:<\/dt>", RegexOptions.IgnoreCase).Groups("mp3").Value
        If _mp3Url <> "" Then
            _mp3Url = INmySettings.DownloadFrom & "/" & _mp3Url
        End If

        ' _GameName
        _GameName = Regex.Match(_HTMLSource, "<h1>\s?<span class=""color-secondary"">ReMix: <\/span><a href=""\/game\/.*?"">(?'game'.*?)<\/a> "".*?"" <span class=""subtext"">\d{1,2}:\d{2}<\/span>\s*?<\/h1>", RegexOptions.IgnoreCase).Groups("game").Value

        ' _RemixName
        _RemixName = Regex.Match(_HTMLSource, "<h1>\s?<span class=""color-secondary"">ReMix: <\/span><a href=""\/game\/.*?"">.*?<\/a> ""(?'remixname'.*?)"" <span class=""subtext"">\d{1,2}:\d{2}<\/span>\s*?<\/h1>", RegexOptions.IgnoreCase).Groups("remixname").Value

        ' _RemixRemixer
        temp = Regex.Match(_HTMLSource, "<h2>By <a href=""\/artist\/.*?"">.*?<\/a>\s*?<\/h2>", RegexOptions.IgnoreCase).Value
        mc = Regex.Matches(temp, "<a href=""\/artist\/.*?"">(?'artist'.*?)<\/a>")
        For Each match As Match In mc
            temp = Regex.Match(match.Value, "<a href=""\/artist\/.*?"">(?'artist'.*?)<\/a>", RegexOptions.IgnoreCase).Groups("artist").Value
            _RemixRemixer.Add(temp)
        Next

        ' _RemixPosted
        _RemixPosted = Regex.Match(_HTMLSource, "<p class=""color-secondary"">Posted (?'posted'\d{4}-\d{2}-\d{2}), (<a href=""\/community\/topic\/\d{3,6}\/"" title=""views judges' decision"">)?evaluated", RegexOptions.IgnoreCase).Groups("posted").Value

        ' _GameSong
        temp = Regex.Match(_HTMLSource, "<h2>Arranging the music of (\d{1,3}|one) songs?\.\.\.<\/h2>\s*?<h3>.*?<\/h3>", RegexOptions.IgnoreCase).Value
        mc = Regex.Matches(temp, "<a href=""\/song\/.*?"">(?'song'.*?)<\/a>")
        For Each match As Match In mc
            temp = Regex.Match(match.Value, "<a href=""\/song\/.*?"">(?'song'.*?)<\/a>", RegexOptions.IgnoreCase).Groups("song").Value
            _GameSong.Add(temp)
        Next

        ' _GameOrganisation
        _GameOrganisation = Regex.Match(_HTMLSource, "<strong>Primary Game<\/strong>: <a href=""\/game\/.*?""><em>.*?<\/em><\/a> \(<a href=""\/org\/.*?"" class=""color-secondary"">(?'gameorg'.*?)<\/a>, \d{4}", RegexOptions.IgnoreCase).Groups("gameorg").Value

        ' _GameYear
        _GameYear = Regex.Match(_HTMLSource, "<strong>Primary Game<\/strong>: <a href=""\/game\/.*?""><em>.*?<\/em><\/a> \(<a href=""\/org\/.*?"" class=""color-secondary"">(?'gameorg'.*?)<\/a>, (?'gameyear'\d{4}), <a href=""\/system", RegexOptions.IgnoreCase).Groups("gameyear").Value

        ' _GameSystem
        _GameSystem = Regex.Match(_HTMLSource, "<strong>Primary Game<\/strong>: <a href=""\/game\/.*?""><em>.*?<\/em><\/a> \(<a href=""\/org\/.*?"" class=""color-secondary"">(?'gameorg'.*?)<\/a>, (?'gameyear'\d{4}), <a href=""\/system\/.*?"" class=""color-secondary"">(?'gamesystem'.*?)<\/a>\), music by", RegexOptions.IgnoreCase).Groups("gamesystem").Value

        ' _GameComposer
        temp = Regex.Match(_HTMLSource, "<strong>Primary Game<\/strong>: <a href=""\/game\/.*?""><em>.*?<\/em><\/a> \(<a href=""\/org\/.*?"" class=""color-secondary"">(?'gameorg'.*?)<\/a>, (?'gameyear'\d{4}), <a href=""\/system\/.*?"" class=""color-secondary"">(?'gamesystem'.*?)<\/a>\), music by (?'composer'<a href=""\/artist\/.*?<\/a>)\s*?<\/div>", RegexOptions.IgnoreCase).Groups("composer").Value
        mc = Regex.Matches(temp, "<a href=""\/artist\/.*?"">(?'composer'.*?)<\/a>")
        For Each match As Match In mc
            temp = Regex.Match(match.Value, "<a href=""\/artist\/.*?"">(?'composer'.*?)<\/a>", RegexOptions.IgnoreCase).Groups("composer").Value
            _GameComposer.Add(temp)
        Next

        ' _TagsGenre
        temp = Regex.Match(_HTMLSource, "<h2>Tags(.|\s)*?Genre:<\/dt>\s*?<.*?>(?'genre'.*?)<\/dd>(.|\s)*?Mood:<\/dt>(.|\s)*?>(?'mood'.*?)<\/dd>(.|\s)*?Instrumentation:<\/dt>(.|\s)*?>(?'instrument'.*?)<\/dd>", RegexOptions.IgnoreCase).Groups("genre").Value
        If temp <> "" Then _TagsGenre = temp.Replace(", ", ",").Split(",").ToList

        ' _TagsMood
        temp = Regex.Match(_HTMLSource, "<h2>Tags(.|\s)*?Genre:<\/dt>\s*?<.*?>(?'genre'.*?)<\/dd>(.|\s)*?Mood:<\/dt>(.|\s)*?>(?'mood'.*?)<\/dd>(.|\s)*?Instrumentation:<\/dt>(.|\s)*?>(?'instrument'.*?)<\/dd>", RegexOptions.IgnoreCase).Groups("mood").Value
        If temp <> "" Then _TagsMood = temp.Replace(", ", ",").Split(",").ToList

        ' _TagsInstrumentation
        temp = Regex.Match(_HTMLSource, "<h2>Tags(.|\s)*?Genre:<\/dt>\s*?<.*?>(?'genre'.*?)<\/dd>(.|\s)*?Mood:<\/dt>(.|\s)*?>(?'mood'.*?)<\/dd>(.|\s)*?Instrumentation:<\/dt>(.|\s)*?>(?'instrument'.*?)<\/dd>", RegexOptions.IgnoreCase).Groups("instrument").Value
        If temp <> "" Then _TagsInstrumentation = temp.Replace(", ", ",").Split(",").ToList

        ' MsgBox("MP3url: " & Mp3Url & vbCrLf &
        '     "GameName: " & _GameName & vbCrLf &
        '     "RemixName: " & _RemixName)
    End Sub
End Class
