Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql

Namespace LFERP.Library.CompanyWareHouse
    Public Class CompanyWareHouseController
        Friend Function FillCompanyWareHouse(ByVal reader As IDataReader) As CompanyWareHouseInfo
            Dim objInfo As New CompanyWareHouseInfo
            objInfo.CompanyID = reader("CompanyID").ToString
            objInfo.WH_ID = reader("WH_ID").ToString
            Return objInfo
        End Function



        Public Function CompanyWareHouse_GetList(ByVal AutoID As Decimal, ByVal CompanyID As String) As List(Of CompanyWareHouseInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("CompanyWareHouse_GetList")
            If AutoID <> 0 Then
                db.AddInParameter(dbComm, "@AutoID", DbType.Decimal, AutoID)
            End If
            db.AddInParameter(dbComm, "@CompanyID", DbType.String, CompanyID)
            Dim FeatureList As New List(Of CompanyWareHouseInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillCompanyWareHouse(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function CompanyWareHouse_GetCompany() As DataTable
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetSqlStringCommand(" select distinct companyID,BasicSubName as CompanyName from CompanyWareHouse W inner join AuxiliaryDataSub A on w.CompanyID=A.BasicSubType ")
            Dim ds As New DataSet
            ds = db.ExecuteDataSet(dbComm)
            If ds.Tables.Count > 0 Then
                Return ds.Tables(0)
            Else
                Return Nothing
            End If
        End Function
    End Class
End Namespace


























