Namespace LFERP.Library.Orders
    Public Class OrdersMainController
        ''' <summary>
        ''' 訂單主表新增
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersMain_Add(ByVal objFile1 As OrdersMainInfo) As Boolean
            '   檢查項目是否已存在()
            'Dim objSystemUserInfo As OrdersMainInfo = OrdersMain_Get(objFile1.OM_No)
            'If objSystemUserInfo Is Nothing Then

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersMain_Add")
                db.AddInParameter(dbComm, "@OM_No", DbType.String, objFile1.OM_No)
                db.AddInParameter(dbComm, "@OM_CusterID", DbType.String, objFile1.OM_CusterID)
                db.AddInParameter(dbComm, "@OM_CusterPO", DbType.String, objFile1.OM_CusterPO)
                db.AddInParameter(dbComm, "@OM_CusterNO", DbType.String, objFile1.OM_CusterNO)

                If objFile1.OM_SendDate = Nothing Then
                    db.AddInParameter(dbComm, "@OM_SendDate", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@OM_SendDate", DbType.String, objFile1.OM_SendDate)
                End If

                If objFile1.OM_CheckDate = Nothing Then
                    db.AddInParameter(dbComm, "@OM_CheckDate", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@OM_CheckDate", DbType.String, objFile1.OM_CheckDate)
                End If


                db.AddInParameter(dbComm, "@OM_AddDate", DbType.String, objFile1.OM_AddDate)
                db.AddInParameter(dbComm, "@OM_EditDate", DbType.String, objFile1.OM_EditDate)

                If objFile1.OM_PoDate = Nothing Then
                    db.AddInParameter(dbComm, "@OM_PoDate", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@OM_PoDate", DbType.String, objFile1.OM_PoDate)
                End If

                db.AddInParameter(dbComm, "@OM_OrderQty", DbType.String, objFile1.OM_OrderQty)
                db.AddInParameter(dbComm, "@OM_NoMakeQty", DbType.String, objFile1.OM_NoMakeQty)
                db.AddInParameter(dbComm, "@OM_NoSendQty", DbType.String, objFile1.OM_NoSendQty)
                db.AddInParameter(dbComm, "@OM_NoOutQty", DbType.String, objFile1.OM_NoOutQty)
                db.AddInParameter(dbComm, "@OM_OrderSpare", DbType.String, objFile1.OM_OrderSpare)
                db.AddInParameter(dbComm, "@OM_CurrencyID", DbType.String, objFile1.OM_CurrencyID)
                db.AddInParameter(dbComm, "@OM_Action", DbType.String, objFile1.OM_Action)
                db.AddInParameter(dbComm, "@OM_Remark", DbType.String, objFile1.OM_Remark)
                db.AddInParameter(dbComm, "@OM_MakeDetail", DbType.String, objFile1.OM_MakeDetail)
                db.AddInParameter(dbComm, "@OM_Gauge", DbType.String, objFile1.OM_Gauge)

                If objFile1.CO_ID = Nothing Then
                    db.AddInParameter(dbComm, "@CO_ID", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@CO_ID", DbType.String, objFile1.CO_ID)
                End If
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objFile1.PM_M_Code)

                db.ExecuteNonQuery(dbComm)
                OrdersMain_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersMain_Add = False

            End Try

            'Else
            'MsgBox("已存在此記錄,請檢查!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            '  End If
        End Function
        '''2014.04.21 鄭少釗
        ''' <summary>
        ''' 訂單主表新增（MRP Excel導入）
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersMain_Add_MRP(ByVal objFile1 As OrdersMainInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersMain_Add_MRP")
                db.AddInParameter(dbComm, "@OM_No", DbType.String, objFile1.OM_No)
                db.AddInParameter(dbComm, "@OM_CusterID", DbType.String, objFile1.OM_CusterID)
                db.AddInParameter(dbComm, "@OM_CusterPO", DbType.String, objFile1.OM_CusterPO)
                db.AddInParameter(dbComm, "@OM_CusterNO", DbType.String, objFile1.OM_CusterNO)

                If objFile1.OM_SendDate = Nothing Then
                    db.AddInParameter(dbComm, "@OM_SendDate", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@OM_SendDate", DbType.String, objFile1.OM_SendDate)
                End If

                If objFile1.OM_CheckDate = Nothing Then
                    db.AddInParameter(dbComm, "@OM_CheckDate", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@OM_CheckDate", DbType.String, objFile1.OM_CheckDate)
                End If


                db.AddInParameter(dbComm, "@OM_AddDate", DbType.String, objFile1.OM_AddDate)
                db.AddInParameter(dbComm, "@OM_EditDate", DbType.String, objFile1.OM_EditDate)

                If objFile1.OM_PoDate = Nothing Then
                    db.AddInParameter(dbComm, "@OM_PoDate", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@OM_PoDate", DbType.String, objFile1.OM_PoDate)
                End If

                db.AddInParameter(dbComm, "@OM_OrderQty", DbType.String, objFile1.OM_OrderQty)
                db.AddInParameter(dbComm, "@OM_NoMakeQty", DbType.String, objFile1.OM_NoMakeQty)
                db.AddInParameter(dbComm, "@OM_NoSendQty", DbType.String, objFile1.OM_NoSendQty)
                db.AddInParameter(dbComm, "@OM_NoOutQty", DbType.String, objFile1.OM_NoOutQty)
                db.AddInParameter(dbComm, "@OM_OrderSpare", DbType.String, objFile1.OM_OrderSpare)
                db.AddInParameter(dbComm, "@OM_CurrencyID", DbType.String, objFile1.OM_CurrencyID)
                db.AddInParameter(dbComm, "@OM_Action", DbType.String, objFile1.OM_Action)
                db.AddInParameter(dbComm, "@OM_Remark", DbType.String, objFile1.OM_Remark)
                db.AddInParameter(dbComm, "@OM_MakeDetail", DbType.String, objFile1.OM_MakeDetail)
                db.AddInParameter(dbComm, "@OM_Gauge", DbType.String, objFile1.OM_Gauge)

                If objFile1.CO_ID = Nothing Then
                    db.AddInParameter(dbComm, "@CO_ID", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@CO_ID", DbType.String, objFile1.CO_ID)
                End If
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objFile1.PM_M_Code)
                db.AddInParameter(dbComm, "@FColorPercent", DbType.String, objFile1.FColorPercent)
                db.AddInParameter(dbComm, "@FQianQty", DbType.String, objFile1.FQianQty)
                db.ExecuteNonQuery(dbComm)
                OrdersMain_Add_MRP = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersMain_Add_MRP = False
            End Try
        End Function

        ''' <summary>
        ''' 訂單主表修改
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersMain_Update(ByVal objFile1 As OrdersMainInfo) As Boolean


            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersMain_Update")

                db.AddInParameter(dbComm, "@OM_ID", DbType.String, objFile1.OM_ID)
                db.AddInParameter(dbComm, "@OM_CusterNO", DbType.String, objFile1.OM_CusterNO)

                If objFile1.OM_CusterPO = Nothing Then
                    db.AddInParameter(dbComm, "@OM_CusterPO", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@OM_CusterPO", DbType.String, objFile1.OM_CusterPO)
                End If

                If objFile1.OM_SendDate = Nothing Then
                    db.AddInParameter(dbComm, "@OM_SendDate", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@OM_SendDate", DbType.String, objFile1.OM_SendDate)
                End If


                If objFile1.OM_CheckDate = Nothing Then
                    db.AddInParameter(dbComm, "@OM_CheckDate", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@OM_CheckDate", DbType.String, objFile1.OM_CheckDate)
                End If

                db.AddInParameter(dbComm, "@OM_EditDate", DbType.String, objFile1.OM_EditDate)


                db.AddInParameter(dbComm, "@OM_OrderQty", DbType.String, objFile1.OM_OrderQty)
                db.AddInParameter(dbComm, "@OM_OrderSpare", DbType.String, objFile1.OM_OrderSpare)
                db.AddInParameter(dbComm, "@OM_Action", DbType.String, objFile1.OM_Action)
                db.AddInParameter(dbComm, "@OM_Remark", DbType.String, objFile1.OM_Remark)
                db.AddInParameter(dbComm, "@OM_Gauge", DbType.String, objFile1.OM_Gauge)

                If objFile1.CO_ID = Nothing Then
                    db.AddInParameter(dbComm, "@CO_ID", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@CO_ID", DbType.String, objFile1.CO_ID)
                End If
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objFile1.PM_M_Code)

                db.ExecuteNonQuery(dbComm)
                OrdersMain_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersMain_Update = False

            End Try
        End Function

        '2014-02-20 姚駿
        Public Function OrderControl_GetList(ByVal OM_CusterID As String, ByVal OM_StartPoDate As String, ByVal OM_EndPoDate As String, ByVal OM_SendStartDate As String, ByVal OM_SendEndDate As String, ByVal TypeVel As String, ByVal Type3ID As String) As List(Of OrdersMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OrderControl_GetList")

            db.AddInParameter(dbComm, "@OM_CusterID", DbType.String, OM_CusterID)
            db.AddInParameter(dbComm, "@OM_StartPoDate", DbType.String, OM_StartPoDate)
            db.AddInParameter(dbComm, "@OM_EndPoDate", DbType.String, OM_EndPoDate)
            db.AddInParameter(dbComm, "@OM_SendStartDate", DbType.String, OM_SendStartDate)
            db.AddInParameter(dbComm, "@OM_SendEndDate", DbType.String, OM_SendEndDate)
            db.AddInParameter(dbComm, "@TypeVel", DbType.String, TypeVel)
            db.AddInParameter(dbComm, "@Type3ID", DbType.String, Type3ID)

            Dim FeatureList As New List(Of OrdersMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOrdersMain(reader))
                End While
                Return FeatureList
            End Using
        End Function

        ''' <summary>
        ''' 訂單主表刪除(某訂單號)
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersMain_OMNo_Del(ByVal objFile1 As OrdersMainInfo) As Boolean


            Try


                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersMain_OMNo_Del")

                db.AddInParameter(dbComm, "@OM_No", DbType.String, objFile1.OM_No)

                db.ExecuteNonQuery(dbComm)
                OrdersMain_OMNo_Del = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersMain_OMNo_Del = False

            End Try
        End Function

        ''' <summary>
        ''' 訂單主表刪除(某流水號)
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersMain_OMID_Del(ByVal objFile1 As OrdersMainInfo) As Boolean


            Try


                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersMain_OMID_Del")

                db.AddInParameter(dbComm, "@OM_ID", DbType.String, objFile1.OM_ID)

                db.ExecuteNonQuery(dbComm)
                OrdersMain_OMID_Del = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersMain_OMID_Del = False

            End Try
        End Function

        ''' <summary>
        ''' 訂單主表查詢
        ''' </summary>
        ''' <param name="OM_No"></param>
        ''' <param name="OM_CusterID"></param>
        ''' <param name="OM_CusterPO"></param>
        ''' <param name="OM_CusterNo"></param>
        ''' <param name="OM_MakeDetail"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersMain_GetList(ByVal OM_No As String, ByVal OM_CusterID As String, ByVal OM_CusterPO As String, ByVal OM_CusterNo As String, ByVal OM_MakeDetail As String, ByVal OM_ID As String) As List(Of OrdersMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersMain_GetList")
            db.AddInParameter(dbComm, "@OM_No", DbType.String, OM_No)
            db.AddInParameter(dbComm, "@OM_CusterID", DbType.String, OM_CusterID)
            db.AddInParameter(dbComm, "@OM_CusterPO", DbType.String, OM_CusterPO)
            db.AddInParameter(dbComm, "@OM_CusterNo", DbType.String, OM_CusterNo)
            db.AddInParameter(dbComm, "@OM_MakeDetail", DbType.String, OM_MakeDetail)
            db.AddInParameter(dbComm, "@OM_ID", DbType.String, OM_ID)
            Dim FeatureList As New List(Of OrdersMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOrdersMain(reader))
                End While
                Return FeatureList
            End Using
        End Function
        ''' <summary>
        ''' 訂單主表查詢，返回前500條記錄
        ''' </summary>
        ''' <param name="OM_No"></param>
        ''' <param name="OM_ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersMain_GetList2(ByVal OM_No As String, ByVal OM_ID As String) As List(Of OrdersMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersMain_GetList2")
            db.AddInParameter(dbComm, "@OM_No", DbType.String, OM_No)
            db.AddInParameter(dbComm, "@OM_ID", DbType.String, OM_ID)
            Dim FeatureList As New List(Of OrdersMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOrdersMain(reader))
                End While
                Return FeatureList
            End Using
        End Function
        ''' <summary>
        ''' 訂單主表查詢
        ''' </summary>
        ''' <param name="OM_No"></param>
        ''' <param name="OM_CusterID"></param>
        ''' <param name="OM_CusterPO"></param>
        ''' <param name="OM_CusterNo"></param>
        ''' <param name="OM_MakeDetail"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersMain_GetList1(ByVal OM_No As String, ByVal OM_CusterID As String, ByVal OM_CusterPO As String, ByVal OM_CusterNo As String, ByVal OM_MakeDetail As String, ByVal OM_ID As String, ByVal OM_PriceCheck As String, ByVal OM_PriceReCheck As String, ByVal OM_Check As String, ByVal OM_PoDateBegin As String, ByVal OM_PoDateEnd As String) As List(Of OrdersMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersMain_GetList1")
            db.AddInParameter(dbComm, "@OM_No", DbType.String, OM_No)
            db.AddInParameter(dbComm, "@OM_CusterID", DbType.String, OM_CusterID)
            db.AddInParameter(dbComm, "@OM_CusterPO", DbType.String, OM_CusterPO)
            db.AddInParameter(dbComm, "@OM_CusterNo", DbType.String, OM_CusterNo)
            db.AddInParameter(dbComm, "@OM_MakeDetail", DbType.String, OM_MakeDetail)

            db.AddInParameter(dbComm, "@OM_ID", DbType.String, OM_ID)
            db.AddInParameter(dbComm, "@OM_PriceCheck", DbType.String, OM_PriceCheck)
            db.AddInParameter(dbComm, "@OM_PriceReCheck", DbType.String, OM_PriceReCheck)
            db.AddInParameter(dbComm, "@OM_Check", DbType.String, OM_Check)
            db.AddInParameter(dbComm, "@OM_PoDateBegin", DbType.String, OM_PoDateBegin)

            db.AddInParameter(dbComm, "@OM_PoDateEnd", DbType.String, OM_PoDateEnd)
            Dim FeatureList As New List(Of OrdersMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOrdersMain(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function OrdersMain_GetList3(ByVal OM_No As String, ByVal OM_CusterID As String, ByVal OM_CusterPO As String, ByVal OM_CusterNo As String, ByVal OM_MakeDetail As String, ByVal OM_ID As String, ByVal OM_PriceCheck As String, ByVal OM_PriceReCheck As String, ByVal OM_Check As String, ByVal OM_PoDateBegin As String, ByVal OM_PoDateEnd As String, ByVal PM_M_Code As String) As List(Of OrdersMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersMain_GetList3")
            db.AddInParameter(dbComm, "@OM_No", DbType.String, OM_No)
            db.AddInParameter(dbComm, "@OM_CusterID", DbType.String, OM_CusterID)
            db.AddInParameter(dbComm, "@OM_CusterPO", DbType.String, OM_CusterPO)
            db.AddInParameter(dbComm, "@OM_CusterNo", DbType.String, OM_CusterNo)
            db.AddInParameter(dbComm, "@OM_MakeDetail", DbType.String, OM_MakeDetail)

            db.AddInParameter(dbComm, "@OM_ID", DbType.String, OM_ID)
            db.AddInParameter(dbComm, "@OM_PriceCheck", DbType.String, OM_PriceCheck)
            db.AddInParameter(dbComm, "@OM_PriceReCheck", DbType.String, OM_PriceReCheck)
            db.AddInParameter(dbComm, "@OM_Check", DbType.String, OM_Check)
            db.AddInParameter(dbComm, "@OM_PoDateBegin", DbType.String, OM_PoDateBegin)

            db.AddInParameter(dbComm, "@OM_PoDateEnd", DbType.String, OM_PoDateEnd)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            Dim FeatureList As New List(Of OrdersMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOrdersMain(reader))
                End While
                Return FeatureList
            End Using
        End Function
        ''' <summary>
        ''' 讀取當前最大訂單單號
        ''' </summary>
        ''' <param name="OM_No"></param>
        ''' <param name="OM_ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersMain_Get(ByVal OM_No As String, ByVal OM_ID As String) As OrdersMainInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersMain_Get")
            db.AddInParameter(dbComm, "@OM_No", DbType.String, OM_No)
            db.AddInParameter(dbComm, "@OM_ID", DbType.String, OM_ID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillOrdersMain(reader)
                End While
                Return Nothing
            End Using
        End Function



        ''' <summary>
        ''' 設置當前訂單單項單價----物流部
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>   
        Public Function OrdersMain_UpdatePrice(ByVal objinfo As OrdersMainInfo) As Boolean
            Try


                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersMain_UpdatePrice")

                db.AddInParameter(dbComm, "@OM_ID", DbType.String, objinfo.OM_ID)
                db.AddInParameter(dbComm, "@OM_Price", DbType.Decimal, objinfo.OM_Price)

                db.ExecuteNonQuery(dbComm)
                OrdersMain_UpdatePrice = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersMain_UpdatePrice = False

            End Try
        End Function
        ''' <summary>
        ''' 審核當前訂單單項單價----營業部
        ''' </summary>
        ''' <param name="Objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersMain_UpdateCheck(ByVal Objinfo As OrdersMainInfo) As Boolean
            Try


                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersMain_UpdateCheck")

                db.AddInParameter(dbComm, "@OM_ID", DbType.String, Objinfo.OM_ID)
                db.AddInParameter(dbComm, "@OM_PriceCheck", DbType.Boolean, Objinfo.OM_PriceCheck)

                db.ExecuteNonQuery(dbComm)
                OrdersMain_UpdateCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersMain_UpdateCheck = False

            End Try
        End Function
        ''' <summary>
        ''' 鎖定當前訂單單項單價----會計部
        ''' </summary>
        ''' <param name="Objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersMain_UpdateReCheck(ByVal Objinfo As OrdersMainInfo) As Boolean
            Try


                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersMain_UpdateReCheck")

                db.AddInParameter(dbComm, "@OM_ID", DbType.String, Objinfo.OM_ID)
                db.AddInParameter(dbComm, "@OM_PriceReCheck", DbType.Boolean, Objinfo.OM_PriceReCheck)

                db.ExecuteNonQuery(dbComm)
                OrdersMain_UpdateReCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersMain_UpdateReCheck = False

            End Try
        End Function

        Public Function OrdersMain_Check(ByVal objinfo As OrdersMainInfo) As Boolean
            Try


                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersMain_Check")

                db.AddInParameter(dbComm, "@OM_No", DbType.String, objinfo.OM_No)
                db.AddInParameter(dbComm, "@OM_Check", DbType.Boolean, objinfo.OM_Check)

                db.ExecuteNonQuery(dbComm)
                OrdersMain_Check = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersMain_Check = False

            End Try

        End Function

        ''' <summary>
        ''' 取得對應數據
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Function FillOrdersMain(ByVal reader As IDataReader) As OrdersMainInfo
            '對應取得的數據
            On Error Resume Next
            Dim objInfo As New OrdersMainInfo
            objInfo.OM_No = reader("OM_No").ToString
            objInfo.OM_CusterID = reader("OM_CusterID").ToString
            objInfo.OM_ID = reader("OM_ID").ToString
            objInfo.OM_CusterPO = reader("OM_CusterPO").ToString
            objInfo.OM_CusterNO = reader("OM_CusterNO").ToString


            If reader("OM_SendDate") Is DBNull.Value Then
                objInfo.OM_SendDate = ""
            Else
                objInfo.OM_SendDate = CDate(reader("OM_SendDate").ToString)
            End If
            If reader("OM_CheckDate") Is DBNull.Value Then
                objInfo.OM_CheckDate = ""
            Else
                objInfo.OM_CheckDate = CDate(reader("OM_CheckDate").ToString)
            End If
            If reader("OM_AddDate") Is DBNull.Value Then
                objInfo.OM_AddDate = ""
            Else
                objInfo.OM_AddDate = CStr(reader("OM_AddDate").ToString)
            End If
            If reader("OM_EditDate") Is DBNull.Value Then
                objInfo.OM_EditDate = ""
            Else
                objInfo.OM_EditDate = CStr(reader("OM_EditDate").ToString)
            End If
            If reader("OM_PoDate") Is DBNull.Value Then
                objInfo.OM_PoDate = ""
            Else
                objInfo.OM_PoDate = CDate(reader("OM_PoDate").ToString)
            End If
            'objInfo.OM_SendDate = reader("OM_SendDate").ToString
            'objInfo.OM_CheckDate = reader("OM_CheckDate").ToString
            'objInfo.OM_AddDate = reader("OM_AddDate").ToString
            'objInfo.OM_EditDate = reader("OM_EditDate").ToString
            'objInfo.OM_PoDate = reader("OM_PoDate").ToString

            objInfo.OM_OrderQty = reader("OM_OrderQty").ToString
            objInfo.OM_NoMakeQty = reader("OM_NoMakeQty").ToString
            objInfo.OM_NoSendQty = reader("OM_NoSendQty").ToString
            objInfo.OM_NoOutQty = reader("OM_NoOutQty").ToString
            objInfo.OM_OrderSpare = reader("OM_OrderSpare").ToString
            objInfo.OM_CurrencyID = reader("OM_CurrencyID").ToString
            objInfo.OM_Action = reader("OM_Action").ToString
            objInfo.OM_Remark = reader("OM_Remark").ToString
            objInfo.OM_MakeDetail = reader("OM_MakeDetail").ToString
            objInfo.OM_Gauge = reader("OM_Gauge").ToString
            objInfo.CO_ID = reader("CO_ID").ToString

            objInfo.OM_Price = reader("OM_Price").ToString

            If reader("OM_PriceCheck") Is DBNull.Value Then
                objInfo.OM_PriceCheck = False
            Else
                objInfo.OM_PriceCheck = reader("OM_PriceCheck")
            End If

            If reader("OM_PriceReCheck") Is DBNull.Value Then
                objInfo.OM_PriceReCheck = False
            Else
                objInfo.OM_PriceReCheck = reader("OM_PriceReCheck")
            End If
            If reader("OM_Check") Is DBNull.Value Then
                objInfo.OM_Check = False
            Else
                objInfo.OM_Check = reader("OM_Check")
            End If

            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            objInfo.PM_JiYu = reader("PM_JiYu").ToString


            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Name = reader("M_Name").ToString

            objInfo.OS_BatchID = reader("OS_BatchID").ToString
            objInfo.WI_Qty = reader("WI_Qty")

            objInfo.OM_CheckA = reader("OM_CheckA")
            objInfo.OM_CheckAAction = reader("OM_CheckAAction").ToString
            objInfo.OM_CheckAActionName = reader("OM_CheckAActionName").ToString
            objInfo.OM_CheckADate = reader("OM_CheckADate")


            objInfo.M_Price = reader("M_Price")
            objInfo.M_Currency = reader("M_Currency").ToString

            ''--------------------
            objInfo.FP_Qty = reader("FP_Qty")
            objInfo.BadQty = reader("BadQty")

            objInfo.OW_Qty = reader("OW_Qty")
            objInfo.SumQty = reader("SumQty")

            '2014-02-20 姚駿--------------------------------------
            objInfo.VProWI_Qty = reader("VProWI_Qty").ToString
            objInfo.VProWI_ReQty = reader("VProWI_ReQty").ToString
            '-----------------------------------------------------

            '2014-04-21 鄭少釗--------------------------------------
            objInfo.FColorPercent = reader("FColorPercent")
            objInfo.FQianQty = reader("FQianQty")
            '-----------------------------------------------------
            Return objInfo

        End Function


        ''''批次交貨情況
        Public Function OrdersMainAndSub_GetCusterID() As List(Of OrdersMainInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("OrdersMainAndSub_GetCusterID")

            Dim FeatureList As New List(Of OrdersMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillOrdersMainCusterID(reader))
                End While
            End Using
            Return FeatureList

        End Function

        Public Function OrdersMainAndSub_GetList(ByVal OM_CusterID As String, ByVal OM_PoDate1 As String, ByVal OM_PoDate2 As String, ByVal OM_SendDate1 As String, ByVal OM_SendDate2 As String) As List(Of OrdersMainInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("OrdersMainAndSub_GetList")

            db.AddInParameter(dbcomm, "@OM_CusterID", DbType.String, OM_CusterID)
            db.AddInParameter(dbcomm, "@OM_PoDate1", DbType.String, OM_PoDate1)
            db.AddInParameter(dbcomm, "@OM_PoDate2", DbType.String, OM_PoDate2)
            db.AddInParameter(dbcomm, "@OM_SendDate1", DbType.String, OM_SendDate1)
            db.AddInParameter(dbcomm, "@OM_SendDate2", DbType.String, OM_SendDate2)

            Dim FeatureList As New List(Of OrdersMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    '' isValue = True
                    FeatureList.Add(FillOrdersMain(reader))
                End While
            End Using
            Return FeatureList

        End Function

        Friend Function FillOrdersMainCusterID(ByVal reader As IDataReader) As OrdersMainInfo
            Dim oinfo As New OrdersMainInfo

            oinfo.OM_CusterID = reader("OM_CusterID").ToString
            Return oinfo
        End Function



        Public Function OrdersMainAndSub_GetList1(ByVal OM_CusterID As String, ByVal OM_PoDate1 As String, ByVal OM_PoDate2 As String, ByVal OM_SendDate1 As String, ByVal OM_SendDate2 As String, ByVal TypeVel As String) As List(Of OrdersMainInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("OrdersMainAndSub_GetList1")

            db.AddInParameter(dbcomm, "@OM_CusterID", DbType.String, OM_CusterID)
            db.AddInParameter(dbcomm, "@OM_PoDate1", DbType.String, OM_PoDate1)
            db.AddInParameter(dbcomm, "@OM_PoDate2", DbType.String, OM_PoDate2)
            db.AddInParameter(dbcomm, "@OM_SendDate1", DbType.String, OM_SendDate1)
            db.AddInParameter(dbcomm, "@OM_SendDate2", DbType.String, OM_SendDate2)
            db.AddInParameter(dbcomm, "@TypeVel", DbType.String, TypeVel)

            Dim FeatureList As New List(Of OrdersMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillOrdersMain(reader))
                End While
            End Using
            Return FeatureList

        End Function

        ''' <summary>
        ''' 2014-06-14
        ''' 姚      駿
        ''' </summary>
        ''' <param name="OM_CusterID"></param>
        ''' <param name="OM_PoDate1"></param>
        ''' <param name="OM_PoDate2"></param>
        ''' <param name="OM_SendDate1"></param>
        ''' <param name="OM_SendDate2"></param>
        ''' <param name="TypeVel"></param>
        ''' <param name="Type3ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersMainAndSub_GetList2(ByVal OM_CusterID As String, ByVal OM_PoDate1 As String, ByVal OM_PoDate2 As String, ByVal OM_SendDate1 As String, ByVal OM_SendDate2 As String, ByVal TypeVel As String, ByVal Type3ID As String) As List(Of OrdersMainInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("OrdersMainAndSub_GetList2")

            db.AddInParameter(dbcomm, "@OM_CusterID", DbType.String, OM_CusterID)
            db.AddInParameter(dbcomm, "@OM_PoDate1", DbType.String, OM_PoDate1)
            db.AddInParameter(dbcomm, "@OM_PoDate2", DbType.String, OM_PoDate2)
            db.AddInParameter(dbcomm, "@OM_SendDate1", DbType.String, OM_SendDate1)
            db.AddInParameter(dbcomm, "@OM_SendDate2", DbType.String, OM_SendDate2)
            db.AddInParameter(dbcomm, "@TypeVel", DbType.String, TypeVel)
            db.AddInParameter(dbcomm, "@Type3ID", DbType.String, Type3ID)

            Dim FeatureList As New List(Of OrdersMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillOrdersMain(reader))
                End While
            End Using
            Return FeatureList
        End Function

        Public Function OrdersMain_UpdateCheckA(ByVal objinfo As OrdersMainInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersMain_UpdateCheckA")

                db.AddInParameter(dbComm, "@OM_ID", DbType.String, objinfo.OM_ID)
                db.AddInParameter(dbComm, "@OM_CheckA", DbType.Boolean, objinfo.OM_CheckA)
                db.AddInParameter(dbComm, "@OM_CheckAAction", DbType.String, objinfo.OM_CheckAAction)
                db.AddInParameter(dbComm, "@OM_CheckADate", DbType.Date, objinfo.OM_CheckADate)
                db.ExecuteNonQuery(dbComm)
                OrdersMain_UpdateCheckA = True
            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersMain_UpdateCheckA = False
            End Try
        End Function

        ''' <summary>
        ''' 2014-06-24
        ''' 姚     駿
        ''' 修改備註
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersMain_UpdateRemark(ByVal objinfo As OrdersMainInfo) As Boolean
            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersMain_UpdateRemark")
                db.AddInParameter(dbComm, "@OM_ID", DbType.String, objinfo.OM_ID)
                db.AddInParameter(dbComm, "@OM_Remark", DbType.String, objinfo.OM_Remark)
                If objinfo.OM_SendDate <> Nothing Then
                    db.AddInParameter(dbComm, "@OM_SendDate", DbType.DateTime, objinfo.OM_SendDate)
                Else
                    db.AddInParameter(dbComm, "@OM_SendDate", DbType.DateTime, Nothing)
                End If
                db.ExecuteNonQuery(dbComm)
                OrdersMain_UpdateRemark = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersMain_UpdateRemark = False
            End Try

        End Function

        ''' <summary>
        ''' 查詢出無單價有訂單編碼的信息
        ''' </summary>
        ''' <param name="O_Date1"></param>
        ''' <param name="O_Date2"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersMain_GetListNoPrice(ByVal O_Date1 As String, ByVal O_Date2 As String) As List(Of OrdersMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersMain_GetListNoPrice")

            db.AddInParameter(dbComm, "@O_Date1", DbType.String, O_Date1)
            db.AddInParameter(dbComm, "@O_Date2", DbType.String, O_Date2)

            Dim FeatureList As New List(Of OrdersMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOrdersMain(reader))
                End While
                Return FeatureList
            End Using
        End Function

        ''' <summary>
        ''' 產品整體流轉記錄
        ''' </summary>
        ''' <param name="PM_M_Code"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersMainProduction_GetList(ByVal PM_M_Code As String, ByVal Date1 As String, ByVal Date2 As String, ByVal Type As String) As List(Of OrdersMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersMainProduction_GetList")

            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@Date1", DbType.String, Date1)
            db.AddInParameter(dbComm, "@Date2", DbType.String, Date2)
            db.AddInParameter(dbComm, "@Type", DbType.String, Type)

            Dim FeatureList As New List(Of OrdersMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOrdersMain(reader))
                End While
                Return FeatureList
            End Using
        End Function


        Public Function OrdersMainProduction_GetListQty(ByVal PM_M_Code As String, ByVal Date1 As String, ByVal Date2 As String, ByVal Type As String) As List(Of OrdersMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersMainProduction_GetListQty")

            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@Date1", DbType.String, Date1)
            db.AddInParameter(dbComm, "@Date2", DbType.String, Date2)
            db.AddInParameter(dbComm, "@Type", DbType.String, Type)

            Dim FeatureList As New List(Of OrdersMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOrdersMain(reader))
                End While
                Return FeatureList
            End Using
        End Function

        ''' <summary>
        ''' 讀取當前最大訂單單號(以年份和月份生成)
        ''' </summary>
        ''' <param name="OM_No"></param>
        ''' <param name="OM_ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersMain_GetOne(ByVal OM_No As String, ByVal OM_ID As String) As OrdersMainInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersMain_GetOne")
            db.AddInParameter(dbComm, "@OM_No", DbType.String, OM_No)
            db.AddInParameter(dbComm, "@OM_ID", DbType.String, OM_ID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillOrdersMain(reader)
                End While
                Return Nothing
            End Using
        End Function

    End Class
End Namespace