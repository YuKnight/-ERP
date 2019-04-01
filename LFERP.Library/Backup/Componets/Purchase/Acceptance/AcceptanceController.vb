Namespace LFERP.Library.Purchase.Acceptance
    Public Class AcceptanceController
        ''' <summary>
        ''' 驗收新增
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Acceptance_Add(ByVal objFile1 As AcceptanceInfo) As Boolean


            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Acceptance_Add")
                db.AddInParameter(dbComm, "@DepotNO", DbType.String, objFile1.DepotNO)
                db.AddInParameter(dbComm, "@PM_NO", DbType.String, objFile1.PM_NO)
                db.AddInParameter(dbComm, "@A_AcceptanceNO", DbType.String, objFile1.A_AcceptanceNO)


                If objFile1.A_SendNO = Nothing Then
                    db.AddInParameter(dbComm, "@A_SendNO", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@A_SendNO", DbType.String, objFile1.A_SendNO)
                End If

                db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)


                If objFile1.M_Unit = Nothing Then
                    db.AddInParameter(dbComm, "@M_Unit", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@M_Unit", DbType.String, objFile1.M_Unit)
                End If

                db.AddInParameter(dbComm, "@M_Name", DbType.String, objFile1.M_Name)
                db.AddInParameter(dbComm, "@M_Gauge", DbType.String, objFile1.M_Gauge)


                If objFile1.OS_BatchID = Nothing Then
                    db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)
                End If


                If objFile1.PM_M_Code = Nothing Then
                    db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objFile1.PM_M_Code)
                End If

                If objFile1.DPT_ID = Nothing Then
                    db.AddInParameter(dbComm, "@DPT_ID", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@DPT_ID", DbType.String, objFile1.DPT_ID)
                End If

                If objFile1.U_ID = Nothing Then
                    db.AddInParameter(dbComm, "@U_ID", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@U_ID", DbType.String, objFile1.U_ID)
                End If
                db.AddInParameter(dbComm, "@A_Ver", DbType.String, objFile1.A_Ver)
                db.AddInParameter(dbComm, "@A_Qty", DbType.String, objFile1.A_Qty)
                db.AddInParameter(dbComm, "@A_SendDate", DbType.String, objFile1.A_SendDate)
                db.AddInParameter(dbComm, "@A_SendType", DbType.String, objFile1.A_SendType)
                db.AddInParameter(dbComm, "@S_Supplier", DbType.String, objFile1.S_Supplier)
                db.AddInParameter(dbComm, "@A_Action", DbType.String, objFile1.A_Action)
                db.AddInParameter(dbComm, "@A_Remark", DbType.String, objFile1.A_Remark)
                db.AddInParameter(dbComm, "@A_UpdateDate", DbType.String, objFile1.A_UpdateDate)


                If objFile1.S_SupplierNO = Nothing Then
                    db.AddInParameter(dbComm, "@S_SupplierNO", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@S_SupplierNO", DbType.String, objFile1.S_SupplierNO)
                End If


                If objFile1.PN_NO = Nothing Then
                    db.AddInParameter(dbComm, "@PN_NO", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@PN_NO", DbType.String, objFile1.PN_NO)
                End If

                If objFile1.A_ToFrom = Nothing Then
                    db.AddInParameter(dbComm, "@A_ToFrom", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@A_ToFrom", DbType.String, objFile1.A_ToFrom)
                End If

                db.AddInParameter(dbComm, "@WQC_Status", DbType.String, objFile1.WQC_Status)
                db.AddInParameter(dbComm, "@WQC_Action", DbType.String, objFile1.WQC_Action)


                db.ExecuteNonQuery(dbComm)
                Acceptance_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Acceptance_Add = False

            End Try
        End Function

        ''' <summary>
        ''' 驗收修改
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Acceptance_Update(ByVal objFile1 As AcceptanceInfo) As Boolean


            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Acceptance_Update")

                db.AddInParameter(dbComm, "@DepotNO", DbType.String, objFile1.DepotNO)
                db.AddInParameter(dbComm, "@PM_NO", DbType.String, objFile1.PM_NO)

                db.AddInParameter(dbComm, "@A_NO", DbType.String, objFile1.A_NO)

                If objFile1.A_SendNO = Nothing Then
                    db.AddInParameter(dbComm, "@A_SendNO", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@A_SendNO", DbType.String, objFile1.A_SendNO)
                End If

                db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)


                If objFile1.M_Unit = Nothing Then
                    db.AddInParameter(dbComm, "@M_Unit", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@M_Unit", DbType.String, objFile1.M_Unit)
                End If

                db.AddInParameter(dbComm, "@M_Name", DbType.String, objFile1.M_Name)
                db.AddInParameter(dbComm, "@M_Gauge", DbType.String, objFile1.M_Gauge)


                If objFile1.OS_BatchID = Nothing Then
                    db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)
                End If


                If objFile1.PM_M_Code = Nothing Then
                    db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objFile1.PM_M_Code)
                End If

                If objFile1.DPT_ID = Nothing Then
                    db.AddInParameter(dbComm, "@DPT_ID", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@DPT_ID", DbType.String, objFile1.DPT_ID)
                End If

                If objFile1.U_ID = Nothing Then
                    db.AddInParameter(dbComm, "@U_ID", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@U_ID", DbType.String, objFile1.U_ID)
                End If
                db.AddInParameter(dbComm, "@A_Ver", DbType.String, objFile1.A_Ver)
                db.AddInParameter(dbComm, "@A_Qty", DbType.String, objFile1.A_Qty)
                db.AddInParameter(dbComm, "@A_SendDate", DbType.String, objFile1.A_SendDate)
                db.AddInParameter(dbComm, "@A_SendType", DbType.String, objFile1.A_SendType)
                db.AddInParameter(dbComm, "@S_Supplier", DbType.String, objFile1.S_Supplier)
                db.AddInParameter(dbComm, "@A_Action", DbType.String, objFile1.A_Action)
                db.AddInParameter(dbComm, "@A_Remark", DbType.String, objFile1.A_Remark)
                db.AddInParameter(dbComm, "@A_UpdateDate", DbType.String, objFile1.A_UpdateDate)

                If objFile1.S_SupplierNO = Nothing Then
                    db.AddInParameter(dbComm, "@S_SupplierNO", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@S_SupplierNO", DbType.String, objFile1.S_SupplierNO)
                End If


                If objFile1.PN_NO = Nothing Then
                    db.AddInParameter(dbComm, "@PN_NO", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@PN_NO", DbType.String, objFile1.PN_NO)
                End If



                db.ExecuteNonQuery(dbComm)
                Acceptance_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                Acceptance_Update = False

            End Try
        End Function

        ''' <summary>
        ''' 刪除--驗收單號
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Acceptance_NO_Delete(ByVal objFile1 As AcceptanceInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Acceptance_NO_Delete")
                db.AddInParameter(dbComm, "@A_AcceptanceNO", DbType.String, objFile1.A_AcceptanceNO)
                db.ExecuteNonQuery(dbComm)
                Acceptance_NO_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Acceptance_NO_Delete = False
            End Try
        End Function
        ''' <summary>
        ''' 驗收單報表匯總查詢
        ''' </summary>
        ''' <param name="A_Date1"></param>
        ''' <param name="A_Date2"></param>
        ''' <param name="S_Supplier"></param>
        ''' <param name="M_Code"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>


        Public Function AcceptanceGroup_GetList(ByVal A_Date1 As String, ByVal A_Date2 As String, ByVal S_Supplier As String, ByVal M_Code As String) As List(Of AcceptanceInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("AcceptanceGroup_GetList")

            db.AddInParameter(dbComm, "@A_Date1", DbType.String, A_Date1)
            db.AddInParameter(dbComm, "@A_Date2", DbType.String, A_Date2)
            db.AddInParameter(dbComm, "@S_Supplier", DbType.String, S_Supplier)

            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)

            Dim FeatureList As New List(Of AcceptanceInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillAcceptance(reader))
                End While
                Return FeatureList
            End Using
        End Function
  

        ''' <summary>
        ''' 刪除--驗收流水號
        ''' </summary>
        ''' <param name="A_NO"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Acceptance_ANO_Delete(ByVal A_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Acceptance_ANO_Delete")
                db.AddInParameter(dbComm, "@A_NO", DbType.String, A_NO)
                db.ExecuteNonQuery(dbComm)
                Acceptance_ANO_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Acceptance_ANO_Delete = False
            End Try
        End Function


        ''' <summary>
        ''' 審核修改
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Acceptance_UpdateCheck(ByVal objFile1 As AcceptanceInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Acceptance_UpdateCheck")
                db.AddInParameter(dbComm, "@A_NO", DbType.String, objFile1.A_NO)
                db.AddInParameter(dbComm, "@A_Check", DbType.String, objFile1.A_Check)
                db.AddInParameter(dbComm, "@A_CheckType", DbType.String, objFile1.A_CheckType)
                db.AddInParameter(dbComm, "@A_CheckAction", DbType.String, objFile1.A_CheckAction)
                db.AddInParameter(dbComm, "@A_CheckRemark", DbType.String, objFile1.A_CheckRemark)
                db.AddInParameter(dbComm, "@A_CheckDate", DbType.String, objFile1.A_CheckDate)
                db.AddInParameter(dbComm, "@A_Detail", DbType.String, objFile1.A_Detail)

                db.ExecuteNonQuery(dbComm)
                Acceptance_UpdateCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Acceptance_UpdateCheck = False
            End Try
        End Function

        ''' <summary>
        ''' 付款審核修改
        ''' </summary>
        ''' <param name="objfile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Acceptance_UpdatePay(ByVal objfile1 As AcceptanceInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Acceptance_UpdatePay")
                db.AddInParameter(dbComm, "@A_NO", DbType.String, objfile1.A_NO)
                db.AddInParameter(dbComm, "@A_PayCheck", DbType.String, objfile1.A_PayCheck)
                db.AddInParameter(dbComm, "@A_PayCheckDate", DbType.String, objfile1.A_PayCheckDate)
                db.AddInParameter(dbComm, "@A_PayCheckAction", DbType.String, objfile1.A_PayCheckAction)
                db.AddInParameter(dbComm, "@A_PayCheckRemark", DbType.String, objfile1.A_PayCheckRemark)
                db.AddInParameter(dbComm, "@A_Detail", DbType.String, objfile1.A_Detail)

                db.ExecuteNonQuery(dbComm)
                Acceptance_UpdatePay = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Acceptance_UpdatePay = False
            End Try
        End Function

        ''' <summary>
        ''' 會計部審核修改
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Acceptance_UpdateAccountCheck(ByVal objFile1 As AcceptanceInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Acceptance_UpdateAccountCheck")
                db.AddInParameter(dbComm, "@A_NO", DbType.String, objFile1.A_NO)
                db.AddInParameter(dbComm, "@A_AccountCheck", DbType.String, objFile1.A_AccountCheck)
                db.AddInParameter(dbComm, "@A_AccountCheckType", DbType.String, objFile1.A_AccountCheckType)
                db.AddInParameter(dbComm, "@A_AccountCheckAction", DbType.String, objFile1.A_AccountCheckAction)
                db.AddInParameter(dbComm, "@A_AccountCheckRemark", DbType.String, objFile1.A_AccountCheckRemark)
                db.AddInParameter(dbComm, "@A_AccountCheckDate", DbType.String, objFile1.A_AccountCheckDate)


                db.ExecuteNonQuery(dbComm)
                Acceptance_UpdateAccountCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Acceptance_UpdateAccountCheck = False
            End Try
        End Function

        Public Function Acceptance_UpdateQCCheck(ByVal objFile1 As AcceptanceInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Acceptance_UpdateQCCheck")

                db.AddInParameter(dbComm, "@A_NO", DbType.String, objFile1.A_NO)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)
                db.AddInParameter(dbComm, "@WQC_Status", DbType.String, objFile1.WQC_Status)
                db.AddInParameter(dbComm, "@WQC_Action", DbType.String, objFile1.WQC_Action)

                db.ExecuteNonQuery(dbComm)
                Acceptance_UpdateQCCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Acceptance_UpdateQCCheck = False
            End Try
        End Function


        ''' <summary>
        ''' 查詢多條記錄
        ''' </summary>
        ''' <param name="PM_NO"></param>
        ''' <param name="A_AcceptanceNO"></param>
        ''' <param name="M_Name"></param>
        ''' <param name="OS_BatchID"></param>
        ''' <param name="A_Detail"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Acceptance_GetList(ByVal PM_NO As String, ByVal A_AcceptanceNO As String, ByVal M_Name As String, ByVal OS_BatchID As String, ByVal A_Detail As String, ByVal A_Check As String, ByVal A_AccountCheck As String, ByVal M_Code As String, ByVal A_SendNO As String, ByVal S_Supplier As String, ByVal A_PayCheck As String, ByVal A_Date1 As String, ByVal A_Date2 As String) As List(Of AcceptanceInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Acceptance_GetList")
            db.AddInParameter(dbComm, "@PM_NO", DbType.String, PM_NO)
            db.AddInParameter(dbComm, "@A_AcceptanceNO", DbType.String, A_AcceptanceNO)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@A_Detail", DbType.String, A_Detail)
            If A_Check = Nothing Then
                db.AddInParameter(dbComm, "@A_Check", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@A_Check", DbType.String, A_Check)
            End If

            If A_PayCheck = Nothing Then
                db.AddInParameter(dbComm, "@A_PayCheck", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@A_PayCheck", DbType.String, A_PayCheck)
            End If



            If A_AccountCheck = Nothing Then
                db.AddInParameter(dbComm, "@A_AccountCheck", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@A_AccountCheck", DbType.String, A_AccountCheck)
            End If

            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@A_SendNO", DbType.String, A_SendNO)
            db.AddInParameter(dbComm, "@S_Supplier", DbType.String, S_Supplier)
            db.AddInParameter(dbComm, "@A_Date1", DbType.String, A_Date1)
            db.AddInParameter(dbComm, "@A_Date2", DbType.String, A_Date2)

            Dim FeatureList As New List(Of AcceptanceInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillAcceptance(reader))
                End While
                Return FeatureList
            End Using

        End Function

        ''' <summary>
        ''' 查詢--單條記錄--驗收單號
        ''' </summary>
        ''' <param name="A_AcceptanceNO"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Function Acceptance_Get(ByVal A_AcceptanceNO As String) As AcceptanceInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Acceptance_Get")
            db.AddInParameter(dbComm, "@A_AcceptanceNO", DbType.String, A_AcceptanceNO)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillAcceptance(reader)
                End While
                Return Nothing
            End Using
        End Function


        ''' <summary>
        ''' 查詢--單條記錄--驗收流水號
        ''' </summary>
        ''' <param name="A_NO"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Acceptance_GetSub(ByVal A_NO As String) As AcceptanceInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Acceptance_GetSub")
            db.AddInParameter(dbComm, "@A_NO", DbType.String, A_NO)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillAcceptance(reader)
                End While
                Return Nothing
            End Using
        End Function




        ''' <summary>
        ''' 取得對應數據
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Function FillAcceptance(ByVal reader As IDataReader) As AcceptanceInfo
            '對應取得的數據
            On Error Resume Next
            Dim objInfo As New AcceptanceInfo
            objInfo.DepotNO = reader("DepotNO").ToString
            objInfo.PM_NO = reader("PM_NO").ToString
            objInfo.A_AcceptanceNO = reader("A_AcceptanceNO").ToString
            objInfo.A_NO = reader("A_NO").ToString
            objInfo.A_SendNO = reader("A_SendNO").ToString
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.OS_BatchID = reader("OS_BatchID").ToString
            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            objInfo.DPT_ID = reader("DPT_ID").ToString
            objInfo.U_ID = reader("U_ID").ToString
            objInfo.A_Ver = reader("A_Ver").ToString
            objInfo.A_Qty = reader("A_Qty").ToString
            objInfo.A_SendType = reader("A_SendType").ToString
            If IsDBNull(reader("A_SendDate")) Then
                objInfo.A_SendDate = Nothing
            Else
                objInfo.A_SendDate = Format(CDate(reader("A_SendDate")), "yyyy/MM/dd").ToString
            End If

            objInfo.S_Supplier = reader("S_Supplier").ToString
            objInfo.A_Action = reader("A_Action").ToString

            objInfo.A_Remark = reader("A_Remark").ToString
            objInfo.A_Detail = reader("A_Detail").ToString
            objInfo.A_UpdateDate = reader("A_UpdateDate").ToString
            objInfo.A_Check = reader("A_Check")
            objInfo.A_CheckAction = reader("A_CheckAction").ToString
            objInfo.A_CheckDate = reader("A_CheckDate").ToString
            objInfo.A_CheckType = reader("A_CheckType").ToString
            objInfo.A_CheckRemark = reader("A_CheckRemark").ToString
            objInfo.A_AccountCheck = reader("A_AccountCheck")
            objInfo.A_AccountCheckAction = reader("A_AccountCheckAction").ToString
            objInfo.A_AccountCheckDate = reader("A_AccountCheckDate").ToString
            objInfo.A_AccountCheckType = reader("A_AccountCheckType").ToString
            objInfo.A_AccountCheckRemark = reader("A_AccountCheckRemark").ToString
            objInfo.S_SupplierNO = reader("S_SupplierNO").ToString

            objInfo.A_PayCheck = reader("A_PayCheck")
            objInfo.A_PayCheckDate = reader("A_PayCheckDate").ToString
            objInfo.A_PayCheckAction = reader("A_PayCheckAction").ToString
            objInfo.A_PayCheckRemark = reader("A_PayCheckRemark").ToString

            objInfo.PN_NO = reader("PN_NO").ToString
            objInfo.A_ToFrom = reader("A_ToFrom").ToString
            objInfo.S_SupplierName = reader("S_SupplierName").ToString

            objInfo.WQC_Action = reader("WQC_Action").ToString
            objInfo.WQC_Status = reader("WQC_Status").ToString
            objInfo.M_Price = reader("M_Price").ToString
            objInfo.M_Currency = reader("M_Currency").ToString

            Return objInfo
        End Function

        ''' <summary>
        ''' 更該驗收單狀態
        ''' </summary>
        ''' <param name="objfile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Acceptance_UpdateDetail(ByVal objfile1 As AcceptanceInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Acceptance_UpdateDetail")
                db.AddInParameter(dbComm, "@A_AcceptanceNO", DbType.String, objfile1.A_AcceptanceNO)
                db.AddInParameter(dbComm, "@A_Detail", DbType.String, objfile1.A_Detail)

                db.ExecuteNonQuery(dbComm)
                Acceptance_UpdateDetail = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Acceptance_UpdateDetail = False
            End Try
        End Function

    End Class
End Namespace