Namespace LFERP.Library.WareHouse.WareInput

    Public Class WareInputContraller


        Friend Function FillWareInput(ByVal reader As IDataReader) As WareInputInfo
            On Error Resume Next
            '對應取得的數據
            Dim objInfo As New WareInputInfo

            objInfo.WIP_NUM = reader("WIP_NUM").ToString
            objInfo.WIP_ID = reader("WIP_ID").ToString

            objInfo.WIP_Type = reader("WIP_Type").ToString

            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            If reader("WIP_Qty") Is DBNull.Value Then
                objInfo.WIP_Qty = Nothing
            Else
                objInfo.WIP_Qty = CDbl(reader("WIP_Qty").ToString)
            End If

            If reader("WIP_AddDate") Is DBNull.Value Then
                objInfo.WIP_AddDate = Nothing
            Else
                objInfo.WIP_AddDate = CStr(reader("WIP_AddDate"))
            End If
            objInfo.WH_ID = reader("WH_ID").ToString
            objInfo.OS_BatchID = reader("OS_BatchID").ToString
            objInfo.WIP_Action = reader("WIP_Action").ToString
            If reader("WIP_EditDate") Is DBNull.Value Then
                objInfo.WIP_EditDate = Nothing
            Else
                objInfo.WIP_EditDate = CStr(reader("WIP_EditDate"))
            End If
            objInfo.WIP_Remark = reader("WIP_Remark").ToString
            objInfo.DPT_ID = reader("DPT_ID").ToString
            If reader("WIP_Check") Is DBNull.Value Then
                objInfo.WIP_Check = Nothing
            Else
                objInfo.WIP_Check = reader("WIP_Check")
            End If
            objInfo.WIP_CheckAction = reader("WIP_CheckAction").ToString
            If reader("WIP_CheckDate") Is DBNull.Value Then
                objInfo.WIP_CheckDate = Nothing
            Else
                objInfo.WIP_CheckDate = CStr(reader("WIP_CheckDate"))
            End If
            objInfo.WIP_CheckRemark = reader("WIP_CheckRemark").ToString

            objInfo.WIP_ActionName = reader("WIP_ActionName").ToString
            objInfo.WIP_CheckActionName = reader("WIP_CheckActionName").ToString
            objInfo.WH_Name = reader("WH_Name").ToString
            objInfo.DPT_Name = reader("DPT_Name").ToString

            If reader("GetQty") Is DBNull.Value Then
                objInfo.GetQty = Nothing
            Else
                objInfo.GetQty = CDbl(reader("GetQty").ToString)
            End If
            If reader("GetQty1") Is DBNull.Value Then
                objInfo.GetQty1 = Nothing
            Else
                objInfo.GetQty1 = CDbl(reader("GetQty1").ToString)
            End If
            If reader("WIP_ReCheck") Is DBNull.Value Then
                objInfo.WIP_ReCheck = Nothing
            Else
                objInfo.WIP_ReCheck = reader("WIP_ReCheck")
            End If
            objInfo.WIP_ReCheckAction = reader("WIP_ReCheckAction").ToString
            If reader("WIP_ReCheckDate") Is DBNull.Value Then
                objInfo.WIP_ReCheckDate = Nothing
            Else
                objInfo.WIP_ReCheckDate = CStr(reader("WIP_ReCheckDate"))
            End If
            objInfo.WIP_ReCheckRemark = reader("WIP_ReCheckRemark").ToString

            If reader("WIP_EndQty") Is DBNull.Value Then    '入庫操作后的期末結餘數
                objInfo.WIP_EndQty = 0
            Else
                objInfo.WIP_EndQty = CDbl(reader("WIP_EndQty").ToString)
            End If

            objInfo.WH_PName = reader("WH_PName").ToString
            objInfo.WH_AllName = reader("WH_PName").ToString & "-" & reader("WH_Name").ToString

            objInfo.CardID = reader("CardID").ToString

            objInfo.RC_NO = reader("RC_NO").ToString '退料單 
            objInfo.RC_AutoID = reader("RC_AutoID").ToString '退料單流水號 

            Return objInfo
        End Function

        Public Function WareInput_Add1(ByVal objFile1 As WareInputInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInput_Add1")

                db.AddInParameter(dbComm, "@WIP_NUM", DbType.String, objFile1.WIP_NUM)
                db.AddInParameter(dbComm, "@WIP_ID", DbType.String, objFile1.WIP_ID)

                db.AddInParameter(dbComm, "@WIP_Type", DbType.String, objFile1.WIP_Type)

                db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)
                'db.AddInParameter(dbComm, "@M_Name", DbType.String, objFile1.M_Name)
                'db.AddInParameter(dbComm, "@M_Gauge", DbType.String, objFile1.M_Gauge)
                'db.AddInParameter(dbComm, "@M_Unit", DbType.String, objFile1.M_Unit)
                db.AddInParameter(dbComm, "@WIP_Qty", DbType.Double, objFile1.WIP_Qty)
                If objFile1.WIP_AddDate = Nothing Then
                    db.AddInParameter(dbComm, "@WIP_AddDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@WIP_AddDate", DbType.Date, objFile1.WIP_AddDate)
                End If

                db.AddInParameter(dbComm, "@WH_ID", DbType.String, objFile1.WH_ID)
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)
                db.AddInParameter(dbComm, "@WIP_Action", DbType.String, objFile1.WIP_Action)
                If objFile1.WIP_EditDate = Nothing Then
                    db.AddInParameter(dbComm, "@WIP_EditDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@WIP_EditDate", DbType.Date, objFile1.WIP_EditDate)
                End If
                db.AddInParameter(dbComm, "@WIP_Remark", DbType.String, objFile1.WIP_Remark)
                db.AddInParameter(dbComm, "@DPT_ID", DbType.String, objFile1.DPT_ID)
                db.AddInParameter(dbComm, "@WIP_Check", DbType.Boolean, objFile1.WIP_Check)
                db.AddInParameter(dbComm, "@WIP_CheckAction", DbType.String, objFile1.WIP_CheckAction)
                If objFile1.WIP_CheckDate = Nothing Then
                    db.AddInParameter(dbComm, "@WIP_CheckDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@WIP_CheckDate", DbType.Date, objFile1.WIP_CheckDate)
                End If

                db.AddInParameter(dbComm, "@WIP_CheckRemark", DbType.String, objFile1.WIP_CheckRemark)
                db.AddInParameter(dbComm, "@CardID", DbType.String, objFile1.CardID)

                db.AddInParameter(dbComm, "@RC_NO", DbType.String, objFile1.RC_NO)
                db.AddInParameter(dbComm, "@RC_AutoID", DbType.String, objFile1.RC_AutoID)

                db.ExecuteNonQuery(dbComm)
                WareInput_Add1 = True

            Catch ex As Exception
                MsgBox(ex.Message)
                WareInput_Add1 = False
            End Try

        End Function

        ''' <summary>
        '''新增 
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareInput_Add(ByVal objFile1 As WareInputInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInput_Add")

                db.AddInParameter(dbComm, "@WIP_NUM", DbType.String, objFile1.WIP_NUM)
                db.AddInParameter(dbComm, "@WIP_ID", DbType.String, objFile1.WIP_ID)

                db.AddInParameter(dbComm, "@WIP_Type", DbType.String, objFile1.WIP_Type)

                db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)
                'db.AddInParameter(dbComm, "@M_Name", DbType.String, objFile1.M_Name)
                'db.AddInParameter(dbComm, "@M_Gauge", DbType.String, objFile1.M_Gauge)
                'db.AddInParameter(dbComm, "@M_Unit", DbType.String, objFile1.M_Unit)
                db.AddInParameter(dbComm, "@WIP_Qty", DbType.Double, objFile1.WIP_Qty)
                If objFile1.WIP_AddDate = Nothing Then
                    db.AddInParameter(dbComm, "@WIP_AddDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@WIP_AddDate", DbType.Date, objFile1.WIP_AddDate)
                End If

                db.AddInParameter(dbComm, "@WH_ID", DbType.String, objFile1.WH_ID)
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)
                db.AddInParameter(dbComm, "@WIP_Action", DbType.String, objFile1.WIP_Action)
                If objFile1.WIP_EditDate = Nothing Then
                    db.AddInParameter(dbComm, "@WIP_EditDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@WIP_EditDate", DbType.Date, objFile1.WIP_EditDate)
                End If
                db.AddInParameter(dbComm, "@WIP_Remark", DbType.String, objFile1.WIP_Remark)
                db.AddInParameter(dbComm, "@DPT_ID", DbType.String, objFile1.DPT_ID)
                db.AddInParameter(dbComm, "@WIP_Check", DbType.Boolean, objFile1.WIP_Check)
                db.AddInParameter(dbComm, "@WIP_CheckAction", DbType.String, objFile1.WIP_CheckAction)
                If objFile1.WIP_CheckDate = Nothing Then
                    db.AddInParameter(dbComm, "@WIP_CheckDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@WIP_CheckDate", DbType.Date, objFile1.WIP_CheckDate)
                End If

                db.AddInParameter(dbComm, "@WIP_CheckRemark", DbType.String, objFile1.WIP_CheckRemark)
                db.AddInParameter(dbComm, "@CardID", DbType.String, objFile1.CardID)

                db.ExecuteNonQuery(dbComm)
                WareInput_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                WareInput_Add = False
            End Try

        End Function

        ''' <summary>
        '''修改 
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareInput_Update(ByVal objFile1 As WareInputInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInput_Update")

                db.AddInParameter(dbComm, "@WIP_ID", DbType.String, objFile1.WIP_ID)
                db.AddInParameter(dbComm, "@WIP_NUM", DbType.String, objFile1.WIP_NUM)

                db.AddInParameter(dbComm, "@WIP_Type", DbType.String, objFile1.WIP_Type)

                db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)
                'db.AddInParameter(dbComm, "@M_Name", DbType.String, objFile1.M_Name)
                'db.AddInParameter(dbComm, "@M_Gauge", DbType.String, objFile1.M_Gauge)
                'db.AddInParameter(dbComm, "@M_Unit", DbType.String, objFile1.M_Unit)
                db.AddInParameter(dbComm, "@WIP_Qty", DbType.Double, objFile1.WIP_Qty)
                If objFile1.WIP_AddDate = Nothing Then
                    db.AddInParameter(dbComm, "@WIP_AddDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@WIP_AddDate", DbType.Date, objFile1.WIP_AddDate)
                End If

                db.AddInParameter(dbComm, "@WH_ID", DbType.String, objFile1.WH_ID)
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)
                db.AddInParameter(dbComm, "@WIP_Action", DbType.String, objFile1.WIP_Action)
                If objFile1.WIP_EditDate = Nothing Then
                    db.AddInParameter(dbComm, "@WIP_EditDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@WIP_EditDate", DbType.Date, objFile1.WIP_EditDate)
                End If
                db.AddInParameter(dbComm, "@WIP_Remark", DbType.String, objFile1.WIP_Remark)
                db.AddInParameter(dbComm, "@DPT_ID", DbType.String, objFile1.DPT_ID)

                db.AddInParameter(dbComm, "@WIP_Check", DbType.Boolean, objFile1.WIP_Check)
                db.AddInParameter(dbComm, "@WIP_CheckAction", DbType.String, objFile1.WIP_CheckAction)
                If objFile1.WIP_CheckDate = Nothing Then
                    db.AddInParameter(dbComm, "@WIP_CheckDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@WIP_CheckDate", DbType.Date, objFile1.WIP_CheckDate)
                End If

                db.AddInParameter(dbComm, "@WIP_CheckRemark", DbType.String, objFile1.WIP_CheckRemark)

                db.ExecuteNonQuery(dbComm)
                WareInput_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                WareInput_Update = False
            End Try

        End Function

        ''' <summary>
        ''' 取消審核
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareInput_UpdateCheck(ByVal objFile1 As WareInputInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInput_UpdateCheck")


                db.AddInParameter(dbComm, "@WIP_ID", DbType.String, objFile1.WIP_ID)

                db.AddInParameter(dbComm, "@WIP_Check", DbType.Boolean, objFile1.WIP_Check)
                db.AddInParameter(dbComm, "@WIP_CheckAction", DbType.String, objFile1.WIP_CheckAction)
                If objFile1.WIP_CheckDate = Nothing Then
                    db.AddInParameter(dbComm, "@WIP_CheckDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@WIP_CheckDate", DbType.Date, objFile1.WIP_CheckDate)
                End If

                db.AddInParameter(dbComm, "@WIP_CheckRemark", DbType.String, objFile1.WIP_CheckRemark)


                db.ExecuteNonQuery(dbComm)
                WareInput_UpdateCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                WareInput_UpdateCheck = False
            End Try

        End Function
        ''' <summary>
        ''' 復核
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareInput_UpdateReCheck(ByVal objFile1 As WareInputInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInput_UpdateReCheck")


                db.AddInParameter(dbComm, "@WIP_ID", DbType.String, objFile1.WIP_ID)

                db.AddInParameter(dbComm, "@WIP_ReCheck", DbType.Boolean, objFile1.WIP_ReCheck)
                db.AddInParameter(dbComm, "@WIP_ReCheckAction", DbType.String, objFile1.WIP_ReCheckAction)
                If objFile1.WIP_ReCheckDate = Nothing Then
                    db.AddInParameter(dbComm, "@WIP_ReCheckDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@WIP_ReCheckDate", DbType.Date, objFile1.WIP_ReCheckDate)
                End If

                db.AddInParameter(dbComm, "@WIP_ReCheckRemark", DbType.String, objFile1.WIP_ReCheckRemark)


                db.ExecuteNonQuery(dbComm)
                WareInput_UpdateReCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                WareInput_UpdateReCheck = False
            End Try
        End Function

        ''' <summary>
        ''' 刪除
        ''' </summary>
        ''' <param name="WIP_NUM"></param>
        ''' <param name="WIP_ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareInput_Delete(ByVal WIP_NUM As String, ByVal WIP_ID As String) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInput_Delete")
                db.AddInParameter(dbComm, "@WIP_NUM", DbType.String, WIP_NUM)
                db.AddInParameter(dbComm, "@WIP_ID", DbType.String, WIP_ID)

                db.ExecuteNonQuery(dbComm)
                WareInput_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                WareInput_Delete = False

            End Try
        End Function

        Public Function WareInputExport_Getlist(ByVal WH_ID As String, ByVal DPT_ID As String, ByVal WIP_AddDate1 As String, ByVal WIP_AddDate2 As String) As List(Of WareInputInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInputExport_Getlist")
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@DPT_ID", DbType.String, DPT_ID)
            db.AddInParameter(dbComm, "@WIP_AddDate1", DbType.String, WIP_AddDate1)
            db.AddInParameter(dbComm, "@WIP_AddDate2", DbType.String, WIP_AddDate2)

            Dim FeatureList As New List(Of WareInputInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInput(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function WareInput_Getlist(ByVal WIP_ID As String, ByVal OS_BatchID As String, ByVal M_Code As String, ByVal M_Name As String, ByVal WH_ID As String, ByVal DPT_ID As String, ByVal WIP_Date1 As String, ByVal WIP_Date2 As String, ByVal WIP_Check As String, ByVal WIP_ReCheck As String) As List(Of WareInputInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInput_Getlist")

            db.AddInParameter(dbComm, "@WIP_ID", DbType.String, WIP_ID)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@DPT_ID", DbType.String, DPT_ID)
            db.AddInParameter(dbComm, "@WIP_Date1", DbType.String, WIP_Date1)
            db.AddInParameter(dbComm, "@WIP_Date2", DbType.String, WIP_Date2)

            db.AddInParameter(dbComm, "@WIP_Check", DbType.String, WIP_Check)
            db.AddInParameter(dbComm, "@WIP_ReCheck", DbType.String, WIP_ReCheck)

            Dim FeatureList As New List(Of WareInputInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInput(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function WareInput_Getlist1(ByVal WIP_ID As String, ByVal OS_BatchID As String, ByVal M_Code As String, ByVal M_Name As String, ByVal WH_ID As String, ByVal DPT_ID As String, ByVal WIP_AddDate As String, ByVal WIP_AddDateVal As String, ByVal WIP_Check As String) As List(Of WareInputInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInput_Getlist1")

            db.AddInParameter(dbComm, "@WIP_ID", DbType.String, WIP_ID)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@DPT_ID", DbType.String, DPT_ID)
            db.AddInParameter(dbComm, "@WIP_AddDate", DbType.String, WIP_AddDate)
            db.AddInParameter(dbComm, "@WIP_AddDateVal", DbType.String, WIP_AddDateVal)
            db.AddInParameter(dbComm, "@WIP_Check", DbType.String, WIP_Check)


            Dim FeatureList As New List(Of WareInputInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInput(reader))
                End While
                Return FeatureList
            End Using
        End Function


        Public Function WareInput_Get(ByVal WIP_ID As String) As WareInputInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInput_Get")
            db.AddInParameter(dbComm, "@WIP_ID", DbType.String, WIP_ID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillWareInput(reader)
                End While
                Return Nothing
            End Using
        End Function
        ''' <summary>
        ''' 匯總當前倉庫當前批次指定物料的入庫總數
        ''' </summary>
        ''' <param name="OS_BatchID"></param>
        ''' <param name="M_Code"></param>
        ''' <param name="WH_ID"></param>
        ''' <param name="WIP_Check"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareInput_GetQty(ByVal OS_BatchID As String, ByVal M_Code As String, ByVal WH_ID As String, ByVal WIP_Check As String) As List(Of WareInputInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInput_GetQty")

            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@WIP_Check", DbType.String, WIP_Check)

            Dim FeatureList As New List(Of WareInputInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInput(reader))
                End While
                Return FeatureList
            End Using

        End Function
        ''' <summary>
        ''' 匯總當前倉庫指定物料在所有批次中分別入庫總數量
        ''' </summary>
        ''' <param name="OS_BatchID"></param>
        ''' <param name="M_Code"></param>
        ''' <param name="WH_ID"></param>
        ''' <param name="WIP_Check"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareInput_GetQty1(ByVal OS_BatchID As String, ByVal M_Code As String, ByVal WH_ID As String, ByVal WIP_Check As String, ByVal WIP_Date1 As String, ByVal WIP_Date2 As String) As List(Of WareInputInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInput_GetQty1")

            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@WIP_Check", DbType.String, WIP_Check)
            db.AddInParameter(dbComm, "@WIP_Date1", DbType.String, WIP_Date1)
            db.AddInParameter(dbComm, "@WIP_Date2", DbType.String, WIP_Date2)

            Dim FeatureList As New List(Of WareInputInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInput(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function WareInput_GetQty2(ByVal M_Code As String, ByVal WH_ID As String, ByVal WIP_Check As String, ByVal WIP_Date1 As String, ByVal WIP_Date2 As String) As List(Of WareInputInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInput_GetQty2")

            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@WIP_Check", DbType.String, WIP_Check)
            db.AddInParameter(dbComm, "@WIP_Date1", DbType.String, WIP_Date1)
            db.AddInParameter(dbComm, "@WIP_Date2", DbType.String, WIP_Date2)

            Dim FeatureList As New List(Of WareInputInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInput(reader))
                End While
                Return FeatureList
            End Using

        End Function

        ''' <summary>
        ''' 取得一條最大WIP_NUM記錄
        ''' </summary>
        ''' <param name="WIP_NUM"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareInput_GetNUM(ByVal WIP_NUM As String) As WareInputInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInput_GetNUM")
            db.AddInParameter(dbComm, "@WIP_NUM", DbType.String, WIP_NUM)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillWareInput(reader)
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
        Public Function WareInput_GetID(ByVal NDate As String) As WareInputInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInput_GetID")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillWareInput(reader)
                End While
                Return Nothing
            End Using
        End Function
        ''' <summary>
        ''' 由入庫單備註取得入庫單號
        ''' </summary>
        ''' <param name="RemarkID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareInput_GetWareID(ByVal RemarkID As String) As List(Of WareInputInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInput_GetWareID")
            db.AddInParameter(dbComm, "@RemarkID", DbType.String, RemarkID)

            Dim FeatureList As New List(Of WareInputInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInput(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function WareInput_UpdateEndQty(ByVal objinfo As WareInputInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInput_UpdateEndQty")

                db.AddInParameter(dbComm, "@WIP_ID", DbType.String, objinfo.WIP_ID)
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, objinfo.WH_ID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@WIP_EndQty", DbType.Double, objinfo.WIP_EndQty)


                db.ExecuteNonQuery(dbComm)
                WareInput_UpdateEndQty = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareInput_UpdateEndQty = False
            End Try

        End Function

        ''呆滯物料，最近一條記錄
        Public Function WareInput_TopGetList(ByVal M_Code As String, ByVal WH_ID As String) As List(Of WareInputInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInput_Getlist")

            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
           
            Dim FeatureList As New List(Of WareInputInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInput(reader))
                End While
                Return FeatureList
            End Using
        End Function


        ''' <summary>
        ''' 只更新備注信息
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareInput_UpdateRemark(ByVal objFile1 As WareInputInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInput_UpdateRemark")

                db.AddInParameter(dbComm, "@WIP_ID", DbType.String, objFile1.WIP_ID)
                db.AddInParameter(dbComm, "@WIP_NUM", DbType.String, objFile1.WIP_NUM)

                db.AddInParameter(dbComm, "@WIP_Remark", DbType.String, objFile1.WIP_Remark)

                db.ExecuteNonQuery(dbComm)
                WareInput_UpdateRemark = True

            Catch ex As Exception
                MsgBox(ex.Message)
                WareInput_UpdateRemark = False
            End Try

        End Function

        ''' <summary>
        ''' 在庫存模塊加入顯示最近50條記錄
        ''' </summary>
        ''' <param name="WIP_ID"></param>
        ''' <param name="OS_BatchID"></param>
        ''' <param name="M_Code"></param>
        ''' <param name="M_Name"></param>
        ''' <param name="WH_ID"></param>
        ''' <param name="DPT_ID"></param>
        ''' <param name="WIP_AddDate"></param>
        ''' <param name="WIP_AddDateVal"></param>
        ''' <param name="WIP_Check"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareInput_GetListTop50(ByVal WIP_ID As String, ByVal OS_BatchID As String, ByVal M_Code As String, ByVal M_Name As String, ByVal WH_ID As String, ByVal DPT_ID As String, ByVal WIP_AddDate As String, ByVal WIP_AddDateVal As String, ByVal WIP_Check As String) As List(Of WareInputInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInput_GetListTop50")

            db.AddInParameter(dbComm, "@WIP_ID", DbType.String, WIP_ID)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@DPT_ID", DbType.String, DPT_ID)
            db.AddInParameter(dbComm, "@WIP_AddDate", DbType.String, WIP_AddDate)
            db.AddInParameter(dbComm, "@WIP_AddDateVal", DbType.String, WIP_AddDateVal)
            db.AddInParameter(dbComm, "@WIP_Check", DbType.String, WIP_Check)


            Dim FeatureList As New List(Of WareInputInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInput(reader))
                End While
                Return FeatureList
            End Using
        End Function



    End Class

End Namespace