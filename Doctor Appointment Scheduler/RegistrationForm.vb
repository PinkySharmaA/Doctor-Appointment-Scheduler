Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class RegistrationForm
    Private connectionString As String = "Data Source=DESKTOP-5HCEJKD\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True;TrustServerCertificate=True"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim doctorName As String = TextBox1.Text
        Dim age As Integer = Convert.ToInt32(TextBox2.Text)
        Dim gender As String = ""
        If RadioButton1.Checked Then
            gender = RadioButton1.Text
        ElseIf RadioButton2.Checked Then
            gender = RadioButton2.Text
        End If
        Dim phone As String = TextBox3.Text
        Dim experience As Integer = Convert.ToInt32(TextBox4.Text)
        Dim specialist As String = ComboBox1.SelectedItem.ToString()
        Dim username As String = TextBox5.Text
        Dim password As String = TextBox6.Text

        If String.IsNullOrWhiteSpace(doctorName) OrElse age <= 0 OrElse String.IsNullOrWhiteSpace(gender) OrElse String.IsNullOrWhiteSpace(phone) OrElse experience <= 0 OrElse String.IsNullOrWhiteSpace(specialist) OrElse String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please fill in all the fields.")
            Return
        End If

        Dim query As String = "INSERT INTO Doctors (DoctorName, Age, Gender, Phone, Experience, Specialist, Username, Password) VALUES (@DoctorName, @Age, @Gender, @Phone, @Experience, @Specialist, @Username, @Password)"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@DoctorName", doctorName)
                command.Parameters.AddWithValue("@Age", age)
                command.Parameters.AddWithValue("@Gender", gender)
                command.Parameters.AddWithValue("@Phone", phone)
                command.Parameters.AddWithValue("@Experience", experience)
                command.Parameters.AddWithValue("@Specialist", specialist)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Registration successful!")
                    LoginForm.Show()
                Catch ex As Exception
                    MessageBox.Show("An error occurred while attempting to register: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox6.UseSystemPasswordChar = False
        Else
            TextBox6.UseSystemPasswordChar = True
        End If
    End Sub
End Class
