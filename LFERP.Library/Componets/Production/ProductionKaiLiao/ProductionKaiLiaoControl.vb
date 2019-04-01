
Namespace LFERP.Library.ProductionKaiLiao

    Public Class ProductionKaiLiaoControl

        Public Function ProductionKaiLiao_GetNO(ByVal Ndate As String) As ProductionKaiLiaoInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionKaiLiao_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionKaiLiao(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function ProductionKaiLiaoA_GetNO(ByVal Ndate As String) As ProductionKaiLiaoInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionKaiLiaoA_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionKaiLiao(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function ProductionKaiLiao_Add(ByVal Objinfo As ProductionKaiLiaoInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionKaiLiao_Add")

                db.AddInParameter(dbComm, "@C_NO", DbType.String, Objinfo.C_NO)
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, Objinfo.WH_ID)
                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Objinfo.Pro_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, Objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, Objinfo.PM_Type)
                db.AddInParameter(dbComm, "@PS_Dep", DbType.String, Objinfo.PS_Dep)
                db.AddInParameter(dbComm, "@PS_Action", DbType.String, Objinfo.PS_Action)
                db.AddInParameter(dbComm, "@C_Qty", DbType.Double, Objinfo.C_Qty)
                db.AddInParameter(dbComm, "@C_Weight", DbType.Double, Objinfo.C_Weight)
                db.AddInParameter(dbComm, "@C_Action", DbType.String, Objinfo.C_Action)
                db.AddInParameter(dbComm, "@C_Remark", DbType.String, Objinfo.C_Remark)
                db.AddInParameter(dbComm, "@C_AddDate", DbType.Date, Objinfo.C_AddDate)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, Objinfo.M_Code)
                db.AddInParameter(dbComm, "@C_Cishu", DbType.String, Objinfo.C_Cishu)
                db.AddInParameter(dbComm, "@C_Type", DbType.String, Objinfo.C_Type)

                db.ExecuteNonQuery(dbComm)
                ProductionKaiLiao_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionKaiLiao_Add = False
            End Try
        End Function

        Public Function ProductionKaiLiaoA_Add(ByVal Objinfo As ProductionKaiLiaoInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionKaiLiaoA_Add")

                db.AddInParameter(dbComm, "@C_NO", DbType.String, Objinfo.C_NO)
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, Objinfo.WH_ID)
                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Objinfo.Pro_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, Objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, Objinfo.PM_Type)
                db.AddInParameter(dbComm, "@PS_Dep", DbType.String, Objinfo.PS_Dep)
                db.AddInParameter(dbComm, "@PS_Action", DbType.String, Objinfo.PS_Action)
                db.AddInParameter(dbComm, "@C_Qty", DbType.Double, Objinfo.C_Qty)
                db.AddInParameter(dbComm, "@C_Weight", DbType.Double, Objinfo.C_Weight)
                db.AddInParameter(dbComm, "@C_Action", DbType.String, Objinfo.C_Action)
                db.AddInParameter(dbComm, "@C_Remark", DbType.String, Objinfo.C_Remark)
                db.AddInParameter(dbComm, "@C_AddDate", DbType.Date, Objinfo.C_AddDate)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, Objinfo.M_Code)
                db.AddInParameter(dbComm, "@C_Cishu", DbType.String, Objinfo.C_Cishu)
                db.AddInParameter(dbComm, "@C_Type", DbType.String, Objinfo.C_Type)
                db.AddInParameter(dbComm, "@C_Number", DbType.String, Objinfo.C_Number)

                db.AddInParameter(dbComm, "@OM_ID", DbType.String, Objinfo.OM_ID)
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, Objinfo.OS_BatchID)

                db.ExecuteNonQuery(dbComm)
                ProductionKaiLiaoA_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionKaiLiaoA_Add = False
            End Try
        End Function

        Public Function ProductionKaiLiao_Update(ByVal Objinfo As ProductionKaiLiaoInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionKaiLiao_Update")

                db.AddInParameter(dbComm, "@C_NO", DbType.String, Objinfo.C_NO)
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, Objinfo.WH_ID)
                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Objinfo.Pro_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, Objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, Objinfo.PM_Type)
                db.AddInParameter(dbComm, "@PS_Dep", DbType.String, Objinfo.PS_Dep)
                db.AddInParameter(dbComm, "@PS_Action", DbType.String, Objinfo.PS_Action)
                db.AddInParameter(dbComm, "@C_Qty", DbType.Double, Objinfo.C_Qty)
                db.AddInParameter(dbComm, "@C_Weight", DbType.Double, Objinfo.C_Weight)
                db.AddInParameter(dbComm, "@C_Action", DbType.String, Objinfo.C_Action)
                db.AddInParameter(dbComm, "@C_Remark", DbType.String, Objinfo.C_Remark)
                db.AddInParameter(dbComm, "@C_AddDate", DbType.Date, Objinfo.C_AddDate)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, Objinfo.M_Code)
                db.AddInParameter(dbComm, "@C_Cishu", DbType.String, Objinfo.C_Cishu)
                db.AddInParameter(dbComm, "@C_Type", DbType.String, Objinfo.C_Type)

                db.ExecuteNonQuery(dbComm)
                ProductionKaiLiao_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionKaiLiao_Update = False
            End Try
        End Function
        '修改不良數'
        Public Function ProductionKaiLiao_BadUpdate(ByVal Objinfo As ProductionKaiLiaoInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionKaiLiao_BadUpdate")

                db.AddInParameter(dbComm, "@C_NO", DbType.String, Objinfo.C_NO)
                db.AddInParameter(dbComm, "@BadQty", DbType.Int32, Objinfo.BadQty)
                db.AddInParameter(dbComm, "@FP_NO", DbType.String, Objinfo.FP_NO)

                db.ExecuteNonQuery(dbComm)
                ProductionKaiLiao_BadUpdate = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionKaiLiao_BadUpdate = False
            End Try
        End Function



        Public Function ProductionKaiLiaoA_Update(ByVal Objinfo As ProductionKaiLiaoInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionKaiLiaoA_Update")

                db.AddInParameter(dbComm, "@C_NO", DbType.String, Objinfo.C_NO)
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, Objinfo.WH_ID)
                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Objinfo.Pro_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, Objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, Objinfo.PM_Type)
                db.AddInParameter(dbComm, "@PS_Dep", DbType.String, Objinfo.PS_Dep)
                db.AddInParameter(dbComm, "@PS_Action", DbType.String, Objinfo.PS_Action)
                db.AddInParameter(dbComm, "@C_Qty", DbType.Double, Objinfo.C_Qty)
                db.AddInParameter(dbComm, "@C_Weight", DbType.Double, Objinfo.C_Weight)
                db.AddInParameter(dbComm, "@C_Action", DbType.String, Objinfo.C_Action)
                db.AddInParameter(dbComm, "@C_Remark", DbType.String, Objinfo.C_Remark)
                db.AddInParameter(dbComm, "@C_AddDate", DbType.Date, Objinfo.C_AddDate)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, Objinfo.M_Code)
                db.AddInParameter(dbComm, "@C_Cishu", DbType.String, Objinfo.C_Cishu)
                db.AddInParameter(dbComm, "@C_Type", DbType.String, Objinfo.C_Type)
                db.AddInParameter(dbComm, "@C_Number", DbType.String, Objinfo.C_Number)
                db.AddInParameter(dbComm, "@OM_ID", DbType.String, Objinfo.OM_ID)
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, Objinfo.OS_BatchID)

                db.ExecuteNonQuery(dbComm)
                ProductionKaiLiaoA_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionKaiLiaoA_Update = False
            End Try
        End Function


        Public Function ProductionKaiLiao_UpdateCheck(ByVal Objinfo As ProductionKaiLiaoInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionKaiLiao_UpdateCheck")

                db.AddInParameter(dbComm, "@C_NO", DbType.String, Objinfo.C_NO)
                db.AddInParameter(dbComm, "@C_Check", DbType.Boolean, Objinfo.C_Check)
                db.AddInParameter(dbComm, "@C_CheckAction", DbType.String, Objinfo.C_CheckAction)
                db.AddInParameter(dbComm, "@C_CheckRemark", DbType.String, Objinfo.C_CheckRemark)
              
                db.ExecuteNonQuery(dbComm)
                ProductionKaiLiao_UpdateCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionKaiLiao_UpdateCheck = False
            End Try
        End Function

        Public Function ProductionKaiLiaoA_UpdateCheck(ByVal Objinfo As ProductionKaiLiaoInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionKaiLiaoA_UpdateCheck")

                db.AddInParameter(dbComm, "@C_Number", DbType.String, Objinfo.C_Number)
                db.AddInParameter(dbComm, "@C_Check", DbType.Boolean, Objinfo.C_Check)
                db.AddInParameter(dbComm, "@C_CheckAction", DbType.String, Objinfo.C_CheckAction)
                db.AddInParameter(dbComm, "@C_CheckRemark", DbType.String, Objinfo.C_CheckRemark)

                db.ExecuteNonQuery(dbComm)
                ProductionKaiLiaoA_UpdateCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionKaiLiaoA_UpdateCheck = False
            End Try
        End Function



        Public Function ProductionKaiLiao_ReCheck(ByVal Objinfo As ProductionKaiLiaoInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionKaiLiao_ReCheck")

                db.AddInParameter(dbComm, "@C_NO", DbType.String, Objinfo.C_NO)
                db.AddInParameter(dbComm, "@C_ReCheck", DbType.Boolean, Objinfo.C_ReCheck)

                db.ExecuteNonQuery(dbComm)
                ProductionKaiLiao_ReCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionKaiLiao_ReCheck = False
            End Try
        End Function

        Public Function ProductionKaiLiao_Delete(ByVal C_NO As String, ByVal IndexNo As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionKaiLiao_Delete")

                db.AddInParameter(dbComm, "@C_NO", DbType.String, C_NO)
                db.AddInParameter(dbComm, "@IndexNo", DbType.String, IndexNo)

                db.ExecuteNonQuery(dbComm)
                ProductionKaiLiao_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionKaiLiao_Delete = False
            End Try
        End Function
        Public Function ProductionKaiLiaoA_Delete(ByVal C_Number As String, ByVal IndexNo As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionKaiLiaoA_Delete")

                db.AddInParameter(dbComm, "@C_Number", DbType.String, C_Number)
                db.AddInParameter(dbComm, "@IndexNo", DbType.String, IndexNo)

                db.ExecuteNonQuery(dbComm)
                ProductionKaiLiaoA_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionKaiLiaoA_Delete = False
            End Try
        End Function



        Public Function ProductionKaiLiao_GetList(ByVal C_NO As String, ByVal Pro_Type As String, ByVal PS_Action As String, ByVal C_Action As String, ByVal M_Name As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal C_Date1 As String, ByVal C_Date2 As String, ByVal C_Check As String, ByVal FacID As String) As List(Of ProductionKaiLiaoInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionKaiLiao_GetList")

            db.AddInParameter(dbComm, "@C_NO", DbType.String, C_NO)
            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PS_Action", DbType.String, PS_Action)
            db.AddInParameter(dbComm, "@C_Action", DbType.String, C_Action)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@C_Date1", DbType.String, C_Date1)
            db.AddInParameter(dbComm, "@C_Date2", DbType.String, C_Date2)
            db.AddInParameter(dbComm, "@C_Check", DbType.String, C_Check)
            db.AddInParameter(dbComm, "@FacID", DbType.String, FacID)

            Dim FeatureList As New List(Of ProductionKaiLiaoInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionKaiLiao(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function ProductionKaiLiao_GetListIndexNo(ByVal IndexNo As String, ByVal C_NO As String, ByVal Pro_Type As String, ByVal PS_Action As String, ByVal C_Action As String, ByVal M_Name As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal C_Date1 As String, ByVal C_Date2 As String, ByVal C_Check As String, ByVal FacID As String) As List(Of ProductionKaiLiaoInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionKaiLiao_GetListIndexNo")

            db.AddInParameter(dbComm, "@IndexNo", DbType.String, IndexNo)
            db.AddInParameter(dbComm, "@C_NO", DbType.String, C_NO)
            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PS_Action", DbType.String, PS_Action)
            db.AddInParameter(dbComm, "@C_Action", DbType.String, C_Action)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@C_Date1", DbType.String, C_Date1)
            db.AddInParameter(dbComm, "@C_Date2", DbType.String, C_Date2)
            db.AddInParameter(dbComm, "@C_Check", DbType.String, C_Check)
            db.AddInParameter(dbComm, "@FacID", DbType.String, FacID)

            Dim FeatureList As New List(Of ProductionKaiLiaoInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionKaiLiao(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function ProductionKaiLiaoA_GetList(ByVal C_NO As String, ByVal Pro_Type As String, ByVal PS_Action As String, ByVal C_Action As String, ByVal M_Name As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal C_Date1 As String, ByVal C_Date2 As String, ByVal C_Check As String, ByVal FacID As String, ByVal C_Number As String, ByVal OM_ID As String, ByVal OS_BatchID As String, ByVal FP_NO As String) As List(Of ProductionKaiLiaoInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionKaiLiaoA_GetList")

            db.AddInParameter(dbComm, "@C_NO", DbType.String, C_NO)
            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PS_Action", DbType.String, PS_Action)
            db.AddInParameter(dbComm, "@C_Action", DbType.String, C_Action)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@C_Date1", DbType.String, C_Date1)
            db.AddInParameter(dbComm, "@C_Date2", DbType.String, C_Date2)
            db.AddInParameter(dbComm, "@C_Check", DbType.String, C_Check)
            db.AddInParameter(dbComm, "@FacID", DbType.String, FacID)
            db.AddInParameter(dbComm, "@C_Number", DbType.String, C_Number)
            db.AddInParameter(dbComm, "@OM_ID", DbType.String, OM_ID)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@FP_NO", DbType.String, FP_NO)

            Dim FeatureList As New List(Of ProductionKaiLiaoInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionKaiLiao(reader))
                End While
                Return FeatureList
            End Using
        End Function


#Region "開料耗用信息記錄"

        Public Function KaiLiaoManagement_Add(ByVal objinfo As ProductionKaiLiaoInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("KaiLiaoManagement_Add")

                db.AddInParameter(dbComm, "@KL_NO", DbType.String, objinfo.KL_NO)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@M_Type", DbType.String, objinfo.M_Type)
                db.AddInParameter(dbComm, "@KL_Qty", DbType.Int32, objinfo.KL_Qty)
                db.AddInParameter(dbComm, "@KL_ActualWeight", DbType.String, objinfo.KL_ActualWeight)
                db.AddInParameter(dbComm, "@KL_TheoryWeight", DbType.String, objinfo.KL_TheoryWeight)
                db.AddInParameter(dbComm, "@KL_Date", DbType.Date, objinfo.KL_Date)
                db.AddInParameter(dbComm, "@KL_Action", DbType.String, objinfo.KL_Action)
                db.AddInParameter(dbComm, "@KL_Check", DbType.Boolean, objinfo.KL_Check)

                db.ExecuteNonQuery(dbComm)
                KaiLiaoManagement_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                KaiLiaoManagement_Add = False
            End Try

        
        End Function

        Public Function KaiLiaoManagement_GetList(ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal KL_NO As String, ByVal M_Code As String, ByVal M_Type As String, ByVal KL_Date1 As String, ByVal KL_Date2 As String, ByVal KL_Check As String) As List(Of ProductionKaiLiaoInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("KaiLiaoManagement_GetList")


            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@KL_NO", DbType.String, KL_NO)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Type", DbType.String, M_Type)
            db.AddInParameter(dbComm, "@KL_Date1", DbType.String, KL_Date1)
            db.AddInParameter(dbComm, "@KL_Date2", DbType.String, KL_Date2)
            db.AddInParameter(dbComm, "@KL_Check", DbType.String, KL_Check)


            Dim FeatureList As New List(Of ProductionKaiLiaoInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionKaiLiao(reader))
                End While
                Return FeatureList
            End Using
        End Function

#End Region

        Public Function vwProductionKaiLiao_GetList(ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal M_Code As String, ByVal KL_StartDate As String, ByVal KL_EndDate As String) As List(Of ProductionKaiLiaoInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("vwProductionKaiLiao_GetList")


            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@KL_StartDate", DbType.String, KL_StartDate)
            db.AddInParameter(dbComm, "@KL_EndDate", DbType.String, KL_EndDate)

            Dim FeatureList As New List(Of ProductionKaiLiaoInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionKaiLiao(reader))
                End While
                Return FeatureList
            End Using
        End Function


        Public Function FillProductionKaiLiao(ByVal reader As IDataReader) As ProductionKaiLiaoInfo

            On Error Resume Next

            Dim pi As New ProductionKaiLiaoInfo



            If reader("PM_JiYu") Is DBNull.Value Then
                pi.PM_JiYu = Nothing
            Else
                pi.PM_JiYu = reader("PM_JiYu")
            End If


            pi.IndexNo = reader("IndexNo").ToString
            pi.C_NO = reader("C_NO").ToString
            pi.WH_ID = reader("WH_ID").ToString
            pi.Pro_Type = reader("Pro_Type").ToString
            pi.PM_M_Code = reader("PM_M_Code").ToString
            pi.PM_Type = reader("PM_Type").ToString
            pi.PS_Dep = reader("PS_Dep").ToString
            pi.PS_Action = reader("PS_Action").ToString

            pi.C_Qty = CDbl(reader("C_Qty").ToString)

            pi.C_Weight = CDbl(reader("C_Weight").ToString)

            pi.C_Action = reader("C_Action").ToString
            pi.C_Remark = reader("C_Remark").ToString

            If reader("C_AddDate") Is DBNull.Value Then
                pi.C_AddDate = Nothing
            Else
                pi.C_AddDate = CStr(reader("C_AddDate"))
            End If

            pi.M_Code = reader("M_Code").ToString
            pi.C_Cishu = reader("C_Cishu").ToString
            pi.C_Type = reader("C_Type").ToString

            If reader("C_Check") Is DBNull.Value Then
                pi.C_Check = Nothing
            Else
                pi.C_Check = CStr(reader("C_Check"))
            End If

            If reader("C_ReCheck") Is DBNull.Value Then
                pi.C_ReCheck = Nothing
            Else
                pi.C_ReCheck = CStr(reader("C_ReCheck"))
            End If

            pi.C_CheckAction = reader("C_CheckAction").ToString
            pi.C_CheckRemark = reader("C_CheckRemark").ToString

            pi.C_Number = reader("C_Number").ToString
            pi.M_Name = reader("M_Name").ToString
            pi.M_Gauge = reader("M_Gauge").ToString
            pi.M_Unit = reader("M_Unit").ToString
            pi.DPT_Name = reader("DPT_Name").ToString
            pi.FacName = reader("FacName").ToString
            pi.WH_Name = reader("WH_Name").ToString
            pi.WH_PName = reader("WH_PName").ToString
            pi.CheckActionName = reader("CheckActionName").ToString
            pi.FacID = reader("FacID").ToString

            pi.OM_ID = reader("OM_ID").ToString
            pi.OS_BatchID = reader("OS_BatchID").ToString

            pi.BadQty = CInt(reader("BadQty").ToString)
            pi.FP_NO = reader("FP_NO").ToString

            '----------------------------------------------開料生產耗用信息記錄

            pi.KL_NO = reader("KL_NO").ToString
            pi.M_Type = reader("M_Type").ToString
            pi.KL_Qty = CInt(reader("KL_Qty").ToString)
            pi.KL_TheoryWeight = CDbl(reader("KL_TheoryWeight").ToString)
            pi.KL_ActualWeight = CDbl(reader("KL_ActualWeight").ToString)
            pi.KL_Action = reader("KL_Action").ToString

            If reader("KL_Date") Is DBNull.Value Then
                pi.KL_Date = Nothing
            Else
                pi.KL_Date = CStr(reader("KL_Date"))
            End If

            If reader("KL_Check") Is DBNull.Value Then
                pi.KL_Check = Nothing
            Else
                pi.KL_Check = CStr(reader("KL_Check"))
            End If

            pi.KaiLiaoActionName = reader("KaiLiaoActionName").ToString

            '----------------------------------------------

            pi.PM_M_Gauge = reader("PM_M_Gauge").ToString
            pi.PM_M_Name = reader("PM_M_Name").ToString


            Return pi

        End Function
        ''' <summary>
        ''' 2012-6-13 主要針對，查詢指定條件睅無數據，打印要輸入登錄密碼的情況
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function NothingNew() As List(Of ProductionKaiLiaoInfo)
            Dim pi As New ProductionKaiLiaoInfo
            Dim FeatureList As New List(Of ProductionKaiLiaoInfo)
            FeatureList.Add(NothingFillProductionKaiLiao())
            Return FeatureList
        End Function

        Public Function NothingFillProductionKaiLiao() As ProductionKaiLiaoInfo
            On Error Resume Next
            Dim pi As New ProductionKaiLiaoInfo
            pi.IndexNo = Nothing
            pi.C_NO = Nothing
            pi.WH_ID = Nothing
            pi.Pro_Type = Nothing
            pi.PM_M_Code = Nothing
            pi.PM_Type = Nothing
            pi.PS_Dep = Nothing
            pi.PS_Action = Nothing

            pi.C_Qty = 0
            pi.C_Weight = 0
            pi.C_Action = Nothing
            pi.C_Remark = Nothing

            pi.C_AddDate = Nothing

            pi.M_Code = Nothing
            pi.C_Cishu = Nothing
            pi.C_Type = Nothing
            pi.C_Check = Nothing

            pi.C_ReCheck = Nothing

            pi.C_CheckAction = Nothing
            pi.C_CheckRemark = Nothing

            pi.M_Name = Nothing
            pi.M_Gauge = Nothing
            pi.M_Unit = Nothing
            pi.DPT_Name = Nothing
            pi.FacName = Nothing
            pi.WH_Name = Nothing
            pi.WH_PName = Nothing
            pi.CheckActionName = Nothing
            pi.FacID = Nothing

            '----------------------------------------------開料生產耗用信息記錄
            pi.KL_NO = Nothing
            pi.M_Type = Nothing
            pi.KL_Qty = 0
            pi.KL_TheoryWeight = 0
            pi.KL_ActualWeight = 0
            pi.KL_Action = Nothing
            pi.KL_Date = Nothing
            pi.KL_Check = Nothing

            pi.KaiLiaoActionName = Nothing
                Return pi
        End Function


    End Class

End Namespace

