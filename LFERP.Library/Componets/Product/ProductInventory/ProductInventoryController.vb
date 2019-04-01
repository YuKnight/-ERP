Imports System
Imports System.Data
Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Imports System.Windows.Forms

Namespace LFERP.Library.Product
    Public Class ProductInventoryController
        Public Function ProductInventory_Add(ByVal obj As ProductInventoryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductInventory_Add")

                db.AddInParameter(dbcomm, "@PM_M_Code", DbType.String, obj.PM_M_Code) '產品編號
                db.AddInParameter(dbcomm, "@M_Code", DbType.String, obj.M_Code) '物料編碼
                db.AddInParameter(dbcomm, "@WH_ID", DbType.String, obj.WH_ID) '倉庫編號
                db.AddInParameter(dbcomm, "@PI_Qty", DbType.Int32, obj.PI_Qty) '庫存數量

                db.ExecuteNonQuery(dbcomm)
                ProductInventory_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductInventory_Add = False
            End Try
        End Function

        Public Function ProductInventory_Update(ByVal obj As ProductInventoryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductInventory_Update")

                db.AddInParameter(dbcomm, "@PM_M_Code", DbType.String, obj.PM_M_Code) '產品編號
                db.AddInParameter(dbcomm, "@M_Code", DbType.String, obj.M_Code) '物料編碼
                db.AddInParameter(dbcomm, "@WH_ID", DbType.String, obj.WH_ID) '倉庫編號
                db.AddInParameter(dbcomm, "@PI_Qty", DbType.Int32, obj.PI_Qty) '庫存數量

                db.ExecuteNonQuery(dbcomm)
                ProductInventory_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductInventory_Update = False
            End Try
        End Function

        Public Function ProductInventory_GetList(ByVal PM_M_Code As String, ByVal M_Code As String, ByVal WH_ID As String, ByVal PI_Qty As String) As List(Of ProductInventoryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductInventory_GetList")

            db.AddInParameter(dbcomm, "@PM_M_Code", DbType.String, PM_M_Code) '產品編號
            db.AddInParameter(dbcomm, "@M_Code", DbType.String, M_Code) '物料編碼
            db.AddInParameter(dbcomm, "@WH_ID", DbType.String, WH_ID) '倉庫編號
            db.AddInParameter(dbcomm, "@PI_Qty", DbType.String, PI_Qty) '庫存數量

            Dim FeatureList As New List(Of ProductInventoryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillProductInventory(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FillProductInventory(ByVal reader As IDataReader) As ProductInventoryInfo

            On Error Resume Next
            Dim ai As New ProductInventoryInfo

            ai.AutoID = reader("AutoID")     '自動編號ID
            ai.PM_M_Code = reader("PM_M_Code").ToString     '產品編號
            ai.M_Code = reader("M_Code").ToString     '物料編碼
            ai.WH_ID = reader("WH_ID").ToString     '倉庫編號

            If reader("PI_Qty") Is DBNull.Value Then
                ai.PI_Qty = 0
                ai.WI_Qty = 0
            Else
                ai.PI_Qty = reader("PI_Qty")     '庫存數量
                ai.WI_Qty = reader("PI_Qty")     '庫存數量
            End If

            ai.WH_Name = reader("WH_Name").ToString     '倉庫名稱
            ai.WH_PName = reader("WH_PName").ToString     '上一級倉庫名稱
            ai.M_Name = reader("M_Name").ToString     '物料名稱
            ai.M_Gauge = reader("M_Gauge").ToString     '物料名稱
            ai.M_Unit = reader("M_Unit").ToString     '物料名稱

            ai.PM_JiYu = reader("PM_JiYu").ToString

            Return ai
        End Function
    End Class
End Namespace

