Namespace LFERP.DataSetting

    Public Class AuxiliaryDataInfo

        Private _BasicMainType As Decimal
        Private _BasicMainName As String
        Private _BasicMainDescription As String
        Private _CreateUserID As String
        Private _CreateDate As DateTime
        Private _ModifyUserID As String
        Private _ModifyDate As DateTime
        Private _Remark As String

        Public Sub New()
            _BasicMainType = 0
            _BasicMainName = Nothing
            _BasicMainDescription = Nothing
            _CreateUserID = Nothing
            _CreateDate = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing
            _Remark = Nothing

        End Sub
        Public Property BasicMainType() As Decimal
            Get
                Return _BasicMainType
            End Get
            Set(ByVal value As Decimal)
                _BasicMainType = value
            End Set
        End Property
        Public Property BasicMainName() As String
            Get
                Return _BasicMainName
            End Get
            Set(ByVal value As String)
                _BasicMainName = value
            End Set
        End Property
        Public Property CreateUserID() As String
            Get
                Return _CreateUserID
            End Get
            Set(ByVal value As String)
                _CreateUserID = value
            End Set
        End Property
        Public Property BasicMainDescription() As String
            Get
                Return _BasicMainDescription
            End Get
            Set(ByVal value As String)
                _BasicMainDescription = value
            End Set
        End Property
        Public Property CreateDate() As DateTime
            Get
                Return _CreateDate
            End Get
            Set(ByVal value As DateTime)
                _CreateDate = value
            End Set
        End Property
        Public Property ModifyUserID() As String
            Get
                Return _ModifyUserID
            End Get
            Set(ByVal value As String)
                _ModifyUserID = value
            End Set
        End Property
        Public Property ModifyDate() As DateTime
            Get
                Return _ModifyDate
            End Get
            Set(ByVal value As DateTime)
                _ModifyDate = value
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
    End Class

End Namespace
