<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentForm))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Button1 = New Button()
        CheckBox1 = New CheckBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(351, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(268, 41)
        Label1.TabIndex = 0
        Label1.Text = "PAYMENT FORM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaption
        Label2.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(196, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(195, 31)
        Label2.TabIndex = 1
        Label2.Text = "CARD NUMBER"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ActiveCaption
        Label3.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(196, 185)
        Label3.Name = "Label3"
        Label3.Size = New Size(167, 31)
        Label3.TabIndex = 2
        Label3.Text = "EXPIRY DATE"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ActiveCaption
        Label4.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(215, 279)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 31)
        Label4.TabIndex = 3
        Label4.Text = "CVV"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ActiveCaption
        Label5.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(196, 368)
        Label5.Name = "Label5"
        Label5.Size = New Size(126, 31)
        Label5.TabIndex = 4
        Label5.Text = "AMOUNT"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.GradientActiveCaption
        TextBox1.Font = New Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(566, 101)
        TextBox1.MaxLength = 12
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 34)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.GradientActiveCaption
        TextBox2.Font = New Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(566, 185)
        TextBox2.MaxLength = 5
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 34)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.GradientActiveCaption
        TextBox3.Font = New Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(566, 276)
        TextBox3.MaxLength = 3
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 34)
        TextBox3.TabIndex = 5
        TextBox3.UseSystemPasswordChar = True
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = SystemColors.GradientActiveCaption
        TextBox4.Font = New Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(566, 371)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(125, 34)
        TextBox4.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(392, 466)
        Button1.Name = "Button1"
        Button1.Size = New Size(158, 61)
        Button1.TabIndex = 9
        Button1.Text = "PAY"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Transparent
        CheckBox1.Font = New Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(597, 321)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(86, 31)
        CheckBox1.TabIndex = 10
        CheckBox1.Text = "Show"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' PaymentForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(895, 690)
        Controls.Add(CheckBox1)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "PaymentForm"
        Text = "PaymentForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
