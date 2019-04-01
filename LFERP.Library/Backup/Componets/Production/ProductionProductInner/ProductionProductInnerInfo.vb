Namespace LFERP.Library.Production.ProductionProductInner

    Public Class ProductionProductInnerInfo
        Private _AutoID As Int32
        Private _Pro_Type As String
        Private _PM_M_Code As String
        Private _PM_Type As String
        Private _Pro_Type1 As String

        Private _PM_M_Code1 As String
        Private _PM_Type1 As String
        Private _AddDate As Date
        Private _AddAction As String
        Private _YesOrNo As Boolean

        Private _AddActionName As String

        Sub New()
            _AutoID = Nothing
            _Pro_Type = Nothing
            _PM_M_Code = Nothing
            _PM_Type = Nothing
            _Pro_Type1 = Nothing

            _PM_M_Code1 = Nothing
            _PM_Type1 = Nothing
            _AddDate = Nothing
            _AddAction = Nothing
            _YesOrNo = False

            _AddActionName = Nothing
        End Sub

        Public Property AutoID() As Int32
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Int32)
                _AutoID = value
            End Set
        End Property

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


        Public Property Pro_Type1() As String
            Get
                Return _Pro_Type1
            End Get
            Set(ByVal value As String)
                _Pro_Type1 = value
            End Set
        End Property


        Public Property PM_M_Code1() As String
            Get
                Return _PM_M_Code1
            End Get
            Set(ByVal value As String)
                _PM_M_Code1 = value
            End Set
        End Property


        Public Property PM_Type1() As String
            Get
                Return _PM_Type1
            End Get
            Set(ByVal value As String)
                _PM_Type1 = value
            End Set
        End Property


        Public Property AddDate() As Date
            Get
                Return _AddDate
            End Get
            Set(ByVal value As Date)
                _AddDate = value
            End Set
        End Property

        Public Property AddAction() As String
            Get
                Return _AddAction
            End Get
            Set(ByVal value As String)
                _AddAction = value
            End Set
        End Property

        Public Property YesOrNo() As Boolean
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Boolean)
                _YesOrNo = value
            End Set
        End Property

        Public Property AddActionName() As String
            Get
                Return _AddActionName
            End Get
            Set(ByVal value As String)
                _AddActionName = value
            End Set
        End Property


    End Class



End Namespace