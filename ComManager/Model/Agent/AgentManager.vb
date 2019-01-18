Imports MySql.Data.MySqlClient

Public Class AgentManager
    Private mConnexion As MySqlConnection
    Private mCmd As MySqlCommand
    Private mQuery As String
    Private mReader As MySqlDataReader

    Sub New(connexion As MySqlConnection)
        mConnexion = connexion
    End Sub


End Class
