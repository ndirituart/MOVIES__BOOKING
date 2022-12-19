<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.lblconfirm = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.checkshow = New System.Windows.Forms.CheckBox()
        Me.checkshow2 = New System.Windows.Forms.CheckBox()
        Me.Labelconfirm = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.SystemColors.Info
        Me.lblWelcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWelcome.Font = New System.Drawing.Font("Perpetua Titling MT", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.lblWelcome.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblWelcome.Location = New System.Drawing.Point(605, 102)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWelcome.Size = New System.Drawing.Size(363, 45)
        Me.lblWelcome.TabIndex = 18
        Me.lblWelcome.Text = "TAKE YOUR TIME"
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Perpetua", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(259, 382)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(421, 44)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUserName
        '
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserName.Font = New System.Drawing.Font("Perpetua", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(263, 286)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(417, 44)
        Me.txtUserName.TabIndex = 2
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Silver
        Me.lblPassword.Font = New System.Drawing.Font("Perpetua Titling MT", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(12, 382)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(207, 38)
        Me.lblPassword.TabIndex = 17
        Me.lblPassword.Text = "Password"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.Color.Silver
        Me.lblUserName.Font = New System.Drawing.Font("Perpetua Titling MT", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(1, 292)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(218, 38)
        Me.lblUserName.TabIndex = 16
        Me.lblUserName.Text = "User Name"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Perpetua", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(209, 201)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(436, 44)
        Me.txtName.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Silver
        Me.lblName.Font = New System.Drawing.Font("Perpetua Titling MT", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(22, 207)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(120, 38)
        Me.lblName.TabIndex = 13
        Me.lblName.Text = "Name"
        '
        'txtConfirm
        '
        Me.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirm.Font = New System.Drawing.Font("Perpetua", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirm.Location = New System.Drawing.Point(390, 477)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.Size = New System.Drawing.Size(409, 44)
        Me.txtConfirm.TabIndex = 4
        Me.txtConfirm.UseSystemPasswordChar = True
        '
        'lblconfirm
        '
        Me.lblconfirm.AutoSize = True
        Me.lblconfirm.BackColor = System.Drawing.Color.Silver
        Me.lblconfirm.Font = New System.Drawing.Font("Perpetua Titling MT", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconfirm.Location = New System.Drawing.Point(3, 479)
        Me.lblconfirm.Name = "lblconfirm"
        Me.lblconfirm.Size = New System.Drawing.Size(381, 38)
        Me.lblconfirm.TabIndex = 20
        Me.lblconfirm.Text = "Confirm Password"
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Perpetua Titling MT", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(234, 567)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(209, 77)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(570, 183)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Perpetua Titling MT", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(838, 615)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(209, 99)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "BACK TO LOGIN"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(553, 644)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 38)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "FINISHED???>>"
        '
        'checkshow
        '
        Me.checkshow.AutoSize = True
        Me.checkshow.Font = New System.Drawing.Font("Perpetua Titling MT", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkshow.Location = New System.Drawing.Point(719, 389)
        Me.checkshow.Name = "checkshow"
        Me.checkshow.Size = New System.Drawing.Size(129, 37)
        Me.checkshow.TabIndex = 27
        Me.checkshow.Text = "Show"
        Me.checkshow.UseVisualStyleBackColor = True
        '
        'checkshow2
        '
        Me.checkshow2.AutoSize = True
        Me.checkshow2.Font = New System.Drawing.Font("Perpetua Titling MT", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkshow2.Location = New System.Drawing.Point(838, 482)
        Me.checkshow2.Name = "checkshow2"
        Me.checkshow2.Size = New System.Drawing.Size(129, 37)
        Me.checkshow2.TabIndex = 28
        Me.checkshow2.Text = "Show"
        Me.checkshow2.UseVisualStyleBackColor = True
        '
        'Labelconfirm
        '
        Me.Labelconfirm.AutoSize = True
        Me.Labelconfirm.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Labelconfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Labelconfirm.Font = New System.Drawing.Font("Perpetua", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelconfirm.ForeColor = System.Drawing.Color.Red
        Me.Labelconfirm.Location = New System.Drawing.Point(719, 534)
        Me.Labelconfirm.Name = "Labelconfirm"
        Me.Labelconfirm.Size = New System.Drawing.Size(2, 44)
        Me.Labelconfirm.TabIndex = 29
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1174, 786)
        Me.Controls.Add(Me.Labelconfirm)
        Me.Controls.Add(Me.checkshow2)
        Me.Controls.Add(Me.checkshow)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtConfirm)
        Me.Controls.Add(Me.lblconfirm)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtConfirm As TextBox
    Friend WithEvents lblconfirm As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents checkshow As CheckBox
    Friend WithEvents checkshow2 As CheckBox
    Friend WithEvents Labelconfirm As Label
End Class
