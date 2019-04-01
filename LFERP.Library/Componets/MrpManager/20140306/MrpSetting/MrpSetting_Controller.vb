Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql

Namespace LFERP.Library.MrpManager.MrpSetting
    Public Class MrpSettingController

        Friend Function FillMrpSetting(ByVal reader As IDataReader) As MrpSettingInfo
            On Error Resume Next
            Dim objInfo As New MrpSettingInfo
            objInfo.U_ID = reader("U_ID").ToString
            objInfo.forecastBeginDate = reader("forecastBeginDate").ToString
            objInfo.forecastCheckType = reader("forecastCheckType").ToString
            objInfo.forecasstCancellation = reader("forecasstCancellation").ToString
            objInfo.forecastCreateUserID = reader("forecastCreateUserID").ToString
            objInfo.forecastBrowserBeginDate = reader("forecastBrowserBeginDate").ToString
            objInfo.forecastBrowserEndDate = reader("forecastBrowserEndDate").ToString
            objInfo.bomBeginDate = reader("bomBeginDate").ToString
            objInfo.bomProductType = reader("bomProductType").ToString
            objInfo.bomCheckType = reader("bomCheckType").ToString
            objInfo.bomDisplayType = reader("bomDisplayType").ToString
            objInfo.bomCreateUserID = reader("bomCreateUserID").ToString
            objInfo.materialBeginDate = reader("materialBeginDate").ToString
            objInfo.materialCheckType = reader("materialCheckType").ToString
            objInfo.materialWarehouse = reader("materialWarehouse").ToString
            objInfo.materialCreateUserID = reader("materialCreateUserID").ToString
            objInfo.warehouseBeginDate = reader("warehouseBeginDate").ToString
            objInfo.warehouseCheckType = reader("warehouseCheckType").ToString
            objInfo.warehouseCreateUserID = reader("warehouseCreateUserID").ToString
            objInfo.mrpInfoBeginDate = reader("mrpInfoBeginDate").ToString
            objInfo.mrpInfoCheckType = reader("mrpInfoCheckType").ToString
            objInfo.mrpInfoMrpType = reader("mrpInfoMrpType").ToString
            objInfo.mrpInfoCreateUserID = reader("mrpInfoCreateUserID").ToString
            objInfo.mrpInfoForecastCancellation = reader("mrpInfoForecastCancellation").ToString
            objInfo.mrpInfoForecastCheckType = reader("mrpInfoForecastCheckType").ToString
            objInfo.needQtyEnable = reader("needQtyEnable")
            objInfo.inventoryQtyEnable = reader("inventoryQtyEnable")
            objInfo.retreatQtyEnable = reader("retreatQtyEnable")
            objInfo.inTransitQtyEnable = reader("inTransitQtyEnable")
            objInfo.inspectionEnable = reader("inspectionEnable")
            objInfo.noCollarEnable = reader("noCollarEnable")
            objInfo.relatedQtyEnable = reader("relatedQtyEnable")
            objInfo.secInvEnable = reader("secInvEnable")
            objInfo.lowLimitEnable = reader("lowLimitEnable")
            objInfo.batFixConomyEnable = reader("batFixConomyEnable")

            If reader("createDate") Is DBNull.Value Then
                objInfo.createDate = Nothing
            Else
                objInfo.createDate = Format(CDate(reader("createDate")), "yyyy/MM/dd")
            End If
            If reader("modifyDate") Is DBNull.Value Then
                objInfo.modifyDate = Nothing
            Else
                objInfo.modifyDate = Format(CDate(reader("modifyDate")), "yyyy/MM/dd")
            End If
            Return objInfo
        End Function



        Public Function MrpSetting_GetList(ByVal U_ID As String) As List(Of MrpSettingInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpSetting_GetList")
            db.AddInParameter(dbComm, "@U_ID", DbType.String, U_ID)
            Dim FeatureList As New List(Of MrpSettingInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMrpSetting(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function MrpSetting_Delete(ByVal U_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpSetting_Delete")
                db.AddInParameter(dbComm, "@U_ID", DbType.String, U_ID)
                db.ExecuteNonQuery(dbComm)
                MrpSetting_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpSetting_Delete = False
            End Try
        End Function


        Public Function MrpSetting_Update(ByVal objinfo As MrpSettingInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpSetting_Update")
                db.AddInParameter(dbComm, "@U_ID", DbType.String, objinfo.U_ID)
                db.AddInParameter(dbComm, "@forecastBeginDate", DbType.DateTime, objinfo.forecastBeginDate)
                db.AddInParameter(dbComm, "@forecastCheckType", DbType.String, objinfo.forecastCheckType)
                db.AddInParameter(dbComm, "@forecasstCancellation", DbType.String, objinfo.forecasstCancellation)
                db.AddInParameter(dbComm, "@forecastCreateUserID", DbType.String, objinfo.forecastCreateUserID)
                db.AddInParameter(dbComm, "@forecastBrowserBeginDate", DbType.DateTime, objinfo.forecastBrowserBeginDate)
                db.AddInParameter(dbComm, "@forecastBrowserEndDate", DbType.DateTime, objinfo.forecastBrowserEndDate)
                db.AddInParameter(dbComm, "@bomBeginDate", DbType.DateTime, objinfo.bomBeginDate)
                db.AddInParameter(dbComm, "@bomProductType", DbType.String, objinfo.bomProductType)
                db.AddInParameter(dbComm, "@bomCheckType", DbType.String, objinfo.bomCheckType)
                db.AddInParameter(dbComm, "@bomDisplayType", DbType.String, objinfo.bomDisplayType)
                db.AddInParameter(dbComm, "@bomCreateUserID", DbType.String, objinfo.bomCreateUserID)
                db.AddInParameter(dbComm, "@materialBeginDate", DbType.DateTime, objinfo.materialBeginDate)
                db.AddInParameter(dbComm, "@materialCheckType", DbType.String, objinfo.materialCheckType)
                db.AddInParameter(dbComm, "@materialWarehouse", DbType.String, objinfo.materialWarehouse)
                db.AddInParameter(dbComm, "@materialCreateUserID", DbType.String, objinfo.materialCreateUserID)
                db.AddInParameter(dbComm, "@warehouseBeginDate", DbType.DateTime, objinfo.warehouseBeginDate)
                db.AddInParameter(dbComm, "@warehouseCheckType", DbType.String, objinfo.warehouseCheckType)
                db.AddInParameter(dbComm, "@warehouseCreateUserID", DbType.String, objinfo.warehouseCreateUserID)
                db.AddInParameter(dbComm, "@mrpInfoBeginDate", DbType.DateTime, objinfo.mrpInfoBeginDate)
                db.AddInParameter(dbComm, "@mrpInfoCheckType", DbType.String, objinfo.mrpInfoCheckType)
                db.AddInParameter(dbComm, "@mrpInfoMrpType", DbType.String, objinfo.mrpInfoMrpType)
                db.AddInParameter(dbComm, "@mrpInfoCreateUserID", DbType.String, objinfo.mrpInfoCreateUserID)
                db.AddInParameter(dbComm, "@mrpInfoForecastCancellation", DbType.String, objinfo.mrpInfoForecastCancellation)
                db.AddInParameter(dbComm, "@mrpInfoForecastCheckType", DbType.String, objinfo.mrpInfoForecastCheckType)
                db.AddInParameter(dbComm, "@needQtyEnable", DbType.Boolean, objinfo.needQtyEnable)
                db.AddInParameter(dbComm, "@inventoryQtyEnable", DbType.Boolean, objinfo.inventoryQtyEnable)
                db.AddInParameter(dbComm, "@retreatQtyEnable", DbType.Boolean, objinfo.retreatQtyEnable)
                db.AddInParameter(dbComm, "@inTransitQtyEnable", DbType.Boolean, objinfo.inTransitQtyEnable)
                db.AddInParameter(dbComm, "@inspectionEnable", DbType.Boolean, objinfo.inspectionEnable)
                db.AddInParameter(dbComm, "@noCollarEnable", DbType.Boolean, objinfo.noCollarEnable)
                db.AddInParameter(dbComm, "@relatedQtyEnable", DbType.Boolean, objinfo.relatedQtyEnable)
                db.AddInParameter(dbComm, "@secInvEnable", DbType.Boolean, objinfo.secInvEnable)
                db.AddInParameter(dbComm, "@lowLimitEnable", DbType.Boolean, objinfo.lowLimitEnable)
                db.AddInParameter(dbComm, "@batFixConomyEnable", DbType.Boolean, objinfo.batFixConomyEnable)
                db.ExecuteNonQuery(dbComm)
                MrpSetting_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpSetting_Update = False
            End Try
        End Function


        Public Function MrpSetting_Add(ByVal objInfo As MrpSettingInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpSetting_Add")
                db.AddInParameter(dbComm, "@U_ID", DbType.String, objInfo.U_ID)
                db.AddInParameter(dbComm, "@forecastBeginDate", DbType.DateTime, objInfo.forecastBeginDate)
                db.AddInParameter(dbComm, "@forecastCheckType", DbType.String, objInfo.forecastCheckType)
                db.AddInParameter(dbComm, "@forecasstCancellation", DbType.String, objInfo.forecasstCancellation)
                db.AddInParameter(dbComm, "@forecastCreateUserID", DbType.String, objInfo.forecastCreateUserID)
                db.AddInParameter(dbComm, "@forecastBrowserBeginDate", DbType.DateTime, objInfo.forecastBrowserBeginDate)
                db.AddInParameter(dbComm, "@forecastBrowserEndDate", DbType.DateTime, objInfo.forecastBrowserEndDate)
                db.AddInParameter(dbComm, "@bomBeginDate", DbType.DateTime, objInfo.bomBeginDate)
                db.AddInParameter(dbComm, "@bomProductType", DbType.String, objInfo.bomProductType)
                db.AddInParameter(dbComm, "@bomCheckType", DbType.String, objInfo.bomCheckType)
                db.AddInParameter(dbComm, "@bomDisplayType", DbType.String, objInfo.bomDisplayType)
                db.AddInParameter(dbComm, "@bomCreateUserID", DbType.String, objInfo.bomCreateUserID)
                db.AddInParameter(dbComm, "@materialBeginDate", DbType.DateTime, objInfo.materialBeginDate)
                db.AddInParameter(dbComm, "@materialCheckType", DbType.String, objInfo.materialCheckType)
                db.AddInParameter(dbComm, "@materialWarehouse", DbType.String, objInfo.materialWarehouse)
                db.AddInParameter(dbComm, "@materialCreateUserID", DbType.String, objInfo.materialCreateUserID)
                db.AddInParameter(dbComm, "@warehouseBeginDate", DbType.DateTime, objInfo.warehouseBeginDate)
                db.AddInParameter(dbComm, "@warehouseCheckType", DbType.String, objInfo.warehouseCheckType)
                db.AddInParameter(dbComm, "@warehouseCreateUserID", DbType.String, objInfo.warehouseCreateUserID)
                db.AddInParameter(dbComm, "@mrpInfoBeginDate", DbType.DateTime, objInfo.mrpInfoBeginDate)
                db.AddInParameter(dbComm, "@mrpInfoCheckType", DbType.String, objInfo.mrpInfoCheckType)
                db.AddInParameter(dbComm, "@mrpInfoMrpType", DbType.String, objInfo.mrpInfoMrpType)
                db.AddInParameter(dbComm, "@mrpInfoCreateUserID", DbType.String, objInfo.mrpInfoCreateUserID)
                db.AddInParameter(dbComm, "@mrpInfoForecastCancellation", DbType.String, objInfo.mrpInfoForecastCancellation)
                db.AddInParameter(dbComm, "@mrpInfoForecastCheckType", DbType.String, objInfo.mrpInfoForecastCheckType)
                db.AddInParameter(dbComm, "@needQtyEnable", DbType.Boolean, objInfo.needQtyEnable)
                db.AddInParameter(dbComm, "@inventoryQtyEnable", DbType.Boolean, objInfo.inventoryQtyEnable)
                db.AddInParameter(dbComm, "@retreatQtyEnable", DbType.Boolean, objInfo.retreatQtyEnable)
                db.AddInParameter(dbComm, "@inTransitQtyEnable", DbType.Boolean, objInfo.inTransitQtyEnable)
                db.AddInParameter(dbComm, "@inspectionEnable", DbType.Boolean, objInfo.inspectionEnable)
                db.AddInParameter(dbComm, "@noCollarEnable", DbType.Boolean, objInfo.noCollarEnable)
                db.AddInParameter(dbComm, "@relatedQtyEnable", DbType.Boolean, objInfo.relatedQtyEnable)
                db.AddInParameter(dbComm, "@secInvEnable", DbType.Boolean, objInfo.secInvEnable)
                db.AddInParameter(dbComm, "@lowLimitEnable", DbType.Boolean, objInfo.lowLimitEnable)
                db.AddInParameter(dbComm, "@batFixConomyEnable", DbType.Boolean, objInfo.batFixConomyEnable)
                db.ExecuteNonQuery(dbComm)
                MrpSetting_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpSetting_Add = False
            End Try
        End Function
    End Class
End Namespace