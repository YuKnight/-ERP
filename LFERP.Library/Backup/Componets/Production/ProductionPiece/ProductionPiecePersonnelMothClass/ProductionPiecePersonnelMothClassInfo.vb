Namespace LFERP.Library.ProductionPiecePersonnelMothClass

    Public Class ProductionPiecePersonnelMothClassInfo
        Private _AutoID As String
        Private _Per_NO As String
        Private _Per_Name As String
        Private _Per_Date As String
        Private _Per_Class As String

        Sub New()
            _AutoID = Nothing
            _Per_NO = Nothing
            _Per_Name = Nothing
            _Per_Date = Nothing
            _Per_Class = Nothing
        End Sub

        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property

        Public Property Per_NO() As String
            Get
                Return _Per_NO
            End Get
            Set(ByVal value As String)
                _Per_NO = value
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

        Public Property Per_Date() As String
            Get
                Return _Per_Date
            End Get
            Set(ByVal value As String)
                _Per_Date = value
            End Set
        End Property

        Public Property Per_Class() As String
            Get
                Return _Per_Class
            End Get
            Set(ByVal value As String)
                _Per_Class = value
            End Set
        End Property

    End Class
End Namespace