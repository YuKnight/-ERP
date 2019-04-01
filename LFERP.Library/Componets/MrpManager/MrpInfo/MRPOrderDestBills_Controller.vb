Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql

Namespace LFERP.Library.MrpManager.MrpInfo
    Public Class MrpOrderDestBillsController

        Friend Function FillMRPOrderDestBills(ByVal reader As IDataReader) As MRPOrderDestBillsInfo
            Try
                Dim objInfo As New MRPOrderDestBillsInfo
                objInfo.MRP_ID = reader("MRP_ID").ToString
                objInfo.OD_ID = reader("OD_ID").ToString
                objInfo.MOB_ForecastID = reader("MOB_ForecastID").ToString
                If reader("MOB_NeedDate") Is DBNull.Value Then
                    objInfo.MOB_NeedDate = Nothing
                Else
                    objInfo.MOB_NeedDate = Format(CDate(reader("MOB_NeedDate")), "yyyy/MM/dd")
                End If
                objInfo.M_Code = reader("M_Code").ToString
                objInfo.M_Name = reader("M_Name").ToString
                objInfo.M_Gauge = reader("M_Gauge").ToString
                objInfo.M_Unit = reader("M_Unit").ToString
                objInfo.MOB_MRPQty = IIf(IsDBNull(reader("MOB_MRPQty")), 0, CDec(reader("MOB_MRPQty")))
                objInfo.MOB_CreateUserID = reader("MOB_CreateUserID").ToString
                If reader("MOB_CreateDate") Is DBNull.Value Then
                    objInfo.MOB_CreateDate = Nothing
                Else
                    objInfo.MOB_CreateDate = Format(CDate(reader("MOB_CreateDate")), "yyyy/MM/dd")
                End If
                objInfo.MOB_ModifyUserID = reader("MOB_ModifyUserID").ToString
                If reader("MOB_ModifyDate") Is DBNull.Value Then
                    objInfo.MOB_ModifyDate = Nothing
                Else
                    objInfo.MOB_ModifyDate = Format(CDate(reader("MOB_ModifyDate")), "yyyy/MM/dd")
                End If
                If reader("AutoID") Is DBNull.Value Then
                    objInfo.AutoID = Nothing
                Else
                    objInfo.AutoID = CDbl(reader("AutoID").ToString)
                End If
                objInfo.customerName = reader("customerName").ToString
                objInfo.Source = reader("Source").ToString
                Return objInfo

            Catch ex As Exception
                If ex.GetType.Name.Equals("ThreadAbortException") = False Then
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:FillMRPOrderDestBills方法出錯")
                End If
                Return Nothing
            End Try
        End Function

        Public Function MRPOrderDestBills_GetList(ByVal MRP_ID As String) As List(Of MRPOrderDestBillsInfo)
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MRPOrderDestBills_GetList")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                Dim FeatureList As New List(Of MRPOrderDestBillsInfo)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        FeatureList.Add(FillMRPOrderDestBills(reader))
                    End While
                    Return FeatureList
                End Using
            Catch ex As Exception
                If ex.GetType.Name.Equals("ThreadAbortException") = False Then
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:MRPOrderDestBills_GetList方法出錯")
                End If
                Return Nothing
            End Try
        End Function

        Public Function MRPOrderDestBills_Delete(ByVal AutoID As String, ByVal MRP_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MRPOrderDestBills_Delete")
                db.AddInParameter(dbComm, "@AutoID ", DbType.String, AutoID)
                db.AddInParameter(dbComm, "@MRP_ID ", DbType.String, MRP_ID)
                db.ExecuteNonQuery(dbComm)
                MRPOrderDestBills_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Proc:MRPOrderDestBills_Delete")
                MRPOrderDestBills_Delete = False
            End Try
        End Function

        Public Function MRPOrderDestBills_Update(ByVal objinfo As MRPOrderDestBillsInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MRPOrderDestBills_Update")
                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objinfo.MRP_ID)
                db.AddInParameter(dbComm, "@OD_ID", DbType.String, objinfo.OD_ID)
                db.AddInParameter(dbComm, "@MOB_ForecastID", DbType.String, objinfo.MOB_ForecastID)
                db.AddInParameter(dbComm, "@MOB_NeedDate", DbType.Date, objinfo.MOB_NeedDate)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@MOB_MRPQty", DbType.Decimal, objinfo.MOB_MRPQty)
                db.AddInParameter(dbComm, "@MOB_ModifyUserID", DbType.String, objinfo.MOB_ModifyUserID)
                db.ExecuteNonQuery(dbComm)
                MRPOrderDestBills_Update = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Proc:MRPOrderDestBills_Update")
                MRPOrderDestBills_Update = False
            End Try
        End Function

        Public Function MRPOrderDestBills_Add(ByVal objInfo As MRPOrderDestBillsInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MRPOrderDestBills_Add")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objInfo.MRP_ID)
                db.AddInParameter(dbComm, "@OD_ID", DbType.String, objInfo.OD_ID)
                db.AddInParameter(dbComm, "@MOB_ForecastID", DbType.String, objInfo.MOB_ForecastID)
                db.AddInParameter(dbComm, "@MOB_NeedDate", DbType.Date, objInfo.MOB_NeedDate)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objInfo.M_Code)
                db.AddInParameter(dbComm, "@MOB_MRPQty", DbType.Decimal, objInfo.MOB_MRPQty)
                db.AddInParameter(dbComm, "@MOB_CreateUserID", DbType.String, objInfo.MOB_CreateUserID)
                db.ExecuteNonQuery(dbComm)
                MRPOrderDestBills_Add = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Proc:MRPOrderDestBills_Add")
                MRPOrderDestBills_Add = False
            End Try
        End Function
    End Class
End Namespace