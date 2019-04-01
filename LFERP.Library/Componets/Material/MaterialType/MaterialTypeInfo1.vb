
Namespace LFERP.Library.Material
    ''' <summary>
    ''' 第一層類型
    ''' </summary>
    ''' <remarks></remarks>
    Public Class MaterialTypeInfo1
        Private _type1id As String
        Private _type1name As String
        Private _materialtypeid As String
        Private _type1remark As String
        Private _materialTypeNameEng As String



        Public Sub New()
            _type1id = ""
            _type1name = ""
            _materialtypeid = ""
            _type1remark = ""
            _materialTypeNameEng = ""

        End Sub
        ''' <summary>
        ''' 第一層物料類型編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Type1ID() As String
            Get
                Return _type1id
            End Get
            Set(ByVal value As String)
                _type1id = value
            End Set
        End Property
        ''' <summary>
        ''' 第一層物料類型名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Type1Name() As String
            Get
                Return _type1name
            End Get
            Set(ByVal value As String)
                _type1name = value
            End Set
        End Property
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
        ''' 第一層類型條碼
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Type1Remark() As String
            Get
                Return _type1remark
            End Get
            Set(ByVal value As String)
                _type1remark = value
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

