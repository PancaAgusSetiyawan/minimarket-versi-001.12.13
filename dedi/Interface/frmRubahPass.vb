Imports MySql.Data.MySqlClient

Public Class frmRubahPass


    Private objUser As clsUser

    Private Sub kosong()
        txtPass.Text = ""
        txtPassbaru1.Text = ""
        txtPassBaru2.Text = ""
        txtUserName.Text = ""
    End Sub

    Private Sub txtPassBaru2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassBaru2.LostFocus
        If txtPassbaru1.Text <> txtPassBaru2.Text Then
            MsgBox("Password tidak sama")
        End If
    End Sub

    Private Sub cekUserIdPass()
        objUser = New clsUser
        With objUser
            .User_id = txtUserName.Text
            .pass = txtPass.Text
            If .isUbahPassword Then
                txtPassbaru1.ReadOnly = False
                txtPassBaru2.ReadOnly = False
            Else
                MsgBox("User Id lama dan Password lama Tidak sesuai")
                txtPass.Text = ""
                txtUserName.Text = ""
                txtUserName.Focus()
            End If
        End With
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If txtPass.Text = "" Or txtPassbaru1.Text = "" Or txtPassBaru2.Text = "" Or txtUserName.Text = "" Then
            MsgBox("Masukkan User name dan password ")
        Else
            objUser = New clsUser
            With objUser
                .User_id = txtUserName.Text
                .pass = txtPassBaru2.Text
                If .isUbahPassword() Then
                    MsgBox("Password Berhasil Dirubah")
                Else
                    MsgBox("Gagal merubah Password")
                End If
            End With
        End If
    End Sub

    Private Sub txtPass_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPass.LostFocus
        Call cekUserIdPass()
    End Sub

    Private Sub frmRubahPass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call kosong()
        txtPassbaru1.ReadOnly = True
        txtPassBaru2.ReadOnly = True
    End Sub
End Class