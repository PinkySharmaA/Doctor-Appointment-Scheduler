<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Profile))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        RichTextBox1 = New RichTextBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        RichTextBox3 = New RichTextBox()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        RichTextBox2 = New RichTextBox()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(55, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 30)
        Label1.TabIndex = 0
        Label1.Text = "PROFILE"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(46, 60)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(175, 170)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.MediumTurquoise
        Label2.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(46, 221)
        Label2.Name = "Label2"
        Label2.Size = New Size(192, 31)
        Label2.TabIndex = 2
        Label2.Text = "Dr.Neha Kumari"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.MediumTurquoise
        Label3.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(34, 255)
        Label3.Name = "Label3"
        Label3.Size = New Size(212, 31)
        Label3.TabIndex = 3
        Label3.Text = "MBBS ,SURGEON"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Palatino Linotype", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(40, 305)
        Label4.Name = "Label4"
        Label4.Size = New Size(201, 40)
        Label4.TabIndex = 4
        Label4.Text = "BIOGRAPHY"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.LightGray
        RichTextBox1.Font = New Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(0, 360)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(327, 201)
        RichTextBox1.TabIndex = 6
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(RichTextBox1)
        Panel1.Location = New Point(1, -3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(324, 567)
        Panel1.TabIndex = 7
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightGray
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(RichTextBox3)
        Panel2.Controls.Add(Label14)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(RichTextBox2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(324, -3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(573, 564)
        Panel2.TabIndex = 8
        ' 
        ' RichTextBox3
        ' 
        RichTextBox3.Location = New Point(66, 453)
        RichTextBox3.Name = "RichTextBox3"
        RichTextBox3.Size = New Size(245, 99)
        RichTextBox3.TabIndex = 12
        RichTextBox3.Text = "1234567890,0987758930" & vbLf & "yourwebsite@gmail.com" & vbLf & "www.yourwebaddress.com" & vbLf & vbLf & vbLf
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(215, 380)
        Label14.Name = "Label14"
        Label14.Size = New Size(138, 27)
        Label14.TabIndex = 11
        Label14.Text = "English,Hindi"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(215, 335)
        Label13.Name = "Label13"
        Label13.Size = New Size(96, 27)
        Label13.TabIndex = 10
        Label13.Text = "10 Years+"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Palatino Linotype", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Red
        Label12.Location = New Point(62, 423)
        Label12.Name = "Label12"
        Label12.Size = New Size(110, 27)
        Label12.TabIndex = 9
        Label12.Text = "CONTACT"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Palatino Linotype", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Red
        Label11.Location = New Point(55, 380)
        Label11.Name = "Label11"
        Label11.Size = New Size(139, 27)
        Label11.TabIndex = 8
        Label11.Text = "LANGUAGES"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Palatino Linotype", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Red
        Label10.Location = New Point(55, 330)
        Label10.Name = "Label10"
        Label10.Size = New Size(139, 27)
        Label10.TabIndex = 7
        Label10.Text = "EXPERIENCE"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(306, 288)
        Label9.Name = "Label9"
        Label9.Size = New Size(120, 27)
        Label9.TabIndex = 6
        Label9.Text = "Neurologist"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(127, 288)
        Label8.Name = "Label8"
        Label8.Size = New Size(149, 27)
        Label8.TabIndex = 5
        Label8.Text = "Opthamologist"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(448, 288)
        Label7.Name = "Label7"
        Label7.Size = New Size(112, 27)
        Label7.TabIndex = 4
        Label7.Text = "Cardiology"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(19, 288)
        Label6.Name = "Label6"
        Label6.Size = New Size(84, 27)
        Label6.TabIndex = 3
        Label6.Text = "Surgery"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(47, 236)
        Label5.Name = "Label5"
        Label5.Size = New Size(147, 30)
        Label5.TabIndex = 2
        Label5.Text = "SPECIALIST"
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.BackColor = SystemColors.MenuBar
        RichTextBox2.Font = New Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RichTextBox2.Location = New Point(55, 55)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(322, 178)
        RichTextBox2.TabIndex = 1
        RichTextBox2.Text = "Dr.Neha Kumari" & vbLf & "MBBS,Surgeon" & vbLf & vbLf & "MS.MCh(Surgery)" & vbLf & "Medic General Medical Hospital" & vbLf & "Bengaluru.India" & vbLf
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Turquoise
        Button1.Location = New Point(390, 444)
        Button1.Name = "Button1"
        Button1.Size = New Size(131, 58)
        Button1.TabIndex = 13
        Button1.Text = "CLOSE"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Profile
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(896, 561)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Profile"
        Text = "Profile"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents Button1 As Button
End Class
