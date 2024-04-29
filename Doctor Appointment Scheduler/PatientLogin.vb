Imports System.Data.SqlClient

Public Class PatientLogin
    Private connectionString As String = "Data Source=DESKTOP-5HCEJKD\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True"

    Private Function GetLoggedInPatientID() As Integer
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        ' Check if username and password are provided
        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter both username and password.")
            Return -1
        End If

        ' Query to retrieve the patient ID based on the username and password from the registration table
        Dim query As String = "SELECT PatientID FROM Patient WHERE Username = @Username AND Password = @Password"

        ' Using statement ensures the connection is closed after use
        Using connection As New SqlConnection("Data Source=DESKTOP-5HCEJKD\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True;TrustServerCertificate=True")
            Using command As New SqlCommand(query, connection)
                ' Add parameters to prevent SQL injection
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)

                Try
                    connection.Open()
                    Dim result As Object = command.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        ' Return the retrieved patient ID
                        Return Convert.ToInt32(result)
                    Else
                        MessageBox.Show("Invalid username or password. Please try again.")
                        Return -1
                    End If
                Catch ex As Exception
                    ' Handle any errors that may occur during database interaction
                    MessageBox.Show("An error occurred while retrieving the patient ID: " & ex.Message)
                    Return -1
                End Try
            End Using
        End Using
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        ' Check if username and password are provided
        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter both username and password.")
            Return
        End If

        ' Query to check if the username and password match
        Dim query As String = "SELECT COUNT(*) FROM Patient WHERE username = @Username AND password = @Password"

        ' Using statement ensures the connection is closed after use
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Add parameters to prevent SQL injection
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)

                Try
                    connection.Open()
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                    ' If there is a record with provided username and password
                    If count > 0 Then
                        ' Successful login
                        MessageBox.Show("Login successful!")
                        DoctorAppointmentForm.Show()
                    Else
                        ' Invalid credentials
                        MessageBox.Show("Invalid username or password. Please try again.")
                    End If
                Catch ex As Exception
                    ' Handle any errors that may occur during database interaction
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Retrieve the patient ID after successful login
        Dim patientID As Integer = GetLoggedInPatientID()

        ' Check if the patient ID is valid
        If patientID <> -1 Then
            ' Open the ViewAppointmentsForm and pass the patient ID
            Dim viewAppointmentsForm As New ViewAppointmentsForm(patientID)
            viewAppointmentsForm.Show()
        Else
            MessageBox.Show("Error retrieving patient ID.")
        End If
    End Sub

    Private Sub TestDatabaseConnection()
        Dim connection As New SqlConnection(connectionString)
        Try
            connection.Open()
            MessageBox.Show("Connection successful!")
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub PatientLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Call the method to test the database connection when the form loads
        TestDatabaseConnection()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Retrieve the patient ID after successful login
        Dim patientID As Integer = GetLoggedInPatientID()

        ' Check if the patient ID is valid
        If patientID <> -1 Then
            ' Open the RescheduleForm and pass the patient ID
            Dim rescheduleForm As New RescheduleForm(patientID)
            rescheduleForm.Show()
        Else
            MessageBox.Show("Error retrieving patient ID.")
        End If
    End Sub

End Class

