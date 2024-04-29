<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrationForm))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Button1 = New Button()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        CheckBox1 = New CheckBox()
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaption
        Label1.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(27, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 31)
        Label1.TabIndex = 0
        Label1.Text = "NAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaption
        Label2.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(27, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 31)
        Label2.TabIndex = 1
        Label2.Text = "AGE"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ActiveCaption
        Label3.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(38, 375)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 31)
        Label3.TabIndex = 2
        Label3.Text = "GENDER"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ActiveCaption
        Label4.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(27, 218)
        Label4.Name = "Label4"
        Label4.Size = New Size(152, 31)
        Label4.TabIndex = 3
        Label4.Text = "SPECIALIST"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ActiveCaption
        Label5.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(27, 133)
        Label5.Name = "Label5"
        Label5.Size = New Size(160, 31)
        Label5.TabIndex = 4
        Label5.Text = "EXPERIENCE"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.ActiveCaption
        Label6.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(27, 266)
        Label6.Name = "Label6"
        Label6.Size = New Size(150, 31)
        Label6.TabIndex = 5
        Label6.Text = "USERNAME"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.ActiveCaption
        Label7.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(27, 314)
        Label7.Name = "Label7"
        Label7.Size = New Size(149, 31)
        Label7.TabIndex = 6
        Label7.Text = "PASSWORD"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(371, 256)
        Button1.Name = "Button1"
        Button1.Size = New Size(210, 50)
        Button1.TabIndex = 14
        Button1.Text = "REGISTER"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.BackColor = Color.Transparent
        RadioButton1.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RadioButton1.Location = New Point(199, 375)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(104, 35)
        RadioButton1.TabIndex = 15
        RadioButton1.TabStop = True
        RadioButton1.Text = "MALE"
        RadioButton1.UseVisualStyleBackColor = False
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.BackColor = Color.Transparent
        RadioButton2.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RadioButton2.Location = New Point(326, 375)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(131, 35)
        RadioButton2.TabIndex = 16
        RadioButton2.TabStop = True
        RadioButton2.Text = "FEMALE"
        RadioButton2.UseVisualStyleBackColor = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Transparent
        CheckBox1.Font = New Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(234, 347)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(86, 31)
        CheckBox1.TabIndex = 18
        CheckBox1.Text = "Show"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = SystemColors.ActiveCaption
        ComboBox1.Font = New Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"MBBS,PHD,SURGEON", "SURGEON", "MBBS", "GYNECOLOGIST"})
        ComboBox1.Location = New Point(199, 218)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 35)
        ComboBox1.TabIndex = 19
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ActiveCaption
        TextBox1.Font = New Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(199, 53)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 34)
        TextBox1.TabIndex = 20
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.ActiveCaption
        TextBox2.Font = New Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(199, 92)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 34)
        TextBox2.TabIndex = 21
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.ActiveCaption
        TextBox3.Font = New Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(199, 178)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 34)
        TextBox3.TabIndex = 22
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = SystemColors.ActiveCaption
        TextBox4.Font = New Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(199, 133)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(125, 34)
        TextBox4.TabIndex = 23
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = SystemColors.ActiveCaption
        TextBox5.Font = New Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(199, 266)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(125, 34)
        TextBox5.TabIndex = 24
        ' 
        ' TextBox6
        ' 
        TextBox6.BackColor = SystemColors.ActiveCaption
        TextBox6.Font = New Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox6.Location = New Point(199, 314)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(125, 34)
        TextBox6.TabIndex = 25
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Palatino Linotype", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(170, 2)
        Label9.Name = "Label9"
        Label9.Size = New Size(296, 38)
        Label9.TabIndex = 26
        Label9.Text = "DOCTOR REGISTER"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.ActiveCaption
        Label8.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(27, 174)
        Label8.Name = "Label8"
        Label8.Size = New Size(99, 31)
        Label8.TabIndex = 17
        Label8.Text = "PHONE"
        ' 
        ' RegistrationForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(624, 416)
        Controls.Add(Label9)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(ComboBox1)
        Controls.Add(CheckBox1)
        Controls.Add(Label8)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Button1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "RegistrationForm"
        Text = "RegistrationForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
End Class
