Partial Class Ds_pembelian
    Partial Class ds_pembelianDataTable

        Private Sub ds_pembelianDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.hrg_beliColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
