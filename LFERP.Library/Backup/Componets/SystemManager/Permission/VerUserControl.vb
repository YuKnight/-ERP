Imports System.data.Sql
Imports System.Data.SqlClient
Imports System.Data.Common

Namespace LFERP.VerUser

    Public Class VerUserControl

        Public Function VerUser_GetList(ByVal U_ID As String) As List(Of VerUserInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("VerUser_GetList")
            db.AddInParameter(dbComm, "@U_ID", DbType.String, U_ID)

            Dim FeatureList As New List(Of VerUserInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillVerUser(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Friend Function FillVerUser(ByVal reader As IDataReader) As VerUserInfo
            On Error Resume Next
            '對應取得的數據
            Dim objInfo As New VerUserInfo
            objInfo.U_ID = reader("U_ID").ToString
            objInfo.Ver = reader("Ver").ToString
            Return objInfo
        End Function

        Public Function VerUser_Update(ByVal objFile1 As VerUserInfo) As Boolean
            Try
                VerUser_Update = True
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("VerUser_Update")
                db.AddInParameter(dbComm, "@U_ID", DbType.String, objFile1.U_ID)
                db.AddInParameter(dbComm, "@Ver", DbType.String, objFile1.Ver)

                db.ExecuteNonQuery(dbComm)
            Catch ex As Exception
                MsgBox(ex.Message)
                VerUser_Update = False
            End Try
        End Function

        Public Function VerUserPermissionModule_GetList(ByVal PM_ID As String) As List(Of VerUserInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("VerUserPermissionModule_GetList")
            Dim FeatureList As New List(Of VerUserInfo)
            db.AddInParameter(dbComm, "@PM_ID", DbType.String, PM_ID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPVerUserPermissionModule(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Private Function FillPVerUserPermissionModule(ByVal reader As IDataReader) As VerUserInfo
            On Error Resume Next
            Dim ci As New VerUserInfo
            ci.PM_ID = reader("PM_ID").ToString()
            ci.PM_Name = reader("PM_Name").ToString()
            Return ci
        End Function

        Public Function VerUserPermissionModuleUser_GetList(ByVal PM_ID As String, ByVal U_ID As String) As List(Of VerUserInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("VerUserPermissionModuleUser_GetList")
            db.AddInParameter(dbcomm, "PM_ID", DbType.String, PM_ID)
            db.AddInParameter(dbcomm, "U_ID", DbType.String, U_ID)
            Dim PMUList As New List(Of VerUserInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    PMUList.Add(FillVerUserPermissionModuleUser(reader))
                End While
                Return PMUList
            End Using
        End Function

        Private Function FillVerUserPermissionModuleUser(ByVal reader As IDataReader) As VerUserInfo
            On Error Resume Next
            Dim VI As New VerUserInfo
            VI.PM_ID = reader("PM_ID").ToString()
            VI.U_ID = reader("U_ID").ToString()
            VI.U_Name = reader("U_Name").ToString()
            VI.Ver = reader("Ver").ToString()
            Return VI
        End Function



    End Class
End Namespace