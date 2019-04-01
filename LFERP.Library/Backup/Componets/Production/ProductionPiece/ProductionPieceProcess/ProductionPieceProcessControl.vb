Namespace LFERP.Library.ProductionPieceProcess

    Public Class ProductionPieceProcessControl
        ''' <summary>
        ''' 新增計件工藝單
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPieceProcess_Add(ByVal objinfo As ProductionPieceProcessInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPieceProcess_Add")

                db.AddInParameter(dbcomm, "@PP_ID", DbType.String, objinfo.PP_ID)
                db.AddInParameter(dbcomm, "@PP_Num", DbType.String, objinfo.PP_Num)
                db.AddInParameter(dbcomm, "@Pro_Type", DbType.String, objinfo.Pro_Type)
                db.AddInParameter(dbcomm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbcomm, "@PM_Type", DbType.String, objinfo.PM_Type)

                db.AddInParameter(dbcomm, "@PP_Remark", DbType.String, objinfo.PP_Remark)
                db.AddInParameter(dbcomm, "@PP_ActionUser", DbType.String, objinfo.PP_ActionUser)
                db.AddInParameter(dbcomm, "@PP_ActionDate", DbType.Date, objinfo.PP_ActionDate)
                db.AddInParameter(dbcomm, "@PS_NO", DbType.String, objinfo.PS_NO)
                db.AddInParameter(dbcomm, "@PP_N_Name", DbType.String, objinfo.PP_N_Name)

                db.AddInParameter(dbcomm, "@DPT_ID", DbType.String, objinfo.DPT_ID)
                db.AddInParameter(dbcomm, "@PP_Price", DbType.Single, objinfo.PP_Price)
                db.AddInParameter(dbcomm, "@PP_Factor", DbType.Single, objinfo.PP_Factor)
                db.AddInParameter(dbcomm, "@PP_Explain", DbType.String, objinfo.PP_Explain)
                db.AddInParameter(dbcomm, "@PP_Type", DbType.String, objinfo.PP_Type)

                db.AddInParameter(dbcomm, "@PP_BeginUseDate", DbType.Date, objinfo.PP_BeginUseDate)
                db.AddInParameter(dbcomm, "@PP_EndUseDate", DbType.Date, objinfo.PP_EndUseDate)
                db.AddInParameter(dbcomm, "@AddUserID", DbType.String, objinfo.AddUserID)
                db.AddInParameter(dbcomm, "@AddDate", DbType.Date, objinfo.AddDate)


                db.AddInParameter(dbcomm, "@PP_PriceType", DbType.String, objinfo.PP_PriceType)                        '2014-06-03  姚駿

                db.ExecuteNonQuery(dbcomm)
                ProductionPieceProcess_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionPieceProcess_Add = False

            End Try
        End Function
        ''' <summary>
        ''' 統計錄入計件工藝時
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPieceProcess_Add1(ByVal objinfo As ProductionPieceProcessInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPieceProcess_Add1")

                db.AddInParameter(dbcomm, "@PP_ID", DbType.String, objinfo.PP_ID)
                db.AddInParameter(dbcomm, "@PP_Num", DbType.String, objinfo.PP_Num)
                db.AddInParameter(dbcomm, "@Pro_Type", DbType.String, objinfo.Pro_Type)
                db.AddInParameter(dbcomm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbcomm, "@PM_Type", DbType.String, objinfo.PM_Type)

                db.AddInParameter(dbcomm, "@PP_Remark", DbType.String, objinfo.PP_Remark)
                db.AddInParameter(dbcomm, "@PP_ActionUser", DbType.String, objinfo.PP_ActionUser)
                db.AddInParameter(dbcomm, "@PP_ActionDate", DbType.Date, objinfo.PP_ActionDate)
                db.AddInParameter(dbcomm, "@PS_NO", DbType.String, objinfo.PS_NO)
                db.AddInParameter(dbcomm, "@PP_N_Name", DbType.String, objinfo.PP_N_Name)

                db.AddInParameter(dbcomm, "@DPT_ID", DbType.String, objinfo.DPT_ID)
                db.AddInParameter(dbcomm, "@PP_Price", DbType.Single, objinfo.PP_Price)
                db.AddInParameter(dbcomm, "@PP_Factor", DbType.Single, objinfo.PP_Factor)
                db.AddInParameter(dbcomm, "@PP_Explain", DbType.String, objinfo.PP_Explain)
                db.AddInParameter(dbcomm, "@PP_Type", DbType.String, objinfo.PP_Type)

                db.AddInParameter(dbcomm, "@PP_BeginUseDate", DbType.Date, objinfo.PP_BeginUseDate)
                db.AddInParameter(dbcomm, "@PP_EndUseDate", DbType.Date, objinfo.PP_EndUseDate)
                db.AddInParameter(dbcomm, "@AddUserID", DbType.String, objinfo.AddUserID)
                db.AddInParameter(dbcomm, "@AddDate", DbType.Date, objinfo.AddDate)

                db.AddInParameter(dbcomm, "@PP_Check", DbType.Boolean, objinfo.PP_Check)
                db.AddInParameter(dbcomm, "@PP_BeginUse", DbType.Boolean, objinfo.PP_BeginUse)

                db.AddInParameter(dbcomm, "@PP_CheckUserID", DbType.String, objinfo.PP_CheckUserID)
                db.AddInParameter(dbcomm, "@PP_CheckDate", DbType.Date, objinfo.PP_CheckDate)

                db.ExecuteNonQuery(dbcomm)
                ProductionPieceProcess_Add1 = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionPieceProcess_Add1 = False

            End Try
        End Function
        ''' <summary>
        ''' 修改計件工藝單
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPieceProcess_Update(ByVal objinfo As ProductionPieceProcessInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPieceProcess_Update")
                db.AddInParameter(dbcomm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbcomm, "@PP_ID", DbType.String, objinfo.PP_ID)
                db.AddInParameter(dbcomm, "@PP_Num", DbType.String, objinfo.PP_Num)
                db.AddInParameter(dbcomm, "@Pro_Type", DbType.String, objinfo.Pro_Type)
                db.AddInParameter(dbcomm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)

                db.AddInParameter(dbcomm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbcomm, "@PP_Remark", DbType.String, objinfo.PP_Remark)
                db.AddInParameter(dbcomm, "@PP_ActionUser", DbType.String, objinfo.PP_ActionUser)
                db.AddInParameter(dbcomm, "@PP_ActionDate", DbType.Date, objinfo.PP_ActionDate)
                db.AddInParameter(dbcomm, "@PS_NO", DbType.String, objinfo.PS_NO)

                db.AddInParameter(dbcomm, "@PP_N_Name", DbType.String, objinfo.PP_N_Name)
                db.AddInParameter(dbcomm, "@DPT_ID", DbType.String, objinfo.DPT_ID)
                db.AddInParameter(dbcomm, "@PP_Price", DbType.Single, objinfo.PP_Price)
                db.AddInParameter(dbcomm, "@PP_Factor", DbType.Single, objinfo.PP_Factor)
                db.AddInParameter(dbcomm, "@PP_Explain", DbType.String, objinfo.PP_Explain)

                db.AddInParameter(dbcomm, "@PP_Type", DbType.String, objinfo.PP_Type)
                db.AddInParameter(dbcomm, "@PP_BeginUseDate", DbType.Date, objinfo.PP_BeginUseDate)
                db.AddInParameter(dbcomm, "@PP_EndUseDate", DbType.Date, objinfo.PP_EndUseDate)
                db.AddInParameter(dbcomm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbcomm, "@ModifyDate", DbType.Date, objinfo.ModifyDate)


                db.AddInParameter(dbcomm, "@PP_PriceType", DbType.String, objinfo.PP_PriceType)                        '2014-06-03  姚駿

                db.ExecuteNonQuery(dbcomm)
                ProductionPieceProcess_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionPieceProcess_Update = False

            End Try
        End Function
        ''' <summary>
        ''' 刪除計件工藝單（或刪除計件工藝單中某條外發記錄）
        ''' </summary>
        ''' <param name="AutoID"></param>
        ''' <param name="PP_ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPieceProcess_Delete(ByVal AutoID As String, ByVal PP_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPieceProcess_Delete")

                db.AddInParameter(dbcomm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbcomm, "@PP_ID", DbType.String, PP_ID)

                db.ExecuteNonQuery(dbcomm)
                ProductionPieceProcess_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionPieceProcess_Delete = False
            End Try
        End Function
        ''' <summary>
        ''' 計件工藝單審核
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPieceProcess_Check(ByVal objinfo As ProductionPieceProcessInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionPieceProcess_Check")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                'db.AddInParameter(dbComm, "@PP_ID", DbType.String, objinfo.PP_ID)
                db.AddInParameter(dbComm, "@PP_Check", DbType.Boolean, objinfo.PP_Check)
                db.AddInParameter(dbComm, "@PP_BeginUse", DbType.Boolean, objinfo.PP_BeginUse)
                db.AddInParameter(dbComm, "@PP_CheckUserID", DbType.String, objinfo.PP_CheckUserID)
                db.AddInParameter(dbComm, "@PP_CheckDate", DbType.Date, objinfo.PP_CheckDate)
                db.ExecuteNonQuery(dbComm)

                ProductionPieceProcess_Check = True

            Catch ex As Exception
                ProductionPieceProcess_Check = False
                MsgBox(ex.Message)
            End Try
        End Function

        ''' <summary>
        ''' 單價審核
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPieceProcessPrice_Check(ByVal objinfo As ProductionPieceProcessInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionPieceProcessPrice_Check")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)

                db.AddInParameter(dbComm, "@PP_PriceCheck", DbType.Boolean, objinfo.PP_PriceCheck)
                db.AddInParameter(dbComm, "@PP_FactorCheck", DbType.Boolean, objinfo.PP_FactorCheck)
                db.AddInParameter(dbComm, "@PP_PriceCheckUserID", DbType.String, objinfo.PP_PriceCheckUserID)
                db.AddInParameter(dbComm, "@PP_PriceCheckDate", DbType.Date, objinfo.PP_PriceCheckDate)
                db.ExecuteNonQuery(dbComm)

                ProductionPieceProcessPrice_Check = True

            Catch ex As Exception
                ProductionPieceProcessPrice_Check = False
                MsgBox(ex.Message)
            End Try
        End Function
        ''' <summary>
        ''' 按條件查詢計件工藝單
        ''' </summary>
        ''' <param name="AutoID"></param>
        ''' <param name="PP_ID"></param>
        ''' <param name="Pro_Type"></param>
        ''' <param name="PM_M_Code"></param>
        ''' <param name="PM_Type"></param>
        ''' <param name="PS_NO"></param>
        ''' <param name="PP_N_Name"></param>
        ''' <param name="DPT_ID"></param>
        ''' <param name="PP_Check"></param>
        ''' <param name="PP_BeginUse"></param>
        ''' <param name="PP_ActionDateBegin"></param>
        ''' <param name="PP_ActionDateEnd"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPieceProcess_GetList(ByVal AutoID As String, ByVal PP_ID As String, ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal PS_NO As String, ByVal PP_N_Name As String, ByVal DPT_ID As String, ByVal PP_Check As String, ByVal PP_BeginUse As String, ByVal PP_ActionDateBegin As String, ByVal PP_ActionDateEnd As String) As List(Of ProductionPieceProcessInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionPieceProcess_GetList")

            db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbComm, "@PP_ID", DbType.String, PP_ID)
            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)

            db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
            db.AddInParameter(dbComm, "@PP_N_Name", DbType.String, PP_N_Name)
            db.AddInParameter(dbComm, "@DPT_ID", DbType.String, DPT_ID)
            db.AddInParameter(dbComm, "@PP_Check", DbType.String, PP_Check)
            db.AddInParameter(dbComm, "@PP_BeginUse", DbType.String, PP_BeginUse)

            db.AddInParameter(dbComm, "@PP_ActionDateBegin", DbType.String, PP_ActionDateBegin)
            db.AddInParameter(dbComm, "@PP_ActionDateEnd", DbType.String, PP_ActionDateEnd)

            Dim FeatureList As New List(Of ProductionPieceProcessInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionPieceProcess(reader))
                End While
                Return FeatureList
            End Using
        End Function
        ''' <summary>
        ''' 按條件查詢計件工藝單
        ''' </summary>
        ''' <param name="PP_ID"></param>
        ''' <param name="Pro_Type"></param>
        ''' <param name="PM_M_Code"></param>
        ''' <param name="PM_Type"></param>
        ''' <param name="PS_NO"></param>
        ''' <param name="PP_N_Name"></param>
        ''' <param name="PP_Check"></param>
        ''' <param name="PP_ActionDateBegin"></param>
        ''' <param name="PP_ActionDateEnd"></param>
        ''' <param name="DPT_ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPieceProcess_GetList1(ByVal PP_ID As String, ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal PS_NO As String, ByVal PP_N_Name As String, ByVal PP_Check As String, ByVal PP_ActionDateBegin As String, ByVal PP_ActionDateEnd As String, ByVal DPT_ID As String) As List(Of ProductionPieceProcessInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionPieceProcess_GetList1")

            db.AddInParameter(dbComm, "@PP_ID", DbType.String, PP_ID)
            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)

            db.AddInParameter(dbComm, "@PP_N_Name", DbType.String, PP_N_Name)
            db.AddInParameter(dbComm, "@PP_Check", DbType.String, PP_Check)
            db.AddInParameter(dbComm, "@PP_ActionDateBegin", DbType.String, PP_ActionDateBegin)
            db.AddInParameter(dbComm, "@PP_ActionDateEnd", DbType.String, PP_ActionDateEnd) '
            db.AddInParameter(dbComm, "@DPT_ID", DbType.String, DPT_ID) '

            Dim FeatureList As New List(Of ProductionPieceProcessInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionPieceProcess(reader))
                End While
                Return FeatureList
            End Using
        End Function


        ''' <summary>
        ''' 獲取產品工藝樹形結構資料
        ''' 2014-06-04
        ''' 姚      駿
        ''' </summary>
        ''' <param name="PName"></param>
        ''' <param name="PID"></param>
        ''' <param name="ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPieceProcess_GetList3(ByVal PName As String, ByVal PID As String, ByVal ID As String, ByVal Pro_Type As String) As List(Of ProductionPieceProcessInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionPieceProcess_GetList3")

            db.AddInParameter(dbComm, "@PName", DbType.String, PName)
            db.AddInParameter(dbComm, "@PID", DbType.String, PID)
            db.AddInParameter(dbComm, "@ID", DbType.String, ID)
            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)

            Dim FeatureList As New List(Of ProductionPieceProcessInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionPieceProcessTwo(reader))
                End While
                Return FeatureList
            End Using
        End Function


        ''' <summary>
        ''' 查詢出未審核的 工序信息
        ''' </summary>
        ''' <param name="Pro_Type"></param>
        ''' <param name="PM_M_Code"></param>
        ''' <param name="PM_Type"></param>
        ''' <param name="DPT_ID"></param>
        ''' <param name="PP_Check"></param>
        ''' <param name="PP_BeginUse"></param>
        ''' <param name="PP_ActionDateBegin"></param>
        ''' <param name="PP_ActionDateEnd"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPieceProcess_GetList2(ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal DPT_ID As String, ByVal PP_Check As String, ByVal PP_BeginUse As String, ByVal PP_ActionDateBegin As String, ByVal PP_ActionDateEnd As String) As List(Of ProductionPieceProcessInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionPieceProcess_GetList2")

            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@DPT_ID", DbType.String, DPT_ID) '

            db.AddInParameter(dbComm, "@PP_BeginUse", DbType.String, PP_BeginUse)
            db.AddInParameter(dbComm, "@PP_Check", DbType.String, PP_Check)
            db.AddInParameter(dbComm, "@PP_ActionDateBegin", DbType.String, PP_ActionDateBegin)
            db.AddInParameter(dbComm, "@PP_ActionDateEnd", DbType.String, PP_ActionDateEnd) '


            Dim FeatureList As New List(Of ProductionPieceProcessInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionPieceProcess(reader))
                End While
                Return FeatureList
            End Using
        End Function

        ''' <summary>
        ''' 獲取產品工藝樹形結構資料
        ''' 2014-06-04
        ''' 姚      駿
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FillProductionPieceProcessTwo(ByVal reader As IDataReader) As ProductionPieceProcessInfo
            On Error Resume Next
            Dim pai As New ProductionPieceProcessInfo
            '2014-06-03  姚駿
            pai.PName = reader("PName")
            pai.PID = reader("PID")
            pai.ID = reader("ID")
            pai.PP_Price = reader("PP_Price")
            pai.PP_PriceType = reader("PP_PriceType")
            Return pai
        End Function


        ''' <summary>
        ''' 獲取字段值
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FillProductionPieceProcess(ByVal reader As IDataReader) As ProductionPieceProcessInfo

            On Error Resume Next

            Dim pai As New ProductionPieceProcessInfo

            pai.AutoID = reader("AutoID").ToString
            pai.PP_ID = reader("PP_ID").ToString
            pai.PP_Num = reader("PP_Num").ToString
            pai.Pro_Type = reader("Pro_Type").ToString
            pai.PM_M_Code = reader("PM_M_Code").ToString

            pai.PM_Type = reader("PM_Type").ToString
            pai.PP_Remark = reader("PP_Remark")
            pai.PP_ActionUser = reader("PP_ActionUser").ToString
            pai.PP_ActionDate = reader("PP_ActionDate").ToString
            pai.PS_NO = reader("PS_NO").ToString


            pai.PS_Name = reader("PS_Name").ToString
            pai.PP_N_Name = reader("PP_N_Name").ToString
            pai.DPT_ID = reader("DPT_ID").ToString
            pai.DPT_Name = reader("DPT_Name").ToString
            pai.DPT_PName = reader("DPT_PName").ToString

            pai.PP_Price = FormatNumber(CDbl(reader("PP_Price")), 7, TriState.True)
            pai.PP_Factor = CSng(reader("PP_Factor"))
            pai.PP_Explain = reader("PP_Explain").ToString
            pai.PP_Type = reader("PP_Type").ToString
            pai.PP_BeginUseDate = reader("PP_BeginUseDate")

            pai.PP_EndUseDate = reader("PP_EndUseDate")
            If reader("PP_BeginUse") Is DBNull.Value Then
                pai.PP_BeginUse = False
            Else
                pai.PP_BeginUse = reader("PP_BeginUse")
            End If
            If reader("PP_Check") Is DBNull.Value Then
                pai.PP_Check = False
            Else
                pai.PP_Check = reader("PP_Check")
            End If
            If reader("PP_CheckUserID") Is DBNull.Value Then
                pai.PP_CheckUserID = Nothing
            Else
                pai.PP_CheckUserID = reader("PP_CheckUserID").ToString
            End If
            'pai.PP_CheckUserID = reader("PP_CheckUserID")
            pai.PP_CheckUserName = reader("PP_CheckUserName")
            If reader("PP_CheckDate") Is DBNull.Value Then
                pai.PP_CheckDate = Nothing
            Else
                pai.PP_CheckDate = Format(reader("PP_CheckDate"), "yyyy/MM/dd").ToString
            End If

            If reader("PP_ActionDateBegin") Is DBNull.Value Then
                pai.PP_ActionDateBegin = Nothing
            Else
                pai.PP_ActionDateBegin = reader("PP_ActionDateBegin").ToString
            End If
            If reader("PP_ActionDateEnd") Is DBNull.Value Then
                pai.PP_ActionDateEnd = Nothing
            Else
                pai.PP_ActionDateEnd = reader("PP_ActionDateEnd").ToString
            End If

            If reader("PP_PriceCheck") Is DBNull.Value Then
                pai.PP_PriceCheck = False
            Else
                pai.PP_PriceCheck = reader("PP_PriceCheck")
            End If

            If reader("PP_FactorCheck") Is DBNull.Value Then
                pai.PP_FactorCheck = False
            Else
                pai.PP_FactorCheck = reader("PP_FactorCheck")
            End If

            If reader("PP_PriceCheckDate") Is DBNull.Value Then
                pai.PP_PriceCheckDate = ""
            Else
                pai.PP_PriceCheckDate = CDate(reader("PP_PriceCheckDate").ToString)
            End If

            If reader("PP_PriceCheckUserID") Is DBNull.Value Then
                pai.PP_PriceCheckUserID = Nothing
            Else
                pai.PP_PriceCheckUserID = reader("PP_PriceCheckUserID").ToString
            End If
            'PP_PriceCheckUserName
            If reader("PP_PriceCheckUserName") Is DBNull.Value Then
                pai.PP_PriceCheckUserName = Nothing
            Else
                pai.PP_PriceCheckUserName = reader("PP_PriceCheckUserName").ToString
            End If

            '2014-06-03  姚駿
            pai.PP_PriceType = reader("PP_PriceType")

            Return pai
        End Function



        Public Function ProductionPieceProcessPrice_Check1(ByVal objinfo As ProductionPieceProcessInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionPieceProcessPrice_Check1")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)

                db.AddInParameter(dbComm, "@PP_PriceCheck", DbType.Boolean, objinfo.PP_PriceCheck)
                db.AddInParameter(dbComm, "@PP_FactorCheck", DbType.Boolean, objinfo.PP_FactorCheck)
                db.AddInParameter(dbComm, "@PP_PriceCheckUserID", DbType.String, objinfo.PP_PriceCheckUserID)
                db.AddInParameter(dbComm, "@PP_PriceCheckDate", DbType.Date, objinfo.PP_PriceCheckDate)


                db.AddInParameter(dbComm, "@PP_Price", DbType.Single, objinfo.PP_Price)
                db.AddInParameter(dbComm, "@PP_Factor", DbType.Single, objinfo.PP_Factor)

                db.ExecuteNonQuery(dbComm)

                ProductionPieceProcessPrice_Check1 = True

            Catch ex As Exception
                ProductionPieceProcessPrice_Check1 = False
                MsgBox(ex.Message)
            End Try
        End Function


    End Class
End Namespace
