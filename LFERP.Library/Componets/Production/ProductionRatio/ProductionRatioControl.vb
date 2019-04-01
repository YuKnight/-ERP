
Namespace LFERP.Library.Production.ProductionRatio

    Public Class ProductionRatioControl

        Public Function ProductionRatio_GetNO(ByVal NDate As String) As ProductionRatioInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionRatio_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionRatio(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function ProductionRatio_Add(ByVal objinfo As ProductionRatioInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionRatio_Add")

                db.AddInParameter(dbComm, "@PR_NO", DbType.String, objinfo.PR_NO)
                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@Pro_NO1", DbType.String, objinfo.Pro_NO1)
                db.AddInParameter(dbComm, "@PR_Ratio", DbType.Single, objinfo.PR_Ratio)
                db.AddInParameter(dbComm, "@PR_Remark", DbType.String, objinfo.PR_Remark)

                db.AddInParameter(dbComm, "@PR_AddUserID", DbType.String, objinfo.PR_AddUserID)
                db.AddInParameter(dbComm, "@PR_AddDate", DbType.String, objinfo.PR_AddDate)

                db.ExecuteNonQuery(dbComm)
                ProductionRatio_Add = True

            Catch ex As Exception
                ProductionRatio_Add = False
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function ProductionRatio_Update(ByVal objinfo As ProductionRatioInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionRatio_Update")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@PR_NO", DbType.String, objinfo.PR_NO)
                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@Pro_NO1", DbType.String, objinfo.Pro_NO1)
                db.AddInParameter(dbComm, "@PR_Ratio", DbType.Single, objinfo.PR_Ratio)

                db.AddInParameter(dbComm, "@PR_Remark", DbType.String, objinfo.PR_Remark)
                db.AddInParameter(dbComm, "@PR_ModifyUserID", DbType.String, objinfo.PR_ModifyUserID)
                db.AddInParameter(dbComm, "@PR_ModifyDate", DbType.String, objinfo.PR_ModifyDate)

                db.ExecuteNonQuery(dbComm)
                ProductionRatio_Update = True
            Catch ex As Exception
                ProductionRatio_Update = False
                MsgBox(ex.Message)
            End Try
        End Function


        Public Function ProductionRatio_Delete(ByVal AutoID As String, ByVal Pro_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionRatio_Delete")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Pro_NO)

                db.ExecuteNonQuery(dbComm)
                ProductionRatio_Delete = True
            Catch ex As Exception
                ProductionRatio_Delete = False
                MsgBox(ex.Message)
            End Try

        End Function

        Public Function ProductionRatio_Check(ByVal objinfo As ProductionRatioInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionRatio_Check")

                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@PR_Check", DbType.String, objinfo.PR_Check)
                db.AddInParameter(dbComm, "@PR_CheckUserID", DbType.String, objinfo.PR_CheckUserID)
                db.AddInParameter(dbComm, "@PR_CheckDate", DbType.String, objinfo.PR_CheckDate)

                db.ExecuteNonQuery(dbComm)
                ProductionRatio_Check = True
            Catch ex As Exception
                ProductionRatio_Check = False
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function ProductionRatio_GetList(ByVal PR_NO As String, ByVal Pro_NO As String, ByVal Pro_NO1 As String, ByVal PR_Check As String) As List(Of ProductionRatioInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionRatio_GetList")

            db.AddInParameter(dbComm, "@PR_NO", DbType.String, PR_NO)
            db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Pro_NO)
            db.AddInParameter(dbComm, "@Pro_NO1", DbType.String, Pro_NO1)
            db.AddInParameter(dbComm, "@PR_Check", DbType.String, PR_Check)

            Dim FeatureList As New List(Of ProductionRatioInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionRatio(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function FillProductionRatio(ByVal reader As IDataReader) As ProductionRatioInfo
            On Error Resume Next

            Dim fi As New ProductionRatioInfo

            'If reader("PM_JiYu") Is DBNull.Value Then
            '    fi.PM_JiYu = Nothing
            'Else
            '    fi.PM_JiYu = reader("PM_JiYu")
            'End If

            fi.AutoID = reader("AutoID").ToString

            fi.PR_NO = reader("PR_NO").ToString
            fi.Pro_NO = reader("Pro_NO").ToString
            fi.Pro_NO1 = reader("Pro_NO1").ToString
            fi.PR_Ratio = reader("PR_Ratio").ToString

            fi.Pro_Type = reader("Pro_Type").ToString
            fi.PM_M_Code = reader("PM_M_Code").ToString
            fi.PM_Type = reader("PM_Type").ToString
            fi.PS_Name = reader("PS_Name").ToString

            fi.Pro_Type1 = reader("Pro_Type1").ToString
            fi.PM_M_Code1 = reader("PM_M_Code1").ToString
            fi.PM_Type1 = reader("PM_Type1").ToString
            fi.PS_Name1 = reader("PS_Name1").ToString

            fi.PR_Remark = reader("PR_Remark").ToString

            fi.PR_AddUserID = reader("PR_AddUserID").ToString
            fi.PR_AddDate = reader("PR_AddDate").ToString
            fi.PR_ModifyUserID = reader("PR_ModifyUserID").ToString
            If reader("PR_ModifyDate") Is DBNull.Value Then
                fi.PR_ModifyDate = Nothing
            Else
                fi.PR_ModifyDate = reader("PR_ModifyDate").ToString
            End If
            If reader("PR_Check") Is DBNull.Value Then
                fi.PR_Check = False
            Else
                fi.PR_Check = reader("PR_Check")
            End If

            fi.PR_CheckUserID = reader("PR_CheckUserID").ToString
            fi.PR_CheckUserName = reader("PR_CheckUserName").ToString
            If reader("PR_CheckDate") Is DBNull.Value Then
                fi.PR_CheckDate = Nothing
            Else
                fi.PR_CheckDate = reader("PR_CheckDate").ToString
            End If

            Return fi

        End Function

    End Class

End Namespace




