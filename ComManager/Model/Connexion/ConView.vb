Public Class ConView
    Private Sub ConView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub USER_TextChanged(sender As Object, e As EventArgs) Handles USER.TextChanged
        If USER.Text = "" Then
            USER.BackColor = Color.Red
            Button1.Enabled = False
        Else
            USER.BackColor = Color.White
            If USER.Text = "" Or PASSWORD.Text = "" Then
                Button1.Enabled = False
            Else
                Button1.Enabled = True
            End If
        End If
    End Sub

    Private Sub PASSWORD_TextChanged(sender As Object, e As EventArgs) Handles PASSWORD.TextChanged
        If PASSWORD.Text = "" Then
            PASSWORD.BackColor = Color.Red
            Button1.Enabled = False
        Else
            PASSWORD.BackColor = Color.White
            If USER.Text = "" Or PASSWORD.Text = "" Then
                Button1.Enabled = False
            Else
                Button1.Enabled = True
            End If
        End If
    End Sub
End Class