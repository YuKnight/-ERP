Namespace LFERP.Library.MaterialParam
    Public Class MaterialParamTypeInfo
        Private _paramtypeid As Integer
        Private _paramtypename As String
        Private _paramtypegauge As String
        Public Sub New()
            _paramtypename = ""
            _paramtypegauge = ""

        End Sub

        Public Property ParamTypeID() As Integer
            Get
                Return _paramtypeid
            End Get
            Set(ByVal value As Integer)
                _paramtypeid = value
            End Set
        End Property
        Public Property ParamTypeName() As String
            Get
                Return _paramtypename
            End Get
            Set(ByVal value As String)
                _paramtypename = value
            End Set
        End Property
        Public Property ParamTypeGauge() As String
            Get
                Return _paramtypegauge
            End Get
            Set(ByVal value As String)
                _paramtypegauge = value
            End Set
        End Property


    End Class
End Namespace

