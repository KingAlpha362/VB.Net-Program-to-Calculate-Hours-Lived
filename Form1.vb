Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim age As Integer
        Dim ans As Double

        age = TextBox1.Text

        ans = age * 365 * 24

        MessageBox.Show("You've been alive for " & ans & " hours! ")
    End Sub
End Class
