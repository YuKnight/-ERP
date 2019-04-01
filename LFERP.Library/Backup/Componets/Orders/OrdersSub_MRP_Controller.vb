Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Namespace LFERP.Library.Orders
    Public Class FOrdersSub_MRPController
        Friend Function FillFOrdersSub(ByVal reader As IDataReader) As FOrdersSub_MRPInfo
            Dim objInfo As New FOrdersSub_MRPInfo
            objInfo.OM_No = reader("OM_No").ToString
            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            objInfo.CustomerID = reader("CustomerID").ToString
            objInfo.FMonth = reader("FMonth").ToString
            objInfo.FWeek = reader("FWeek").ToString
            objInfo.FDateRange = reader("FDateRange").ToString
            objInfo.FDateRangeQty = reader("FDateRangeQty").ToString
            objInfo.FDate = reader("FDate").ToString
            Return objInfo
        End Function

        Public Function FOrdersSub_GetList_MRP(ByVal OM_No As String, ByVal PM_M_Code As String, ByVal CustomerID As String, ByVal FMonth As String, ByVal FWeek As String, ByVal FDateRange As String, ByVal FDateRangeQty As String, ByVal FDate As String) As List(Of FOrdersSub_MRPInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("FOrdersSub_GetList_MRP")
            db.AddInParameter(dbComm, "@OM_No", DbType.String, OM_No)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@CustomerID", DbType.String, CustomerID)
            db.AddInParameter(dbComm, "@FMonth", DbType.String, FMonth)
            db.AddInParameter(dbComm, "@FWeek", DbType.String, FWeek)
            db.AddInParameter(dbComm, "@FDateRange", DbType.String, FDateRange)
            db.AddInParameter(dbComm, "@FDateRangeQty", DbType.String, FDateRangeQty)
            db.AddInParameter(dbComm, "@FDate", DbType.String, FDate)
            Dim FeatureList As New List(Of FOrdersSub_MRPInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillFOrdersSub(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FOrdersSub_GetListBySql_MRP(ByVal strOM_No As String, ByVal strCusterID As String, ByVal strPM_M_Code As String) As DataSet
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim strSql As String = String.Empty
            strSql = getQuerySql(strOM_No, strCusterID, strPM_M_Code)
            Dim dbComm As DbCommand = db.GetSqlStringCommand(strSql)
            dbComm.CommandTimeout = 50000
            Return db.ExecuteDataSet(dbComm)
        End Function

        ''' <summary>
        ''' 通過訂單編號、客戶編號、產品編號獲得查詢訂單明細sql語句
        ''' </summary>
        ''' <param name="strOM_No">訂單編號</param>
        ''' <param name="strCusterID">客戶編號</param>
        ''' <param name="strPM_M_Code">產品編號</param>
        ''' <returns>sql語句</returns>
        ''' <remarks></remarks>
        Friend Function getQuerySql(ByVal strOM_No As String, ByVal strCusterID As String, ByVal strPM_M_Code As String) As String
            Dim FOSubcon As New FOrdersSub_MRPController
            Dim strFDateRange As String = String.Empty
            Dim strFMonth As String = String.Empty
            Dim strFWeek As String = String.Empty
            Dim strSql As String = String.Empty
            'Dim strSqlQuery As String = String.Empty
            Dim oinfoList As New List(Of FOrdersSub_MRPInfo)
            oinfoList = FOSubcon.FOrdersSub_GetList_MRP(strOM_No, strPM_M_Code, strCusterID, Nothing, Nothing, Nothing, Nothing, Nothing)
            For index As Integer = 0 To oinfoList.Count - 1
                strFDateRange = oinfoList(index).FDateRange.ToString()
                strFMonth = oinfoList(index).FMonth.ToString()
                strFWeek = oinfoList(index).FWeek.ToString()
                strSql = strSql + ",(select distinct FDateRangeQty from FOrdersSub  where  FDateRange ='" + strFDateRange + "' and PM_M_Code='" + strPM_M_Code + "' and CustomerID='" + strCusterID + "' and OM_No='" + strOM_No + "') as '" + Mid(strFMonth, 1, 4) + "-(" + strFDateRange + ")-" + Microsoft.VisualBasic.Right(strFWeek, 4) + "'"
            Next
            strSql = "select distinct OM_No as '訂單編號', PM_M_Code as '產品編號',CustomerID as '客戶編號' " + strSql + " from FOrdersSub where PM_M_Code='" + strPM_M_Code + "' and CustomerID='" + strCusterID + "' and OM_No='" + strOM_No + "'"
            Return strSql
        End Function


        Public Function FOrdersSub_Add_MRP(ByVal objInfo As FOrdersSub_MRPInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("FOrdersSub_Add_MRP")
                db.AddInParameter(dbComm, "@OM_No", DbType.String, objInfo.OM_No)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objInfo.PM_M_Code)
                db.AddInParameter(dbComm, "@CustomerID", DbType.String, objInfo.CustomerID)
                db.AddInParameter(dbComm, "@FMonth", DbType.String, objInfo.FMonth)
                db.AddInParameter(dbComm, "@FWeek", DbType.String, objInfo.FWeek)
                db.AddInParameter(dbComm, "@FDateRange", DbType.String, objInfo.FDateRange)
                db.AddInParameter(dbComm, "@FDateRangeQty", DbType.String, objInfo.FDateRangeQty)
                db.AddInParameter(dbComm, "@FDate", DbType.String, objInfo.FDate)
                db.ExecuteNonQuery(dbComm)
                FOrdersSub_Add_MRP = True
            Catch ex As Exception
                MsgBox(ex.Message)
                FOrdersSub_Add_MRP = False
            End Try
        End Function
    End Class
End Namespace