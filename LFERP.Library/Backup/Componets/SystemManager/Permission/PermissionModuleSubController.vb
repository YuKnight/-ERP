Namespace LFERP.SystemManager
    Public Class PermissionModuleSubController
        Friend Function FillPermissionModuleSub(ByVal reader As IDataReader) As PermissionModuleSubInfo
            '對應取得的數據
            On Error Resume Next
            Dim objInfo As New PermissionModuleSubInfo
            objInfo.PM_ID = reader("PM_ID").ToString
            objInfo.PMS_ID = reader("PMS_ID").ToString
            objInfo.PMS_Name = reader("PMS_Name").ToString
            objInfo.PMS_Remark = reader("PMS_Remark").ToString
            objInfo.PMS_Type = reader("PMS_Type").ToString
            objInfo.PMS_Value = reader("PMS_Value").ToString
            objInfo.PMS_ValueList = reader("PMS_ValueList").ToString

            Return objInfo
        End Function



        Public Function PermissionModuleSub_GetList(ByVal PM_ID As String, ByVal PMS_ID As String) As List(Of PermissionModuleSubInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PermissionModuleSub_GetList")
            db.AddInParameter(dbComm, "@PM_ID", DbType.String, PM_ID)
            db.AddInParameter(dbComm, "@PMS_ID", DbType.String, PMS_ID)


            Dim FeatureList As New List(Of PermissionModuleSubInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPermissionModuleSub(reader))
                End While
                Return FeatureList
            End Using


        End Function

    End Class
End Namespace