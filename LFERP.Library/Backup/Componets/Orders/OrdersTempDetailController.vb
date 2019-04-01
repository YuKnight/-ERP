Namespace LFERP.Library.Orders

    Public Class OrdersTempDetailController




        ''' <summary>
        ''' 取得對應數據
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Function FillOrdersTempDetail(ByVal reader As IDataReader) As OrdersTempDetailInfo
            '對應取得的數據
            On Error Resume Next
            Dim objInfo As New OrdersTempDetailInfo
            objInfo.OS_BatchID = reader("OS_BatchID").ToString
            objInfo.OT_ID = reader("OT_ID").ToString
            objInfo.OT_Detail = reader("OT_Detail").ToString
            objInfo.OT_AddDate = reader("OT_AddDate").ToString
            objInfo.OT_EditDate = reader("OT_EditDate").ToString
            objInfo.OT_Check = reader("OT_Check").ToString
            objInfo.OT_Action = reader("OT_Action").ToString


            objInfo.OS_Qty = reader("OS_Qty").ToString
            objInfo.OS_SendDate = reader("OS_SendDate").ToString
            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            objInfo.PM_JiYu = reader("PM_JiYu").ToString
            objInfo.OM_CusterID = reader("OM_CusterID").ToString
            objInfo.OM_CusterNo = reader("OM_CusterNo").ToString
            objInfo.OS_Remark = reader("OS_Remark").ToString
            objInfo.OS_Fac = reader("OS_Fac").ToString


            Return objInfo
        End Function



        ''' <summary>
        ''' 臨時單查詢
        ''' </summary>
        ''' <param name="OT_ID"></param>
        ''' <param name="OS_BatchID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersTempDetail_GetList(ByVal OT_ID As String, ByVal OS_BatchID As String) As List(Of OrdersTempDetailInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersTempDetail_GetList")
            db.AddInParameter(dbComm, "@OT_ID", DbType.String, OT_ID)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)

            Dim FeatureList As New List(Of OrdersTempDetailInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOrdersTempDetail(reader))
                End While
                Return FeatureList
            End Using


        End Function


        ''' <summary>
        ''' 臨時單新增
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersTempDetail_Add(ByVal objFile1 As OrdersTempDetailInfo) As Boolean

       

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersTempDetail_Add")
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)
                db.AddInParameter(dbComm, "@OT_Detail", DbType.String, objFile1.OT_Detail)
                db.AddInParameter(dbComm, "@OT_AddDate", DbType.String, objFile1.OT_AddDate)
                db.AddInParameter(dbComm, "@OT_EditDate", DbType.String, objFile1.OT_EditDate)
                db.AddInParameter(dbComm, "@OT_Check", DbType.String, objFile1.OT_Check)
                db.AddInParameter(dbComm, "@OT_Action", DbType.String, objFile1.OT_Action)


                db.ExecuteNonQuery(dbComm)
                OrdersTempDetail_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersTempDetail_Add = False

            End Try

         
        End Function




        ''' <summary>
        ''' 臨時單修改
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersTempDetail_Update(ByVal objFile1 As OrdersTempDetailInfo) As Boolean


            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersTempDetail_Update")

                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)
                db.AddInParameter(dbComm, "@OT_ID", DbType.String, objFile1.OT_ID)
                db.AddInParameter(dbComm, "@OT_Detail", DbType.String, objFile1.OT_Detail)
                db.AddInParameter(dbComm, "@OT_EditDate", DbType.String, objFile1.OT_EditDate)
                db.AddInParameter(dbComm, "@OT_Check", DbType.String, objFile1.OT_Check)
                db.AddInParameter(dbComm, "@OT_Action", DbType.String, objFile1.OT_Action)
               

                db.ExecuteNonQuery(dbComm)
                OrdersTempDetail_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersTempDetail_Update = False

            End Try
        End Function


        ''' <summary>
        ''' 臨時單刪除--OT_ID
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersTempDetail_OTID_Del(ByVal objFile1 As OrdersTempDetailInfo) As Boolean


            Try


                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersTempDetail_OTID_Del")

                db.AddInParameter(dbComm, "@OT_ID", DbType.String, objFile1.OT_ID)

                db.ExecuteNonQuery(dbComm)
                OrdersTempDetail_OTID_Del = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersTempDetail_OTID_Del = False

            End Try
        End Function


        ''' <summary>
        ''' 臨時單刪除--OS_BatchID
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OrdersTempDetail_OSBatchID_Del(ByVal objFile1 As OrdersTempDetailInfo) As Boolean


            Try


                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersTempDetail_OSBatchID_Del")

                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)

                db.ExecuteNonQuery(dbComm)
                OrdersTempDetail_OSBatchID_Del = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersTempDetail_OSBatchID_Del = False

            End Try
        End Function

    End Class

End Namespace
