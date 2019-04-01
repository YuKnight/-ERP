Namespace LFERP.Library.Production.DeptBalanceMain
    Public Class DeptBalance_Control
        Public Function getDataSetByDeptList(ByVal DPT_IDList As List(Of String), ByVal strCondition As String, ByVal strDPT_ID As String) As DataSet
            Dim strSql As String = String.Empty

            For Each DPT_ID As String In DPT_IDList
                strSql = strSql + ",(select a.wi_qty+a.wi_reqty  from ProductionDPTWareInventory a where a.M_Code =Processsub.PS_NO and a.DPT_ID ='" + DPT_ID + "') as '" + DPT_ID + "'"
            Next
            strSql = "select distinct ProcessMain.PM_M_Code,prod_main_new.PM_JiYu ,prod_main_new.M_Gauge ,ProcessMain.M_Code  ,MaterialCode.M_Name ,MaterialCode.M_Gauge as M_Gauge_Half,MaterialCode.M_Unit ,ProcessSub.PS_NO ,ProcessSub.PS_Name " + strSql + " ,(select SUM(WI_Qty)+SUM(WI_ReQty) from ProductionDPTWareInventory where M_Code=Processsub.PS_NO and DPT_ID in (" + strDPT_ID + ")) as SumQty from Processsub, ProcessMain, ProductionDPTWareInventory, Prod_Main_New, MaterialCode where Processsub.Pro_NO =ProcessMain.Pro_NO and ProductionDPTWareInventory.M_Code =Processsub.PS_NO and ProcessMain.PM_M_Code =Prod_Main_New.PM_M_Code and MaterialCode.M_Code =ProcessMain.M_Code and (ProductionDPTWareInventory.WI_Qty +ProductionDPTWareInventory.WI_ReQty)>0 and " + strCondition + " order by ProcessMain.PM_M_Code desc"
            Return getDataSet(strSql)
        End Function

        Public Function getDataSetByDeptList_Knife(ByVal DPT_IDList As List(Of String), ByVal strCondition As String, ByVal strDPT_ID As String) As DataSet
            Dim strSql As String = String.Empty

            For Each DPT_ID As String In DPT_IDList
                strSql = strSql + ",(select b.WI_Qty +b.WI_ReQty  from vwProductionDPTWareInventory b where  b.PM_M_Code =a.PM_M_Code and b.DPT_ID ='" + DPT_ID + "') as '" + DPT_ID + "'"
            Next
            strSql = "select distinct a.PM_M_Code ,a.M_Name ,a.M_Gauge ,a.M_Unit " + strSql + " ,(select SUM(WI_Qty)+SUM(WI_ReQty) from vwProductionDPTWareInventory where PM_M_Code=a.PM_M_Code and DPT_ID in (" + strDPT_ID + ")) as SumQty from vwProductionDPTWareInventory a where " + strCondition + " order by a.PM_M_Code desc"
            Return getDataSet(strSql)
        End Function

        Public Function getDataSet(ByVal strSql As String) As DataSet
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetSqlStringCommand(strSql)
            dbComm.CommandTimeout = 0
            Return db.ExecuteDataSet(dbComm)
        End Function

    End Class
End Namespace