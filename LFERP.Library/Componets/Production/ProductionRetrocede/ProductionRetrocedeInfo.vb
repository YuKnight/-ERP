

Namespace LFERP.Library.ProductionRetrocede

    Public Class ProductionRetrocedeInfo

        Private _IndexNO As String
        Private _R_NO As String
        Private _R_Type As String
        Private _WH_OutID As String
        Private _WH_InID As String
        Private _Pro_Type As String
        Private _PM_M_Code As String
        Private _PM_Type As String
        ''Private _Pro_NO As String
        Private _R_Qty As Single
        Private _R_NoSendQty As Single
        Private _R_Remark As String
        Private _R_Date As Date
        Private _R_Detail As String
        Private _R_Action As String
        Private _R_Check As Boolean
        Private _R_CheckAction As String
        Private _R_CheckDate As Date
        Private _R_CheckRemark As String

        Private _WH_Name As String
        Private _WH_InName As String
        ''Private _PS_Name As String
        Private _ActionName As String
        Private _CheckActionName As String



        Private _R_InCheck As Boolean
        Private _R_InCheckAction As String
        Private _R_InCheckDate As Date
        Private _R_InCheckRemark As String
        Private _R_InCheckActionName As String

        Sub New()
            _IndexNO = 0
            _R_NO = Nothing
            _R_Type = Nothing
            _WH_OutID = Nothing
            _WH_InID = Nothing
            _Pro_Type = Nothing
            _PM_M_Code = Nothing
            _PM_Type = Nothing
            '_Pro_NO = Nothing
            _R_Qty = 0
            _R_NoSendQty = 0
            _R_Remark = Nothing
            _R_Date = Nothing
            _R_Detail = Nothing
            _R_Action = Nothing
            _R_Check = False
            _R_CheckAction = Nothing
            _R_CheckDate = Nothing
            _R_CheckRemark = Nothing

            _WH_Name = Nothing
            _WH_InName = Nothing
            '_PS_Name = Nothing
            _ActionName = Nothing
            _CheckActionName = Nothing


            _R_InCheck = False
            _R_InCheckAction = Nothing
            _R_InCheckDate = Nothing
            _R_InCheckRemark = Nothing
            _R_InCheckActionName = Nothing



        End Sub



        Public Property R_InCheck() As Boolean
            Get
                Return _R_InCheck
            End Get
            Set(ByVal value As Boolean)
                _R_InCheck = value
            End Set
        End Property

        Public Property R_InCheckAction() As String
            Get
                Return _R_InCheckAction
            End Get
            Set(ByVal value As String)
                _R_InCheckAction = value
            End Set
        End Property

        Public Property R_InCheckDate() As Date
            Get
                Return _R_InCheckDate
            End Get
            Set(ByVal value As Date)
                _R_InCheckDate = value
            End Set
        End Property

        Public Property R_InCheckRemark() As String
            Get
                Return _R_InCheckRemark
            End Get
            Set(ByVal value As String)
                _R_InCheckRemark = value
            End Set
        End Property

        Public Property R_InCheckActionName() As String
            Get
                Return _R_InCheckActionName
            End Get
            Set(ByVal value As String)
                _R_InCheckActionName = value
            End Set
        End Property


        Public Property IndexNO() As String
            Get
                Return _IndexNO
            End Get
            Set(ByVal value As String)
                _IndexNO = value
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
        Public Property R_Type() As String
            Get
                Return _R_Type
            End Get
            Set(ByVal value As String)
                _R_Type = value
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
        Public Property R_Qty() As Single
            Get
                Return _R_Qty
            End Get
            Set(ByVal value As Single)
                _R_Qty = value
            End Set
        End Property
        Public Property R_NoSendQty() As Single
            Get
                Return _R_NoSendQty
            End Get
            Set(ByVal value As Single)
                _R_NoSendQty = value
            End Set
        End Property
        Public Property R_Remark() As String
            Get
                Return _R_Remark
            End Get
            Set(ByVal value As String)
                _R_Remark = value
            End Set
        End Property
        Public Property R_Date() As Date
            Get
                Return _R_Date
            End Get
            Set(ByVal value As Date)
                _R_Date = value
            End Set
        End Property
        Public Property R_Detail() As String
            Get
                Return _R_Detail
            End Get
            Set(ByVal value As String)
                _R_Detail = value
            End Set
        End Property
        Public Property R_Action() As String
            Get
                Return _R_Action
            End Get
            Set(ByVal value As String)
                _R_Action = value
            End Set
        End Property
        Public Property R_Check() As Boolean
            Get
                Return _R_Check
            End Get
            Set(ByVal value As Boolean)
                _R_Check = value
            End Set
        End Property
        Public Property R_CheckAction() As String
            Get
                Return _R_CheckAction
            End Get
            Set(ByVal value As String)
                _R_CheckAction = value
            End Set
        End Property
        Public Property R_CheckDate() As Date
            Get
                Return _R_CheckDate
            End Get
            Set(ByVal value As Date)
                _R_CheckDate = value
            End Set
        End Property
        Public Property R_CheckRemark() As String
            Get
                Return _R_CheckRemark
            End Get
            Set(ByVal value As String)
                _R_CheckRemark = value
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

