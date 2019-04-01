

Namespace LFERP.DataSetting

    Public Class MeGaShareControl

        Public Function CompanyUnion_GetList(ByVal Company_ID As String, ByVal Company_Name As String, ByVal Company_NO As String) As List(Of MeGaShareInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("CompanyUnion_GetList")

            db.AddInParameter(dbComm, "@Company_ID", DbType.String, Company_ID)
            db.AddInParameter(dbComm, "@Company_Name", DbType.String, Company_Name)
            db.AddInParameter(dbComm, "@Company_NO", DbType.String, Company_NO)

            Dim FeatureList As New List(Of MeGaShareInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMeGaShare(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function DepartmentMeGa_GetList(ByVal Department_ID As String, ByVal Company_ID As String, ByVal Department_Name As String) As List(Of MeGaShareInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("DepartmentMeGa_GetList")

            db.AddInParameter(dbComm, "@Department_ID", DbType.String, Department_ID)
            db.AddInParameter(dbComm, "@Company_ID", DbType.String, Company_ID)
            db.AddInParameter(dbComm, "@Department_Name", DbType.String, Department_Name)

            Dim FeatureList As New List(Of MeGaShareInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMeGaShare(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FillMeGaShare(ByVal reader As IDataReader) As MeGaShareInfo
            On Error Resume Next

            Dim mi As New MeGaShareInfo

            mi.Company_ID = reader("Company_ID").ToString
            mi.Company_Name = reader("Company_Name").ToString
            mi.Company_NO = reader("Company_NO").ToString
            mi.Department_ID = reader("Department_ID").ToString
            mi.Department_Name = reader("Department_Name").ToString

            Return mi

        End Function

    End Class

End Namespace


