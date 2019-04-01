Namespace LFERP.Library.Outward.OutwardProjectType

    Public Class OutwardProjectTypeControl

        Public Function OutwardProjectType_Add(ByVal objinfo As OutwardProjectTypeInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardProjectType_Add")

                db.AddInParameter(dbComm, "@PT_NO", DbType.String, objinfo.PT_NO)
                db.AddInParameter(dbComm, "@PT_Name", DbType.String, objinfo.PT_Name)
                db.AddInParameter(dbComm, "@PT_Detail", DbType.String, objinfo.PT_Detail)

                db.ExecuteNonQuery(dbComm)
                OutwardProjectType_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OutwardProjectType_Add = False

            End Try
          
        End Function

        Public Function OutwardProjectType_Update(ByVal objinfo As OutwardProjectTypeInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardProjectType_Update")

                db.AddInParameter(dbComm, "@PT_NO", DbType.String, objinfo.PT_NO)
                db.AddInParameter(dbComm, "@PT_Name", DbType.String, objinfo.PT_Name)
                db.AddInParameter(dbComm, "@PT_Detail", DbType.String, objinfo.PT_Detail)

                db.ExecuteNonQuery(dbComm)
                OutwardProjectType_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OutwardProjectType_Update = False

            End Try

        End Function
        Public Function OutwardProjectType_Delete(ByVal AutoID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardProjectType_Delete")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)

                db.ExecuteNonQuery(dbComm)
                OutwardProjectType_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OutwardProjectType_Delete = False
            End Try

        End Function
        Public Function OutwardProjectType_GetNO(ByVal NDate As String) As OutwardProjectTypeInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardProjectType_GetNO")

            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)

            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillOutwardProjectType(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function OutwardProjectType_GetList(ByVal PT_NO As String, ByVal PT_Name As String) As List(Of OutwardProjectTypeInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardProjectType_GetList")

            db.AddInParameter(dbComm, "@PT_NO", DbType.String, PT_NO)
            db.AddInParameter(dbComm, "@PT_Name", DbType.String, PT_Name)

            Dim FeatureList As New List(Of OutwardProjectTypeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOutwardProjectType(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function FillOutwardProjectType(ByVal reader As IDataReader) As OutwardProjectTypeInfo
            On Error Resume Next

            Dim fpt As New OutwardProjectTypeInfo

            fpt.AutoID = reader("AutoID")
            fpt.PT_NO = reader("PT_NO").ToString
            fpt.PT_Name = reader("PT_Name").ToString
            fpt.PT_Detail = reader("PT_Detail").ToString

            Return fpt

        End Function

    End Class

End Namespace

