Namespace LFERP.Library.OrdersChange
    Public Class OrdersChangeInfo

        Private _OM_ID As String
        Private _PM_M_CodeOld As String
        Private _PM_M_CodeNew As String
        Private _Remark As String
        Private _U_ID As String
        Private _OrderDate As Date
        Private _U_Name As String
        Private _ChangeType As String
        Private _ChangeTypeName As String

        Public Sub New()
            _OM_ID = Nothing
            _PM_M_CodeOld = Nothing
            _PM_M_CodeNew = Nothing
            _Remark = Nothing
            _U_ID = Nothing
            _OrderDate = Nothing
            _U_Name = Nothing
            _ChangeType = Nothing
            _ChangeTypeName = Nothing

        End Sub

        Public Property ChangeTypeName() As String
            Get
                Return _ChangeTypeName
            End Get
            Set(ByVal value As String)
                _ChangeTypeName = value
            End Set
        End Property

        Public Property ChangeType() As String
            Get
                Return _ChangeType
            End Get
            Set(ByVal value As String)
                _ChangeType = value
            End Set
        End Property

        Public Property OM_ID() As String
            Get
                Return _OM_ID
            End Get
            Set(ByVal value As String)
                _OM_ID = value
            End Set
        End Property


        Public Property PM_M_CodeOld() As String
            Get
                Return _PM_M_CodeOld
            End Get
            Set(ByVal value As String)
                _PM_M_CodeOld = value
            End Set
        End Property


        Public Property PM_M_CodeNew() As String
            Get
                Return _PM_M_CodeNew
            End Get
            Set(ByVal value As String)
                _PM_M_CodeNew = value
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


        Public Property U_ID() As String
            Get
                Return _U_ID
            End Get
            Set(ByVal value As String)
                _U_ID = value
            End Set
        End Property

        Public Property OrderDate() As Date
            Get
                Return _OrderDate
            End Get
            Set(ByVal value As Date)
                _OrderDate = value
            End Set
        End Property

        Public Property U_Name() As String
            Get
                Return _U_Name
            End Get
            Set(ByVal value As String)
                _U_Name = value
            End Set
        End Property


    End Class

End Namespace