<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillReceiptForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BillReceiptForm))
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.White
        TextBox1.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(298, 106)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(262, 39)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.White
        TextBox2.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(298, 177)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(262, 39)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.White
        TextBox3.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(628, 106)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(262, 39)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.White
        TextBox4.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(628, 177)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(262, 39)
        TextBox4.TabIndex = 3
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.White
        TextBox5.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(298, 240)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(262, 39)
        TextBox5.TabIndex = 4
        ' 
        ' TextBox6
        ' 
        TextBox6.BackColor = Color.White
        TextBox6.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox6.Location = New Point(298, 307)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(262, 39)
        TextBox6.TabIndex = 5
        ' 
        ' TextBox7
        ' 
        TextBox7.BackColor = Color.White
        TextBox7.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox7.Location = New Point(72, 487)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(249, 39)
        TextBox7.TabIndex = 6
        ' 
        ' TextBox8
        ' 
        TextBox8.BackColor = Color.White
        TextBox8.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox8.Location = New Point(405, 487)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(251, 39)
        TextBox8.TabIndex = 7
        ' 
        ' TextBox9
        ' 
        TextBox9.BackColor = Color.White
        TextBox9.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox9.Location = New Point(748, 487)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(262, 39)
        TextBox9.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 75)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(223, 204)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Palatino Linotype", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(368, 367)
        Label1.Name = "Label1"
        Label1.Size = New Size(288, 38)
        Label1.TabIndex = 10
        Label1.Text = "PAYMENT DETAILS"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Palatino Linotype", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(449, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(217, 38)
        Label2.TabIndex = 11
        Label2.Text = "BILL/RECEIPT "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(470, 12)
        Label3.Name = "Label3"
        Label3.Size = New Size(186, 41)
        Label3.TabIndex = 12
        Label3.Text = "MEDICARE"
        ' 
        ' BillReceiptForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1092, 592)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox9)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "BillReceiptForm"
        Text = "BillReceiptForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
