Imports System
Imports MySql.Data.MySqlClient

Public Class clsPenjualan
    Private blnReturn As Boolean

    Private strNo_Penjualan As String
    Private dtTgl_jual As Date
    Private strUserId As String
    Private strKd_brg As String
    Private intJumlah As Integer
    Private intDiskon As Integer
    Private decHrg_jual_satuan As Decimal
    Private decSub_Total As Decimal

    Public Property No_Penjualan()
        Get
            Return strNo_Penjualan
        End Get
        Set(ByVal value)
            strNo_Penjualan = value
        End Set
    End Property

    Public Property Tgl_Jual()
        Get
            Return dtTgl_jual
        End Get
        Set(ByVal value)
            dtTgl_jual = value
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
            Return strKd_brg
        End Get
        Set(ByVal value)
            strKd_brg = value
        End Set
    End Property

    Public Property Jumlah()
        Get
            Return intJumlah
        End Get
        Set(ByVal value)
            intJumlah = value
        End Set
    End Property

    Public Property Hrg_jual_satuan()
        Get
            Return decHrg_jual_satuan
        End Get
        Set(ByVal value)
            decHrg_jual_satuan = value
        End Set
    End Property

    Public Property Diskon()
        Get
            Return intDiskon
        End Get
        Set(ByVal value)
            intDiskon = value
        End Set
    End Property

    Public Property Sub_Total()
        Get
            Return decSub_Total
        End Get
        Set(ByVal value)
            decSub_Total = value
        End Set
    End Property

    Public Function isExist() As Boolean
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "select no_penjualan FROM tb_penjualan WHERE kd_brg = '" & kd_brg & "'"
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

    Public Function isSavePenjualan() As Boolean
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "Insert into tb_penjualan (no_penjualan, tgl_jual, user_id)values ( '" & Trim(No_Penjualan) & "','" & Trim(Tgl_Jual) & "', '" & Trim(UserId) & "')"
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

    Public Function isSavePenjualanDetail()
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "Insert into tb_penjualan_detail (no_penjualan, kd_brg, jumlah, hrg_jual, diskon, sub_total) values ( '" & Trim(No_Penjualan) & "','" & Trim(kd_brg) & "','" & Trim(Jumlah) & "', '" & Trim(Hrg_jual_satuan) & "','" & Trim(Diskon) & "','" & Trim(Sub_Total) & "')"
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

    Public Function getDataByTanggal() As DataTable
        Try
            mycon = New MySqlConnection(strCon)
            objDataTable = New DataTable
            mycon.Open()
            strSql = "Select P.no_penjualan, P.tgl_jual, D.kd_brg , D.jumlah, D.sub_total FROM Tb_penjualan P INNER JOIN Tb_penjualan_Detail D On P.no_Penjualan  = D.No_penjualan  ORDER By tgl_jual = '" & Tgl_Jual & "'"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            objDataTable.Load(objReader)
            objCommand.Dispose()
            Return objDataTable
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            mycon.Close()
            mycon = Nothing
        End Try
        Return Nothing
    End Function

    Public Function getDataByNo() As DataTable
        Try
            mycon = New MySqlConnection(strCon)
            objDataTable = New DataTable
            mycon.Open()
            strSql = "Select P.no_penjualan, P.tgl_jual, D.kd_brg , D.jumlah, D.sub_total FROM Tb_penjualan P INNER JOIN Tb_penjualan_Detail D On P.no_Penjualan  = D.No_penjualan  ORDER By no_penjualan = '" & No_Penjualan & "'"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            objDataTable.Load(objReader)
            objCommand.Dispose()
            Return objDataTable
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            mycon.Close()
            mycon = Nothing
        End Try
        Return Nothing
    End Function

    'Public Function testBegin() As Boolean
    '    Dim isConError As Boolean
    '    Try
    '        mycon = New MySqlConnection(strCon)
    '        mycon.Open()
    '        mycon.BeginTransaction()

    '        isConError = True
    '        strSql = "Insert into tb_penjualan_detail (no_penjualan, kd_brg, jumlah, hrg_jual, sub_total) values ( '" & Trim(No_Penjualan) & "','" & Trim(kd_brg) & "','" & Trim(Jumlah) & "', '" & Trim(Hrg_jual_satuan) & "','" & Trim(Sub_Total) & "')"
    '        objCommand = New MySqlCommand(strSql, mycon)
    '        If objCommand.ExecuteNonQuery Then
    '            blnReturn = True
    '        Else
    '            blnReturn = False
    '        End If
    '        objCommand.Dispose()

    '        strSql = "Insert into tb_penjualan (no_penjualan, tgl_jual, user_id)values ( '" & Trim(No_Penjualan) & "','" & Trim(Tgl_Jual) & "', '" & Trim(UserId) & "')"
    '        objCommand = New MySqlCommand(strSql, mycon)
    '        If objCommand.ExecuteNonQuery Then
    '            blnReturn = True
    '        Else
    '            blnReturn = False
    '        End If
    '        objCommand.Dispose()
    '        Return blnReturn

    '        conTransaksi.Commit()
    '    Catch ex As Exception

    '    End Try
    '    Return Nothing
    'End Function
End Class
