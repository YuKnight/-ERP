Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql

Namespace LFERP.Library.MrpManager.MrpCalendar
    Public Class MrpCalendarEntryController
        Friend Function FillMrpCalendarEntry(ByVal reader As IDataReader) As MrpCalendarEntryInfo
            Dim objInfo As New MrpCalendarEntryInfo
            objInfo.CalendarID = reader("CalendarID").ToString
            objInfo.CalendarDate = reader("CalendarDate").ToString
            If reader("IsWorkDay") Is DBNull.Value Then
                objInfo.IsWorkDay = Nothing
            Else
                objInfo.IsWorkDay = reader("IsWorkDay")
            End If
            Return objInfo
        End Function



        Public Function MrpCalendarEntry_GetList(ByVal CalendarID As String) As List(Of MrpCalendarEntryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpCalendarEntry_GetList")
            db.AddInParameter(dbComm, "@CalendarID", DbType.String, CalendarID)
            Dim FeatureList As New List(Of MrpCalendarEntryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMrpCalendarEntry(reader))
                End While
                Return FeatureList
            End Using
        End Function


        Public Function MrpCalendarEntry_GetTable(ByVal CalendarID As String) As DataTable
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpCalendarEntry_GetList")
            db.AddInParameter(dbComm, "@CalendarID", DbType.String, CalendarID)
            Dim ds As DataSet
            ds = db.ExecuteDataSet(dbComm)
            If ds.Tables.Count > 0 Then
                Return ds.Tables(0)
            Else
                Return Nothing
            End If
        End Function



        Public Function MrpCalendarEntry_Delete(ByVal CalendarID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpCalendarEntry_Delete")
                db.AddInParameter(dbComm, "@CalendarID", DbType.String, CalendarID)
                db.ExecuteNonQuery(dbComm)
                MrpCalendarEntry_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpCalendarEntry_Delete = False
            End Try
        End Function


        Public Function MrpCalendarEntry_Update(ByVal objinfo As MrpCalendarEntryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpCalendarEntry_Update")
                db.AddInParameter(dbComm, "@CalendarID", DbType.String, objinfo.CalendarID)
                db.AddInParameter(dbComm, "@CalendarDate", DbType.DateTime, objinfo.CalendarDate)
                db.AddInParameter(dbComm, "@IsWorkDay", DbType.Boolean, objinfo.IsWorkDay)
                db.ExecuteNonQuery(dbComm)
                MrpCalendarEntry_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpCalendarEntry_Update = False
            End Try
        End Function


        Public Function MrpCalendarEntry_Add(ByVal objInfo As MrpCalendarEntryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpCalendarEntry_Add")
                db.AddInParameter(dbComm, "@CalendarID", DbType.String, objInfo.CalendarID)
                db.AddInParameter(dbComm, "@CalendarDate", DbType.DateTime, objInfo.CalendarDate)
                db.AddInParameter(dbComm, "@IsWorkDay", DbType.Boolean, objInfo.IsWorkDay)
                db.ExecuteNonQuery(dbComm)
                MrpCalendarEntry_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpCalendarEntry_Add = False
            End Try
        End Function
    End Class
End Namespace