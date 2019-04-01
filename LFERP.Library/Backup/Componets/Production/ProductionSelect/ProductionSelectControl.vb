Imports LFERP.Library.ProductionRetrocede
Imports LFERP.Library.ProductionReturn


Namespace LFERP.Library.ProductionSelect

    Public Class ProductionSelectControl

        Public Function ProductionSelect_Retrocede_Getlist(ByVal WareModule As String, ByVal strWhere As String) As List(Of ProductionRetrocedeInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Production_Select")

            db.AddInParameter(dbComm, "@WareModule", DbType.String, WareModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)

            Dim FeatureList As New List(Of ProductionRetrocedeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionRetrocede(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function ProductionSelect_Return_Getlist(ByVal WareModule As String, ByVal strWhere As String) As List(Of ProductionReturnInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Production_Select")

            db.AddInParameter(dbComm, "@WareModule", DbType.String, WareModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)

            Dim FeatureList As New List(Of ProductionReturnInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionReturn(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FillProductionRetrocede(ByVal reader As IDataReader) As ProductionRetrocedeInfo

            On Error Resume Next

            Dim pri As New ProductionRetrocedeInfo

            pri.IndexNO = reader("IndexNO").ToString
            pri.R_NO = reader("R_NO").ToString
            pri.R_Type = reader("R_Type").ToString
            pri.WH_OutID = reader("WH_OutID").ToString
            pri.WH_InID = reader("WH_InID").ToString
            pri.Pro_Type = reader("Pro_Type").ToString
            pri.PM_M_Code = reader("PM_M_Code").ToString
            pri.PM_Type = reader("PM_Type").ToString
            'pri.Pro_NO = reader("Pro_NO").ToString

            pri.R_Qty = CSng(reader("R_Qty").ToString)
            pri.R_NoSendQty = CSng(reader("R_NoSendQty").ToString)

            If reader("R_Date") Is DBNull.Value Then
                pri.R_Date = Nothing
            Else
                pri.R_Date = CStr(reader("R_Date"))
            End If

            pri.R_Detail = reader("R_Detail").ToString
            pri.R_Remark = reader("R_Remark").ToString
            pri.R_Action = reader("R_Action").ToString

            If reader("R_Check") Is DBNull.Value Then
                pri.R_Check = Nothing
            Else
                pri.R_Check = CStr(reader("R_Check"))
            End If
            pri.R_CheckAction = reader("R_CheckAction").ToString

            If reader("R_CheckDate") Is DBNull.Value Then
                pri.R_CheckDate = Nothing
            Else
                pri.R_CheckDate = CStr(reader("R_CheckDate"))
            End If
            pri.R_CheckRemark = reader("R_CheckRemark").ToString


            pri.ActionName = reader("ActionName").ToString
            pri.CheckActionName = reader("CheckActionName").ToString
            pri.WH_Name = reader("WH_Name").ToString
            pri.WH_InName = reader("WH_InName").ToString
            'pri.PS_Name = reader("PS_Name").ToString


            Return pri

        End Function

        Public Function FillProductionReturn(ByVal reader As IDataReader) As ProductionReturnInfo

            On Error Resume Next

            Dim pri As New ProductionReturnInfo

            pri.AutoID = reader("AutoID").ToString
            pri.AR_NO = reader("AR_NO").ToString
            pri.R_NO = reader("R_NO").ToString
            pri.AR_Type = reader("AR_Type").ToString
            pri.WH_OutID = reader("WH_OutID").ToString
            pri.WH_InID = reader("WH_InID").ToString
            pri.Pro_Type = reader("Pro_Type").ToString
            pri.PM_M_Code = reader("PM_M_Code").ToString
            pri.PM_Type = reader("PM_Type").ToString
            'pri.Pro_NO = reader("Pro_NO").ToString

            pri.AR_Qty = CSng(reader("AR_Qty").ToString)

            If reader("AR_Date") Is DBNull.Value Then
                pri.AR_Date = Nothing
            Else
                pri.AR_Date = CStr(reader("AR_Date"))
            End If

            pri.AR_Detail = reader("AR_Detail").ToString
            pri.AR_Remark = reader("AR_Remark").ToString
            pri.AR_Action = reader("AR_Action").ToString

            If reader("AR_Check") Is DBNull.Value Then
                pri.AR_Check = Nothing
            Else
                pri.AR_Check = CStr(reader("AR_Check"))
            End If
            pri.AR_CheckAction = reader("AR_CheckAction").ToString

            If reader("AR_CheckDate") Is DBNull.Value Then
                pri.AR_CheckDate = Nothing
            Else
                pri.AR_CheckDate = CStr(reader("AR_CheckDate"))
            End If
            pri.AR_CheckRemark = reader("AR_CheckRemark").ToString


            pri.ActionName = reader("ActionName").ToString
            pri.CheckActionName = reader("CheckActionName").ToString
            pri.WH_Name = reader("WH_Name").ToString
            pri.WH_InName = reader("WH_InName").ToString
            'pri.PS_Name = reader("PS_Name").ToString

            Return pri
        End Function

        '2014.04.25 取得生產收發明細表  劉祥松
        Public Function GetProductTransceiving(ByVal BeginDate As DateTime, ByVal EndDate As DateTime, ByVal PM_M_Code As String, ByVal M_Code As String, ByVal ProcessType As String, ByVal PS_NO As String, ByVal OutFacID As String, ByVal InFacID As String, ByVal OutDeptID As String, ByVal InDeptID As String) As DataTable
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("GetProductTransceiving")
            If BeginDate <> DateTime.MinValue Then
                db.AddInParameter(dbComm, "@BeginDate", DbType.DateTime, BeginDate)
            End If
            If EndDate <> DateTime.MinValue Then
                db.AddInParameter(dbComm, "@EndDate", DbType.DateTime, EndDate)
            End If
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@ProcessType", DbType.String, ProcessType)
            db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
            db.AddInParameter(dbComm, "@OutFacID", DbType.String, OutFacID)
            db.AddInParameter(dbComm, "@InFacID", DbType.String, InFacID)
            db.AddInParameter(dbComm, "@OutDeptID", DbType.String, OutDeptID)
            db.AddInParameter(dbComm, "@InDeptID", DbType.String, InDeptID)
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