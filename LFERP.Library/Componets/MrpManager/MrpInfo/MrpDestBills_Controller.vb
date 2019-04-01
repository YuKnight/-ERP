Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql

Namespace LFERP.Library.MrpManager.MrpInfo
    Public Class MrpDestBillsController

        Friend Function FillMrpDestBills(ByVal reader As IDataReader) As MrpDestBillsInfo
            Try
                Dim objInfo As New MrpDestBillsInfo
                objInfo.AutoID = reader("AutoID").ToString
                objInfo.MRP_ID = reader("MRP_ID").ToString
                objInfo.M_Code = reader("M_Code").ToString
                objInfo.MB_MRPQty = IIf(IsDBNull(reader("MB_MRPQty")), 0, CDec(reader("MB_MRPQty")))
                objInfo.MB_CreateUserID = reader("MB_CreateUserID").ToString
                If reader("MB_CreateDate") Is DBNull.Value Then
                    objInfo.MB_CreateDate = Nothing
                Else
                    objInfo.MB_CreateDate = Format(CDate(reader("MB_CreateDate")), "yyyy/MM/dd")
                End If
                objInfo.MB_ModifyUserID = reader("MB_ModifyUserID").ToString
                If reader("MB_ModifyDate") Is DBNull.Value Then
                    objInfo.MB_ModifyDate = Nothing
                Else
                    objInfo.MB_ModifyDate = Format(CDate(reader("MB_ModifyDate")), "yyyy/MM/dd")
                End If
                objInfo.M_Name = reader("M_Name").ToString

                objInfo.M_Gauge = reader("M_Gauge").ToString
                objInfo.M_Unit = reader("M_Unit").ToString
                If reader("MP_InventoryQty") Is DBNull.Value Then
                    objInfo.MP_InventoryQty = Nothing
                Else
                    objInfo.MP_InventoryQty = CDec(reader("MP_InventoryQty"))
                End If
                objInfo.Source = reader("Source").ToString
                Return objInfo

            Catch ex As Exception
                If ex.GetType.Name.Equals("ThreadAbortException") = False Then
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:FillMrpDestBills方法出錯")
                End If
                Return Nothing
            End Try
        End Function


        Public Function MrpDestBills_GetList(ByVal MRP_ID As String) As List(Of MrpDestBillsInfo)
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpDestBills_GetList")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                Dim FeatureList As New List(Of MrpDestBillsInfo)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        FeatureList.Add(FillMrpDestBills(reader))
                    End While
                    Return FeatureList
                End Using
            Catch ex As Exception
                If ex.GetType.Name.Equals("ThreadAbortException") = False Then
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:MrpDestBills_GetList方法出錯")
                End If
                Return Nothing
            End Try
        End Function


        Public Function MrpDestBills_Delete(ByVal AutoID As String, ByVal MRP_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpDestBills_Delete")
                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                db.ExecuteNonQuery(dbComm)
                MrpDestBills_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:MrpDestBills_Delete方法出錯")
                MrpDestBills_Delete = False
            End Try
        End Function


        Public Function MrpDestBills_Update(ByVal objinfo As MrpDestBillsInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpDestBills_Update")
                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objinfo.MRP_ID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@MB_MRPQty", DbType.Decimal, objinfo.MB_MRPQty)
                db.AddInParameter(dbComm, "@MB_ModifyUserID", DbType.String, objinfo.MB_ModifyUserID)
                db.ExecuteNonQuery(dbComm)
                MrpDestBills_Update = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:MrpDestBills_Update方法出錯")
                MrpDestBills_Update = False
            End Try
        End Function


        Public Function MrpDestBills_Add(ByVal objInfo As MrpDestBillsInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpDestBills_Add")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objInfo.MRP_ID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objInfo.M_Code)
                db.AddInParameter(dbComm, "@MB_MRPQty", DbType.Decimal, objInfo.MB_MRPQty)
                db.AddInParameter(dbComm, "@MB_CreateUserID", DbType.String, objInfo.MB_CreateUserID)
                db.ExecuteNonQuery(dbComm)
                MrpDestBills_Add = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:MrpDestBills_Add方法出錯")
                MrpDestBills_Add = False
            End Try
        End Function
    End Class
End Namespace
