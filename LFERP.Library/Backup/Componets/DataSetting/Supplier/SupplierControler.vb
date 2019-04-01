Namespace LFERP.DataSetting
    ''' <summary>
    ''' 供應商資料管理
    ''' </summary>
    ''' <remarks></remarks>
    Public Class SupplierControler
        ''' <summary>
        ''' 取得供應商資料
        ''' </summary>
        ''' <param name="Supplier"></param>
        ''' <param name="SupplierName"></param>
        ''' <param name="S_Type"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetSupplierList(ByVal Supplier As String, ByVal SupplierName As String, ByVal S_Type As String) As List(Of SupplierInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Suppliers_GetList")
            db.AddInParameter(dbComm, "@S_Supplier", DbType.String, Supplier)
            db.AddInParameter(dbComm, "@S_SupplierName", DbType.String, SupplierName)
            db.AddInParameter(dbComm, "@S_Type", DbType.String, S_Type)
            Dim FeatureList As New List(Of SupplierInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSupplierType(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function GetSuppliersList(ByVal Supplier As String, ByVal SupplierName As String, ByVal S_Type As String) As List(Of SupplierInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Suppliers_GetList")
            db.AddInParameter(dbComm, "@S_Supplier", DbType.String, Supplier)
            db.AddInParameter(dbComm, "@S_SupplierName", DbType.String, SupplierName)
            db.AddInParameter(dbComm, "@S_TypeID", DbType.String, S_Type)


            Dim FeatureList As New List(Of SupplierInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSupplierType(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Friend Function FillSupplierType(ByVal reader As IDataReader) As SupplierInfo
            '對應取得的數據
            Dim objInfo As New SupplierInfo
            objInfo.S_Supplier = reader("供應商代號").ToString
            objInfo.S_SupplierName = reader("供應商名稱").ToString
            objInfo.S_Email = reader("郵件地址").ToString
            objInfo.S_Associate = reader("聯系人").ToString
            objInfo.S_Tel = reader("聯系電話").ToString
            objInfo.S_Fax = reader("Fax_no").ToString
            objInfo.S_Type = reader("供應商類型").ToString
            objInfo.S_Address = reader("供應商地址").ToString
            objInfo.S_Currency = reader("幣別").ToString
            objInfo.S_Contace = reader("聯絡方式").ToString
            objInfo.S_Tel1 = reader("聯系電話1").ToString
            objInfo.S_Remark = reader("備注").ToString
            Return objInfo
        End Function

    End Class
End Namespace

