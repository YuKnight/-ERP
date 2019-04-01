Namespace LFERP.Library.WareHouse.WareMove
    Public Class WareMoveController

        ''' <summary>
        ''' 新增
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareMove_Add(ByVal objFile1 As WareMoveInfo) As Boolean


            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareMove_Add")
                db.AddInParameter(dbComm, "@MV_NO", DbType.String, objFile1.MV_NO)
                db.AddInParameter(dbComm, "@MV_Number", DbType.String, objFile1.MV_Number)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)
                db.AddInParameter(dbComm, "@M_Name", DbType.String, objFile1.M_Name)
                db.AddInParameter(dbComm, "@MV_Qty", DbType.Double, objFile1.MV_Qty)
                db.AddInParameter(dbComm, "@MV_Date", DbType.String, objFile1.MV_Date)
                db.AddInParameter(dbComm, "@DepotNO", DbType.String, objFile1.DepotNO)
                db.AddInParameter(dbComm, "@MV_ChangeDepotNO", DbType.String, objFile1.MV_ChangeDepotNO)

                db.AddInParameter(dbComm, "@MV_Property", DbType.String, objFile1.MV_Property)
                db.AddInParameter(dbComm, "@MV_OutAction", DbType.String, objFile1.MV_OutAction)


                If objFile1.M_Gauge = Nothing Then
                    db.AddInParameter(dbComm, "@M_Gauge", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@M_Gauge", DbType.String, objFile1.M_Gauge)
                End If


                If objFile1.M_Unit = Nothing Then
                    db.AddInParameter(dbComm, "@M_Unit", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@M_Unit", DbType.String, objFile1.M_Unit)
                End If


                If objFile1.OS_BatchID = Nothing Then
                    db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)
                End If

                If objFile1.PM_M_Code = Nothing Then
                    db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objFile1.PM_M_Code)
                End If

                If objFile1.MV_Remark = Nothing Then
                    db.AddInParameter(dbComm, "@MV_Remark", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@MV_Remark", DbType.String, objFile1.MV_Remark)
                End If

                db.ExecuteNonQuery(dbComm)
                WareMove_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareMove_Add = False

            End Try
        End Function


        ''' <summary>
        ''' 修改
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareMove_Update(ByVal objFile1 As WareMoveInfo) As Boolean


            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareMove_Update")
                db.AddInParameter(dbComm, "@MV_Number", DbType.String, objFile1.MV_Number)
                db.AddInParameter(dbComm, "@MV_Qty", DbType.Double, objFile1.MV_Qty)
                db.AddInParameter(dbComm, "@MV_ChangeDepotNO", DbType.String, objFile1.MV_ChangeDepotNO)
                db.AddInParameter(dbComm, "@MV_Property", DbType.String, objFile1.MV_Property)
                db.AddInParameter(dbComm, "@MV_OutAction", DbType.String, objFile1.MV_OutAction)
                If objFile1.MV_Remark = Nothing Then
                    db.AddInParameter(dbComm, "@MV_Remark", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@MV_Remark", DbType.String, objFile1.MV_Remark)
                End If





                db.ExecuteNonQuery(dbComm)
                WareMove_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareMove_Update = False

            End Try
        End Function

        ''' <summary>
        ''' 收貨確認
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareMove_UpdateAck(ByVal objFile1 As WareMoveInfo) As Boolean


            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareMove_UpdateAck")
                db.AddInParameter(dbComm, "@MV_NO", DbType.String, objFile1.MV_NO)
                db.AddInParameter(dbComm, "@MV_InAction", DbType.String, objFile1.MV_InAction)
                db.AddInParameter(dbComm, "@MV_Ack", DbType.String, objFile1.MV_Ack)
              




                db.ExecuteNonQuery(dbComm)
                WareMove_UpdateAck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareMove_UpdateAck = False

            End Try
        End Function


        ''' <summary>
        ''' 審核
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareMove_UpdateCheck(ByVal objFile1 As WareMoveInfo) As Boolean


            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareMove_UpdateCheck")
                db.AddInParameter(dbComm, "@MV_NO", DbType.String, objFile1.MV_NO)
                db.AddInParameter(dbComm, "@MV_Check", DbType.String, objFile1.MV_Check)
                db.AddInParameter(dbComm, "@MV_AckDate", DbType.Date, objFile1.MV_AckDate)
                db.AddInParameter(dbComm, "@MV_CheckRemark", DbType.String, objFile1.MV_CheckRemark)
                db.AddInParameter(dbComm, "@MV_CheckAction", DbType.String, objFile1.MV_CheckAction)



                db.ExecuteNonQuery(dbComm)
                WareMove_UpdateCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareMove_UpdateCheck = False

            End Try
        End Function


        ''' <summary>
        ''' 取得對應數據
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Function FillWareMove(ByVal reader As IDataReader) As WareMoveInfo

            On Error Resume Next
            Dim objInfo As New WareMoveInfo
            objInfo.MV_NO = reader("MV_NO").ToString
            objInfo.MV_Number = reader("MV_Number").ToString
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString

            If reader("MV_Qty") Is DBNull.Value Then
                objInfo.MV_Qty = 0
            Else
                objInfo.MV_Qty = reader("MV_Qty").ToString
            End If
            If reader("MV_Date") Is DBNull.Value Then
                objInfo.MV_Date = Nothing
            Else
                objInfo.MV_Date = CStr(reader("MV_Date"))
            End If
            'objInfo.MV_Date = reader("MV_Date").ToString
            objInfo.OS_BatchID = reader("OS_BatchID").ToString
            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            objInfo.DepotNO = reader("DepotNO").ToString
            objInfo.MV_ChangeDepotNO = reader("MV_ChangeDepotNO").ToString
            objInfo.MV_InOrOut = reader("MV_InOrOut").ToString
            objInfo.MV_Remark = reader("MV_Remark").ToString
            objInfo.MV_Ack = reader("MV_Ack")
            objInfo.MV_OutAction = reader("MV_OutAction").ToString
            objInfo.MV_InAction = reader("MV_InAction").ToString
            objInfo.MV_Property = reader("MV_Property").ToString
            objInfo.MV_Check = reader("MV_Check")
            objInfo.MV_CheckAction = reader("MV_CheckAction").ToString
            objInfo.MV_CheckType = reader("MV_CheckType").ToString
            objInfo.MV_CheckRemark = reader("MV_CheckRemark").ToString
            objInfo.MV_InActionName = reader("MV_InActionName")
            objInfo.MV_OutActionName = reader("MV_OutActionName").ToString
            objInfo.MV_CheckActionName = reader("MV_CheckActionName").ToString

            If reader("MV_AckDate") Is DBNull.Value Then
                objInfo.MV_AckDate = Nothing
            Else
                objInfo.MV_AckDate = CStr(reader("MV_AckDate"))
            End If
            If reader("MV_EndQty") Is DBNull.Value Then   '調撥收入后的期末結餘數據
                objInfo.MV_EndQty = 0
            Else
                objInfo.MV_EndQty = CDbl(reader("MV_EndQty"))
            End If

            Return objInfo
        End Function


        ''' <summary>
        ''' 查詢
        ''' </summary>
        ''' <param name="MV_NO"></param>
        ''' <param name="M_Code"></param>
        ''' <param name="M_Name"></param>
        ''' <param name="DepotNO"></param>
        ''' <param name="MV_InOrOut"></param>
        ''' <param name="MV_Ack"></param>
        ''' <param name="MV_Check"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareMove_GetList(ByVal MV_NO As String, ByVal M_Code As String, ByVal M_Name As String, ByVal DepotNO As String, ByVal MV_ChangeDepotNO As String, ByVal MV_InOrOut As String, ByVal MV_Ack As String, ByVal MV_Check As String, ByVal Mode As String) As List(Of WareMoveInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareMove_GetList")
            db.AddInParameter(dbComm, "@MV_NO", DbType.String, MV_NO)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@DepotNO", DbType.String, DepotNO)
            db.AddInParameter(dbComm, "@MV_ChangeDepotNO", DbType.String, MV_ChangeDepotNO)
            db.AddInParameter(dbComm, "@MV_InOrOut", DbType.String, MV_InOrOut)
            db.AddInParameter(dbComm, "@Mode", DbType.String, Mode)
            If MV_Ack = Nothing Then
                db.AddInParameter(dbComm, "@MV_Ack", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@MV_Ack", DbType.String, MV_Ack)
            End If

            If MV_Check = Nothing Then
                db.AddInParameter(dbComm, "@MV_Check", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@MV_Check", DbType.String, MV_Check)
            End If



            Dim FeatureList As New List(Of WareMoveInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareMove(reader))
                End While
                Return FeatureList
            End Using

        End Function



        Public Function WareMove_GetList1(ByVal MV_NO As String, ByVal M_Code As String, ByVal M_Name As String, ByVal DepotNO As String, ByVal MV_ChangeDepotNO As String, ByVal MV_InOrOut As String, ByVal MV_Ack As String, ByVal MV_Check As String, ByVal Mode As String, ByVal WV_AddDate1 As String, ByVal WV_AddDate2 As String) As List(Of WareMoveInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareMove_GetList1")
            db.AddInParameter(dbComm, "@MV_NO", DbType.String, MV_NO)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@DepotNO", DbType.String, DepotNO)
            db.AddInParameter(dbComm, "@MV_ChangeDepotNO", DbType.String, MV_ChangeDepotNO)
            db.AddInParameter(dbComm, "@MV_InOrOut", DbType.String, MV_InOrOut)
            db.AddInParameter(dbComm, "@Mode", DbType.String, Mode)
            If MV_Ack = Nothing Then
                db.AddInParameter(dbComm, "@MV_Ack", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@MV_Ack", DbType.String, MV_Ack)
            End If

            If MV_Check = Nothing Then
                db.AddInParameter(dbComm, "@MV_Check", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@MV_Check", DbType.String, MV_Check)
            End If

            db.AddInParameter(dbComm, "@WV_AddDate1", DbType.String, WV_AddDate1)
            db.AddInParameter(dbComm, "@WV_AddDate2", DbType.String, WV_AddDate2)

            Dim FeatureList As New List(Of WareMoveInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareMove(reader))
                End While
                Return FeatureList
            End Using

        End Function

        ''' <summary>
        ''' 刪除某流水號記錄
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareMove_DelNumber(ByVal objFile1 As WareMoveInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareMove_DelNumber")
                db.AddInParameter(dbComm, "@MV_Number", DbType.String, objFile1.MV_Number)
                db.ExecuteNonQuery(dbComm)
                WareMove_DelNumber = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareMove_DelNumber = False
            End Try
        End Function

        ''' <summary>
        ''' 刪除某調撥單號
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareMove_DelNO(ByVal objFile1 As WareMoveInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareMove_DelNO")
                db.AddInParameter(dbComm, "@MV_NO", DbType.String, objFile1.MV_NO)
                db.ExecuteNonQuery(dbComm)
                WareMove_DelNO = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareMove_DelNO = False
            End Try
        End Function
        Public Function WareMove_UpdateOutEndQty(ByVal objinfo As WareMoveInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareMove_UpdateOutEndQty")

                db.AddInParameter(dbComm, "@MV_NO", DbType.String, objinfo.MV_NO)
                db.AddInParameter(dbComm, "@DepotNO", DbType.String, objinfo.DepotNO)
                db.AddInParameter(dbComm, "@MV_ChangeDepotNO", DbType.String, objinfo.MV_ChangeDepotNO)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@MV_EndQty", DbType.Double, objinfo.MV_EndQty)

                db.ExecuteNonQuery(dbComm)
                WareMove_UpdateOutEndQty = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareMove_UpdateOutEndQty = False
            End Try
        End Function

        Public Function WareMove_UpdateInEndQty(ByVal objinfo As WareMoveInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareMove_UpdateInEndQty")

                db.AddInParameter(dbComm, "@MV_NO", DbType.String, objinfo.MV_NO)
                db.AddInParameter(dbComm, "@DepotNO", DbType.String, objinfo.DepotNO)
                db.AddInParameter(dbComm, "@MV_ChangeDepotNO", DbType.String, objinfo.MV_ChangeDepotNO)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@MV_EndQty", DbType.Double, objinfo.MV_EndQty)

                db.ExecuteNonQuery(dbComm)
                WareMove_UpdateInEndQty = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareMove_UpdateInEndQty = False
            End Try
        End Function

        ''呆滯物料
        Public Function WareMove_TopGetList(ByVal M_Code As String, ByVal WH_ID As String, ByVal MV_InOrOut As String) As List(Of WareMoveInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareMove_TopGetList")

            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@MV_InOrOut", DbType.String, MV_InOrOut)


            Dim FeatureList As New List(Of WareMoveInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareMove(reader))
                End While
                Return FeatureList
            End Using
        End Function


        ''---2013-7-22-----------------------------------------------------------

        ''' <summary>
        ''' 查詢出 已調撥驗收單
        ''' </summary>
        ''' <param name="M_Code"></param>
        ''' <param name="MV_Remark"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareMove_GetListRemark(ByVal M_Code As String, ByVal MV_Remark As String, ByVal DepotNO As String) As List(Of WareMoveInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareMove_GetListRemark")

            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@MV_Remark", DbType.String, MV_Remark)
            db.AddInParameter(dbComm, "@DepotNO", DbType.String, DepotNO)

            Dim FeatureList As New List(Of WareMoveInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareMove(reader))
                End While
                Return FeatureList
            End Using
        End Function


        Public Function WareMove_GetListTop50(ByVal MV_NO As String, ByVal M_Code As String, ByVal M_Name As String, ByVal DepotNO As String, ByVal MV_ChangeDepotNO As String, ByVal MV_InOrOut As String, ByVal MV_Ack As String, ByVal MV_Check As String, ByVal Mode As String, ByVal WV_AddDate1 As String, ByVal WV_AddDate2 As String) As List(Of WareMoveInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareMove_GetListTop50")
            db.AddInParameter(dbComm, "@MV_NO", DbType.String, MV_NO)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@DepotNO", DbType.String, DepotNO)
            db.AddInParameter(dbComm, "@MV_ChangeDepotNO", DbType.String, MV_ChangeDepotNO)
            db.AddInParameter(dbComm, "@MV_InOrOut", DbType.String, MV_InOrOut)
            db.AddInParameter(dbComm, "@Mode", DbType.String, Mode)
            If MV_Ack = Nothing Then
                db.AddInParameter(dbComm, "@MV_Ack", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@MV_Ack", DbType.String, MV_Ack)
            End If

            If MV_Check = Nothing Then
                db.AddInParameter(dbComm, "@MV_Check", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@MV_Check", DbType.String, MV_Check)
            End If

            db.AddInParameter(dbComm, "@WV_AddDate1", DbType.String, WV_AddDate1)
            db.AddInParameter(dbComm, "@WV_AddDate2", DbType.String, WV_AddDate2)

            Dim FeatureList As New List(Of WareMoveInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareMove(reader))
                End While
                Return FeatureList
            End Using

        End Function




        Public Function WareMove_GetNO(ByVal NDate As String) As List(Of WareMoveInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareMove_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
   
            Dim FeatureList As New List(Of WareMoveInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareMove(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function WareMove_GetNumber(ByVal NDate As String) As List(Of WareMoveInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareMove_GetNumber")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)

            Dim FeatureList As New List(Of WareMoveInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareMove(reader))
                End While
                Return FeatureList
            End Using

        End Function




    End Class
End Namespace