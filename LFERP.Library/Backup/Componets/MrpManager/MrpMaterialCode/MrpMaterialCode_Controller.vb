Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Imports LFERP.Library.MrpManager.Bom_M
Namespace LFERP.Library.MrpManager.MrpMaterialCode
    Public Class MrpMaterialCodeController

        Friend Function FillMrpMaterialCode(ByVal reader As IDataReader) As MrpMaterialCodeInfo
            Dim objInfo As New MrpMaterialCodeInfo
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString

            If reader("MC_BatchQty") Is DBNull.Value Then
                objInfo.MC_BatchQty = Nothing
            Else
                objInfo.MC_BatchQty = CDbl(reader("MC_BatchQty").ToString)
            End If

            If reader("MC_BatFixEconomy") Is DBNull.Value Then
                objInfo.MC_BatFixEconomy = Nothing
            Else
                objInfo.MC_BatFixEconomy = CDbl(reader("MC_BatFixEconomy").ToString)
            End If

            objInfo.MC_OrderInterVal = reader("MC_OrderInterVal").ToString

            objInfo.MC_OrderMan = reader("MC_OrderMan").ToString

            If reader("MC_QtyMax") Is DBNull.Value Then
                objInfo.MC_QtyMax = Nothing
            Else
                objInfo.MC_QtyMax = CDbl(reader("MC_QtyMax").ToString)
            End If
            If reader("MC_QtyMin") Is DBNull.Value Then
                objInfo.MC_QtyMin = Nothing
            Else
                objInfo.MC_QtyMin = CDbl(reader("MC_QtyMin").ToString)
            End If
            If reader("MC_LowLimit") Is DBNull.Value Then
                objInfo.MC_LowLimit = Nothing
            Else
                objInfo.MC_LowLimit = CDbl(reader("MC_LowLimit").ToString)
            End If
            If reader("MC_SecInv") Is DBNull.Value Then
                objInfo.MC_SecInv = Nothing
            Else
                objInfo.MC_SecInv = CDbl(reader("MC_SecInv").ToString)
            End If
            objInfo.MC_Source = reader("Source").ToString
            objInfo.MC_SourceID = reader("MC_Source").ToString
            If reader("MC_MRPCon") Is DBNull.Value Then
                objInfo.MC_MRPCon = Nothing
            Else
                objInfo.MC_MRPCon = reader("MC_MRPCon")
            End If
            objInfo.MC_WH_ID = reader("MC_WH_ID").ToString
            objInfo.MC_WH_Name = reader("MC_WH_Name").ToString
            objInfo.CheckUserID = reader("CheckUserName").ToString
            If reader("CheckBit") Is DBNull.Value Then
                objInfo.CheckBit = Nothing
            Else
                objInfo.CheckBit = reader("CheckBit")
            End If
            objInfo.CheckRemark = reader("CheckRemark").ToString
            objInfo.CreateUserID = reader("CreateUserName").ToString
            If reader("CreateDate") Is DBNull.Value Then
                objInfo.CreateDate = Nothing
            Else
                objInfo.CreateDate = CStr(reader("CreateDate"))
            End If
            If reader("CheckDate") Is DBNull.Value Then
                objInfo.CheckDate = Nothing
            Else
                objInfo.CheckDate = CStr(reader("CheckDate"))
            End If

            objInfo.ModifyUserID = reader("ModifyUserName").ToString
            If reader("ModifyDate") Is DBNull.Value Then
                objInfo.ModifyDate = Nothing
            Else
                objInfo.ModifyDate = CStr(reader("ModifyDate"))
            End If
            objInfo.MC_Remark = reader("MC_Remark").ToString
            objInfo.MC_OrderRemark = reader("MC_OrderRemark").ToString
            objInfo.MC_WareHouseRemark = reader("MC_WareHouseRemark").ToString
            objInfo.M_Supplier = reader("M_Supplier").ToString
            objInfo.M_SupplierName = reader("M_SupplierName").ToString

            objInfo.AutoID = reader("AutoID")
            Return objInfo
        End Function

        Public Function MrpMaterialCode_GetList(ByVal M_Code As String, ByVal CreateDate As String, ByVal CheckBit As String, ByVal CreateUserID As String, ByVal MC_WH_ID As String, ByVal MC_Source As String, ByVal BeginDate As String, ByVal EndDate As String, ByVal M_Supplier As String, ByVal DisplayNum As Decimal) As List(Of MrpMaterialCodeInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpMaterialCode_GetList")
            If M_Code <> Nothing Then
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            End If
            If CreateDate <> Nothing Then
                db.AddInParameter(dbComm, "@CreateDate", DbType.DateTime, CreateDate)
            End If
            If CreateUserID <> Nothing Then
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, CreateUserID)
            End If
            If CheckBit <> Nothing Then
                db.AddInParameter(dbComm, "@CheckBit", DbType.Boolean, CheckBit)
            End If

            If MC_WH_ID <> Nothing Then
                db.AddInParameter(dbComm, "@MC_WH_ID", DbType.String, MC_WH_ID)
            End If
            If MC_Source <> Nothing Then
                db.AddInParameter(dbComm, "@MC_Source", DbType.String, MC_Source)
            End If
            If BeginDate <> Nothing Then
                db.AddInParameter(dbComm, "@BeginDate", DbType.DateTime, BeginDate)
            End If
            If EndDate <> Nothing Then
                db.AddInParameter(dbComm, "@EndDate", DbType.DateTime, EndDate)
            End If
            If M_Supplier <> Nothing Then
                db.AddInParameter(dbComm, "@M_Supplier", DbType.String, M_Supplier)
            End If
            db.AddInParameter(dbComm, "@DisplayNum ", DbType.Decimal, DisplayNum)
            Try
                Dim FeatureList As New List(Of MrpMaterialCodeInfo)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        FeatureList.Add(FillMrpMaterialCode(reader))
                    End While
                    Return FeatureList
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "MrpMaterialCode_GetList方法出錯")
                Return Nothing
            End Try
        End Function
        Public Function MrpMaterialCode_GetListByChecked()
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpMaterialCode_GetListByChecked")
            Try
                Dim FeatureList As New List(Of MrpMaterialCodeInfo)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        FeatureList.Add(FillMrpMaterialCode(reader))
                    End While
                    Return FeatureList
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "MrpMaterialCode_GetListByChecked方法出錯")
                Return Nothing
            End Try
        End Function

        Friend Function FillWareHouseInfo(ByVal reader As IDataReader) As MrpMaterialCodeInfo
            Dim objInfo As New MrpMaterialCodeInfo
            objInfo.MC_WH_ID = reader("WH_ID").ToString
            objInfo.MC_WH_Name = reader("WH_Name").ToString
            Return objInfo
        End Function

        Friend Function FillSource(ByVal reader As IDataReader) As MrpMaterialCodeInfo
            Dim objInfo As New MrpMaterialCodeInfo
            objInfo.MC_SourceID = reader("SourceID").ToString
            objInfo.MC_Source = reader("Source").ToString
            Return objInfo
        End Function
        Public Function MrpMaterialCode_Insert(ByVal objInfo As MrpMaterialCodeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpMaterialCode_Insert")
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objInfo.M_Code)
                db.AddInParameter(dbComm, "@MC_BatchQty", DbType.Double, objInfo.MC_BatchQty)
                db.AddInParameter(dbComm, "@MC_BatFixEconomy", DbType.Double, objInfo.MC_BatFixEconomy)
                db.AddInParameter(dbComm, "@MC_OrderInterVal", DbType.Int64, objInfo.MC_OrderInterVal)
                db.AddInParameter(dbComm, "@MC_OrderMan", DbType.String, objInfo.MC_OrderMan)
                db.AddInParameter(dbComm, "@MC_QtyMax", DbType.Double, objInfo.MC_QtyMax)
                db.AddInParameter(dbComm, "@MC_QtyMin", DbType.Double, objInfo.MC_QtyMin)
                db.AddInParameter(dbComm, "@MC_LowLimit", DbType.Double, objInfo.MC_LowLimit)
                db.AddInParameter(dbComm, "@MC_SecInv", DbType.Double, objInfo.MC_SecInv)
                db.AddInParameter(dbComm, "@MC_Source", DbType.String, objInfo.MC_Source)
                db.AddInParameter(dbComm, "@MC_MRPCon", DbType.Boolean, objInfo.MC_MRPCon)
                db.AddInParameter(dbComm, "@MC_WH_ID", DbType.String, objInfo.MC_WH_ID)
                db.AddInParameter(dbComm, "@CheckBit", DbType.String, objInfo.CheckBit)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                If objInfo.CreateDate = Nothing Then
                    db.AddInParameter(dbComm, "@CreateDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@CreateDate", DbType.Date, objInfo.CreateDate)
                End If
                db.AddInParameter(dbComm, "@MC_Remark", DbType.String, objInfo.MC_Remark)
                db.AddInParameter(dbComm, "@MC_OrderRemark", DbType.String, objInfo.MC_OrderRemark)
                db.AddInParameter(dbComm, "@MC_WareHouseRemark", DbType.String, objInfo.MC_WareHouseRemark)
                db.AddInParameter(dbComm, "@M_Supplier", DbType.String, objInfo.M_Supplier)

                db.ExecuteNonQuery(dbComm)
                MrpMaterialCode_Insert = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpMaterialCode_Insert = False
            End Try
        End Function
        Public Function MrpMaterialCode_Supplier(ByVal objinfo As MrpMaterialCodeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpMaterialCode_Supplier")
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@MC_BatchQty", DbType.Double, objinfo.MC_BatchQty)
                db.AddInParameter(dbComm, "@MC_BatFixEconomy", DbType.Double, objinfo.MC_BatFixEconomy)
                db.AddInParameter(dbComm, "@MC_OrderInterVal", DbType.Int64, objinfo.MC_OrderInterVal)
                db.AddInParameter(dbComm, "@MC_OrderMan", DbType.String, objinfo.MC_OrderMan)
                db.AddInParameter(dbComm, "@MC_QtyMax", DbType.Double, objinfo.MC_QtyMax)
                db.AddInParameter(dbComm, "@MC_QtyMin", DbType.Double, objinfo.MC_QtyMin)

                db.AddInParameter(dbComm, "@M_Supplier", DbType.String, objinfo.M_Supplier)
                db.ExecuteNonQuery(dbComm)
                MrpMaterialCode_Supplier = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpMaterialCode_Supplier = False
            End Try
        End Function

        Public Function MrpMaterialCode_Stock(ByVal objinfo As MrpMaterialCodeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpMaterialCode_Stock")
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@MC_WH_ID", DbType.String, objinfo.MC_WH_ID)
                db.AddInParameter(dbComm, "@MC_LowLimit", DbType.Double, objinfo.MC_LowLimit)
                db.AddInParameter(dbComm, "@MC_SecInv", DbType.Double, objinfo.MC_SecInv)

                db.ExecuteNonQuery(dbComm)
                MrpMaterialCode_Stock = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpMaterialCode_Stock = False
            End Try
        End Function

        Public Function MrpMaterialCode_GetWareHouseInfo(ByVal WH_ID As String) As List(Of MrpMaterialCodeInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareHouse_GetList")
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            Dim FeatureList As New List(Of MrpMaterialCodeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareHouseInfo(reader))
                End While
                Return FeatureList
            End Using
        End Function


        Public Function MrpSource_GetList(ByVal SourceID As String, ByVal Source As String) As List(Of MrpMaterialCodeInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpSource_GetList")
            db.AddInParameter(dbComm, "@SourceID", DbType.String, SourceID)
            db.AddInParameter(dbComm, "@Source", DbType.String, Source)
            Dim FeatureList As New List(Of MrpMaterialCodeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSource(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function MrpMaterialCode_PreDelete(ByVal M_Code As String) As Boolean
            Dim list As New List(Of String)
            list.Add("select ParentGroup from Bom_M where ParentGroup='" + M_Code + "'")
            list.Add("的Bom結構中存在該物料編碼(" + M_Code + ")，無法刪除")

            list.Add("select ParentGroup from Bom_D where ChildGroup='" + M_Code + "'")
            list.Add("的Bom結構中存在該物料編碼(" + M_Code + ")，無法刪除")

            list.Add("select MRP_ID from MrpIndReq where M_Code='" + M_Code + "'")
            list.Add("的需求運算中存在該物料編碼(" + M_Code + ")，無法刪除")

            list.Add("select MRP_ID from MrpDestBills where M_Code='" + M_Code + "'")
            list.Add("的需求運算中存在該物料編碼(" + M_Code + ")，無法刪除")

            list.Add("select MRP_ID from MrpOrderDestBills where M_Code='" + M_Code + "'")
            list.Add("的需求運算中存在該物料編碼(" + M_Code + ")，無法刪除")

            list.Add("select MRP_ID from MrpPurchase  where M_Code='" + M_Code + "'")
            list.Add("的需求運算中存在該物料編碼(" + M_Code + ")，無法刪除")

            list.Add("select Ware_ID from MrpWareHouseInfoEntry where M_Code='" + M_Code + "'")
            list.Add("的庫存記錄表中存在該物料編碼(" + M_Code + ")，無法刪除")

            list.Add("select MrpPurchaseID from MrpPurchaseRecordEntry where M_Code='" + M_Code + "'")
            list.Add("的請購申請單中存在該物料編碼(" + M_Code + ")，無法刪除")

            list.Add("select PO from MrpPurchaseOrderEntry where M_Code='" + M_Code + "'")
            list.Add("的采購單中存在該物料編碼(" + M_Code + ")，無法刪除")

            Return MRP_PreDelete(list)
        End Function

        Public Function MrpMaterialCode_Delete(ByVal AutoID As Double) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpMaterialCode_Delete")
                db.AddInParameter(dbComm, "@AutoID", DbType.Double, AutoID)
                db.ExecuteNonQuery(dbComm)
                MrpMaterialCode_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpMaterialCode_Delete = False
            End Try
        End Function

        Public Function MrpMaterialCode_Update(ByVal objinfo As MrpMaterialCodeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpMaterialCode_Update")
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@MC_BatchQty", DbType.Double, objinfo.MC_BatchQty)
                db.AddInParameter(dbComm, "@MC_BatFixEconomy", DbType.Double, objinfo.MC_BatFixEconomy)
                db.AddInParameter(dbComm, "@MC_OrderInterVal", DbType.Int64, objinfo.MC_OrderInterVal)
                db.AddInParameter(dbComm, "@MC_OrderMan", DbType.String, objinfo.MC_OrderMan)
                db.AddInParameter(dbComm, "@MC_QtyMax", DbType.Double, objinfo.MC_QtyMax)
                db.AddInParameter(dbComm, "@MC_QtyMin", DbType.Double, objinfo.MC_QtyMin)
                db.AddInParameter(dbComm, "@MC_LowLimit", DbType.Double, objinfo.MC_LowLimit)
                db.AddInParameter(dbComm, "@MC_SecInv", DbType.Double, objinfo.MC_SecInv)
                db.AddInParameter(dbComm, "@MC_Source", DbType.String, objinfo.MC_Source)
                db.AddInParameter(dbComm, "@MC_MRPCon", DbType.Boolean, objinfo.MC_MRPCon)
                db.AddInParameter(dbComm, "@MC_WH_ID", DbType.String, objinfo.MC_WH_ID)
                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)

                If objinfo.ModifyDate = Nothing Then
                    db.AddInParameter(dbComm, "@ModifyDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@ModifyDate", DbType.Date, objinfo.ModifyDate)
                End If

                'db.AddInParameter(dbComm, "@AutoID", DbType.Double, objinfo.AutoID)
                db.AddInParameter(dbComm, "@MC_Remark", DbType.String, objinfo.MC_Remark)
                db.AddInParameter(dbComm, "@MC_OrderRemark", DbType.String, objinfo.MC_OrderRemark)
                db.AddInParameter(dbComm, "@MC_WareHouseRemark", DbType.String, objinfo.MC_WareHouseRemark)
                db.AddInParameter(dbComm, "@M_Supplier", DbType.String, objinfo.M_Supplier)
                db.ExecuteNonQuery(dbComm)
                MrpMaterialCode_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpMaterialCode_Update = False
            End Try
        End Function

        Public Function MrpMaterialCode_UpdateCheck(ByVal objinfo As MrpMaterialCodeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpMaterialCode_UpdateCheck")
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@CheckUserID", DbType.String, objinfo.CheckUserID)
                db.AddInParameter(dbComm, "@CheckBit", DbType.Boolean, objinfo.CheckBit)
                db.AddInParameter(dbComm, "@CheckRemark", DbType.String, objinfo.CheckRemark)
                db.ExecuteNonQuery(dbComm)
                MrpMaterialCode_UpdateCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpMaterialCode_UpdateCheck = False
            End Try
        End Function


        Friend Function FillMaterialInfo(ByVal reader As IDataReader) As MrpMaterialCodeInfo
            Dim objInfo As New MrpMaterialCodeInfo
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            Return objInfo
        End Function

        ''' <summary>
        ''' 獲得物料編碼信息
        ''' </summary>
        ''' <param name="M_Code"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ''' 
        Public Function MaterialCode_GetList(ByVal M_Code As String) As List(Of MrpMaterialCodeInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialCode_GetList")
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            Dim FeatureList As New List(Of MrpMaterialCodeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMaterialInfo(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function MrpMaterialCode_GetAllTable(ByVal M_Code As String, ByVal CheckBit As Boolean) As DataTable
            Dim ds As DataSet
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpMaterialCode_GetAllTable")
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@CheckBit", DbType.Boolean, CheckBit)
            ds = db.ExecuteDataSet(dbComm)
            If ds.Tables.Count > 0 Then
                Return ds.Tables(0)
            Else
                Return Nothing
            End If
        End Function
    End Class
End Namespace


