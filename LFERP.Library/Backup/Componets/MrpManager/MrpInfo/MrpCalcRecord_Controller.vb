Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql

Namespace LFERP.Library.MrpManager.MrpInfo
    Public Class MrpCalcRecordController
        Friend Function FillMrpCalcRecord(ByVal reader As IDataReader) As MrpCalcRecordInfo
            Try
                Dim objInfo As New MrpCalcRecordInfo
                If reader("MrpCalcDateTime") Is DBNull.Value Then
                    objInfo.MrpCalcDateTime = Nothing
                Else
                    objInfo.MrpCalcDateTime = Format(CDate(reader("MrpCalcDateTime")), "yyyy/MM/dd HH:mm:ss")
                End If
                If reader("MrpCalcBeginDate") Is DBNull.Value Then
                    objInfo.MrpCalcBeginDate = Nothing
                Else
                    objInfo.MrpCalcBeginDate = Format(CDate(reader("MrpCalcBeginDate")), "yyyy/MM/dd HH:mm:ss")
                End If
                If reader("MrpCalcEndDate") Is DBNull.Value Then
                    objInfo.MrpCalcEndDate = Nothing
                Else
                    objInfo.MrpCalcEndDate = Format(CDate(reader("MrpCalcEndDate")), "yyyy/MM/dd HH:mm:ss")
                End If
                If reader("UsedTime") Is DBNull.Value Then
                    objInfo.UsedTime = Nothing
                Else
                    objInfo.UsedTime = CDbl(reader("UsedTime").ToString)
                End If
                objInfo.CreateUserID = reader("CreateUserID").ToString
                objInfo.CreateUserName = reader("CreateUserName").ToString
                objInfo.Mrp_ID = reader("Mrp_ID").ToString
                objInfo.ProductNum = IIf(IsDBNull(reader("ProductNum")), 0, reader("ProductNum").ToString)
                objInfo.PurchaseNum = IIf(IsDBNull(reader("PurchaseNum")), 0, reader("PurchaseNum").ToString)
                Return objInfo
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:FillMrpCalcRecord方法出錯")
                Return Nothing
            End Try
        End Function

        Public Function MrpCalcRecord_GetList() As List(Of MrpCalcRecordInfo)
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpCalcRecord_GetList")
                Dim FeatureList As New List(Of MrpCalcRecordInfo)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        FeatureList.Add(FillMrpCalcRecord(reader))
                    End While
                    Return FeatureList
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:MrpCalcRecord_GetList方法出錯")
                Return Nothing
            End Try
           
        End Function


        Public Function MrpCalcRecord_Delete(ByVal AutoID As Decimal) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpCalcRecord_Delete")
                db.AddInParameter(dbComm, "@AutoID", DbType.Decimal, AutoID)
                db.ExecuteNonQuery(dbComm)
                MrpCalcRecord_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:MrpCalcRecord_Delete出錯")
                MrpCalcRecord_Delete = False
            End Try
        End Function


        Public Function MrpCalcRecord_Update(ByVal objinfo As MrpCalcRecordInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpCalcRecord_Update")
                If objinfo.MrpCalcDateTime = Nothing Then
                    db.AddInParameter(dbComm, "@MrpCalcDateTime", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@MrpCalcDateTime", DbType.Date, objinfo.MrpCalcDateTime)
                End If
                If objinfo.MrpCalcBeginDate = Nothing Then
                    db.AddInParameter(dbComm, "@MrpCalcBeginDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@MrpCalcBeginDate", DbType.Date, objinfo.MrpCalcBeginDate)
                End If
                If objinfo.MrpCalcEndDate = Nothing Then
                    db.AddInParameter(dbComm, "@MrpCalcEndDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@MrpCalcEndDate", DbType.Date, objinfo.MrpCalcEndDate)
                End If
                db.AddInParameter(dbComm, "@UsedTime", DbType.Decimal, objinfo.UsedTime)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objinfo.CreateUserID)
                db.AddInParameter(dbComm, "@Mrp_ID", DbType.String, objinfo.Mrp_ID)
                db.AddInParameter(dbComm, "@ProductNum", DbType.Int64, objinfo.ProductNum)
                db.AddInParameter(dbComm, "@PurchaseNum", DbType.Int64, objinfo.PurchaseNum)
                db.ExecuteNonQuery(dbComm)
                MrpCalcRecord_Update = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:MrpCalcRecord_Update出錯")
                MrpCalcRecord_Update = False
            End Try
        End Function


        Public Function MrpCalcRecord_Add(ByVal objInfo As MrpCalcRecordInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpCalcRecord_Add")
                If objInfo.MrpCalcDateTime = Nothing Then
                    db.AddInParameter(dbComm, "@MrpCalcDateTime", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@MrpCalcDateTime", DbType.Date, objInfo.MrpCalcDateTime)
                End If
                If objInfo.MrpCalcBeginDate = Nothing Then
                    db.AddInParameter(dbComm, "@MrpCalcBeginDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@MrpCalcBeginDate", DbType.Date, objInfo.MrpCalcBeginDate)
                End If
                If objInfo.MrpCalcEndDate = Nothing Then
                    db.AddInParameter(dbComm, "@MrpCalcEndDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@MrpCalcEndDate", DbType.Date, objInfo.MrpCalcEndDate)
                End If
                db.AddInParameter(dbComm, "@UsedTime", DbType.Decimal, objInfo.UsedTime)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                db.AddInParameter(dbComm, "@Mrp_ID", DbType.String, objInfo.Mrp_ID)
                db.AddInParameter(dbComm, "@ProductNum", DbType.Int64, objInfo.ProductNum)
                db.AddInParameter(dbComm, "@PurchaseNum", DbType.Int64, objInfo.PurchaseNum)
                db.ExecuteNonQuery(dbComm)
                MrpCalcRecord_Add = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:MrpCalcRecord_Add出錯")
                MrpCalcRecord_Add = False
            End Try
        End Function
    End Class
End Namespace