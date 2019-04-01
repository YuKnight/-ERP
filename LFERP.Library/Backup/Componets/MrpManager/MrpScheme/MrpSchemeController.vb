Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Namespace LFERP.Library.MrpManager.MrpScheme
    Public Class MRPSchemeController
        Friend Function FillMrpScheme(ByVal reader As IDataReader) As MrpSchemeInfo
            On Error Resume Next
            Dim objInfo As New MrpSchemeInfo

            objInfo.AutoID = reader("AutoID").ToString
            objInfo.CreateUserID = reader("CreateUserID").ToString
            objInfo.CreateUserName = reader("CreateUserName").ToString
            objInfo.CreateDate = reader("CreateDate")
            objInfo.ModifyUserID = reader("ModifyUserID").ToString
            objInfo.ModifyUserName = reader("ModifyUserName").ToString
            objInfo.ModifyDate = reader("ModifyDate")

            objInfo.SchemeID = reader("SchemeID").ToString
            objInfo.SchemeDesc = reader("SchemeDesc").ToString
            objInfo.SysDefault = reader("SysDefault")
            objInfo.CalculateRange = reader("CalculateRange")
            objInfo.BitSalesOrder = reader("BitSalesOrder")
            objInfo.BitProductForecast = reader("BitProductForecast")
            objInfo.BitSalesUnaudited = reader("BitSalesUnaudited")
            objInfo.BitProductUnaudited = reader("BitProductUnaudited")
            objInfo.BitLossRate = reader("BitLossRate")
            objInfo.BitProductRate = reader("BitProductRate")
            objInfo.BitDemandQty = reader("BitDemandQty")
            objInfo.BitTempQty = reader("BitTempQty")
            objInfo.BitSecurityStockQty = reader("BitSecurityStockQty")
            objInfo.BitStockQty = reader("BitStockQty")
            objInfo.BitPurchaseQty = reader("BitPurchaseQty")
            objInfo.BitInWayQty = reader("BitInWayQty")
            objInfo.BitSubStitateQty = reader("BitSubStitateQty")
            objInfo.BitAssignQty = reader("BitAssignQty")
            objInfo.ValidMonth = reader("ValidMonth")
            objInfo.BitSubDetails = reader("BitSubDetails")
            objInfo.BitSubRelation = reader("BitSubRelation")
            objInfo.BitSalesMerger = reader("BitSalesMerger")
            objInfo.SalesMergerValue = reader("SalesMergerValue")
            objInfo.BitForecastMerger = reader("BitForecastMerger")
            objInfo.ForecastMergerValue = reader("ForecastMergerValue")
            objInfo.BitDemandMerger = reader("BitDemandMerger")
            objInfo.BitPutInPlan = reader("BitPutInPlan")
            objInfo.PurchEmtryNumber = reader("PurchEmtryNumber")
            objInfo.CarrentDateDays = reader("CarrentDateDays")
            objInfo.ProduceStatus = reader("ProduceStatus")
            objInfo.PurchaseStatus = reader("PurchaseStatus")
            objInfo.GroupPrinciple = reader("GroupPrinciple")
            objInfo.OrderPrinciple = reader("OrderPrinciple")

            objInfo.BitLowestBomCode = reader("BitLowestBomCode")
            objInfo.ShowType = reader("ShowType")
            objInfo.ComputeType = reader("ComputeType")

            Return objInfo

        End Function


        Public Function MrpScheme_GetList(ByVal SchemeID As String) As List(Of MrpSchemeInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpScheme_GetList")
            db.AddInParameter(dbComm, "@SchemeID", DbType.String, SchemeID)

            Dim FeatureList As New List(Of MrpSchemeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMrpScheme(reader))
                End While
                Return FeatureList
            End Using
        End Function


        Public Function MrpScheme_Delete(ByVal SchemeID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpScheme_Delete")
                db.AddInParameter(dbComm, "@SchemeID", DbType.String, SchemeID)
                db.ExecuteNonQuery(dbComm)
                MrpScheme_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpScheme_Delete = False
            End Try
        End Function


        Public Function MrpScheme_Update(ByVal objinfo As MrpSchemeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpScheme_Update")

                db.AddInParameter(dbComm, "@SchemeID", DbType.String, objinfo.SchemeID)
                db.AddInParameter(dbComm, "@SchemeDesc", DbType.String, objinfo.SchemeDesc)
                db.AddInParameter(dbComm, "@SysDefault", DbType.Boolean, objinfo.SysDefault)
                db.AddInParameter(dbComm, "@CalculateRange", DbType.Boolean, objinfo.CalculateRange)
                db.AddInParameter(dbComm, "@BitSalesOrder", DbType.Boolean, objinfo.BitSalesOrder)
                db.AddInParameter(dbComm, "@BitProductForecast", DbType.Boolean, objinfo.BitProductForecast)
                db.AddInParameter(dbComm, "@BitSalesUnaudited", DbType.Boolean, objinfo.BitSalesUnaudited)
                db.AddInParameter(dbComm, "@BitProductUnaudited", DbType.Boolean, objinfo.BitProductUnaudited)
                db.AddInParameter(dbComm, "@BitLossRate", DbType.Boolean, objinfo.BitLossRate)
                db.AddInParameter(dbComm, "@BitProductRate", DbType.Boolean, objinfo.BitProductRate)
                db.AddInParameter(dbComm, "@BitDemandQty", DbType.Boolean, objinfo.BitDemandQty)
                db.AddInParameter(dbComm, "@BitTempQty", DbType.Boolean, objinfo.BitTempQty)
                db.AddInParameter(dbComm, "@BitSecurityStockQty", DbType.Boolean, objinfo.BitSecurityStockQty)
                db.AddInParameter(dbComm, "@BitStockQty", DbType.Boolean, objinfo.BitStockQty)
                db.AddInParameter(dbComm, "@BitPurchaseQty", DbType.Boolean, objinfo.BitPurchaseQty)
                db.AddInParameter(dbComm, "@BitInWayQty", DbType.Boolean, objinfo.BitInWayQty)
                db.AddInParameter(dbComm, "@BitSubStitateQty", DbType.Boolean, objinfo.BitSubStitateQty)
                db.AddInParameter(dbComm, "@BitAssignQty", DbType.Boolean, objinfo.BitAssignQty)
                db.AddInParameter(dbComm, "@ValidMonth", DbType.Int16, objinfo.ValidMonth)
                db.AddInParameter(dbComm, "@BitSubDetails", DbType.Boolean, objinfo.BitSubDetails)
                db.AddInParameter(dbComm, "@BitSubRelation", DbType.Boolean, objinfo.BitSubRelation)
                db.AddInParameter(dbComm, "@BitSalesMerger", DbType.Boolean, objinfo.BitSalesMerger)
                db.AddInParameter(dbComm, "@SalesMergerValue", DbType.Int16, objinfo.SalesMergerValue)
                db.AddInParameter(dbComm, "@BitForecastMerger", DbType.Boolean, objinfo.BitForecastMerger)
                db.AddInParameter(dbComm, "@ForecastMergerValue", DbType.Int16, objinfo.ForecastMergerValue)
                db.AddInParameter(dbComm, "@BitDemandMerger", DbType.Boolean, objinfo.BitDemandMerger)
                db.AddInParameter(dbComm, "@BitPutInPlan", DbType.Boolean, objinfo.BitPutInPlan)
                db.AddInParameter(dbComm, "@PurchEmtryNumber", DbType.Int16, objinfo.PurchEmtryNumber)
                db.AddInParameter(dbComm, "@CarrentDateDays", DbType.Int16, objinfo.CarrentDateDays)
                db.AddInParameter(dbComm, "@ProduceStatus", DbType.Int16, objinfo.ProduceStatus)
                db.AddInParameter(dbComm, "@PurchaseStatus", DbType.Int16, objinfo.PurchaseStatus)
                db.AddInParameter(dbComm, "@GroupPrinciple", DbType.Int16, objinfo.GroupPrinciple)
                db.AddInParameter(dbComm, "@OrderPrinciple", DbType.Int16, objinfo.OrderPrinciple)

                db.AddInParameter(dbComm, "@BitLowestBomCode", DbType.Boolean, objinfo.BitLowestBomCode)
                db.AddInParameter(dbComm, "@ShowType", DbType.Int16, objinfo.ShowType)
                db.AddInParameter(dbComm, "@ComputeType", DbType.Int16, objinfo.ComputeType)

                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbComm, "@ModifyDate", DbType.DateTime, objinfo.ModifyDate)

                db.ExecuteNonQuery(dbComm)
                MrpScheme_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpScheme_Update = False
            End Try
        End Function


        Public Function MrpScheme_Add(ByVal objInfo As MrpSchemeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpScheme_Add")

                db.AddInParameter(dbComm, "@SchemeID", DbType.String, objInfo.SchemeID)
                db.AddInParameter(dbComm, "@SchemeDesc", DbType.String, objInfo.SchemeDesc)
                db.AddInParameter(dbComm, "@SysDefault", DbType.Boolean, objInfo.SysDefault)
                db.AddInParameter(dbComm, "@CalculateRange", DbType.Boolean, objInfo.CalculateRange)
                db.AddInParameter(dbComm, "@BitSalesOrder", DbType.Boolean, objInfo.BitSalesOrder)
                db.AddInParameter(dbComm, "@BitProductForecast", DbType.Boolean, objInfo.BitProductForecast)
                db.AddInParameter(dbComm, "@BitSalesUnaudited", DbType.Boolean, objInfo.BitSalesUnaudited)
                db.AddInParameter(dbComm, "@BitProductUnaudited", DbType.Boolean, objInfo.BitProductUnaudited)
                db.AddInParameter(dbComm, "@BitLossRate", DbType.Boolean, objInfo.BitLossRate)
                db.AddInParameter(dbComm, "@BitProductRate", DbType.Boolean, objInfo.BitProductRate)
                db.AddInParameter(dbComm, "@BitDemandQty", DbType.Boolean, objInfo.BitDemandQty)
                db.AddInParameter(dbComm, "@BitTempQty", DbType.Boolean, objInfo.BitTempQty)
                db.AddInParameter(dbComm, "@BitSecurityStockQty", DbType.Boolean, objInfo.BitSecurityStockQty)
                db.AddInParameter(dbComm, "@BitStockQty", DbType.Boolean, objInfo.BitStockQty)
                db.AddInParameter(dbComm, "@BitPurchaseQty", DbType.Boolean, objInfo.BitPurchaseQty)
                db.AddInParameter(dbComm, "@BitInWayQty", DbType.Boolean, objInfo.BitInWayQty)
                db.AddInParameter(dbComm, "@BitSubStitateQty", DbType.Boolean, objInfo.BitSubStitateQty)
                db.AddInParameter(dbComm, "@BitAssignQty", DbType.Boolean, objInfo.BitAssignQty)
                db.AddInParameter(dbComm, "@ValidMonth", DbType.Int16, objInfo.ValidMonth)
                db.AddInParameter(dbComm, "@BitSubDetails", DbType.Boolean, objInfo.BitSubDetails)
                db.AddInParameter(dbComm, "@BitSubRelation", DbType.Boolean, objInfo.BitSubRelation)
                db.AddInParameter(dbComm, "@BitSalesMerger", DbType.Boolean, objInfo.BitSalesMerger)
                db.AddInParameter(dbComm, "@SalesMergerValue", DbType.Int16, objInfo.SalesMergerValue)
                db.AddInParameter(dbComm, "@BitForecastMerger", DbType.Boolean, objInfo.BitForecastMerger)
                db.AddInParameter(dbComm, "@ForecastMergerValue", DbType.Int16, objInfo.ForecastMergerValue)
                db.AddInParameter(dbComm, "@BitDemandMerger", DbType.Boolean, objInfo.BitDemandMerger)
                db.AddInParameter(dbComm, "@BitPutInPlan", DbType.Boolean, objInfo.BitPutInPlan)
                db.AddInParameter(dbComm, "@PurchEmtryNumber", DbType.Int16, objInfo.PurchEmtryNumber)
                db.AddInParameter(dbComm, "@CarrentDateDays", DbType.Int16, objInfo.CarrentDateDays)
                db.AddInParameter(dbComm, "@ProduceStatus", DbType.Int16, objInfo.ProduceStatus)
                db.AddInParameter(dbComm, "@PurchaseStatus", DbType.Int16, objInfo.PurchaseStatus)
                db.AddInParameter(dbComm, "@GroupPrinciple", DbType.Int16, objInfo.GroupPrinciple)
                db.AddInParameter(dbComm, "@OrderPrinciple", DbType.Int16, objInfo.OrderPrinciple)
                db.AddInParameter(dbComm, "@BitLowestBomCode", DbType.Boolean, objInfo.BitLowestBomCode)
                db.AddInParameter(dbComm, "@ShowType", DbType.Int16, objInfo.ShowType)
                db.AddInParameter(dbComm, "@ComputeType", DbType.Int16, objInfo.ComputeType)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                db.AddInParameter(dbComm, "@CreateDate", DbType.DateTime, objInfo.CreateDate)

                db.ExecuteNonQuery(dbComm)
                MrpScheme_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpScheme_Add = False
            End Try
        End Function
    End Class
End Namespace