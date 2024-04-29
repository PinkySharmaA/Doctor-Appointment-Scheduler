Imports System.Data.SqlClient

Public Class DoctorAppointmentForm
    ' Declare a global variable to store the appointmentID
    Private Shared appointmentID As Integer

    ' SQL connection string
    Private connectionString As String = "Data Source=DESKTOP-5HCEJKD\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check if patient information and consultation details are provided
        If String.IsNullOrWhiteSpace(TextBox1.Text) OrElse String.IsNullOrWhiteSpace(TextBox2.Text) OrElse ComboBox1.SelectedItem Is Nothing OrElse ComboBox2.SelectedItem Is Nothing OrElse MonthCalendar1.SelectionStart = DateTime.MinValue OrElse ComboBox3.SelectedItem Is Nothing Then
            MessageBox.Show("Please fill in all the fields.")
            Return
        End If

        ' Get patient information and consultation details from the form
        Dim patientName As String = TextBox1.Text
        Dim contactNumber As String = TextBox2.Text
        Dim consultationType As String = ComboBox1.SelectedItem.ToString()
        Dim urgency As String = ComboBox2.SelectedItem.ToString()

        ' Get selected date and time for the appointment
        Dim selectedDate As Date = MonthCalendar1.SelectionStart.Date
        Dim selectedTime As String = ComboBox3.SelectedItem.ToString()

        ' Check if the selected time slot is available
        If Not IsTimeSlotAvailable(selectedDate, selectedTime) Then
            MessageBox.Show("The selected time slot is not available. Please choose another time.")
            Return
        End If

        ' Insert the details into the database
        Dim query As String = "INSERT INTO Appointments (PatientName, ContactNumber, ConsultationType, Urgency, AppointmentDate, AppointmentTime) VALUES (@PatientName, @ContactNumber, @ConsultationType, @Urgency, @AppointmentDate, @AppointmentTime)"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Add parameters to prevent SQL injection
                command.Parameters.AddWithValue("@PatientName", patientName)
                command.Parameters.AddWithValue("@ContactNumber", contactNumber)
                command.Parameters.AddWithValue("@ConsultationType", consultationType)
                command.Parameters.AddWithValue("@Urgency", urgency)
                command.Parameters.AddWithValue("@AppointmentDate", selectedDate)
                command.Parameters.AddWithValue("@AppointmentTime", selectedTime)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Appointment scheduled successfully.")

                    ' Retrieve the last inserted appointment ID
                    appointmentID = GetLastAppointmentID(connection)
                    ' Create an instance of PaymentForm and pass the appointment ID
                    Dim paymentForm As New PaymentForm(appointmentID)
                    paymentForm.Show()

                Catch ex As Exception
                    MessageBox.Show("An error occurred while scheduling the appointment: " & ex.Message)
                End Try

            End Using
        End Using
    End Sub

    Private Function IsTimeSlotAvailable(appointmentDate As Date, appointmentTime As String) As Boolean
        ' Check if the selected date is within the booking range
        Dim currentDate As Date = Date.Today
        Dim oneWeekLater As Date = currentDate.AddDays(7)

        If appointmentDate < currentDate OrElse appointmentDate >= oneWeekLater Then
            MessageBox.Show("Appointments can only be scheduled for the current week.")
            Return False
        End If

        ' Check if the selected date is a valid booking day
        If Not IsValidBookingDay(appointmentDate) Then
            MessageBox.Show("Appointments cannot be scheduled on this day.")
            Return False
        End If

        ' Check if the selected time slot is available
        Dim query As String = "SELECT COUNT(*) FROM Appointments WHERE AppointmentDate = @AppointmentDate AND AppointmentTime = @AppointmentTime"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@AppointmentDate", appointmentDate)
                command.Parameters.AddWithValue("@AppointmentTime", appointmentTime)

                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count = 0 ' Return true if no appointments exist for the selected time slot
            End Using
        End Using
    End Function


    Private Function IsValidBookingDay(appointmentDate As Date) As Boolean
        ' Check if the selected date is a valid booking day
        ' Add conditions to check for holidays, festivals, Saturdays, and Sundays
        If appointmentDate.DayOfWeek = DayOfWeek.Saturday OrElse appointmentDate.DayOfWeek = DayOfWeek.Sunday Then
            Return False ' Saturdays and Sundays are not valid booking days
        End If

        ' Add conditions for national holidays or festivals
        Dim holidays As New List(Of Date) From {
            #1/1/2024#, ' New Year's Day
            #12/25/2024#}
        ' Christmas Day
        ' Add more holidays/festivals as needed

        If holidays.Contains(appointmentDate) Then
            Return False ' If the selected date is a holiday, return false
        End If

        ' If none of the above conditions are met, the date is a valid booking day
        Return True
    End Function


    Private Function GetLastAppointmentID(connection As SqlConnection) As Integer
        ' Retrieve the last inserted appointment ID from the database
        Dim query As String = "SELECT MAX(AppointmentID) FROM Appointments"
        Using command As New SqlCommand(query, connection)
            Dim result = command.ExecuteScalar()
            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                Return Convert.ToInt32(result)
            Else
                Return -1 ' Return a default value if no appointment ID is found
            End If
        End Using
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Open the reschedule form and pass the appointmentID
        Dim rescheduleForm As New RescheduleForm(appointmentID)
        rescheduleForm.Show()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cancelForm As New CancelForm(appointmentID)
        cancelForm.Show()
    End Sub
End Class