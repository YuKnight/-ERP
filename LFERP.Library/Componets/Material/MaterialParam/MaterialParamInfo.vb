Namespace LFERP.Library.MaterialParam

    Public Class MaterialParamInfo
        Private _type3id As String
        Private _paramid As String
        Private _paramname As String
        Private _paramgauge As String


        Public Sub New()
            _type3id = ""
            _paramid = ""
            _paramname = ""
            _paramgauge = ""
        End Sub
        ''' <summary>
        ''' 物料類別編號，用於區分物料種類
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Type3ID() As String
            Get
                Return _type3id
            End Get
            Set(ByVal value As String)
                _type3id = value
            End Set
        End Property

        Public Property ParamID() As String
            Get
                Return _paramid
            End Get
            Set(ByVal value As String)
                _paramid = value
            End Set
        End Property

        Public Property ParamName() As String
            Get
                Return _paramname
            End Get
            Set(ByVal value As String)
                _paramname = value
            End Set
        End Property
        Public Property ParamGauge() As String
            Get
                Return _paramgauge
            End Get
            Set(ByVal value As String)
                _paramgauge = value
            End Set
        End Property
    End Class

End Namespace

