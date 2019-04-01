
Imports System
Imports System.Data
Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Imports System.Windows.Forms


Namespace LFERP.Library.Material
    Public Class MaterialController

        ''' <summary>
        '''新增物料編碼
        ''' </summary>
        ''' <param name="objMaterial"></param>
        ''' <remarks></remarks>
        Public Function MaterialCode_Add(ByVal objMaterial As MaterialInfo) As Boolean
            ' Dim strM_Code As String = GetM_Code(objMaterial.M_Code)
            '檢查物料編碼編號是否已存在
            Dim objMaterialCode As MaterialInfo = MaterialCode_Get(objMaterial.M_Code)
            If objMaterialCode Is Nothing Then
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialCode_Add")
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objMaterial.M_Code)
                db.AddInParameter(dbComm, "@BlocCode", DbType.String, objMaterial.BlocCode)
                db.AddInParameter(dbComm, "@M_Name", DbType.String, objMaterial.M_Name)
                db.AddInParameter(dbComm, "@M_Gauge", DbType.String, objMaterial.M_Gauge)
                db.AddInParameter(dbComm, "@M_Unit", DbType.String, objMaterial.M_Unit)
                'db.AddInParameter(dbComm, "@M_Type", DbType.String, objMaterial.M_Type)
                db.AddInParameter(dbComm, "@M_Price", DbType.Double, objMaterial.M_Price)
                db.AddInParameter(dbComm, "@M_Currency", DbType.String, objMaterial.M_Currency)
                db.AddInParameter(dbComm, "@M_IsEnabled", DbType.Boolean, objMaterial.M_IsEnabled)
                db.AddInParameter(dbComm, "@M_Maker", DbType.String, objMaterial.M_Maker)
                db.AddInParameter(dbComm, "@M_Photo", DbType.Binary, objMaterial.M_Photo)
                db.AddInParameter(dbComm, "@M_AddDate", DbType.String, objMaterial.M_AddDate)
                db.AddInParameter(dbComm, "@M_Remark", DbType.String, objMaterial.M_Remark)
                db.AddInParameter(dbComm, "@Type3ID", DbType.String, objMaterial.Type3ID)
                db.AddInParameter(dbComm, "@M_AccountCheck", DbType.Boolean, objMaterial.M_AccountCheck)
                db.AddInParameter(dbComm, "InUser", DbType.String, objMaterial.InUser)
                db.AddInParameter(dbComm, "@M_IsSub", DbType.Boolean, objMaterial.M_IsSub)
                db.AddInParameter(dbComm, "@M_supplier", DbType.String, objMaterial.M_supplier)
                db.AddInParameter(dbComm, "@M_supplierNo", DbType.String, objMaterial.M_SupplierNo)
                db.AddInParameter(dbComm, "@M_SaveKuCun", DbType.String, objMaterial.M_SaveKuCun)

                db.AddInParameter(dbComm, "@M_Weight", DbType.Double, objMaterial.M_Weight)
                db.AddInParameter(dbComm, "@M_WeightUnit", DbType.String, objMaterial.M_WeightUnit)
                db.AddInParameter(dbComm, "@M_CheckRemark", DbType.String, objMaterial.M_CheckRemark)

                db.ExecuteNonQuery(dbComm)
                MaterialCode_Add = True
            Else
                MaterialCode_Add = False
            End If
        End Function

        ''' <summary>
        ''' 取得物料編碼資料列表,無圖像,不需要的字段請設為Nothing
        ''' </summary>
        ''' <param name="M_Code">物料編碼</param>
        ''' <param name="M_Name">物料名稱,模糊查詢</param>
        ''' <param name="M_Gauge">規格,模糊查詢</param>    
        ''' <param name="Type3ID">物料類別編號</param>
        ''' <param name="M_AccountCheck">會計部審核:0 為未審核 , 1為已審核,不需要則設置為Nothing</param>
        ''' <param name="M_IsEnabled">是否啟用</param>
        ''' <param name="M_AddDateVal">建立日期查詢符號: 等於,大於,小於等等 </param>
        ''' <param name="M_AddDate">建立日期</param>
        ''' <param name="M_EditDateVal"> 修改日期查詢符號: 等於,大於,小於等等 </param>
        ''' <param name="M_EditDate">修改日期</param>
        ''' <param name="InUser">操作員</param> 
        ''' <param name="M_IsSub">是否有子物料</param> 
        ''' <param name="SoureType">來源類型</param> 
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MaterialCode_GetList_New(ByVal M_Code As String, ByVal M_Name As String, ByVal M_Gauge As String, ByVal Type3ID As String, ByVal M_AccountCheck As String, ByVal M_IsEnabled As String, _
        ByVal M_AddDateVal As String, ByVal M_AddDate As String, ByVal M_EditDateVal As String, ByVal M_EditDate As String, ByVal InUser As String, ByVal M_IsSub As String, ByVal M_SupplierNo As String, ByVal M_TeSu As String, ByVal SoureType As String) As List(Of MaterialInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialCode_GetList_New")
            If M_Code Is Nothing Then
                db.AddInParameter(dbComm, "@M_Code", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            End If
            If M_Name Is Nothing Then
                db.AddInParameter(dbComm, "@M_Name", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            End If
            If M_Gauge Is Nothing Then
                db.AddInParameter(dbComm, "@M_Gauge", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_Gauge", DbType.String, M_Gauge)
            End If
            If M_IsEnabled Is Nothing Then
                db.AddInParameter(dbComm, "@M_IsEnabled", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_IsEnabled", DbType.String, M_IsEnabled)
            End If
            If M_AddDateVal Is Nothing Then
                db.AddInParameter(dbComm, "@M_AddDateVal", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_AddDateVal", DbType.String, M_AddDateVal)
            End If
            If M_AddDate Is Nothing Then
                db.AddInParameter(dbComm, "@M_AddDate", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_AddDate", DbType.String, M_AddDate)
            End If
            If M_EditDateVal Is Nothing Then
                db.AddInParameter(dbComm, "@M_EditDateVal", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_EditDateVal", DbType.String, M_EditDateVal)
            End If
            If M_EditDate Is Nothing Then
                db.AddInParameter(dbComm, "@M_EditDate", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_EditDate", DbType.String, M_EditDate)
            End If
            If Type3ID Is Nothing Then
                db.AddInParameter(dbComm, "@Type3ID", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@Type3ID", DbType.String, Type3ID)
            End If
            If M_AccountCheck Is Nothing Then
                db.AddInParameter(dbComm, "@M_AccountCheck", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_AccountCheck", DbType.String, M_AccountCheck)
            End If
            If InUser Is Nothing Then
                db.AddInParameter(dbComm, "@InUser", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@InUser", DbType.String, InUser)
            End If
            If M_IsSub Is Nothing Then
                db.AddInParameter(dbComm, "@M_IsSub", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_IsSub", DbType.String, M_IsSub)
            End If

            If M_SupplierNo Is Nothing Then
                db.AddInParameter(dbComm, "@M_SupplierNo", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_SupplierNo", DbType.String, M_SupplierNo)
            End If



            If M_TeSu Is Nothing Then
                db.AddInParameter(dbComm, "@M_TeSu", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_TeSu", DbType.String, M_TeSu)
            End If

            If SoureType Is Nothing Then
                db.AddInParameter(dbComm, "@SoureType", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@SoureType", DbType.Int32, SoureType)
            End If

            Dim FeatureList As New List(Of MaterialInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMaterialCodeListNew(reader))
                End While
                Return FeatureList
            End Using

        End Function
        ''' <summary>
        '''新增物料編碼
        ''' </summary>
        ''' <param name="objMaterial"></param>
        ''' <remarks></remarks>
        Public Function MaterialCode_AddNew(ByVal objMaterial As MaterialInfo) As Boolean
            ' Dim strM_Code As String = GetM_Code(objMaterial.M_Code)
            '檢查物料編碼編號是否已存在
            Dim objMaterialCode As MaterialInfo = MaterialCode_GetNew(objMaterial.M_Code)
            If objMaterialCode Is Nothing Then
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialCode_Add_New")
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objMaterial.M_Code)
                db.AddInParameter(dbComm, "@BlocCode", DbType.String, objMaterial.BlocCode)
                db.AddInParameter(dbComm, "@M_Name", DbType.String, objMaterial.M_Name)
                db.AddInParameter(dbComm, "@M_Gauge", DbType.String, objMaterial.M_Gauge)
                db.AddInParameter(dbComm, "@M_Unit", DbType.String, objMaterial.M_Unit)
                'db.AddInParameter(dbComm, "@M_Type", DbType.String, objMaterial.M_Type)
                db.AddInParameter(dbComm, "@M_Price", DbType.Double, objMaterial.M_Price)
                db.AddInParameter(dbComm, "@M_Currency", DbType.String, objMaterial.M_Currency)
                db.AddInParameter(dbComm, "@M_IsEnabled", DbType.Boolean, objMaterial.M_IsEnabled)
                db.AddInParameter(dbComm, "@M_Maker", DbType.String, objMaterial.M_Maker)
                db.AddInParameter(dbComm, "@M_Photo", DbType.Binary, objMaterial.M_Photo)
                db.AddInParameter(dbComm, "@M_AddDate", DbType.String, objMaterial.M_AddDate)
                db.AddInParameter(dbComm, "@M_Remark", DbType.String, objMaterial.M_Remark)
                db.AddInParameter(dbComm, "@Type3ID", DbType.String, objMaterial.Type3ID)
                db.AddInParameter(dbComm, "@M_AccountCheck", DbType.Boolean, objMaterial.M_AccountCheck)
                db.AddInParameter(dbComm, "InUser", DbType.String, objMaterial.InUser)
                db.AddInParameter(dbComm, "@M_IsSub", DbType.Boolean, objMaterial.M_IsSub)
                db.AddInParameter(dbComm, "@M_supplier", DbType.String, objMaterial.M_Supplier)
                db.AddInParameter(dbComm, "@M_supplierNo", DbType.String, objMaterial.M_SupplierNo)
                db.AddInParameter(dbComm, "@M_SaveKuCun", DbType.String, objMaterial.M_SaveKuCun)

                db.AddInParameter(dbComm, "@M_Weight", DbType.Double, objMaterial.M_Weight)
                db.AddInParameter(dbComm, "@M_WeightUnit", DbType.String, objMaterial.M_WeightUnit)
                db.AddInParameter(dbComm, "@M_CheckRemark", DbType.String, objMaterial.M_CheckRemark)

                '新的字段
                '2014/4/11
                db.AddInParameter(dbComm, "@MaterialProperty", DbType.Int32, objMaterial.MaterialProperty)
                db.AddInParameter(dbComm, "@SoureType", DbType.Int32, objMaterial.SoureType)
                db.AddInParameter(dbComm, "@ObtainingMode", DbType.Int32, objMaterial.ObtainingMode)
                db.AddInParameter(dbComm, "@MinStock", DbType.Decimal, objMaterial.MinStock)
                db.AddInParameter(dbComm, "@MaxStock", DbType.Decimal, objMaterial.MaxStock)
                db.AddInParameter(dbComm, "@SafetyStock", DbType.Decimal, objMaterial.SafetyStock)
                db.AddInParameter(dbComm, "@GrossWeight", DbType.Decimal, objMaterial.GrossWeight)
                db.AddInParameter(dbComm, "@NetWeight", DbType.Decimal, objMaterial.NetWeight)
                db.AddInParameter(dbComm, "@WeightUnit", DbType.String, objMaterial.WeightUnit)
                db.AddInParameter(dbComm, "@CustormerMaterial", DbType.String, objMaterial.CustormerMaterial)
                db.AddInParameter(dbComm, "@InVerfyMode", DbType.Int32, objMaterial.InVerfyMode)
                db.AddInParameter(dbComm, "@ProductVerifyMode", DbType.Int32, objMaterial.ProductVerifyMode)
                db.AddInParameter(dbComm, "@OutSourceExcessProportion", DbType.Decimal, objMaterial.OutSourceExcessProportion)
                db.AddInParameter(dbComm, "@OutSourceLessProportion", DbType.Decimal, objMaterial.OutSourceLessProportion)
                db.AddInParameter(dbComm, "@SalesExcessProportion", DbType.Decimal, objMaterial.SalesExcessProportion)
                db.AddInParameter(dbComm, "@SalesLessProportion", DbType.Decimal, objMaterial.SalesLessProportion)
                db.AddInParameter(dbComm, "@CompleteExcessProportion", DbType.Decimal, objMaterial.CompleteExcessProportion)
                db.AddInParameter(dbComm, "@ComoleteLessProportion", DbType.Decimal, objMaterial.ComoleteLessProportion)
                db.AddInParameter(dbComm, "@PlanStrategy", DbType.Int32, objMaterial.PlanStrategy)
                db.AddInParameter(dbComm, "@OrderStrategy", DbType.Int32, objMaterial.OrderStrategy)
                db.AddInParameter(dbComm, "@FixLeadTime", DbType.Int32, objMaterial.FixLeadTime)
                db.AddInParameter(dbComm, "@OrderInterval", DbType.Int32, objMaterial.OrderInterval)
                db.AddInParameter(dbComm, "@MinOrderQty", DbType.Decimal, objMaterial.MinOrderQty)
                db.AddInParameter(dbComm, "@MaxOrderQty", DbType.Decimal, objMaterial.MaxOrderQty)
                db.AddInParameter(dbComm, "@IncreasBatch", DbType.Decimal, objMaterial.IncreasBatch)
                db.AddInParameter(dbComm, "@ReOrderPoint", DbType.Decimal, objMaterial.ReOrderPoint)
                db.AddInParameter(dbComm, "@FixedQty", DbType.Decimal, objMaterial.FixedQty)
                db.AddInParameter(dbComm, "@DefaultProductionType", DbType.Int32, objMaterial.DefaultProductionType)
                db.AddInParameter(dbComm, "@DayConsumption", DbType.Decimal, objMaterial.DayConsumption)
                db.AddInParameter(dbComm, "@ValuationMethods", DbType.Int32, objMaterial.ValuationMethods)
                db.AddInParameter(dbComm, "@SaleUnitPrice", DbType.Decimal, objMaterial.SaleUnitPrice)
                db.AddInParameter(dbComm, "@OrderUnitPrice", DbType.Decimal, objMaterial.OrderUnitPrice)
                db.AddInParameter(dbComm, "@SaleSubjectNo", DbType.String, objMaterial.SaleSubjectNo)
                db.AddInParameter(dbComm, "@SaleCostSubjectNo", DbType.String, objMaterial.SaleCostSubjectNo)
                db.AddInParameter(dbComm, "@SaleInSubjectNo", DbType.String, objMaterial.SaleInSubjectNo)
                db.AddInParameter(dbComm, "@CostDiffSubjectNo", DbType.String, objMaterial.CostDiffSubjectNo)
                db.AddInParameter(dbComm, "@EscrowMaterialSubject", DbType.String, objMaterial.EscrowMaterialSubject)
                db.AddInParameter(dbComm, "@CostProject", DbType.Int32, objMaterial.CostProject)

                db.ExecuteNonQuery(dbComm)
                MaterialCode_AddNew = True
            Else
                MaterialCode_AddNew = False
            End If
        End Function
        ''' <summary>
        ''' 取得物料編碼資料
        ''' </summary>
        ''' <param name="M_Code"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MaterialCode_Get(ByVal M_Code As String) As MaterialInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialCode_Get")
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillMaterialCode(reader)
                End While
                Return Nothing

            End Using
        End Function
        ''' <summary>
        ''' 取得物料編碼資料
        ''' </summary>
        ''' <param name="M_Code"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MaterialCode_GetNew(ByVal M_Code As String) As MaterialInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialCode_Get")
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillMaterialCodeNew(reader)
                End While
                Return Nothing

            End Using
        End Function
        Public Function MaterialCode_GetDataTable(ByVal M_Code As String) As DataTable
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialCode_GetDataTable")

                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
                Return db.ExecuteDataSet(dbComm).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing

            End Try


        End Function

