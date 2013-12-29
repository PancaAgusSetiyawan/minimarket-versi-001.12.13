Imports System.Data
Imports MySql.Data.MySqlClient

Public Class clsBarang
    Private strKd_brg As String
    Private strNm_brg As String
    Private strJenis As String
    Private strWarna As String
    Private strModel As String
    Private strSatuan As String
    Private intStok As Integer 'unt join ke tb_harga

    Private blnReturn As Boolean

    Public Property stok()
        Get
            Return intStok
        End Get
        Set(ByVal value)
            intStok = value
        End Set
    End Property

    Public Property kd_brg()
        Get
            Return strKd_brg
        End Get
        Set(ByVal value)
            strKd_brg = value
        End Set
    End Property

    Public Property nm_brg()
        Get
            Return strNm_brg
        End Get
        Set(ByVal value)
            strNm_brg = value
        End Set
    End Property

    Public Property Jenis()
        Get
            Return strJenis
        End Get
        Set(ByVal value)
            strJenis = value
        End Set
    End Property

    Public Property warna()
        Get
            Return strWarna
        End Get
        Set(ByVal value)
            strWarna = value
        End Set
    End Property

    Public Property model()
        Get
            Return strModel
        End Get
        Set(ByVal value)
            strModel = value
        End Set
    End Property

    Public Property satuan()
        Get
            Return strSatuan
        End Get
        Set(ByVal value)
            strSatuan = value
        End Set
    End Property

    Public Function getData() As DataTable
        Try
            mycon = New MySqlConnection(strCon)
            objDataTable = New DataTable
            mycon.Open()
            strSql = "select * from tb_barang"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader
            objDataTable.Load(objReader)
            objCommand.Dispose()
            objReader.Close()
            Return objDataTable
        Catch ex As Exception
            Return Nothing
            'MsgBox(ex.Message.ToString)
        End Try
    End Function

    Public Function isExist() As Boolean
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "Select kd_brg from tb_barang where kd_brg = '" & kd_brg & "'"
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
            strSql = "Delete from tb_barang where kd_brg = '" & kd_brg & "'"
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
            strSql = "insert into tb_barang (kd_brg, nm_brg, jns_brg, model, warna, satuan) values ('" & Trim(kd_brg) & "', '" & Trim(nm_brg) & "', '" & Trim(Jenis) & "','" & Trim(model) & "','" & Trim(warna) & "','" & Trim(satuan) & "')"
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
            strSql = "update tb_barang set nm_brg = '" & nm_brg & "'," & _
                                            "jns_brg = '" & Jenis & "'," & _
                                            "model = '" & model & "'," & _
                                            "warna = '" & warna & "'," & _
                                            "satuan = '" & satuan & "'" & _
                                            "where kd_brg = '" & kd_brg & "'"
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
            mycon = Nothing
            objCommand.Dispose()
            objCommand = Nothing
        End Try
        Return blnReturn
    End Function

    Public Function getDataJoin() As DataTable
        Try
            mycon = New MySqlConnection(strCon)
            objDataTable = New DataTable
            mycon.Open()
            strSql = "SELECT B.kd_brg, B.nm_brg, B.satuan, B.jns_brg, B.model, B.warna,  h.stok FROM tb_barang B LEFT JOIN tb_harga H ON B.kd_brg = H.Kd_brg"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            objDataTable.Load(objReader)
            objCommand.Dispose()
            Return objDataTable
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Return Nothing
    End Function

    Public Function getAutoBrg() As MySqlDataReader
        Try ' membuat auto pada pembelian dan  pos(kasir)
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "Select kd_brg, nm_brg, satuan from tb_barang where kd_brg = '" & kd_brg & "'"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            objCommand.Dispose()
            Return objReader
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return Nothing
        End Try
    End Function

    Public Function getKode() As DataTable
        Try ' membuat auto pencarian data d dlm tabel
            mycon = New MySqlConnection(strCon)
            objDataTable = New DataTable
            mycon.Open()
            strSql = "SELECT B.kd_brg, B.nm_brg, B.satuan, B.jns_brg, B.model, B.warna, h.stok FROM tb_barang B LEFT JOIN tb_harga H ON B.kd_brg = H.Kd_brg WHERE B.kd_brg  like '%" & kd_brg & "%'"
            '            strSql = "Select * from tb_barang where kd_brg  like '%" & kd_brg & "%'"
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

    Public Function getNmBarang() As DataTable
        Try ' membuat auto pencarian data d dlm tabel
            mycon = New MySqlConnection(strCon)
            objDataTable = New DataTable
            mycon.Open()
            strSql = "SELECT B.kd_brg, B.nm_brg, B.satuan, B.jns_brg, B.model, B.warna, h.stok FROM tb_barang B LEFT JOIN tb_harga H ON B.kd_brg = H.Kd_brg WHERE B.nM_BRG  like '%" & nm_brg & "%'"
            '            strSql = "Select * from tb_barang where nm_brg  like '%" & nm_brg & "%'"
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

    Public Function getJenisBrg() As DataTable
        Try ' membuat auto pencarian data d dlm tabel
            mycon = New MySqlConnection(strCon)
            objDataTable = New DataTable
            mycon.Open()
            strSql = "SELECT B.kd_brg, B.nm_brg, B.satuan, B.jns_brg, B.model, B.warna, h.stok FROM tb_barang B LEFT JOIN tb_harga H ON B.kd_brg = H.Kd_brg WHERE B.JNS_BRG  like '%" & Jenis & "%'"
            '            strSql = "Select * from tb_barang where jns_brg  like '%" & Jenis & "%'"
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

End Class
