Imports System.Data
Imports MySql.Data.MySqlClient

Public Class FrmLogIn2

    Private objUser As clsUser

    Private Sub kosong()
        txtUserName.Text = ""
        txtPass.Text = ""
        cboLevel.SelectedIndex = 0
    End Sub

    Private Sub txtLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLogIn.Click
        If txtUserName.Text = "" Then
            MsgBox("Masukkan Password anda...")
        ElseIf txtPass.Text = "" Then
            MsgBox("Masukkan User Name Anda...", MsgBoxStyle.Critical)
        ElseIf txtUserName.Text = "" Or txtPass.Text = "" Then
            MsgBox("Masukkan User name dan Password anda ....")
        Else
            objUser = New clsUser
            With objUser
                .User_id = txtUserName.Text
                .pass = txtPass.Text
                .Level1 = cboLevel.text
                If .getLogin Then
                    MsgBox("Sukses")
                    MenuMain.Show()
                    If cboLevel.Text = "Supervisor" Then
                        Call Spv()
                    ElseIf cboLevel.Text = "Admin" Then
                        Call OperatorAdmin()
                    ElseIf cboLevel.Text = "Kasir" Then
                        Call Kasir()
                    Else
                        Call LogOut()
                    End If
                    UserId_LogIn = txtUserName.Text
                    Me.Hide()
                    Call kosong()
                Else
                    MsgBox("Gagal Log In")
                End If
            End With
        End If
    End Sub

    Private Sub txtCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCancel.Click
        Call kosong()
    End Sub

    Private Sub FrmLogIn2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboLevel.SelectedIndex = 0
    End Sub

    Private Sub txtUserName_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserName.KeyPress
        ' imputan huruf awal kapital
        Dim i As Integer = txtPass.SelectionStart
        txtPass.Text = StrConv(txtPass.Text, VbStrConv.ProperCase)
        txtPass.SelectionStart = i
    End Sub
End Class