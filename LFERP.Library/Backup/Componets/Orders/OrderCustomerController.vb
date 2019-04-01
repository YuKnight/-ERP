Namespace LFERP.Library.Orders
    Public Class OrderCustomerController
        Public Function OrderCustomer_Add(ByVal objinfo As OrderCustomerInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrderCustomer_Add")

                db.AddInParameter(dbComm, "@OC_ID", DbType.String, objinfo.OC_ID)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@OC_CustomerNo", DbType.String, objinfo.OC_CustomerNo)
                db.AddInParameter(dbComm, "@OC_CustomerID", DbType.String, objinfo.OC_CustomerID)

                db.AddInParameter(dbComm, "@OC_CustomerPO", DbType.String, objinfo.OC_CustomerPO)
                db.AddInParameter(dbComm, "@OC_PODate", DbType.Date, objinfo.OC_PODate)
                db.AddInParameter(dbComm, "@OC_Qty", DbType.Int32, objinfo.OC_Qty)
                db.AddInParameter(dbComm, "@OC_NoSendQty", DbType.Int32, objinfo.OC_NoSendQty)
                db.AddInParameter(dbComm, "@OC_Spare", DbType.Double, objinfo.OC_Spare)

                db.AddInParameter(dbComm, "@OC_Remark", DbType.String, objinfo.OC_Remark)
                db.AddInParameter(dbComm, "@OC_Index", DbType.String, objinfo.OC_Index)
                db.AddInParameter(dbComm, "@OC_AddDate", DbType.Date, objinfo.OC_AddDate)
                db.AddInParameter(dbComm, "@OC_AddUser", DbType.String, objinfo.OC_AddUser)

                db.ExecuteNonQuery(dbComm)
                OrderCustomer_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OrderCustomer_Add = False
            End Try
        End Function

        Public Function OrderCustomer_Update(ByVal objinfo As OrderCustomerInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrderCustomer_Update")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@OC_ID", DbType.String, objinfo.OC_ID)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@OC_CustomerNo", DbType.String, objinfo.OC_CustomerNo)

                db.AddInParameter(dbComm, "@OC_CustomerID", DbType.String, objinfo.OC_CustomerID)
                db.AddInParameter(dbComm, "@OC_CustomerPO", DbType.String, objinfo.OC_CustomerPO)
                db.AddInParameter(dbComm, "@OC_PODate", DbType.Date, objinfo.OC_PODate)
                db.AddInParameter(dbComm, "@OC_Qty", DbType.Int32, objinfo.OC_Qty)
                db.AddInParameter(dbComm, "@OC_NoSendQty", DbType.Int32, objinfo.OC_NoSendQty)

                db.AddInParameter(dbComm, "@OC_Spare", DbType.Double, objinfo.OC_Spare)
                db.AddInParameter(dbComm, "@OC_Index", DbType.String, objinfo.OC_Index)
                db.AddInParameter(dbComm, "@OC_Remark", DbType.String, objinfo.OC_Remark)
                db.AddInParameter(dbComm, "@OC_ModifyDate", DbType.Date, objinfo.OC_ModifyDate)
                db.AddInParameter(dbComm, "@OC_ModifyUser", DbType.String, objinfo.OC_ModifyUser)
                db.ExecuteNonQuery(dbComm)
                OrderCustomer_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                OrderCustomer_Update = False
            End Try
        End Function

        Public Function OrderCustomer_Delete(ByVal AutoID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrderCustomer_Delete")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)

                db.ExecuteNonQuery(dbComm)
                OrderCustomer_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                OrderCustomer_Delete = False
            End Try
        End Function
        ''' <summary>
        ''' 返回查詢記錄
        ''' </summary>
        ''' <param name="AutoID">流水號</param>
        ''' <param name="OC_ID">訂單編號</param>
        ''' <param name="PM_M_Code">產品編號</param>
        ''' <param name="M_Code">物料編號</param>
        ''' <param name="OC_CustomerNo">客戶產品編號</param>
        ''' <param name="OC_CustomerID">客戶代號</param>
        ''' <param name="OC_CustomerPO">客戶PO</param>
        ''' <param name="OC_PODateBegin">查詢PO開始日期</param>
        ''' <param name="OC_PODateEnd">查詢PO結束日期</param>
        ''' <param name="OC_NoSendQty">訂單未交數，查詢條件為大於此輸入未交數</param>
        ''' <param name="OC_AddDateBegin">查詢訂單開始添加日期</param>
        ''' <param name="OC_AddDateEnd">查詢訂單結束添加日期</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrderCustomer_GetList(ByVal AutoID As String, ByVal OC_ID As String, ByVal PM_M_Code As String, ByVal M_Code As String, _
        ByVal OC_CustomerNo As String, ByVal OC_CustomerID As String, ByVal OC_CustomerPO As String, ByVal OC_PODateBegin As String, _
        ByVal OC_PODateEnd As String, ByVal OC_NoSendQty As String, ByVal OC_AddDateBegin As String, ByVal OC_AddDateEnd As String) As List(Of OrderCustomerInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OrderCustomer_GetList")

            db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbComm, "@OC_ID", DbType.String, OC_ID)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@OC_CustomerNo", DbType.String, OC_CustomerNo)

            db.AddInParameter(dbComm, "@OC_CustomerID", DbType.String, OC_CustomerID)
            db.AddInParameter(dbComm, "@OC_CustomerPO", DbType.String, OC_CustomerPO)
            db.AddInParameter(dbComm, "@OC_PODateBegin", DbType.String, OC_PODateBegin)
            db.AddInParameter(dbComm, "@OC_PODateEnd", DbType.String, OC_PODateEnd)
            db.AddInParameter(dbComm, "@OC_NoSendQty", DbType.String, OC_NoSendQty)

            db.AddInParameter(dbComm, "@OC_AddDateBegin", DbType.String, OC_AddDateBegin)
            db.AddInParameter(dbComm, "@OC_AddDateEnd", DbType.String, OC_AddDateEnd)

            Dim FeatureList As New List(Of OrderCustomerInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOrderCustomer(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function OrderCustomer_GetCustomerID() As List(Of OrderCustomerInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OrderCustomer_GetCustomerID")

            Dim FeatureList As New List(Of OrderCustomerInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOrderCustomer(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FillOrderCustomer(ByVal reader As IDataReader) As OrderCustomerInfo
            '對應取得的數據
            On Error Resume Next
            Dim oci As New OrderCustomerInfo

            oci.AutoID = reader("AutoID")
            oci.OC_ID = reader("OC_ID").ToString
            oci.PM_M_Code = reader("PM_M_Code").ToString
            oci.M_Code = reader("M_Code").ToString
            oci.M_Name = reader("M_Name").ToString

            oci.OC_CustomerNo = reader("OC_CustomerNo").ToString
            oci.OC_CustomerID = reader("OC_CustomerID").ToString
            oci.OC_CustomerPO = reader("OC_CustomerPO").ToString
            If reader("OC_PODate") Is DBNull.Value Then
                oci.OC_PODate = Nothing
            Else
                oci.OC_PODate = Format(reader("OC_PODate"), "yyyy/MM/dd")
            End If
            oci.OC_Qty = reader("OC_Qty")

            oci.OC_NoSendQty = reader("OC_NoSendQty")
            oci.OC_Spare = reader("OC_Spare")
            oci.OC_Remark = reader("OC_Remark").ToString
            oci.OC_Index = reader("OC_Index").ToString
            If reader("OC_AddDate") Is DBNull.Value Then
                oci.OC_AddDate = Nothing
            Else
                oci.OC_AddDate = Format(reader("OC_AddDate"), "yyyy/MM/dd")
            End If

            oci.OC_AddUser = reader("OC_AddUser").ToString
            If reader("OC_ModifyDate") Is DBNull.Value Then
                oci.OC_ModifyDate = Nothing
            Else
                oci.OC_ModifyDate = Format(reader("OC_ModifyDate"), "yyyy/MM/dd")
            End If
            oci.OC_ModifyUser = reader("OC_ModifyUser").ToString
            Return oci
        End Function
    End Class
End Namespace

