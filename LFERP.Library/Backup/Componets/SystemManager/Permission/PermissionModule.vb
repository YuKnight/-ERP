Namespace LFERP.SystemManager
    Public Class PermissionModule
        Private Sub GetPermissionModuleNode(ByVal PID As String, ByVal tNodes As Windows.Forms.TreeView)
            '導入第一層類型   
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PermissionModule_GetList")
            db.AddInParameter(dbComm, "@PM_PID", DbType.String, PID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Dim tree_leaf As New Windows.Forms.TreeNode()
                    tree_leaf.ImageIndex = reader("PM_Image")
                    tree_leaf.SelectedImageIndex = reader("PM_selectImage")
                    tree_leaf.Tag = reader("PM_ID")
                    tree_leaf.Text = reader("PM_Name")
                    tNodes.Nodes.Add(tree_leaf)
                End While
            End Using
        End Sub
        Private Sub GetPermissionModuleNode1(ByVal ID1 As Integer, ByVal PID As String, ByVal tNodes As Windows.Forms.TreeView)
            '導入第一層類型   
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PermissionModule_GetList")
            db.AddInParameter(dbComm, "@PM_PID", DbType.String, PID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Dim tree_leaf As New Windows.Forms.TreeNode()
                    tree_leaf.ImageIndex = reader("PM_Image")
                    tree_leaf.SelectedImageIndex = reader("PM_selectImage")
                    tree_leaf.Tag = reader("PM_ID")
                    tree_leaf.Text = reader("PM_Name")
                    tNodes.Nodes(ID1).Nodes.Add(tree_leaf)
                End While
            End Using
        End Sub
        Private Sub GetPermissionModuleNode2(ByVal ID1 As Integer, ByVal ID2 As Integer, ByVal PID As String, ByVal tNodes As Windows.Forms.TreeView)
            '導入第一層類型   
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PermissionModule_GetList")
            db.AddInParameter(dbComm, "@PM_PID", DbType.String, PID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Dim tree_leaf As New Windows.Forms.TreeNode()
                    tree_leaf.ImageIndex = reader("PM_Image")
                    tree_leaf.SelectedImageIndex = reader("PM_selectImage")
                    tree_leaf.Tag = reader("PM_ID")
                    tree_leaf.Text = reader("PM_Name")
                    tNodes.Nodes(ID1).Nodes(ID2).Nodes.Add(tree_leaf)
                End While
            End Using
        End Sub
        Private Sub GetPermissionModuleNode3(ByVal ID1 As Integer, ByVal ID2 As Integer, ByVal ID3 As Integer, ByVal PID As String, ByVal tNodes As Windows.Forms.TreeView)
            '導入第一層類型   
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PermissionModule_GetList")
            db.AddInParameter(dbComm, "@PM_PID", DbType.String, PID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Dim tree_leaf As New Windows.Forms.TreeNode()
                    tree_leaf.ImageIndex = reader("PM_Image")
                    tree_leaf.SelectedImageIndex = reader("PM_selectImage")
                    tree_leaf.Tag = reader("PM_ID")
                    tree_leaf.Text = reader("PM_Name")
                    tNodes.Nodes(ID1).Nodes(ID2).Nodes(ID3).Nodes.Add(tree_leaf)
                End While
            End Using
        End Sub
        Public Sub GetPermissionModule(ByVal TreeView As Windows.Forms.TreeView)
            TreeView.Nodes.Clear()
            GetPermissionModuleNode("01", TreeView)
            Dim iNodeNum As Integer = TreeView.GetNodeCount(False)
            Dim A, B, C As Integer
            For A = 0 To iNodeNum - 1
                '導入第二層類型 
                GetPermissionModuleNode1(A, TreeView.Nodes(A).Tag, TreeView)
                Dim Nodecount As Integer = TreeView.Nodes.Item(A).GetNodeCount(False)
                For B = 0 To Nodecount - 1
                    ''導入第三層類型
                    GetPermissionModuleNode2(A, B, TreeView.Nodes(A).Nodes(B).Tag, TreeView)
                    Dim NodecountC As Integer = TreeView.Nodes.Item(A).Nodes.Item(B).GetNodeCount(False)
                    For C = 0 To NodecountC - 1
                        GetPermissionModuleNode3(A, B, C, TreeView.Nodes(A).Nodes(B).Nodes(C).Tag, TreeView)
                    Next
                Next
            Next
        End Sub



        Private Sub GetPermissionModuleNodeUser(ByVal PID As String, ByVal tNodes As Windows.Forms.TreeView, ByVal U_ID As String)
            '導入第一層類型   
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PermissionModuleUser_GetList")
            db.AddInParameter(dbComm, "@PM_PID", DbType.String, PID)
            db.AddInParameter(dbComm, "@U_ID", DbType.String, U_ID)
            db.AddInParameter(dbComm, "@PMU_Value", DbType.String, "1")
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Dim tree_leaf As New Windows.Forms.TreeNode()
                    tree_leaf.ImageIndex = reader("PM_Image")
                    tree_leaf.SelectedImageIndex = reader("PM_selectImage")
                    tree_leaf.Tag = reader("PM_ID")
                    tree_leaf.Text = reader("PM_Name")
                    tNodes.Nodes.Add(tree_leaf)
                End While
            End Using
        End Sub
        Private Sub GetPermissionModuleNodeUser1(ByVal ID1 As Integer, ByVal PID As String, ByVal tNodes As Windows.Forms.TreeView, ByVal U_ID As String)
            '導入第一層類型   
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PermissionModuleUser_GetList")
            db.AddInParameter(dbComm, "@PM_PID", DbType.String, PID)
            db.AddInParameter(dbComm, "@U_ID", DbType.String, U_ID)
            db.AddInParameter(dbComm, "@PMU_Value", DbType.String, "1")
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Dim tree_leaf As New Windows.Forms.TreeNode()
                    tree_leaf.ImageIndex = reader("PM_Image")
                    tree_leaf.SelectedImageIndex = reader("PM_selectImage")
                    tree_leaf.Tag = reader("PM_ID")
                    tree_leaf.Text = reader("PM_Name")
                    tNodes.Nodes(ID1).Nodes.Add(tree_leaf)
                End While
            End Using
        End Sub
        Private Sub GetPermissionModuleNodeUser2(ByVal ID1 As Integer, ByVal ID2 As Integer, ByVal PID As String, ByVal tNodes As Windows.Forms.TreeView, ByVal U_ID As String)
            '導入第一層類型   
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PermissionModuleUser_GetList")
            db.AddInParameter(dbComm, "@PM_PID", DbType.String, PID)
            db.AddInParameter(dbComm, "@U_ID", DbType.String, U_ID)
            db.AddInParameter(dbComm, "@PMU_Value", DbType.String, "1")
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Dim tree_leaf As New Windows.Forms.TreeNode()
                    tree_leaf.ImageIndex = reader("PM_Image")
                    tree_leaf.SelectedImageIndex = reader("PM_selectImage")
                    tree_leaf.Tag = reader("PM_ID")
                    tree_leaf.Text = reader("PM_Name")
                    tNodes.Nodes(ID1).Nodes(ID2).Nodes.Add(tree_leaf)
                End While
            End Using
        End Sub
        Private Sub GetPermissionModuleNodeUser3(ByVal ID1 As Integer, ByVal ID2 As Integer, ByVal ID3 As Integer, ByVal PID As String, ByVal tNodes As Windows.Forms.TreeView, ByVal U_ID As String)
            '導入第一層類型   
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PermissionModuleUser_GetList")
            db.AddInParameter(dbComm, "@PM_PID", DbType.String, PID)
            db.AddInParameter(dbComm, "@U_ID", DbType.String, U_ID)
            db.AddInParameter(dbComm, "@PMU_Value", DbType.String, "1")
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Dim tree_leaf As New Windows.Forms.TreeNode()
                    tree_leaf.ImageIndex = reader("PM_Image")
                    tree_leaf.SelectedImageIndex = reader("PM_selectImage")
                    tree_leaf.Tag = reader("PM_ID")
                    tree_leaf.Text = reader("PM_Name")
                    tNodes.Nodes(ID1).Nodes(ID2).Nodes(ID3).Nodes.Add(tree_leaf)
                End While
            End Using
        End Sub
        Public Sub GetPermissionModuleUser(ByVal TreeView As Windows.Forms.TreeView, ByVal U_ID As String)
            TreeView.Nodes.Clear()
            GetPermissionModuleNodeUser("01", TreeView, U_ID)
            Dim iNodeNum As Integer = TreeView.GetNodeCount(False)
            Dim A, B, C As Integer
            For A = 0 To iNodeNum - 1
                '導入第二層類型 
                GetPermissionModuleNodeUser1(A, TreeView.Nodes(A).Tag, TreeView, U_ID)
                Dim Nodecount As Integer = TreeView.Nodes.Item(A).GetNodeCount(False)
                For B = 0 To Nodecount - 1
                    ''導入第三層類型
                    GetPermissionModuleNodeUser2(A, B, TreeView.Nodes(A).Nodes(B).Tag, TreeView, U_ID)
                    Dim NodecountC As Integer = TreeView.Nodes.Item(A).Nodes.Item(B).GetNodeCount(False)
                    For C = 0 To NodecountC - 1
                        GetPermissionModuleNodeUser3(A, B, C, TreeView.Nodes(A).Nodes(B).Nodes(C).Tag, TreeView, U_ID)
                    Next
                Next
            Next
        End Sub
    End Class

End Namespace

