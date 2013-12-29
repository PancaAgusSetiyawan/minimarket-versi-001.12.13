
Public Class frmLogIn1

    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
        If txtUserName.Text = "admin" And txtPass.Text = "dedisodikin" Then
            MsgBox("Selamat Datang ")
            MenuMain.Show()
            Call LogOut()
            Me.Hide()
        ElseIf txtPass.Text <> "dedisodikin" And txtUserName.Text <> "admin" Then
            MsgBox("User dan Password Salah")
        ElseIf txtUserName.Text = "admin" Then
            MsgBox("User Id Salah")
        Else
            MsgBox("Password Salah")
        End If
        txtPass.Text = ""
        txtUserName.Text = ""
    End Sub

    Private Sub txtUserName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserName.KeyPress
        txtUserName.CharacterCasing = CharacterCasing.Lower
    End Sub

    Private Sub txtPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPass.KeyPress
        txtPass.CharacterCasing = CharacterCasing.Lower
    End Sub

    Private Sub frmLogIn1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPass.Text = ""
        txtUserName.Text = ""
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        txtPass.Text = ""
        txtUserName.Text = ""
    End Sub
End Class
