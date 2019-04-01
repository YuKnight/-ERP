
Namespace LFERP.Library.Production.ProductionOutWard

    Public Class ProductionOutWardControl

        Public Function ProductionOutWard_GetNO(ByVal NDate As String) As ProductionOutWardInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionOutWard_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionOutWard(reader)
                End While
                Return Nothing
            End Using

        End Function

        Public Function ProductionOutWard_Add(ByVal objinfo As ProductionOutWardInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionOutWard_Add")

                db.AddInParameter(dbComm, "@OW_ID", DbType.String, objinfo.OW_ID)
                db.AddInParameter(dbComm, "@OW_TO", DbType.String, objinfo.OW_TO)
                db.AddInParameter(dbComm, "@OW_From", DbType.String, objinfo.OW_From)
                db.AddInParameter(dbComm, "@OW_IN", DbType.String, objinfo.OW_IN)
                db.AddInParameter(dbComm, "@OW_Out", DbType.String, objinfo.OW_Out)
                db.AddInParameter(dbComm, "@OW_Reason", DbType.String, objinfo.OW_Reason)
                db.AddInParameter(dbComm, "@OW_Detail", DbType.String, objinfo.OW_Detail)

                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@OW_Return", DbType.String, objinfo.OW_Return)
                db.AddInParameter(dbComm, "@OW_Do", DbType.String, objinfo.OW_Do)
                db.AddInParameter(dbComm, "@OW_Type", DbType.String, objinfo.OW_Type)
                db.AddInParameter(dbComm, "@OW_Date", DbType.Date, objinfo.OW_Date)
                db.AddInParameter(dbComm, "@OW_Qty", DbType.Single, objinfo.OW_Qty)
                db.AddInParameter(dbComm, "@OW_Weight", DbType.Single, objinfo.OW_Weight)

                db.AddInParameter(dbComm, "@OW_Unit", DbType.String, objinfo.OW_Unit)
                db.AddInParameter(dbComm, "@OW_Remark", DbType.String, objinfo.OW_Remark)
                db.AddInParameter(dbComm, "@OW_Action", DbType.String, objinfo.OW_Action)

                db.ExecuteNonQuery(dbComm)
                ProductionOutWard_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionOutWard_Add = False
            End Try

        End Function

        Public Function ProductionOutWard_Update(ByVal objinfo As ProductionOutWardInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionOutWard_Update")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@OW_ID", DbType.String, objinfo.OW_ID)
                db.AddInParameter(dbComm, "@OW_TO", DbType.String, objinfo.OW_TO)
                db.AddInParameter(dbComm, "@OW_From", DbType.String, objinfo.OW_From)
                db.AddInParameter(dbComm, "@OW_IN", DbType.String, objinfo.OW_IN)
                db.AddInParameter(dbComm, "@OW_Out", DbType.String, objinfo.OW_Out)
                db.AddInParameter(dbComm, "@OW_Reason", DbType.String, objinfo.OW_Reason)
                db.AddInParameter(dbComm, "@OW_Detail", DbType.String, objinfo.OW_Detail)

                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@OW_Return", DbType.String, objinfo.OW_Return)
                db.AddInParameter(dbComm, "@OW_Do", DbType.String, objinfo.OW_Do)
                db.AddInParameter(dbComm, "@OW_Type", DbType.String, objinfo.OW_Type)
                db.AddInParameter(dbComm, "@OW_Date", DbType.Date, objinfo.OW_Date)
                db.AddInParameter(dbComm, "@OW_Qty", DbType.Single, objinfo.OW_Qty)
                db.AddInParameter(dbComm, "@OW_Weight", DbType.Single, objinfo.OW_Weight)
                db.AddInParameter(dbComm, "@OW_Unit", DbType.String, objinfo.OW_Unit)
                db.AddInParameter(dbComm, "@OW_Remark", DbType.String, objinfo.OW_Remark)
                db.AddInParameter(dbComm, "@OW_Action", DbType.String, objinfo.OW_Action)

                db.ExecuteNonQuery(dbComm)
                ProductionOutWard_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionOutWard_Update = False
            End Try
        End Function

        Public Function ProductionOutWard_Delete(ByVal OW_ID As String, ByVal AutoID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionOutWard_Delete")


                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbComm, "@OW_ID", DbType.String, OW_ID)

                db.ExecuteNonQuery(dbComm)
                ProductionOutWard_Delete = True

            Catch ex As Exception

                MsgBox(ex.Message)
                ProductionOutWard_Delete = False
            End Try
       
        End Function

        Public Function ProductionOutWard_UpdateCheck(ByVal objinfo As ProductionOutWardInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionOutWard_UpdateCheck")

                db.AddInParameter(dbComm, "@OW_ID", DbType.String, objinfo.OW_ID)
                db.AddInParameter(dbComm, "@OW_Check", DbType.Boolean, objinfo.OW_Check)
                db.AddInParameter(dbComm, "@OW_CheckAction", DbType.String, objinfo.OW_CheckAction)
                db.AddInParameter(dbComm, "@OW_CheckRemark", DbType.String, objinfo.OW_CheckRemark)
                db.AddInParameter(dbComm, "@OW_CheckDate", DbType.Date, objinfo.OW_CheckDate)
         
                db.ExecuteNonQuery(dbComm)
                ProductionOutWard_UpdateCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionOutWard_UpdateCheck = False
            End Try
        End Function

        Public Function ProductionOutWard_GetList(ByVal OW_ID As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal OW_Detail As String, ByVal Pro_NO As String, ByVal OW_Type As String, ByVal OW_Do As String, ByVal OW_Return As String, ByVal OW_IN As String, ByVal OW_Out As String, ByVal OW_Date1 As String, ByVal OW_Date2 As String) As List(Of ProductionOutWardInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionOutWard_GetList")

            db.AddInParameter(dbComm, "@OW_ID", DbType.String, OW_ID)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@OW_Detail", DbType.String, OW_Detail)

            db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Pro_NO)
            db.AddInParameter(dbComm, "@OW_Type", DbType.String, OW_Type)
            db.AddInParameter(dbComm, "@OW_Do", DbType.String, OW_Do)
            db.AddInParameter(dbComm, "@OW_Return", DbType.String, OW_Return)
            db.AddInParameter(dbComm, "@OW_IN", DbType.String, OW_IN)
            db.AddInParameter(dbComm, "@OW_Out", DbType.String, OW_Out)
            db.AddInParameter(dbComm, "@OW_Date1", DbType.String, OW_Date1)
            db.AddInParameter(dbComm, "@OW_Date2", DbType.String, OW_Date2)


            Dim FeatureList As New List(Of ProductionOutWardInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionOutWard(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FillProductionOutWard(ByVal reader As IDataReader) As ProductionOutWardInfo
            On Error Resume Next

            Dim pi As New ProductionOutWardInfo


            If reader("PM_JiYu") Is DBNull.Value Then
                pi.PM_JiYu = Nothing
            Else
                pi.PM_JiYu = reader("PM_JiYu")
            End If


            pi.AutoID = reader("AutoID").ToString
            pi.OW_Type = reader("OW_Type").ToString
            pi.OW_ID = reader("OW_ID").ToString

            pi.OW_TO = reader("OW_TO").ToString
            pi.OW_From = reader("OW_From").ToString
            pi.OW_IN = reader("OW_IN").ToString
            pi.OW_Out = reader("OW_Out").ToString
            pi.OW_Driver = reader("OW_Driver").ToString


            pi.PM_M_Code = reader("PM_M_Code").ToString
            pi.PM_Type = reader("PM_Type").ToString
            pi.Pro_NO = reader("Pro_NO").ToString

            If reader("OW_Date") Is DBNull.Value Then
                pi.OW_Date = Nothing
            Else
                pi.OW_Date = CStr(reader("OW_Date"))
            End If

            If reader("OW_Qty") Is DBNull.Value Then
                pi.OW_Qty = 0
            Else
                pi.OW_Qty = CInt(reader("OW_Qty"))
            End If
            If reader("OW_Weight") Is DBNull.Value Then
                pi.OW_Weight = 0
            Else
                pi.OW_Weight = CSng(reader("OW_Weight"))
            End If
            pi.OW_Remark = reader("OW_Remark").ToString

            If reader("OW_Check") Is DBNull.Value Then
                pi.OW_Check = Nothing
            Else
                pi.OW_Check = reader("OW_Check")
            End If

            If reader("OW_CheckDate") Is DBNull.Value Then
                pi.OW_CheckDate = Nothing
            Else
                pi.OW_CheckDate = CStr(reader("OW_CheckDate"))
            End If

            pi.OW_CheckRemark = reader("OW_CheckRemark").ToString
            pi.OW_Return = reader("OW_Return").ToString
            pi.OW_Do = reader("OW_Do").ToString
            pi.OW_Type = reader("OW_Type").ToString
            pi.OW_Reason = reader("OW_Reason").ToString
            pi.OW_Detail = reader("OW_Detail").ToString

            pi.OW_Unit = reader("OW_Unit").ToString

            pi.PS_Name = reader("PS_Name").ToString
            pi.ActionName = reader("ActionName").ToString
            pi.CheckActionName = reader("CheckActionName").ToString

            Return pi

        End Function

    End Class

End Namespace


