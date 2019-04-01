Imports System.Data.Common
Namespace LFERP.Library.ProductionPiecePayWGMain

    Public Class ProductionPiecePayWGMainControl
        ''' <summary>
        ''' 查詢出組別薪金計算主表 
        ''' </summary>
        ''' <param name="AutoID"></param>
        ''' <param name="PY_ID"></param>
        ''' <param name="G_NO"></param>
        ''' <param name="PY_YYMM"></param>
        ''' <param name="PY_CheckUserID"></param>
        ''' <param name="PY_AddUserID"></param>
        ''' <param name="DepID"></param>
        ''' <param name="FacID"></param>
        ''' <param name="Py_DateStart"></param>
        ''' <param name="Py_DateEnd"></param>
        ''' <param name="PY_Check"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPiecePayWGMain_GetList(ByVal AutoID As String, ByVal PY_ID As String, ByVal G_NO As String, ByVal PY_YYMM As String, ByVal PY_CheckUserID As String, _
                                                         ByVal PY_AddUserID As String, ByVal DepID As String, ByVal FacID As String, ByVal Py_DateStart As String, ByVal Py_DateEnd As String, ByVal PY_Check As String) As List(Of ProductionPiecePayWGMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPiecePayWGMain_GetList")

            db.AddInParameter(dbcomm, "@AutoID", DbType.String, AutoID) '自動編號ID
            db.AddInParameter(dbcomm, "@PY_ID", DbType.String, PY_ID) '單號
            db.AddInParameter(dbcomm, "@G_NO", DbType.String, G_NO) '組別編號
            db.AddInParameter(dbcomm, "@PY_YYMM", DbType.String, PY_YYMM) '年月
            db.AddInParameter(dbcomm, "@PY_CheckUserID", DbType.String, PY_CheckUserID) '審核編號

            db.AddInParameter(dbcomm, "@PY_AddUserID", DbType.String, PY_AddUserID) '添加人(操作人)編號
            db.AddInParameter(dbcomm, "@DepID", DbType.String, DepID) '部門
            db.AddInParameter(dbcomm, "@FacID", DbType.String, FacID) '廠別
            db.AddInParameter(dbcomm, "@Py_DateStart", DbType.String, Py_DateStart)
            db.AddInParameter(dbcomm, "@Py_DateEnd", DbType.String, Py_DateEnd)

            db.AddInParameter(dbcomm, "@PY_Check", DbType.String, PY_Check)

            Dim FeatureList As New List(Of ProductionPiecePayWGMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillProductionPiecePayWGMain(reader))
                End While
                Return FeatureList
            End Using
        End Function
        ''' <summary>
        ''' 載入查詢出的數據
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FillProductionPiecePayWGMain(ByVal reader As IDataReader) As ProductionPiecePayWGMainInfo
            Dim ai As New ProductionPiecePayWGMainInfo

            'G_NO_OUTSum = 0
            'G_NO_InSum = 0
            ''-------------------------------------------------------
            If reader("G_NO_OUTSum") Is DBNull.Value Then
                ai.G_NO_OUTSum = 0
            Else
                ai.G_NO_OUTSum = reader("G_NO_OUTSum").ToString
            End If

            If reader("G_NO_InSum") Is DBNull.Value Then
                ai.G_NO_InSum = 0
            Else
                ai.G_NO_InSum = reader("G_NO_InSum").ToString
            End If
            ''-------------------------------------------------------


            If reader("AutoID") Is DBNull.Value Then
                ai.AutoID = Nothing
            Else
                ai.AutoID = reader("AutoID").ToString     '自編號
            End If


            If reader("PY_G_Name") Is DBNull.Value Then
                ai.PY_G_Name = Nothing
            Else
                ai.PY_G_Name = reader("PY_G_Name").ToString    '組別名稱
            End If


            If reader("PY_ID") Is DBNull.Value Then
                ai.PY_ID = Nothing
            Else
                ai.PY_ID = reader("PY_ID").ToString     '單號
            End If

            If reader("G_NO") Is DBNull.Value Then
                ai.G_NO = Nothing
            Else
                ai.G_NO = reader("G_NO").ToString     '組別編號
            End If

            If reader("PY_YYMM") Is DBNull.Value Then
                ai.PY_YYMM = Nothing
            Else
                ai.PY_YYMM = reader("PY_YYMM").ToString     '年月
            End If

            If reader("PY_CompleteSum") Is DBNull.Value Then
                ai.PY_CompleteSum = 0
            Else
                ai.PY_CompleteSum = reader("PY_CompleteSum").ToString      '完成總金額
            End If

            If reader("PY_UseSum") Is DBNull.Value Then
                ai.PY_UseSum = 0
            Else
                ai.PY_UseSum = reader("PY_UseSum").ToString      '耗用總金額
            End If

            If reader("PY_TimeAllSum") Is DBNull.Value Then
                ai.PY_TimeAllSum = 0
            Else
                ai.PY_TimeAllSum = reader("PY_TimeAllSum").ToString      '計時總金額
            End If

            If reader("PY_PieceAllSum") Is DBNull.Value Then
                ai.PY_PieceAllSum = 0
            Else
                ai.PY_PieceAllSum = reader("PY_PieceAllSum").ToString      '計件總金額
            End If

            If reader("PY_TimeSum") Is DBNull.Value Then
                ai.PY_TimeSum = 0
            Else
                ai.PY_TimeSum = reader("PY_TimeSum")     '計時金額
            End If

            If reader("PY_PieceSum") Is DBNull.Value Then
                ai.PY_PieceSum = 0
            Else
                ai.PY_PieceSum = reader("PY_PieceSum").ToString      '計件金額
            End If

            If reader("PY_CompensateSum") Is DBNull.Value Then
                ai.PY_CompensateSum = 0
            Else
                ai.PY_CompensateSum = reader("PY_CompensateSum").ToString      '應補金額
            End If

            If reader("PY_SubtractSum") Is DBNull.Value Then
                ai.PY_SubtractSum = 0
            Else
                ai.PY_SubtractSum = reader("PY_SubtractSum").ToString      '應扣金額
            End If

            If reader("PY_BonusSum") Is DBNull.Value Then
                ai.PY_BonusSum = 0
            Else
                ai.PY_BonusSum = reader("PY_BonusSum").ToString      '其它金額
            End If

            If reader("PY_Remark") Is DBNull.Value Then
                ai.PY_Remark = Nothing
            Else
                ai.PY_Remark = reader("PY_Remark").ToString     '備注
            End If

            If reader("PY_Check") Is DBNull.Value Then
                ai.PY_Check = Nothing
            Else
                ai.PY_Check = reader("PY_Check").ToString     '審核
            End If

            If reader("PY_CheckUserID") Is DBNull.Value Then
                ai.PY_CheckUserID = Nothing
            Else
                ai.PY_CheckUserID = reader("PY_CheckUserID").ToString     '審核編號
            End If

            If reader("PY_CheckDate") Is DBNull.Value Then
                ai.PY_CheckDate = Nothing
            Else
                ai.PY_CheckDate = reader("PY_CheckDate").ToString     '審核日期
            End If

            If reader("PY_AddUserID") Is DBNull.Value Then
                ai.PY_AddUserID = Nothing
            Else
                ai.PY_AddUserID = reader("PY_AddUserID").ToString     '添加人(操作人)編號
            End If

            If reader("PY_AddDate") Is DBNull.Value Then
                ai.PY_AddDate = Nothing
            Else
                ai.PY_AddDate = reader("PY_AddDate").ToString     '添加日期
            End If

            If reader("PY_ModifyUserID") Is DBNull.Value Then
                ai.PY_ModifyUserID = Nothing
            Else
                ai.PY_ModifyUserID = reader("PY_ModifyUserID").ToString     '修改人
            End If

            If reader("PY_ModifyDate") Is DBNull.Value Then
                ai.PY_ModifyDate = Nothing
            Else
                ai.PY_ModifyDate = reader("PY_ModifyDate").ToString     '修改日期
            End If

            If reader("DepID") Is DBNull.Value Then
                ai.DepID = Nothing
            Else
                ai.DepID = reader("DepID").ToString     '部門
            End If

            If reader("FacID") Is DBNull.Value Then
                ai.FacID = Nothing
            Else
                ai.FacID = reader("FacID").ToString     '廠別
            End If

            If reader("PY_DepName") Is DBNull.Value Then
                ai.PY_DepName = Nothing
            Else
                ai.PY_DepName = reader("PY_DepName").ToString     '部門
            End If

            If reader("PY_FacName") Is DBNull.Value Then
                ai.PY_FacName = Nothing
            Else
                ai.PY_FacName = reader("PY_FacName").ToString     '廠別
            End If
            'PY_AddUserName

            If reader("PY_AddUserName") Is DBNull.Value Then
                ai.PY_AddUserName = Nothing
            Else
                ai.PY_AddUserName = reader("PY_AddUserName").ToString
            End If

            Return ai
        End Function
        ''' <summary>
        ''' 更新組別薪金計算主表
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPiecePayWGMain_Update(ByVal obj As ProductionPiecePayWGMainInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPiecePayWGMain_Update")

                db.AddInParameter(dbcomm, "@PY_ID", DbType.String, obj.PY_ID) '單號
                db.AddInParameter(dbcomm, "@G_NO", DbType.String, obj.G_NO) '組別編號
                db.AddInParameter(dbcomm, "@PY_YYMM", DbType.String, obj.PY_YYMM) '年月
                db.AddInParameter(dbcomm, "@PY_CompleteSum", DbType.Double, obj.PY_CompleteSum) '完成總金額
                db.AddInParameter(dbcomm, "@PY_UseSum", DbType.Double, obj.PY_UseSum) '耗用總金額

                db.AddInParameter(dbcomm, "@PY_TimeAllSum", DbType.Double, obj.PY_TimeAllSum) '計時總金額
                db.AddInParameter(dbcomm, "@PY_PieceAllSum", DbType.Double, obj.PY_PieceAllSum) '計件總金額

                db.AddInParameter(dbcomm, "@PY_CompensateSum", DbType.Double, obj.PY_CompensateSum) '應補金額
                db.AddInParameter(dbcomm, "@PY_SubtractSum", DbType.Double, obj.PY_SubtractSum) '應扣金額
                db.AddInParameter(dbcomm, "@PY_BonusSum", DbType.Double, obj.PY_BonusSum) '其它金額

                db.AddInParameter(dbcomm, "@PY_Remark", DbType.String, obj.PY_Remark) '備注
                db.AddInParameter(dbcomm, "@PY_ModifyUserID", DbType.String, obj.PY_ModifyUserID) '修改人
                db.AddInParameter(dbcomm, "@PY_ModifyDate", DbType.String, obj.PY_ModifyDate) '修改日期
                db.AddInParameter(dbcomm, "@DepID", DbType.String, obj.DepID) '部門
                db.AddInParameter(dbcomm, "@FacID", DbType.String, obj.FacID) '廠別

                db.AddInParameter(dbcomm, "@PY_TimeSum", DbType.Double, obj.PY_TimeSum) '計時金額
                db.AddInParameter(dbcomm, "@PY_PieceSum", DbType.Double, obj.PY_PieceSum) '計件金額

                db.AddInParameter(dbcomm, "@G_NO_InSum", DbType.Double, obj.G_NO_InSum) '調整收入
                db.AddInParameter(dbcomm, "@G_NO_OUTSum", DbType.Double, obj.G_NO_OUTSum) '調整轉出


                db.ExecuteNonQuery(dbcomm)
                ProductionPiecePayWGMain_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionPiecePayWGMain_Update = False
            End Try
        End Function


        ''' <summary>
        ''' 增加組別薪金計算主表
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPiecePayWGMain_Add(ByVal obj As ProductionPiecePayWGMainInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPiecePayWGMain_Add")

                db.AddInParameter(dbcomm, "@PY_ID", DbType.String, obj.PY_ID) '單號
                db.AddInParameter(dbcomm, "@G_NO", DbType.String, obj.G_NO) '組別編號
                db.AddInParameter(dbcomm, "@PY_YYMM", DbType.String, obj.PY_YYMM) '年月
                db.AddInParameter(dbcomm, "@PY_CompleteSum", DbType.Double, obj.PY_CompleteSum) '完成總金額
                db.AddInParameter(dbcomm, "@PY_UseSum", DbType.Double, obj.PY_UseSum) '耗用總金額

                db.AddInParameter(dbcomm, "@PY_TimeAllSum", DbType.Double, obj.PY_TimeAllSum) '計時總金額
                db.AddInParameter(dbcomm, "@PY_PieceAllSum", DbType.Double, obj.PY_PieceAllSum) '計件總金額
                db.AddInParameter(dbcomm, "@PY_CompensateSum", DbType.Double, obj.PY_CompensateSum) '應補金額
                db.AddInParameter(dbcomm, "@PY_SubtractSum", DbType.Double, obj.PY_SubtractSum) '應扣金額
                db.AddInParameter(dbcomm, "@PY_BonusSum", DbType.Double, obj.PY_BonusSum) '其它金額

                db.AddInParameter(dbcomm, "@PY_Remark", DbType.String, obj.PY_Remark) '備注
                db.AddInParameter(dbcomm, "@PY_Check", DbType.String, obj.PY_Check) '審核
                db.AddInParameter(dbcomm, "@PY_AddUserID", DbType.String, obj.PY_AddUserID) '添加人(操作人)編號
                db.AddInParameter(dbcomm, "@PY_AddDate", DbType.String, obj.PY_AddDate) '添加日期
                db.AddInParameter(dbcomm, "@DepID", DbType.String, obj.DepID) '部門

                db.AddInParameter(dbcomm, "@FacID", DbType.String, obj.FacID) '廠別
                db.AddInParameter(dbcomm, "@PY_TimeSum", DbType.Double, obj.PY_TimeSum) '計時金額
                db.AddInParameter(dbcomm, "@PY_PieceSum", DbType.Double, obj.PY_PieceSum) '計件金額

                db.AddInParameter(dbcomm, "@G_NO_InSum", DbType.Double, obj.G_NO_InSum) '調整收入
                db.AddInParameter(dbcomm, "@G_NO_OUTSum", DbType.Double, obj.G_NO_OUTSum) '調整轉出



                db.ExecuteNonQuery(dbcomm)
                ProductionPiecePayWGMain_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionPiecePayWGMain_Add = False
            End Try
        End Function
        ''' <summary>
        ''' 刪除組別薪金主表記錄
        ''' </summary>
        ''' <param name="AutoID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPiecePayWGMain_Delete(ByVal AutoID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPiecePayWGMain_Delete")

                db.AddInParameter(dbcomm, "@AutoID", DbType.String, AutoID)

                db.ExecuteNonQuery(dbcomm)
                ProductionPiecePayWGMain_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionPiecePayWGMain_Delete = False
            End Try
        End Function


        ''' <summary>
        ''' 更新 組別薪金計算 審核
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPiecePayWGMain_Updatecheck(ByVal obj As ProductionPiecePayWGMainInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPiecePayWGMain_Updatecheck")

                db.AddInParameter(dbcomm, "@PY_ID", DbType.String, obj.PY_ID) '單號
                db.AddInParameter(dbcomm, "@PY_Check", DbType.Boolean, obj.PY_Check) ' /審核
                db.AddInParameter(dbcomm, "@PY_CheckUserID", DbType.String, obj.PY_CheckUserID)
                db.AddInParameter(dbcomm, "@PY_CheckDate", DbType.String, obj.PY_CheckDate)


                db.ExecuteNonQuery(dbcomm)
                ProductionPiecePayWGMain_Updatecheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionPiecePayWGMain_Updatecheck = False
            End Try
        End Function

        ''' <summary>
        ''' 獲取組別薪金主表編號
        ''' </summary>
        ''' <param name="Ndate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPiecePayWGMain_GetNO(ByVal Ndate As String) As ProductionPiecePayWGMainInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionPiecePayWGMain_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionPiecePayWGMain1(reader)
                End While
                Return Nothing
            End Using
        End Function

        ''' <summary>
        ''' 載入  組別薪金主表編號 
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FillProductionPiecePayWGMain1(ByVal reader As IDataReader) As ProductionPiecePayWGMainInfo
            Dim ai1 As New ProductionPiecePayWGMainInfo

            If reader("PY_ID") Is DBNull.Value Then
                ai1.PY_ID = Nothing
            Else
                ai1.PY_ID = reader("PY_ID").ToString     '單號
            End If

            Return ai1
        End Function


        ''' <summary>
        ''' 查詢統計出指定組別某一月份計件總額(視圖)
        ''' </summary>
        ''' <param name="G_NO"></param>
        ''' <param name="GP_DateStart"></param>
        ''' <param name="GP_DateEnd"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Function ProductionSumPieceWorkGroupView(ByVal G_NO As String, ByVal GP_DateStart As String, ByVal GP_DateEnd As String) As ProductionPiecePayWGMainInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionSumPieceWorkGroupView")

            db.AddInParameter(dbComm, "@G_NO", DbType.String, G_NO) '組別編號
            db.AddInParameter(dbComm, "@GP_DateStart", DbType.String, GP_DateStart)
            db.AddInParameter(dbComm, "@GP_DateEnd", DbType.String, GP_DateEnd)

            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionSumPieceWorkGroupView(reader)
                End While
                Return Nothing
            End Using
        End Function
        ''' <summary>
        '''  載入  查詢統計出指定組別某一月份計件總額(視圖)
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FillProductionSumPieceWorkGroupView(ByVal reader As IDataReader) As ProductionPiecePayWGMainInfo
            Dim ai1 As New ProductionPiecePayWGMainInfo
            If reader("PWGtotal_P") Is DBNull.Value Then
                ai1.PWGtotal_P = 0
            Else
                ai1.PWGtotal_P = reader("PWGtotal_P")
            End If
            Return ai1
        End Function
        ''' <summary>
        ''' 查詢統計出指定組別某一月份計時總額(視圖)
        ''' </summary>
        ''' <param name="G_NO"></param>
        ''' <param name="GT_DateStart"></param>
        ''' <param name="GT_DateEnd"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionSumTimeWorkGroupView(ByVal G_NO As String, ByVal GT_DateStart As String, ByVal GT_DateEnd As String) As ProductionPiecePayWGMainInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionSumTimeWorkGroupView")

            db.AddInParameter(dbcomm, "@G_NO", DbType.String, G_NO) '組別編號
            db.AddInParameter(dbcomm, "@GT_DateStart", DbType.String, GT_DateStart)
            db.AddInParameter(dbcomm, "@GT_DateEnd", DbType.String, GT_DateEnd)

            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    Return FillProductionSumTimeWorkGroupView(reader)
                End While
                Return Nothing
            End Using
        End Function
        ''' <summary>
        '''  載入  查詢統計出指定組別某一月份計時總額(視圖)
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FillProductionSumTimeWorkGroupView(ByVal reader As IDataReader) As ProductionPiecePayWGMainInfo
            Dim ai1 As New ProductionPiecePayWGMainInfo
            If reader("PWGtotal_T") Is DBNull.Value Then
                ai1.PWGtotal_T = 0
            Else
                ai1.PWGtotal_T = reader("PWGtotal_T")
            End If
            Return ai1
        End Function


    End Class

End Namespace