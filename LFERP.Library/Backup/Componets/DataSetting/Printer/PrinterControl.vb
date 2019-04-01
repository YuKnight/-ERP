Namespace LFERP.DataSetting

    Public Class PrinterControl

        Public Function Printer_GetList(ByVal P_IP As String) As List(Of PrinterInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Printer_GetList")
            db.AddInParameter(dbComm, "@P_IP", DbType.String, P_IP)
            Dim FeatureList As New List(Of PrinterInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPrinter(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FillPrinter(ByVal reader As IDataReader) As PrinterInfo
            Dim pi As New PrinterInfo

            pi.P_IP = reader("P_IP").ToString
            pi.P_Name = reader("P_Name").ToString
            pi.P_Remark = reader("P_Remark").ToString

            Return pi
        End Function
    End Class

End Namespace

