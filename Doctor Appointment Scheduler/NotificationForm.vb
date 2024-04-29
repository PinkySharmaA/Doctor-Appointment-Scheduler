Imports System.Data.SqlClient

Public Class NotificationForm
    Private connectionString As String = "Data Source=DESKTOP-5HCEJKD\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"

    Private Sub NotificationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAppointmentDetails()
    End Sub

    Private Sub LoadAppointmentDetails()
        Dim query As String = "SELECT A.AppointmentID, A.PatientName, A.AppointmentDate, A.AppointmentTime, " &
                              "Payment.AmountPaid, " &
                              "Feedback.FeedbackText, " &
                              "CASE WHEN A.IsRescheduled = 'Yes' THEN 'Yes' ELSE 'No' END AS IsRescheduled, " & ' Update IsRescheduled column based on the value in the database
                              "CASE WHEN A.IsCancelled = 1 THEN 'Yes' ELSE 'No' END AS IsCancelled " & ' Update IsCancelled column based on the value in the database
                              "FROM Appointments A " &
                              "LEFT JOIN Payments Payment ON A.AppointmentID = Payment.AppointmentID " &
                              "LEFT JOIN Feedback ON A.AppointmentID = Feedback.AppointmentID"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                Try
                    connection.Open()
                    Dim reader As SqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        ' Clear existing rows and columns
                        DataGridView1.Rows.Clear()
                        DataGridView1.Columns.Clear()

                        ' Add columns to the DataGridView
                        DataGridView1.Columns.Add("AppointmentID", "Appointment ID")
                        DataGridView1.Columns.Add("PatientName", "Patient Name")
                        DataGridView1.Columns.Add("AppointmentDate", "Appointment Date")
                        DataGridView1.Columns.Add("AppointmentTime", "Appointment Time")
                        DataGridView1.Columns.Add("AmountPaid", "Amount Paid")
                        DataGridView1.Columns.Add("FeedbackText", "Feedback")
                        DataGridView1.Columns.Add("IsRescheduled", "Rescheduled")
                        DataGridView1.Columns.Add("IsCancelled", "Cancelled")

                        While reader.Read()
                            Dim appointmentID As Integer = reader.GetInt32(0)
                            Dim patientName As String = reader.GetString(1)
                            Dim appointmentDate As Date = reader.GetDateTime(2)
                            Dim appointmentTime As String = reader.GetString(3)
                            Dim amountPaid As Decimal = If(Not reader.IsDBNull(4), reader.GetDecimal(4), 0)
                            Dim feedbackText As String = If(Not reader.IsDBNull(5), reader.GetString(5), "")
                            Dim isRescheduled As String = reader.GetString(6)
                            Dim isCancelled As String = reader.GetString(7)

                            ' Add the data to the DataGridView
                            Dim row As DataGridViewRow = DataGridView1.Rows(DataGridView1.Rows.Add(appointmentID, patientName, appointmentDate, appointmentTime, amountPaid, feedbackText, isRescheduled, isCancelled))
                        End While
                    Else
                        MessageBox.Show("No appointment information found.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("An error occurred while loading appointment details: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check if any row is selected
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Iterate through selected rows and remove them from the data source
            For Each selectedRow As DataGridViewRow In DataGridView1.SelectedRows
                DataGridView1.Rows.Remove(selectedRow)
            Next
            ' Optionally, update your database here to reflect the deletion
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

End Class


