Imports System
Imports System.IO
Imports LFERP.SystemManager
Imports LFERP.Library.ProductProcess
Imports LFERP.Library.PieceProcessMoSub

Public Class FrmPieceImport

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        '導入
        Dim pc As New PieceProcessMoSubControl
        Dim pi As New PieceProcessMoSubInfo
        Dim ptc As New ProcessMainControl
        Dim ptiL As New List(Of ProcessMainInfo)

        Label24.Text = GetNO() '計件工藝單號

        pi.PM_NO = Label24.Text

        pi.PM_M_Code = GridLookUpEdit1.EditValue
        pi.Pro_Type = ComboBoxEdit1.Text
        pi.Type3ID = ComboBoxEdit2.Text
        pi.PM_AddDate = Format(Now, "yyyy/MM/dd")
        pi.PM_Action = InUserID

        If pc.PieceProcessMo_Add(pi) = False Then
            MsgBox("主表保存失敗!")
            Exit Sub
        End If

        ptiL = ptc.ProcessMain_GetList(Nothing, GridLookUpEdit1.EditValue, ComboBoxEdit1.Text, ComboBoxEdit2.Text, Nothing, Nothing)
        If ptiL.Count > 0 Then
            For i As Integer = 0 To ptiL.Count - 1

                pi.PM_NO = Label24.Text
                pi.PM_Num = GetNum()
                pi.PS_NO = ptiL(i).PS_NO
                pi.PS_Num = ptiL(i).PS_Num
                pi.PM_Name = ptiL(i).PS_Name
                pi.PM_DepNO = Nothing
                pi.PM_DepName = Nothing
                pi.PM_Price = Nothing
                pi.PM_Explain = Nothing
                pi.PM_CheckPrice = False
                pi.PM_Factor = "1"
                pi.PM_CheckFactor = False
                pi.PM_Type = "大貨"
                pi.PM_DayNight = "白班"
                pi.PM_Enable = True

                If pc.PieceProcessMoSub_Add(pi) = False Then
                    MsgBox("導入失敗!")
                    Exit Sub
                End If

            Next
        Else
            MsgBox("生產工藝單號不存在!")
        End If


        Me.Close()
    End Sub
    Private Function GetNum() As String
        Dim pc As New PieceProcessMoSubControl
        Dim pi As New PieceProcessMoSubInfo
        pi = pc.PieceProcessMoSub_GetNum(Label24.Text)
        If pi Is Nothing Then
            GetNum = Trim(Label24.Text) & "-" & "01"
        Else
            GetNum = Trim(Label24.Text) & "-" & CStr(Microsoft.VisualBasic.Right(CInt(Microsoft.VisualBasic.Right(pi.PM_Num, 2)) + 101, 2))
        End If

    End Function
    Private Function GetNO() As String

        Dim pc As New PieceProcessMoSubControl
        Dim pi As New PieceProcessMoSubInfo
        Dim str As String
        str = CStr(Format(Now, "yyMM"))
        pi = pc.PieceProcessMo_GetNO(str)
        If pi Is Nothing Then
            GetNO = "PM" & str & "0001"
        Else
            GetNO = "PM" & str & Mid((CInt(Mid(pi.PM_NO, 6)) + 10001), 2)
        End If

    End Function
 
    Private Sub FrmPieceImport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim pc As New LFERP.Library.Product.ProductController
        GridLookUpEdit1.Properties.DataSource = pc.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        GridLookUpEdit1.Properties.DisplayMember = "PM_M_Code"
        GridLookUpEdit1.Properties.ValueMember = "PM_M_Code"
    End Sub

    Private Sub GridLookUpEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridLookUpEdit1.EditValueChanged
        Dim prc As New ProcessMainControl
        Dim priL As New List(Of ProcessMainInfo)
        priL = prc.ProcessMain_GetList1(Nothing, GridLookUpEdit1.EditValue, ComboBoxEdit1.Text, Nothing)
        ComboBoxEdit2.Properties.Items.Clear()
        For i As Integer = 0 To priL.Count - 1
            ComboBoxEdit2.Properties.Items.Add(priL(i).Type3ID)
        Next
    End Sub

End Class