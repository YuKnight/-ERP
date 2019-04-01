

Namespace LFERP.Library.Outward

    Public Class OutwardChangeControl

        Public Function OutwardChange_Add(ByVal Objinfo As OutwardChangeInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardChange_Add")

                db.AddInParameter(dbComm, "@OC_NO", DbType.String, Objinfo.OC_NO)
                db.AddInParameter(dbComm, "@O_NO", DbType.String, Objinfo.O_NO)
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, Objinfo.OS_BatchID)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, Objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, Objinfo.M_Code)
                db.AddInParameter(dbComm, "@OS_Qty", DbType.Double, Objinfo.OS_Qty)
                db.AddInParameter(dbComm, "@OS_NoSendQty", DbType.Double, Objinfo.OS_NoSendQty)
                db.AddInParameter(dbComm, "@OC_Qty", DbType.Double, Objinfo.OC_Qty)
                db.AddInParameter(dbComm, "@OC_Reason", DbType.String, Objinfo.OC_Reason)
                db.AddInParameter(dbComm, "@OC_Action", DbType.String, Objinfo.OC_Action)
                db.AddInParameter(dbComm, "@OC_AddDate", DbType.Date, Objinfo.OC_AddDate)
                db.AddInParameter(dbComm, "@OC_EditDate", DbType.Date, Objinfo.OC_EditDate)
                db.AddInParameter(dbComm, "@OC_Remark", DbType.String, Objinfo.OC_Remark)

                db.ExecuteNonQuery(dbComm)
                OutwardChange_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                OutwardChange_Add = False
            End Try

        End Function

        Public Function OutwardChange_Update(ByVal Objinfo As OutwardChangeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardChange_Update")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, Objinfo.AutoID)
                db.AddInParameter(dbComm, "@OC_Qty", DbType.Double, Objinfo.OC_Qty)
                db.AddInParameter(dbComm, "@OC_Reason", DbType.String, Objinfo.OC_Reason)
                db.AddInParameter(dbComm, "@OC_Action", DbType.String, Objinfo.OC_Action)
                db.AddInParameter(dbComm, "@OC_EditDate", DbType.Date, Objinfo.OC_EditDate)
                db.AddInParameter(dbComm, "@OC_Remark", DbType.String, Objinfo.OC_Remark)

                db.ExecuteNonQuery(dbComm)
                OutwardChange_Update = True

            Catch ex As Exception

                MsgBox(ex.Message)
                OutwardChange_Update = False
            End Try

        End Function

        Public Function OutwardChange_Delete(ByVal OC_NO As String, ByVal AutoID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardChange_Delete")

                db.AddInParameter(dbComm, "@OC_NO", DbType.String, OC_NO)
                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)

                db.ExecuteNonQuery(dbComm)
                OutwardChange_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OutwardChange_Delete = False
            End Try

        End Function

        Public Function OutwardChange_GetNO(ByVal NDate As String) As OutwardChangeInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardChange_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillOutwardChange(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function OutwardChange_GetList(ByVal OC_NO As String, ByVal O_NO As String, ByVal OS_BatchID As String, ByVal M_Name As String, ByVal OC_Action As String, ByVal OC_Check As String) As List(Of OutwardChangeInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardChange_GetList")

            db.AddInParameter(dbComm, "@OC_NO", DbType.String, OC_NO)
            db.AddInParameter(dbComm, "@O_NO", DbType.String, O_NO)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@OC_Action", DbType.String, OC_Action)
            db.AddInParameter(dbComm, "@OC_Check", DbType.String, OC_Check)

            Dim FeatureList As New List(Of OutwardChangeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOutwardChange(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function OutwardChange_UpdateCheck(ByVal Objinfo As OutwardChangeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardChange_UpdateCheck")

                db.AddInParameter(dbComm, "@OC_NO", DbType.String, Objinfo.OC_NO)
                db.AddInParameter(dbComm, "@OC_Check", DbType.Boolean, Objinfo.OC_Check)
                db.AddInParameter(dbComm, "@OC_CheckAction", DbType.String, Objinfo.OC_CheckAction)
                If Objinfo.OC_CheckDate = Nothing Then
                    db.AddInParameter(dbComm, "@OC_CheckDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@OC_CheckDate", DbType.Date, Objinfo.OC_CheckDate)
                End If
                db.AddInParameter(dbComm, "@OC_CheckRemark", DbType.String, Objinfo.OC_CheckRemark)

                db.ExecuteNonQuery(dbComm)
                OutwardChange_UpdateCheck = True

            Catch ex As Exception

                MsgBox(ex.Message)
                OutwardChange_UpdateCheck = False

            End Try
        End Function

        Public Function UpdateOutwardChange_NoSendQty(ByVal Objinfo As OutwardChangeInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("UpdateOutwardChange_NoSendQty")

                db.AddInParameter(dbComm, "@O_NO", DbType.String, Objinfo.O_NO)
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, Objinfo.OS_BatchID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, Objinfo.M_Code)
                db.AddInParameter(dbComm, "@OS_NoSendQty", DbType.Double, Objinfo.OS_NoSendQty)

                db.ExecuteNonQuery(dbComm)
                UpdateOutwardChange_NoSendQty = True

            Catch ex As Exception

                MsgBox(ex.Message)
                UpdateOutwardChange_NoSendQty = False
            End Try

        End Function

        Public Function FillOutwardChange(ByVal reader As IDataReader) As OutwardChangeInfo

            On Error Resume Next

            Dim fci As New OutwardChangeInfo

            fci.AutoID = reader("AutoID").ToString
            fci.OC_NO = reader("OC_NO").ToString
            fci.O_NO = reader("O_NO").ToString
            fci.OS_BatchID = reader("OS_BatchID").ToString
            fci.PM_M_Code = reader("PM_M_Code").ToString
            fci.M_Code = reader("M_Code").ToString

            If reader("OS_Qty") Is DBNull.Value Then
                fci.OS_Qty = Nothing
            Else
                fci.OS_Qty = CDbl(reader("OS_Qty").ToString)
            End If
            If reader("OS_NoSendQty") Is DBNull.Value Then
                fci.OS_NoSendQty = Nothing
            Else
                fci.OS_NoSendQty = CDbl(reader("OS_NoSendQty").ToString)
            End If
            If reader("OC_Qty") Is DBNull.Value Then
                fci.OC_Qty = Nothing
            Else
                fci.OC_Qty = CDbl(reader("OC_Qty").ToString)
            End If

            fci.OC_Reason = reader("OC_Reason").ToString
            fci.OC_Action = reader("OC_Action").ToString

            If reader("OC_AddDate") Is DBNull.Value Then
                fci.OC_AddDate = Nothing
            Else
                fci.OC_AddDate = CStr(reader("OC_AddDate"))
            End If
            If reader("OC_EditDate") Is DBNull.Value Then
                fci.OC_EditDate = Nothing
            Else
                fci.OC_EditDate = CStr(reader("OC_EditDate"))
            End If

            fci.OC_Remark = reader("OC_Remark").ToString

            If reader("OC_Check") Is DBNull.Value Then
                fci.OC_Check = Nothing
            Else
                fci.OC_Check = reader("OC_Check")
            End If

            fci.OC_CheckAction = reader("OC_CheckAction").ToString

            If reader("OC_CheckDate") Is DBNull.Value Then
                fci.OC_CheckDate = Nothing
            Else
                fci.OC_CheckDate = CStr(reader("OC_CheckDate"))
            End If

            fci.OC_CheckRemark = reader("OC_CheckRemark").ToString
            '------------------------------------------------------------------------------------------
            fci.M_Gauge = reader("M_Gauge").ToString
            fci.M_Name = reader("M_Name").ToString
            fci.CheckActionName = reader("CheckActionName").ToString
            fci.ActionName = reader("ActionName").ToString

            Return fci

        End Function

    End Class

End Namespace

