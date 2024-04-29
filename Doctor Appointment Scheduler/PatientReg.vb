Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class PatientReg
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-5HCEJKD\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True;TrustServerCertificate=True")
                con.Open()
                Dim query As String = "INSERT INTO [dbo].[Patient] ([fname], [lname], [gender], [phone], [username], [password]) VALUES (@fname, @lname, @gender, @phone, @username, @password)"

                Using cmd As SqlCommand = New SqlCommand(query, con)
                    ' Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@fname", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@lname", TextBox2.Text)
                    ' Determine the selected gender
                    Dim gender As String = ""
                    If RadioButton1.Checked Then
                        gender = "Male"
                    ElseIf RadioButton2.Checked Then
                        gender = "Female"
                    End If
                    cmd.Parameters.AddWithValue("@gender", gender)
                    cmd.Parameters.AddWithValue("@phone", TextBox4.Text)
                    cmd.Parameters.AddWithValue("@username", TextBox5.Text)
                    cmd.Parameters.AddWithValue("@password", TextBox6.Text)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("You have registered successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            PatientLogin.Show()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox6.UseSystemPasswordChar = False
        Else
            TextBox6.UseSystemPasswordChar = True
        End If
    End Sub
End Class

