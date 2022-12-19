<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.lblFirstNAme = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblEmailaddress = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtEmailaddress = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioRegular = New System.Windows.Forms.RadioButton()
        Me.RadioVIP = New System.Windows.Forms.RadioButton()
        Me.radioVVIP = New System.Windows.Forms.RadioButton()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblSpacetype = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMovieName = New System.Windows.Forms.TextBox()
        Me.lblMovieName = New System.Windows.Forms.Label()
        Me.cboPrice = New System.Windows.Forms.ComboBox()
        Me.cboTime = New System.Windows.Forms.ComboBox()
        Me.cboGenre = New System.Windows.Forms.ComboBox()
        Me.lblMovieGenre = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblTimeofScreening = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboTheatre = New System.Windows.Forms.ComboBox()
        Me.lblTheatreName = New System.Windows.Forms.Label()
        Me.cmdBookNow = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFirstNAme
        '
        Me.lblFirstNAme.AutoSize = True
        Me.lblFirstNAme.BackColor = System.Drawing.SystemColors.InfoText
        Me.lblFirstNAme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFirstNAme.Location = New System.Drawing.Point(6, 45)
        Me.lblFirstNAme.Name = "lblFirstNAme"
        Me.lblFirstNAme.Size = New System.Drawing.Size(143, 31)
        Me.lblFirstNAme.TabIndex = 0
        Me.lblFirstNAme.Text = "First Name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.BackColor = System.Drawing.SystemColors.InfoText
        Me.lblLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLastName.Location = New System.Drawing.Point(6, 94)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(139, 31)
        Me.lblLastName.TabIndex = 1
        Me.lblLastName.Text = "Last Name"
        '
        'lblEmailaddress
        '
        Me.lblEmailaddress.AutoSize = True
        Me.lblEmailaddress.BackColor = System.Drawing.SystemColors.InfoText
        Me.lblEmailaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmailaddress.Location = New System.Drawing.Point(6, 156)
        Me.lblEmailaddress.Name = "lblEmailaddress"
        Me.lblEmailaddress.Size = New System.Drawing.Size(182, 31)
        Me.lblEmailaddress.TabIndex = 2
        Me.lblEmailaddress.Text = "Email address"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(163, 41)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(284, 35)
        Me.txtFirstName.TabIndex = 0
        '
        'txtEmailaddress
        '
        Me.txtEmailaddress.Location = New System.Drawing.Point(194, 152)
        Me.txtEmailaddress.Name = "txtEmailaddress"
        Me.txtEmailaddress.Size = New System.Drawing.Size(324, 35)
        Me.txtEmailaddress.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(163, 90)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(272, 35)
        Me.txtLastName.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.RadioRegular)
        Me.GroupBox1.Controls.Add(Me.RadioVIP)
        Me.GroupBox1.Controls.Add(Me.radioVVIP)
        Me.GroupBox1.Controls.Add(Me.txtAge)
        Me.GroupBox1.Controls.Add(Me.lblAge)
        Me.GroupBox1.Controls.Add(Me.lblSpacetype)
        Me.GroupBox1.Controls.Add(Me.lblFirstNAme)
        Me.GroupBox1.Controls.Add(Me.txtEmailaddress)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.lblLastName)
        Me.GroupBox1.Controls.Add(Me.lblEmailaddress)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(547, 361)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "USER DETAILS"
        '
        'RadioRegular
        '
        Me.RadioRegular.AutoSize = True
        Me.RadioRegular.BackColor = System.Drawing.Color.Black
        Me.RadioRegular.Location = New System.Drawing.Point(272, 309)
        Me.RadioRegular.Name = "RadioRegular"
        Me.RadioRegular.Size = New System.Drawing.Size(158, 33)
        Me.RadioRegular.TabIndex = 11
        Me.RadioRegular.TabStop = True
        Me.RadioRegular.Text = "REGULAR"
        Me.RadioRegular.UseVisualStyleBackColor = False
        '
        'RadioVIP
        '
        Me.RadioVIP.AutoSize = True
        Me.RadioVIP.BackColor = System.Drawing.Color.Black
        Me.RadioVIP.Location = New System.Drawing.Point(31, 309)
        Me.RadioVIP.Name = "RadioVIP"
        Me.RadioVIP.Size = New System.Drawing.Size(78, 33)
        Me.RadioVIP.TabIndex = 10
        Me.RadioVIP.TabStop = True
        Me.RadioVIP.Text = "VIP"
        Me.RadioVIP.UseVisualStyleBackColor = False
        '
        'radioVVIP
        '
        Me.radioVVIP.AutoSize = True
        Me.radioVVIP.BackColor = System.Drawing.Color.Black
        Me.radioVVIP.Location = New System.Drawing.Point(335, 263)
        Me.radioVVIP.Name = "radioVVIP"
        Me.radioVVIP.Size = New System.Drawing.Size(94, 33)
        Me.radioVVIP.TabIndex = 9
        Me.radioVVIP.TabStop = True
        Me.radioVVIP.Text = "VVIP"
        Me.radioVVIP.UseVisualStyleBackColor = False
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(122, 214)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(284, 35)
        Me.txtAge.TabIndex = 3
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.BackColor = System.Drawing.SystemColors.InfoText
        Me.lblAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAge.Location = New System.Drawing.Point(6, 218)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(61, 31)
        Me.lblAge.TabIndex = 8
        Me.lblAge.Text = "Age"
        '
        'lblSpacetype
        '
        Me.lblSpacetype.AutoSize = True
        Me.lblSpacetype.BackColor = System.Drawing.SystemColors.InfoText
        Me.lblSpacetype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSpacetype.Location = New System.Drawing.Point(6, 263)
        Me.lblSpacetype.Name = "lblSpacetype"
        Me.lblSpacetype.Size = New System.Drawing.Size(304, 31)
        Me.lblSpacetype.TabIndex = 6
        Me.lblSpacetype.Text = "Space Resesrvation type"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.txtMovieName)
        Me.GroupBox2.Controls.Add(Me.lblMovieName)
        Me.GroupBox2.Controls.Add(Me.cboPrice)
        Me.GroupBox2.Controls.Add(Me.cboTime)
        Me.GroupBox2.Controls.Add(Me.cboGenre)
        Me.GroupBox2.Controls.Add(Me.lblMovieGenre)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblPrice)
        Me.GroupBox2.Controls.Add(Me.lblTimeofScreening)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 373)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(547, 299)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MOVIE DETAILS"
        '
        'txtMovieName
        '
        Me.txtMovieName.Location = New System.Drawing.Point(194, 41)
        Me.txtMovieName.Name = "txtMovieName"
        Me.txtMovieName.Size = New System.Drawing.Size(324, 35)
        Me.txtMovieName.TabIndex = 5
        '
        'lblMovieName
        '
        Me.lblMovieName.AutoSize = True
        Me.lblMovieName.BackColor = System.Drawing.SystemColors.InfoText
        Me.lblMovieName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMovieName.Location = New System.Drawing.Point(6, 46)
        Me.lblMovieName.Name = "lblMovieName"
        Me.lblMovieName.Size = New System.Drawing.Size(161, 31)
        Me.lblMovieName.TabIndex = 7
        Me.lblMovieName.Text = "Movie Name"
        '
        'cboPrice
        '
        Me.cboPrice.FormattingEnabled = True
        Me.cboPrice.Items.AddRange(New Object() {"Price"})
        Me.cboPrice.Location = New System.Drawing.Point(224, 158)
        Me.cboPrice.Name = "cboPrice"
        Me.cboPrice.Size = New System.Drawing.Size(285, 37)
        Me.cboPrice.TabIndex = 7
        '
        'cboTime
        '
        Me.cboTime.FormattingEnabled = True
        Me.cboTime.Items.AddRange(New Object() {"1100hrs", "1230hrs", "1500hrs", "1730hrs", "1930hrs", "2200hrs"})
        Me.cboTime.Location = New System.Drawing.Point(260, 207)
        Me.cboTime.Name = "cboTime"
        Me.cboTime.Size = New System.Drawing.Size(249, 37)
        Me.cboTime.TabIndex = 8
        '
        'cboGenre
        '
        Me.cboGenre.FormattingEnabled = True
        Me.cboGenre.Location = New System.Drawing.Point(214, 105)
        Me.cboGenre.Name = "cboGenre"
        Me.cboGenre.Size = New System.Drawing.Size(304, 37)
        Me.cboGenre.TabIndex = 6
        '
        'lblMovieGenre
        '
        Me.lblMovieGenre.AutoSize = True
        Me.lblMovieGenre.BackColor = System.Drawing.SystemColors.InfoText
        Me.lblMovieGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMovieGenre.Location = New System.Drawing.Point(6, 108)
        Me.lblMovieGenre.Name = "lblMovieGenre"
        Me.lblMovieGenre.Size = New System.Drawing.Size(164, 31)
        Me.lblMovieGenre.TabIndex = 6
        Me.lblMovieGenre.Text = "Movie Genre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(77, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(314, 31)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "* Choose best preference"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.SystemColors.InfoText
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrice.Location = New System.Drawing.Point(6, 164)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(159, 31)
        Me.lblPrice.TabIndex = 1
        Me.lblPrice.Text = "Price in KSh"
        '
        'lblTimeofScreening
        '
        Me.lblTimeofScreening.AutoSize = True
        Me.lblTimeofScreening.BackColor = System.Drawing.SystemColors.InfoText
        Me.lblTimeofScreening.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTimeofScreening.Location = New System.Drawing.Point(6, 210)
        Me.lblTimeofScreening.Name = "lblTimeofScreening"
        Me.lblTimeofScreening.Size = New System.Drawing.Size(230, 31)
        Me.lblTimeofScreening.TabIndex = 2
        Me.lblTimeofScreening.Text = "Time of Screening"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = CType(resources.GetObject("GroupBox3.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox3.Controls.Add(Me.cboTheatre)
        Me.GroupBox3.Controls.Add(Me.lblTheatreName)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Location = New System.Drawing.Point(616, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(619, 136)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "THEATRE DETAILS"
        '
        'cboTheatre
        '
        Me.cboTheatre.FormattingEnabled = True
        Me.cboTheatre.Items.AddRange(New Object() {"Century Cinemax Garden City", "Westgate Cinema", "Prestige Cinemas", "Anga Sky Cinema Panari", "Century Cinemax Junction", "Motion Cinemas", "Anga Diamond Cinema-Diamond", "Century Cinemax, Sarit", "Nyumba Cinema", "7D Cinema"})
        Me.cboTheatre.Location = New System.Drawing.Point(217, 39)
        Me.cboTheatre.Name = "cboTheatre"
        Me.cboTheatre.Size = New System.Drawing.Size(396, 37)
        Me.cboTheatre.TabIndex = 9
        '
        'lblTheatreName
        '
        Me.lblTheatreName.AutoSize = True
        Me.lblTheatreName.BackColor = System.Drawing.SystemColors.InfoText
        Me.lblTheatreName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTheatreName.Location = New System.Drawing.Point(6, 45)
        Me.lblTheatreName.Name = "lblTheatreName"
        Me.lblTheatreName.Size = New System.Drawing.Size(189, 31)
        Me.lblTheatreName.TabIndex = 0
        Me.lblTheatreName.Text = " Theatre Name"
        '
        'cmdBookNow
        '
        Me.cmdBookNow.BackColor = System.Drawing.SystemColors.Desktop
        Me.cmdBookNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBookNow.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdBookNow.Location = New System.Drawing.Point(799, 241)
        Me.cmdBookNow.Name = "cmdBookNow"
        Me.cmdBookNow.Size = New System.Drawing.Size(199, 89)
        Me.cmdBookNow.TabIndex = 11
        Me.cmdBookNow.Text = "BOOK NOW"
        Me.cmdBookNow.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1403, 732)
        Me.Controls.Add(Me.cmdBookNow)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form2"
        Me.Text = "MOVIE BOOKING FORM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblFirstNAme As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblEmailaddress As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtEmailaddress As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblSpacetype As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cboPrice As ComboBox
    Friend WithEvents cboTime As ComboBox
    Friend WithEvents cboGenre As ComboBox
    Friend WithEvents lblMovieGenre As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblTimeofScreening As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cboTheatre As ComboBox
    Friend WithEvents lblTheatreName As Label
    Friend WithEvents cmdBookNow As Button
    Friend WithEvents txtMovieName As TextBox
    Friend WithEvents lblMovieName As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents RadioRegular As RadioButton
    Friend WithEvents RadioVIP As RadioButton
    Friend WithEvents radioVVIP As RadioButton
End Class
