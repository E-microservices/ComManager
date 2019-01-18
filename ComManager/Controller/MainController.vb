Public Class MainController
    Dim agent As Agent
    Dim mProspect As Prospect
    Dim mProManager As ProspectManager
    Dim mPublisher As Publish
    Dim mPubManager As PablishManager
    Dim connexion As Connexion
    Private Sub MainController_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'FichierToolStripMenuItem.Enabled = False
        ActualiserToolStripMenuItem.Enabled = False
        AjoutePToolStripMenuItem.Enabled = False
        AjouterPrToolStripMenuItem.Enabled = False
    End Sub
    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        If MsgBox("Etre vous sûr de vouloir fermé le programme ?", MsgBoxStyle.YesNo, "") = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub AjoutePToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjoutePToolStripMenuItem.Click
        PublishAddView.ShowDialog()
        If PublishAddView.DialogResult = DialogResult.Cancel Then
            Exit Sub
        End If
        mPublisher = New Publish(PublishAddView.TXT_DATE.Text, PublishAddView.TXT_GROUP_NAME.Text, PublishAddView.TXT_LINK.Text, PublishAddView.TXT_NUMBER_OF_MEMBER.Text)
        mPubManager.AddPublisher(mPublisher, agent.getName)
        displayPublisherData(mPubManager.getAllPublished(agent.getName))

    End Sub

    Private Sub AjouterPrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterPrToolStripMenuItem.Click
        ProspectAddView.ShowDialog()
        If ProspectAddView.DialogResult = DialogResult.Cancel Then
            Exit Sub
        End If
        mProspect = New Prospect(ProspectAddView.TXT_DATE.Text, ProspectAddView.TXT_NAME.Text, ProspectAddView.TXT_INTERET.Text, ProspectAddView.TXT_OBSERVATION.Text, ProspectAddView.TXT_CONCLUSION.Text)
        mProManager.AddProspect(mProspect, agent.getName)
        displayProspectData(mProManager.getAllProspect(agent.getName))
    End Sub

    Private Sub ConnexionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnexionToolStripMenuItem.Click
        If ConnexionToolStripMenuItem.Text = "Connexion" Then
            If ConView.ShowDialog = DialogResult.Cancel Then
                Exit Sub
            End If
            Try
                agent = New Agent
                connexion = New Connexion(ConView.USER.Text, ConView.PASSWORD.Text, "")
                If connexion.establishConnexion() Then
                    Exit Sub
                End If
                agent.setName(ConView.USER.Text)
                mProManager = New ProspectManager(connexion.getConnexion)
                mPubManager = New PablishManager(connexion.getConnexion)
                displayPublisherData(mPubManager.getAllPublished(agent.getName))
                displayProspectData(mProManager.getAllProspect(agent.getName))
                ETAT_CONNEXION.ForeColor = Color.Green
                ETAT_CONNEXION.Text = "Connecter"
                ConnexionToolStripMenuItem.Text = "Déconnexion"
                ActualiserToolStripMenuItem.Enabled = True
                AjoutePToolStripMenuItem.Enabled = True
                AjouterPrToolStripMenuItem.Enabled = True
            Catch ex As Exception
                MsgBox("Erreur: " & ex.ToString)
            End Try
        Else
            Try
                If MsgBox("Voulez vous deconnecter le système ?", MsgBoxStyle.YesNo, "Déconnexion") = MsgBoxResult.No Then
                    Exit Sub
                End If
                connexion.closeConnexion()
                ConnexionToolStripMenuItem.Text = "Connexion"
                ActualiserToolStripMenuItem.Enabled = False
                AjoutePToolStripMenuItem.Enabled = False
                AjouterPrToolStripMenuItem.Enabled = False
                Prospect.Rows.Clear()
                Publisher.Rows.Clear()
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub ActualiserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualiserToolStripMenuItem.Click
        displayPublisherData(mPubManager.getAllPublished(agent.getName))
        displayProspectData(mProManager.getAllProspect(agent.getName))
    End Sub

    Private Sub Prospect_CellValueChange(sender As Object, e As DataGridViewCellEventArgs) Handles Prospect.CellValueChanged
        Try
            mProManager.updateProProspectDataValue()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Publisher_CellValueChange(sender As Object, e As DataGridViewCellEventArgs) Handles Publisher.CellValueChanged
        Try
            mPubManager.updatePublisherDataValue()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FichierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FichierToolStripMenuItem.Click

    End Sub
End Class
