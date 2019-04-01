Namespace LFERP.Library.Shared

    Public Class TempController

        Public Function Temp_GetList(ByVal Str1 As String, ByVal Str2 As String, ByVal Str3 As String) As List(Of TempInfo)


            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Temp_GetList")

            db.AddInParameter(dbComm, "@Str1", DbType.String, Str1)
            db.AddInParameter(dbComm, "@Str2", DbType.String, Str2)
            db.AddInParameter(dbComm, "@Str3", DbType.String, Str3)

            Dim FeatureList As New List(Of TempInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(Filltemp(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function Temp2_GetList(ByVal Str1 As String, ByVal Str2 As String, ByVal Str3 As String) As List(Of TempInfo)


            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Temp2_GetList")

            db.AddInParameter(dbComm, "@Str1", DbType.String, Str1)
            db.AddInParameter(dbComm, "@Str2", DbType.String, Str2)
            db.AddInParameter(dbComm, "@Str3", DbType.String, Str3)

            Dim FeatureList As New List(Of TempInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(Filltemp(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function Filltemp(ByVal reader As IDataReader) As TempInfo

            Dim ti As New TempInfo

            ti.Str1 = reader("Str1").ToString
            ti.Str2 = reader("Str2").ToString
            ti.Str3 = reader("Str3").ToString

            Return ti

        End Function

        Public Function Temp2_Add(ByVal objFile1 As TempInfo) As Boolean


            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Temp2_Add")
       


                If objFile1.Str1 = Nothing Then
                    db.AddInParameter(dbComm, "@Str1", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@Str1", DbType.String, objFile1.Str1)
                End If

              
                If objFile1.Str2 = Nothing Then
                    db.AddInParameter(dbComm, "@Str2", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@Str2", DbType.String, objFile1.Str2)
                End If

                If objFile1.Str3 = Nothing Then
                    db.AddInParameter(dbComm, "@Str3", DbType.String, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@Str3", DbType.String, objFile1.Str3)
                End If


  

                db.ExecuteNonQuery(dbComm)
                Temp2_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Temp2_Add = False

            End Try
        End Function

    End Class

End Namespace


