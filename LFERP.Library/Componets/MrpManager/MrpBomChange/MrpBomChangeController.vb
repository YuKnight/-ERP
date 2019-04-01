Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql

Namespace LFERP.Library.MrpManager.MrpBomChange
    Public Class MrpBomChangeController
        Friend Function FillMrpBomChange(ByVal reader As IDataReader) As MrpBomChangeInfo
            Dim objInfo As New MrpBomChangeInfo
            objInfo.ChangeOrderNo = reader("ChangeOrderNo").ToString
            If reader("ApplyDate") Is DBNull.Value Then
                objInfo.ApplyDate = Nothing
            Else
                objInfo.ApplyDate = Format(CDate(reader("ApplyDate")), "yyyy/MM/dd")
            End If
            objInfo.Reason = reader("Reason").ToString
            objInfo.Affect = reader("Affect").ToString
            objInfo.DealLevel = reader("DealLevel").ToString
            objInfo.DataSource = reader("DataSource").ToString
            objInfo.AffectDept = reader("AffectDept").ToString
            objInfo.Changer = reader("Changer").ToString
            objInfo.DeptDirector = reader("DeptDirector").ToString
            If reader("ExecuteDate") Is DBNull.Value Then
                objInfo.ExecuteDate = Nothing
            Else
                objInfo.ExecuteDate = Format(CDate(reader("ExecuteDate")), "yyyy/MM/dd")
            End If
            objInfo.ExecuteUserID = reader("ExecuteUserID").ToString
            If reader("IsCheck") Is DBNull.Value Then
                objInfo.IsCheck = Nothing
            Else
                objInfo.IsCheck = reader("IsCheck")
            End If
            objInfo.CheckUserID = reader("CheckUserID").ToString
            If reader("CheckDate") Is DBNull.Value Then
                objInfo.CheckDate = Nothing
            Else
                objInfo.CheckDate = Format(CDate(reader("CheckDate")), "yyyy/MM/dd")
            End If
            objInfo.CheckRemarks = reader("CheckRemarks").ToString
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
            objInfo.CreateUserName = reader("CreateUserName").ToString()
            objInfo.CheckUserName = reader("CheckUserName").ToString
            Return objInfo
        End Function

        Public Function MrpBomChange_GetList(ByVal ChangeOrderNo As String) As List(Of MrpBomChangeInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpBomChange_GetList")
            db.AddInParameter(dbComm, "@ChangeOrderNo", DbType.String, ChangeOrderNo)
            Dim FeatureList As New List(Of MrpBomChangeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMrpBomChange(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function MrpBomChange_Delete(ByVal ChangeOrderNo As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpBomChange_Delete")
                db.AddInParameter(dbComm, "@ChangeOrderNo", DbType.String, ChangeOrderNo)
                db.ExecuteNonQuery(dbComm)
                MrpBomChange_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpBomChange_Delete = False
            End Try
        End Function

        Public Function MrpBomChange_Update(ByVal objinfo As MrpBomChangeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpBomChange_Update")
                db.AddInParameter(dbComm, "@ChangeOrderNo", DbType.String, objinfo.ChangeOrderNo)
                If objinfo.ApplyDate = Nothing Then
                    db.AddInParameter(dbComm, "@ApplyDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@ApplyDate", DbType.Date, objinfo.ApplyDate)
                End If
                db.AddInParameter(dbComm, "@Reason", DbType.String, objinfo.Reason)
                db.AddInParameter(dbComm, "@Affect", DbType.String, objinfo.Affect)
                db.AddInParameter(dbComm, "@DealLevel", DbType.String, objinfo.DealLevel)
                db.AddInParameter(dbComm, "@DataSource", DbType.String, objinfo.DataSource)
                db.AddInParameter(dbComm, "@AffectDept", DbType.String, objinfo.AffectDept)
                db.AddInParameter(dbComm, "@Changer", DbType.String, objinfo.Changer)
                db.AddInParameter(dbComm, "@DeptDirector", DbType.String, objinfo.DeptDirector)
                If objinfo.ExecuteDate = Nothing Then
                    db.AddInParameter(dbComm, "@ExecuteDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@ExecuteDate", DbType.Date, objinfo.ExecuteDate)
                End If
                db.AddInParameter(dbComm, "@ExecuteUserID", DbType.String, objinfo.ExecuteUserID)
                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID) 
                db.AddInParameter(dbComm, "@Remarks", DbType.String, objinfo.Remarks)
                db.ExecuteNonQuery(dbComm)
                MrpBomChange_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpBomChange_Update = False
            End Try
        End Function

        Public Function MrpBomChange_UpdateCheck(ByVal objinfo As MrpBomChangeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpBomChange_UpdateCheck")
                db.AddInParameter(dbComm, "@ChangeOrderNo", DbType.String, objinfo.ChangeOrderNo)
                db.AddInParameter(dbComm, "@IsCheck", DbType.Boolean, objinfo.IsCheck)
                db.AddInParameter(dbComm, "@CheckUserID", DbType.String, objinfo.CheckUserID)
                db.AddInParameter(dbComm, "@CheckRemarks", DbType.String, objinfo.CheckRemarks)
                db.ExecuteNonQuery(dbComm)
                MrpBomChange_UpdateCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpBomChange_UpdateCheck = False
            End Try
        End Function

        Public Function MrpBomChange_UpdateExcute(ByVal objinfo As MrpBomChangeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr) 
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpBomChange_UpdateExcute")
                db.AddInParameter(dbComm, "@ChangeOrderNo", DbType.String, objinfo.ChangeOrderNo) 
                db.AddInParameter(dbComm, "@ExecuteUserID", DbType.String, objinfo.ExecuteUserID)
                db.ExecuteNonQuery(dbComm)
                MrpBomChange_UpdateExcute = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpBomChange_UpdateExcute = False
            End Try
        End Function

        Public Function MrpBomChange_Add(ByVal objInfo As MrpBomChangeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpBomChange_Add")
                db.AddInParameter(dbComm, "@ChangeOrderNo", DbType.String, objInfo.ChangeOrderNo)
                If objInfo.ApplyDate = Nothing Then
                    db.AddInParameter(dbComm, "@ApplyDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@ApplyDate", DbType.Date, objInfo.ApplyDate)
                End If
                db.AddInParameter(dbComm, "@Reason", DbType.String, objInfo.Reason)
                db.AddInParameter(dbComm, "@Affect", DbType.String, objInfo.Affect)
                db.AddInParameter(dbComm, "@DealLevel", DbType.String, objInfo.DealLevel)
                db.AddInParameter(dbComm, "@DataSource", DbType.String, objInfo.DataSource)
                db.AddInParameter(dbComm, "@AffectDept", DbType.String, objInfo.AffectDept)
                db.AddInParameter(dbComm, "@Changer", DbType.String, objInfo.Changer)
                db.AddInParameter(dbComm, "@DeptDirector", DbType.String, objInfo.DeptDirector)
                If objInfo.ExecuteDate = Nothing Then
                    db.AddInParameter(dbComm, "@ExecuteDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@ExecuteDate", DbType.Date, objInfo.ExecuteDate)
                End If
                db.AddInParameter(dbComm, "@ExecuteUserID", DbType.String, objInfo.ExecuteUserID) 
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                db.AddInParameter(dbComm, "@Remarks", DbType.String, objInfo.Remarks)
                db.ExecuteNonQuery(dbComm)
                MrpBomChange_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpBomChange_Add = False
            End Try
        End Function

        Public Function MrpBomChange_GetID() As String
            Try
                Dim ndate = "CN" + Format(Now(), "yyMM")
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpBomChange_GetID")
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    If reader.Read Then
                        Return ndate + Mid((CInt(Mid(reader("ChangeOrderNo").ToString, 7)) + 10001), 2)
                    Else
                        Return ndate + "0001"
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:MrpBomChange_GetID方法出錯")
                Return Nothing
            End Try
        End Function

        Public Function MrpBomChange_GetMaxVersion(ByVal Bom_Code As String) As Int16
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpBomChange_GetMaxVersion")
                db.AddInParameter(dbComm, "@Bom_Code", DbType.String, Bom_Code)
                Dim obj As Object = db.ExecuteScalar(dbComm)
                If obj Is Nothing = False Then
                    Return CInt(obj)
                End If
                Return 0
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:MrpBomChange_GetMaxVersion方法出錯")
                Return 0
            End Try
        End Function
    End Class
End Namespace
