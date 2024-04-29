Imports System.Data.SqlClient
Public Class BillReceiptForm
    Private appointmentID As Integer
    Private connectionString As String = "Data Source=DESKTOP-5HCEJKD\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"

    Public Sub New(ByVal apptID As Integer)
        InitializeComponent()
        appointmentID = apptID
    End Sub

    Private Sub BillReceiptForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAppointmentDetails()
        LoadPaymentDetails()
    End Sub

    Private Sub LoadAppointmentDetails()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT * FROM Appointments WHERE AppointmentID = @AppointmentID"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@AppointmentID", appointmentID)
                    Dim reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        TextBox1.Text = "Patient Name: " & reader("PatientName").ToString()
                        TextBox2.Text = "Contact Number: " & reader("ContactNumber").ToString()
                        TextBox3.Text = "Consultation Type: " & reader("ConsultationType").ToString()
                        TextBox4.Text = "Urgency: " & reader("Urgency").ToString()
                        TextBox5.Text = "Appointment Date: " & DateTime.Parse(reader("AppointmentDate").ToString()).ToShortDateString()
                        TextBox6.Text = "Appointment Time: " & reader("AppointmentTime").ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading appointment details: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadPaymentDetails()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT * FROM Payments WHERE AppointmentID = @AppointmentID"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@AppointmentID", appointmentID)
                    Dim reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        TextBox7.Text = "Card Number: " & reader("CardNumber").ToString()
                        TextBox8.Text = "Expiration Date: " & reader("ExpirationDate").ToString()
                        TextBox9.Text = "Amount Paid: $" & reader("AmountPaid").ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading payment details: " & ex.Message)
        End Try
    End Sub
End Class
