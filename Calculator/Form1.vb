Public Class Form1
    Private Sub Plus_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Display.Text = Display.Text & "+"
    End Sub

    Private Sub Minus_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Display.Text = Display.Text & "-"
    End Sub

    Private Sub Multiply_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Display.Text = Display.Text & "*"
    End Sub

    Private Sub Division_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Display.Text = Display.Text & "/"
    End Sub

    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Equals.Click
        Dim expr As String
        expr = Display.Text

        Dim result As Double
        Try
            result = Convert.ToDouble(New DataTable().Compute(expr, Nothing))
            Display.Text = result.ToString()
        Catch ex As Exception
            MessageBox.Show("Invalid expression!")
        End Try
    End Sub

    Private Sub one_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Display.Text = Display.Text & "1"
    End Sub

    Private Sub two_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Display.Text = Display.Text & "2"
    End Sub

    Private Sub three_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Display.Text = Display.Text & "3"
    End Sub

    Private Sub four_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Display.Text = Display.Text & "4"
    End Sub

    Private Sub five_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Display.Text = Display.Text & "5"
    End Sub

    Private Sub six_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Display.Text = Display.Text & "6"
    End Sub

    Private Sub seven_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Display.Text = Display.Text & "7"
    End Sub

    Private Sub eight_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Display.Text = Display.Text & "8"
    End Sub

    Private Sub nine_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Display.Text = Display.Text & "9"
    End Sub

    Private Sub dot_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Display.Text = Display.Text & "."
    End Sub

    Private Sub zero_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Display.Text = Display.Text & "0"
    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Display.Text = ""
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If Display.Text.Length > 0 Then
            Display.Text = Display.Text.Substring(0, Display.Text.Length - 1)
        End If
    End Sub
End Class
