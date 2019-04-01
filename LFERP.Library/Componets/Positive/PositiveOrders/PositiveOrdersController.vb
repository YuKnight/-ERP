Namespace LFERP.Library.Positive
    Public Class PositiveOrdersController

#Region "獲取單號"
        ''' <summary>
        ''' 獲取單號
        ''' </summary>
        ''' <param name="P_OM_ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PositiveOrders_GetNO(ByVal P_OM_ID As String, ByVal P_OM_Num As String) As PositiveOrdersInfo

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)

            Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveOrders_GetNO")

            db.AddInParameter(dbComm, "@P_OM_ID", DbType.String, P_OM_ID)
            db.AddInParameter(dbComm, "@P_OM_Num", DbType.String, P_OM_Num)

            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillPositiveOrders(reader)
                End While
                Return Nothing
            End Using

        End Function
#End Region

#Region "獲取陽極訂單"
        ''' <summary>
        ''' 獲取陽極訂單
        ''' </summary>
        ''' <param name="P_OM_ID"></param>
        ''' <param name="P_OM_CusterNo"></param>
        ''' <param name="P_M_Code"></param>
        ''' <param name="PartNumber"></param>
        ''' <param name="POMStstDate"></param>
        ''' <param name="POMEndDate"></param>
        ''' <param name="P_OM_AddAction"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PositiveOrders_GetList(ByVal P_OM_ID As String, ByVal P_OM_Num As String, ByVal P_OM_CusterNo As String, ByVal P_M_Code As String, ByVal PartNumber As String, ByVal POMStstDate As String, ByVal POMEndDate As String, ByVal P_OM_AddAction As String, ByVal P_OMComplateStartDate As String, ByVal P_OMComplateEndDate As String, ByVal P_OM_CusterPO As String) As List(Of PositiveOrdersInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveOrders_GetList")

            db.AddInParameter(dbComm, "@P_OM_ID", DbType.String, P_OM_ID)
            db.AddInParameter(dbComm, "@P_OM_Num", DbType.String, P_OM_Num)
            db.AddInParameter(dbComm, "@P_OM_CusterNo", DbType.String, P_OM_CusterNo)
            db.AddInParameter(dbComm, "@P_M_Code", DbType.String, P_M_Code)
            db.AddInParameter(dbComm, "@PartNumber", DbType.String, PartNumber)
            db.AddInParameter(dbComm, "@POMStstDate", DbType.String, POMStstDate)
            db.AddInParameter(dbComm, "@POMEndDate", DbType.String, POMEndDate)
            db.AddInParameter(dbComm, "@P_OMComplateStartDate", DbType.String, P_OMComplateStartDate)
            db.AddInParameter(dbComm, "@P_OMComplateEndDate", DbType.String, P_OMComplateEndDate)
            db.AddInParameter(dbComm, "@P_OM_AddAction", DbType.String, P_OM_AddAction)
            db.AddInParameter(dbComm, "@P_OM_CusterPO", DbType.String, P_OM_CusterPO)

            Dim FeatureList As New List(Of PositiveOrdersInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPositiveOrders(reader))
                End While
                Return FeatureList
            End Using


        End Function

        ''' <summary>
        ''' 獲取訂單列表
        ''' </summary>
        ''' <param name="P_OM_CusterNo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PositiveOrders_GetPOMIDList(ByVal P_OM_CusterNo As String, ByVal IsCheck As Boolean) As List(Of PositiveOrdersInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveOrders_GetPOMIDList")

            db.AddInParameter(dbComm, "@P_OM_CusterNo", DbType.String, P_OM_CusterNo)
            db.AddInParameter(dbComm, "@IsCheck", DbType.Boolean, IsCheck)
            Dim FeatureList As New List(Of PositiveOrdersInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPositiveOrders(reader))
                End While
                Return FeatureList
            End Using
        End Function


        Public Function PositiveOrders_GetPOList(ByVal IsCheck As Boolean) As DataTable
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveOrders_GetPOList")
            If IsCheck = True Then
                db.AddInParameter(dbComm, "@IsCheck", DbType.Boolean, IsCheck)
            End If
            Dim ds As DataSet
            ds = db.ExecuteDataSet(dbComm)
            If ds.Tables.Count > 0 Then
                Return ds.Tables(0)
            Else
                Return Nothing
            End If
        End Function

        ''' <summary>
        ''' 獲取陽極訂單前五百條記錄
        ''' </summary>
        ''' <param name="P_OM_ID"></param>
        ''' <param name="P_OM_CusterNo"></param>
        ''' <param name="P_M_Code"></param>
        ''' <param name="PartNumber"></param>
        ''' <param name="POMStstDate"></param>
        ''' <param name="POMEndDate"></param>
        ''' <param name="P_OM_AddAction"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PositiveOrders_GetListTopFiveHundred(ByVal P_OM_ID As String, ByVal P_OM_CusterNo As String, ByVal P_M_Code As String, ByVal PartNumber As String, ByVal POMStstDate As String, ByVal POMEndDate As String, ByVal P_OM_AddAction As String, ByVal P_OMComplateStartDate As String, ByVal P_OMComplateEndDate As String) As List(Of PositiveOrdersInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveOrders_GetListTopFiveHundred")

            db.AddInParameter(dbComm, "@P_OM_ID", DbType.String, P_OM_ID)
            db.AddInParameter(dbComm, "@P_OM_CusterNo", DbType.String, P_OM_CusterNo)
            db.AddInParameter(dbComm, "@P_M_Code", DbType.String, P_M_Code)
            db.AddInParameter(dbComm, "@PartNumber", DbType.String, PartNumber)
            db.AddInParameter(dbComm, "@POMStstDate", DbType.String, POMStstDate)
            db.AddInParameter(dbComm, "@POMEndDate", DbType.String, POMEndDate)
            db.AddInParameter(dbComm, "@P_OMComplateStartDate", DbType.String, P_OMComplateStartDate)
            db.AddInParameter(dbComm, "@P_OMComplateEndDate", DbType.String, P_OMComplateEndDate)
            db.AddInParameter(dbComm, "@P_OM_AddAction", DbType.String, P_OM_AddAction)

            Dim FeatureList As New List(Of PositiveOrdersInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPositiveOrders(reader))
                End While
                Return FeatureList
            End Using
        End Function
#End Region

#Region "新增陽極訂單"
        ''' <summary>
        ''' 新增陽極訂單
        ''' </summary>
        ''' <param name="posOrderInfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PositiveOrders_Add(ByVal posOrderInfo As PositiveOrdersInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveOrders_Add")

                db.AddInParameter(dbComm, "@P_OM_ID", DbType.String, posOrderInfo.P_OM_ID)

                db.AddInParameter(dbComm, "@P_OM_Num", DbType.String, posOrderInfo.P_OM_Num)

                db.AddInParameter(dbComm, "@P_OM_CusterPO", DbType.String, posOrderInfo.P_OM_CusterPO)

                db.AddInParameter(dbComm, "@P_M_Code", DbType.String, posOrderInfo.P_M_Code)

                db.AddInParameter(dbComm, "@P_OM_CusterNo", DbType.String, posOrderInfo.P_OM_CusterNo)

                db.AddInParameter(dbComm, "@PartNumber", DbType.String, posOrderInfo.PartNumber)

                db.AddInParameter(dbComm, "@Qty", DbType.Double, posOrderInfo.Qty)

                db.AddInParameter(dbComm, "@NoSendQty", DbType.String, posOrderInfo.NoSendQty)

                db.AddInParameter(dbComm, "@P_OM_AddDate", DbType.DateTime, posOrderInfo.P_OM_AddDate)

                db.AddInParameter(dbComm, "@P_OM_AddAction", DbType.String, posOrderInfo.P_OM_AddAction)

                db.AddInParameter(dbComm, "@P_OM_Check", DbType.Boolean, posOrderInfo.P_OM_Check)

                db.AddInParameter(dbComm, "@P_Remark", DbType.String, posOrderInfo.P_Remark)

                db.AddInParameter(dbComm, "@P_OMComplateDate", DbType.DateTime, posOrderInfo.P_OMComplateDate)

                db.AddInParameter(dbComm, "@P_OMRemark", DbType.String, posOrderInfo.P_OMRemark)


                db.AddInParameter(dbComm, "@NoTaxPrice", DbType.Decimal, posOrderInfo.NoTaxPrice)
                db.AddInParameter(dbComm, "@TaxRate", DbType.Decimal, posOrderInfo.TaxRate)
                db.AddInParameter(dbComm, "@Discount", DbType.Decimal, posOrderInfo.Discount)
                db.AddInParameter(dbComm, "@M_Name", DbType.String, posOrderInfo.M_Name)
                db.AddInParameter(dbComm, "@M_Gauge", DbType.String, posOrderInfo.M_Gauge)
                db.AddInParameter(dbComm, "@UnitID", DbType.String, posOrderInfo.UnitID)
                db.ExecuteNonQuery(dbComm)
                PositiveOrders_Add = True

            Catch ex As Exception
                PositiveOrders_Add = False
            End Try

        End Function
