Namespace LFERP.Library.Material
    ''' <summary>
    ''' 第二層類型
    ''' </summary>
    ''' <remarks></remarks>
    Public Class MaterialTypeInfo2
        Private _type2id As String
        Private _type2name As String
        Private _type1id As String
        Private _type2remark As String
        Private _materialTypeNameEng As String


        Public Sub New()
            _type2id = ""
            _type2name = ""
            _type1id = ""
            _type2remark = ""
            _materialTypeNameEng = ""
        End Sub
        ''' <summary>
        ''' 第二層物料類型編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Type2ID() As String
            Get
                Return _type2id
            End Get
            Set(ByVal value As String)
                _type2id = value
            End Set
        End Property
        ''' <summary>
        ''' 第二層物料類型名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Type2Name() As String
            Get
                Return _type2name
            End Get
            Set(ByVal value As String)
                _type2name = value
            End Set
        End Property
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
        ''' 第二層類型條碼
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Type2Remark() As String
            Get
                Return _type2remark
            End Get
            Set(ByVal value As String)
                _type2remark = value
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

