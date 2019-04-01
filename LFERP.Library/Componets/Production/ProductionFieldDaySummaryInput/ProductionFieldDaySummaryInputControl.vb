Namespace LFERP.Library.Production.ProductionFieldDaySummaryInput

    Public Class ProductionFieldDaySummaryInputControl
        Public Function ProductionFieldDaySummaryInput_Add(ByVal obj As ProductionFieldDaySummaryInputInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionFieldDaySummaryInput_Add")

                db.AddInParameter(dbcomm, "@PM_NO", DbType.String, obj.PM_NO)
                db.AddInParameter(dbcomm, "@Pro_Type", DbType.String, obj.Pro_Type) '生產工藝
                db.AddInParameter(dbcomm, "@PM_M_Code", DbType.String, obj.PM_M_Code) '產品編號
                db.AddInParameter(dbcomm, "@PM_Type", DbType.String, obj.PM_Type) '類型
                db.AddInParameter(dbcomm, "@Pro_NO", DbType.String, obj.Pro_NO) '工序編號

                db.AddInParameter(dbcomm, "@FP_OutDep", DbType.String, obj.FP_OutDep) '部門
                db.AddInParameter(dbcomm, "@PM_Date", DbType.String, obj.PM_Date) '日期
                db.AddInParameter(dbcomm, "@OutInType", DbType.String, obj.OutInType) '米亞 聯豐 瓦克
                db.AddInParameter(dbcomm, "@AccIn", DbType.Double, obj.AccIn) '收入數量
                db.AddInParameter(dbcomm, "@ReIn", DbType.Double, obj.ReIn) '收入返修

                db.AddInParameter(dbcomm, "@AccOut", DbType.Double, obj.AccOut) '發出數量
                db.AddInParameter(dbcomm, "@ReOut", DbType.Double, obj.ReOut) '發出返修
                db.AddInParameter(dbcomm, "@PM_Check", DbType.String, obj.PM_Check) '審核(鎖定)
                db.AddInParameter(dbcomm, "@Remark", DbType.String, obj.Remark) '備注

                db.AddInParameter(dbcomm, "@SaveNow", DbType.String, obj.SaveNow)
                db.AddInParameter(dbcomm, "@SaveEnd", DbType.String, obj.SaveEnd)

                db.AddInParameter(dbcomm, "@LiuBan", DbType.String, obj.LiuBan)
                db.AddInParameter(dbcomm, "@SunHuai", DbType.String, obj.SunHuai)
                db.AddInParameter(dbcomm, "@DiuShi", DbType.String, obj.DiuShi)
                db.AddInParameter(dbcomm, "@BuNiang", DbType.String, obj.BuNiang)
                db.AddInParameter(dbcomm, "@PM_Action", DbType.String, obj.PM_Action) 'PM_Action


                db.ExecuteNonQuery(dbcomm)
                ProductionFieldDaySummaryInput_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionFieldDaySummaryInput_Add = False
            End Try
        End Function

        Public Function ProductionFieldDaySummaryInput_Update(ByVal obj As ProductionFieldDaySummaryInputInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionFieldDaySummaryInput_Update")

                db.AddInParameter(dbcomm, "@AutoID", DbType.String, obj.AutoID) '自動編號ID
                db.AddInParameter(dbcomm, "@Pro_Type", DbType.String, obj.Pro_Type) '生產工藝
                db.AddInParameter(dbcomm, "@PM_M_Code", DbType.String, obj.PM_M_Code) '產品編號
                db.AddInParameter(dbcomm, "@PM_Type", DbType.String, obj.PM_Type) '類型
                db.AddInParameter(dbcomm, "@Pro_NO", DbType.String, obj.Pro_NO) '工序編號
                db.AddInParameter(dbcomm, "@FP_OutDep", DbType.String, obj.FP_OutDep) '部門
                db.AddInParameter(dbcomm, "@PM_Date", DbType.String, obj.PM_Date) '日期
                db.AddInParameter(dbcomm, "@OutInType", DbType.String, obj.OutInType) '米亞 聯豐 瓦克
                db.AddInParameter(dbcomm, "@AccIn", DbType.Double, obj.AccIn) '收入數量
                db.AddInParameter(dbcomm, "@ReIn", DbType.Double, obj.ReIn) '收入返修
                db.AddInParameter(dbcomm, "@AccOut", DbType.Double, obj.AccOut) '發出數量
                db.AddInParameter(dbcomm, "@ReOut", DbType.Double, obj.ReOut) '發出返修
                db.AddInParameter(dbcomm, "@PM_Check", DbType.String, obj.PM_Check) '審核(鎖定)
                db.AddInParameter(dbcomm, "@Remark", DbType.String, obj.Remark) '備注

                db.AddInParameter(dbcomm, "@SaveNow", DbType.String, obj.SaveNow)
                db.AddInParameter(dbcomm, "@SaveEnd", DbType.String, obj.SaveEnd)

                db.AddInParameter(dbcomm, "@LiuBan", DbType.String, obj.LiuBan)
                db.AddInParameter(dbcomm, "@SunHuai", DbType.String, obj.SunHuai)
                db.AddInParameter(dbcomm, "@DiuShi", DbType.String, obj.DiuShi)
                db.AddInParameter(dbcomm, "@BuNiang", DbType.String, obj.BuNiang)

                db.AddInParameter(dbcomm, "@PM_Action", DbType.String, obj.PM_Action)

                db.ExecuteNonQuery(dbcomm)
                ProductionFieldDaySummaryInput_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionFieldDaySummaryInput_Update = False
            End Try
        End Function

        Public Function ProductionFieldDaySummaryInput_GetList(ByVal AutoID As String, ByVal PM_NO As String, ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal Pro_NO As String, ByVal FP_OutDep As String, ByVal PM_Date1 As String, ByVal PM_Date2 As String, ByVal PM_Check As String, ByVal OutInType As String) As List(Of ProductionFieldDaySummaryInputInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionFieldDaySummaryInput_GetList")

            db.AddInParameter(dbcomm, "@AutoID", DbType.Int32, AutoID)
            db.AddInParameter(dbcomm, "@PM_NO", DbType.String, PM_NO)
            db.AddInParameter(dbcomm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbcomm, "@PM_M_Code", DbType.String, PM_M_Code) '產品編號
            db.AddInParameter(dbcomm, "@PM_Type", DbType.String, PM_Type) '類型

            db.AddInParameter(dbcomm, "@Pro_NO", DbType.String, Pro_NO) '工序編號
            db.AddInParameter(dbcomm, "@FP_OutDep", DbType.String, FP_OutDep) '部門
            db.AddInParameter(dbcomm, "@PM_Date1", DbType.String, PM_Date1) '日期
            db.AddInParameter(dbcomm, "@PM_Date2", DbType.String, PM_Date2) '日期
            db.AddInParameter(dbcomm, "@PM_Check", DbType.String, PM_Check) '審核(鎖定) @OutInType
            db.AddInParameter(dbcomm, "@OutInType", DbType.String, OutInType)


            Dim FeatureList As New List(Of ProductionFieldDaySummaryInputInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillProductionFieldDaySummaryInput(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FillProductionFieldDaySummaryInput(ByVal reader As IDataReader) As ProductionFieldDaySummaryInputInfo
            Dim ai As New ProductionFieldDaySummaryInputInfo

            If reader("PM_Action") Is DBNull.Value Then
                ai.PM_Action = Nothing
            Else
                ai.PM_Action = reader("PM_Action").ToString
            End If

            If reader("PM_Check_Action") Is DBNull.Value Then
                ai.PM_Check_Action = Nothing
            Else
                ai.PM_Check_Action = reader("PM_Check_Action").ToString
            End If

            If reader("PM_Action_Name") Is DBNull.Value Then
                ai.PM_Action_Name = Nothing
            Else
                ai.PM_Action_Name = reader("PM_Action_Name").ToString
            End If

            If reader("PM_Check_Action_Name") Is DBNull.Value Then
                ai.PM_Check_Action_Name = Nothing
            Else
                ai.PM_Check_Action_Name = reader("PM_Check_Action_Name").ToString
            End If

            ''Dep_Name
            If reader("Dep_Name") Is DBNull.Value Then
                ai.Dep_Name = Nothing
            Else
                ai.Dep_Name = reader("Dep_Name").ToString     '自動編號ID
            End If

            If reader("PS_Name") Is DBNull.Value Then
                ai.PS_Name = Nothing
            Else
                ai.PS_Name = reader("PS_Name").ToString     '自動編號ID
            End If

            If reader("PM_NO") Is DBNull.Value Then
                ai.PM_NO = Nothing
            Else
                ai.PM_NO = reader("PM_NO").ToString     '自動編號ID
            End If

            If reader("AutoID") Is DBNull.Value Then
                ai.AutoID = Nothing
            Else
                ai.AutoID = reader("AutoID").ToString     '自動編號ID
            End If

            If reader("Pro_Type") Is DBNull.Value Then
                ai.Pro_Type = Nothing
            Else
                ai.Pro_Type = reader("Pro_Type").ToString     '生產工藝
            End If

            If reader("PM_M_Code") Is DBNull.Value Then
                ai.PM_M_Code = Nothing
            Else
                ai.PM_M_Code = reader("PM_M_Code").ToString     '產品編號
            End If

            If reader("PM_Type") Is DBNull.Value Then
                ai.PM_Type = Nothing
            Else
                ai.PM_Type = reader("PM_Type").ToString     '類型
            End If

            If reader("Pro_NO") Is DBNull.Value Then
                ai.Pro_NO = Nothing
            Else
                ai.Pro_NO = reader("Pro_NO").ToString     '工序編號
            End If

            If reader("FP_OutDep") Is DBNull.Value Then
                ai.FP_OutDep = Nothing
            Else
                ai.FP_OutDep = reader("FP_OutDep").ToString     '部門
            End If

            If reader("PM_Date") Is DBNull.Value Then
                ai.PM_Date = ""
            Else
                ai.PM_Date = Format(CDate(reader("PM_Date").ToString))     '日期
            End If

            If reader("AccIn") Is DBNull.Value Then
                ai.AccIn = 0
            Else
                ai.AccIn = reader("AccIn")     '收入數量
            End If

            If reader("OutInType") Is DBNull.Value Then
                ai.OutInType = 0
            Else
                ai.OutInType = reader("OutInType")     '米亞 聯豐 瓦克
            End If


            If reader("ReIn") Is DBNull.Value Then
                ai.ReIn = 0
            Else
                ai.ReIn = reader("ReIn")     '收入返修
            End If

            If reader("AccOut") Is DBNull.Value Then
                ai.AccOut = 0
            Else
                ai.AccOut = reader("AccOut")     '發出數量
            End If

            If reader("ReOut") Is DBNull.Value Then
                ai.ReOut = 0
            Else
                ai.ReOut = reader("ReOut")     '發出返修
            End If

            If reader("SaveNow") Is DBNull.Value Then
                ai.SaveNow = 0
            Else
                ai.SaveNow = reader("SaveNow")     '當前節余
            End If

            If reader("SaveEnd") Is DBNull.Value Then
                ai.SaveEnd = 0
            Else
                ai.SaveEnd = reader("SaveEnd")     '節余
            End If

            If reader("PM_Check") Is DBNull.Value Then
                ai.PM_Check = Nothing
            Else
                ai.PM_Check = reader("PM_Check").ToString     '審核(鎖定)
            End If

            If reader("Remark") Is DBNull.Value Then
                ai.Remark = Nothing
            Else
                ai.Remark = reader("Remark").ToString     '備注
            End If


            If reader("LiuBan") Is DBNull.Value Then
                ai.LiuBan = 0
            Else
                ai.LiuBan = reader("LiuBan")
            End If


            If reader("SunHuai") Is DBNull.Value Then
                ai.SunHuai = 0
            Else
                ai.SunHuai = reader("SunHuai")
            End If

            If reader("DiuShi") Is DBNull.Value Then
                ai.DiuShi = 0
            Else
                ai.DiuShi = reader("DiuShi")
            End If

            If reader("BuNiang") Is DBNull.Value Then
                ai.BuNiang = 0
            Else
                ai.BuNiang = reader("BuNiang")
            End If



            Return ai
        End Function
        ''' <summary>
        ''' 刪除
        ''' </summary>
        ''' <param name="AutoID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionFieldDaySummaryInput_Delete(ByVal AutoID As String, ByVal PM_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionFieldDaySummaryInput_Delete")

                db.AddInParameter(dbcomm, "@AutoID", DbType.String, AutoID) '自動編號ID
                db.AddInParameter(dbcomm, "@PM_NO", DbType.String, PM_NO)

                db.ExecuteNonQuery(dbcomm)
                ProductionFieldDaySummaryInput_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionFieldDaySummaryInput_Delete = False
            End Try
        End Function
        ''' <summary>
        ''' 取得流水號 (停用)
        ''' </summary>
        ''' <param name="Ndate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionFieldDaySummaryInput_GetNO(ByVal Ndate As String) As ProductionFieldDaySummaryInputInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldDaySummaryInput_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionFieldDaySummaryInput1(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function FillProductionFieldDaySummaryInput1(ByVal reader As IDataReader) As ProductionFieldDaySummaryInputInfo
            Dim ai1 As New ProductionFieldDaySummaryInputInfo
            If reader("PM_NO") Is DBNull.Value Then ai1.PM_NO = Nothing Else ai1.PM_NO = reader("PM_NO").ToString '

            Return ai1

        End Function

        ''' <summary>
        ''' 更新鎖定
        ''' </summary>
        ''' <param name="AutoID"></param>
        ''' <param name="PM_Check"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionFieldDaySummaryInput_UpdateCheck(ByVal AutoID As String, ByVal PM_Check As String, ByVal PM_Check_Action As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionFieldDaySummaryInput_UpdateCheck")

                db.AddInParameter(dbcomm, "@AutoID", DbType.String, AutoID) '自動編號ID
                db.AddInParameter(dbcomm, "@PM_Check", DbType.String, PM_Check)
                db.AddInParameter(dbcomm, "@PM_Check_Action", DbType.String, PM_Check_Action)

                db.ExecuteNonQuery(dbcomm)
                ProductionFieldDaySummaryInput_UpdateCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionFieldDaySummaryInput_UpdateCheck = False
            End Try
        End Function
        ''' <summary>
        '''  ProductionFieldDaySummaryInput_Qty表中指定條件 數量
        ''' </summary>
        ''' <param name="PS_NO"></param>
        ''' <param name="StartDate"></param>
        ''' <param name="EndDate"></param>
        ''' <param name="SumContent"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionFieldDaySummaryInput_Qty(ByVal PS_NO As String, ByVal StartDate As String, ByVal EndDate As String, ByVal SumContent As String, ByVal CO_ID As String) As List(Of ProductionFieldDaySummaryInputInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldDaySummaryInput_Qty")

            db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
            db.AddInParameter(dbComm, "@StartDate", DbType.String, StartDate)
            db.AddInParameter(dbComm, "@EndDate", DbType.String, EndDate) '
            db.AddInParameter(dbComm, "@SumContent", DbType.String, SumContent) '@model
            db.AddInParameter(dbComm, "@CO_ID", DbType.String, CO_ID)


            Dim FeatureList As New List(Of ProductionFieldDaySummaryInputInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionFieldDaySummaryInput_Qty(reader))
                End While
                Return FeatureList
            End Using

        End Function


        Public Function FillProductionFieldDaySummaryInput_Qty(ByVal reader As IDataReader) As ProductionFieldDaySummaryInputInfo

            Dim ai As New ProductionFieldDaySummaryInputInfo


            If reader("Qty") Is DBNull.Value Then
                ai.Qty = 0
            Else
                ai.Qty = CDbl(reader("Qty")) '
            End If
            Return ai
        End Function

        ''-------------------------------------------------------------------------
        ''' <summary>
        ''' 讀取工序類型
        ''' </summary>
        ''' <param name="ID"></param>
        ''' <param name="TypeName"></param>
        ''' <param name="CO_ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionFieldDaySummaryInputType_GetList(ByVal ID As String, ByVal TypeName As String, ByVal CO_ID As String, ByVal Statistical_Type As String) As List(Of ProductionFieldDaySummaryInputInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldDaySummaryInputType_GetList")

            db.AddInParameter(dbComm, "@ID", DbType.String, ID)
            db.AddInParameter(dbComm, "@TypeName", DbType.String, TypeName)
            db.AddInParameter(dbComm, "@CO_ID", DbType.String, CO_ID)
            db.AddInParameter(dbComm, "@Statistical_Type", DbType.String, Statistical_Type)

            Dim FeatureList As New List(Of ProductionFieldDaySummaryInputInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionFieldDaySummaryInputType(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function FillProductionFieldDaySummaryInputType(ByVal reader As IDataReader) As ProductionFieldDaySummaryInputInfo

            Dim ai As New ProductionFieldDaySummaryInputInfo


            If reader("ID") Is DBNull.Value Then
                ai.ID = Nothing
            Else
                ai.ID = reader("ID")
            End If

            If reader("TypeName") Is DBNull.Value Then
                ai.TypeName = Nothing
            Else
                ai.TypeName = reader("TypeName")
            End If

            If reader("CO_ID") Is DBNull.Value Then
                ai.CO_ID = Nothing
            Else
                ai.CO_ID = reader("CO_ID")
            End If

            If reader("Sum_Content") Is DBNull.Value Then
                ai.Sum_Content = Nothing
            Else
                ai.Sum_Content = reader("Sum_Content")
            End If


            If reader("Statistical_Type") Is DBNull.Value Then
                ai.Statistical_Type = Nothing
            Else
                ai.Statistical_Type = reader("Statistical_Type")
            End If

            Return ai
        End Function
    End Class
End Namespace