#End Region

#Region "修改陽極訂單"
        ''' <summary>
        ''' 修改陽極訂單
        ''' </summary>
        ''' <param name="posOrderInfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PositiveOrders_Update(ByVal posOrderInfo As PositiveOrdersInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveOrders_Update")

                db.AddInParameter(dbComm, "@P_OM_ID", DbType.String, posOrderInfo.P_OM_ID)

                db.AddInParameter(dbComm, "@P_OM_Num", DbType.String, posOrderInfo.P_OM_Num)

                db.AddInParameter(dbComm, "@P_OM_CusterPO", DbType.String, posOrderInfo.P_OM_CusterPO)

                db.AddInParameter(dbComm, "@P_M_Code", DbType.String, posOrderInfo.P_M_Code)

                db.AddInParameter(dbComm, "@P_OM_CusterNo", DbType.String, posOrderInfo.P_OM_CusterNo)

                db.AddInParameter(dbComm, "@PartNumber", DbType.String, posOrderInfo.PartNumber)

                db.AddInParameter(dbComm, "@Qty", DbType.Double, posOrderInfo.Qty)

                db.AddInParameter(dbComm, "@NoSendQty", DbType.String, posOrderInfo.NoSendQty)

                db.AddInParameter(dbComm, "@P_OM_AddDate", DbType.DateTime, posOrderInfo.P_OM_AddDate)

                db.AddInParameter(dbComm, "@P_OM_AddAction", DbType.String, posOrderInfo.P_OM_AddAction)

                db.AddInParameter(dbComm, "@P_Remark", DbType.String, posOrderInfo.P_Remark)

                db.AddInParameter(dbComm, "@P_OMComplateDate", DbType.DateTime, posOrderInfo.P_OMComplateDate)

                db.AddInParameter(dbComm, "@P_OMRemark", DbType.String, posOrderInfo.P_OMRemark)

                db.AddInParameter(dbComm, "@NoTaxPrice", DbType.Decimal, posOrderInfo.NoTaxPrice)
                db.AddInParameter(dbComm, "@TaxRate", DbType.Decimal, posOrderInfo.TaxRate)
                db.AddInParameter(dbComm, "@Discount", DbType.Decimal, posOrderInfo.Discount)
                db.AddInParameter(dbComm, "@M_Name", DbType.String, posOrderInfo.M_Name)
                db.AddInParameter(dbComm, "@M_Gauge", DbType.String, posOrderInfo.M_Gauge)
                db.AddInParameter(dbComm, "@UnitID", DbType.String, posOrderInfo.UnitID)
                db.ExecuteNonQuery(dbComm)
                PositiveOrders_Update = True

            Catch ex As Exception
                PositiveOrders_Update = False
            End Try

        End Function

        ''' <summary>
        ''' 更改未交數量
        ''' </summary>
        ''' <param name="P_OM_Num"></param>
        ''' <param name="NoSendQty"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PositiveOrders_UpdateNoSendQty(ByVal P_OM_Num As String, ByVal NoSendQty As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveOrders_UpdateNoSendQty")

                db.AddInParameter(dbComm, "@P_OM_Num", DbType.String, P_OM_Num)
                db.AddInParameter(dbComm, "@NoSendQty", DbType.Double, NoSendQty)

                db.ExecuteNonQuery(dbComm)
                PositiveOrders_UpdateNoSendQty = True

            Catch ex As Exception
                PositiveOrders_UpdateNoSendQty = False
            End Try

        End Function

        ''' <summary>
        ''' 更新單價
        ''' </summary>
        ''' <param name="posOrderInfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PositiveOrders_UpdatePrice(ByVal posOrderInfo As PositiveOrdersInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveOrders_UpdatePrice")

                db.AddInParameter(dbComm, "@P_OM_ID", DbType.String, posOrderInfo.P_OM_ID)
                db.AddInParameter(dbComm, "@P_OM_Num", DbType.String, posOrderInfo.P_OM_Num)
                db.AddInParameter(dbComm, "@P_SalesPrice", DbType.Double, posOrderInfo.P_SalesPrice)
                db.AddInParameter(dbComm, "@P_ProductPrice", DbType.Double, posOrderInfo.P_ProductPrice)

                db.ExecuteNonQuery(dbComm)
                PositiveOrders_UpdatePrice = True

            Catch ex As Exception
                PositiveOrders_UpdatePrice = False
            End Try

        End Function

#End Region

#Region "審核陽極訂單"
        ''' <summary>
        ''' 審核陽極訂單
        ''' </summary>
        ''' <param name="posOrderInfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PositiveOrders_Check(ByVal posOrderInfo As PositiveOrdersInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveOrders_Check")

                db.AddInParameter(dbComm, "@P_OM_ID", DbType.String, posOrderInfo.P_OM_ID)

                db.AddInParameter(dbComm, "@P_OM_Num", DbType.String, posOrderInfo.P_OM_Num)

                db.AddInParameter(dbComm, "@P_OM_Check", DbType.Boolean, posOrderInfo.P_OM_Check)

                db.AddInParameter(dbComm, "@P_OM_CheckAction", DbType.String, posOrderInfo.P_OM_CheckAction)

                db.AddInParameter(dbComm, "@P_OM_CheckDate", DbType.String, posOrderInfo.P_OM_CheckDate)

                db.AddInParameter(dbComm, "@P_CheckRemark", DbType.String, posOrderInfo.P_CheckRemark)

                db.ExecuteNonQuery(dbComm)
                PositiveOrders_Check = True

            Catch ex As Exception
                MsgBox(ex.Message)
                PositiveOrders_Check = False
            End Try

        End Function
#End Region

#Region "刪除陽極訂單"
        ''' <summary>
        ''' 刪除陽極訂單
        ''' </summary>
        ''' <param name="P_OM_ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PositiveOrders_Delete(ByVal P_OM_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveOrders_Delete")

                db.AddInParameter(dbComm, "@P_OM_ID", DbType.String, P_OM_ID)

                db.ExecuteNonQuery(dbComm)
                PositiveOrders_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PositiveOrders_Delete = False
            End Try
        End Function

        ''' <summary>
        ''' 根據訂單流水號刪除陽極訂單
        ''' </summary>
        ''' <param name="P_OM_Num"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PositiveOrders_DeleteByPONum(ByVal P_OM_Num As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveOrders_DeleteByPONum")

                db.AddInParameter(dbComm, "@P_OM_Num", DbType.String, P_OM_Num)

                db.ExecuteNonQuery(dbComm)
                PositiveOrders_DeleteByPONum = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PositiveOrders_DeleteByPONum = False
            End Try
        End Function
#End Region

#Region "填充數據集合"
        ''' <summary>
        ''' 填充數據集合
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function FillPositiveOrders(ByVal reader As IDataReader) As PositiveOrdersInfo
            On Error Resume Next

            Dim poInfo As New PositiveOrdersInfo

            poInfo.AutoID = reader("AutoID").ToString

            poInfo.P_OM_Num = reader("P_OM_Num").ToString

            poInfo.P_OM_ID = reader("P_OM_ID").ToString

            poInfo.P_OM_CusterPO = reader("P_OM_CusterPO").ToString

            poInfo.P_OM_CusterNo = reader("P_OM_CusterNo").ToString

            poInfo.P_M_Code = reader("P_M_Code").ToString

            poInfo.PartNumber = reader("PartNumber").ToString

            poInfo.Qty = reader("Qty").ToString

            poInfo.NoSendQty = reader("NoSendQty").ToString

            poInfo.P_OM_AddDate = CDate(reader("P_OM_AddDate")).ToString("yyyy/MM/dd")

            poInfo.P_OMComplateDate = CDate(reader("P_OMComplateDate")).ToString("yyyy/MM/dd")

            poInfo.P_OM_AddAction = reader("P_OM_AddAction").ToString

            poInfo.ChineseName = reader("ChineseName").ToString

            poInfo.People = reader("People").ToString

            If reader("P_OM_Check") Is DBNull.Value Then
                poInfo.P_OM_Check = Nothing
            Else
                poInfo.P_OM_Check = reader("P_OM_Check")
            End If

            If reader("P_OM_CheckAction") Is DBNull.Value Then
                poInfo.P_OM_CheckAction = Nothing
            Else
                poInfo.P_OM_CheckAction = reader("P_OM_CheckAction")
            End If

            If reader("P_OM_CheckDate") Is DBNull.Value Then
                poInfo.P_OM_CheckDate = Nothing
            Else
                poInfo.P_OM_CheckDate = CDate(reader("P_OM_CheckDate")).ToString("yyyy/MM/dd")
            End If

            If reader("P_SalesPrice") Is DBNull.Value Then
                poInfo.P_SalesPrice = Nothing
            Else
                poInfo.P_SalesPrice = reader("P_SalesPrice")
            End If

            If reader("P_ProductPrice") Is DBNull.Value Then
                poInfo.P_ProductPrice = Nothing
            Else
                poInfo.P_ProductPrice = reader("P_ProductPrice")
            End If

            If reader("P_Remark") Is DBNull.Value Then
                poInfo.P_Remark = Nothing
            Else
                poInfo.P_Remark = reader("P_Remark")
            End If

            If reader("P_CheckRemark") Is DBNull.Value Then
                poInfo.P_CheckRemark = Nothing
            Else
                poInfo.P_CheckRemark = reader("P_CheckRemark")
            End If

            If reader("ActionName") Is DBNull.Value Then
                poInfo.ActionName = Nothing
            Else
                poInfo.ActionName = reader("ActionName")
            End If

            If reader("CheckActionName") Is DBNull.Value Then
                poInfo.CheckActionName = Nothing
            Else
                poInfo.CheckActionName = reader("CheckActionName")
            End If

            If reader("P_OMRemark") Is DBNull.Value Then
                poInfo.P_OMRemark = Nothing
            Else
                poInfo.P_OMRemark = reader("P_OMRemark")
            End If

            If reader("NoTaxPrice") Is DBNull.Value Then
                poInfo.NoTaxPrice = 0
            Else
                poInfo.NoTaxPrice = CDec(reader("NoTaxPrice"))
            End If
            If reader("TaxRate") Is DBNull.Value Then
                poInfo.TaxRate = 0
            Else
                poInfo.TaxRate = CDec(reader("TaxRate"))
            End If
            If reader("Discount") Is DBNull.Value Then
                poInfo.Discount = 0
            Else
                poInfo.Discount = CDec(reader("Discount"))
            End If

            If IsDBNull(reader("M_Name")) = False Then
                poInfo.M_Name = reader("M_Name").ToString
            End If
            If IsDBNull(reader("M_Gauge")) = False Then
                poInfo.M_Gauge = reader("M_Gauge").ToString
            End If
            If IsDBNull(reader("UnitID")) = False Then
                poInfo.UnitID = reader("UnitID").ToString
            End If
            If IsDBNull(reader("UnitName")) = False Then
                poInfo.UnitName = reader("UnitName").ToString
            End If
            Return poInfo

        End Function
#End Region

        Public Function PositiveOrders_GetCustomer() As DataTable
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveOrders_GetCustomer")
            Dim ds As New DataSet
            ds = db.ExecuteDataSet(dbComm)
            If ds.Tables.Count > 0 Then
                Return ds.Tables(0)
            Else
                Return Nothing
            End If
        End Function

    End Class
End Namespace


