Public Class PublishAddView
    Private Sub PublishAddView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXT_DATE.Text = Date.Now.ToShortDateString
        TXT_GROUP_NAME.Text = ""
        TXT_LINK.Text = ""
        TXT_NUMBER_OF_MEMBER.Text = ""
        Button1.Enabled = False
    End Sub

    Private Sub TXT_GROUP_NAME_TextChanged(sender As Object, e As EventArgs) Handles TXT_GROUP_NAME.TextChanged
        If TXT_GROUP_NAME.Text = "" Then
            TXT_GROUP_NAME.BackColor = Color.Red
            Button1.Enabled = False
        Else
            TXT_GROUP_NAME.BackColor = Color.White
            If TXT_GROUP_NAME.Text = "" Or TXT_LINK.Text = "" Or TXT_NUMBER_OF_MEMBER.Text = "" Then
                Button1.Enabled = False
            Else
                Button1.Enabled = True
            End If
        End If
    End Sub

    Private Sub TXT_LINK_TextChanged(sender As Object, e As EventArgs) Handles TXT_LINK.TextChanged
        If TXT_LINK.Text = "" Then
            TXT_LINK.BackColor = Color.Red
            Button1.Enabled = False
        Else
            TXT_LINK.BackColor = Color.White
            If TXT_GROUP_NAME.Text = "" Or TXT_LINK.Text = "" Or TXT_NUMBER_OF_MEMBER.Text = "" Then
                Button1.Enabled = False
            Else
                Button1.Enabled = True
            End If
        End If
    End Sub

    Private Sub TXT_NUMBER_OF_MEMBER_TextChanged(sender As Object, e As EventArgs) Handles TXT_NUMBER_OF_MEMBER.TextChanged
        If TXT_NUMBER_OF_MEMBER.Text = "" Then
            TXT_NUMBER_OF_MEMBER.BackColor = Color.Red
            Button1.Enabled = False
        Else
            TXT_NUMBER_OF_MEMBER.BackColor = Color.White
            If TXT_GROUP_NAME.Text = "" Or TXT_LINK.Text = "" Or TXT_NUMBER_OF_MEMBER.Text = "" Then
                Button1.Enabled = False
            Else
                Button1.Enabled = True
            End If
        End If
    End Sub
End Class