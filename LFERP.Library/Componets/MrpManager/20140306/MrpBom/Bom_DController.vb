Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Namespace LFERP.Library.MrpManager.Bom_D
    Public Class Bom_DController
        Friend Function FillBom_D(ByVal reader As IDataReader) As Bom_DInfo
            On Error Resume Next
            Dim objInfo As New Bom_DInfo
            objInfo.ChildName = reader("ChildName").ToString
            objInfo.ChildGauge = reader("ChildGauge").ToString
            objInfo.ChildMC_Source = reader("ChildMC_Source").ToString
            objInfo.AutoID = reader("AutoID").ToString
            objInfo.ParentGroup = reader("ParentGroup").ToString
            objInfo.ChildGroup = reader("ChildGroup").ToString
            objInfo.IsUnfold = reader("IsUnfold")
            objInfo.Item = reader("Item").ToString
            objInfo.ReplaceType = reader("ReplaceType").ToString
            objInfo.ReplaceType1 = reader("ReplaceType1").ToString
            objInfo.UseFeatures = reader("UseFeatures").ToString
            objInfo.PID = reader("PID").ToString
            objInfo.ID = reader("ID").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            objInfo.M_Source = reader("M_Source").ToString
            objInfo.sonsNum = reader("sonsNum").ToString
            objInfo.CreateUserName = reader("CreateUserName").ToString


            If IsDBNull(reader("EffectiveDate")) = True Then
                objInfo.EffectiveDate = Nothing
            Else
                objInfo.EffectiveDate = Format(CDate(reader("EffectiveDate")), "yyyy/MM/dd")
            End If
            If IsDBNull(reader("InvalidDate")) = True Then
                objInfo.InvalidDate = Nothing
            Else
                objInfo.InvalidDate = Format(CDate(reader("InvalidDate")), "yyyy/MM/dd")
            End If
            objInfo.Mount = CDec(reader("Mount").ToString)
            objInfo.Tmrtc = CDec(reader("Tmrtc").ToString)
            objInfo.SumQty = CDec(reader("SumQty").ToString)
            objInfo.LossQty = CDec(reader("LossQty").ToString)
            objInfo.ActualQty = CDec(reader("ActualQty").ToString)
            objInfo.QtyPer = CDec(reader("QtyPer").ToString)
            objInfo.SendUnit = reader("SendUnit").ToString
            objInfo.LossRate = CDec(reader("LossRate").ToString)
            objInfo.CreateUserID = reader("CreateUserID").ToString
            If IsDBNull(reader("CreateDate")) = True Then
                objInfo.CreateDate = Nothing
            Else
                objInfo.CreateDate = Format(CDate(reader("CreateDate")), "yyyy/MM/dd")
            End If
            objInfo.ModifyUserID = reader("ModifyUserID").ToString
            If IsDBNull(reader("ModifyDate")) = True Then
                objInfo.ModifyDate = Nothing
            Else
                objInfo.ModifyDate = Format(CDate(reader("ModifyDate")), "yyyy/MM/dd")
            End If
            Return objInfo

        End Function

        Public Function Bom_D_GetList(ByVal ParentGroup As String) As List(Of Bom_DInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Bom_D_GetList")
            db.AddInParameter(dbComm, "@ParentGroup", DbType.String, ParentGroup)
            Dim FeatureList As New List(Of Bom_DInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillBom_D(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function MRP_GetSingleBomTree(ByVal ParentGroup As String, ByVal Qty As Integer, ByVal IsBottom As Boolean) As List(Of Bom_DInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MRP_GetSingleBomTree")
            db.AddInParameter(dbComm, "@parentGroupM", DbType.String, ParentGroup)
            db.AddInParameter(dbComm, "@Qty", DbType.String, Qty)
            db.AddInParameter(dbComm, "@IsBottom", DbType.Boolean, IsBottom)

            Dim FeatureList As New List(Of Bom_DInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillBom_D(reader))
                End While
                Return FeatureList
            End Using
        End Function



        Public Function Bom_D_Delete(ByVal AutoID As String, ByVal ParentGroup As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Bom_D_Delete")
                db.AddInParameter(dbComm, "@AutoID", DbType.Decimal, AutoID)
                db.AddInParameter(dbComm, "@ParentGroup", DbType.String, ParentGroup)
                db.ExecuteNonQuery(dbComm)
                Bom_D_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Bom_D_Delete = False
            End Try
        End Function

        Public Function Bom_D_Update(ByVal objinfo As Bom_DInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Bom_D_Update")
                db.AddInParameter(dbComm, "@ChildGroup", DbType.String, objinfo.ChildGroup)
                db.AddInParameter(dbComm, "@IsUnfold", DbType.Boolean, objinfo.IsUnfold)
                db.AddInParameter(dbComm, "@Item", DbType.String, objinfo.Item)
                db.AddInParameter(dbComm, "@ReplaceType", DbType.String, objinfo.ReplaceType)
                db.AddInParameter(dbComm, "@UseFeatures", DbType.String, objinfo.UseFeatures)
                'db.AddInParameter(dbComm, "@EffectiveDate", DbType.DateTime, objinfo.EffectiveDate)
                db.AddInParameter(dbComm, "@InvalidDate", DbType.DateTime, objinfo.InvalidDate)
                db.AddInParameter(dbComm, "@Mount", DbType.Decimal, objinfo.Mount)
                db.AddInParameter(dbComm, "@Tmrtc", DbType.Decimal, objinfo.Tmrtc)
                db.AddInParameter(dbComm, "@SendUnit", DbType.String, objinfo.SendUnit)
                db.AddInParameter(dbComm, "@LossRate", DbType.Decimal, objinfo.LossRate)
                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbComm, "@ModifyDate", DbType.Date, objinfo.ModifyDate)
                db.AddInParameter(dbComm, "@AutoID", DbType.Decimal, objinfo.AutoID)
                db.ExecuteNonQuery(dbComm)
                Bom_D_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Bom_D_Update = False
            End Try
        End Function

        Public Function Bom_D_Add(ByVal objInfo As Bom_DInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Bom_D_Add")
                db.AddInParameter(dbComm, "@ParentGroup", DbType.String, objInfo.ParentGroup)
                db.AddInParameter(dbComm, "@ChildGroup", DbType.String, objInfo.ChildGroup)
                db.AddInParameter(dbComm, "@IsUnfold", DbType.Boolean, objInfo.IsUnfold)
                db.AddInParameter(dbComm, "@Item", DbType.String, objInfo.Item)
                db.AddInParameter(dbComm, "@ReplaceType", DbType.String, objInfo.ReplaceType)
                db.AddInParameter(dbComm, "@UseFeatures", DbType.String, objInfo.UseFeatures)
                db.AddInParameter(dbComm, "@EffectiveDate", DbType.String, objInfo.EffectiveDate)
                'db.AddInParameter(dbComm, "@InvalidDate", DbType.String, objInfo.InvalidDate)
                db.AddInParameter(dbComm, "@Mount", DbType.Decimal, objInfo.Mount)
                db.AddInParameter(dbComm, "@Tmrtc", DbType.Decimal, objInfo.Tmrtc)
                db.AddInParameter(dbComm, "@SendUnit", DbType.String, objInfo.SendUnit)
                db.AddInParameter(dbComm, "@LossRate", DbType.Decimal, objInfo.LossRate)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                db.AddInParameter(dbComm, "@CreateDate", DbType.Date, objInfo.CreateDate)
                db.ExecuteNonQuery(dbComm)
                Bom_D_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Bom_D_Add = False
            End Try
        End Function


        Public Function Bom_D_GetChildGroup(ByVal ParentGroup As String, ByVal mount As Double) As DataTable
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_GetBomChildGroup")
            db.AddInParameter(dbComm, "@ParentGroup", DbType.String, ParentGroup)
            db.AddInParameter(dbComm, "@mount", DbType.Double, mount)
            Dim table As New DataTable
            table = db.ExecuteDataSet(dbComm).Tables(0)
            Return table
        End Function

#Region "Bom嵌套檢查"
        Public Function Mrp_BomNestedCheck()
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_BomNestedCheck")
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                If reader.Read Then
                    MsgBox(reader(0) + "物料存在嵌套使用,無法保存", MsgBoxStyle.Information, "提示")
                    Return True
                End If
                Return False
            End Using
        End Function
#End Region
    End Class
End Namespace