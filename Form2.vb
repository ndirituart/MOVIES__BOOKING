Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Public Class Form2

    Dim conString As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim cmd As OleDbCommand

    Private Sub ConDB()
        conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\clive\source\repos\MOVIES__BOOKING\Final.mdb"
        myconnection.ConnectionString = conString
        myconnection.Open()
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged
        txtFirstName.CharacterCasing = CharacterCasing.Upper
        txtFirstName.MaxLength = 20
    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        txtLastName.CharacterCasing = CharacterCasing.Upper
        txtLastName.MaxLength = 20

    End Sub

    Private Sub txtEmailaddress_TextChanged(sender As Object, e As EventArgs) Handles txtEmailaddress.TextChanged

    End Sub


    Private Sub txtAge_TextChanged(sender As Object, e As EventArgs) Handles txtAge.TextChanged
        If Convert.ToInt32(txtAge.Text) < 18 Then
            With cboGenre.Items()
                .Clear()
                .Add("Education")
                .Add("Animation")
                .Add("Short Documentaries")
                .Add("Musical")
                .Add("Sports")
            End With


        Else
            With cboGenre.Items()
                .Clear()
                .Add("Action")
                .Add("Thriller")
                .Add("Horror")
                .Add("Sci-fi")
                .Add("Romance")
                .Add("Comedy")
                .Add("Life")
                .Add("Musical")
                .Add("Sports")

            End With
        End If

    End Sub

    Private Sub txtMovieName_TextChanged(sender As Object, e As EventArgs) Handles txtMovieName.TextChanged
        txtMovieName.CharacterCasing = CharacterCasing.Upper
        txtMovieName.MaxLength = 20
    End Sub


    Private Sub cmdBookNow_Click(sender As Object, e As EventArgs) Handles cmdBookNow.Click
        'Email address format that is required
        Dim regex As Regex = New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
        Dim isValid As Boolean = regex.IsMatch(txtEmailaddress.Text.Trim)
        'Required fields (Cannot be skipped)
        If Not isValid Then
            MessageBox.Show("Invalid email format entered.Please try again")
        End If
        If String.IsNullOrEmpty(txtFirstName.Text.Trim) Then
            MessageBox.Show("Warning! Please input your First Name")
        End If

        If String.IsNullOrEmpty(txtLastName.Text.Trim) Then
            MessageBox.Show("Warning! Please input your Last Name")
        End If

        If String.IsNullOrEmpty(txtMovieName.Text.Trim) Then
            MessageBox.Show("Warning The movie name is required!!")
        End If
        'Age restriction

        If txtAge.Text < 18 Then
            MsgBox("YOU WILL BE RESTRICTED TO SOME OF OUR CONTENT", MsgBoxStyle.Critical)
        End If


        Try
            Call ConDB()
            command = "INSERT into Movie([First_Name],[Last_Name],[Email_address],[Age],[Movie_Name],[Movie_Genre],[Price],[Theatre_Name],[Time_of_Screening]) VALUES('" & txtFirstName.Text & "','" & txtLastName.Text & "','" & txtEmailaddress.Text & "','" & txtAge.Text & "','" & txtMovieName.Text & "','" & cboGenre.Text & "','" & cboPrice.Text & "','" & cboTheatre.Text & "','" & cboTime.Text & "')"

            Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)




            Dim i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("Your details have been successfully received")
            Else
                MsgBox("Something went wrong!")
            End If
            cmd.Dispose()
            myconnection.Close()
            txtFirstName.Clear()
            txtLastName.Clear()
            txtEmailaddress.Clear()
            txtAge.Clear()
            txtMovieName.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Form4.Show()
        Me.Hide()
    End Sub


    Private Sub radioVVIP_CheckedChanged(sender As Object, e As EventArgs) Handles radioVVIP.CheckedChanged
        If radioVVIP.Checked Then
            With cboPrice.Items()
                .Clear()
                .Add("3000")
                .Add("3500")
                .Add("4000")
                .Add("5000")
            End With
        End If
    End Sub

    Private Sub RadioVIP_CheckedChanged(sender As Object, e As EventArgs) Handles RadioVIP.CheckedChanged
        If RadioVIP.Checked Then
            With cboPrice.Items()
                .Clear()
                .Add("2000")
                .Add("2500")
                .Add("1000")
            End With
        End If
    End Sub

    Private Sub RadioRegular_CheckedChanged(sender As Object, e As EventArgs) Handles RadioRegular.CheckedChanged
        If RadioRegular.Checked Then
            With cboPrice.Items()
                .Clear()
                .Add("700")
                .Add("900")
                .Add("500")
            End With
        End If

    End Sub

    Private Sub cboTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTime.SelectedIndexChanged

    End Sub

    Private Sub cboPrice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPrice.SelectedIndexChanged

    End Sub
End Class
