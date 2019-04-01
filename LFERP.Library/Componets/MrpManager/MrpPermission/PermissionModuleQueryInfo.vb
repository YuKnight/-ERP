Namespace LFERP.Library.MrpManager.MrpPermission
    Public Class PermissionModuleQueryInfo
        Private _PMS_ID As String
        Private _Category As String
        Private _Type As String
        Private _FieldName As String
        Private _AutoID As String
        Public Sub New()
            _PMS_ID = Nothing
            _Category = Nothing
            _Type = Nothing
            _FieldName = Nothing
            _AutoID = Nothing
        End Sub
        Public Property PMS_ID() As String
            Get
                Return _PMS_ID
            End Get
            Set(ByVal value As String)
                _PMS_ID = value
            End Set
        End Property
        Public Property Category() As String
            Get
                Return _Category
            End Get
            Set(ByVal value As String)
                _Category = value
            End Set
        End Property

        Public Property Type() As String
            Get
                Return _Type
            End Get
            Set(ByVal value As String)
                _Type = value
            End Set
        End Property
        Public Property FieldName() As String
            Get
                Return _FieldName
            End Get
            Set(ByVal value As String)
                _FieldName = value
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
    End Class
End Namespace