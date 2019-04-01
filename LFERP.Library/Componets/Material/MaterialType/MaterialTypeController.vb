Imports System.Windows.Forms
Imports System
Imports System.Data
Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.SqlClient
Imports System.Data.Common

Namespace LFERP.Library.Material

    Public Class MaterialTypeController
#Region "取得物料類型"
        'Enum MaterialType
        '    配件 = 1
        '    材料 = 2
        '    半成品 = 3
        '    成品 = 4
        'End Enum
        ''' <summary>
        ''' 導入主物料類型
        ''' </summary>
        ''' <param name="TreeView"></param>
        ''' <param name="MaterialTypeID"></param>
        ''' <remarks></remarks>
        Public Sub LoadNodes(ByVal TreeView As TreeView, ByVal MaterialTypeID As String)

            '清除原有數據
            TreeView.Nodes.Clear()
            '導入第一層類型
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialType_Get")
            db.AddInParameter(dbComm, "@MaterialTypeID", DbType.String, MaterialTypeID)
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
                GetNodes1(A, TreeView.Nodes(A).Tag, TreeView)
                Dim Nodecount As Integer = TreeView.Nodes.Item(A).GetNodeCount(False)
                For B = 0 To Nodecount - 1
                    ''導入第三層類型
                    GetNodes2(A, B, TreeView.Nodes(A).Nodes(B).Tag, TreeView)
                    Dim NodecountC As Integer = TreeView.Nodes.Item(A).Nodes.Item(B).GetNodeCount(False)
                    For C = 0 To NodecountC - 1
                        GetNodes3(A, B, C, TreeView.Nodes(A).Nodes(B).Nodes(C).Tag, TreeView)
                    Next
                Next
                TreeView.Nodes(A).Expand()
            Next
       
        End Sub
        Private Sub GetNodes1(ByVal pID As Integer, ByVal MaterialTypeID As String, ByVal TreeView As TreeView)
            '導入第一層類型   
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialType_GetNodes1")
            db.AddInParameter(dbComm, "@MaterialTypeID", DbType.String, MaterialTypeID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Dim tNodes As New TreeNode
                    tNodes.Tag = reader("Type1ID")
                    tNodes.Text = reader("Type1Name")
                    TreeView.Nodes.Item(pID).Nodes.Add(tNodes)
                End While
            End Using
        End Sub
        Private Sub GetNodes2(ByVal pID As Integer, ByVal pID1 As Integer, ByVal Type1ID As String, ByVal TreeView As TreeView)
            '導入第二層類型   

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialType_GetNodes2")
            db.AddInParameter(dbComm, "@Type1ID", DbType.String, Type1ID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Dim tNodes As New TreeNode
                    tNodes.Tag = reader("Type2ID")
                    tNodes.Text = reader("Type2Name")
                    TreeView.Nodes.Item(pID).Nodes.Item(pID1).Nodes.Add(tNodes)
                End While
            End Using

        End Sub
        Private Sub GetNodes3(ByVal pID As Integer, ByVal pID1 As Integer, ByVal pID2 As Integer, ByVal Type2ID As String, ByVal TreeView As TreeView)
            '導入第三層類型
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialType_GetNodes3")
            db.AddInParameter(dbComm, "@Type2ID", DbType.String, Type2ID)
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

#Region "主物料類型,暫時不用，手工在數據庫中增加"
        Public Function MaterialTypeAdd(ByVal objMaterialType As MaterialTypeInfo) As Boolean
            '檢查物料編碼編號是否已存在
            Dim objMaterialInfo As MaterialTypeInfo = MaterialType_Get(objMaterialType.MaterialTypeID)
            If objMaterialInfo Is Nothing Then
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialType_Add")
                db.AddInParameter(dbComm, "@MaterialTypeID", DbType.String, objMaterialType.MaterialTypeID)
                db.AddInParameter(dbComm, "@MaterialTypeName", DbType.String, objMaterialType.MaterialTypeName)
                db.ExecuteNonQuery(dbComm)
                MaterialTypeAdd = True
            Else
                MaterialTypeAdd = False
            End If

        End Function

        Public Function MaterialTypeUpdate(ByVal objMaterialType As MaterialTypeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialType_Update")
                db.AddInParameter(dbComm, "@MaterialTypeID", DbType.String, objMaterialType.MaterialTypeID)
                db.AddInParameter(dbComm, "@MaterialTypeName", DbType.String, objMaterialType.MaterialTypeName)
                db.ExecuteNonQuery(dbComm)
                MaterialTypeUpdate = True
            Catch ex As Exception
                MaterialTypeUpdate = False
            End Try

        End Function

        Public Function MaterialTypeDel(ByVal MaterialTypeID As String) As Boolean
            'return delleteuser(dfdfd)
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialType_Del")
                db.AddInParameter(dbComm, "@MaterialTypeID", DbType.String, MaterialTypeID)
                db.ExecuteNonQuery(dbComm)
                MaterialTypeDel = True
            Catch ex As Exception
                MaterialTypeDel = False
            End Try
        End Function

        Public Function MaterialType_Get(ByVal MaterialTypeID As String) As MaterialTypeInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialType_Get")
            db.AddInParameter(dbComm, "@MaterialTypeID", DbType.String, MaterialTypeID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillMaterialTypeInfo(reader)
                End While
                Return Nothing
            End Using
        End Function

        Friend Function FillMaterialTypeInfo(ByVal reader As IDataReader) As MaterialTypeInfo
            '對應取得的數據
            Dim objMaterialTypeInfo As New MaterialTypeInfo
            objMaterialTypeInfo.MaterialTypeID = reader("MaterialTypeID").ToString
            objMaterialTypeInfo.MaterialTypeName = reader("MaterialTypeName").ToString
            objMaterialTypeInfo.MaterialTypeRemark = reader("MaterialTypeRemark").ToString
            objMaterialTypeInfo.MaterialTypeNameEng = reader("MaterialTypeNameEng").ToString
            Return objMaterialTypeInfo
        End Function
#End Region

#Region "第一層類型"
        Public Function MaterialType1_Add(ByVal objMaterialTypeInfo1 As MaterialTypeInfo1) As Boolean
            '檢查物料編碼編號是否已存在
            Dim objMaterialInfo As MaterialTypeInfo1 = MaterialType1_Get(objMaterialTypeInfo1.Type1ID)
            If objMaterialInfo Is Nothing Then
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialType1_Add")
                db.AddInParameter(dbComm, "@Type1ID", DbType.String, objMaterialTypeInfo1.Type1ID)
                db.AddInParameter(dbComm, "@Type1Name", DbType.String, objMaterialTypeInfo1.Type1Name)
                db.AddInParameter(dbComm, "@MaterialTypeID", DbType.String, objMaterialTypeInfo1.MaterialTypeID)
                db.AddInParameter(dbComm, "@Type1Remark", DbType.String, objMaterialTypeInfo1.Type1Remark)
                db.AddInParameter(dbComm, "@MaterialTypeNameEng", DbType.String, objMaterialTypeInfo1.MaterialTypeNameEng)
                db.ExecuteNonQuery(dbComm)
                MaterialType1_Add = True
            Else
                MaterialType1_Add = False
            End If
        End Function
        ''' <summary>
        ''' 取得指定第一層類型編號的數據
        ''' </summary>
        ''' <param name="Type1ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MaterialType1_Get(ByVal Type1ID As String) As MaterialTypeInfo1
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialType1_Get")
            db.AddInParameter(dbComm, "@Type1ID", DbType.String, Type1ID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillMaterialTypeInfo1(reader)
                End While
                Return Nothing
            End Using
        End Function

        Friend Function FillMaterialTypeInfo1(ByVal reader As IDataReader) As MaterialTypeInfo1
            '對應取得的數據
            Dim objMaterialTypeInfo1 As New MaterialTypeInfo1
            objMaterialTypeInfo1.Type1ID = reader("Type1ID").ToString
            objMaterialTypeInfo1.Type1Name = reader("Type1Name").ToString
            objMaterialTypeInfo1.MaterialTypeID = reader("MaterialTypeID").ToString
            objMaterialTypeInfo1.Type1Remark = reader("Type1Remark").ToString
            objMaterialTypeInfo1.MaterialTypeNameEng = reader("MaterialTypeNameEng").ToString
            Return objMaterialTypeInfo1
        End Function
        ''' <summary>
        ''' 更新第一層類型資料
        ''' </summary>
        ''' <param name="objMaterialTypeInfo1"></param>
        ''' <remarks></remarks>
        Public Function MaterialType1_Update(ByVal objMaterialTypeInfo1 As MaterialTypeInfo1) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialType1_Update")
                db.AddInParameter(dbComm, "@Type1ID", DbType.String, objMaterialTypeInfo1.Type1ID)
                db.AddInParameter(dbComm, "@Type1Name", DbType.String, objMaterialTypeInfo1.Type1Name)
                db.AddInParameter(dbComm, "@MaterialTypeID", DbType.String, objMaterialTypeInfo1.MaterialTypeID)
                db.AddInParameter(dbComm, "@Type1Remark", DbType.String, objMaterialTypeInfo1.Type1Remark)
                db.AddInParameter(dbComm, "@MaterialTypeNameEng", DbType.String, objMaterialTypeInfo1.MaterialTypeNameEng)
                db.ExecuteNonQuery(dbComm)
                MaterialType1_Update = True
            Catch ex As Exception
                MaterialType1_Update = False
            End Try

        End Function
        Public Function MaterialType1_Delete(ByVal Type1ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialType1_Delete")
                db.AddInParameter(dbComm, "@Type1ID", DbType.String, Type1ID)
                db.ExecuteNonQuery(dbComm)
                MaterialType1_Delete = True
            Catch ex As Exception
                MaterialType1_Delete = False
            End Try
        End Function

        Public Function MaterialType1_GetID(ByVal strTopID As String) As String
            '取得第一層編碼
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialType1_GetID")
            Dim tTemp As String = ""
            Dim i As Integer = 0
            db.AddInParameter(dbComm, "@Type1ID", DbType.String, strTopID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    '00 000  長5位                    
                    tTemp = strTopID & Mid(1000 + CLng(Mid(reader("Type1ID"), 3) + 1), 2)
                    i = i + 1
                End While
                If i = 0 Then tTemp = strTopID & "001"
            End Using
            MaterialType1_GetID = tTemp
        End Function
#End Region

#Region "第二層類型"
        Public Function MaterialType2_Add(ByVal objMaterialTypeInfo2 As MaterialTypeInfo2) As Boolean
            '檢查物料編碼編號是否已存在
            Dim objMaterialInfo As MaterialTypeInfo2 = MaterialType2_Get(objMaterialTypeInfo2.Type1ID)
            If objMaterialInfo Is Nothing Then
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialType2_Add")
                db.AddInParameter(dbComm, "@Type2ID", DbType.String, objMaterialTypeInfo2.Type2ID)
                db.AddInParameter(dbComm, "@Type2Name", DbType.String, objMaterialTypeInfo2.Type2Name)
                db.AddInParameter(dbComm, "@Type1ID", DbType.String, objMaterialTypeInfo2.Type1ID)
                db.AddInParameter(dbComm, "@Type2Remark", DbType.String, objMaterialTypeInfo2.Type2Remark)
                db.AddInParameter(dbComm, "@MaterialTypeNameEng", DbType.String, objMaterialTypeInfo2.MaterialTypeNameEng)
                db.ExecuteNonQuery(dbComm)
                MaterialType2_Add = True
            Else
                MaterialType2_Add = False
            End If
        End Function
        Public Function MaterialType2_Get(ByVal Type2ID As String) As MaterialTypeInfo2
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialType2_Get")
            db.AddInParameter(dbComm, "@Type2ID", DbType.String, Type2ID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillMaterialTypeInfo2(reader)
                End While
                Return Nothing
            End Using
        End Function

        Friend Function FillMaterialTypeInfo2(ByVal reader As IDataReader) As MaterialTypeInfo2
            '對應取得的數據
            Dim objMaterialTypeInfo2 As New MaterialTypeInfo2
            objMaterialTypeInfo2.Type2ID = reader("Type2ID").ToString
            objMaterialTypeInfo2.Type2Name = reader("Type2Name").ToString
            objMaterialTypeInfo2.Type1ID = reader("Type1ID").ToString
            objMaterialTypeInfo2.Type2Remark = reader("Type2Remark").ToString
            objMaterialTypeInfo2.MaterialTypeNameEng = reader("MaterialTypeNameEng").ToString
            Return objMaterialTypeInfo2
        End Function
        Public Function MaterialType2_Update(ByVal objMaterialTypeInfo2 As MaterialTypeInfo2) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialType2_Update")
                db.AddInParameter(dbComm, "@Type2ID", DbType.String, objMaterialTypeInfo2.Type2ID)
                db.AddInParameter(dbComm, "@Type2Name", DbType.String, objMaterialTypeInfo2.Type2Name)
                db.AddInParameter(dbComm, "@Type1ID", DbType.String, objMaterialTypeInfo2.Type1ID)
                db.AddInParameter(dbComm, "@Type2Remark", DbType.String, objMaterialTypeInfo2.Type2Remark)
                db.AddInParameter(dbComm, "@MaterialTypeNameEng", DbType.String, objMaterialTypeInfo2.MaterialTypeNameEng)
                db.ExecuteNonQuery(dbComm)
                MaterialType2_Update = True
            Catch ex As Exception
                MaterialType2_Update = False
            End Try

        End Function
        Public Function MaterialType2_Delete(ByVal Type2ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialType2_Delete")
                db.AddInParameter(dbComm, "@Type2ID", DbType.String, Type2ID)
                db.ExecuteNonQuery(dbComm)
                MaterialType2_Delete = True
            Catch ex As Exception
                MaterialType2_Delete = False
            End Try
        End Function
        Public Function MaterialType2_GetID(ByVal strTopID As String) As String
            '取得第二層編碼
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialType2_GetID")
            Dim tTemp As String = ""
            Dim i As Integer = 0
            db.AddInParameter(dbComm, "@Type2ID", DbType.String, strTopID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    '00 000  000長8位                    
                    tTemp = strTopID & Mid(1000 + CLng(Mid(reader("Type2ID"), 6) + 1), 2)
                    i = i + 1
                End While
                If i = 0 Then tTemp = strTopID & "001"
            End Using
            MaterialType2_GetID = tTemp
        End Function


        ''' <summary>
        ''' 到第二級項目中是否存在一級的內容 2012-6-30
        ''' </summary>
        ''' <param name="Type2ID"></param>
        ''' <param name="Type2Name"></param>
        ''' <param name="Type1ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MaterialType2_GetList(ByVal Type2ID As String, ByVal Type2Name As String, ByVal Type1ID As String) As List(Of MaterialTypeInfo2)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialType2_GetList")

            db.AddInParameter(dbComm, "@Type2ID", DbType.String, Type2ID)
            db.AddInParameter(dbComm, "@Type2Name", DbType.String, Type2Name)
            db.AddInParameter(dbComm, "@Type1ID", DbType.String, Type1ID)

            Dim FeatureList As New List(Of MaterialTypeInfo2)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMaterialTypeInfo2(reader))
                End While
                Return FeatureList
            End Using
        End Function


#End Region

#Region "第三層類型"
        Public Function MaterialType3_Add(ByVal objMaterialTypeInfo3 As MaterialTypeInfo3) As Boolean
            '檢查物料編碼編號是否已存在
            Dim objMaterialInfo As MaterialTypeInfo3 = MaterialType3_Get(objMaterialTypeInfo3.Type3ID)
            If objMaterialInfo Is Nothing Then
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialType3_Add")
                db.AddInParameter(dbComm, "@Type3ID", DbType.String, objMaterialTypeInfo3.Type3ID)
                db.AddInParameter(dbComm, "@Type3Name", DbType.String, objMaterialTypeInfo3.Type3Name)
                db.AddInParameter(dbComm, "@Type2ID", DbType.String, objMaterialTypeInfo3.Type2ID)
                db.AddInParameter(dbComm, "@Type3Remark", DbType.String, objMaterialTypeInfo3.Type3Remark)
                db.AddInParameter(dbComm, "@MaterialTypeNameEng", DbType.String, objMaterialTypeInfo3.MaterialTypeNameEng)
                db.ExecuteNonQuery(dbComm)
                MaterialType3_Add = True
            Else
                MaterialType3_Add = False
            End If
        End Function

        Public Function MaterialType3_Get(ByVal Type3ID As String) As MaterialTypeInfo3
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialType3_Get")
            db.AddInParameter(dbComm, "@Type3ID", DbType.String, Type3ID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillMaterialTypeInfo3(reader)
                End While
                Return Nothing
            End Using
        End Function
        Friend Function FillMaterialTypeInfo3(ByVal reader As IDataReader) As MaterialTypeInfo3
            '對應取得的數據
            Dim objMaterialTypeInfo3 As New MaterialTypeInfo3
            objMaterialTypeInfo3.Type3ID = reader("Type3ID").ToString
            objMaterialTypeInfo3.Type3Name = reader("Type3Name").ToString
            objMaterialTypeInfo3.Type2ID = reader("Type2ID").ToString
            objMaterialTypeInfo3.Type3Remark = reader("Type3Remark").ToString
            objMaterialTypeInfo3.MaterialTypeNameEng = reader("MaterialTypeNameEng").ToString
            Return objMaterialTypeInfo3
        End Function
        Public Function MaterialType3_Update(ByVal objMaterialTypeInfo3 As MaterialTypeInfo3) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialType3_Update")
                db.AddInParameter(dbComm, "@Type3ID", DbType.String, objMaterialTypeInfo3.Type3ID)
                db.AddInParameter(dbComm, "@Type3Name", DbType.String, objMaterialTypeInfo3.Type3Name)
                db.AddInParameter(dbComm, "@Type2ID", DbType.String, objMaterialTypeInfo3.Type2ID)
                db.AddInParameter(dbComm, "@Type3Remark", DbType.String, objMaterialTypeInfo3.Type3Remark)
                db.AddInParameter(dbComm, "@MaterialTypeNameEng", DbType.String, objMaterialTypeInfo3.MaterialTypeNameEng)
                db.ExecuteNonQuery(dbComm)
                MaterialType3_Update = True
            Catch ex As Exception
                MaterialType3_Update = False
            End Try

        End Function
        Public Function MaterialType3_Delete(ByVal Type3ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialType3_Delete")
                db.AddInParameter(dbComm, "@Type3ID", DbType.String, Type3ID)
                db.ExecuteNonQuery(dbComm)
                MaterialType3_Delete = True
            Catch ex As Exception
                MaterialType3_Delete = False
            End Try
        End Function
        Public Function MaterialType3_GetID(ByVal strTopID As String) As String
            '取得第三層編碼
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialType3_GetID")
            Dim tTemp As String = ""
            Dim i As Integer = 0
            db.AddInParameter(dbComm, "@Type3ID", DbType.String, strTopID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    '00 000  000 000長11位                    
                    tTemp = strTopID & Mid(1000 + CLng(Mid(reader("Type3ID"), 9) + 1), 2)
                    i = i + 1
                End While
                If i = 0 Then tTemp = strTopID & "001"
            End Using
            MaterialType3_GetID = tTemp
        End Function

        ''' <summary>
        ''' 查詢第三級有沒有第二級的內容2012-6-30
        ''' </summary>
        ''' <param name="Type3ID"></param>
        ''' <param name="Type3Name"></param>
        ''' <param name="Type2ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MaterialType3_GetList(ByVal Type3ID As String, ByVal Type3Name As String, ByVal Type2ID As String) As List(Of MaterialTypeInfo3)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialType3_GetList")

            db.AddInParameter(dbComm, "@Type3ID", DbType.String, Type3ID)
            db.AddInParameter(dbComm, "@Type3Name", DbType.String, Type3Name)
            db.AddInParameter(dbComm, "@Type2ID", DbType.String, Type2ID)

            Dim FeatureList As New List(Of MaterialTypeInfo3)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMaterialTypeInfo3(reader))
                End While
                Return FeatureList
            End Using
        End Function

#End Region


    End Class


End Namespace
