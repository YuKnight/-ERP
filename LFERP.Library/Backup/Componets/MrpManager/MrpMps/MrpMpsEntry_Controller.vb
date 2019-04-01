Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql

Namespace LFERP.Library.MrpManager.MrpMps
    Public Class MrpMpsEntryController

        Friend Function FillMrpMpsEntry(ByVal reader As IDataReader) As MrpMpsEntryInfo
            Dim objInfo As New MrpMpsEntryInfo
            objInfo.AutoID = reader("AutoID")
            objInfo.MO = reader("MO").ToString
            If reader("PlanQty") Is DBNull.Value Then
                objInfo.PlanQty = Nothing
            Else
                objInfo.PlanQty = CDbl(reader("PlanQty").ToString)
            End If
            If reader("ProducedQty") Is DBNull.Value Then
                objInfo.ProducedQty = Nothing
            Else
                objInfo.ProducedQty = CDbl(reader("ProducedQty").ToString)
            End If
            objInfo.NeedDate = Format(CDate(reader("NeedDate")), "yyyy/MM/dd")
            objInfo.WeeksNumber = reader("WeeksNumber")
            objInfo.TimeSpan = reader("TimeSpan")
            objInfo.Remarks = reader("Remarks").ToString
            If reader("CreateDate") Is DBNull.Value Then
                objInfo.CreateDate = Nothing
            Else
                objInfo.CreateDate = Format(CDate(reader("CreateDate")), "yyyy/MM/dd")
            End If
            objInfo.CreateUserID = reader("CreateUserID").ToString
            If reader("ModifyDate") Is DBNull.Value Then
                objInfo.ModifyDate = Nothing
            Else
                objInfo.ModifyDate = Format(CDate(reader("ModifyDate")), "yyyy/MM/dd")
            End If
            objInfo.ModifyUserID = reader("ModifyUserID").ToString
            Return objInfo
        End Function

        Public Function MrpMpsEntry_GetList(ByVal MO As String) As List(Of MrpMpsEntryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpMpsEntry_GetList")
            db.AddInParameter(dbComm, "@MO", DbType.String, MO)
            Dim FeatureList As New List(Of MrpMpsEntryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMrpMpsEntry(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function MrpMpsEntry_Delete(ByVal AutoID As String, ByVal MO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpMpsEntry_Delete")
                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbComm, "@MO", DbType.String, MO)
                db.ExecuteNonQuery(dbComm)
                MrpMpsEntry_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpMpsEntry_Delete = False
            End Try
        End Function


        Public Function MrpMpsEntry_Update(ByVal objinfo As MrpMpsEntryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpMpsEntry_Update")
                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@MO", DbType.String, objinfo.MO)
                db.AddInParameter(dbComm, "@PlanQty", DbType.Decimal, objinfo.PlanQty)
                db.AddInParameter(dbComm, "@ProducedQty", DbType.Decimal, objinfo.ProducedQty)
                db.AddInParameter(dbComm, "@NeedDate", DbType.DateTime, objinfo.NeedDate)
                db.AddInParameter(dbComm, "@WeeksNumber", DbType.Int32, objinfo.WeeksNumber)
                db.AddInParameter(dbComm, "@TimeSpan", DbType.String, objinfo.TimeSpan)
                db.AddInParameter(dbComm, "@Remarks", DbType.String, objinfo.Remarks)
                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)
                db.ExecuteNonQuery(dbComm)
                MrpMpsEntry_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpMpsEntry_Update = False
            End Try
        End Function


        Public Function MrpMpsEntry_Add(ByVal objInfo As MrpMpsEntryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpMpsEntry_Add")
                db.AddInParameter(dbComm, "@MO", DbType.String, objInfo.MO)
                db.AddInParameter(dbComm, "@PlanQty", DbType.Decimal, objInfo.PlanQty)
                db.AddInParameter(dbComm, "@ProducedQty", DbType.Decimal, objInfo.ProducedQty)
                db.AddInParameter(dbComm, "@NeedDate", DbType.DateTime, objInfo.NeedDate)
                db.AddInParameter(dbComm, "@WeeksNumber", DbType.Int32, objInfo.WeeksNumber)
                db.AddInParameter(dbComm, "@TimeSpan", DbType.String, objInfo.TimeSpan)
                db.AddInParameter(dbComm, "@Remarks", DbType.String, objInfo.Remarks)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                db.ExecuteNonQuery(dbComm)
                MrpMpsEntry_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpMpsEntry_Add = False
            End Try
        End Function
    End Class
End Namespace
