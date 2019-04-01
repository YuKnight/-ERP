

Namespace LFERP.DataSetting

    Public Class EndorsementControl

        Public Function Endorsement_Update(ByVal objinfo As EndorsementInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Endorsement_Update")

                db.AddInParameter(dbComm, "@AM_ID", DbType.String, objinfo.AM_ID)
                db.AddInParameter(dbComm, "@AM_Type", DbType.String, objinfo.AM_Type)
                db.AddInParameter(dbComm, "@AM_Check", DbType.Boolean, objinfo.AM_Check)
                db.AddInParameter(dbComm, "@AM_Time", DbType.Date, objinfo.AM_Time)

                db.ExecuteNonQuery(dbComm)
                Endorsement_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                Endorsement_Update = False
            End Try
        
        End Function
        Public Function Endorsement_GetList(ByVal AM_ID As String, ByVal AM_Type As String, ByVal AM_Check As String) As List(Of EndorsementInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Endorsement_GetList")

            db.AddInParameter(dbComm, "@AM_ID", DbType.String, AM_ID)
            db.AddInParameter(dbComm, "@AM_Type", DbType.String, AM_Type)
            db.AddInParameter(dbComm, "@AM_Check", DbType.String, AM_Check)

            Dim FeatureList As New List(Of EndorsementInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillEndorsement(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function FillEndorsement(ByVal reader As IDataReader) As EndorsementInfo

            On Error Resume Next

            Dim fei As New EndorsementInfo

            fei.AM_ID = reader("AM_ID").ToString
            fei.AM_Type = reader("AM_Type").ToString

            If reader("AM_Check") Is DBNull.Value Then
                fei.AM_Check = Nothing
            Else
                fei.AM_Check = reader("AM_Check")
            End If

            If reader("AM_Time") Is DBNull.Value Then
                fei.AM_Time = Nothing
            Else
                fei.AM_Time = reader("AM_Time")
            End If

            Return fei

        End Function

    End Class

End Namespace


