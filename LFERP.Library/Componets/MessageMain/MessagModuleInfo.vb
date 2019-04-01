Namespace LFERP.Library.MessageMain


    Public Class MessagModuleInfo

        Private _MM_ID As String
        Private _MM_Name As String
        Private _MM_PID As String
        Private _MM_Image As String
        Private _MM_SelectImage As String

        Public Sub New()
            _MM_Name = Nothing
            _MM_ID = Nothing
            _MM_PID = Nothing
            _MM_Image = Nothing
            _MM_SelectImage = Nothing
        End Sub

        Public Property MM_ID() As String
            Get
                Return _MM_ID
            End Get
            Set(ByVal value As String)
                _MM_ID = value
            End Set
        End Property
        Public Property MM_Name() As String
            Get
                Return _MM_Name
            End Get
            Set(ByVal value As String)
                _MM_Name = value
            End Set
        End Property
        Public Property MM_PID() As String

            Get
                Return _MM_PID
            End Get
            Set(ByVal value As String)
                _MM_PID = value
            End Set

        End Property

        Public Property MM_Image() As String
            Get
                Return _MM_Image
            End Get
            Set(ByVal value As String)
                _MM_Image = value
            End Set
        End Property
        Public Property MM_SelectImage() As String
            Get
                Return _MM_SelectImage
            End Get
            Set(ByVal value As String)
                _MM_SelectImage = value
            End Set
        End Property



    End Class

End Namespace