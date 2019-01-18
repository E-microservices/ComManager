Public Class Publish
    Private mId As Integer
    Private mDate As String
    Private mName As String
    Private mLink As String
    Private mMember As String

    Sub New()

    End Sub
    Sub New(ate As String, name As String, link As String, member As String)
        mDate = ate
        mName = name
        mLink = link
        mMember = member
    End Sub
    Sub New(id As Integer, ate As String, name As String, link As String, member As String)
        mId = id
        mDate = ate
        mName = name
        mLink = link
        mMember = member
    End Sub

    Private Sub setId(id As Integer)
        mId = id
    End Sub
    Public Sub setDate(value As String)
        mDate = value
    End Sub
    Public Sub setName(value As String)
        mName = value
    End Sub
    Public Sub setLink(value As String)
        mLink = value
    End Sub

    Public Sub setMember(value As String)
        mMember = value
    End Sub

    Public Function getId() As Integer
        Return mId
    End Function
    Public Function getDate() As String
        Return mDate
    End Function
    Public Function getName() As String
        Return mName
    End Function
    Public Function getLink() As String
        Return mLink
    End Function

    Public Function getMember() As String
        Return mMember
    End Function
End Class
