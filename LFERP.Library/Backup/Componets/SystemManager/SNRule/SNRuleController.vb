Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Namespace LFERP.SystemManager

    Public Class SNRuleController
        Friend Function FillSNRule(ByVal reader As IDataReader) As SNRuleInfo
            Dim objInfo As New SNRuleInfo
            objInfo.AutoID = reader("AutoID").ToString
            objInfo.CodeFormat = reader("CodeFormat").ToString
            objInfo.Name = reader("Name").ToString
            objInfo.Type = reader("Type").ToString
            objInfo.Description = reader("Description").ToString
            objInfo.Sample = reader("Sample").ToString
            objInfo.CanAlterBillNo = reader("CanAlterBillNo").ToString
            objInfo.CheckAfterSave = reader("CheckAfterSave").ToString
            objInfo.UseBillCodeRule = reader("UseBillCodeRule").ToString
            objInfo.SingleApproval = reader("SingleApproval").ToString
            objInfo.SingleUnApproval = reader("SingleUnApproval").ToString
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
            objInfo.Remarks = reader("Remarks").ToString
            Return objInfo
        End Function



        Public Function SNRule_GetList(ByVal AutoID As Decimal) As List(Of SNRuleInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SNRule_GetList")
            If AutoID <> 0 Then
                db.AddInParameter(dbComm, "@AutoID", DbType.Decimal, AutoID)
            End If
            Dim FeatureList As New List(Of SNRuleInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSNRule(reader))
                End While
                Return FeatureList
            End Using
        End Function




        Public Function SNRule_Delete(ByVal AutoID As Decimal) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SNRule_Delete")
                db.AddInParameter(dbComm, "@AutoID", DbType.Decimal, AutoID)
                db.ExecuteNonQuery(dbComm)
                SNRule_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SNRule_Delete = False
            End Try
        End Function


        Public Function SNRule_Update(ByVal objinfo As SNRuleInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SNRule_Update")
                db.AddInParameter(dbComm, "@AutoID", DbType.Decimal, objinfo.AutoID)
                db.AddInParameter(dbComm, "@CodeFormat", DbType.String, objinfo.CodeFormat)
                db.AddInParameter(dbComm, "@Name", DbType.String, objinfo.Name)
                db.AddInParameter(dbComm, "@Type", DbType.String, objinfo.Type)
                db.AddInParameter(dbComm, "@Description", DbType.String, objinfo.Description)
                db.AddInParameter(dbComm, "@Sample", DbType.String, objinfo.Sample)
                db.AddInParameter(dbComm, "@CanAlterBillNo", DbType.Int64, objinfo.CanAlterBillNo)
                db.AddInParameter(dbComm, "@CheckAfterSave", DbType.Int64, objinfo.CheckAfterSave)
                db.AddInParameter(dbComm, "@UseBillCodeRule", DbType.Int64, objinfo.UseBillCodeRule)
                db.AddInParameter(dbComm, "@SingleApproval", DbType.Int64, objinfo.SingleApproval)
                db.AddInParameter(dbComm, "@SingleUnApproval", DbType.Int64, objinfo.SingleUnApproval)
                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbComm, "@Remarks", DbType.String, objinfo.Remarks)
                db.ExecuteNonQuery(dbComm)
                SNRule_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SNRule_Update = False
            End Try
        End Function


        Public Function SNRule_Add(ByVal objInfo As SNRuleInfo) As Decimal
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SNRule_Add")
                db.AddInParameter(dbComm, "@CodeFormat", DbType.String, objInfo.CodeFormat)
                db.AddInParameter(dbComm, "@Name", DbType.String, objInfo.Name)
                db.AddInParameter(dbComm, "@Type", DbType.String, objInfo.Type)
                db.AddInParameter(dbComm, "@Description", DbType.String, objInfo.Description)
                db.AddInParameter(dbComm, "@Sample", DbType.String, objInfo.Sample)
                db.AddInParameter(dbComm, "@CanAlterBillNo", DbType.Int64, objInfo.CanAlterBillNo)
                db.AddInParameter(dbComm, "@CheckAfterSave", DbType.Int64, objInfo.CheckAfterSave)
                db.AddInParameter(dbComm, "@UseBillCodeRule", DbType.Int64, objInfo.UseBillCodeRule)
                db.AddInParameter(dbComm, "@SingleApproval", DbType.Int64, objInfo.SingleApproval)
                db.AddInParameter(dbComm, "@SingleUnApproval", DbType.Int64, objInfo.SingleUnApproval)

                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                db.AddInParameter(dbComm, "@Remarks", DbType.String, objInfo.Remarks)
                Return db.ExecuteScalar(dbComm)
            Catch ex As Exception
                MsgBox(ex.Message)
                SNRule_Add = 0
            End Try
        End Function

        Public Function SNRule_GetSN(ByVal SNRuleID As Decimal) As String
            Try
                Dim prefix As String       '前輟
                Dim snDigits As Integer    '流水號位數
                Dim maxNum As String       '單據最大編號
                Dim nowDateFormat As String
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SNRuleSub_GetList")
                db.AddInParameter(dbComm, "@SNRuleID", DbType.Decimal, SNRuleID)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    If reader.Read Then
                        prefix = reader("prefix")
                        snDigits = CInt(reader("SNDigits"))
                        nowDateFormat = Format(CDate(reader("NowDate")), reader("DateFormat").ToString)
                        'nowDateFormat = Format(Date.Now, reader("DateFormat").ToString)
                    Else
                        MsgBox("取得單據編號出錯")
                        Return Nothing
                    End If
                End Using

                dbComm = db.GetStoredProcCommand("SNRule_GetSNMaxNum")
                db.AddInParameter(dbComm, "@SNRuleID", DbType.Decimal, SNRuleID)
                db.AddInParameter(dbComm, "@NowDateFormat", DbType.String, nowDateFormat)
                'dbComm = db.GetStoredProcCommand("SNRule_GetSN")
                'db.AddInParameter(dbComm, "@SNRuleID", DbType.Decimal, SNRuleID)
                'db.AddInParameter(dbComm, "@IsUpdateMaxNum", DbType.Boolean, False)
                'db.AddInParameter(dbComm, "@NowDateFormat", DbType.String, nowDateFormat)
                maxNum = db.ExecuteScalar(dbComm).ToString
                Return prefix + nowDateFormat + maxNum.PadLeft(snDigits, "0")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        'Public Function SNRule_UpdateMaxNum(ByVal SNRuleID As Decimal) As Boolean
        '    Try  
        '        Dim nowDateFormat As String
        '        Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
        '        Dim dbComm As DbCommand = db.GetStoredProcCommand("SNRuleSub_GetList")
        '        db.AddInParameter(dbComm, "@SNRuleID", DbType.Decimal, SNRuleID)
        '        Using reader As IDataReader = db.ExecuteReader(dbComm)
        '            If reader.Read Then 
        '                nowDateFormat = Format(CDate(reader("NowDate")), reader("DateFormat").ToString)
        '            Else
        '                MsgBox("取得單據編號出錯")
        '                Return Nothing
        '            End If
        '        End Using

        '        dbComm = db.GetStoredProcCommand("SNRule_GetSN")
        '        db.AddInParameter(dbComm, "@SNRuleID", DbType.Decimal, SNRuleID)
        '        db.AddInParameter(dbComm, "@IsUpdateMaxNum", DbType.Boolean, True)
        '        db.AddInParameter(dbComm, "@NowDateFormat", DbType.String, nowDateFormat)
        '        db.ExecuteNonQuery(dbComm)
        '        SNRule_UpdateMaxNum = True
        '    Catch ex As Exception
        '        Return False
        '    End Try
        'End Function

        Public Function GetSNRecord(ByVal snRuleID As Decimal) As DataTable
            Try
                Dim str As String = "select *,(select Name from SNRule where autoID=snruleID) RuleName from SNMaxNum where snRuleID=@snRuleID"
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetSqlStringCommand(str)
                db.AddInParameter(dbComm, "@snRuleID", DbType.Decimal, snRuleID)
                Dim ds As DataSet
                ds = db.ExecuteDataSet(dbComm)
                If ds.Tables.Count > 0 Then
                    Return ds.Tables(0)
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try

        End Function
    End Class
End Namespace
