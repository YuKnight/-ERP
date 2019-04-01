Imports System
Imports System.Data
Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Imports System.Windows.Forms

Namespace LFERP.Library.Product
    Public Class ProductBomController
        ''' <summary>
        ''' 獲取選擇物料的詳細及子物料
        ''' </summary>
        ''' <param name="M_Code"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetMaterialCodeSubList(ByVal M_Code As String) As List(Of ProductBomInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Product_GetMaterialCodeSub")
            db.AddInParameter(dbComm, "@root", DbType.String, M_Code)
            Dim FeatureList As New List(Of ProductBomInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMaterialCodeSub(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Friend Function FillMaterialCodeSub(ByVal reader As IDataReader) As ProductBomInfo
            On Error Resume Next
            '對應取得的數據
            Dim objInfo As New ProductBomInfo
            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_CodePID = reader("M_CodePID").ToString
            objInfo.PM_ID = reader("PM_ID").ToString
            objInfo.PM_Qty = CSng(reader("PM_Qty").ToString)
            'objInfo.M_Weight = CSng(reader("M_Weight").ToString)
            objInfo.M_Weight = reader("M_Weight")
            If reader("PM_Make") Is Nothing Then
                objInfo.PM_Make = False
            Else
                objInfo.PM_Make = reader("PM_Make")
            End If
            objInfo.PM_MakeRemark = reader("PM_MakeRemark").ToString
            If reader("PM_Check") Is Nothing Then
                objInfo.PM_Check = False
            Else
                objInfo.PM_Check = reader("PM_Check")
            End If
            objInfo.M_Supplier = reader("M_Supplier").ToString
            objInfo.M_SupplierNo = reader("M_SupplierNo").ToString

            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            objInfo.M_Price = CSng(reader("M_Price").ToString)

            objInfo.PM_LVL = CInt(reader("lvl").ToString)
            objInfo.PM_Key = reader("path").ToString & reader("M_Code").ToString & "."
            objInfo.PM_PID = reader("path").ToString

            Return objInfo
        End Function

        
        ''' <summary>
        ''' 增加子物料
        ''' </summary>
        ''' <param name="objProductBom"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductBom_Add(ByVal objProductBom As ProductBomInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Prod_Mounting_New_Add")
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objProductBom.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_ID", DbType.String, objProductBom.PM_ID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objProductBom.M_Code)
                db.AddInParameter(dbComm, "@M_CodePID", DbType.String, objProductBom.M_CodePID)
                db.AddInParameter(dbComm, "@PM_Qty", DbType.Single, objProductBom.PM_Qty)
                db.AddInParameter(dbComm, "@PM_MakeRemark", DbType.String, objProductBom.PM_MakeRemark)
                db.AddInParameter(dbComm, "@PM_Make", DbType.String, objProductBom.PM_Make)
                db.AddInParameter(dbComm, "@PM_Check", DbType.Boolean, objProductBom.PM_Check)
                db.AddInParameter(dbComm, "@M_Supplier", DbType.String, objProductBom.M_Supplier)
                db.AddInParameter(dbComm, "@M_SupplierNo", DbType.String, objProductBom.M_SupplierNo)
                db.AddInParameter(dbComm, "@PM_Key", DbType.String, objProductBom.PM_Key)
                db.AddInParameter(dbComm, "@PM_PID", DbType.String, objProductBom.PM_PID)
                db.AddInParameter(dbComm, "@PM_Lvl", DbType.Int16, objProductBom.PM_LVL)

                db.AddInParameter(dbComm, "@M_CodeType", DbType.String, objProductBom.M_CodeType)
                db.AddInParameter(dbComm, "@M_CodeMouldNO", DbType.String, objProductBom.M_CodeMouldNO)
                'db.AddInParameter(dbComm, "@M_Weight", DbType.Single, objProductBom.M_Weight)
                db.AddInParameter(dbComm, "@M_Weight", DbType.Decimal, objProductBom.M_Weight)

                db.ExecuteNonQuery(dbComm)
                ProductBom_Add = True
            Catch ex As Exception
                ProductBom_Add = False
                MsgBox(ex.Message)
            End Try


        End Function
        ''' <summary>
        ''' 修改子物料
        ''' </summary>
        ''' <param name="objProductBom"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductBom_Update(ByVal objProductBom As ProductBomInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Prod_Mounting_New_Update")
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objProductBom.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_ID", DbType.String, objProductBom.PM_ID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objProductBom.M_Code)
                db.AddInParameter(dbComm, "@M_CodePID", DbType.String, objProductBom.M_CodePID)
                db.AddInParameter(dbComm, "@PM_Qty", DbType.Single, objProductBom.PM_Qty)
                db.AddInParameter(dbComm, "@PM_MakeRemark", DbType.String, objProductBom.PM_MakeRemark)
                db.AddInParameter(dbComm, "@PM_Make", DbType.String, objProductBom.PM_Make)
                db.AddInParameter(dbComm, "@PM_Check", DbType.Boolean, objProductBom.PM_Check)
                db.AddInParameter(dbComm, "@M_Supplier", DbType.String, objProductBom.M_Supplier)
                db.AddInParameter(dbComm, "@M_SupplierNo", DbType.String, objProductBom.M_SupplierNo)
                db.AddInParameter(dbComm, "@PM_Key", DbType.String, objProductBom.PM_Key)
                db.AddInParameter(dbComm, "@PM_PID", DbType.String, objProductBom.PM_PID)
                db.AddInParameter(dbComm, "@PM_Lvl", DbType.Int16, objProductBom.PM_LVL)

                db.AddInParameter(dbComm, "@M_CodeType", DbType.String, objProductBom.M_CodeType)
                db.AddInParameter(dbComm, "@M_CodeMouldNO", DbType.String, objProductBom.M_CodeMouldNO)
                'db.AddInParameter(dbComm, "@M_Weight", DbType.Single, objProductBom.M_Weight)
                db.AddInParameter(dbComm, "@M_Weight", DbType.Decimal, objProductBom.M_Weight)

                db.ExecuteNonQuery(dbComm)
                ProductBom_Update = True
            Catch ex As Exception
                ProductBom_Update = False
                MsgBox(ex.Message)
            End Try


        End Function
        Public Function ProductBom_UpdateCheck(ByVal objProductBom As ProductBomInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Prod_Mounting_New_UpdateCheck")
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objProductBom.PM_M_Code)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objProductBom.M_Code)
                db.AddInParameter(dbComm, "@M_CodePID", DbType.String, objProductBom.M_CodePID)
                db.AddInParameter(dbComm, "@PM_Check", DbType.Boolean, objProductBom.PM_Check)

                db.ExecuteNonQuery(dbComm)
                ProductBom_UpdateCheck = True

            Catch ex As Exception
                ProductBom_UpdateCheck = False
                MsgBox(ex.Message)

            End Try
        End Function
        ''' <summary>
        ''' 刪除子物料
        ''' </summary>
        ''' <param name="PM_M_Code">產品編號,一定要有值</param>
        ''' <param name="PM_Key">要刪除的項目,如是所有,則設為Nothing</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductBom_Delete(ByVal PM_M_Code As String, ByVal PM_Key As String) As Boolean
            If PM_M_Code = Nothing Then
                '不能為空,否則會刪除所有數據
                ProductBom_Delete = False
                Exit Function
            End If
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Prod_Mounting_New_Delete")
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Key", DbType.String, PM_Key)
                db.ExecuteNonQuery(dbComm)
                ProductBom_Delete = True
            Catch ex As Exception
                ProductBom_Delete = False
            End Try
        End Function
        ''' <summary>
        ''' 導入配件資料
        ''' </summary>
        ''' <param name="PM_M_Code">產品編號</param>
        ''' <param name="M_Code">子物料編號</param>
        ''' <param name="M_CodePID">子物料父項ID</param>
        ''' <param name="PM_Key">子物料Key(樹狀生成,如:001.001.001.</param>
        ''' <param name="PM_PID">子物料Key的父項Key,如:001.001.</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductBom_GetList(ByVal PM_M_Code As String, ByVal M_Code As String, ByVal M_CodePID As String, ByVal PM_Key As String, ByVal PM_PID As String, ByVal PM_Check As String) As List(Of ProductBomInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Prod_Mounting_New_Get")
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_CodePID", DbType.String, M_CodePID)
            db.AddInParameter(dbComm, "@PM_Key", DbType.String, PM_Key)
            db.AddInParameter(dbComm, "@PM_PID", DbType.String, PM_PID)
            db.AddInParameter(dbComm, "@PM_Check", DbType.String, PM_Check)

            Dim FeatureList As New List(Of ProductBomInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductBom(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function ProductBom_GetList(ByVal PM_M_Code As String) As List(Of ProductBomInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Bom_M_Treee_Get")
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)

            Dim FeatureList As New List(Of ProductBomInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductBom(reader))
                End While
                Return FeatureList
            End Using
        End Function




        ''' <summary>
        ''' 導入配件資料
        ''' </summary>
        ''' <param name="PM_M_Code"></param>
        ''' <param name="M_Code"></param>
        ''' <param name="M_CodePID"></param>
        ''' <param name="PM_Lvl"></param>
        ''' <param name="PM_Key"></param>
        ''' <param name="PM_PID"></param>
        ''' <param name="PM_Check"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Prod_Mounting_New_GetList(ByVal PM_M_Code As String, ByVal M_Code As String, ByVal M_CodePID As String, ByVal PM_Lvl As Integer, ByVal PM_Key As String, ByVal PM_PID As String, ByVal PM_Check As String) As List(Of ProductBomInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Prod_Mounting_New_GetList")
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_CodePID", DbType.String, M_CodePID)
            db.AddInParameter(dbComm, "@PM_Lvl", DbType.String, PM_Lvl)
            db.AddInParameter(dbComm, "@PM_Key", DbType.String, PM_Key)
            db.AddInParameter(dbComm, "@PM_PID", DbType.String, PM_PID)
            db.AddInParameter(dbComm, "@PM_Check", DbType.String, PM_Check)

            Dim FeatureList As New List(Of ProductBomInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductBom(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Friend Function FillProductBom(ByVal reader As IDataReader) As ProductBomInfo
            On Error Resume Next
            '對應取得的數據
            Dim objInfo As New ProductBomInfo
            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_CodePID = reader("M_CodePID").ToString
            objInfo.PM_ID = reader("PM_ID").ToString
            objInfo.PM_Qty = CSng(reader("PM_Qty").ToString)

            If reader("PM_Make") Is Nothing Then
                objInfo.PM_Make = False
            Else
                objInfo.PM_Make = reader("PM_Make")
            End If
            objInfo.PM_MakeRemark = reader("PM_MakeRemark").ToString

            If reader("PM_Check") Is Nothing Then
                objInfo.PM_Check = False
            Else
                objInfo.PM_Check = reader("PM_Check")
            End If

            objInfo.M_Supplier = reader("M_Supplier").ToString
            objInfo.M_SupplierNo = reader("M_SupplierNo").ToString
            objInfo.M_SupplierName = reader("M_SupplierName").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            objInfo.M_Price = CSng(reader("M_Price").ToString)
            objInfo.PM_LVL = CInt(reader("PM_LVL").ToString)
            objInfo.PM_Key = reader("PM_Key").ToString
            objInfo.PM_PID = reader("PM_PID").ToString

            objInfo.M_CodeMouldNO = reader("M_CodeMouldNO").ToString
            objInfo.M_CodeType = reader("M_CodeType").ToString
            'objInfo.M_Weight = CSng(reader("M_Weight").ToString)
            objInfo.M_Weight = reader("M_Weight")

            Return objInfo
        End Function
    End Class
End Namespace

