Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Namespace LFERP.Library.SampleManager.SampleAlarm
    Public Class SampleAlarmController
        Friend Function FillSampleAlarm(ByVal reader As IDataReader) As SampleAlarmInfo
            On Error Resume Next
            Dim objInfo As New SampleAlarmInfo
            objInfo.SE_ID = reader("SE_ID").ToString
            objInfo.SE_OutD_ID = reader("SE_OutD_ID").ToString
            objInfo.SE_InD_ID = reader("SE_InD_ID").ToString
            objInfo.SE_AddUserID = reader("SE_AddUserID").ToString
            objInfo.SE_OutD_Dep = reader("SE_OutD_Dep").ToString
            objInfo.SE_InD_Dep = reader("SE_InD_Dep").ToString

            objInfo.SE_Qty = reader("SE_Qty")
            objInfo.SE_AddUserName = reader("SE_AddUserName").ToString
            objInfo.SE_AddDate = reader("SE_AddDate")
            objInfo.SE_OutCardID = reader("SE_OutCardID").ToString
            objInfo.SE_InCardID = reader("SE_InCardID").ToString
            objInfo.ProcessResult = reader("ProcessResult").ToString
            objInfo.AddUserID = reader("AddUserID").ToString
            objInfo.CheckBit = reader("CheckBit")
            objInfo.CheckAction = reader("CheckAction").ToString
            objInfo.CheckDate = reader("CheckDate")
            objInfo.CheckRemark = reader("CheckRemark").ToString
            objInfo.AddUserName = reader("AddUserName").ToString
            objInfo.CheckActionName = reader("CheckActionName").ToString
            objInfo.SO_SampleID = reader("SO_SampleID").ToString
            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            Return objInfo
        End Function

        Public Function SampleAlarm_GetList(ByVal SE_ID As String) As List(Of SampleAlarmInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleAlarm_GetList")

            db.AddInParameter(dbComm, "@SE_ID", DbType.String, SE_ID)

            Dim FeatureList As New List(Of SampleAlarmInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSampleAlarm(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function SampleAlarm_Delete(ByVal AutoID As String, ByVal SE_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleAlarm_Delete")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbComm, "@SE_ID", DbType.String, SE_ID)

                db.ExecuteNonQuery(dbComm)
                SampleAlarm_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SampleAlarm_Delete = False
            End Try
        End Function

        Public Function SampleAlarm_Update(ByVal objinfo As SampleAlarmInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleAlarm_Update")

                db.AddInParameter(dbComm, "@SE_ID", DbType.String, objinfo.SE_ID)
                db.AddInParameter(dbComm, "@ProcessResult", DbType.String, objinfo.ProcessResult)
                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbComm, "@ModifyDate", DbType.Date, objinfo.ModifyDate)

                db.ExecuteNonQuery(dbComm)
                SampleAlarm_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SampleAlarm_Update = False
            End Try
        End Function

        Public Function SampleAlarm_Add(ByVal objinfo As SampleAlarmInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleAlarm_Add")

                db.AddInParameter(dbComm, "@SE_ID", DbType.String, objinfo.SE_ID)
                db.AddInParameter(dbComm, "@ProcessResult", DbType.String, objinfo.ProcessResult)
                db.AddInParameter(dbComm, "@AddUserID", DbType.String, objinfo.AddUserID)
                db.AddInParameter(dbComm, "@AddDate", DbType.Date, objinfo.AddDate)

                db.ExecuteNonQuery(dbComm)
                SampleAlarm_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SampleAlarm_Add = False
            End Try
        End Function

        Public Function SampleAlarm_Check(ByVal objinfo As SampleAlarmInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleAlarm_Check")

                db.AddInParameter(dbComm, "@SE_ID", DbType.String, objinfo.SE_ID)
                db.AddInParameter(dbComm, "@CheckAction", DbType.String, objinfo.CheckAction)
                db.AddInParameter(dbComm, "@CheckDate", DbType.Date, objinfo.CheckDate)
                db.AddInParameter(dbComm, "@CheckBit", DbType.Boolean, objinfo.CheckBit)
                db.AddInParameter(dbComm, "@CheckRemark", DbType.String, objinfo.CheckRemark)

                db.ExecuteNonQuery(dbComm)
                SampleAlarm_Check = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SampleAlarm_Check = False
            End Try
        End Function
    End Class

End Namespace