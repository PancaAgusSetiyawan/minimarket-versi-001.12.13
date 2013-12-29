Imports System
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class clsSuplier
    Private blnReturn As Boolean

    Private strKd_Suplier As String
    Private strNm_Suplier As String
    Private strAlamat As String
    Private strKota As String
    Private strTelp As String
    Private strEmail As String


    Public Property kd_suplier()
        Get
            Return strKd_Suplier
        End Get
        Set(ByVal value)
            strKd_Suplier = value
        End Set
    End Property

    Public Property nm_suplier()
        Get
            Return strNm_Suplier
        End Get
        Set(ByVal value)
            strNm_Suplier = value
        End Set
    End Property

    Public Property alamat()
        Get
            Return strAlamat
        End Get
        Set(ByVal value)
            strAlamat = value
        End Set
    End Property

    Public Property kota()
        Get
            Return strKota
        End Get
        Set(ByVal value)
            strKota = value
        End Set
    End Property

    Public Property telp()
        Get
            Return strTelp
        End Get
        Set(ByVal value)
            strTelp = value
        End Set
    End Property

    Public Property email()
        Get
            Return strEmail
        End Get
        Set(ByVal value)
            strEmail = value
        End Set
    End Property

    Public Function GetData() As DataTable
        Try
            mycon = New MySqlConnection(strCon)
            objDataTable = New DataTable
            mycon.Open()
            strSql = "select * from tb_suplier"
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

    Public Function GetKOdeSuplier() As DataTable
        Try
            mycon = New MySqlConnection(strCon)
            objDataTable = New DataTable
            mycon.Open()
            strSql = "select * from tb_suplier where kd_suplier like '%" & kd_suplier & "%'"
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

    Public Function GetNamaSuplier() As DataTable
        Try
            mycon = New MySqlConnection(strCon)
            objDataTable = New DataTable
            mycon.Open()
            strSql = "select * from tb_suplier where nm_suplier like '%" & nm_suplier & "%'"
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

    Public Function GetKotaSuplier() As DataTable
        Try
            mycon = New MySqlConnection(strCon)
            objDataTable = New DataTable
            mycon.Open()
            strSql = "select * from tb_suplier where kota like '%" & kota & "%'"
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
            strSql = "select kd_suplier  from tb_suplier where kd_suplier = '" & kd_suplier & "'"
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
            strSql = "insert into tb_suplier (kd_suplier, nm_suplier, alamat, kota, telp, email) values ('" & Trim(kd_suplier) & "','" & Trim(nm_suplier) & "', '" & Trim(alamat) & "','" & Trim(kota) & "','" & Trim(telp) & "','" & Trim(email) & "')"
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
            strSql = "delete from tb_suplier where kd_suplier = '" & kd_suplier & "'"
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
            strSql = "Update tb_suplier set nm_suplier = '" & nm_suplier & "'," & _
                                            "alamat ='" & alamat & "'," & _
                                            "kota = '" & kota & "'," & _
                                            "telp = '" & Trim(telp) & "'," & _
                                            "email = '" & Trim(email) & "'" & _
                                            "where kd_suplier ='" & kd_suplier & "'"
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

    Public Function getAutoSuplier() As MySqlDataReader
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "select nm_suplier,alamat from tb_suplier where kd_suplier = '" & kd_suplier & "'"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            objCommand.Dispose()
            Return objReader
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message.ToString)
        End Try
    End Function
End Class
