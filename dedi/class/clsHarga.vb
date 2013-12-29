Imports System
Imports MySql.Data.MySqlClient

Public Class clsHarga
    Public blnReturn As Boolean

    Private strKd_brg As String
    Private decHrg_Beli_Satuan As Decimal
    Private decHrg_Jual_Satuan As Decimal
    Private intStok As Integer
    Private intDiskon As Integer
    Private strNm_brg As String 'unt query join ke tb_brg

    Public Property kd_brg()
        Get
            Return strKd_brg
        End Get
        Set(ByVal value)
            strKd_brg = value
        End Set
    End Property

    Public Property Stok()
        Get
            Return intStok
        End Get
        Set(ByVal value)
            intStok = value
        End Set
    End Property

    Public Property DIskon()
        Get
            Return intDiskon
        End Get
        Set(ByVal value)
            intDiskon = value
        End Set
    End Property

    Public Property hrg_jual_satuan()
        Get
            Return decHrg_Jual_Satuan
        End Get
        Set(ByVal value)
            decHrg_Jual_Satuan = value
        End Set
    End Property

    Public Property hrg_beli_satuan()
        Get
            Return decHrg_Beli_Satuan
        End Get
        Set(ByVal value)
            decHrg_Beli_Satuan = value
        End Set
    End Property

    Public Function getData() As DataTable
        Try
            mycon = New MySqlConnection(strCon)
            objDataTable = New DataTable
            mycon.Open()
            strSql = "Select H.kd_brg, B.nm_brg, H.stok, H.hrg_beli_satuan, H.hrg_jual_satuan, H.diskon FROM tb_harga H INNER JOIN tb_Barang B ON H.kd_brg = B.kd_brg"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            objDataTable.Load(objReader)
            objCommand.Dispose()
            objReader.Close()
            Return objDataTable
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Return Nothing
    End Function

    Public Function getDataPOS() As MySqlDataReader
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "select hrg_jual_satuan, diskon FROM tb_harga where kd_brg = '" & kd_brg & "'"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            objCommand.Dispose()
            Return objReader
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Return Nothing
    End Function

    Public Function getDataStok() As MySqlDataReader
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "SELECT stok FROM tb_harga where kd_brg = '" & kd_brg & "'"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            objCommand.Dispose()
            Return objReader
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Return Nothing
    End Function

    Public Function isExist() As Boolean
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "Select kd_brg from tb_harga where kd_brg = '" & kd_brg & "'"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            If objReader.HasRows Then
                objReader.Read()
                blnReturn = True
            Else
                blnReturn = False
            End If
            objCommand.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            mycon.Clone()
            objReader.Close()
            objReader = Nothing
            mycon = Nothing
        End Try
        Return blnReturn
    End Function

    Public Function isSave() As Boolean
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "insert into tb_harga (kd_brg, stok, hrg_beli_satuan, hrg_jual_satuan) values ('" & Trim(kd_brg) & "','" & Trim(Stok) & "','" & Trim(hrg_beli_satuan) & "','" & Trim(hrg_jual_satuan) & "')"
            objCommand = New MySqlCommand(strSql, mycon)
            If objCommand.ExecuteNonQuery Then
                blnReturn = True
            Else
                blnReturn = False
            End If
            objCommand.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            mycon.Clone()
            'objReader.Close()
            objReader = Nothing
            mycon = Nothing
        End Try
        Return blnReturn
    End Function

    Public Function isUpdateHarga() As Boolean
        Try 'LWAT PEMBELIAN
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "update tb_harga set stok = '" & Trim(Stok) & "'," & _
                                        "hrg_beli_satuan = '" & Trim(hrg_beli_satuan) & "'," & _
                                        "hrg_jual_satuan = '" & Trim(hrg_jual_satuan) & "'," & _
                                        "Diskon = '" & Trim(DIskon) & "'" & _
                                        "where kd_brg = '" & Trim(kd_brg) & "'"
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
            objCommand.Dispose()
            objCommand = Nothing
            mycon = Nothing
        End Try
        Return blnReturn
    End Function

    Public Function isUpdateStok() As Boolean
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "UPDATE tb_harga SET stok = '" & Trim(Stok) & "' WHERE kd_brg = '" & kd_brg & "'"
            objCommand = New MySqlCommand(strSql, mycon)
            If objCommand.ExecuteNonQuery Then
                blnReturn = True
            Else
                blnReturn = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            ' Finally
            mycon.Close()
            mycon = Nothing
            objCommand.Dispose()
            objCommand = Nothing
        End Try
        Return blnReturn
    End Function
End Class
