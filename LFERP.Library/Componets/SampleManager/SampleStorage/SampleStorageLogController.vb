Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Namespace LFERP.Library.SampleManager.SampleStorage
    Public Class SampleStorageLogController

        Friend Function FillSampleStorageLog(ByVal reader As IDataReader) As SampleStorageLogInfo
            On Error Resume Next
            Dim objInfo As New SampleStorageLogInfo
            objInfo.AutoID = reader("AutoID")
            objInfo.D_ID = reader("D_ID").ToString
            objInfo.Code_ID = reader("Code_ID").ToString
            objInfo.SS_StorageLocation = reader("SS_StorageLocation").ToString
            objInfo.SS_ShelveID = reader("SS_ShelveID").ToString
            objInfo.SO_ID = reader("SO_ID").ToString
            objInfo.CreateUserID = reader("CreateUserID").ToString
            If reader("CreateDate") Is DBNull.Value Then
                objInfo.CreateDate = Nothing
            Else
                objInfo.CreateDate = Format(CDate(reader("CreateDate")), "yyyy/MM/dd")
            End If
            objInfo.Remark = reader("Remark").ToString
            objInfo.OperateType = reader("OperateType").ToString
            objInfo.CreateUserName = reader("CreateUserName").ToString
            objInfo.Operate = reader("Operate").ToString
            objInfo.DepName = reader("DepName").ToString
            objInfo.SO_SampleID = reader("SO_SampleID").ToString
            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            Return objInfo
        End Function

        Public Function SampleStorageLog_GetList(ByVal AutoID As Decimal, ByVal D_ID As String, ByVal Code_ID As String, ByVal SS_ShelveID As String) As List(Of SampleStorageLogInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleStorageLog_GetList")
            dbComm.CommandTimeout = 0
            If AutoID <> 0 Then
                db.AddInParameter(dbComm, "@AutoID", DbType.Decimal, AutoID)
            End If
            db.AddInParameter(dbComm, "@Code_ID", DbType.String, Code_ID)
            db.AddInParameter(dbComm, "@SS_ShelveID", DbType.String, SS_ShelveID)
            Dim FeatureList As New List(Of SampleStorageLogInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSampleStorageLog(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function SampleStorageLog_Add(ByVal objInfo As SampleStorageLogInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleStorageLog_Add")
                dbComm.CommandTimeout = 0
                db.AddInParameter(dbComm, "@Code_ID", DbType.String, objInfo.Code_ID)
                db.AddInParameter(dbComm, "@D_ID", DbType.String, objInfo.D_ID)
                db.AddInParameter(dbComm, "@SS_StorageLocation", DbType.String, objInfo.SS_StorageLocation)
                db.AddInParameter(dbComm, "@SS_ShelveID", DbType.String, objInfo.SS_ShelveID)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                db.AddInParameter(dbComm, "@Remark", DbType.String, objInfo.Remark)
                db.AddInParameter(dbComm, "@OperateType", DbType.String, objInfo.OperateType)
                db.ExecuteNonQuery(dbComm)
                SampleStorageLog_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SampleStorageLog_Add = False
            End Try
        End Function

    End Class
End Namespace