
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Namespace LFERP.Library.WareHouse.WareBorrowChange

    Public Class WareBorrowChangeControl
        Public Function WareBorrowChange_GetNo(ByVal NDate As String) As WareBorrowChangeInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareBorrowChange_GetNo")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)

            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillWareBorrowChangeNo(reader)
                End While
                Return Nothing
            End Using
        End Function


        Public Function FillWareBorrowChangeNo(ByVal reader As IDataReader) As WareBorrowChangeInfo
            Dim ci As New WareBorrowChangeInfo
            '流水號
            ci.ChangeNo = reader("ChangeNo").ToString
            Return ci

        End Function

        Public Function WareBorrowChange_Add(ByVal objinfo As WareBorrowChangeInfo) As Boolean
            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("WareBorrowChange_Add")

                db.AddInParameter(dbcomm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbcomm, "@WB_PerID", DbType.String, objinfo.WB_PerID)
                db.AddInParameter(dbcomm, "@WB_NUM", DbType.String, objinfo.WB_NUM)
                db.AddInParameter(dbcomm, "@QtyS", DbType.Int32, objinfo.QtyS)
                db.AddInParameter(dbcomm, "@QtyE", DbType.Int32, objinfo.QtyE)

                db.AddInParameter(dbcomm, "@ChangeType", DbType.String, objinfo.ChangeType)
                db.AddInParameter(dbcomm, "@Remark", DbType.String, objinfo.Remark)
                db.AddInParameter(dbcomm, "@ChageDate", DbType.String, objinfo.ChageDate)
                db.AddInParameter(dbcomm, "@ChangeAction", DbType.String, objinfo.ChangeAction)

                db.AddInParameter(dbcomm, "@ChangeNo", DbType.String, objinfo.ChangeNo)

                db.ExecuteNonQuery(dbcomm)
                WareBorrowChange_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareBorrowChange_Add = False
            End Try

        End Function

        Public Function WareBorrowReturn_UpdateNO_ReQtyChange(ByVal WB_NUM As String, ByVal NO_ReQty As Int32) As Boolean
            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("WareBorrowReturn_UpdateNO_ReQtyChange")

                db.AddInParameter(dbcomm, "@WB_NUM", DbType.String, WB_NUM)
                db.AddInParameter(dbcomm, "@NO_ReQty", DbType.String, NO_ReQty)

                db.ExecuteNonQuery(dbcomm)
                WareBorrowReturn_UpdateNO_ReQtyChange = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareBorrowReturn_UpdateNO_ReQtyChange = False
            End Try

        End Function

        Friend Function FillWareBorrowChange(ByVal reader As IDataReader) As WareBorrowChangeInfo
            '對應取得的數據
            On Error Resume Next
            Dim objInfo As New WareBorrowChangeInfo

            objInfo.ChangeNo = reader("ChangeNo").ToString
            objInfo.AutoID = reader("AutoID").ToString

            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString

            objInfo.WB_PerID = reader("WB_PerID").ToString
            objInfo.WB_NUM = reader("WB_NUM").ToString
            objInfo.QtyS = reader("QtyS")
            objInfo.QtyE = reader("QtyE")

            objInfo.ChangeType = reader("ChangeType").ToString
            objInfo.Remark = reader("Remark").ToString
            objInfo.ChageDate = reader("ChageDate").ToString
            objInfo.ChangeAction = reader("ChangeAction").ToString

            objInfo.SumQty = reader("SumQty")

            objInfo.ChangeActionName = reader("ChangeActionName").ToString


            '2014-02-15 姚駿------------------------------------
            objInfo.CheckRemark = reader("CheckRemark").ToString
            objInfo.CheckAction = reader("CheckAction").ToString
            objInfo.CheckActionName = reader("CheckActionName").ToString
            If reader("Check") Is DBNull.Value Then
                objInfo.Check = Nothing
            Else
                objInfo.Check = reader("Check")
            End If

            If reader("CheckDate") Is DBNull.Value Then
                objInfo.CheckDate = ""
            Else
                objInfo.CheckDate = CStr(reader("CheckDate"))
            End If
            '----------------------------------------------------
            Return objInfo
        End Function

        '2014-02-13 姚駿
        Public Function WareBorrowChange_CheckGetList(ByVal M_Code As String, ByVal WB_PerID As String, ByVal WB_NUM As String, ByVal ChageDateS As String, ByVal ChageDateE As String, ByVal ChangeNo As String, ByVal Check As String) As List(Of WareBorrowChangeInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareBorrowChange_CheckGetList")
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@WB_PerID", DbType.String, WB_PerID)
            db.AddInParameter(dbComm, "@WB_NUM", DbType.String, WB_NUM)
            db.AddInParameter(dbComm, "@ChageDateS", DbType.String, ChageDateS)

            db.AddInParameter(dbComm, "@ChageDateE", DbType.String, ChageDateE)
            db.AddInParameter(dbComm, "@ChangeNo", DbType.String, ChangeNo)
            db.AddInParameter(dbComm, "@Check", DbType.String, Check)

            Dim FeatureList As New List(Of WareBorrowChangeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareBorrowChange(reader))
                End While
                Return FeatureList
            End Using
        End Function

        '2014-02-12 姚駿
        Public Function WareBorrowChange_update(ByVal AutoID As String, ByVal Check As String, ByVal CheckAction As String, ByVal CheckDate As String, ByVal CheckRemark As String) As Boolean
            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareBorrowChange_update")
                db.AddInParameter(dbComm, "@AutoID", DbType.Decimal, AutoID)
                db.AddInParameter(dbComm, "@Check", DbType.String, Check)
                db.AddInParameter(dbComm, "@CheckAction", DbType.String, CheckAction)
                db.AddInParameter(dbComm, "@CheckDate", DbType.String, CheckDate)
                db.AddInParameter(dbComm, "@CheckRemark", DbType.String, CheckRemark)


                db.ExecuteNonQuery(dbComm)
                WareBorrowChange_update = True
            Catch ex As Exception
                WareBorrowChange_update = False
            End Try
        End Function

        Public Function WareBorrowChange_GetList(ByVal M_Code As String, ByVal WB_PerID As String, ByVal WB_NUM As String, ByVal ChageDateS As String, ByVal ChageDateE As String, ByVal ChangeNo As String) As List(Of WareBorrowChangeInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareBorrowChange_GetList")
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@WB_PerID", DbType.String, WB_PerID)
            db.AddInParameter(dbComm, "@WB_NUM", DbType.String, WB_NUM)
            db.AddInParameter(dbComm, "@ChageDateS", DbType.String, ChageDateS)

            db.AddInParameter(dbComm, "@ChageDateE", DbType.String, ChageDateE)
            db.AddInParameter(dbComm, "@ChangeNo", DbType.String, ChangeNo)


            Dim FeatureList As New List(Of WareBorrowChangeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareBorrowChange(reader))
                End While
                Return FeatureList
            End Using
        End Function
        ''' <summary>
        ''' 匯總出針對指定人，指定編號共調整多少
        ''' </summary>
        ''' <param name="M_Code"></param>
        ''' <param name="WB_PerID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareBorrowChange_GetSum(ByVal M_Code As String, ByVal WB_PerID As String) As List(Of WareBorrowChangeInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareBorrowChange_GetSum")
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@WB_PerID", DbType.String, WB_PerID)

            Dim FeatureList As New List(Of WareBorrowChangeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareBorrowChange(reader))
                End While
                Return FeatureList
            End Using
        End Function


    End Class

End Namespace
