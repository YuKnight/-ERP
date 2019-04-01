Namespace LFERP.Library.NmetalSampleManager.NmetalSamplePaceTypeBriName

    Public Class NmetalSamplePaceTypeBriNameControl
        Public Function NmetalSamplePaceTypeBriName_Add(ByVal objinfo As NmetalSamplePaceTypeBriNameInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSamplePaceTypeBriName_Add")

                db.AddInParameter(dbComm, "@DepID", DbType.String, objinfo.DepID)
                db.AddInParameter(dbComm, "@SE_Type", DbType.String, objinfo.SE_Type)

                db.ExecuteNonQuery(dbComm)
                NmetalSamplePaceTypeBriName_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSamplePaceTypeBriName_Add = False
            End Try
        End Function

        Public Function NmetalSamplePaceTypeBriName_delete(ByVal DepID As String, ByVal SE_Type As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSamplePaceTypeBriName_delete")

                db.AddInParameter(dbComm, "@DepID", DbType.String, DepID)
                db.AddInParameter(dbComm, "@SE_Type", DbType.String, SE_Type)

                db.ExecuteNonQuery(dbComm)
                NmetalSamplePaceTypeBriName_delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSamplePaceTypeBriName_delete = False
            End Try
        End Function


        Public Function NmetalSamplePaceTypeBriName_GetList(ByVal DepID As String, ByVal SE_Type As String) As List(Of NmetalSamplePaceTypeBriNameInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSamplePaceTypeBriName_GetList")
            db.AddInParameter(dbComm, "@DepID", DbType.String, DepID)
            db.AddInParameter(dbComm, "@SE_Type", DbType.String, SE_Type)

            Dim FeatureList As New List(Of NmetalSamplePaceTypeBriNameInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillNmetalSamplePaceTypeBriName(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Friend Function FillNmetalSamplePaceTypeBriName(ByVal reader As IDataReader) As NmetalSamplePaceTypeBriNameInfo
            On Error Resume Next

            Dim objInfo As New NmetalSamplePaceTypeBriNameInfo

            objInfo.DepID = reader("DepID").ToString
            objInfo.SE_Type = reader("SE_Type").ToString
            objInfo.DepName = reader("DepName").ToString
            objInfo.SE_TypeName = reader("SE_TypeName").ToString


            '2014-07-19  Mark
            objInfo.PE_User = reader("PE_User").ToString
            objInfo.PE_Name = reader("PE_Name").ToString
            objInfo.PE_PSW = reader("PE_PSW").ToString

            objInfo.AutoID = reader("AutoID")
            Return objInfo
        End Function

        ''' <summary>
        ''' Mark 
        ''' 2014-07-19
        ''' </summary>
        ''' <param name="PE_User"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function NmetalSampleExceptionUser_GetList(ByVal PE_User As String) As List(Of NmetalSamplePaceTypeBriNameInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleExceptionUser_GetList")
            db.AddInParameter(dbComm, "@PE_User", DbType.String, PE_User)

            Dim FeatureList As New List(Of NmetalSamplePaceTypeBriNameInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillNmetalSamplePaceTypeBriName(reader))
                End While
                Return FeatureList
            End Using
        End Function

        ''' <summary>
        ''' Mark
        ''' 2014-07-21
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function NmetalSampleExceptionUser_Add(ByVal objinfo As NmetalSamplePaceTypeBriNameInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleExceptionUser_Add")

                db.AddInParameter(dbComm, "@PE_User", DbType.String, objinfo.PE_User)
                db.AddInParameter(dbComm, "@PE_Name", DbType.String, objinfo.PE_Name)
                db.AddInParameter(dbComm, "@PE_PSW", DbType.String, objinfo.PE_PSW)

                db.ExecuteNonQuery(dbComm)
                NmetalSampleExceptionUser_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSampleExceptionUser_Add = False
            End Try
        End Function

        ''' <summary>
        ''' Mark
        ''' 2014-07-21
        ''' </summary>
        ''' <param name="AutoID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function NmetalSampleExceptionUser_Delete(ByVal AutoID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleExceptionUser_Delete")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)

                db.ExecuteNonQuery(dbComm)

                NmetalSampleExceptionUser_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSampleExceptionUser_Delete = False
            End Try
        End Function
        ''' <summary>
        ''' Mark
        ''' 2014-07-21
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function NmetalSampleExceptionUser_Update(ByVal objinfo As NmetalSamplePaceTypeBriNameInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleExceptionUser_Update")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@PE_User", DbType.String, objinfo.PE_User)
                db.AddInParameter(dbComm, "@PE_Name", DbType.String, objinfo.PE_Name)

                db.ExecuteNonQuery(dbComm)
                NmetalSampleExceptionUser_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSampleExceptionUser_Update = False
            End Try
        End Function

    End Class
End Namespace