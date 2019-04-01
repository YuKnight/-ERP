Namespace LFERP.Library.Material
    ''' <summary>
    ''' 第三層
    ''' </summary>
    ''' <remarks></remarks>
    Public Class MaterialTypeInfo3
        Private _type3id As String
        Private _type3name As String
        Private _type2id As String
        Private _type3remark As String
        Private _materialTypeNameEng As String

        Public Sub New()
            _type3id = ""
            _type3name = ""
            _type2id = ""
            _type3remark = ""
            _materialTypeNameEng = ""
        End Sub
        ''' <summary>
        ''' 第三層物料類型編號
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
        ''' <summary>
        ''' 第三層物料類型名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Type3Name() As String
            Get
                Return _type3name
            End Get
            Set(ByVal value As String)
                _type3name = value
            End Set
        End Property
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
        ''' 第三層類型條碼
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Type3Remark() As String
            Get
                Return _type3remark
            End Get
            Set(ByVal value As String)
                _type3remark = value
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

