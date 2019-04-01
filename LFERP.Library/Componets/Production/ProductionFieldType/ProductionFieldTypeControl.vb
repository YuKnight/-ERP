Imports LFERP.Library.ProductionFieldType

Namespace LFERP.Library.ProductionFieldType

    Public Class ProductionFieldTypeControl


        Public Function ProductionFieldType_GetList(ByVal PT_NO As String, ByVal PT_Type As String, ByVal PT_Detail As String) As List(Of ProductionFieldTypeInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldType_GetList")

            db.AddInParameter(dbComm, "@PT_NO", DbType.String, PT_NO)
            db.AddInParameter(dbComm, "@PT_Type", DbType.String, PT_Type)
            db.AddInParameter(dbComm, "@PT_Detail", DbType.String, PT_Detail)

            Dim FeatureList As New List(Of ProductionFieldTypeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionFieldType(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function FillProductionFieldType(ByVal reader As IDataReader) As ProductionFieldTypeInfo

            Dim ffi As New ProductionFieldTypeInfo

            ffi.PT_NO = reader("PT_NO").ToString
            ffi.PT_Type = reader("PT_Type").ToString
            ffi.PT_Detail = reader("PT_Detail").ToString
            ffi.PT_DataValue = CInt(reader("PT_DataValue").ToString)

            Return ffi
        End Function
    End Class
End Namespace


