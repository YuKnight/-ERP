Namespace LFERP.Library.SampleManager.SampleSetting
    Public Class SampleSettingController
        Friend Function FillSampleSetting(ByVal reader As IDataReader) As SampleSettingInfo
            On Error Resume Next
            Dim objInfo As New SampleSettingInfo
            objInfo.U_ID = reader("U_ID").ToString
            '--------------------------------------------------
            If reader("SampleOrdersBeginDate") Is DBNull.Value Then
                objInfo.SampleOrdersBeginDate = Nothing
            Else
                objInfo.SampleOrdersBeginDate = Format(CDate(reader("SampleOrdersBeginDate")), "yyyy/MM/dd")
            End If
            objInfo.SampleOrdersCheck = reader("SampleOrdersCheck")
            objInfo.SampleOrdersCreateUserID = reader("SampleOrdersCreateUserID").ToString
            '--------------------------------------------------
            If reader("SampleProcessBeginDate") Is DBNull.Value Then
                objInfo.SampleProcessBeginDate = Nothing
            Else
                objInfo.SampleProcessBeginDate = Format(CDate(reader("SampleProcessBeginDate")), "yyyy/MM/dd")
            End If
            objInfo.SampleProcessCheck = reader("SampleProcessCheck")
            objInfo.SampleProcessCreateUserID = reader("SampleProcessCreateUserID").ToString
            '--------------------------------------------------
            If reader("SamplePaceBeginDate") Is DBNull.Value Then
                objInfo.SamplePaceBeginDate = Nothing
            Else
                objInfo.SamplePaceBeginDate = Format(CDate(reader("SamplePaceBeginDate")), "yyyy/MM/dd")
            End If
            objInfo.SamplePaceCheck = reader("SamplePaceCheck")
            objInfo.SamplePaceCreateUserID = reader("SamplePaceCreateUserID").ToString
            objInfo.SamplePacePortName = reader("SamplePacePortName").ToString
            objInfo.SamplePaceBaudRate = reader("SamplePaceBaudRate")
            objInfo.SamplePaceBitWeighing = reader("SamplePaceBitWeighing")
            '--------------------------------------------------
            If reader("SampleSendBeginDate") Is DBNull.Value Then
                objInfo.SampleSendBeginDate = Nothing
            Else
                objInfo.SampleSendBeginDate = Format(CDate(reader("SampleSendBeginDate")), "yyyy/MM/dd")
            End If
            objInfo.SampleSendCheck = reader("SampleSendCheck")
            objInfo.SampleSendCreateUserID = reader("SampleSendCreateUserID").ToString
            '--------------------------------------------------
            If reader("SampleCustomerFeedbackBeginDate") Is DBNull.Value Then
                objInfo.SampleCustomerFeedbackBeginDate = Nothing
            Else
                objInfo.SampleCustomerFeedbackBeginDate = Format(CDate(reader("SampleCustomerFeedbackBeginDate")), "yyyy/MM/dd")
            End If
            objInfo.SampleCustomerFeedbackCheck = reader("SampleCustomerFeedbackCheck")
            objInfo.SampleCustomerFeedbackCreateUserID = reader("SampleCustomerFeedbackCreateUserID").ToString
            '--------------------------------------------------
            If reader("SampleCollectionBeginDate") Is DBNull.Value Then
                objInfo.SampleCollectionBeginDate = Nothing
            Else
                objInfo.SampleCollectionBeginDate = Format(CDate(reader("SampleCollectionBeginDate")), "yyyy/MM/dd")
            End If
            objInfo.SampleCollectionCheck = reader("SampleCollectionCheck")
            objInfo.SampleCollectionCreateUserID = reader("SampleCollectionCreateUserID").ToString

            objInfo.SampleCollectionD_ID = reader("SampleCollectionD_ID").ToString
            objInfo.SampleCollectionStatusType = reader("SampleCollectionStatusType").ToString
            '--------------------------------------------------
            If reader("SampleTransactionBeginDate") Is DBNull.Value Then
                objInfo.SampleTransactionBeginDate = Nothing
            Else
                objInfo.SampleTransactionBeginDate = Format(CDate(reader("SampleTransactionBeginDate")), "yyyy/MM/dd")
            End If
            objInfo.SampleTransactionCheck = reader("SampleTransactionCheck")
            objInfo.SampleTransactionCreateUserID = reader("SampleTransactionCreateUserID").ToString
            '--------------------------------------------------
            If reader("SampleWareInventoryBeginDate") Is DBNull.Value Then
                objInfo.SampleWareInventoryBeginDate = Nothing
            Else
                objInfo.SampleWareInventoryBeginDate = Format(CDate(reader("SampleWareInventoryBeginDate")), "yyyy/MM/dd")
            End If
            objInfo.SampleWareInventoryCheck = reader("SampleWareInventoryCheck")
            objInfo.SampleWareInventoryCreateUserID = reader("SampleWareInventoryCreateUserID").ToString
            '--------------------------------------------------
            If reader("SamplePackingBeginDate") Is DBNull.Value Then
                objInfo.SamplePackingBeginDate = Nothing
            Else
                objInfo.SamplePackingBeginDate = Format(CDate(reader("SamplePackingBeginDate")), "yyyy/MM/dd")
            End If
            objInfo.SamplePackingCheck = reader("SamplePackingCheck")
            objInfo.SamplePackingCreateUserID = reader("SamplePackingCreateUserID").ToString
            '--------------------------------------------------
            If reader("SamplePlanBeginDate") Is DBNull.Value Then
                objInfo.SamplePlanBeginDate = Nothing
            Else
                objInfo.SamplePlanBeginDate = Format(CDate(reader("SamplePlanBeginDate")), "yyyy/MM/dd")
            End If
            objInfo.SamplePlanCheck = reader("SamplePlanCheck")
            objInfo.SamplePlanCreateUserID = reader("SamplePlanCreateUserID").ToString
            '--------------------------------------------------
            If reader("SampleDivertBeginDate") Is DBNull.Value Then
                objInfo.SampleDivertBeginDate = Nothing
            Else
                objInfo.SampleDivertBeginDate = Format(CDate(reader("SampleDivertBeginDate")), "yyyy/MM/dd")
            End If
            objInfo.SampleDivertCheck = reader("SampleDivertCheck")
            objInfo.SampleDivertCreateUserID = reader("SampleDivertCreateUserID").ToString
            Return objInfo
        End Function


        Public Function SampleSetting_GetList(ByVal U_ID As String) As List(Of SampleSettingInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleSetting_GetList")
            db.AddInParameter(dbComm, "@U_ID", DbType.String, U_ID)
            Dim FeatureList As New List(Of SampleSettingInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSampleSetting(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function SampleSetting_Update(ByVal objinfo As SampleSettingInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleSetting_Update")
                db.AddInParameter(dbComm, "@U_ID", DbType.String, objinfo.U_ID)
                db.AddInParameter(dbComm, "@SampleOrdersBeginDate", DbType.DateTime, objinfo.SampleOrdersBeginDate)
                db.AddInParameter(dbComm, "@SampleOrdersCheck", DbType.String, objinfo.SampleOrdersCheck)
                db.AddInParameter(dbComm, "@SampleOrdersCreateUserID", DbType.String, objinfo.SampleOrdersCreateUserID)
                '---------------------------------------------------------------------------------------------------------
                db.AddInParameter(dbComm, "@SampleProcessBeginDate", DbType.DateTime, objinfo.SampleProcessBeginDate)
                db.AddInParameter(dbComm, "@SampleProcessCheck", DbType.String, objinfo.SampleProcessCheck)
                db.AddInParameter(dbComm, "@SampleProcessCreateUserID", DbType.String, objinfo.SampleProcessCreateUserID)
                '---------------------------------------------------------------------------------------------------------
                db.AddInParameter(dbComm, "@SamplePaceBeginDate", DbType.DateTime, objinfo.SamplePaceBeginDate)
                db.AddInParameter(dbComm, "@SamplePaceCheck", DbType.String, objinfo.SamplePaceCheck)
                db.AddInParameter(dbComm, "@SamplePaceCreateUserID", DbType.String, objinfo.SamplePaceCreateUserID)

                db.AddInParameter(dbComm, "@SamplePacePortName", DbType.String, objinfo.SamplePacePortName)
                db.AddInParameter(dbComm, "@SamplePaceBaudRate", DbType.Int32, objinfo.SamplePaceBaudRate)
                db.AddInParameter(dbComm, "@SamplePaceBitWeighing", DbType.Boolean, objinfo.SamplePaceBitWeighing)
                '---------------------------------------------------------------------------------------------------------
                db.AddInParameter(dbComm, "@SampleSendBeginDate", DbType.DateTime, objinfo.SampleSendBeginDate)
                db.AddInParameter(dbComm, "@SampleSendCheck", DbType.String, objinfo.SampleSendCheck)
                db.AddInParameter(dbComm, "@SampleSendCreateUserID", DbType.String, objinfo.SampleSendCreateUserID)
                '---------------------------------------------------------------------------------------------------------
                db.AddInParameter(dbComm, "@SampleCustomerFeedbackBeginDate", DbType.DateTime, objinfo.SampleCustomerFeedbackBeginDate)
                db.AddInParameter(dbComm, "@SampleCustomerFeedbackCheck", DbType.String, objinfo.SampleCustomerFeedbackCheck)
                db.AddInParameter(dbComm, "@SampleCustomerFeedbackCreateUserID", DbType.String, objinfo.SampleCustomerFeedbackCreateUserID)
                '---------------------------------------------------------------------------------------------------------
                db.AddInParameter(dbComm, "@SampleCollectionBeginDate", DbType.DateTime, objinfo.SampleCollectionBeginDate)
                db.AddInParameter(dbComm, "@SampleCollectionCheck", DbType.String, objinfo.SampleCollectionCheck)
                db.AddInParameter(dbComm, "@SampleCollectionCreateUserID", DbType.String, objinfo.SampleCollectionCreateUserID)
                db.AddInParameter(dbComm, "@SampleCollectionD_ID", DbType.String, objinfo.SampleCollectionD_ID)
                db.AddInParameter(dbComm, "@SampleCollectionStatusType", DbType.String, objinfo.SampleCollectionStatusType)
                '---------------------------------------------------------------------------------------------------------
                db.AddInParameter(dbComm, "@SampleTransactionBeginDate", DbType.DateTime, objinfo.SampleTransactionBeginDate)
                db.AddInParameter(dbComm, "@SampleTransactionCheck", DbType.String, objinfo.SampleTransactionCheck)
                db.AddInParameter(dbComm, "@SampleTransactionCreateUserID", DbType.String, objinfo.SampleTransactionCreateUserID)
                '---------------------------------------------------------------------------------------------------------
                db.AddInParameter(dbComm, "@SampleWareInventoryBeginDate", DbType.DateTime, objinfo.SampleWareInventoryBeginDate)
                db.AddInParameter(dbComm, "@SampleWareInventoryCheck", DbType.String, objinfo.SampleWareInventoryCheck)
                db.AddInParameter(dbComm, "@SampleWareInventoryCreateUserID", DbType.String, objinfo.SampleWareInventoryCreateUserID)
                '---------------------------------------------------------------------------------------------------------
                db.AddInParameter(dbComm, "@SamplePackingBeginDate", DbType.DateTime, objinfo.SamplePackingBeginDate)
                db.AddInParameter(dbComm, "@SamplePackingCheck", DbType.String, objinfo.SamplePackingCheck)
                db.AddInParameter(dbComm, "@SamplePackingCreateUserID", DbType.String, objinfo.SamplePackingCreateUserID)
                '---------------------------------------------------------------------------------------------------------
                db.AddInParameter(dbComm, "@SamplePlanBeginDate", DbType.DateTime, objinfo.SamplePlanBeginDate)
                db.AddInParameter(dbComm, "@SamplePlanCheck", DbType.String, objinfo.SamplePlanCheck)
                db.AddInParameter(dbComm, "@SamplePlanCreateUserID", DbType.String, objinfo.SamplePlanCreateUserID)
                '---------------------------------------------------------------------------------------------------------
                db.AddInParameter(dbComm, "@SampleDivertBeginDate", DbType.DateTime, objinfo.SampleDivertBeginDate)
                db.AddInParameter(dbComm, "@SampleDivertCheck", DbType.String, objinfo.SampleDivertCheck)
                db.AddInParameter(dbComm, "@SampleDivertCreateUserID", DbType.String, objinfo.SampleDivertCreateUserID)
                db.ExecuteNonQuery(dbComm)
                SampleSetting_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SampleSetting_Update = False
            End Try
        End Function

        Public Function SampleSetting_Add(ByVal objInfo As SampleSettingInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleSetting_Add")
                db.AddInParameter(dbComm, "@U_ID", DbType.String, objInfo.U_ID)
                db.AddInParameter(dbComm, "@SampleOrdersBeginDate", DbType.DateTime, objInfo.SampleOrdersBeginDate)
                db.AddInParameter(dbComm, "@SampleOrdersCheck", DbType.String, objInfo.SampleOrdersCheck)
                db.AddInParameter(dbComm, "@SampleOrdersCreateUserID", DbType.String, objInfo.SampleOrdersCreateUserID)
                '---------------------------------------------------------------------------------------------------------
                db.AddInParameter(dbComm, "@SampleProcessBeginDate", DbType.DateTime, objInfo.SampleProcessBeginDate)
                db.AddInParameter(dbComm, "@SampleProcessCheck", DbType.String, objInfo.SampleProcessCheck)
                db.AddInParameter(dbComm, "@SampleProcessCreateUserID", DbType.String, objInfo.SampleProcessCreateUserID)
                '---------------------------------------------------------------------------------------------------------
                db.AddInParameter(dbComm, "@SamplePaceBeginDate", DbType.DateTime, objInfo.SamplePaceBeginDate)
                db.AddInParameter(dbComm, "@SamplePaceCheck", DbType.String, objInfo.SamplePaceCheck)
                db.AddInParameter(dbComm, "@SamplePaceCreateUserID", DbType.String, objInfo.SamplePaceCreateUserID)
                db.AddInParameter(dbComm, "@SamplePacePortName", DbType.String, objInfo.SamplePacePortName)
                db.AddInParameter(dbComm, "@SamplePaceBaudRate", DbType.Int32, objInfo.SamplePaceBaudRate)
                db.AddInParameter(dbComm, "@SamplePaceBitWeighing", DbType.Boolean, objInfo.SamplePaceBitWeighing)
                '---------------------------------------------------------------------------------------------------------
                db.AddInParameter(dbComm, "@SampleSendBeginDate", DbType.DateTime, objInfo.SampleSendBeginDate)
                db.AddInParameter(dbComm, "@SampleSendCheck", DbType.String, objInfo.SampleSendCheck)
                db.AddInParameter(dbComm, "@SampleSendCreateUserID", DbType.String, objInfo.SampleSendCreateUserID)
                '---------------------------------------------------------------------------------------------------------
                db.AddInParameter(dbComm, "@SampleCustomerFeedbackBeginDate", DbType.DateTime, objInfo.SampleCustomerFeedbackBeginDate)
                db.AddInParameter(dbComm, "@SampleCustomerFeedbackCheck", DbType.String, objInfo.SampleCustomerFeedbackCheck)
                db.AddInParameter(dbComm, "@SampleCustomerFeedbackCreateUserID", DbType.String, objInfo.SampleCustomerFeedbackCreateUserID)
                '---------------------------------------------------------------------------------------------------------
                db.AddInParameter(dbComm, "@SampleCollectionBeginDate", DbType.DateTime, objInfo.SampleCollectionBeginDate)
                db.AddInParameter(dbComm, "@SampleCollectionCheck", DbType.String, objInfo.SampleCollectionCheck)
                db.AddInParameter(dbComm, "@SampleCollectionCreateUserID", DbType.String, objInfo.SampleCollectionCreateUserID)
                db.AddInParameter(dbComm, "@SampleCollectionD_ID", DbType.String, objInfo.SampleCollectionD_ID)
                db.AddInParameter(dbComm, "@SampleCollectionStatusType", DbType.String, objInfo.SampleCollectionStatusType)
                '---------------------------------------------------------------------------------------------------------
                db.AddInParameter(dbComm, "@SampleTransactionBeginDate", DbType.DateTime, objInfo.SampleTransactionBeginDate)
                db.AddInParameter(dbComm, "@SampleTransactionCheck", DbType.String, objInfo.SampleTransactionCheck)
                db.AddInParameter(dbComm, "@SampleTransactionCreateUserID", DbType.String, objInfo.SampleTransactionCreateUserID)
                '---------------------------------------------------------------------------------------------------------
                db.AddInParameter(dbComm, "@SampleWareInventoryBeginDate", DbType.DateTime, objInfo.SampleWareInventoryBeginDate)
                db.AddInParameter(dbComm, "@SampleWareInventoryCheck", DbType.String, objInfo.SampleWareInventoryCheck)
                db.AddInParameter(dbComm, "@SampleWareInventoryCreateUserID", DbType.String, objInfo.SampleWareInventoryCreateUserID)
                '---------------------------------------------------------------------------------------------------------
                db.AddInParameter(dbComm, "@SamplePackingBeginDate", DbType.DateTime, objInfo.SamplePackingBeginDate)
                db.AddInParameter(dbComm, "@SamplePackingCheck", DbType.String, objInfo.SamplePackingCheck)
                db.AddInParameter(dbComm, "@SamplePackingCreateUserID", DbType.String, objInfo.SamplePackingCreateUserID)
                '---------------------------------------------------------------------------------------------------------
                db.AddInParameter(dbComm, "@SamplePlanBeginDate", DbType.DateTime, objInfo.SamplePlanBeginDate)
                db.AddInParameter(dbComm, "@SamplePlanCheck", DbType.String, objInfo.SamplePlanCheck)
                db.AddInParameter(dbComm, "@SamplePlanCreateUserID", DbType.String, objInfo.SamplePlanCreateUserID)
                '---------------------------------------------------------------------------------------------------------
                db.AddInParameter(dbComm, "@SampleDivertBeginDate", DbType.DateTime, objInfo.SampleDivertBeginDate)
                db.AddInParameter(dbComm, "@SampleDivertCheck", DbType.String, objInfo.SampleDivertCheck)
                db.AddInParameter(dbComm, "@SampleDivertCreateUserID", DbType.String, objInfo.SampleDivertCreateUserID)

                db.ExecuteNonQuery(dbComm)
                SampleSetting_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SampleSetting_Add = False
            End Try
        End Function
    End Class
End Namespace