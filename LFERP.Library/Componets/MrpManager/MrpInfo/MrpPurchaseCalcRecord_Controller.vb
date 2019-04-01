Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Namespace LFERP.Library.MrpManager.MrpInfo
    Public Class MrpPurchaseCalcRecordController
        Friend Function FillMrpPurchaseCalcRecord(ByVal reader As IDataReader) As MrpPurchaseCalcRecordInfo
            Try
                Dim objInfo As New MrpPurchaseCalcRecordInfo
                objInfo.SN = reader("SN").ToString
                objInfo.MRP_ID = reader("MRP_ID").ToString
                objInfo.MRPType = reader("MRPType").ToString
                objInfo.Ware_ID = reader("Ware_ID").ToString
                objInfo.M_Code = reader("M_Code").ToString
                If reader("NeedBeginDate") Is DBNull.Value Then
                    objInfo.NeedBeginDate = Nothing
                Else
                    objInfo.NeedBeginDate = Format(CDate(reader("NeedBeginDate")), "yyyy/MM/dd")
                End If
                If reader("NeedEndDate") Is DBNull.Value Then
                    objInfo.NeedEndDate = Nothing
                Else
                    objInfo.NeedEndDate = Format(CDate(reader("NeedEndDate")), "yyyy/MM/dd")
                End If
                objInfo.ForecastID = reader("ForecastID").ToString
                objInfo.CalcType = reader("CalcType").ToString
                If reader("NeedQty") Is DBNull.Value Then
                    objInfo.NeedQty = Nothing
                Else
                    objInfo.NeedQty = CDec(reader("NeedQty").ToString)
                End If
                If reader("MRPQty") Is DBNull.Value Then
                    objInfo.MRPQty = Nothing
                Else
                    objInfo.MRPQty = CDec(reader("MRPQty").ToString)
                End If
                If reader("InventoryQty") Is DBNull.Value Then
                    objInfo.InventoryQty = Nothing
                Else
                    objInfo.InventoryQty = CDec(reader("InventoryQty").ToString)
                End If
                If reader("InTransitQty") Is DBNull.Value Then
                    objInfo.InTransitQty = Nothing
                Else
                    objInfo.InTransitQty = CDec(reader("InTransitQty").ToString)
                End If
                If reader("Inspection") Is DBNull.Value Then
                    objInfo.Inspection = Nothing
                Else
                    objInfo.Inspection = CDec(reader("Inspection").ToString)
                End If
                If reader("NoCollar") Is DBNull.Value Then
                    objInfo.NoCollar = Nothing
                Else
                    objInfo.NoCollar = CDec(reader("NoCollar").ToString)
                End If
                If reader("RetreatQty") Is DBNull.Value Then
                    objInfo.RetreatQty = Nothing
                Else
                    objInfo.RetreatQty = CDec(reader("RetreatQty").ToString)
                End If
                If reader("RelatedQty") Is DBNull.Value Then
                    objInfo.RelatedQty = Nothing
                Else
                    objInfo.RelatedQty = CDec(reader("RelatedQty").ToString)
                End If
                objInfo.CreateUserID = reader("CreateUserID").ToString
                If reader("CreateDate") Is DBNull.Value Then
                    objInfo.CreateDate = Nothing
                Else
                    objInfo.CreateDate = Format(CDate(reader("CreateDate")), "yyyy/MM/dd")
                End If
                objInfo.M_Name = reader("M_Name").ToString
                objInfo.M_Gauge = reader("M_Gauge").ToString
                objInfo.M_Unit = reader("M_Unit").ToString
                objInfo.Source = reader("Source").ToString
                objInfo.CreateUserName = reader("CreateUserName").ToString
                Return objInfo
            Catch ex As Exception
                If ex.GetType.Name.Equals("ThreadAbortException") = False Then
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:FillMrpPurchaseCalcRecord方法出錯")
                End If
                Return Nothing
            End Try
        End Function

        Public Function MrpPurchaseCalcRecord_GetList(ByVal MRP_ID As String) As List(Of MrpPurchaseCalcRecordInfo)
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseCalcRecord_GetList")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                Dim FeatureList As New List(Of MrpPurchaseCalcRecordInfo)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        FeatureList.Add(FillMrpPurchaseCalcRecord(reader))
                    End While
                    Return FeatureList
                End Using
            Catch ex As Exception
                If ex.GetType.Name.Equals("ThreadAbortException") = False Then
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:MrpPurchaseCalcRecord_GetList方法出錯")
                End If
            End Try
            Return Nothing
        End Function

        Public Function MrpPurchaseCalcRecord_Delete(ByVal AutoID As Decimal) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseCalcRecord_Delete")
                db.AddInParameter(dbComm, "@AutoID", DbType.Decimal, AutoID)
                db.ExecuteNonQuery(dbComm)
                MrpPurchaseCalcRecord_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Proc:MrpPurchaseCalcRecord_Delete出錯")
                MrpPurchaseCalcRecord_Delete = False
            End Try
        End Function

        Public Function MrpPurchaseCalcRecord_Update(ByVal objinfo As MrpPurchaseCalcRecordInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseCalcRecord_Update")
                db.AddInParameter(dbComm, "@SN", DbType.String, objinfo.SN)
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objinfo.MRP_ID)
                db.AddInParameter(dbComm, "@MRPType", DbType.Byte, objinfo.MRPType)
                db.AddInParameter(dbComm, "@Ware_ID", DbType.String, objinfo.Ware_ID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@NeedBeginDate", DbType.Date, objinfo.NeedBeginDate)
                db.AddInParameter(dbComm, "@NeedEndDate", DbType.Date, objinfo.NeedEndDate)
                db.AddInParameter(dbComm, "@ForecastID", DbType.String, objinfo.ForecastID)
                db.AddInParameter(dbComm, "@CalcType", DbType.Byte, objinfo.CalcType)
                db.AddInParameter(dbComm, "@NeedQty", DbType.Decimal, objinfo.NeedQty)
                db.AddInParameter(dbComm, "@MRPQty", DbType.Decimal, objinfo.MRPQty)
                db.AddInParameter(dbComm, "@InventoryQty", DbType.Decimal, objinfo.InventoryQty)
                db.AddInParameter(dbComm, "@InTransitQty", DbType.Decimal, objinfo.InTransitQty)
                db.AddInParameter(dbComm, "@Inspection", DbType.Decimal, objinfo.Inspection)
                db.AddInParameter(dbComm, "@NoCollar", DbType.Decimal, objinfo.NoCollar)
                db.AddInParameter(dbComm, "@RetreatQty", DbType.Decimal, objinfo.RetreatQty)
                db.AddInParameter(dbComm, "@RelatedQty", DbType.Decimal, objinfo.RelatedQty)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objinfo.CreateUserID)
                db.ExecuteNonQuery(dbComm)
                MrpPurchaseCalcRecord_Update = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Proc:MrpPurchaseCalcRecord_Update出錯")
                MrpPurchaseCalcRecord_Update = False
            End Try
        End Function

        Public Function MrpPurchaseCalcRecord_Add(ByVal objInfo As MrpPurchaseCalcRecordInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseCalcRecord_Add")
                db.AddInParameter(dbComm, "@SN", DbType.String, objInfo.SN)
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objInfo.MRP_ID)
                db.AddInParameter(dbComm, "@MRPType", DbType.Byte, objInfo.MRPType)
                db.AddInParameter(dbComm, "@Ware_ID", DbType.String, objInfo.Ware_ID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objInfo.M_Code)
                If objInfo.NeedBeginDate = Nothing Then
                    db.AddInParameter(dbComm, "@NeedBeginDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@NeedBeginDate", DbType.Date, objInfo.NeedBeginDate)
                End If
                If objInfo.NeedEndDate = Nothing Then
                    db.AddInParameter(dbComm, "@NeedEndDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@NeedEndDate", DbType.Date, objInfo.NeedEndDate)
                End If

                db.AddInParameter(dbComm, "@ForecastID", DbType.String, objInfo.ForecastID)
                db.AddInParameter(dbComm, "@CalcType", DbType.Byte, objInfo.CalcType)
                db.AddInParameter(dbComm, "@NeedQty", DbType.Decimal, objInfo.NeedQty)
                db.AddInParameter(dbComm, "@MRPQty", DbType.Decimal, objInfo.MRPQty)
                db.AddInParameter(dbComm, "@InventoryQty", DbType.Decimal, objInfo.InventoryQty)
                db.AddInParameter(dbComm, "@InTransitQty", DbType.Decimal, objInfo.InTransitQty)
                db.AddInParameter(dbComm, "@Inspection", DbType.Decimal, objInfo.Inspection)
                db.AddInParameter(dbComm, "@NoCollar", DbType.Decimal, objInfo.NoCollar)
                db.AddInParameter(dbComm, "@RetreatQty", DbType.Decimal, objInfo.RetreatQty)
                db.AddInParameter(dbComm, "@RelatedQty", DbType.Decimal, objInfo.RelatedQty)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                db.ExecuteNonQuery(dbComm)
                MrpPurchaseCalcRecord_Add = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Proc:MrpPurchaseCalcRecord_Add出錯")
                MrpPurchaseCalcRecord_Add = False
            End Try
        End Function

        Public Function MrpPurchaseCalcRecord_GetID() As String
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseCalcRecord_GetID")
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                If reader.Read Then
                    Return reader("SN").ToString
                Else
                    Return Nothing
                End If
            End Using
        End Function

    End Class
End Namespace