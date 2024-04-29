<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoctorAppointmentForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DoctorAppointmentForm))
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        MonthCalendar1 = New MonthCalendar()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(202, 425)
        Button1.Name = "Button1"
        Button1.Size = New Size(137, 63)
        Button1.TabIndex = 0
        Button1.Text = "BOOK"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.GradientActiveCaption
        TextBox1.Font = New Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(321, 55)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(151, 34)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.GradientActiveCaption
        TextBox2.Font = New Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(321, 113)
        TextBox2.MaxLength = 10
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(151, 34)
        TextBox2.TabIndex = 2
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = SystemColors.GradientActiveCaption
        ComboBox1.Font = New Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"General Checkup", "Annual Physical Examination", "Follow-up Consultation", "Minor Illness Consultation", "Chronic Disease Management", "Medication Refill", "Immunization", "Health Screening", "Wellness Consultation", "Lifestyle Counseling"})
        ComboBox1.Location = New Point(321, 253)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 35)
        ComboBox1.TabIndex = 3
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = SystemColors.GradientActiveCaption
        ComboBox2.Font = New Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"YES", "NO"})
        ComboBox2.Location = New Point(321, 180)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(151, 35)
        ComboBox2.TabIndex = 5
        ' 
        ' ComboBox3
        ' 
        ComboBox3.BackColor = SystemColors.GradientActiveCaption
        ComboBox3.Font = New Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"08:00 AM", "08:30 AM", "09:00 AM", "09:30 AM", "10:00 AM", "10:30 AM", "11:00 AM", "11:30 AM", "12:00 PM", "12:30 PM", "01:00 PM", "01:30 PM", "02:00 PM", "02:30 PM", "03:00 PM", "03:30 PM", "04:00 PM", "04:30 PM", "05:00 PM", "05:30 PM"})
        ComboBox3.Location = New Point(321, 320)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(151, 35)
        ComboBox3.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaption
        Label1.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(25, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 31)
        Label1.TabIndex = 7
        Label1.Text = "NAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaption
        Label2.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(25, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(133, 31)
        Label2.TabIndex = 8
        Label2.Text = "CONTACT"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ActiveCaption
        Label3.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(25, 248)
        Label3.Name = "Label3"
        Label3.Size = New Size(270, 31)
        Label3.TabIndex = 9
        Label3.Text = "CONSULTATION TYPE"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ActiveCaption
        Label4.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(26, 180)
        Label4.Name = "Label4"
        Label4.Size = New Size(132, 31)
        Label4.TabIndex = 10
        Label4.Text = "URGENCY"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ActiveCaption
        Label5.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(25, 320)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 31)
        Label5.TabIndex = 11
        Label5.Text = "TIMINGS"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.ActiveCaption
        Label6.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(542, 204)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 31)
        Label6.TabIndex = 12
        Label6.Text = "DATE"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(382, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(261, 41)
        Label7.TabIndex = 13
        Label7.Text = "SLOT BOOKING"
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(633, 104)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 16
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaption
        Button2.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(361, 425)
        Button2.Name = "Button2"
        Button2.Size = New Size(184, 63)
        Button2.TabIndex = 17
        Button2.Text = "RESCHEDULE"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ActiveCaption
        Button3.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(570, 425)
        Button3.Name = "Button3"
        Button3.Size = New Size(138, 61)
        Button3.TabIndex = 18
        Button3.Text = "CANCEL"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' DoctorAppointmentForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(908, 618)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(MonthCalendar1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Name = "DoctorAppointmentForm"
        Text = "DoctorAppointmentForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
