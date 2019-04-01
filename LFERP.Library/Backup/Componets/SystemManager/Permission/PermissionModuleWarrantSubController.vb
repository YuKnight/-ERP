Namespace LFERP.SystemManager
    Public Class PermissionModuleWarrantSubController
        ''' <summary>
        ''' 新增
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PermissionModuleWarrantSub_Add(ByVal objFile1 As PermissionModuleWarrantSubInfo) As Boolean
            '用戶模塊權限明細新增加
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PermissionModuleWarrantSub_Add")
                db.AddInParameter(dbComm, "@PMS_ID", DbType.String, objFile1.PMS_ID)
                db.AddInParameter(dbComm, "@PMWS_Value", DbType.String, objFile1.PMWS_Value)
                db.AddInParameter(dbComm, "@U_ID", DbType.String, objFile1.U_ID)
                db.ExecuteNonQuery(dbComm)
                PermissionModuleWarrantSub_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                PermissionModuleWarrantSub_Add = False

            End Try


        End Function

        ''' <summary>
        ''' 修改
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PermissionModuleWarrantSub_Update(ByVal objFile1 As PermissionModuleWarrantSubInfo) As Boolean
            '用戶模塊權限明細修改
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PermissionModuleWarrantSub_Update")
                db.AddInParameter(dbComm, "@PMS_ID", DbType.String, objFile1.PMS_ID)
                db.AddInParameter(dbComm, "@PMWS_Value", DbType.String, objFile1.PMWS_Value)
                db.AddInParameter(dbComm, "@U_ID", DbType.String, objFile1.U_ID)
                db.ExecuteNonQuery(dbComm)
                PermissionModuleWarrantSub_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                PermissionModuleWarrantSub_Update = False

            End Try


        End Function
        ''' <summary>
        ''' 刪除某單項權限
        ''' </summary>
        ''' <param name="U_ID"></param>
        ''' <param name="PMS_ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PermissionModuleWarrantSub_Delete(ByVal U_ID As String, ByVal PMS_ID As String) As Boolean
            '用戶模塊權限明細修改
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PermissionModuleWarrantSub_Delete")
                db.AddInParameter(dbComm, "@PMS_ID", DbType.String, PMS_ID)
                db.AddInParameter(dbComm, "@U_ID", DbType.String, U_ID)
                db.ExecuteNonQuery(dbComm)
                PermissionModuleWarrantSub_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                PermissionModuleWarrantSub_Delete = False

            End Try
        End Function

        ''' <summary>
        ''' 查詢
        ''' </summary>
        ''' <param name="U_ID"></param>
        ''' <param name="PMS_ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PermissionModuleWarrantSub_GetList(ByVal U_ID As String, ByVal PMS_ID As String) As List(Of PermissionModuleWarrantSubInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PermissionModuleWarrantSub_GetList")
            db.AddInParameter(dbComm, "@U_ID", DbType.String, U_ID)
            db.AddInParameter(dbComm, "@PMS_ID", DbType.String, PMS_ID)


            Dim FeatureList As New List(Of PermissionModuleWarrantSubInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPermissionModuleWarrantSub(reader))
                End While
                Return FeatureList
            End Using

        End Function
        Public Function PermissionModuleWarrantSub_Get(ByVal U_ID As String) As List(Of PermissionModuleWarrantSubInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PermissionModuleWarrantSub_Get")
            db.AddInParameter(dbComm, "@U_ID", DbType.String, U_ID)

            Dim FeatureList As New List(Of PermissionModuleWarrantSubInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPermissionModuleWarrantSub(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Friend Function FillPermissionModuleWarrantSub(ByVal reader As IDataReader) As PermissionModuleWarrantSubInfo
            '對應取得的數據
            On Error Resume Next
            Dim objInfo As New PermissionModuleWarrantSubInfo
            objInfo.U_ID = reader("U_ID").ToString
            objInfo.PMWS_Value = reader("PMWS_Value").ToString
            objInfo.PMS_ID = reader("PMS_ID").ToString

            Return objInfo
        End Function
    End Class
End Namespace