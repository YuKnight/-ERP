Imports System.Windows.Forms

Namespace LFERP.Library.WareHouse.WareInventory
    Public Class WareInventoryMTController
#Region "導入選擇倉庫的物料類別"
        Public Sub LoadNodes(ByVal TreeView As TreeView, ByVal WH_ID As String)

            '清除原有數據
            TreeView.Nodes.Clear()
            '導入第一層類型
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInventory_GetMTList")
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Dim tNodes As New TreeNode
                    tNodes.Tag = reader("MaterialTypeID")
                    tNodes.Text = reader("MaterialTypeName")
                    TreeView.Nodes.Add(tNodes)
                End While
            End Using

            Dim iNodeNum As Integer = TreeView.GetNodeCount(False)
            Dim A, B, C As Integer
            For A = 0 To iNodeNum - 1
                '導入第二層類型 
                GetNodes1(A, TreeView.Nodes(A).Tag, TreeView, WH_ID)
                Dim Nodecount As Integer = TreeView.Nodes.Item(A).GetNodeCount(False)
                For B = 0 To Nodecount - 1
                    ''導入第三層類型
                    GetNodes2(A, B, TreeView.Nodes(A).Nodes(B).Tag, TreeView, WH_ID)
                    Dim NodecountC As Integer = TreeView.Nodes.Item(A).Nodes.Item(B).GetNodeCount(False)
                    For C = 0 To NodecountC - 1
                        GetNodes3(A, B, C, TreeView.Nodes(A).Nodes(B).Nodes(C).Tag, TreeView, WH_ID)
                    Next
                Next
            Next
        End Sub
        Private Sub GetNodes1(ByVal pID As Integer, ByVal MaterialTypeID As String, ByVal TreeView As TreeView, ByVal WH_ID As String)
            '導入第一層類型   
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInventory_GetMT1List")
            db.AddInParameter(dbComm, "@MaterialTypeID", DbType.String, MaterialTypeID)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Dim tNodes As New TreeNode
                    tNodes.Tag = reader("Type1ID")
                    tNodes.Text = reader("Type1Name")
                    TreeView.Nodes.Item(pID).Nodes.Add(tNodes)
                End While
            End Using
        End Sub
        Private Sub GetNodes2(ByVal pID As Integer, ByVal pID1 As Integer, ByVal Type1ID As String, ByVal TreeView As TreeView, ByVal WH_ID As String)
            '導入第二層類型   

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInventory_GetMT2List")
            db.AddInParameter(dbComm, "@Type1ID", DbType.String, Type1ID)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Dim tNodes As New TreeNode
                    tNodes.Tag = reader("Type2ID")
                    tNodes.Text = reader("Type2Name")
                    TreeView.Nodes.Item(pID).Nodes.Item(pID1).Nodes.Add(tNodes)
                End While
            End Using

        End Sub
        Private Sub GetNodes3(ByVal pID As Integer, ByVal pID1 As Integer, ByVal pID2 As Integer, ByVal Type2ID As String, ByVal TreeView As TreeView, ByVal WH_ID As String)
            '導入第三層類型
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInventory_GetMT3List")
            db.AddInParameter(dbComm, "@Type2ID", DbType.String, Type2ID)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)

            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Dim tNodes As New TreeNode
                    tNodes.Tag = reader("Type3ID")
                    tNodes.Text = reader("Type3Name")
                    TreeView.Nodes.Item(pID).Nodes.Item(pID1).Nodes.Item(pID2).Nodes.Add(tNodes)
                End While
            End Using
        End Sub
#End Region


