Public Class Form4


    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim c As Control

        For Each c In Me.Controls
            If TypeOf (c) Is PictureBox Then
                CType(c, PictureBox).Image = My.Resources.greyer
                AddHandler c.Click, AddressOf PictureBox10_Click
            End If
        Next
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs)
        If CType(sender, PictureBox).Image Is My.Resources.blacker Then
            CType(sender, PictureBox).Image = My.Resources.blacker
        ElseIf CType(sender, PictureBox).Image Is My.Resources.redhat Then
            CType(sender, PictureBox).Image = My.Resources.redhat
        End If
    End Sub
End Class