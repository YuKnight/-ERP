
Namespace LFERP.DataSetting
    Public Class TarriffController
        Public Function TarriffGetList(ByVal Tarriff_Value As String) As List(Of TarriffInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Tarriff_GetList")
            db.AddInParameter(dbComm, "@Tarriff_Value", DbType.Single, Tarriff_Value)
            Dim FeatureList As New List(Of TarriffInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillTarriff(reader))
                End While
                Return FeatureList
            End Using
        End Function


        Friend Function FillTarriff(ByVal reader As IDataReader) As TarriffInfo
            '對應取得的數據
            Dim objInfo As New TarriffInfo
            objInfo.Tarriff_Value = reader("Tarriff_Value").ToString
            objInfo.Tarriff_Name = reader("Tarriff_Name").ToString

            Return objInfo
        End Function
    End Class
End Namespace