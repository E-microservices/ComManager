Imports MySql.Data.MySqlClient

Public Class ProspectManager
    Private mConnexion As MySqlConnection
    Private mReader As MySqlDataReader
    Private mCmd As MySqlCommand
    Private mQuery As String

    Sub New(connexion As MySqlConnection)
        mConnexion = connexion
    End Sub

    Public Sub AddProspect(prospect As Prospect, agent As String)
        mQuery = "INSERT INTO prospect(date_pr, nom, interet, observation, conclusion, agent) VALUE(@val1, @val2, @val3, @val4, @val5, @val6)"
        mCmd = New MySqlCommand(mQuery, mConnexion)
        Try
            mCmd.Parameters.AddWithValue("@val1", prospect.getDate)
            mCmd.Parameters.AddWithValue("@val2", prospect.getName)
            mCmd.Parameters.AddWithValue("@val3", prospect.getInterest)
            mCmd.Parameters.AddWithValue("@val4", prospect.getObservation)
            mCmd.Parameters.AddWithValue("@val5", prospect.getConclusion)
            mCmd.Parameters.AddWithValue("@val6", agent)

            mCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Erreur d'insersion dans BDD: " & ex.ToString)
        Finally
            eraseMemory()
        End Try
    End Sub
    Public Function getAllProspect(agent As String) As List(Of Prospect)
        Dim listOfP As List(Of Prospect)
        listOfP = New List(Of Prospect)
        mQuery = "SELECT * FROM prospect WHERE agent = @val1"

        Try
            mCmd = New MySqlCommand(mQuery, mConnexion)
            mCmd.Parameters.AddWithValue("@val1", agent)
            mReader = mCmd.ExecuteReader
            While mReader.Read
                listOfP.Add(New Prospect(mReader.GetString("id"), mReader.GetString("date_pr"), mReader.GetString("nom"), mReader.GetString("interet"), mReader.GetString("observation"), mReader.GetString("conclusion")))
            End While
        Catch ex As Exception
            MsgBox("Erreur d'execution du programme")
        Finally
            eraseMemory()
        End Try
        Return listOfP
    End Function

    Public Sub updateProProspectDataValue()
        Dim id As Integer
        Dim name As String
        Dim interet As String
        Dim observation As String
        Dim conclusion As String
        name = MainController.Prospect.CurrentRow.Cells().Item(2).Value
        interet = MainController.Prospect.CurrentRow.Cells().Item(3).Value
        observation = MainController.Prospect.CurrentRow.Cells().Item(4).Value
        conclusion = MainController.Prospect.CurrentRow.Cells().Item(5).Value

        id = CInt(MainController.Prospect.CurrentRow.Cells().Item(0).Value)

        mQuery = "UPDATE prospect SET nom = @val1, interet = @val2, observation = @val3, conclusion = @val4 WHERE id = @val5"
        mCmd = New MySqlCommand(mQuery, mConnexion)
        Try
            mCmd.Parameters.AddWithValue("@val1", name)
            mCmd.Parameters.AddWithValue("@val2", interet)
            mCmd.Parameters.AddWithValue("@val3", observation)
            mCmd.Parameters.AddWithValue("@val4", conclusion)
            mCmd.Parameters.AddWithValue("@val5", id)

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
