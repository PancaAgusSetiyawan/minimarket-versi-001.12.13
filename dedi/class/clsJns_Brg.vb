Imports System
Imports System.Data
Imports MySql.Data.MySqlClient


Public Class clsJns_Brg
    Private strKd_Jenis As String
    Private strJenis As String
    Private blnReturn As Boolean

    Public Property Kd_Jenis()
        Get
            Return strKd_Jenis
        End Get
        Set(ByVal value)
            strKd_Jenis = value
        End Set
    End Property

    Public Property jenis()
        Get
            Return strJenis
        End Get
        Set(ByVal value)
            strJenis = value
        End Set
    End Property

    Public Function GetData() As DataTable
        Try
            mycon = New MySqlConnection(strCon)
            objDataTable = New DataTable
            mycon.Open()
            strSql = "select * from tb_jns_brg"
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

    Public Function getKode() As DataTable
        Try
            mycon = New MySqlConnection(strCon)
            objDataTable = New DataTable
            mycon.Open()
            strSql = "select *  from tb_jns_brg where kd_jns_brg like '%" & Kd_Jenis & "%'"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            objDataTable.Load(objReader)
            objCommand.Dispose()
            objReader.Close()
            Return objDataTable
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return Nothing
        End Try
    End Function

    Public Function getJenis() As DataTable
        Try
            mycon = New MySqlConnection(strCon)
            objDataTable = New DataTable
            mycon.Open()
            strSql = "select *  from tb_jns_brg where jns_brg like '%" & jenis & "%'"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            objDataTable.Load(objReader)
            objCommand.Dispose()
            objReader.Close()
            Return objDataTable
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return Nothing
        End Try
        mycon.Close()
    End Function


    'Public Function getList() As Boolean
    '    Try
    '        mycon = New MySqlConnection(strCon)
    '        mycon.Open()
    '        strSql = "Select kd_jns_brg, jns_brg from tb_jns_brg"
    '        objCommand = New MySqlCommand(strSql, mycon)
    '        objReader = objCommand.ExecuteReader(CommandBehavior.Default)
    '        If objReader.HasRows Then
    '            blnReturn = True
    '        Else
    '            blnReturn = False
    '        End If
    '    Catch ex As Exception
    '        blnReturn = False
    '        MsgBox(ex.Message.ToString)
    '    Finally
    '        mycon.Close()
    '        objCommand.Dispose()
    '        mycon = Nothing
    '        objCommand = Nothing
    '    End Try
    '    Return blnReturn
    'End Function

    Public Function isGetKode() As MySqlDataReader
        Try 'unt mendapatkan kode jenis pada form barang
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "select kd_jns_brg  from tb_jns_brg where jns_brg = '" & jenis & "'"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            Return objReader
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            '            mycon.Close()
            objCommand.Dispose()
            '            mycon = Nothing
            objCommand = Nothing
        End Try
        Return Nothing
    End Function

    Public Function isExist() As Boolean
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "select kd_jns_brg  from tb_jns_brg where kd_jns_brg = '" & Kd_Jenis & "'"
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
            strSql = "insert into tb_jns_brg (kd_jns_brg, jns_brg) values ('" & Kd_Jenis & "','" & jenis & "')"
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
            strSql = "delete from tb_jns_brg where kd_jns_brg = '" & Kd_Jenis & "'"
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
            strSql = "Update tb_jns_brg set jns_brg = '" & jenis & "' where kd_jns_brg ='" & Kd_Jenis & "'"
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

    'membuat isi cbo sesuai database
    Public Function PopulateList()
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "SELECT kd_jns_brg, Jns_brg FROM tb_jns_brg"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            objCommand.Dispose()
            Return objReader
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return Nothing
        End Try
    End Function


End Class
