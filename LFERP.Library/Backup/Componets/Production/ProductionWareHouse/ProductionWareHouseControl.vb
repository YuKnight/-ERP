
Namespace LFERP.Library.ProductionWareHouse

    Public Class ProductionWareHouseControl

        Public Function ProductionWareHouse_GetList(ByVal PH_IDList As String) As List(Of ProductionWareHouseInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareHouse_GetList")
            db.AddInParameter(dbComm, "@PH_ID", DbType.String, PH_IDList)
            Dim FeatureList As New List(Of ProductionWareHouseInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionWareHouse(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function ProductionWareHouse_Get(ByVal PH_IDList As String) As List(Of ProductionWareHouseInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareHouse_Get")
            db.AddInParameter(dbComm, "@PH_ID", DbType.String, PH_IDList)
            Dim FeatureList As New List(Of ProductionWareHouseInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionWareHouse(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Friend Function FillProductionWareHouse(ByVal reader As IDataReader) As ProductionWareHouseInfo
            '對應取得的數據
            Dim objInfo As New ProductionWareHouseInfo

            objInfo.PH_ID = reader("PH_ID").ToString
            objInfo.PH_Name = reader("PH_Name").ToString
            objInfo.PH_PID = reader("PH_PID").ToString
            objInfo.PH_Key = reader("PH_Key").ToString

            Return objInfo
        End Function

        ''' <summary>
        ''' 導入倉庫清單到TreeView控件
        ''' </summary>
        ''' <param name="tw"></param>
        ''' <param name="WareHouseList"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareHouse_LoadToTreeView(ByVal tw As Windows.Forms.TreeView, ByVal WareHouseList As String) As Boolean

            Dim mt As New ProductionWareHouseControl
            Dim objInfo As New List(Of ProductionWareHouseInfo)
            Dim i, l As Long
            Try

                WareHouse_LoadToTreeView = False
                tw.Nodes.Clear()
                objInfo = mt.ProductionWareHouse_GetList(WareHouseList)
                If objInfo Is Nothing Then WareHouse_LoadToTreeView = False
                For i = 0 To objInfo.Count - 1
                    If objInfo(i).PH_PID = "" Then
                        Dim tNode As New Windows.Forms.TreeNode()
                        tNode = tw.Nodes.Add(objInfo(i).PH_ID, objInfo(i).PH_Name)
                        tNode.Tag = objInfo(i).PH_ID
                        For l = 0 To objInfo.Count - 1
                            If objInfo(l).PH_PID = objInfo(i).PH_ID Then
                                tNode.Nodes.Add(objInfo(l).PH_ID, objInfo(l).PH_Name).Tag = objInfo(l).PH_ID
                            End If
                        Next
                    End If
                    WareHouse_LoadToTreeView = True
                    tw.ExpandAll()
                Next

            Catch ex As Exception
                WareHouse_LoadToTreeView = False

            End Try


        End Function

    End Class

End Namespace


