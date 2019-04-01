
Namespace LFERP.Library.Production.ProductionType

    Public Class ProductionOutWardTypeInfo

        Private _AutoID As String
        Private _PM_M_Code As String
        Private _PM_Type As String
        Private _OW_Do As String
        Private _OW_Return As String
        Private _OW_ReQty As Int32
        Private _PM_JiYu As String


        Sub New()
            _PM_JiYu = Nothing

            _AutoID = 0
            _PM_M_Code = Nothing
            _PM_Type = Nothing
            _OW_Do = Nothing
            _OW_Return = Nothing
            _OW_ReQty = 0
        End Sub

        Public Property PM_JiYu() As String
            Get
                Return _PM_JiYu
            End Get
            Set(ByVal value As String)
                _PM_JiYu = value
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
        Public Property OW_Do() As String
            Get
                Return _OW_Do
            End Get
            Set(ByVal value As String)
                _OW_Do = value
            End Set
        End Property

        Public Property OW_Return() As String
            Get
                Return _OW_Return
            End Get
            Set(ByVal value As String)
                _OW_Return = value
            End Set
        End Property
        Public Property OW_ReQty() As Integer
            Get
                Return _OW_ReQty
            End Get
            Set(ByVal value As Integer)
                _OW_ReQty = value
            End Set
        End Property

    End Class

End Namespace

