Public Class Agent
    Private mName As String
    Private mResponsbility As String

    Sub New()

    End Sub
    Sub New(name As String, responsbility As String)
        mName = name
        mResponsbility = responsbility
    End Sub

    Public Sub setName(name As String)
        mName = name
    End Sub
    Public Sub setResponsbility(responsbility As String)
        mResponsbility = responsbility
    End Sub

    Public Function getName() As String
        Return mName
    End Function
    Public Function getResponsbility() As String
        Return mResponsbility
    End Function
End Class
