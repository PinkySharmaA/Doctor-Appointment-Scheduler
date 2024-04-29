Imports System.Data.SqlClient
Imports System.Globalization

Public Class RescheduleForm
    Private appointmentID As Integer
    Private connectionString As String = "Data Source=DESKTOP-5HCEJKD\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"

    Public Sub New(ByVal apptID As Integer)
        InitializeComponent()
        appointmentID = apptID
    End Sub

    Private Sub RescheduleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Set the MinDate of the MonthCalendar to today's date
            MonthCalendar1.MinDate = Date.Today

            ' Set the MaxDate of the MonthCalendar to one week from today
            Dim oneWeekLater As Date = Date.Today.AddDays(7)
            MonthCalendar1.MaxDate = oneWeekLater

            ' Disable Saturdays and Sundays in the MonthCalendar
            Dim day As DayOfWeek
            For day = DayOfWeek.Saturday To DayOfWeek.Sunday
                MonthCalendar1.AddBoldedDate(GetNextWeekday(oneWeekLater, day))
            Next

            ' Retrieve and display the current appointment date
            Dim currentDate As Date = GetCurrentAppointmentDate()
            If currentDate <> DateTime.MinValue Then
                ' Check if currentDate is within the valid range
                If currentDate >= MonthCalendar1.MinDate AndAlso currentDate <= MonthCalendar1.MaxDate Then
                    MonthCalendar1.SelectionStart = currentDate
                    Label1.Text = $"Selected Date: {currentDate.ToShortDateString()}"
                Else
                    ' Handle the case where the current appointment date is outside the valid range
                    MessageBox.Show("Current appointment date is outside the valid range.")
                End If
            Else
                MessageBox.Show("Error retrieving current appointment date.")
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred during form load: " & ex.Message)
        End Try
    End Sub
    Private Function GetNextWeekday(startDate As Date, targetDay As DayOfWeek) As Date
        ' Find the next occurrence of the target day starting from the specified date
        Dim currentDay As DayOfWeek = startDate.DayOfWeek
        Dim daysToAdd As Integer = (targetDay - currentDay + 7) Mod 7
        Return startDate.AddDays(daysToAdd)
    End Function


    Private Function GetCurrentAppointmentDate() As Date
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT AppointmentDate FROM Appointments WHERE AppointmentID = @AppointmentID"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@AppointmentID", appointmentID)
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        Return Convert.ToDateTime(result)
                    Else
                        MessageBox.Show("Appointment not found.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving appointment date: " & ex.Message)
        End Try
        Return DateTime.MinValue
    End Function

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        ' Update the text of the label to show the selected date
        Label1.Text = $"Selected Date: {e.Start.ToShortDateString()}"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check if a date is selected
        If MonthCalendar1.SelectionStart = DateTime.MinValue Then
            MessageBox.Show("Please select a reschedule date.")
            Return
        End If

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Check if the selected date and time slot are available
                If IsTimeSlotAvailable(connection, MonthCalendar1.SelectionStart) Then
                    ' Proceed with rescheduling
                    Dim updateQuery As String = "UPDATE Appointments SET AppointmentDate = @RescheduleDate, IsRescheduled = @IsRescheduled WHERE AppointmentID = @AppointmentID"
                    Using command As New SqlCommand(updateQuery, connection)
                        ' Use the selected date from the MonthCalendar
                        command.Parameters.AddWithValue("@RescheduleDate", MonthCalendar1.SelectionStart)
                        command.Parameters.AddWithValue("@AppointmentID", appointmentID)
                        Dim isRescheduled As String = If(MonthCalendar1.SelectionStart <> DateTime.Today, "Yes", "No")
                        command.Parameters.AddWithValue("@IsRescheduled", isRescheduled)
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("Appointment has been successfully rescheduled.")
                        Else
                            MessageBox.Show("Failed to reschedule your appointment.")
                        End If
                    End Using
                Else
                    MessageBox.Show("The selected time slot is not available. Please choose another slot.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while attempting to reschedule appointment: " & ex.Message)
        End Try
        Me.Close()
    End Sub

    Private Function IsTimeSlotAvailable(connection As SqlConnection, selectedDate As Date) As Boolean
        ' Query to check if the selected time slot is available
        Dim query As String = "SELECT COUNT(*) FROM Appointments WHERE AppointmentDate = @SelectedDate AND AppointmentID <> @AppointmentID"
        Using command As New SqlCommand(query, connection)
            ' Use the selected date and appointment ID for checking availability
            command.Parameters.AddWithValue("@SelectedDate", selectedDate)
            command.Parameters.AddWithValue("@AppointmentID", appointmentID)
            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
            Return count = 0 ' Return true if no appointment exists for the selected date and time slot
        End Using
    End Function
End Class
