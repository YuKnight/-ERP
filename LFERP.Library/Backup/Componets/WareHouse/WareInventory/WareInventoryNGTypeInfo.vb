Namespace LFERP.Library.WareHouse.WareInventoryNGType

    Public Class WareInventoryNGTypeInfo

        Private _M_Code As String

        Private _AutoID As Int32
        Private _NGType As String
        Private _NGName As String
        Private _NGMaterial As String
        Private _Remark As String

        Private _AddAction As String
        Private _AddDate As Date
        Private _UpdateAction As String
        Private _UpdateDate As String

        Private _AddActionName As String
        Private _UpdateActionName As String


        Sub New()
            _M_Code = Nothing

            _AutoID = Nothing
            _NGType = Nothing
            _NGName = Nothing
            _NGMaterial = Nothing
            _Remark = Nothing

            _AddAction = Nothing
            _AddDate = Nothing
            _UpdateAction = Nothing
            _UpdateDate = Nothing

            _AddActionName = Nothing
            _UpdateActionName = Nothing

        End Sub
        Public Property M_Code() As String
            Get
                Return _M_Code
            End Get
            Set(ByVal value As String)
                _M_Code = value
            End Set
        End Property


        Public Property AutoID() As Int32
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Int32)
                _AutoID = value
            End Set
        End Property


        Public Property NGType() As String
            Get
                Return _NGType
            End Get
            Set(ByVal value As String)
                _NGType = value
            End Set
        End Property


        Public Property NGName() As String
            Get
                Return _NGName
            End Get
            Set(ByVal value As String)
                _NGName = value
            End Set
        End Property

        Public Property NGMaterial() As String
            Get
                Return _NGMaterial
            End Get
            Set(ByVal value As String)
                _NGMaterial = value
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



        Public Property AddAction() As String
            Get
                Return _AddAction
            End Get
            Set(ByVal value As String)
                _AddAction = value
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

        Public Property UpdateAction() As String
            Get
                Return _UpdateAction
            End Get
            Set(ByVal value As String)
                _UpdateAction = value
            End Set
        End Property

        Public Property UpdateDate() As Date
            Get
                Return _UpdateDate
            End Get
            Set(ByVal value As Date)
                _UpdateDate = value
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

        Public Property UpdateActionName() As String
            Get
                Return _UpdateActionName
            End Get
            Set(ByVal value As String)
                _UpdateActionName = value
            End Set
        End Property

    End Class

End Namespace