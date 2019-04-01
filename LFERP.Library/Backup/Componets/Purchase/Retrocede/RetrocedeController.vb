Namespace LFERP.Library.Purchase.Retrocede
    Public Class RetrocedeController
        ''' <summary>
        ''' 退貨新增
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Retrocede_Add(ByVal objFile1 As RetrocedeInfo) As Boolean


            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Retrocede_Add")
                db.AddInParameter(dbComm, "@A_AcceptanceNO", DbType.String, objFile1.A_AcceptanceNO)
                db.AddInParameter(dbComm, "@DepotNO", DbType.String, objFile1.DepotNO)
                db.AddInParameter(dbComm, "@S_Supplier", DbType.String, objFile1.S_Supplier)

                If objFile1.S_SupplierNO = Nothing Then
                    db.AddInParameter(dbComm, "@S_SupplierNO", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@S_SupplierNO", DbType.String, objFile1.S_SupplierNO)
                End If

                If objFile1.A_SendNo = Nothing Then
                    db.AddInParameter(dbComm, "@A_SendNO", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@A_SendNO", DbType.String, objFile1.A_SendNo)
                End If

                db.AddInParameter(dbComm, "@R_ReturnDate", DbType.String, objFile1.R_ReturnDate)
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

                db.AddInParameter(dbComm, "@R_Qty", DbType.String, objFile1.R_Qty)
                db.AddInParameter(dbComm, "@R_RemarkS", DbType.String, objFile1.R_RemarkS)
                db.AddInParameter(dbComm, "@R_Reason", DbType.String, objFile1.R_Reason)
                db.AddInParameter(dbComm, "@R_RemarkT", DbType.String, objFile1.R_RemarkT)

                If objFile1.R_SendDate = Nothing Then
                    db.AddInParameter(dbComm, "@R_SendDate", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@R_SendDate", DbType.String, objFile1.R_SendDate)
                End If

                db.AddInParameter(dbComm, "@R_ReturnType", DbType.String, objFile1.R_ReturnType)
                db.AddInParameter(dbComm, "@PM_NO", DbType.String, objFile1.PM_NO)
                db.AddInParameter(dbComm, "@R_RetrocedeNO", DbType.String, objFile1.R_RetrocedeNO)

                If objFile1.PM_M_Code = Nothing Then
                    db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objFile1.PM_M_Code)
                End If

                If objFile1.R_Detail = Nothing Then
                    db.AddInParameter(dbComm, "@R_Detail", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@R_Detail", DbType.String, objFile1.R_Detail)
                End If


                db.AddInParameter(dbComm, "@R_Action", DbType.String, objFile1.R_Action)
                db.AddInParameter(dbComm, "@R_Ver", DbType.String, objFile1.R_Ver)
                db.AddInParameter(dbComm, "@R_UpdateDate", DbType.String, objFile1.R_UpdateDate)

                db.ExecuteNonQuery(dbComm)
                Retrocede_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Retrocede_Add = False
            End Try
        End Function


        ''' <summary>
        ''' 退貨修改
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Retrocede_Update(ByVal objFile1 As RetrocedeInfo) As Boolean


            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Retrocede_Update")
                db.AddInParameter(dbComm, "@R_NO", DbType.String, objFile1.R_NO)
                db.AddInParameter(dbComm, "@A_AcceptanceNO", DbType.String, objFile1.A_AcceptanceNO)
                db.AddInParameter(dbComm, "@DepotNO", DbType.String, objFile1.DepotNO)
                db.AddInParameter(dbComm, "@S_Supplier", DbType.String, objFile1.S_Supplier)

                If objFile1.S_SupplierNO = Nothing Then
                    db.AddInParameter(dbComm, "@S_SupplierNO", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@S_SupplierNO", DbType.String, objFile1.S_SupplierNO)
                End If

                If objFile1.A_SendNo = Nothing Then
                    db.AddInParameter(dbComm, "@A_SendNO", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@A_SendNO", DbType.String, objFile1.A_SendNo)
                End If

                db.AddInParameter(dbComm, "@R_ReturnDate", DbType.String, objFile1.R_ReturnDate)
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

                db.AddInParameter(dbComm, "@R_Qty", DbType.String, objFile1.R_Qty)
                db.AddInParameter(dbComm, "@R_RemarkS", DbType.String, objFile1.R_RemarkS)
                db.AddInParameter(dbComm, "@R_Reason", DbType.String, objFile1.R_Reason)
                db.AddInParameter(dbComm, "@R_RemarkT", DbType.String, objFile1.R_RemarkT)

                If objFile1.R_SendDate = Nothing Then
                    db.AddInParameter(dbComm, "@R_SendDate", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@R_SendDate", DbType.String, objFile1.R_SendDate)
                End If

                db.AddInParameter(dbComm, "@R_ReturnType", DbType.String, objFile1.R_ReturnType)
                db.AddInParameter(dbComm, "@PM_NO", DbType.String, objFile1.PM_NO)
                db.AddInParameter(dbComm, "@R_RetrocedeNO", DbType.String, objFile1.R_RetrocedeNO)

                If objFile1.PM_M_Code = Nothing Then
                    db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objFile1.PM_M_Code)
                End If

                If objFile1.R_Detail = Nothing Then
                    db.AddInParameter(dbComm, "@R_Detail", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@R_Detail", DbType.String, objFile1.R_Detail)
                End If


                db.AddInParameter(dbComm, "@R_Action", DbType.String, objFile1.R_Action)
                db.AddInParameter(dbComm, "@R_Ver", DbType.String, objFile1.R_Ver)
                db.AddInParameter(dbComm, "@R_UpdateDate", DbType.String, objFile1.R_UpdateDate)

                db.ExecuteNonQuery(dbComm)
                Retrocede_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Retrocede_Update = False
            End Try
        End Function
        ''' <summary>
        ''' 退貨單報表匯總查詢
        ''' </summary>
        ''' <param name="R_Date1"></param>
        ''' <param name="R_Date2"></param>
        ''' <param name="S_Supplier"></param>
        ''' <param name="M_Code"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>


        Public Function RetrocedeGroup_GetList(ByVal R_Date1 As String, ByVal R_Date2 As String, ByVal S_Supplier As String, ByVal M_Code As String) As List(Of RetrocedeInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("RetrocedeGroup_GetList")

            db.AddInParameter(dbComm, "@R_Date1", DbType.String, R_Date1)
            db.AddInParameter(dbComm, "@R_Date2", DbType.String, R_Date2)
            db.AddInParameter(dbComm, "@S_Supplier", DbType.String, S_Supplier)

            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)

            Dim FeatureList As New List(Of RetrocedeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillRetrocede(reader))
                End While
                Return FeatureList
            End Using
        End Function

        ''' <summary>
        ''' 退貨刪除--退貨單號
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Retrocede_Delete(ByVal objFile1 As RetrocedeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Retrocede_Delete")
                db.AddInParameter(dbComm, "@R_RetrocedeNO", DbType.String, objFile1.R_RetrocedeNO)
                db.ExecuteNonQuery(dbComm)
                Retrocede_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Retrocede_Delete = False
            End Try
        End Function


        ''' <summary>
        ''' 退貨刪除--退貨流水號
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Retrocede_Delete_RNO(ByVal objFile1 As RetrocedeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Retrocede_Delete_RNO")
                db.AddInParameter(dbComm, "@R_NO", DbType.String, objFile1.R_NO)
                db.ExecuteNonQuery(dbComm)
                Retrocede_Delete_RNO = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Retrocede_Delete_RNO = False
            End Try
        End Function

        ''' <summary>
        ''' 退貨查詢---單條
        ''' </summary>
        ''' <param name="R_RetrocedeNO"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Retrocede_Get(ByVal R_RetrocedeNO As String) As RetrocedeInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Retrocede_Get")
            db.AddInParameter(dbComm, "@R_RetrocedeNO", DbType.String, R_RetrocedeNO)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillRetrocede(reader)
                End While
                Return Nothing
            End Using
        End Function


        ''' <summary>
        ''' 退貨查詢--多條
        ''' </summary>
        ''' <param name="PM_NO"></param>
        ''' <param name="A_AcceptanceNO"></param>
        ''' <param name="M_Name"></param>
        ''' <param name="OS_BatchID"></param>
        ''' <param name="R_Check"></param>
        ''' <param name="R_AccountCheck"></param>
        ''' <param name="M_Code"></param>
        ''' <param name="A_SendNO"></param>
        ''' <param name="S_Supplier"></param>
        ''' <param name="R_RetrocedeNO"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Retrocede_GetList(ByVal PM_NO As String, ByVal A_AcceptanceNO As String, ByVal M_Name As String, ByVal OS_BatchID As String, ByVal R_Date1 As String, ByVal R_Date2 As String, ByVal R_Check As String, ByVal R_AccountCheck As String, ByVal M_Code As String, ByVal A_SendNO As String, ByVal S_Supplier As String, ByVal R_RetrocedeNO As String) As List(Of RetrocedeInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Retrocede_GetList")
            db.AddInParameter(dbComm, "@PM_NO", DbType.String, PM_NO)
            db.AddInParameter(dbComm, "@A_AcceptanceNO", DbType.String, A_AcceptanceNO)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@R_Date1", DbType.String, R_Date1)
            db.AddInParameter(dbComm, "@R_Date2", DbType.String, R_Date2)

            If R_Check = Nothing Then
                db.AddInParameter(dbComm, "@R_Check", DbType.Boolean, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@R_Check", DbType.Boolean, R_Check)
            End If


            If R_AccountCheck = Nothing Then
                db.AddInParameter(dbComm, "@R_AccountCheck", DbType.Boolean, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@R_AccountCheck", DbType.Boolean, R_AccountCheck)
            End If

            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@A_SendNO", DbType.String, A_SendNO)
            db.AddInParameter(dbComm, "@S_Supplier", DbType.String, S_Supplier)
            db.AddInParameter(dbComm, "@R_RetrocedeNO", DbType.String, R_RetrocedeNO)

            Dim FeatureList As New List(Of RetrocedeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillRetrocede(reader))
                End While
                Return FeatureList
            End Using

        End Function


        Friend Function FillRetrocede(ByVal reader As IDataReader) As RetrocedeInfo
            '對應取得的數據
            On Error Resume Next
            Dim objInfo As New RetrocedeInfo
            objInfo.R_NO = reader("R_NO").ToString
            objInfo.R_RetrocedeNO = reader("R_RetrocedeNO").ToString
            objInfo.A_AcceptanceNO = reader("A_AcceptanceNO").ToString
            objInfo.PM_NO = reader("PM_NO").ToString
            objInfo.DepotNO = reader("DepotNO").ToString
            objInfo.S_Supplier = reader("S_Supplier").ToString
            objInfo.S_SupplierNO = reader("S_SupplierNO").ToString
            objInfo.A_SendNo = reader("A_SendNo").ToString
            objInfo.R_ReturnDate = reader("R_ReturnDate").ToString
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.OS_BatchID = reader("OS_BatchID").ToString
            objInfo.R_Qty = reader("R_Qty").ToString
            objInfo.R_RemarkS = reader("R_RemarkS").ToString
            objInfo.R_Reason = reader("R_Reason").ToString
            objInfo.R_RemarkT = reader("R_RemarkT").ToString
            objInfo.R_SendDate = reader("R_SendDate").ToString

            objInfo.R_ReturnType = reader("R_ReturnType").ToString
            objInfo.R_Check = reader("R_Check").ToString
            objInfo.R_CheckAction = reader("R_CheckAction").ToString
            objInfo.R_CheckDate = reader("R_CheckDate").ToString
            objInfo.R_CheckType = reader("R_CheckType").ToString
            objInfo.R_CheckRemark = reader("R_CheckRemark").ToString
            objInfo.R_AccountCheck = reader("R_AccountCheck").ToString
            objInfo.R_AccountAction = reader("R_AccountAction").ToString
            objInfo.R_AccountCheckDate = reader("R_AccountCheckDate").ToString
            objInfo.R_AccountCheckType = reader("R_AccountCheckType").ToString
            objInfo.R_AccountCheckRemark = reader("R_AccountCheckRemark").ToString
            objInfo.R_Detail = reader("R_Detail").ToString
            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            objInfo.R_Ver = reader("R_Ver").ToString
            objInfo.R_Action = reader("R_Action").ToString
            objInfo.R_UpdateDate = reader("R_UpdateDate").ToString
            objInfo.CO_ID = reader("CO_ID").ToString
            objInfo.S_SupplierName = reader("S_SupplierName").ToString
            Return objInfo
        End Function



        ''' <summary>
        ''' 退貨單審核
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Retrocede_UpdateCheck(ByVal objFile1 As RetrocedeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Retrocede_UpdateCheck")
                db.AddInParameter(dbComm, "@R_NO", DbType.String, objFile1.R_NO)
                db.AddInParameter(dbComm, "@R_Check", DbType.String, objFile1.R_Check)
                db.AddInParameter(dbComm, "@R_CheckType", DbType.String, objFile1.R_CheckType)
                db.AddInParameter(dbComm, "@R_CheckAction", DbType.String, objFile1.R_CheckAction)
                db.AddInParameter(dbComm, "@R_CheckRemark", DbType.String, objFile1.R_CheckRemark)
                db.AddInParameter(dbComm, "@R_CheckDate", DbType.String, objFile1.R_CheckDate)


                db.ExecuteNonQuery(dbComm)
                Retrocede_UpdateCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Retrocede_UpdateCheck = False
            End Try
        End Function

        ''' <summary>
        ''' 退貨單會計部審核
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Retrocede_UpdateAccCheck(ByVal objFile1 As RetrocedeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Retrocede_UpdateAccCheck")
                db.AddInParameter(dbComm, "@R_NO", DbType.String, objFile1.R_NO)
                db.AddInParameter(dbComm, "@R_AccountCheck", DbType.String, objFile1.R_AccountCheck)
                db.AddInParameter(dbComm, "@R_AccountCheckType", DbType.String, objFile1.R_AccountCheckType)
                db.AddInParameter(dbComm, "@R_AccountAction", DbType.String, objFile1.R_AccountAction)
                db.AddInParameter(dbComm, "@R_AccountCheckRemark", DbType.String, objFile1.R_AccountCheckRemark)
                db.AddInParameter(dbComm, "@R_AccountCheckDate", DbType.String, objFile1.R_AccountCheckDate)


                db.ExecuteNonQuery(dbComm)
                Retrocede_UpdateAccCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Retrocede_UpdateAccCheck = False
            End Try
        End Function
    End Class
End Namespace
