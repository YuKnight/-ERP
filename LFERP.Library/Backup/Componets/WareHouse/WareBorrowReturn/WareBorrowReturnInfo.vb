Namespace LFERP.Library.WareHouse.WareBorrowReturn
    Public Class WareBorrowReturnInfo
        Private _WB_NUM As String
        Private _WB_NO As String
        Private _WB_Type As String
        Private _M_Code As String
        Private _Qty As Double

        Private _NO_ReQty As Double
        Private _DPT_ID As String
        Private _WB_PerID As String
        Private _WB_PerName As String
        Private _WH_ID As String

        Private _WB_Action As String
        Private _WB_Date As Date
        Private _RR_PerID As String
        Private _RR_PerName As String
        Private _Remark As String

        Private _AutoID As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _WB_ActionName As String

        Private _WH_Name As String
        Private _WH_PName As String
        Private _DPT_Name As String
        Private _DPT_PName As String

        Private _WB_EndQty As Double
        Private _SumNO_ReQty As Double
        Private _SumQty As Double

        Private _WBR_NO As String
        Private _WBR_QtyStr As String
        Private _QtyReal As Double
        Private _RemarkReal As String

        Private _WR_NUM As String

        ''-------------以下針對產、延期還刀的操作
        Private _DelayDate As String
        Private _DelayRemark As String
        Private _DelayAction As String
        Private _DelayActionName As String

        '       	@DelayDate	    datetime,
        '@DelayRemark	nvarchar(20),
        '@DelayAction	nvarchar(50)


        Sub New()
            _WB_NUM = Nothing
            _WB_NO = Nothing
            _WB_Type = Nothing
            _M_Code = Nothing
            _Qty = 0

            _NO_ReQty = 0
            _DPT_ID = Nothing
            _WB_PerID = Nothing
            _WB_PerName = Nothing
            _WH_ID = Nothing

            _WB_Action = Nothing
            _WB_Date = Nothing
            _RR_PerID = Nothing
            _RR_PerName = Nothing
            _Remark = Nothing

            _AutoID = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _WB_ActionName = Nothing

            _WH_Name = Nothing
            _WH_PName = Nothing
            _DPT_Name = Nothing
            _DPT_PName = Nothing

            _WB_EndQty = 0
            _SumNO_ReQty = 0
            _SumQty = 0

            _WBR_NO = Nothing
            _WBR_QtyStr = Nothing

            _QtyReal = 0
            _RemarkReal = Nothing

            _WR_NUM = Nothing

            _DelayDate = Nothing
            _DelayRemark = Nothing
            _DelayAction = Nothing
            _DelayActionName = Nothing

        End Sub

        Public Property WR_NUM() As String
            Get
                Return _WR_NUM
            End Get
            Set(ByVal value As String)
                _WR_NUM = value
            End Set
        End Property

        Public Property RemarkReal() As String
            Get
                Return _RemarkReal
            End Get
            Set(ByVal value As String)
                _RemarkReal = value
            End Set
        End Property

        Public Property QtyReal() As Double
            Get
                Return _QtyReal
            End Get
            Set(ByVal value As Double)
                _QtyReal = value
            End Set
        End Property

        Public Property WBR_QtyStr() As String
            Get
                Return _WBR_QtyStr
            End Get
            Set(ByVal value As String)
                _WBR_QtyStr = value
            End Set
        End Property

        Public Property DPT_PName() As String
            Get
                Return _DPT_PName
            End Get
            Set(ByVal value As String)
                _DPT_PName = value
            End Set
        End Property

        Public Property WBR_NO() As String
            Get
                Return _WBR_NO
            End Get
            Set(ByVal value As String)
                _WBR_NO = value
            End Set
        End Property


        Public Property SumNO_ReQty() As Double
            Get
                Return _SumNO_ReQty
            End Get
            Set(ByVal value As Double)
                _SumNO_ReQty = value
            End Set
        End Property


        Public Property SumQty() As Double
            Get
                Return _SumQty
            End Get
            Set(ByVal value As Double)
                _SumQty = value
            End Set
        End Property

        Public Property WB_EndQty() As Double
            Get
                Return _WB_EndQty
            End Get
            Set(ByVal value As Double)
                _WB_EndQty = value
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

        ''--------------------------------------------------------------
        Public Property WB_NUM() As String
            Get
                Return _WB_NUM
            End Get
            Set(ByVal value As String)
                _WB_NUM = value
            End Set
        End Property

        Public Property WB_NO() As String
            Get
                Return _WB_NO
            End Get
            Set(ByVal value As String)
                _WB_NO = value
            End Set
        End Property


        Public Property WB_Type() As String
            Get
                Return _WB_Type
            End Get
            Set(ByVal value As String)
                _WB_Type = value
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

        Public Property Qty() As Double
            Get
                Return _Qty
            End Get
            Set(ByVal value As Double)
                _Qty = value
            End Set
        End Property

        ''------------------------------------------------------------------------------
        Public Property NO_ReQty() As Double
            Get
                Return _NO_ReQty
            End Get
            Set(ByVal value As Double)
                _NO_ReQty = value
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


        Public Property WB_PerID() As String
            Get
                Return _WB_PerID
            End Get
            Set(ByVal value As String)
                _WB_PerID = value
            End Set
        End Property


        Public Property WB_PerName() As String
            Get
                Return _WB_PerName
            End Get
            Set(ByVal value As String)
                _WB_PerName = value
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

        ''---------------------------------------------------

        Public Property WB_Action() As String
            Get
                Return _WB_Action
            End Get
            Set(ByVal value As String)
                _WB_Action = value
            End Set
        End Property

        Public Property WB_Date() As Date
            Get
                Return _WB_Date
            End Get
            Set(ByVal value As Date)
                _WB_Date = value
            End Set
        End Property

        Public Property RR_PerID() As String
            Get
                Return _RR_PerID
            End Get
            Set(ByVal value As String)
                _RR_PerID = value
            End Set
        End Property

        Public Property RR_PerName() As String
            Get
                Return _RR_PerName
            End Get
            Set(ByVal value As String)
                _RR_PerName = value
            End Set
        End Property


        Public Property Remark() As String
            Get
                Return _Remark
            End Get
            Set(ByVal value As String)
                _Remark = value
            End Set
        End Property

        ''-------------------------------------------------------------------

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

        Public Property WB_ActionName() As String
            Get
                Return _WB_ActionName
            End Get
            Set(ByVal value As String)
                _WB_ActionName = value
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

        Public Property WH_PName() As String
            Get
                Return _WH_PName
            End Get
            Set(ByVal value As String)
                _WH_PName = value
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

        '_DelayDate = Nothing
        '    _DelayRemark = Nothing
        '    _DelayAction = Nothing

        Public Property DelayDate() As String
            Get
                Return _DelayDate
            End Get
            Set(ByVal value As String)
                _DelayDate = value
            End Set
        End Property

        Public Property DelayRemark() As String
            Get
                Return _DelayRemark
            End Get
            Set(ByVal value As String)
                _DelayRemark = value
            End Set
        End Property

        Public Property DelayAction() As String
            Get
                Return _DelayAction
            End Get
            Set(ByVal value As String)
                _DelayAction = value
            End Set
        End Property

        '
        Public Property DelayActionName() As String
            Get
                Return _DelayActionName
            End Get
            Set(ByVal value As String)
                _DelayActionName = value
            End Set
        End Property

    End Class
End Namespace
