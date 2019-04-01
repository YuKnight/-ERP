Namespace LFERP.Library.ProductionCombination

    Public Class ProductionCombinationControl

        Public Function ProductionCombination_GetNO(ByVal NDate As String) As ProductionCombinationInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionCombination_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionCombination(reader)
                End While
                Return Nothing
            End Using

        End Function

        Public Function ProductionCombination_Add(ByVal objinfo As ProductionCombinationInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionCombination_Add")


                db.AddInParameter(dbComm, "@M_ID", DbType.String, objinfo.M_ID)
                db.AddInParameter(dbComm, "@M_Type", DbType.String, objinfo.M_Type)
                db.AddInParameter(dbComm, "@M_Dep", DbType.String, objinfo.M_Dep)
                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, objinfo.Pro_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)

                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@M_InQty", DbType.Single, objinfo.M_InQty)
                db.AddInParameter(dbComm, "@Pro_Type1", DbType.String, objinfo.Pro_Type1)
                db.AddInParameter(dbComm, "@PM_M_Code1", DbType.String, objinfo.PM_M_Code1)

                db.AddInParameter(dbComm, "@PM_Type1", DbType.String, objinfo.PM_Type1)
                db.AddInParameter(dbComm, "@Pro_NO1", DbType.String, objinfo.Pro_NO1)
                db.AddInParameter(dbComm, "@M_OutQty", DbType.Single, objinfo.M_OutQty)
                db.AddInParameter(dbComm, "@M_Date", DbType.Date, objinfo.M_Date)
                db.AddInParameter(dbComm, "@M_Action", DbType.String, objinfo.M_Action)

                db.AddInParameter(dbComm, "@M_Remark", DbType.String, objinfo.M_Remark)
                db.AddInParameter(dbComm, "@CardID", DbType.String, objinfo.CardID)

                db.ExecuteNonQuery(dbComm)
                ProductionCombination_Add = True

            Catch ex As Exception

                MsgBox(ex.Message)
                ProductionCombination_Add = False

            End Try
        End Function

        Public Function ProductionCombination_Update(ByVal objinfo As ProductionCombinationInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionCombination_Update")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@M_ID", DbType.String, objinfo.M_ID)
                db.AddInParameter(dbComm, "@M_Type", DbType.String, objinfo.M_Type)
                db.AddInParameter(dbComm, "@M_Dep", DbType.String, objinfo.M_Dep)
                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, objinfo.Pro_Type)

                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@M_InQty", DbType.Single, objinfo.M_InQty)
                db.AddInParameter(dbComm, "@Pro_Type1", DbType.String, objinfo.Pro_Type1)

                db.AddInParameter(dbComm, "@PM_M_Code1", DbType.String, objinfo.PM_M_Code1)
                db.AddInParameter(dbComm, "@PM_Type1", DbType.String, objinfo.PM_Type1)
                db.AddInParameter(dbComm, "@Pro_NO1", DbType.String, objinfo.Pro_NO1)
                db.AddInParameter(dbComm, "@M_OutQty", DbType.Single, objinfo.M_OutQty)
                db.AddInParameter(dbComm, "@M_Action", DbType.String, objinfo.M_Action)

                db.AddInParameter(dbComm, "@M_Remark", DbType.Single, objinfo.M_Remark)

                db.ExecuteNonQuery(dbComm)
                ProductionCombination_Update = True

            Catch ex As Exception

                MsgBox(ex.Message)
                ProductionCombination_Update = False

            End Try
        End Function

        Public Function ProductionCombination_Delete(ByVal AutoID As String, ByVal M_ID As String) As Boolean
            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionCombination_Delete")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbComm, "@M_ID", DbType.String, M_ID)

                db.ExecuteNonQuery(dbComm)
                ProductionCombination_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionCombination_Delete = False
            End Try
        End Function

        Public Function ProductionCombination_GetList(ByVal M_ID As String, ByVal M_Type As String, ByVal M_Dep As String, ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal Pro_NO As String, ByVal M_BeginDate As String, ByVal M_EndDate As String, ByVal M_Action As String) As List(Of ProductionCombinationInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionCombination_GetList")

            db.AddInParameter(dbComm, "@M_ID", DbType.String, M_ID)
            db.AddInParameter(dbComm, "@M_Type", DbType.String, M_Type)
            db.AddInParameter(dbComm, "@M_Dep", DbType.String, M_Dep)
            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)

            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Pro_NO)
            db.AddInParameter(dbComm, "@M_BeginDate", DbType.String, M_BeginDate)
            db.AddInParameter(dbComm, "@M_EndDate", DbType.String, M_EndDate)
            db.AddInParameter(dbComm, "@M_Action", DbType.String, M_Action)

            Dim FeatureList As New List(Of ProductionCombinationInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionCombination(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FillProductionCombination(ByVal reader As IDataReader) As ProductionCombinationInfo
            On Error Resume Next

            Dim bi As New ProductionCombinationInfo


            'If reader("PM_JiYu") Is DBNull.Value Then
            '    bi.PM_JiYu = Nothing
            'Else
            '    bi.PM_JiYu = reader("PM_JiYu")
            'End If

            'If reader("PM_JiYu1") Is DBNull.Value Then
            '    bi.PM_JiYu1 = Nothing
            'Else
            '    bi.PM_JiYu1 = reader("PM_JiYu1")
            'End If

            bi.AutoID = reader("AutoID").ToString
            bi.M_ID = reader("M_ID").ToString
            bi.M_Type = reader("M_Type").ToString
            bi.Pro_Type = reader("Pro_Type").ToString
            bi.PM_M_Code = reader("PM_M_Code").ToString
            bi.M_Dep = reader("M_Dep").ToString

            bi.PM_Type = reader("PM_Type").ToString
            bi.Pro_NO = reader("Pro_NO").ToString
            If reader("M_InQty") Is DBNull.Value Then
                bi.M_InQty = 0
            Else
                bi.M_InQty = CSng(reader("M_InQty"))
            End If
            bi.Pro_Type1 = reader("Pro_Type1").ToString
            bi.PM_M_Code1 = reader("PM_M_Code1").ToString

            bi.PM_Type1 = reader("PM_Type1").ToString
            bi.Pro_NO1 = reader("Pro_NO1").ToString
            If reader("M_OutQty") Is DBNull.Value Then
                bi.M_OutQty = 0
            Else
                bi.M_OutQty = CSng(reader("M_OutQty"))
            End If
            If reader("M_Date") Is DBNull.Value Then
                bi.M_Date = Nothing
            Else
                bi.M_Date = CStr(reader("M_Date"))
            End If
            bi.M_Action = reader("M_Action").ToString

            bi.M_Remark = reader("M_Remark").ToString
            bi.CardID = reader("CardID").ToString

            bi.ActionName = reader("ActionName").ToString
            bi.PS_Name = reader("PS_Name").ToString
            bi.PS_Name1 = reader("PS_Name1").ToString
            bi.M_DepName = reader("M_DepName").ToString
            bi.M_AllDepName = reader("M_UpDepName").ToString & "-" & reader("M_DepName").ToString
            Return bi

        End Function
    End Class

End Namespace
