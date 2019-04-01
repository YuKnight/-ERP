Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql

Namespace LFERP.Library.MrpManager.MrpMps
    Public Class MrpMpsController
        Friend Function FillMrpMps(ByVal reader As IDataReader) As MrpMpsInfo
            Dim objInfo As New MrpMpsInfo
            objInfo.MO = reader("MO").ToString
            objInfo.ForecastID = reader("ForecastID").ToString
            objInfo.CusterID = reader("CusterID").ToString
            objInfo.CusterName = reader("CusterName").ToString
            objInfo.M_Code = reader("M_Code").ToString
            If reader("ProductionQty") Is DBNull.Value Then
                objInfo.ProductionQty = Nothing
            Else
                objInfo.ProductionQty = CDbl(reader("ProductionQty").ToString)
            End If
            If reader("CheckBit") Is DBNull.Value Then
                objInfo.CheckBit = Nothing
            Else
                objInfo.CheckBit = reader("CheckBit")
            End If
            If reader("CheckDate") Is DBNull.Value Then
                objInfo.CheckDate = Nothing
            Else
                objInfo.CheckDate = Format(CDate(reader("CheckDate")), "yyyy/MM/dd")
            End If
            objInfo.CheckUserID = reader("CheckUserID").ToString
            objInfo.CheckRemarks = reader("CheckRemarks").ToString
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
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            objInfo.M_Source = reader("M_Source").ToString
            objInfo.CheckUserName = reader("CheckUserName").ToString
            objInfo.CreateUserName = reader("CreateUserName").ToString
            objInfo.ModifyUserName = reader("ModifyUserName").ToString
            Return objInfo
        End Function

        Public Function MrpMps_GetList(ByVal MO As String, ByVal M_Code As String, ByVal CheckBit As String, ByVal BeginDate As Date, ByVal EndDate As Date, ByVal CreateUserID As String, ByVal DisplayNum As Decimal) As List(Of MrpMpsInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpMps_GetList")
            If MO <> Nothing Then
                db.AddInParameter(dbComm, "@MO", DbType.String, MO)
            End If
            If M_Code <> Nothing Then
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            End If

            If CheckBit <> Nothing Then
                db.AddInParameter(dbComm, "@CheckBit", DbType.Boolean, CheckBit)
            End If

            If BeginDate <> Nothing Then
                db.AddInParameter(dbComm, "@BeginDate", DbType.Date, BeginDate)
            End If
            If EndDate <> Nothing Then
                db.AddInParameter(dbComm, "@EndDate", DbType.Date, EndDate)
            End If
            If CreateUserID <> Nothing Then
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, CreateUserID)
            End If
            db.AddInParameter(dbComm, "@DisplayNum ", DbType.Decimal, DisplayNum)
            Dim FeatureList As New List(Of MrpMpsInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMrpMps(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function MrpMps_Delete(ByVal MO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpMps_Delete")
                db.AddInParameter(dbComm, "@MO", DbType.String, MO)
                db.ExecuteNonQuery(dbComm)
                MrpMps_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpMps_Delete = False
            End Try
        End Function

        Public Function MrpMps_Update(ByVal objinfo As MrpMpsInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpMps_Update")
                db.AddInParameter(dbComm, "@MO", DbType.String, objinfo.MO)
                db.AddInParameter(dbComm, "@ForecastID", DbType.String, objinfo.ForecastID)
                db.AddInParameter(dbComm, "@CusterID", DbType.String, objinfo.CusterID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@ProductionQty", DbType.Decimal, objinfo.ProductionQty)
                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbComm, "@Remarks", DbType.String, objinfo.Remarks)
                db.ExecuteNonQuery(dbComm)
                MrpMps_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpMps_Update = False
            End Try
        End Function

        Public Function MrpMps_UpdateCheck(ByVal objInfo As MrpMpsInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpMps_UpdateCheck")
                db.AddInParameter(dbComm, "@MO", DbType.String, objInfo.MO)
                db.AddInParameter(dbComm, "@CheckBit", DbType.Boolean, objInfo.CheckBit)
                db.AddInParameter(dbComm, "@CheckUserID", DbType.String, objInfo.CheckUserID)
                db.AddInParameter(dbComm, "@CheckRemarks", DbType.String, objInfo.CheckRemarks)
                db.ExecuteNonQuery(dbComm)
                MrpMps_UpdateCheck = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:MrpMps_UpdateCheck方法出錯")
                MrpMps_UpdateCheck = False
            End Try
        End Function

        Public Function MrpMps_Add(ByVal objInfo As MrpMpsInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpMps_Add")
                db.AddInParameter(dbComm, "@MO", DbType.String, objInfo.MO)
                db.AddInParameter(dbComm, "@ForecastID", DbType.String, objInfo.ForecastID)
                db.AddInParameter(dbComm, "@CusterID", DbType.String, objInfo.CusterID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objInfo.M_Code)
                db.AddInParameter(dbComm, "@ProductionQty", DbType.Decimal, objInfo.ProductionQty)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                db.AddInParameter(dbComm, "@Remarks", DbType.String, objInfo.Remarks)
                db.ExecuteNonQuery(dbComm)
                MrpMps_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpMps_Add = False
            End Try
        End Function

        Public Function MrpMps_GetID() As String
            Try
                Dim ndate = "MO" + Format(Now(), "yyMM")
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpMps_GetID")
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    If reader.Read Then
                        Return ndate + Mid((CInt(Mid(reader("MO").ToString, 7)) + 10001), 2)
                    Else
                        Return ndate + "0001"
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:MrpMps_GetID方法出錯")
                Return Nothing
            End Try
        End Function

        Public Function MrpMps_GetGroupList(ByVal BeginNeedDate As DateTime, ByVal EndNeedDate As DateTime, ByVal GroupType As String, ByVal M_Code As String, ByVal CusterFlag As Boolean) As DataTable
            Try
                Dim ds As New DataSet
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpMps_GetGroupList")
                If BeginNeedDate <> Nothing Then
                    db.AddInParameter(dbComm, "@BeginNeedDate", DbType.Date, BeginNeedDate)
                End If
                If EndNeedDate <> Nothing Then
                    db.AddInParameter(dbComm, "@EndNeedDate", DbType.Date, EndNeedDate)
                End If
                db.AddInParameter(dbComm, "@GroupType", DbType.String, GroupType) 'GroupType為分組類型，值為week或month
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
                db.AddInParameter(dbComm, "@CusterFlag", DbType.Boolean, CusterFlag) '是否查找客戶信息
                ds = db.ExecuteDataSet(dbComm)
                If ds.Tables.Count > 0 Then
                    Return ds.Tables(0)
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "MrpMps_GetGroupList出錯")
                Return Nothing
            End Try
        End Function
    End Class
End Namespace