Imports System.Data.OleDb
Imports System.Data

Public Class Form1

    Dim connection As New OleDbConnection(My.Settings.FinalConnectionString)
    Dim pro As String
    Dim conString As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim da As New OleDbDataAdapter
    Dim con As New OleDbConnection
    Dim dt As New DataTable
    Dim dr As OleDbDataReader
    Dim Qry As String
    ' Dim C As New conection
    Dim cmd As OleDbCommand
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Form3.Show()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        txtName.CharacterCasing = CharacterCasing.Upper
        txtName.MaxLength = 12

    End Sub

    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged
        txtName.MaxLength = 16
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        If txtName.Text Is Nothing Or txtPassword.Text Is Nothing Then
            MsgBox("Enter credentials in detail before proceeding", MsgBoxStyle.Exclamation)
        Else
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim cmd As New OleDbCommand("select count(*) from Login where Name=? and User_Name=? and Password=?", connection)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtName.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = txtUserName.Text
            cmd.Parameters.AddWithValue("@3", OleDbType.VarChar).Value = txtPassword.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                MsgBox("Login successful!!", MsgBoxStyle.Information)
                Form2.Show()
            Else
                MsgBox("Account not found!Please Sign up", MsgBoxStyle.Critical)
            End If

        End If

        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub txtName_LostFocus(sender As Object, e As EventArgs) Handles txtName.LostFocus
        txtName.BackColor = Color.White
    End Sub

    Private Sub txtName_GotFocus(sender As Object, e As EventArgs) Handles txtName.GotFocus
        txtName.BackColor = Color.LightGreen
    End Sub

    Private Sub txtUserName_LostFocus(sender As Object, e As EventArgs) Handles txtUserName.LostFocus
        txtUserName.BackColor = Color.White
    End Sub

    Private Sub txtUserName_GotFocus(sender As Object, e As EventArgs) Handles txtUserName.GotFocus
        txtUserName.BackColor = Color.LightGreen
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        txtPassword.BackColor = Color.White
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        txtPassword.BackColor = Color.LightGreen
    End Sub

    Private Sub checkpassword_CheckedChanged(sender As Object, e As EventArgs) Handles checkpassword.CheckedChanged
        If checkpassword.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class