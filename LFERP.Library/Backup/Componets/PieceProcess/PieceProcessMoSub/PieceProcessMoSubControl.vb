Namespace LFERP.Library.PieceProcessMoSub
    Public Class PieceProcessMoSubControl
        ''' <summary>
        ''' 建立模板
        ''' </summary>
        ''' <param name="Objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PieceProcessMo_Add(ByVal Objinfo As PieceProcessMoSubInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceProcessMo_Add")

                db.AddInParameter(dbComm, "@PM_NO", DbType.String, Objinfo.PM_NO)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, Objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Objinfo.Pro_Type)
                db.AddInParameter(dbComm, "@Type3ID", DbType.String, Objinfo.Type3ID)
                db.AddInParameter(dbComm, "@PM_AddDate", DbType.Date, Objinfo.PM_AddDate)
                db.AddInParameter(dbComm, "@PM_Action", DbType.String, Objinfo.PM_Action)
                db.ExecuteNonQuery(dbComm)
                PieceProcessMo_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PieceProcessMo_Add = False
            End Try
        End Function
        ''' <summary>
        ''' 修改模板
        ''' </summary>
        ''' <param name="Objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PieceProcessMo_Update(ByVal Objinfo As PieceProcessMoSubInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceProcessMo_Update")

                db.AddInParameter(dbComm, "@PM_NO", DbType.String, Objinfo.PM_NO)
                db.AddInParameter(dbComm, "@PM_Remark", DbType.String, Objinfo.PM_Remark)

                db.ExecuteNonQuery(dbComm)
                PieceProcessMo_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                PieceProcessMo_Update = False
            End Try
        End Function
        Public Function PieceProcessMo_Del(ByVal PM_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceProcessMo_Del")

                db.AddInParameter(dbComm, "@PM_NO", DbType.String, PM_NO)

                db.ExecuteNonQuery(dbComm)
                PieceProcessMo_Del = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PieceProcessMo_Del = False
            End Try
        End Function
        Public Function PieceProcessMo_UpdateCheck(ByVal Objinfo As PieceProcessMoSubInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceProcessMo_UpdateCheck")

                db.AddInParameter(dbComm, "@PM_NO", DbType.String, Objinfo.PM_NO)
                db.AddInParameter(dbComm, "@PM_Check", DbType.Boolean, Objinfo.PM_Check)
                db.AddInParameter(dbComm, "@PM_CheckRemark", DbType.String, Objinfo.PM_CheckRemark)
                db.AddInParameter(dbComm, "@PM_CheckAction", DbType.String, Objinfo.PM_CheckAction)
                db.AddInParameter(dbComm, "@PM_CheckDate", DbType.Date, Objinfo.PM_CheckDate)


                db.ExecuteNonQuery(dbComm)
                PieceProcessMo_UpdateCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PieceProcessMo_UpdateCheck = False
            End Try
        End Function
        Public Function PieceProcessMo_GetList(ByVal PM_NO As String, ByVal PM_M_NO As String, ByVal Pro_Type As String, ByVal Type3ID As String, ByVal PM_Action As String, ByVal PM_AddDate1 As String, ByVal PM_AddDate2 As String, ByVal PM_Check As String, ByVal PM_CheckAction As String) As List(Of PieceProcessMoSubInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceProcessMo_GetList")

            db.AddInParameter(dbComm, "@PM_NO", DbType.String, PM_NO)
            db.AddInParameter(dbComm, "@PM_M_NO", DbType.String, PM_M_NO)
            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@Type3ID", DbType.String, Type3ID)
            db.AddInParameter(dbComm, "@PM_Action", DbType.String, PM_Action)
            db.AddInParameter(dbComm, "@PM_AddDate1", DbType.String, PM_AddDate1)
            db.AddInParameter(dbComm, "@PM_AddDate2", DbType.String, PM_AddDate2)
            db.AddInParameter(dbComm, "@PM_Check", DbType.String, PM_Check)
            db.AddInParameter(dbComm, "@PM_CheckAction", DbType.String, PM_CheckAction)

            Dim FeatureList As New List(Of PieceProcessMoSubInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPieceProcessMoSub(reader))
                End While
                Return FeatureList
            End Using

        End Function
        ''' <summary>
        ''' 建立模板后添加數據
        ''' </summary>
        ''' <param name="Objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PieceProcessMoSub_Add(ByVal Objinfo As PieceProcessMoSubInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceProcessMoSub_Add")

                db.AddInParameter(dbComm, "@PM_NO", DbType.String, Objinfo.PM_NO)
                db.AddInParameter(dbComm, "@PM_Num", DbType.String, Objinfo.PM_Num)
                db.AddInParameter(dbComm, "@PS_Num", DbType.String, Objinfo.PS_Num)
                db.AddInParameter(dbComm, "@PS_NO", DbType.String, Objinfo.PS_NO)
                db.AddInParameter(dbComm, "@PM_Name", DbType.String, Objinfo.PM_Name)
                db.AddInParameter(dbComm, "@PM_DepNO", DbType.String, Objinfo.PM_DepNO)
                db.AddInParameter(dbComm, "@PM_DepName", DbType.String, Objinfo.PM_DepName)
                db.AddInParameter(dbComm, "@PM_Price", DbType.String, Objinfo.PM_Price)
                db.AddInParameter(dbComm, "@PM_Explain", DbType.String, Objinfo.PM_Explain)
                db.AddInParameter(dbComm, "@PM_CheckPrice", DbType.Boolean, Objinfo.PM_CheckPrice)
                db.AddInParameter(dbComm, "@PM_Factor", DbType.String, Objinfo.PM_Factor)
                db.AddInParameter(dbComm, "@PM_CheckFactor", DbType.Boolean, Objinfo.PM_CheckFactor)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, Objinfo.PM_Type)
                db.AddInParameter(dbComm, "@PM_DayNight", DbType.String, Objinfo.PM_DayNight)
                db.AddInParameter(dbComm, "@PM_Enable", DbType.Boolean, Objinfo.PM_Enable)

                db.ExecuteNonQuery(dbComm)
                PieceProcessMoSub_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PieceProcessMoSub_Add = False
            End Try
        End Function
        Public Function PieceProcessMoSub_Update(ByVal Objinfo As PieceProcessMoSubInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceProcessMoSub_Update")


                db.AddInParameter(dbComm, "@PM_NO", DbType.String, Objinfo.PM_NO)
                db.AddInParameter(dbComm, "@PM_Num", DbType.String, Objinfo.PM_Num)
                db.AddInParameter(dbComm, "@PS_NO", DbType.String, Objinfo.PS_NO)
                db.AddInParameter(dbComm, "@PS_Num", DbType.String, Objinfo.PS_Num)
                db.AddInParameter(dbComm, "@PM_Name", DbType.String, Objinfo.PM_Name)
                db.AddInParameter(dbComm, "@PM_DepNO", DbType.String, Objinfo.PM_DepNO)
                db.AddInParameter(dbComm, "@PM_DepName", DbType.String, Objinfo.PM_DepName)
                db.AddInParameter(dbComm, "@PM_Price", DbType.String, Objinfo.PM_Price)
                db.AddInParameter(dbComm, "@PM_Explain", DbType.String, Objinfo.PM_Explain)
                db.AddInParameter(dbComm, "@PM_CheckPrice", DbType.Boolean, Objinfo.PM_CheckPrice)
                db.AddInParameter(dbComm, "@PM_Factor", DbType.String, Objinfo.PM_Factor)
                db.AddInParameter(dbComm, "@PM_CheckFactor", DbType.Boolean, Objinfo.PM_CheckFactor)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, Objinfo.PM_Type)
                db.AddInParameter(dbComm, "@PM_DayNight", DbType.String, Objinfo.PM_DayNight)
                db.AddInParameter(dbComm, "@PM_Enable", DbType.Boolean, Objinfo.PM_Enable)



                db.ExecuteNonQuery(dbComm)
                PieceProcessMoSub_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PieceProcessMoSub_Update = False
            End Try
        End Function
       
        Public Function PieceProcessMoSub_Del(ByVal PM_NO As String, ByVal PM_Num As String) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceProcessMoSub_Del")

                db.AddInParameter(dbComm, "@PM_NO", DbType.String, PM_NO)
                db.AddInParameter(dbComm, "@PM_Num", DbType.String, PM_Num)

                db.ExecuteNonQuery(dbComm)
                PieceProcessMoSub_Del = True
            Catch ex As Exception
                PieceProcessMoSub_Del = False
            End Try

        End Function
        Public Function PieceProcessMoSub_GetList(ByVal PM_NO As String, ByVal PM_Num As String, ByVal PS_NO As String) As List(Of PieceProcessMoSubInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceProcessMoSub_GetList")

            db.AddInParameter(dbComm, "@PM_NO", DbType.String, PM_NO)
            db.AddInParameter(dbComm, "@PM_Num", DbType.String, PM_Num)
            db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)

            Dim FeatureList As New List(Of PieceProcessMoSubInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPieceProcessMoSub(reader))
                End While
                Return FeatureList
            End Using

        End Function
        Public Function PieceProcessMo_GetNO(ByVal Ndate As String) As PieceProcessMoSubInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceProcessMo_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillPieceProcessMoSub(reader)
                End While
                Return Nothing
            End Using
        End Function
        Public Function PieceProcessMoSub_GetNum(ByVal PM_NO As String) As PieceProcessMoSubInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceProcessMoSub_GetNum")
            db.AddInParameter(dbComm, "@PM_NO", DbType.String, PM_NO)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillPieceProcessMoSub(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function FillPieceProcessMoSub(ByVal reader As IDataReader) As PieceProcessMoSubInfo
            On Error Resume Next
            Dim pmi As New PieceProcessMoSubInfo

            pmi.PM_NO = reader("PM_NO").ToString
            pmi.PM_M_Code = reader("PM_M_Code").ToString
            pmi.Pro_M_NO = reader("Pro_M_NO").ToString
            pmi.Pro_NO = reader("Pro_NO").ToString
            pmi.Pro_Type = reader("Pro_Type").ToString
            pmi.PM_Type = reader("PM_Type").ToString
            pmi.Type3ID = reader("Type3ID").ToString
            pmi.PM_Action = reader("PM_Action").ToString
            pmi.ActionName = reader("ActionName").ToString
            pmi.PM_Remark = reader("PM_Remark").ToString
            pmi.PM_CheckAction = reader("PM_CheckAction").ToString
            pmi.CheckActionName = reader("CheckActionName").ToString
            pmi.PM_CheckType = reader("PM_Checktype").ToString
            pmi.PM_CheckRemark = reader("PM_CheckRemark").ToString
            If reader("PM_Check") Is DBNull.Value Then '審核整改單
                pmi.PM_Check = False
            Else
                pmi.PM_Check = reader("PM_Check")
            End If
            If reader("PM_AddDate") Is DBNull.Value Then '添加日期
                pmi.PM_AddDate = Nothing
            Else
                pmi.PM_AddDate = CStr(reader("PM_AddDate"))
            End If
            If reader("PM_CheckDate") Is DBNull.Value Then '審核日期
                pmi.PM_CheckDate = Nothing
            Else
                pmi.PM_CheckDate = CStr(reader("PM_CheckDate"))
            End If
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            pmi.PM_Num = reader("PM_Num").ToString
            pmi.PS_Num = reader("PS_Num").ToString
            pmi.PS_NO = reader("PS_NO").ToString
            pmi.PM_Name = reader("PM_Name").ToString
            pmi.PM_DepNO = reader("PM_DepNO").ToString
            pmi.PM_DepName = reader("PM_DepName").ToString
            If reader("PM_Price") Is DBNull.Value Then
                pmi.PM_Price = 0
            Else
                pmi.PM_Price = CSng(reader("PM_Price"))
            End If

            pmi.PM_Explain = reader("PM_Explain").ToString

            If reader("PM_CheckPrice") Is DBNull.Value Then
                pmi.PM_CheckPrice = False
            Else
                pmi.PM_CheckPrice = reader("PM_CheckPrice")
            End If
            pmi.PM_Factor = CInt(reader("PM_Factor"))
            If reader("PM_CheckFactor") Is DBNull.Value Then
                pmi.PM_CheckFactor = False
            Else
                pmi.PM_CheckFactor = reader("PM_CheckFactor")
            End If
            pmi.PM_Type = reader("PM_Type").ToString
            pmi.PM_DayNight = reader("PM_DayNight").ToString
            If reader("PM_Enable") Is DBNull.Value Then
                pmi.PM_Enable = False
            Else
                pmi.PM_Enable = reader("PM_Enable")
            End If
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            pmi.M_Code = reader("M_Code").ToString
            pmi.M_Gauge = reader("M_Gauge").ToString
            pmi.M_Name = reader("M_Name").ToString

            Return pmi
        End Function
    End Class
End Namespace

