Imports System.Data.SqlClient

Public Class FeedbackForm
    ' SQL connection string
    Private connectionString As String = "Data Source=DESKTOP-5HCEJKD\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Get feedback details from the form
        Dim feedbackText As String = TextBox1.Text
        Dim rating As Integer = CInt(NumericUpDown1.Value) ' Assuming the rating is provided through a NumericUpDown control
        Dim appointmentID As Integer = GetLastAppointmentID()

        ' Insert the feedback into the database
        Dim query As String = "INSERT INTO Feedback (AppointmentID, FeedbackText, Rating) VALUES (@AppointmentID, @FeedbackText, @Rating)"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Add parameters to prevent SQL injection
                command.Parameters.AddWithValue("@AppointmentID", appointmentID)
                command.Parameters.AddWithValue("@FeedbackText", feedbackText)
                command.Parameters.AddWithValue("@Rating", rating)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Thank you for your feedback!")
                Catch ex As Exception
                    MessageBox.Show("An error occurred while saving the feedback: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    ' Function to retrieve the last appointment ID
    Private Function GetLastAppointmentID() As Integer
        Dim lastAppointmentID As Integer = -1
        ' Query to retrieve the last appointment ID from the database
        Dim query As String = "SELECT MAX(AppointmentID) FROM Appointments"
        Using connection As New SqlConnection("Data Source=DESKTOP-5HCEJKD\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True;Encrypt=True;TrustServerCertificate=True")
            Using command As New SqlCommand(query, connection)
                Try
                    connection.Open()
                    Dim result = command.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        lastAppointmentID = Convert.ToInt32(result)
                    End If
                Catch ex As Exception
                    MessageBox.Show("An error occurred while retrieving the last appointment ID: " & ex.Message)
                End Try
            End Using
        End Using
        Return lastAppointmentID
    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Retrieve the last appointment ID
        Dim lastAppointmentID As Integer = GetLastAppointmentID()

        ' Create an instance of the BillReceiptForm with the last appointment ID as argument
        Dim billReceiptForm As New BillReceiptForm(lastAppointmentID)

        ' Show the form
        billReceiptForm.Show()
    End Sub

End Class



