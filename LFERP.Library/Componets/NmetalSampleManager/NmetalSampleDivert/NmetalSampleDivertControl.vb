Namespace LFERP.Library.NmetalSampleManager.NmetalSampleDivert
    Public Class NmetalSampleDivertControl

        Public Function NmetalSampleDivert_Add(ByVal objinfo As NmetalSampleDivertInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleDivert_Add")

                db.AddInParameter(dbComm, "@SD_ID", DbType.String, objinfo.SD_ID)
                db.AddInParameter(dbComm, "@Code_ID", DbType.String, objinfo.Code_ID)
                db.AddInParameter(dbComm, "@SD_OutSO_ID", DbType.String, objinfo.SD_OutSO_ID)
                db.AddInParameter(dbComm, "@SD_OutD_ID", DbType.String, objinfo.SD_OutD_ID)
                db.AddInParameter(dbComm, "@SD_OutPS_NO", DbType.String, objinfo.SD_OutPS_NO)

                db.AddInParameter(dbComm, "@SD_InSO_ID", DbType.String, objinfo.SD_InSO_ID)
                db.AddInParameter(dbComm, "@SD_InD_ID", DbType.String, objinfo.SD_InD_ID)
                db.AddInParameter(dbComm, "@SD_InPS_NO", DbType.String, objinfo.SD_InPS_NO)
                db.AddInParameter(dbComm, "@SD_Qty", DbType.Int16, objinfo.SD_Qty)
                db.AddInParameter(dbComm, "@SD_CardID", DbType.String, objinfo.SD_CardID)

                db.AddInParameter(dbComm, "@SD_Remark", DbType.String, objinfo.SD_Remark)
                db.AddInParameter(dbComm, "@SD_AddUserID", DbType.String, objinfo.SD_AddUserID)
                db.AddInParameter(dbComm, "@SD_AddDate", DbType.Date, objinfo.SD_AddDate)

                db.ExecuteNonQuery(dbComm)
                NmetalSampleDivert_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSampleDivert_Add = False
            End Try
        End Function

        Public Function NmetalSampleDivert_Update(ByVal objinfo As NmetalSampleDivertInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleDivert_Update")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)

                db.AddInParameter(dbComm, "@SD_ID", DbType.String, objinfo.SD_ID)
                db.AddInParameter(dbComm, "@Code_ID", DbType.String, objinfo.Code_ID)
                db.AddInParameter(dbComm, "@SD_OutSO_ID", DbType.String, objinfo.SD_OutSO_ID)
                db.AddInParameter(dbComm, "@SD_OutD_ID", DbType.String, objinfo.SD_OutD_ID)
                db.AddInParameter(dbComm, "@SD_OutPS_NO", DbType.String, objinfo.SD_OutPS_NO)

                db.AddInParameter(dbComm, "@SD_InSO_ID", DbType.String, objinfo.SD_InSO_ID)
                db.AddInParameter(dbComm, "@SD_InD_ID", DbType.String, objinfo.SD_InD_ID)
                db.AddInParameter(dbComm, "@SD_InPS_NO", DbType.String, objinfo.SD_InPS_NO)
                db.AddInParameter(dbComm, "@SD_Qty", DbType.Int16, objinfo.SD_Qty)
                db.AddInParameter(dbComm, "@SD_CardID", DbType.String, objinfo.SD_CardID)

                db.AddInParameter(dbComm, "@SD_Remark", DbType.String, objinfo.SD_Remark)
                db.AddInParameter(dbComm, "@SD_ModifyUserID", DbType.String, objinfo.SD_ModifyUserID)
                db.AddInParameter(dbComm, "@SD_ModifyDate", DbType.Date, objinfo.SD_ModifyDate)

                db.ExecuteNonQuery(dbComm)
                NmetalSampleDivert_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSampleDivert_Update = False
            End Try
        End Function

        Public Function NmetalSampleDivert_Check(ByVal objinfo As NmetalSampleDivertInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleDivert_Check")

                db.AddInParameter(dbComm, "@SD_ID", DbType.String, objinfo.SD_ID)
                db.AddInParameter(dbComm, "@SD_CheckAction", DbType.String, objinfo.SD_CheckAction)
                db.AddInParameter(dbComm, "@SD_CheckDate", DbType.Date, objinfo.SD_CheckDate)
                db.AddInParameter(dbComm, "@SD_Check", DbType.Boolean, objinfo.SD_Check)
                db.AddInParameter(dbComm, "@SD_CheckRemark", DbType.String, objinfo.SD_CheckRemark)

                db.ExecuteNonQuery(dbComm)
                NmetalSampleDivert_Check = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSampleDivert_Check = False
            End Try
        End Function

        Public Function NmetalSampleDivert_Delete(ByVal AutoID As String, ByVal SD_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleDivert_Delete")
                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbComm, "@SD_ID", DbType.String, SD_ID)
                db.ExecuteNonQuery(dbComm)
                NmetalSampleDivert_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSampleDivert_Delete = False
            End Try
        End Function


        Public Function NmetalSampleDivert_GetID(ByVal SD_ID As String) As NmetalSampleDivertInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleDivert_GetID")
            db.AddInParameter(dbComm, "@SD_ID", DbType.String, SD_ID)
            Dim FeatureList As New NmetalSampleDivertInfo
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.SD_ID = reader("SD_ID").ToString
                End While
                Return FeatureList
            End Using
        End Function


        Public Function NmetalSampleDivert_Getlist(ByVal AutoID As String, ByVal SD_ID As String, ByVal Code_ID As String, ByVal SD_OutSO_ID As String, ByVal SD_OutD_ID As String, _
        ByVal SD_OutPS_NO As String, ByVal SD_InSO_ID As String, ByVal SD_InD_ID As String, ByVal SD_InPS_NO As String, ByVal SD_Check As String, ByVal StartDate As String, ByVal EndDate As String, ByVal SD_AddUserID As String) As List(Of NmetalSampleDivertInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleDivert_Getlist")

            db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbComm, "@SD_ID", DbType.String, SD_ID)
            db.AddInParameter(dbComm, "@Code_ID", DbType.String, Code_ID)
            db.AddInParameter(dbComm, "@SD_OutSO_ID", DbType.String, SD_OutSO_ID)
            db.AddInParameter(dbComm, "@SD_OutD_ID", DbType.String, SD_OutD_ID)

            db.AddInParameter(dbComm, "@SD_OutPS_NO", DbType.String, SD_OutPS_NO)
            db.AddInParameter(dbComm, "@SD_InSO_ID", DbType.String, SD_InSO_ID)
            db.AddInParameter(dbComm, "@SD_InD_ID", DbType.Boolean, SD_InD_ID)

            db.AddInParameter(dbComm, "@SD_InPS_NO", DbType.String, SD_InPS_NO)
            db.AddInParameter(dbComm, "@SD_Check", DbType.String, SD_Check)
            db.AddInParameter(dbComm, "@StartDate", DbType.String, StartDate)
            db.AddInParameter(dbComm, "@EndDate", DbType.String, EndDate)
            db.AddInParameter(dbComm, "@SD_AddUserID", DbType.String, SD_AddUserID)

            Dim FeatureList As New List(Of NmetalSampleDivertInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillNmetalSampleDivert(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Friend Function FillNmetalSampleDivert(ByVal reader As IDataReader) As NmetalSampleDivertInfo
            On Error Resume Next

            Dim objInfo As New NmetalSampleDivertInfo

            objInfo.AutoID = reader("AutoID").ToString
            objInfo.SD_ID = reader("SD_ID").ToString
            objInfo.Code_ID = reader("Code_ID").ToString
            objInfo.SD_OutSO_ID = reader("SD_OutSO_ID").ToString
            objInfo.SD_OutD_ID = reader("SD_OutD_ID").ToString

            objInfo.SD_OutPS_NO = reader("SD_OutPS_NO").ToString
            objInfo.SD_InSO_ID = reader("SD_InSO_ID").ToString
            objInfo.SD_InD_ID = reader("SD_InD_ID").ToString
            objInfo.SD_InPS_NO = reader("SD_InPS_NO").ToString
            objInfo.SD_Qty = reader("SD_Qty")

            objInfo.SD_Check = reader("SD_Check")
            objInfo.SD_CheckDate = reader("SD_CheckDate")
            objInfo.SD_CheckAction = reader("SD_CheckAction").ToString
            objInfo.SD_CheckRemark = reader("SD_CheckRemark").ToString
            objInfo.SD_CardID = reader("SD_CardID").ToString

            objInfo.SD_Remark = reader("SD_Remark").ToString
            objInfo.SD_AddUserID = reader("SD_AddUserID").ToString
            objInfo.SD_AddDate = reader("SD_AddDate")
            objInfo.SD_ModifyUserID = reader("SD_ModifyUserID").ToString
            objInfo.SD_ModifyDate = reader("SD_ModifyDate")

            objInfo.SD_CheckActionName = reader("SD_CheckActionName").ToString
            objInfo.SD_AddUserName = reader("SD_AddUserName").ToString
            objInfo.SD_ModifyUserName = reader("SD_ModifyUserName").ToString
            objInfo.SD_OutPS_Name = reader("SD_OutPS_Name").ToString
            objInfo.SD_InPS_Name = reader("SD_InPS_Name").ToString

            objInfo.SD_OutD_Name = reader("SD_OutD_Name").ToString
            objInfo.SD_InD_Name = reader("SD_InD_Name").ToString
            objInfo.OutSO_SampleID = reader("OutSO_SampleID").ToString
            objInfo.InSO_SampleID = reader("InSO_SampleID").ToString
            objInfo.OutPM_M_Code = reader("OutPM_M_Code").ToString

            objInfo.InPM_M_Code = reader("InPM_M_Code").ToString

            Return objInfo
        End Function


    End Class
End Namespace
