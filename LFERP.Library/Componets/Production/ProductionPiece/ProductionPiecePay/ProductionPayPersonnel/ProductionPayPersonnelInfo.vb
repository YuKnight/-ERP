Namespace LFERP.Library.ProductionPayPersonnel


    Public Class ProductionPayPersonnelInfo
        ''SUM
        Private _Per_NO As String
        Private _Per_Name As String
        Private _G_NO As String
        Private _G_Name As String
        Private _FacID As String
        Private _DepID As String
        Private _Pay_Check As String
        Private _PaySum_YYMM As String
        Private _Per_DepName As String
        Private _Per_FacName As String
        Private _PL_MeritedPaySum As Double  '匯總額
        Private _PYS_MeritedPaySum As Double
        Private _TotalSum As Double



        Sub New()
            _Per_NO = Nothing
            _Per_Name = Nothing
            _G_NO = Nothing
            _G_Name = Nothing
            _FacID = Nothing
            _DepID = Nothing
            _Pay_Check = Nothing
            _PaySum_YYMM = Nothing
            _Per_DepName = Nothing
            _Per_FacName = Nothing
            _PL_MeritedPaySum = 0
            _PYS_MeritedPaySum = 0
            _TotalSum = 0

        End Sub


        ''' <summary>
        ''' 工號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Per_NO() As String
            Get
                Return _Per_NO
            End Get
            Set(ByVal value As String)
                _Per_NO = value
            End Set
        End Property


        ''' <summary>
        ''' 姓名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Per_Name() As String
            Get
                Return _Per_Name
            End Get
            Set(ByVal value As String)
                _Per_Name = value
            End Set
        End Property


        ''' <summary>
        ''' 組別
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property G_NO() As String
            Get
                Return _G_NO
            End Get
            Set(ByVal value As String)
                _G_NO = value
            End Set
        End Property


        ''' <summary>
        ''' 組別名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property G_Name() As String
            Get
                Return _G_Name
            End Get
            Set(ByVal value As String)
                _G_Name = value
            End Set
        End Property


        ''' <summary>
        ''' 廠別
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property FacID() As String
            Get
                Return _FacID
            End Get
            Set(ByVal value As String)
                _FacID = value
            End Set
        End Property


        ''' <summary>
        ''' 部門
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DepID() As String
            Get
                Return _DepID
            End Get
            Set(ByVal value As String)
                _DepID = value
            End Set
        End Property


        ''' <summary>
        ''' 審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Pay_Check() As String
            Get
                Return _Pay_Check
            End Get
            Set(ByVal value As String)
                _Pay_Check = value
            End Set
        End Property


        ''' <summary>
        ''' 日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PaySum_YYMM() As String
            Get
                Return _PaySum_YYMM
            End Get
            Set(ByVal value As String)
                _PaySum_YYMM = value
            End Set
        End Property


        ''' <summary>
        ''' 部門
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Per_DepName() As String
            Get
                Return _Per_DepName
            End Get
            Set(ByVal value As String)
                _Per_DepName = value
            End Set
        End Property


        ''' <summary>
        ''' 廠別
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Per_FacName() As String
            Get
                Return _Per_FacName
            End Get
            Set(ByVal value As String)
                _Per_FacName = value
            End Set
        End Property


        ''' <summary>
        ''' 匯總
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PL_MeritedPaySum() As Double
            Get
                Return _PL_MeritedPaySum
            End Get
            Set(ByVal value As Double)
                _PL_MeritedPaySum = value
            End Set
        End Property


        ''' <summary>
        ''' 匯總
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PYS_MeritedPaySum() As Double
            Get
                Return _PYS_MeritedPaySum
            End Get
            Set(ByVal value As Double)
                _PYS_MeritedPaySum = value
            End Set
        End Property

        '

        Public Property TotalSum() As Double
            Get
                Return _TotalSum
            End Get
            Set(ByVal value As Double)
                _TotalSum = value
            End Set
        End Property
    End Class

End Namespace
