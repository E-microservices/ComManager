Module DataGrigModule
    Public Sub displayProspectData(lisObjext As List(Of Prospect))
        MainController.Prospect.Rows.Clear()
        For Each pros As Prospect In lisObjext
            MainController.Prospect.Rows.Add(pros.getId, pros.getDate, pros.getName, pros.getInterest, pros.getObservation, pros.getConclusion)
        Next
    End Sub
    Public Sub displayPublisherData(lisObjext As List(Of Publish))
        MainController.Publisher.Rows.Clear()
        For Each pros As Publish In lisObjext
            MainController.Publisher.Rows.Add(pros.getId, pros.getDate, pros.getName, pros.getLink, pros.getMember)
        Next
    End Sub
End Module
