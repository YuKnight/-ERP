
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql

Namespace LFERP.Library.MrpManager.MrpCalendar
    Public Class MrpDeptCalendarController
        Friend Function FillMrpDeptCalendar(ByVal reader As IDataReader) As MrpDeptCalendarInfo
            Dim objInfo As New MrpDeptCalendarInfo
            objInfo.DeptID = reader("DeptID").ToString
            objInfo.CalendarID = reader("CalendarID").ToString
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



        Public Function MrpDeptCalendar_GetList(ByVal DeptID As String, ByVal CalendarID As String) As List(Of MrpDeptCalendarInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpDeptCalendar_GetList")
            db.AddInParameter(dbComm, "@DeptID", DbType.String, DeptID)
            db.AddInParameter(dbComm, "@CalendarID", DbType.String, CalendarID)
            Dim FeatureList As New List(Of MrpDeptCalendarInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMrpDeptCalendar(reader))
                End While
                Return FeatureList
            End Using
        End Function




        Public Function MrpDeptCalendar_Delete(ByVal DeptID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpDeptCalendar_Delete")
                db.AddInParameter(dbComm, "@DeptID", DbType.String, DeptID)
                db.ExecuteNonQuery(dbComm)
                MrpDeptCalendar_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpDeptCalendar_Delete = False
            End Try
        End Function


        Public Function MrpDeptCalendar_Update(ByVal objinfo As MrpDeptCalendarInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpDeptCalendar_Update")
                db.AddInParameter(dbComm, "@DeptID", DbType.String, objinfo.DeptID)
                db.AddInParameter(dbComm, "@CalendarID", DbType.String, objinfo.CalendarID)
                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbComm, "@Remarks", DbType.String, objinfo.Remarks)
                db.ExecuteNonQuery(dbComm)
                MrpDeptCalendar_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpDeptCalendar_Update = False
            End Try
        End Function


        Public Function MrpDeptCalendar_Add(ByVal objInfo As MrpDeptCalendarInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpDeptCalendar_Add")
                db.AddInParameter(dbComm, "@DeptID", DbType.String, objInfo.DeptID)
                db.AddInParameter(dbComm, "@CalendarID", DbType.String, objInfo.CalendarID)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                db.AddInParameter(dbComm, "@Remarks", DbType.String, objInfo.Remarks)
                db.ExecuteNonQuery(dbComm)
                MrpDeptCalendar_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpDeptCalendar_Add = False
            End Try
        End Function
    End Class
End Namespace