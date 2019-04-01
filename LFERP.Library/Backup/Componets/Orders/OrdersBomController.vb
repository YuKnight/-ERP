Namespace LFERP.Library.Orders
    Public Class OrdersBomController
        ''' <summary>
        ''' 物料清單新增
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersBom_Add(ByVal objFile1 As OrdersBomInfo) As Boolean
            '   檢查項目是否已存在()
            'Dim objSystemUserInfo As OrdersBomInfo = OrdersBom_Get(objFile1.OS_BatchID)
            'If objSystemUserInfo Is Nothing Then

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersBom_Add")
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)
                db.AddInParameter(dbComm, "@OB_PID", DbType.String, objFile1.OB_PID)
                db.AddInParameter(dbComm, "@OB_Key", DbType.String, objFile1.OB_Key)
                db.AddInParameter(dbComm, "@OB_Qty", DbType.String, objFile1.OB_Qty)
                db.AddInParameter(dbComm, "@OB_MainQty", DbType.String, objFile1.OB_MainQty)
                db.AddInParameter(dbComm, "@OB_Price", DbType.String, objFile1.OB_Price)
                db.AddInParameter(dbComm, "@OB_Supplier", DbType.String, objFile1.OB_Supplier)
                db.AddInParameter(dbComm, "@OB_SupplierNo", DbType.String, objFile1.OB_SupplierNo)
                db.AddInParameter(dbComm, "@OB_Product", DbType.String, objFile1.OB_Product)
                db.AddInParameter(dbComm, "@OB_ProductNo", DbType.String, objFile1.OB_ProductNo)
                db.AddInParameter(dbComm, "@OB_ProductRemark", DbType.String, objFile1.OB_ProductRemark)
                db.AddInParameter(dbComm, "@OB_AccountCheck", DbType.String, objFile1.OB_AccountCheck)
                db.AddInParameter(dbComm, "@OB_AccountRemark", DbType.String, objFile1.OB_AccountRemark)
                db.AddInParameter(dbComm, "@OB_Make", DbType.String, objFile1.OB_Make)
                db.AddInParameter(dbComm, "@OB_MakeRemark", DbType.String, objFile1.OB_MakeRemark)
                db.AddInParameter(dbComm, "@OB_ID", DbType.String, objFile1.OB_ID)
                db.AddInParameter(dbComm, "@PM_LVL", DbType.String, objFile1.PM_LVL)

                db.AddInParameter(dbComm, "@M_CodeMouldNO", DbType.String, objFile1.M_CodeMouldNO)
                db.AddInParameter(dbComm, "@M_CodeType", DbType.String, objFile1.M_CodeType)
                db.AddInParameter(dbComm, "@OB_MakeDepartment", DbType.String, objFile1.OB_MakeDepartment)
                db.AddInParameter(dbComm, "@OB_MModeCusterNO", DbType.String, objFile1.OB_MModeCusterNO)
                db.AddInParameter(dbComm, "@M_Weight", DbType.String, objFile1.M_Weight)
                db.ExecuteNonQuery(dbComm)
                OrdersBom_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersBom_Add = False

            End Try

            'Else
            'MsgBox("已存在此記錄,請檢查!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            'End If
        End Function

        ''' <summary>
        ''' 物料清單修改---會計部審核
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersBom_Check_Update(ByVal objFile1 As OrdersBomInfo) As Boolean


            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersBom_Check_Update")

                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)
                db.AddInParameter(dbComm, "@OB_PID", DbType.String, objFile1.OB_PID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)
                db.AddInParameter(dbComm, "@OB_AccountCheck", DbType.String, objFile1.OB_AccountCheck)
                db.AddInParameter(dbComm, "@OB_AccountRemark", DbType.String, objFile1.OB_AccountRemark)
      

                db.ExecuteNonQuery(dbComm)
                OrdersBom_Check_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersBom_Check_Update = False

            End Try
        End Function

        ''' <summary>
        ''' 物料清單修改---再加工
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersBom_Make_Update(ByVal objFile1 As OrdersBomInfo) As Boolean


            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersBom_Make_Update")

                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)
                db.AddInParameter(dbComm, "@OB_Qty", DbType.String, objFile1.OB_Qty)
                db.AddInParameter(dbComm, "@OB_Make", DbType.String, objFile1.OB_Make)
                db.AddInParameter(dbComm, "@OB_MakeRemark", DbType.String, objFile1.OB_MakeRemark)

                db.AddInParameter(dbComm, "@M_CodeMouldNO", DbType.String, objFile1.M_CodeMouldNO)
                db.AddInParameter(dbComm, "@M_CodeType", DbType.String, objFile1.M_CodeType)
                db.AddInParameter(dbComm, "@OB_MakeDepartment", DbType.String, objFile1.OB_MakeDepartment)
                db.AddInParameter(dbComm, "@OB_MModeCusterNO", DbType.String, objFile1.OB_MModeCusterNO)
                db.AddInParameter(dbComm, "@M_Weight", DbType.String, objFile1.M_Weight)

                db.AddInParameter(dbComm, "@OB_PID", DbType.String, objFile1.OB_PID)
                db.ExecuteNonQuery(dbComm)
                OrdersBom_Make_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersBom_Make_Update = False

            End Try
        End Function
        Public Function OrdersBom_UpdateProduct(ByVal objinfo As OrdersBomInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersBom_UpdateProduct")

                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objinfo.OS_BatchID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@OB_Product", DbType.String, objinfo.OB_Product)
                db.AddInParameter(dbComm, "@OS_ProductAction", DbType.String, objinfo.OS_ProductAction)
                db.AddInParameter(dbComm, "@OB_Supplier", DbType.String, objinfo.OB_Supplier)
                db.AddInParameter(dbComm, "@OB_SupplierNo", DbType.String, objinfo.OB_SupplierNo)
                db.AddInParameter(dbComm, "@OB_ProductRemark", DbType.String, objinfo.OB_ProductRemark)
                db.ExecuteNonQuery(dbComm)
                OrdersBom_UpdateProduct = True
            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersBom_UpdateProduct = False
            End Try
        End Function
        ''' <summary>
        ''' 物料清單刪除
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersBom_Del(ByVal objFile1 As OrdersBomInfo) As Boolean

            Try


                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersBom_Del")

                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)

                db.ExecuteNonQuery(dbComm)
                OrdersBom_Del = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersBom_Del = False

            End Try
        End Function
        Public Function OrdersBom_Del_1(ByVal OS_BatchID As String, ByVal OB_Key As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersBom_Del_1")

                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
                db.AddInParameter(dbComm, "@OB_Key", DbType.String, OB_Key)

                db.ExecuteNonQuery(dbComm)
                OrdersBom_Del_1 = True
            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersBom_Del_1 = False
            End Try
        End Function

        
 
        Public Function OrdersBom_GetList(ByVal M_Code As String, ByVal OS_BatchID As String, ByVal OB_AccountCheck As String, ByVal PM_LVL As String) As List(Of OrdersBomInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersBom_GetList")

            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@OB_AccountCheck", DbType.String, OB_AccountCheck)
            db.AddInParameter(dbComm, "@PM_LVL", DbType.String, PM_LVL)

            Dim FeatureList As New List(Of OrdersBomInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOrdersBom(reader))
                End While
                Return FeatureList
            End Using


        End Function

        ''' <summary>
        ''' 取得對應數據
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Function FillOrdersBom(ByVal reader As IDataReader) As OrdersBomInfo
            '對應取得的數據
            On Error Resume Next
            Dim objInfo As New OrdersBomInfo
            objInfo.OS_BatchID = reader("OS_BatchID").ToString
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.OB_PID = reader("PM_PID").ToString
            objInfo.OB_Key = reader("PM_Key").ToString
            objInfo.OB_Qty = reader("PM_Qty").ToString
            objInfo.OB_MainQty = reader("OB_MainQty").ToString
            objInfo.OB_Price = reader("OB_Price").ToString
            objInfo.OB_Supplier = reader("M_Supplier").ToString
            objInfo.OB_SupplierNo = reader("M_SupplierNo").ToString
            objInfo.OB_Product = reader("OB_Product").ToString
            objInfo.OB_ProductNo = reader("OB_ProductNo").ToString
            objInfo.OB_ProductRemark = reader("OB_ProductRemark").ToString
            objInfo.OB_AccountCheck = reader("OB_AccountCheck")
            objInfo.OB_AccountRemark = reader("OB_AccountRemark").ToString
            objInfo.OB_Make = reader("PM_Make")
            objInfo.OB_MakeRemark = reader("PM_MakeRemark").ToString
            objInfo.OB_ID = reader("OB_ID").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.PM_LVL = reader("PM_LVL").ToString
            objInfo.M_SupplierName = reader("M_SupplierName").ToString

            objInfo.OB_MModeCusterNO = reader("OB_MModeCusterNO").ToString
            objInfo.OB_MakeDepartment = reader("OB_MakeDepartment").ToString
            objInfo.M_CodeMouldNO = reader("M_CodeMouldNO").ToString
            objInfo.M_CodeType = reader("M_CodeType").ToString
            objInfo.OS_ProductAction = reader("OS_ProductAction").ToString

            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            objInfo.OS_AddDate = reader("OS_AddDate").ToString
            objInfo.OS_EditDate = reader("OS_EditDate").ToString
            objInfo.OS_Check = reader("OS_Check")

            objInfo.AutoID = reader("AutoID")
            objInfo.M_Weight = reader("M_Weight").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            Return objInfo
        End Function

      

    End Class
End Namespace