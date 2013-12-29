Imports System
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class clsUser

    Private blnReturn As Boolean
    Private strUser_id As String
    Private strUser_name As String
    Private strPass As String
    Private strLevel As String

    Public Property User_id()
        Get
            Return strUser_id
        End Get
        Set(ByVal value)
            strUser_id = value
        End Set
    End Property

    Public Property User_name()
        Get
            Return strUser_name
        End Get
        Set(ByVal value)
            strUser_name = value
        End Set
    End Property

    Public Property pass()
        Get
            Return strPass
        End Get
        Set(ByVal value)
            strPass = value
        End Set
    End Property


    Public Property Level1()
        Get
            Return strLevel
        End Get
        Set(ByVal value)
            strLevel = value
        End Set
    End Property

    Public Function GetData() As DataTable
        Try
            mycon = New MySqlConnection(strCon)
            objDataTable = New DataTable
            mycon.Open()
            strSql = "select * from tb_user"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            objDataTable.Load(objReader)
            objCommand.Dispose()
            objReader.Close()
            Return objDataTable
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function isExist() As Boolean
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "select user_id  from tb_user where user_id = '" & User_id & "'"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            If objReader.HasRows Then
                blnReturn = True
            Else
                blnReturn = False
            End If
        Catch ex As Exception
            blnReturn = False
            MsgBox(ex.Message.ToString)
        Finally
            mycon.Close()
            objCommand.Dispose()
            mycon = Nothing
            objCommand = Nothing
        End Try
        Return blnReturn
    End Function

    Public Function isSave() As Boolean
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "insert into tb_user (user_id, nm_user, pass, level1) values ('" & Trim(User_id) & "','" & Trim(User_name) & "', '" & Trim(pass) & "', '" & Trim(Level1) & "')"
            objCommand = New MySqlCommand(strSql, mycon)
            If objCommand.ExecuteNonQuery Then
                blnReturn = True
            Else
                blnReturn = False
            End If
        Catch ex As Exception
            blnReturn = False
            MsgBox(ex.Message.ToString)
        Finally
            mycon.Close()
            objCommand.Dispose()
            mycon = Nothing
            objCommand = Nothing
        End Try
        Return blnReturn
    End Function

    Public Function isDelete() As Boolean
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "delete from tb_user where user_id= '" & User_id & "'"
            objCommand = New MySqlCommand(strSql, mycon)
            If objCommand.ExecuteNonQuery Then
                blnReturn = True
            Else
                blnReturn = False
            End If
        Catch ex As Exception
            blnReturn = False
            objCommand.Dispose()
            mycon = Nothing
            objCommand = Nothing
        End Try
        Return blnReturn
    End Function

    Public Function isUpdate() As Boolean
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "Update tb_user set nm_user= '" & Trim(User_name) & "', pass ='" & Trim(pass) & "', level1 = '" & Trim(Level1) & "' where user_id ='" & Trim(User_id) & "'"
            objCommand = New MySqlCommand(strSql, mycon)
            If objCommand.ExecuteNonQuery Then
                blnReturn = True
            Else
                blnReturn = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            blnReturn = False
            objCommand.Dispose()
            objCommand = Nothing
            mycon = Nothing
        End Try
        Return blnReturn
    End Function

    Public Function getLogin() As Boolean
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "select user_id, pass , level1 from tb_user where user_id = '" & User_id & "' and pass = '" & pass & "' and level1 = '" & Level1 & "'"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            If objReader.HasRows Then
                blnReturn = True
            Else
                blnReturn = False
            End If
        Catch ex As Exception
            blnReturn = False
            MsgBox(ex.Message.ToString)
        Finally
            mycon.Close()
            objCommand.Dispose()
            mycon = Nothing
            objCommand = Nothing
        End Try
        Return blnReturn
    End Function

    Public Function isUbahPassword() As Boolean
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "Update tb_user set pass ='" & pass & "' where user_id ='" & User_id & "'"
            objCommand = New MySqlCommand(strSql, mycon)
            If objCommand.ExecuteNonQuery Then
                blnReturn = True
            Else
                blnReturn = False
            End If
        Catch ex As Exception
            blnReturn = False
            objCommand.Dispose()
            objCommand = Nothing
            mycon = Nothing
        End Try
        Return blnReturn
    End Function
End Class
