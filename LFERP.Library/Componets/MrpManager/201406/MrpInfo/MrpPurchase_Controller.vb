Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql

Namespace LFERP.Library.MrpManager.MrpInfo
    Public Class MrpPurchaseController
        Friend Function FillMrpPurchase(ByVal reader As IDataReader) As MrpPurchaseInfo
            Try
                Dim objInfo As New MrpPurchaseInfo
                objInfo.MRP_ID = reader("MRP_ID").ToString
                objInfo.M_Code = reader("M_Code").ToString
                If reader("MP_NeedQty") Is DBNull.Value Then
                    objInfo.MP_NeedQty = Nothing
                Else
                    objInfo.MP_NeedQty = CDec(reader("MP_NeedQty").ToString)
                End If
                If reader("MP_BatchQty") Is DBNull.Value Then
                    objInfo.MP_BatchQty = Nothing
                Else
                    objInfo.MP_BatchQty = CDec(reader("MP_BatchQty").ToString)
                End If
                If reader("MP_BatFixEconomy") Is DBNull.Value Then
                    objInfo.MP_BatFixEconomy = Nothing
                Else
                    objInfo.MP_BatFixEconomy = CDec(reader("MP_BatFixEconomy").ToString)
                End If
                If reader("MP_OrderMax") Is DBNull.Value Then
                    objInfo.MP_OrderMax = Nothing
                Else
                    objInfo.MP_OrderMax = CDec(reader("MP_OrderMax").ToString)
                End If
                If reader("MP_OrderMin") Is DBNull.Value Then
                    objInfo.MP_OrderMin = Nothing
                Else
                    objInfo.MP_OrderMin = CDec(reader("MP_OrderMin").ToString)
                End If
                If reader("MP_SecInv") Is DBNull.Value Then
                    objInfo.MP_SecInv = Nothing
                Else
                    objInfo.MP_SecInv = CDec(reader("MP_SecInv").ToString)
                End If
                If reader("MP_LowLimit") Is DBNull.Value Then
                    objInfo.MP_LowLimit = Nothing
                Else
                    objInfo.MP_LowLimit = CDec(reader("MP_LowLimit").ToString)
                End If
                If reader("MP_RetreatQty") Is DBNull.Value Then
                    objInfo.MP_RetreatQty = Nothing
                Else
                    objInfo.MP_RetreatQty = CDec(reader("MP_RetreatQty").ToString)
                End If
                If reader("MP_InventoryQty") Is DBNull.Value Then
                    objInfo.MP_InventoryQty = Nothing
                Else
                    objInfo.MP_InventoryQty = CDec(reader("MP_InventoryQty").ToString)
                End If
                If reader("MP_InTransitQty") Is DBNull.Value Then
                    objInfo.MP_InTransitQty = Nothing
                Else
                    objInfo.MP_InTransitQty = CDec(reader("MP_InTransitQty").ToString)
                End If
                If reader("MP_Inspection") Is DBNull.Value Then
                    objInfo.MP_Inspection = Nothing
                Else
                    objInfo.MP_Inspection = CDec(reader("MP_Inspection").ToString)
                End If
                If reader("MP_NoCollar") Is DBNull.Value Then
                    objInfo.MP_NoCollar = Nothing
                Else
                    objInfo.MP_NoCollar = CDec(reader("MP_NoCollar").ToString)
                End If
                If reader("MP_MRPQty") Is DBNull.Value Then
                    objInfo.MP_MRPQty = Nothing
                Else
                    objInfo.MP_MRPQty = CDec(reader("MP_MRPQty").ToString)
                End If
                objInfo.MP_CreateUserID = reader("MP_CreateUserID").ToString
                If reader("MP_CreateDate") Is DBNull.Value Then
                    objInfo.MP_CreateDate = Nothing
                Else
                    objInfo.MP_CreateDate = Format(CDate(reader("MP_CreateDate")), "yyyy/MM/dd")
                End If
                objInfo.MP_ModifyUserID = reader("MP_ModifyUserID").ToString
                If reader("MP_ModifyDate") Is DBNull.Value Then
                    objInfo.MP_ModifyDate = Nothing
                Else
                    objInfo.MP_ModifyDate = Format(CDate(reader("MP_ModifyDate")), "yyyy/MM/dd")
                End If
                If reader("AutoID") Is DBNull.Value Then
                    objInfo.AutoID = Nothing
                Else
                    objInfo.AutoID = CDbl(reader("AutoID").ToString)
                End If
                objInfo.M_Name = reader("M_Name").ToString
                objInfo.M_Gauge = reader("M_Gauge").ToString
                objInfo.M_Unit = reader("M_Unit").ToString
                objInfo.Source = reader("Source").ToString
                If reader("MP_RelatedQty") Is DBNull.Value Then
                    objInfo.MP_RelatedQty = Nothing
                Else
                    objInfo.MP_RelatedQty = CDec(reader("MP_RelatedQty").ToString)
                End If
                If reader("MP_NeedDate") Is DBNull.Value Then
                    objInfo.MP_NeedDate = Nothing
                Else
                    objInfo.MP_NeedDate = Format(CDate(reader("MP_NeedDate")), "yyyy/MM/dd")
                End If
                Return objInfo
            Catch ex As Exception
                If ex.GetType.Name.Equals("ThreadAbortException") = False Then
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:FillMrpPurchase方法出錯")
                End If
                Return Nothing
            End Try
        End Function

        Public Function MrpPurchase_GetList(ByVal MRP_ID As String) As List(Of MrpPurchaseInfo)
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchase_GetList")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                Dim FeatureList As New List(Of MrpPurchaseInfo)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        FeatureList.Add(FillMrpPurchase(reader))
                    End While
                    Return FeatureList
                End Using
            Catch ex As Exception
                If ex.GetType.Name.Equals("ThreadAbortException") = False Then
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:MrpPurchase_GetList方法出錯")
                End If
                Return Nothing
            End Try
        End Function


        Public Function MrpPurchase_Delete(ByVal AutoID As String, ByVal MRP_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchase_Delete")
                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                db.ExecuteNonQuery(dbComm)
                MrpPurchase_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Proc:MrpPurchase_Delete出錯")
                MrpPurchase_Delete = False
            End Try
        End Function


        Public Function MrpPurchase_Update(ByVal objinfo As MrpPurchaseInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchase_Update")
                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objinfo.MRP_ID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@MP_NeedQty", DbType.Decimal, objinfo.MP_NeedQty)
                db.AddInParameter(dbComm, "@MP_BatchQty", DbType.Decimal, objinfo.MP_BatchQty)
                db.AddInParameter(dbComm, "@MP_BatFixEconomy", DbType.Decimal, objinfo.MP_BatFixEconomy)
                db.AddInParameter(dbComm, "@MP_OrderMax", DbType.Decimal, objinfo.MP_OrderMax)
                db.AddInParameter(dbComm, "@MP_OrderMin", DbType.Decimal, objinfo.MP_OrderMin)
                db.AddInParameter(dbComm, "@MP_SecInv", DbType.Decimal, objinfo.MP_SecInv)
                db.AddInParameter(dbComm, "@MP_LowLimit", DbType.Decimal, objinfo.MP_LowLimit)
                db.AddInParameter(dbComm, "@MP_RetreatQty", DbType.Decimal, objinfo.MP_RetreatQty)
                db.AddInParameter(dbComm, "@MP_InventoryQty", DbType.Decimal, objinfo.MP_InventoryQty)
                db.AddInParameter(dbComm, "@MP_InTransitQty", DbType.Decimal, objinfo.MP_InTransitQty)
                db.AddInParameter(dbComm, "@MP_Inspection", DbType.Decimal, objinfo.MP_Inspection)
                db.AddInParameter(dbComm, "@MP_NoCollar", DbType.Decimal, objinfo.MP_NoCollar)
                db.AddInParameter(dbComm, "@MP_MRPQty", DbType.Decimal, objinfo.MP_MRPQty)
                db.AddInParameter(dbComm, "@MP_ModifyUserID", DbType.String, objinfo.MP_ModifyUserID)
                db.AddInParameter(dbComm, "@MP_RelatedQty", DbType.Decimal, objinfo.MP_RelatedQty)
                If objinfo.MP_NeedDate = Nothing Then
                    db.AddInParameter(dbComm, "@MP_NeedDate", DbType.Date, Nothing)
                Else
                    db.AddInParameter(dbComm, "@MP_NeedDate", DbType.Date, objinfo.MP_NeedDate)
                End If

                db.ExecuteNonQuery(dbComm)
                MrpPurchase_Update = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Proc:MrpPurchase_Update出錯")
                MrpPurchase_Update = False
            End Try
        End Function


        Public Function MrpPurchase_Add(ByVal objInfo As MrpPurchaseInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchase_Add")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objInfo.MRP_ID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objInfo.M_Code)
                db.AddInParameter(dbComm, "@MP_NeedQty", DbType.Decimal, objInfo.MP_NeedQty)
                db.AddInParameter(dbComm, "@MP_BatchQty", DbType.Decimal, objInfo.MP_BatchQty)
                db.AddInParameter(dbComm, "@MP_BatFixEconomy", DbType.Decimal, objInfo.MP_BatFixEconomy)
                db.AddInParameter(dbComm, "@MP_OrderMax", DbType.Decimal, objInfo.MP_OrderMax)
                db.AddInParameter(dbComm, "@MP_OrderMin", DbType.Decimal, objInfo.MP_OrderMin)
                db.AddInParameter(dbComm, "@MP_SecInv", DbType.Decimal, objInfo.MP_SecInv)
                db.AddInParameter(dbComm, "@MP_LowLimit", DbType.Decimal, objInfo.MP_LowLimit)
                db.AddInParameter(dbComm, "@MP_RetreatQty", DbType.Decimal, objInfo.MP_RetreatQty)
                db.AddInParameter(dbComm, "@MP_InventoryQty", DbType.Decimal, objInfo.MP_InventoryQty)
                db.AddInParameter(dbComm, "@MP_InTransitQty", DbType.Decimal, objInfo.MP_InTransitQty)
                db.AddInParameter(dbComm, "@MP_Inspection", DbType.Decimal, objInfo.MP_Inspection)
                db.AddInParameter(dbComm, "@MP_NoCollar", DbType.Decimal, objInfo.MP_NoCollar)
                db.AddInParameter(dbComm, "@MP_MRPQty", DbType.Decimal, objInfo.MP_MRPQty)
                db.AddInParameter(dbComm, "@MP_CreateUserID", DbType.String, objInfo.MP_CreateUserID)
                db.AddInParameter(dbComm, "@MP_RelatedQty", DbType.Decimal, objInfo.MP_RelatedQty)
                If objInfo.MP_NeedDate = Nothing Then
                    db.AddInParameter(dbComm, "@MP_NeedDate", DbType.Date, Nothing)
                Else
                    db.AddInParameter(dbComm, "@MP_NeedDate", DbType.Date, objInfo.MP_NeedDate)
                End If
                db.ExecuteNonQuery(dbComm)
                MrpPurchase_Add = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Proc:MrpPurchase_Add出錯")
                MrpPurchase_Add = False
            End Try
        End Function
    End Class
End Namespace