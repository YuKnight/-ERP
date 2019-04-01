Imports System.Windows.Forms

Namespace LFERP.Library.WareHouse.WareInventory
    Public Class CurrentStockSelect
        Public Function GetCurrentStock(ByVal IsDetail As Boolean, ByVal WHIDs As String, ByVal M_Code As String, ByVal Type3ID As String) As DataTable
            Dim ds As New DataSet
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("CurrentStockSelect")
            db.AddInParameter(dbComm, "@IsDetail", DbType.Boolean, IsDetail)
            db.AddInParameter(dbComm, "@WHIDs", DbType.String, WHIDs)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@Type3ID", DbType.String, Type3ID)
            ds = db.ExecuteDataSet(dbComm)
            If ds.Tables.Count > 0 Then
                Return ds.Tables(0)
            Else
                Return Nothing
            End If
        End Function
    End Class
End Namespace