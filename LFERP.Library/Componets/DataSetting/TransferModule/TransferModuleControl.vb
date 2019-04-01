
Namespace LFERP.DataSetting

    Public Class TransferModuleControl

        Public Function TransferModule_Add(ByVal objinfo As TransferModuleInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("TransferModule_Add")

                db.AddInParameter(dbComm, "@ModuleID", DbType.String, objinfo.ModuleID)
                db.AddInParameter(dbComm, "@ModuleDetail", DbType.String, objinfo.ModuleDetail)
                db.AddInParameter(dbComm, "@ModuleRemark", DbType.String, objinfo.ModuleRemark)

                db.ExecuteNonQuery(dbComm)
                TransferModule_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                TransferModule_Add = False

            End Try

        End Function

        Public Function TransferModule_Update(ByVal objinfo As TransferModuleInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("TransferModule_Update")

                'db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@ModuleID", DbType.String, objinfo.ModuleID)
                'db.AddInParameter(dbComm, "@ModuleDetail", DbType.String, objinfo.ModuleDetail)
                db.AddInParameter(dbComm, "@ModuleBit", DbType.Boolean, objinfo.ModuleBit)
                db.AddInParameter(dbComm, "@ModuleTime", DbType.Date, objinfo.ModuleTime)
                db.AddInParameter(dbComm, "@ModuleRemark", DbType.String, objinfo.ModuleRemark)

                db.ExecuteNonQuery(dbComm)
                TransferModule_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                TransferModule_Update = False
            End Try
        End Function

        Public Function TransferModule_Delete(ByVal ModuleID As String, ByVal ModuleRemark As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("TransferModule_Delete")

                db.AddInParameter(dbComm, "@ModuleID", DbType.String, ModuleID)
                db.AddInParameter(dbComm, "@ModuleRemark", DbType.String, ModuleRemark)

                db.ExecuteNonQuery(dbComm)
                TransferModule_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                TransferModule_Delete = False
            End Try

        End Function

        Public Function TransferModule_GetList(ByVal AutoID As String, ByVal ModuleID As String, ByVal ModuleBit As String, ByVal ModuleRemark As String) As List(Of TransferModuleInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("TransferModule_GetList")

            db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbComm, "@ModuleID", DbType.String, ModuleID)
            db.AddInParameter(dbComm, "@ModuleBit", DbType.String, ModuleBit)
            db.AddInParameter(dbComm, "@ModuleRemark", DbType.String, ModuleRemark)

            Dim FeatureList As New List(Of TransferModuleInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillTransferModule(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FillTransferModule(ByVal reader As IDataReader) As TransferModuleInfo
            On Error Resume Next

            Dim ti As New TransferModuleInfo

            ti.AutoID = reader("AutoID").ToString
            ti.ModuleID = reader("ModuleID").ToString
            ti.ModuleDetail = reader("ModuleDetail").ToString

            If reader("ModuleBit") Is DBNull.Value Then
                ti.ModuleBit = Nothing
            Else
                ti.ModuleBit = reader("ModuleBit")
            End If
            If reader("ModuleTime") Is DBNull.Value Then
                ti.ModuleTime = Nothing
            Else
                ti.ModuleTime = CStr(reader("ModuleTime"))
            End If
            ti.ModuleRemark = reader("ModuleRemark").ToString
            Return ti

        End Function
    End Class

End Namespace

