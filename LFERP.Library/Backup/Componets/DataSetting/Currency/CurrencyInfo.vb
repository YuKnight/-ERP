Namespace LFERP.DataSetting
    Public Class CurrencyInfo

        Private _c_id As String
        Private _c_name As String
        Private _strym As String
        Private _Ex_Rate As Double
        Private _AutoID As String


        Public Sub New()
            _c_id = ""
            _c_name = ""
            _strym = Nothing
            _Ex_Rate = 0
            _AutoID = 0
        End Sub
        ''' <summary>
        ''' ³f¹ô¥N¸¹
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property C_ID() As String
            Get
                Return _c_id
            End Get
            Set(ByVal value As String)
                _c_id = value
            End Set
        End Property
        ''' <summary>
        ''' ³f¹ô¦WºÙ
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property C_Name() As String
            Get
                Return _c_name
            End Get
            Set(ByVal value As String)
                _c_name = value
            End Set
        End Property

        Public Property StrYM() As String
            Get
                Return _strym
            End Get
            Set(ByVal value As String)
                _strym = value
            End Set
        End Property
        Public Property Ex_Rate() As Double
            Get
                Return _Ex_Rate
            End Get
            Set(ByVal value As Double)
                _Ex_Rate = value
            End Set
        End Property
        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property

    End Class

End Namespace

