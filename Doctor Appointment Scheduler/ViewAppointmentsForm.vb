Imports System.Data.SqlClient

Public Class ViewAppointmentsForm
    Private connectionString As String = "Data Source=DESKTOP-5HCEJKD\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True;TrustServerCertificate=True"
    Private appointmentID As Integer ' Variable to store the appointment ID after login

    Public Sub New(ByVal appointmentID As Integer)
        InitializeComponent()
        ' Store the appointment ID passed from the login form
        Me.appointmentID = appointmentID
    End Sub

    Private Sub ViewAppointmentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the appointments based on the appointment ID
        LoadAppointments()
    End Sub

    Private Sub LoadAppointments()
        Try
            ' Clear existing rows and columns in the DataGridView
            DataGridView1.Rows.Clear()
            DataGridView1.Columns.Clear()

            ' Add columns to the DataGridView
            DataGridView1.Columns.Add("AppointmentIDColumn", "Appointment ID")
            DataGridView1.Columns.Add("PatientNameColumn", "Patient Name")
            DataGridView1.Columns.Add("ContactNumberColumn", "Contact Number")
            DataGridView1.Columns.Add("ConsultationTypeColumn", "Consultation Type")
            DataGridView1.Columns.Add("UrgencyColumn", "Urgency")
            DataGridView1.Columns.Add("AppointmentDateColumn", "Appointment Date")
            DataGridView1.Columns.Add("AppointmentTimeColumn", "Appointment Time")

            Using connection As New SqlConnection(connectionString)
                connection.Open()
                ' Query to retrieve appointments based on the appointment ID
                Dim query As String = "SELECT AppointmentID, PatientName, ContactNumber, ConsultationType, Urgency, AppointmentDate, AppointmentTime FROM Appointments WHERE AppointmentID = @AppointmentID"
                Using command As New SqlCommand(query, connection)
                    ' Add parameter to prevent SQL injection
                    command.Parameters.AddWithValue("@AppointmentID", appointmentID)

                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            ' Read appointment details from the database
                            Dim appointmentID As Integer = reader.GetInt32(0)
                            Dim patientName As String = reader.GetString(1)
                            Dim contactNumber As String = reader.GetString(2)
                            Dim consultationType As String = reader.GetString(3)
                            Dim urgency As String = reader.GetString(4)
                            Dim appointmentDate As Date = reader.GetDateTime(5)
                            Dim appointmentTime As String = reader.GetString(6)

                            ' Add a new row to the DataGridView
                            DataGridView1.Rows.Add(appointmentID, patientName, contactNumber, consultationType, urgency, appointmentDate.ToString("MM/dd/yyyy"), appointmentTime)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading appointments: " & ex.Message)
        End Try
    End Sub


End Class
