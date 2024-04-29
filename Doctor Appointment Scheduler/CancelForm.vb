Imports System.Data.SqlClient

Public Class CancelForm
    Private appointmentID As Integer
    Private connectionString As String = "Data Source=DESKTOP-5HCEJKD\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"

    Public Sub New(ByVal apptID As Integer)
        InitializeComponent()
        appointmentID = apptID
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Implement cancellation logic here
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                ' Perform cancellation update in the database
                Dim cancelQuery As String = "UPDATE Appointments SET IsCancelled = 1 WHERE AppointmentID = @AppointmentID"
                Using command As New SqlCommand(cancelQuery, connection)
                    ' Pass parameters
                    command.Parameters.AddWithValue("@AppointmentID", appointmentID)
                    ' Execute the command
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Appointment has been successfully cancelled.")
                    Else
                        MessageBox.Show("Failed to cancel appointment.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while attempting to cancel appointment: " & ex.Message)
        End Try
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class

