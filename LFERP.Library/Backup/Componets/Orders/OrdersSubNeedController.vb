Namespace LFERP.Library.Orders
    Public Class OrdersSubNeedController
        Public Function OrdersSubNeed_Add(ByVal objFile1 As OrdersSubNeedInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersSubNeed_Add")

                db.AddInParameter(dbComm, "@ON_ID", DbType.String, objFile1.ON_ID)
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)
                db.AddInParameter(dbComm, "@OS_Qty", DbType.String, objFile1.OS_Qty)
                db.AddInParameter(dbComm, "@M_Weight", DbType.String, objFile1.M_Weight)

                db.AddInParameter(dbComm, "@ON_NeedQty", DbType.String, objFile1.ON_NeedQty)
                db.AddInParameter(dbComm, "@M_CodeType", DbType.String, objFile1.M_CodeType)
                db.AddInParameter(dbComm, "@ON_PrepareQty", DbType.String, objFile1.ON_PrepareQty)
                db.AddInParameter(dbComm, "@ON_NeedPurchaseQty", DbType.String, objFile1.ON_NeedPurchaseQty)
                db.AddInParameter(dbComm, "@ON_PurchaseState", DbType.String, objFile1.ON_PurchaseState)

                db.AddInParameter(dbComm, "@ON_Remark", DbType.String, objFile1.ON_Remark)
                db.AddInParameter(dbComm, "@ON_AddUser", DbType.String, objFile1.ON_AddUser)
                db.AddInParameter(dbComm, "@ON_AddDate", DbType.String, objFile1.ON_AddDate)

                db.ExecuteNonQuery(dbComm)
                OrdersSubNeed_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersSubNeed_Add = False

            End Try
        End Function

        Public Function OrdersSubNeed_Update(ByVal objFile1 As OrdersSubNeedInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersSubNeed_Update")

                db.AddInParameter(dbComm, "@ON_ID", DbType.String, objFile1.ON_ID)
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)
                db.AddInParameter(dbComm, "@OS_Qty", DbType.String, objFile1.OS_Qty)
                db.AddInParameter(dbComm, "@M_Weight", DbType.String, objFile1.M_Weight)

                db.AddInParameter(dbComm, "@ON_NeedQty", DbType.String, objFile1.ON_NeedQty)
                db.AddInParameter(dbComm, "@M_CodeType", DbType.String, objFile1.M_CodeType)
                db.AddInParameter(dbComm, "@ON_PrepareQty", DbType.String, objFile1.ON_PrepareQty)
                db.AddInParameter(dbComm, "@ON_NeedPurchaseQty", DbType.String, objFile1.ON_NeedPurchaseQty)
                db.AddInParameter(dbComm, "@ON_PurchaseReturnQty", DbType.String, objFile1.ON_PurchaseReturnQty)

                db.AddInParameter(dbComm, "@ON_TakeQty", DbType.String, objFile1.ON_TakeQty)
                db.AddInParameter(dbComm, "@ON_PurchaseState", DbType.String, objFile1.ON_PurchaseState)
                db.AddInParameter(dbComm, "@ON_Remark", DbType.String, objFile1.ON_Remark)
                db.AddInParameter(dbComm, "@ON_ModifyUser", DbType.String, objFile1.ON_ModifyUser)
                db.AddInParameter(dbComm, "@ON_ModifyDate", DbType.String, objFile1.ON_ModifyDate)

                db.AddInParameter(dbComm, "@ON_SalesDptCheck", DbType.String, objFile1.ON_SalesDptCheck)
                db.AddInParameter(dbComm, "@ON_OperationDptCheck", DbType.String, objFile1.ON_OperationDptCheck)
                db.AddInParameter(dbComm, "@ON_SalesDptCheckUser", DbType.String, objFile1.ON_SalesDptCheckUser)
                db.AddInParameter(dbComm, "@ON_SalesDptCheckDate", DbType.String, objFile1.ON_SalesDptCheckDate)
                db.AddInParameter(dbComm, "@ON_OperationDptCheckUser", DbType.String, objFile1.ON_OperationDptCheckUser)

                db.AddInParameter(dbComm, "@ON_OperationDptCheckDate", DbType.String, objFile1.ON_OperationDptCheckDate)
                db.AddInParameter(dbComm, "@AutoID", DbType.String, objFile1.AutoID)
                db.ExecuteNonQuery(dbComm)
                OrdersSubNeed_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersSubNeed_Update = False

            End Try
        End Function

        Public Function OrdersSubNeed_Delete(ByVal ON_ID As String, ByVal AutoID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersSubNeed_Delete")

                db.AddInParameter(dbComm, "@ON_ID", DbType.String, ON_ID)
                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)

                db.ExecuteNonQuery(dbComm)
                OrdersSubNeed_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersSubNeed_Delete = False
            End Try
        End Function

        Public Function OrdersSubNeed_GetList(ByVal AutoID As String, ByVal ON_ID As String, ByVal OS_BatchID As String, ByVal M_Code As String, _
        ByVal M_Name As String, ByVal WH_ID As String, ByVal M_CodeType As String, ByVal ON_PurchaseState As String, _
        ByVal ON_AddDateBegin As String, ByVal ON_AddDateEnd As String, ByVal ON_SalesDptCheck As String, _
        ByVal ON_OperationDptCheck As String) As List(Of OrdersSubNeedInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersSubNeed_GetList")

            db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbComm, "@ON_ID", DbType.String, ON_ID)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)

            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@M_CodeType", DbType.String, M_CodeType)
            db.AddInParameter(dbComm, "@ON_PurchaseState", DbType.String, ON_PurchaseState)
            db.AddInParameter(dbComm, "@ON_AddDateBegin", DbType.String, ON_AddDateBegin)
            db.AddInParameter(dbComm, "@ON_AddDateEnd", DbType.String, ON_AddDateEnd)

            db.AddInParameter(dbComm, "@ON_SalesDptCheck", DbType.String, ON_SalesDptCheck)
            db.AddInParameter(dbComm, "@ON_OperationDptCheck", DbType.String, ON_OperationDptCheck)

            Dim FeatureList As New List(Of OrdersSubNeedInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOrdersSubNeed(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function OrdersSubNeed_AddGetList(ByVal OS_BatchID As String, ByVal WH_ID As String, ByVal M_CodeType As String) As List(Of OrdersSubNeedInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersSubNeed_AddGetList")

            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@M_CodeType", DbType.String, M_CodeType)

            Dim FeatureList As New List(Of OrdersSubNeedInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOrdersSubNeed(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Friend Function FillOrdersSubNeed(ByVal reader As IDataReader) As OrdersSubNeedInfo
            On Error Resume Next
            Dim objInfo As New OrdersSubNeedInfo

            objInfo.ON_ID = reader("ON_ID").ToString
            objInfo.OS_BatchID = reader("OS_BatchID").ToString
            objInfo.OS_Qty = reader("OS_Qty")
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString

            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            objInfo.M_Weight = reader("M_Weight").ToString
            objInfo.ON_NeedQty = reader("ON_NeedQty").ToString
            objInfo.M_CodeType = reader("M_CodeType").ToString

            If reader("WI_Qty") Is DBNull.Value Then
                objInfo.WI_Qty = 0
            Else
                objInfo.WI_Qty = reader("WI_Qty").ToString
            End If
            If reader("ON_PrepareQty") Is DBNull.Value Then
                objInfo.ON_PrepareQty = 0
            Else
                objInfo.ON_PrepareQty = reader("ON_PrepareQty")
            End If
            If reader("ON_PrepareQty") Is DBNull.Value Then
                objInfo.ON_PrepareQty = 0
            Else
                objInfo.ON_PrepareQty = reader("ON_PrepareQty")
            End If
            If reader("ON_NeedPurchaseQty") Is DBNull.Value Then
                objInfo.ON_NeedPurchaseQty = 0
            Else
                objInfo.ON_NeedPurchaseQty = reader("ON_NeedPurchaseQty")
            End If
            If reader("ON_ReallyPurchaseQty") Is DBNull.Value Then
                objInfo.ON_ReallyPurchaseQty = 0
            Else
                objInfo.ON_ReallyPurchaseQty = reader("ON_ReallyPurchaseQty")
            End If

            If reader("ON_PurchaseReturnQty") Is DBNull.Value Then
                objInfo.ON_PurchaseReturnQty = 0
            Else
                objInfo.ON_PurchaseReturnQty = reader("ON_PurchaseReturnQty")
            End If
            If reader("ON_TakeQty") Is DBNull.Value Then
                objInfo.ON_TakeQty = 0
            Else
                objInfo.ON_TakeQty = reader("ON_TakeQty").ToString
            End If
            objInfo.ON_Remark = reader("ON_Remark").ToString
            If reader("ON_SalesDptCheck") Is DBNull.Value Then
                objInfo.ON_SalesDptCheck = Nothing
            Else
                objInfo.ON_SalesDptCheck = reader("ON_SalesDptCheck")
            End If
            If reader("ON_OperationDptCheck") Is DBNull.Value Then
                objInfo.ON_OperationDptCheck = Nothing
            Else
                objInfo.ON_OperationDptCheck = reader("ON_OperationDptCheck")
            End If

            objInfo.AutoID = reader("AutoID")
            objInfo.ON_PurchaseState = reader("ON_PurchaseState").ToString
            objInfo.ON_AddUser = reader("ON_AddUser").ToString
            If reader("ON_AddDate") Is DBNull.Value Then
                objInfo.ON_AddDate = Nothing
            Else
                objInfo.ON_AddDate = Format(reader("ON_AddDate"), "yyyy/MM/dd")
            End If
            objInfo.ON_ModifyUser = reader("ON_ModifyUser").ToString

            If reader("ON_ModifyDate") Is DBNull.Value Then
                objInfo.ON_ModifyDate = Nothing
            Else
                objInfo.ON_ModifyDate = Format(reader("ON_ModifyDate"), "yyyy/MM/dd")
            End If

            objInfo.ON_SalesDptCheckUser = reader("ON_SalesDptCheckUser").ToString
            If reader("ON_SalesDptCheckDate") Is DBNull.Value Then
                objInfo.ON_SalesDptCheckDate = Nothing
            Else
                objInfo.ON_SalesDptCheckDate = Format(reader("ON_SalesDptCheckDate"), "yyyy/MM/dd")
            End If
            objInfo.ON_OperationDptCheckUser = reader("ON_OperationDptCheckUser").ToString
            If reader("ON_OperationDptCheckDate") Is DBNull.Value Then
                objInfo.ON_OperationDptCheckDate = Nothing
            Else
                objInfo.ON_OperationDptCheckDate = Format(reader("ON_OperationDptCheckDate"), "yyyy/MM/dd")
            End If
            If reader("WI_UsableQty") Is DBNull.Value Then
                objInfo.WI_UsableQty = 0
            Else
                objInfo.WI_UsableQty = reader("WI_UsableQty").ToString
            End If
            Return objInfo
        End Function
    End Class
End Namespace

