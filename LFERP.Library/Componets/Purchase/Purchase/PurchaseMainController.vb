
Imports System
Imports System.Data
Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Imports System.Windows.Forms

Namespace LFERP.Library.Purchase.Purchase
    Public Class PurchaseMainController


        ''' <summary>
        ''' 取得一條記錄
        ''' </summary>
        ''' <param name="PM_NO"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PurchaseMain_Get(ByVal PM_NO As String) As PurchaseMainInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PurchaseMain_Get")
            db.AddInParameter(dbComm, "@PM_NO", DbType.String, PM_NO)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillPurchaseMain(reader)
                End While
                Return Nothing
            End Using
        End Function
        ''' <summary>
        ''' 取得當前最大的ID。隻用於生成新的ID用
        ''' </summary>
        ''' <param name="NDate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PurchaseMain_GetID(ByVal NDate As String) As PurchaseMainInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PurchaseMain_GetID")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillPurchaseMain(reader)
                End While
                Return Nothing
            End Using
        End Function




        ''' <summary>
        ''' 取得一條SUB記錄
        ''' </summary>
        ''' <param name="PS_NO"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PurchaseSub_Get(ByVal PS_NO As String) As PurchaseMainInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PurchaseSub_Get")
            db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillPurchaseMain(reader)
                End While
                Return Nothing
            End Using
        End Function

        ''' <summary>
        ''' 採購單報表匯總查詢
        ''' </summary>
        ''' <param name="PM_Date1"></param>
        ''' <param name="PM_Date2"></param>
        ''' <param name="S_Supplier"></param>
        ''' <param name="M_Code"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>


        Public Function PurchaseMainGroup_GetList(ByVal PM_Type As String, ByVal PM_PurchaseType As String, ByVal PM_Date1 As String, ByVal PM_Date2 As String, ByVal S_Supplier As String, ByVal M_Code As String) As List(Of PurchaseMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PurchaseMainGroup_GetList")

            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@PM_PurchaseType", DbType.String, PM_PurchaseType)
            db.AddInParameter(dbComm, "@PM_Date1", DbType.String, PM_Date1)
            db.AddInParameter(dbComm, "@PM_Date2", DbType.String, PM_Date2)
            db.AddInParameter(dbComm, "@S_Supplier", DbType.String, S_Supplier)

            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)

            Dim FeatureList As New List(Of PurchaseMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPurchaseMain(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function PurchaseSub_GetBatchList(ByVal PM_NO As String, ByVal M_Code As String, ByVal OS_BatchID As String) As List(Of PurchaseMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PurchaseSub_GetBatchList")
            db.AddInParameter(dbComm, "@PM_NO", DbType.String, PM_NO)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)

            Dim FeatureList As New List(Of PurchaseMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPurchaseMain(reader))
                End While
                Return FeatureList
            End Using

        End Function

        ''' <summary>
        ''' 取得一張採購單的所有記錄
        ''' </summary>
        ''' <param name="PM_NO"></param>
        ''' <param name="PS_NO"></param>
        ''' <param name="M_Code"></param>
        ''' <param name="PM_PurchaseDate"></param>
        ''' <param name="PM_AddDateVal"></param>
        ''' <param name="S_Supplier"></param>
        ''' <param name="PM_Check"></param>
        ''' <param name="PM_AccountCheck"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PurchaseMain_Getlist(ByVal PM_NO As String, ByVal PS_NO As String, ByVal Q_QuoID As String, ByVal M_Code As String, ByVal M_Name As String, ByVal M_Gauge As String, ByVal PM_PurchaseType As String, ByVal PM_PurchaseDate As String, ByVal PM_AddDateVal As String, ByVal S_Supplier As String, ByVal PM_Action As String, ByVal PM_Type As String, ByVal PM_Check As String, ByVal PM_AccountCheck As String, ByVal NoSendQtyZero As String, ByVal M_TeSu As String) As List(Of PurchaseMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PurchaseMain_Getlist")
            db.AddInParameter(dbComm, "@PM_NO", DbType.String, PM_NO)
            db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
            db.AddInParameter(dbComm, "@Q_QuoID", DbType.String, Q_QuoID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@M_Gauge", DbType.String, M_Gauge)
            db.AddInParameter(dbComm, "@PM_PurchaseType", DbType.String, PM_PurchaseType)
            db.AddInParameter(dbComm, "@PM_PurchaseDate", DbType.String, PM_PurchaseDate)
            db.AddInParameter(dbComm, "@PM_AddDateVal", DbType.String, PM_AddDateVal)
            db.AddInParameter(dbComm, "@S_Supplier", DbType.String, S_Supplier)
            db.AddInParameter(dbComm, "@NoSendQtyZero", DbType.String, NoSendQtyZero)
            db.AddInParameter(dbComm, "@PM_Action", DbType.String, PM_Action)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)

            db.AddInParameter(dbComm, "@PM_Check", DbType.String, PM_Check)
            db.AddInParameter(dbComm, "@PM_AccountCheck", DbType.String, PM_AccountCheck)
            db.AddInParameter(dbComm, "@M_TeSu", DbType.String, M_TeSu)

            'If PM_Check = Nothing Then
            '    db.AddInParameter(dbComm, "@PM_Check", DbType.Boolean, DBNull.Value)
            'Else
            '    db.AddInParameter(dbComm, "@PM_Check", DbType.Boolean, PM_Check)
            'End If

            'If PM_AccountCheck = Nothing Then
            '    db.AddInParameter(dbComm, "@PM_AccountCheck", DbType.Boolean, DBNull.Value)
            'Else
            '    db.AddInParameter(dbComm, "@PM_AccountCheck", DbType.Boolean, PM_AccountCheck)
            'End If


            Dim FeatureList As New List(Of PurchaseMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPurchaseMain(reader))
                End While
                Return FeatureList
            End Using

        End Function
        Public Function PurchaseMain_Getlist1(ByVal PM_NO As String, ByVal PS_NO As String, ByVal Q_QuoID As String, ByVal M_Code As String, ByVal M_Name As String, ByVal M_Gauge As String, ByVal PM_PurchaseType As String, ByVal PM_Date1 As String, ByVal PM_Date2 As String, ByVal S_Supplier As String, ByVal PM_Action As String, ByVal PM_Type As String, ByVal PM_Check As String, ByVal PM_AccountCheck As String, ByVal NoSendQtyZero As String, ByVal M_TeSu As String) As List(Of PurchaseMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PurchaseMainGroup_GetList1")
            db.AddInParameter(dbComm, "@PM_NO", DbType.String, PM_NO)
            db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
            db.AddInParameter(dbComm, "@Q_QuoID", DbType.String, Q_QuoID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@M_Gauge", DbType.String, M_Gauge)
            db.AddInParameter(dbComm, "@PM_PurchaseType", DbType.String, PM_PurchaseType)
            db.AddInParameter(dbComm, "@PM_Date1", DbType.String, PM_Date1)
            db.AddInParameter(dbComm, "@PM_Date2", DbType.String, PM_Date2)
            db.AddInParameter(dbComm, "@S_Supplier", DbType.String, S_Supplier)
            db.AddInParameter(dbComm, "@NoSendQtyZero", DbType.String, NoSendQtyZero)
            db.AddInParameter(dbComm, "@PM_Action", DbType.String, PM_Action)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)

            'db.AddInParameter(dbComm, "@PM_Check", DbType.String, PM_Check)
            'db.AddInParameter(dbComm, "@PM_AccountCheck", DbType.String, PM_AccountCheck)
            If PM_Check = Nothing Then
                db.AddInParameter(dbComm, "@PM_Check", DbType.Boolean, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@PM_Check", DbType.Boolean, PM_Check)
            End If

            If PM_AccountCheck = Nothing Then
                db.AddInParameter(dbComm, "@PM_AccountCheck", DbType.Boolean, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@PM_AccountCheck", DbType.Boolean, PM_AccountCheck)
            End If
            db.AddInParameter(dbComm, "@M_TeSu", DbType.String, M_TeSu)

            Dim FeatureList As New List(Of PurchaseMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPurchaseMain(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function PurchaseMain_Getlist2(ByVal MaterialTypeID As String, ByVal PM_Action As String, ByVal PM_Date1 As String, ByVal PM_Date2 As String, ByVal S_Supplier As String) As List(Of PurchaseMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PurchaseMainGroup_GetList2")
            db.AddInParameter(dbComm, "@MaterialTypeID", DbType.String, MaterialTypeID)
            db.AddInParameter(dbComm, "@PM_Action", DbType.String, PM_Action)
            db.AddInParameter(dbComm, "@PM_Date1", DbType.String, PM_Date1)
            db.AddInParameter(dbComm, "@PM_Date2", DbType.String, PM_Date2)
            db.AddInParameter(dbComm, "@S_Supplier", DbType.String, S_Supplier)

            Dim FeatureList As New List(Of PurchaseMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPurchaseMain(reader))
                End While
                Return FeatureList
            End Using

        End Function

        '@ 2012/7/6 添加
        Public Function PurchaseMainGroup_GetList3(ByVal PM_NO As String, ByVal PS_NO As String, ByVal Q_QuoID As String, ByVal M_Code As String, ByVal M_Name As String, ByVal M_Gauge As String, ByVal PM_PurchaseType As String, ByVal PM_Date1 As String, ByVal PM_Date2 As String, ByVal S_Supplier As String, ByVal PM_Action As String, ByVal PM_Type As String, ByVal PM_Check As String, ByVal PM_AccountCheck As String, ByVal NoSendQtyZero As String, ByVal M_TeSu As String) As List(Of PurchaseMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PurchaseMainGroup_GetList3")
            db.AddInParameter(dbComm, "@PM_NO", DbType.String, PM_NO)
            db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
            db.AddInParameter(dbComm, "@Q_QuoID", DbType.String, Q_QuoID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@M_Gauge", DbType.String, M_Gauge)
            db.AddInParameter(dbComm, "@PM_PurchaseType", DbType.String, PM_PurchaseType)
            db.AddInParameter(dbComm, "@PM_Date1", DbType.String, PM_Date1)
            db.AddInParameter(dbComm, "@PM_Date2", DbType.String, PM_Date2)
            db.AddInParameter(dbComm, "@S_Supplier", DbType.String, S_Supplier)
            db.AddInParameter(dbComm, "@NoSendQtyZero", DbType.String, NoSendQtyZero)
            db.AddInParameter(dbComm, "@PM_Action", DbType.String, PM_Action)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)

            'db.AddInParameter(dbComm, "@PM_Check", DbType.String, PM_Check)
            'db.AddInParameter(dbComm, "@PM_AccountCheck", DbType.String, PM_AccountCheck)
            If PM_Check = Nothing Then
                db.AddInParameter(dbComm, "@PM_Check", DbType.Boolean, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@PM_Check", DbType.Boolean, PM_Check)
            End If

            If PM_AccountCheck = Nothing Then
                db.AddInParameter(dbComm, "@PM_AccountCheck", DbType.Boolean, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@PM_AccountCheck", DbType.Boolean, PM_AccountCheck)
            End If
            db.AddInParameter(dbComm, "@M_TeSu", DbType.String, M_TeSu)

            Dim FeatureList As New List(Of PurchaseMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPurchaseMain(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function PurchaseMain_GetReportList(ByVal PM_NO As String, ByVal M_Code As String, ByVal PS_SendDate1 As String, ByVal PS_SendDate2 As String, ByVal PM_AddDate1 As String, ByVal PM_AddDate2 As String, ByVal S_Supplier As String, ByVal PM_Check As Boolean, ByVal PM_AccountCheck As Boolean, ByVal NoSendQtyZero As String, ByVal M_TeSu As String) As List(Of PurchaseMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PurchaseMain_GetReportList")
            db.AddInParameter(dbComm, "@PM_NO", DbType.String, PM_NO)

            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@PS_SendDate1", DbType.String, PS_SendDate1)
            db.AddInParameter(dbComm, "@PS_SendDate2", DbType.String, PS_SendDate2)
            db.AddInParameter(dbComm, "@PM_AddDate1", DbType.String, PM_AddDate1)
            db.AddInParameter(dbComm, "@PM_AddDate2", DbType.String, PM_AddDate2)


            db.AddInParameter(dbComm, "@S_Supplier", DbType.String, S_Supplier)
            If PM_Check = Nothing Then
                db.AddInParameter(dbComm, "@PM_Check", DbType.Boolean, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@PM_Check", DbType.Boolean, PM_Check)
            End If
            If PM_AccountCheck = Nothing Then
                db.AddInParameter(dbComm, "@PM_AccountCheck", DbType.Boolean, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@PM_AccountCheck", DbType.Boolean, PM_AccountCheck)
            End If
            db.AddInParameter(dbComm, "@NoSendQtyZero", DbType.String, NoSendQtyZero)
            db.AddInParameter(dbComm, "@M_TeSu", DbType.String, M_TeSu)


            Dim FeatureList As New List(Of PurchaseMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPurchaseMain(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function PurchaseMain_GetListTop10(ByVal PM_NO As String, ByVal PS_NO As String, ByVal M_Code As String, ByVal PM_Check As Boolean, ByVal PM_AccountCheck As Boolean) As List(Of PurchaseMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PurchaseMain_GetListTop10")
            db.AddInParameter(dbComm, "@PM_NO", DbType.String, PM_NO)
            db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            If PM_Check = Nothing Then
                db.AddInParameter(dbComm, "@PM_Check", DbType.Boolean, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@PM_Check", DbType.Boolean, PM_Check)
            End If
            If PM_AccountCheck = Nothing Then
                db.AddInParameter(dbComm, "@PM_AccountCheck", DbType.Boolean, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@PM_AccountCheck", DbType.Boolean, PM_AccountCheck)
            End If


            Dim FeatureList As New List(Of PurchaseMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPurchaseMain(reader))
                End While
                Return FeatureList
            End Using
        End Function



        Friend Function FillPurchaseMain(ByVal reader As IDataReader) As PurchaseMainInfo
            '對應取得的數據
            On Error Resume Next
            Dim objInfo As New PurchaseMainInfo
            objInfo.PM_NO = reader("PM_NO").ToString
            objInfo.PM_Associate = reader("PM_Associate").ToString
            objInfo.PM_Tel = reader("PM_Tel").ToString
            objInfo.PM_Fax = reader("PM_Fax").ToString
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

            If reader("PM_Rebate") Is DBNull.Value Then
                objInfo.PM_Rebate = 0
            Else
                objInfo.PM_Rebate = CSng(reader("PM_Rebate"))
            End If

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
                objInfo.PS_NoSendQty = 0
            Else
                objInfo.PS_NoSendQty = FormatNumber(CDbl(reader("PS_NoSendQty").ToString), 3, TriState.True)
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
                objInfo.PS_Tarriff = CDbl(reader("PS_Tarriff").ToString)
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
            objInfo.MaterialTypeID = reader("MaterialTypeID").ToString

            If reader("PM_OS_SendDate") Is DBNull.Value Then
                objInfo.PM_OS_SendDate = Nothing
            Else
                objInfo.PM_OS_SendDate = CDate(reader("PM_OS_SendDate").ToString)
            End If

            objInfo.BeginPurchaseDate = CDate(reader("BeginPurchaseDate").ToString)
            objInfo.EndPurchaseDate = CDate(reader("EndPurchaseDate").ToString)

            If reader("PSs_Date") Is DBNull.Value Then
                objInfo.PSs_Date = Nothing
            Else
                objInfo.PSs_Date = CDate(reader("PSs_Date").ToString)
            End If

            objInfo.PSs_Remark = reader("PSs_Remark").ToString

            objInfo.M_BatchID = reader("M_BatchID").ToString


            If reader("C_Qty") Is DBNull.Value Then
                objInfo.C_Qty = Nothing
            Else
                objInfo.C_Qty = CSng(reader("C_Qty").ToString)
            End If

            '2012-12-13
            If reader("HKDRate") Is DBNull.Value Then
                objInfo.HKDRate = 0
            Else
                objInfo.HKDRate = reader("HKDRate").ToString
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

        ''' <summary>
        '''採購單新增 
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PurchaseMain_Add(ByVal objFile1 As PurchaseMainInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PurchaseMain_Add")

                db.AddInParameter(dbComm, "@PM_NO", DbType.String, objFile1.PM_NO)
                db.AddInParameter(dbComm, "@PM_Associate", DbType.String, objFile1.PM_Associate)
                db.AddInParameter(dbComm, "@PM_Tel", DbType.String, objFile1.PM_Tel)
                db.AddInParameter(dbComm, "@PM_Fax", DbType.String, objFile1.PM_Fax)
                db.AddInParameter(dbComm, "@S_Supplier", DbType.String, objFile1.S_Supplier)
                If objFile1.PM_PurchaseDate = Nothing Then
                    db.AddInParameter(dbComm, "@PM_PurchaseDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@PM_PurchaseDate", DbType.Date, objFile1.PM_PurchaseDate)
                End If
                db.AddInParameter(dbComm, "@PM_Remark", DbType.String, objFile1.PM_Remark)
                db.AddInParameter(dbComm, "@PM_Action", DbType.String, objFile1.PM_Action)
                db.AddInParameter(dbComm, "@PM_ToFrom", DbType.String, objFile1.PM_ToFrom)
                db.AddInParameter(dbComm, "@PM_ComeType", DbType.String, objFile1.PM_ComeType)
                db.AddInParameter(dbComm, "@PM_PurchaseType", DbType.String, objFile1.PM_PurchaseType)
                db.AddInParameter(dbComm, "@PM_Version", DbType.Int16, objFile1.PM_Version)
                db.AddInParameter(dbComm, "@PM_Rebate", DbType.Double, objFile1.PM_Rebate)

                db.AddInParameter(dbComm, "@CO_ID", DbType.String, objFile1.CO_ID)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objFile1.PM_Type)

                db.ExecuteNonQuery(dbComm)
                PurchaseMain_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                PurchaseMain_Add = False
            End Try

        End Function

        ''' <summary>
        '''採購單基本修改
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PurchaseMain_Update(ByVal objFile1 As PurchaseMainInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PurchaseMain_Update")

                db.AddInParameter(dbComm, "@PM_NO", DbType.String, objFile1.PM_NO)
                db.AddInParameter(dbComm, "@PM_Associate", DbType.String, objFile1.PM_Associate)
                db.AddInParameter(dbComm, "@PM_Tel", DbType.String, objFile1.PM_Tel)
                db.AddInParameter(dbComm, "@PM_Fax", DbType.String, objFile1.PM_Fax)
                db.AddInParameter(dbComm, "@S_Supplier", DbType.String, objFile1.S_Supplier)
                If objFile1.PM_PurchaseDate = Nothing Then
                    db.AddInParameter(dbComm, "@PM_PurchaseDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@PM_PurchaseDate", DbType.Date, objFile1.PM_PurchaseDate)
                End If
                db.AddInParameter(dbComm, "@PM_Remark", DbType.String, objFile1.PM_Remark)
                db.AddInParameter(dbComm, "@PM_Action", DbType.String, objFile1.PM_Action)
                db.AddInParameter(dbComm, "@PM_ToFrom", DbType.String, objFile1.PM_ToFrom)
                db.AddInParameter(dbComm, "@PM_ComeType", DbType.String, objFile1.PM_ComeType)
                db.AddInParameter(dbComm, "@PM_PurchaseType", DbType.String, objFile1.PM_PurchaseType)
                'db.AddInParameter(dbComm, "@PM_Version", DbType.Int16, objFile1.PM_Version)

                db.AddInParameter(dbComm, "@PM_Rebate", DbType.Double, objFile1.PM_Rebate)
                db.AddInParameter(dbComm, "@CO_ID", DbType.String, objFile1.CO_ID)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objFile1.PM_Type)

                'db.AddInParameter(dbComm, "@PM_Check", DbType.Boolean, objFile1.PM_Check)
                'db.AddInParameter(dbComm, "@PM_CheckAction", DbType.String, objFile1.PM_CheckAction)
                'db.AddInParameter(dbComm, "@PM_CheckType", DbType.String, objFile1.PM_CheckType)
                'db.AddInParameter(dbComm, "@PM_CheckRemark", DbType.String, objFile1.PM_CheckRemark)

                'If objFile1.PM_CheckDate = Nothing Then
                '    db.AddInParameter(dbComm, "@PM_CheckDate", DbType.Date, DBNull.Value)
                'Else
                '    db.AddInParameter(dbComm, "@PM_CheckDate", DbType.Date, objFile1.PM_CheckDate)
                'End If


                'db.AddInParameter(dbComm, "@PM_AccountCheck", DbType.Boolean, objFile1.PM_AccountCheck)

                'db.AddInParameter(dbComm, "@PM_AccountCheckAction", DbType.String, objFile1.PM_AccountCheckAction)
                'db.AddInParameter(dbComm, "@PM_AccountCheckType", DbType.String, objFile1.PM_AccountCheckType)

                'If objFile1.PM_AccountCheckDate = Nothing Then
                '    db.AddInParameter(dbComm, "@PM_AccountCheckDate", DbType.Date, DBNull.Value)
                'Else
                '    db.AddInParameter(dbComm, "@PM_AccountCheckDate", DbType.Date, objFile1.PM_AccountCheckDate)
                'End If


                'db.AddInParameter(dbComm, "@PM_AccountCheckRemark", DbType.String, objFile1.PM_AccountCheckRemark)

                db.ExecuteNonQuery(dbComm)
                PurchaseMain_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                PurchaseMain_Update = False
            End Try

        End Function

        ''' <summary>
        '''採購單部門審核修改
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PurchaseMain_UpdateCheck(ByVal objFile1 As PurchaseMainInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PurchaseMain_UpdateCheck")

                db.AddInParameter(dbComm, "@PM_NO", DbType.String, objFile1.PM_NO)

                db.AddInParameter(dbComm, "@PM_Check", DbType.Boolean, objFile1.PM_Check)
                db.AddInParameter(dbComm, "@PM_CheckAction", DbType.String, objFile1.PM_CheckAction)
                db.AddInParameter(dbComm, "@PM_CheckType", DbType.String, objFile1.PM_CheckType)
                db.AddInParameter(dbComm, "@PM_CheckRemark", DbType.String, objFile1.PM_CheckRemark)

                If objFile1.PM_CheckDate = Nothing Then
                    db.AddInParameter(dbComm, "@PM_CheckDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@PM_CheckDate", DbType.Date, objFile1.PM_CheckDate)
                End If
                db.AddInParameter(dbComm, "@PM_Version", DbType.Int16, objFile1.PM_Version)
                db.ExecuteNonQuery(dbComm)
                PurchaseMain_UpdateCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                PurchaseMain_UpdateCheck = False
            End Try

        End Function

        ''' <summary>
        '''採購單會計審核修改
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PurchaseMain_UpdateAccCheck(ByVal objFile1 As PurchaseMainInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PurchaseMain_UpdateAccCheck")

                db.AddInParameter(dbComm, "@PM_NO", DbType.String, objFile1.PM_NO)

                db.AddInParameter(dbComm, "@PM_AccountCheck", DbType.Boolean, objFile1.PM_AccountCheck)

                db.AddInParameter(dbComm, "@PM_AccountCheckAction", DbType.String, objFile1.PM_AccountCheckAction)
                db.AddInParameter(dbComm, "@PM_AccountCheckType", DbType.String, objFile1.PM_AccountCheckType)

                If objFile1.PM_AccountCheckDate = Nothing Then
                    db.AddInParameter(dbComm, "@PM_AccountCheckDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@PM_AccountCheckDate", DbType.Date, objFile1.PM_AccountCheckDate)
                End If

                db.AddInParameter(dbComm, "@PM_AccountCheckRemark", DbType.String, objFile1.PM_AccountCheckRemark)

                db.ExecuteNonQuery(dbComm)
                PurchaseMain_UpdateAccCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                PurchaseMain_UpdateAccCheck = False
            End Try

        End Function


        ''' <summary>
        ''' 採購單刪除
        ''' </summary>
        ''' <param name="PM_NO"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PurchaseMain_Delete(ByVal PM_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PurchaseMain_Delete")
                db.AddInParameter(dbComm, "@PM_NO", DbType.String, PM_NO)
                db.ExecuteNonQuery(dbComm)
                PurchaseMain_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PurchaseMain_Delete = False
            End Try
        End Function

        ''' <summary>
        '''sub新增 
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PurchaseSub_Add(ByVal objFile1 As PurchaseMainInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PurchaseSub_Add")

                db.AddInParameter(dbComm, "@PS_NO", DbType.String, objFile1.PS_NO)
                db.AddInParameter(dbComm, "@PM_NO", DbType.String, objFile1.PM_NO)
                db.AddInParameter(dbComm, "@Q_QuoID", DbType.String, objFile1.Q_QuoID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)
                db.AddInParameter(dbComm, "@S_SupplierNo", DbType.String, objFile1.S_SupplierNo)
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)
                'db.AddInParameter(dbComm, "@M_Unit", DbType.String, objFile1.M_Unit)
                'db.AddInParameter(dbComm, "@M_Name", DbType.String, objFile1.M_Name)
                'db.AddInParameter(dbComm, "@M_Gauge", DbType.String, objFile1.M_Gauge)

                db.AddInParameter(dbComm, "@PN_NO", DbType.String, objFile1.PN_NO)
                db.AddInParameter(dbComm, "@DPT_ID", DbType.String, objFile1.DPT_ID)
                db.AddInParameter(dbComm, "@U_ID", DbType.String, objFile1.U_ID)
                db.AddInParameter(dbComm, "@PS_NeedPurchaseUse", DbType.String, objFile1.PS_NeedPurchaseUse)
                db.AddInParameter(dbComm, "@C_ID", DbType.String, objFile1.C_ID)
                db.AddInParameter(dbComm, "@PS_QTY", DbType.Double, objFile1.PS_QTY)

                db.AddInParameter(dbComm, "@PS_NoSendQty", DbType.Single, objFile1.PS_NoSendQty)
                db.AddInParameter(dbComm, "@PS_Price", DbType.Double, objFile1.PS_Price)


                If objFile1.PS_SendDate = Nothing Then
                    db.AddInParameter(dbComm, "@PS_SendDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@PS_SendDate", DbType.Date, objFile1.PS_SendDate)
                End If

                db.AddInParameter(dbComm, "@PS_Depict", DbType.String, objFile1.PS_Depict)
                db.AddInParameter(dbComm, "@PS_Detail", DbType.String, objFile1.PS_Detail)

                db.AddInParameter(dbComm, "@PS_Tarriff", DbType.Double, objFile1.PS_Tarriff)
                db.AddInParameter(dbComm, "@PS_TffCost", DbType.Double, objFile1.PS_TffCost)
                db.AddInParameter(dbComm, "@PS_AmountBf", DbType.Double, objFile1.PS_AmountBf)
                db.AddInParameter(dbComm, "@PS_AmountAf", DbType.Double, objFile1.PS_AmountAf)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objFile1.PM_M_Code)

                db.ExecuteNonQuery(dbComm)
                PurchaseSub_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                PurchaseSub_Add = False
            End Try

        End Function

        ''' <summary>
        '''sub修改 
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PurchaseSub_Update(ByVal objFile1 As PurchaseMainInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PurchaseSub_Update")
                db.AddInParameter(dbComm, "@PS_NO", DbType.String, objFile1.PS_NO)
                db.AddInParameter(dbComm, "@PM_NO", DbType.String, objFile1.PM_NO)
                db.AddInParameter(dbComm, "@Q_QuoID", DbType.String, objFile1.Q_QuoID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)
                db.AddInParameter(dbComm, "@S_SupplierNo", DbType.String, objFile1.S_SupplierNo)
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)
                'db.AddInParameter(dbComm, "@M_Unit", DbType.String, objFile1.M_Unit)
                'db.AddInParameter(dbComm, "@M_Name", DbType.String, objFile1.M_Name)
                'db.AddInParameter(dbComm, "@M_Gauge", DbType.String, objFile1.M_Gauge)

                db.AddInParameter(dbComm, "@PN_NO", DbType.String, objFile1.PN_NO)
                db.AddInParameter(dbComm, "@DPT_ID", DbType.String, objFile1.DPT_ID)
                db.AddInParameter(dbComm, "@U_ID", DbType.String, objFile1.U_ID)
                db.AddInParameter(dbComm, "@PS_NeedPurchaseUse", DbType.String, objFile1.PS_NeedPurchaseUse)
                db.AddInParameter(dbComm, "@C_ID", DbType.String, objFile1.C_ID)
                db.AddInParameter(dbComm, "@PS_QTY", DbType.Double, objFile1.PS_QTY)

                db.AddInParameter(dbComm, "@PS_NoSendQty", DbType.Double, objFile1.PS_NoSendQty)
                db.AddInParameter(dbComm, "@PS_Price", DbType.Double, objFile1.PS_Price)


                If objFile1.PS_SendDate = Nothing Then
                    db.AddInParameter(dbComm, "@PS_SendDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@PS_SendDate", DbType.Date, objFile1.PS_SendDate)
                End If

                db.AddInParameter(dbComm, "@PS_Depict", DbType.String, objFile1.PS_Depict)
                db.AddInParameter(dbComm, "@PS_Detail", DbType.String, objFile1.PS_Detail)

                db.AddInParameter(dbComm, "@PS_Tarriff", DbType.Double, objFile1.PS_Tarriff)
                db.AddInParameter(dbComm, "@PS_TffCost", DbType.Double, objFile1.PS_TffCost)
                db.AddInParameter(dbComm, "@PS_AmountBf", DbType.Double, objFile1.PS_AmountBf)
                db.AddInParameter(dbComm, "@PS_AmountAf", DbType.Double, objFile1.PS_AmountAf)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objFile1.PM_M_Code)
                db.ExecuteNonQuery(dbComm)
                PurchaseSub_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                PurchaseSub_Update = False
            End Try

        End Function

        ''' <summary>
        ''' sub刪除
        ''' </summary>
        ''' <param name="PM_NO"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PurchaseSub_Delete(ByVal PM_NO As String, ByVal PS_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PurchaseSub_Delete")
                db.AddInParameter(dbComm, "@PM_NO", DbType.String, PM_NO)
                db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
                db.ExecuteNonQuery(dbComm)
                PurchaseSub_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PurchaseSub_Delete = False
            End Try
        End Function


        Public Function UpdatePurchase_NoSendQty(ByVal objinfo As PurchaseMainInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("UpdatePurchase_NoSendQty2")

                db.AddInParameter(dbComm, "@PM_NO", DbType.String, objinfo.PM_NO)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@PS_NoSendQty", DbType.Double, objinfo.PS_NoSendQty)
                db.AddInParameter(dbComm, "@PS_Price", DbType.Double, objinfo.PS_Price)

                db.AddInParameter(dbComm, "@C_Qty", DbType.Single, objinfo.C_Qty)

                db.ExecuteNonQuery(dbComm)
                UpdatePurchase_NoSendQty = True
            Catch ex As Exception
                MsgBox(ex.Message)
                UpdatePurchase_NoSendQty = False
            End Try
          
        End Function

        Public Function PurchaseSub_GetList(ByVal PM_NO As String, ByVal PN_NO As String, ByVal M_Code As String) As List(Of PurchaseMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PurchaseSub_GetList")

            db.AddInParameter(dbComm, "@PM_NO", DbType.String, PM_NO)
            db.AddInParameter(dbComm, "@PN_NO", DbType.String, PN_NO)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)

            Dim FeatureList As New List(Of PurchaseMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPurchaseMain(reader))
                End While
                Return FeatureList
            End Using

        End Function

    End Class
End Namespace

