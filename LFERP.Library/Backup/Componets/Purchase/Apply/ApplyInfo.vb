Namespace LFERP.Library.Purchase.Apply

    Public Class ApplyInfo
        Private _AM_ID As String
        Private _M_ID As String
        Private _M_Code As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _M_Qty As Double
        Private _M_SendQty As Double
        Private _M_Useful As String
        Private _M_Remark As String
        Private _M_Department As String
        Private _M_UserID As String
        Private _AM_Date As Date
        Private _Temp_Code As String
        Private _M_Type As String  '申領類型'N'--可申領,'Y' 取消申領
        Private _AM_ID_Pri As String                         '原申領單號         @2012/8/28
        Private _M_Department_Pri As String            '原申領部門         @2012/8/28
        Private _M_UserID_Pri As String                    '原申領人           @2012/8/28
        Private _tuihuanhuonum As Double      '退換貨數量      @2012/1/12/4

        Sub New()

            _AM_ID = Nothing
            _M_ID = 0
            _M_Code = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _M_Qty = 0
            _M_SendQty = 0
            _M_Useful = Nothing
            _M_Remark = Nothing
            _M_Department = Nothing
            _M_UserID = Nothing
            _AM_Date = Nothing
            _Temp_Code = Nothing
            _M_Type = Nothing
            _AM_ID_Pri = Nothing
            _M_Department_Pri = Nothing
            _M_UserID_Pri = Nothing
            _tuihuanhuonum = 0

        End Sub

        Public Property AM_ID() As String
            Get
                Return _AM_ID
            End Get
            Set(ByVal value As String)
                _AM_ID = value
            End Set
        End Property
        Public Property M_ID() As String
            Get
                Return _M_ID
            End Get
            Set(ByVal value As String)
                _M_ID = value
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
        Public Property M_Qty() As Double
            Get
                Return _M_Qty
            End Get
            Set(ByVal value As Double)
                _M_Qty = value
            End Set
        End Property
        Public Property M_SendQty() As Double
            Get
                Return _M_SendQty
            End Get
            Set(ByVal value As Double)
                _M_SendQty = value
            End Set
        End Property
        Public Property M_Useful() As String
            Get
                Return _M_Useful
            End Get
            Set(ByVal value As String)
                _M_Useful = value
            End Set
        End Property
        Public Property M_Remark() As String
            Get
                Return _M_Remark
            End Get
            Set(ByVal value As String)
                _M_Remark = value
            End Set
        End Property
        Public Property M_Department() As String
            Get
                Return _M_Department
            End Get
            Set(ByVal value As String)
                _M_Department = value
            End Set
        End Property
        Public Property M_UserID() As String
            Get
                Return _M_UserID
            End Get
            Set(ByVal value As String)
                _M_UserID = value
            End Set
        End Property
        Public Property AM_Date() As Date
            Get
                Return _AM_Date
            End Get
            Set(ByVal value As Date)
                _AM_Date = value
            End Set
        End Property
        Public Property Temp_Code() As String
            Get
                Return _Temp_Code
            End Get
            Set(ByVal value As String)
                _Temp_Code = value
            End Set
        End Property
        Public Property M_Type() As String
            Get
                Return _M_Type
            End Get
            Set(ByVal value As String)
                _M_Type = value
            End Set
        End Property
        Public Property AM_ID_Pri() As String
            Get
                Return _AM_ID_Pri
            End Get
            Set(ByVal value As String)
                _AM_ID_Pri = value
            End Set
        End Property
        Public Property M_Department_Pri() As String
            Get
                Return _M_Department_Pri
            End Get
            Set(ByVal value As String)
                _M_Department_Pri = value
            End Set
        End Property
        Public Property M_UserID_Pri() As String
            Get
                Return _M_UserID_Pri
            End Get
            Set(ByVal value As String)
                _M_UserID_Pri = value
            End Set
        End Property
        Public Property Tuihuanhuonum() As Double
            Get
                Return _tuihuanhuonum
            End Get
            Set(ByVal value As Double)
                _tuihuanhuonum = 0
            End Set

        End Property
    End Class

End Namespace

