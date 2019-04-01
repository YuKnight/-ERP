

Namespace LFERP.Library.WareHouse.WareQCSend

    Public Class WareQCSendController

        Public Function WareQCSend_GetAutoID(ByVal AutoID As String) As WareQCSendInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareQCSend_GetAutoID")
            db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillWareQCSend(reader)
                End While
                Return Nothing
            End Using
        End Function
        Public Function WareQCSend_GetNO(ByVal Ndate As String) As WareQCSendInfo

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareQCSend_GetNO")
            db.AddInParameter(dbComm, "@Ndate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillWareQCSend(reader)
                End While
                Return Nothing
            End Using

        End Function

        Public Function WareQCSend_Add(ByVal objinfo As WareQCSendInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareQCSend_Add")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@WQS_NO", DbType.String, objinfo.WQS_NO)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@WQS_Qty", DbType.Single, objinfo.WQS_Qty)
                db.AddInParameter(dbComm, "@WQS_NotRecoverQty", DbType.Single, objinfo.WQS_NotRecoverQty)
                db.AddInParameter(dbComm, "@A_AcceptanceNO", DbType.String, objinfo.A_AcceptanceNO)
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, objinfo.WH_ID)
                db.AddInParameter(dbComm, "@WQS_Date", DbType.Date, objinfo.WQS_Date)
                db.AddInParameter(dbComm, "@WQS_Remark", DbType.String, objinfo.WQS_Remark)
                db.AddInParameter(dbComm, "@WQS_Action", DbType.String, objinfo.WQS_Action)

                db.ExecuteNonQuery(dbComm)
                WareQCSend_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                WareQCSend_Add = False
            End Try
           
        End Function

        Public Function WareQCSend_Update(ByVal Objinfo As WareQCSendInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareQCSend_Update")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, Objinfo.AutoID)
                db.AddInParameter(dbComm, "@WQS_NO", DbType.String, Objinfo.WQS_NO)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, Objinfo.M_Code)
                db.AddInParameter(dbComm, "@WQS_Qty", DbType.Single, Objinfo.WQS_Qty)
                db.AddInParameter(dbComm, "@WQS_NotRecoverQty", DbType.Single, Objinfo.WQS_NotRecoverQty)
                db.AddInParameter(dbComm, "@A_AcceptanceNO", DbType.String, Objinfo.A_AcceptanceNO)
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, Objinfo.WH_ID)
                db.AddInParameter(dbComm, "@WQS_Date", DbType.Date, Objinfo.WQS_Date)
                db.AddInParameter(dbComm, "@WQS_Remark", DbType.String, Objinfo.WQS_Remark)
                db.AddInParameter(dbComm, "@WQS_Action", DbType.String, Objinfo.WQS_Action)

                db.ExecuteNonQuery(dbComm)
                WareQCSend_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                WareQCSend_Update = False
            End Try
        End Function
        Public Function UpdateWareQC_NotRecoverQty(ByVal objinfo As WareQCSendInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("UpdateWareQC_NotRecoverQty")
                db.AddInParameter(dbComm, "@WQS_NO", DbType.String, objinfo.WQS_NO)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.ExecuteNonQuery(dbComm)
                UpdateWareQC_NotRecoverQty = True
            Catch ex As Exception
                MsgBox(ex.Message)
                UpdateWareQC_NotRecoverQty = False
            End Try
        End Function

        Public Function WareQCSend_Delete(ByVal WQS_NO As String, ByVal M_Code As String, ByVal AutoID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareQCSend_Delete")

                db.AddInParameter(dbComm, "@WQS_NO", DbType.String, WQS_NO)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)

                db.ExecuteNonQuery(dbComm)
                WareQCSend_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareQCSend_Delete = False
            End Try
        End Function
        Public Function WareQCSend_GetSub(ByVal AutoID As String) As WareQCSendInfo

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareQCSend_GetSub")

            db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)

            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillWareQCSend(reader)
                End While
                Return Nothing
            End Using

        End Function
        Public Function WareQCSend_GetList(ByVal WQS_NO As String, ByVal M_Code As String, ByVal A_AcceptanceNO As String, ByVal WQS_Action As String, ByVal WQS_Check As String, ByVal WQS_BeginDate As String, ByVal WQS_EndDate As String) As List(Of WareQCSendInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareQCSend_GetList")

            db.AddInParameter(dbComm, "@WQS_NO", DbType.String, WQS_NO)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@A_AcceptanceNO", DbType.String, A_AcceptanceNO)
            db.AddInParameter(dbComm, "@WQS_Action", DbType.String, WQS_Action)
            db.AddInParameter(dbComm, "@WQS_Check", DbType.String, WQS_Check)
            db.AddInParameter(dbComm, "@WQS_BeginDate", DbType.String, WQS_BeginDate)
            db.AddInParameter(dbComm, "@WQS_EndDate", DbType.String, WQS_EndDate)

            Dim FeatureList As New List(Of WareQCSendInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareQCSend(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function WareQCSend_Check(ByVal objinfo As WareQCSendInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareQCSend_Check")

                db.AddInParameter(dbComm, "@WQS_NO", DbType.String, objinfo.WQS_NO)

                db.AddInParameter(dbComm, "@WQS_Check", DbType.String, objinfo.WQS_Check)
                db.AddInParameter(dbComm, "@WQS_CheckAction", DbType.String, objinfo.WQS_CheckAction)

                db.ExecuteNonQuery(dbComm)
                WareQCSend_Check = True

            Catch ex As Exception
                MsgBox(ex.Message)
                WareQCSend_Check = False
            End Try
        End Function

        Public Function FillWareQCSend(ByVal reader As IDataReader) As WareQCSendInfo

            On Error Resume Next

            Dim wqi As New WareQCSendInfo

            wqi.WQS_NO = reader("WQS_NO").ToString
            wqi.M_Code = reader("M_Code").ToString
            wqi.WQS_Qty = CDbl(reader("WQS_Qty"))
            wqi.WQS_NotRecoverQty = CDbl(reader("WQS_NotRecoverQty"))
            wqi.A_AcceptanceNO = reader("A_AcceptanceNO").ToString
            wqi.WH_ID = reader("WH_ID").ToString

            If reader("WQS_Date") Is DBNull.Value Then
                wqi.WQS_Date = Nothing
            Else
                wqi.WQS_Date = CStr(reader("WQS_Date"))
            End If

            wqi.WQS_Action = reader("WQS_Action").ToString
            wqi.WQS_Remark = reader("WQS_Remark").ToString

            If reader("WQS_Check") Is DBNull.Value Then
                wqi.WQS_Check = Nothing
            Else
                wqi.WQS_Check = reader("WQS_Check")
            End If
            wqi.WQS_CheckAction = reader("WQS_CheckAction").ToString

            wqi.M_Name = reader("M_Name").ToString
            wqi.M_Gauge = reader("M_Gauge").ToString
            wqi.AutoID = reader("AutoID").ToString
            wqi.UserName = reader("UserName").ToString
            wqi.WH_Name = reader("WH_Name").ToString

            Return wqi

        End Function
    End Class

End Namespace

