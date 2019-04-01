Imports System.Data.Common

Namespace LFERP.Library.ProductionSumTimeSetting
    Public Class ProductionSumTimeSettingControl
        Public Function ProductionSumTimeSetting_GetList(ByVal AutoID As String, ByVal StartTime As String, ByVal EndTime As String) As List(Of ProductionSumTimeSettingInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionSumTimeSetting_GetList")

            db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbComm, "@StartTime", DbType.String, StartTime)
            db.AddInParameter(dbComm, "@EndTime", DbType.String, EndTime) ' 

            Dim FeatureList As New List(Of ProductionSumTimeSettingInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionSumTimeSetting(reader))
                End While
                Return FeatureList
            End Using

        End Function



        Public Function FillProductionSumTimeSetting(ByVal reader As IDataReader) As ProductionSumTimeSettingInfo
            Dim ai As New ProductionSumTimeSettingInfo


            If reader("AutoID") Is DBNull.Value Then
                ai.AutoID = Nothing
            Else
                ai.AutoID = reader("AutoID").ToString
            End If

            If reader("StartTime") Is DBNull.Value Then
                ai.StartTime = Nothing
            Else
                ai.StartTime = reader("StartTime").ToString
            End If

            If reader("EndTime") Is DBNull.Value Then
                ai.EndTime = Nothing
            Else
                ai.EndTime = reader("EndTime").ToString
            End If

            If reader("TotalTime") Is DBNull.Value Then
                ai.TotalTime = 0
            Else
                ai.TotalTime = reader("TotalTime")
            End If


            If reader("ActionID") Is DBNull.Value Then
                ai.ActionID = Nothing
            Else
                ai.ActionID = reader("ActionID").ToString
            End If

            If reader("EndTime") Is DBNull.Value Then
                ai.EndTime = Nothing
            Else
                ai.EndTime = reader("EndTime").ToString
            End If


            If reader("ActionName") Is DBNull.Value Then
                ai.ActionName = Nothing
            Else
                ai.ActionName = reader("ActionName").ToString
            End If

            If reader("ModifyDate") Is DBNull.Value Then
                ai.ModifyDate = Nothing
            Else
                ai.ModifyDate = reader("ModifyDate").ToString
            End If





            Return ai

        End Function


        Public Function ProductionSumTimeSetting_Add(ByVal obj As ProductionSumTimeSettingInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionSumTimeSetting_Add")

                db.AddInParameter(dbcomm, "@StartTime", DbType.String, obj.StartTime)
                db.AddInParameter(dbcomm, "@EndTime", DbType.String, obj.EndTime)
                db.AddInParameter(dbcomm, "@TotalTime", DbType.Double, obj.TotalTime)

                db.AddInParameter(dbcomm, "@ActionID", DbType.String, obj.ActionID)
                db.AddInParameter(dbcomm, "@ModifyDate", DbType.String, obj.ModifyDate)

                db.ExecuteNonQuery(dbcomm)
                ProductionSumTimeSetting_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionSumTimeSetting_Add = False
            End Try
        End Function


        Public Function ProductionSumTimeSetting_Update(ByVal obj As ProductionSumTimeSettingInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionSumTimeSetting_Update")

                db.AddInParameter(dbcomm, "@AutoID", DbType.String, obj.AutoID)

                db.AddInParameter(dbcomm, "@StartTime", DbType.String, obj.StartTime)
                db.AddInParameter(dbcomm, "@EndTime", DbType.String, obj.EndTime)
                db.AddInParameter(dbcomm, "@TotalTime", DbType.Double, obj.TotalTime)

                db.AddInParameter(dbcomm, "@ActionID", DbType.String, obj.ActionID)
                db.AddInParameter(dbcomm, "@ModifyDate", DbType.String, obj.ModifyDate)

                db.ExecuteNonQuery(dbcomm)
                ProductionSumTimeSetting_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionSumTimeSetting_Update = False
            End Try
        End Function


        Public Function ProductionSumTimeSetting_Delete(ByVal AutoID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionSumTimeSetting_Delete")

                db.AddInParameter(dbcomm, "@AutoID", DbType.String, AutoID)

                db.ExecuteNonQuery(dbcomm)
                ProductionSumTimeSetting_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionSumTimeSetting_Delete = False
            End Try
        End Function


    End Class

End Namespace

