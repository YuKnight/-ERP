Namespace LFERP.Library.Material
    Public Class MaterialSubInfo
        Private _m_code As String
        Private _m_codesub As String
        Private _m_qty As Integer
        Private _autoid As String

        Public Sub New()
            '初始化數據
            _m_code = Nothing
            _m_codesub = Nothing
            _m_qty = 0
            _autoid = Nothing

        End Sub

        ''' <summary>
        ''' 主物料編碼
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Code() As String
            Get
                Return _m_code
            End Get
            Set(ByVal value As String)
                _m_code = value
            End Set
        End Property
        ''' <summary>
        ''' 子物料編碼
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_CodeSub() As String
            Get
                Return _m_codesub
            End Get
            Set(ByVal value As String)
                _m_codesub = value
            End Set
        End Property
        ''' <summary>
        ''' 數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Qty() As Integer
            Get
                Return _m_Qty
            End Get
            Set(ByVal value As Integer)
                _m_qty = value
            End Set
        End Property
        Public Property AutoID() As String
            Get
                Return _autoid
            End Get
            Set(ByVal value As String)
                _autoid = value
            End Set
        End Property

    End Class
End Namespace

