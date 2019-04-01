Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql

Namespace LFERP.Library.MrpManager.MrpPurchaseOrder
    Public Class MrpPurchaseOrderEntryController
        Friend Function FillMrpPurchaseOrderEntry(ByVal reader As IDataReader) As MrpPurchaseOrderEntryInfo
            Dim objInfo As New MrpPurchaseOrderEntryInfo
            objInfo.AutoID = reader("AutoID")
            objInfo.PO = reader("PO").ToString
            objInfo.M_Code = reader("M_Code").ToString
            If reader("PurchaseQty") Is DBNull.Value Then
                objInfo.PurchaseQty = Nothing
            Else
                objInfo.PurchaseQty = CDbl(reader("PurchaseQty").ToString)
            End If
            If reader("NeedDate") Is DBNull.Value Then
                objInfo.NeedDate = Nothing
            Else
                objInfo.NeedDate = Format(CDate(reader("NeedDate")), "yyyy/MM/dd")
            End If
            If reader("DeliveryDate") Is DBNull.Value Then
                objInfo.DeliveryDate = Nothing
            Else
                objInfo.DeliveryDate = Format(CDate(reader("DeliveryDate")), "yyyy/MM/dd")
            End If
            If reader("UnitPrice") Is DBNull.Value Then
                objInfo.UnitPrice = Nothing
            Else
                objInfo.UnitPrice = CDbl(reader("UnitPrice").ToString)
            End If
            objInfo.Remarks = reader("Remarks").ToString
            objInfo.CreateUserID = reader("CreateUserID").ToString
            If reader("CreateDate") Is DBNull.Value Then
                objInfo.CreateDate = Nothing
            Else
                objInfo.CreateDate = Format(CDate(reader("CreateDate")), "yyyy/MM/dd")
            End If
            objInfo.ModifyUserID = reader("ModifyUserID").ToString
            If reader("ModifyDate") Is DBNull.Value Then
                objInfo.ModifyDate = Nothing
            Else
                objInfo.ModifyDate = Format(CDate(reader("ModifyDate")), "yyyy/MM/dd")
            End If
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            objInfo.Source = reader("Source").ToString
            Return objInfo
        End Function

        Public Function MrpPurchaseOrderEntry_GetList(ByVal PO As String) As List(Of MrpPurchaseOrderEntryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseOrderEntry_GetList")
            db.AddInParameter(dbComm, "@PO", DbType.String, PO)
            Dim FeatureList As New List(Of MrpPurchaseOrderEntryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMrpPurchaseOrderEntry(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function MrpPurchaseOrderEntry_Delete(ByVal AutoID As String, ByVal PO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseOrderEntry_Delete")
                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbComm, "@PO", DbType.String, PO)
                db.ExecuteNonQuery(dbComm)
                MrpPurchaseOrderEntry_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpPurchaseOrderEntry_Delete = False
            End Try
        End Function

        Public Function MrpPurchaseOrderEntry_Update(ByVal objinfo As MrpPurchaseOrderEntryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseOrderEntry_Update")
                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@PurchaseQty", DbType.Decimal, objinfo.PurchaseQty)
                If objinfo.NeedDate = Nothing Then
                    db.AddInParameter(dbComm, "@NeedDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@NeedDate", DbType.Date, objinfo.NeedDate)
                End If
                If objinfo.DeliveryDate = Nothing Then
                    db.AddInParameter(dbComm, "@DeliveryDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@DeliveryDate", DbType.Date, objinfo.NeedDate)
                End If
                db.AddInParameter(dbComm, "@UnitPrice", DbType.Decimal, objinfo.UnitPrice)
                db.AddInParameter(dbComm, "@Remarks", DbType.String, objinfo.Remarks)
                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)
                db.ExecuteNonQuery(dbComm)
                MrpPurchaseOrderEntry_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpPurchaseOrderEntry_Update = False
            End Try
        End Function

        Public Function MrpPurchaseOrderEntry_Add(ByVal objInfo As MrpPurchaseOrderEntryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseOrderEntry_Add")
                db.AddInParameter(dbComm, "@PO", DbType.String, objInfo.PO)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objInfo.M_Code)
                db.AddInParameter(dbComm, "@PurchaseQty", DbType.Decimal, objInfo.PurchaseQty)
                If objInfo.NeedDate = Nothing Then
                    db.AddInParameter(dbComm, "@NeedDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@NeedDate", DbType.Date, objInfo.NeedDate)
                End If
                If objInfo.DeliveryDate = Nothing Then
                    db.AddInParameter(dbComm, "@DeliveryDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@DeliveryDate", DbType.Date, objInfo.NeedDate)
                End If
                db.AddInParameter(dbComm, "@UnitPrice", DbType.Decimal, objInfo.UnitPrice)
                db.AddInParameter(dbComm, "@Remarks", DbType.String, objInfo.Remarks)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                db.ExecuteNonQuery(dbComm)
                MrpPurchaseOrderEntry_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpPurchaseOrderEntry_Add = False
            End Try
        End Function

        Public Function GetDeptInfo() As DataTable
            Dim ds As New DataSet
            Dim sqlStr As String = "select DPT_ID as DeptID,DPT_Name as DeptName from Department  "
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetSqlStringCommand(sqlStr)
            ds = db.ExecuteDataSet(dbcomm)
            If ds.Tables.Count > 0 Then
                Return ds.Tables(0)
            Else
                Return Nothing
            End If
        End Function
    End Class
End Namespace