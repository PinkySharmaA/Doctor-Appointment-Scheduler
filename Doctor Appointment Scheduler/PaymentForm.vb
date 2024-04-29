Imports System.Data.SqlClient

Public Class PaymentForm
    ' SQL connection string
    Private connectionString As String = "Data Source=DESKTOP-5HCEJKD\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"

    ' Appointment ID passed from previous forms
    Private appointmentID As Integer

    Public Sub New(ByVal apptID As Integer)
        InitializeComponent()
        ' Store the appointment ID passed from previous form
        appointmentID = apptID
    End Sub

    Private Sub PaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the default amount to $500
        TextBox4.Text = "500"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Get payment details from the form
        Dim cardNumber = TextBox1.Text
        Dim expirationDate = TextBox2.Text
        Dim cvv = TextBox3.Text
        Dim amountPaid = Decimal.Parse(TextBox4.Text)

        ' Insert payment details into the database
        Dim query = "INSERT INTO Payments (AppointmentID, CardNumber, ExpirationDate, CVV, AmountPaid) VALUES (@AppointmentID, @CardNumber, @ExpirationDate, @CVV, @AmountPaid)"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Add parameters to prevent SQL injection
                command.Parameters.AddWithValue("@AppointmentID", appointmentID)
                command.Parameters.AddWithValue("@CardNumber", cardNumber)
                command.Parameters.AddWithValue("@ExpirationDate", expirationDate)
                command.Parameters.AddWithValue("@CVV", cvv)
                command.Parameters.AddWithValue("@AmountPaid", amountPaid)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Payment submitted successfully.")
                    FeedbackForm.Show()
                    ' Close the payment form
                    Close()
                Catch ex As Exception
                    MessageBox.Show("An error occurred while submitting the payment: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox3.UseSystemPasswordChar = False
        Else
            TextBox3.UseSystemPasswordChar = True
        End If
    End Sub
End Class

