Imports LFERP.Library.WareHouse.WareInput
Imports LFERP.Library.WareHouse.WareOut
Imports LFERP.Library.WareHouse.WareMove
Imports LFERP.Library.WareHouse.WareBorrowReturn

Namespace LFERP.Library.WareHouse.WareSelect
    Public Class WareSelectControl
        Public Function WareInput_Getlist(ByVal WareModule As String, ByVal strWhere As String) As List(Of WareInputInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Ware_Select")

            db.AddInParameter(dbComm, "@WareModule", DbType.String, WareModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)

            Dim FeatureList As New List(Of WareInputInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInput(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function WareOut_Getlist(ByVal WareModule As String, ByVal strWhere As String) As List(Of WareOutInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Ware_Select")

            db.AddInParameter(dbComm, "@WareModule", DbType.String, WareModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)

            Dim FeatureList As New List(Of WareOutInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareOut(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function WareMove_Getlist(ByVal WareModule As String, ByVal strWhere As String) As List(Of WareMoveInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Ware_Select")

            db.AddInParameter(dbComm, "@WareModule", DbType.String, WareModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)

            Dim FeatureList As New List(Of WareMoveInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareMove(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function WareBorrowReturn_Getlist(ByVal WareModule As String, ByVal strWhere As String) As List(Of WareBorrowReturnInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Ware_Select")

            db.AddInParameter(dbComm, "@WareModule", DbType.String, WareModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)

            Dim FeatureList As New List(Of WareBorrowReturnInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillBorrowReturn1(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Friend Function FillBorrowReturn1(ByVal reader As IDataReader) As WareBorrowReturnInfo

            On Error Resume Next
            '
            Dim ci As New WareBorrowReturnInfo
            '流水號
            ci.WB_NUM = reader("WB_NUM").ToString
            ci.WB_NO = reader("WB_NO").ToString
            ci.AutoID = reader("AutoID").ToString
            ci.WB_Type = reader("WB_Type").ToString

            ci.M_Code = reader("M_Code").ToString

            If reader("Qty") Is DBNull.Value Then
                ci.Qty = 0
            Else
                ci.Qty = CDbl(reader("Qty").ToString)
            End If

            If reader("NO_ReQty") Is DBNull.Value Then
                ci.NO_ReQty = 0
            Else
                ci.NO_ReQty = CDbl(reader("NO_ReQty").ToString)
            End If

            If reader("WB_EndQty") Is DBNull.Value Then
                ci.WB_EndQty = 0
            Else
                ci.WB_EndQty = CDbl(reader("WB_EndQty").ToString)
            End If

            If reader("DPT_ID") Is DBNull.Value Then
                ci.DPT_ID = Nothing
            Else
                ci.DPT_ID = reader("DPT_ID").ToString
            End If

            '-------------------------------------------------------
            If reader("WB_PerID") Is DBNull.Value Then
                ci.WB_PerID = Nothing
            Else
                ci.WB_PerID = reader("WB_PerID").ToString
            End If

            If reader("WB_PerName") Is DBNull.Value Then
                ci.WB_PerName = Nothing
            Else
                ci.WB_PerName = reader("WB_PerName").ToString
            End If

            If reader("WH_ID") Is DBNull.Value Then
                ci.WH_ID = Nothing
            Else
                ci.WH_ID = reader("WH_ID").ToString
            End If

            If reader("WB_Action") Is DBNull.Value Then
                ci.WB_Action = Nothing
            Else
                ci.WB_Action = reader("WB_Action").ToString
            End If

            If reader("WB_Date") Is DBNull.Value Then
                ci.WB_Date = Nothing
            Else
                ci.WB_Date = CStr(reader("WB_Date").ToString)
            End If

            If reader("RR_PerID") Is DBNull.Value Then
                ci.RR_PerID = Nothing
            Else
                ci.RR_PerID = reader("RR_PerID").ToString
            End If
            '-------------------------------------------------------

            If reader("RR_PerName") Is DBNull.Value Then
                ci.RR_PerName = Nothing
            Else
                ci.RR_PerName = reader("RR_PerName").ToString
            End If

            If reader("Remark") Is DBNull.Value Then
                ci.Remark = Nothing
            Else
                ci.Remark = reader("Remark").ToString
            End If

            If reader("M_Name") Is DBNull.Value Then
                ci.M_Name = Nothing
            Else
                ci.M_Name = reader("M_Name").ToString
            End If

            If reader("M_Gauge") Is DBNull.Value Then
                ci.M_Gauge = Nothing
            Else
                ci.M_Gauge = reader("M_Gauge").ToString
            End If
            '-------------------------------------------------------
            If reader("M_Unit") Is DBNull.Value Then
                ci.M_Unit = Nothing
            Else
                ci.M_Unit = reader("M_Unit").ToString
            End If

            If reader("WB_ActionName") Is DBNull.Value Then
                ci.WB_ActionName = Nothing
            Else
                ci.WB_ActionName = reader("WB_ActionName").ToString
            End If

            If reader("WH_Name") Is DBNull.Value Then
                ci.WH_Name = Nothing
            Else
                ci.WH_Name = reader("WH_Name").ToString
            End If

            If reader("WH_PName") Is DBNull.Value Then
                ci.WH_PName = Nothing
            Else
                ci.WH_PName = reader("WH_PName").ToString
            End If

            If reader("DPT_Name") Is DBNull.Value Then
                ci.DPT_Name = Nothing
            Else
                ci.DPT_Name = reader("DPT_Name").ToString
            End If
            '
            If reader("WBR_NO") Is DBNull.Value Then
                ci.WBR_NO = Nothing
            Else
                ci.WBR_NO = reader("WBR_NO").ToString
            End If

            If reader("DPT_PName") Is DBNull.Value Then
                ci.DPT_PName = Nothing
            Else
                ci.DPT_PName = reader("DPT_PName").ToString
            End If

            If reader("WBR_QtyStr") Is DBNull.Value Then
                ci.WBR_QtyStr = Nothing
            Else
                ci.WBR_QtyStr = reader("WBR_QtyStr").ToString
            End If

            ci.QtyReal = 0 '默認為0，需要此結構
            ci.RemarkReal = Nothing

            Return ci

        End Function

        Friend Function FillWareInput(ByVal reader As IDataReader) As WareInputInfo
            On Error Resume Next
            '對應取得的數據
            Dim objInfo As New WareInputInfo

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

            objInfo.WH_PName = reader("WH_PName").ToString
            objInfo.WH_AllName = reader("WH_PName").ToString & "-" & reader("WH_Name").ToString
            Return objInfo
        End Function

        Friend Function FillWareOut(ByVal reader As IDataReader) As WareOutInfo
            On Error Resume Next
            '對應取得的數據
            Dim objInfo As New WareOutInfo

            ''2012-12-21
            objInfo.HKDRate = reader("HKDRate")

            If reader("M_Price") Is DBNull.Value Then
                objInfo.M_Price = Nothing
            Else
                objInfo.M_Price = FormatNumber(CDbl(reader("M_Price")), 4, TriState.True)
            End If

            objInfo.M_Currency = CStr(reader("M_Currency").ToString)


            objInfo.WO_NUM = reader("WO_NUM").ToString
            objInfo.WO_ID = reader("WO_ID").ToString

            objinfo.WO_Type = reader("WO_Type").ToString
            objInfo.AP_NO = reader("AP_NO").ToString
            objInfo.OP_NO = reader("OP_NO").ToString

            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
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
            objInfo.WH_ID = reader("WH_ID").ToString
            objInfo.OS_BatchID = reader("OS_BatchID").ToString
            objInfo.WO_Action = reader("WO_Action").ToString
            If reader("WO_EditDate") Is DBNull.Value Then
                objInfo.WO_EditDate = Nothing
            Else
                objInfo.WO_EditDate = CStr(reader("WO_EditDate"))
            End If
            objInfo.WO_Remark = reader("WO_Remark").ToString
            objInfo.DPT_ID = reader("DPT_ID").ToString
            objInfo.WO_PerID = reader("WO_PerID").ToString
            objInfo.WO_PerName = reader("WO_PerName").ToString

            If reader("WO_Check") Is DBNull.Value Then
                objInfo.WO_Check = Nothing
            Else
                objInfo.WO_Check = reader("WO_Check")
            End If
            objInfo.WO_CheckAction = reader("WO_CheckAction").ToString
            If reader("WO_CheckDate") Is DBNull.Value Then
                objInfo.WO_CheckDate = Nothing
            Else
                objInfo.WO_CheckDate = CStr(reader("WO_CheckDate"))
            End If
            objInfo.WO_CheckRemark = reader("WO_CheckRemark").ToString

            If reader("WO_ReCheck") Is DBNull.Value Then
                objInfo.WO_ReCheck = Nothing
            Else
                objInfo.WO_ReCheck = reader("WO_ReCheck")
            End If
            objInfo.WO_ReCheckAction = reader("WO_ReCheckAction").ToString
            If reader("WO_ReCheckDate") Is DBNull.Value Then
                objInfo.WO_ReCheckDate = Nothing
            Else
                objInfo.WO_ReCheckDate = CStr(reader("WO_ReCheckDate"))
            End If
            objInfo.WO_ReCheckRemark = reader("WO_ReCheckRemark").ToString


            objInfo.WO_ActionName = reader("WO_ActionName").ToString
            objInfo.WO_CheckActionName = reader("WO_CheckActionName").ToString
            objInfo.WH_Name = reader("WH_Name").ToString
            objInfo.WH_PName = reader("WH_PName").ToString
            objInfo.WH_AllName = reader("WH_PName").ToString & "-" & reader("WH_Name").ToString
            objInfo.DPT_Name = reader("DPT_PName").ToString & "-" & reader("DPT_Name").ToString
            objInfo.DPT_PName = reader("DPT_PName").ToString

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

            Return objInfo
        End Function

        Friend Function FillWareMove(ByVal reader As IDataReader) As WareMoveInfo

            On Error Resume Next
            Dim objInfo As New WareMoveInfo
            objInfo.MV_NO = reader("MV_NO").ToString
            objInfo.MV_Number = reader("MV_Number").ToString
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString

            objInfo.MV_Qty = reader("MV_Qty").ToString
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

            Return objInfo
        End Function
    End Class
End Namespace

