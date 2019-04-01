Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql

Namespace LFERP.SystemManager

    Public Class SNMaxNumController
        Friend Function FillSNMaxNum(ByVal reader As IDataReader) As SNMaxNumInfo
            Dim objInfo As New SNMaxNumInfo
            If reader("SNRuleID") Is DBNull.Value Then
                objInfo.SNRuleID = Nothing
            Else
                objInfo.SNRuleID = CDbl(reader("SNRuleID").ToString)
            End If
            objInfo.DateFormat = reader("DateFormat").ToString
            objInfo.MaxNum = reader("MaxNum").ToString
            Return objInfo
        End Function



        Public Function SNMaxNum_GetList(ByVal SNRuleID As Decimal, ByVal DateFormat As String) As List(Of SNMaxNumInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SNMaxNum_GetList")
            db.AddInParameter(dbComm, "@SNRuleID", DbType.Decimal, SNRuleID)
            db.AddInParameter(dbComm, "@DateFormat", DbType.String, DateFormat)
            Dim FeatureList As New List(Of SNMaxNumInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSNMaxNum(reader))
                End While
                Return FeatureList
            End Using
        End Function




        Public Function SNMaxNum_Delete(ByVal AutoID As Decimal) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SNMaxNum_Delete")
                db.AddInParameter(dbComm, "@AutoID", DbType.Decimal, AutoID)
                db.ExecuteNonQuery(dbComm)
                SNMaxNum_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SNMaxNum_Delete = False
            End Try
        End Function


        Public Function SNMaxNum_Update(ByVal objinfo As SNMaxNumInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SNMaxNum_Update")
                db.AddInParameter(dbComm, "@SNRuleID", DbType.Decimal, objinfo.SNRuleID)
                db.AddInParameter(dbComm, "@DateFormat", DbType.String, objinfo.DateFormat)
                db.AddInParameter(dbComm, "@MaxNum", DbType.Int64, objinfo.MaxNum)
                db.ExecuteNonQuery(dbComm)
                SNMaxNum_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SNMaxNum_Update = False
            End Try
        End Function


        Public Function SNMaxNum_Add(ByVal objInfo As SNMaxNumInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SNMaxNum_Add")
                db.AddInParameter(dbComm, "@SNRuleID", DbType.Decimal, objInfo.SNRuleID)
                db.AddInParameter(dbComm, "@DateFormat", DbType.String, objInfo.DateFormat)
                db.AddInParameter(dbComm, "@MaxNum", DbType.Int64, objInfo.MaxNum)
                db.ExecuteNonQuery(dbComm)
                SNMaxNum_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SNMaxNum_Add = False
            End Try
        End Function
    End Class
End Namespace