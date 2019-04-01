Namespace LFERP.Library.Positive
    Public Class PositiveDeliverController
#Region "獲取單號"
        ''' <summary>
        ''' 獲取單號
        ''' </summary>
        ''' <param name="D_NO"></param>
        ''' <param name="D_OM_Num"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PositiveDeliver_GetNO(ByVal D_NO As String, ByVal D_OM_Num As String) As PositiveDeliverInfo

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)

            Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveDeliver_GetNO")

            db.AddInParameter(dbComm, "@D_NO", DbType.String, D_NO)
            db.AddInParameter(dbComm, "@D_OM_Num", DbType.String, D_OM_Num)

            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillPositiveDeliver(reader)
                End While
                Return Nothing
            End Using

        End Function
#End Region

#Region "獲取送貨類型"
        ''' <summary>
        ''' 獲取送貨類型
        ''' </summary>
        ''' <param name="D_TypeID"></param>
        ''' <param name="D_TypeName"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PositiveDeliver_GetListType(ByVal D_TypeID As String, ByVal D_TypeName As String) As List(Of PositiveDeliverInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveDeliver_GetListType")

            db.AddInParameter(dbComm, "@D_TypeID", DbType.String, D_TypeID)
            db.AddInParameter(dbComm, "@D_TypeName", DbType.String, D_TypeName)


            Dim FeatureList As New List(Of PositiveDeliverInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPositiveDeliver_GetListType(reader))
                End While
                Return FeatureList
            End Using
        End Function


#End Region

#Region "獲取送貨列表"
        ''' <summary>
        ''' 獲取送貨列表
        ''' </summary>
        ''' <param name="D_NO"></param>
        ''' <param name="P_OM_Num"></param>
        ''' <param name="P_M_Code"></param>
        ''' <param name="D_AddStartDate"></param>
        ''' <param name="D_EndStartDate"></param>
        ''' <param name="D_AddAction"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PositiveDeliver_GetList(ByVal D_NO As String, ByVal P_OM_Num As String, ByVal P_M_Code As String, ByVal D_AddStartDate As String, ByVal D_EndStartDate As String, ByVal D_AddAction As String, ByVal P_OM_CusterPO As String) As List(Of PositiveDeliverInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveDeliver_GetList")

            db.AddInParameter(dbComm, "@D_NO", DbType.String, D_NO)
            db.AddInParameter(dbComm, "@P_OM_Num", DbType.String, P_OM_Num)
            db.AddInParameter(dbComm, "@P_M_Code", DbType.String, P_M_Code)
            db.AddInParameter(dbComm, "@D_AddStartDate", DbType.DateTime, D_AddStartDate)
            db.AddInParameter(dbComm, "@D_EndStartDate", DbType.DateTime, D_EndStartDate)
            db.AddInParameter(dbComm, "@D_AddAction", DbType.String, D_AddAction)
            db.AddInParameter(dbComm, "@P_OM_CusterPO", DbType.String, P_OM_CusterPO)

            Dim FeatureList As New List(Of PositiveDeliverInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPositiveDeliver(reader))
                End While
                Return FeatureList
            End Using




        End Function

        ''' <summary>
        ''' 獲取送貨訂單列表的前500條記錄
        ''' </summary>
        ''' <param name="D_NO"></param>
        ''' <param name="P_OM_Num"></param>
        ''' <param name="P_M_Code"></param>
        ''' <param name="D_AddStartDate"></param>
        ''' <param name="D_EndStartDate"></param>
        ''' <param name="D_AddAction"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PositiveDeliver_GetListTopFiveHundred(ByVal D_NO As String, ByVal P_OM_Num As String, ByVal P_M_Code As String, ByVal D_AddStartDate As String, ByVal D_EndStartDate As String, ByVal D_AddAction As String) As List(Of PositiveDeliverInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveDeliver_GetListTopFiveHundred")

            db.AddInParameter(dbComm, "@D_NO", DbType.String, D_NO)
            db.AddInParameter(dbComm, "@P_OM_Num", DbType.String, P_OM_Num)
            db.AddInParameter(dbComm, "@P_M_Code", DbType.String, P_M_Code)
            db.AddInParameter(dbComm, "@D_AddStartDate", DbType.DateTime, D_AddStartDate)
            db.AddInParameter(dbComm, "@D_EndStartDate", DbType.DateTime, D_EndStartDate)
            db.AddInParameter(dbComm, "@D_AddAction", DbType.String, D_AddAction)


            Dim FeatureList As New List(Of PositiveDeliverInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPositiveDeliver(reader))
                End While
                Return FeatureList
            End Using
        End Function
#End Region

#Region "修改送貨訂單"
        ''' <summary>
        ''' 修改送貨訂單
        ''' </summary>
        ''' <param name="posDelInfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PositiveDeliver_Update(ByVal posDelInfo As PositiveDeliverInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveDeliver_Update")

                db.AddInParameter(dbComm, "@D_NO", DbType.String, posDelInfo.D_NO)

                db.AddInParameter(dbComm, "@P_OM_Num", DbType.String, posDelInfo.P_OM_Num)

                db.AddInParameter(dbComm, "@D_TypeID", DbType.String, posDelInfo.D_TypeID)

                db.AddInParameter(dbComm, "@D_AddAction", DbType.String, posDelInfo.D_AddAction)

                db.AddInParameter(dbComm, "@D_AddDate", DbType.String, posDelInfo.D_AddDate)

                db.AddInParameter(dbComm, "@Qty", DbType.Double, posDelInfo.Qty)

                db.AddInParameter(dbComm, "@D_Remark", DbType.String, posDelInfo.D_Remark)

                db.AddInParameter(dbComm, "@D_Check", DbType.Boolean, posDelInfo.D_Check)

                db.AddInParameter(dbComm, "@AutoID", DbType.String, posDelInfo.AutoID)

                db.AddInParameter(dbComm, "@D_OMCheckRemark", DbType.String, posDelInfo.D_OMCheckRemark)



                db.AddInParameter(dbComm, "@NoTaxPrice", DbType.Decimal, posDelInfo.NoTaxPrice)
                db.AddInParameter(dbComm, "@TaxRate", DbType.Decimal, posDelInfo.TaxRate)
                db.AddInParameter(dbComm, "@Discount", DbType.Decimal, posDelInfo.Discount)

                db.AddInParameter(dbComm, "@Sequence", DbType.Int16, posDelInfo.Sequence)
                db.AddInParameter(dbComm, "@M_Name", DbType.String, posDelInfo.M_Name)
                db.AddInParameter(dbComm, "@M_Gauge", DbType.String, posDelInfo.M_Gauge)
                db.AddInParameter(dbComm, "@UnitID", DbType.String, posDelInfo.UnitID)
                db.ExecuteNonQuery(dbComm)
                PositiveDeliver_Update = True

            Catch ex As Exception
                PositiveDeliver_Update = False
            End Try

        End Function


       
#End Region

#Region "新增送貨訂單"
        ''' <summary>
        ''' 新增送貨訂單
        ''' </summary>
        ''' <param name="posDelInfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PositiveDeliver_Add(ByVal posDelInfo As PositiveDeliverInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveDeliver_Add")

                db.AddInParameter(dbComm, "@D_NO", DbType.String, posDelInfo.D_NO)

                db.AddInParameter(dbComm, "@P_OM_Num", DbType.String, posDelInfo.P_OM_Num)

                db.AddInParameter(dbComm, "@D_TypeID", DbType.String, posDelInfo.D_TypeID)

                db.AddInParameter(dbComm, "@D_AddAction", DbType.String, posDelInfo.D_AddAction)

                db.AddInParameter(dbComm, "@D_AddDate", DbType.String, posDelInfo.D_AddDate)

                db.AddInParameter(dbComm, "@Qty", DbType.Double, posDelInfo.Qty)

                db.AddInParameter(dbComm, "@D_Remark", DbType.String, posDelInfo.D_Remark)

                db.AddInParameter(dbComm, "@D_Check", DbType.Boolean, posDelInfo.D_Check)

                db.AddInParameter(dbComm, "@D_OMCheckRemark", DbType.String, posDelInfo.D_OMCheckRemark)

                db.AddInParameter(dbComm, "@NoTaxPrice", DbType.Decimal, posDelInfo.NoTaxPrice)
                db.AddInParameter(dbComm, "@TaxRate", DbType.Decimal, posDelInfo.TaxRate)
                db.AddInParameter(dbComm, "@Discount", DbType.Decimal, posDelInfo.Discount)
                db.AddInParameter(dbComm, "@Sequence", DbType.Int16, posDelInfo.Sequence)
                db.AddInParameter(dbComm, "@M_Name", DbType.String, posDelInfo.M_Name)
                db.AddInParameter(dbComm, "@M_Gauge", DbType.String, posDelInfo.M_Gauge)
                db.AddInParameter(dbComm, "@UnitID", DbType.String, posDelInfo.UnitID)
                db.ExecuteNonQuery(dbComm)
                PositiveDeliver_Add = True

            Catch ex As Exception
                PositiveDeliver_Add = False
                MsgBox(ex.Message)
            End Try

        End Function
