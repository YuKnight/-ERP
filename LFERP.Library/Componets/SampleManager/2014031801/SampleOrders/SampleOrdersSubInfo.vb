Namespace LFERP.Library.SampleManager.SampleOrdersSub

    Public Class SampleOrdersSubInfo
        Private _AutoID As String
        Private _SO_ID As String
        Private _SS_Edition As String
        Private _PM_M_Code As String
        Private _M_Code As String
        Private _SWI_Qty As Integer
        Private _SS_OrderQty As Integer
        Private _SO_NoSendQty As Integer
        Private _SS_Price As Double
        Private _SS_Remark As String
        Private _CO_ID As String
        Private _SO_Closed As Boolean
        Private _SO_SampleID As String
        Public Sub New()
            _AutoId = 0
            _SO_ID = Nothing
            _CO_ID = Nothing
            _SS_Edition = Nothing
            _PM_M_Code = Nothing
            _M_Code = Nothing
            _SWI_Qty = 0
            _SS_OrderQty = 0
            _SS_Price = 0
            _SS_Remark = Nothing
            _SO_Closed = Nothing
            _SO_NoSendQty = 0
            _SO_SampleID = String.Empty
        End Sub

        Public Property SO_SampleID() As String
            Get
                Return _SO_SampleID
            End Get
            Set(ByVal value As String)
                _SO_SampleID = value
            End Set
        End Property
        Public Property SO_Closed() As Boolean
            Get
                Return _SO_Closed
            End Get
            Set(ByVal value As Boolean)
                _SO_Closed = value
            End Set
        End Property

        Public Property SS_Edition() As String
            Get
                Return _SS_Edition
            End Get
            Set(ByVal value As String)
                _SS_Edition = value
            End Set
        End Property
        Public Property PM_M_Code() As String
            Get
                Return _PM_M_Code
            End Get
            Set(ByVal value As String)
                _PM_M_Code = value
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
        Public Property SO_ID() As String
            Get
                Return _SO_ID
            End Get
            Set(ByVal value As String)
                _SO_ID = value
            End Set
        End Property
        Public Property SWI_Qty() As Integer
            Get
                Return _SWI_Qty
            End Get
            Set(ByVal value As Integer)
                _SWI_Qty = value
            End Set
        End Property
        Public Property SS_OrderQty() As Integer
            Get
                Return _SS_OrderQty
            End Get
            Set(ByVal value As Integer)
                _SS_OrderQty = value
            End Set
        End Property
        Public Property SO_NoSendQty() As Integer
            Get
                Return _SO_NoSendQty
            End Get
            Set(ByVal value As Integer)
                _SO_NoSendQty = value
            End Set
        End Property
        Public Property SS_Price() As Double
            Get
                Return _SS_Price
            End Get
            Set(ByVal value As Double)
                _SS_Price = value
            End Set
        End Property
        Public Property SS_Remark() As String
            Get
                Return _SS_Remark
            End Get
            Set(ByVal value As String)
                _SS_Remark = value
            End Set
        End Property

        Public Property CO_ID() As String
            Get
                Return _CO_ID
            End Get
            Set(ByVal value As String)
                _CO_ID = value
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
