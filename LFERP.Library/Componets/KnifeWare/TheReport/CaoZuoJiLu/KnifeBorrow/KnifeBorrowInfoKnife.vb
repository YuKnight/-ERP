Namespace LFERP.Library.KnifeWare
    Public Class KnifeBorrowInfoKnife

        Private _B_Num As String
        Private _B_NO As String
        Private _M_Code As String
        Private _WH_ID As String
        Private _BPer_ID As String
        Private _BPer_Name As String
        Private _B_Qty As Double
        Private _R_Qty As Double
        Private _NOReturn As Double
        Private _B_Date As Date
        Private _R_Date As Date
        Private _B_Action As String
        Private _B_Remark As String
        Private _G_NO As String
        Private _B_Type As String
        Private _B_EndQty As Double
        Private _B_AllEndQty As Double
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _WH_Name As String

        Public Sub New()
            _B_Num = Nothing
            _B_NO = Nothing
            _M_Code = Nothing
            _WH_ID = Nothing
            _BPer_ID = Nothing
            _BPer_Name = Nothing
            _B_Qty = 0
            _R_Qty = 0
            _NOReturn = 0
            _B_Date = Nothing
            _R_Date = Nothing
            _B_Action = Nothing
            _B_Remark = Nothing
            _G_NO = Nothing
            _B_Type = Nothing
            _B_EndQty = 0
            _B_AllEndQty = 0
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _WH_Name = Nothing
        End Sub

        Public Property B_Num() As String
            Get
                Return _B_Num
            End Get
            Set(ByVal value As String)
                _B_Num = value
            End Set
        End Property

        Public Property B_NO() As String
            Get
                Return _B_NO
            End Get
            Set(ByVal value As String)
                _B_NO = value
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

        Public Property WH_ID() As String
            Get
                Return _WH_ID
            End Get
            Set(ByVal value As String)
                _WH_ID = value
            End Set
        End Property

        Public Property BPer_ID() As String
            Get
                Return _BPer_ID
            End Get
            Set(ByVal value As String)
                _BPer_ID = value
            End Set
        End Property

        Public Property BPer_Name() As String
            Get
                Return _BPer_Name
            End Get
            Set(ByVal value As String)
                _BPer_Name = value
            End Set
        End Property

        Public Property B_Qty() As Double
            Get
                Return _B_Qty
            End Get
            Set(ByVal value As Double)
                _B_Qty = value
            End Set
        End Property

        Public Property R_Qty() As Double
            Get
                Return _R_Qty
            End Get
            Set(ByVal value As Double)
                _R_Qty = value
            End Set
        End Property

        Public Property NOReturn() As Double
            Get
                Return _NOReturn
            End Get
            Set(ByVal value As Double)
                _NOReturn = value
            End Set
        End Property

        Public Property B_Date() As Date
            Get
                Return _B_Date
            End Get
            Set(ByVal value As Date)
                _B_Date = value
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

        Public Property B_Action() As String
            Get
                Return _B_Action
            End Get
            Set(ByVal value As String)
                _B_Action = value
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

        Public Property G_NO() As String
            Get
                Return _G_NO
            End Get
            Set(ByVal value As String)
                _G_NO = value
            End Set
        End Property

        Public Property B_Type() As String
            Get
                Return _B_Type
            End Get
            Set(ByVal value As String)
                _B_Type = value
            End Set
        End Property

        Public Property B_EndQty() As Double
            Get
                Return _B_EndQty
            End Get
            Set(ByVal value As Double)
                _B_EndQty = value
            End Set
        End Property

        Public Property B_AllEndQty() As Double
            Get
                Return _B_AllEndQty
            End Get
            Set(ByVal value As Double)
                _B_AllEndQty = value
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