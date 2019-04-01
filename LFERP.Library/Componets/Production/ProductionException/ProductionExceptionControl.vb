

Namespace LFERP.Library.ProductionException

    Public Class ProductionExceptionControl

        Public Function ProductionException_Add(ByVal objinfo As ProductionExceptionInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionException_Add")

                db.AddInParameter(dbcomm, "@PE_User", DbType.String, objinfo.PE_User)
                db.AddInParameter(dbcomm, "@PE_CardID", DbType.String, objinfo.PE_CardID)
                db.AddInParameter(dbcomm, "@PE_CardName", DbType.String, objinfo.PE_CardName)
                db.AddInParameter(dbcomm, "@PE_Remark", DbType.String, objinfo.PE_Remark)
                db.AddInParameter(dbcomm, "@PE_Date", DbType.Date, objinfo.PE_Date)

                db.ExecuteNonQuery(dbcomm)
                ProductionException_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionException_Add = False
            End Try

        End Function
        Public Function ProductionException_GetList(ByVal PE_User As String, ByVal PE_CardID As String) As List(Of ProductionExceptionInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionException_GetList")

            db.AddInParameter(dbcomm, "@PE_User", DbType.String, PE_User)
            db.AddInParameter(dbcomm, "@PE_CardID", DbType.String, PE_CardID)

            Dim FeatureList As New List(Of ProductionExceptionInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillProductionException(reader))
                End While
                Return FeatureList
            End Using

        End Function
        Public Function ProductionExceptionUser_GetList(ByVal PE_User As String, ByVal PE_PSW As String) As List(Of ProductionExceptionInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionExceptionUser_GetList")

            db.AddInParameter(dbcomm, "@PE_User", DbType.String, PE_User)
            db.AddInParameter(dbcomm, "@PE_PSW", DbType.String, PE_PSW)

            Dim FeatureList As New List(Of ProductionExceptionInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillProductionException(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FillProductionException(ByVal reader As IDataReader) As ProductionExceptionInfo

            On Error Resume Next

            Dim fe As New ProductionExceptionInfo

            fe.PE_CardID = reader("PE_CardID").ToString
            fe.PE_CardName = reader("PE_CardName").ToString


            If reader("PE_Date") Is DBNull.Value Then
                fe.PE_Date = Nothing
            Else
                fe.PE_Date = reader("PE_Date")
            End If

            fe.PE_Remark = reader("PE_Remark").ToString
            fe.PE_User = reader("PE_User").ToString
            fe.PE_Name = reader("PE_Name").ToString
            fe.PE_PSW = reader("PE_PSW").ToString


            Return fe

        End Function
    End Class

End Namespace


