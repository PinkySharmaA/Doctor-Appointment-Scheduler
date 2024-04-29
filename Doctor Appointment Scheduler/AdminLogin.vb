Imports System.Data.SqlClient

Public Class AdminLogin
    Private connectionString As String = "Data Source=DESKTOP-5HCEJKD\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True;TrustServerCertificate=True"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter both username and password.")
            Return
        End If

        Dim query As String = "SELECT COUNT(*) FROM Admins WHERE Username = @Username AND Password = @Password"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)

                Try
                    connection.Open()
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                    If count > 0 Then
                        MessageBox.Show("Login successful!")

                        ' Open the admin dashboard form
                        Dim adminDashboardForm As New AdminDashboardForm()
                        adminDashboardForm.Show()
                    Else
                        MessageBox.Show("Invalid username or password. Please try again.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("An error occurred while attempting to log in: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub
End Class
