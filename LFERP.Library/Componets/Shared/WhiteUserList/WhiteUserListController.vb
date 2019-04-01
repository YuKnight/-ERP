Namespace LFERP.Library.Shared

    Public Class WhiteUserListController

        Public Function WhiteUserList_GetList(ByVal W_UserID As String, ByVal WH_ID As String) As List(Of WhiteuserListInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WhiteUserList_GetList")

            db.AddInParameter(dbComm, "@W_UserID", DbType.String, W_UserID)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            Dim FeatureList As New List(Of WhiteuserListInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWhiteUserList(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function FillWhiteUserList(ByVal reader As IDataReader) As WhiteuserListInfo

            On Error Resume Next
            Dim wli As New WhiteuserListInfo

            wli.W_UserID = reader("W_UserID").ToString
            wli.W_UserName = reader("W_UserName").ToString
            wli.DPT_ID = reader("DPT_ID").ToString
            wli.WH_ID = reader("WH_ID").ToString
            wli.W_Remark = reader("W_Remark").ToString

            wli.DPT_Name = reader("DPT_Name").ToString
            wli.DPT_PID = reader("DPT_PID").ToString

            Return wli

        End Function

        Public Function WhiteUserListSub_GetList(ByVal W_UserID As String, ByVal WH_ID As String) As List(Of WhiteuserListInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WhiteUserListSub_GetList")

            db.AddInParameter(dbComm, "@W_UserID", DbType.String, W_UserID)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            Dim FeatureList As New List(Of WhiteuserListInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWhiteUserListSub(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function FillWhiteUserListSub(ByVal reader As IDataReader) As WhiteuserListInfo

            On Error Resume Next
            Dim wli As New WhiteuserListInfo

            wli.W_UserID = reader("W_UserID").ToString
            wli.W_UserName = reader("W_UserName").ToString
            wli.WH_ID = reader("WH_ID").ToString
            wli.WareIn = reader("WareIn")
            wli.WareOut = reader("WareOut")
            wli.WareChange = reader("WareChange")
            wli.DPT_Name = reader("DPT_Name").ToString
            wli.DPT_ID = reader("DPT_ID").ToString

            Return wli

        End Function


    End Class

End Namespace
