Namespace LFERP.Library.Material
    ''' <summary>
    ''' 物料總類
    ''' </summary>
    ''' <remarks></remarks>
    Public Class MaterialTypeInfo
        Private _materialtypeid As String
        Private _materialtypename As String
        Private _materialtypeRemark As String
        Private _materialtypeNameEng As String

        Public Sub New()
            _materialtypeid = ""
            _materialtypename = ""
            _materialtypeRemark = ""
            _materialtypeNameEng = ""
        End Sub
        ''' <summary>
        ''' 物料類別編號，用於區分物料總類
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MaterialTypeID() As String
            Get
                Return _materialtypeid
            End Get
            Set(ByVal value As String)
                _materialtypeid = value
            End Set
        End Property
        ''' <summary>
        ''' 物料類別名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MaterialTypeName() As String
            Get
                Return _materialtypename
            End Get
            Set(ByVal value As String)
                _materialtypename = value
            End Set
        End Property
        ''' <summary>
        ''' 物料類別備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MaterialTypeRemark() As String
            Get
                Return _materialtypeRemark
            End Get
            Set(ByVal value As String)
                _materialtypeRemark = value
            End Set
        End Property
        ''' <summary>
        ''' 物料類別英文名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MaterialTypeNameEng() As String
            Get
                Return _materialTypeNameEng
            End Get
            Set(ByVal value As String)
                _materialTypeNameEng = value
            End Set
        End Property

    End Class
End Namespace

