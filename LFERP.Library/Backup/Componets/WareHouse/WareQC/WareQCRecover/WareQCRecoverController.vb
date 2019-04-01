

Namespace LFERP.Library.WareHouse.WareQCRecover

    Public Class WareQCRecoverController

        Public Function WareQCRecover_GetNO(ByVal Ndate As String) As WareQCRecoverInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareQCRecover_GetNO")
            db.AddInParameter(dbComm, "@Ndate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillWareQCRecover(reader)
                End While
                Return Nothing
            End Using
        End Function
        Public Function WareQCRecover_GetAutoID(ByVal AutoID As String) As WareQCRecoverInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareQCRecover_GetAutoID")
            db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillWareQCRecover(reader)
                End While
                Return Nothing
            End Using
        End Function
        Public Function WareQCRecover_Add(ByVal objinfo As WareQCRecoverInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareQCRecover_Add")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@WQR_NO", DbType.String, objinfo.WQR_NO)
                db.AddInParameter(dbComm, "@WQS_NO", DbType.String, objinfo.WQS_NO)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@WQR_Qty", DbType.String, objinfo.WQR_Qty)
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, objinfo.WH_ID)
                db.AddInParameter(dbComm, "@WQR_Date", DbType.Date, objinfo.WQR_Date)
                db.AddInParameter(dbComm, "@WQR_Remark", DbType.String, objinfo.WQR_Remark)
                db.AddInParameter(dbComm, "@WQR_Action", DbType.String, objinfo.WQR_Action)

                db.ExecuteNonQuery(dbComm)
                WareQCRecover_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareQCRecover_Add = False
            End Try
        End Function
        Public Function WareQCRecover_Update(ByVal objinfo As WareQCRecoverInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareQCRecover_Update")


                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@WQR_NO", DbType.String, objinfo.WQR_NO)
                db.AddInParameter(dbComm, "@WQS_NO", DbType.String, objinfo.WQS_NO)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@WQR_Qty", DbType.String, objinfo.WQR_Qty)
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, objinfo.WH_ID)
                db.AddInParameter(dbComm, "@WQR_Date", DbType.Date, objinfo.WQR_Date)
                db.AddInParameter(dbComm, "@WQR_Remark", DbType.String, objinfo.WQR_Remark)
                db.AddInParameter(dbComm, "@WQR_Action", DbType.String, objinfo.WQR_Action)

                db.ExecuteNonQuery(dbComm)
                WareQCRecover_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareQCRecover_Update = False
            End Try
        End Function
        Public Function WareQCRecover_Delete(ByVal WQR_NO As String, ByVal WQS_NO As String, ByVal AutoID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareQCRecover_Delete")

                db.AddInParameter(dbComm, "@WQR_NO", DbType.String, WQR_NO)
                db.AddInParameter(dbComm, "@WQS_NO", DbType.String, WQS_NO)
                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)

                db.ExecuteNonQuery(dbComm)
                WareQCRecover_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                WareQCRecover_Delete = False
            End Try
        End Function
        Public Function WareQCRecover_Check(ByVal objinfo As WareQCRecoverInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareQCRecover_Check")

                db.AddInParameter(dbComm, "@WQR_NO", DbType.String, objinfo.WQR_NO)
                db.AddInParameter(dbComm, "@WQR_Check", DbType.Boolean, objinfo.WQR_Check)
                db.AddInParameter(dbComm, "@WQR_CheckAction", DbType.String, objinfo.WQR_CheckAction)

                db.ExecuteNonQuery(dbComm)
                WareQCRecover_Check = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareQCRecover_Check = False
            End Try
        End Function
        Public Function WareQCRecover_GetList(ByVal WQR_NO As String, ByVal WQS_NO As String, ByVal M_Code As String, ByVal WQR_Action As String, ByVal WQR_BeginDate As String, ByVal WQR_EndDate As String) As List(Of WareQCRecoverInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareQCRecover_GetList")

            db.AddInParameter(dbComm, "@WQR_NO", DbType.String, WQR_NO)
            db.AddInParameter(dbComm, "@WQS_NO", DbType.String, WQS_NO)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@WQR_Action", DbType.String, WQR_Action)
            db.AddInParameter(dbComm, "@WQR_BeginDate", DbType.String, WQR_BeginDate)
            db.AddInParameter(dbComm, "@WQR_EndDate", DbType.String, WQR_EndDate)

            Dim FeatureList As New List(Of WareQCRecoverInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareQCRecover(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function FillWareQCRecover(ByVal reader As IDataReader) As WareQCRecoverInfo
            On Error Resume Next

            Dim qri As New WareQCRecoverInfo

            qri.AutoID = reader("AutoID").ToString

            qri.WQS_NO = reader("WQS_NO").ToString
            qri.WQR_NO = reader("WQR_NO").ToString
            qri.WQR_Qty = CDbl(reader("WQR_Qty"))
            qri.M_Code = reader("M_Code").ToString
            qri.WH_ID = reader("WH_ID").ToString
            qri.WQR_Action = reader("WQR_Action").ToString

            If reader("WQR_Check") Is DBNull.Value Then
                qri.WQR_Check = Nothing
            Else
                qri.WQR_Check = reader("WQR_Check")
            End If

            qri.WQR_CheckAction = reader("WQR_CheckAction").ToString
            If reader("WQR_Date") Is DBNull.Value Then
                qri.WQR_Date = Nothing
            Else
                qri.WQR_Date = CStr(reader("WQR_Date"))
            End If
          
            qri.WQR_Remark = reader("WQR_Remark").ToString
            qri.M_Gauge = reader("M_Gauge").ToString
            qri.M_Name = reader("M_Name").ToString
            qri.UserName = reader("UserName").ToString
            qri.WH_Name = reader("WH_Name").ToString

            Return qri

        End Function

    End Class

End Namespace

