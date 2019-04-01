Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Namespace LFERP.Library.MrpManager.MrpForecastOrder
    Public Class MrpForecastOrderEntryController

#Region "添加"
        ''' <summary>
        ''' 函數：預測訂單明細信息的添加
        ''' </summary>
        ''' <param name="objInfo"></param>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Function MrpForecastOrderEntry_Add(ByVal objInfo As MrpForecastOrderEntryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpForecastOrderEntry_Add")
                db.AddInParameter(dbComm, "@ForecastID", DbType.String, objInfo.ForecastID)
                db.AddInParameter(dbComm, "@MI_Qty", DbType.Double, objInfo.MI_Qty)
                db.AddInParameter(dbComm, "@MI_NeedDate", DbType.Date, CDate(objInfo.MI_NeedDate))
                db.AddInParameter(dbComm, "@MI_Note", DbType.String, objInfo.MI_Note)
                db.AddInParameter(dbComm, "@MI_WeekNumber", DbType.Int64, objInfo.MI_WeekNumber)
                db.AddInParameter(dbComm, "@MI_ISpurchase", DbType.Boolean, objInfo.MI_ISpurchase)
                db.AddInParameter(dbComm, "@MI_ISPpurchase", DbType.Boolean, objInfo.MI_ISPpurchase)
                db.AddInParameter(dbComm, "@MI_ISWorkOrder", DbType.Boolean, objInfo.MI_ISWorkOrder)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                db.AddInParameter(dbComm, "@CreateDate", DbType.Date, CDate(objInfo.CreateDate))
                db.AddInParameter(dbComm, "@DateCross", DbType.String, objInfo.DateCross)
                db.ExecuteNonQuery(dbComm)
                MrpForecastOrderEntry_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpForecastOrderEntry_Add = False
            End Try
        End Function
#End Region

#Region "刪除"
        ''' <summary>
        ''' 函數：預測訂單明細的刪除
        ''' </summary>
        ''' <param name="ForecastID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MrpForecastOrderEntry_Delete(ByVal AutoID As Int32, ByVal ForecastID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpForecastOrderEntry_Delete")
                db.AddInParameter(dbComm, "@ForecastID", DbType.String, ForecastID)
                db.AddInParameter(dbComm, "@AutoID", DbType.Int32, AutoID)
                db.ExecuteNonQuery(dbComm)
                MrpForecastOrderEntry_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpForecastOrderEntry_Delete = False
            End Try
        End Function

#End Region

#Region "更新"
        ''' <summary>
        ''' 函數：預測訂單明細的更新
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Function MrpForecastOrderEntry_Update(ByVal objinfo As MrpForecastOrderEntryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpForecastOrderEntry_Update")
                db.AddInParameter(dbComm, "@ForecastID", DbType.String, objinfo.ForecastID)
                db.AddInParameter(dbComm, "@MI_Qty", DbType.Double, objinfo.MI_Qty)
                If objinfo.MI_NeedDate = Nothing Then
                    db.AddInParameter(dbComm, "@MI_NeedDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@MI_NeedDate", DbType.Date, CDate(objinfo.MI_NeedDate))
                End If
                If objinfo.MI_Note = Nothing Then
                    db.AddInParameter(dbComm, "@MI_Note", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@MI_Note", DbType.String, objinfo.MI_Note)
                End If
                db.AddInParameter(dbComm, "@MI_WeekNumber", DbType.Int64, objinfo.MI_WeekNumber)
                db.AddInParameter(dbComm, "@MI_ISpurchase", DbType.Boolean, objinfo.MI_ISpurchase)
                db.AddInParameter(dbComm, "@MI_ISPpurchase", DbType.Boolean, objinfo.MI_ISPpurchase)
                db.AddInParameter(dbComm, "@MI_ISWorkOrder", DbType.Boolean, objinfo.MI_ISWorkOrder)
                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbComm, "@ModifyDate", DbType.Date, Now)
                db.AddInParameter(dbComm, "@AutoID", DbType.Double, objinfo.AutoID)
                db.AddInParameter(dbComm, "@DateCross", DbType.String, objinfo.DateCross)
                db.ExecuteNonQuery(dbComm)
                MrpForecastOrderEntry_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpForecastOrderEntry_Update = False
            End Try
        End Function
#End Region

#Region "查詢"
        ''' <summary>
        ''' 函數：查詢預測訂單ID對應的明細信息
        ''' </summary>
        ''' <param name="ForecastID"></param>
        ''' <returns>List(Of MrpForecastOrderEntryInfo)</returns>
        ''' <remarks></remarks>
        Public Function MrpForecastOrderEntry_GetList(ByVal ForecastID As String) As List(Of MrpForecastOrderEntryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpForecastOrderEntry_GetList")
            db.AddInParameter(dbComm, "@ForecastID", DbType.String, ForecastID)
            Dim FeatureList As New List(Of MrpForecastOrderEntryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMrpForecastOrderEntry(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function MrpForecastOrderEntry_GetQty(ByVal M_Code As String, ByVal CusterID As String, ByVal YearMonth1 As Integer, ByVal YearMonth2 As Integer) As DataSet
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpOderEntryX")
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@CusterID", DbType.String, CusterID)
            db.AddInParameter(dbComm, "@YearMonth1", DbType.Int32, YearMonth1)
            db.AddInParameter(dbComm, "@YearMonth2", DbType.Int32, YearMonth2)
            Dim ds As New DataSet
            ds = db.ExecuteDataSet(dbComm)
            Return ds
        End Function

#End Region

#Region "填充"

        ''' <summary>
        ''' 預測訂單明細填充函數
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Function FillMrpForecastOrderEntry(ByVal reader As IDataReader) As MrpForecastOrderEntryInfo
            Dim objInfo As New MrpForecastOrderEntryInfo
            objInfo.ForecastID = reader("ForecastID").ToString

            objInfo.MI_Qty = reader("MI_Qty")
            If IsDBNull(reader("MI_NeedDate")) = True Then
                objInfo.MI_NeedDate = Nothing
            Else
                objInfo.MI_NeedDate = Format(reader("MI_NeedDate"), "yyyy/MM/dd").ToString
            End If
            objInfo.MI_Note = reader("MI_Note").ToString
            objInfo.MI_WeekNumber = reader("MI_WeekNumber").ToString
            If IsDBNull(reader("MI_ISpurchase")) = True Then
                objInfo.MI_ISpurchase = False
            Else
                objInfo.MI_ISpurchase = reader("MI_ISpurchase")
            End If
            If IsDBNull(reader("MI_ISPpurchase")) = True Then
                objInfo.MI_ISPpurchase = False
            Else
                objInfo.MI_ISPpurchase = reader("MI_ISPpurchase")
            End If
            If IsDBNull(reader("MI_ISWorkOrder")) = True Then
                objInfo.MI_ISWorkOrder = False
            Else
                objInfo.MI_ISWorkOrder = reader("MI_ISWorkOrder")
            End If
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
            objInfo.CreateUserName = reader("CreateUserName").ToString
            objInfo.ModifyUserName = reader("ModifyUserName").ToString
            objInfo.DateCross = reader("DateCross").ToString
            If IsDBNull(reader("PurchasedQty")) = True Then
                objInfo.PurchasedQty = Nothing
            Else
                objInfo.PurchasedQty = reader("PurchasedQty")
            End If

            Return objInfo
        End Function
#End Region

    End Class

End Namespace