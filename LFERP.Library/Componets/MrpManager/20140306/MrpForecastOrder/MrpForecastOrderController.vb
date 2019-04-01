Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Namespace LFERP.Library.MrpManager.MrpForecastOrder
    Public Class MrpForecastOrderController

#Region "信息的填充"
        ''' <summary>
        ''' 函數：預測訂單信息的填充
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns>MrpForecastOrderInfo</returns>
        ''' <remarks></remarks>
        Friend Function FillMrpForecastOrder(ByVal reader As IDataReader) As MrpForecastOrderInfo

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
        ''' <summary>
        ''' 函數：客戶中文名信息的填充
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Function FillCusterNameList(ByVal reader As IDataReader) As MrpForecastOrderInfo
            Dim objInfo As New MrpForecastOrderInfo
            objInfo.MO_CusterName = reader("CusterName").ToString
            objInfo.MO_CusterID = reader("CusterID").ToString
            Return objInfo
        End Function

        Friend Function FillMrpForecastOrderisCheck(ByVal reader As IDataReader) As MrpForecastOrderInfo
            Dim objInfo As New MrpForecastOrderInfo
            objInfo.CheckBit = reader("CheckBit")
            Return objInfo
        End Function

#End Region

#Region "查詢"
        ''' <summary>
        ''' 查詢所有預測訂單信息
        ''' </summary>
        ''' <param name="ForecastID"></param>
        ''' <param name="date1"></param>
        ''' <param name="date2"></param>
        ''' <returns> List(Of MrpForecastOrderInfo)</returns>
        ''' <remarks></remarks>
        Public Function MrpForecastOrder_GetList(ByVal ForecastID As String, ByVal date1 As Date, ByVal date2 As Date, ByVal CheckBit As Boolean, ByVal MO_PlanType As Boolean, ByVal StrCusterID As String) As List(Of MrpForecastOrderInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpForecastOrder_GetList")
            db.AddInParameter(dbComm, "@ForecastID", DbType.String, ForecastID)
            If date1 <> Nothing Then
                db.AddInParameter(dbComm, "@Date1", DbType.Date, date1)
            End If
            If date2 <> Nothing Then
                db.AddInParameter(dbComm, "@Date2", DbType.Date, date2)
            End If

            If CheckBit <> Nothing Then
                db.AddInParameter(dbComm, "@CheckBit", DbType.Boolean, CheckBit)
            End If
            If MO_PlanType <> Nothing Then
                db.AddInParameter(dbComm, "@MO_PlanType", DbType.Boolean, MO_PlanType)
            End If
            If StrCusterID <> Nothing Then
                StrCusterID = "( " + StrCusterID + " )"
                db.AddInParameter(dbComm, "@StrCusterID", DbType.String, StrCusterID)
            End If
            Dim FeatureList As New List(Of MrpForecastOrderInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMrpForecastOrder(reader))
                End While
                Return FeatureList
            End Using
        End Function

        ''' <summary>
        ''' 函數：獲得新的預測訂單號
        ''' </summary>
        ''' <returns>NewForecastID</returns>
        ''' <remarks></remarks>
        Public Function MrpForecastOrder_GetMONum() As String
            Try
                Dim MONum As String
                Dim NewForecastID As String = String.Empty
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpForecastOrder_GetMONum")

                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        MONum = reader("MONum").ToString
                    End While
                End Using
                If MONum = String.Empty Then
                    NewForecastID = "MO" + Format(Now, "yyyyMM") + "0001"
                    Return NewForecastID
                    Exit Function
                End If
                If CInt(Format(Now, "yyyyMM")) <= CInt(MONum) Then
                    NewForecastID = "MO" + (CInt(MONum) + 1).ToString
                Else
                    NewForecastID = "MO" + Format(Now, "yyyyMM") + "0001"
                End If
                Return NewForecastID
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function
        ''' <summary>
        ''' 通過CusterID獲得客戶的中文名
        ''' </summary>
        ''' <param name="CusterID"></param>
        ''' <param name="CusterName"></param>
        ''' <returns> List(Of MrpForecastOrderInfo)</returns>
        ''' <remarks></remarks>
        Public Function CusterGetName(ByVal CusterID As String, ByVal CusterName As String) As List(Of MrpForecastOrderInfo)
            Try
                Dim CusterNameList As New List(Of MrpForecastOrderInfo)
                Dim i As Integer = 0
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Custer_GetName")
                db.AddInParameter(dbComm, "@CusterID", DbType.String, CusterID)
                db.AddInParameter(dbComm, "@CusterName", DbType.String, CusterName)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        CusterNameList.Add(FillCusterNameList(reader))
                    End While
                    Return CusterNameList
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try

        End Function


        ''' <summary>
        ''' 通過ForecastID獲得審核狀態
        ''' </summary>
        ''' <param name="ForecastID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MrpForecastOrder_GetIScheck(ByVal ForecastID As String) As Boolean
            Try
                Dim CusterNameList As New List(Of MrpForecastOrderInfo)
                Dim i As Integer = 0
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpForecastOrder_GetIScheck")
                db.AddInParameter(dbComm, "@ForecastID", DbType.String, ForecastID)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        CusterNameList.Add(FillMrpForecastOrderisCheck(reader))
                    End While
                    Return CusterNameList(0).CheckBit
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function


        Public Function GetWeekInfo(ByVal StartNeedDate As Date, ByVal EndNeedDate As Date, ByVal CusterID As String, ByVal M_Code As String, ByVal MC_Source As String) As DataSet
            Try
                Dim ds As New DataSet
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpOderEntryWeek")
                db.AddInParameter(dbComm, "@StartNeedDate", DbType.Date, StartNeedDate)
                db.AddInParameter(dbComm, "@EndNeedDate", DbType.Date, EndNeedDate)
                db.AddInParameter(dbComm, "@MO_CusterID", DbType.String, CusterID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
                db.AddInParameter(dbComm, "@MC_Source", DbType.String, MC_Source)
                ds = db.ExecuteDataSet(dbComm)
                Return ds
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function GetWeekAllInfo(ByVal StartNeedDate As Date, ByVal EndNeedDate As Date, ByVal CusterID As String, ByVal M_Code As String, ByVal MC_Source As String) As DataSet
            Try
                Dim ds As New DataSet
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpOderEntryAllWeek")
                db.AddInParameter(dbComm, "@StartNeedDate", DbType.Date, StartNeedDate)
                db.AddInParameter(dbComm, "@EndNeedDate", DbType.Date, EndNeedDate)
                db.AddInParameter(dbComm, "@MO_CusterID", DbType.String, CusterID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
                db.AddInParameter(dbComm, "@MC_Source", DbType.String, MC_Source)
                ds = db.ExecuteDataSet(dbComm)
                Return ds
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function GetMonthInfo(ByVal StartNeedDate As Date, ByVal EndNeedDate As Date, ByVal CusterID As String, ByVal M_Code As String, ByVal MC_Source As String) As DataSet
            Try
                Dim ds As New DataSet
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpOderEntryMonth")
                db.AddInParameter(dbComm, "@StartNeedDate", DbType.Date, StartNeedDate)
                db.AddInParameter(dbComm, "@EndNeedDate", DbType.Date, EndNeedDate)
                db.AddInParameter(dbComm, "@MO_CusterID", DbType.String, CusterID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
                db.AddInParameter(dbComm, "@MC_Source", DbType.String, MC_Source)
                ds = db.ExecuteDataSet(dbComm)
                Return ds
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function GetMonthAllInfo(ByVal StartNeedDate As Date, ByVal EndNeedDate As Date, ByVal CusterID As String, ByVal M_Code As String, ByVal MC_Source As String) As DataSet
            Try
                Dim ds As New DataSet
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpOderEntryAllMonth")
                db.AddInParameter(dbComm, "@StartNeedDate", DbType.Date, StartNeedDate)
                db.AddInParameter(dbComm, "@EndNeedDate", DbType.Date, EndNeedDate)
                db.AddInParameter(dbComm, "@MO_CusterID", DbType.String, CusterID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
                db.AddInParameter(dbComm, "@MC_Source", DbType.String, MC_Source)
                ds = db.ExecuteDataSet(dbComm)
                Return ds
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function GetWeekInfoChild(ByVal StartNeedDate As Date, ByVal EndNeedDate As Date, ByVal MO_CusterID As String, ByVal M_Code As String, ByVal MC_Source As String) As DataSet
            Try
                Dim ds As New DataSet
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpOderEntryCodeWeek")
                db.AddInParameter(dbComm, "@StartNeedDate", DbType.Date, StartNeedDate)
                db.AddInParameter(dbComm, "@EndNeedDate", DbType.Date, EndNeedDate)
                db.AddInParameter(dbComm, "@MO_CusterID", DbType.String, MO_CusterID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
                db.AddInParameter(dbComm, "@MC_Source", DbType.String, MC_Source)
                ds = db.ExecuteDataSet(dbComm)
                Return ds
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function GetWeekAllInfoChild(ByVal StartNeedDate As Date, ByVal EndNeedDate As Date, ByVal MO_CusterID As String, ByVal M_Code As String, ByVal MC_Source As String) As DataSet
            Try
                Dim ds As New DataSet
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpOderEntryAllCodeWeek")
                db.AddInParameter(dbComm, "@StartNeedDate", DbType.Date, StartNeedDate)
                db.AddInParameter(dbComm, "@EndNeedDate", DbType.Date, EndNeedDate)
                db.AddInParameter(dbComm, "@MO_CusterID", DbType.String, MO_CusterID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
                db.AddInParameter(dbComm, "@MC_Source", DbType.String, MC_Source)
                ds = db.ExecuteDataSet(dbComm)
                Return ds
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function GetMonthInfoChild(ByVal StartNeedDate As Date, ByVal EndNeedDate As Date, ByVal MO_CusterID As String, ByVal M_Code As String, ByVal MC_Source As String) As DataSet
            Try
                Dim ds As New DataSet
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpOderEntryCodeMonth")
                db.AddInParameter(dbComm, "@StartNeedDate", DbType.Date, StartNeedDate)
                db.AddInParameter(dbComm, "@EndNeedDate", DbType.Date, EndNeedDate)
                db.AddInParameter(dbComm, "@MO_CusterID", DbType.String, MO_CusterID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
                db.AddInParameter(dbComm, "@MC_Source", DbType.String, MC_Source)
                ds = db.ExecuteDataSet(dbComm)
                Return ds
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function GetMonthAllInfoChild(ByVal StartNeedDate As Date, ByVal EndNeedDate As Date, ByVal MO_CusterID As String, ByVal M_Code As String, ByVal MC_Source As String) As DataSet
            Try
                Dim ds As New DataSet
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpOderEntryAllCodeMonth")
                db.AddInParameter(dbComm, "@StartNeedDate", DbType.Date, StartNeedDate)
                db.AddInParameter(dbComm, "@EndNeedDate", DbType.Date, EndNeedDate)
                db.AddInParameter(dbComm, "@MO_CusterID", DbType.String, MO_CusterID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
                db.AddInParameter(dbComm, "@MC_Source", DbType.String, MC_Source)
                ds = db.ExecuteDataSet(dbComm)
                Return ds
            Catch ex As Exception
65:
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function MrpOderEntryAllCodeWeek_Out(ByVal StartNeedDate As Date, ByVal EndNeedDate As Date, ByVal MO_CusterID As String, ByVal M_Code As String, ByVal MC_Source As String) As DataSet
            Try
                Dim ds As New DataSet
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpOderEntryAllCodeWeek_Out")
                db.AddInParameter(dbComm, "@StartNeedDate", DbType.Date, StartNeedDate)
                db.AddInParameter(dbComm, "@EndNeedDate", DbType.Date, EndNeedDate)
                db.AddInParameter(dbComm, "@MO_CusterID", DbType.String, MO_CusterID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
                db.AddInParameter(dbComm, "@MC_Source", DbType.String, MC_Source)
                ds = db.ExecuteDataSet(dbComm)
                Return ds
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function MrpOderEntryAllCodeMonth_Out(ByVal StartNeedDate As Date, ByVal EndNeedDate As Date, ByVal MO_CusterID As String, ByVal M_Code As String, ByVal MC_Source As String) As DataSet
            Try
                Dim ds As New DataSet
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpOderEntryAllCodeMonth_Out")
                db.AddInParameter(dbComm, "@StartNeedDate", DbType.Date, StartNeedDate)
                db.AddInParameter(dbComm, "@EndNeedDate", DbType.Date, EndNeedDate)
                db.AddInParameter(dbComm, "@MO_CusterID", DbType.String, MO_CusterID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
                db.AddInParameter(dbComm, "@MC_Source", DbType.String, MC_Source)
                ds = db.ExecuteDataSet(dbComm)

                Return ds
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

#End Region

#Region "刪除"
        ''' <summary>
        ''' 刪除ForecastID對應的預測訂單信息
        ''' </summary>
        ''' <param name="ForecastID"></param>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Function MrpForecastOrder_Delete(ByVal AutoID As Int32, ByVal ForecastID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpForecastOrder_Delete")
                db.AddInParameter(dbComm, "@ForecastID", DbType.String, ForecastID)
                db.AddInParameter(dbComm, "@AutoID", DbType.Int32, AutoID)

                db.ExecuteNonQuery(dbComm)
                MrpForecastOrder_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpForecastOrder_Delete = False
            End Try
        End Function
#End Region

#Region "更新"

        ''' <summary>
        ''' 函數：預測訂單信息的更新
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Function MrpForecastOrder_Update(ByVal objinfo As MrpForecastOrderInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpForecastOrder_Update")
                db.AddInParameter(dbComm, "@ForecastID", DbType.String, objinfo.ForecastID)
                If objinfo.MO_ForecastDate = Nothing Then
                    db.AddInParameter(dbComm, "@MO_ForecastDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@MO_ForecastDate", DbType.Date, CDate(objinfo.MO_ForecastDate))
                End If
                db.AddInParameter(dbComm, "@MO_Status", DbType.String, objinfo.MO_Status)
                db.AddInParameter(dbComm, "@MO_Cancellation", DbType.Boolean, objinfo.MO_Cancellation)
                db.AddInParameter(dbComm, "@OrderInterID", DbType.String, objinfo.OrderInterID)
                db.AddInParameter(dbComm, "@MO_PlanType", DbType.String, objinfo.MO_PlanType)
                db.AddInParameter(dbComm, "@CheckUserID", DbType.String, objinfo.CheckUserID)
                db.AddInParameter(dbComm, "@CheckBit", DbType.Boolean, objinfo.CheckBit)
                db.AddInParameter(dbComm, "@CheckRemark", DbType.String, objinfo.CheckRemark)
                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbComm, "@ModifyDate", DbType.Date, Now)
                db.AddInParameter(dbComm, "@MO_CusterID", DbType.String, objinfo.MO_CusterID)
                db.AddInParameter(dbComm, "M_Code", DbType.String, objinfo.M_Code)
                db.ExecuteNonQuery(dbComm)
                MrpForecastOrder_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpForecastOrder_Update = False
            End Try
        End Function
        ''' <summary>
        ''' 函數：審核預測訂單
        ''' </summary>
        ''' <param name="ForecastID"></param>
        ''' <param name="CheckBit"></param>
        ''' <param name="CheckRemark"></param>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Function MrpForecastOrder_Check(ByVal ForecastID As String, ByVal CheckBit As Boolean, ByVal CheckRemark As String, ByVal CheckUserID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpForecastOrder_Check")
                db.AddInParameter(dbComm, "@ForecastID", DbType.String, ForecastID)
                db.AddInParameter(dbComm, "@CheckBit", DbType.Boolean, CheckBit)
                db.AddInParameter(dbComm, "@CheckRemark", DbType.String, CheckRemark)
                db.AddInParameter(dbComm, "@CheckUserID", DbType.String, CheckUserID)
                db.ExecuteNonQuery(dbComm)
                MrpForecastOrder_Check = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpForecastOrder_Check = False
            End Try
        End Function
#End Region

#Region "添加"

        ''' <summary>
        ''' 函數：預測訂單信息的添加
        ''' </summary>
        ''' <param name="objInfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MrpForecastOrder_Add(ByVal objInfo As MrpForecastOrderInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpForecastOrder_Add")
                db.AddInParameter(dbComm, "@ForecastID", DbType.String, objInfo.ForecastID)
                If objInfo.MO_ForecastDate = Nothing Then
                    db.AddInParameter(dbComm, "@MO_ForecastDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@MO_ForecastDate", DbType.Date, objInfo.MO_ForecastDate)
                End If
                db.AddInParameter(dbComm, "@MO_Status", DbType.String, objInfo.MO_Status)
                db.AddInParameter(dbComm, "@MO_Cancellation", DbType.Boolean, objInfo.MO_Cancellation)
                db.AddInParameter(dbComm, "@OrderInterID", DbType.String, objInfo.OrderInterID)
                db.AddInParameter(dbComm, "@MO_PlanType", DbType.String, objInfo.MO_PlanType)
                db.AddInParameter(dbComm, "@CheckUserID", DbType.String, objInfo.CheckUserID)
                db.AddInParameter(dbComm, "@CheckBit", DbType.Boolean, objInfo.CheckBit)
                db.AddInParameter(dbComm, "@CheckRemark", DbType.String, objInfo.CheckRemark)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                db.AddInParameter(dbComm, "@MO_CusterID", DbType.String, objInfo.MO_CusterID)
                db.AddInParameter(dbComm, "@CreateDate", DbType.Date, Now)
                db.AddInParameter(dbComm, "M_Code", DbType.String, objInfo.M_Code)
                db.ExecuteNonQuery(dbComm)
                MrpForecastOrder_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpForecastOrder_Add = False
            End Try
        End Function
#End Region


    End Class
End Namespace