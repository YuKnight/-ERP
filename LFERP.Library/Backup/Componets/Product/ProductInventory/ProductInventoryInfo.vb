Namespace LFERP.Library.Product

    Public Class ProductInventoryInfo

        Private _AutoID As String     '自動編號ID
        Private _PM_M_Code As String     '產品編號
        Private _M_Code As String     '物料編號
        Private _WH_ID As String     '倉庫編號
        Private _PI_Qty As Integer     '庫存數量
        Private _WH_Name As String     '倉庫名稱
        Private _WH_PName As String     '上一級倉庫名稱
        Private _M_Name As String     '物料名稱
        Private _M_Gauge As String     '物料規格
        Private _M_Unit As String     '物料單位
        Private _WI_Qty As Double      '庫存數量   @ 2013/4/24 添加
        Private _PM_JiYu As String

        Sub New()
            _AutoID = Nothing
            _PM_M_Code = Nothing
            _M_Code = Nothing
            _WH_ID = Nothing
            _PI_Qty = 0
            _WH_Name = Nothing
            _WH_PName = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _WI_Qty = 0
        End Sub
        ''' <summary>
        ''' 自動編號ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property
        ''' <summary>
        ''' 產品編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_M_Code() As String
            Get
                Return _PM_M_Code
            End Get
            Set(ByVal value As String)
                _PM_M_Code = value
            End Set
        End Property
        ''' <summary>
        ''' 物料編碼
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Code() As String
            Get
                Return _M_Code
            End Get
            Set(ByVal value As String)
                _M_Code = value
            End Set
        End Property
        ''' <summary>
        ''' 倉庫編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property WH_ID() As String
            Get
                Return _WH_ID
            End Get
            Set(ByVal value As String)
                _WH_ID = value
            End Set
        End Property
        ''' <summary>
        ''' 庫存數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PI_Qty() As Integer
            Get
                Return _PI_Qty
            End Get
            Set(ByVal value As Integer)
                _PI_Qty = value
            End Set
        End Property
        ''' <summary>
        ''' 倉庫名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property WH_Name() As String
            Get
                Return _WH_Name
            End Get
            Set(ByVal value As String)
                _WH_Name = value
            End Set
        End Property
        ''' <summary>
        ''' 上一級倉庫名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property WH_PName() As String
            Get
                Return _WH_PName
            End Get
            Set(ByVal value As String)
                _WH_PName = value
            End Set
        End Property
        ''' <summary>
        ''' 物料名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Name() As String
            Get
                Return _M_Name
            End Get
            Set(ByVal value As String)
                _M_Name = value
            End Set
        End Property
        ''' <summary>
        ''' 物料規格
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Gauge() As String
            Get
                Return _M_Gauge
            End Get
            Set(ByVal value As String)
                _M_Gauge = value
            End Set
        End Property
        ''' <summary>
        ''' 物料單位
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Unit() As String
            Get
                Return _M_Unit
            End Get
            Set(ByVal value As String)
                _M_Unit = value
            End Set
        End Property
        ''' <summary>
        ''' 庫存數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property WI_Qty() As Double
            Get
                Return _WI_Qty
            End Get
            Set(ByVal value As Double)
                _WI_Qty = value
            End Set
        End Property


        Public Property PM_JiYu() As String
            Get
                Return _PM_JiYu
            End Get
            Set(ByVal value As String)
                _PM_JiYu = value
            End Set
        End Property

    End Class
End Namespace