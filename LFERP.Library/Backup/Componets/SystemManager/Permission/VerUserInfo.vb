Namespace LFERP.VerUser


    Public Class VerUserInfo

        Private _U_ID As String
        Private _Ver As String

        Private _PM_ID As String
        Private _PM_Name As String
        Private _PM_PID As String
        Private _U_Name As String


        Public Sub New()
            _U_ID = Nothing
            _Ver = Nothing

            _PM_ID = Nothing
            _PM_Name = Nothing
            _PM_PID = Nothing
            _U_Name = Nothing
        End Sub

        Public Property U_ID() As String
            Get
                Return _U_ID
            End Get
            Set(ByVal value As String)
                _U_ID = value
            End Set
        End Property

        Public Property Ver() As String
            Get
                Return _Ver
            End Get
            Set(ByVal value As String)
                _Ver = value
            End Set
        End Property

        Public Property PM_ID() As String
            Get
                Return _PM_ID
            End Get
            Set(ByVal value As String)
                _PM_ID = value
            End Set
        End Property

        Public Property PM_Name() As String
            Get
                Return _PM_Name
            End Get
            Set(ByVal value As String)
                _PM_Name = value
            End Set
        End Property
        Public Property PM_PID() As String
            Get
                Return _PM_PID
            End Get
            Set(ByVal value As String)
                _PM_PID = value
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