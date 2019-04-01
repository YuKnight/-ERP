Namespace LFERP.Library.WareHouse
    Public Class WareHouseController
        Public Function WareHouse_GetList(ByVal WH_IDList As String) As List(Of WareHouseInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareHouse_GetList")
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_IDList)
            Dim FeatureList As New List(Of WareHouseInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareHouse(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function WareHouse_GetList1(ByVal WH_IDList As String) As List(Of WareHouseInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareHouse_GetList1")
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_IDList)
            Dim FeatureList As New List(Of WareHouseInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareHouse(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function WareHouse_GetDataTable(ByVal WH_IDList As String) As DataTable
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareHouse_GetDataTable")
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_IDList)
                Return db.ExecuteDataSet(dbComm).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try


        End Function

        Public Function WareHouse_Get(ByVal WH_IDList As String) As List(Of WareHouseInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareHouse_Get")
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_IDList)
            Dim FeatureList As New List(Of WareHouseInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareHouse(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Friend Function FillWareHouse(ByVal reader As IDataReader) As WareHouseInfo

            On Error Resume Next

            '對應取得的數據
            Dim objInfo As New WareHouseInfo
            objInfo.WH_ID = reader("WH_ID").ToString
            objInfo.WH_Name = reader("WH_Name").ToString
            objInfo.WH_PID = reader("WH_PID").ToString
            objInfo.WH_Key = reader("WH_Key").ToString
            objInfo.WH_Remark = reader("WH_Remark").ToString
            objInfo.WH_Action = reader("WH_Action").ToString
            objInfo.CO_ID = reader("CO_ID").ToString
            objInfo.NeedCheck = reader("NeedCheck")
            objInfo.PrintBulk = reader("PrintBulk").ToString
            objInfo.WH_AllName = reader("WH_AllName").ToString

            objInfo.NeedCheckInput = reader("NeedCheckInput")
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

            Dim mt As New WareHouseController
            Dim objInfo As New List(Of WareHouseInfo)
            Dim i, l As Long
            Try

                WareHouse_LoadToTreeView = False
                tw.Nodes.Clear()
                objInfo = mt.WareHouse_GetList(WareHouseList)

                If objInfo Is Nothing Then WareHouse_LoadToTreeView = False

                For i = 0 To objInfo.Count - 1
                    If objInfo(i).WH_PID = "" Then
                        Dim tNode As New Windows.Forms.TreeNode()
                        tNode = tw.Nodes.Add(objInfo(i).WH_ID, objInfo(i).WH_Name)
                        tNode.Tag = objInfo(i).WH_ID
                        For l = 0 To objInfo.Count - 1
                            If objInfo(l).WH_PID = objInfo(i).WH_ID Then
                                tNode.Nodes.Add(objInfo(l).WH_ID, objInfo(l).WH_Name).Tag = objInfo(l).WH_ID
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

        ''' <summary>
        ''' 導入倉庫清單到TreeView控件
        ''' </summary>
        ''' <param name="tw"></param>
        ''' <param name="WareHouseList"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareHouse_LoadToTreeViewIn(ByVal tw As Windows.Forms.TreeView, ByVal WareHouseList As String, ByVal StrPMWS_Value As String) As Boolean

            Dim mt As New WareHouseController
            Dim objInfo As New List(Of WareHouseInfo)
            Dim i, l As Long
            Try

                WareHouse_LoadToTreeViewIn = False
                tw.Nodes.Clear()
                objInfo = mt.WareHouse_GetList(WareHouseList)
                If objInfo Is Nothing Then WareHouse_LoadToTreeViewIn = False

                For i = 0 To objInfo.Count - 1

                    If objInfo(i).WH_PID = "" Then
                        Dim tNode As New Windows.Forms.TreeNode()
                        tNode = tw.Nodes.Add(objInfo(i).WH_PID, objInfo(i).WH_Name)
                        tNode.Tag = objInfo(i).WH_PID
                        For l = 0 To objInfo.Count - 1
                            If objInfo(l).WH_PID = objInfo(i).WH_ID Then
                                If InStr(StrPMWS_Value, objInfo(l).WH_ID) Then
                                    tNode.Nodes.Add(objInfo(l).WH_ID, objInfo(l).WH_Name).Tag = objInfo(l).WH_ID
                                End If

                            End If
                        Next
                    End If
                    WareHouse_LoadToTreeViewIn = True
                    tw.ExpandAll()
                Next

            Catch ex As Exception
                WareHouse_LoadToTreeViewIn = False

            End Try

        End Function

    End Class
End Namespace

