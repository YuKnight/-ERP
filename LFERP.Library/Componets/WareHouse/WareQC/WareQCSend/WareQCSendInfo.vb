

Namespace LFERP.Library.WareHouse.WareQCSend

    Public Class WareQCSendInfo

        Private _AutoID As String
        Private _WQS_NO As String
        Private _M_Code As String
        Private _WQS_Qty As Single
        Private _WQS_NotRecoverQty As Single
        Private _A_AcceptanceNO As String
        Private _WH_ID As String
        Private _WQS_Date As Date
        Private _WQS_Action As String
        Private _WQS_Check As Boolean
        Private _WQS_CheckAction As String
        Private _WQS_Remark As String

        Private _M_Name As String
        Private _M_Gauge As String
        Private _UserName As String
        Private _WH_Name As String


        Sub New()

            _WQS_NO = Nothing
            _M_Code = Nothing
            _WQS_Qty = 0
            _WQS_NotRecoverQty = 0
            _A_AcceptanceNO = Nothing
            _WH_ID = Nothing
            _WQS_Date = Nothing
            _WQS_Action = Nothing
            _WQS_Check = False
            _WQS_CheckAction = Nothing
            _WQS_Remark = Nothing

            _M_Name = Nothing
            _M_Gauge = Nothing
            _AutoID = Nothing
            _UserName = Nothing
            _WH_Name = Nothing
        End Sub
        Public Property WQS_NO() As String
            Get
                Return _WQS_NO
            End Get
            Set(ByVal value As String)
                _WQS_NO = value
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
        Public Property WQS_Qty() As Single
            Get
                Return _WQS_Qty
            End Get
            Set(ByVal value As Single)
                _WQS_Qty = value
            End Set
        End Property
        Public Property WQS_NotRecoverQty() As Single
            Get
                Return _WQS_NotRecoverQty
            End Get
            Set(ByVal value As Single)
                _WQS_NotRecoverQty = value
            End Set
        End Property
        Public Property A_AcceptanceNO() As String
            Get
                Return _A_AcceptanceNO
            End Get
            Set(ByVal value As String)
                _A_AcceptanceNO = value
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
        Public Property WQS_Date() As Date
            Get
                Return _WQS_Date
            End Get
            Set(ByVal value As Date)
                _WQS_Date = value
            End Set
        End Property
        Public Property WQS_Action() As String
            Get
                Return _WQS_Action
            End Get
            Set(ByVal value As String)
                _WQS_Action = value
            End Set
        End Property
        Public Property WQS_Check() As Boolean
            Get
                Return _WQS_Check
            End Get
            Set(ByVal value As Boolean)
                _WQS_Check = value
            End Set
        End Property
        Public Property WQS_CheckAction() As String
            Get
                Return _WQS_CheckAction
            End Get
            Set(ByVal value As String)
                _WQS_CheckAction = value
            End Set
        End Property
        Public Property WQS_Remark() As String
            Get
                Return _WQS_Remark
            End Get
            Set(ByVal value As String)
                _WQS_Remark = value
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
        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property
        Public Property UserName() As String
            Get
                Return _UserName
            End Get
            Set(ByVal value As String)
                _UserName = value
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
    End Class

End Namespace
