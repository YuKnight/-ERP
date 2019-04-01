Namespace LFERP.Library.Orders
    Public Class OrdersDetailInfo
        Private _OS_BatchID As String
        Private _OD_ID As String
        Private _OD_Name As String
        Private _OD_Detail As String


        Private _PM_JiYu As String
        Private _OM_CusterNO As String
        Private _PM_M_Code As String



        Public Sub New()
            _OS_BatchID = ""
            _OD_ID = ""
            _OD_Name = ""
            _OD_Detail = ""
            _PM_JiYu = ""
            _OM_CusterNO = ""
            _PM_M_Code = ""

        End Sub

        ''' <summary>
        ''' 生產批次
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_BatchID() As String
            Get
                Return _OS_BatchID
            End Get
            Set(ByVal value As String)
                _OS_BatchID = value
            End Set
        End Property


        ''' <summary>
        ''' 項目流水號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OD_ID() As String
            Get
                Return _OD_ID
            End Get
            Set(ByVal value As String)
                _OD_ID = value
            End Set
        End Property

        ''' <summary>
        ''' 項目名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OD_Name() As String
            Get
                Return _OD_Name
            End Get
            Set(ByVal value As String)
                _OD_Name = value
            End Set
        End Property

        ''' <summary>
        ''' 內容
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OD_Detail() As String
            Get
                Return _OD_Detail
            End Get
            Set(ByVal value As String)
                _OD_Detail = value
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
        Public Property OM_CusterNO() As String
            Get
                Return _OM_CusterNO
            End Get
            Set(ByVal value As String)
                _OM_CusterNO = value
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

    End Class
End Namespace