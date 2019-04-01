

Namespace LFERP.Library.ProductionReturn

    Public Class ProductionReturnInfo

        Private _AutoID As String
        Private _AR_NO As String
        Private _R_NO As String
        Private _AR_Type As String
        Private _WH_OutID As String
        Private _WH_InID As String
        Private _Pro_Type As String
        Private _PM_M_Code As String
        Private _PM_Type As String
        'Private _Pro_NO As String
        Private _AR_Qty As Double
        Private _AR_Remark As String
        Private _AR_Date As Date
        Private _AR_Detail As String
        Private _AR_Action As String
        Private _AR_Check As Boolean
        Private _AR_CheckAction As String
        Private _AR_CheckDate As Date
        Private _AR_CheckRemark As String

        Private _WH_Name As String
        Private _WH_InName As String
        'Private _PS_Name As String
        Private _ActionName As String
        Private _CheckActionName As String

        Private _AR_InCheck As Boolean
        Private _AR_InCheckAction As String
        Private _AR_InCheckDate As Date
        Private _AR_InCheckRemark As String
        Private _AR_InCheckActionName As String

        Private _SumR_Qty As Double
        Private _SumR_NoSendQty As Double
        Private _AR_RInfo As String 'ÃöÁp¦©¼Æ


        Sub New()

            _AutoID = 0
            _AR_NO = Nothing
            _R_NO = Nothing
            _AR_Type = Nothing
            _WH_OutID = Nothing
            _WH_InID = Nothing
            _Pro_Type = Nothing
            _PM_M_Code = Nothing
            _PM_Type = Nothing
            '_Pro_NO = Nothing
            _AR_Qty = 0
            _AR_Remark = Nothing
            _AR_Date = Nothing
            _AR_Detail = Nothing
            _AR_Action = Nothing
            _AR_Check = False
            _AR_CheckAction = Nothing
            _AR_CheckDate = Nothing
            _AR_CheckRemark = Nothing

            _WH_Name = Nothing
            _WH_InName = Nothing
            '_PS_Name = Nothing
            _ActionName = Nothing
            _CheckActionName = Nothing

            _AR_InCheck = False
            _AR_InCheckDate = Nothing
            _AR_InCheckRemark = Nothing
            _AR_InCheckAction = Nothing
            _AR_InCheckActionName = Nothing

            _SumR_Qty = 0
            _SumR_NoSendQty = 0
            _AR_RInfo = Nothing

        End Sub

        Public Property AR_RInfo() As String
            Get
                Return _AR_RInfo
            End Get
            Set(ByVal value As String)
                _AR_RInfo = value
            End Set
        End Property

        Public Property SumR_Qty() As Double
            Get
                Return _SumR_Qty
            End Get
            Set(ByVal value As Double)
                _SumR_Qty = value
            End Set
        End Property


        Public Property SumR_NoSendQty() As Double
            Get
                Return _SumR_NoSendQty
            End Get
            Set(ByVal value As Double)
                _SumR_NoSendQty = value
            End Set
        End Property

        Public Property AR_InCheck() As Boolean
            Get
                Return _AR_InCheck
            End Get
            Set(ByVal value As Boolean)
                _AR_InCheck = value
            End Set
        End Property

        Public Property AR_InCheckDate() As Date
            Get
                Return _AR_InCheckDate
            End Get
            Set(ByVal value As Date)
                _AR_InCheckDate = value
            End Set
        End Property

        Public Property AR_InCheckRemark() As String
            Get
                Return _AR_InCheckRemark
            End Get
            Set(ByVal value As String)
                _AR_InCheckRemark = value
            End Set
        End Property

        Public Property AR_InCheckAction() As String
            Get
                Return _AR_InCheckAction
            End Get
            Set(ByVal value As String)
                _AR_InCheckAction = value
            End Set
        End Property

        Public Property AR_InCheckActionName() As String
            Get
                Return _AR_InCheckActionName
            End Get
            Set(ByVal value As String)
                _AR_InCheckActionName = value
            End Set
        End Property


        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property
        Public Property AR_NO() As String
            Get
                Return _AR_NO
            End Get
            Set(ByVal value As String)
                _AR_NO = value
            End Set
        End Property
        Public Property R_NO() As String
            Get
                Return _R_NO
            End Get
            Set(ByVal value As String)
                _R_NO = value
            End Set
        End Property
        Public Property AR_Type() As String
            Get
                Return _AR_Type
            End Get
            Set(ByVal value As String)
                _AR_Type = value
            End Set
        End Property
        Public Property WH_OutID() As String
            Get
                Return _WH_OutID
            End Get
            Set(ByVal value As String)
                _WH_OutID = value
            End Set
        End Property
        Public Property WH_InID() As String
            Get
                Return _WH_InID
            End Get
            Set(ByVal value As String)
                _WH_InID = value
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
        Public Property PM_M_Code() As String
            Get
                Return _PM_M_Code
            End Get
            Set(ByVal value As String)
                _PM_M_Code = value
            End Set
        End Property
        Public Property PM_Type() As String
            Get
                Return _PM_Type
            End Get
            Set(ByVal value As String)
                _PM_Type = value
            End Set
        End Property
        'Public Property Pro_NO() As String
        '    Get
        '        Return _Pro_NO
        '    End Get
        '    Set(ByVal value As String)
        '        _Pro_NO = value
        '    End Set
        'End Property
        Public Property AR_Qty() As Double
            Get
                Return _AR_Qty
            End Get
            Set(ByVal value As Double)
                _AR_Qty = value
            End Set
        End Property
        Public Property AR_Remark() As String
            Get
                Return _AR_Remark
            End Get
            Set(ByVal value As String)
                _AR_Remark = value
            End Set
        End Property
        Public Property AR_Date() As Date
            Get
                Return _AR_Date
            End Get
            Set(ByVal value As Date)
                _AR_Date = value
            End Set
        End Property
        Public Property AR_Detail() As String
            Get
                Return _AR_Detail
            End Get
            Set(ByVal value As String)
                _AR_Detail = value
            End Set
        End Property
        Public Property AR_Action() As String
            Get
                Return _AR_Action
            End Get
            Set(ByVal value As String)
                _AR_Action = value
            End Set
        End Property
        Public Property AR_Check() As Boolean
            Get
                Return _AR_Check
            End Get
            Set(ByVal value As Boolean)
                _AR_Check = value
            End Set
        End Property
        Public Property AR_CheckAction() As String
            Get
                Return _AR_CheckAction
            End Get
            Set(ByVal value As String)
                _AR_CheckAction = value
            End Set
        End Property
        Public Property AR_CheckDate() As Date
            Get
                Return _AR_CheckDate
            End Get
            Set(ByVal value As Date)
                _AR_CheckDate = value
            End Set
        End Property
        Public Property AR_CheckRemark() As String
            Get
                Return _AR_CheckRemark
            End Get
            Set(ByVal value As String)
                _AR_CheckRemark = value
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
        Public Property WH_InName() As String
            Get
                Return _WH_InName
            End Get
            Set(ByVal value As String)
                _WH_InName = value
            End Set
        End Property
        'Public Property PS_Name() As String
        '    Get
        '        Return _PS_Name
        '    End Get
        '    Set(ByVal value As String)
        '        _PS_Name = value
        '    End Set
        'End Property
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

    End Class

End Namespace