#Region "取得物料編碼資料列表,無圖像,不需要的字段請設為Nothing"
        ''' <summary>
        ''' 取得物料編碼資料列表,無圖像,不需要的字段請設為Nothing
        ''' </summary>
        ''' <param name="M_Code">物料編碼</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MaterialCode_GetList(ByVal M_Code As String) As List(Of MaterialInfo)
            Return MaterialCode_GetList(M_Code, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        End Function
        ''' <summary>
        ''' 取得物料編碼資料列表,無圖像,不需要的字段請設為Nothing
        ''' </summary>
        ''' <param name="M_Code">物料編碼</param>
        ''' <param name="M_Name">物料名稱,模糊查詢</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MaterialCode_GetList(ByVal M_Code As String, ByVal M_Name As String) As List(Of MaterialInfo)
            Return MaterialCode_GetList(M_Code, M_Name, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        End Function
        ''' <summary>
        ''' 取得物料編碼資料列表,無圖像,不需要的字段請設為Nothing
        ''' </summary>
        ''' <param name="M_Code">物料編碼</param>
        ''' <param name="M_Name">物料名稱,模糊查詢</param>
        ''' <param name="M_Gauge">規格,模糊查詢</param>    
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MaterialCode_GetList(ByVal M_Code As String, ByVal M_Name As String, ByVal M_Gauge As String) As List(Of MaterialInfo)
            Return MaterialCode_GetList(M_Code, M_Name, M_Gauge, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        End Function
        ''' <summary>
        ''' 取得物料編碼資料列表,無圖像,不需要的字段請設為Nothing
        ''' </summary>
        ''' <param name="M_Code">物料編碼</param>
        ''' <param name="M_Name">物料名稱,模糊查詢</param>
        ''' <param name="M_Gauge">規格,模糊查詢</param>    
        ''' <param name="Type3ID">物料類別編號</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MaterialCode_GetList(ByVal M_Code As String, ByVal M_Name As String, ByVal M_Gauge As String, ByVal Type3ID As String) As List(Of MaterialInfo)
            Return MaterialCode_GetList(M_Code, M_Name, M_Gauge, Type3ID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        End Function
        ''' <summary>
        ''' 取得物料編碼資料列表,無圖像,不需要的字段請設為Nothing
        ''' </summary>
        ''' <param name="M_Code">物料編碼</param>
        ''' <param name="M_Name">物料名稱,模糊查詢</param>
        ''' <param name="M_Gauge">規格,模糊查詢</param>
        ''' <param name="Type3ID">物料類別編號</param>
        ''' <param name="M_AccountCheck">會計部審核:0 為未審核 , 1為已審核,不需要則設置為Nothing</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MaterialCode_GetList(ByVal M_Code As String, ByVal M_Name As String, ByVal M_Gauge As String, ByVal Type3ID As String, ByVal M_AccountCheck As String) As List(Of MaterialInfo)
            Return MaterialCode_GetList(M_Code, M_Name, M_Gauge, Type3ID, M_AccountCheck, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        End Function
        ''' <summary>
        ''' 取得物料編碼資料列表,無圖像,不需要的字段請設為Nothing
        ''' </summary>
        ''' <param name="M_Code">物料編碼</param>
        ''' <param name="M_Name">物料名稱,模糊查詢</param>
        ''' <param name="M_Gauge">規格,模糊查詢</param>  
        ''' <param name="Type3ID">物料類別編號</param>
        ''' <param name="M_AccountCheck">會計部審核:0 為未審核 , 1為已審核,不需要則設置為Nothing</param>
        ''' <param name="M_IsEnabled">是否啟用</param>        
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MaterialCode_GetList(ByVal M_Code As String, ByVal M_Name As String, ByVal M_Gauge As String, ByVal Type3ID As String, ByVal M_AccountCheck As String, ByVal M_IsEnabled As String) As List(Of MaterialInfo)
            Return MaterialCode_GetList(M_Code, M_Name, M_Gauge, Type3ID, M_AccountCheck, M_IsEnabled, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        End Function
        ''' <summary>
        ''' 取得物料編碼資料列表,無圖像,不需要的字段請設為Nothing
        ''' </summary>
        ''' <param name="M_Code">物料編碼</param>
        ''' <param name="M_Name">物料名稱,模糊查詢</param>
        ''' <param name="M_Gauge">規格,模糊查詢</param>    
        ''' <param name="Type3ID">物料類別編號</param>
        ''' <param name="M_AccountCheck">會計部審核:0 為未審核 , 1為已審核,不需要則設置為Nothing</param>
        ''' <param name="M_IsEnabled">是否啟用</param>
        ''' <param name="M_AddDateVal">建立日期查詢符號: 等於,大於,小於等等 </param>
        ''' <param name="M_AddDate">建立日期</param>
        ''' <param name="M_EditDateVal"> 修改日期查詢符號: 等於,大於,小於等等 </param>
        ''' <param name="M_EditDate">修改日期</param>
        ''' <param name="InUser">操作員</param> 
        ''' <param name="M_IsSub">是否有子物料</param> 
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MaterialCode_GetList(ByVal M_Code As String, ByVal M_Name As String, ByVal M_Gauge As String, ByVal Type3ID As String, ByVal M_AccountCheck As String, ByVal M_IsEnabled As String, _
        ByVal M_AddDateVal As String, ByVal M_AddDate As String, ByVal M_EditDateVal As String, ByVal M_EditDate As String, ByVal InUser As String, ByVal M_IsSub As String, ByVal M_SupplierNo As String, ByVal M_TeSu As String) As List(Of MaterialInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialCode_GetList")
            If M_Code Is Nothing Then
                db.AddInParameter(dbComm, "@M_Code", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            End If
            If M_Name Is Nothing Then
                db.AddInParameter(dbComm, "@M_Name", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            End If
            If M_Gauge Is Nothing Then
                db.AddInParameter(dbComm, "@M_Gauge", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_Gauge", DbType.String, M_Gauge)
            End If
            If M_IsEnabled Is Nothing Then
                db.AddInParameter(dbComm, "@M_IsEnabled", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_IsEnabled", DbType.String, M_IsEnabled)
            End If
            If M_AddDateVal Is Nothing Then
                db.AddInParameter(dbComm, "@M_AddDateVal", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_AddDateVal", DbType.String, M_AddDateVal)
            End If
            If M_AddDate Is Nothing Then
                db.AddInParameter(dbComm, "@M_AddDate", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_AddDate", DbType.String, M_AddDate)
            End If
            If M_EditDateVal Is Nothing Then
                db.AddInParameter(dbComm, "@M_EditDateVal", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_EditDateVal", DbType.String, M_EditDateVal)
            End If
            If M_EditDate Is Nothing Then
                db.AddInParameter(dbComm, "@M_EditDate", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_EditDate", DbType.String, M_EditDate)
            End If
            If Type3ID Is Nothing Then
                db.AddInParameter(dbComm, "@Type3ID", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@Type3ID", DbType.String, Type3ID)
            End If
            If M_AccountCheck Is Nothing Then
                db.AddInParameter(dbComm, "@M_AccountCheck", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_AccountCheck", DbType.String, M_AccountCheck)
            End If
            If InUser Is Nothing Then
                db.AddInParameter(dbComm, "@InUser", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@InUser", DbType.String, InUser)
            End If
            If M_IsSub Is Nothing Then
                db.AddInParameter(dbComm, "@M_IsSub", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_IsSub", DbType.String, M_IsSub)
            End If

            If M_SupplierNo Is Nothing Then
                db.AddInParameter(dbComm, "@M_SupplierNo", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_SupplierNo", DbType.String, M_SupplierNo)
            End If



            If M_TeSu Is Nothing Then
                db.AddInParameter(dbComm, "@M_TeSu", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_TeSu", DbType.String, M_TeSu)
            End If

            Dim FeatureList As New List(Of MaterialInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMaterialCodeList(reader))
                End While
                Return FeatureList
            End Using

        End Function

#End Region

        Public Function MaterialCode_NoUseGetList(ByVal M_Code As String) As List(Of MaterialInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialCode_NoUseGetList")

            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)

            Dim FeatureList As New List(Of MaterialInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMaterialCodeList(reader))
                End While
                Return FeatureList
            End Using
        End Function
        ''' <summary>
        ''' 取得物料編碼資料列表,無圖像,不需要的字段請設為Nothing
        ''' </summary>
        ''' <param name="M_Code">物料編碼</param>
        ''' <param name="M_Name">物料名稱,模糊查詢</param>
        ''' <param name="M_Gauge">規格,模糊查詢</param>    
        ''' <param name="Type3ID">物料類別編號</param>
        ''' <param name="M_AccountCheck">會計部審核:0 為未審核 , 1為已審核,不需要則設置為Nothing</param>
        ''' <param name="M_IsEnabled">是否啟用</param>
        ''' <param name="M_AddDateVal">建立日期查詢符號: 等於,大於,小於等等 </param>
        ''' <param name="M_AddDate">建立日期</param>
        ''' <param name="M_EditDateVal"> 修改日期查詢符號: 等於,大於,小於等等 </param>
        ''' <param name="M_EditDate">修改日期</param>
        ''' <param name="InUser">操作員</param> 
        ''' <param name="M_IsSub">是否有子物料</param> 
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MaterialCode_GetListNew(ByVal M_Code As String, ByVal M_Name As String, ByVal M_Gauge As String, ByVal Type3ID As String, ByVal M_AccountCheck As String, ByVal M_IsEnabled As String, _
        ByVal M_AddDateVal As String, ByVal M_AddDate As String, ByVal M_EditDateVal As String, ByVal M_EditDate As String, ByVal InUser As String, ByVal M_IsSub As String, ByVal M_SupplierNo As String, ByVal M_TeSu As String) As List(Of MaterialInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialCode_GetList")
            If M_Code Is Nothing Then
                db.AddInParameter(dbComm, "@M_Code", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            End If
            If M_Name Is Nothing Then
                db.AddInParameter(dbComm, "@M_Name", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            End If
            If M_Gauge Is Nothing Then
                db.AddInParameter(dbComm, "@M_Gauge", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_Gauge", DbType.String, M_Gauge)
            End If
            If M_IsEnabled Is Nothing Then
                db.AddInParameter(dbComm, "@M_IsEnabled", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_IsEnabled", DbType.String, M_IsEnabled)
            End If
            If M_AddDateVal Is Nothing Then
                db.AddInParameter(dbComm, "@M_AddDateVal", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_AddDateVal", DbType.String, M_AddDateVal)
            End If
            If M_AddDate Is Nothing Then
                db.AddInParameter(dbComm, "@M_AddDate", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_AddDate", DbType.String, M_AddDate)
            End If
            If M_EditDateVal Is Nothing Then
                db.AddInParameter(dbComm, "@M_EditDateVal", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_EditDateVal", DbType.String, M_EditDateVal)
            End If
            If M_EditDate Is Nothing Then
                db.AddInParameter(dbComm, "@M_EditDate", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_EditDate", DbType.String, M_EditDate)
            End If
            If Type3ID Is Nothing Then
                db.AddInParameter(dbComm, "@Type3ID", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@Type3ID", DbType.String, Type3ID)
            End If
            If M_AccountCheck Is Nothing Then
                db.AddInParameter(dbComm, "@M_AccountCheck", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_AccountCheck", DbType.String, M_AccountCheck)
            End If
            If InUser Is Nothing Then
                db.AddInParameter(dbComm, "@InUser", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@InUser", DbType.String, InUser)
            End If
            If M_IsSub Is Nothing Then
                db.AddInParameter(dbComm, "@M_IsSub", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_IsSub", DbType.String, M_IsSub)
            End If

            If M_SupplierNo Is Nothing Then
                db.AddInParameter(dbComm, "@M_SupplierNo", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_SupplierNo", DbType.String, M_SupplierNo)
            End If



            If M_TeSu Is Nothing Then
                db.AddInParameter(dbComm, "@M_TeSu", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_TeSu", DbType.String, M_TeSu)
            End If

            Dim FeatureList As New List(Of MaterialInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMaterialCodeListNew(reader))
                End While
                Return FeatureList
            End Using

        End Function
        ''' <summary>
        ''' 更新物料編碼資料
        ''' </summary>
        ''' <param name="objMaterial"></param>
        ''' <remarks></remarks>
        Public Function MaterialCode_Update(ByVal objMaterial As MaterialInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialCode_Update")
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objMaterial.M_Code)
                db.AddInParameter(dbComm, "@BlocCode", DbType.String, objMaterial.BlocCode)
                db.AddInParameter(dbComm, "@M_Name", DbType.String, objMaterial.M_Name)
                db.AddInParameter(dbComm, "@M_Gauge", DbType.String, objMaterial.M_Gauge)
                db.AddInParameter(dbComm, "@M_Unit", DbType.String, objMaterial.M_Unit)
                db.AddInParameter(dbComm, "@M_Price", DbType.Double, objMaterial.M_Price)
                db.AddInParameter(dbComm, "@M_Currency", DbType.String, objMaterial.M_Currency)
                db.AddInParameter(dbComm, "@M_IsEnabled", DbType.Boolean, objMaterial.M_IsEnabled)
                db.AddInParameter(dbComm, "@M_Maker", DbType.String, objMaterial.M_Maker)
                db.AddInParameter(dbComm, "@M_Photo", DbType.Binary, objMaterial.M_Photo)
                'db.AddInParameter(dbComm, "@M_AddDate", DbType.Date, objMaterial.M_AddDate)
                db.AddInParameter(dbComm, "@M_EditDate", DbType.String, objMaterial.M_EditDate)
                db.AddInParameter(dbComm, "@M_Remark", DbType.String, objMaterial.M_Remark)
                db.AddInParameter(dbComm, "@Type3ID", DbType.String, objMaterial.Type3ID)
                db.AddInParameter(dbComm, "@M_AccountCheck", DbType.Boolean, objMaterial.M_AccountCheck)
                db.AddInParameter(dbComm, "InUser", DbType.String, objMaterial.InUser)
                db.AddInParameter(dbComm, "@M_IsSub", DbType.Boolean, objMaterial.M_IsSub)
                db.AddInParameter(dbComm, "@M_supplier", DbType.String, objMaterial.M_Supplier)
                db.AddInParameter(dbComm, "@M_supplierNo", DbType.String, objMaterial.M_SupplierNo)
                db.AddInParameter(dbComm, "@M_SaveKuCun", DbType.String, objMaterial.M_SaveKuCun)

                db.AddInParameter(dbComm, "@M_Weight", DbType.Double, objMaterial.M_Weight)
                db.AddInParameter(dbComm, "@M_WeightUnit", DbType.String, objMaterial.M_WeightUnit)
                db.AddInParameter(dbComm, "@M_CheckRemark", DbType.String, objMaterial.M_CheckRemark)

                db.ExecuteNonQuery(dbComm)
                MaterialCode_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MaterialCode_Update = False

            End Try

        End Function

        ''' <summary>
        ''' 更新物料編碼資料
        ''' </summary>
        ''' <param name="objMaterial"></param>
        ''' <remarks></remarks>
        Public Function MaterialCode_UpdateNew(ByVal objMaterial As MaterialInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialCode_Update_New")
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objMaterial.M_Code)
                db.AddInParameter(dbComm, "@BlocCode", DbType.String, objMaterial.BlocCode)
                db.AddInParameter(dbComm, "@M_Name", DbType.String, objMaterial.M_Name)
                db.AddInParameter(dbComm, "@M_Gauge", DbType.String, objMaterial.M_Gauge)
                db.AddInParameter(dbComm, "@M_Unit", DbType.String, objMaterial.M_Unit)
                db.AddInParameter(dbComm, "@M_Price", DbType.Double, objMaterial.M_Price)
                db.AddInParameter(dbComm, "@M_Currency", DbType.String, objMaterial.M_Currency)
                db.AddInParameter(dbComm, "@M_IsEnabled", DbType.Boolean, objMaterial.M_IsEnabled)
                db.AddInParameter(dbComm, "@M_Maker", DbType.String, objMaterial.M_Maker)
                db.AddInParameter(dbComm, "@M_Photo", DbType.Binary, objMaterial.M_Photo)
                'db.AddInParameter(dbComm, "@M_AddDate", DbType.Date, objMaterial.M_AddDate)
                db.AddInParameter(dbComm, "@M_EditDate", DbType.String, objMaterial.M_EditDate)
                db.AddInParameter(dbComm, "@M_Remark", DbType.String, objMaterial.M_Remark)
                db.AddInParameter(dbComm, "@Type3ID", DbType.String, objMaterial.Type3ID)
                db.AddInParameter(dbComm, "@M_AccountCheck", DbType.Boolean, objMaterial.M_AccountCheck)
                db.AddInParameter(dbComm, "InUser", DbType.String, objMaterial.InUser)
                db.AddInParameter(dbComm, "@M_IsSub", DbType.Boolean, objMaterial.M_IsSub)
                db.AddInParameter(dbComm, "@M_supplier", DbType.String, objMaterial.M_Supplier)
                db.AddInParameter(dbComm, "@M_supplierNo", DbType.String, objMaterial.M_SupplierNo)
                db.AddInParameter(dbComm, "@M_SaveKuCun", DbType.String, objMaterial.M_SaveKuCun)

                db.AddInParameter(dbComm, "@M_Weight", DbType.Double, objMaterial.M_Weight)
                db.AddInParameter(dbComm, "@M_WeightUnit", DbType.String, objMaterial.M_WeightUnit)
                db.AddInParameter(dbComm, "@M_CheckRemark", DbType.String, objMaterial.M_CheckRemark)

                '新的字段
                '2014/4/11
                db.AddInParameter(dbComm, "@MaterialProperty", DbType.Int32, objMaterial.MaterialProperty)
                db.AddInParameter(dbComm, "@SoureType", DbType.Int32, objMaterial.SoureType)
                db.AddInParameter(dbComm, "@ObtainingMode", DbType.Int32, objMaterial.ObtainingMode)
                db.AddInParameter(dbComm, "@MinStock", DbType.Decimal, objMaterial.MinStock)
                db.AddInParameter(dbComm, "@MaxStock", DbType.Decimal, objMaterial.MaxStock)
                db.AddInParameter(dbComm, "@SafetyStock", DbType.Decimal, objMaterial.SafetyStock)
                db.AddInParameter(dbComm, "@GrossWeight", DbType.Decimal, objMaterial.GrossWeight)
                db.AddInParameter(dbComm, "@NetWeight", DbType.Decimal, objMaterial.NetWeight)
                db.AddInParameter(dbComm, "@WeightUnit", DbType.String, objMaterial.WeightUnit)
                db.AddInParameter(dbComm, "@CustormerMaterial", DbType.String, objMaterial.CustormerMaterial)
                db.AddInParameter(dbComm, "@InVerfyMode", DbType.Int32, objMaterial.InVerfyMode)
                db.AddInParameter(dbComm, "@ProductVerifyMode", DbType.Int32, objMaterial.ProductVerifyMode)
                db.AddInParameter(dbComm, "@OutSourceExcessProportion", DbType.Decimal, objMaterial.OutSourceExcessProportion)
                db.AddInParameter(dbComm, "@OutSourceLessProportion", DbType.Decimal, objMaterial.OutSourceLessProportion)
                db.AddInParameter(dbComm, "@SalesExcessProportion", DbType.Decimal, objMaterial.SalesExcessProportion)
                db.AddInParameter(dbComm, "@SalesLessProportion", DbType.Decimal, objMaterial.SalesLessProportion)
                db.AddInParameter(dbComm, "@CompleteExcessProportion", DbType.Decimal, objMaterial.CompleteExcessProportion)
                db.AddInParameter(dbComm, "@ComoleteLessProportion", DbType.Decimal, objMaterial.ComoleteLessProportion)
                db.AddInParameter(dbComm, "@PlanStrategy", DbType.Int32, objMaterial.PlanStrategy)
                db.AddInParameter(dbComm, "@OrderStrategy", DbType.Int32, objMaterial.OrderStrategy)
                db.AddInParameter(dbComm, "@FixLeadTime", DbType.Int32, objMaterial.FixLeadTime)
                db.AddInParameter(dbComm, "@OrderInterval", DbType.Int32, objMaterial.OrderInterval)
                db.AddInParameter(dbComm, "@MinOrderQty", DbType.Decimal, objMaterial.MinOrderQty)
                db.AddInParameter(dbComm, "@MaxOrderQty", DbType.Decimal, objMaterial.MaxOrderQty)
                db.AddInParameter(dbComm, "@IncreasBatch", DbType.Decimal, objMaterial.IncreasBatch)
                db.AddInParameter(dbComm, "@ReOrderPoint", DbType.Decimal, objMaterial.ReOrderPoint)
                db.AddInParameter(dbComm, "@FixedQty", DbType.Decimal, objMaterial.FixedQty)
                db.AddInParameter(dbComm, "@DefaultProductionType", DbType.Int32, objMaterial.DefaultProductionType)
                db.AddInParameter(dbComm, "@DayConsumption", DbType.Decimal, objMaterial.DayConsumption)
                db.AddInParameter(dbComm, "@ValuationMethods", DbType.Int32, objMaterial.ValuationMethods)
                db.AddInParameter(dbComm, "@SaleUnitPrice", DbType.Decimal, objMaterial.SaleUnitPrice)
                db.AddInParameter(dbComm, "@OrderUnitPrice", DbType.Decimal, objMaterial.OrderUnitPrice)
                db.AddInParameter(dbComm, "@SaleSubjectNo", DbType.String, objMaterial.SaleSubjectNo)
                db.AddInParameter(dbComm, "@SaleCostSubjectNo", DbType.String, objMaterial.SaleCostSubjectNo)
                db.AddInParameter(dbComm, "@SaleInSubjectNo", DbType.String, objMaterial.SaleInSubjectNo)
                db.AddInParameter(dbComm, "@CostDiffSubjectNo", DbType.String, objMaterial.CostDiffSubjectNo)
                db.AddInParameter(dbComm, "@EscrowMaterialSubject", DbType.String, objMaterial.EscrowMaterialSubject)
                db.AddInParameter(dbComm, "@CostProject", DbType.Int32, objMaterial.CostProject)

                db.ExecuteNonQuery(dbComm)
                MaterialCode_UpdateNew = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MaterialCode_UpdateNew = False

            End Try

        End Function

#Region "更新產品名稱"
        Public Function MaterialCode_UpdateProduct(ByVal M_Code As String, ByVal M_Product As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialCode_UpdateProduct")
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
                db.AddInParameter(dbComm, "@M_Product", DbType.String, M_Product)
                db.ExecuteNonQuery(dbComm)
                MaterialCode_UpdateProduct = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MaterialCode_UpdateProduct = False

            End Try
        End Function
#End Region
        ''' <summary>
        ''' 更新物料編碼的報價，隻在報價單審核通時後調用此程序
        ''' </summary>
        ''' <param name="M_Code"></param>
        ''' <param name="M_Price"></param>
        ''' <param name="M_Currency"></param>
        ''' <param name="M_supplier"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MaterialCode_UpdatePrice(ByVal M_Code As String, ByVal M_Price As Single, ByVal M_Currency As String, ByVal M_Supplier As String, ByVal M_SupplierNo As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialCode_UpdatePrice")
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
                db.AddInParameter(dbComm, "@M_Price", DbType.Single, M_Price)
                db.AddInParameter(dbComm, "@M_Currency", DbType.String, M_Currency)
                db.AddInParameter(dbComm, "@M_Supplier", DbType.String, M_Supplier)
                db.AddInParameter(dbComm, "@M_SupplierNo", DbType.String, M_SupplierNo)


                db.ExecuteNonQuery(dbComm)
                MaterialCode_UpdatePrice = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MaterialCode_UpdatePrice = False

            End Try

        End Function
        ''' <summary>
        ''' 更新物料最後的採購日期 .在採購表中獲取
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MaterialCode_UpdateFinalDate(ByVal objinfo As MaterialInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialCode_UpdateFinalDate")

                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@M_FinalDate", DbType.String, objinfo.M_FinalDate)

                db.ExecuteNonQuery(dbComm)
                MaterialCode_UpdateFinalDate = True

            Catch ex As Exception
                MsgBox(ex.Message)
                MaterialCode_UpdateFinalDate = False
            End Try
        End Function


        ''' <summary>
        ''' 刪除物料編碼資料
        ''' </summary>
        ''' <param name="M_Code"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MaterialCode_Delete(ByVal M_Code As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialCode_Delete")
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
                db.ExecuteNonQuery(dbComm)
                MaterialCode_Delete = True
            Catch ex As Exception
                MaterialCode_Delete = False
            End Try
        End Function
        Friend Function FillMaterialCode(ByVal reader As IDataReader) As MaterialInfo
            '對應取得的數據,單一記錄時使用
            On Error Resume Next

            Dim objMaterialInfo As New MaterialInfo
            objMaterialInfo.M_Code = reader("M_Code").ToString
            objMaterialInfo.BlocCode = reader("BlocCode").ToString
            objMaterialInfo.M_Name = reader("M_Name").ToString
            objMaterialInfo.M_Gauge = reader("M_Gauge").ToString
            objMaterialInfo.M_Unit = reader("M_Unit").ToString
            objMaterialInfo.M_Supplier = reader("M_supplier").ToString
            objMaterialInfo.M_SupplierNo = reader("M_supplierNo").ToString

            objMaterialInfo.M_Price = reader("M_Price")
            objMaterialInfo.M_Currency = reader("M_Currency").ToString
            objMaterialInfo.M_IsEnabled = reader("M_IsEnabled").ToString
            objMaterialInfo.M_Maker = reader("M_Maker").ToString
            objMaterialInfo.M_SaveKuCun = reader("M_SaveKuCun").ToString
            If reader("M_Photo") Is DBNull.Value Then
                objMaterialInfo.M_Photo = Nothing
            Else
                objMaterialInfo.M_Photo = reader("M_Photo")
            End If
            If reader("M_AddDate") Is DBNull.Value Then
                objMaterialInfo.M_AddDate = Nothing
            Else
                objMaterialInfo.M_AddDate = CStr(reader("M_AddDate"))
            End If
            If reader("M_EditDate") Is DBNull.Value Then
                objMaterialInfo.M_EditDate = Nothing
            Else
                objMaterialInfo.M_EditDate = CStr(reader("M_EditDate"))
            End If
            'objMaterialInfo.M_AddDate = reader("M_AddDate").ToString
            'objMaterialInfo.M_EditDate = reader("M_EditDate").ToString
            objMaterialInfo.M_Remark = reader("M_Remark").ToString
            objMaterialInfo.Type3ID = reader("Type3ID").ToString
            objMaterialInfo.M_AccountCheck = reader("M_AccountCheck").ToString
            objMaterialInfo.InUser = reader("InUser").ToString
            objMaterialInfo.M_IsSub = reader("M_IsSub").ToString

            objMaterialInfo.M_WeightUnit = reader("M_WeightUnit").ToString
            objMaterialInfo.M_Weight = reader("M_Weight")

            If reader("M_FinalDate") Is DBNull.Value Then
                objMaterialInfo.M_FinalDate = Nothing
            Else
                objMaterialInfo.M_FinalDate = CStr(reader("M_FinalDate"))
            End If
            objMaterialInfo.Type3Name = reader("Type3Name").ToString
            objMaterialInfo.M_CheckRemark = reader("M_CheckRemark").ToString

            Return objMaterialInfo

        End Function
        Friend Function FillMaterialCodeList(ByVal reader As IDataReader) As MaterialInfo
            On Error Resume Next
            '對應取得的數據,多條記錄時使用，沒有顯示圖片，節省資源
            Dim objMaterialInfo As New MaterialInfo
            objMaterialInfo.M_Code = reader("M_Code").ToString
            objMaterialInfo.BlocCode = reader("BlocCode").ToString
            objMaterialInfo.M_Name = reader("M_Name").ToString
            objMaterialInfo.M_Gauge = reader("M_Gauge").ToString
            objMaterialInfo.M_Unit = reader("M_Unit").ToString
            objMaterialInfo.M_Price = reader("M_Price")
            objMaterialInfo.M_Currency = reader("M_Currency").ToString
            objMaterialInfo.M_IsEnabled = reader("M_IsEnabled").ToString
            objMaterialInfo.M_Maker = reader("M_Maker").ToString
            objMaterialInfo.M_Supplier = reader("M_supplier").ToString
            objMaterialInfo.M_SupplierNo = reader("M_supplierNo").ToString

            objMaterialInfo.M_SaveKuCun = reader("M_SaveKuCun").ToString
            'If reader("M_Photo") Is DBNull.Value Then
            '    objMaterialInfo.M_Photo = Nothing
            'Else
            '    objMaterialInfo.M_Photo = reader("M_Photo")
            'End If
            If reader("M_AddDate") Is DBNull.Value Then
                objMaterialInfo.M_AddDate = Nothing
            Else
                objMaterialInfo.M_AddDate = CStr(reader("M_AddDate"))
            End If
            If reader("M_EditDate") Is DBNull.Value Then
                objMaterialInfo.M_EditDate = Nothing
            Else
                objMaterialInfo.M_EditDate = CStr(reader("M_EditDate"))
            End If
            'objMaterialInfo.M_AddDate = reader("M_AddDate").ToString
            'objMaterialInfo.M_EditDate = reader("M_EditDate").ToString
            objMaterialInfo.M_Remark = reader("M_Remark").ToString
            objMaterialInfo.Type3ID = reader("Type3ID").ToString
            objMaterialInfo.M_AccountCheck = reader("M_AccountCheck").ToString
            objMaterialInfo.InUser = reader("InUser").ToString
            objMaterialInfo.M_IsSub = reader("M_IsSub").ToString
            objMaterialInfo.M_Qty = CInt(reader("M_Qty"))
            objMaterialInfo.U_Name = reader("U_Name").ToString
            objMaterialInfo.M_TeSu = reader("M_TeSu").ToString

            objMaterialInfo.M_WeightUnit = reader("M_WeightUnit").ToString
            objMaterialInfo.M_Weight = reader("M_Weight")

            If reader("M_FinalDate") Is DBNull.Value Then
                objMaterialInfo.M_FinalDate = Nothing
            Else
                objMaterialInfo.M_FinalDate = CStr(reader("M_FinalDate"))
            End If
            If reader("M_ChangeDate") Is DBNull.Value Then
                objMaterialInfo.M_ChangeDate = Nothing
            Else
                objMaterialInfo.M_ChangeDate = CStr(reader("M_ChangeDate"))
            End If
            objMaterialInfo.Type3Name = reader("Type3Name").ToString

            '------------------------------子物料類型信息

            objMaterialInfo.M_CodeSub = reader("M_CodeSub").ToString
            objMaterialInfo.M_Qty = CInt(reader("M_Qty").ToString)
            objMaterialInfo.M_CheckRemark = reader("M_CheckRemark").ToString

            objMaterialInfo.M_Product = reader("M_Product")
            Return objMaterialInfo
        End Function

        Friend Function FillMaterialCodeNew(ByVal reader As IDataReader) As MaterialInfo
            '對應取得的數據,單一記錄時使用
            On Error Resume Next

            Dim objMaterialInfo As New MaterialInfo
            objMaterialInfo.M_Code = reader("M_Code").ToString
            objMaterialInfo.BlocCode = reader("BlocCode").ToString
            objMaterialInfo.M_Name = reader("M_Name").ToString
            objMaterialInfo.M_Gauge = reader("M_Gauge").ToString
            objMaterialInfo.M_Unit = reader("M_Unit").ToString
            objMaterialInfo.M_Supplier = reader("M_supplier").ToString
            objMaterialInfo.M_SupplierNo = reader("M_supplierNo").ToString

            objMaterialInfo.M_Price = reader("M_Price")
            objMaterialInfo.M_Currency = reader("M_Currency").ToString
            objMaterialInfo.M_IsEnabled = reader("M_IsEnabled").ToString
            objMaterialInfo.M_Maker = reader("M_Maker").ToString
            objMaterialInfo.M_SaveKuCun = reader("M_SaveKuCun").ToString
            If reader("M_Photo") Is DBNull.Value Then
                objMaterialInfo.M_Photo = Nothing
            Else
                objMaterialInfo.M_Photo = reader("M_Photo")
            End If
            If reader("M_AddDate") Is DBNull.Value Then
                objMaterialInfo.M_AddDate = Nothing
            Else
                objMaterialInfo.M_AddDate = CStr(reader("M_AddDate"))
            End If
            If reader("M_EditDate") Is DBNull.Value Then
                objMaterialInfo.M_EditDate = Nothing
            Else
                objMaterialInfo.M_EditDate = CStr(reader("M_EditDate"))
            End If
            'objMaterialInfo.M_AddDate = reader("M_AddDate").ToString
            'objMaterialInfo.M_EditDate = reader("M_EditDate").ToString
            objMaterialInfo.M_Remark = reader("M_Remark").ToString
            objMaterialInfo.Type3ID = reader("Type3ID").ToString
            objMaterialInfo.M_AccountCheck = reader("M_AccountCheck").ToString
            objMaterialInfo.InUser = reader("InUser").ToString
            objMaterialInfo.M_IsSub = reader("M_IsSub").ToString

            objMaterialInfo.M_WeightUnit = reader("M_WeightUnit").ToString
            objMaterialInfo.M_Weight = reader("M_Weight")

            If reader("M_FinalDate") Is DBNull.Value Then
                objMaterialInfo.M_FinalDate = Nothing
            Else
                objMaterialInfo.M_FinalDate = CStr(reader("M_FinalDate"))
            End If
            objMaterialInfo.Type3Name = reader("Type3Name").ToString
            objMaterialInfo.M_CheckRemark = reader("M_CheckRemark").ToString

            '2014/4/11
            objMaterialInfo.MaterialProperty = reader("MaterialProperty").ToString
            objMaterialInfo.SoureType = reader("SoureType").ToString
            objMaterialInfo.ObtainingMode = reader("ObtainingMode").ToString
            objMaterialInfo.MinStock = reader("MinStock")
            objMaterialInfo.MaxStock = reader("MaxStock")
            objMaterialInfo.SafetyStock = reader("SafetyStock")
            objMaterialInfo.GrossWeight = reader("GrossWeight")
            objMaterialInfo.NetWeight = reader("NetWeight")
            objMaterialInfo.WeightUnit = reader("WeightUnit").ToString
            objMaterialInfo.CustormerMaterial = reader("CustormerMaterial").ToString
            objMaterialInfo.InVerfyMode = reader("InVerfyMode").ToString
            objMaterialInfo.ProductVerifyMode = reader("ProductVerifyMode").ToString
            objMaterialInfo.OutSourceExcessProportion = reader("OutSourceExcessProportion")
            objMaterialInfo.OutSourceLessProportion = reader("OutSourceLessProportion")
            objMaterialInfo.SalesExcessProportion = reader("SalesExcessProportion")
            objMaterialInfo.SalesLessProportion = reader("SalesLessProportion")
            objMaterialInfo.CompleteExcessProportion = reader("CompleteExcessProportion")
            objMaterialInfo.ComoleteLessProportion = reader("ComoleteLessProportion")
            objMaterialInfo.PlanStrategy = reader("PlanStrategy").ToString
            objMaterialInfo.OrderStrategy = reader("OrderStrategy").ToString
            objMaterialInfo.FixLeadTime = reader("FixLeadTime")
            objMaterialInfo.OrderInterval = reader("OrderInterval")
            objMaterialInfo.MinOrderQty = reader("MinOrderQty")
            objMaterialInfo.MaxOrderQty = reader("MaxOrderQty")
            objMaterialInfo.IncreasBatch = reader("IncreasBatch")
            objMaterialInfo.ReOrderPoint = reader("ReOrderPoint")
            objMaterialInfo.FixedQty = reader("FixedQty")
            objMaterialInfo.DefaultProductionType = reader("DefaultProductionType").ToString
            objMaterialInfo.DayConsumption = reader("DayConsumption").ToString
            objMaterialInfo.ValuationMethods = reader("ValuationMethods").ToString
            objMaterialInfo.SaleUnitPrice = reader("SaleUnitPrice")
            objMaterialInfo.OrderUnitPrice = reader("OrderUnitPrice")
            objMaterialInfo.SaleSubjectNo = reader("SaleSubjectNo").ToString
            objMaterialInfo.SaleCostSubjectNo = reader("SaleCostSubjectNo").ToString
            objMaterialInfo.SaleInSubjectNo = reader("SaleInSubjectNo").ToString
            objMaterialInfo.CostDiffSubjectNo = reader("CostDiffSubjectNo").ToString
            objMaterialInfo.EscrowMaterialSubject = reader("EscrowMaterialSubject").ToString
            objMaterialInfo.CostProject = reader("CostProject").ToString
            Return objMaterialInfo

        End Function
        Friend Function FillMaterialCodeListNew(ByVal reader As IDataReader) As MaterialInfo
            On Error Resume Next
            '對應取得的數據,多條記錄時使用，沒有顯示圖片，節省資源
            Dim objMaterialInfo As New MaterialInfo
            objMaterialInfo.M_Code = reader("M_Code").ToString
            objMaterialInfo.BlocCode = reader("BlocCode").ToString
            objMaterialInfo.M_Name = reader("M_Name").ToString
            objMaterialInfo.M_Gauge = reader("M_Gauge").ToString
            objMaterialInfo.M_Unit = reader("M_Unit").ToString
            objMaterialInfo.M_Price = reader("M_Price")
            objMaterialInfo.M_Currency = reader("M_Currency").ToString
            objMaterialInfo.M_IsEnabled = reader("M_IsEnabled").ToString
            objMaterialInfo.M_Maker = reader("M_Maker").ToString
            objMaterialInfo.M_Supplier = reader("M_supplier").ToString
            objMaterialInfo.M_SupplierNo = reader("M_supplierNo").ToString

            objMaterialInfo.M_SaveKuCun = reader("M_SaveKuCun").ToString
            'If reader("M_Photo") Is DBNull.Value Then
            '    objMaterialInfo.M_Photo = Nothing
            'Else
            '    objMaterialInfo.M_Photo = reader("M_Photo")
            'End If
            If reader("M_AddDate") Is DBNull.Value Then
                objMaterialInfo.M_AddDate = Nothing
            Else
                objMaterialInfo.M_AddDate = CStr(reader("M_AddDate"))
            End If
            If reader("M_EditDate") Is DBNull.Value Then
                objMaterialInfo.M_EditDate = Nothing
            Else
                objMaterialInfo.M_EditDate = CStr(reader("M_EditDate"))
            End If
            'objMaterialInfo.M_AddDate = reader("M_AddDate").ToString
            'objMaterialInfo.M_EditDate = reader("M_EditDate").ToString
            objMaterialInfo.M_Remark = reader("M_Remark").ToString
            objMaterialInfo.Type3ID = reader("Type3ID").ToString
            objMaterialInfo.M_AccountCheck = reader("M_AccountCheck").ToString
            objMaterialInfo.InUser = reader("InUser").ToString
            objMaterialInfo.M_IsSub = reader("M_IsSub").ToString
            objMaterialInfo.M_Qty = CInt(reader("M_Qty"))
            objMaterialInfo.U_Name = reader("U_Name").ToString
            objMaterialInfo.M_TeSu = reader("M_TeSu").ToString

            objMaterialInfo.M_WeightUnit = reader("M_WeightUnit").ToString
            objMaterialInfo.M_Weight = reader("M_Weight")

            If reader("M_FinalDate") Is DBNull.Value Then
                objMaterialInfo.M_FinalDate = Nothing
            Else
                objMaterialInfo.M_FinalDate = CStr(reader("M_FinalDate"))
            End If
            If reader("M_ChangeDate") Is DBNull.Value Then
                objMaterialInfo.M_ChangeDate = Nothing
            Else
                objMaterialInfo.M_ChangeDate = CStr(reader("M_ChangeDate"))
            End If
            objMaterialInfo.Type3Name = reader("Type3Name").ToString
            '2014/4/11
            objMaterialInfo.MaterialProperty = reader("MaterialProperty")
            objMaterialInfo.SoureType = reader("SoureType")
            objMaterialInfo.ObtainingMode = reader("ObtainingMode")
            objMaterialInfo.MinStock = reader("MinStock")
            objMaterialInfo.MaxStock = reader("MaxStock")
            objMaterialInfo.SafetyStock = reader("SafetyStock")
            objMaterialInfo.GrossWeight = reader("GrossWeight")
            objMaterialInfo.NetWeight = reader("NetWeight")
            objMaterialInfo.WeightUnit = reader("WeightUnit")
            objMaterialInfo.CustormerMaterial = reader("CustormerMaterial")
            objMaterialInfo.InVerfyMode = reader("InVerfyMode")
            objMaterialInfo.ProductVerifyMode = reader("ProductVerifyMode")
            objMaterialInfo.OutSourceExcessProportion = reader("OutSourceExcessProportion")
            objMaterialInfo.OutSourceLessProportion = reader("OutSourceLessProportion")
            objMaterialInfo.SalesExcessProportion = reader("SalesExcessProportion")
            objMaterialInfo.SalesLessProportion = reader("SalesLessProportion")
            objMaterialInfo.CompleteExcessProportion = reader("CompleteExcessProportion")
            objMaterialInfo.ComoleteLessProportion = reader("ComoleteLessProportion")
            objMaterialInfo.PlanStrategy = reader("PlanStrategy")
            objMaterialInfo.OrderStrategy = reader("OrderStrategy")
            objMaterialInfo.FixLeadTime = reader("FixLeadTime")
            objMaterialInfo.OrderInterval = reader("OrderInterval")
            objMaterialInfo.MinOrderQty = reader("MinOrderQty")
            objMaterialInfo.MaxOrderQty = reader("MaxOrderQty")
            objMaterialInfo.IncreasBatch = reader("IncreasBatch")
            objMaterialInfo.ReOrderPoint = reader("ReOrderPoint")
            objMaterialInfo.FixedQty = reader("FixedQty")
            objMaterialInfo.DefaultProductionType = reader("DefaultProductionType")
            objMaterialInfo.DayConsumption = reader("DayConsumption")
            objMaterialInfo.ValuationMethods = reader("ValuationMethods")
            objMaterialInfo.SaleUnitPrice = reader("SaleUnitPrice")
            objMaterialInfo.OrderUnitPrice = reader("OrderUnitPrice")
            objMaterialInfo.SaleSubjectNo = reader("SaleSubjectNo")
            objMaterialInfo.SaleCostSubjectNo = reader("SaleCostSubjectNo").ToString
            objMaterialInfo.SaleInSubjectNo = reader("SaleInSubjectNo").ToString
            objMaterialInfo.CostDiffSubjectNo = reader("CostDiffSubjectNo").ToString
            objMaterialInfo.EscrowMaterialSubject = reader("EscrowMaterialSubject").ToString
            objMaterialInfo.CostProject = reader("CostProject")

            '------------------------------子物料類型信息

            objMaterialInfo.M_CodeSub = reader("M_CodeSub").ToString
            objMaterialInfo.M_Qty = CInt(reader("M_Qty").ToString)
            objMaterialInfo.M_CheckRemark = reader("M_CheckRemark").ToString

            Return objMaterialInfo
        End Function

#Region "子物料"
        ''' <summary>
        ''' 子物料
        ''' </summary>
        ''' <param name="objInfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MaterialCodeSub_Add(ByVal objInfo As MaterialSubInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialCodeSub_Add")
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objInfo.M_Code)
                db.AddInParameter(dbComm, "@M_CodeSub", DbType.String, objInfo.M_CodeSub)
                db.AddInParameter(dbComm, "@M_Qty", DbType.Int16, objInfo.M_Qty)
                db.ExecuteNonQuery(dbComm)
                MaterialCodeSub_Add = True
            Catch ex As Exception
                MaterialCodeSub_Add = False
            End Try

        End Function

        Public Function MaterialCodeSub_Update(ByVal objInfo As MaterialSubInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialCodeSub_Update")
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objInfo.M_Code)
                db.AddInParameter(dbComm, "@M_CodeSub", DbType.String, objInfo.M_CodeSub)
                db.AddInParameter(dbComm, "@M_Qty", DbType.Int16, objInfo.M_Qty)
                db.ExecuteNonQuery(dbComm)
                MaterialCodeSub_Update = True
            Catch ex As Exception
                MaterialCodeSub_Update = False
            End Try

        End Function
        ''' <summary>
        ''' 導入指定物料的子物料資料
        ''' </summary>
        ''' <param name="M_Code"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MaterialCodeSub_GetList(ByVal M_Code As String) As List(Of MaterialInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialCodeSub_GetList")
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            Dim FeatureList As New List(Of MaterialInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMaterialCodeList(reader))
                End While
                Return FeatureList
            End Using
        End Function
        ''' <summary>
        ''' 導入指定物料的子物料資料
        ''' </summary>
        ''' <param name="M_Code"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MaterialCodeSub_GetList1(ByVal M_Code As String, ByVal M_CodeSub As String) As List(Of MaterialInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)

            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialCodeSub_GetList1")

            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)

            db.AddInParameter(dbComm, "@M_CodeSub", DbType.String, M_CodeSub)

            Dim FeatureList As New List(Of MaterialInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMaterialCodeList(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function MaterialCodeSub_Get(ByVal M_Code As String, ByVal M_CodeSub As String) As MaterialSubInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialCodeSub_Get")
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_CodeSub", DbType.String, M_CodeSub)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillMaterialSubInfo(reader)
                End While
                Return Nothing
            End Using
        End Function

        Friend Function FillMaterialSubInfo(ByVal reader As IDataReader) As MaterialSubInfo
            '對應取得的數據
            Dim objInfo As New MaterialSubInfo

            objInfo.AutoID = reader("AutoID").ToString
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_CodeSub = reader("M_CodeSub").ToString
            objInfo.M_Qty = CInt(reader("M_Qty").ToString)
            Return objInfo
        End Function

        Public Function MaterialCodeSub_Delete(ByVal M_Code As String, ByVal M_CodeSub As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialCodeSub_Delete")
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
                db.AddInParameter(dbComm, "@M_CodeSub", DbType.String, M_CodeSub)
                db.ExecuteNonQuery(dbComm)
                MaterialCodeSub_Delete = True
            Catch ex As Exception
                MaterialCodeSub_Delete = False
            End Try
        End Function

#End Region

#Region "針對倉庫自行變更物料單價" '默認採購后的價格

        Public Function MaterialPrice_Add(ByVal objinfo As MaterialInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialPrice_Add")
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@M_Price", DbType.Single, objinfo.M_Price)
                db.AddInParameter(dbComm, "@M_Currency", DbType.String, objinfo.M_Currency)
                db.AddInParameter(dbComm, "@M_ChangeDate", DbType.Date, objinfo.M_ChangeDate)

                db.ExecuteNonQuery(dbComm)
                MaterialPrice_Add = True
            Catch ex As Exception
                MaterialPrice_Add = False
            End Try
        End Function

        Public Function MaterialPrice_Update(ByVal objinfo As MaterialInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialPrice_Update")

                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@M_Price", DbType.Single, objinfo.M_Price)
                db.AddInParameter(dbComm, "@M_Currency", DbType.String, objinfo.M_Currency)
                db.AddInParameter(dbComm, "@M_ChangeDate", DbType.Date, objinfo.M_ChangeDate)

                db.ExecuteNonQuery(dbComm)

                MaterialPrice_Update = True
            Catch ex As Exception
                MaterialPrice_Update = False
            End Try
        End Function

        Public Function MaterialPrice_Delete(ByVal M_Code As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialPrice_Delete")
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)

                db.ExecuteNonQuery(dbComm)
                MaterialPrice_Delete = True
            Catch ex As Exception
                MaterialPrice_Delete = False
            End Try
        End Function

        Public Function MaterialPrice_GetList(ByVal M_Code As String, ByVal M_Name As String, ByVal M_Gauge As String) As List(Of MaterialInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialPrice_GetList")
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@M_Gauge", DbType.String, M_Gauge)
            Dim FeatureList As New List(Of MaterialInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMaterialCodeList(reader))
                End While
                Return FeatureList
            End Using
        End Function
#End Region

        ''暫時不用
        'Private Function GetM_Code(ByVal strCondition As String) As String
        '    '取得物料編碼
        '    Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
        '    Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialCode_GetM_Code")
        '    db.AddInParameter(dbComm, "@M_Code", DbType.String, strCondition & "%")
        '    Using reader As IDataReader = db.ExecuteReader(dbComm)
        '        While reader.Read
        '            Return reader
        '            GetM_Code = strCondition & Mid(100000000 + CLng(Mid(GetM_Code, 10) + 1), 10)
        '        End While
        '        Return Nothing
        '    End Using
        'End Function

        ''' <summary>
        ''' 新建立物料編碼ID
        ''' </summary>
        ''' <param name="strTopID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MaterialCode_GetID(ByVal strTopID As String) As String
            '取得物料編碼
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialCode_GetID")
            Dim tTemp As String = ""
            Dim i As Integer = 0
            db.AddInParameter(dbComm, "@M_Code", DbType.String, strTopID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    '00 000  000 000 000000長17位                    
                    tTemp = strTopID & Mid(1000000 + CLng(Mid(reader("M_Code"), 12) + 1), 2)
                    i = i + 1
                End While
                If i = 0 Then tTemp = strTopID & "000001"
            End Using
            MaterialCode_GetID = tTemp
        End Function



        ''2013-5-10 
        ''' <summary>
        ''' 產品編號自動增長
        ''' </summary>
        ''' <param name="M_Code"></param>
        ''' <param name="Type3ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MaterialCodeProd_Main_New_Get(ByVal M_Code As String, ByVal Type3ID As String) As String
            '取得物料編碼
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialCodeProd_Main_New_Get")
            Dim tTemp As String = ""

            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@Type3ID", DbType.String, Type3ID)

            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read                
                    tTemp = reader("M_Code").ToString
                End While
            End Using
            MaterialCodeProd_Main_New_Get = tTemp
        End Function


        ''' <summary>
        ''' 更新單價,不更新幣別
        ''' </summary>
        ''' <param name="M_Code"></param>
        ''' <param name="M_Price"></param>
        ''' <param name="M_Currency"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MaterialCode_UpdatePrice1(ByVal M_Code As String, ByVal M_Price As Single, ByVal M_Currency As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialCode_UpdatePrice1")
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
                db.AddInParameter(dbComm, "@M_Price", DbType.Single, M_Price)
                db.AddInParameter(dbComm, "@M_Currency", DbType.String, M_Currency)

                db.ExecuteNonQuery(dbComm)
                MaterialCode_UpdatePrice1 = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MaterialCode_UpdatePrice1 = False

            End Try

        End Function




        '-----------------------2013-11-6  姚駿新增--------------------------------
        ''' <summary>
        ''' 查詢庫存數量不為零的刀具出庫
        ''' </summary>
        ''' <param name="M_Code"></param>
        ''' <param name="M_Name"></param>
        ''' <param name="M_Gauge"></param>
        ''' <param name="Type3ID"></param>
        ''' <param name="M_SupplierNo"></param>
        ''' <param name="M_TeSu"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MaterialCode_GetKnifeList(ByVal M_Code As String, ByVal M_Name As String, ByVal M_Gauge As String, ByVal Type3ID As String, ByVal M_SupplierNo As String, ByVal M_TeSu As String, ByVal WH_ID As String) As List(Of MaterialInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialCode_GetKnifeList")
            If M_Code Is Nothing Then
                db.AddInParameter(dbComm, "@M_Code", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            End If
            If M_Name Is Nothing Then
                db.AddInParameter(dbComm, "@M_Name", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            End If
            If M_Gauge Is Nothing Then
                db.AddInParameter(dbComm, "@M_Gauge", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_Gauge", DbType.String, M_Gauge)
            End If



            If Type3ID Is Nothing Then
                db.AddInParameter(dbComm, "@Type3ID", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@Type3ID", DbType.String, Type3ID)
            End If

            If M_SupplierNo Is Nothing Then
                db.AddInParameter(dbComm, "@M_SupplierNo", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_SupplierNo", DbType.String, M_SupplierNo)
            End If



            If M_TeSu Is Nothing Then
                db.AddInParameter(dbComm, "@M_TeSu", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_TeSu", DbType.String, M_TeSu)
            End If

            If WH_ID Is Nothing Then
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            End If

            Dim FeatureList As New List(Of MaterialInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMaterialCodeList(reader))
                End While
                Return FeatureList
            End Using
        End Function
        '---------------------------------------------------------------------------

        ' 2014.4.28  劉祥松 
        Public Function MaterialCode_GetDataTable() As DataTable
            Dim strSql = "select M_Code,M_Name,M_Gauge,M_Unit from MaterialCode "
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetSqlStringCommand(strSql)
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

