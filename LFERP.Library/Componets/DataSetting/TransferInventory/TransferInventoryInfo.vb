Namespace LFERP.DataSetting

    Public Class TransferInventoryInfo

        Private _AutoID As Integer
        Private _M_Code As String
        Private _M_Qty As Single
        Private _M_Bit As Boolean

        Sub New()
            _AutoID = 0
            _M_Code = Nothing
            _M_Qty = 0
            _M_Bit = False
        End Sub

        Public Property AutoID() As Integer
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Integer)
                _AutoID = value
            End Set
        End Property
        Public Property M_Code() As String
            Get
                Return _M_Code
            End Get
            Set(ByVal value As String)
                _M_Code = value
            End Set
        End Property
        Public Property M_Qty() As Single
            Get
                Return _M_Qty
            End Get
            Set(ByVal value As Single)
                _M_Qty = value
            End Set
        End Property
        Public Property M_Bit() As Boolean
            Get
                Return _M_Bit
            End Get
            Set(ByVal value As Boolean)
                _M_Bit = value
            End Set
        End Property
    End Class


End Namespace

