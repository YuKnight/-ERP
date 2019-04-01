
Namespace LFERP.Library.ProductionFieldChange

    Public Class ProductionFieldChangeControl

        Public Function ProductionFieldChange_GetNO(ByVal NDate As String) As ProductionFieldChangeInfo

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldChange_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionFieldChange(reader)
                End While
                Return Nothing
            End Using

        End Function

        Public Function ProductionFieldChange_Add(ByVal objinfo As ProductionFieldChangeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldChange_Add")


                db.AddInParameter(dbComm, "@PC_NO", DbType.String, objinfo.PC_NO)
                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, objinfo.Pro_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@PC_Qty", DbType.Single, objinfo.PC_Qty)
                db.AddInParameter(dbComm, "@PC_ReQty", DbType.Single, objinfo.PC_ReQty)
                db.AddInParameter(dbComm, "@PC_Type", DbType.String, objinfo.PC_Type)
                db.AddInParameter(dbComm, "@DepID", DbType.String, objinfo.DepID)
                db.AddInParameter(dbComm, "@PC_Date", DbType.Date, objinfo.PC_Date)
                db.AddInParameter(dbComm, "@PC_Action", DbType.String, objinfo.PC_Action)
                db.AddInParameter(dbComm, "@PC_Remark", DbType.String, objinfo.PC_Remark)
                db.AddInParameter(dbComm, "@CardID", DbType.String, objinfo.CardID)
                db.ExecuteNonQuery(dbComm)
                ProductionFieldChange_Add = True

            Catch ex As Exception

                MsgBox(ex.Message)
                ProductionFieldChange_Add = False

            End Try
        End Function

        Public Function ProductionFieldChange_Update(ByVal objinfo As ProductionFieldChangeInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldChange_Update")

                db.AddInParameter(dbComm, "@IndexNO", DbType.String, objinfo.IndexNO)
                db.AddInParameter(dbComm, "@PC_NO", DbType.String, objinfo.PC_NO)
                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, objinfo.Pro_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@PC_Qty", DbType.Single, objinfo.PC_Qty)
                db.AddInParameter(dbComm, "@PC_ReQty", DbType.Single, objinfo.PC_ReQty)
                db.AddInParameter(dbComm, "@PC_Type", DbType.String, objinfo.PC_Type)
                db.AddInParameter(dbComm, "@DepID", DbType.String, objinfo.DepID)
                db.AddInParameter(dbComm, "@PC_Date", DbType.Date, objinfo.PC_Date)
                db.AddInParameter(dbComm, "@PC_Action", DbType.String, objinfo.PC_Action)
                db.AddInParameter(dbComm, "@PC_Remark", DbType.String, objinfo.PC_Remark)
                db.AddInParameter(dbComm, "@CardID", DbType.String, objinfo.CardID)

                db.ExecuteNonQuery(dbComm)
                ProductionFieldChange_Update = True

            Catch ex As Exception

                MsgBox(ex.Message)
                ProductionFieldChange_Update = False

            End Try
        End Function

        Public Function ProductionFieldChange_Delete(ByVal IndexNO As String, ByVal PC_NO As String) As Boolean
            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldChange_Delete")

                db.AddInParameter(dbComm, "@IndexNO", DbType.String, IndexNO)
                db.AddInParameter(dbComm, "@PC_NO", DbType.String, PC_NO)

                db.ExecuteNonQuery(dbComm)
                ProductionFieldChange_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionFieldChange_Delete = False
            End Try
        End Function

        Public Function ProductionFieldChange_UpdateCheck(ByVal objinfo As ProductionFieldChangeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldChange_UpdateCheck")

                db.AddInParameter(dbComm, "@IndexNO", DbType.String, objinfo.IndexNO)
                'db.AddInParameter(dbComm, "@PC_NO", DbType.String, objinfo.PC_NO)
                db.AddInParameter(dbComm, "@PC_Check", DbType.Boolean, objinfo.PC_Check)
                db.AddInParameter(dbComm, "@PC_CheckAction", DbType.String, objinfo.PC_CheckAction)
                db.AddInParameter(dbComm, "@PC_CheckDate", DbType.Date, objinfo.PC_CheckDate)
                db.AddInParameter(dbComm, "@PC_CheckRemark", DbType.String, objinfo.PC_CheckRemark)

                db.ExecuteNonQuery(dbComm)
                ProductionFieldChange_UpdateCheck = True

            Catch ex As Exception

                MsgBox(ex.Message)
                ProductionFieldChange_UpdateCheck = False
            End Try
        End Function

        Public Function ProductionFieldChange_GetList(ByVal PC_NO As String, ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal Pro_NO As String, ByVal DepID As String, ByVal PC_Action As String, ByVal PC_Date1 As String, ByVal PC_Date2 As String, ByVal PC_Check As String) As List(Of ProductionFieldChangeInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldChange_GetList")

            db.AddInParameter(dbComm, "@PC_NO", DbType.String, PC_NO)
            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Pro_NO)
            db.AddInParameter(dbComm, "@DepID", DbType.String, DepID)
            db.AddInParameter(dbComm, "@PC_Action", DbType.String, PC_Action)
            db.AddInParameter(dbComm, "@PC_Date1", DbType.String, PC_Date1)
            db.AddInParameter(dbComm, "@PC_Date2", DbType.String, PC_Date2)

            If PC_Check = Nothing Then
                db.AddInParameter(dbComm, "@PC_Check", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@PC_Check", DbType.String, PC_Check)
            End If

            Dim FeatureList As New List(Of ProductionFieldChangeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionFieldChange(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FillProductionFieldChange(ByVal reader As IDataReader) As ProductionFieldChangeInfo

            On Error Resume Next

            Dim pi As New ProductionFieldChangeInfo




            If reader("PM_JiYu") Is DBNull.Value Then
                pi.PM_JiYu = Nothing
            Else
                pi.PM_JiYu = reader("PM_JiYu")
            End If

            pi.IndexNO = reader("IndexNO").ToString
            pi.PC_NO = reader("PC_NO").ToString
            pi.Pro_Type = reader("Pro_Type").ToString
            pi.PM_M_Code = reader("PM_M_Code").ToString
            pi.PM_Type = reader("PM_Type").ToString
            pi.Pro_NO = reader("Pro_NO").ToString
            pi.DepID = reader("DepID").ToString
            pi.PC_Type = reader("PC_Type").ToString

            If reader("PC_Qty") Is DBNull.Value Then
                pi.PC_Qty = 0
            Else
                pi.PC_Qty = CSng(reader("PC_Qty"))
            End If
            If reader("PC_ReQty") Is DBNull.Value Then
                pi.PC_ReQty = 0
            Else
                pi.PC_ReQty = CSng(reader("PC_ReQty"))
            End If
            If reader("PC_Date") Is DBNull.Value Then
                pi.PC_Date = Nothing
            Else
                pi.PC_Date = CStr(reader("PC_Date"))
            End If

            pi.PC_Action = reader("PC_Action").ToString
            pi.PC_Remark = reader("PC_Remark").ToString

            If reader("PC_Check") Is DBNull.Value Then
                pi.PC_Check = Nothing
            Else
                pi.PC_Check = CStr(reader("PC_Check"))
            End If

            pi.PC_CheckAction = reader("PC_CheckAction").ToString

            If reader("PC_CheckDate") Is DBNull.Value Then
                pi.PC_CheckDate = Nothing
            Else
                pi.PC_CheckDate = CStr(reader("PC_CheckDate"))
            End If

            pi.PC_CheckRemark = reader("PC_CheckRemark").ToString
            pi.CardID = reader("CardID").ToString

            '-------------------------------------------------------------
            pi.PS_Name = reader("PS_Name").ToString
            pi.DepName = reader("DepName").ToString
            pi.FacName = reader("FacName").ToString
            pi.ActionName = reader("ActionName").ToString
            pi.CheckActionName = reader("CheckActionName").ToString

            If reader("WI_Qty") Is DBNull.Value Then
                pi.WI_Qty = 0
            Else
                pi.WI_Qty = CSng(reader("WI_Qty"))
            End If
            pi.FP_NO = reader("FP_NO").ToString

            Return pi

        End Function

    End Class

End Namespace


