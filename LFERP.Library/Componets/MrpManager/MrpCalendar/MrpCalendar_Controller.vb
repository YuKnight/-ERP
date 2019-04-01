Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql

Namespace LFERP.Library.MrpManager.MrpCalendar
    Public Class MrpCalendarController
        Friend Function FillMrpCalendar(ByVal reader As IDataReader) As MrpCalendarInfo
            Dim objInfo As New MrpCalendarInfo
            objInfo.CalendarID = reader("CalendarID").ToString
            objInfo.CalendarName = reader("CalendarName").ToString
            objInfo.BeginDate = reader("BeginDate").ToString
            objInfo.EndDate = reader("EndDate").ToString
            objInfo.CreateUserID = reader("CreateUserID").ToString
            If reader("CreateDate") Is DBNull.Value Then
                objInfo.CreateDate = Nothing
            Else
                objInfo.CreateDate = Format(CDate(reader("CreateDate")), "yyyy/MM/dd")
            End If
            objInfo.ModifyUserID = reader("ModifyUserID").ToString
            If reader("ModifyDate") Is DBNull.Value Then
                objInfo.ModifyDate = Nothing
            Else
                objInfo.ModifyDate = Format(CDate(reader("ModifyDate")), "yyyy/MM/dd")
            End If
            objInfo.Remarks = reader("Remarks").ToString
            Return objInfo
        End Function



        Public Function MrpCalendar_GetList(ByVal CalendarID As String) As List(Of MrpCalendarInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpCalendar_GetList")
            db.AddInParameter(dbComm, "@CalendarID", DbType.String, CalendarID)
            Dim FeatureList As New List(Of MrpCalendarInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMrpCalendar(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function MrpDept_GetTable(ByVal DepID As String) As DataTable
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("BriName_GetList")
            db.AddInParameter(dbComm, "@DepID", DbType.String, DepID)
            Dim ds As DataSet
            ds = db.ExecuteDataSet(dbComm)
            If ds.Tables.Count > 0 Then
                Return ds.Tables(0)
            Else
                Return Nothing
            End If
        End Function

        Public Function MrpCalendar_GetTable(ByVal CalendarID As String) As DataTable
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpCalendar_GetList")
            db.AddInParameter(dbComm, "@CalendarID", DbType.String, CalendarID)
            Dim ds As DataSet
            ds = db.ExecuteDataSet(dbComm)
            If ds.Tables.Count > 0 Then
                Return ds.Tables(0)
            Else
                Return Nothing
            End If
        End Function

        'Public Function MrpCalendar_ExcuteTable(ByVal sqlString As String) As DataTable
        '    Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
        '    Dim dbComm As DbCommand = db.GetSqlStringCommand(sqlString)
        '    Dim ds As DataSet
        '    ds = db.ExecuteDataSet(dbComm)
        '    If ds.Tables.Count > 0 Then
        '        Return ds.Tables(0)
        '    Else
        '        Return Nothing
        '    End If
        'End Function


        Public Function MrpCalendar_Delete(ByVal CalendarID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpCalendar_Delete")
                db.AddInParameter(dbComm, "@CalendarID", DbType.String, CalendarID)
                db.ExecuteNonQuery(dbComm)
                MrpCalendar_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpCalendar_Delete = False
            End Try
        End Function


        Public Function MrpCalendar_Update(ByVal objinfo As MrpCalendarInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpCalendar_Update")
                db.AddInParameter(dbComm, "@CalendarID", DbType.String, objinfo.CalendarID)
                db.AddInParameter(dbComm, "@CalendarName", DbType.String, objinfo.CalendarName)
                db.AddInParameter(dbComm, "@BeginDate", DbType.DateTime, objinfo.BeginDate)
                db.AddInParameter(dbComm, "@EndDate", DbType.DateTime, objinfo.EndDate)
                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbComm, "@Remarks", DbType.String, objinfo.Remarks)
                db.ExecuteNonQuery(dbComm)
                MrpCalendar_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpCalendar_Update = False
            End Try
        End Function


        Public Function MrpCalendar_Add(ByVal objInfo As MrpCalendarInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpCalendar_Add")
                db.AddInParameter(dbComm, "@CalendarID", DbType.String, objInfo.CalendarID)
                db.AddInParameter(dbComm, "@CalendarName", DbType.String, objInfo.CalendarName)
                db.AddInParameter(dbComm, "@BeginDate", DbType.DateTime, objInfo.BeginDate)
                db.AddInParameter(dbComm, "@EndDate", DbType.DateTime, objInfo.EndDate)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                db.AddInParameter(dbComm, "@Remarks", DbType.String, objInfo.Remarks)
                db.ExecuteNonQuery(dbComm)
                MrpCalendar_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpCalendar_Add = False
            End Try
        End Function
    End Class
End Namespace