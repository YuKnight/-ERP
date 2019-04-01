Namespace LFERP.Library.OutWards
    Public Class OutWardsController
        Public Function OutWards_Add(ByVal objinfo As OutWardsInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OutWards_Add")

                db.AddInParameter(dbComm, "@OW_NO", DbType.String, objinfo.OW_NO)
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objinfo.OS_BatchID)
                db.AddInParameter(dbComm, "@OM_ID", DbType.String, objinfo.OM_ID)
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, objinfo.WH_ID)
                db.AddInParameter(dbComm, "@OW_Address", DbType.String, objinfo.OW_Address)

                db.AddInParameter(dbComm, "@OW_Detail", DbType.String, objinfo.OW_Detail)
                db.AddInParameter(dbComm, "@OW_Remark", DbType.String, objinfo.OW_Remark)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)

                db.AddInParameter(dbComm, "@OW_Qty", DbType.Int32, objinfo.OW_Qty)
                db.AddInParameter(dbComm, "@OW_Date", DbType.Date, objinfo.OW_Date)
                db.AddInParameter(dbComm, "@OW_AddUserID", DbType.String, objinfo.OW_AddUserID)
                db.AddInParameter(dbComm, "@OW_AddDate", DbType.Date, objinfo.OW_AddDate)
                db.AddInParameter(dbComm, "@OC_AutoID", DbType.String, objinfo.OC_AutoID)

                db.AddInParameter(dbComm, "@OW_Sprace", DbType.Int32, objinfo.OW_Sprace)


                db.ExecuteNonQuery(dbComm)
                OutWards_Add = True

            Catch ex As Exception

                MsgBox(ex.Message)
                OutWards_Add = False
            End Try
        End Function

        Public Function OutWards_Update(ByVal objinfo As OutWardsInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OutWards_Update")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objinfo.OS_BatchID)
                db.AddInParameter(dbComm, "@OM_ID", DbType.String, objinfo.OM_ID)
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, objinfo.WH_ID)
                db.AddInParameter(dbComm, "@OW_Address", DbType.String, objinfo.OW_Address)

                db.AddInParameter(dbComm, "@OW_Detail", DbType.String, objinfo.OW_Detail)
                db.AddInParameter(dbComm, "@OW_Remark", DbType.String, objinfo.OW_Remark)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)

                db.AddInParameter(dbComm, "@OW_Qty", DbType.Int32, objinfo.OW_Qty)
                db.AddInParameter(dbComm, "@OW_Date", DbType.Date, objinfo.OW_Date)
                db.AddInParameter(dbComm, "@OW_ModifyUserID", DbType.String, objinfo.OW_ModifyUserID)
                db.AddInParameter(dbComm, "@OW_ModifyDate", DbType.Date, objinfo.OW_ModifyDate)
                db.AddInParameter(dbComm, "@OC_AutoID", DbType.String, objinfo.OC_AutoID)

                db.AddInParameter(dbComm, "@OW_Sprace", DbType.Int32, objinfo.OW_Sprace)

                db.ExecuteNonQuery(dbComm)
                OutWards_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                OutWards_Update = False
            End Try
        End Function

        Public Function OutWards_UpdateCheck(ByVal objinfo As OutWardsInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OutWards_UpdateCheck")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@OW_Check", DbType.String, objinfo.OW_Check)
                db.AddInParameter(dbComm, "@OW_CheckUserID", DbType.String, objinfo.OW_CheckUserID)
                db.AddInParameter(dbComm, "@OW_CheckDate", DbType.String, objinfo.OW_CheckDate)

                db.ExecuteNonQuery(dbComm)
                OutWards_UpdateCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                OutWards_UpdateCheck = False
            End Try
        End Function

        Public Function OutWards_Delete(ByVal AutoID As String, ByVal OW_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OutWards_Delete")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbComm, "@OW_NO", DbType.String, OW_NO)

                db.ExecuteNonQuery(dbComm)
                OutWards_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                OutWards_Delete = False
            End Try
        End Function

        Public Function OutWards_GetList(ByVal OW_NO As String, ByVal OS_BatchID As String, ByVal OM_CusterID As String, ByVal OM_CusterNO As String, ByVal OM_CusterPO As String, ByVal OM_ID As String, ByVal WH_ID As String, ByVal PM_M_Code As String, ByVal OW_Detail As String, ByVal OW_Check As String, ByVal OW_BeginDate As String, ByVal OW_EndDate As String) As List(Of OutWardsInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OutWards_GetList")

            db.AddInParameter(dbComm, "@OW_NO", DbType.String, OW_NO)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@OM_CusterID", DbType.String, OM_CusterID)
            db.AddInParameter(dbComm, "@OM_CusterNO", DbType.String, OM_CusterNO)
            db.AddInParameter(dbComm, "@OM_CusterPO", DbType.String, OM_CusterPO)

            db.AddInParameter(dbComm, "@OM_ID", DbType.String, OM_ID)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@OW_Detail", DbType.String, OW_Detail)
            db.AddInParameter(dbComm, "@OW_Check", DbType.String, OW_Check)

            db.AddInParameter(dbComm, "@OW_BeginDate", DbType.String, OW_BeginDate)
            db.AddInParameter(dbComm, "@OW_EndDate", DbType.String, OW_EndDate)

            Dim FeatureList As New List(Of OutWardsInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOutWards(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function OutWards_GetList1(ByVal OW_NO As String, ByVal OS_BatchID As String, ByVal OC_CustomerID As String, ByVal OC_CustomerNO As String, ByVal OC_CustomerPO As String, ByVal OC_ID As String, ByVal WH_ID As String, ByVal PM_M_Code As String, ByVal OW_Detail As String, ByVal OW_Check As String, ByVal OC_AutoID As String, ByVal OW_BeginDate As String, ByVal OW_EndDate As String) As List(Of OutWardsInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OutWards_GetList1")

            db.AddInParameter(dbComm, "@OW_NO", DbType.String, OW_NO)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@OC_CustomerID", DbType.String, OC_CustomerID)
            db.AddInParameter(dbComm, "@OC_CustomerNO", DbType.String, OC_CustomerNO)
            db.AddInParameter(dbComm, "@OC_CustomerPO", DbType.String, OC_CustomerPO)

            db.AddInParameter(dbComm, "@OC_ID", DbType.String, OC_ID)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@OW_Detail", DbType.String, OW_Detail)
            db.AddInParameter(dbComm, "@OW_Check", DbType.String, OW_Check)

            db.AddInParameter(dbComm, "@OC_AutoID", DbType.String, OC_AutoID)
            db.AddInParameter(dbComm, "@OW_BeginDate", DbType.String, OW_BeginDate)
            db.AddInParameter(dbComm, "@OW_EndDate", DbType.String, OW_EndDate)

            Dim FeatureList As New List(Of OutWardsInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOutWards(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FillOutWards(ByVal reader As IDataReader) As OutWardsInfo
            '對應取得的數據
            On Error Resume Next
            Dim owi As New OutWardsInfo

            owi.AutoID = reader("AutoID").ToString
            owi.OW_NO = reader("OW_NO").ToString
            owi.OS_BatchID = reader("OS_BatchID").ToString
            owi.OM_ID = reader("OM_ID").ToString
            owi.WH_ID = reader("WH_ID").ToString

            owi.WH_Name = reader("WH_Name").ToString
            owi.OW_Address = reader("OW_Address").ToString
            owi.OW_Detail = reader("OW_Detail").ToString
            owi.OW_Remark = reader("OW_Remark").ToString
            owi.PM_M_Code = reader("PM_M_Code").ToString

            owi.OW_Qty = reader("OW_Qty")
            owi.OW_Date = Format(reader("OW_Date"), "yyyy/MM/dd")
            owi.OW_AddUserID = reader("OW_AddUserID").ToString
            owi.OW_AddUserName = reader("OW_AddUserName").ToString
            If reader("OW_AddDate") Is DBNull.Value Then
                owi.OW_AddDate = Nothing
            Else
                owi.OW_AddDate = reader("OW_AddDate")
            End If

            owi.OW_ModifyUserID = reader("OW_ModifyUserID").ToString
            If reader("OW_ModifyDate") Is DBNull.Value Then
                owi.OW_ModifyDate = Nothing
            Else
                owi.OW_ModifyDate = reader("OW_ModifyDate")
            End If
            If reader("OW_Check") Is DBNull.Value Then
                owi.OW_Check = False
            Else
                owi.OW_Check = reader("OW_Check")
            End If
            owi.OW_CheckUserID = reader("OW_CheckUserID").ToString
            owi.OW_CheckUserName = reader("OW_CheckUserName").ToString

            If reader("OW_CheckDate") Is DBNull.Value Then
                owi.OW_CheckDate = Nothing
            Else
                owi.OW_CheckDate = reader("OW_CheckDate")
            End If
            owi.OM_CusterID = reader("OM_CusterID").ToString
            owi.OM_CusterNO = reader("OM_CusterNO").ToString
            owi.OM_CusterPO = reader("OM_CusterPO").ToString
            If reader("OM_OrderSpare") Is DBNull.Value Then
                owi.OM_OrderSpare = 0
            Else
                owi.OM_OrderSpare = reader("OM_OrderSpare")
            End If

            owi.OS_Plate = reader("OS_Plate").ToString
            If reader("OS_NoSendQty") Is DBNull.Value Then
                owi.OS_NoSendQty = 0
            Else
                owi.OS_NoSendQty = reader("OS_NoSendQty")
            End If
            owi.PI_Qty = reader("PI_Qty")
            owi.C_EngName = reader("C_EngName").ToString
            owi.C_ChsName = reader("C_ChsName").ToString

            owi.PM_JiYu = reader("PM_JiYu").ToString
            owi.PM_Type = reader("PM_Type").ToString
            owi.M_Code = reader("M_Code").ToString
            owi.M_Name = reader("M_Name").ToString
            owi.M_Gauge = reader("M_Gauge").ToString

            owi.M_Unit = reader("M_Unit").ToString
            If reader("OS_Sprace") Is DBNull.Value Then
                owi.OS_Sprace = 0
            Else
                owi.OS_Sprace = reader("OS_Sprace")
            End If
            If reader("OC_Spare") Is DBNull.Value Then
                owi.OC_Spare = 0
            Else
                owi.OC_Spare = reader("OC_Spare")
            End If
            owi.OC_AutoID = reader("OC_AutoID").ToString
            If reader("OC_NoSendQty") Is DBNull.Value Then
                owi.OC_NoSendQty = 0
            Else
                owi.OC_NoSendQty = reader("OC_NoSendQty")
            End If

            owi.OC_ID = reader("OC_ID").ToString
            owi.OC_CustomerID = reader("OC_CustomerID").ToString
            owi.OC_CustomerNO = reader("OC_CustomerNo").ToString
            owi.OC_CustomerPO = reader("OC_CustomerPO").ToString

            owi.OW_Sprace = reader("OW_Sprace")


            owi.Type1ID = reader("Type1ID").ToString
            owi.Type2ID = reader("Type2ID").ToString
            owi.Type3ID = reader("Type3ID").ToString
            owi.Type1Name = reader("Type1Name").ToString
            owi.Type2Name = reader("Type2Name").ToString
            owi.Type3Name = reader("Type3Name").ToString

            Return owi
        End Function

        Public Function OutWards_GetList2(ByVal OW_NO As String, ByVal OS_BatchID As String, ByVal OM_CusterID As String, ByVal OM_CusterNO As String, _
        ByVal OM_CusterPO As String, ByVal OM_ID As String, ByVal WH_ID As String, ByVal PM_M_Code As String, _
        ByVal OW_Detail As String, ByVal OW_Check As String, ByVal OW_BeginDate As String, _
        ByVal OW_EndDate As String, ByVal TypeID As String) As List(Of OutWardsInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OutWards_GetList2")

            db.AddInParameter(dbComm, "@OW_NO", DbType.String, OW_NO)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@OM_CusterID", DbType.String, OM_CusterID)
            db.AddInParameter(dbComm, "@OM_CusterNO", DbType.String, OM_CusterNO)
            db.AddInParameter(dbComm, "@OM_CusterPO", DbType.String, OM_CusterPO)

            db.AddInParameter(dbComm, "@OM_ID", DbType.String, OM_ID)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@OW_Detail", DbType.String, OW_Detail)
            db.AddInParameter(dbComm, "@OW_Check", DbType.String, OW_Check)

            db.AddInParameter(dbComm, "@OW_BeginDate", DbType.String, OW_BeginDate)
            db.AddInParameter(dbComm, "@OW_EndDate", DbType.String, OW_EndDate)

            db.AddInParameter(dbComm, "@TypeID", DbType.String, TypeID)

            Dim FeatureList As New List(Of OutWardsInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOutWards(reader))
                End While
                Return FeatureList
            End Using
        End Function


    End Class
End Namespace