#End Region

#Region "刪除送貨訂單"
        ''' <summary>
        ''' 刪除送貨訂單
        ''' </summary>
        ''' <param name="AutoID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PositiveDeliver_Delete(ByVal AutoID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveDeliver_Delete")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)

                db.ExecuteNonQuery(dbComm)
                PositiveDeliver_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PositiveDeliver_Delete = False
            End Try
        End Function

        ''' <summary>
        ''' 根據訂單編號進行刪除
        ''' </summary>
        ''' <param name="D_NO"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function PositiveDeliver_DeleteByDOMNum(ByVal D_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveDeliver_DeleteByDOMNum")

                db.AddInParameter(dbComm, "@D_NO", DbType.String, D_NO)

                db.ExecuteNonQuery(dbComm)
                PositiveDeliver_DeleteByDOMNum = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PositiveDeliver_DeleteByDOMNum = False
            End Try
        End Function
#End Region

#Region "審核陽極送貨訂單"
        Public Function PositiveDeliver_Check(ByVal posDelInfo As PositiveDeliverInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveDeliver_Check")

                db.AddInParameter(dbComm, "@D_NO", DbType.String, posDelInfo.D_NO)

                db.AddInParameter(dbComm, "@D_OM_Num", DbType.String, posDelInfo.D_OM_Num)

                db.AddInParameter(dbComm, "@D_Check", DbType.Boolean, posDelInfo.D_Check)

                db.AddInParameter(dbComm, "@D_CheckAction", DbType.String, posDelInfo.D_CheckAction)

                db.AddInParameter(dbComm, "@D_CheckDate", DbType.String, posDelInfo.D_CheckDate)

                db.AddInParameter(dbComm, "@D_CheckRemark", DbType.String, posDelInfo.D_CheckRemark)

                db.ExecuteNonQuery(dbComm)
                PositiveDeliver_Check = True

            Catch ex As Exception
                MsgBox(ex.Message)
                PositiveDeliver_Check = False
            End Try

        End Function
#End Region

#Region "填充數據集合"
        ''' <summary>
        ''' 填充送貨訂單類型
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function FillPositiveDeliver_GetListType(ByVal reader As IDataReader) As PositiveDeliverInfo
            On Error Resume Next

            Dim poInfo As New PositiveDeliverInfo

            poInfo.AutoID = reader("AutoID").ToString
            poInfo.D_TypeID = reader("D_TypeID").ToString
            poInfo.D_TypeName = reader("D_TypeName").ToString

            Return poInfo
        End Function

        ''' <summary>
        ''' 填充數據集合
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function FillPositiveDeliver(ByVal reader As IDataReader) As PositiveDeliverInfo
            On Error Resume Next

            Dim poInfo As New PositiveDeliverInfo

            poInfo.AutoID = reader("AutoID").ToString

            poInfo.P_OM_Num = reader("P_OM_Num").ToString

            poInfo.P_OM_ID = reader("P_OM_ID").ToString

            poInfo.P_OM_CusterPO = reader("P_OM_CusterPO").ToString

            poInfo.P_OM_CusterNo = reader("P_OM_CusterNo").ToString

            poInfo.D_TypeID = reader("D_TypeID").ToString

            poInfo.M_Unit = reader("M_Unit").ToString

            poInfo.P_M_Code = reader("P_M_Code").ToString

            poInfo.PartNumber = reader("PartNumber").ToString

            poInfo.People = reader("People").ToString

            poInfo.Qty = reader("Qty").ToString

            poInfo.OrderQty = reader("OrderQty").ToString

            poInfo.NoSendQty = reader("NoSendQty").ToString

            poInfo.ActionName = reader("ActionName").ToString

            poInfo.CheckActionName = reader("CheckActionName").ToString

            poInfo.D_AddAction = reader("D_AddAction").ToString

            poInfo.D_CheckAction = reader("D_CheckAction").ToString

            poInfo.ChineseName = reader("ChineseName").ToString

            poInfo.CusterAddr = reader("CusterAddr").ToString

            poInfo.D_AddDate = CDate(reader("D_AddDate")).ToString("yyyy/MM/dd")


            If reader("P_SalesPrice") Is DBNull.Value Then
                poInfo.P_SalesPrice = Nothing
            Else
                poInfo.P_SalesPrice = reader("P_SalesPrice")
            End If

            If reader("P_ProductPrice") Is DBNull.Value Then
                poInfo.P_ProductPrice = Nothing
            Else
                poInfo.P_ProductPrice = reader("P_ProductPrice")
            End If

            If reader("D_NO") Is DBNull.Value Then
                poInfo.D_NO = Nothing
            Else
                poInfo.D_NO = reader("D_NO")
            End If

            If reader("D_OM_Num") Is DBNull.Value Then
                poInfo.D_OM_Num = Nothing
            Else
                poInfo.D_OM_Num = reader("D_OM_Num")
            End If

            If reader("D_OM_Num") Is DBNull.Value Then
                poInfo.D_OM_Num = Nothing
            Else
                poInfo.D_OM_Num = reader("D_OM_Num")
            End If

            If reader("D_TypeName") Is DBNull.Value Then
                poInfo.D_TypeName = Nothing
            Else
                poInfo.D_TypeName = reader("D_TypeName")
            End If

            If reader("D_Remark") Is DBNull.Value Then
                poInfo.D_Remark = Nothing
            Else
                poInfo.D_Remark = reader("D_Remark")
            End If


            If reader("D_Check") Is DBNull.Value Then
                poInfo.D_Check = Nothing
            Else
                poInfo.D_Check = reader("D_Check")
            End If


            If reader("D_CheckDate") Is DBNull.Value Then
                poInfo.D_CheckDate = Nothing
            Else
                poInfo.D_CheckDate = CDate(reader("D_CheckDate")).ToString("yyyy/MM/dd")
            End If


            If reader("D_CheckRemark") Is DBNull.Value Then
                poInfo.D_CheckRemark = Nothing
            Else
                poInfo.D_CheckRemark = reader("D_CheckRemark")
            End If

            If reader("D_OMCheckRemark") Is DBNull.Value Then
                poInfo.D_OMCheckRemark = Nothing
            Else
                poInfo.D_OMCheckRemark = reader("D_OMCheckRemark")
            End If


            If reader("NoTaxPrice") Is DBNull.Value Then
                poInfo.NoTaxPrice = 0
            Else
                poInfo.NoTaxPrice = CDec(reader("NoTaxPrice"))
            End If
            If reader("TaxRate") Is DBNull.Value Then
                poInfo.TaxRate = 0
            Else
                poInfo.TaxRate = CDec(reader("TaxRate"))
            End If
            If reader("Discount") Is DBNull.Value Then
                poInfo.Discount = 0
            Else
                poInfo.Discount = CDec(reader("Discount"))
            End If

            poInfo.Sequence = reader("Sequence")
            If IsDBNull(reader("M_Name")) = False Then
                poInfo.M_Name = reader("M_Name").ToString
            End If
            If IsDBNull(reader("M_Gauge")) = False Then
                poInfo.M_Gauge = reader("M_Gauge").ToString
            End If
            If IsDBNull(reader("UnitID")) = False Then
                poInfo.UnitID = reader("UnitID").ToString
            End If
            If IsDBNull(reader("UnitName")) = False Then
                poInfo.UnitName = reader("UnitName").ToString
            End If
            Return poInfo

        End Function
#End Region
    End Class
End Namespace
