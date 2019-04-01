
Namespace LFERP.Library.ProductionBalance

    Public Class ProductionBalanceInfo

        Private _AutoID As String
        Private _B_ID As String
        Private _DPT_ID As String
        Private _M_Code As String
        Private _WI_Qty As Single
        Private _WI_ReQty As Single
        Private _B_Action As String
        Private _B_AddDate As Date
        Private _B_Remark As String
        Private _B_Check As Boolean
        Private _B_CheckAction As String
        Private _B_CheckDate As Date
        Private _B_CheckRemark As String


        Private _ActionName As String
        Private _CheckActionName As String
        Private _PS_Name As String
        Private _DepName As String
        Private _PM_M_Code As String
        Private _Pro_Type As String
        Private _Type3ID As String  ''工藝流程類型

        Sub New()
            _AutoID = 0
            _B_ID = Nothing
            _DPT_ID = Nothing
            _M_Code = Nothing
            _WI_Qty = 0
            _WI_ReQty = 0
            _B_Action = Nothing
            _B_AddDate = Nothing
            _B_Remark = Nothing
            _B_Check = False
            _B_CheckAction = Nothing
            _B_CheckDate = Nothing
            _B_CheckRemark = Nothing

            _ActionName = Nothing
            _CheckActionName = Nothing
            _PS_Name = Nothing
            _DepName = Nothing


            _PM_M_Code = Nothing
            _Pro_Type = Nothing
            _Type3ID = Nothing

        End Sub

        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property
        Public Property B_ID() As String
            Get
                Return _B_ID
            End Get
            Set(ByVal value As String)
                _B_ID = value
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
        Public Property M_Code() As String
            Get
                Return _M_Code
            End Get
            Set(ByVal value As String)
                _M_Code = value
            End Set
        End Property
        Public Property WI_Qty() As Single
            Get
                Return _WI_Qty
            End Get
            Set(ByVal value As Single)
                _WI_Qty = value
            End Set
        End Property
        Public Property WI_ReQty() As Single
            Get
                Return _WI_ReQty
            End Get
            Set(ByVal value As Single)
                _WI_ReQty = value
            End Set
        End Property
        Public Property B_Action() As String
            Get
                Return _B_Action
            End Get
            Set(ByVal value As String)
                _B_Action = value
            End Set
        End Property
        Public Property B_AddDate() As Date
            Get
                Return _B_AddDate
            End Get
            Set(ByVal value As Date)
                _B_AddDate = value
            End Set
        End Property
        Public Property B_Remark() As String
            Get
                Return _B_Remark
            End Get
            Set(ByVal value As String)
                _B_Remark = value
            End Set
        End Property
        Public Property B_Check() As Boolean
            Get
                Return _B_Check
            End Get
            Set(ByVal value As Boolean)
                _B_Check = value
            End Set
        End Property
        Public Property B_CheckAction() As String
            Get
                Return _B_CheckAction
            End Get
            Set(ByVal value As String)
                _B_CheckAction = value
            End Set
        End Property
        Public Property B_CheckDate() As Date
            Get
                Return _B_CheckDate
            End Get
            Set(ByVal value As Date)
                _B_CheckDate = value
            End Set
        End Property
        Public Property B_CheckRemark() As String
            Get
                Return _B_CheckRemark
            End Get
            Set(ByVal value As String)
                _B_CheckRemark = value
            End Set
        End Property

        Public Property ActionName() As String
            Get
                Return _ActionName
            End Get
            Set(ByVal value As String)
                _ActionName = value
            End Set
        End Property
        Public Property CheckActionName() As String
            Get
                Return _CheckActionName
            End Get
            Set(ByVal value As String)
                _CheckActionName = value
            End Set
        End Property
        Public Property PS_Name() As String
            Get
                Return _PS_Name
            End Get
            Set(ByVal value As String)
                _PS_Name = value
            End Set
        End Property
        Public Property DepName() As String
            Get
                Return _DepName
            End Get
            Set(ByVal value As String)
                _DepName = value
            End Set
        End Property
        Public Property PM_M_Code() As String
            Get
                Return _PM_M_Code
            End Get
            Set(ByVal value As String)
                _PM_M_Code = value
            End Set
        End Property
        Public Property Pro_Type() As String
            Get
                Return _Pro_Type
            End Get
            Set(ByVal value As String)
                _Pro_Type = value
            End Set
        End Property
        Public Property Type3ID() As String
            Get
                Return _Type3ID
            End Get
            Set(ByVal value As String)
                _Type3ID = value
            End Set
        End Property

    End Class

End Namespace

