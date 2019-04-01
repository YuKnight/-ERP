Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql

Namespace LFERP.Library.Positive
    Public Class PositiveQuotationController
        Friend Function FillPositiveQuotation(ByVal reader As IDataReader) As PositiveQuotationInfo
            Dim objInfo As New PositiveQuotationInfo
            objInfo.AutoID = reader("AutoID")
            objInfo.BillNo = reader("BillNo").ToString
            objInfo.CustomerID = reader("CustomerID").ToString
            objInfo.CreateUserID = reader("CreateUserID").ToString
            If reader("CreateDate") Is DBNull.Value Then
                objInfo.CreateDate = Nothing
            Else
                objInfo.CreateDate = Format(CDate(reader("CreateDate")), "yyyy/MM/dd")
            End If
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
            objInfo.ModifyUserID = reader("ModifyUserID").ToString
            If reader("ModifyDate") Is DBNull.Value Then
                objInfo.ModifyDate = Nothing
            Else
                objInfo.ModifyDate = Format(CDate(reader("ModifyDate")), "yyyy/MM/dd")
            End If
            Return objInfo
        End Function

        Public Function PositiveQuotation_GetList(ByVal BillNo As String) As List(Of PositiveQuotationInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveQuotation_GetList")
            db.AddInParameter(dbComm, "@BillNo", DbType.String, BillNo)
            Dim FeatureList As New List(Of PositiveQuotationInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPositiveQuotation(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function PositiveQuotation_GetTable(ByVal BillNo As String) As DataTable
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveQuotation_GetList")
            db.AddInParameter(dbComm, "@BillNo", DbType.String, BillNo)
            Dim ds As New DataSet
            ds = db.ExecuteDataSet(dbComm)
            If ds.Tables.Count > 0 Then
                Return ds.Tables(0)
            Else
                Return Nothing
            End If
        End Function

        Public Function PositiveQuotation_Delete(ByVal BillNo As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveQuotation_Delete")
                db.AddInParameter(dbComm, "@BillNo", DbType.String, BillNo)
                db.ExecuteNonQuery(dbComm)
                PositiveQuotation_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PositiveQuotation_Delete = False
            End Try
        End Function


        Public Function PositiveQuotation_Update(ByVal objinfo As PositiveQuotationInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveQuotation_Update")
                db.AddInParameter(dbComm, "@BillNo", DbType.String, objinfo.BillNo)
                db.AddInParameter(dbComm, "@CustomerID", DbType.String, objinfo.CustomerID)
                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)

                db.ExecuteNonQuery(dbComm)
                PositiveQuotation_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PositiveQuotation_Update = False
            End Try
        End Function

        Public Function PositiveQuotation_UpdateCheck(ByVal objinfo As PositiveQuotationInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveQuotation_UpdateCheck")
                db.AddInParameter(dbComm, "@BillNo", DbType.String, objinfo.BillNo)
                db.AddInParameter(dbComm, "@IsCheck", DbType.Boolean, objinfo.IsCheck)
                db.AddInParameter(dbComm, "@CheckUserID", DbType.String, objinfo.CheckUserID)
                db.AddInParameter(dbComm, "@CheckRemarks", DbType.String, objinfo.CheckRemarks)

                db.ExecuteNonQuery(dbComm)
                PositiveQuotation_UpdateCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PositiveQuotation_UpdateCheck = False
            End Try
        End Function

        Public Function PositiveQuotation_Add(ByVal objInfo As PositiveQuotationInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveQuotation_Add")
                db.AddInParameter(dbComm, "@BillNo", DbType.String, objInfo.BillNo)
                db.AddInParameter(dbComm, "@CustomerID", DbType.String, objInfo.CustomerID)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                db.ExecuteNonQuery(dbComm)
                PositiveQuotation_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PositiveQuotation_Add = False
            End Try
        End Function

        Public Function PositiveQuotation_GetID() As String
            Try
                Dim ndate = "BN" + Format(Now(), "yyMM")
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveQuotation_GetID")
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    If reader.Read Then
                        Return ndate + Mid((CInt(Mid(reader("BillNo").ToString, 7)) + 10001), 2)
                    Else
                        Return ndate + "0001"
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:PositiveQuotation_GetID方法出錯")
                Return Nothing
            End Try
        End Function

        ''' <summary>
        ''' 取得送貨對賬單
        ''' </summary>
        ''' <param name="objInfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Positive_GetStatement(ByVal BeginDate As Date, ByVal EndDate As Date) As DataTable
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Positive_GetStatement")
                If BeginDate <> Date.MinValue Then
                    db.AddInParameter(dbComm, "@BeginDate", DbType.Date, BeginDate)
                End If
                If EndDate <> Date.MinValue Then
                    db.AddInParameter(dbComm, "@EndDate", DbType.Date, EndDate)
                End If
                Dim ds As New DataSet
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