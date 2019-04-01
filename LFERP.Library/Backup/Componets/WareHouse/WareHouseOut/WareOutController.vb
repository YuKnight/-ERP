
Namespace LFERP.Library.WareHouse.WareOut


    Public Class WareOutController

        Friend Function FillWareOut(ByVal reader As IDataReader) As WareOutInfo
            On Error Resume Next
            '對應取得的數據
            Dim objInfo As New WareOutInfo

            objInfo.SumHKD = reader("SumHKD")
            objInfo.HKDRate = reader("HKDRate")


            objInfo.WO_NUM = reader("WO_NUM").ToString
            objInfo.WO_ID = reader("WO_ID").ToString

            objinfo.WO_Type =reader("WO_Type").ToString  
            objInfo.AP_NO = reader("AP_NO").ToString
            objInfo.OP_NO = reader("OP_NO").ToString

            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            If reader("M_Price") Is DBNull.Value Then
                objInfo.M_Price = Nothing
            Else
                objInfo.M_Price = FormatNumber(CDbl(reader("M_Price")), 4, TriState.True)
            End If

            If reader("WO_Qty") Is DBNull.Value Then
                objInfo.WO_Qty = Nothing
            Else
                objInfo.WO_Qty = CDbl(reader("WO_Qty").ToString)
            End If

            If reader("WO_AddDate") Is DBNull.Value Then
                objInfo.WO_AddDate = Nothing
            Else
                objInfo.WO_AddDate = CStr(reader("WO_AddDate"))
            End If
            objInfo.WH_ID = reader("WH_ID").ToString
            objInfo.OS_BatchID = reader("OS_BatchID").ToString
            objInfo.WO_Action = reader("WO_Action").ToString
            If reader("WO_EditDate") Is DBNull.Value Then
                objInfo.WO_EditDate = Nothing
            Else
                objInfo.WO_EditDate = CStr(reader("WO_EditDate"))
            End If
            objInfo.WO_Remark = reader("WO_Remark").ToString
            objInfo.DPT_ID = reader("DPT_ID").ToString
            objInfo.WO_PerID = reader("WO_PerID").ToString
            objInfo.WO_PerName = reader("WO_PerName").ToString

            If reader("WO_Check") Is DBNull.Value Then
                objInfo.WO_Check = Nothing
            Else
                objInfo.WO_Check = reader("WO_Check")
            End If
            objInfo.WO_CheckAction = reader("WO_CheckAction").ToString
            If reader("WO_CheckDate") Is DBNull.Value Then
                objInfo.WO_CheckDate = Nothing
            Else
                objInfo.WO_CheckDate = CStr(reader("WO_CheckDate"))
            End If
            objInfo.WO_CheckRemark = reader("WO_CheckRemark").ToString

            If reader("WO_ReCheck") Is DBNull.Value Then
                objInfo.WO_ReCheck = Nothing
            Else
                objInfo.WO_ReCheck = reader("WO_ReCheck")
            End If
            objInfo.WO_ReCheckAction = reader("WO_ReCheckAction").ToString
            If reader("WO_ReCheckDate") Is DBNull.Value Then
                objInfo.WO_ReCheckDate = Nothing
            Else
                objInfo.WO_ReCheckDate = CStr(reader("WO_ReCheckDate"))
            End If
            objInfo.WO_ReCheckRemark = reader("WO_ReCheckRemark").ToString


            objInfo.WO_ActionName = reader("WO_ActionName").ToString
            objInfo.WO_CheckActionName = reader("WO_CheckActionName").ToString
            objInfo.WH_Name = reader("WH_Name").ToString
            objInfo.WH_PName = reader("WH_PName").ToString
            objInfo.DPT_Name = reader("DPT_PName").ToString & "-" & reader("DPT_Name").ToString
            objInfo.DPT_PName = reader("DPT_PName").ToString

            If reader("OutGetQty") Is DBNull.Value Then
                objInfo.OutGetQty = Nothing
            Else
                objInfo.OutGetQty = CDbl(reader("OutGetQty").ToString)
            End If
            If reader("OutGetQty1") Is DBNull.Value Then
                objInfo.OutGetQty1 = Nothing
            Else
                objInfo.OutGetQty1 = CDbl(reader("OutGetQty1").ToString)
            End If

            objInfo.M_ID = reader("M_ID").ToString
            objInfo.Temp_Code = reader("Temp_Code").ToString

            If reader("WO_EndQty") Is DBNull.Value Then   '出庫后的期末結餘數
                objInfo.WO_EndQty = 0
            Else
                objInfo.WO_EndQty = CDbl(reader("WO_EndQty").ToString)
            End If

            objInfo.strDate = CStr(reader("strDate").ToString)

            objInfo.TypeAllName = reader("Type1Name") & "-" & reader("Type2Name") & "-" & reader("Type3Name")
            objInfo.M_Currency = CStr(reader("M_Currency").ToString)
            objInfo.M_ID = reader("M_ID").ToString
            objInfo.Temp_Code = reader("Temp_Code").ToString
            If reader("AllQty") Is DBNull.Value Then
                objInfo.AllQty = 0
            Else
                objInfo.AllQty = reader("AllQty")
            End If

            objInfo.WH_AllName = reader("WH_PName").ToString & "-" & reader("WH_Name").ToString
            Return objInfo
        End Function


        ''' <summary>
        '''新增 
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareOut_Add(ByVal objFile1 As WareOutInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareOut_Add")

                db.AddInParameter(dbComm, "@WO_NUM", DbType.String, objFile1.WO_NUM)
                db.AddInParameter(dbComm, "@WO_ID", DbType.String, objFile1.WO_ID)

                db.AddInParameter(dbComm, "@WO_Type", DbType.String, objFile1.WO_Type)
                db.AddInParameter(dbComm, "@AP_NO", DbType.String, objFile1.AP_NO)
                db.AddInParameter(dbComm, "@OP_NO", DbType.String, objFile1.OP_NO)

                db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)
                'db.AddInParameter(dbComm, "@M_Name", DbType.String, objFile1.M_Name)
                'db.AddInParameter(dbComm, "@M_Gauge", DbType.String, objFile1.M_Gauge)
                'db.AddInParameter(dbComm, "@M_Unit", DbType.String, objFile1.M_Unit)
                db.AddInParameter(dbComm, "@WO_Qty", DbType.Single, objFile1.WO_Qty)
                If objFile1.WO_AddDate = Nothing Then
                    db.AddInParameter(dbComm, "@WO_AddDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@WO_AddDate", DbType.Date, objFile1.WO_AddDate)
                End If

                db.AddInParameter(dbComm, "@WH_ID", DbType.String, objFile1.WH_ID)
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)
                db.AddInParameter(dbComm, "@WO_Action", DbType.String, objFile1.WO_Action)
                If objFile1.WO_EditDate = Nothing Then
                    db.AddInParameter(dbComm, "@WO_EditDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@WO_EditDate", DbType.Date, objFile1.WO_EditDate)
                End If
                db.AddInParameter(dbComm, "@WO_Remark", DbType.String, objFile1.WO_Remark)
                db.AddInParameter(dbComm, "@DPT_ID", DbType.String, objFile1.DPT_ID)
                db.AddInParameter(dbComm, "@WO_PerID", DbType.String, objFile1.WO_PerID)
                db.AddInParameter(dbComm, "@WO_PerName", DbType.String, objFile1.WO_PerName)


                db.AddInParameter(dbComm, "@WO_Check", DbType.Boolean, objFile1.WO_Check)
                db.AddInParameter(dbComm, "@WO_CheckAction", DbType.String, objFile1.WO_CheckAction)
                If objFile1.WO_CheckDate = Nothing Then
                    db.AddInParameter(dbComm, "@WO_CheckDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@WO_CheckDate", DbType.Date, objFile1.WO_CheckDate)
                End If

                db.AddInParameter(dbComm, "@WO_CheckRemark", DbType.String, objFile1.WO_CheckRemark)

                db.AddInParameter(dbComm, "@M_ID", DbType.String, objFile1.M_ID)
                db.AddInParameter(dbComm, "@Temp_Code", DbType.String, objFile1.Temp_Code)

                db.ExecuteNonQuery(dbComm)
                WareOut_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                WareOut_Add = False
            End Try

        End Function


        ''' <summary>
        '''修改 
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareOut_Update(ByVal objFile1 As WareOutInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareOut_Update")

                db.AddInParameter(dbComm, "@WO_ID", DbType.String, objFile1.WO_ID)
                db.AddInParameter(dbComm, "@WO_NUM", DbType.String, objFile1.WO_NUM)
                db.AddInParameter(dbComm, "@WO_Type", DbType.String, objFile1.WO_Type)
                db.AddInParameter(dbComm, "@AP_NO", DbType.String, objFile1.AP_NO)
                db.AddInParameter(dbComm, "@OP_NO", DbType.String, objFile1.OP_NO)

                db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)
                'db.AddInParameter(dbComm, "@M_Name", DbType.String, objFile1.M_Name)
                'db.AddInParameter(dbComm, "@M_Gauge", DbType.String, objFile1.M_Gauge)
                'db.AddInParameter(dbComm, "@M_Unit", DbType.String, objFile1.M_Unit)
                db.AddInParameter(dbComm, "@WO_Qty", DbType.Single, objFile1.WO_Qty)
                If objFile1.WO_AddDate = Nothing Then
                    db.AddInParameter(dbComm, "@WO_AddDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@WO_AddDate", DbType.Date, objFile1.WO_AddDate)
                End If

                db.AddInParameter(dbComm, "@WH_ID", DbType.String, objFile1.WH_ID)
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)
                db.AddInParameter(dbComm, "@WO_Action", DbType.String, objFile1.WO_Action)
                If objFile1.WO_EditDate = Nothing Then
                    db.AddInParameter(dbComm, "@WO_EditDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@WO_EditDate", DbType.Date, objFile1.WO_EditDate)
                End If
                db.AddInParameter(dbComm, "@WO_Remark", DbType.String, objFile1.WO_Remark)
                db.AddInParameter(dbComm, "@DPT_ID", DbType.String, objFile1.DPT_ID)
                db.AddInParameter(dbComm, "@WO_PerID", DbType.String, objFile1.WO_PerID)
                db.AddInParameter(dbComm, "@WO_PerName", DbType.String, objFile1.WO_PerName)


                db.AddInParameter(dbComm, "@WO_Check", DbType.Boolean, objFile1.WO_Check)
                db.AddInParameter(dbComm, "@WO_CheckAction", DbType.String, objFile1.WO_CheckAction)
                If objFile1.WO_CheckDate = Nothing Then
                    db.AddInParameter(dbComm, "@WO_CheckDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@WO_CheckDate", DbType.Date, objFile1.WO_CheckDate)
                End If

                db.AddInParameter(dbComm, "@WO_CheckRemark", DbType.String, objFile1.WO_CheckRemark)


                db.AddInParameter(dbComm, "@M_ID", DbType.String, objFile1.M_ID)
                db.AddInParameter(dbComm, "@Temp_Code", DbType.String, objFile1.Temp_Code)

                db.ExecuteNonQuery(dbComm)
                WareOut_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                WareOut_Update = False
            End Try

        End Function


        ''' <summary>
        ''' 修改審核  (具體到取消審核)
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareOut_UpdateCheck(ByVal objFile1 As WareOutInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareOut_UpdateCheck")


                db.AddInParameter(dbComm, "@WO_ID", DbType.String, objFile1.WO_ID)

                db.AddInParameter(dbComm, "@WO_Check", DbType.Boolean, objFile1.WO_Check)
                db.AddInParameter(dbComm, "@WO_CheckAction", DbType.String, objFile1.WO_CheckAction)
                If objFile1.WO_CheckDate = Nothing Then
                    db.AddInParameter(dbComm, "@WO_CheckDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@WO_CheckDate", DbType.Date, objFile1.WO_CheckDate)
                End If

                db.AddInParameter(dbComm, "@WO_CheckRemark", DbType.String, objFile1.WO_CheckRemark)


                db.ExecuteNonQuery(dbComm)
                WareOut_UpdateCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                WareOut_UpdateCheck = False
            End Try

        End Function
        ''' <summary>
        ''' 復核(會計部操作)
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareOut_UpdateReCheck(ByVal objFile1 As WareOutInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareOut_UpdateReCheck")


                db.AddInParameter(dbComm, "@WO_ID", DbType.String, objFile1.WO_ID)

                db.AddInParameter(dbComm, "@WO_ReCheck", DbType.Boolean, objFile1.WO_ReCheck)
                db.AddInParameter(dbComm, "@WO_ReCheckAction", DbType.String, objFile1.WO_ReCheckAction)
                If objFile1.WO_ReCheckDate = Nothing Then
                    db.AddInParameter(dbComm, "@WO_ReCheckDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@WO_ReCheckDate", DbType.Date, objFile1.WO_ReCheckDate)
                End If

                db.AddInParameter(dbComm, "@WO_ReCheckRemark", DbType.String, objFile1.WO_ReCheckRemark)


                db.ExecuteNonQuery(dbComm)
                WareOut_UpdateReCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                WareOut_UpdateReCheck = False
            End Try

        End Function


        ''' <summary>
        ''' 刪除
        ''' </summary>
        ''' <param name="WO_NUM"></param>
        ''' <param name="WO_ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareOut_Delete(ByVal WO_NUM As String, ByVal WO_ID As String) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareOut_Delete")
                db.AddInParameter(dbComm, "@WO_NUM", DbType.String, WO_NUM)
                db.AddInParameter(dbComm, "@WO_ID", DbType.String, WO_ID)

                db.ExecuteNonQuery(dbComm)
                WareOut_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                WareOut_Delete = False

            End Try
        End Function


        Public Function WareOut_Getlist(ByVal WO_ID As String, ByVal OS_BatchID As String, ByVal M_Code As String, ByVal M_Name As String, ByVal WH_ID As String, ByVal DPT_ID As String, ByVal WO_PerID As String, ByVal WO_AddDate As String, ByVal WO_AddDateVal As String, ByVal WO_Check As String, ByVal WO_ReCheck As String) As List(Of WareOutInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareOut_Getlist")

            db.AddInParameter(dbComm, "@WO_ID", DbType.String, WO_ID)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@DPT_ID", DbType.String, DPT_ID)
            db.AddInParameter(dbComm, "@WO_PerID", DbType.String, WO_PerID)
            db.AddInParameter(dbComm, "@WO_AddDate", DbType.String, WO_AddDate)
            db.AddInParameter(dbComm, "@WO_AddDateVal", DbType.String, WO_AddDateVal)

            db.AddInParameter(dbComm, "@WO_Check", DbType.String, WO_Check)
            db.AddInParameter(dbComm, "@WO_ReCheck", DbType.String, WO_ReCheck)


            Dim FeatureList As New List(Of WareOutInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareOut(reader))
                End While
                Return FeatureList
            End Using
        End Function


        Public Function WareOut_Getlist5(ByVal WO_ID As String, ByVal OS_BatchID As String, ByVal M_Code As String, ByVal M_Name As String, ByVal WH_ID As String, ByVal DPT_ID As String, ByVal WO_PerID As String, ByVal WO_AddDate As String, ByVal WO_AddDateVal As String, ByVal WO_Check As String, ByVal WO_ReCheck As String, ByVal Type3ID As String) As List(Of WareOutInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareOut_Getlist5")

            db.AddInParameter(dbComm, "@WO_ID", DbType.String, WO_ID)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@DPT_ID", DbType.String, DPT_ID)
            db.AddInParameter(dbComm, "@WO_PerID", DbType.String, WO_PerID)
            db.AddInParameter(dbComm, "@WO_AddDate", DbType.String, WO_AddDate)
            db.AddInParameter(dbComm, "@WO_AddDateVal", DbType.String, WO_AddDateVal)

            db.AddInParameter(dbComm, "@WO_Check", DbType.String, WO_Check)
            db.AddInParameter(dbComm, "@WO_ReCheck", DbType.String, WO_ReCheck)

            db.AddInParameter(dbComm, "@Type3ID", DbType.String, Type3ID)

            Dim FeatureList As New List(Of WareOutInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareOut(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function WareOut_GetList1(ByVal WO_ID As String, ByVal WH_ID As String, ByVal M_Code As String, ByVal DPT_ID As String, ByVal M_Name As String, ByVal WO_Date1 As String, ByVal WO_Date2 As String, ByVal WO_PerID As String, ByVal WO_Check As String) As List(Of WareOutInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareOut_GetList1")

            db.AddInParameter(dbComm, "@WO_ID", DbType.String, WO_ID)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@DPT_ID", DbType.String, DPT_ID)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@WO_Date1", DbType.String, WO_Date1)
            db.AddInParameter(dbComm, "@WO_Date2", DbType.String, WO_Date2)
            db.AddInParameter(dbComm, "@WO_PerID", DbType.String, WO_PerID)
            db.AddInParameter(dbComm, "@WO_Check", DbType.String, WO_Check)

            Dim FeatureList As New List(Of WareOutInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareOut(reader))
                End While
                Return FeatureList
            End Using

        End Function


        Public Function WareOutExport_Getlist(ByVal WH_ID As String, ByVal DPT_ID As String, ByVal WO_AddDate1 As String, ByVal WO_AddDate2 As String) As List(Of WareOutInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareOutExport_Getlist")
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@DPT_ID", DbType.String, DPT_ID)
            db.AddInParameter(dbComm, "@WO_AddDate1", DbType.String, WO_AddDate1)
            db.AddInParameter(dbComm, "@WO_AddDate2", DbType.String, WO_AddDate2)

            Dim FeatureList As New List(Of WareOutInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareOut(reader))
                End While
                Return FeatureList
            End Using
        End Function
        ''' <summary>
        '''  匯總當前倉庫當前批次指定物料的出庫總數
        ''' </summary>
        ''' <param name="OS_BatchID"></param>
        ''' <param name="M_Code"></param>
        ''' <param name="WH_ID"></param>
        ''' <param name="WO_Check"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareOut_GetQty(ByVal OS_BatchID As String, ByVal M_Code As String, ByVal WH_ID As String, ByVal WO_Check As String) As List(Of WareOutInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareOut_GetQty")

            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@WO_Check", DbType.String, WO_Check)

            Dim FeatureList As New List(Of WareOutInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareOut(reader))
                End While
                Return FeatureList
            End Using
        End Function
        ''' <summary>
        ''' 匯總當前倉庫指定物料在所有批次中分別出庫總數量
        ''' </summary>
        ''' <param name="OS_BatchID"></param>
        ''' <param name="M_Code"></param>
        ''' <param name="WH_ID"></param>
        ''' <param name="WO_Check"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareOut_GetQty1(ByVal OS_BatchID As String, ByVal M_Code As String, ByVal WH_ID As String, ByVal WO_Check As String, ByVal WO_Date1 As String, ByVal WO_Date2 As String) As List(Of WareOutInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareOut_GetQty1")

            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@WO_Check", DbType.String, WO_Check)
            db.AddInParameter(dbComm, "@WO_Date1", DbType.String, WO_Date1)
            db.AddInParameter(dbComm, "@WO_Date2", DbType.String, WO_Date2)

            Dim FeatureList As New List(Of WareOutInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareOut(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function WareOut_GetQty2(ByVal M_Code As String, ByVal WH_ID As String, ByVal WO_Check As String, ByVal WO_Date1 As String, ByVal WO_Date2 As String) As List(Of WareOutInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareOut_GetQty2")

            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@WO_Check", DbType.String, WO_Check)
            db.AddInParameter(dbComm, "@WO_Date1", DbType.String, WO_Date1)
            db.AddInParameter(dbComm, "@WO_Date2", DbType.String, WO_Date2)

            Dim FeatureList As New List(Of WareOutInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareOut(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function WareOut_GetQty3(ByVal WO_ID As String, ByVal M_Code As String, ByVal OP_NO As String) As List(Of WareOutInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareOut_GetQty3")

            db.AddInParameter(dbComm, "@WO_ID", DbType.String, WO_ID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@OP_NO", DbType.String, OP_NO)

            Dim FeatureList As New List(Of WareOutInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareOut(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function WareOut_ProductionGetList(ByVal WO_Type As String, ByVal AP_NO As String) As List(Of WareOutInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareOut_ProductionGetList")

            db.AddInParameter(dbComm, "@WO_Type", DbType.String, WO_Type)
            db.AddInParameter(dbComm, "@AP_NO", DbType.String, AP_NO)

            Dim FeatureList As New List(Of WareOutInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareOut(reader))
                End While
                Return FeatureList
            End Using

        End Function
        ''' <summary>
        ''' 取得一條最大WO_NUM記錄
        ''' </summary>
        ''' <param name="WO_NUM"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareOut_GetNUM(ByVal WO_NUM As String) As WareOutInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareOut_GetNUM")
            db.AddInParameter(dbComm, "@WO_NUM", DbType.String, WO_NUM)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillWareOut(reader)
                End While
                Return Nothing
            End Using
        End Function


        ''' <summary>
        ''' 取得當前最大的ID。隻用於生成新的ID用
        ''' </summary>
        ''' <param name="NDate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareOut_GetID(ByVal NDate As String) As WareOutInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareOut_GetID")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillWareOut(reader)
                End While
                Return Nothing
            End Using
        End Function


        Public Function WareOut_UpdateEndQty(ByVal objinfo As WareOutInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareOut_UpdateEndQty")

                db.AddInParameter(dbComm, "@WO_ID", DbType.String, objinfo.WO_ID)
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, objinfo.WH_ID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@WO_EndQty", DbType.Single, objinfo.WO_EndQty)

                db.ExecuteNonQuery(dbComm)
                WareOut_UpdateEndQty = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareOut_UpdateEndQty = False
            End Try

        End Function


        Public Function WareOut_HalfYearGetList(ByVal WH_ID As String, ByVal M_Code As String, ByVal WO_AddDate As String, ByVal WO_AddDateVal As String) As List(Of WareOutInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareOut_HalfYearGetList")

            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@WO_AddDate", DbType.String, WO_AddDate)
            db.AddInParameter(dbComm, "@WO_AddDateVal", DbType.String, WO_AddDateVal)

            Dim FeatureList As New List(Of WareOutInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareOut(reader))
                End While
                Return FeatureList
            End Using
        End Function

        ''' <summary>
        ''' 出庫匯總信息 2012-11-20
        ''' </summary>
        ''' <param name="WH_ID"></param>
        ''' <param name="DateStart"></param>
        ''' <param name="DateEnd"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareOut_Getlist4(ByVal WH_ID As String, ByVal DateStart As String, ByVal DateEnd As String) As List(Of WareOutInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareOut_GetList4")

            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@DateStart", DbType.String, DateStart)
            db.AddInParameter(dbComm, "@DateEnd", DbType.String, DateEnd)

            Dim FeatureList As New List(Of WareOutInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareOut(reader))
                End While
                Return FeatureList
            End Using
        End Function



        ''' <summary>
        ''' 只修改備注信息
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareOut_UpdateRemark(ByVal objFile1 As WareOutInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareOut_UpdateRemark")

                db.AddInParameter(dbComm, "@WO_ID", DbType.String, objFile1.WO_ID)
                db.AddInParameter(dbComm, "@WO_NUM", DbType.String, objFile1.WO_NUM)

                db.AddInParameter(dbComm, "@WO_Remark", DbType.String, objFile1.WO_Remark)


                db.ExecuteNonQuery(dbComm)
                WareOut_UpdateRemark = True

            Catch ex As Exception
                MsgBox(ex.Message)
                WareOut_UpdateRemark = False
            End Try

        End Function

        ''' <summary>
        ''' 在庫存模塊加入顯示最近50條記錄
        ''' </summary>
        ''' <param name="WO_ID"></param>
        ''' <param name="OS_BatchID"></param>
        ''' <param name="M_Code"></param>
        ''' <param name="M_Name"></param>
        ''' <param name="WH_ID"></param>
        ''' <param name="DPT_ID"></param>
        ''' <param name="WO_PerID"></param>
        ''' <param name="WO_AddDate"></param>
        ''' <param name="WO_AddDateVal"></param>
        ''' <param name="WO_Check"></param>
        ''' <param name="WO_ReCheck"></param>
        ''' <param name="Type3ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareOut_GetListTop50(ByVal WO_ID As String, ByVal OS_BatchID As String, ByVal M_Code As String, ByVal M_Name As String, ByVal WH_ID As String, ByVal DPT_ID As String, ByVal WO_PerID As String, ByVal WO_AddDate As String, ByVal WO_AddDateVal As String, ByVal WO_Check As String, ByVal WO_ReCheck As String, ByVal Type3ID As String) As List(Of WareOutInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareOut_GetListTop50")

            db.AddInParameter(dbComm, "@WO_ID", DbType.String, WO_ID)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@DPT_ID", DbType.String, DPT_ID)
            db.AddInParameter(dbComm, "@WO_PerID", DbType.String, WO_PerID)
            db.AddInParameter(dbComm, "@WO_AddDate", DbType.String, WO_AddDate)
            db.AddInParameter(dbComm, "@WO_AddDateVal", DbType.String, WO_AddDateVal)

            db.AddInParameter(dbComm, "@WO_Check", DbType.String, WO_Check)
            db.AddInParameter(dbComm, "@WO_ReCheck", DbType.String, WO_ReCheck)

            db.AddInParameter(dbComm, "@Type3ID", DbType.String, Type3ID)

            Dim FeatureList As New List(Of WareOutInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareOut(reader))
                End While
                Return FeatureList
            End Using
        End Function


    End Class




End Namespace