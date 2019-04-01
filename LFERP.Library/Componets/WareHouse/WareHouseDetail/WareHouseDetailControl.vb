

Namespace LFERP.Library.WareHouseDetail

    Public Class WareHouseDetailControl

        Public Function WareHouseDetail_GetList1(ByVal WH_ID As String, ByVal M_Code As String, ByVal StartDate As String, ByVal EndDate As String) As List(Of WareHouseDetailInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareHouseDetail_GetList1")

            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@StartDate", DbType.String, StartDate)
            db.AddInParameter(dbComm, "@EndDate", DbType.String, EndDate)


            Dim FeatureList As New List(Of WareHouseDetailInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareHouseDetail(reader))
                End While
                Return FeatureList
            End Using
        End Function

        '鄭少釗 2014-4-28
        Public Function WareHouseDetail_GetStrType() As DataSet
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareHouseDetail_GetStrType")
            Using ds As DataSet = db.ExecuteDataSet(dbComm)
                Return ds
            End Using
        End Function
        '鄭少釗 2014-4-28
        Public Function WareHouseDetail_GetList_MRP(ByVal StartDate As String, ByVal EndDate As String, ByVal M_Code_Begin As String, ByVal M_Code_End As String, ByVal WH_ID As String, ByVal strType As String, ByVal WType As String) As DataSet
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareHouseDetail_GetList_MRP")
            db.AddInParameter(dbComm, "@StartDate", DbType.String, StartDate)
            db.AddInParameter(dbComm, "@EndDate", DbType.String, EndDate)
            db.AddInParameter(dbComm, "@M_Code_Begin", DbType.String, M_Code_Begin)
            db.AddInParameter(dbComm, "@M_Code_End", DbType.String, M_Code_End)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@strType", DbType.String, strType)
            db.AddInParameter(dbComm, "@WType", DbType.String, WType)
            Using ds As DataSet = db.ExecuteDataSet(dbComm)
                Return ds
            End Using
        End Function
        Public Function WareINandOutQty_V_GetList(ByVal M_Code As String, ByVal WH_ID As String, ByVal AddDateBegin As String, ByVal AddDateEnd As String) As List(Of WareHouseDetailInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareINandOutQty_V_GetList")

            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@AddDateBegin", DbType.String, AddDateBegin)
            db.AddInParameter(dbComm, "@AddDateEnd", DbType.String, AddDateEnd)


            Dim FeatureList As New List(Of WareHouseDetailInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareHouseDetail(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FillWareHouseDetail(ByVal reader As IDataReader) As WareHouseDetailInfo

            On Error Resume Next

            Dim fd As New WareHouseDetailInfo

            fd.M_Code = reader("M_Code").ToString
            fd.M_Name = reader("M_Name").ToString
            fd.WH_ID = reader("WH_ID").ToString
            fd.WH_Name = reader("WH_UpName").ToString & "-" & reader("WH_Name").ToString
            fd.WH_UpName = reader("WH_UpName").ToString
            fd.ID = reader("ID").ToString

            If reader("Qty") Is DBNull.Value Then
                fd.Qty = Nothing
            Else
                fd.Qty = CDbl(reader("Qty").ToString)
            End If

            If reader("strDate") Is DBNull.Value Then
                fd.strDate = Nothing
            Else
                fd.strDate = CStr(reader("strDate"))
            End If

            If reader("EndQty") Is DBNull.Value Then
                fd.EndQty = Nothing
            Else
                fd.EndQty = CDbl(reader("EndQty").ToString)
            End If
            fd.strType = reader("strType").ToString
            fd.Remark = reader("Remark").ToString
            fd.AP_NO = reader("AP_NO").ToString
            fd.WO_PerName = reader("WO_PerName").ToString
            fd.CardID = reader("CardID").ToString

            '2013
            fd.M_Gauge = reader("M_Gauge").ToString
            fd.M_Unit = reader("M_Unit").ToString
            fd.W_Type = reader("W_Type").ToString & "/" & reader("strType").ToString

            '2013-5-13
            fd.Type1ID = reader("Type1ID").ToString
            fd.Type1Name = reader("Type1Name").ToString

            fd.Type2ID = reader("Type2ID").ToString
            fd.Type2Name = reader("Type2Name").ToString

            fd.Type3ID = reader("Type3ID").ToString
            fd.Type3Name = reader("Type3Name").ToString
            fd.WType = reader("WType").ToString
            fd.SType = reader("SType").ToString


            Return fd

        End Function

        ''' <summary>
        ''' 針對磨刀部(單獨增加) 可選多外倉庫
        ''' </summary>
        ''' <param name="WH_ID"></param>
        ''' <param name="M_Code"></param>
        ''' <param name="StartDate"></param>
        ''' <param name="EndDate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareHouseDetail_GetList2(ByVal WH_ID As String, ByVal M_Code As String, ByVal StartDate As String, ByVal EndDate As String, ByVal CardID As String) As List(Of WareHouseDetailInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareHouseDetail_GetList2")

            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@StartDate", DbType.String, StartDate)
            db.AddInParameter(dbComm, "@EndDate", DbType.String, EndDate)
            db.AddInParameter(dbComm, "@CardID", DbType.String, CardID)


            Dim FeatureList As New List(Of WareHouseDetailInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareHouseDetail(reader))
                End While
                Return FeatureList
            End Using
        End Function

        ''' <summary>
        ''' 出入庫明細表 帶Type3ID
        ''' </summary>
        ''' <param name="WH_ID"></param>
        ''' <param name="M_Code"></param>
        ''' <param name="StartDate"></param>
        ''' <param name="EndDate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareHouseDetail_GetList3(ByVal WH_ID As String, ByVal M_Code As String, ByVal StartDate As String, ByVal EndDate As String) As List(Of WareHouseDetailInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareHouseDetail_GetList3")

            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@StartDate", DbType.String, StartDate)
            db.AddInParameter(dbComm, "@EndDate", DbType.String, EndDate)


            Dim FeatureList As New List(Of WareHouseDetailInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareHouseDetail(reader))
                End While
                Return FeatureList
            End Using
        End Function


        Public Function WareHouseDetail_GetList5(ByVal WH_ID As String, ByVal M_Code As String, ByVal StartDate As String, ByVal EndDate As String, ByVal WType As String) As List(Of WareHouseDetailInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareHouseDetail_GetList5")

            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@StartDate", DbType.String, StartDate)
            db.AddInParameter(dbComm, "@EndDate", DbType.String, EndDate)
            db.AddInParameter(dbComm, "@WType", DbType.String, WType)

            Dim FeatureList As New List(Of WareHouseDetailInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareHouseDetail(reader))
                End While
                Return FeatureList
            End Using
        End Function



        Public Function WareHouseDetail_GetListQty(ByVal WH_ID As String, ByVal M_Code As String, ByVal StartDate As String, ByVal EndDate As String, ByVal WType As String) As List(Of WareHouseDetailInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareHouseDetail_GetListQty")

            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@StartDate", DbType.String, StartDate)
            db.AddInParameter(dbComm, "@EndDate", DbType.String, EndDate)
            db.AddInParameter(dbComm, "@WType", DbType.String, WType)

            Dim FeatureList As New List(Of WareHouseDetailInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareHouseDetail(reader))
                End While
                Return FeatureList
            End Using
        End Function





    End Class

End Namespace

