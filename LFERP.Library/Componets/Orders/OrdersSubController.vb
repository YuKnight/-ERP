Namespace LFERP.Library.Orders
    Public Class OrdersSubController



        ''' <summary>
        ''' 取得對應數據
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Function FillOrdersSub(ByVal reader As IDataReader) As OrdersSubInfo
            '對應取得的數據
            On Error Resume Next
            Dim objInfo As New OrdersSubInfo
            objInfo.OM_ID = reader("OM_ID").ToString
            objInfo.OS_BatchID = reader("OS_BatchID").ToString
            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            objInfo.OS_Qty = reader("OS_Qty").ToString
            objInfo.OS_Sprace = reader("OS_Sprace").ToString
            objInfo.OS_SpraceQty = reader("OS_SpraceQty").ToString
            objInfo.OS_NoSendQty = reader("OS_NoSendQty").ToString
            objInfo.OS_NoOutQty = reader("OS_NoOutQty").ToString
            objInfo.OS_SendDate = Format(reader("OS_SendDate"), "yyyy/MM/dd")
            objInfo.OS_CheckDate = Format(reader("OS_CheckDate"), "yyyy/MM/dd")
            objInfo.OS_Price = reader("OS_Price").ToString
            objInfo.OS_Type = reader("OS_Type").ToString
            objInfo.OS_MakeDetail = reader("OS_MakeDetail").ToString
            objInfo.OS_Fac = reader("OS_Fac").ToString
            objInfo.OS_Plate = reader("OS_Plate").ToString
            objInfo.OS_ToHK = reader("OS_ToHK").ToString
            objInfo.OS_AccountCheck = reader("OS_AccountCheck").ToString
            objInfo.OS_AccountAction = reader("OS_AccountAction").ToString
            objInfo.OS_AccountRemark = reader("OS_AccountRemark").ToString
            If reader("OS_Check") Is DBNull.Value Then
                objInfo.OS_Check = Nothing
            Else
                objInfo.OS_Check = reader("OS_Check")
            End If
            'objInfo.OS_Check = reader("OS_Check").ToString
            objInfo.OS_Action = reader("OS_Action").ToString
            objInfo.OS_CheckRemark = reader("OS_CheckRemark").ToString
            objInfo.OS_Remark = reader("OS_Remark").ToString
            objInfo.OS_AddDate = Format(reader("OS_AddDate"), "yyyy/MM/dd HH:mm:ss")
            objInfo.OS_EditDate = Format(reader("OS_EditDate"), "yyyy/MM/dd HH:mm:ss")
            objInfo.OM_CusterID = reader("OM_CusterID").ToString
            objInfo.OM_CusterNo = reader("OM_CusterNo").ToString
            objInfo.OM_CusterPO = reader("OM_CusterPO").ToString
            objInfo.OM_No = reader("OM_No").ToString
            objInfo.FacName = reader("FacName").ToString
            objInfo.OS_CheckAction = reader("OS_CheckAction").ToString
            objInfo.OS_SendNeed = reader("OS_SendNeed").ToString
            objInfo.PM_JiYu = reader("PM_JiYu").ToString
            objInfo.U_Name = reader("U_Name").ToString
            objInfo.OS_SendType = reader("OS_SendType").ToString
            objInfo.PM_Rank = reader("PM_Rank").ToString
            objInfo.OS_ProductAction = reader("OS_ProductAction").ToString

            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_BatchID = reader("M_BatchID").ToString
            If reader("OS_ProductionWeek") Is DBNull.Value Then
                objInfo.OS_ProductionWeek = 0
            Else
                objInfo.OS_ProductionWeek = reader("OS_ProductionWeek")
            End If

            Return objInfo
        End Function

        ''' <summary>
        ''' 生產表查詢
        ''' </summary>
        ''' <param name="OS_BatchID"></param>
        ''' <returns></returns>
        ''' <remarks>精確查詢返回一條記錄</remarks>
        Public Function OrdersSub_Get(ByVal OS_BatchID As String) As OrdersSubInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersSub_Get")
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillOrdersSub(reader)
                End While
                Return Nothing
            End Using
        End Function
        ''' <summary>
        ''' 生產表查詢
        ''' </summary>
        ''' <param name="OS_BatchID"></param>
        ''' <returns></returns>
        ''' <remarks>模糊查詢返回一條記錄</remarks>
        Public Function OrdersSub_Get1(ByVal OS_BatchID As String) As OrdersSubInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersSub_Get1")
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillOrdersSub(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function OrdersSub_GetList(ByVal OM_ID As String, ByVal OS_BatchID As String, ByVal PM_M_Code As String, ByVal OS_Type As String, ByVal OS_MakeDetail As String, ByVal OS_Fac As String, ByVal OM_No As String, ByVal OM_CusterID As String, ByVal OM_CusterPO As String, ByVal OM_CusterNo As String, ByVal OS_Check As String) As List(Of OrdersSubInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersSub_GetList")
            db.AddInParameter(dbComm, "@OM_ID", DbType.String, OM_ID)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@OS_Type", DbType.String, OS_Type)
            db.AddInParameter(dbComm, "@OS_MakeDetail", DbType.String, OS_MakeDetail)
            db.AddInParameter(dbComm, "@OS_Fac", DbType.String, OS_Fac)
            db.AddInParameter(dbComm, "@OM_No", DbType.String, OM_No)

            db.AddInParameter(dbComm, "@OM_CusterID", DbType.String, OM_CusterID)
            db.AddInParameter(dbComm, "@OM_CusterPO", DbType.String, OM_CusterPO)
            db.AddInParameter(dbComm, "@OM_CusterNo", DbType.String, OM_CusterNo)
            db.AddInParameter(dbComm, "@OS_Check", DbType.String, OS_Check)

            Dim FeatureList As New List(Of OrdersSubInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOrdersSub(reader))
                End While
                Return FeatureList
            End Using
        End Function
        ''' <summary>
        ''' 返回查詢條件的前500條記錄
        ''' </summary>
        ''' <param name="OM_ID"></param>
        ''' <param name="OS_BatchID"></param>
        ''' <param name="PM_M_Code"></param>
        ''' <param name="OS_Type"></param>
        ''' <param name="OM_No"></param>
        ''' <param name="OS_Check"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersSub_GetList1(ByVal OM_ID As String, ByVal OS_BatchID As String, ByVal PM_M_Code As String, ByVal M_Code As String, ByVal OS_Type As String, ByVal OM_No As String, ByVal OS_Check As String) As List(Of OrdersSubInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersSub_GetList1")

            db.AddInParameter(dbComm, "@OM_ID", DbType.String, OM_ID)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@OS_Type", DbType.String, OS_Type)

            db.AddInParameter(dbComm, "@OM_No", DbType.String, OM_No)
            db.AddInParameter(dbComm, "@OS_Check", DbType.String, OS_Check)

            Dim FeatureList As New List(Of OrdersSubInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOrdersSub(reader))
                End While
                Return FeatureList
            End Using


        End Function
        ''' <summary>
        ''' 主要針對配件批次主界面的顯示
        ''' </summary>
        ''' <param name="OM_ID"></param>
        ''' <param name="OS_BatchID"></param>
        ''' <param name="PM_M_Code"></param>
        ''' <param name="OS_Type"></param>
        ''' <param name="OS_MakeDetail"></param>
        ''' <param name="OS_Fac"></param>
        ''' <param name="OM_No"></param>
        ''' <param name="OM_CusterID"></param>
        ''' <param name="OM_CusterPO"></param>
        ''' <param name="OM_CusterNo"></param>
        ''' <param name="OS_Check"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersSub_GetList2(ByVal OM_ID As String, ByVal OS_BatchID As String, ByVal PM_M_Code As String, ByVal OS_Type As String, ByVal OS_MakeDetail As String, ByVal OS_Fac As String, ByVal OM_No As String, ByVal OM_CusterID As String, ByVal OM_CusterPO As String, ByVal OM_CusterNo As String, ByVal OS_Check As String) As List(Of OrdersSubInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersSub_GetList2")
            db.AddInParameter(dbComm, "@OM_ID", DbType.String, OM_ID)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@OS_Type", DbType.String, OS_Type)
            db.AddInParameter(dbComm, "@OS_MakeDetail", DbType.String, OS_MakeDetail)
            db.AddInParameter(dbComm, "@OS_Fac", DbType.String, OS_Fac)
            db.AddInParameter(dbComm, "@OM_No", DbType.String, OM_No)

            db.AddInParameter(dbComm, "@OM_CusterID", DbType.String, OM_CusterID)
            db.AddInParameter(dbComm, "@OM_CusterPO", DbType.String, OM_CusterPO)
            db.AddInParameter(dbComm, "@OM_CusterNo", DbType.String, OM_CusterNo)
            db.AddInParameter(dbComm, "@OS_Check", DbType.String, OS_Check)

            Dim FeatureList As New List(Of OrdersSubInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOrdersSub(reader))
                End While
                Return FeatureList
            End Using

        End Function
        Public Function OrdersSub_UpdateCheck(ByVal Obj As OrdersSubInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersSub_UpdateCheck")

                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, Obj.OS_BatchID)
                db.AddInParameter(dbComm, "@OS_Check", DbType.Boolean, Obj.OS_Check)
                db.AddInParameter(dbComm, "@OS_CheckAction", DbType.String, Obj.OS_CheckAction)
                db.AddInParameter(dbComm, "@OS_CheckRemark", DbType.String, Obj.OS_CheckRemark)

                db.ExecuteNonQuery(dbComm)
                OrdersSub_UpdateCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersSub_UpdateCheck = False

            End Try

        End Function

        ''' <summary>
        ''' 生產表新增
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersSub_Add(ByVal objFile1 As OrdersSubInfo) As Boolean
            '   檢查項目是否已存在()
            Dim objSystemUserInfo As OrdersSubInfo = OrdersSub_Get(objFile1.OS_BatchID)
            If objSystemUserInfo Is Nothing Then

                Try
                    Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                    Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersSub_Add")
                    db.AddInParameter(dbComm, "@OM_ID", DbType.String, objFile1.OM_ID)
                    db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)
                    db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objFile1.PM_M_Code)
                    db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)
                    db.AddInParameter(dbComm, "@OS_Qty", DbType.String, objFile1.OS_Qty)
                    db.AddInParameter(dbComm, "@OS_Sprace", DbType.String, objFile1.OS_Sprace)
                    db.AddInParameter(dbComm, "@OS_SpraceQty", DbType.String, objFile1.OS_SpraceQty)
                    db.AddInParameter(dbComm, "@OS_NoSendQty", DbType.String, objFile1.OS_NoSendQty)
                    db.AddInParameter(dbComm, "@OS_NoOutQty", DbType.String, objFile1.OS_NoOutQty)
                    db.AddInParameter(dbComm, "@OS_SendDate", DbType.String, objFile1.OS_SendDate)
                    db.AddInParameter(dbComm, "@OS_CheckDate", DbType.String, objFile1.OS_CheckDate)
                    db.AddInParameter(dbComm, "@OS_Price", DbType.String, objFile1.OS_Price)
                    db.AddInParameter(dbComm, "@OS_Type", DbType.String, objFile1.OS_Type)
                    db.AddInParameter(dbComm, "@OS_MakeDetail", DbType.String, objFile1.OS_MakeDetail)
                    db.AddInParameter(dbComm, "@OS_Fac", DbType.String, objFile1.OS_Fac)
                    db.AddInParameter(dbComm, "@OS_Plate", DbType.String, objFile1.OS_Plate)
                    db.AddInParameter(dbComm, "@OS_ToHK", DbType.String, objFile1.OS_ToHK)
                    db.AddInParameter(dbComm, "@OS_AccountCheck", DbType.String, objFile1.OS_AccountCheck)
                    db.AddInParameter(dbComm, "@OS_AccountAction", DbType.String, objFile1.OS_AccountAction)
                    db.AddInParameter(dbComm, "@OS_AccountRemark", DbType.String, objFile1.OS_AccountRemark)
                    db.AddInParameter(dbComm, "@OS_Check", DbType.Boolean, objFile1.OS_Check)
                    db.AddInParameter(dbComm, "@OS_Action", DbType.String, objFile1.OS_Action)
                    db.AddInParameter(dbComm, "@OS_CheckAction", DbType.String, objFile1.OS_CheckAction)
                    db.AddInParameter(dbComm, "@OS_CheckRemark", DbType.String, objFile1.OS_CheckRemark)
                    db.AddInParameter(dbComm, "@OS_Remark", DbType.String, objFile1.OS_Remark)
                    db.AddInParameter(dbComm, "@OS_AddDate", DbType.String, objFile1.OS_AddDate)
                    db.AddInParameter(dbComm, "@OS_EditDate", DbType.String, objFile1.OS_EditDate)

                    db.AddInParameter(dbComm, "@OS_SendNeed", DbType.String, objFile1.OS_SendNeed)
                    db.AddInParameter(dbComm, "@OS_SendType", DbType.String, objFile1.OS_SendType)
                    db.AddInParameter(dbComm, "@M_BatchID", DbType.String, objFile1.M_BatchID)
                    db.AddInParameter(dbComm, "@OS_ProductionWeek", DbType.String, objFile1.OS_ProductionWeek)
                    db.ExecuteNonQuery(dbComm)
                    OrdersSub_Add = True

                Catch ex As Exception
                    MsgBox(ex.Message)
                    OrdersSub_Add = False

                End Try

            Else
                MsgBox("已存在此記錄,請檢查!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            End If
        End Function


        ''' <summary>
        ''' 生產表修改
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersSub_Update(ByVal objFile1 As OrdersSubInfo) As Boolean


            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersSub_Update")
                db.AddInParameter(dbComm, "@OM_ID", DbType.String, objFile1.OM_ID)
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objFile1.PM_M_Code)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)
                db.AddInParameter(dbComm, "@OS_Qty", DbType.String, objFile1.OS_Qty)
                db.AddInParameter(dbComm, "@OS_Sprace", DbType.String, objFile1.OS_Sprace)
                db.AddInParameter(dbComm, "@OS_SpraceQty", DbType.String, objFile1.OS_SpraceQty)
                'db.AddInParameter(dbComm, "@OS_NoSendQty", DbType.String, objFile1.OS_NoSendQty)
                'db.AddInParameter(dbComm, "@OS_NoOutQty", DbType.String, objFile1.OS_NoOutQty)
                db.AddInParameter(dbComm, "@OS_SendDate", DbType.String, objFile1.OS_SendDate)
                db.AddInParameter(dbComm, "@OS_CheckDate", DbType.String, objFile1.OS_CheckDate)
                db.AddInParameter(dbComm, "@OS_Price", DbType.String, objFile1.OS_Price)
                db.AddInParameter(dbComm, "@OS_Type", DbType.String, objFile1.OS_Type)
                db.AddInParameter(dbComm, "@OS_MakeDetail", DbType.String, objFile1.OS_MakeDetail)
                db.AddInParameter(dbComm, "@OS_Fac", DbType.String, objFile1.OS_Fac)
                db.AddInParameter(dbComm, "@OS_Plate", DbType.String, objFile1.OS_Plate)
                db.AddInParameter(dbComm, "@OS_ToHK", DbType.String, objFile1.OS_ToHK)
                db.AddInParameter(dbComm, "@OS_AccountCheck", DbType.String, objFile1.OS_AccountCheck)
                db.AddInParameter(dbComm, "@OS_AccountAction", DbType.String, objFile1.OS_AccountAction)
                db.AddInParameter(dbComm, "@OS_AccountRemark", DbType.String, objFile1.OS_AccountRemark)
                db.AddInParameter(dbComm, "@OS_Check", DbType.Boolean, objFile1.OS_Check)
                db.AddInParameter(dbComm, "@OS_Action", DbType.String, objFile1.OS_Action)
                db.AddInParameter(dbComm, "@OS_CheckAction", DbType.String, objFile1.OS_CheckAction)
                db.AddInParameter(dbComm, "@OS_CheckRemark", DbType.String, objFile1.OS_CheckRemark)
                db.AddInParameter(dbComm, "@OS_Remark", DbType.String, objFile1.OS_Remark)
                'db.AddInParameter(dbComm, "@OS_AddDate", DbType.String, objFile1.OS_AddDate)
                db.AddInParameter(dbComm, "@OS_EditDate", DbType.String, objFile1.OS_EditDate)

                db.AddInParameter(dbComm, "@OS_SendNeed", DbType.String, objFile1.OS_SendNeed)
                db.AddInParameter(dbComm, "@OS_SendType", DbType.String, objFile1.OS_SendType)
                db.AddInParameter(dbComm, "@M_BatchID", DbType.String, objFile1.M_BatchID)
                db.AddInParameter(dbComm, "@OS_ProductionWeek", DbType.String, objFile1.OS_ProductionWeek)
                db.ExecuteNonQuery(dbComm)
                OrdersSub_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersSub_Update = False

            End Try
        End Function

        ''' <summary>
        ''' 修改未交數
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersSub_UpdateNoSendQty(ByVal objFile1 As OrdersSubInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersSub_UpdateNoSendQty")
                db.AddInParameter(dbComm, "@OM_ID", DbType.String, objFile1.OM_ID)
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)
                db.AddInParameter(dbComm, "@OS_NoSendQty", DbType.String, objFile1.OS_NoSendQty)
                db.AddInParameter(dbComm, "@OS_NoOutQty", DbType.String, objFile1.OS_NoOutQty)

                db.ExecuteNonQuery(dbComm)
                OrdersSub_UpdateNoSendQty = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersSub_UpdateNoSendQty = False
            End Try
        End Function

        ''' <summary>
        ''' 生產表刪除
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersSub_Del(ByVal objFile1 As OrdersSubInfo) As Boolean


            Try


                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersSub_Del")

                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)

                db.ExecuteNonQuery(dbComm)
                OrdersSub_Del = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersSub_Del = False

            End Try
        End Function

        Public Function OrdersSub_GetReportList(ByVal OM_ID As String, ByVal OS_BatchID As String, ByVal PM_M_Code As String, ByVal OS_Type As String, ByVal OS_MakeDetail As String, ByVal OS_Fac As String, ByVal OM_No As String, ByVal OM_CusterID As String, ByVal OM_CusterPO As String, ByVal OM_CusterNo As String, ByVal OM_Date1 As String, ByVal OM_Date2 As String, ByVal OS_Check As String, ByVal NoSendQtyZero As String) As List(Of OrdersSubInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersSub_GetRePortList")

            db.AddInParameter(dbComm, "@OM_ID", DbType.String, OM_ID)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@OS_Type", DbType.String, OS_Type)
            db.AddInParameter(dbComm, "@OS_MakeDetail", DbType.String, OS_MakeDetail)
            db.AddInParameter(dbComm, "@OS_Fac", DbType.String, OS_Fac)
            db.AddInParameter(dbComm, "@OM_No", DbType.String, OM_No)

            db.AddInParameter(dbComm, "@OM_CusterID", DbType.String, OM_CusterID)
            db.AddInParameter(dbComm, "@OM_CusterPO", DbType.String, OM_CusterPO)
            db.AddInParameter(dbComm, "@OM_CusterNo", DbType.String, OM_CusterNo)
            db.AddInParameter(dbComm, "@OM_Date1", DbType.String, OM_Date1)
            db.AddInParameter(dbComm, "@OM_Date2", DbType.String, OM_Date2)

            db.AddInParameter(dbComm, "@OS_Check", DbType.String, OS_Check)

            db.AddInParameter(dbComm, "@NoSendQtyZero", DbType.String, NoSendQtyZero)

            Dim FeatureList As New List(Of OrdersSubInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOrdersSub(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function OrdersSub_GetList3(ByVal OM_ID As String, ByVal OS_BatchID As String, ByVal PM_M_Code As String, ByVal OS_Type As String, ByVal OS_MakeDetail As String, ByVal OS_Fac As String, ByVal OM_No As String, ByVal OM_CusterID As String, ByVal OM_CusterPO As String, ByVal OM_CusterNo As String, ByVal OM_Date1 As String, ByVal OM_Date2 As String, ByVal OS_Check As String) As List(Of OrdersSubInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersSub_GetList3")

            db.AddInParameter(dbComm, "@OM_ID", DbType.String, OM_ID)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@OS_Type", DbType.String, OS_Type)
            db.AddInParameter(dbComm, "@OS_MakeDetail", DbType.String, OS_MakeDetail)
            db.AddInParameter(dbComm, "@OS_Fac", DbType.String, OS_Fac)
            db.AddInParameter(dbComm, "@OM_No", DbType.String, OM_No)

            db.AddInParameter(dbComm, "@OM_CusterID", DbType.String, OM_CusterID)
            db.AddInParameter(dbComm, "@OM_CusterPO", DbType.String, OM_CusterPO)
            db.AddInParameter(dbComm, "@OM_CusterNo", DbType.String, OM_CusterNo)
            db.AddInParameter(dbComm, "@OM_Date1", DbType.String, OM_Date1)
            db.AddInParameter(dbComm, "@OM_Date2", DbType.String, OM_Date2)

            db.AddInParameter(dbComm, "@OS_Check", DbType.String, OS_Check)

            Dim FeatureList As New List(Of OrdersSubInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOrdersSub(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function OrdersSub_GetList4(ByVal OM_ID As String, ByVal OS_BatchID As String, ByVal PM_M_Code As String, ByVal OS_Type As String, ByVal OS_MakeDetail As String, ByVal OS_Fac As String, ByVal OM_No As String, ByVal OM_CusterID As String, ByVal OM_CusterPO As String, ByVal OM_CusterNo As String, ByVal OM_Date1 As String, ByVal OM_Date2 As String, ByVal OS_Check As String) As List(Of OrdersSubInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersSub_GetList4")

            db.AddInParameter(dbComm, "@OM_ID", DbType.String, OM_ID)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@OS_Type", DbType.String, OS_Type)
            db.AddInParameter(dbComm, "@OS_MakeDetail", DbType.String, OS_MakeDetail)
            db.AddInParameter(dbComm, "@OS_Fac", DbType.String, OS_Fac)
            db.AddInParameter(dbComm, "@OM_No", DbType.String, OM_No)

            db.AddInParameter(dbComm, "@OM_CusterID", DbType.String, OM_CusterID)
            db.AddInParameter(dbComm, "@OM_CusterPO", DbType.String, OM_CusterPO)
            db.AddInParameter(dbComm, "@OM_CusterNo", DbType.String, OM_CusterNo)
            db.AddInParameter(dbComm, "@OM_Date1", DbType.String, OM_Date1)
            db.AddInParameter(dbComm, "@OM_Date2", DbType.String, OM_Date2)

            db.AddInParameter(dbComm, "@OS_Check", DbType.String, OS_Check)

            Dim FeatureList As New List(Of OrdersSubInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOrdersSub(reader))
                End While
                Return FeatureList
            End Using

        End Function

    End Class
End Namespace
