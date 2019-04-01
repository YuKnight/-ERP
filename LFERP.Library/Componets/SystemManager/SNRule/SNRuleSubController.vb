Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql

Namespace LFERP.SystemManager
    Public Class SNRuleSubController
        Friend Function FillSNRuleSub(ByVal reader As IDataReader) As SNRuleSubInfo
            Dim objInfo As New SNRuleSubInfo
            If reader("SNRuleID") Is DBNull.Value Then
                objInfo.SNRuleID = Nothing
            Else
                objInfo.SNRuleID = CDbl(reader("SNRuleID").ToString)
            End If
            objInfo.PreFix = reader("PreFix").ToString
            objInfo.DateFormat = reader("DateFormat").ToString
            objInfo.SNDigits = reader("SNDigits").ToString
            objInfo.SNRuleName = reader("SNRuleName").ToString
            objInfo.SNRuleType = reader("SNRuletype").ToString
            Return objInfo
        End Function



        Public Function SNRuleSub_GetList(ByVal SNRuleID As Decimal) As List(Of SNRuleSubInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SNRuleSub_GetList")
            If SNRuleID <> 0 Then
                db.AddInParameter(dbComm, "@SNRuleID", DbType.Decimal, SNRuleID)
            End If
            Dim FeatureList As New List(Of SNRuleSubInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSNRuleSub(reader))
                End While
                Return FeatureList
            End Using
        End Function




        Public Function SNRuleSub_Delete(ByVal AutoID As String, ByVal SNRuleID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SNRuleSub_Delete")
                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbComm, "@SNRuleID", DbType.String, SNRuleID)
                db.ExecuteNonQuery(dbComm)
                SNRuleSub_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SNRuleSub_Delete = False
            End Try
        End Function


        Public Function SNRuleSub_Update(ByVal objinfo As SNRuleSubInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SNRuleSub_Update") 
                db.AddInParameter(dbComm, "@SNRuleID", DbType.Decimal, objinfo.SNRuleID)
                db.AddInParameter(dbComm, "@PreFix", DbType.String, objinfo.PreFix)
                db.AddInParameter(dbComm, "@DateFormat", DbType.String, objinfo.DateFormat)
                db.AddInParameter(dbComm, "@SNDigits", DbType.Int64, objinfo.SNDigits)
                db.ExecuteNonQuery(dbComm)
                SNRuleSub_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SNRuleSub_Update = False
            End Try
        End Function


        Public Function SNRuleSub_Add(ByVal objInfo As SNRuleSubInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SNRuleSub_Add")
                db.AddInParameter(dbComm, "@SNRuleID", DbType.Decimal, objInfo.SNRuleID)
                db.AddInParameter(dbComm, "@PreFix", DbType.String, objInfo.PreFix)
                db.AddInParameter(dbComm, "@DateFormat", DbType.String, objInfo.DateFormat)
                db.AddInParameter(dbComm, "@SNDigits", DbType.Int64, objInfo.SNDigits)
                db.ExecuteNonQuery(dbComm)
                SNRuleSub_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SNRuleSub_Add = False
            End Try
        End Function
    End Class
End Namespace
