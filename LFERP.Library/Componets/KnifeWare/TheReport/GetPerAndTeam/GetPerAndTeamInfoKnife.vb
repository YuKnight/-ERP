Namespace LFERP.Library.KnifeWare
    Public Class GetPerAndTeamInfoKnife

        Private _G_NO As String
        Private _G_Name As String
        Private _Per_Name As String
        Private _Per_ID As String

        Public Sub New()

            _G_NO = Nothing
            _G_Name = Nothing
            _Per_Name = Nothing
            _Per_ID = Nothing

        End Sub

        Public Property G_NO() As String
            Get
                Return _G_NO
            End Get
            Set(ByVal value As String)
                _G_NO = value
            End Set
        End Property

        Public Property G_Name() As String
            Get
                Return _G_Name
            End Get
            Set(ByVal value As String)
                _G_Name = value
            End Set
        End Property

        Public Property Per_Name() As String
            Get
                Return _Per_Name
            End Get
            Set(ByVal value As String)
                _Per_Name = value
            End Set
        End Property

        Public Property Per_ID() As String
            Get
                Return _Per_ID
            End Get
            Set(ByVal value As String)
                _Per_ID = value
            End Set
        End Property

    End Class
End Namespace