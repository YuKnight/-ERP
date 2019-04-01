Namespace LFERP.Library.Orders
    Public Class OrdersDetailController


        ''' <summary>
        ''' 取得對應數據
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Function FillOrdersDetail(ByVal reader As IDataReader) As OrdersDetailInfo
            '對應取得的數據
            On Error Resume Next
            Dim objInfo As New OrdersDetailInfo
            objInfo.OS_BatchID = reader("OS_BatchID").ToString
            objInfo.OD_ID = reader("OD_ID").ToString
            objInfo.OD_Name = reader("OD_Name").ToString
            objInfo.OD_Detail = reader("OD_Detail").ToString

            objInfo.OM_CusterNO = reader("OM_CusterNO").ToString
            objInfo.PM_JiYu = reader("PM_JiYu").ToString
            objInfo.PM_M_Code = reader("PM_M_Code").ToString

            Return objInfo
        End Function


        ''' <summary>
        ''' 生產表項目內容查詢
        ''' </summary>
        ''' <param name="OS_BatchID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersDetail_GetList(ByVal OS_BatchID As String, ByVal OD_Name As String) As List(Of OrdersDetailInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersDetail_GetList")

            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@OD_Name", DbType.String, OD_Name)

            Dim FeatureList As New List(Of OrdersDetailInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOrdersDetail(reader))
                End While
                Return FeatureList
            End Using


        End Function
        Public Function OrdersDetail_Get(ByVal OD_ID As String) As OrdersDetailInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersDetail_Get")
            db.AddInParameter(dbComm, "@OD_ID", DbType.String, OD_ID)

            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillOrdersDetail(reader)
                End While
                Return Nothing
            End Using

        End Function
        ''' <summary>
        ''' 導入生成表中電鍍和打磨資料
        ''' </summary>
        ''' <param name="PM_M_Code"></param>
        ''' <param name="OS_BatchID"></param>
        ''' <param name="OD_Name"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersDetail_GetElectorPlate(ByVal PM_M_Code As String, ByVal OS_BatchID As String, ByVal OD_Name As String) As List(Of OrdersDetailInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersDetail_GetElectorPlate")

            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@OD_Name", DbType.String, OD_Name)

            Dim FeatureList As New List(Of OrdersDetailInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOrdersDetail(reader))
                End While
                Return FeatureList
            End Using

        End Function

        ''' <summary>
        ''' 生產表項目內容新增
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersDetail_Add(ByVal objFile1 As OrdersDetailInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersDetail_Add")
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)
                db.AddInParameter(dbComm, "@OD_Name", DbType.String, objFile1.OD_Name)
                db.AddInParameter(dbComm, "@OD_Detail", DbType.String, objFile1.OD_Detail)


                db.ExecuteNonQuery(dbComm)
                OrdersDetail_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersDetail_Add = False

            End Try


        End Function


        ''' <summary>
        ''' 生產表項目內容修改
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersDetail_Update(ByVal objFile1 As OrdersDetailInfo) As Boolean


            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersDetail_Update")

                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)
                db.AddInParameter(dbComm, "@OD_ID", DbType.String, objFile1.OD_ID)
                db.AddInParameter(dbComm, "@OD_Name", DbType.String, objFile1.OD_Name)
                db.AddInParameter(dbComm, "@OD_Detail", DbType.String, objFile1.OD_Detail)


                db.ExecuteNonQuery(dbComm)
                OrdersDetail_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersDetail_Update = False

            End Try
        End Function



        ''' <summary>
        ''' 生產表項目內容刪除 OD_ID
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersDetail_ODID_Del(ByVal objFile1 As OrdersDetailInfo) As Boolean


            Try


                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersDetail_ODID_Del")

                db.AddInParameter(dbComm, "@OD_ID", DbType.String, objFile1.OD_ID)

                db.ExecuteNonQuery(dbComm)
                OrdersDetail_ODID_Del = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersDetail_ODID_Del = False

            End Try
        End Function


        ''' <summary>
        ''' 生產表項目內容刪除 OS_BatchID
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersDetail_OSBatchID_Del(ByVal objFile1 As OrdersDetailInfo) As Boolean


            Try


                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersDetail_OSBatchID_Del")

                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)

                db.ExecuteNonQuery(dbComm)
                OrdersDetail_OSBatchID_Del = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersDetail_OSBatchID_Del = False

            End Try
        End Function
    End Class

End Namespace
