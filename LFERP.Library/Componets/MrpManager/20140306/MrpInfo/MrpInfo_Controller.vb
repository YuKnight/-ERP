Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Imports System.Collections
Imports LFERP.Library.MrpManager.MrpSetting

Namespace LFERP.Library.MrpManager.MrpInfo
    Public Class MrpInfoController

        Friend Function FillMrpInfo(ByVal reader As IDataReader) As MRPInfoInfo
            Try
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
                objInfo.MI_Remarks = reader("MI_Remarks").ToString
                objInfo.MI_ForecastID = reader("MI_ForecastID").ToString
                If IsDBNull(reader("MI_CalcType")) Then
                    objInfo.MI_CalcType = 0
                Else
                    objInfo.MI_CalcType = CInt(reader("MI_CalcType"))
                End If
                objInfo.MI_WareID = reader("MI_WareID").ToString
                Return objInfo
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:FillMrpInfo方法出錯")
                Return Nothing
            End Try
        End Function

        Public Function MrpInfo_GetList(ByVal MRP_ID As String, ByVal BeginDate As DateTime, ByVal CheckType As String, ByVal MrpType As String, ByVal MI_CreateUserID As String) As List(Of MRPInfoInfo)
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpInfo_GetList")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                If BeginDate = Nothing Then
                    db.AddInParameter(dbComm, "@BeginDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@BeginDate", DbType.Date, BeginDate)
                End If
                db.AddInParameter(dbComm, "@CheckType", DbType.String, CheckType)
                db.AddInParameter(dbComm, "@MrpType", DbType.String, MrpType)
                db.AddInParameter(dbComm, "@MI_CreateUserID ", DbType.String, MI_CreateUserID)
                Dim FeatureList As New List(Of MRPInfoInfo)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        FeatureList.Add(FillMrpInfo(reader))
                    End While
                    Return FeatureList
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:MrpInfo_GetList方法出錯")
                Return Nothing
            End Try
           
        End Function

        Public Function MrpInfo_Delete(ByVal MRP_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpInfo_Delete")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                db.ExecuteNonQuery(dbComm)
                MrpInfo_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:MrpInfo_Delete方法出錯")
                MrpInfo_Delete = False
            End Try
        End Function

        Public Function MrpInfo_Update(ByVal objinfo As MRPInfoInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpInfo_Update")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objinfo.MRP_ID)
                If objinfo.MI_MRPDate = Nothing Then
                    db.AddInParameter(dbComm, "@MI_MRPDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@MI_MRPDate", DbType.Date, objinfo.MI_MRPDate)
                End If
                db.AddInParameter(dbComm, "@MI_LogTxt", DbType.String, objinfo.MI_LogTxt)
                If objinfo.MI_NeedBeginDate = Nothing Then
                    db.AddInParameter(dbComm, "@MI_NeedBeginDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@MI_NeedBeginDate", DbType.Date, objinfo.MI_NeedBeginDate)
                End If
                If objinfo.MI_NeedEndDate = Nothing Then
                    db.AddInParameter(dbComm, "@MI_NeedEndDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@MI_NeedEndDate", DbType.Date, objinfo.MI_NeedEndDate)
                End If
                db.AddInParameter(dbComm, "@MI_MRPType", DbType.String, objinfo.MI_MRPType)
                db.AddInParameter(dbComm, "@MI_ModifyUserID", DbType.String, objinfo.MI_ModifyUserID)
                db.AddInParameter(dbComm, "@MI_Remarks", DbType.String, objinfo.MI_Remarks)
                db.AddInParameter(dbComm, "@MI_ForecastID ", DbType.String, objinfo.MI_ForecastID)
                db.AddInParameter(dbComm, "@MI_CalcType", DbType.Int16, objinfo.MI_CalcType)
                db.AddInParameter(dbComm, "@MI_WareID ", DbType.String, objinfo.MI_WareID)
                db.ExecuteNonQuery(dbComm)
                MrpInfo_Update = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:MrpInfo_Update方法出錯")
                MrpInfo_Update = False
            End Try
        End Function

        Public Function MrpInfo_Add(ByVal objInfo As MRPInfoInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpInfo_Add")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objInfo.MRP_ID)
                If objInfo.MI_MRPDate = Nothing Then
                    db.AddInParameter(dbComm, "@MI_MRPDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@MI_MRPDate", DbType.Date, objInfo.MI_MRPDate)
                End If
                db.AddInParameter(dbComm, "@MI_LogTxt", DbType.String, objInfo.MI_LogTxt)
                If objInfo.MI_NeedBeginDate = Nothing Then
                    db.AddInParameter(dbComm, "@MI_NeedBeginDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@MI_NeedBeginDate", DbType.Date, objInfo.MI_NeedBeginDate)
                End If
                If objInfo.MI_NeedEndDate = Nothing Then
                    db.AddInParameter(dbComm, "@MI_NeedEndDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@MI_NeedEndDate", DbType.Date, objInfo.MI_NeedEndDate)
                End If
                db.AddInParameter(dbComm, "@MI_MRPType", DbType.String, objInfo.MI_MRPType)
                db.AddInParameter(dbComm, "@MI_CreateUserID", DbType.String, objInfo.MI_CreateUserID)
                db.AddInParameter(dbComm, "@MI_Remarks", DbType.String, objInfo.MI_Remarks)
                db.AddInParameter(dbComm, "@MI_ForecastID ", DbType.String, objInfo.MI_ForecastID)
                db.AddInParameter(dbComm, "@MI_CalcType", DbType.Int16, objInfo.MI_CalcType)
                db.AddInParameter(dbComm, "@MI_WareID ", DbType.String, objInfo.MI_WareID)
                db.ExecuteNonQuery(dbComm)
                MrpInfo_Add = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:MrpInfo_Add方法出錯")
                MrpInfo_Add = False
            End Try
        End Function

        Public Function MrpInfo_UpdateCheck(ByVal objInfo As MRPInfoInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpInfo_UpdateCheck")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objInfo.MRP_ID)
                db.AddInParameter(dbComm, "@MI_CheckUserID", DbType.String, objInfo.MI_CheckUserID)
                db.AddInParameter(dbComm, "@MI_CheckBit", DbType.Boolean, objInfo.MI_CheckBit)
                db.AddInParameter(dbComm, "@MI_CheckRemark", DbType.String, objInfo.MI_CheckRemark)
                db.ExecuteNonQuery(dbComm)
                MrpInfo_UpdateCheck = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:MrpInfo_UpdateCheck方法出錯")
                MrpInfo_UpdateCheck = False
            End Try
        End Function

        Public Function MrpInfo_GetID() As String
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MRPInfo_GetID")
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    If reader.Read Then
                        Return reader("MRP_ID").ToString
                    Else
                        Return Nothing
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:MrpInfo_GetID方法出錯")
                Return Nothing
            End Try
        End Function

        Public Function GetMaterialInfo() As DataTable
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetSqlStringCommand("select M_Code,M_Name,M_Gauge,M_Unit from MaterialCode")
            Return db.ExecuteDataSet(dbcomm).Tables(0)
        End Function

        Public Function GetMrpWareHouseID(ByVal MRP_ID As String) As String
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetSqlStringCommand("select Ware_ID from MrpWareHouseInfo where MRP_ID='" + MRP_ID + "'")
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                If reader.Read Then
                    Return reader(0).ToString
                End If
                If reader.read Then
                    Return "false"
                End If
                Return ""
            End Using          
        End Function

#Region "MRP運算"
        Public dt As New DataTable
        Public MRP_ID As String
        Public userID As String


#Region "MRP運算時取得產品明細"
        Public Sub GetBills(ByVal needBeginDate As Date, ByVal needEndDate As Date, ByVal CheckType As String, ByVal Cancellation As String, ByVal ForecastID As String)
            dt.Rows.Clear()
            Dim row As DataRow
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("MRP_GetBills")
                If needBeginDate = Nothing Then
                    db.AddInParameter(dbcomm, "@NeedBeginDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbcomm, "@NeedBeginDate", DbType.Date, needBeginDate)
                End If
                If needEndDate = Nothing Then
                    db.AddInParameter(dbcomm, "@NeedEndDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbcomm, "@NeedEndDate", DbType.Date, needEndDate)
                End If
                db.AddInParameter(dbcomm, "@ForecastID ", DbType.String, ForecastIDAddQuote(ForecastID))
                db.AddInParameter(dbcomm, "@CheckType", DbType.String, CheckType)
                db.AddInParameter(dbcomm, "@Cancellation", DbType.String, Cancellation)
                Using reader As IDataReader = db.ExecuteReader(dbcomm)
                    While reader.Read
                        row = dt.NewRow()
                        row("AutoID") = 0
                        row("MRP_ID") = MRP_ID
                        row("M_Code") = reader("M_Code").ToString
                        row("M_Name") = reader("M_Name").ToString
                        row("M_Gauge") = reader("M_Gauge").ToString
                        row("M_Unit") = reader("M_Unit").ToString
                        row("Source") = reader("Source").ToString
                        row("MRPQty") = IIf(IsDBNull(reader("MI_Qty")), 0, CDec(reader("MI_Qty")))
                        row("MP_InventoryQty") = IIf(IsDBNull(reader("InventoryQty")), 0, CDec(reader("InventoryQty")))
                        dt.Rows.Add(row)
                    End While
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Proc:MRP_GetBills")
            End Try       
        End Sub
#End Region

#Region "獲取訂單信息"
        Private customerName As String
        Private OD_ID As String
        Private MOB_ForecastID As String
        Private MOB_NeedDate As String
        Private M_Name As String
        Private M_Gauge As String
        Private M_Unit As String
        Private Source As String
        Public Sub GetOrderBills(ByVal needBeginDate As Date, ByVal needEndDate As Date, ByVal CheckType As String, ByVal Cancellation As String, ByVal ForecastID As String)
            dt.Rows.Clear()
            Dim row As DataRow
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("MRP_GetOrderBills")
                If needBeginDate = Nothing Then
                    db.AddInParameter(dbcomm, "@NeedBeginDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbcomm, "@NeedBeginDate", DbType.Date, needBeginDate)
                End If
                If needEndDate = Nothing Then
                    db.AddInParameter(dbcomm, "@NeedEndDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbcomm, "@NeedEndDate", DbType.Date, needEndDate)
                End If
                db.AddInParameter(dbcomm, "@ForecastID ", DbType.String, ForecastIDAddQuote(ForecastID))
                db.AddInParameter(dbcomm, "@CheckType", DbType.String, CheckType)
                db.AddInParameter(dbcomm, "@Cancellation", DbType.String, Cancellation)
                Using reader As SqlDataReader = db.ExecuteReader(dbcomm)
                    While reader.Read
                        row = dt.NewRow()
                        row("AutoID") = 0
                        row("MRP_ID") = MRP_ID
                        row("OD_ID") = IIf(IsDBNull(reader("OD_ID")), Nothing, reader("OD_ID").ToString)
                        row("MOB_ForecastID") = reader("MOB_ForecastID").ToString
                        row("MOB_NeedDate") = Format(CDate(reader("MOB_NeedDate")), "yyyy/MM/dd")
                        row("customerName") = IIf(IsDBNull(reader("customerName")), Nothing, reader("customerName").ToString)
                        row("M_Code") = reader("M_Code").ToString
                        row("MRPQty") = IIf(IsDBNull(reader("MI_Qty")), 0, CDec(reader("MI_Qty")))
                        row("M_Name") = reader("M_Name").ToString
                        row("M_Gauge") = reader("M_Gauge").ToString
                        row("M_Unit") = reader("M_Unit").ToString
                        row("Source") = reader("Source").ToString
                        dt.Rows.Add(row)
                    End While
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Proc：MRP_GetOrderBills")
            End Try
        End Sub
#End Region

#Region "MRP運算時取得獨立需求"
        Public Sub GetIndReq(ByVal needBeginDate As Date, ByVal needEndDate As Date, ByVal CheckType As String, ByVal Cancellation As String, ByVal ForecastID As String)
            dt.Rows.Clear()
            Dim row As DataRow
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("Mrp_GetIndReq")
                If needBeginDate = Nothing Then
                    db.AddInParameter(dbcomm, "@NeedBeginDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbcomm, "@NeedBeginDate", DbType.Date, needBeginDate)
                End If
                If needEndDate = Nothing Then
                    db.AddInParameter(dbcomm, "@NeedEndDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbcomm, "@NeedEndDate", DbType.Date, needEndDate)
                End If
                db.AddInParameter(dbcomm, "@CheckType", DbType.String, CheckType)
                db.AddInParameter(dbcomm, "@Cancellation", DbType.String, Cancellation)
                db.AddInParameter(dbcomm, "@ForecastID ", DbType.String, ForecastIDAddQuote(ForecastID))
                Using reader As IDataReader = db.ExecuteReader(dbcomm)
                    While reader.Read
                        row = dt.NewRow()
                        row("AutoID") = 0
                        row("MRP_ID") = MRP_ID
                        row("PID") = reader("PID").ToString
                        row("ID") = reader("ID").ToString
                        row("sonsNum") = reader("sonsNum").ToString
                        row("ForecastID") = reader("ForecastID").ToString
                        row("NeedDate") = IIf(IsDBNull(reader("NeedDate")), Nothing, CDate(reader("NeedDate")))
                        If IsDBNull(reader("InvalidDate")) = True Then
                            row("InvalidDate") = DBNull.Value
                        Else
                            row("InvalidDate") = CDate(reader("InvalidDate"))
                        End If
                        row("M_Code") = reader("M_Code").ToString
                        row("NeedQty") = IIf(IsDBNull(reader("NeedQty")), 0, reader("NeedQty"))
                        row("Source") = reader("Source").ToString
                        row("M_Name") = reader("M_Name").ToString
                        row("M_Gauge") = reader("M_Gauge").ToString
                        row("M_Unit") = reader("M_Unit").ToString
                        dt.Rows.Add(row)
                    End While
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Proc:Mrp_GetIndReq")
            End Try

        End Sub
#End Region

#Region "取得要轉庫存記錄的資料"
        Public Function Mrp_GetMrpInfoWareHouse(ByVal needBeginDate As Date, ByVal needEndDate As Date, ByVal CheckType As String, ByVal Cancellation As String, ByVal ForecastID As String) As DataTable
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("Mrp_GetMrpInfoWareHouse")
                If needBeginDate = Nothing Then
                    db.AddInParameter(dbcomm, "@NeedBeginDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbcomm, "@NeedBeginDate", DbType.Date, needBeginDate)
                End If
                If needEndDate = Nothing Then
                    db.AddInParameter(dbcomm, "@NeedEndDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbcomm, "@NeedEndDate", DbType.Date, needEndDate)
                End If
                db.AddInParameter(dbcomm, "@ForecastID ", DbType.String, ForecastIDAddQuote(ForecastID))
                db.AddInParameter(dbcomm, "@CheckType", DbType.String, CheckType)
                db.AddInParameter(dbcomm, "@Cancellation", DbType.String, Cancellation)
                Return db.ExecuteDataSet(dbcomm).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Proc:Mrp_GetMrpInfoWareHouse")
                Return Nothing
            End Try
        End Function
#End Region

#Region "對臨時表按指定列分組"
        Public Sub TableGroupby(ByVal columns As String, ByVal table As DataTable)
            Dim tempBo As Boolean = False
            Dim i, j As Integer
            Dim row As DataRow
            For i = 0 To table.Rows.Count - 1
                row = table.Rows(i)
                If row("M_Code").ToString = "IsEmpty" Then
                    Continue For
                End If

                For j = i + 1 To table.Rows.Count - 1
                    If (row("M_Code").ToString = "1") Then
                    End If
                    Select Case columns
                        Case "1"
                            tempBo = row("M_Code").ToString.Trim.Equals(table.Rows(j)("M_Code").ToString.Trim)
                            'Case "2"
                            '    tempBo = row("OD_ID").Equals(table.Rows(j)("OD_ID")) And row("M_Code").Equals(table.Rows(j)("M_Code"))
                        Case "3"
                            tempBo = row("MOB_ForecastID").Equals(table.Rows(j)("MOB_ForecastID")) And row("M_Code").Equals(table.Rows(j)("M_Code")) And row("MOB_NeedDate").Equals(table.Rows(j)("MOB_NeedDate"))
                    End Select
                    If tempBo = True Then
                        table.Rows(j)("MRPQty") = CDec(row("MRPQty")) + CDec(table.Rows(j)("MRPQty"))
                        row("M_Code") = "IsEmpty"
                        row = table.Rows(j)
                    End If
                Next
            Next
            Dim filterString As String = "M_Code not in ('IsEmpty')"
            table.DefaultView.RowFilter = filterString
        End Sub
#End Region

#Region "MRP運算時取得請購建議表"
        Public Sub GetPurchaseMaterial(ByVal needBeginDate As Date, ByVal needEndDate As Date, ByVal CheckType As String, ByVal Cancellation As String, ByVal ForecastID As String, ByVal WareID As String)
            dt.Rows.Clear()
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("Mrp_GetIndReq")
                If needBeginDate = Nothing Then
                    db.AddInParameter(dbcomm, "@NeedBeginDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbcomm, "@NeedBeginDate", DbType.Date, needBeginDate)
                End If
                If needEndDate = Nothing Then
                    db.AddInParameter(dbcomm, "@NeedEndDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbcomm, "@NeedEndDate", DbType.Date, needEndDate)
                End If
                db.AddInParameter(dbcomm, "@CheckType", DbType.String, CheckType)
                db.AddInParameter(dbcomm, "@Cancellation", DbType.String, Cancellation)
                If ForecastID = Nothing Then
                    db.AddInParameter(dbcomm, "@ForecastID ", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbcomm, "@ForecastID ", DbType.String, ForecastIDAddQuote(ForecastID))
                End If
                db.AddInParameter(dbcomm, "@sonsNum", DbType.Int16, 0)
                Using reader As IDataReader = db.ExecuteReader(dbcomm)
                    While reader.Read
                        GetPurchaseQty(reader("M_Code").ToString, CDec(reader("NeedQty")), WareID)
                    End While
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Proc:Mrp_GetIndReq")
            End Try
        End Sub

        Private Sub GetPurchaseQty(ByVal M_Code As String, ByVal NeedQty As Decimal, ByVal WareID As String)
            Try
                Dim row As DataRow
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("Mrp_GetPurchaseQty")
                db.AddInParameter(dbcomm, "@M_Code", DbType.String, M_Code)
                db.AddInParameter(dbcomm, "@NeedQty", DbType.Decimal, NeedQty)
                db.AddInParameter(dbcomm, "@WareID", DbType.String, WareID)
                Using reader As IDataReader = db.ExecuteReader(dbcomm)
                    If reader.Read Then
                        row = dt.NewRow
                        row("MRP_ID") = MRP_ID
                        row("AutoID") = 0
                        row("M_Code") = reader("M_Code").ToString
                        row("M_Name") = IIf(IsDBNull(reader("M_Name")), "", reader("M_Name").ToString)
                        row("M_Gauge") = IIf(IsDBNull(reader("M_Gauge")), "", reader("M_Gauge").ToString)
                        row("M_Unit") = IIf(IsDBNull(reader("M_Unit")), "", reader("M_Unit").ToString)
                        row("Source") = IIf(IsDBNull(reader("Source")), "", reader("Source").ToString)
                        row("MP_NeedQty") = IIf(IsDBNull(reader("MP_NeedQty")), 0, reader("MP_NeedQty"))
                        row("MP_InventoryQty") = IIf(IsDBNull(reader("MP_InventoryQty")), 0, reader("MP_InventoryQty"))
                        row("MP_InTransitQty") = IIf(IsDBNull(reader("MP_IntransitQty")), 0, reader("MP_IntransitQty"))
                        row("MP_Inspection") = IIf(IsDBNull(reader("MP_Inspection")), 0, reader("MP_Inspection"))
                        row("MP_NoCollar") = IIf(IsDBNull(reader("MP_NoCollar")), 0, reader("MP_NoCollar"))
                        row("MP_RetreatQty") = IIf(IsDBNull(reader("MP_RetreatQty")), 0, reader("MP_RetreatQty"))
                        row("MP_SecInv") = IIf(IsDBNull(reader("MC_SecInv")), 0, reader("MC_SecInv"))
                        row("MP_LowLimit") = IIf(IsDBNull(reader("MC_LowLimit")), 0, reader("MC_LowLimit"))
                        row("MP_BatchQty") = IIf(IsDBNull(reader("MC_BatchQty")), 0, reader("MC_BatchQty"))
                        row("MP_BatFixEconomy") = IIf(IsDBNull(reader("MC_BatFixEconomy")), 0, reader("MC_BatFixEconomy"))
                        row("MP_OrderMax") = IIf(IsDBNull(reader("MC_OrderMax")), 0, reader("MC_OrderMax"))
                        row("MP_OrderMin") = IIf(IsDBNull(reader("MC_OrderMin")), 0, reader("MC_OrderMin"))
                        row("MP_RelatedQty") = IIf(IsDBNull(reader("MP_RelatedQty")), 0, reader("MP_RelatedQty"))
                        row("MP_MRPQty") = GetMrpQtyFormula(CDec(row("MP_NeedQty")), CDec(row("MP_InventoryQty")), CDec(row("MP_RetreatQty")), CDec(row("MP_InTransitQty")), CDec(row("MP_Inspection")), CDec(row("MP_NoCollar")), CDec(row("MP_RelatedQty")))
                        dt.Rows.Add(row)
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Proc：Mrp_GetPurchaseQty")
            End Try
        End Sub
#End Region

#Region "取得MRP凈需求計算公式"
        Private Function GetMrpQtyFormula(ByVal needQty As Decimal, ByVal inventoryQty As Decimal, ByVal retreatQty As Decimal, ByVal inTransitQty As Decimal, ByVal inspection As Decimal, ByVal noCollar As Decimal, ByVal RelatedQty As Decimal) As Decimal
            Dim msi As New MrpSettingInfo
            Dim msc As New MrpSettingController
            msi = msc.MrpSetting_GetList(userID)(0)
            If msi.needQtyEnable = True Then
                GetMrpQtyFormula = needQty
            End If
            If msi.inventoryQtyEnable = True Then
                GetMrpQtyFormula = GetMrpQtyFormula - inventoryQty
            End If
            If msi.retreatQtyEnable = True Then
                GetMrpQtyFormula = GetMrpQtyFormula + retreatQty
            End If
            If msi.inTransitQtyEnable = True Then
                GetMrpQtyFormula = GetMrpQtyFormula - inTransitQty
            End If
            If msi.inspectionEnable = True Then
                GetMrpQtyFormula = GetMrpQtyFormula - inspection
            End If
            If msi.noCollarEnable = True Then
                GetMrpQtyFormula = GetMrpQtyFormula + noCollar
            End If
            If msi.relatedQtyEnable = True Then
                GetMrpQtyFormula = GetMrpQtyFormula - RelatedQty
            End If
        End Function
#End Region

#Region "給每個ForecastID加單引號"
        Private Function ForecastIDAddQuote(ByVal ForecastID As String) As String
            If ForecastID Is Nothing = False Then
                Dim n As Int16
                n = ForecastID.Length - ForecastID.Replace(",", "").Length + 1
                Dim list(n) As String
                list = ForecastID.Split(",")
                ForecastID = ""
                For i As Integer = 0 To list.Length - 1
                    ForecastID += "'" + list(i) + "',"
                Next
                ForecastID = ForecastID.Remove(ForecastID.LastIndexOf(","), 1)
            End If
            Return ForecastID
        End Function
#End Region

#Region "Mrp運算稽核"
        Public Function Mrp_ExamineForecastOrder(ByVal needBeginDate As Date, ByVal needEndDate As Date, ByVal CheckType As String, ByVal Cancellation As String, ByVal ForecastID As String) As DataSet
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("MRP_GetOrderBills")
                If needBeginDate = Nothing Then
                    db.AddInParameter(dbcomm, "@NeedBeginDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbcomm, "@NeedBeginDate", DbType.Date, needBeginDate)
                End If
                If needEndDate = Nothing Then
                    db.AddInParameter(dbcomm, "@NeedEndDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbcomm, "@NeedEndDate", DbType.Date, needEndDate)
                End If
                db.AddInParameter(dbcomm, "@ForecastID ", DbType.String, ForecastIDAddQuote(ForecastID))
                db.AddInParameter(dbcomm, "@CheckType", DbType.String, CheckType)
                db.AddInParameter(dbcomm, "@Cancellation", DbType.String, Cancellation)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "中間層：Mrp_ExamineForecastOrder")
            End Try
        End Function
#End Region

#End Region

    End Class
End Namespace