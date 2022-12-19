<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblIntro = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.lblInquire = New System.Windows.Forms.Label()
        Me.lblGo = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.checkpassword = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblIntro
        '
        Me.lblIntro.AutoSize = True
        Me.lblIntro.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblIntro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIntro.Font = New System.Drawing.Font("Perpetua Titling MT", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntro.ForeColor = System.Drawing.Color.Navy
        Me.lblIntro.Location = New System.Drawing.Point(188, 9)
        Me.lblIntro.Name = "lblIntro"
        Me.lblIntro.Size = New System.Drawing.Size(531, 40)
        Me.lblIntro.TabIndex = 0
        Me.lblIntro.Text = "MOVIE REGISTRATION LOGIN "
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblName.Font = New System.Drawing.Font("Perpetua Titling MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(111, 148)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(135, 43)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Perpetua Titling MT", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(306, 150)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(473, 46)
        Me.txtName.TabIndex = 1
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblUserName.Font = New System.Drawing.Font("Perpetua Titling MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(62, 250)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(246, 43)
        Me.lblUserName.TabIndex = 3
        Me.lblUserName.Text = "User Name"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblPassword.Font = New System.Drawing.Font("Perpetua Titling MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(73, 355)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(235, 43)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password"
        '
        'txtUserName
        '
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserName.Font = New System.Drawing.Font("Perpetua Titling MT", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(346, 247)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(464, 46)
        Me.txtUserName.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Perpetua Titling MT", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(369, 352)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(464, 46)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.SystemColors.Info
        Me.btnSignUp.Font = New System.Drawing.Font("Perpetua Titling MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.Location = New System.Drawing.Point(561, 579)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(218, 92)
        Me.btnSignUp.TabIndex = 5
        Me.btnSignUp.Text = "SIGN UP"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.SystemColors.Info
        Me.btnLogIn.Font = New System.Drawing.Font("Perpetua Titling MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIn.Location = New System.Drawing.Point(457, 446)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(204, 92)
        Me.btnLogIn.TabIndex = 4
        Me.btnLogIn.Text = "LOG IN"
        Me.btnLogIn.UseVisualStyleBackColor = False
        '
        'lblInquire
        '
        Me.lblInquire.AutoSize = True
        Me.lblInquire.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblInquire.Font = New System.Drawing.Font("Perpetua Titling MT", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInquire.Location = New System.Drawing.Point(12, 608)
        Me.lblInquire.Name = "lblInquire"
        Me.lblInquire.Size = New System.Drawing.Size(486, 38)
        Me.lblInquire.TabIndex = 9
        Me.lblInquire.Text = "No account ?? Sign Up >>"
        '
        'lblGo
        '
        Me.lblGo.AutoSize = True
        Me.lblGo.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblGo.Font = New System.Drawing.Font("Perpetua Titling MT", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGo.Location = New System.Drawing.Point(112, 475)
        Me.lblGo.Name = "lblGo"
        Me.lblGo.Size = New System.Drawing.Size(250, 38)
        Me.lblGo.TabIndex = 10
        Me.lblGo.Text = "Go ahead >>"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblWelcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWelcome.Font = New System.Drawing.Font("Ravie", 18.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.Crimson
        Me.lblWelcome.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblWelcome.Location = New System.Drawing.Point(313, 67)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWelcome.Size = New System.Drawing.Size(339, 51)
        Me.lblWelcome.TabIndex = 11
        Me.lblWelcome.Text = "WELCOME!!!!!"
        '
        'checkpassword
        '
        Me.checkpassword.AutoSize = True
        Me.checkpassword.Font = New System.Drawing.Font("Perpetua Titling MT", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkpassword.Location = New System.Drawing.Point(870, 362)
        Me.checkpassword.Name = "checkpassword"
        Me.checkpassword.Size = New System.Drawing.Size(129, 37)
        Me.checkpassword.TabIndex = 12
        Me.checkpassword.Text = "Show"
        Me.checkpassword.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1095, 742)
        Me.Controls.Add(Me.checkpassword)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblGo)
        Me.Controls.Add(Me.lblInquire)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblIntro)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIntro As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnSignUp As Button
    Friend WithEvents btnLogIn As Button
    Friend WithEvents lblInquire As Label
    Friend WithEvents lblGo As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents checkpassword As CheckBox
End Class
