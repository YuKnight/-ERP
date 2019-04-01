Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Namespace LFERP.Library.SampleManager.SampleEmailSetting
    Public Class SampleEmailSettingController
        Friend Function FillSampleEmailInfo(ByVal reader As IDataReader) As SampleEmailSettingInfo
            On Error Resume Next
            Dim objInfo As New SampleEmailSettingInfo
            objInfo.AutoID = reader("AutoID")
            objInfo.Email_UserID = reader("Email_UserID").ToString
            objInfo.Email_UserName = reader("Email_UserName").ToString
            objInfo.Email = reader("Email").ToString
            objInfo.CheckOrder = reader("CheckOrder").ToString
            objInfo.CreateUserID = reader("CreateUserID").ToString
            If reader("CreateDate") Is DBNull.Value Then
                objInfo.CreateDate = Nothing
            Else
                objInfo.CreateDate = CStr(reader("CreateDate"))
            End If
            objInfo.ModifyUserID = reader("ModifyUserID").ToString
            If reader("ModifyDate") Is DBNull.Value Then
                objInfo.ModifyDate = Nothing
            Else
                objInfo.ModifyDate = CStr(reader("ModifyDate"))
            End If
            objInfo.Remark = reader("Remark").ToString
            objInfo.StateAlarmTime = reader("StateAlarmTime").ToString
            objInfo.EndAlarmTime = reader("EndAlarmTime").ToString

            '2014-04-13  «ÀÂ@
            objInfo.StoreTime = reader("StoreTime").ToString
            objInfo.CycleTime = reader("CycleTime").ToString

            Return objInfo
        End Function

        Public Function SampleEmailSetting_GetList(ByVal AutoID As String, ByVal Email_UserID As String, ByVal Email As String, ByVal CheckOrder As String, ByVal CreateDate As String) As List(Of SampleEmailSettingInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleEmailSetting_GetList")
            dbComm.CommandTimeout = 0
            db.AddInParameter(dbComm, "@AutoID", DbType.Double, AutoID)
            db.AddInParameter(dbComm, "@Email_UserID", DbType.String, Email_UserID)
            db.AddInParameter(dbComm, "@Email", DbType.String, Email)
            db.AddInParameter(dbComm, "@CheckOrder", DbType.Int64, CheckOrder)
            db.AddInParameter(dbComm, "@CreateDate", DbType.DateTime, CreateDate)

            Dim FeatureList As New List(Of SampleEmailSettingInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSampleEmailInfo(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function SampleEmailSetting_Delete(ByVal Email_UserID As String, ByVal AutoID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleEmailSetting_Delete")
                dbComm.CommandTimeout = 0
                db.AddInParameter(dbComm, "@Email_UserID", DbType.String, Email_UserID)
                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.ExecuteNonQuery(dbComm)
                SampleEmailSetting_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SampleEmailSetting_Delete = False
            End Try
        End Function
        Public Function SampleEmailSetting_Update(ByVal objinfo As SampleEmailSettingInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleEmailSetting_Update")
                dbComm.CommandTimeout = 0
                db.AddInParameter(dbComm, "@AutoID", DbType.Double, objinfo.AutoID)
                db.AddInParameter(dbComm, "@Email_UserID", DbType.String, objinfo.Email_UserID)
                db.AddInParameter(dbComm, "@Email_UserName", DbType.String, objinfo.Email_UserName)
                db.AddInParameter(dbComm, "@Email", DbType.String, objinfo.Email)
                db.AddInParameter(dbComm, "@StateAlarmTime", DbType.Int16, objinfo.StateAlarmTime)
                db.AddInParameter(dbComm, "@EndAlarmTime", DbType.Int16, objinfo.EndAlarmTime)
                db.AddInParameter(dbComm, "@CheckOrder", DbType.Int64, objinfo.CheckOrder)
                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)
                If objinfo.ModifyDate = Nothing Then
                    db.AddInParameter(dbComm, "@ModifyDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@ModifyDate", DbType.Date, objinfo.ModifyDate)
                End If
                db.AddInParameter(dbComm, "@Remark", DbType.String, objinfo.Remark)

                ''2014-04-11  «ÀÂ@
                db.AddInParameter(dbComm, "@StoreTime", DbType.Int16, objinfo.StoreTime)
                db.AddInParameter(dbComm, "@CycleTime", DbType.Int16, objinfo.CycleTime)

                db.ExecuteNonQuery(dbComm)
                SampleEmailSetting_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SampleEmailSetting_Update = False
            End Try
        End Function
        Public Function SampleEmailSetting_Add(ByVal objInfo As SampleEmailSettingInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleEmailSetting_Add")
                dbComm.CommandTimeout = 0
                db.AddInParameter(dbComm, "@Email_UserID", DbType.String, objInfo.Email_UserID)
                db.AddInParameter(dbComm, "@Email_UserName", DbType.String, objInfo.Email_UserName)
                db.AddInParameter(dbComm, "@Email", DbType.String, objInfo.Email)
                db.AddInParameter(dbComm, "@StateAlarmTime", DbType.Int16, objInfo.StateAlarmTime)
                db.AddInParameter(dbComm, "@EndAlarmTime", DbType.Int16, objInfo.EndAlarmTime)

                db.AddInParameter(dbComm, "@CheckOrder", DbType.Int64, objInfo.CheckOrder)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                If objInfo.CreateDate = Nothing Then
                    db.AddInParameter(dbComm, "@CreateDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@CreateDate", DbType.Date, objInfo.CreateDate)
                End If
                db.AddInParameter(dbComm, "@Remark", DbType.String, objInfo.Remark)

                '2014-04-11  «ÀÂ@
                db.AddInParameter(dbComm, "@StoreTime", DbType.Int16, objInfo.StoreTime)
                db.AddInParameter(dbComm, "@CycleTime", DbType.Int16, objInfo.CycleTime)

                db.ExecuteNonQuery(dbComm)
                SampleEmailSetting_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SampleEmailSetting_Add = False
            End Try
        End Function
    End Class
End Namespace