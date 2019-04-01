Imports LFERP.SystemManager
Imports LFERP.SystemManager.SystemUser
Imports System.IO

Imports System.Data.SqlClient
Imports system.data.oledb

Imports LFERPDB

Public Class Login
    Public uu As New SystemUserController
    Dim isEnter As Boolean

    Public IOPath As String = "C:\lferp\聯豐企業資源管理系統\UserLog.txt"
    Public XMLPath As String = "C:\lferp\聯豐企業資源管理系統\Ver.xml"



    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sb2.Click
        Me.Close()
    End Sub

    Private Sub txtuserpsw_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtuserpsw.Enter
        If Trim(txtuserid.Text) <> "" Then
            Dim us As SystemUserInfo = uu.SystemUser_Get(txtuserid.Text.ToString)
            If us Is Nothing Then
                MsgBox("用戶不存在！", 64, "提示")
                Label1.Text = "此用戶不存在"
                txtuserid.Focus()
                txtuserid.SelectAll()
                Exit Sub
            End If
            Label1.Text = us.U_Name
            InUserID = us.U_ID
        End If
    End Sub

    Private Sub txtuserpsw_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtuserpsw.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' check()
            sb1_Click(Nothing, Nothing)
        End If
    End Sub

    Sub check()
        If Trim(txtuserid.Text) = "" Then
            MsgBox("請輸入廠証！", 64, "提示")
            txtuserid.Focus()
        Else
            Dim us As SystemUserInfo = uu.SystemUser_Get(txtuserid.Text.ToString)
            If us Is Nothing Then
                MsgBox("用戶不存在！", 64, "提示")
                Label1.Text = "此用戶不存在"
                txtuserid.Focus()
                txtuserid.SelectAll()
                Exit Sub
            ElseIf us.U_PassWord.Equals(txtuserpsw.Text) Then
                If us.U_Enabled = True Then
                    strUserLoginTime = Format(Now, "yyyy/MM/dd HH:mm:ss")
                    UserName = Label1.Text  '登錄用戶名
                    InUserID = us.U_ID      '登錄用戶ID
                    InUser = Label1.Text    '登錄用戶名
                    strInDPT_ID = us.DPT_ID     '登錄用戶所屬部門ID
                    strInDepName = us.DepName   '登錄用戶所屬生產部門名稱

                    strInUserRank = us.UserRank '登錄用戶所擁有的生產權限等級
                    strInUserType = us.UserType '工藝類型

                    strInCompany = Mid(strInDPT_ID, 1, 4)         ''登錄用戶所屬公司數字代號

                    If us.DepID Is Nothing Then
                        strInDepID = "不存在"
                    Else
                        If strInUserRank = "生產部" Then
                            strInDepID = Mid(us.DepID, 1, 1)    '登錄用戶所屬生產部門ID
                            strInFacID = Mid(us.DepID, 1, 1)    '登錄用戶所屬廠別ID
                        ElseIf strInUserRank = "管理" Then
                            strInDepID = Nothing
                            strInFacID = Nothing
                        ElseIf strInUserRank = "統計" Then
                            strInDepID = us.DepID
                            strInFacID = Mid(us.DepID, 1, 1)
                        End If

                        strInFacIDFull = Mid(us.DepID, 1, 1)
                        strInDepIDFull = us.DepID  ''用戶所屬部門全稱

                    End If

                    Dim pmws As New PermissionModuleWarrantSubController
                    Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

                    pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "880408")
                    If pmwiL.Count > 0 Then
                        strRefCard = pmwiL.Item(0).PMWS_Value
                    End If

                    My.Settings.UserID = txtuserid.Text.Trim
                    My.Settings.Save()
                    Me.Hide()

                    MDIMain.Show()
                Else
                    MsgBox("無此用戶!", 64, "提示")
                    txtuserpsw.Text = ""
                    txtuserid.Focus()
                    txtuserid.SelectAll()
                End If
            Else
                If txtuserpsw.Text = "" Then
                    MsgBox("請輸入密碼！", 64, "提示")
                Else
                    MsgBox("密碼錯誤,請重新輸入密碼！", 64, "提示")
                    txtuserpsw.Text = ""
                End If
                txtuserpsw.Focus()
            End If
        End If
    End Sub

    Private Sub sb1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sb1.Click
        If WriteUserXmlUpdateYN(txtuserid.Text) = True Then
            Dim str As String
            str = "C:\lferp\自動更新\AutoUpdateNew.exe"
            If Dir(str) = "" Then
            Else
                System.Diagnostics.Process.Start("C:\lferp\自動更新\AutoUpdateNew.exe")
                Exit Sub
            End If
        End If


        check()
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim str As String
        'str = "C:\lferp\自動更新\AutoUpdate.exe"
        'If Dir(str) = "" Then
        'Else
        '    System.Diagnostics.Process.Start("C:\lferp\自動更新\AutoUpdate.exe")
        'End If
        txtuserid.Text = My.Settings.UserID
        If txtuserid.Text.Trim = "" Then
            txtuserid.Select()
        Else
            txtuserpsw.Select()
        End If

        strVer = "2014-04-08 V2.0.7"  '程序版本號，手動改變
        CheckUpdate()

    End Sub




    Function WriteUserXmlUpdateYN(ByVal U_ID As String) As Boolean

        WriteUserXmlUpdateYN = False

        Dim dsA As New DataSet
        With dsA.Tables.Add("U_IDVer")
            .Columns.Add("U_ID", GetType(String))
            .Columns.Add("Ver", GetType(String))
        End With
        '-------------------------------------------------------------------------------
        Dim strVer As String
        Dim dsVer As New DataSet

        dsVer = DataSet("select U_ID,Ver from VerUser where U_ID= '" + U_ID + "'")
        If dsVer.Tables(0).Rows.Count <= 0 Then
            Exit Function
        End If
        strVer = dsVer.Tables(0).Rows(0)("Ver").ToString


        If Dir(IOPath, FileAttribute.Directory) <> "" Then
            Kill(IOPath)
        End If
        Using sw As StreamWriter = File.AppendText(IOPath)
            sw.WriteLine(U_ID & "," & strVer)
            sw.Close()
        End Using


        '-------------------------------------------------------------------------------
        If Dir(XmlPath, FileAttribute.Directory) = "" Then
            Dim row As DataRow
            row = dsA.Tables(0).NewRow
            row("U_ID") = U_ID
            row("Ver") = strVer
            dsA.Tables(0).Rows.Add(row)
            dsA.WriteXml(XmlPath)
            Exit Function
        End If
        '-------------------------------------------------------------------------------
        dsA.ReadXml(XmlPath)

        Dim Bz As String = ""
        Dim i As Integer
        If dsA.Tables(0).Rows.Count > 0 Then
            For i = 0 To dsA.Tables(0).Rows.Count - 1
                If dsA.Tables(0).Rows(i)("U_ID").ToString = U_ID Then
                    Bz = "Y"
                    If strVer = dsA.Tables(0).Rows(i)("Ver").ToString Then
                    Else
                        WriteUserXmlUpdateYN = True
                    End If
                End If
            Next
        End If
        '-------------------------------------------------------------------------------
        If Bz = "" Then
            Dim row As DataRow
            row = dsA.Tables(0).NewRow
            row("U_ID") = U_ID
            row("Ver") = strVer
            dsA.Tables(0).Rows.Add(row)
        End If

        dsA.WriteXml(XmlPath)

    End Function

    Function DataSet(ByVal sql As String) As DataSet

        Dim ai As New LFERPDataBase

        Dim ds As New DataSet
        Dim conn As SqlConnection
        Dim da As SqlDataAdapter
        conn = New SqlConnection
        conn.ConnectionString = ai.LoadConnStr
        conn.Open()
        da = New SqlDataAdapter(sql, conn)
        da.Fill(ds)

        da.Dispose()
        conn.Close()
        Return ds
    End Function
End Class
