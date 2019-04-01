Namespace LFERP.Library.Outward.OutwardAcceptance

    Public Class OutwardAcceptanceControl

        ''' <summary>
        ''' 驗收單號（自動獲得）
        ''' </summary>
        ''' <param name="Ndate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OutwardAcceptance_GetNO(ByVal Ndate As String) As OutwardAcceptanceInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardAcceptance_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillOutwardAcceptance(reader)
                End While
                Return Nothing
            End Using
        End Function
        ''' <summary>
        ''' 驗收流水號
        ''' </summary>
        ''' <param name="A_NO"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OutwardAcceptance_GetNum(ByVal A_NO As String) As OutwardAcceptanceInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardAcceptance_GetNum")
            db.AddInParameter(dbComm, "@A_NO", DbType.String, A_NO)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillOutwardAcceptance(reader)
                End While
                Return Nothing
            End Using
        End Function
        Public Function OutwardAcceptance_Add(ByVal obj As OutwardAcceptanceInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("OutwardAcceptance_Add")

                db.AddInParameter(dbcomm, "@A_NO", DbType.String, obj.A_NO)
                db.AddInParameter(dbcomm, "@A_AcceptanceNO", DbType.String, obj.A_AcceptanceNO)
                db.AddInParameter(dbcomm, "@WH_ID", DbType.String, obj.WH_ID)
                db.AddInParameter(dbcomm, "@O_NO", DbType.String, obj.O_NO)
                db.AddInParameter(dbcomm, "@A_SendNO", DbType.String, obj.A_SendNO)
                db.AddInParameter(dbcomm, "@A_SendType", DbType.String, obj.A_SendType)
                db.AddInParameter(dbcomm, "@M_Code", DbType.String, obj.M_Code)
                db.AddInParameter(dbcomm, "@OS_BatchID", DbType.String, obj.OS_BatchID)
                db.AddInParameter(dbcomm, "@PM_M_Code", DbType.String, obj.PM_M_Code)
                db.AddInParameter(dbcomm, "@A_Qty", DbType.Double, obj.A_Qty)
                db.AddInParameter(dbcomm, "@A_SendDate", DbType.Date, obj.A_SendDate)
                db.AddInParameter(dbcomm, "@A_Ver", DbType.Int32, obj.A_Ver)
                db.AddInParameter(dbcomm, "@S_Supplier", DbType.String, obj.S_Supplier)
                db.AddInParameter(dbcomm, "@A_Action", DbType.String, obj.A_Action)
                db.AddInParameter(dbcomm, "@A_Remark", DbType.String, obj.A_Remark)
                db.AddInParameter(dbcomm, "@A_Detail", DbType.String, obj.A_Detail)
                db.AddInParameter(dbcomm, "@A_UpdateDate", DbType.Date, obj.A_UpdateDate)

                db.AddInParameter(dbcomm, "@A_QtyType", DbType.String, obj.A_QtyType)
                db.AddInParameter(dbcomm, "@OS_ItemType", DbType.String, obj.OS_ItemType)

                db.ExecuteNonQuery(dbcomm)
                OutwardAcceptance_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OutwardAcceptance_Add = False
            End Try
        End Function
        Public Function OutwardAcceptance_Update(ByVal obj As OutwardAcceptanceInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("OutwardAcceptance_Update")

                db.AddInParameter(dbcomm, "@A_NO", DbType.String, obj.A_NO)
                db.AddInParameter(dbcomm, "@A_AcceptanceNO", DbType.String, obj.A_AcceptanceNO)
                db.AddInParameter(dbcomm, "@WH_ID", DbType.String, obj.WH_ID)
                db.AddInParameter(dbcomm, "@O_NO", DbType.String, obj.O_NO)
                db.AddInParameter(dbcomm, "@A_SendNO", DbType.String, obj.A_SendNO)
                db.AddInParameter(dbcomm, "@A_SendType", DbType.String, obj.A_SendType)
                db.AddInParameter(dbcomm, "@M_Code", DbType.String, obj.M_Code)
                db.AddInParameter(dbcomm, "@OS_BatchID", DbType.String, obj.OS_BatchID)
                db.AddInParameter(dbcomm, "@PM_M_Code", DbType.String, obj.PM_M_Code)
                db.AddInParameter(dbcomm, "@A_Qty", DbType.Double, obj.A_Qty)
                db.AddInParameter(dbcomm, "@A_SendDate", DbType.Date, obj.A_SendDate)
                db.AddInParameter(dbcomm, "@A_Ver", DbType.Int32, obj.A_Ver)
                db.AddInParameter(dbcomm, "@S_Supplier", DbType.String, obj.S_Supplier)
                db.AddInParameter(dbcomm, "@A_Action", DbType.String, obj.A_Action)
                db.AddInParameter(dbcomm, "@A_Remark", DbType.String, obj.A_Remark)
                db.AddInParameter(dbcomm, "@A_Detail", DbType.String, obj.A_Detail)
                db.AddInParameter(dbcomm, "@A_UpdateDate", DbType.Date, obj.A_UpdateDate)

                db.AddInParameter(dbcomm, "@A_QtyType", DbType.String, obj.A_QtyType)

                db.ExecuteNonQuery(dbcomm)
                OutwardAcceptance_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OutwardAcceptance_Update = False
            End Try
        End Function
        Public Function OutwardAcceptance_UpdateCheck(ByVal obj As OutwardAcceptanceInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("OutwardAcceptance_UpdateCheck")

                db.AddInParameter(dbcomm, "@A_AcceptanceNO", DbType.String, obj.A_AcceptanceNO)
                db.AddInParameter(dbcomm, "@A_Check", DbType.Boolean, obj.A_Check)
                db.AddInParameter(dbcomm, "@A_CheckAction", DbType.String, obj.A_CheckAction)
                db.AddInParameter(dbcomm, "@A_CheckDate", DbType.Date, obj.A_CheckDate)
                db.AddInParameter(dbcomm, "@A_CheckRemark", DbType.String, obj.A_CheckRemark)
                db.AddInParameter(dbcomm, "@A_Detail", DbType.String, obj.A_Detail)

                db.ExecuteNonQuery(dbcomm)
                OutwardAcceptance_UpdateCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                OutwardAcceptance_UpdateCheck = False
            End Try

        End Function
        Public Function OutwardAcceptance_UpdateDetail(ByVal objinfo As OutwardAcceptanceInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardAcceptance_UpdateDetail")

                db.AddInParameter(dbComm, "@A_AcceptanceNO", DbType.String, objinfo.A_AcceptanceNO)
                db.AddInParameter(dbComm, "@A_Detail", DbType.String, objinfo.A_Detail)
                db.ExecuteNonQuery(dbComm)
                OutwardAcceptance_UpdateDetail = True
            Catch ex As Exception
                MsgBox(ex.Message)
                OutwardAcceptance_UpdateDetail = False
            End Try
        End Function
        Public Function Outward_UpdateNoSendQty(ByVal obj As OutwardInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("UpdateOutward_NoSendQty")
                db.AddInParameter(dbComm, "@O_NO", DbType.String, obj.O_NO)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, obj.M_Code)
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, obj.OS_BatchID)

                db.ExecuteNonQuery(dbComm)
                Outward_UpdateNoSendQty = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Outward_UpdateNoSendQty = False
            End Try
        End Function
        Public Function OutwardAcceptance_UpdateAccCheck(ByVal obj As OutwardAcceptanceInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("OutwardAcceptance_UpdateAccCheck")

                db.AddInParameter(dbcomm, "@A_AcceptanceNO", DbType.String, obj.A_AcceptanceNO)
                db.AddInParameter(dbcomm, "@A_AccCheck", DbType.Boolean, obj.A_AccCheck)
                db.AddInParameter(dbcomm, "@A_AccCheckAction", DbType.String, obj.A_AccCheckAction)
                db.AddInParameter(dbcomm, "@A_AccCheckDate", DbType.Date, obj.A_AccCheckDate)
                db.AddInParameter(dbcomm, "@A_AccCheckRemark", DbType.String, obj.A_AccCheckRemark)
                db.AddInParameter(dbcomm, "@A_AccCheckType", DbType.String, obj.A_AccCheckType)

                db.ExecuteNonQuery(dbcomm)
                OutwardAcceptance_UpdateAccCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                OutwardAcceptance_UpdateAccCheck = False
            End Try

        End Function
        Public Function OutwardAcceptance_Delete(ByVal A_AcceptanceNO As String, ByVal A_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("OutwardAcceptance_Delete")
                db.AddInParameter(dbcomm, "@A_NO", DbType.String, A_NO)
                db.AddInParameter(dbcomm, "@A_AcceptanceNO", DbType.String, A_AcceptanceNO)

                db.ExecuteNonQuery(dbcomm)
                OutwardAcceptance_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                OutwardAcceptance_Delete = False
            End Try
        End Function
        Public Function OutwardAcceptance_GetList(ByVal A_AcceptanceNO As String, ByVal A_NO As String, ByVal O_NO As String, ByVal A_SendNO As String, ByVal OS_ItemType As String, ByVal A_Date1 As String, ByVal A_Date2 As String, ByVal M_Code As String, ByVal M_Name As String, ByVal OS_BatchID As String, ByVal PM_M_Code As String, ByVal S_Supplier As String) As List(Of OutwardAcceptanceInfo)


            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardAcceptance_GetList")

            db.AddInParameter(dbComm, "@A_AcceptanceNO", DbType.String, A_AcceptanceNO)
            db.AddInParameter(dbComm, "@A_NO", DbType.String, A_NO)
            db.AddInParameter(dbComm, "@O_NO", DbType.String, O_NO)
            db.AddInParameter(dbComm, "@A_SendNO", DbType.String, A_SendNO)
            db.AddInParameter(dbComm, "@OS_ItemType", DbType.String, OS_ItemType)
            db.AddInParameter(dbComm, "@A_Date1", DbType.String, A_Date1)
            db.AddInParameter(dbComm, "@A_Date2", DbType.String, A_Date2)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@S_Supplier", DbType.String, S_Supplier)

            Dim FeatureList As New List(Of OutwardAcceptanceInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOutwardAcceptance(reader))
                End While
                Return FeatureList
            End Using

        End Function
        Public Function FillOutwardAcceptance(ByVal reader As IDataReader) As OutwardAcceptanceInfo

            On Error Resume Next

            Dim oai As New OutwardAcceptanceInfo

            oai.A_NO = reader("A_NO").ToString
            oai.A_AcceptanceNO = reader("A_AcceptanceNO").ToString
            oai.WH_ID = reader("WH_ID").ToString
            oai.O_NO = reader("O_NO").ToString
            oai.A_SendNO = reader("A_SendNO").ToString
            oai.A_SendType = reader("A_SendType").ToString
            oai.M_Code = reader("M_Code").ToString
            oai.OS_BatchID = reader("OS_BatchID").ToString
            oai.PM_M_Code = reader("PM_M_Code").ToString
            If reader("A_Qty") Is DBNull.Value Then
                oai.A_Qty = Nothing
            Else
                oai.A_Qty = CDbl(reader("A_Qty").ToString)
            End If
            If reader("A_SendDate") Is DBNull.Value Then
                oai.A_SendDate = Nothing
            Else
                oai.A_SendDate = CStr(reader("A_SendDate"))
            End If
            oai.A_Ver = CInt(reader("A_Ver"))
            oai.S_Supplier = reader("S_Supplier").ToString
            oai.A_Action = reader("A_Action").ToString
            oai.A_Remark = reader("A_Remark").ToString
            oai.A_Detail = reader("A_Detail").ToString
            If reader("A_UpdateDate") Is DBNull.Value Then
                oai.A_UpdateDate = Nothing
            Else
                oai.A_UpdateDate = CStr(reader("A_UpdateDate"))

            End If
            oai.A_QtyType = reader("A_QtyType").ToString

            '--------------------------------------------------------
            If reader("A_Check") Is DBNull.Value Then
                oai.A_Check = Nothing
            Else
                oai.A_Check = reader("A_Check")
            End If
            oai.A_CheckAction = reader("A_CheckAction").ToString
            If reader("A_CheckDate") Is DBNull.Value Then
                oai.A_CheckDate = Nothing
            Else
                oai.A_CheckDate = CStr(reader("A_CheckDate"))
            End If
            oai.A_CheckRemark = reader("A_CheckRemark").ToString
            '---------------------------------------------------------
            If reader("A_AccCheck") Is DBNull.Value Then
                oai.A_AccCheck = Nothing
            Else
                oai.A_AccCheck = reader("A_AccCheck")
            End If
            oai.A_AccCheckAction = reader("A_AccCheckAction").ToString
            If reader("A_AccCheckDate") Is DBNull.Value Then
                oai.A_AccCheckDate = Nothing
            Else
                oai.A_AccCheckDate = CStr(reader("A_AccCheckDate"))
            End If
            oai.A_AccCheckRemark = reader("A_AccCheckRemark").ToString
            oai.A_AccCheckType = reader("A_AccCheckType").ToString
            '---------------------------------------------------------
            oai.M_Gauge = reader("M_Gauge").ToString
            oai.M_Name = reader("M_Name").ToString
            oai.M_Unit = reader("M_Unit").ToString
            oai.SupplierName = reader("SupplierName").ToString
            oai.WH_Name = reader("WH_Name").ToString

            oai.OS_ItemType = reader("OS_ItemType").ToString
            oai.ItemType = reader("ItemType").ToString

            Return oai

        End Function
    End Class


End Namespace

