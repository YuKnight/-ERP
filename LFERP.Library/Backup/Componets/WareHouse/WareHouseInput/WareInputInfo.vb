Namespace LFERP.Library.WareHouse.WareInput

    Public Class WareInputInfo


        Private _WIP_NUM As String
        Private _WIP_ID As String

        Private _WIP_Type As String

        Private _M_Code As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _WIP_Qty As Double
        Private _WIP_AddDate As Date
        Private _WH_ID As String
        Private _OS_BatchID As String
        Private _WIP_Action As String
        Private _WIP_EditDate As Date
        Private _WIP_Remark As String
        Private _DPT_ID As String
        Private _WIP_Check As Boolean
        Private _WIP_CheckAction As String
        Private _WIP_CheckDate As Date
        Private _WIP_CheckRemark As String
        Private _WIP_ActionName As String
        Private _WIP_CheckActionName As String

        Private _WIP_ReCheck As Boolean
        Private _WIP_ReCheckDate As Date
        Private _WIP_ReCheckAction As String
        Private _WIP_ReCheckRemark As String
        Private _CardID As String

        Private _WH_Name As String    '倉庫名稱
        Private _DPT_Name As String

        Private _WIP_AddDate1 As Date '導出用
        Private _WIP_AddDate2 As Date

        Private _GetQty As Double  '匯總指定條件數量
        Private _GetQty1 As Double '匯總指定條件數量
        Private _WIP_EndQty As Double  '期末結餘數
        Private _WH_PName As String      '上一級倉庫名稱
        Private _WH_AllName As String     '完整倉庫名稱

        Private _RC_NO As String ''退料單
        Private _RC_AutoID As String ''開料單流水號

        Public Sub New()

            _WIP_NUM = Nothing
            _WIP_ID = Nothing

            _WIP_Type = Nothing

            _M_Code = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _WIP_Qty = 0
            _WIP_AddDate = Nothing
            _WH_ID = Nothing
            _OS_BatchID = Nothing
            _WIP_Action = Nothing
            _WIP_EditDate = Nothing
            _WIP_Remark = Nothing
            _DPT_ID = Nothing
            _WIP_Check = False
            _WIP_CheckAction = Nothing
            _WIP_CheckDate = Nothing
            _WIP_CheckRemark = Nothing
            _WIP_CheckActionName = Nothing
            _WIP_ActionName = Nothing

            _WIP_ReCheck = False
            _WIP_ReCheckDate = Nothing
            _WIP_ReCheckAction = Nothing
            _WIP_ReCheckRemark = Nothing
            _CardID = Nothing

            _WH_Name = Nothing
            _DPT_Name = Nothing

            _WIP_AddDate1 = Nothing
            _WIP_AddDate2 = Nothing

            _GetQty = 0
            _GetQty1 = 0
            _WIP_EndQty = 0
            _WH_PName = Nothing
            _WH_AllName = Nothing

            _RC_NO = Nothing
            _RC_AutoID = Nothing

        End Sub
        Public Property WIP_NUM() As String
            Get
                Return _WIP_NUM
            End Get
            Set(ByVal value As String)
                _WIP_NUM = value
            End Set
        End Property



        ''' <summary>
        ''' 入庫編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ''' 
        Public Property WIP_ID() As String
            Get
                Return _WIP_ID
            End Get
            Set(ByVal value As String)
                _WIP_ID = value
            End Set
        End Property

        Public Property WIP_Type() As String
            Get
                Return _WIP_Type
            End Get
            Set(ByVal value As String)
                _WIP_Type = value
            End Set
        End Property

        Public Property M_Code() As String
            Get
                Return _M_Code
            End Get
            Set(ByVal value As String)
                _M_Code = value
            End Set
        End Property
        Public Property M_Name() As String
            Get
                Return _M_Name
            End Get
            Set(ByVal value As String)
                _M_Name = value
            End Set
        End Property
        Public Property M_Gauge() As String
            Get
                Return _M_Gauge
            End Get
            Set(ByVal value As String)
                _M_Gauge = value
            End Set
        End Property
        Public Property M_Unit() As String
            Get
                Return _M_Unit
            End Get
            Set(ByVal value As String)
                _M_Unit = value
            End Set
        End Property

        Public Property WIP_Qty() As Double
            Get
                Return _WIP_Qty
            End Get
            Set(ByVal value As Double)
                _WIP_Qty = value
            End Set
        End Property
        Public Property WIP_AddDate() As Date
            Get
                Return _WIP_AddDate
            End Get
            Set(ByVal value As Date)
                _WIP_AddDate = value
            End Set
        End Property
        Public Property WH_ID() As String
            Get
                Return _WH_ID
            End Get
            Set(ByVal value As String)
                _WH_ID = value
            End Set
        End Property
        Public Property OS_BatchID() As String
            Get
                Return _OS_BatchID
            End Get
            Set(ByVal value As String)
                _OS_BatchID = value
            End Set
        End Property
        Public Property WIP_Action() As String
            Get
                Return _WIP_Action
            End Get
            Set(ByVal value As String)
                _WIP_Action = value
            End Set
        End Property
        Public Property WIP_EditDate() As Date
            Get
                Return _WIP_EditDate
            End Get
            Set(ByVal value As Date)
                _WIP_EditDate = value
            End Set
        End Property
        Public Property WIP_Remark() As String
            Get
                Return _WIP_Remark
            End Get
            Set(ByVal value As String)
                _WIP_Remark = value
            End Set
        End Property
        Public Property DPT_ID() As String
            Get
                Return _DPT_ID
            End Get
            Set(ByVal value As String)
                _DPT_ID = value
            End Set
        End Property
        Public Property WIP_Check() As Boolean
            Get
                Return _WIP_Check
            End Get
            Set(ByVal value As Boolean)
                _WIP_Check = value
            End Set
        End Property
        Public Property WIP_CheckAction() As String
            Get
                Return _WIP_CheckAction
            End Get
            Set(ByVal value As String)
                _WIP_CheckAction = value
            End Set
        End Property
        Public Property WIP_CheckDate() As Date
            Get
                Return _WIP_CheckDate
            End Get
            Set(ByVal value As Date)
                _WIP_CheckDate = value
            End Set
        End Property
        Public Property WIP_CheckRemark() As String
            Get
                Return _WIP_CheckRemark
            End Get
            Set(ByVal value As String)
                _WIP_CheckRemark = value
            End Set
        End Property


        Public Property WIP_CheckActionName() As String
            Get
                Return _WIP_CheckActionName
            End Get
            Set(ByVal value As String)
                _WIP_CheckActionName = value
            End Set
        End Property

        Public Property WIP_ActionName() As String
            Get
                Return _WIP_ActionName
            End Get
            Set(ByVal value As String)
                _WIP_ActionName = value
            End Set
        End Property
        Public Property WH_Name() As String
            Get
                Return _WH_Name
            End Get
            Set(ByVal value As String)
                _WH_Name = value
            End Set
        End Property
        Public Property DPT_Name() As String
            Get
                Return _DPT_Name
            End Get
            Set(ByVal value As String)
                _DPT_Name = value
            End Set
        End Property


        Public Property WIP_AddDate1() As Date
            Get
                Return _WIP_AddDate1
            End Get
            Set(ByVal value As Date)
                _WIP_AddDate1 = value
            End Set
        End Property
        Public Property WIP_AddDate2() As Date
            Get
                Return _WIP_AddDate2
            End Get
            Set(ByVal value As Date)
                _WIP_AddDate2 = value
            End Set
        End Property
        Public Property GetQty() As Double
            Get
                Return _GetQty
            End Get
            Set(ByVal value As Double)
                _GetQty = value
            End Set
        End Property
        Public Property GetQty1() As Double
            Get
                Return _GetQty1
            End Get
            Set(ByVal value As Double)
                _GetQty1 = value
            End Set
        End Property

        Public Property WIP_ReCheck() As Boolean
            Get
                Return _WIP_ReCheck
            End Get
            Set(ByVal value As Boolean)
                _WIP_ReCheck = value
            End Set
        End Property

        Public Property WIP_ReCheckDate() As Date
            Get
                Return _WIP_ReCheckDate
            End Get
            Set(ByVal value As Date)
                _WIP_ReCheckDate = value
            End Set
        End Property
        Public Property WIP_ReCheckAction() As String
            Get
                Return _WIP_ReCheckAction
            End Get
            Set(ByVal value As String)
                _WIP_ReCheckAction = value
            End Set
        End Property
        Public Property WIP_ReCheckRemark() As String
            Get
                Return _WIP_ReCheckRemark
            End Get
            Set(ByVal value As String)
                _WIP_ReCheckRemark = value
            End Set
        End Property
        Public Property CardID() As String
            Get
                Return _CardID
            End Get
            Set(ByVal value As String)
                _CardID = value
            End Set
        End Property
        Public Property WIP_EndQty() As Double
            Get
                Return _WIP_EndQty
            End Get
            Set(ByVal value As Double)
                _WIP_EndQty = value
            End Set
        End Property

        Public Property WH_PName() As String
            Get
                Return _WH_PName
            End Get
            Set(ByVal value As String)
                _WH_PName = value
            End Set
        End Property

        Public Property WH_AllName() As String
            Get
                Return _WH_AllName
            End Get
            Set(ByVal value As String)
                _WH_AllName = value
            End Set
        End Property

        ''退料單
        Public Property RC_NO() As String
            Get
                Return _RC_NO
            End Get
            Set(ByVal value As String)
                _RC_NO = value
            End Set
        End Property

        ' 開料單流水號
        Public Property RC_AutoID() As String
            Get
                Return _RC_AutoID
            End Get
            Set(ByVal value As String)
                _RC_AutoID = value
            End Set
        End Property
    End Class

End Namespace
