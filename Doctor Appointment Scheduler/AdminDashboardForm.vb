Imports System.Data.SqlClient

Public Class AdminDashboardForm
    Private connectionString As String = "Data Source=DESKTOP-5HCEJKD\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True;TrustServerCertificate=True"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Load appointments data into DataGridView
        LoadAppointmentsData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Load payments data into DataGridView
        LoadPaymentsData()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Load feedback data into DataGridView
        LoadFeedbackData()
    End Sub

    Private Sub LoadAppointmentsData()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT * FROM Appointments"
                Using command As New SqlCommand(query, connection)
                    Using adapter As New SqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)
                        DataGridView1.DataSource = dataTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading appointments data: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadPaymentsData()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT * FROM Payments"
                Using command As New SqlCommand(query, connection)
                    Using adapter As New SqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)
                        DataGridView1.DataSource = dataTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading payments data: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadFeedbackData()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT * FROM Feedback"
                Using command As New SqlCommand(query, connection)
                    Using adapter As New SqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)
                        DataGridView1.DataSource = dataTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading feedback data: " & ex.Message)
        End Try
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Get the appointment ID from the selected row in the DataGridView
        Dim appointmentID As Integer = GetSelectedAppointmentID()

        ' Check if an appointment is selected
        If appointmentID <> -1 Then
            ' Open the form to cancel appointments and pass the appointment ID
            Dim cancelForm As New CancelForm(appointmentID)
            If cancelForm.ShowDialog() = DialogResult.OK Then
                ' Appointment was successfully canceled
                ' Remove the appointment from the DataGridView
                Dim dataTable As DataTable = TryCast(DataGridView1.DataSource, DataTable)
                If dataTable IsNot Nothing Then
                    Dim rowToDelete As DataRow = dataTable.Select("AppointmentID = " & appointmentID.ToString()).FirstOrDefault()
                    If rowToDelete IsNot Nothing Then
                        Try
                            dataTable.Rows.Remove(rowToDelete)
                            ' Refresh the DataGridView to reflect the changes
                            DataGridView1.Refresh()
                            MessageBox.Show("Appointment canceled successfully.")
                        Catch ex As Exception
                            MessageBox.Show("Error removing appointment from DataTable: " & ex.Message)
                        End Try
                    Else
                        MessageBox.Show("Appointment ID not found in DataTable.")
                    End If
                Else
                    MessageBox.Show("DataGridView is not bound to a DataTable.")
                End If
            End If
        Else
            MessageBox.Show("Please select an appointment.")
        End If
    End Sub


    Private Function GetSelectedAppointmentID() As Integer
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Retrieve the appointment ID from the selected row
            Dim rowIndex As Integer = DataGridView1.SelectedRows(0).Index
            Return Convert.ToInt32(DataGridView1.Rows(rowIndex).Cells("AppointmentID").Value)
        Else
            ' No appointment selected
            Return -1
        End If
    End Function


End Class
