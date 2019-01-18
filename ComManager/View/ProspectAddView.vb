Public Class ProspectAddView
    Private Sub ProspectAddView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXT_DATE.Text = Date.Now.ToShortDateString
        TXT_NAME.Text = ""
        TXT_INTERET.Text = ""
        TXT_OBSERVATION.Text = ""
        TXT_CONCLUSION.Text = ""
        Button1.Enabled = False
    End Sub

    Private Sub TXT_NAME_TextChanged(sender As Object, e As EventArgs) Handles TXT_NAME.TextChanged
        If TXT_NAME.Text = "" Then
            TXT_NAME.BackColor = Color.Red
            Button1.Enabled = False
        Else
            TXT_NAME.BackColor = Color.White
            If TXT_DATE.Text = "" Or TXT_NAME.Text = "" Or TXT_INTERET.Text = "" Or TXT_OBSERVATION.Text = "" Or TXT_CONCLUSION.Text = "" Then
                Button1.Enabled = False
            Else
                Button1.Enabled = True
            End If
        End If
    End Sub

    Private Sub TXT_INTERET_TextChanged(sender As Object, e As EventArgs) Handles TXT_INTERET.TextChanged
        If TXT_INTERET.Text = "" Then
            TXT_INTERET.BackColor = Color.Red
            Button1.Enabled = False
        Else
            TXT_INTERET.BackColor = Color.White
            If TXT_DATE.Text = "" Or TXT_NAME.Text = "" Or TXT_INTERET.Text = "" Or TXT_OBSERVATION.Text = "" Or TXT_CONCLUSION.Text = "" Then
                Button1.Enabled = False
            Else
                Button1.Enabled = True
            End If
        End If
    End Sub

    Private Sub TXT_OBSERVATION_TextChanged(sender As Object, e As EventArgs) Handles TXT_OBSERVATION.TextChanged
        If TXT_OBSERVATION.Text = "" Then
            TXT_OBSERVATION.BackColor = Color.Red
            Button1.Enabled = False
        Else
            TXT_OBSERVATION.BackColor = Color.White
            If TXT_DATE.Text = "" Or TXT_NAME.Text = "" Or TXT_INTERET.Text = "" Or TXT_OBSERVATION.Text = "" Or TXT_CONCLUSION.Text = "" Then
                Button1.Enabled = False
            Else
                Button1.Enabled = True
            End If
        End If
    End Sub

    Private Sub TXT_CONCLUSION_TextChanged(sender As Object, e As EventArgs) Handles TXT_CONCLUSION.TextChanged
        If TXT_CONCLUSION.Text = "" Then
            TXT_CONCLUSION.BackColor = Color.Red
            Button1.Enabled = False
        Else
            TXT_CONCLUSION.BackColor = Color.White
            If TXT_DATE.Text = "" Or TXT_NAME.Text = "" Or TXT_INTERET.Text = "" Or TXT_OBSERVATION.Text = "" Or TXT_CONCLUSION.Text = "" Then
                Button1.Enabled = False
            Else
                Button1.Enabled = True
            End If
        End If
    End Sub
End Class