#Region "依選擇的物料類別加載庫存數據"
        Public Function WareInventory_GetMaterial(ByVal Type3ID As String, ByVal WH_ID As String, ByVal M_CodeList As String) As List(Of WareInventoryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInventory_GetList")
            db.AddInParameter(dbComm, "@Type3ID", DbType.String, Type3ID)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@M_CodeList", DbType.String, M_CodeList)
            Dim FeatureList As New List(Of WareInventoryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInventoryList(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function WareInventory_GetListType123(ByVal Type1ID As String, ByVal Type2ID As String, ByVal Type3ID As String, ByVal WH_ID As String, ByVal M_CodeList As String) As List(Of WareInventoryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInventory_GetListType123")
            db.AddInParameter(dbComm, "@Type1ID", DbType.String, Type1ID)
            db.AddInParameter(dbComm, "@Type2ID", DbType.String, Type2ID)
            db.AddInParameter(dbComm, "@Type3ID", DbType.String, Type3ID)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@M_CodeList", DbType.String, M_CodeList)
            Dim FeatureList As New List(Of WareInventoryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInventoryList(reader))
                End While
                Return FeatureList
            End Using

        End Function

        ''  劉祥松 相對于WareInventory_GetListType123增加M_Product和WI_Address字段
        Public Function WareInventory_GetListType123New(ByVal Type1ID As String, ByVal Type2ID As String, ByVal Type3ID As String, ByVal WH_ID As String, ByVal M_CodeList As String) As List(Of WareInventoryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInventory_GetListType123New")
            db.AddInParameter(dbComm, "@Type1ID", DbType.String, Type1ID)
            db.AddInParameter(dbComm, "@Type2ID", DbType.String, Type2ID)
            db.AddInParameter(dbComm, "@Type3ID", DbType.String, Type3ID)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@M_CodeList", DbType.String, M_CodeList)
            Dim FeatureList As New List(Of WareInventoryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInventoryListNew(reader))
                End While
                Return FeatureList
            End Using

        End Function
        ''' <summary>
        ''' 月度庫存報表
        ''' </summary>
        ''' <param name="Type3ID"></param>
        ''' <param name="WH_ID"></param>
        ''' <param name="M_CodeList"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareInventoryBackup_GetMaterial(ByVal Type3ID As String, ByVal WH_ID As String, ByVal M_CodeList As String, ByVal O_Date1 As String, ByVal o_Date2 As String) As List(Of WareInventoryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInventoryBackup_GetList")
            db.AddInParameter(dbComm, "@Type3ID", DbType.String, Type3ID)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@M_CodeList", DbType.String, M_CodeList)
            db.AddInParameter(dbComm, "@O_Date1", DbType.String, O_Date1)
            db.AddInParameter(dbComm, "@O_Date2", DbType.String, o_Date2)
            Dim FeatureList As New List(Of WareInventoryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInventoryList(reader))
                End While
                Return FeatureList
            End Using

        End Function

        
        Friend Function FillWareInventoryList(ByVal reader As IDataReader) As WareInventoryInfo
            On Error Resume Next
            '對應取得的數據,多條記錄時使用，沒有顯示圖片，節省資源
            Dim objMaterialInfo As New WareInventoryInfo
            objMaterialInfo.M_Code = reader("M_Code").ToString
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
            objMaterialInfo.M_Remark = reader("M_Remark").ToString

            objMaterialInfo.M_AccountCheck = reader("M_AccountCheck").ToString
            objMaterialInfo.InUser = reader("InUser").ToString
            objMaterialInfo.M_IsSub = reader("M_IsSub").ToString
            objMaterialInfo.M_Qty = CInt(reader("M_Qty"))
            objMaterialInfo.U_Name = reader("U_Name").ToString

            objMaterialInfo.Type1ID = reader("Type1ID").ToString
            objMaterialInfo.Type1Name = reader("Type1Name").ToString
            objMaterialInfo.Type2ID = reader("Type2ID").ToString
            objMaterialInfo.Type2Name = reader("Type2Name").ToString
            objMaterialInfo.Type3ID = reader("Type3ID").ToString
            objMaterialInfo.Type3Name = reader("Type3Name").ToString
            objMaterialInfo.MaterialTypeID = reader("MaterialTypeID").ToString
            objMaterialInfo.MaterialTypeName = reader("MaterialTypeName").ToString

            objMaterialInfo.WI_Qty = Format(CDbl(reader("WI_Qty").ToString), "0.000") '2012-10-23

            objMaterialInfo.WI_SafeQty = Format(CDbl(reader("WI_SafeQty")), "0.000")  '' 安全庫存！
            '2014.5.5 鄭少釗新增
            objMaterialInfo.WI_MaxQty = Format(CDbl(reader("WI_MaxQty")), "0.000")  '' 最大庫存數量！


            objMaterialInfo.WH_ID = reader("WH_ID").ToString


            If reader("BackUpTime") Is DBNull.Value Then
                objMaterialInfo.BackUpTime = Nothing
            Else
                objMaterialInfo.BackUpTime = CStr(reader("BackUpTime"))
            End If

            objMaterialInfo.WH_Name = reader("WH_Name").ToString
            objMaterialInfo.WH_SName = reader("WH_SName").ToString
            objMaterialInfo.WH_AllName = reader("WH_SName").ToString & "-" & reader("WH_Name").ToString
            '---------------------------------------------------------------------

            If reader("InQty") Is DBNull.Value Then
                objMaterialInfo.InQty = 0
            Else
                objMaterialInfo.InQty = CDbl(reader("InQty"))
            End If
            If reader("OutQty") Is DBNull.Value Then
                objMaterialInfo.OutQty = 0
            Else
                objMaterialInfo.OutQty = CDbl(reader("OutQty").ToString)
            End If
            If reader("MVInQty") Is DBNull.Value Then
                objMaterialInfo.MVInQty = 0
            Else
                objMaterialInfo.MVInQty = CDbl(reader("MVInQty").ToString)
            End If
            If reader("MVOutQty") Is DBNull.Value Then
                objMaterialInfo.MVOutQty = 0
            Else
                objMaterialInfo.MVOutQty = CDbl(reader("MVOutQty").ToString)
            End If



            objMaterialInfo.WI_UserID = reader("WI_UserID").ToString

            If reader("WI_EditDate") Is DBNull.Value Then
                objMaterialInfo.WI_EditDate = Nothing
            Else
                objMaterialInfo.WI_EditDate = CStr(reader("WI_EditDate"))
            End If

            If reader("WO_Qty1") Is DBNull.Value Then
                objMaterialInfo.WO_Qty1 = 0
            Else
                objMaterialInfo.WO_Qty1 = CDbl(reader("WO_Qty1"))
            End If
            If reader("WO_Qty2") Is DBNull.Value Then
                objMaterialInfo.WO_Qty2 = 0
            Else
                objMaterialInfo.WO_Qty2 = CDbl(reader("WO_Qty2"))
            End If
            If reader("WO_Qty3") Is DBNull.Value Then
                objMaterialInfo.WO_Qty3 = 0
            Else
                objMaterialInfo.WO_Qty3 = CDbl(reader("WO_Qty3"))
            End If
            '---------------------------------------------------------------------
            objMaterialInfo.PM_JiYu = reader("PM_JiYu").ToString
            objMaterialInfo.NGMaterial = reader("NGMaterial").ToString
            objMaterialInfo.NGName = reader("NGName").ToString
            objMaterialInfo.NGType = reader("NGType").ToString
            objMaterialInfo.NGReamrk = reader("NGReamrk").ToString
            objMaterialInfo.M_Product = reader("M_Product")
            objMaterialInfo.WI_Address = reader("WI_Address")

            Return objMaterialInfo
        End Function

        ''  劉祥松 相對于WareInventory_GetListType123增加M_Product和WI_Address字段
        Friend Function FillWareInventoryListNew(ByVal reader As IDataReader) As WareInventoryInfo
            On Error Resume Next
            '對應取得的數據,多條記錄時使用，沒有顯示圖片，節省資源
            Dim objMaterialInfo As New WareInventoryInfo
            objMaterialInfo.M_Code = reader("M_Code").ToString
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
            objMaterialInfo.M_Remark = reader("M_Remark").ToString

            objMaterialInfo.M_AccountCheck = reader("M_AccountCheck").ToString
            objMaterialInfo.InUser = reader("InUser").ToString
            objMaterialInfo.M_IsSub = reader("M_IsSub").ToString
            objMaterialInfo.M_Qty = CInt(reader("M_Qty"))
            objMaterialInfo.U_Name = reader("U_Name").ToString

            objMaterialInfo.Type1ID = reader("Type1ID").ToString
            objMaterialInfo.Type1Name = reader("Type1Name").ToString
            objMaterialInfo.Type2ID = reader("Type2ID").ToString
            objMaterialInfo.Type2Name = reader("Type2Name").ToString
            objMaterialInfo.Type3ID = reader("Type3ID").ToString
            objMaterialInfo.Type3Name = reader("Type3Name").ToString
            objMaterialInfo.MaterialTypeID = reader("MaterialTypeID").ToString
            objMaterialInfo.MaterialTypeName = reader("MaterialTypeName").ToString

            objMaterialInfo.WI_Qty = Format(CDbl(reader("WI_Qty").ToString), "0.000") '2012-10-23

            objMaterialInfo.WI_SafeQty = Format(CDbl(reader("WI_SafeQty")), "0.000")  '' 安全庫存！
            '2014.5.5 鄭少釗新增
            objMaterialInfo.WI_MaxQty = Format(CDbl(reader("WI_MaxQty")), "0.000")  '' 最大庫存數量！
            objMaterialInfo.WH_ID = reader("WH_ID").ToString


            If reader("BackUpTime") Is DBNull.Value Then
                objMaterialInfo.BackUpTime = Nothing
            Else
                objMaterialInfo.BackUpTime = CStr(reader("BackUpTime"))
            End If

            objMaterialInfo.WH_Name = reader("WH_Name").ToString
            objMaterialInfo.WH_SName = reader("WH_SName").ToString
            objMaterialInfo.WH_AllName = reader("WH_SName").ToString & "-" & reader("WH_Name").ToString
            '---------------------------------------------------------------------

            If reader("InQty") Is DBNull.Value Then
                objMaterialInfo.InQty = 0
            Else
                objMaterialInfo.InQty = CDbl(reader("InQty"))
            End If
            If reader("OutQty") Is DBNull.Value Then
                objMaterialInfo.OutQty = 0
            Else
                objMaterialInfo.OutQty = CDbl(reader("OutQty").ToString)
            End If
            If reader("MVInQty") Is DBNull.Value Then
                objMaterialInfo.MVInQty = 0
            Else
                objMaterialInfo.MVInQty = CDbl(reader("MVInQty").ToString)
            End If
            If reader("MVOutQty") Is DBNull.Value Then
                objMaterialInfo.MVOutQty = 0
            Else
                objMaterialInfo.MVOutQty = CDbl(reader("MVOutQty").ToString)
            End If



            objMaterialInfo.WI_UserID = reader("WI_UserID").ToString

            If reader("WI_EditDate") Is DBNull.Value Then
                objMaterialInfo.WI_EditDate = Nothing
            Else
                objMaterialInfo.WI_EditDate = CStr(reader("WI_EditDate"))
            End If

            If reader("WO_Qty1") Is DBNull.Value Then
                objMaterialInfo.WO_Qty1 = 0
            Else
                objMaterialInfo.WO_Qty1 = CDbl(reader("WO_Qty1"))
            End If
            If reader("WO_Qty2") Is DBNull.Value Then
                objMaterialInfo.WO_Qty2 = 0
            Else
                objMaterialInfo.WO_Qty2 = CDbl(reader("WO_Qty2"))
            End If
            If reader("WO_Qty3") Is DBNull.Value Then
                objMaterialInfo.WO_Qty3 = 0
            Else
                objMaterialInfo.WO_Qty3 = CDbl(reader("WO_Qty3"))
            End If
            '---------------------------------------------------------------------
            objMaterialInfo.PM_JiYu = reader("PM_JiYu").ToString
            objMaterialInfo.NGMaterial = reader("NGMaterial").ToString
            objMaterialInfo.NGName = reader("NGName").ToString
            objMaterialInfo.NGType = reader("NGType").ToString
            objMaterialInfo.NGReamrk = reader("NGReamrk").ToString

            objMaterialInfo.M_Product = reader("M_Product")
            objMaterialInfo.WI_Address = reader("WI_Address")

            Return objMaterialInfo
        End Function
#End Region



        ''' <summary>
        ''' 查詢WareInventory單條記錄
        ''' </summary>
        ''' <param name="M_Code"></param>
        ''' <param name="WH_ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareInventory_GetSub(ByVal M_Code As String, ByVal WH_ID As String) As WareInventoryInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInventory_GetSub")
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillWareInventorySub(reader)
                End While
                Return Nothing
            End Using
        End Function
        Public Function WareInventory_GetHalt(ByVal WH_ID As String, ByVal Date1 As String, ByVal Date2 As String) As List(Of WareInventoryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInventory_GetHalt")
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@Date1", DbType.String, Date1)
            db.AddInParameter(dbComm, "@Date2", DbType.String, Date2)
            Dim FeatureList As New List(Of WareInventoryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInventoryList(reader))
                End While
                Return FeatureList
            End Using
        End Function
        ''' <summary>
        '''對應取得的數據--WareInventoryGetSub
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Function FillWareInventorySub(ByVal reader As IDataReader) As WareInventoryInfo

            On Error Resume Next
            Dim objInfo As New WareInventoryInfo
            Dim sngInputQty, sngMoveInQty, sngWSSplitInQty, sngWESplitInQty As Single
            Dim sngOutQty, sngWSSplitOutQty, sngMoveOutQty, sngWESplitOutQty As Single

            objInfo.WH_ID = reader("WH_ID").ToString
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            objInfo.M_Price = reader("M_Price").ToString

            objInfo.M_Currency = reader("M_Currency").ToString

            objInfo.M_Maker = reader("M_Maker").ToString

            objInfo.M_AddDate = reader("M_AddDate").ToString

            objInfo.M_EditDate = reader("M_EditDate").ToString

            objInfo.M_Remark = reader("M_Remark").ToString

            objInfo.Type3ID = reader("Type3ID").ToString

            objInfo.M_AccountCheck = reader("M_AccountCheck")

            objInfo.M_IsEnabled = reader("M_IsEnabled")

            objInfo.InUser = reader("InUser").ToString

            objInfo.M_Supplier = reader("M_Supplier").ToString

            objInfo.M_SupplierNo = reader("M_SupplierNo").ToString

            objInfo.M_SaveKuCun = reader("M_SaveKuCun").ToString

            If reader("WI_Qty") Is DBNull.Value Then
                objInfo.WI_Qty = 0
            Else
                objInfo.WI_Qty = Format(CDbl(reader("WI_Qty").ToString), "0.000")
            End If

            objInfo.WI_SafeQty = CDbl(reader("WI_SafeQty").ToString)  '' 安全庫存！

            objInfo.Type3Name = reader("Type3Name").ToString

            objInfo.Type2Name = reader("Type2Name").ToString

            objInfo.Type1Name = reader("Type1Name").ToString

            objInfo.MaterialTypeID = reader("MaterialTypeID").ToString

            objInfo.Type1ID = reader("Type1ID").ToString

            objInfo.Type2ID = reader("Type2ID").ToString

            objInfo.MaterialTypeName = reader("MaterialTypeName").ToString

            objInfo.WH_Name = reader("WH_Name").ToString
            objInfo.WH_AllName = reader("WH_SName").ToString & "-" & reader("WH_Name").ToString

            objInfo.WI_UserID = reader("WI_UserID").ToString

            If reader("WI_EditDate") Is DBNull.Value Then
                objInfo.WI_EditDate = Nothing
            Else
                objInfo.WI_EditDate = CStr(reader("WI_EditDate"))
            End If

            If reader("BeginQty") Is DBNull.Value Then
                objInfo.BeginQty = 0
            Else
                objInfo.BeginQty = CDbl(reader("BeginQty"))
            End If
            If reader("InputQty") Is DBNull.Value Then
                sngInputQty = 0
            Else
                sngInputQty = CDbl(reader("InputQty"))
            End If
            If reader("MoveInQty") Is DBNull.Value Then
                sngMoveInQty = 0
            Else
                sngMoveInQty = CDbl(reader("MoveInQty"))
            End If
            If reader("WSSplitInQty") Is DBNull.Value Then
                sngWSSplitInQty = 0
            Else
                sngWSSplitInQty = CDbl(reader("WSSplitInQty"))
            End If
            If reader("WESplitInQty") Is DBNull.Value Then
                sngWESplitInQty = 0
            Else
                sngWESplitInQty = CDbl(reader("WESplitInQty"))
            End If

            If reader("OutQty") Is DBNull.Value Then
                sngOutQty = 0
            Else
                sngOutQty = CDbl(reader("OutQty"))
            End If
            If reader("MoveOutQty") Is DBNull.Value Then
                sngMoveOutQty = 0
            Else
                sngMoveOutQty = CDbl(reader("MoveOutQty"))
            End If
            If reader("WSSplitOutQty") Is DBNull.Value Then
                sngWSSplitOutQty = 0
            Else
                sngWSSplitOutQty = CDbl(reader("WSSplitOutQty"))
            End If
            If reader("WESplitOutQty") Is DBNull.Value Then
                sngWESplitOutQty = 0
            Else
                sngWESplitOutQty = CDbl(reader("WESplitOutQty"))
            End If

            objInfo.AllInQty = sngInputQty + sngMoveInQty + sngWSSplitInQty + sngWESplitInQty
            objInfo.AllOutQty = sngOutQty + sngMoveOutQty + sngWSSplitOutQty + sngWESplitOutQty

            If reader("BeginDate") Is DBNull.Value Then
                objInfo.BeginDate = Nothing
            Else
                objInfo.BeginDate = reader("BeginDate").ToString
            End If
            If reader("EndDate") Is DBNull.Value Then
                objInfo.EndDate = Nothing
            Else
                objInfo.EndDate = reader("EndDate").ToString
            End If

            objInfo.NO_ReQty = reader("NO_ReQty")
            objInfo.PM_JiYu = reader("PM_JiYu").ToString


            '---------------- 2013-11-6姚駿新增------------------------------------
            If reader("WI_SQty") Is DBNull.Value Then
                objInfo.WI_SQty = 0
            Else
                objInfo.WI_SQty = Format(CDbl(reader("WI_SQty").ToString), "0.000")
            End If

            If reader("WI_SReQty") Is DBNull.Value Then
                objInfo.WI_SReQty = 0
            Else
                objInfo.WI_SReQty = Format(CDbl(reader("WI_SReQty").ToString), "0.000")
            End If
            '-----------------------------------------------------------------------

            '_PM_JiYu
            Return objInfo
        End Function

        Public Function WareInventory_GetList(ByVal M_Code As String, ByVal WH_ID As String) As List(Of WareInventoryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInventory_GetList1")

            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)

            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)

            Dim FeatureList As New List(Of WareInventoryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInventorySub(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function WareInventory_GetList2(ByVal M_Code As String, ByVal WH_ID As String) As List(Of WareInventoryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInventory_GetList2")

            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)

            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)

            Dim FeatureList As New List(Of WareInventoryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInventorySub(reader))
                End While
                Return FeatureList
            End Using
        End Function
        ''' <summary>
        ''' 修改與新增倉庫庫存中數量
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareInventory_UpdateA(ByVal objinfo As WareInventoryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInventory_UpdateA")

                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, objinfo.WH_ID)
                db.AddInParameter(dbComm, "@WI_Qty", DbType.String, objinfo.WI_Qty)
                db.AddInParameter(dbComm, "@WI_UserID", DbType.String, objinfo.WI_UserID)
                db.AddInParameter(dbComm, "@WI_EditDate", DbType.Date, objinfo.WI_EditDate)

                db.ExecuteNonQuery(dbComm)
                WareInventory_UpdateA = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareInventory_UpdateA = False
            End Try
        End Function
        Public Function WareInventory_SelectCode(ByVal M_Code As String, ByVal M_Name As String, ByVal M_Gauge As String, ByVal WH_ID As String) As List(Of WareInventoryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInventory_SelectCode")

            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@M_Gauge", DbType.String, M_Gauge)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)

            Dim FeatureList As New List(Of WareInventoryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInventorySub(reader))
                End While
                Return FeatureList
            End Using
        End Function
        ''' <summary>
        ''' 修改倉庫庫存中的安全庫存數量
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareInventory_Update(ByVal objinfo As WareInventoryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInventory_Update")

                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, objinfo.WH_ID)
                db.AddInParameter(dbComm, "@WI_SafeQty", DbType.String, objinfo.WI_SafeQty)
                db.AddInParameter(dbComm, "@WI_UserID", DbType.String, objinfo.WI_UserID)
                db.AddInParameter(dbComm, "@WI_EditDate", DbType.Date, objinfo.WI_EditDate)

                db.ExecuteNonQuery(dbComm)
                WareInventory_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareInventory_Update = False
            End Try
     
        End Function
        ''' <summary>
        ''' 呆滯物料查詢 (自行設置多久沒有出庫記錄的查詢條件!)
        ''' </summary>
        ''' <param name="WH_ID"></param>
        ''' <param name="WO_AddDate"></param>
        ''' <param name="WO_AddDateVal"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Function WareInventory_GetNoUsefulList(ByVal WH_ID As String, ByVal WO_AddDate As String, ByVal WO_AddDateVal As String) As List(Of WareInventoryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInventory_GetNoUsefulList")

            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@WO_AddDate", DbType.String, WO_AddDate)
            db.AddInParameter(dbComm, "@WO_AddDateVal", DbType.String, WO_AddDateVal)

            Dim FeatureList As New List(Of WareInventoryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInventorySub(reader))
                End While
                Return FeatureList
            End Using
        End Function
        '針對生產倉庫而言---無或虛擬Type3,Type2,Type1 類型
        Public Function WareInventory_GetList3(ByVal M_Code As String, ByVal WH_ID As String, ByVal ShowZero As String) As List(Of WareInventoryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInventory_GetList3")

            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@ShowZero", DbType.String, ShowZero)

            Dim FeatureList As New List(Of WareInventoryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInventorySub(reader))
                End While
                Return FeatureList
            End Using
        End Function
        ''' <summary>
        ''' 返回物料的所有庫存數量
        ''' </summary>
        ''' <param name="M_Code"></param>
        ''' <param name="ShowZero"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareInventory_GetSum(ByVal M_Code As String, ByVal ShowZero As String) As List(Of WareInventoryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInventory_GetSum")

            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)

            db.AddInParameter(dbComm, "@ShowZero", DbType.String, ShowZero)

            Dim FeatureList As New List(Of WareInventoryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInventorySub(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function WareInventoryOut_GetList(ByVal WH_ID As String, ByVal M_Code As String, ByVal WO_AddDate1 As String, ByVal WO_AddDate2 As String, ByVal WO_AddDate3 As String) As List(Of WareInventoryInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInventoryOut_GetList")

            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@WO_AddDate1", DbType.String, WO_AddDate1)
            db.AddInParameter(dbComm, "@WO_AddDate2", DbType.String, WO_AddDate2)
            db.AddInParameter(dbComm, "@WO_AddDate3", DbType.String, WO_AddDate3)

            Dim FeatureList As New List(Of WareInventoryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInventoryList(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function WareHouseCode_GetList(ByVal WH_ID As String, ByVal M_Code As String, ByVal StartDate As String, ByVal EndDate As String) As List(Of WareInventoryInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareHouseCode_GetList")

            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@StartDate", DbType.String, StartDate)
            db.AddInParameter(dbComm, "@EndDate", DbType.String, EndDate)


            Dim FeatureList As New List(Of WareInventoryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInventoryList(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function WareNum_GetList(ByVal M_Code As String, ByVal WH_ID As String, ByVal BeginDate As String, ByVal EndDate As String) As List(Of WareInventoryInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareNum_GetList")

            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@BeginDate", DbType.String, BeginDate)
            db.AddInParameter(dbComm, "@EndDate", DbType.String, EndDate)


            Dim FeatureList As New List(Of WareInventoryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInventorySub(reader))
                End While
                Return FeatureList
            End Using
        End Function


        ''-------2012-8-3-呆滯物料--------------------------------------
        Public Function WareInventory_NOUserGetList(ByVal WH_ID As String, ByVal BeginDate As String, ByVal EndDate As String) As List(Of WareInventoryInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInventory_NOUserGetList")


            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@BeginDate", DbType.String, BeginDate)
            db.AddInParameter(dbComm, "@EndDate", DbType.String, EndDate)


            Dim FeatureList As New List(Of WareInventoryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInventoryNOUser(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Friend Function FillWareInventoryNOUser(ByVal reader As IDataReader) As WareInventoryInfo
            On Error Resume Next
            Dim objInfo As New WareInventoryInfo

            objInfo.WH_ID = reader("WH_ID").ToString
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            objInfo.Type3ID = reader("Type3ID").ToString
            objInfo.Type3Name = reader("Type3Name").ToString

            objInfo.WH_Name = reader("WH_Name").ToString
            objInfo.WH_SName = reader("WH_SName").ToString
            objInfo.WH_AllName = reader("WH_SName").ToString & "-" & reader("WH_Name").ToString 'DateOut 

            If reader("strTypeIN") Is DBNull.Value Then
                objInfo.strTypeIN = Nothing
            Else
                objInfo.strTypeIN = reader("strTypeIN").ToString
            End If

            If reader("strTypeOut") Is DBNull.Value Then
                objInfo.strTypeOut = Nothing
            Else
                objInfo.strTypeOut = reader("strTypeOut").ToString
            End If

            If reader("DateOut") Is DBNull.Value Then
                objInfo.DateOut = Nothing
            Else
                objInfo.DateOut = reader("DateOut").ToString
            End If

            If reader("DateIN") Is DBNull.Value Then
                objInfo.DateIn = Nothing
            Else
                objInfo.DateIn = reader("DateIN").ToString
            End If


            If reader("WI_Qty") Is DBNull.Value Then
                objInfo.WI_Qty = 0
            Else
                objInfo.WI_Qty = Format(CDbl(reader("WI_Qty").ToString), "0.000")
            End If

            'If reader("WIP_ID") Is DBNull.Value Then
            'Else
            '    objInfo.WIP_ID = reader("WIP_ID").ToString
            'End If

            'If reader("WIP_AddDate") Is DBNull.Value Then
            'Else
            '    objInfo.WIP_AddDate = reader("WIP_AddDate").ToString
            'End If

            'If reader("WIP_Qty") Is DBNull.Value Then
            'Else
            '    objInfo.WIP_Qty = CSng(reader("WIP_Qty").ToString)
            'End If
            '''''--------------------------
            'If reader("MV_NO_OUT") Is DBNull.Value Then
            'Else
            '    objInfo.MV_NO_OUT = reader("MV_NO_OUT").ToString
            'End If

            'If reader("MV_Date_OUT") Is DBNull.Value Then
            'Else
            '    objInfo.MV_Date_OUT = reader("MV_Date_OUT").ToString
            'End If

            'If reader("MV_Qty_OUT") Is DBNull.Value Then
            'Else
            '    objInfo.MV_Qty_OUT = CSng(reader("MV_Qty_OUT").ToString)
            'End If
            ' ''--------------------------
            'If reader("MV_NO_IN") Is DBNull.Value Then
            'Else
            '    objInfo.MV_NO_IN = reader("MV_NO_IN").ToString
            'End If

            'If reader("MV_Date_IN") Is DBNull.Value Then
            'Else
            '    objInfo.MV_Date_IN = reader("MV_Date_IN").ToString
            'End If

            'If reader("MV_Qty_IN") Is DBNull.Value Then
            'Else
            '    objInfo.MV_Qty_IN = CSng(reader("MV_Qty_IN").ToString)
            'End If


            Return objInfo
        End Function
        ''庫存月報表2012-11-19----------------------------------


        Public Function WareInventoryMothColl(ByVal WH_ID As String, ByVal Type1ID As String, ByVal Type2ID As String, ByVal Type3ID As String, ByVal DateStart As String, ByVal DateEnd As String, ByVal NextDate As String) As List(Of WareInventoryInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInventoryMothColl")

            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@Type1ID", DbType.String, Type1ID)
            db.AddInParameter(dbComm, "@Type2ID", DbType.String, Type2ID)
            db.AddInParameter(dbComm, "@Type3ID", DbType.String, Type3ID)
            db.AddInParameter(dbComm, "@DateStart", DbType.String, DateStart)
            db.AddInParameter(dbComm, "@DateEnd", DbType.String, DateEnd)
            db.AddInParameter(dbComm, "@NextDate", DbType.String, NextDate)


            Dim FeatureList As New List(Of WareInventoryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInventoryMothColl(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Friend Function FillWareInventoryMothColl(ByVal reader As IDataReader) As WareInventoryInfo
            On Error Resume Next
            Dim objInfo As New WareInventoryInfo

            objInfo.WH_ID = reader("WH_ID").ToString
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            objInfo.Type3ID = reader("Type3ID").ToString
            objInfo.Type3Name = reader("Type3Name").ToString

            objInfo.WH_Name = reader("WH_Name").ToString
            objInfo.WH_SName = reader("WH_SName").ToString
            objInfo.WH_AllName = reader("WH_SName").ToString & "-" & reader("WH_Name").ToString 'DateOut 

            objInfo.Type2Name = reader("Type2Name").ToString
            objInfo.Type1Name = reader("Type1Name").ToString
            objInfo.Type1ID = reader("Type1ID").ToString
            objInfo.Type2ID = reader("Type2ID").ToString

            objInfo.WI_Qty = reader("WI_Qty").ToString

            If reader("SumOut") Is DBNull.Value Then
                objInfo.SumOut = 0
            Else
                objInfo.SumOut = Format(CDbl(reader("SumOut").ToString), "0.0000")
            End If

            If reader("SumIN") Is DBNull.Value Then
                objInfo.SumIN = 0
            Else
                objInfo.SumIN = Format(CDbl(reader("SumIN").ToString), "0.0000")
            End If

            If reader("QTYStart") Is DBNull.Value Then
                objInfo.QTYStart = 0
            Else
                objInfo.QTYStart = reader("QTYStart").ToString
            End If

            If reader("QTYEnd") Is DBNull.Value Then
                objInfo.QTYEnd = 0
            Else
                objInfo.QTYEnd = reader("QTYEnd").ToString
            End If


            Return objInfo
        End Function




        ''2013-5-13 月份出入庫價值明細


        Public Function WareInventory_GetListMothPrice(ByVal WH_ID As String, ByVal WareDate As String, ByVal Type As String) As List(Of WareInventoryInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInventory_GetListMothPrice")

            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@WareDate", DbType.String, WareDate)
            db.AddInParameter(dbComm, "@Type", DbType.String, Type)

            Dim FeatureList As New List(Of WareInventoryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInventory_GetListMothPrice(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Friend Function FillWareInventory_GetListMothPrice(ByVal reader As IDataReader) As WareInventoryInfo
            On Error Resume Next
            Dim objInfo As New WareInventoryInfo

            objInfo.WH_ID = reader("WH_ID").ToString
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString



            objInfo.Type3ID = reader("Type3ID").ToString
            objInfo.Type3Name = reader("Type3Name").ToString

            objInfo.WH_Name = reader("WH_Name").ToString
            objInfo.WH_SName = reader("WH_SName").ToString
            objInfo.WH_AllName = reader("WH_SName").ToString & "-" & reader("WH_Name").ToString 'DateOut 

            objInfo.Type2Name = reader("Type2Name").ToString
            objInfo.Type1Name = reader("Type1Name").ToString
            objInfo.Type1ID = reader("Type1ID").ToString
            objInfo.Type2ID = reader("Type2ID").ToString

            objInfo.WI_Qty = reader("WI_Qty")

            objInfo.M_Currency = reader("M_Currency").ToString
            objInfo.M_Price = reader("M_Price")


            Return objInfo
        End Function



        Public Function WareBorrowReturnInventory_GetList(ByVal WH_ID As String, ByVal Type3ID As String, ByVal M_Code As String) As List(Of WareInventoryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareBorrowReturnInventory_GetList")

            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@Type3ID", DbType.String, Type3ID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)

            Dim FeatureList As New List(Of WareInventoryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInventorySub(reader))
                End While
                Return FeatureList
            End Using
        End Function

        ''' <summary>
        ''' 2014.5.5 鄭少釗新增 
        ''' </summary>
        ''' <param name="WH_ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareInventory_GetList_New(ByVal WH_ID As String) As List(Of WareInventoryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInventory_GetList_New")
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            Dim FeatureList As New List(Of WareInventoryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInventoryList(reader))
                End While
                Return FeatureList
            End Using
        End Function
        '''2014.5.5 鄭少釗新增
        ''' <summary>
        ''' 修改最大庫存量
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareInventory_UpdateMaxQty(ByVal objinfo As WareInventoryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInventory_UpdateMaxQty")

                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, objinfo.WH_ID)
                db.AddInParameter(dbComm, "@WI_MaxQty", DbType.String, objinfo.WI_MaxQty)
                db.AddInParameter(dbComm, "@WI_UserID", DbType.String, objinfo.WI_UserID)
                db.AddInParameter(dbComm, "@WI_EditDate", DbType.Date, objinfo.WI_EditDate)

                db.ExecuteNonQuery(dbComm)
                WareInventory_UpdateMaxQty = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareInventory_UpdateMaxQty = False
            End Try

        End Function

        '更新庫存位  劉祥松  2014.05.05
        Public Function WareInventory_ModifyWareAddress(ByVal M_Code As String, ByVal WH_ID As String, ByVal WI_Address As String)
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInventory_ModifyWareAddress")
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
                db.AddInParameter(dbComm, "@WI_Address", DbType.String, WI_Address)
                db.ExecuteNonQuery(dbComm)
                WareInventory_ModifyWareAddress = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareInventory_ModifyWareAddress = False
            End Try

        End Function
    End Class
End Namespace

