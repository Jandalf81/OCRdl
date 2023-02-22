Imports System.Text.RegularExpressions

Public Class OCRemix
    Private Const baseUrl As String = "https://ocremix.org"

    Private _number As Integer                          'Constructor
    Private _id As String                               'SET Number
    Private _url As String                              'SET Number
    Private _HTMLSource As String                       'getHTMLSource()

    Private _mp3Name As String                          'getMetadata()
    Private _mp3Url As String                           'getMetadata()
    Private _mp3LocalFile As String                     'download()

    Private _GameUrl As String                          'getMetadata()

    Private _GameName As String                         'getMetadata()
    Private _RemixName As String                        'getMetadata()
    Private _RemixRemixer As New List(Of String)        'getMetadata()
    Private _RemixPosted As Date                        'getMetadata()
    Private _GameSong As New List(Of String)            'getMetadata()
    Private _GameOrganisation As String                 'getMetadata()
    Private _GameYear As Integer                        'getMetadata()
    Private _GameSystem As String                       'getMetadata()
    Private _GameSystemLong As String                   'getMetadata()
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
            _id = "OCR" & Strings.Right("00000" & _number, 5)
            _url = baseUrl & "/remix/" & _id
        End Set
    End Property
    Public ReadOnly Property Id As String
        Get
            Return _id
        End Get
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

    Public ReadOnly Property Mp3Name As String
        Get
            Return _mp3Name
        End Get
    End Property
    Public ReadOnly Property Mp3Url As String
        Get
            Return _mp3Url
        End Get
    End Property
    Public ReadOnly Property Mp3LocalFile As String
        Get
            Return _mp3LocalFile
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
    Public ReadOnly Property RemixRemixer As String
        Get
            Dim retval As String = ""

            For Each item In _RemixRemixer
                retval &= item & ", "
            Next

            retval = Regex.Replace(retval, ", $", "")

            Return retval
        End Get
    End Property
    Public ReadOnly Property RemixPosted As String
        Get
            Return _RemixPosted.ToString("yyyy-MM-dd")
        End Get
    End Property
    Public ReadOnly Property GameSong As String
        Get
            Dim retval As String = ""

            For Each item In _GameSong
                retval &= item & ", "
            Next

            retval = Regex.Replace(retval, ", $", "")

            Return retval
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
    Public ReadOnly Property GameSystemLong As String
        Get
            Return _GameSystemLong
        End Get
    End Property
    Public ReadOnly Property GameComposer As String
        Get
            Dim retval As String = ""

            For Each item In _GameComposer
                retval &= item & ", "
            Next

            retval = Regex.Replace(retval, ", $", "")

            Return retval
        End Get
    End Property
    Public ReadOnly Property TagsGenre As String
        Get
            Dim retval As String = ""

            For Each item In _TagsGenre
                retval &= item & ", "
            Next

            retval = Regex.Replace(retval, ", $", "")

            Return retval
        End Get
    End Property
    Public ReadOnly Property TagsMood As String
        Get
            Dim retval As String = ""

            For Each item In _TagsMood
                retval &= item & ", "
            Next

            retval = Regex.Replace(retval, ", $", "")

            Return retval
        End Get
    End Property
    Public ReadOnly Property TagsInstrumentation As String
        Get
            Dim retval As String = ""

            For Each item In _TagsInstrumentation
                retval &= item & ", "
            Next

            retval = Regex.Replace(retval, ", $", "")

            Return retval
        End Get
    End Property

    Public Sub New(INnumber As Integer)
        Me.Number = INnumber
    End Sub

    Public Sub getRemixHTML()
        Me._HTMLSource = getHTMLSource(Me.Url)
    End Sub

    Public Sub getMetadata(INmySettings As Settings)
        Dim mc As MatchCollection
        Dim temp As String

        Try

            ' _mp3url
            _mp3Url = Regex.Match(_HTMLSource, "<dt class=""col-sm-3 text-right"">Name:<\/dt>\s?<dd class=""col-sm-9""><span class=""single-line-item"">(?'mp3'.*?\.mp3)<\/span><\/dd>\s?<dt class=""col-sm-3 text-right"">Size:<\/dt>", RegexOptions.IgnoreCase).Groups("mp3").Value
            _mp3Url = urlDecode(_mp3Url)

            _mp3Name = _mp3Url
            If _mp3Url <> "" Then
                _mp3Url = INmySettings.DownloadFrom & "/" & _mp3Url
            End If

            ' _GameName
            _GameName = Regex.Match(_HTMLSource, "<h1>\s?<span class=""color-secondary"">ReMix:<\/span><a href=""\/game\/.*?"">(?'game'.*?)<\/a> "".*?"" <span class=""subtext"">\d{1,2}:\d{2}<\/span>\s*?<\/h1>", RegexOptions.IgnoreCase).Groups("game").Value
            _GameName = urlDecode(_GameName)

            ' _GameUrl
            _GameUrl = Regex.Match(_HTMLSource, "<h1>\s?<span class=""color-secondary"">ReMix:<\/span><a href=""(?'gameurl'\/game\/.*?)"">(?'game'.*?)<\/a> "".*?"" <span class=""subtext"">\d{1,2}:\d{2}<\/span>\s*?<\/h1>", RegexOptions.IgnoreCase).Groups("gameurl").Value

            ' _RemixName
            _RemixName = Regex.Match(_HTMLSource, "<h1>\s?<span class=""color-secondary"">ReMix:<\/span><a href=""\/game\/.*?"">.*?<\/a> ""(?'remixname'.*?)"" <span class=""subtext"">\d{1,2}:\d{2}<\/span>\s*?<\/h1>", RegexOptions.IgnoreCase).Groups("remixname").Value

            ' _RemixRemixer
            temp = Regex.Match(_HTMLSource, "<h2>By <a href=""\/artist\/.*?"">.*?<\/a>\s*?<\/h2>", RegexOptions.IgnoreCase).Value
            mc = Regex.Matches(temp, "<a href=""\/artist\/.*?"">(?'artist'.*?)<\/a>")
            For Each match As Match In mc
                temp = Regex.Match(match.Value, "<a href=""\/artist\/.*?"">(?'artist'.*?)<\/a>", RegexOptions.IgnoreCase).Groups("artist").Value
                _RemixRemixer.Add(temp)
            Next

            ' _RemixPosted
            _RemixPosted = Regex.Match(_HTMLSource, "<p class=""color-secondary"">Posted\s*?(?'posted'\d{4}-\d{2}-\d{2}), (<a href=""\/community\/topic\/\d{3,6}\/"" title=""views judges' decision"">)?evaluated", RegexOptions.IgnoreCase).Groups("posted").Value

            ' _GameSong
            temp = Regex.Match(_HTMLSource, "<h2>Arranging the music of (\d{1,3}|one) songs?\.\.\.<\/h2>\s*?<h3>.*?<\/h3>", RegexOptions.IgnoreCase).Value
            mc = Regex.Matches(temp, "<a href=""\/song\/.*?"">(?'song'.*?)<\/a>")
            For Each match As Match In mc
                temp = Regex.Match(match.Value, "<a href=""\/song\/.*?"">(?'song'.*?)<\/a>", RegexOptions.IgnoreCase).Groups("song").Value
                _GameSong.Add(temp)
            Next

            ' _GameOrganisation
            _GameOrganisation = Regex.Match(_HTMLSource, "<strong>Primary Game<\/strong>:\s*?<a href=""\/game\/.*?""><em>.*?<\/em><\/a> \(<a href=""\/org\/.*?"" class=""color-secondary"">(?'gameorg'.*?)<\/a>\s*?, \d{4}", RegexOptions.IgnoreCase).Groups("gameorg").Value

            ' _GameYear
            _GameYear = Regex.Match(_HTMLSource, "<strong>Primary Game<\/strong>:\s*?<a href=""\/game\/.*?""><em>.*?<\/em><\/a> \(<a href=""\/org\/.*?"" class=""color-secondary"">(?'gameorg'.*?)<\/a>\s*?, (?'gameyear'\d{4}),\s*?<a href=""\/system", RegexOptions.IgnoreCase).Groups("gameyear").Value

            ' _GameSystem
            _GameSystem = Regex.Match(_HTMLSource, "<strong>Primary Game<\/strong>:\s*?<a href=""\/game\/.*?""><em>.*?<\/em><\/a> \(<a href=""\/org\/.*?"" class=""color-secondary"">(?'gameorg'.*?)<\/a>\s*?, (?'gameyear'\d{4}),\s*?<a href=""\/system\/.*?"" class=""color-secondary"">(?'gamesystem'.*?)<\/a>\), music by", RegexOptions.IgnoreCase).Groups("gamesystem").Value
            Me.getSystemNameLong()

            ' _GameComposer
            temp = Regex.Match(_HTMLSource, "<strong>Primary Game<\/strong>:\s*?<a href=""\/game\/.*?""><em>.*?<\/em><\/a> \(<a href=""\/org\/.*?"" class=""color-secondary"">(?'gameorg'.*?)<\/a>\s*?, (?'gameyear'\d{4}),\s*?<a href=""\/system\/.*?"" class=""color-secondary"">(?'gamesystem'.*?)<\/a>\), music by (?'composer'<a href=""\/artist\/.*?<\/a>)\s*?<\/div>", RegexOptions.IgnoreCase).Groups("composer").Value
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
        Catch
            Throw New GetMetadataException("Error while extracting metadata")
        End Try
    End Sub

    Public Sub download(mySettings As Settings)
        ' Build path to download the file to
        Dim toFile As String

        If (mySettings.CreateSubdirectories = "") Then
            toFile = mySettings.DownloadTo & "\" & Me.Mp3Name
        Else
            toFile = mySettings.CreateSubdirectories

            toFile = toFile.Replace("%mp3file%", Me.Mp3Name)

            toFile = toFile.Replace("%game_composer%", Me.GameComposer)
            toFile = toFile.Replace("%game_name%", Me.GameName)
            toFile = toFile.Replace("%game_organisation%", Me.GameOrganisation)
            toFile = toFile.Replace("%game_song%", Me.GameSong)
            toFile = toFile.Replace("%game_system%", Me.GameSystem)
            toFile = toFile.Replace("%game_system_long%", Me.GameSystemLong)
            toFile = toFile.Replace("%game_year%", Me.GameYear)

            toFile = toFile.Replace("%remix_id%", Me.Id)
            toFile = toFile.Replace("%remix_name%", Me.RemixName)
            toFile = toFile.Replace("%remix_posted%", Me.RemixPosted)
            toFile = toFile.Replace("%remix_remixer%", Me.RemixRemixer)

            toFile = toFile.Replace("%tags_genre%", Me.TagsGenre)
            toFile = toFile.Replace("%tags_instrument%", Me.TagsInstrumentation)
            toFile = toFile.Replace("%tags_mood%", Me.TagsMood)

            ' tidy up toFile
            toFile = toFile.Replace(":", "_")
            toFile = toFile.Replace("/", "_")
            toFile = toFile.Replace("*", "_")
            toFile = toFile.Replace("""", "")
            toFile = toFile.Replace("?", "")
            toFile = toFile.Replace("|", " ")

            toFile = mySettings.DownloadTo & "\" & toFile
        End If

        _mp3LocalFile = toFile

        ' create path to download file to
        ' ToDo make this work with very long path
        Dim path As String = My.Computer.FileSystem.GetParentPath(toFile)

        If (My.Computer.FileSystem.DirectoryExists(path) = False) Then
            My.Computer.FileSystem.CreateDirectory(path)

        End If

        downLoadFile(Me._mp3Url, toFile)
    End Sub

    Public Sub getCover()
        Dim gameHTML As String = getHTMLSource(baseUrl & "/" & Me._GameUrl)
        Dim coverURL As String
        Dim coverExt As String

        ' <div class="col-sm-4 col-md-4 col-lg-4"><div style="text-align:center;"><img src="(?'coverUrl'\/img-size\/.*?jpg)" alt=
        coverURL = Regex.Match(gameHTML, "<div class=""col-sm-4 col-md-4 col-lg-4""><div style=""text-align:center;""><img src=""(?'coverUrl'\/img-size\/.*?)"" alt=", RegexOptions.IgnoreCase).Groups("coverUrl").Value

        coverExt = IO.Path.GetExtension(coverURL)

        downLoadFile(baseUrl & "/" & coverURL, My.Computer.FileSystem.GetParentPath(Me._mp3LocalFile) & "\folder" & coverExt)

        ' convert the image if necessary
        If (coverExt <> ".jpg") Then
            Dim image As Image

            image = Image.FromFile(My.Computer.FileSystem.GetParentPath(Me._mp3LocalFile) & "\folder" & coverExt)
            image.Save(My.Computer.FileSystem.GetParentPath(Me._mp3LocalFile) & "\folder.jpg", Imaging.ImageFormat.Jpeg)

            image.Dispose()

            My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.GetParentPath(Me._mp3LocalFile) & "\folder" & coverExt)
        End If
    End Sub

    Public Sub saveMetadata(mySettings As Settings)
        Try
            Dim mp3 As TagLib.File = TagLib.File.Create(Me._mp3LocalFile)
            Dim tag As TagLib.Id3v2.Tag = CType(mp3.GetTag(TagLib.TagTypes.Id3v2), TagLib.Id3v2.Tag)
            Dim custom As TagLib.Id3v2.UserTextInformationFrame

            ' remove all tags from file
            mp3.RemoveTags(TagLib.TagTypes.AllTags) ' removes the ability to add custom tags!
            mp3.Save()
            mp3.Dispose()

            ' re-open file to re-create tags
            mp3 = TagLib.File.Create(Me._mp3LocalFile)
            TagLib.Id3v2.Tag.DefaultVersion = 4 ' needed to correctly split ARTIST
            TagLib.Id3v2.Tag.ForceDefaultVersion = True
            tag = CType(mp3.GetTag(TagLib.TagTypes.Id3v2), TagLib.Id3v2.Tag)

            tag.Performers = Me._RemixRemixer.ToArray
            tag.Title = Me._RemixName
            tag.Album = Me._GameName
            tag.Year = Me._GameYear
            tag.Genres = Me._TagsGenre.ToArray
            tag.Composers = {"Video Game Remixes"}

            custom = New TagLib.Id3v2.UserTextInformationFrame("GAME_NAME", TagLib.StringType.UTF16)
            custom.Text = {Me._GameName}
            tag.AddFrame(custom)

            custom = New TagLib.Id3v2.UserTextInformationFrame("GAME_SONG", TagLib.StringType.UTF16)
            custom.Text = Me._GameSong.ToArray
            tag.AddFrame(custom)

            If (mySettings.useLongSystemNameInTag = True) Then
                tag.AlbumArtists = {Me._GameSystemLong}

                custom = New TagLib.Id3v2.UserTextInformationFrame("GAME_SYSTEM", TagLib.StringType.UTF16)
                custom.Text = {Me._GameSystemLong}
                tag.AddFrame(custom)
            Else
                tag.AlbumArtists = {Me._GameSystem}

                custom = New TagLib.Id3v2.UserTextInformationFrame("GAME_SYSTEM", TagLib.StringType.UTF16)
                custom.Text = {Me._GameSystem}
                tag.AddFrame(custom)
            End If

            custom = New TagLib.Id3v2.UserTextInformationFrame("GAME_ORGANISATION", TagLib.StringType.UTF16)
            custom.Text = {Me._GameOrganisation}
            tag.AddFrame(custom)

            custom = New TagLib.Id3v2.UserTextInformationFrame("GAME_COMPOSER", TagLib.StringType.UTF16)
            custom.Text = Me._GameComposer.ToArray
            tag.AddFrame(custom)

            custom = New TagLib.Id3v2.UserTextInformationFrame("ID", TagLib.StringType.UTF16)
            custom.Text = {Me._id}
            tag.AddFrame(custom)

            custom = New TagLib.Id3v2.UserTextInformationFrame("REMIX_POSTED", TagLib.StringType.UTF16)
            custom.Text = {Me.RemixPosted}
            tag.AddFrame(custom)

            custom = New TagLib.Id3v2.UserTextInformationFrame("SOURCE", TagLib.StringType.UTF16)
            custom.Text = {baseUrl & "/"}
            tag.AddFrame(custom)

            custom = New TagLib.Id3v2.UserTextInformationFrame("MOOD", TagLib.StringType.UTF16)
            custom.Text = Me._TagsMood.ToArray
            tag.AddFrame(custom)

            custom = New TagLib.Id3v2.UserTextInformationFrame("INSTRUMENTS", TagLib.StringType.UTF16)
            custom.Text = Me._TagsInstrumentation.ToArray
            tag.AddFrame(custom)

            ' re-remove ID3v1 tag
            mp3.RemoveTags(TagLib.TagTypes.Id3v1)

            mp3.Save()
            mp3.Dispose()
        Catch
            Throw New SaveMetadataException("error while saving metadata")
        End Try
    End Sub

    Private Sub getSystemNameLong()
        Dim game_system_long As String = ""

        Select Case Me.GameSystem.ToLower
            Case "3do"
                game_system_long = "Panasonic 3do"
            Case "elctr"
                game_system_long = "Acorn Electron"
            Case "amiga"
                game_system_long = "Commodore Amiga"
            Case "cd32"
                game_system_long = "Commodore Amiga 32"
            Case "cpc"
                game_system_long = "Amstrad CPC"
            Case "andrd"
                game_system_long = "Google Android"
            Case "aplii"
                game_system_long = "Apple AppleII"
            Case "arc"
                game_system_long = "Arcade"
            Case "a2600"
                game_system_long = "Atari 2600"
            Case "axlxe"
                game_system_long = "Atari 400"
            Case "a5200"
                game_system_long = "Atari 5200"
            Case "a7800"
                game_system_long = "Atari 7800"
            Case "jag"
                game_system_long = "Atari Jaguar"
            Case "lynx"
                game_system_long = "Atari Lynx"
            Case "st"
                game_system_long = "Atari ST"
            Case "bbcm"
                game_system_long = "Acorn BBC Micro"
            Case "col"
                game_system_long = "Mattel Colecovision"
            Case "c64"
                game_system_long = "Commodore 64"
            Case "dos"
                game_system_long = "Microsoft DOS"
            Case "dc"
                game_system_long = "Sega Dreamcast"
            Case "fm7"
                game_system_long = "Fujitsu FM-7"
            Case "fmtwn"
                game_system_long = "Fujitsu FM-Towns"
            Case "gb"
                game_system_long = "Nintendo Game Boy"
            Case "gba"
                game_system_long = "Nintendo Game Boy Advance"
            Case "gbc"
                game_system_long = "Nintendo Game Boy Color"
            Case "gcn"
                game_system_long = "Nintendo GameCube"
            Case "intvn"
                game_system_long = "Mattel Intellivision"
            Case "ios"
                game_system_long = "Apple iOS"
            Case "linux"
                game_system_long = "Linux"
            Case "mac"
                game_system_long = "Apple Macintosh"
            Case "msx"
                game_system_long = "MSX Association MSX"
            Case "ngage"
                game_system_long = "Nokia N-Gage"
            Case "pc60"
                game_system_long = "NEC PC-6001"
            Case "pc88"
                game_system_long = "NEC PC-8801"
            Case "pc98"
                game_system_long = "NEC PC-9801"
            Case "ng"
                game_system_long = "SNK Neo Geo"
            Case "ngcd"
                game_system_long = "SNK Neo Geo CD"
            Case "ngp"
                game_system_long = "SNK Neo Geo Pocket"
            Case "ngpc"
                game_system_long = "SNK Neo Geo Pocket Color"
            Case "nes"
                game_system_long = "Nintendo NES"
            Case "3ds"
                game_system_long = "Nintendo 3DS"
            Case "n64"
                game_system_long = "Nintendo N64"
            Case "nds"
                game_system_long = "Nintendo DS"
            Case "swtch"
                game_system_long = "Nintendo Switch"
            Case "pcfx"
                game_system_long = "NEC PC-FX"
            Case "cdi"
                game_system_long = "Philips CD-i"
            Case "ps1"
                game_system_long = "Sony PlayStation"
            Case "ps2"
                game_system_long = "Sony PlayStation 2"
            Case "ps3"
                game_system_long = "Sony PlayStation 3"
            Case "ps4"
                game_system_long = "Sony PlayStation 4"
            Case "psp"
                game_system_long = "Sony PlayStation Portable"
            Case "vita"
                game_system_long = "Sony PlayStation Vita"
            Case "32x"
                game_system_long = "Sega 32X"
            Case "scd"
                game_system_long = "Sega CD"
            Case "gg"
                game_system_long = "Sega Game Gear"
            Case "gen"
                game_system_long = "Sega Genesis"
            Case "sms"
                game_system_long = "Sega Master System"
            Case "pico"
                game_system_long = "Sega Pico"
            Case "sat"
                game_system_long = "Sega Saturn"
            Case "sg1k"
                game_system_long = "Sega SG-1000"
            Case "snes"
                game_system_long = "Nintendo SuperNES"
            Case "sgfx"
                game_system_long = "NEC SuperGrafx"
            Case "tg16"
                game_system_long = "NEC TurboGrafx-16"
            Case "tgcd"
                game_system_long = "NEC TurboGrafx-CD"
            Case "vec"
                game_system_long = "Vectrex"
            Case "vb"
                game_system_long = "Nintendo Virtual Boy"
            Case "wii"
                game_system_long = "Nintendo Wii"
            Case "wiiu"
                game_system_long = "Nintendo Wii U"
            Case "win"
                game_system_long = "Microsoft Windows"
            Case "ws"
                game_system_long = "Bandai WonderSwan"
            Case "wsc"
                game_system_long = "Bandai WonderSwan Color"
            Case "x1"
                game_system_long = "Sharp X1"
            Case "x68k"
                game_system_long = "Sharp X68000"
            Case "xbox"
                game_system_long = "Microsoft Xbox"
            Case "xb360"
                game_system_long = "Microsoft Xbox 360"
            Case "xbone"
                game_system_long = "Microsoft Xbox One"
            Case "spec"
                game_system_long = "Amstrad ZX Spectrum"
        End Select

        Me._GameSystemLong = game_system_long
    End Sub

    Private Function urlDecode(url As String) As String
        url = url.Replace("&amp;", "&")

        Return url
    End Function

    Private Function getHTMLSource(url As String) As String
        Dim wc As Net.WebClient = New Net.WebClient()
        Dim retval As String = ""

        wc.Encoding = System.Text.Encoding.UTF8

        ' test security protocols
        Try
            retval = wc.DownloadString(url)

            GoTo finish
        Catch ex As Exception

        End Try

        Try
            Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Ssl3
            retval = wc.DownloadString(url)

            GoTo finish
        Catch ex As Exception

        End Try

        Try
            Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Tls
            retval = wc.DownloadString(url)

            GoTo finish
        Catch ex As Exception

        End Try

        Try
            Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Tls11
            retval = wc.DownloadString(url)

            GoTo finish
        Catch ex As Exception

        End Try

        Try
            Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Tls12
            retval = wc.DownloadString(url)

            GoTo finish
        Catch ex As Exception

        End Try

        Throw New GetHTMLException("no HTML page found")

finish:
        retval = System.Text.RegularExpressions.Regex.Replace(retval, "\r\n|\r|\n", "")
        _HTMLSource = retval

        Return retval
    End Function

    Private Sub downLoadFile(url As String, toFile As String)
        Dim wc As Net.WebClient = New Net.WebClient()
        wc.Encoding = System.Text.Encoding.UTF8

        ' test security protocols
        Try
            wc.DownloadFile(url, toFile)

            Exit Sub
        Catch ex As Exception

        End Try

        Try
            Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Ssl3
            wc.DownloadFile(url, toFile)

            Exit Sub
        Catch ex As Exception

        End Try

        Try
            Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Tls
            wc.DownloadFile(url, toFile)

            Exit Sub
        Catch ex As Exception

        End Try

        Try
            Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Tls11
            wc.DownloadFile(url, toFile)

            Exit Sub
        Catch ex As Exception

        End Try

        Try
            Net.ServicePointManager.SecurityProtocol = Net.SecurityProtocolType.Tls12
            wc.DownloadFile(url, toFile)

            Exit Sub
        Catch ex As Exception

        End Try

        Throw New DownloadException("file could not be downloaded")
    End Sub
End Class

Public Class GetHTMLException
    Inherits Exception

    Public Sub New(message As String)
        MyBase.New(message)
    End Sub
End Class

Public Class GetMetadataException
    Inherits Exception

    Public Sub New(message As String)
        MyBase.New(message)
    End Sub
End Class

Public Class DownloadException
    Inherits Exception

    Public Sub New(message As String)
        MyBase.New(message)
    End Sub
End Class

Public Class SaveMetadataException
    Inherits Exception

    Public Sub New(message As String)
        MyBase.New(message)
    End Sub
End Class