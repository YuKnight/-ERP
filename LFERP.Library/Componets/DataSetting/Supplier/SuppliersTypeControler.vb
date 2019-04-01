Namespace LFERP.DataSetting
    Public Class SuppliersTypeControler

        Public Function SuppliersType_GetList(ByVal S_TypeID As String, ByVal S_TypeName As String, ByVal S_TypePID As String) As List(Of SuppliersTypeInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SuppliersType_GetList")
            db.AddInParameter(dbComm, "@S_TypeID", DbType.String, S_TypeID)
            db.AddInParameter(dbComm, "@S_TypeName", DbType.String, S_TypeName)
            db.AddInParameter(dbComm, "@S_TypePID", DbType.String, S_TypePID)

            Dim FeatureList As New List(Of SuppliersTypeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSuppliersType(reader))
                End While
                Return FeatureList
            End Using

        End Function



        Public Function SuppliersType_Get(ByVal S_TypeID As String) As SuppliersTypeInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SuppliersType_Get")
            db.AddInParameter(dbComm, "@S_TypeID", DbType.String, S_TypeID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillSuppliersType(reader)
                End While
                Return Nothing
            End Using
        End Function






        Friend Function FillSuppliersType(ByVal reader As IDataReader) As SuppliersTypeInfo
            '對應取得的數據
            On Error Resume Next
            Dim objInfo As New SuppliersTypeInfo
            objInfo.S_TypeID = reader("S_TypeID").ToString
            objInfo.S_TypeName = reader("S_TypeName").ToString
            objInfo.S_TypePID = reader("S_TypePID").ToString
            objInfo.S_TypeRemark = reader("S_TypeRemark").ToString

            Return objInfo
        End Function
    End Class
End Namespace