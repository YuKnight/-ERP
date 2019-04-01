Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Namespace LFERP.Library.MrpManager.MrpWareHouseInfo
    Public Class MrpWareHouseInfoEntryController
        Friend Function FillMrpWareHouseInfoEntry(ByVal reader As IDataReader) As MrpWareHouseInfoEntryInfo
            On Error Resume Next
            Dim objInfo As New MrpWareHouseInfoEntryInfo
            objInfo.Ware_ID = reader("Ware_ID").ToString
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            If reader("SourceID") Is DBNull.Value Then
                objInfo.SourceID = Nothing
            Else
                objInfo.SourceID = reader("SourceID").ToString
            End If
            objInfo.Source = reader("Source").ToString
            If reader("MP_InventoryQty") Is DBNull.Value Then
                objInfo.MP_InventoryQty = Nothing
            Else
                objInfo.MP_InventoryQty = CDec(reader("MP_InventoryQty").ToString)
            End If
            If reader("MP_InTransitQty") Is DBNull.Value Then
                objInfo.MP_InTransitQty = Nothing
            Else
                objInfo.MP_InTransitQty = CDec(reader("MP_InTransitQty").ToString)
            End If
            If reader("MP_Inspection") Is DBNull.Value Then
                objInfo.MP_Inspection = Nothing
            Else
                objInfo.MP_Inspection = CDec(reader("MP_Inspection").ToString)
            End If
            If reader("MP_NoCollar") Is DBNull.Value Then
                objInfo.MP_NoCollar = Nothing
            Else
                objInfo.MP_NoCollar = CDec(reader("MP_NoCollar").ToString)
            End If
            If reader("MP_RetreatQty") Is DBNull.Value Then
                objInfo.MP_RetreatQty = Nothing
            Else
                objInfo.MP_RetreatQty = CDec(reader("MP_RetreatQty").ToString)
            End If
            objInfo.CreateUserID = reader("CreateUserName").ToString
            If reader("CreateDate") Is DBNull.Value Then
                objInfo.CreateDate = Nothing
            Else
                objInfo.CreateDate = Format(CDate(reader("CreateDate")), "yyyy/MM/dd")
            End If
            objInfo.ModifyUserID = reader("ModifyUserName").ToString
            If reader("ModifyDate") Is DBNull.Value Then
                objInfo.ModifyDate = Nothing
            Else
                objInfo.ModifyDate = Format(CDate(reader("ModifyDate")), "yyyy/MM/dd")
            End If
            objInfo.MP_Remark = reader("MP_Remark").ToString
            objInfo.AutoID = reader("AutoID").ToString
            Return objInfo
        End Function

        Public Function MrpWareHouseInfoEntry_GetList(ByVal Ware_ID As String) As List(Of MrpWareHouseInfoEntryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpWareHouseInfoEntry_GetList")
            db.AddInParameter(dbComm, "@Ware_ID", DbType.String, Ware_ID)
            'db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            Dim FeatureList As New List(Of MrpWareHouseInfoEntryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMrpWareHouseInfoEntry(reader))
                End While
                Return FeatureList
            End Using
        End Function

        ''' <summary>
        ''' 刪除--通過WareID
        ''' </summary>
        ''' <param name="Ware_ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MrpWareHouseInfoEntry_DeleteAll(ByVal Ware_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpWareHouseInfoEntry_DeleteAll")
                db.AddInParameter(dbComm, "@Ware_ID", DbType.String, Ware_ID)

                db.ExecuteNonQuery(dbComm)
                MrpWareHouseInfoEntry_DeleteAll = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpWareHouseInfoEntry_DeleteAll = False
            End Try
        End Function
        ''' <summary>
        ''' 刪除--通過autoID
        ''' </summary>
        ''' <param name="AutoID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MrpWareHouseInfoEntry_Delete(ByVal AutoID As Double) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpWareHouseInfoEntry_Delete")
                db.AddInParameter(dbComm, "@AutoID", DbType.Double, AutoID)
                db.ExecuteNonQuery(dbComm)
                MrpWareHouseInfoEntry_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpWareHouseInfoEntry_Delete = False
            End Try
        End Function

        ''' <summary>
        ''' 更新
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MrpWareHouseInfoEntry_Update(ByVal objinfo As MrpWareHouseInfoEntryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpWareHouseInfoEntry_Update")
                db.AddInParameter(dbComm, "@Ware_ID", DbType.String, objinfo.Ware_ID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@MP_InventoryQty", DbType.Decimal, objinfo.MP_InventoryQty)
                db.AddInParameter(dbComm, "@MP_InTransitQty", DbType.Decimal, objinfo.MP_InTransitQty)
                db.AddInParameter(dbComm, "@MP_Inspection", DbType.Decimal, objinfo.MP_Inspection)
                db.AddInParameter(dbComm, "@MP_NoCollar", DbType.Decimal, objinfo.MP_NoCollar)
                db.AddInParameter(dbComm, "@MP_RetreatQty", DbType.Decimal, objinfo.MP_RetreatQty)
                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)
                If objinfo.ModifyDate = Nothing Then
                    db.AddInParameter(dbComm, "@ModifyDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@ModifyDate", DbType.Date, objinfo.ModifyDate)
                End If
                db.AddInParameter(dbComm, "@MP_Remark", DbType.String, objinfo.MP_Remark)
                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.ExecuteNonQuery(dbComm)
                MrpWareHouseInfoEntry_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpWareHouseInfoEntry_Update = False
            End Try
        End Function

        ''' <summary>
        ''' 添加
        ''' </summary>
        ''' <param name="objInfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MrpWareHouseInfoEntry_Insert(ByVal objInfo As MrpWareHouseInfoEntryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpWareHouseInfoEntry_Insert")
                db.AddInParameter(dbComm, "@Ware_ID", DbType.String, objInfo.Ware_ID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objInfo.M_Code)
                db.AddInParameter(dbComm, "@MP_InventoryQty", DbType.Decimal, objInfo.MP_InventoryQty)
                db.AddInParameter(dbComm, "@MP_InTransitQty", DbType.Decimal, objInfo.MP_InTransitQty)
                db.AddInParameter(dbComm, "@MP_Inspection", DbType.Decimal, objInfo.MP_Inspection)
                db.AddInParameter(dbComm, "@MP_NoCollar", DbType.Decimal, objInfo.MP_NoCollar)
                db.AddInParameter(dbComm, "@MP_RetreatQty", DbType.Decimal, objInfo.MP_RetreatQty)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                If objInfo.CreateDate = Nothing Then
                    db.AddInParameter(dbComm, "@CreateDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@CreateDate", DbType.Date, objInfo.CreateDate)
                End If
                db.AddInParameter(dbComm, "@MP_Remark", DbType.String, objInfo.MP_Remark)
                db.ExecuteNonQuery(dbComm)
                MrpWareHouseInfoEntry_Insert = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpWareHouseInfoEntry_Insert = False
            End Try
        End Function

    End Class
End Namespace


