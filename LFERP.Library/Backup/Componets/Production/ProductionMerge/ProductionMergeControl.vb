

Namespace LFERP.Library.ProductionMerge

    Public Class ProductionMergeControl

        Public Function ProductionMerge_GetNO(ByVal Ndate As String) As ProductionMergeInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionMerge_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionMerge(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function ProductionMerge_Add(ByVal pmi As ProductionMergeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionMerge_Add")

                db.AddInParameter(dbComm, "@PM_NO", DbType.String, pmi.PM_NO)
                db.AddInParameter(dbComm, "@Pro_MNO", DbType.String, pmi.Pro_MNO)
                db.AddInParameter(dbComm, "@Pro_MQty", DbType.Single, pmi.Pro_MQty)
                db.AddInParameter(dbComm, "@Pro_SNO", DbType.String, pmi.Pro_SNO)
                db.AddInParameter(dbComm, "@Pro_SQty", DbType.Single, pmi.Pro_SQty)
                db.AddInParameter(dbComm, "@PM_Action", DbType.String, pmi.PM_Action)
                db.AddInParameter(dbComm, "@PM_Check", DbType.Boolean, pmi.PM_Check)
                db.AddInParameter(dbComm, "@PM_AddDate", DbType.Date, pmi.PM_AddDate)
                db.AddInParameter(dbComm, "@FP_NO", DbType.String, pmi.FP_NO)

                db.ExecuteNonQuery(dbComm)
                ProductionMerge_Add = True
            Catch ex As Exception

                MsgBox(ex.Message)
                ProductionMerge_Add = False
            End Try
        End Function

        Public Function ProductionMerge_Update(ByVal pmi As ProductionMergeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionMerge_Update")

                db.AddInParameter(dbComm, "@PM_NO", DbType.String, pmi.PM_NO)
                db.AddInParameter(dbComm, "@Pro_MNO", DbType.String, pmi.Pro_MNO)
                db.AddInParameter(dbComm, "@Pro_MQty", DbType.Single, pmi.Pro_MQty)
                db.AddInParameter(dbComm, "@Pro_SNO", DbType.String, pmi.Pro_SNO)
                db.AddInParameter(dbComm, "@Pro_SQty", DbType.Single, pmi.Pro_SQty)
                db.AddInParameter(dbComm, "@PM_Action", DbType.String, pmi.PM_Action)
                db.AddInParameter(dbComm, "@PM_Check", DbType.Boolean, pmi.PM_Check)
                db.AddInParameter(dbComm, "@PM_AddDate", DbType.Date, pmi.PM_AddDate)
                db.AddInParameter(dbComm, "@FP_NO", DbType.String, pmi.FP_NO)

                db.ExecuteNonQuery(dbComm)
                ProductionMerge_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionMerge_Update = False
            End Try
        End Function

        Public Function ProductionMerge_Delete(ByVal PM_NO As String, ByVal FP_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionMerge_Delete")

                db.AddInParameter(dbComm, "@PM_NO", DbType.String, PM_NO)
                db.AddInParameter(dbComm, "@FP_NO", DbType.String, FP_NO)

                db.ExecuteNonQuery(dbComm)
                ProductionMerge_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionMerge_Delete = False
            End Try
        End Function

        Public Function ProductionMerge_GetList(ByVal PM_NO As String, ByVal Pro_MNO As String, ByVal Pro_SNO As String, ByVal PM_Action As String, ByVal MName As String, ByVal SName As String, ByVal FP_NO As String) As List(Of ProductionMergeInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionMerge_GetList")

            db.AddInParameter(dbComm, "@PM_NO", DbType.String, PM_NO)
            db.AddInParameter(dbComm, "@Pro_MNO", DbType.String, Pro_MNO)
            db.AddInParameter(dbComm, "@Pro_SNO", DbType.String, Pro_SNO)
            db.AddInParameter(dbComm, "@PM_Action", DbType.String, PM_Action)
            db.AddInParameter(dbComm, "@MName", DbType.String, MName)
            db.AddInParameter(dbComm, "@SName", DbType.String, SName)
            db.AddInParameter(dbComm, "@FP_NO", DbType.String, FP_NO)

            Dim FeatureList As New List(Of ProductionMergeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionMerge(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function FillProductionMerge(ByVal reader As IDataReader) As ProductionMergeInfo

            On Error Resume Next

            Dim pmi As New ProductionMergeInfo

            pmi.PM_NO = reader("PM_NO").ToString

            pmi.Pro_MNO = reader("Pro_MNO").ToString

            pmi.Pro_MQty = CSng(reader("Pro_MQty").ToString)
            pmi.Pro_SNO = reader("Pro_SNO").ToString
            pmi.Pro_SQty = CSng(reader("Pro_SQty").ToString)
            pmi.PM_Action = reader("PM_Action").ToString

            If reader("PM_AddDate") Is DBNull.Value Then
                pmi.PM_AddDate = Nothing
            Else
                pmi.PM_AddDate = CStr(reader("PM_AddDate"))
            End If
            If reader("PM_Check") Is DBNull.Value Then
                pmi.PM_Check = Nothing
            Else
                pmi.PM_Check = CStr(reader("PM_Check"))
            End If

            pmi.FP_NO = reader("FP_NO").ToString

            '---------------------------------------------------------
            pmi.Pro_Type = reader("Pro_Type").ToString
            pmi.PM_M_Code = reader("PM_M_Code").ToString
            pmi.PM_Type = reader("PM_Type").ToString
            pmi.MName = reader("MName").ToString
            pmi.SName = reader("SName").ToString
            pmi.ActionName = reader("ActionName").ToString

            Return pmi

        End Function


    End Class

End Namespace

