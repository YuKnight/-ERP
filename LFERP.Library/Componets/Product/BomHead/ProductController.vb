Imports System
Imports System.Data
Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql

Namespace LFERP.Library.Product
    Public Class ProductController

        ''' <summary>
        ''' 獲取產品資料清單
        ''' </summary>
        ''' <param name="PM_M_Code">產品編號</param>
        ''' <param name="PM_CusterID">客戶代號</param>
        ''' <param name="PM_CusterNO">客戶編號</param>
        ''' <param name="Type3ID">類型代號</param>
        ''' <param name="M_AddDate">建立日期</param>
        ''' <param name="M_EditDate">修改日期</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Product_GetList(ByVal PM_M_Code As String, ByVal PM_CusterID As String, ByVal PM_CusterNO As String, ByVal Type3ID As String, _
        ByVal M_AddDate As String, ByVal M_EditDate As String, ByVal M_Gauge As String) As List(Of ProductInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Prod_Main_New_Get")
            If PM_M_Code Is Nothing Then
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            End If
            If PM_CusterID Is Nothing Then
                db.AddInParameter(dbComm, "@PM_CusterID", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@PM_CusterID", DbType.String, PM_CusterID)
            End If
            If PM_CusterNO Is Nothing Then
                db.AddInParameter(dbComm, "@PM_CusterNO", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@PM_CusterNO", DbType.String, PM_CusterNO)
            End If

            If M_AddDate Is Nothing Then
                db.AddInParameter(dbComm, "@PM_AddDate", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@PM_AddDate", DbType.String, M_AddDate)
            End If

            If M_EditDate Is Nothing Then
                db.AddInParameter(dbComm, "@PM_EditDate", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@PM_EditDate", DbType.String, M_EditDate)
            End If
            If Type3ID Is Nothing Then
                db.AddInParameter(dbComm, "@Type3ID", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@Type3ID", DbType.String, Type3ID)
            End If


            If M_Gauge Is Nothing Then
                db.AddInParameter(dbComm, "@M_Gauge", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_Gauge", DbType.String, M_Gauge)
            End If


            Dim FeatureList As New List(Of ProductInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductList(reader))
                End While
                Return FeatureList
            End Using

        End Function


        Public Function Product_GetList1(ByVal PM_M_Code As String, ByVal PM_CusterID As String, ByVal PM_CusterNO As String, ByVal Type3ID As String, _
        ByVal M_AddDate As String, ByVal M_EditDate As String, ByVal M_Gauge As String) As List(Of ProductInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Prod_Main_New_Get1")

            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_CusterID", DbType.String, PM_CusterID)
            db.AddInParameter(dbComm, "@PM_CusterNO", DbType.String, PM_CusterNO)
            db.AddInParameter(dbComm, "@PM_AddDate", DbType.String, M_AddDate)
            db.AddInParameter(dbComm, "@PM_EditDate", DbType.String, M_EditDate)
            db.AddInParameter(dbComm, "@Type3ID", DbType.String, Type3ID)
            db.AddInParameter(dbComm, "@M_Gauge", DbType.String, M_Gauge)

            Dim FeatureList As New List(Of ProductInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductList(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function Product_GetList2(ByVal PM_M_Code As String, ByVal PM_CusterID As String, ByVal PM_CusterNO As String, ByVal Type3ID As String, _
       ByVal M_AddDate As String, ByVal M_EditDate As String, ByVal M_Gauge As String, ByVal Prod_Check As String) As List(Of ProductInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Prod_Main_New_Get2")

            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_CusterID", DbType.String, PM_CusterID)
            db.AddInParameter(dbComm, "@PM_CusterNO", DbType.String, PM_CusterNO)
            db.AddInParameter(dbComm, "@PM_AddDate", DbType.String, M_AddDate)
            db.AddInParameter(dbComm, "@PM_EditDate", DbType.String, M_EditDate)
            db.AddInParameter(dbComm, "@Type3ID", DbType.String, Type3ID)
            db.AddInParameter(dbComm, "@M_Gauge", DbType.String, M_Gauge)
            db.AddInParameter(dbComm, "@Prod_Check", DbType.String, Prod_Check)

            Dim FeatureList As New List(Of ProductInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductList(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function Product_GetList3(ByVal PM_M_Code As String, ByVal PM_CusterID As String, ByVal PM_CusterNO As String, ByVal Type3ID As String, _
    ByVal M_AddDate As String, ByVal M_EditDate As String, ByVal M_Gauge As String, ByVal Prod_Check As String, ByVal PM_Hide As String) As List(Of ProductInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Prod_Main_New_Get3")

            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_CusterID", DbType.String, PM_CusterID)
            db.AddInParameter(dbComm, "@PM_CusterNO", DbType.String, PM_CusterNO)
            db.AddInParameter(dbComm, "@PM_AddDate", DbType.String, M_AddDate)
            db.AddInParameter(dbComm, "@PM_EditDate", DbType.String, M_EditDate)
            db.AddInParameter(dbComm, "@Type3ID", DbType.String, Type3ID)
            db.AddInParameter(dbComm, "@M_Gauge", DbType.String, M_Gauge)
            db.AddInParameter(dbComm, "@Prod_Check", DbType.String, Prod_Check)
            db.AddInParameter(dbComm, "@PM_Hide", DbType.String, PM_Hide)

            Dim FeatureList As New List(Of ProductInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductList(reader))
                End While
                Return FeatureList
            End Using

        End Function

        ''' <summary>
        ''' 姚駿
        ''' 2014-04-08
        ''' </summary>
        ''' <param name="PM_M_Code"></param>
        ''' <param name="PM_CusterID"></param>
        ''' <param name="PM_CusterNO"></param>
        ''' <param name="Type3ID"></param>
        ''' <param name="M_AddDate"></param>
        ''' <param name="M_EditDate"></param>
        ''' <param name="M_Gauge"></param>
        ''' <param name="Prod_Check"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Product_GetList4(ByVal PM_M_Code As String, ByVal PM_CusterID As String, ByVal PM_CusterNO As String, ByVal Type3ID As String, _
        ByVal M_AddDate As String, ByVal M_EditDate As String, ByVal M_Gauge As String, ByVal Prod_Check As String, ByVal WHID As String) As List(Of ProductInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Prod_Main_New_Get4")

            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_CusterID", DbType.String, PM_CusterID)
            db.AddInParameter(dbComm, "@PM_CusterNO", DbType.String, PM_CusterNO)
            db.AddInParameter(dbComm, "@PM_AddDate", DbType.String, M_AddDate)
            db.AddInParameter(dbComm, "@PM_EditDate", DbType.String, M_EditDate)
            db.AddInParameter(dbComm, "@Type3ID", DbType.String, Type3ID)
            db.AddInParameter(dbComm, "@M_Gauge", DbType.String, M_Gauge)
            db.AddInParameter(dbComm, "@Prod_Check", DbType.String, Prod_Check)
            db.AddInParameter(dbComm, "@WHID", DbType.String, WHID)

            Dim FeatureList As New List(Of ProductInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductList(reader))
                End While
                Return FeatureList
            End Using

        End Function

        ''' <summary>
        ''' 獲取指定物料編碼的產品資料共用清單
        ''' </summary>
        ''' <param name="M_Code"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Product_GetListCodeShare(ByVal M_Code As String) As List(Of ProductInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Prod_Main_New_GetCodeShare")
            If M_Code Is Nothing Then
                db.AddInParameter(dbComm, "@M_Code", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            End If
            Dim FeatureList As New List(Of ProductInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductList(reader))
                End While
                Return FeatureList
            End Using

        End Function
        ''' <summary>
        ''' 獲取單一產品資料
        ''' </summary>
        ''' <param name="PM_M_Code"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Product_Get(ByVal PM_M_Code As String) As ProductInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Prod_Main_New_Get")
          
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_CusterID", DbType.String, DBNull.Value)
            db.AddInParameter(dbComm, "@PM_CusterNO", DbType.String, DBNull.Value)
            db.AddInParameter(dbComm, "@PM_AddDate", DbType.String, DBNull.Value)
            db.AddInParameter(dbComm, "@PM_EditDate", DbType.String, DBNull.Value)
            db.AddInParameter(dbComm, "@Type3ID", DbType.String, DBNull.Value)
            db.AddInParameter(dbComm, "@M_Gauge", DbType.String, DBNull.Value)
         
            Dim FeatureList As New ProductInfo
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProduct(reader)
                End While
                Return Nothing

            End Using

        End Function
        Friend Function FillProduct(ByVal reader As IDataReader) As ProductInfo
            On Error Resume Next
            '對應取得的數據,多條記錄時使用，沒有顯示圖片，節省資源
            Dim objInfo As New ProductInfo
            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            objInfo.PM_CusterID = reader("PM_CusterID").ToString
            objInfo.PM_CusterNO = reader("PM_CusterNO").ToString

            If reader("PM_Weight") Is DBNull.Value Then
                objInfo.PM_Weight = 0
            Else
                objInfo.PM_Weight = CSng(reader("PM_Weight"))
            End If

            objInfo.PM_Action = reader("PM_Action").ToString
            objInfo.PM_Check = reader("PM_Check").ToString
            objInfo.Type3ID = reader("Type3ID").ToString
            objInfo.PM_Rank = reader("PM_Rank").ToString
            objInfo.PM_JiYu = reader("PM_JiYu").ToString
            objInfo.PM_BoWei = reader("PM_BoWei").ToString
            objInfo.PM_FangShui = reader("PM_FangShui").ToString
            objInfo.PM_ZhuHe = reader("PM_ZhuHe").ToString
            objInfo.PM_Dai = reader("PM_Dai").ToString
            objInfo.PM_Spare = reader("PM_Spare").ToString
            objInfo.PM_Price = reader("PM_Price").ToString
            objInfo.PM_DiNaZi = reader("PM_DiNaZi").ToString
            objInfo.PM_DiWaiZi = reader("PM_DiWaiZi").ToString

            If reader("PM_Image") Is DBNull.Value Then
                objInfo.PM_Image = Nothing
            Else
                objInfo.PM_Image = reader("PM_Image")
            End If
            If reader("PM_AddDate") Is DBNull.Value Then
                objInfo.PM_AddDate = Nothing
            Else
                objInfo.PM_AddDate = CStr(reader("PM_AddDate"))
            End If
            If reader("PM_EditDate") Is DBNull.Value Then
                objInfo.PM_EditDate = Nothing
            Else
                objInfo.PM_EditDate = CStr(reader("PM_EditDate"))
            End If
            objInfo.PM_Remark = reader("PM_Remark").ToString

            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.Type3Name = reader("Type3Name").ToString


            objInfo.Prod_Check = reader("Prod_Check")
            objInfo.Prod_CheckDate = reader("Prod_CheckDate")
            objInfo.Prod_CheckID = reader("Prod_CheckID").ToString
            objInfo.Prod_CheckName = reader("Prod_CheckName").ToString
            objInfo.M_IsEnabled = reader("M_IsEnabled")
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Currency = reader("M_Currency").ToString

            If reader("LossRate") Is DBNull.Value Then
                objInfo.LossRate = 0
            Else
                objInfo.LossRate = reader("LossRate")
            End If
            objInfo.PM_Name = reader("PM_Name")
            objInfo.PM_ColorCategory = reader("PM_ColorCategory")
            objInfo.PM_FProductCategory = reader("PM_FProductCategory")

            objInfo.QPN = reader("QPN")                     '2014-05-20  姚駿

            Return objInfo
        End Function
        Friend Function FillProductList(ByVal reader As IDataReader) As ProductInfo
            On Error Resume Next
            '對應取得的數據,多條記錄時使用，沒有顯示圖片，節省資源
            Dim objInfo As New ProductInfo
            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            objInfo.PM_CusterID = reader("PM_CusterID").ToString
            objInfo.PM_CusterNO = reader("PM_CusterNO").ToString

            If reader("PM_Weight") Is DBNull.Value Then
                objInfo.PM_Weight = 0
            Else
                objInfo.PM_Weight = CSng(reader("PM_Weight"))
            End If

            objInfo.PM_Action = reader("PM_Action").ToString
            objInfo.PM_Check = reader("PM_Check").ToString
            objInfo.Type3ID = reader("Type3ID").ToString
            objInfo.PM_Rank = reader("PM_Rank").ToString
            objInfo.PM_JiYu = reader("PM_JiYu").ToString
            objInfo.PM_BoWei = reader("PM_BoWei").ToString
            objInfo.PM_FangShui = reader("PM_FangShui").ToString
            objInfo.PM_ZhuHe = reader("PM_ZhuHe").ToString
            objInfo.PM_Dai = reader("PM_Dai").ToString
            objInfo.PM_Spare = reader("PM_Spare").ToString
            objInfo.PM_Price = reader("PM_Price").ToString
            objInfo.PM_DiNaZi = reader("PM_DiNaZi").ToString
            objInfo.PM_DiWaiZi = reader("PM_DiWaiZi").ToString
            'objInfo.PM_Image = Nothing
            If reader("PM_Image") Is DBNull.Value Then
                objInfo.PM_Image = Nothing
            Else
                objInfo.PM_Image = reader("PM_Image")
            End If

            If reader("PM_AddDate") Is DBNull.Value Then
                objInfo.PM_AddDate = Nothing
            Else
                objInfo.PM_AddDate = CStr(reader("PM_AddDate"))
            End If
            If reader("PM_EditDate") Is DBNull.Value Then
                objInfo.PM_EditDate = Nothing
            Else
                objInfo.PM_EditDate = CStr(reader("PM_EditDate"))
            End If
            objInfo.PM_Remark = reader("PM_Remark").ToString

            objInfo.M_Gauge = reader("M_Gauge").ToString
            '
            objInfo.Type3Name = reader("Type3Name").ToString
            objInfo.PM_ActionName = reader("PM_ActionName").ToString


            objInfo.Prod_Check = reader("Prod_Check")
            objInfo.Prod_CheckDate = reader("Prod_CheckDate")
            objInfo.Prod_CheckID = reader("Prod_CheckID").ToString
            objInfo.Prod_CheckName = reader("Prod_CheckName").ToString

            objInfo.M_IsEnabled = reader("M_IsEnabled")
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Currency = reader("M_Currency").ToString


            objInfo.PM_Hide = reader("PM_Hide")
            objInfo.PM_HideDate = reader("PM_HideDate")
            objInfo.PM_HideID = reader("PM_HideID").ToString
            objInfo.PM_HideName = reader("PM_HideName").ToString

            If reader("LossRate") Is DBNull.Value Then
                objInfo.LossRate = 0
            Else
                objInfo.LossRate = reader("LossRate")
            End If
            objInfo.PM_Name = reader("PM_Name")
            objInfo.PM_ColorCategory = reader("PM_ColorCategory")
            objInfo.PM_FProductCategory = reader("PM_FProductCategory")


            objInfo.QPN = reader("QPN")                     '2014-05-20  姚駿

            Return objInfo
        End Function
        ''' <summary>
        ''' 建立產品資料--主表
        ''' </summary>
        ''' <param name="objProduct"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Product_Add(ByVal objProduct As ProductInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Prod_Main_New_Add")
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objProduct.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_CusterID", DbType.String, objProduct.PM_CusterID)
                db.AddInParameter(dbComm, "@PM_CusterNO", DbType.String, objProduct.PM_CusterNO)
                db.AddInParameter(dbComm, "@PM_Weight", DbType.Single, objProduct.PM_Weight)
                db.AddInParameter(dbComm, "@PM_Action", DbType.String, objProduct.PM_Action)
                db.AddInParameter(dbComm, "@PM_Check", DbType.String, objProduct.PM_Check)
                db.AddInParameter(dbComm, "@Type3ID", DbType.String, objProduct.Type3ID)
                db.AddInParameter(dbComm, "@PM_Rank", DbType.String, objProduct.PM_Rank)
                db.AddInParameter(dbComm, "@PM_JiYu", DbType.String, objProduct.PM_JiYu)
                db.AddInParameter(dbComm, "@PM_BoWei", DbType.String, objProduct.PM_BoWei)
                db.AddInParameter(dbComm, "@PM_FangShui", DbType.String, objProduct.PM_FangShui)
                db.AddInParameter(dbComm, "@PM_ZhuHe", DbType.String, objProduct.PM_ZhuHe)
                db.AddInParameter(dbComm, "@PM_Dai", DbType.String, objProduct.PM_Dai)
                db.AddInParameter(dbComm, "@PM_Spare", DbType.Single, objProduct.PM_Spare)
                db.AddInParameter(dbComm, "@PM_Price", DbType.Single, objProduct.PM_Price)
                db.AddInParameter(dbComm, "@PM_DiNaZi", DbType.String, objProduct.PM_DiNaZi)
                db.AddInParameter(dbComm, "@PM_DiWaiZi", DbType.String, objProduct.PM_DiWaiZi)
                db.AddInParameter(dbComm, "@PM_AddDate", DbType.Date, objProduct.PM_AddDate)
                db.AddInParameter(dbComm, "@PM_EditDate", DbType.Date, objProduct.PM_EditDate)
                db.AddInParameter(dbComm, "@PM_Image", DbType.Binary, objProduct.PM_Image)
                db.AddInParameter(dbComm, "@PM_Remark", DbType.String, objProduct.PM_Remark)
                'M_Gauge
                db.AddInParameter(dbComm, "@M_Gauge", DbType.String, objProduct.M_Gauge)

                db.AddInParameter(dbComm, "@LossRate", DbType.Decimal, objProduct.LossRate)
                db.AddInParameter(dbComm, "@PM_Name", DbType.String, objProduct.PM_Name)
                db.AddInParameter(dbComm, "@PM_ColorCategory", DbType.String, objProduct.PM_ColorCategory)
                db.AddInParameter(dbComm, "@PM_FProductCategory", DbType.String, objProduct.PM_FProductCategory)

                db.ExecuteNonQuery(dbComm)
                Product_Add = True
            Catch ex As Exception
                Product_Add = False
                MsgBox(ex.Message)
            End Try

           
        End Function

        ''' <summary>
        ''' 新增QPN字段
        ''' 2014-05-22
        ''' 姚     駿
        ''' </summary>
        ''' <param name="objProduct"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Prod_Main_New_SampleAdd(ByVal objProduct As ProductInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Prod_Main_New_SampleAdd")
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objProduct.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_CusterID", DbType.String, objProduct.PM_CusterID)
                db.AddInParameter(dbComm, "@PM_CusterNO", DbType.String, objProduct.PM_CusterNO)
                db.AddInParameter(dbComm, "@PM_Weight", DbType.Single, objProduct.PM_Weight)
                db.AddInParameter(dbComm, "@PM_Action", DbType.String, objProduct.PM_Action)
                db.AddInParameter(dbComm, "@PM_Check", DbType.String, objProduct.PM_Check)
                db.AddInParameter(dbComm, "@Type3ID", DbType.String, objProduct.Type3ID)
                db.AddInParameter(dbComm, "@PM_Rank", DbType.String, objProduct.PM_Rank)
                db.AddInParameter(dbComm, "@PM_JiYu", DbType.String, objProduct.PM_JiYu)
                db.AddInParameter(dbComm, "@PM_BoWei", DbType.String, objProduct.PM_BoWei)
                db.AddInParameter(dbComm, "@PM_FangShui", DbType.String, objProduct.PM_FangShui)
                db.AddInParameter(dbComm, "@PM_ZhuHe", DbType.String, objProduct.PM_ZhuHe)
                db.AddInParameter(dbComm, "@PM_Dai", DbType.String, objProduct.PM_Dai)
                db.AddInParameter(dbComm, "@PM_Spare", DbType.Single, objProduct.PM_Spare)
                db.AddInParameter(dbComm, "@PM_Price", DbType.Single, objProduct.PM_Price)
                db.AddInParameter(dbComm, "@PM_DiNaZi", DbType.String, objProduct.PM_DiNaZi)
                db.AddInParameter(dbComm, "@PM_DiWaiZi", DbType.String, objProduct.PM_DiWaiZi)
                db.AddInParameter(dbComm, "@PM_AddDate", DbType.Date, objProduct.PM_AddDate)
                db.AddInParameter(dbComm, "@PM_EditDate", DbType.Date, objProduct.PM_EditDate)
                db.AddInParameter(dbComm, "@PM_Image", DbType.Binary, objProduct.PM_Image)
                db.AddInParameter(dbComm, "@PM_Remark", DbType.String, objProduct.PM_Remark)
                'M_Gauge
                db.AddInParameter(dbComm, "@M_Gauge", DbType.String, objProduct.M_Gauge)

                db.AddInParameter(dbComm, "@LossRate", DbType.Decimal, objProduct.LossRate)
                db.AddInParameter(dbComm, "@PM_Name", DbType.String, objProduct.PM_Name)
                db.AddInParameter(dbComm, "@PM_ColorCategory", DbType.String, objProduct.PM_ColorCategory)
                db.AddInParameter(dbComm, "@PM_FProductCategory", DbType.String, objProduct.PM_FProductCategory)

                db.AddInParameter(dbComm, "@QPN", DbType.String, objProduct.QPN)                  '2014-05-20  姚駿

                db.ExecuteNonQuery(dbComm)
                Prod_Main_New_SampleAdd = True
            Catch ex As Exception
                Prod_Main_New_SampleAdd = False
                MsgBox(ex.Message)
            End Try


        End Function

        ''' <summary>
        ''' 修改QPN字段
        ''' 2014-05-22
        ''' 姚     駿
        ''' </summary>
        ''' <param name="objProduct"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Prod_Main_New_SampleUpdate(ByVal objProduct As ProductInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Prod_Main_New_SampleUpdate")
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objProduct.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_CusterID", DbType.String, objProduct.PM_CusterID)
                db.AddInParameter(dbComm, "@PM_CusterNO", DbType.String, objProduct.PM_CusterNO)
                db.AddInParameter(dbComm, "@PM_Weight", DbType.Single, objProduct.PM_Weight)
                db.AddInParameter(dbComm, "@PM_Action", DbType.String, objProduct.PM_Action)
                db.AddInParameter(dbComm, "@PM_Check", DbType.String, objProduct.PM_Check)
                db.AddInParameter(dbComm, "@Type3ID", DbType.String, objProduct.Type3ID)
                db.AddInParameter(dbComm, "@PM_Rank", DbType.String, objProduct.PM_Rank)
                db.AddInParameter(dbComm, "@PM_JiYu", DbType.String, objProduct.PM_JiYu)
                db.AddInParameter(dbComm, "@PM_BoWei", DbType.String, objProduct.PM_BoWei)
                db.AddInParameter(dbComm, "@PM_FangShui", DbType.String, objProduct.PM_FangShui)
                db.AddInParameter(dbComm, "@PM_ZhuHe", DbType.String, objProduct.PM_ZhuHe)
                db.AddInParameter(dbComm, "@PM_Dai", DbType.String, objProduct.PM_Dai)
                db.AddInParameter(dbComm, "@PM_Spare", DbType.Single, objProduct.PM_Spare)
                db.AddInParameter(dbComm, "@PM_Price", DbType.Single, objProduct.PM_Price)
                db.AddInParameter(dbComm, "@PM_DiNaZi", DbType.String, objProduct.PM_DiNaZi)
                db.AddInParameter(dbComm, "@PM_DiWaiZi", DbType.String, objProduct.PM_DiWaiZi)
                db.AddInParameter(dbComm, "@PM_EditDate", DbType.Date, objProduct.PM_EditDate)
                db.AddInParameter(dbComm, "@PM_Image", DbType.Binary, objProduct.PM_Image)
                db.AddInParameter(dbComm, "@PM_Remark", DbType.String, objProduct.PM_Remark)

                db.AddInParameter(dbComm, "@M_Gauge", DbType.String, objProduct.M_Gauge)
                db.AddInParameter(dbComm, "@LossRate", DbType.Decimal, objProduct.LossRate)
                db.AddInParameter(dbComm, "@PM_Name", DbType.String, objProduct.PM_Name)
                db.AddInParameter(dbComm, "@PM_ColorCategory", DbType.String, objProduct.PM_ColorCategory)
                db.AddInParameter(dbComm, "@PM_FProductCategory", DbType.String, objProduct.PM_FProductCategory)

                db.AddInParameter(dbComm, "@QPN", DbType.String, objProduct.QPN)                  '2014-05-20  姚駿

                db.ExecuteNonQuery(dbComm)
                Prod_Main_New_SampleUpdate = True
            Catch ex As Exception
                Prod_Main_New_SampleUpdate = False
                MsgBox(ex.Message)
            End Try


        End Function


        ''' <summary>
        ''' 修改產品資料--主表
        ''' </summary>
        ''' <param name="objProduct"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Product_Update(ByVal objProduct As ProductInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Prod_Main_New_Update")
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objProduct.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_CusterID", DbType.String, objProduct.PM_CusterID)
                db.AddInParameter(dbComm, "@PM_CusterNO", DbType.String, objProduct.PM_CusterNO)
                db.AddInParameter(dbComm, "@PM_Weight", DbType.Single, objProduct.PM_Weight)
                db.AddInParameter(dbComm, "@PM_Action", DbType.String, objProduct.PM_Action)
                db.AddInParameter(dbComm, "@PM_Check", DbType.String, objProduct.PM_Check)
                db.AddInParameter(dbComm, "@Type3ID", DbType.String, objProduct.Type3ID)
                db.AddInParameter(dbComm, "@PM_Rank", DbType.String, objProduct.PM_Rank)
                db.AddInParameter(dbComm, "@PM_JiYu", DbType.String, objProduct.PM_JiYu)
                db.AddInParameter(dbComm, "@PM_BoWei", DbType.String, objProduct.PM_BoWei)
                db.AddInParameter(dbComm, "@PM_FangShui", DbType.String, objProduct.PM_FangShui)
                db.AddInParameter(dbComm, "@PM_ZhuHe", DbType.String, objProduct.PM_ZhuHe)
                db.AddInParameter(dbComm, "@PM_Dai", DbType.String, objProduct.PM_Dai)
                db.AddInParameter(dbComm, "@PM_Spare", DbType.Single, objProduct.PM_Spare)
                db.AddInParameter(dbComm, "@PM_Price", DbType.Single, objProduct.PM_Price)
                db.AddInParameter(dbComm, "@PM_DiNaZi", DbType.String, objProduct.PM_DiNaZi)
                db.AddInParameter(dbComm, "@PM_DiWaiZi", DbType.String, objProduct.PM_DiWaiZi)
                db.AddInParameter(dbComm, "@PM_EditDate", DbType.Date, objProduct.PM_EditDate)
                db.AddInParameter(dbComm, "@PM_Image", DbType.Binary, objProduct.PM_Image)
                db.AddInParameter(dbComm, "@PM_Remark", DbType.String, objProduct.PM_Remark)

                db.AddInParameter(dbComm, "@M_Gauge", DbType.String, objProduct.M_Gauge)
                db.AddInParameter(dbComm, "@LossRate", DbType.Decimal, objProduct.LossRate)
                db.AddInParameter(dbComm, "@PM_Name", DbType.String, objProduct.PM_Name)
                db.AddInParameter(dbComm, "@PM_ColorCategory", DbType.String, objProduct.PM_ColorCategory)
                db.AddInParameter(dbComm, "@PM_FProductCategory", DbType.String, objProduct.PM_FProductCategory)


                db.ExecuteNonQuery(dbComm)
                Product_Update = True
            Catch ex As Exception
                Product_Update = False
                MsgBox(ex.Message)
            End Try


        End Function
        ''' <summary>
        '''刪除產品資料
        ''' </summary>
        ''' <param name="PM_M_Code">產品編號</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Product_Delete(ByVal PM_M_Code As String) As Boolean
            If PM_M_Code = Nothing Then
                '不能為空,否則會刪除所有數據
                Product_Delete = False
                Exit Function
            End If
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Prod_Main_New_Delete")
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
                db.ExecuteNonQuery(dbComm)
                Product_Delete = True
            Catch ex As Exception
                Product_Delete = False
            End Try
        End Function



        ''--------------------------------------------
        Public Function Prod_Main_New_UpdateCheck(ByVal objProduct As ProductInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Prod_Main_New_UpdateCheck")
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objProduct.PM_M_Code)
                db.AddInParameter(dbComm, "@Prod_Check", DbType.Boolean, objProduct.Prod_Check)
                db.AddInParameter(dbComm, "@Prod_CheckDate", DbType.Date, objProduct.Prod_CheckDate)
                db.AddInParameter(dbComm, "@Prod_CheckID", DbType.String, objProduct.Prod_CheckID)

                db.ExecuteNonQuery(dbComm)
                Prod_Main_New_UpdateCheck = True
            Catch ex As Exception
                Prod_Main_New_UpdateCheck = False
                MsgBox(ex.Message)
            End Try
        End Function

        ''' <summary>
        ''' 產品資料隱藏
        ''' </summary>
        ''' <param name="objProduct"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Prod_Main_New_Hide(ByVal objProduct As ProductInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Prod_Main_New_Hide")
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objProduct.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Hide", DbType.Boolean, objProduct.PM_Hide)
                db.AddInParameter(dbComm, "@PM_HideDate", DbType.String, objProduct.PM_HideDate)
                db.AddInParameter(dbComm, "@PM_HideID", DbType.String, objProduct.PM_HideID)

                db.ExecuteNonQuery(dbComm)
                Prod_Main_New_Hide = True
            Catch ex As Exception
                Prod_Main_New_Hide = False
                MsgBox(ex.Message)
            End Try
        End Function
        Public Function Prod_Main_New_HideOnly(ByVal objProduct As ProductInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Prod_Main_New_HideOnly")
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objProduct.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Hide", DbType.Boolean, objProduct.PM_Hide)
                db.AddInParameter(dbComm, "@PM_HideDate", DbType.String, objProduct.PM_HideDate)
                db.AddInParameter(dbComm, "@PM_HideID", DbType.String, objProduct.PM_HideID)

                db.ExecuteNonQuery(dbComm)
                Prod_Main_New_HideOnly = True
            Catch ex As Exception
                Prod_Main_New_HideOnly = False
                MsgBox(ex.Message)
            End Try
        End Function


        '2014.4.25  取得所有產品編碼   劉祥松
        Public Function Prod_Main_New_GetList() As DataTable
            Dim ds As New DataSet
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Prod_Main_New_GetList")
            ds = db.ExecuteDataSet(dbComm)
            If ds.Tables.Count > 0 Then
                Return ds.Tables(0)
            Else
                Return Nothing
            End If
        End Function

    End Class
End Namespace

