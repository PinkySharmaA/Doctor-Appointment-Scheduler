<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RescheduleForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RescheduleForm))
        Button1 = New Button()
        Button2 = New Button()
        ComboBox1 = New ComboBox()
        MonthCalendar1 = New MonthCalendar()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(184, 449)
        Button1.Name = "Button1"
        Button1.Size = New Size(193, 80)
        Button1.TabIndex = 0
        Button1.Text = "RESCHEDULE"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaption
        Button2.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(441, 449)
        Button2.Name = "Button2"
        Button2.Size = New Size(197, 80)
        Button2.TabIndex = 1
        Button2.Text = "CANCEL"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = SystemColors.GradientActiveCaption
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"9:00 am", "10:00 am", "11:00 am", "12:00 pm", "5:00 pm", "6:00 pm", "7:00 pm", "8:00 pm"})
        ComboBox1.Location = New Point(322, 308)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 3
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.BackColor = SystemColors.Window
        MonthCalendar1.Location = New Point(293, 64)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaption
        Label1.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(167, 371)
        Label1.Name = "Label1"
        Label1.Size = New Size(169, 31)
        Label1.TabIndex = 5
        Label1.Text = "Appointment :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaption
        Label2.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(167, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 31)
        Label2.TabIndex = 6
        Label2.Text = "DATE"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ActiveCaption
        Label3.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(180, 308)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 31)
        Label3.TabIndex = 7
        Label3.Text = "TIME"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(275, 15)
        Label4.Name = "Label4"
        Label4.Size = New Size(325, 41)
        Label4.TabIndex = 8
        Label4.Text = "RESCHEDULE FORM"
        ' 
        ' RescheduleForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(896, 568)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MonthCalendar1)
        Controls.Add(ComboBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "RescheduleForm"
        Text = "RescheduleForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
