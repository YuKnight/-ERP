Namespace LFERP.Library.ProductionField
    Public Class ProductionFieldBadnessCauseControl
        Public Function ProductionFieldBadnessCause_Add(ByVal objinfo As ProductionFieldBadnessCauseInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldBadnessCause_Add")

                db.AddInParameter(dbComm, "@PB_ID", DbType.String, objinfo.PB_ID)
                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@PB_Cause", DbType.String, objinfo.PB_Cause)
                db.AddInParameter(dbComm, "@PB_Explain", DbType.String, objinfo.PB_Explain)
                db.AddInParameter(dbComm, "@PB_AddUserID", DbType.String, objinfo.PB_AddUserID)

                db.AddInParameter(dbComm, "@PB_AddDate", DbType.Date, objinfo.PB_AddDate)

                db.ExecuteNonQuery(dbComm)
                ProductionFieldBadnessCause_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionFieldBadnessCause_Add = False
            End Try
        End Function

        Public Function ProductionFieldBadnessCause_Update(ByVal objinfo As ProductionFieldBadnessCauseInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldBadnessCause_Update")

                db.AddInParameter(dbComm, "@PB_ID", DbType.String, objinfo.PB_ID)
                db.AddInParameter(dbComm, "@PB_Cause", DbType.String, objinfo.PB_Cause)
                db.AddInParameter(dbComm, "@PB_Explain", DbType.String, objinfo.PB_Explain)

                db.ExecuteNonQuery(dbComm)
                ProductionFieldBadnessCause_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionFieldBadnessCause_Update = False
            End Try
        End Function

        Public Function ProductionFieldBadnessCause_Delete(ByVal PB_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldBadnessCause_Delete")

                db.AddInParameter(dbComm, "@PB_ID", DbType.String, PB_ID)

                db.ExecuteNonQuery(dbComm)
                ProductionFieldBadnessCause_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionFieldBadnessCause_Delete = False
            End Try
        End Function

        Public Function ProductionFieldBadnessCause_GetList(ByVal PB_ID As String, ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal Pro_NO As String, ByVal PB_Cause As String) As List(Of ProductionFieldBadnessCauseInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldBadnessCause_GetList")
            db.AddInParameter(dbComm, "@PB_ID", DbType.String, PB_ID)
            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Pro_NO)
            db.AddInParameter(dbComm, "@PB_Cause", DbType.String, PB_Cause)

          
            Dim FeatureList As New List(Of ProductionFieldBadnessCauseInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionFieldBadnessCause(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function ProductionFieldBadnessCause_GetList1(ByVal PB_ID As String, ByVal Pro_NO As String, ByVal PB_Cause As String) As List(Of ProductionFieldBadnessCauseInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldBadnessCause_GetList1")
            db.AddInParameter(dbComm, "@PB_ID", DbType.String, PB_ID)
            db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Pro_NO)
            db.AddInParameter(dbComm, "@PB_Cause", DbType.String, PB_Cause)

            Dim FeatureList As New List(Of ProductionFieldBadnessCauseInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionFieldBadnessCause(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FillProductionFieldBadnessCause(ByVal reader As IDataReader) As ProductionFieldBadnessCauseInfo
            On Error Resume Next
            Dim pbi As New ProductionFieldBadnessCauseInfo

            pbi.PB_ID = reader("PB_ID").ToString
            pbi.Pro_Type = reader("Pro_Type").ToString
            pbi.PM_M_Code = reader("PM_M_Code").ToString
            pbi.PM_Type = reader("PM_Type").ToString
            pbi.Pro_NO = reader("Pro_NO").ToString

            pbi.PS_Name = reader("PS_Name").ToString
            pbi.PB_Cause = reader("PB_Cause").ToString
            pbi.PB_Explain = reader("PB_Explain").ToString
            pbi.PB_AddUserID = reader("PB_AddUserID").ToString
            pbi.PB_AddDate = reader("PB_AddDate").ToString

            Return pbi
        End Function
    End Class
End Namespace

