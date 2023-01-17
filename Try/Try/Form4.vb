Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If score = "3" Then
            Label1.Text = "Congratulations!! Your score is " & score & " out of 3"
        Else
            Label1.Text = "Your score is " & score & " out of 3"
        End If
    End Sub
End Class