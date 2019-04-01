
Namespace LFERP.Library.WareHouse.WareChange

    Public Class WareChangeControl

        Public Function WareChange_GetNO(ByVal NDate As String) As WareChangeInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareChange_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillWareChange(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function WareChange_Insert(ByVal objinfo As WareChangeInfo) As Boolean
            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("WareChange_Insert")

                db.AddInParameter(dbcomm, "@C_ChangeNO", DbType.String, objinfo.C_ChangeNO)
                db.AddInParameter(dbcomm, "@WH_ID", DbType.String, objinfo.WH_ID)
                db.AddInParameter(dbcomm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbcomm, "@WI_Qty", DbType.Double, objinfo.WI_Qty)
                db.AddInParameter(dbcomm, "@C_Qty", DbType.Double, objinfo.C_Qty)
                db.AddInParameter(dbcomm, "@C_Date", DbType.Date, objinfo.C_Date)
                db.AddInParameter(dbcomm, "@C_Remark", DbType.String, objinfo.C_Remark)
                db.AddInParameter(dbcomm, "@C_Action", DbType.String, objinfo.C_Action)
                db.AddInParameter(dbcomm, "@C_Check", DbType.Boolean, objinfo.C_Check)
                db.AddInParameter(dbcomm, "@C_CheckAction", DbType.String, objinfo.C_CheckAction)
                db.AddInParameter(dbcomm, "@C_ReCheck", DbType.Boolean, objinfo.C_ReCheck)
                db.AddInParameter(dbcomm, "@C_ReCheckAction", DbType.String, objinfo.C_ReCheckAction)

                db.ExecuteNonQuery(dbcomm)
                WareChange_Insert = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareChange_Insert = False
            End Try
        End Function

        Public Function WareChange_Add(ByVal objinfo As WareChangeInfo) As Boolean
            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("WareChange_Add")

                db.AddInParameter(dbcomm, "@C_ChangeNO", DbType.String, objinfo.C_ChangeNO)
                db.AddInParameter(dbcomm, "@WH_ID", DbType.String, objinfo.WH_ID)
                db.AddInParameter(dbcomm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbcomm, "@WI_Qty", DbType.Double, objinfo.WI_Qty)
                db.AddInParameter(dbcomm, "@C_Qty", DbType.Double, objinfo.C_Qty)
                db.AddInParameter(dbcomm, "@C_Date", DbType.Date, objinfo.C_Date)
                db.AddInParameter(dbcomm, "@C_Remark", DbType.String, objinfo.C_Remark)
                db.AddInParameter(dbcomm, "@C_Action", DbType.String, objinfo.C_Action)

                db.ExecuteNonQuery(dbcomm)
                WareChange_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareChange_Add = False
            End Try

        End Function


        Public Function WareChange_Update(ByVal objinfo As WareChangeInfo) As Boolean
            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("WareChange_Update")

                db.AddInParameter(dbcomm, "@IndexNo", DbType.String, objinfo.IndexNo)
                db.AddInParameter(dbcomm, "@WH_ID", DbType.String, objinfo.WH_ID)
                db.AddInParameter(dbcomm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbcomm, "@WI_Qty", DbType.Double, objinfo.WI_Qty)
                db.AddInParameter(dbcomm, "@C_Qty", DbType.Double, objinfo.C_Qty)
                db.AddInParameter(dbcomm, "@C_Date", DbType.Date, objinfo.C_Date)
                db.AddInParameter(dbcomm, "@C_Remark", DbType.String, objinfo.C_Remark)
                db.AddInParameter(dbcomm, "@C_Action", DbType.String, objinfo.C_Action)

                db.ExecuteNonQuery(dbcomm)
                WareChange_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareChange_Update = False
            End Try
        End Function

        Public Function WareChange_Delete(ByVal C_ChangeNO As String, ByVal IndexNo As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("WareChange_Delete")

                db.AddInParameter(dbcomm, "@C_ChangeNO", DbType.String, C_ChangeNO)
                db.AddInParameter(dbcomm, "@IndexNo", DbType.String, IndexNo)

                db.ExecuteNonQuery(dbcomm)
                WareChange_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                WareChange_Delete = False

            End Try
        End Function

        Public Function WareChange_UpdateCheck(ByVal objinfo As WareChangeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("WareChange_UpdateCheck")

                db.AddInParameter(dbcomm, "@C_ChangeNO", DbType.String, objinfo.C_ChangeNO)
                db.AddInParameter(dbcomm, "@C_Check", DbType.Boolean, objinfo.C_Check)
                db.AddInParameter(dbcomm, "@C_CheckDate", DbType.Date, objinfo.C_CheckDate)
                db.AddInParameter(dbcomm, "@C_CheckRemark", DbType.String, objinfo.C_CheckRemark)
                db.AddInParameter(dbcomm, "@C_CheckAction", DbType.String, objinfo.C_CheckAction)

                db.ExecuteNonQuery(dbcomm)
                WareChange_UpdateCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareChange_UpdateCheck = False
            End Try
        End Function

        Public Function WareChange_UpdateReCheck(ByVal objinfo As WareChangeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("WareChange_UpdateReCheck")

                db.AddInParameter(dbcomm, "@C_ChangeNO", DbType.String, objinfo.C_ChangeNO)
                db.AddInParameter(dbcomm, "@C_ReCheck", DbType.Boolean, objinfo.C_ReCheck)
                db.AddInParameter(dbcomm, "@C_ReCheckDate", DbType.Date, objinfo.C_ReCheckDate)
                db.AddInParameter(dbcomm, "@C_ReCheckRemark", DbType.String, objinfo.C_ReCheckRemark)
                db.AddInParameter(dbcomm, "@C_ReCheckAction", DbType.String, objinfo.C_ReCheckAction)

                db.ExecuteNonQuery(dbcomm)
                WareChange_UpdateReCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareChange_UpdateReCheck = False
            End Try
        End Function

        Public Function WareChange_GetList(ByVal C_ChangeNO As String, ByVal M_Code As String, ByVal M_Name As String, ByVal WH_ID As String, ByVal C_Check As String) As List(Of WareChangeInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareChange_GetList")

            db.AddInParameter(dbComm, "@C_ChangeNO", DbType.String, C_ChangeNO)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@C_Check", DbType.String, C_Check)

            Dim FeatureList As New List(Of WareChangeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareChange(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function FillWareChange(ByVal reader As IDataReader) As WareChangeInfo

            On Error Resume Next

            Dim ci As New WareChangeInfo
            '對應取得的數據
            On Error Resume Next

            ci.IndexNo = reader("IndexNo").ToString

            '--------------------------------------------------------------------
            ci.C_ChangeNO = reader("C_ChangeNO").ToString
            ci.WH_ID = reader("WH_ID").ToString
            ci.M_Code = reader("M_Code").ToString

            If reader("WI_Qty") Is DBNull.Value Then
                ci.WI_Qty = Nothing
            Else
                ci.WI_Qty = CDbl(reader("WI_Qty").ToString)
            End If

            If reader("C_Qty") Is DBNull.Value Then
                ci.C_Qty = Nothing
            Else
                ci.C_Qty = CDbl(reader("C_Qty").ToString)
            End If
            ci.C_Remark = reader("C_Remark").ToString

            If reader("C_Date") Is DBNull.Value Then
                ci.C_Date = Nothing
            Else
                ci.C_Date = CStr(reader("C_Date"))
            End If
            ci.C_Action = reader("C_Action").ToString
         
            '--------------------------------------------------------------------
            If reader("C_Check") Is DBNull.Value Then
                ci.C_Check = False
            Else
                ci.C_Check = reader("C_Check")
            End If
            If reader("C_CheckDate") Is DBNull.Value Then
                ci.C_CheckDate = Nothing
            Else
                ci.C_CheckDate = CStr(reader("C_CheckDate"))
            End If
            ci.C_CheckRemark = reader("C_CheckRemark").ToString
            ci.C_CheckAction = reader("C_CheckAction").ToString

            '---------------------------------------------------------------------

            '--------------------------------------------------------------------
            If reader("C_ReCheck") Is DBNull.Value Then
                ci.C_ReCheck = False
            Else
                ci.C_ReCheck = reader("C_ReCheck")
            End If
            If reader("C_ReCheckDate") Is DBNull.Value Then
                ci.C_ReCheckDate = Nothing
            Else
                ci.C_ReCheckDate = CStr(reader("C_ReCheckDate"))
            End If
            ci.C_ReCheckRemark = reader("C_ReCheckRemark").ToString
            ci.C_ReCheckAction = reader("C_ReCheckAction").ToString

            '---------------------------------------------------------------------

            ci.M_Gauge = reader("M_Gauge").ToString
            ci.M_Name = reader("M_Name").ToString
            ci.M_Unit = reader("M_Unit").ToString
            ci.ActionName = reader("ActionName").ToString
            ci.CheckActionName = reader("CheckActionName").ToString
            ci.ReCheckActionName = reader("ReCheckActionName").ToString
            ci.WH_PName = reader("WH_PName").ToString
            ci.WH_Name = reader("WH_PName").ToString & "-" & reader("WH_Name").ToString


            Return ci

        End Function

    End Class

End Namespace

