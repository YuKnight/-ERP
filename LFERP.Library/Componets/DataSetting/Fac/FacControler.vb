Namespace LFERP.DataSetting
    Public Class FacControler
        Public Function GetFacList(ByVal FacID As String, ByVal FacName As String) As List(Of FacInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("FacName_GetList")

            db.AddInParameter(dbComm, "@FacID", DbType.String, FacID)
            db.AddInParameter(dbComm, "@FacName", DbType.String, FacName)

            Dim FeatureList As New List(Of FacInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillFac(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function GetFacListA(ByVal FacID As String, ByVal FacName As String, ByVal FacRemark As String) As List(Of FacInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("FacName_GetListA")

            db.AddInParameter(dbComm, "@FacID", DbType.String, FacID)
            db.AddInParameter(dbComm, "@FacName", DbType.String, FacName)
            db.AddInParameter(dbComm, "@FacRemark", DbType.String, FacRemark)

            Dim FeatureList As New List(Of FacInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillFac(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function GetFacListB(ByVal FacID As String, ByVal FacName As String) As List(Of FacInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("FacName_GetListB")

            db.AddInParameter(dbComm, "@FacID", DbType.String, FacID)
            db.AddInParameter(dbComm, "@FacName", DbType.String, FacName)

            Dim FeatureList As New List(Of FacInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillFac(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Friend Function FillFac(ByVal reader As IDataReader) As FacInfo
            '對應取得的數據
            On Error Resume Next
            Dim objInfo As New FacInfo
            objInfo.FacID = reader("FacID").ToString
            objInfo.FacName = reader("FacName").ToString
            objInfo.FacRemark = reader("FacRemark").ToString

            Return objInfo
        End Function
    End Class

End Namespace