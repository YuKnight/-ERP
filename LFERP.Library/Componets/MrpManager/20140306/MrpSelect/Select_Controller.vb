Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Imports LFERP.Library.MrpManager.MrpMaterialCode
Imports LFERP.Library.MrpManager.MrpWareHouseInfo
Imports LFERP.Library.MrpManager.MrpForecastOrder
Imports LFERP.Library.MrpManager.Bom_M
Imports LFERP.Library.MrpManager.MrpInfo
Imports LFERP.Library.MrpManager.MrpPurchaseOrder
Imports LFERP.Library.MrpManager.MrpMps
Imports LFERP.Library.MrpManager.MrpPurchaseRecord


Namespace LFERP.Library.MrpManager.MrpSelect
    Public Class Select_Controller

#Region "字段屬性"
        Dim mmcc As New MrpMaterialCodeController
        Dim mwic As New MrpWareHouseInfoController
        Dim mfoc As New MrpForecastOrderController
        Dim mbc As New Bom_MController
        Dim mc As New MrpInfoController
        Dim mpoc As New MrpPurchaseOrderController
        Dim mmc As New MrpMpsController
        Dim mprc As New MrpPurchaseRecordController

#End Region

        '查詢物料編碼  
        Public Function MrpMaterialCode_GetList(ByVal strWhere As String) As List(Of MrpMaterialCodeInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As Data.Common.DbCommand = db.GetStoredProcCommand("MrpMaterialCode_GetList")
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)
            Dim FeatureList As New List(Of MrpMaterialCodeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(mmcc.FillMrpMaterialCode(reader))
                End While
                Return FeatureList
            End Using
        End Function


        '查詢庫存信息
        Public Function MrpWareHouseInfo_GetList(ByVal strWhere As String) As List(Of MrpWareHouseInfoInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpWareHouseInfo_GetList")
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)
            Dim FeatureList As New List(Of MrpWareHouseInfoInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(mwic.FillMrpWareHouseInfo(reader))
                End While
                Return FeatureList
            End Using
        End Function

        '查詢預測單號
        Public Function MrpForecastOrder_GetList(ByVal strWhere As String) As List(Of MrpForecastOrderInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpForecastOrder_GetList")
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)
            Dim FeatureList As New List(Of MrpForecastOrderInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(mfoc.FillMrpForecastOrder(reader))
                End While
                Return FeatureList
            End Using
        End Function

        '查詢產品結構
        Public Function MrpBom_GetList(ByVal strWhere As String) As List(Of Bom_MInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Bom_M_GetList")
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)
            Dim FeatureList As New List(Of Bom_MInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(mbc.FillBom_M(reader))
                End While
                Return FeatureList
            End Using
        End Function

        '查詢運算記錄
        Public Function MrpInfo_GetList(ByVal strWhere As String) As List(Of MrpInfoInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpInfo_GetList")
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)
            Dim FeatureList As New List(Of MrpInfoInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(mc.FillMrpInfo(reader))
                End While
                Return FeatureList
            End Using
        End Function

        '查詢采購單
        Public Function MrpPurchaseOrder_GetList(ByVal strWhere As String) As List(Of MrpPurchaseOrderInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseOrder_GetList")
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)
            Dim FeatureList As New List(Of MrpPurchaseOrderInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(mpoc.FillMrpPurchaseOrder(reader))
                End While
                Return FeatureList
            End Using
        End Function

        '查詢生產計劃
        Public Function MrpMps_GetList(ByVal strWhere As String) As List(Of MrpMpsInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpMps_GetList")
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)
            Dim FeatureList As New List(Of MrpMpsInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(mmc.FillMrpMps(reader))
                End While
                Return FeatureList
            End Using
        End Function

        '查詢請購申請
        Public Function MrpPurchaseRecord_GetList(ByVal strWhere As String) As List(Of MrpPurchaseRecordInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseRecord_GetList")
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)
            Dim FeatureList As New List(Of MrpPurchaseRecordInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(mprc.FillMrpPurchaseRecord(reader))
                End While
                Return FeatureList
            End Using
        End Function
    End Class
End Namespace
