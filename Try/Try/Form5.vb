Public Class Form5
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddHandler Button1.Click, AddressOf MyClickHandler
        AddHandler Button2.Click, AddressOf MyClickHandler
        AddHandler Button3.Click, AddressOf MyClickHandler
        AddHandler Button4.Click, AddressOf MyClickHandler

    End Sub

    Private Sub MyClickHandler(sender As Object, e As EventArgs)

        Select Case CType(sender, Button).Name
            Case "Button1"
                Me.Hide()
                Form4.Show()

            Case "Button2"
                Me.Hide()
                Form4.Show()

            Case "Button3"
                Me.Hide()
                Form4.Show()

            Case "Button4"
                score += 1
                Me.Hide()
                Form4.Show()

        End Select
    End Sub
End Class