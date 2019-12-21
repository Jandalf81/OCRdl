﻿Public Class Settings
    Private _downloadTo As String
    Private _lastSuccess As Integer
    Private _downloadFrom As String

    Public Property DownloadTo As String
        Get
            Return _downloadTo
        End Get
        Set(value As String)
            _downloadTo = value
        End Set
    End Property
    Public Property LastSuccess As Integer
        Get
            Return _lastSuccess
        End Get
        Set(value As Integer)
            _lastSuccess = value
        End Set
    End Property
    Public Property DownloadFrom As String
        Get
            Return _downloadFrom
        End Get
        Set(value As String)
            _downloadFrom = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub Save()
        Dim x As New Xml.Serialization.XmlSerializer(Me.GetType)
        Dim fileWriter As IO.StreamWriter

        fileWriter = My.Computer.FileSystem.OpenTextFileWriter(My.Application.Info.DirectoryPath + "\settings.xml", False)
        x.Serialize(fileWriter, Me)
        fileWriter.Close()
    End Sub

    Public Sub Load()
        Dim ISettings As New Settings()
        Dim x As New Xml.Serialization.XmlSerializer(Me.GetType)

        If (My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\settings.xml")) Then
            Using fs As New IO.FileStream(My.Application.Info.DirectoryPath + "\settings.xml", IO.FileMode.Open)
                ISettings = x.Deserialize(fs)
            End Using
        End If

        Me.DownloadTo = ISettings.DownloadTo
        Me.LastSuccess = ISettings.LastSuccess
        Me.DownloadFrom = ISettings.DownloadFrom
    End Sub
End Class