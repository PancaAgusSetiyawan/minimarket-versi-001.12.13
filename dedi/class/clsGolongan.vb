
Imports MySql.Data.MySqlClient

Public Class clsGolongan
    Private blnReturn As Boolean
    Private strKd_Gol As String
    Private strGolongan As String
    Private strKeterangan As String

    Public Property Kd_Gol()
        Get
            Return strKd_Gol
        End Get
        Set(ByVal value)
            strKd_Gol = value
        End Set
    End Property

    Public Property Golongan()
        Get
            Return strGolongan
        End Get
        Set(ByVal value)
            strGolongan = value
        End Set
    End Property

    Public Property Keterangan()
        Get
            Return strKeterangan
        End Get
        Set(ByVal value)
            strKeterangan = value
        End Set
    End Property

    Public Function getData() As DataTable
        Try
            mycon = New MySqlConnection(strCon)
            objDataTable = New DataTable
            mycon.Open()
            strSql = "select kd_gol, golongan, keterangan from tb_golongan"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader
            objDataTable.Load(objReader)
            Return objDataTable
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            objCommand.Dispose()
            objCommand = Nothing
        End Try
        Return Nothing
    End Function

    Public Function isExist() As Boolean
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = " select kd_gol from tb_golongan where kd_gol = '" & Kd_Gol & "'"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            If objReader.HasRows Then
                objReader.Read()
                blnReturn = True
            Else
                blnReturn = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            mycon.Close()
            mycon = Nothing
            objCommand.Dispose()
            objCommand = Nothing
        End Try
        Return blnReturn
    End Function

    Public Function isSave() As Boolean
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = " insert into tb_golongan (kd_gol, golongan, keterangan) values ('" & Trim(Kd_Gol) & "', '" & Trim(Golongan) & "','" & Trim(Keterangan) & "')"
            objCommand = New MySqlCommand(strSql, mycon)
            If objCommand.ExecuteNonQuery Then
                blnReturn = True
            Else
                blnReturn = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            mycon.Close()
            mycon = Nothing
            objCommand.Dispose()
            objCommand = Nothing
        End Try
        Return blnReturn
    End Function

    Public Function isDelete() As Boolean
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "delete from tb_golongan where kd_gol = '" & Kd_Gol & "'"
            objCommand = New MySqlCommand(strSql, mycon)
            If objCommand.ExecuteNonQuery Then
                blnReturn = True
            Else
                blnReturn = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            mycon.Close()
            mycon = Nothing
            objCommand.Dispose()
            objCommand = Nothing
        End Try
        Return blnReturn
    End Function

    Public Function isUpdate() As Boolean
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "Update tb_golongan set golongan = '" & Trim(Golongan) & "', Keterangan = '" & Trim(Keterangan) & "' where kd_gol = '" & Trim(Kd_Gol) & "'"
            objCommand = New MySqlCommand(strSql, mycon)
            If objCommand.ExecuteNonQuery Then
                blnReturn = True
            Else
                blnReturn = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            mycon.Close()
            mycon = Nothing
            objCommand.Dispose()
            objCommand = Nothing
        End Try
        Return blnReturn
    End Function

    Public Function getKd_Gol() As DataTable
        Try
            mycon = New MySqlConnection(strCon)
            objDataTable = New DataTable
            mycon.Open()
            strSql = "Select kd_gol from tb_golongan where kd_gol LIKE  '%" & Kd_Gol & "%'"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            objDataTable.Load(objReader)
            Return objDataTable
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            mycon.Close()
            objCommand.Dispose()
            mycon = Nothing
            objCommand = Nothing
        End Try
        Return Nothing
    End Function

    Public Function getGol() As DataTable
        Try
            mycon = New MySqlConnection(strCon)
            objDataTable = New DataTable
            mycon.Open()
            strSql = "Select golongan from tb_golongan where golongan LIKE  '%" & Golongan & "%'"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            objDataTable.Load(objReader)
            Return objDataTable
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            mycon.Close()
            objCommand.Dispose()
            mycon = Nothing
            objCommand = Nothing
        End Try
        Return Nothing
    End Function

End Class
