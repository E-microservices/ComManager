Imports MySql.Data.MySqlClient

Public Class PablishManager
    Private mConnexion As MySqlConnection
    Private mCmd As MySqlCommand
    Private mQuery As String
    Private mReader As MySqlDataReader

    Sub New(connexion As MySqlConnection)
        mConnexion = connexion
    End Sub

    Public Sub AddPublisher(publish As Publish, agent As String)
        mQuery = "INSERT INTO publication(date_pu, name_pu, link, member, agent ) VALUE(@val1, @val2, @val3, @val4, @val5)"
        mCmd = New MySqlCommand(mQuery, mConnexion)
        Try
            mCmd.Parameters.AddWithValue("@val1", publish.getDate)
            mCmd.Parameters.AddWithValue("@val2", publish.getName)
            mCmd.Parameters.AddWithValue("@val3", publish.getLink)
            mCmd.Parameters.AddWithValue("@val4", publish.getMember)
            mCmd.Parameters.AddWithValue("@val5", agent)

            mCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Erreur de l'execution du code: " & ex.ToString)
        Finally
            eraseMemory()
        End Try
    End Sub
    Public Function getAllPublished(agent As String) As List(Of Publish)
        Dim listOfPublish As List(Of Publish)
        listOfPublish = New List(Of Publish)
        mQuery = "SELECT * FROM publication WHERE agent = @val1"
        Try
            mCmd = New MySqlCommand(mQuery, mConnexion)
            mCmd.Parameters.AddWithValue("@val1", agent)
            mReader = mCmd.ExecuteReader
            While mReader.Read
                listOfPublish.Add(New Publish(mReader.GetString("id"), mReader.GetString("date_pu"), mReader.GetString("name_pu"), mReader.GetString("link"), mReader.GetString("member")))
            End While
        Catch ex As Exception
            MsgBox("Erreur d'execution du code: " & ex.ToString)
        Finally
            eraseMemory()
        End Try
        Return listOfPublish
    End Function

    Public Sub updatePublisherDataValue()
        Dim id As Integer
        Dim name As String
        Dim link As String
        Dim memberN As String
        name = MainController.Publisher.CurrentRow.Cells().Item(2).Value
        link = MainController.Publisher.CurrentRow.Cells().Item(3).Value
        memberN = MainController.Publisher.CurrentRow.Cells().Item(4).Value

        id = CInt(MainController.Publisher.CurrentRow.Cells().Item(0).Value)

        mQuery = "UPDATE publication SET name_pu = @val1, link = @val2, member = @val3 WHERE id = @val4"
        mCmd = New MySqlCommand(mQuery, mConnexion)
        Try
            mCmd.Parameters.AddWithValue("@val1", name)
            mCmd.Parameters.AddWithValue("@val2", link)
            mCmd.Parameters.AddWithValue("@val3", memberN)
            mCmd.Parameters.AddWithValue("@val4", id)

            mCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Erreur d'execution de la commande. Source de l'erreur: " & ex.ToString)
        Finally
            eraseMemory()
        End Try
    End Sub
    Private Sub eraseMemory()
        If mReader IsNot Nothing Then
            mReader.Dispose()
            mReader.Close()
        End If
        If mCmd IsNot Nothing Then
            mCmd.Dispose()
        End If
    End Sub
End Class
