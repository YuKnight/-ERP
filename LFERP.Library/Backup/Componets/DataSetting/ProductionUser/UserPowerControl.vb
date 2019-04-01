

Namespace LFERP.DataSetting

    Public Class UserPowerControl

        Function UserPower_GetList(ByVal UserID As String, ByVal UserName As String, ByVal UserRank As String, ByVal DepID As String) As List(Of UserPowerInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("UserPower_GetList")

            db.AddInParameter(dbComm, "@UserID", DbType.String, UserID)
            db.AddInParameter(dbComm, "@UserName", DbType.String, UserName)
            db.AddInParameter(dbComm, "@UserRank", DbType.String, UserRank)
            db.AddInParameter(dbComm, "@DepID", DbType.String, DepID)

            Dim FeatureList As New List(Of UserPowerInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillUserPoser(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function FillUserPoser(ByVal reader As IDataReader) As UserPowerInfo
            On Error Resume Next

            Dim ui As New UserPowerInfo

            ui.UserID = reader("UserID").ToString
            ui.UserName = reader("UserName").ToString
            ui.UserRank = reader("UserRank").ToString
            ui.DepID = reader("DepID").ToString
            ui.DepName = reader("DepName").ToString
            ui.UserType = reader("UserType").ToString

            Return ui

        End Function

    End Class

End Namespace


