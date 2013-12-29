Imports System
Imports System.Data
Imports MySql.Data.MySqlClient

Module mdlMain
    Public strCon As String = "Server=localhost;User id=root;Database=db_dedi"
    '"Provider=Microsoft.Jet.sql.4.0;Data Source=\Parkir\SisPeTang\Db_Piutang.mdb"
    Public blnReturn As Boolean
    Public strSql As String
    Public mycon As MySqlConnection
    Public objReader As MySqlDataReader
    Public objAdapter As MySqlDataAdapter
    Public objDataTable As DataTable
    Public objCommand As MySqlCommand
    Public objDataSet As DataSet
    Public objDataRow As DataRow


    ' membuat warna zebra pada datagridview
    Public Sub djieChangeColorGrid(ByVal pDataGridView As DataGridView)
        For Each iRow As DataGridViewRow In pDataGridView.Rows
            For Each iCell As DataGridViewCell In iRow.Cells
                If iRow.Index Mod 2 = 0 Then
                    iCell.Style.BackColor = Color.AliceBlue
                Else
                    iCell.Style.BackColor = Color.LightBlue
                End If
            Next
        Next
    End Sub

End Module
