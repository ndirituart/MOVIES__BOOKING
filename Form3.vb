Imports System.Data.OleDb
'Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\clive\source\repos\MOVIES__BOOKING\Final.mdb
Public Class Form3

    Dim conString As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim cmd As OleDbCommand

    Private Sub ConDB()
        conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\clive\source\repos\MOVIES__BOOKING\Final.mdb"
        myconnection.ConnectionString = conString
        myconnection.Open()
    End Sub


    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        txtName.CharacterCasing = CharacterCasing.Upper
        txtName.MaxLength = 16
    End Sub

    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged
        txtUserName.CharacterCasing = CharacterCasing.Upper
        txtUserName.MaxLength = 16
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        txtPassword.MaxLength = 16
    End Sub

    Private Sub txtConfirm_TextChanged(sender As Object, e As EventArgs) Handles txtConfirm.TextChanged
        txtConfirm.MaxLength = 16
        If (txtPassword.Text = txtConfirm.Text) Then
            Labelconfirm.Text = "Matched"
        Else
            Labelconfirm.Text = "Not Matched"
        End If
    End Sub



    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If txtPassword.Text = txtConfirm.Text Then

            Labelconfirm.Text = "Matched"


            Call ConDB()
            command = "INSERT into Login([Name],[User_Name],[Password]) VALUES('" & txtName.Text & "','" & txtUserName.Text & "','" & txtConfirm.Text & "')"
            Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
            cmd.Parameters.Add(New OleDbParameter("Name", CType(txtName.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("User_Name", CType(txtUserName.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Password", CType(txtConfirm.Text, String)))
            MsgBox("Your details have been successfully received")
            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                myconnection.Close()
                txtName.Clear()
                txtUserName.Clear()
                txtPassword.Clear()
                txtConfirm.Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            Labelconfirm.Text = "Not Matched"
            MsgBox("Your passwords are conflicting", MsgBoxStyle.Critical)

        End If
    End Sub

    Private Sub txtUserName_LostFocus(sender As Object, e As EventArgs) Handles txtUserName.LostFocus
        txtUserName.BackColor = Color.White
    End Sub

    Private Sub txtUserName_GotFocus(sender As Object, e As EventArgs) Handles txtUserName.GotFocus
        txtUserName.BackColor = Color.LightGray
    End Sub

    Private Sub txtName_LostFocus(sender As Object, e As EventArgs) Handles txtName.LostFocus
        txtName.BackColor = Color.White
    End Sub

    Private Sub txtName_GotFocus(sender As Object, e As EventArgs) Handles txtName.GotFocus
        txtName.BackColor = Color.LightGray
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        txtPassword.BackColor = Color.White
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        txtPassword.BackColor = Color.White
    End Sub

    Private Sub txtConfirm_LostFocus(sender As Object, e As EventArgs) Handles txtConfirm.LostFocus
        txtConfirm.BackColor = Color.LightGray
    End Sub

    Private Sub txtConfirm_GotFocus(sender As Object, e As EventArgs) Handles txtConfirm.GotFocus
        txtPassword.BackColor = Color.LightGray
    End Sub

    Private Sub checkshow_CheckedChanged(sender As Object, e As EventArgs) Handles checkshow.CheckedChanged
        If checkshow.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub checkshow2_CheckedChanged(sender As Object, e As EventArgs) Handles checkshow2.CheckedChanged
        If checkshow2.Checked Then
            txtConfirm.UseSystemPasswordChar = False
        Else
            txtConfirm.UseSystemPasswordChar = True

        End If
    End Sub


End Class