Namespace LFERP.Library.NmetalSampleBigBox
    Public Class NmetalSampleBigBoxController
#Region "獲取單號"
        ''' <summary>
        ''' 獲取單號
        ''' </summary>
        ''' <param name="BigBoxID"></param>
        ''' <param name="BigBoxNum"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function NmetalSampleBigBox_GetNO(ByVal BigBoxID As String, ByVal BigBoxNum As String) As NmetalSampleBigBoxInfo

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleBigBox_GetNO")

            db.AddInParameter(dbComm, "@BigBoxID", DbType.String, BigBoxID)
            db.AddInParameter(dbComm, "@BigBoxNum", DbType.String, BigBoxNum)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillNmetalSampleBigBox(reader)
                End While
                Return Nothing
            End Using
        End Function
#End Region

#Region "新增外箱包裝"
        ''' <summary>
        ''' 新增外箱包裝
        ''' </summary>
        ''' <param name="objInfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function NmetalSampleBigBox_Add(ByVal objInfo As NmetalSampleBigBoxInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleBigBox_Add")

                db.AddInParameter(dbComm, "@BigBoxID", DbType.String, objInfo.BigBoxID)
                db.AddInParameter(dbComm, "@BigBoxNum ", DbType.String, objInfo.BigBoxNum)
                db.AddInParameter(dbComm, "@SmallBoxID", DbType.String, objInfo.SmallBoxID)
                db.AddInParameter(dbComm, "@Customer", DbType.String, objInfo.Customer)
                db.AddInParameter(dbComm, "@PartNumber", DbType.String, objInfo.PartNumber)
                db.AddInParameter(dbComm, "@ProductionPlace", DbType.String, objInfo.ProductionPlace)
                db.AddInParameter(dbComm, "@Supplier", DbType.String, objInfo.Supplier)
                db.AddInParameter(dbComm, "@BigBoxDate", DbType.DateTime, objInfo.BigBoxDate)
                db.AddInParameter(dbComm, "@SmallBoxCount", DbType.String, objInfo.SmallBoxCount)
                db.AddInParameter(dbComm, "@SmallBoxWeight", DbType.String, objInfo.SmallBoxWeight)
                db.AddInParameter(dbComm, "@SmallBoxNum", DbType.String, objInfo.SmallBoxNum)
                db.AddInParameter(dbComm, "@BigBoxAddAction", DbType.String, objInfo.BigBoxAddAction)
                db.AddInParameter(dbComm, "@BigBoxAddDate", DbType.DateTime, objInfo.BigBoxAddDate)
                db.AddInParameter(dbComm, "@BigBoxRemark", DbType.String, objInfo.BigBoxRemark)
                db.AddInParameter(dbComm, "@SmallBoxName", DbType.String, objInfo.SmallBoxName)
                db.AddInParameter(dbComm, "@ClientNumber", DbType.String, objInfo.ClientNumber)
                db.AddInParameter(dbComm, "@SmallBoxType", DbType.String, objInfo.SmallBoxType)
                db.AddInParameter(dbComm, "@SmallBoxMatrial", DbType.String, objInfo.SmallBoxMatrial)
                db.AddInParameter(dbComm, "@Remark", DbType.String, objInfo.Remark)

                db.ExecuteNonQuery(dbComm)
                NmetalSampleBigBox_Add = True
            Catch ex As Exception
                NmetalSampleBigBox_Add = False
            End Try
        End Function
#End Region

#Region "修改外箱包裝"
        ''' <summary>
        ''' 修改外箱包裝
        ''' </summary>
        ''' <param name="objInfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function NmetalSampleBigBox_Update(ByVal objInfo As NmetalSampleBigBoxInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleBigBox_Update")

                db.AddInParameter(dbComm, "@BigBoxID", DbType.String, objInfo.BigBoxID)
                db.AddInParameter(dbComm, "@BigBoxNum ", DbType.String, objInfo.BigBoxNum)
                db.AddInParameter(dbComm, "@SmallBoxID", DbType.String, objInfo.SmallBoxID)
                db.AddInParameter(dbComm, "@Customer", DbType.String, objInfo.Customer)
                db.AddInParameter(dbComm, "@PartNumber", DbType.String, objInfo.PartNumber)
                db.AddInParameter(dbComm, "@ProductionPlace", DbType.String, objInfo.ProductionPlace)
                db.AddInParameter(dbComm, "@Supplier", DbType.String, objInfo.Supplier)
                db.AddInParameter(dbComm, "@BigBoxDate", DbType.DateTime, objInfo.BigBoxDate)
                db.AddInParameter(dbComm, "@SmallBoxCount", DbType.String, objInfo.SmallBoxCount)
                db.AddInParameter(dbComm, "@SmallBoxWeight", DbType.String, objInfo.SmallBoxWeight)
                db.AddInParameter(dbComm, "@SmallBoxNum", DbType.String, objInfo.SmallBoxNum)
                db.AddInParameter(dbComm, "@BigBoxAddAction", DbType.String, objInfo.BigBoxAddAction)
                db.AddInParameter(dbComm, "@BigBoxAddDate", DbType.DateTime, objInfo.BigBoxAddDate)
                db.AddInParameter(dbComm, "@BigBoxRemark", DbType.String, objInfo.BigBoxRemark)
                db.AddInParameter(dbComm, "@SmallBoxName", DbType.String, objInfo.SmallBoxName)
                db.AddInParameter(dbComm, "@ClientNumber", DbType.String, objInfo.ClientNumber)
                db.AddInParameter(dbComm, "@SmallBoxType", DbType.String, objInfo.SmallBoxType)
                db.AddInParameter(dbComm, "@SmallBoxMatrial", DbType.String, objInfo.SmallBoxMatrial)
                db.AddInParameter(dbComm, "@Remark", DbType.String, objInfo.Remark)

                db.ExecuteNonQuery(dbComm)
                NmetalSampleBigBox_Update = True
            Catch ex As Exception
                NmetalSampleBigBox_Update = False
            End Try
        End Function
#End Region

#Region "刪除外箱包裝"
        ''' <summary>
        ''' 根據外箱單號刪除
        ''' </summary>
        ''' <param name="BigBoxID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function NmetalSampleBigBox_Delete(ByVal BigBoxID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleBigBox_Delete")

                db.AddInParameter(dbComm, "@BigBoxID", DbType.String, BigBoxID)

                db.ExecuteNonQuery(dbComm)
                NmetalSampleBigBox_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSampleBigBox_Delete = False
            End Try
        End Function

        ''' <summary>
        ''' 根據外箱包裝流水號刪除
        ''' </summary>
        ''' <param name="BigBoxNum"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function NmetalSampleBigBox_DeleteByBigBoxNum(ByVal BigBoxNum As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleBigBox_DeleteByBigBoxNum")

                db.AddInParameter(dbComm, "@BigBoxNum", DbType.String, BigBoxNum)

                db.ExecuteNonQuery(dbComm)
                NmetalSampleBigBox_DeleteByBigBoxNum = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSampleBigBox_DeleteByBigBoxNum = False
            End Try
        End Function
#End Region

#Region "獲取外箱包裝"
        ''' <summary>
        ''' 外箱列表明細
        ''' </summary>
        ''' <param name="BigBoxID"></param>
        ''' <param name="BigBoxNum"></param>
        ''' <param name="SmallBoxID"></param>
        ''' <param name="Customer"></param>
        ''' <param name="Supplier"></param>
        ''' <param name="BigBoxAddStartDate"></param>
        ''' <param name="BigBoxAddEndDate"></param>
        ''' <param name="BigBoxAddAction"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function NmetalSampleBigBox_GetList(ByVal BigBoxID As String, ByVal BigBoxNum As String, ByVal SmallBoxID As String, ByVal Customer As String, ByVal Supplier As String, ByVal BigBoxAddStartDate As String, ByVal BigBoxAddEndDate As String, ByVal BigBoxAddAction As String) As List(Of NmetalSampleBigBoxInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleBigBox_GetList")

            db.AddInParameter(dbComm, "@BigBoxID", DbType.String, BigBoxID)
            db.AddInParameter(dbComm, "@BigBoxNum", DbType.String, BigBoxNum)
            db.AddInParameter(dbComm, "@SmallBoxID", DbType.String, SmallBoxID)
            db.AddInParameter(dbComm, "@Customer", DbType.String, Customer)
            db.AddInParameter(dbComm, "@Supplier", DbType.String, Supplier)
            db.AddInParameter(dbComm, "@BigBoxAddStartDate", DbType.String, BigBoxAddStartDate)
            db.AddInParameter(dbComm, "@BigBoxAddEndDate", DbType.String, BigBoxAddEndDate)
            db.AddInParameter(dbComm, "@BigBoxAddAction", DbType.String, BigBoxAddAction)

            Dim FeatureList As New List(Of NmetalSampleBigBoxInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillNmetalSampleBigBox(reader))
                End While
                Return FeatureList
            End Using
        End Function
        ''' <summary>
        ''' 列印外箱列表明細
        ''' </summary>
        ''' <param name="BigBoxID"></param>
        ''' <param name="BigBoxNum"></param>
        ''' <param name="SmallBoxID"></param>
        ''' <param name="Customer"></param>
        ''' <param name="Supplier"></param>
        ''' <param name="BigBoxAddStartDate"></param>
        ''' <param name="BigBoxAddEndDate"></param>
        ''' <param name="BigBoxAddAction"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function NmetalSampleBigBox_GetListOne(ByVal BigBoxID As String, ByVal BigBoxNum As String, ByVal SmallBoxID As String, ByVal Customer As String, ByVal Supplier As String, ByVal BigBoxAddStartDate As String, ByVal BigBoxAddEndDate As String, ByVal BigBoxAddAction As String) As List(Of NmetalSampleBigBoxInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleBigBox_GetListOne")

            db.AddInParameter(dbComm, "@BigBoxID", DbType.String, BigBoxID)
            db.AddInParameter(dbComm, "@BigBoxNum", DbType.String, BigBoxNum)
            db.AddInParameter(dbComm, "@SmallBoxID", DbType.String, SmallBoxID)
            db.AddInParameter(dbComm, "@Customer", DbType.String, Customer)
            db.AddInParameter(dbComm, "@Supplier", DbType.String, Supplier)
            db.AddInParameter(dbComm, "@BigBoxAddStartDate", DbType.String, BigBoxAddStartDate)
            db.AddInParameter(dbComm, "@BigBoxAddEndDate", DbType.String, BigBoxAddEndDate)
            db.AddInParameter(dbComm, "@BigBoxAddAction", DbType.String, BigBoxAddAction)

            Dim FeatureList As New List(Of NmetalSampleBigBoxInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillNmetalSampleBigBox(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function NmetalSampleBigBox_GetListTwo(ByVal BigBoxID As String, ByVal BigBoxNum As String, ByVal SmallBoxID As String, ByVal Customer As String, ByVal Supplier As String, ByVal BigBoxAddStartDate As String, ByVal BigBoxAddEndDate As String, ByVal BigBoxAddAction As String) As List(Of NmetalSampleBigBoxInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleBigBox_GetListTwo")

            db.AddInParameter(dbComm, "@BigBoxID", DbType.String, BigBoxID)
            db.AddInParameter(dbComm, "@BigBoxNum", DbType.String, BigBoxNum)
            db.AddInParameter(dbComm, "@SmallBoxID", DbType.String, SmallBoxID)
            db.AddInParameter(dbComm, "@Customer", DbType.String, Customer)
            db.AddInParameter(dbComm, "@Supplier", DbType.String, Supplier)
            db.AddInParameter(dbComm, "@BigBoxAddStartDate", DbType.String, BigBoxAddStartDate)
            db.AddInParameter(dbComm, "@BigBoxAddEndDate", DbType.String, BigBoxAddEndDate)
            db.AddInParameter(dbComm, "@BigBoxAddAction", DbType.String, BigBoxAddAction)

            Dim FeatureList As New List(Of NmetalSampleBigBoxInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillNmetalSampleBigBox(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function NmetalSampleBigBox_GetBigBoxID(ByVal BigBoxID As String, ByVal BigBoxNum As String, ByVal SmallBoxID As String, ByVal Customer As String, ByVal Supplier As String, ByVal BigBoxAddStartDate As String, ByVal BigBoxAddEndDate As String, ByVal BigBoxAddAction As String) As List(Of NmetalSampleBigBoxInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleBigBox_GetBigBoxID")

            db.AddInParameter(dbComm, "@BigBoxID", DbType.String, BigBoxID)
            db.AddInParameter(dbComm, "@BigBoxNum", DbType.String, BigBoxNum)
            db.AddInParameter(dbComm, "@SmallBoxID", DbType.String, SmallBoxID)
            db.AddInParameter(dbComm, "@Customer", DbType.String, Customer)
            db.AddInParameter(dbComm, "@Supplier", DbType.String, Supplier)
            db.AddInParameter(dbComm, "@BigBoxAddStartDate", DbType.String, BigBoxAddStartDate)
            db.AddInParameter(dbComm, "@BigBoxAddEndDate", DbType.String, BigBoxAddEndDate)
            db.AddInParameter(dbComm, "@BigBoxAddAction", DbType.String, BigBoxAddAction)

            Dim FeatureList As New List(Of NmetalSampleBigBoxInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillNmetalSampleBigBox(reader))
                End While
                Return FeatureList
            End Using
        End Function

#End Region

#Region "審核外箱包裝"
        ''' <summary>
        ''' 審     核
        ''' </summary>
        ''' <param name="NmetalSampleBigBoxInfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function NmetalSampleBigBox_Check(ByVal NmetalSampleBigBoxInfo As NmetalSampleBigBoxInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleBigBox_Check")

                db.AddInParameter(dbComm, "@BigBoxID", DbType.String, NmetalSampleBigBoxInfo.BigBoxID)
                db.AddInParameter(dbComm, "@BigBoxCheck", DbType.Boolean, NmetalSampleBigBoxInfo.BigBoxCheck)
                db.AddInParameter(dbComm, "@BigBoxCheckAction", DbType.String, NmetalSampleBigBoxInfo.BigBoxCheckAction)
                db.AddInParameter(dbComm, "@BigBoxCheckDate", DbType.String, NmetalSampleBigBoxInfo.BigBoxCheckDate)
                db.AddInParameter(dbComm, "@BigBoxCheckRemark", DbType.String, NmetalSampleBigBoxInfo.BigBoxCheckRemark)

                db.ExecuteNonQuery(dbComm)
                NmetalSampleBigBox_Check = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSampleBigBox_Check = False
            End Try

        End Function
#End Region

#Region "填充數據集合"
        ''' <summary>
        ''' 填充數據集合
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function FillNmetalSampleBigBox(ByVal reader As IDataReader) As NmetalSampleBigBoxInfo
            On Error Resume Next

            Dim poInfo As New NmetalSampleBigBoxInfo

            poInfo.AutoID = reader("AutoID").ToString
            poInfo.BigBoxID = reader("BigBoxID").ToString
            poInfo.BigBoxNum = reader("BigBoxNum").ToString
            poInfo.SmallBoxID = reader("SmallBoxID").ToString
            poInfo.Customer = reader("Customer").ToString
            poInfo.PartNumber = reader("PartNumber").ToString
            poInfo.ProductionPlace = reader("ProductionPlace").ToString
            poInfo.Supplier = reader("Supplier").ToString
            poInfo.BigBoxDate = CDate(reader("BigBoxDate")).ToString("yyyy/MM/dd")
            poInfo.SmallBoxWeight = reader("SmallBoxWeight").ToString
            poInfo.SmallBoxCount = reader("SmallBoxCount").ToString
            poInfo.SmallBoxNum = reader("SmallBoxNum").ToString
            poInfo.BigBoxAddAction = reader("BigBoxAddAction").ToString
            poInfo.BigBoxAddDate = CDate(reader("BigBoxAddDate")).ToString("yyyy/MM/dd")

            poInfo.BigBoxRemark = reader("BigBoxRemark").ToString
            poInfo.Remark = reader("Remark").ToString
            poInfo.BigBoxCheckAction = reader("BigBoxCheckAction").ToString
            poInfo.BigBoxCheck = reader("BigBoxCheck").ToString
            poInfo.BigBoxCheckDate = CDate(reader("BigBoxCheckDate")).ToString("yyyy/MM/dd")
            poInfo.BigBoxCheckRemark = reader("BigBoxCheckRemark").ToString

            poInfo.SO_SampleID = reader("SO_SampleID").ToString
            poInfo.PK_ID = reader("PK_ID").ToString
            poInfo.D_Dep = reader("D_Dep").ToString

            poInfo.ActionName = reader("ActionName").ToString
            poInfo.CheckActionName = reader("CheckActionName").ToString
            poInfo.BitNeed = reader("BitNeed").ToString
            poInfo.BigRemark = reader("BigRemark").ToString

            poInfo.SmallBoxName = reader("SmallBoxName").ToString
            poInfo.SmallBoxType = reader("SmallBoxType").ToString
            poInfo.SmallBoxMatrial = reader("SmallBoxMatrial").ToString
            poInfo.ClientNumber = reader("ClientNumber").ToString

            Return poInfo
        End Function
#End Region


    End Class
End Namespace

