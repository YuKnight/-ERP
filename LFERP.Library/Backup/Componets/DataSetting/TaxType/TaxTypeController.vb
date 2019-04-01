Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql

Namespace LFERP.DataSetting
    Public Class TaxTypeController
        Friend Function FillTaxType(ByVal reader As IDataReader) As TaxTypeInfo
            Dim objInfo As New TaxTypeInfo
            objInfo.TaxTypeID = reader("TaxTypeID").ToString
            objInfo.TaxTypeName = reader("TaxTypeName").ToString
            Return objInfo
        End Function



        Public Function TaxType_GetList(ByVal TaxTypeID As String) As List(Of TaxTypeInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("TaxType_GetList")
            db.AddInParameter(dbComm, "@TaxTypeID", DbType.String, TaxTypeID)
            Dim FeatureList As New List(Of TaxTypeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillTaxType(reader))
                End While
                Return FeatureList
            End Using
        End Function

 
    End Class
End Namespace