Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql


Namespace LFERP.Library.MrpManager.MrpInfo
    Public Class MrpIndReqController

        Friend Function FillMrpIndReq(ByVal reader As IDataReader) As MrpIndReqInfo
            Try
                Dim objInfo As New MrpIndReqInfo
                objInfo.MRP_ID = reader("MRP_ID").ToString
                objInfo.PID = reader("PID").ToString
                objInfo.ID = reader("ID").ToString
                objInfo.sonsNum = CInt(reader("sonsNum"))
                objInfo.ForecastID = reader("ForecastID").ToString
                objInfo.NeedDate = Format(CDate(reader("NeedDate")), "yyyy/MM/dd")
                objInfo.M_Code = reader("M_Code").ToString
                If reader("NeedQty") Is DBNull.Value Then
                    objInfo.NeedQty = Nothing
                Else
                    objInfo.NeedQty = CDbl(reader("NeedQty").ToString)
                End If

                If IsDBNull(reader("InvalidDate")) Then
                    objInfo.InvalidDate = Nothing
                Else
                    objInfo.InvalidDate = Format(CDate(reader("InvalidDate")), "yyyy/MM/dd")
                End If

                objInfo.CreateUserID = reader("CreateUserID").ToString
                objInfo.ModifyUserID = reader("ModifyUserID").ToString
                objInfo.CustomerName = reader("CustomerName").ToString
                objInfo.M_Name = reader("M_Name").ToString
                objInfo.M_Gauge = reader("M_Gauge").ToString
                objInfo.M_Unit = reader("M_Unit").ToString
                objInfo.Source = reader("Source").ToString
                Return objInfo
            Catch ex As Exception
                If ex.GetType.Name.Equals("ThreadAbortException") = False Then
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:FillMrpDestBills方法出錯")
                End If
                Return Nothing
            End Try
        End Function

        Public Function MrpIndReq_GetList(ByVal MRP_ID As String) As List(Of MrpIndReqInfo)
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpIndReq_GetList")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                Dim FeatureList As New List(Of MrpIndReqInfo)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        FeatureList.Add(FillMrpIndReq(reader))
                    End While
                    Return FeatureList
                End Using
            Catch ex As Exception
                If ex.GetType.Name.Equals("ThreadAbortException") = False Then
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:MrpIndReq_GetList方法出錯")
                End If
                Return Nothing
            End Try
        End Function

        Public Function MrpIndReq_Delete(ByVal MRP_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpIndReq_Delete")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                db.ExecuteNonQuery(dbComm)
                MrpIndReq_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:MrpIndReq_Delete方法出錯")
                MrpIndReq_Delete = False
            End Try
        End Function

        Public Function MrpIndReq_Update(ByVal objinfo As MrpIndReqInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpIndReq_Update")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objinfo.MRP_ID)
                db.AddInParameter(dbComm, "@PID", DbType.String, objinfo.PID)
                db.AddInParameter(dbComm, "@ID", DbType.String, objinfo.ID)
                db.AddInParameter(dbComm, "@sonsNum", DbType.Int16, objinfo.sonsNum)
                db.AddInParameter(dbComm, "@ForecastID", DbType.String, objinfo.ForecastID)
                db.AddInParameter(dbComm, "@NeedDate", DbType.Date, objinfo.NeedDate)
                If objinfo.InvalidDate = Nothing Then
                    db.AddInParameter(dbComm, "@InvalidDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@InvalidDate", DbType.Date, objinfo.InvalidDate)
                End If
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@NeedQty", DbType.Decimal, objinfo.NeedQty)
                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)
                db.ExecuteNonQuery(dbComm)
                MrpIndReq_Update = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:MrpIndReq_Update方法出錯")
                MrpIndReq_Update = False
            End Try
        End Function

        Public Function MrpIndReq_Add(ByVal objInfo As MrpIndReqInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpIndReq_Add")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objInfo.MRP_ID)
                db.AddInParameter(dbComm, "@PID", DbType.String, objInfo.PID)
                db.AddInParameter(dbComm, "@ID", DbType.String, objInfo.ID)
                db.AddInParameter(dbComm, "@sonsNum", DbType.Int16, objInfo.sonsNum)
                db.AddInParameter(dbComm, "@ForecastID", DbType.String, objInfo.ForecastID)
                db.AddInParameter(dbComm, "@NeedDate", DbType.Date, objInfo.NeedDate)
                If objInfo.InvalidDate = Nothing Then
                    db.AddInParameter(dbComm, "@InvalidDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@InvalidDate", DbType.Date, objInfo.InvalidDate)
                End If
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objInfo.M_Code)
                db.AddInParameter(dbComm, "@NeedQty", DbType.Decimal, objInfo.NeedQty)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                db.ExecuteNonQuery(dbComm)
                MrpIndReq_Add = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:MrpIndReq_Add方法出錯")
                MrpIndReq_Add = False
            End Try
        End Function

    End Class

End Namespace