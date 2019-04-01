Imports LFERP.SystemManager
Imports LFERP.DataSetting
Imports LFERP.Library.ProductionSumLock

Imports LFERP.Library.ProductionPieceWorkGroup

Public Class frmProductionSumLockMain
    Dim dc As New DepartmentControler

    Function TreeListLoad() As Boolean
        Dim PerMFacID As String
        PerMFacID = "A,B,C,D"

        Dim pmws As New LFERP.SystemManager.PermissionModuleWarrantSubController
        Dim pmwiL As List(Of LFERP.SystemManager.PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88161301")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value <> "" Then
                PerMFacID = pmwiL.Item(0).PMWS_Value
            End If
        End If



        Dim ds As New DataSet
        With ds.Tables.Add("FacBring")
            .Columns.Add("DepID", GetType(String))
            .Columns.Add("DepPID", GetType(String))
            .Columns.Add("DepName", GetType(String))
        End With



        ' 加載廠別名稱()
        Dim fc As New FacControler
        Dim fcl As New List(Of FacInfo)
        Dim i As Integer

        fcl = fc.GetFacList(Nothing, Nothing)

        If fcl.Count <= 0 Then Exit Function

        For i = 0 To fcl.Count - 1

            If InStr(PerMFacID, fcl(i).FacID, CompareMethod.Text) > 0 Then

                Dim row2 As DataRow
                row2 = ds.Tables("FacBring").NewRow
                row2("DepID") = fcl(i).FacID
                row2("DepPID") = "00"
                row2("DepName") = fcl(i).FacName
                ds.Tables("FacBring").Rows.Add(row2)

                Dim j As Integer
                '' 1  
                Dim pci As New ProductionPieceWorkGroupControl
                Dim pcL As New List(Of ProductionPieceWorkGroupInfo)
                pcL = pci.DepFac_GetList1(Nothing, Nothing, fcl(i).FacID, Nothing)

                If pcL.Count > 0 Then
                    For j = 0 To pcL.Count - 1
                        Dim row1 As DataRow
                        row1 = ds.Tables("FacBring").NewRow()
                        row1("DepID") = pcL(j).DepID
                        row1("DepPID") = pcL(j).FacID
                        row1("DepName") = pcL(j).G_DepName
                        ds.Tables("FacBring").Rows.Add(row1)

                        ''-----------------------------------------
                        LoadLock(pcL(j).DepID, pcL(j).FacID, Format(Now, "yyyy/MM"))



                    Next
                End If
            End If
        Next

        TreeList2.DataSource = ds.Tables("FacBring")


    End Function




    Function LoadLock(ByVal _DepID As String, ByVal _FacID As String, ByVal _LockYYYYMM As String) As Boolean
        Dim pc As New ProductionSumLockControl

        Dim PL As New List(Of ProductionSumLockInfo)

        PL = pc.ProductionSumLock_GetList(Nothing, Nothing, _DepID, _LockYYYYMM)
        If PL.Count <= 0 Then
            Dim PI As New ProductionSumLockInfo
            PI.DepID = _DepID
            PI.FacID = _FacID
            PI.LockCheck = False
            PI.LockYYYYMM = _LockYYYYMM
            PI.AddAction = InUserID
            PI.AddDate = Format(Now, "yyyy/MM/dd")

            pc.ProductionSumLock_Add(PI)

        End If

    End Function



    Private Sub TreeList2_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeList2.FocusedNodeChanged
        Dim str As String
        Dim pc As New ProductionSumLockControl



        str = TreeList2.FocusedNode.Item("DepID").ToString()
        msgLabel.Text = str

        If Len(msgLabel.Text) = 1 Then
            GridControl1.DataSource = pc.ProductionSumLock_GetList(Nothing, str, Nothing, Nothing)
        ElseIf Len(msgLabel.Text) > 0 Then
            GridControl1.DataSource = pc.ProductionSumLock_GetList(Nothing, Nothing, str, Nothing)
        Else
            GridControl1.DataSource = pc.ProductionSumLock_GetList(Nothing, Nothing, Nothing, Nothing)
        End If


    End Sub

    Private Sub ProductionSumLockAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductionSumLockAdd.Click

        If GridView1.RowCount <= 0 Then
            Exit Sub
        End If

        Dim pc As New ProductionSumLockControl
        Dim pi As New ProductionSumLockInfo

        Dim _AutoID, _FacID, _DepID, _LockYYYYMM, _DepName, _LockCheck As String
        _LockCheck = GridView1.GetFocusedRowCellValue("LockCheck")

        If _LockCheck = True Then
            MsgBox("此記錄已鎖定！")
            Exit Sub
        End If



        _AutoID = GridView1.GetFocusedRowCellValue("AutoID")
        _FacID = GridView1.GetFocusedRowCellValue("FacID")

        _DepName = GridView1.GetFocusedRowCellValue("DepName")

        _DepID = GridView1.GetFocusedRowCellValue("DepID")
        _LockYYYYMM = GridView1.GetFocusedRowCellValue("LockYYYYMM")

        If MsgBox("你確定鎖定:  '" & _DepName & " " & _LockYYYYMM & "'  的記錄嗎?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            pi.AutoID = _AutoID
            pi.FacID = _FacID
            pi.DepID = _DepID
            pi.LockYYYYMM = _LockYYYYMM
            pi.LockCheck = True
            pi.AddAction = InUserID
            pi.AddDate = Format(Now, "yyyy/MM/dd")


            If pc.ProductionSumLock_Update(pi) = True Then
                MsgBox("鎖定成功")
                ToolStripMenuItemref_Click(Nothing, Nothing)
            Else
                MsgBox("鎖定失敗")
            End If
        End If



    End Sub

    Private Sub ToolStripMenuItemref_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemref.Click
        Dim pc As New ProductionSumLockControl

        If Len(msgLabel.Text) = 1 Then
            GridControl1.DataSource = pc.ProductionSumLock_GetList(Nothing, msgLabel.Text, Nothing, Nothing)
        ElseIf Len(msgLabel.Text) > 0 Then
            GridControl1.DataSource = pc.ProductionSumLock_GetList(Nothing, Nothing, msgLabel.Text, Nothing)
        ElseIf Len(msgLabel.Text) = 0 Then
            GridControl1.DataSource = pc.ProductionSumLock_GetList(Nothing, Nothing, Nothing, Nothing)
        End If

    End Sub

    Private Sub ProductionSumLockModif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductionSumLockModif.Click
        If GridView1.RowCount <= 0 Then
            Exit Sub
        End If

        Dim pc As New ProductionSumLockControl
        Dim pi As New ProductionSumLockInfo

        Dim _AutoID, _FacID, _DepID, _LockYYYYMM, _DepName, _LockCheck As String

        _LockCheck = GridView1.GetFocusedRowCellValue("LockCheck")
        If _LockCheck = False Then
            MsgBox("此記錄未鎖定！")
            Exit Sub
        End If
        _AutoID = GridView1.GetFocusedRowCellValue("AutoID")
        _FacID = GridView1.GetFocusedRowCellValue("FacID")


        _DepName = GridView1.GetFocusedRowCellValue("DepName")
        _DepID = GridView1.GetFocusedRowCellValue("DepID")
        _LockYYYYMM = GridView1.GetFocusedRowCellValue("LockYYYYMM")

        If MsgBox("你確定取消鎖定:  '" & _DepName & " " & _LockYYYYMM & "'  的記錄嗎?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            pi.AutoID = _AutoID
            pi.FacID = _FacID
            pi.DepID = _DepID
            pi.LockYYYYMM = _LockYYYYMM
            pi.LockCheck = False
            pi.AddAction = InUserID
            pi.AddDate = Format(Now, "yyyy/MM/dd")


            If pc.ProductionSumLock_Update(pi) = True Then
                MsgBox("取消鎖定成功")
                ToolStripMenuItemref_Click(Nothing, Nothing)
            Else
                MsgBox("取消鎖定失敗")
            End If
        End If

    End Sub



  
    Private Sub frmProductionSumLockMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TreeListLoad()
        msgLabel.Text = ""
    End Sub
End Class