Public Class Form2

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddHandler Button1.Click, AddressOf MyClickHandler
        AddHandler Button2.Click, AddressOf MyClickHandler
        AddHandler Button3.Click, AddressOf MyClickHandler
        AddHandler Button4.Click, AddressOf MyClickHandler

    End Sub

    Private Sub MyClickHandler(sender As Object, e As EventArgs)

        Select Case CType(sender, Button).Name
            Case "Button1"
                score += 1
                Me.Hide()
                Form3.Show()

            Case "Button2"
                score = 0
                Me.Hide()
                Form3.Show()

            Case "Button3"
                score = 0
                Me.Hide()
                Form3.Show()

            Case "Button4"
                score = 0
                Me.Hide()
                Form3.Show()

        End Select

    End Sub
End Class