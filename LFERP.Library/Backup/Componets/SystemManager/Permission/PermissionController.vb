Imports System
Imports System.Data
Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Imports System.Windows.Forms

Namespace LFERP.SystemManager

    Public Class PermissionController
        ''' <summary>
        ''' 項目新增
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PermissionModule_Add(ByVal objFile1 As PermissionInfo) As Boolean
            '   檢查項目是否已存在()
            Dim objSystemUserInfo As PermissionInfo = PermissionModule_Get(objFile1.PM_ID, Nothing, Nothing)
            If objSystemUserInfo Is Nothing Then

                Try
                    Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                    Dim dbComm As DbCommand = db.GetStoredProcCommand("PermissionModule_Add")
                    db.AddInParameter(dbComm, "@PM_ID", DbType.String, objFile1.PM_ID)
                    db.AddInParameter(dbComm, "@PM_PID", DbType.String, objFile1.PM_PID)
                    db.AddInParameter(dbComm, "@PM_Name", DbType.String, objFile1.PM_Name)
                    db.AddInParameter(dbComm, "@PM_Level", DbType.String, objFile1.PM_Level)
                    db.AddInParameter(dbComm, "@PM_Sub", DbType.String, objFile1.PM_Sub)
                    db.AddInParameter(dbComm, "@PM_Image", DbType.String, objFile1.PM_Image)
                    db.AddInParameter(dbComm, "@PM_SelectImage", DbType.String, objFile1.PM_SelectImage)

                    db.ExecuteNonQuery(dbComm)
                    PermissionModule_Add = True

                Catch ex As Exception
                    MsgBox(ex.Message)
                    PermissionModule_Add = False

                End Try

            Else
                MsgBox("已存在此記錄,請檢查!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            End If




        End Function

        ''' <summary>
        ''' 項目修改
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PermissionModule_Update(ByVal objFile1 As PermissionInfo) As Boolean

       
            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PermissionModule_Update")

                db.AddInParameter(dbComm, "@PM_ID", DbType.String, objFile1.PM_ID)
                db.AddInParameter(dbComm, "@PM_Name", DbType.String, objFile1.PM_Name)
                db.AddInParameter(dbComm, "@PM_PID", DbType.String, objFile1.PM_PID)
                db.AddInParameter(dbComm, "@PM_Level", DbType.String, objFile1.PM_Level)
                db.AddInParameter(dbComm, "@PM_Sub", DbType.String, objFile1.PM_Sub)
                db.AddInParameter(dbComm, "@PM_Image", DbType.String, objFile1.PM_Image)
                db.AddInParameter(dbComm, "@PM_SelectImage", DbType.String, objFile1.PM_SelectImage)

                db.ExecuteNonQuery(dbComm)
                PermissionModule_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                PermissionModule_Update = False
       
            End Try
        End Function
        ''' <summary>
        ''' 項目刪除
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PermissionModule_Delete(ByVal objFile1 As PermissionInfo) As Boolean

  
            Try


                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PermissionModule_Delete")

                db.AddInParameter(dbComm, "@PM_ID", DbType.String, objFile1.PM_ID)

                db.ExecuteNonQuery(dbComm)
                PermissionModule_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                PermissionModule_Delete = False
       
            End Try
        End Function
        ''' <summary>
        ''' 項目查詢
        ''' </summary>
        ''' <param name="PM_ID"></param>
        ''' <param name="PM_Name"></param>
        ''' <param name="PM_PID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Function PermissionModule_Get(ByVal PM_ID As String, ByVal PM_Name As String, ByVal PM_PID As String) As PermissionInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PermissionModule_Get")
            db.AddInParameter(dbComm, "@PM_ID", DbType.String, PM_ID)
            db.AddInParameter(dbComm, "@PM_Name", DbType.String, PM_Name)
            db.AddInParameter(dbComm, "@PM_PID", DbType.String, PM_PID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillPermissionModule(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function PermissionModule_GetList(ByVal PM_ID As String, ByVal PM_Name As String, ByVal PM_PID As String) As List(Of PermissionInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PermissionModule_Get")
            db.AddInParameter(dbComm, "@PM_ID", DbType.String, PM_ID)
            db.AddInParameter(dbComm, "@PM_Name", DbType.String, PM_Name)
            db.AddInParameter(dbComm, "@PM_PID", DbType.String, PM_PID)

            Dim FeatureList As New List(Of PermissionInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPermissionModule(reader))
                End While
                Return FeatureList
            End Using
        End Function



        Friend Function FillPermissionModule(ByVal reader As IDataReader) As PermissionInfo
            '對應取得的數據
            On Error Resume Next
            Dim objInfo As New PermissionInfo
            objInfo.PM_ID = reader("PM_ID").ToString
            objInfo.PM_Name = reader("PM_Name").ToString
            objInfo.PM_PID = reader("PM_PID").ToString
            objInfo.PM_Level = reader("PM_Level").ToString
            objInfo.PM_Sub = reader("PM_Sub")
            objInfo.PM_Image = reader("PM_Image").ToString
            objInfo.PM_SelectImage = reader("PM_SelectImage").ToString
            objInfo.PMU_Value = reader("PMU_Value")
            objInfo.U_ID = reader("U_ID")
            Return objInfo
        End Function
        ''' <summary>
        ''' 取得選擇工號及編號的記錄
        ''' </summary>
        ''' <param name="PM_ID"></param>
        ''' <param name="U_ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PermissionModuleUser_Get(ByVal PM_ID As String, ByVal U_ID As String) As PermissionInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PermissionModuleUser_Get")
            db.AddInParameter(dbComm, "@PM_ID", DbType.String, PM_ID)
            db.AddInParameter(dbComm, "@U_ID", DbType.String, U_ID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillPermissionModule(reader)
                End While
                Return Nothing
            End Using
        End Function
        ''' <summary>
        ''' 加載用戶的權限
        ''' </summary>
        ''' <param name="U_ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PermissionModuleUser_GetList(ByVal U_ID As String) As List(Of PermissionInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PermissionModuleUser_Get")
            db.AddInParameter(dbComm, "@U_ID", DbType.String, U_ID)
            Dim FeatureList As New List(Of PermissionInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPermissionModule(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function PermissionModuleUser_Update(ByVal objFile As PermissionInfo, ByVal U_ID As String) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PermissionModuleUser_Update")

                db.AddInParameter(dbComm, "@PM_ID", DbType.String, objFile.PM_ID)
                db.AddInParameter(dbComm, "@PM_Name", DbType.String, objFile.PM_Name)
                db.AddInParameter(dbComm, "@PM_PID", DbType.String, objFile.PM_PID)
                db.AddInParameter(dbComm, "@PM_Level", DbType.String, objFile.PM_Level)
                db.AddInParameter(dbComm, "@PM_Sub", DbType.String, objFile.PM_Sub)
                db.AddInParameter(dbComm, "@PM_Image", DbType.String, objFile.PM_Image)
                db.AddInParameter(dbComm, "@PM_SelectImage", DbType.String, objFile.PM_SelectImage)
                db.AddInParameter(dbComm, "@PMU_Value", DbType.String, objFile.PMU_Value)
                db.AddInParameter(dbComm, "@U_ID", DbType.String, U_ID)

                db.ExecuteNonQuery(dbComm)
                PermissionModuleUser_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                PermissionModuleUser_Update = False

            End Try

        End Function

        Public Function PermissionModuleUser_Delete(ByVal U_ID As String, ByVal PM_ID As String) As Boolean
            '用戶模塊權限明細修改
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PermissionModuleUser_Delete")
                db.AddInParameter(dbComm, "@PM_ID", DbType.String, PM_ID)
                db.AddInParameter(dbComm, "@U_ID", DbType.String, U_ID)
                db.ExecuteNonQuery(dbComm)
                PermissionModuleUser_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                PermissionModuleUser_Delete = False

            End Try


        End Function

    End Class
End Namespace