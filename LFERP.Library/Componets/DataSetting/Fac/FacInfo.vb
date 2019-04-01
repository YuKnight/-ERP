
Namespace LFERP.DataSetting
    Public Class FacInfo
        Private _facID As String
        Private _facName As String
        Private _facRemark As String

        Sub New()
            _facID = ""
            _facName = ""
            _facRemark = ""
        End Sub


        Public Property FacID() As String
            Get
                Return _facID
            End Get
            Set(ByVal value As String)
                _facID = value
            End Set
        End Property


        Public Property FacName() As String
            Get
                Return _facName
            End Get
            Set(ByVal value As String)
                _facName = value
            End Set
        End Property
        Public Property FacRemark() As String
            Get
                Return _facRemark
            End Get
            Set(ByVal value As String)
                _facRemark = value
            End Set
        End Property

    End Class

End Namespace