Imports System
Imports System.Data
Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Imports System.Windows.Forms
Imports LFERP.Library.Purchase.Quotation
Imports LFERP.Library.Purchase.Purchase
Imports LFERP.Library.Purchase.Acceptance
Imports LFERP.Library.Purchase.Retrocede

Namespace LFERP.Library.Purchase.purselect

    Public Class PurSelectControl
        Public Function Retrocede_GetList(ByVal PurModule As String, ByVal strWhere As String) As List(Of RetrocedeInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Purchase_Select")
            db.AddInParameter(dbComm, "@PurModule", DbType.String, PurModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)

            Dim FeatureList As New List(Of RetrocedeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillRetrocede(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function Acceptance_GetList(ByVal PurModule As String, ByVal strWhere As String) As List(Of AcceptanceInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Purchase_Select")
            db.AddInParameter(dbComm, "@PurModule", DbType.String, PurModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)

            Dim FeatureList As New List(Of AcceptanceInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillAcceptance(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function Quotation_Getlist(ByVal PurModule As String, ByVal strWhere As String) As List(Of QuotationInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Purchase_Select")
            db.AddInParameter(dbComm, "@PurModule", DbType.String, PurModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)

            Dim FeatureList As New List(Of QuotationInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillQuotation(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function PurchaseMain_Getlist(ByVal PurModule As String, ByVal strWhere As String) As List(Of PurchaseMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Purchase_Select")
            db.AddInParameter(dbComm, "@PurModule", DbType.String, PurModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)

            Dim FeatureList As New List(Of PurchaseMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPurchaseMain(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Friend Function FillRetrocede(ByVal reader As IDataReader) As RetrocedeInfo
            '對應取得的數據
            On Error Resume Next
            Dim objInfo As New RetrocedeInfo
            objInfo.R_NO = reader("R_NO").ToString
            objInfo.R_RetrocedeNO = reader("R_RetrocedeNO").ToString
            objInfo.A_AcceptanceNO = reader("A_AcceptanceNO").ToString
            objInfo.PM_NO = reader("PM_NO").ToString
            objInfo.DepotNO = reader("DepotNO").ToString
            objInfo.S_Supplier = reader("S_Supplier").ToString
            objInfo.S_SupplierNO = reader("S_SupplierNO").ToString
            objInfo.S_SupplierName = reader("S_SupplierName").ToString
            objInfo.A_SendNo = reader("A_SendNo").ToString
            objInfo.R_ReturnDate = reader("R_ReturnDate").ToString
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.OS_BatchID = reader("OS_BatchID").ToString
            objInfo.R_Qty = reader("R_Qty").ToString
            objInfo.R_RemarkS = reader("R_RemarkS").ToString
            objInfo.R_Reason = reader("R_Reason").ToString
            objInfo.R_RemarkT = reader("R_RemarkT").ToString
            objInfo.R_SendDate = reader("R_SendDate").ToString

            objInfo.R_ReturnType = reader("R_ReturnType").ToString
            objInfo.R_Check = reader("R_Check").ToString
            objInfo.R_CheckAction = reader("R_CheckAction").ToString
            objInfo.R_CheckDate = reader("R_CheckDate").ToString
            objInfo.R_CheckType = reader("R_CheckType").ToString
            objInfo.R_CheckRemark = reader("R_CheckRemark").ToString
            objInfo.R_AccountCheck = reader("R_AccountCheck").ToString
            objInfo.R_AccountAction = reader("R_AccountAction").ToString
            objInfo.R_AccountCheckDate = reader("R_AccountCheckDate").ToString
            objInfo.R_AccountCheckType = reader("R_AccountCheckType").ToString
            objInfo.R_AccountCheckRemark = reader("R_AccountCheckRemark").ToString
            objInfo.R_Detail = reader("R_Detail").ToString
            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            objInfo.R_Ver = reader("R_Ver").ToString
            objInfo.R_Action = reader("R_Action").ToString
            objInfo.R_UpdateDate = reader("R_UpdateDate").ToString
            objInfo.CO_ID = reader("CO_ID").ToString
            Return objInfo
        End Function
        Friend Function FillAcceptance(ByVal reader As IDataReader) As AcceptanceInfo
            '對應取得的數據
            On Error Resume Next
            Dim objInfo As New AcceptanceInfo
            objInfo.DepotNO = reader("DepotNO").ToString
            objInfo.PM_NO = reader("PM_NO").ToString
            objInfo.A_AcceptanceNO = reader("A_AcceptanceNO").ToString
            objInfo.A_NO = reader("A_NO").ToString
            objInfo.A_SendNO = reader("A_SendNO").ToString
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.OS_BatchID = reader("OS_BatchID").ToString
            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            objInfo.DPT_ID = reader("DPT_ID").ToString
            objInfo.U_ID = reader("U_ID").ToString
            objInfo.A_Ver = reader("A_Ver").ToString
            objInfo.A_Qty = reader("A_Qty").ToString
            objInfo.A_SendType = reader("A_SendType").ToString
            objInfo.A_SendDate = reader("A_SendDate").ToString
            objInfo.S_Supplier = reader("S_Supplier").ToString
            objInfo.A_Action = reader("A_Action").ToString

            objInfo.A_Remark = reader("A_Remark").ToString
            objInfo.A_Detail = reader("A_Detail").ToString
            objInfo.A_UpdateDate = reader("A_UpdateDate").ToString
            objInfo.A_Check = reader("A_Check")
            objInfo.A_CheckAction = reader("A_CheckAction").ToString
            objInfo.A_CheckDate = reader("A_CheckDate").ToString
            objInfo.A_CheckType = reader("A_CheckType").ToString
            objInfo.A_CheckRemark = reader("A_CheckRemark").ToString
            objInfo.A_AccountCheck = reader("A_AccountCheck")
            objInfo.A_AccountCheckAction = reader("A_AccountCheckAction").ToString
            objInfo.A_AccountCheckDate = reader("A_AccountCheckDate").ToString
            objInfo.A_AccountCheckType = reader("A_AccountCheckType").ToString
            objInfo.A_AccountCheckRemark = reader("A_AccountCheckRemark").ToString
            objInfo.S_SupplierNO = reader("S_SupplierNO").ToString

            objInfo.A_PayCheck = reader("A_PayCheck")
            objInfo.A_PayCheckDate = reader("A_PayCheckDate").ToString
            objInfo.A_PayCheckAction = reader("A_PayCheckAction").ToString
            objInfo.A_PayCheckRemark = reader("A_PayCheckRemark").ToString

            objInfo.PN_NO = reader("PN_NO").ToString
            objInfo.A_ToFrom = reader("A_ToFrom").ToString
            objInfo.S_SupplierName = reader("S_SupplierName").ToString

            objInfo.WQC_Action = reader("WQC_Action").ToString
            objInfo.WQC_Status = reader("WQC_Status").ToString
            Return objInfo
        End Function
        Friend Function FillPurchaseMain(ByVal reader As IDataReader) As PurchaseMainInfo
            '對應取得的數據
            On Error Resume Next
            Dim objInfo As New PurchaseMainInfo
            objInfo.PM_NO = reader("PM_NO").ToString
            objInfo.PM_Associate = reader("PM_Associate").ToString
            objInfo.S_Supplier = reader("S_Supplier").ToString

            If reader("PM_PurchaseDate") Is DBNull.Value Then
                objInfo.PM_PurchaseDate = Nothing
            Else
                objInfo.PM_PurchaseDate = CStr(reader("PM_PurchaseDate"))
            End If

            objInfo.PM_Remark = reader("PM_Remark").ToString
            objInfo.PM_Action = reader("PM_Action").ToString
            objInfo.PM_ToFrom = reader("PM_ToFrom").ToString
            objInfo.PM_ComeType = reader("PM_ComeType").ToString
            objInfo.PM_PurchaseType = reader("PM_PurchaseType").ToString

            If reader("PM_Version") Is DBNull.Value Then
                objInfo.PM_Version = Nothing
            Else
                objInfo.PM_Version = CSng(reader("PM_Version"))
            End If
            objInfo.CO_ID = reader("CO_ID").ToString
            If reader("PM_Check") Is DBNull.Value Then
                objInfo.PM_Check = Nothing
            Else
                objInfo.PM_Check = reader("PM_Check")
            End If
            objInfo.PM_CheckAction = reader("PM_CheckAction").ToString
            objInfo.PM_CheckType = reader("PM_CheckType").ToString
            objInfo.PM_CheckRemark = reader("PM_CheckRemark").ToString
            If reader("PM_CheckDate") Is DBNull.Value Then
                objInfo.PM_CheckDate = Nothing
            Else
                objInfo.PM_CheckDate = CStr(reader("PM_CheckDate"))
            End If
            If reader("PM_AccountCheck") Is DBNull.Value Then
                objInfo.PM_AccountCheck = Nothing
            Else
                objInfo.PM_AccountCheck = reader("PM_AccountCheck")
            End If
            objInfo.PM_AccountCheckAction = reader("PM_AccountCheckAction").ToString
            objInfo.PM_AccountCheckType = reader("PM_AccountCheckType").ToString
            objInfo.PM_AccountCheckRemark = reader("PM_AccountCheckRemark").ToString


            If reader("PM_AccountCheckDate") Is DBNull.Value Then
                objInfo.PM_AccountCheckDate = Nothing
            Else
                objInfo.PM_AccountCheckDate = CStr(reader("PM_AccountCheckDate"))
            End If

            objInfo.PS_NO = reader("PS_NO").ToString

            objInfo.Q_QuoID = reader("Q_QuoID").ToString
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.S_SupplierNo = reader("S_SupplierNo").ToString

            objInfo.OS_BatchID = reader("OS_BatchID").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.PN_NO = reader("PN_NO").ToString


            objInfo.DPT_ID = reader("DPT_ID").ToString
            objInfo.U_ID = reader("U_ID").ToString
            objInfo.PS_NeedPurchaseUse = reader("PS_NeedPurchaseUse").ToString

            objInfo.C_ID = reader("C_ID").ToString
            objInfo.PM_Type = reader("PM_Type").ToString

            If reader("PS_QTY") Is DBNull.Value Then
                objInfo.PS_QTY = Nothing
            Else
                objInfo.PS_QTY = CDbl(reader("PS_QTY").ToString)
            End If
            If reader("PS_NoSendQty") Is DBNull.Value Then
                objInfo.PS_NoSendQty = Nothing
            Else
                objInfo.PS_NoSendQty = CDbl(reader("PS_NoSendQty").ToString)
            End If
            If reader("PS_Price") Is DBNull.Value Then
                objInfo.PS_Price = Nothing
            Else
                objInfo.PS_Price = CDbl(reader("PS_Price").ToString)
            End If
            If reader("PS_SendDate") Is DBNull.Value Then
                objInfo.PS_SendDate = Nothing
            Else
                objInfo.PS_SendDate = CStr(reader("PS_SendDate"))
            End If



            objInfo.PS_Depict = reader("PS_Depict").ToString
            objInfo.PS_Detail = reader("PS_Detail").ToString

            If reader("PS_Tarriff") Is DBNull.Value Then
                objInfo.PS_Tarriff = Nothing
            Else
                objInfo.PS_Tarriff = CSng(reader("PS_Tarriff").ToString)
            End If

            If reader("PS_TffCost") Is DBNull.Value Then
                objInfo.PS_TffCost = Nothing
            Else
                objInfo.PS_TffCost = CDbl(reader("PS_TffCost").ToString)
            End If

            If reader("PS_AmountBf") Is DBNull.Value Then
                objInfo.PS_AmountBf = Nothing
            Else
                objInfo.PS_AmountBf = CDbl(reader("PS_AmountBf").ToString)
            End If

            If reader("PS_AmountAf") Is DBNull.Value Then
                objInfo.PS_AmountAf = Nothing
            Else
                objInfo.PS_AmountAf = CDbl(reader("PS_AmountAf").ToString)
            End If


            objInfo.PM_M_Code = reader("PM_M_Code").ToString

            objInfo.PM_AccCheckActionName = reader("PM_AccCheckActionName").ToString
            objInfo.PM_CheckActionName = reader("PM_CheckActionName").ToString
            objInfo.PM_ActionName = reader("PM_ActionName").ToString
            objInfo.S_SupplierName = reader("S_SupplierName").ToString

            objInfo.Type1Name = reader("Type1Name").ToString
            objInfo.Type2Name = reader("Type2Name").ToString
            objInfo.Type3Name = reader("Type3Name").ToString
            objInfo.MaterialTypeName = reader("MaterialTypeName").ToString

            If reader("PM_OS_SendDate") Is DBNull.Value Then
                objInfo.PM_OS_SendDate = Nothing
            Else
                objInfo.PM_OS_SendDate = CDate(reader("PM_OS_SendDate").ToString)
            End If


            If reader("PSs_Date") Is DBNull.Value Then
                objInfo.PSs_Date = Nothing
            Else
                objInfo.PSs_Date = CDate(reader("PSs_Date").ToString)
            End If

            objInfo.PSs_Remark = reader("PSs_Remark").ToString

            objInfo.M_BatchID = reader("M_BatchID").ToString

            If reader("HKDRate") Is DBNull.Value Then
                objInfo.HKDRate = Nothing
            Else
                objInfo.HKDRate = reader("HKDRate")
            End If


            'WI_Qty

            If reader("WI_Qty") Is DBNull.Value Then
                objInfo.WI_Qty = 0
            Else
                objInfo.WI_Qty = FormatNumber(CDbl(reader("WI_Qty").ToString), 3, TriState.True)
            End If

            objInfo.PM_U_Name = reader("PM_U_Name").ToString
            objInfo.PS_Sum = objInfo.PS_QTY * objInfo.PS_Price

            Return objInfo

        End Function
        Friend Function FillQuotation(ByVal reader As IDataReader) As QuotationInfo
            On Error Resume Next
            '對應取得的數據
            Dim objInfo As New QuotationInfo

            If reader("HKDRate") Is DBNull.Value Then
                objInfo.HKDRate = 0
            Else
                objInfo.HKDRate = CDbl(reader("HKDRate").ToString)
            End If

            objInfo.AutoID = reader("AutoID").ToString
            objInfo.Q_QuoID = reader("Q_QuoID").ToString
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            objInfo.Q_Supplier = reader("Q_Supplier").ToString
            objInfo.Q_SupplierNo = reader("Q_SupplierNo").ToString
            objInfo.Q_Type = reader("Q_Type").ToString
            If reader("Q_Price") Is DBNull.Value Then
                objInfo.Q_Price = Nothing
            Else
                objInfo.Q_Price = CDbl(reader("Q_Price").ToString)
            End If

            objInfo.Type3Name = reader("Type3Name").ToString

            objInfo.Q_Currency = reader("Q_Currency").ToString

            If reader("Q_AddDate") Is DBNull.Value Then
                objInfo.Q_AddDate = Nothing
            Else
                objInfo.Q_AddDate = CStr(reader("Q_AddDate"))
            End If
            If reader("Q_EditDate") Is DBNull.Value Then
                objInfo.Q_EditDate = Nothing
            Else
                objInfo.Q_EditDate = CStr(reader("Q_EditDate"))
            End If

            objInfo.Q_Associate = reader("Q_Associate").ToString

            If reader("Q_Edition") Is DBNull.Value Then
                objInfo.Q_Edition = 0
            Else
                objInfo.Q_Edition = CSng(reader("Q_Edition").ToString)
            End If



            If reader("Q_Check") Is DBNull.Value Then
                objInfo.Q_Check = Nothing
            Else
                objInfo.Q_Check = reader("Q_Check")
            End If


            objInfo.Q_CheckAction = reader("Q_CheckAction").ToString

            If reader("Q_CheckDate") Is DBNull.Value Then
                objInfo.Q_CheckDate = Nothing
            Else
                objInfo.Q_CheckDate = CStr(reader("Q_CheckDate"))
            End If


            objInfo.Q_CheckRemark = reader("Q_CheckRemark").ToString
            objInfo.Q_CheckType = reader("Q_CheckType").ToString

            If reader("Q_AccCheck") Is DBNull.Value Then
                objInfo.Q_AccCheck = Nothing
            Else
                objInfo.Q_AccCheck = reader("Q_AccCheck")
            End If

            If reader("Q_AccCheckDate") Is DBNull.Value Then
                objInfo.Q_AccCheckDate = Nothing
            Else
                objInfo.Q_AccCheckDate = CStr(reader("Q_AccCheckDate"))
            End If

            objInfo.Q_AccCheckRemark = reader("Q_AccCheckRemark").ToString
            objInfo.Q_AccCheckType = reader("Q_AccCheckType").ToString
            objInfo.Q_AccCheckAction = reader("Q_AccCheckAction").ToString

            objInfo.Q_Action = reader("Q_Action").ToString
            objInfo.Q_Remark = reader("Q_Remark").ToString
            objInfo.Q_RetrDate = reader("Q_RetrDate").ToString
            objInfo.CO_ID = reader("CO_ID").ToString


            If reader("Q_Qty") Is DBNull.Value Then
                objInfo.Q_Qty = Nothing
            Else
                objInfo.Q_Qty = CDbl(reader("Q_Qty").ToString)
            End If


            objInfo.Q_Depict = reader("Q_Depict").ToString
            objInfo.PN_NO = reader("PN_NO").ToString

            objInfo.Q_ActionName = reader("Q_ActionName").ToString
            objInfo.Q_CheckActionName = reader("Q_CheckActionName").ToString
            objInfo.Q_AccCheckActionName = reader("Q_AccCheckActionName").ToString

            If reader("Q_SupplierName") Is DBNull.Value Then
                objInfo.Q_SupplierName = Nothing
            Else
                objInfo.Q_SupplierName = reader("Q_SupplierName").ToString
            End If


            If reader("Q_Brand") Is DBNull.Value Then
                objInfo.Q_Brand = Nothing
            Else
                objInfo.Q_Brand = reader("Q_Brand").ToString
            End If

            If reader("Q_Origine") Is DBNull.Value Then
                objInfo.Q_Origine = Nothing
            Else
                objInfo.Q_Origine = reader("Q_Origine").ToString
            End If

            If reader("Q_StandardPack") Is DBNull.Value Then
                objInfo.Q_StandardPack = Nothing
            Else
                objInfo.Q_StandardPack = reader("Q_StandardPack").ToString
            End If


            If reader("Q_MOQ") Is DBNull.Value Then
                objInfo.Q_MOQ = Nothing
            Else
                objInfo.Q_MOQ = reader("Q_MOQ").ToString
            End If


            If reader("Q_ProductionCycle") Is DBNull.Value Then
                objInfo.Q_ProductionCycle = Nothing
            Else
                objInfo.Q_ProductionCycle = reader("Q_ProductionCycle").ToString
            End If

            If reader("Q_DeliveredCycle") Is DBNull.Value Then
                objInfo.Q_DeliveredCycle = Nothing
            Else
                objInfo.Q_DeliveredCycle = reader("Q_DeliveredCycle").ToString
            End If


            If reader("Q_DeliveredAddress") Is DBNull.Value Then
                objInfo.Q_DeliveredAddress = Nothing
            Else
                objInfo.Q_DeliveredAddress = reader("Q_DeliveredAddress").ToString
            End If

            If reader("Q_ExchangeRate") Is DBNull.Value Then
                objInfo.Q_ExchangeRate = Nothing
            Else
                objInfo.Q_ExchangeRate = reader("Q_ExchangeRate").ToString
            End If


            If reader("Q_Validity") Is DBNull.Value Then
                objInfo.Q_Validity = Nothing
            Else
                objInfo.Q_Validity = reader("Q_Validity").ToString
            End If


            If reader("Q_MoldExpense") Is DBNull.Value Then
                objInfo.Q_MoldExpense = Nothing
            Else
                objInfo.Q_MoldExpense = reader("Q_MoldExpense").ToString
            End If

            If reader("Q_PriceType") Is DBNull.Value Then
                objInfo.Q_PriceType = Nothing
            Else
                objInfo.Q_PriceType = reader("Q_PriceType").ToString
            End If
            If reader("Q_ToForm") Is DBNull.Value Then
                objInfo.Q_ToForm = Nothing
            Else
                objInfo.Q_ToForm = reader("Q_ToForm").ToString
            End If
            If reader("Q_Tarriff") Is DBNull.Value Then
                objInfo.Q_Tarriff = Nothing
            Else
                objInfo.Q_Tarriff = CSng(reader("Q_Tarriff").ToString)
            End If

            '--------------------------------------------------------------------------------------------------------
            objInfo.CodeMain = reader("CodeMain").ToString

            objInfo.CodeMain_Gauge = reader("CodeMain_Gauge").ToString

            objInfo.CodeMain_Name = reader("CodeMain_Name").ToString
            objInfo.CodeMain_Unit = reader("CodeMain_Unit").ToString
            objInfo.CodeSub = reader("CodeSub").ToString
            If reader("CodeSub_Gauge") Is DBNull.Value Then
                objInfo.CodeSub_Gauge = Nothing
            Else
                objInfo.CodeSub_Gauge = reader("CodeSub_Gauge").ToString
            End If

            objInfo.CodeSub_Name = reader("CodeSub_Name").ToString
            objInfo.CodeSub_Unit = reader("CodeSub_Unit").ToString
            objInfo.TagID = reader("TagID").ToString

            objInfo.UserID = reader("UserID").ToString
            objInfo.Code_UserName = reader("Code_UserName").ToString


            If reader("Q_Total") Is DBNull.Value Then
                objInfo.Q_Total = 0
            Else
                objInfo.Q_Total = CSng(reader("Q_Total").ToString)
            End If

            If reader("Q_SubTotal") Is DBNull.Value Then
                objInfo.Q_SubTotal = 0
            Else
                objInfo.Q_SubTotal = CSng(reader("Q_SubTotal").ToString)
            End If

            Return objInfo
        End Function
    End Class

End Namespace
