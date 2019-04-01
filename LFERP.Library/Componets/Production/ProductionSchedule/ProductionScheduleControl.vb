
Namespace LFERP.Library.ProductionSchedule

    Public Class ProductionScheduleControl

        ''' <summary>
        ''' 讀取項目編號
        ''' </summary>
        ''' <param name="NDate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionSchedule_GetNO(ByVal NDate As String) As ProductionScheduleInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionSchedule_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionSchedule(reader)
                End While
                Return Nothing
            End Using
        End Function
        ''' <summary>
        ''' 增加一位
        ''' </summary>
        ''' <param name="NDate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionSchedule_GetNO1(ByVal NDate As String) As ProductionScheduleInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionSchedule_GetNO1")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionSchedule(reader)
                End While
                Return Nothing
            End Using
        End Function

        ''' <summary>
        ''' 每天生產計劃編號
        ''' </summary>
        ''' <param name="Ndate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionSchedule_GetNum(ByVal Ndate As String) As ProductionScheduleInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionSchedule_GetNum")
            db.AddInParameter(dbComm, "@NDate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionSchedule(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function ProductionSchedule_Add(ByVal objinfo As ProductionScheduleInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionSchedule_Add")

                db.AddInParameter(dbComm, "@PS_NO", DbType.String, objinfo.PS_NO)
                db.AddInParameter(dbComm, "@PS_Num", DbType.String, objinfo.PS_Num)
                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, objinfo.Pro_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@PS_Date", DbType.Date, objinfo.PS_Date)
                db.AddInParameter(dbComm, "@PS_DayNumber", DbType.Int32, objinfo.PS_DayNumber)
                db.AddInParameter(dbComm, "@PS_Dep", DbType.String, objinfo.PS_Dep)
                db.AddInParameter(dbComm, "@PS_Detail", DbType.String, objinfo.PS_Detail)
                db.AddInParameter(dbComm, "@PS_KaiLiao", DbType.Boolean, objinfo.PS_KaiLiao)
                db.AddInParameter(dbComm, "@PS_Action", DbType.String, objinfo.PS_Action)
                db.AddInParameter(dbComm, "@PS_AddDate", DbType.Date, objinfo.PS_AddDate)
                db.AddInParameter(dbComm, "@PS_Remark", DbType.String, objinfo.PS_Remark)

                db.ExecuteNonQuery(dbComm)
                ProductionSchedule_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionSchedule_Add = False
            End Try

        End Function

        Public Function ProductionSchedule_Update(ByVal objinfo As ProductionScheduleInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionSchedule_Update")

                db.AddInParameter(dbComm, "@PS_NO", DbType.String, objinfo.PS_NO)
                db.AddInParameter(dbComm, "@PS_Num", DbType.String, objinfo.PS_Num)
                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, objinfo.Pro_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@PS_Date", DbType.Date, objinfo.PS_Date)
                db.AddInParameter(dbComm, "@PS_DayNumber", DbType.Int32, objinfo.PS_DayNumber)
                db.AddInParameter(dbComm, "@PS_Dep", DbType.String, objinfo.PS_Dep)
                db.AddInParameter(dbComm, "@PS_Detail", DbType.String, objinfo.PS_Detail)
                db.AddInParameter(dbComm, "@PS_KaiLiao", DbType.Boolean, objinfo.PS_KaiLiao)
                db.AddInParameter(dbComm, "@PS_Action", DbType.String, objinfo.PS_Action)
                db.AddInParameter(dbComm, "@PS_AddDate", DbType.Date, objinfo.PS_AddDate)
                db.AddInParameter(dbComm, "@PS_Remark", DbType.String, objinfo.PS_Remark)

                db.ExecuteNonQuery(dbComm)
                ProductionSchedule_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionSchedule_Update = False
            End Try

        End Function

        Public Function ProductionSchedule_UpdateCheck(ByVal Objinfo As ProductionScheduleInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionSchedule_UpdateCheck")

                db.AddInParameter(dbComm, "@PS_NO", DbType.String, Objinfo.PS_NO)
                db.AddInParameter(dbComm, "@PS_Check", DbType.Boolean, Objinfo.PS_Check)
                db.AddInParameter(dbComm, "@PS_CheckDate", DbType.Date, Objinfo.PS_CheckDate)
                db.AddInParameter(dbComm, "@PS_CheckAction", DbType.String, Objinfo.PS_CheckAction)
                db.AddInParameter(dbComm, "@PS_CheckRemark", DbType.String, Objinfo.PS_CheckRemark)
            
                db.ExecuteNonQuery(dbComm)
                ProductionSchedule_UpdateCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionSchedule_UpdateCheck = False
            End Try
        End Function

        '更新每天實際生產部此工藝實際生產量
        Public Function ProductionSchedule_UpdateActualNumber(ByVal objinfo As ProductionScheduleInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionSchedule_UpdateActualNumber")

                db.AddInParameter(dbComm, "@PS_NO", DbType.String, objinfo.PS_NO)
                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, objinfo.Pro_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@PS_Dep", DbType.String, objinfo.PS_Dep)
                db.AddInParameter(dbComm, "@PS_Date", DbType.Date, objinfo.PS_Date)
                db.AddInParameter(dbComm, "@PS_ActualNumber", DbType.Int32, objinfo.PS_ActualNumber)

                db.ExecuteNonQuery(dbComm)
                ProductionSchedule_UpdateActualNumber = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionSchedule_UpdateActualNumber = False

            End Try
        End Function

        Public Function ProductionSchedule_Delete(ByVal PS_NO As String, ByVal PS_Num As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionSchedule_Delete")

                db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
                db.AddInParameter(dbComm, "@PS_Num", DbType.String, PS_Num)

                db.ExecuteNonQuery(dbComm)
                ProductionSchedule_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionSchedule_Delete = False
            End Try
        End Function

        Public Function ProductionSchedule_GetList(ByVal PS_NO As String, ByVal Pro_Type As String, ByVal PS_Dep As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal PS_Date1 As String, ByVal PS_Date2 As String, ByVal PS_Action As String) As List(Of ProductionScheduleInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionSchedule_GetList")

            db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PS_Dep", DbType.String, PS_Dep)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@PS_Date1", DbType.String, PS_Date1)
            db.AddInParameter(dbComm, "@PS_Date2", DbType.String, PS_Date2)
            db.AddInParameter(dbComm, "@PS_Action", DbType.String, PS_Action)

            Dim FeatureList As New List(Of ProductionScheduleInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionSchedule(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function ProductionSchedule_GetList1(ByVal PS_NO As String, ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal M_Code As String, ByVal FacID As String, ByVal M_Name As String, ByVal PS_Date1 As String, ByVal PS_Date2 As String, ByVal PM_Type As String) As List(Of ProductionScheduleInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionSchedule_GetList1")

            db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@FacID", DbType.String, FacID)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@PS_Date1", DbType.String, PS_Date1)
            db.AddInParameter(dbComm, "@PS_Date2", DbType.String, PS_Date2)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)

            Dim FeatureList As New List(Of ProductionScheduleInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionSchedule(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function ProductionSchedule_GetList2(ByVal PS_NO As String, ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal PS_Dep As String, ByVal PS_Date1 As String, ByVal PS_Date2 As String) As List(Of ProductionScheduleInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionSchedule_GetList2")

            db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@PS_Dep", DbType.String, PS_Dep)
            db.AddInParameter(dbComm, "@PS_Date1", DbType.String, PS_Date1)
            db.AddInParameter(dbComm, "@PS_Date2", DbType.String, PS_Date2)

            Dim FeatureList As New List(Of ProductionScheduleInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionSchedule(reader))
                End While
                Return FeatureList
            End Using
        End Function

        '2014-03-05  姚駿
        Public Function ProductPlan_GetQty(ByVal PM_M_Code As String, ByVal FP_Date As String) As List(Of ProductionScheduleInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductPlan_GetQty")


            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@FP_Date", DbType.String, FP_Date)


            Dim FeatureList As New List(Of ProductionScheduleInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionSchedule(reader))
                End While
                Return FeatureList
            End Using

        End Function

        ''' <summary>
        ''' 更新開料數量
        ''' </summary>
        ''' <param name="PM_M_Code"></param>
        ''' <param name="PS_Date"></param>
        ''' <param name="C_Qty"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionSchedule_UpdateMaterialsQty(ByVal PM_M_Code As String, ByVal PS_Date As String, ByVal C_Qty As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionSchedule_UpdateMaterialsQty")

                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
                db.AddInParameter(dbComm, "@PS_Date", DbType.String, PS_Date)
                db.AddInParameter(dbComm, "@C_Qty", DbType.String, C_Qty)

                db.ExecuteNonQuery(dbComm)
                ProductionSchedule_UpdateMaterialsQty = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionSchedule_UpdateMaterialsQty = False
            End Try
        End Function


        Public Function ProductionSchedule_GetList3(ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal PS_Date1 As String, ByVal PS_Date2 As String) As List(Of ProductionScheduleInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionSchedule_GetList3")

            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@PS_Date1", DbType.String, PS_Date1)
            db.AddInParameter(dbComm, "@PS_Date2", DbType.String, PS_Date2)

            Dim FeatureList As New List(Of ProductionScheduleInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionSchedule(reader))
                End While
                Return FeatureList
            End Using
        End Function
        ''' <summary>
        ''' 去除重復的產品編號
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionSchedule_GetList4(ByVal Pro_Type As String) As List(Of ProductionScheduleInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionSchedule_GetList4")

            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)

            Dim FeatureList As New List(Of ProductionScheduleInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionSchedule(reader))
                End While
                Return FeatureList
            End Using
        End Function

        '------------------------------------------------------------------------以下為部門生產計劃

        '------------------------------------------------------------------------
        Public Function FillProductionSchedule(ByVal reader As IDataReader) As ProductionScheduleInfo
            On Error Resume Next

            Dim pi As New ProductionScheduleInfo


            If reader("PM_JiYu") Is DBNull.Value Then
                pi.PM_JiYu = Nothing
            Else
                pi.PM_JiYu = reader("PM_JiYu")
            End If


            pi.PS_NO = reader("PS_NO").ToString
            pi.PS_Num = reader("PS_Num").ToString

            pi.Pro_Type = reader("Pro_Type").ToString
            pi.PM_M_Code = reader("PM_M_Code").ToString
            pi.PM_Type = reader("PM_Type").ToString
            pi.M_Code = reader("M_Code").ToString


            If reader("PS_Date") Is DBNull.Value Then
                pi.PS_Date = Nothing
            Else
                pi.PS_Date = CStr(reader("PS_Date"))
            End If
            pi.PS_DayNumber = CInt(reader("PS_DayNumber"))
            If reader("PS_ActualNumber") Is DBNull.Value Then
                pi.PS_ActualNumber = 0
            Else
                pi.PS_ActualNumber = CInt(reader("PS_ActualNumber"))
            End If

            pi.PS_Remark = reader("PS_Remark").ToString

            If reader("PS_KaiLiao") Is DBNull.Value Then
                pi.PS_KaiLiao = Nothing
            Else
                pi.PS_KaiLiao = CStr(reader("PS_KaiLiao"))
            End If

            pi.PS_Detail = reader("PS_Detail").ToString
            pi.PS_Action = reader("PS_Action").ToString
            pi.PS_Dep = reader("PS_Dep").ToString

            If reader("PS_AddDate") Is DBNull.Value Then
                pi.PS_AddDate = Nothing
            Else
                pi.PS_AddDate = CStr(reader("PS_AddDate"))
            End If
            '--------------------------------------------------------
            If reader("PS_Check") Is DBNull.Value Then
                pi.PS_Check = Nothing
            Else
                pi.PS_Check = CStr(reader("PS_Check"))
            End If
            If reader("PS_CheckDate") Is DBNull.Value Then
                pi.PS_CheckDate = Nothing
            Else
                pi.PS_CheckDate = CStr(reader("PS_CheckDate"))
            End If

            pi.PS_CheckAction = reader("PS_CheckAction").ToString
            pi.PS_CheckRemark = reader("PS_CheckRemark").ToString

            '---------------------------------------------------------------
            pi.M_Name = reader("M_Name").ToString
            pi.M_Gauge = reader("M_Gauge").ToString
            pi.ActionName = reader("ActionName").ToString
            pi.CheckActionName = reader("CheckActionName").ToString
            pi.FacID = reader("FacID").ToString
            pi.FacName = reader("FacName").ToString
            pi.DepName = reader("DepName").ToString
            '----------------------------------------------------------------

            pi.AutoID = reader("AutoID")
            pi.PS_S_NO = reader("PS_S_NO").ToString
            pi.PS_S_Dep = reader("PS_S_Dep").ToString

            If reader("PS_S_Date") Is DBNull.Value Then
                pi.PS_S_Date = Nothing
            Else
                pi.PS_S_Date = CStr(reader("PS_S_Date"))
            End If

            If reader("PS_S_DayNumber") Is DBNull.Value Then
                pi.PS_S_DayNumber = 0
            Else
                pi.PS_S_DayNumber = CInt(reader("PS_S_DayNumber"))
            End If

            If reader("PS_S_ActualNumber") Is DBNull.Value Then
                pi.PS_S_ActualNumber = 0
            Else
                pi.PS_S_ActualNumber = CInt(reader("PS_S_ActualNumber"))
            End If

            pi.PS_S_Remark = reader("PS_S_Remark").ToString

            If reader("PS_S_Check") Is DBNull.Value Then
                pi.PS_S_Check = Nothing
            Else
                pi.PS_S_Check = CStr(reader("PS_S_Check"))
            End If

            pi.PS_S_CheckAction = reader("PS_S_CheckAction").ToString
            pi.PS_CheckRemark = reader("PS_CheckRemark").ToString


            '2014-03-05  姚駿
            pi.SumNoSendQty = reader("SumNoSendQty")
            pi.SumDayQty = reader("SumDayQty")
            pi.SumPIQty = reader("SumPIQty")



            If reader("C_Qty") Is DBNull.Value Then
                pi.C_Qty = 0
            Else
                pi.C_Qty = CInt(reader("C_Qty"))
            End If





            Return pi

        End Function

    End Class

End Namespace

