Public Class Prospect
    Private mId As Integer
    Private mDate As String
    Private mName As String
    Private mInterest As String
    Private mObserv As String
    Private mConclusion As String

    Sub New()

    End Sub
    Sub New(iDate As String, name As String, interest As String, observ As String, conclusion As String)
        mDate = iDate
        mName = name
        mInterest = interest
        mObserv = observ
        mConclusion = conclusion
    End Sub
    Sub New(id As Integer, iDate As String, name As String, interest As String, observ As String, conclusion As String)
        mId = id
        mDate = iDate
        mName = name
        mInterest = interest
        mObserv = observ
        mConclusion = conclusion
    End Sub

    Private Sub setId(id As Integer)
        mId = id
    End Sub
    Public Sub setDate(idtae As Date)
        mDate = idtae.ToShortDateString
    End Sub
    Public Sub setName(name As String)
        mName = name
    End Sub
    Public Sub setInterest(interest As String)
        mInterest = interest
    End Sub
    Public Sub setObservation(observ As String)
        mObserv = observ
    End Sub
    Public Sub setConclusion(con As String)
        mConclusion = con
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
    Public Function getInterest() As String
        Return mInterest
    End Function
    Public Function getObservation() As String
        Return mObserv
    End Function
    Public Function getConclusion() As String
        Return mConclusion
    End Function

End Class
