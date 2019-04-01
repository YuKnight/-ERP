
Namespace LFERP.Library.ProductionMaterial

    Public Class ProductionMaterialInfo

        Private _Pro_Type As String
        Private _PM_M_Code As String
        Private _PM_Type As String
        Private _M_Code As String
        Private _M_Qty As Single

        '---------------------------------  記錄原材料使用狀況結餘記錄
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _Pro_Rate As Single
        '---------------------------------
        Private _M_Date As Date    '每天結餘信息記錄（天記錄字段）



        Sub New()  '初始化字段

            _Pro_Type = Nothing
            _PM_M_Code = Nothing
            _PM_Type = Nothing
            _M_Code = Nothing
            _M_Qty = 0

            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _Pro_Rate = 0
            _M_Date = Nothing
        End Sub

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
        Public Property M_Code() As String
            Get
                Return _M_Code
            End Get
            Set(ByVal value As String)
                _M_Code = value
            End Set
        End Property
        Public Property M_Qty() As Single
            Get
                Return _M_Qty
            End Get
            Set(ByVal value As Single)
                _M_Qty = value
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
        Public Property Pro_Rate() As Single
            Get
                Return _Pro_Rate
            End Get
            Set(ByVal value As Single)
                _Pro_Rate = value
            End Set
        End Property
        Public Property M_Date() As Date
            Get
                Return _M_Date
            End Get
            Set(ByVal value As Date)
                _M_Date = value
            End Set
        End Property
    End Class

End Namespace

