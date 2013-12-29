Imports System
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class clsPemblian
    Private blnReturn As Boolean

    Private strNo_Pembelian As String
    Private strKd_Suplier As String
    Private dtTanggal As Date
    Private strUserId As String

    Private strKd_barang As String
    Private intJumlah As Integer
    Private dblHrg_Beli As Decimal
    Private dblSubTotal As Decimal


    Public Property no_pembelian()
        Get
            Return strNo_Pembelian
        End Get
        Set(ByVal value)
            strNo_Pembelian = value
        End Set
    End Property

    Public Property kd_suplier()
        Get
            Return strKd_Suplier
        End Get
        Set(ByVal value)
            strKd_Suplier = value
        End Set
    End Property

    Public Property tanggal()
        Get
            Return dtTanggal
        End Get
        Set(ByVal value)
            dtTanggal = value
        End Set
    End Property

    Public Property UserId()
        Get
            Return strUserId
        End Get
        Set(ByVal value)
            strUserId = value
        End Set
    End Property

    Public Property kd_brg()
        Get
            Return strKd_barang
        End Get
        Set(ByVal value)
            strKd_barang = value
        End Set
    End Property

    Public Property jumlah()
        Get
            Return intJumlah
        End Get
        Set(ByVal value)
            intJumlah = value
        End Set
    End Property

    Public Property hrg_beli()
        Get
            Return dblHrg_Beli
        End Get
        Set(ByVal value)
            dblHrg_Beli = value
        End Set
    End Property

    Public Property subTotal()
        Get
            Return dblSubTotal
        End Get
        Set(ByVal value)
            dblSubTotal = value
        End Set
    End Property


    Public Function getData() As DataTable
        Try
            mycon = New MySqlConnection(strCon)
            objDataTable = New DataTable
            mycon.Open()
            strSql = "Select *  from tb_pembelian"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            objDataTable.Load(objReader)
            objCommand.Dispose()
            Return objDataTable
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function isSavePembelian() As Boolean
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "insert into tb_pembelian (no_pembelian, tgl_beli, kd_suplier,user_id) values ('" & Trim(no_pembelian) & "','" & tanggal & "','" & Trim(kd_suplier) & "', '" & Trim(UserId) & "')"
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

    Public Function isSavePembelianDetail() As Boolean
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "insert into tb_pembelian_Detail (no_pembelian, kd_brg, jumlah, hrg_beli, sub_total) values ('" & Trim(no_pembelian) & "','" & Trim(kd_brg) & "','" & Trim(jumlah) & "','" & Trim(hrg_beli) & "', '" & Trim(subTotal) & "')"
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


    Public Function getNo_Pembelian() As MySqlDataReader
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "select right(no_pembelian,4) as no_pembelian FROM tb_pembelian WHERE year(left(no_pembelian,8))+month(left(no_pembelian,8))=Year(getdate())+month(getdate()) order by right(no_pembelian,4) desc"
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
