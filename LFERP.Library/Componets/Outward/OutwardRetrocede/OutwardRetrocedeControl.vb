
Namespace LFERP.Library.Outward

    Public Class OutwardRetrocedeControl

        ''' <summary>
        ''' 獲得當前退貨單號的最大值
        ''' </summary>
        ''' <param name="Ndate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OutwardRetrocede_GetNO(ByVal Ndate As String) As OutwardRetrocedeInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardRetrocede_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillOutwardRetrocede(reader)
                End While
                Return Nothing
            End Using
        End Function
        ''' <summary>
        ''' 取得退貨單流水號當前最大值
        ''' </summary>
        ''' <param name="R_NO"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OutwardRetrocede_RNO(ByVal R_NO As String) As OutwardRetrocedeInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardRetrocede_RNO")
            db.AddInParameter(dbComm, "@R_NO", DbType.String, R_NO)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillOutwardRetrocede(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function OutwardRetrocede_Add(ByVal objinfo As OutwardRetrocedeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardRetrocede_Add")

                db.AddInParameter(dbComm, "@R_NO", DbType.String, objinfo.R_NO)
                db.AddInParameter(dbComm, "@R_RetrocedeNO", DbType.String, objinfo.R_RetrocedeNO)
                db.AddInParameter(dbComm, "@A_AcceptanceNO", DbType.String, objinfo.A_AcceptanceNO)
                db.AddInParameter(dbComm, "@O_NO", DbType.String, objinfo.O_NO)
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, objinfo.WH_ID)
                db.AddInParameter(dbComm, "@S_Supplier", DbType.String, objinfo.S_Supplier)
                db.AddInParameter(dbComm, "@A_SendNO", DbType.String, objinfo.A_SendNO)
                db.AddInParameter(dbComm, "@R_ReturnDate", DbType.Date, objinfo.R_ReturnDate)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objinfo.OS_BatchID)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@R_Qty", DbType.Double, objinfo.R_Qty)
                db.AddInParameter(dbComm, "@R_RemarkS", DbType.String, objinfo.R_RemarkS)
                db.AddInParameter(dbComm, "@R_Reason", DbType.String, objinfo.R_Reason)
                db.AddInParameter(dbComm, "@R_RemarkT", DbType.String, objinfo.R_RemarkT)
                db.AddInParameter(dbComm, "@R_SendDate", DbType.Date, objinfo.R_SendDate)
                db.AddInParameter(dbComm, "@R_ReturnType", DbType.String, objinfo.R_ReturnType)
                db.AddInParameter(dbComm, "@R_Detail", DbType.String, objinfo.R_Detail)
                db.AddInParameter(dbComm, "@R_Action", DbType.String, objinfo.R_Action)
                db.AddInParameter(dbComm, "@R_Ver", DbType.Double, objinfo.R_Ver)
                db.AddInParameter(dbComm, "@R_UpdateDate", DbType.Date, objinfo.R_UpdateDate)

                db.ExecuteNonQuery(dbComm)
                OutwardRetrocede_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                OutwardRetrocede_Add = False

            End Try
        End Function
        Public Function OutwardRetrocede_Update(ByVal objinfo As OutwardRetrocedeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardRetrocede_Update")

                db.AddInParameter(dbComm, "@R_NO", DbType.String, objinfo.R_NO)
                db.AddInParameter(dbComm, "@R_RetrocedeNO", DbType.String, objinfo.R_RetrocedeNO)
                db.AddInParameter(dbComm, "@A_AcceptanceNO", DbType.String, objinfo.A_AcceptanceNO)
                db.AddInParameter(dbComm, "@O_NO", DbType.String, objinfo.O_NO)
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, objinfo.WH_ID)
                db.AddInParameter(dbComm, "@S_Supplier", DbType.String, objinfo.S_Supplier)
                db.AddInParameter(dbComm, "@A_SendNO", DbType.String, objinfo.A_SendNO)
                db.AddInParameter(dbComm, "@R_ReturnDate", DbType.Date, objinfo.R_ReturnDate)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objinfo.OS_BatchID)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@R_Qty", DbType.Double, objinfo.R_Qty)
                db.AddInParameter(dbComm, "@R_RemarkS", DbType.String, objinfo.R_RemarkS)
                db.AddInParameter(dbComm, "@R_Reason", DbType.String, objinfo.R_Reason)
                db.AddInParameter(dbComm, "@R_RemarkT", DbType.String, objinfo.R_RemarkT)
                db.AddInParameter(dbComm, "@R_SendDate", DbType.Date, objinfo.R_SendDate)
                db.AddInParameter(dbComm, "@R_ReturnType", DbType.String, objinfo.R_ReturnType)
                db.AddInParameter(dbComm, "@R_Detail", DbType.String, objinfo.R_Detail)
                db.AddInParameter(dbComm, "@R_Action", DbType.String, objinfo.R_Action)
                db.AddInParameter(dbComm, "@R_Ver", DbType.Double, objinfo.R_Ver)
                db.AddInParameter(dbComm, "@R_UpdateDate", DbType.Date, objinfo.R_UpdateDate)

                db.ExecuteNonQuery(dbComm)
                OutwardRetrocede_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                OutwardRetrocede_Update = False

            End Try
        End Function
        Public Function OutwardRetrocede_Delete(ByVal R_RetrocedeNO As String, ByVal R_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardRetrocede_Delete")

                db.AddInParameter(dbComm, "@R_NO", DbType.String, R_NO)
                db.AddInParameter(dbComm, "@R_RetrocedeNO", DbType.String, R_RetrocedeNO)
                db.ExecuteNonQuery(dbComm)
                OutwardRetrocede_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                OutwardRetrocede_Delete = False
            End Try
        End Function
        Public Function OutwardRetrocede_GetList(ByVal R_RetrocedeNO As String, ByVal A_AcceptanceNO As String, ByVal O_NO As String, ByVal A_SendNO As String, ByVal M_Code As String, ByVal OS_BatchID As String) As List(Of OutwardRetrocedeInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardRetrocede_GetList")

            db.AddInParameter(dbComm, "@R_RetrocedeNO", DbType.String, R_RetrocedeNO)
            db.AddInParameter(dbComm, "@A_AcceptanceNO", DbType.String, A_AcceptanceNO)
            db.AddInParameter(dbComm, "@O_NO", DbType.String, O_NO)
            db.AddInParameter(dbComm, "@A_SendNO", DbType.String, A_SendNO)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)

            Dim FeatureList As New List(Of OutwardRetrocedeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOutwardRetrocede(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function OutwardRetrocede_UpdateCheck(ByVal objinfo As OutwardRetrocedeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardRetrocede_UpdateCheck")

                db.AddInParameter(dbComm, "@R_RetrocedeNO", DbType.String, objinfo.R_RetrocedeNO)
                db.AddInParameter(dbComm, "@R_Check", DbType.Boolean, objinfo.R_Check)
                db.AddInParameter(dbComm, "@R_CheckAction", DbType.String, objinfo.R_CheckAction)
                db.AddInParameter(dbComm, "@R_CheckDate", DbType.Date, objinfo.R_CheckDate)
                db.AddInParameter(dbComm, "@R_CheckRemark", DbType.String, objinfo.R_CheckRemark)
                db.AddInParameter(dbComm, "@R_CheckType", DbType.String, objinfo.R_CheckType)

                db.ExecuteNonQuery(dbComm)
                OutwardRetrocede_UpdateCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OutwardRetrocede_UpdateCheck = False

            End Try
        End Function
        Public Function OutwardRetrocede_UpdateAccCheck(ByVal Objinfo As OutwardRetrocedeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardRetrocede_UpdateAccCheck")

                db.AddInParameter(dbComm, "@R_RetrocedeNO", DbType.String, Objinfo.R_RetrocedeNO)
                db.AddInParameter(dbComm, "@R_AccountCheck", DbType.Boolean, Objinfo.R_AccountCheck)
                db.AddInParameter(dbComm, "@R_AccountAction", DbType.String, Objinfo.R_AccountAction)
                db.AddInParameter(dbComm, "@R_AccountCheckDate", DbType.Date, Objinfo.R_AccountCheckDate)
                db.AddInParameter(dbComm, "@R_AccountCheckRemark", DbType.String, Objinfo.R_AccountCheckRemark)
                db.AddInParameter(dbComm, "@R_AccountCheckType", DbType.String, Objinfo.R_AccountCheckType)

                db.ExecuteNonQuery(dbComm)
                OutwardRetrocede_UpdateAccCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OutwardRetrocede_UpdateAccCheck = False

            End Try
        End Function

        Public Function FillOutwardRetrocede(ByVal reader As IDataReader) As OutwardRetrocedeInfo

            On Error Resume Next

            Dim objInfo As New OutwardRetrocedeInfo

            objInfo.R_NO = reader("R_NO").ToString
            objInfo.R_RetrocedeNO = reader("R_RetrocedeNO").ToString
            objInfo.A_AcceptanceNO = reader("A_AcceptanceNO").ToString
            objInfo.O_NO = reader("O_NO").ToString
            objInfo.S_Supplier = reader("S_Supplier").ToString
            objInfo.A_SendNO = reader("A_SendNO").ToString

            If reader("R_ReturnDate") Is DBNull.Value Then
                objInfo.R_ReturnDate = Nothing
            Else
                objInfo.R_ReturnDate = CStr(reader("R_ReturnDate"))
            End If

            objInfo.M_Code = reader("M_Code").ToString
            objInfo.OS_BatchID = reader("OS_BatchID").ToString
            If reader("R_Qty") Is DBNull.Value Then
                objInfo.R_Qty = 0
            Else
                objInfo.R_Qty = CDbl(reader("R_Qty"))
            End If
            objInfo.R_RemarkS = reader("R_RemarkS").ToString
            objInfo.R_Reason = reader("R_Reason").ToString
            objInfo.R_RemarkT = reader("R_RemarkT").ToString

            If reader("R_SendDate") Is DBNull.Value Then
                objInfo.R_SendDate = Nothing
            Else
                objInfo.R_SendDate = CStr(reader("R_SendDate"))
            End If

            objInfo.R_ReturnType = reader("R_ReturnType").ToString
            '------------------------------------------------------------------------------------
            If reader("R_Check") Is DBNull.Value Then
                objInfo.R_Check = Nothing
            Else
                objInfo.R_Check = reader("R_Check")
            End If

            objInfo.R_CheckAction = reader("R_CheckAction").ToString
            If reader("R_CheckDate") Is DBNull.Value Then
                objInfo.R_CheckDate = Nothing
            Else
                objInfo.R_CheckDate = CStr(reader("R_CheckDate"))
            End If
            objInfo.R_CheckType = reader("R_CheckType").ToString
            objInfo.R_CheckRemark = reader("R_CheckRemark").ToString
            '------------------------------------------------------------------------------------------
            If reader("R_AccountCheck") Is DBNull.Value Then
                objInfo.R_AccountCheck = Nothing
            Else
                objInfo.R_AccountCheck = reader("R_AccountCheck")
            End If
            objInfo.R_AccountAction = reader("R_AccountAction").ToString

            If reader("R_AccountCheckDate") Is DBNull.Value Then
                objInfo.R_AccountCheckDate = Nothing
            Else
                objInfo.R_AccountCheckDate = CStr(reader("R_AccountCheckDate"))
            End If
            objInfo.R_AccountCheckType = reader("R_AccountCheckType").ToString
            objInfo.R_AccountCheckRemark = reader("R_AccountCheckRemark").ToString


            objInfo.R_Detail = reader("R_Detail").ToString
            objInfo.PM_M_Code = reader("PM_M_Code").ToString

            If reader("R_Ver") Is DBNull.Value Then
                objInfo.R_Ver = 0
            Else
                objInfo.R_Ver = CDbl(reader("R_Ver"))
            End If
            objInfo.R_Action = reader("R_Action").ToString

            If reader("R_UpdateDate") Is DBNull.Value Then
                objInfo.R_UpdateDate = Nothing
            Else
                objInfo.R_UpdateDate = CStr(reader("R_UpdateDate"))
            End If

            '------------------------------------------------------------------------------------
            objInfo.M_Unit = reader("M_Unit").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.WH_Name = reader("WH_Name").ToString

            Return objInfo
        End Function

    End Class
  

End Namespace

