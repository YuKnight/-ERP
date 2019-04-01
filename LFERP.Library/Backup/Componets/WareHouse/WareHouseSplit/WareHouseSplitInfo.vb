
Namespace LFERP.Library.WareHouse.WareHouseSplit

    Public Class WareHouseSplitInfo
        Private _S_ID As String
        Private _WH_ID As String
        Private _M_LCode As String
        Private _M_SCode As String
        Private _S_Type As String

        Private _S_Qty As Double
        Private _S_Ratio As String
        Private _WI_LQty As Double
        Private _WI_SQty As Double
        Private _S_AddDate As Date

        Private _S_Action As String
        Private _S_Remark As String
        Private _M_Name As String
        Private _Unit1 As String '大單位
        Private _Unit2 As String '小單位



        Sub New()
            _S_ID = Nothing
            _WH_ID = Nothing
            _M_LCode = Nothing
            _M_SCode = Nothing
            _S_Type = Nothing

            _S_Qty = 0
            _S_Ratio = Nothing
            _WI_LQty = Nothing
            _WI_SQty = Nothing
            _S_AddDate = Nothing

            _S_Action = Nothing
            _S_Remark = Nothing
            _M_Name = Nothing
            _Unit1 = Nothing
            _Unit2 = Nothing

        End Sub

        Public Property S_ID() As String
            Get
                Return _S_ID
            End Get
            Set(ByVal value As String)
                _S_ID = value
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
        Public Property M_LCode() As String
            Get
                Return _M_LCode
            End Get
            Set(ByVal value As String)
                _M_LCode = value
            End Set
        End Property
        Public Property M_SCode() As String
            Get
                Return _M_SCode
            End Get
            Set(ByVal value As String)
                _M_SCode = value
            End Set
        End Property
        Public Property S_Type() As String
            Get
                Return _S_Type
            End Get
            Set(ByVal value As String)
                _S_Type = value
            End Set
        End Property
        Public Property S_Qty() As Double
            Get
                Return _S_Qty
            End Get
            Set(ByVal value As Double)
                _S_Qty = value
            End Set
        End Property
        Public Property S_Ratio() As String
            Get
                Return _S_Ratio
            End Get
            Set(ByVal value As String)
                _S_Ratio = value
            End Set
        End Property
        Public Property WI_LQty() As Double
            Get
                Return _WI_LQty
            End Get
            Set(ByVal value As Double)
                _WI_LQty = value
            End Set
        End Property
        Public Property WI_SQty() As Double
            Get
                Return _WI_SQty
            End Get
            Set(ByVal value As Double)
                _WI_SQty = value
            End Set
        End Property
        Public Property S_AddDate() As Date
            Get
                Return _S_AddDate
            End Get
            Set(ByVal value As Date)
                _S_AddDate = value
            End Set
        End Property
        Public Property S_Action() As String
            Get
                Return _S_Action
            End Get
            Set(ByVal value As String)
                _S_Action = value
            End Set
        End Property
        Public Property S_Remark() As String
            Get
                Return _S_Remark
            End Get
            Set(ByVal value As String)
                _S_Remark = value
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
        Public Property Unit1() As String
            Get
                Return _Unit1
            End Get
            Set(ByVal value As String)
                _Unit1 = value
            End Set
        End Property
        Public Property Unit2() As String
            Get
                Return _Unit2
            End Get
            Set(ByVal value As String)
                _Unit2 = value
            End Set
        End Property
    End Class

End Namespace

