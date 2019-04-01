

Namespace LFERP.Library.ProductionWareMove

    Public Class ProductionWareMoveControl

        Public Function ProductionWareMove_GetNo(ByVal NDate As String) As ProductionWareMoveInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareMove_GetNo")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionWareMove(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function ProductionWareMove_GetNum(ByVal NDate As String) As ProductionWareMoveInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareMove_GetNum")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionWareMove(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function ProductionWareMove_Add(ByVal objinfo As ProductionWareMoveInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareMove_Add")

                db.AddInParameter(dbComm, "@PWM_NO", DbType.String, objinfo.PWM_NO)
                db.AddInParameter(dbComm, "@PH_OutID", DbType.String, objinfo.PH_OutID)
                db.AddInParameter(dbComm, "@PH_InID", DbType.String, objinfo.PH_InID)
                db.AddInParameter(dbComm, "@PWM_Type", DbType.String, objinfo.PWM_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)

                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@PWM_Qty", DbType.Int32, objinfo.PWM_Qty)
                db.AddInParameter(dbComm, "@PWM_AddDate", DbType.Date, objinfo.PWM_AddDate)
                db.AddInParameter(dbComm, "@PWM_Property", DbType.String, objinfo.PWM_Property)
                db.AddInParameter(dbComm, "@PWM_Remark", DbType.String, objinfo.PWM_Remark)

                db.AddInParameter(dbComm, "@PWM_OutAction", DbType.String, objinfo.PWM_OutAction)

                db.ExecuteNonQuery(dbComm)

                ProductionWareMove_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionWareMove_Add = False
            End Try
        End Function

        Public Function ProductionWareMove_Update(ByVal objinfo As ProductionWareMoveInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareMove_Update")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@PH_InID", DbType.String, objinfo.PH_InID)
                db.AddInParameter(dbComm, "@PWM_Type", DbType.String, objinfo.PWM_Type)
                db.AddInParameter(dbComm, "@PWM_Qty", DbType.Int32, objinfo.PWM_Qty)
                db.AddInParameter(dbComm, "@PWM_ModifyDate", DbType.Date, objinfo.PWM_ModifyDate)

                db.AddInParameter(dbComm, "@PWM_ModifyUserID", DbType.String, objinfo.PWM_ModifyUserID)
                db.AddInParameter(dbComm, "@PWM_Property", DbType.String, objinfo.PWM_Property)
                db.AddInParameter(dbComm, "@PWM_Remark", DbType.String, objinfo.PWM_Remark)

                db.ExecuteNonQuery(dbComm)
                ProductionWareMove_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionWareMove_Update = False

            End Try

        End Function

        Public Function ProductionWareMove_Delete(ByVal PWM_NO As String, ByVal AutoID As String) As Boolean
            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareMove_Delete")

                db.AddInParameter(dbComm, "@PWM_NO", DbType.String, PWM_NO)
                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)

                db.ExecuteNonQuery(dbComm)
                ProductionWareMove_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionWareMove_Delete = False
            End Try
        End Function

        Public Function ProductionWareMove_UpdateInCheck(ByVal objinfo As ProductionWareMoveInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareMove_UpdateInCheck")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@PWM_InAction", DbType.String, objinfo.PWM_InAction)
                db.AddInParameter(dbComm, "@PWM_InCheck", DbType.Boolean, objinfo.PWM_InCheck)
                db.AddInParameter(dbComm, "@PWM_InDate", DbType.Date, objinfo.PWM_InDate)

                db.ExecuteNonQuery(dbComm)
                ProductionWareMove_UpdateInCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionWareMove_UpdateInCheck = False
            End Try
        End Function

        Public Function ProductionWareMove_UpdateCheck(ByVal objinfo As ProductionWareMoveInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareMove_UpdateCheck")

                db.AddInParameter(dbComm, "@PWM_NO", DbType.String, objinfo.PWM_NO)
                db.AddInParameter(dbComm, "@PWM_Check", DbType.Boolean, objinfo.PWM_Check)
                db.AddInParameter(dbComm, "@PWM_CheckDate", DbType.Date, objinfo.PWM_CheckDate)
                db.AddInParameter(dbComm, "@PWM_CheckRemark", DbType.String, objinfo.PWM_CheckRemark)
                db.AddInParameter(dbComm, "@PWM_CheckAction", DbType.String, objinfo.PWM_CheckAction)

                db.ExecuteNonQuery(dbComm)
                ProductionWareMove_UpdateCheck = True

            Catch ex As Exception

                MsgBox(ex.Message)
                ProductionWareMove_UpdateCheck = False
            End Try
        End Function

        Public Function ProductionWareMove_GetList(ByVal PWM_NO As String, ByVal PM_M_Code As String, ByVal M_Code As String, ByVal M_Name As String, ByVal PWM_Date1 As String, ByVal PWM_Date2 As String, ByVal PWM_Type As String, ByVal PH_InID As String, ByVal PH_OutID As String, ByVal PWM_Property As String, ByVal PWM_OutCheck As String, ByVal PWM_InCheck As String, ByVal PWM_Check As String) As List(Of ProductionWareMoveInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareMove_GetList")

            db.AddInParameter(dbComm, "@PWM_NO", DbType.String, PWM_NO)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@PWM_Date1", DbType.String, PWM_Date1)

            db.AddInParameter(dbComm, "@PWM_Date2", DbType.String, PWM_Date2)
            db.AddInParameter(dbComm, "@PWM_Type", DbType.String, PWM_Type)
            db.AddInParameter(dbComm, "@PH_InID", DbType.String, PH_InID)
            db.AddInParameter(dbComm, "@PH_OutID", DbType.String, PH_OutID)
            db.AddInParameter(dbComm, "@PWM_Property", DbType.String, PWM_Property)

            db.AddInParameter(dbComm, "@PWM_OutCheck", DbType.String, PWM_OutCheck)
            db.AddInParameter(dbComm, "@PWM_InCheck", DbType.String, PWM_InCheck)
            db.AddInParameter(dbComm, "@PWM_Check", DbType.String, PWM_Check)

            Dim FeatureList As New List(Of ProductionWareMoveInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionWareMove(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FillProductionWareMove(ByVal reader As IDataReader) As ProductionWareMoveInfo

            On Error Resume Next

            Dim fpwi As New ProductionWareMoveInfo

            fpwi.AutoID = reader("AutoID").ToString
            fpwi.PWM_NO = reader("PWM_NO").ToString
            fpwi.PH_InID = reader("PH_InID").ToString
            fpwi.PH_OutID = reader("PH_OutID").ToString
            fpwi.PWM_Type = reader("PWM_Type").ToString
            fpwi.PM_M_Code = reader("PM_M_Code").ToString

            fpwi.M_Code = reader("M_Code").ToString
            If reader("PWM_Qty") Is DBNull.Value Then
                fpwi.PWM_Qty = 0
            Else
                fpwi.PWM_Qty = CInt(reader("PWM_Qty"))
            End If
            fpwi.PWM_AddDate = Format(reader("PWM_AddDate"), "yyyy/MM/dd HH:mm:ss")

            fpwi.PWM_Property = reader("PWM_Property").ToString
            fpwi.PWM_Remark = reader("PWM_Remark").ToString

            If reader("PWM_InCheck") Is DBNull.Value Then
                fpwi.PWM_InCheck = False
            Else
                fpwi.PWM_InCheck = reader("PWM_InCheck")
            End If
            If reader("PWM_InDate") Is DBNull.Value Then
                fpwi.PWM_InDate = Nothing
            Else
                fpwi.PWM_InDate = Format(reader("PWM_InDate"), "yyyy/MM/dd HH:mm:ss")
            End If
            If reader("PWM_OutCheck") Is DBNull.Value Then
                fpwi.PWM_OutCheck = False
            Else
                fpwi.PWM_OutCheck = reader("PWM_OutCheck")
            End If
            fpwi.PWM_InAction = reader("PWM_InAction").ToString
            fpwi.PWM_OutAction = reader("PWM_OutAction").ToString
            If reader("PWM_Check") Is DBNull.Value Then
                fpwi.PWM_Check = False
            Else
                fpwi.PWM_Check = reader("PWM_Check")
            End If

            fpwi.PWM_CheckAction = reader("PWM_CheckAction").ToString

            If reader("PWM_CheckDate") Is DBNull.Value Then
                fpwi.PWM_CheckDate = Nothing
            Else
                fpwi.PWM_CheckDate = Format(reader("PWM_CheckDate"), "yyyy/MM/dd HH:mm:ss")
            End If
            fpwi.PWM_CheckRemark = reader("PWM_CheckRemark").ToString

            fpwi.M_Gauge = reader("M_Gauge").ToString
            fpwi.M_Name = reader("M_Name").ToString
            fpwi.M_Unit = reader("M_Unit").ToString
            fpwi.InActionName = reader("InActionName").ToString
            fpwi.OutActionName = reader("OutActionName").ToString
            fpwi.CheckActionName = reader("CheckActionName").ToString
            fpwi.PH_OutName = reader("PH_OutName").ToString
            fpwi.PH_InName = reader("PH_InName").ToString


            Return fpwi

        End Function
    End Class

End Namespace

