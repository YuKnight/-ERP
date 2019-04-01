Imports System.data.Sql
Imports System.Data.SqlClient
Imports System.Data.Common
Namespace LFERP.Library.KnifeWare
    Public Class KnifeWareSelectController

        Public Function WareInput_Getlist(ByVal WareModule As String, ByVal strWhere As String) As List(Of KnifeWareInputInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeWare_Select")

            db.AddInParameter(dbComm, "@WareModule", DbType.String, WareModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)

            Dim FeatureList As New List(Of KnifeWareInputInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInput(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function WareOut_Getlist(ByVal WareModule As String, ByVal strWhere As String) As List(Of KnifeWareOutInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeWare_Select")

            db.AddInParameter(dbComm, "@WareModule", DbType.String, WareModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)

            Dim FeatureList As New List(Of KnifeWareOutInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareOut(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function WareMove_Getlist(ByVal WareModule As String, ByVal strWhere As String) As List(Of KnifeWareMoveInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeWare_Select")

            db.AddInParameter(dbComm, "@WareModule", DbType.String, WareModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)

            Dim FeatureList As New List(Of KnifeWareMoveInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareMove(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function WareBorrow_Getlist(ByVal WareModule As String, ByVal strWhere As String) As List(Of KnifeBorrowInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeWare_Select")

            db.AddInParameter(dbComm, "@WareModule", DbType.String, WareModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)

            Dim FeatureList As New List(Of KnifeBorrowInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillKnifeBorrow(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function WareReturn_Getlist(ByVal WareModule As String, ByVal strWhere As String) As List(Of KnifeReturnInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeWare_Select")

            db.AddInParameter(dbComm, "@WareModule", DbType.String, WareModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)

            Dim FeatureList As New List(Of KnifeReturnInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillKnifeReturn(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function KnifeWareInventorySub_GetList(ByVal WareModule As String, ByVal strWhere As String) As List(Of KnifeWareInventorySubInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeWare_Select")

            db.AddInParameter(dbComm, "@WareModule", DbType.String, WareModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)

            Dim FeatureList As New List(Of KnifeWareInventorySubInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillKnifeWareInventorySub(reader))
                End While
                Return FeatureList
            End Using

        End Function

    

        Public Function FillKnifeBorrow(ByVal reader As IDataReader) As KnifeBorrowInfo
            Dim ai As New KnifeBorrowInfo

            On Error Resume Next

            If reader("AutoID") Is DBNull.Value Then
                ai.AutoID = Nothing
            Else
                ai.AutoID = reader("AutoID").ToString     '自動編號ID
            End If

            If reader("B_Num") Is DBNull.Value Then
                ai.B_Num = Nothing
            Else
                ai.B_Num = reader("B_Num").ToString     '借刀流水號
            End If

            If reader("B_NO") Is DBNull.Value Then
                ai.B_NO = Nothing
            Else
                ai.B_NO = reader("B_NO").ToString     '借刀單號
            End If

            If reader("M_Code") Is DBNull.Value Then
                ai.M_Code = Nothing
            Else
                ai.M_Code = reader("M_Code").ToString     '刀具編碼
            End If

            If reader("WH_ID") Is DBNull.Value Then
                ai.WH_ID = Nothing
            Else
                ai.WH_ID = reader("WH_ID").ToString     '倉庫代號
            End If

            If reader("BPer_ID") Is DBNull.Value Then
                ai.BPer_ID = Nothing
            Else
                ai.BPer_ID = reader("BPer_ID").ToString     '借刀人
            End If

            If reader("BPer_Name") Is DBNull.Value Then
                ai.BPer_Name = Nothing
            Else
                ai.BPer_Name = reader("BPer_Name").ToString     '借刀姓名
            End If

            If reader("B_Qty") Is DBNull.Value Then
                ai.B_Qty = 0
            Else
                ai.B_Qty = reader("B_Qty")     '借刀數
            End If

            If reader("R_Qty") Is DBNull.Value Then
                ai.R_Qty = 0
            Else
                ai.R_Qty = reader("R_Qty")     '還刀數
            End If

            If reader("B_Date") Is DBNull.Value Then
                ai.B_Date = Nothing
            Else
                ai.B_Date = Format(CDate(reader("B_Date").ToString), "yyyy/MM/dd")     '借刀日期
            End If

            If reader("R_Date") Is DBNull.Value Then
                ai.R_Date = Nothing
            Else
                ai.R_Date = reader("R_Date").ToString     '還刀日期
            End If

            If reader("B_Action") Is DBNull.Value Then
                ai.B_Action = Nothing
            Else
                ai.B_Action = reader("B_Action").ToString     '操作員
            End If

            If reader("B_Remark") Is DBNull.Value Then
                ai.B_Remark = Nothing
            Else
                ai.B_Remark = reader("B_Remark").ToString     '備注
            End If

            If reader("G_NO") Is DBNull.Value Then
                ai.G_NO = Nothing
            Else
                ai.G_NO = reader("G_NO").ToString     '組別編號
            End If

            If reader("B_Type") Is DBNull.Value Then
                ai.B_Type = Nothing
            Else
                ai.B_Type = reader("B_Type").ToString     '發刀屬性
            End If

            If reader("M_Name") Is DBNull.Value Then
                ai.M_Name = Nothing
            Else
                ai.M_Name = reader("M_Name").ToString     '刀具名稱---------------
            End If

            If reader("WH_Name") Is DBNull.Value Then
                ai.WH_Name = Nothing
            Else
                ai.WH_Name = reader("WH_Name").ToString     '倉庫名稱
            End If

            If reader("WH_PName") Is DBNull.Value Then
                ai.WH_PName = Nothing
            Else
                ai.WH_PName = reader("WH_PName").ToString     '父倉庫名稱
            End If

            If reader("B_ActionName") Is DBNull.Value Then
                ai.B_ActionName = Nothing
            Else
                ai.B_ActionName = reader("B_ActionName").ToString     '操作員名稱
            End If

            If reader("G_Name") Is DBNull.Value Then
                ai.G_Name = Nothing
            Else
                ai.G_Name = reader("G_Name").ToString     '組別名稱
            End If

            ai.M_Gauge = reader("M_Gauge").ToString
            ai.NOReturn = reader("NOReturn").ToString
            ai.B_AllEndQty = reader("B_AllEndQty")

            Return ai
        End Function

        Public Function FillKnifeReturn(ByVal reader As IDataReader) As KnifeReturnInfo
            Dim ci As New KnifeReturnInfo
            '流水號
            On Error Resume Next
            ci.AutoID = reader("R_NUM").ToString

            ci.R_NUM = reader("R_NUM").ToString
            ci.R_NO = reader("R_NO").ToString
            ci.M_Code = reader("M_Code").ToString
            ci.R_Qty = reader("R_Qty")
            ci.RPer_ID = reader("RPer_ID").ToString

            ci.RPer_Name = reader("RPer_Name").ToString
            ci.RRPer_ID = reader("RRPer_ID").ToString
            ci.RRPer_Name = reader("RRPer_Name").ToString
            ci.R_Type = reader("R_Type").ToString
            ci.R_Date = reader("R_Date").ToString

            ci.RR_Mark = reader("RR_Mark").ToString
            ci.WH_ID = reader("WH_ID").ToString
            ci.R_Action = reader("R_Action").ToString

            ci.M_Name = reader("M_Name").ToString
            ci.R_ActionName = reader("R_ActionName").ToString
            ci.R_Action = reader("R_Action").ToString
            ci.WH_Name = reader("WH_Name").ToString
            ci.WH_PName = reader("WH_PName").ToString

            ''----------------------------
            ci.SumB_QTY = reader("SumB_QTY")
            ci.SumR_QTY = reader("SumR_QTY")
            ci.SumNOReturn = reader("SumNOReturn")
            ci.SumCountR_Qty = reader("SumCountR_Qty")
            ci.M_Gauge = reader("M_Gauge").ToString
            ci.R_Check = reader("R_Check")

            ci.R_EndQty = reader("R_EndQty")
            ci.R_AllEndQty = reader("R_AllEndQty")

            Return ci

        End Function

        Friend Function FillWareInput(ByVal reader As IDataReader) As KnifeWareInputInfo
            On Error Resume Next
            '對應取得的數據
            Dim objInfo As New KnifeWareInputInfo

            objInfo.WIP_NUM = reader("WIP_NUM").ToString
            objInfo.WIP_ID = reader("WIP_ID").ToString
            objInfo.WIP_Type = reader("WIP_Type").ToString
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString

            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            If reader("WIP_Qty") Is DBNull.Value Then
                objInfo.WIP_Qty = Nothing
            Else
                objInfo.WIP_Qty = CDbl(reader("WIP_Qty").ToString)
            End If

            If reader("WIP_AddDate") Is DBNull.Value Then
                objInfo.WIP_AddDate = Nothing
            Else
                objInfo.WIP_AddDate = CStr(reader("WIP_AddDate"))
            End If
            objInfo.WH_ID = reader("WH_ID").ToString
            objInfo.OS_BatchID = reader("OS_BatchID").ToString
            objInfo.WIP_Action = reader("WIP_Action").ToString
            If reader("WIP_EditDate") Is DBNull.Value Then
                objInfo.WIP_EditDate = Nothing
            Else
                objInfo.WIP_EditDate = CStr(reader("WIP_EditDate"))
            End If
            objInfo.WIP_Remark = reader("WIP_Remark").ToString
            objInfo.DPT_ID = reader("DPT_ID").ToString
            If reader("WIP_Check") Is DBNull.Value Then
                objInfo.WIP_Check = Nothing
            Else
                objInfo.WIP_Check = reader("WIP_Check")
            End If
            objInfo.WIP_CheckAction = reader("WIP_CheckAction").ToString
            If reader("WIP_CheckDate") Is DBNull.Value Then
                objInfo.WIP_CheckDate = Nothing
            Else
                objInfo.WIP_CheckDate = CStr(reader("WIP_CheckDate"))
            End If
            objInfo.WIP_CheckRemark = reader("WIP_CheckRemark").ToString

            objInfo.WIP_ActionName = reader("WIP_ActionName").ToString
            objInfo.WIP_CheckActionName = reader("WIP_CheckActionName").ToString
            objInfo.WH_Name = reader("WH_Name").ToString
            objInfo.DPT_Name = reader("DPT_Name").ToString

            If reader("GetQty") Is DBNull.Value Then
                objInfo.GetQty = Nothing
            Else
                objInfo.GetQty = CDbl(reader("GetQty").ToString)
            End If
            If reader("GetQty1") Is DBNull.Value Then
                objInfo.GetQty1 = Nothing
            Else
                objInfo.GetQty1 = CDbl(reader("GetQty1").ToString)
            End If
            If reader("WIP_ReCheck") Is DBNull.Value Then
                objInfo.WIP_ReCheck = Nothing
            Else
                objInfo.WIP_ReCheck = reader("WIP_ReCheck")
            End If
            objInfo.WIP_ReCheckAction = reader("WIP_ReCheckAction").ToString
            If reader("WIP_ReCheckDate") Is DBNull.Value Then
                objInfo.WIP_ReCheckDate = Nothing
            Else
                objInfo.WIP_ReCheckDate = CStr(reader("WIP_ReCheckDate"))
            End If
            objInfo.WIP_ReCheckRemark = reader("WIP_ReCheckRemark").ToString

            If reader("WIP_EndQty") Is DBNull.Value Then    '入庫操作后的期末結餘數
                objInfo.WIP_EndQty = 0
            Else
                objInfo.WIP_EndQty = CDbl(reader("WIP_EndQty").ToString)
            End If

            objInfo.WH_PName = reader("WH_PName").ToString
            objInfo.KnifeType = reader("KnifeType").ToString
            objInfo.WH_AllName = reader("WH_PName").ToString & "-" & reader("WH_Name").ToString
            Return objInfo
        End Function

        Friend Function FillWareOut(ByVal reader As IDataReader) As KnifeWareOutInfo
            On Error Resume Next
            '對應取得的數據
            Dim objInfo As New KnifeWareOutInfo

            objInfo.SumHKD = reader("SumHKD")
            objInfo.HKDRate = reader("HKDRate")
            objInfo.WO_NUM = reader("WO_NUM").ToString
            objInfo.WO_ID = reader("WO_ID").ToString
            objInfo.WO_Type = reader("WO_Type").ToString
            objInfo.AP_NO = reader("AP_NO").ToString
            objInfo.OP_NO = reader("OP_NO").ToString
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            objInfo.KnifeType = reader("KnifeType").ToString
            objInfo.WH_ID = reader("WH_ID").ToString
            objInfo.OS_BatchID = reader("OS_BatchID").ToString
            objInfo.WO_Action = reader("WO_Action").ToString
            objInfo.WO_Remark = reader("WO_Remark").ToString
            objInfo.DPT_ID = reader("DPT_ID").ToString
            objInfo.WO_PerID = reader("WO_PerID").ToString
            objInfo.WO_PerName = reader("WO_PerName").ToString
            objInfo.WO_CheckAction = reader("WO_CheckAction").ToString
            objInfo.WO_CheckRemark = reader("WO_CheckRemark").ToString
            objInfo.WO_ReCheckAction = reader("WO_ReCheckAction").ToString
            objInfo.WO_ReCheckRemark = reader("WO_ReCheckRemark").ToString
            objInfo.WO_ActionName = reader("WO_ActionName").ToString
            objInfo.WO_CheckActionName = reader("WO_CheckActionName").ToString
            objInfo.WH_Name = reader("WH_Name").ToString
            objInfo.WH_PName = reader("WH_PName").ToString
            objInfo.DPT_Name = reader("DPT_PName").ToString & "-" & reader("DPT_Name").ToString
            objInfo.DPT_PName = reader("DPT_PName").ToString
            objInfo.M_ID = reader("M_ID").ToString
            objInfo.Temp_Code = reader("Temp_Code").ToString
            objInfo.strDate = CStr(reader("strDate").ToString)
            objInfo.TypeAllName = reader("Type1Name") & "-" & reader("Type2Name") & "-" & reader("Type3Name")
            objInfo.M_Currency = CStr(reader("M_Currency").ToString)
            objInfo.M_ID = reader("M_ID").ToString
            objInfo.Temp_Code = reader("Temp_Code").ToStringobjInfo.WH_AllName = reader("WH_PName").ToString & "-" & reader("WH_Name").ToString

            If reader("M_Price") Is DBNull.Value Then
                objInfo.M_Price = Nothing
            Else
                objInfo.M_Price = FormatNumber(CDbl(reader("M_Price")), 4, TriState.True)
            End If

            If reader("WO_Qty") Is DBNull.Value Then
                objInfo.WO_Qty = Nothing
            Else
                objInfo.WO_Qty = CDbl(reader("WO_Qty").ToString)
            End If

            If reader("WO_AddDate") Is DBNull.Value Then
                objInfo.WO_AddDate = Nothing
            Else
                objInfo.WO_AddDate = CStr(reader("WO_AddDate"))
            End If

            If reader("WO_EditDate") Is DBNull.Value Then
                objInfo.WO_EditDate = Nothing
            Else
                objInfo.WO_EditDate = CStr(reader("WO_EditDate"))
            End If

            If reader("WO_Check") Is DBNull.Value Then
                objInfo.WO_Check = Nothing
            Else
                objInfo.WO_Check = reader("WO_Check")
            End If

            If reader("WO_CheckDate") Is DBNull.Value Then
                objInfo.WO_CheckDate = Nothing
            Else
                objInfo.WO_CheckDate = CStr(reader("WO_CheckDate"))
            End If

            If reader("WO_ReCheck") Is DBNull.Value Then
                objInfo.WO_ReCheck = Nothing
            Else
                objInfo.WO_ReCheck = reader("WO_ReCheck")
            End If

            If reader("WO_ReCheckDate") Is DBNull.Value Then
                objInfo.WO_ReCheckDate = Nothing
            Else
                objInfo.WO_ReCheckDate = CStr(reader("WO_ReCheckDate"))
            End If

            If reader("OutGetQty") Is DBNull.Value Then
                objInfo.OutGetQty = Nothing
            Else
                objInfo.OutGetQty = CDbl(reader("OutGetQty").ToString)
            End If

            If reader("OutGetQty1") Is DBNull.Value Then
                objInfo.OutGetQty1 = Nothing
            Else
                objInfo.OutGetQty1 = CDbl(reader("OutGetQty1").ToString)
            End If

            If reader("WO_EndQty") Is DBNull.Value Then   '出庫后的期末結餘數
                objInfo.WO_EndQty = 0
            Else
                objInfo.WO_EndQty = CDbl(reader("WO_EndQty").ToString)
            End If

            If reader("AllQty") Is DBNull.Value Then
                objInfo.AllQty = 0
            Else
                objInfo.AllQty = reader("AllQty")
            End If

            objInfo.WO_PerNameS = reader("WO_PerNameS").ToString

            Return objInfo
        End Function

        Friend Function FillWareMove(ByVal reader As IDataReader) As KnifeWareMoveInfo

            On Error Resume Next
            Dim objInfo As New KnifeWareMoveInfo
            objInfo.MV_NO = reader("MV_NO").ToString
            objInfo.MV_Number = reader("MV_Number").ToString
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString

            If reader("MV_Qty") Is DBNull.Value Then
                objInfo.MV_Qty = 0
            Else
                objInfo.MV_Qty = reader("MV_Qty").ToString
            End If
            If reader("MV_Date") Is DBNull.Value Then
                objInfo.MV_Date = Nothing
            Else
                objInfo.MV_Date = CStr(reader("MV_Date"))
            End If
            'objInfo.MV_Date = reader("MV_Date").ToString
            objInfo.OS_BatchID = reader("OS_BatchID").ToString
            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            objInfo.DepotNO = reader("DepotNO").ToString
            objInfo.MV_ChangeDepotNO = reader("MV_ChangeDepotNO").ToString
            objInfo.MV_InOrOut = reader("MV_InOrOut").ToString
            objInfo.MV_Remark = reader("MV_Remark").ToString
            objInfo.MV_Ack = reader("MV_Ack")
            objInfo.MV_OutAction = reader("MV_OutAction").ToString
            objInfo.MV_InAction = reader("MV_InAction").ToString
            objInfo.MV_Property = reader("MV_Property").ToString
            objInfo.MV_Check = reader("MV_Check")
            objInfo.MV_CheckAction = reader("MV_CheckAction").ToString
            objInfo.MV_CheckType = reader("MV_CheckType").ToString
            objInfo.MV_CheckRemark = reader("MV_CheckRemark").ToString
            objInfo.MV_InActionName = reader("MV_InActionName")
            objInfo.MV_OutActionName = reader("MV_OutActionName").ToString
            objInfo.MV_CheckActionName = reader("MV_CheckActionName").ToString
            objInfo.KnifeType = reader("KnifeType").ToString

            If reader("MV_AckDate") Is DBNull.Value Then
                objInfo.MV_AckDate = Nothing
            Else
                objInfo.MV_AckDate = CStr(reader("MV_AckDate"))
            End If
            If reader("MV_EndQty") Is DBNull.Value Then   '調撥收入后的期末結餘數據
                objInfo.MV_EndQty = 0
            Else
                objInfo.MV_EndQty = CDbl(reader("MV_EndQty"))
            End If

            objInfo.DepotName = reader("_DepotName").ToString
            objInfo.DepotPName = reader("DepotPName").ToString
            objInfo.MV_ChangeDepotName = reader("MV_ChangeDepotName").ToString
            objInfo.MV_ChangeDepotPName = reader("MV_ChangeDepotPName").ToString

            '_DepotAllName = Nothing
            ' _MV_ChangeDepotAllName = Nothing
            objInfo.DepotAllName = reader("DepotPName").ToString & "-" & reader("DepotName").ToString
            objInfo.MV_ChangeDepotAllName = reader("MV_ChangeDepotPName").ToString & "-" & reader("MV_ChangeDepotName").ToString


            Return objInfo
        End Function

        Public Function FillKnifeWareInventorySub(ByVal reader As IDataReader) As KnifeWareInventorySubInfo
            Dim ai As New KnifeWareInventorySubInfo

            On Error Resume Next

            ai.Type3ID = reader("Type3ID").ToString
            ai.WH_ID = reader("WH_ID").ToString
            ai.Type3Name = reader("Type3Name").ToString

            ai.WI_SQty = reader("WI_SQty")
            ai.WI_SReQty = reader("WI_SReQty")
            '--------------------------------------------------

            If reader("WI_SQty") Is DBNull.Value Then
                ai.WI_SQty = 0
            Else
                ai.WI_SQty = CDbl(reader("WI_SQty"))
            End If

            If reader("WI_SReQty") Is DBNull.Value Then
                ai.WI_SReQty = 0
            Else
                ai.WI_SReQty = CDbl(reader("WI_SReQty"))
            End If

            If reader("WI_QtyAll") Is DBNull.Value Then
                ai.WI_QtyAll = 0
            Else
                ai.WI_QtyAll = CDbl(reader("WI_QtyAll"))
            End If

            If reader("B_Qty") Is DBNull.Value Then
                ai.B_Qty = 0
            Else
                ai.B_Qty = CDbl(reader("B_Qty"))
            End If


            ai.M_Code = reader("M_code").ToString
            ai.M_Name = reader("M_Name").ToString
            ai.M_Gauge = reader("M_Gauge").ToString
            ai.Type1ID = reader("Type1ID").ToString
            ai.Type1Name = reader("Type1Name").ToString
            ai.Type2ID = reader("Type2ID").ToString
            ai.Type2Name = reader("Type2Name").ToString


            ai.WI_Qty = IIf(IsDBNull(reader("WI_Qty")), 0, CDbl(reader("WI_Qty")))
            ai.WI_SafeQty = IIf(IsDBNull(reader("WI_SafeQty")), 0, CDbl(reader("WI_SafeQty")))
            ai.WI_UsableQty = IIf(IsDBNull(reader("WI_UsableQty")), 0, CDbl(reader("WI_UsableQty")))
            ai.WI_UserID = reader("WI_UserID").ToString()
            ai.PM_M_Name = reader("PM_M_Name").ToString()
            ai.WH_Name = reader("WH_Name").ToString()
            ai.M_Gauge = reader("M_Gauge").ToString()
            ai.M_Unit = reader("M_Unit").ToString()
            ai.WI_EditDate = CDate(reader("WI_EditDate").ToString())

            Return ai
        End Function

    End Class
End Namespace