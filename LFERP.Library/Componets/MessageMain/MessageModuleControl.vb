Namespace LFERP.Library.MessageMain


    Public Class MessageModuleControl
        Public Function MessageModule_GetList() As List(Of MessagModuleInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MessageModule_GetList")
            'db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_IDList)
            Dim FeatureList As New List(Of MessagModuleInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMessageModule(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Friend Function FillMessageModule(ByVal reader As IDataReader) As MessagModuleInfo
            '對應取得的數據
            Dim objInfo As New MessagModuleInfo
            objInfo.MM_ID = reader("MM_ID").ToString
            objInfo.MM_Name = reader("MM_Name").ToString
            objInfo.MM_PID = reader("MM_PID").ToString
            objInfo.MM_Image = reader("MM_Image").ToString
            objInfo.MM_SelectImage = reader("MM_SelectImage").ToString
            Return objInfo
        End Function



        Public Function MessageModule_LoadToTree(ByVal tw As Windows.Forms.TreeView) As Boolean

            Dim mt As New MessageModuleControl
            Dim objInfo As New List(Of MessagModuleInfo)
            Dim i, l As Integer
            Try
                MessageModule_LoadToTree = False
                tw.Nodes.Clear()
                objInfo = mt.MessageModule_GetList
                If objInfo Is Nothing Then MessageModule_LoadToTree = False
                For i = 0 To objInfo.Count - 1
                    If objInfo(i).MM_PID = "" Then
                        Dim tNode As New Windows.Forms.TreeNode()

                        tNode.ImageIndex = objInfo(i).MM_Image
                        tNode.SelectedImageIndex = objInfo(i).MM_SelectImage
                        tNode.Tag = objInfo(i).MM_ID
                        tNode.Text = objInfo(i).MM_Name
                        tw.Nodes.Add(tNode)

                        For l = 0 To objInfo.Count - 1
                            If objInfo(l).MM_PID = objInfo(i).MM_ID Then


                                tNode.Nodes.Add(objInfo(l).MM_ID, objInfo(l).MM_Name, objInfo(l).MM_Image, objInfo(l).MM_SelectImage).Tag = objInfo(l).MM_ID
                            End If
                        Next
                    End If
                    MessageModule_LoadToTree = True
                    tw.ExpandAll()

                Next
            Catch ex As Exception
                MessageModule_LoadToTree = False
            End Try

        End Function



    End Class
End Namespace