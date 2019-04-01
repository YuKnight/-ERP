Namespace LFERP.Library.KnifeWare
    Public Class KnifeGroupInfo
        Private _AutoID As String
        Private _G_NO As String
        Private _G_Name As String
        Private _Remark As String
        Private _WH_ID As String

        Sub New()
            _AutoID = Nothing
            _G_NO = Nothing
            _G_Name = Nothing
            _Remark = Nothing
            _WH_ID = Nothing
        End Sub

        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property

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

        Public Property Remark() As String
            Get
                Return _Remark
            End Get
            Set(ByVal value As String)
                _Remark = value
            End Set
        End Property

        Public Property WH_ID() As String
            Get
                Return _WH_ID
            End Get
            Set(ByVal value As String)
                _WH_ID = value
            End Set
        End Property

    End Class
End Namespace
