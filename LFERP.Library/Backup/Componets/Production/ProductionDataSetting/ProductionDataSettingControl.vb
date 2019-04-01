Namespace LFERP.Library.Production.Datasetting

    Public Class ProductionDataSettingControl

        Public Function ProductionUser_Add(ByVal objinfo As ProductionDataSettingInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionUser_Add")

                db.AddInParameter(dbComm, "@UserID", DbType.String, objinfo.UserID)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)

                db.ExecuteNonQuery(dbComm)
                ProductionUser_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionUser_Add = False
            End Try

        End Function

        Public Function ProductionUser_Delete(ByVal UserID As String, ByVal PM_M_Code As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionUser_Delete")

                db.AddInParameter(dbComm, "@UserID", DbType.String, UserID)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)

                db.ExecuteNonQuery(dbComm)
                ProductionUser_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionUser_Delete = False
            End Try

        End Function

        Public Function ProductionUser_GetList(ByVal UserID As String, ByVal PM_M_Code As String) As List(Of ProductionDataSettingInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionUser_GetList")

            db.AddInParameter(dbComm, "@UserID", DbType.String, UserID)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)


            Dim FeatureList As New List(Of ProductionDataSettingInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionDataSetting(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function ProductionIssue_Add(ByVal objinfo As ProductionDataSettingInfo) As Boolean
            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionIssue_Add")

                db.AddInParameter(dbComm, "@UserID", DbType.String, objinfo.UserID)
                db.AddInParameter(dbComm, "@FP_OutDep", DbType.String, objinfo.FP_OutDep)
                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, objinfo.Pro_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)

                db.ExecuteNonQuery(dbComm)
                ProductionIssue_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionIssue_Add = False
            End Try
        End Function

        Public Function ProductionIssue_Delete(ByVal UserID As String, ByVal FP_OutDep As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal Pro_NO As String) As Boolean
            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionIssue_Delete")

                db.AddInParameter(dbComm, "@UserID", DbType.String, UserID)
                db.AddInParameter(dbComm, "@FP_OutDep", DbType.String, FP_OutDep)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Pro_NO)

                db.ExecuteNonQuery(dbComm)
                ProductionIssue_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionIssue_Delete = False
            End Try
        End Function

        Public Function ProductionIssue_GetList(ByVal UserID As String, ByVal FP_OutDep As String, ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal Pro_NO As String) As List(Of ProductionDataSettingInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionIssue_GetList")

            db.AddInParameter(dbComm, "@UserID", DbType.String, UserID)
            db.AddInParameter(dbComm, "@FP_OutDep", DbType.String, FP_OutDep)
            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Pro_NO)

            Dim FeatureList As New List(Of ProductionDataSettingInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionDataSetting(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function ProductionIncome_Add(ByVal objinfo As ProductionDataSettingInfo) As Boolean
            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionIncome_Add")

                db.AddInParameter(dbComm, "@UserID", DbType.String, objinfo.UserID)
                db.AddInParameter(dbComm, "@FP_InDep", DbType.String, objinfo.FP_InDep)
              

                db.ExecuteNonQuery(dbComm)
                ProductionIncome_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionIncome_Add = False
            End Try
        End Function


        Public Function ProductionIncome_Delete(ByVal UserID As String, ByVal FP_InDep As String) As Boolean
            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionIncome_Delete")

                db.AddInParameter(dbComm, "@UserID", DbType.String, UserID)
                db.AddInParameter(dbComm, "@FP_InDep", DbType.String, FP_InDep)


                db.ExecuteNonQuery(dbComm)
                ProductionIncome_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionIncome_Delete = False
            End Try
        End Function

        Public Function ProductionIncome_GetList(ByVal UserID As String, ByVal FP_InDep As String) As List(Of ProductionDataSettingInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionIncome_GetList")

            db.AddInParameter(dbComm, "@UserID", DbType.String, UserID)
            db.AddInParameter(dbComm, "@FP_InDep", DbType.String, FP_InDep)

            Dim FeatureList As New List(Of ProductionDataSettingInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionDataSetting(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FillProductionDataSetting(ByVal reader As IDataReader) As ProductionDataSettingInfo

            On Error Resume Next

            Dim pi As New ProductionDataSettingInfo

            If reader("PM_JiYu") Is DBNull.Value Then
                pi.PM_JiYu = Nothing
            Else
                pi.PM_JiYu = reader("PM_JiYu")
            End If

            pi.UserID = reader("UserID").ToString
            pi.FP_OutDep = reader("FP_OutDep").ToString
            pi.FP_InDep = reader("FP_InDep").ToString
            pi.Pro_Type = reader("Pro_Type").ToString
            pi.PM_M_Code = reader("PM_M_Code").ToString
            pi.PM_Type = reader("PM_Type").ToString
            pi.Pro_NO = reader("Pro_NO").ToString
            pi.FP_InName = reader("FP_InName").ToString
            pi.PS_NO = reader("Pro_NO").ToString
            pi.PS_Name = reader("PS_Name").ToString

            Return pi

        End Function


    End Class

End Namespace
