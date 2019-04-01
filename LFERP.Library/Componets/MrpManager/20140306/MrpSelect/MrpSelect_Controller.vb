Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Imports LFERP.Library.MrpManager.MrpMaterialCode
Imports LFERP.Library.MrpManager.MrpWareHouseInfo
Imports LFERP.Library.MrpManager.MrpForecastOrder
Imports LFERP.Library.MrpManager.Bom_M
Imports LFERP.Library.MrpManager.MrpInfo
Namespace LFERP.Library.MrpManager.MrpSelect
    Public Class MrpSelect_Controller
        '琩高絪絏
        Friend Function FillMrpMaterialCode(ByVal reader As IDataReader) As MrpMaterialCodeInfo
            On Error Resume Next
            Dim objInfo As New MrpMaterialCodeInfo
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            If reader("MC_BatchQty") Is DBNull.Value Then
                objInfo.MC_BatchQty = Nothing
            Else
                objInfo.MC_BatchQty = CDbl(reader("MC_BatchQty").ToString)
            End If
            If reader("MC_BatFixEconomy") Is DBNull.Value Then
                objInfo.MC_BatFixEconomy = Nothing
            Else
                objInfo.MC_BatFixEconomy = CDbl(reader("MC_BatFixEconomy").ToString)
            End If
            objInfo.MC_OrderInterVal = reader("MC_OrderInterVal").ToString
            objInfo.MC_OrderMan = reader("MC_OrderMan").ToString
            If reader("MC_QtyMax") Is DBNull.Value Then
                objInfo.MC_QtyMax = Nothing
            Else
                objInfo.MC_QtyMax = CDbl(reader("MC_QtyMax").ToString)
            End If
            If reader("MC_QtyMin") Is DBNull.Value Then
                objInfo.MC_QtyMin = Nothing
            Else
                objInfo.MC_QtyMin = CDbl(reader("MC_QtyMin").ToString)
            End If
            If reader("MC_LowLimit") Is DBNull.Value Then
                objInfo.MC_LowLimit = Nothing
            Else
                objInfo.MC_LowLimit = CDbl(reader("MC_LowLimit").ToString)
            End If
            If reader("MC_SecInv") Is DBNull.Value Then
                objInfo.MC_SecInv = Nothing
            Else
                objInfo.MC_SecInv = CDbl(reader("MC_SecInv").ToString)
            End If
            objInfo.MC_Source = reader("MC_Source").ToString
            If reader("MC_MRPCon") Is DBNull.Value Then
                objInfo.MC_MRPCon = Nothing
            Else
                objInfo.MC_MRPCon = reader("MC_MRPCon")
            End If
            objInfo.MC_WH_ID = reader("MC_WH_ID").ToString
            objInfo.CheckUserID = reader("CheckUserName").ToString
            If reader("CheckBit") Is DBNull.Value Then
                objInfo.CheckBit = Nothing
            Else
                objInfo.CheckBit = reader("CheckBit")
            End If
            objInfo.CheckRemark = reader("CheckRemark").ToString
            objInfo.CreateUserID = reader("CreateUserName").ToString
            If reader("CreateDate") Is DBNull.Value Then
                objInfo.CreateDate = Nothing
            Else
                objInfo.CreateDate = CStr(reader("CreateDate"))
            End If
            objInfo.ModifyUserID = reader("ModifyUserName").ToString
            If reader("ModifyDate") Is DBNull.Value Then
                objInfo.ModifyDate = Nothing
            Else
                objInfo.ModifyDate = CStr(reader("ModifyDate"))
            End If
            objInfo.AutoID = reader("AutoID")
            Return objInfo
        End Function
        Public Function MrpMaterialCode_Select_GetList(ByVal MrpModule As String, ByVal strWhere As String) As List(Of MrpMaterialCodeInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpSelect_GetList")
            db.AddInParameter(dbComm, "@MrpModule", DbType.String, MrpModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)
            Dim FeatureList As New List(Of MrpMaterialCodeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMrpMaterialCode(reader))
                End While
                Return FeatureList
            End Using
        End Function
        '-----------------------------------------------------------------------------------------------
        '琩高畐獺
        Friend Function FillMrpWareHouseInfo(ByVal reader As IDataReader) As MrpWareHouseInfoInfo
            On Error Resume Next
            Dim objInfo As New MrpWareHouseInfoInfo
            objInfo.Ware_ID = reader("Ware_ID").ToString
            objInfo.MRP_ID = reader("MRP_ID").ToString
            If reader("MD_ISMrp") Is DBNull.Value Then
                objInfo.MD_ISMrp = Nothing
            Else
                objInfo.MD_ISMrp = reader("MD_ISMrp")
            End If
            If reader("MD_RecordCreateDate") Is DBNull.Value Then
                objInfo.MD_RecordCreateDate = Nothing
            Else
                objInfo.MD_RecordCreateDate = Format(CDate(reader("MD_RecordCreateDate")), "yyyy/MM/dd")
            End If
            If reader("CheckUserID") Is DBNull.Value Then
                objInfo.CheckUserID = Nothing
            Else
                objInfo.CheckUserID = CStr(reader("CheckUserName").ToString)
            End If
            If reader("CheckBit") Is DBNull.Value Then
                objInfo.CheckBit = Nothing
            Else
                objInfo.CheckBit = reader("CheckBit")
            End If
            objInfo.CheckRemark = reader("CheckRemark").ToString
            objInfo.CreateUserID = reader("CreateUserName").ToString
            If reader("CreateDate") Is DBNull.Value Then
                objInfo.CreateDate = Nothing
            Else
                objInfo.CreateDate = Format(CDate(reader("CreateDate")), "yyyy/MM/dd")
            End If
            objInfo.ModifyUserID = reader("ModifyUserName").ToString
            If reader("ModifyDate") Is DBNull.Value Then
                objInfo.ModifyDate = Nothing
            Else
                objInfo.ModifyDate = Format(CDate(reader("ModifyDate")), "yyyy/MM/dd")
            End If
            objInfo.AutoID = reader("AutoID").ToString
            Return objInfo
        End Function
        Public Function MrpWareHouseInfo_Select_GetList(ByVal MrpModule As String, ByVal strWhere As String) As List(Of MrpWareHouseInfoInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpSelect_GetList")
            db.AddInParameter(dbComm, "@MrpModule", DbType.String, MrpModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)
            Dim FeatureList As New List(Of MrpWareHouseInfoInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMrpWareHouseInfo(reader))
                End While
                Return FeatureList
            End Using
        End Function
        '--------------------------------------------------------------------------------------
        '琩高箇代虫腹
        Friend Function FillMrpForecastOrder(ByVal reader As IDataReader) As MrpForecastOrderInfo
            On Error Resume Next
            Dim objInfo As New MrpForecastOrderInfo
            objInfo.ForecastID = reader("ForecastID").ToString
            If IsDBNull(reader("MO_ForecastDate")) = True Then
                objInfo.MO_ForecastDate = Nothing
            Else
                objInfo.MO_ForecastDate = Format(reader("MO_ForecastDate"), "yyyy/MM/dd")
            End If
            objInfo.MO_Status = reader("MO_Status").ToString
            objInfo.MO_Cancellation = reader("MO_Cancellation").ToString
            objInfo.OrderInterID = reader("OrderInterID").ToString
            objInfo.MO_PlanType = reader("MO_PlanType").ToString
            objInfo.CheckUserID = reader("CheckUserID").ToString
            If IsDBNull(reader("CheckBit")) = True Then
                objInfo.CheckBit = False
            Else
                objInfo.CheckBit = reader("CheckBit")
            End If
            objInfo.CheckRemark = reader("CheckRemark").ToString
            objInfo.CreateUserID = reader("CreateUserID").ToString
            If IsDBNull(reader("CreateDate")) = True Then
                objInfo.CreateDate = Nothing
            Else
                objInfo.CreateDate = Format(reader("CreateDate"), "yyyy/MM/dd")
            End If
            objInfo.ModifyUserID = reader("ModifyUserID").ToString
            If IsDBNull(reader("ModifyDate")) = True Then
                objInfo.ModifyDate = Nothing
            Else
                objInfo.ModifyDate = Format(reader("ModifyDate"), "yyyy/MM/dd")
            End If
            objInfo.AutoID = reader("AutoID")
            objInfo.CheckUserName = reader("CheckUserName").ToString
            objInfo.CreateUserName = reader("CreateUserName").ToString
            objInfo.ModifyUserName = reader("ModifyUserName").ToString
            objInfo.MO_CusterID = reader("MO_CusterID").ToString
            objInfo.MO_CusterName = reader("MO_CusterName").ToString
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            objInfo.M_Source = reader("M_Source").ToString
            Return objInfo
        End Function

        Public Function MrpForecastOrder_Select_GetList(ByVal MrpModule As String, ByVal strWhere As String) As List(Of MrpForecastOrderInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpSelect_GetList")
            db.AddInParameter(dbComm, "@MrpModule", DbType.String, MrpModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)
            Dim FeatureList As New List(Of MrpForecastOrderInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMrpForecastOrder(reader))
                End While
                Return FeatureList
            End Using
        End Function
        '----------------------------------------------------------------------------------
        '琩高玻珇挡篶
        Friend Function FillBom_M(ByVal reader As IDataReader) As Bom_MInfo
            On Error Resume Next
            Dim objInfo As New Bom_MInfo
            objInfo.AutoID = reader("AutoID").ToString
            objInfo.ParentGroup = reader("ParentGroup").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.SourceID = reader("SourceID").ToString
            objInfo.M_Source = reader("M_Source").ToString
            If IsDBNull(reader("CheckDate")) = True Then
                objInfo.CheckDate = Nothing
            Else
                objInfo.CheckDate = Format(reader("CheckDate"), "yyyy/MM/dd")
            End If
            objInfo.M_Unit = reader("M_Unit").ToString
            If IsDBNull(reader("EffectiveDate")) = True Then
                objInfo.EffectiveDate = Nothing
            Else
                objInfo.EffectiveDate = Format(reader("EffectiveDate"), "yyyy/MM/dd")
            End If
            If IsDBNull(reader("InvalidDate")) = True Then
                objInfo.InvalidDate = Nothing
            Else
                objInfo.InvalidDate = Format(reader("InvalidDate"), "yyyy/MM/dd")
            End If
            objInfo.Version = reader("Version").ToString
            objInfo.CheckUserID = reader("CheckUserID").ToString

            objInfo.CreateUserName = reader("CreateUserName").ToString
            objInfo.CheckUserName = reader("CheckUserName").ToString

            objInfo.CheckBit = reader("CheckBit")
            objInfo.CheckRemark = reader("CheckRemark").ToString
            objInfo.CreateUserID = reader("CreateUserID").ToString
            If IsDBNull(reader("CreateDate")) = True Then
                objInfo.CreateDate = Nothing
            Else
                objInfo.CreateDate = Format(reader("CreateDate"), "yyyy/MM/dd")
            End If
            objInfo.ModifyUserID = reader("ModifyUserID").ToString
            If IsDBNull(reader("ModifyDate")) = True Then
                objInfo.ModifyDate = Nothing
            Else
                objInfo.ModifyDate = Format(reader("ModifyDate"), "yyyy/MM/dd")
            End If
            Return objInfo
        End Function
        Public Function MrpBom_M_Select_GetList(ByVal MrpModule As String, ByVal strWhere As String) As List(Of Bom_MInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpSelect_GetList")
            db.AddInParameter(dbComm, "@MrpModule", DbType.String, MrpModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)
            Dim FeatureList As New List(Of Bom_MInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillBom_M(reader))
                End While
                Return FeatureList
            End Using
        End Function
        '----------------------------------------------------------------------------------
        '琩高笲衡癘魁
        Friend Function FillMrpInfo(ByVal reader As IDataReader) As MRPInfoInfo
            On Error Resume Next
            Dim objInfo As New MRPInfoInfo
            objInfo.MRP_ID = reader("MRP_ID").ToString
            If reader("MI_MRPDate") Is DBNull.Value Then
                objInfo.MI_MRPDate = Nothing
            Else
                objInfo.MI_MRPDate = Format(CDate(reader("MI_MRPDate")), "yyyy/MM/dd")
            End If
            objInfo.MI_LogTxt = reader("MI_LogTxt").ToString
            If reader("MI_NeedBeginDate") Is DBNull.Value Then
                objInfo.MI_NeedBeginDate = Nothing
            Else
                objInfo.MI_NeedBeginDate = Format(CDate(reader("MI_NeedBeginDate")), "yyyy/MM/dd")
            End If
            If reader("MI_NeedEndDate") Is DBNull.Value Then
                objInfo.MI_NeedEndDate = Nothing
            Else
                objInfo.MI_NeedEndDate = Format(CDate(reader("MI_NeedEndDate")), "yyyy/MM/dd")
            End If
            objInfo.MI_MRPType = reader("MI_MRPType").ToString
            objInfo.MI_CheckUserID = reader("MI_CheckUserID").ToString
            If reader("MI_CheckBit") Is DBNull.Value Then
                objInfo.MI_CheckBit = Nothing
            Else
                objInfo.MI_CheckBit = reader("MI_CheckBit")
            End If
            If reader("MI_CheckDate") Is DBNull.Value Then
                objInfo.MI_CheckDate = Nothing
            Else
                objInfo.MI_CheckDate = Format(CDate(reader("MI_CheckDate")), "yyyy/MM/dd")
            End If
            objInfo.MI_CheckRemark = reader("MI_CheckRemark").ToString
            objInfo.MI_CreateUserID = reader("MI_CreateUserID").ToString
            If reader("MI_CreateDate") Is DBNull.Value Then
                objInfo.MI_CreateDate = Nothing
            Else
                objInfo.MI_CreateDate = Format(CDate(reader("MI_CreateDate")), "yyyy/MM/dd")
            End If
            objInfo.MI_ModifyUserID = reader("MI_ModifyUserID").ToString
            If reader("MI_ModifyDate") Is DBNull.Value Then
                objInfo.MI_ModifyDate = Nothing
            Else
                objInfo.MI_ModifyDate = Format(CDate(reader("MI_ModifyDate")), "yyyy/MM/dd")
            End If
            objInfo.MI_CreateUserName = reader("MI_CreateUserName").ToString
            objInfo.MI_CheckUserName = reader("MI_CheckUserName").ToString
            Return objInfo
        End Function

        Public Function MrpInfo_Select_GetList(ByVal MrpModule As String, ByVal strWhere As String) As List(Of MRPInfoInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpSelect_GetList")
            db.AddInParameter(dbComm, "@MrpModule", DbType.String, MrpModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)
            Dim FeatureList As New List(Of MRPInfoInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMrpInfo(reader))
                End While
                Return FeatureList
            End Using
        End Function
    End Class
End Namespace
