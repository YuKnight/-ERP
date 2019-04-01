Imports System.Data.Common
Namespace LFERP.Library.ProductionPiecePayWGSub

    Public Class ProductionPiecePayWGSubControl

        ''' <summary>
        ''' 查詢出組別薪金 子表
        ''' </summary>
        ''' <param name="AutoID"></param>
        ''' <param name="PY_ID"></param>
        ''' <param name="Per_NO"></param>
        ''' <param name="Per_Name"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPiecePayWGSub_GetList(ByVal AutoID As String, ByVal PY_ID As String, ByVal Per_NO As String, ByVal Per_Name As String) As List(Of ProductionPiecePayWGSubInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPiecePayWGSub_GetList")

            db.AddInParameter(dbcomm, "@AutoID", DbType.String, AutoID) '自動編號ID
            db.AddInParameter(dbcomm, "@PY_ID", DbType.String, PY_ID) '單號
            db.AddInParameter(dbcomm, "@Per_NO", DbType.String, Per_NO) '廠證編號
            db.AddInParameter(dbcomm, "@Per_Name", DbType.String, Per_Name) '姓名

            Dim FeatureList As New List(Of ProductionPiecePayWGSubInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillProductionPiecePayWGSub(reader))
                End While
                Return FeatureList
            End Using
        End Function
        ''' <summary>
        ''' 載入   查詢出組別薪金 子表
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FillProductionPiecePayWGSub(ByVal reader As IDataReader) As ProductionPiecePayWGSubInfo
            Dim ai As New ProductionPiecePayWGSubInfo

            '
            If reader("PYS_WorkWGDay") Is DBNull.Value Then
                ai.PYS_WorkWGDay = Nothing
            Else
                ai.PYS_WorkWGDay = reader("PYS_WorkWGDay")
            End If


            If reader("Per_PayType") Is DBNull.Value Then
                ai.Per_PayType = Nothing
            Else
                ai.Per_PayType = reader("Per_PayType").ToString
            End If

            If reader("AutoID") Is DBNull.Value Then
                ai.AutoID = Nothing
            Else
                ai.AutoID = reader("AutoID").ToString     '自動編號ID
            End If

            If reader("PY_ID") Is DBNull.Value Then
                ai.PY_ID = Nothing
            Else
                ai.PY_ID = reader("PY_ID").ToString     '單號
            End If

            If reader("Per_NO") Is DBNull.Value Then
                ai.Per_NO = Nothing
            Else
                ai.Per_NO = reader("Per_NO").ToString     '廠證編號
            End If

            If reader("Per_Name") Is DBNull.Value Then
                ai.Per_Name = Nothing
            Else
                ai.Per_Name = reader("Per_Name").ToString     '姓名
            End If

            If reader("PYS_FormulaID") Is DBNull.Value Then
                ai.PYS_FormulaID = Nothing
            Else
                ai.PYS_FormulaID = reader("PYS_FormulaID").ToString     '計算公式編號
            End If

            If reader("Per_DayPrice") Is DBNull.Value Then
                ai.Per_DayPrice = 0
            Else
                ai.Per_DayPrice = reader("Per_DayPrice")
            End If

            If reader("PYS_OnDutyDays") Is DBNull.Value Then
                ai.PYS_OnDutyDays = 0
            Else
                ai.PYS_OnDutyDays = reader("PYS_OnDutyDays")     '上班天數
            End If

            If reader("PYS_UsualOverTime") Is DBNull.Value Then
                ai.PYS_UsualOverTime = 0
            Else
                ai.PYS_UsualOverTime = reader("PYS_UsualOverTime")     '平時加班小時數
            End If

            If reader("PYS_HolidayOVerTime") Is DBNull.Value Then
                ai.PYS_HolidayOVerTime = 0
            Else
                ai.PYS_HolidayOVerTime = reader("PYS_HolidayOVerTime")     '節假日加班小時數
            End If

            If reader("PYS_Proportion") Is DBNull.Value Then
                ai.PYS_Proportion = 0
            Else
                ai.PYS_Proportion = reader("PYS_Proportion").ToString      '工時比例
            End If

            If reader("PYS_Bonus") Is DBNull.Value Then
                ai.PYS_Bonus = 0
            Else
                ai.PYS_Bonus = reader("PYS_Bonus")     '獎金
            End If

            If reader("PYS_AllHours") Is DBNull.Value Then
                ai.PYS_AllHours = 0
            Else
                ai.PYS_AllHours = reader("PYS_AllHours")     '總工時
            End If

            If reader("PYS_MeritedHours") Is DBNull.Value Then
                ai.PYS_MeritedHours = 0
            Else
                ai.PYS_MeritedHours = reader("PYS_MeritedHours")     '應計工時
            End If

            If reader("PYS_TimePay") Is DBNull.Value Then
                ai.PYS_TimePay = 0
            Else
                ai.PYS_TimePay = reader("PYS_TimePay")     '計時工資
            End If

            If reader("PYS_PiecePay") Is DBNull.Value Then
                ai.PYS_PiecePay = 0
            Else
                ai.PYS_PiecePay = reader("PYS_PiecePay")     '計件工資
            End If

            If reader("PYS_MeritedPay") Is DBNull.Value Then
                ai.PYS_MeritedPay = 0
            Else
                ai.PYS_MeritedPay = reader("PYS_MeritedPay")     '應得工資
            End If

            If reader("PYS_Remark") Is DBNull.Value Then
                ai.PYS_Remark = Nothing
            Else
                ai.PYS_Remark = reader("PYS_Remark").ToString     '備注
            End If


            Return ai
        End Function
        ''' <summary>
        ''' 添加 組別薪金子表 記錄
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPiecePayWGSub_Add(ByVal obj As ProductionPiecePayWGSubInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPiecePayWGSub_Add")

                db.AddInParameter(dbcomm, "@PY_ID", DbType.String, obj.PY_ID) '單號
                db.AddInParameter(dbcomm, "@Per_NO", DbType.String, obj.Per_NO) '廠證編號
                db.AddInParameter(dbcomm, "@Per_Name", DbType.String, obj.Per_Name) '姓名
                db.AddInParameter(dbcomm, "@PYS_FormulaID", DbType.String, obj.PYS_FormulaID) '計算公式編號
                db.AddInParameter(dbcomm, "@Per_DayPrice", DbType.Double, obj.Per_DayPrice) '薪金類型
                db.AddInParameter(dbcomm, "@PYS_OnDutyDays", DbType.Double, obj.PYS_OnDutyDays) '上班天數
                db.AddInParameter(dbcomm, "@PYS_UsualOverTime", DbType.Double, obj.PYS_UsualOverTime) '平時加班小時數
                db.AddInParameter(dbcomm, "@PYS_HolidayOVerTime", DbType.Double, obj.PYS_HolidayOVerTime) '節假日加班小時數
                db.AddInParameter(dbcomm, "@PYS_Proportion", DbType.Double, obj.PYS_Proportion) '工時比例
                db.AddInParameter(dbcomm, "@PYS_Bonus", DbType.Double, obj.PYS_Bonus) '獎金
                db.AddInParameter(dbcomm, "@PYS_AllHours", DbType.Double, obj.PYS_AllHours) '總工時
                db.AddInParameter(dbcomm, "@PYS_MeritedHours", DbType.Double, obj.PYS_MeritedHours) '應計工時
                db.AddInParameter(dbcomm, "@PYS_TimePay", DbType.Double, obj.PYS_TimePay) '計時工資
                db.AddInParameter(dbcomm, "@PYS_PiecePay", DbType.Double, obj.PYS_PiecePay) '計件工資
                db.AddInParameter(dbcomm, "@PYS_MeritedPay", DbType.Double, obj.PYS_MeritedPay) '應得工資
                db.AddInParameter(dbcomm, "@PYS_Remark", DbType.String, obj.PYS_Remark) '備注

                db.AddInParameter(dbcomm, "@PYS_WorkWGDay", DbType.Double, obj.PYS_WorkWGDay)
                db.AddInParameter(dbcomm, "@Per_PayType", DbType.String, obj.Per_PayType)

                db.ExecuteNonQuery(dbcomm)
                ProductionPiecePayWGSub_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionPiecePayWGSub_Add = False
            End Try
        End Function
        ''' <summary>
        ''' 更新 組別薪金子表
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPiecePayWGSub_Update(ByVal obj As ProductionPiecePayWGSubInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPiecePayWGSub_Update")

                db.AddInParameter(dbcomm, "@AutoID", DbType.String, obj.AutoID) '自動編號ID
                db.AddInParameter(dbcomm, "@PY_ID", DbType.String, obj.PY_ID) '單號
                db.AddInParameter(dbcomm, "@Per_NO", DbType.String, obj.Per_NO) '廠證編號
                db.AddInParameter(dbcomm, "@Per_Name", DbType.String, obj.Per_Name) '姓名
                db.AddInParameter(dbcomm, "@PYS_FormulaID", DbType.String, obj.PYS_FormulaID) '計算公式編號
                db.AddInParameter(dbcomm, "@Per_DayPrice", DbType.Double, obj.Per_DayPrice) '薪金類型
                db.AddInParameter(dbcomm, "@PYS_OnDutyDays", DbType.Double, obj.PYS_OnDutyDays) '上班天數
                db.AddInParameter(dbcomm, "@PYS_UsualOverTime", DbType.Double, obj.PYS_UsualOverTime) '平時加班小時數
                db.AddInParameter(dbcomm, "@PYS_HolidayOVerTime", DbType.Double, obj.PYS_HolidayOVerTime) '節假日加班小時數
                db.AddInParameter(dbcomm, "@PYS_Proportion", DbType.Double, obj.PYS_Proportion) '工時比例
                db.AddInParameter(dbcomm, "@PYS_Bonus", DbType.Double, obj.PYS_Bonus) '獎金
                db.AddInParameter(dbcomm, "@PYS_AllHours", DbType.Double, obj.PYS_AllHours) '總工時
                db.AddInParameter(dbcomm, "@PYS_MeritedHours", DbType.Double, obj.PYS_MeritedHours) '應計工時
                db.AddInParameter(dbcomm, "@PYS_TimePay", DbType.Double, obj.PYS_TimePay) '計時工資
                db.AddInParameter(dbcomm, "@PYS_PiecePay", DbType.Double, obj.PYS_PiecePay) '計件工資
                db.AddInParameter(dbcomm, "@PYS_MeritedPay", DbType.Double, obj.PYS_MeritedPay) '應得工資
                db.AddInParameter(dbcomm, "@PYS_Remark", DbType.String, obj.PYS_Remark) '備注

                db.AddInParameter(dbcomm, "@PYS_WorkWGDay", DbType.Double, obj.PYS_WorkWGDay)
                db.AddInParameter(dbcomm, "@Per_PayType", DbType.String, obj.Per_PayType)

                db.ExecuteNonQuery(dbcomm)
                ProductionPiecePayWGSub_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionPiecePayWGSub_Update = False
            End Try
        End Function

        ''' <summary>
        ''' 刪除 組別薪金子表  (先由主表查詢出 PY_ID,再刪除)
        ''' </summary>
        ''' <param name="AutoID"></param>
        ''' <param name="PY_ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPiecePayWGSub_Delete(ByVal AutoID As String, ByVal PY_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPiecePayWGSub_Delete")

                db.AddInParameter(dbcomm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbcomm, "@PY_ID", DbType.String, PY_ID)

                db.ExecuteNonQuery(dbcomm)
                ProductionPiecePayWGSub_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionPiecePayWGSub_Delete = False
            End Try
        End Function



        ''' <summary>
        ''' 批量導入工時比例
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPiecePayWGSub_UpdateRat(ByVal obj As ProductionPiecePayWGSubInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPiecePayWGSub_UpdateRat")

                db.AddInParameter(dbcomm, "@PY_ID", DbType.String, obj.PY_ID) '單號
                db.AddInParameter(dbcomm, "@Per_NO", DbType.String, obj.Per_NO) '廠證編號
                db.AddInParameter(dbcomm, "@PYS_Proportion", DbType.Double, obj.PYS_Proportion) '工時比例
              
                db.ExecuteNonQuery(dbcomm)
                ProductionPiecePayWGSub_UpdateRat = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionPiecePayWGSub_UpdateRat = False
            End Try
        End Function

    End Class





End Namespace