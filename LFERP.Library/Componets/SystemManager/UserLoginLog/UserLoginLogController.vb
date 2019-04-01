Namespace LFERP.SystemManager.UserLoginLog
    Public Class UserLoginLogController
        Public Function UserLoginLog_Add(ByVal objinfo As UserLoginLogInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("UserLoginLog_Add")

                db.AddInParameter(dbComm, "U_ID", DbType.String, objinfo.U_ID)
                db.AddInParameter(dbComm, "UL_InTime", DbType.String, objinfo.UL_InTime)
                db.AddInParameter(dbComm, "UL_ExitTime", DbType.String, objinfo.UL_ExitTime)
                db.AddInParameter(dbComm, "UL_Mac", DbType.String, objinfo.UL_Mac)
                db.AddInParameter(dbComm, "UL_IP", DbType.String, objinfo.UL_IP)

                db.ExecuteNonQuery(dbComm)
                UserLoginLog_Add = True

            Catch ex As Exception

                UserLoginLog_Add = False

            End Try

        End Function

        Public Function UserLoginLog_GetList(ByVal U_ID As String, ByVal U_Name As String, ByVal UL_InTimeBegin As String, ByVal UL_InTimeEnd As String, ByVal UL_Mac As String, ByVal UL_IP As String) As List(Of UserLoginLogInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("UserLoginLog_GetList")

            db.AddInParameter(dbComm, "U_ID", DbType.String, U_ID)
            db.AddInParameter(dbComm, "U_Name", DbType.String, U_Name)
            db.AddInParameter(dbComm, "UL_InTimeBegin", DbType.String, UL_InTimeBegin)
            db.AddInParameter(dbComm, "UL_InTimeEnd", DbType.String, UL_InTimeEnd)
            db.AddInParameter(dbComm, "UL_Mac", DbType.String, UL_Mac)
            db.AddInParameter(dbComm, "UL_IP", DbType.String, UL_IP)

            Dim FeatureList As New List(Of UserLoginLogInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillUserLoginLog(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function FillUserLoginLog(ByVal reader As IDataReader) As UserLoginLogInfo
            On Error Resume Next

            Dim objinfo As New UserLoginLogInfo

            objinfo.U_ID = reader("U_ID").ToString
            objinfo.U_Name = reader("U_Name").ToString
            objinfo.UL_InTime = reader("UL_InTime").ToString
            objinfo.UL_ExitTime = reader("UL_ExitTime").ToString
            objinfo.UL_Mac = reader("UL_Mac").ToString
            objinfo.UL_IP = reader("UL_IP").ToString

            Return objinfo
        End Function

    End Class
End Namespace

