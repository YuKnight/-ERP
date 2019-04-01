
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql

Namespace LFERP.SystemManager.OperationLog
    Public Class OperationLogController
        Friend Function FillOperationLog(ByVal reader As IDataReader) As OperationLogInfo
            Dim objInfo As New OperationLogInfo
            objInfo.ComputerName = reader("ComputerName").ToString
            objInfo.DomainUser = reader("DomainUser").ToString
            objInfo.MAC = reader("MAC").ToString
            objInfo.UserID = reader("UserID").ToString
            objInfo.FormName = reader("FormName").ToString
            objInfo.OperationType = reader("OperationType").ToString
            If reader("BeginTime") Is DBNull.Value Then
                objInfo.BeginTime = Nothing
            Else
                objInfo.BeginTime = Format(CDate(reader("BeginTime")), "yyyy/MM/dd HH:mm:ss")
            End If
            If reader("EndTime") Is DBNull.Value Then
                objInfo.EndTime = Nothing
            Else
                objInfo.EndTime = Format(CDate(reader("EndTime")), "yyyy/MM/dd HH:mm:ss")
            End If
            objInfo.OperationNotes = reader("OperationNotes").ToString
            objInfo.UserName = reader("UserName").ToString
            If reader("BeginTime") Is DBNull.Value Or reader("EndTime") Is DBNull.Value Then
                objInfo.StaySpan = TimeSpan.Zero
            Else
                objInfo.StaySpan = objInfo.EndTime.Subtract(objInfo.BeginTime)
            End If

            Return objInfo
        End Function

        Public Function OperationLog_GetList() As List(Of OperationLogInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OperationLog_GetList")

            Dim FeatureList As New List(Of OperationLogInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOperationLog(reader))
                End While
                Return FeatureList
            End Using
        End Function


        'Public Function OperationLog_Delete(ByVal AutoID As Decimal) As Boolean
        '    Try
        '        Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
        '        Dim dbComm As DbCommand = db.GetStoredProcCommand("OperationLog_Delete")
        '        db.AddInParameter(dbComm, "@AutoID", DbType.Decimal, AutoID)
        '        db.ExecuteNonQuery(dbComm)
        '        OperationLog_Delete = True
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '        OperationLog_Delete = False
        '    End Try
        'End Function


        Public Function OperationLog_Update(ByVal objinfo As OperationLogInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OperationLog_Update")
                db.AddInParameter(dbComm, "@ComputerName", DbType.String, objinfo.ComputerName)
                db.AddInParameter(dbComm, "@DomainUser", DbType.String, objinfo.DomainUser)
                db.AddInParameter(dbComm, "@MAC", DbType.String, objinfo.MAC)
                db.AddInParameter(dbComm, "@UserID", DbType.String, objinfo.UserID)
                db.AddInParameter(dbComm, "@FormName", DbType.String, objinfo.FormName)
                db.AddInParameter(dbComm, "@OperationType", DbType.String, objinfo.OperationType) 
                db.AddInParameter(dbComm, "@OperationNotes", DbType.String, objinfo.OperationNotes)
                db.ExecuteNonQuery(dbComm)
                OperationLog_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                OperationLog_Update = False
            End Try
        End Function


        Public Function OperationLog_Add(ByVal objInfo As OperationLogInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OperationLog_Add")
                db.AddInParameter(dbComm, "@ComputerName", DbType.String, objInfo.ComputerName)
                db.AddInParameter(dbComm, "@DomainUser", DbType.String, objInfo.DomainUser)
                db.AddInParameter(dbComm, "@MAC", DbType.String, objInfo.MAC)
                db.AddInParameter(dbComm, "@UserID", DbType.String, objInfo.UserID)
                db.AddInParameter(dbComm, "@FormName", DbType.String, objInfo.FormName)
                db.AddInParameter(dbComm, "@OperationType", DbType.String, objInfo.OperationType) 
                db.AddInParameter(dbComm, "@OperationNotes", DbType.String, objInfo.OperationNotes)
                db.ExecuteNonQuery(dbComm)
                OperationLog_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                OperationLog_Add = False
            End Try
        End Function
    End Class
End Namespace