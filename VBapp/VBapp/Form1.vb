Public Class Register
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        If txtUsername.Text <> "" Then
            a = a + 1
        End If

        If txtPassword.Text <> "" Then
            a = a + 1
        End If

        If a = 2 Then
            My.Settings.Username = Me.txtUsername.Text
            My.Settings.Password = Me.txtPassword.Text
            My.Settings.Save()

            MessageBox.Show("Username and Password has been saved successfuly.")
        Else
            MessageBox.Show("Username or Password is not entered!")
        End If


    End Sub
End Class
