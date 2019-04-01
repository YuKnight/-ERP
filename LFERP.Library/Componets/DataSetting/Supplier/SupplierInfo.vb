Namespace LFERP.DataSetting
    ''' <summary>
    ''' 供應商資料
    ''' </summary>
    ''' <remarks></remarks>
    Public Class SupplierInfo
        Private _s_supplier As String
        Private _s_suppliername As String
        Private _s_email As String
        Private _s_associate As String
        Private _s_tel As String
        Private _s_fax As String
        Private _s_type As String
        Private _s_address As String
        Private _s_currency As String
        Private _s_contace As String
        Private _s_tel1 As String
        Private _s_remark As String


        Public Sub New()
            _s_supplier = Nothing
            _s_suppliername = Nothing
            _s_email = Nothing
            _s_associate = Nothing
            _s_tel = Nothing
            _s_fax = Nothing
            _s_type = Nothing
            _s_address = Nothing
            _s_currency = Nothing
            _s_contace = Nothing
            _s_tel1 = Nothing
            _s_remark = Nothing
        End Sub

        Public Property S_Supplier() As String
            Get
                Return _s_supplier
            End Get
            Set(ByVal value As String)
                _s_supplier = value
            End Set
        End Property
        Public Property S_SupplierName() As String
            Get
                Return _s_suppliername
            End Get
            Set(ByVal value As String)
                _s_suppliername = value
            End Set
        End Property
        Public Property S_Email() As String
            Get
                Return _s_email
            End Get
            Set(ByVal value As String)
                _s_email = value
            End Set
        End Property
        Public Property S_Associate() As String
            Get
                Return _s_associate
            End Get
            Set(ByVal value As String)
                _s_associate = value
            End Set
        End Property
        Public Property S_Tel() As String
            Get
                Return _s_tel
            End Get
            Set(ByVal value As String)
                _s_tel = value
            End Set
        End Property
        Public Property S_Fax() As String
            Get
                Return _s_fax
            End Get
            Set(ByVal value As String)
                _s_fax = value
            End Set
        End Property
        Public Property S_Type() As String
            Get
                Return _s_type
            End Get
            Set(ByVal value As String)
                _s_type = value
            End Set
        End Property
        Public Property S_Address() As String
            Get
                Return _s_address
            End Get
            Set(ByVal value As String)
                _s_address = value
            End Set
        End Property
        Public Property S_Currency() As String
            Get
                Return _s_currency
            End Get
            Set(ByVal value As String)
                _s_currency = value
            End Set
        End Property
        Public Property S_Contace() As String
            Get
                Return _s_contace
            End Get
            Set(ByVal value As String)
                _s_contace = value
            End Set
        End Property
        Public Property S_Tel1() As String
            Get
                Return _s_tel1
            End Get
            Set(ByVal value As String)
                _s_tel1 = value
            End Set
        End Property
        Public Property S_Remark() As String
            Get
                Return _s_remark
            End Get
            Set(ByVal value As String)
                _s_remark = value
            End Set
        End Property
    End Class

End Namespace

