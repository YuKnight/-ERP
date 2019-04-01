Namespace LFERP.Library.Orders
    Public Class OrderCustomerInfo
        Private _AutoID As String
        Private _OC_ID As String
        Private _PM_M_Code As String
        Private _M_Code As String
        Private _M_Name As String

        Private _OC_CustomerNo As String
        Private _OC_CustomerID As String
        Private _OC_CustomerPO As String
        Private _OC_PODate As Date
        Private _OC_Qty As Integer

        Private _OC_NoSendQty As String
        Private _OC_Spare As Double
        Private _OC_Remark As String
        Private _OC_Index As String
        Private _OC_AddDate As Date

        Private _OC_AddUser As String
        Private _OC_ModifyDate As Date
        Private _OC_ModifyUser As String

        Public Sub New()
            _AutoID = Nothing
            _OC_ID = Nothing
            _PM_M_Code = Nothing
            _M_Code = Nothing
            _M_Name = Nothing

            _OC_CustomerNo = Nothing
            _OC_CustomerID = Nothing
            _OC_CustomerPO = Nothing
            _OC_PODate = Nothing
            _OC_Qty = 0

            _OC_NoSendQty = Nothing
            _OC_Spare = 0
            _OC_Remark = Nothing
            _OC_Index = Nothing
            _OC_AddDate = Nothing

            _OC_AddUser = Nothing
            _OC_ModifyDate = Nothing
            _OC_ModifyUser = Nothing
        End Sub
        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property
        ''' <summary>
        ''' ­q³æ½s¸¹
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OC_ID() As String
            Get
                Return _OC_ID
            End Get
            Set(ByVal value As String)
                _OC_ID = value
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
        Public Property M_Name() As String
            Get
                Return _M_Name
            End Get
            Set(ByVal value As String)
                _M_Name = value
            End Set
        End Property
        Public Property OC_CustomerNo() As String
            Get
                Return _OC_CustomerNo
            End Get
            Set(ByVal value As String)
                _OC_CustomerNo = value
            End Set
        End Property
        Public Property OC_CustomerID() As String
            Get
                Return _OC_CustomerID
            End Get
            Set(ByVal value As String)
                _OC_CustomerID = value
            End Set
        End Property
        Public Property OC_CustomerPO() As String
            Get
                Return _OC_CustomerPO
            End Get
            Set(ByVal value As String)
                _OC_CustomerPO = value
            End Set
        End Property
        Public Property OC_PODate() As Date
            Get
                Return _OC_PODate
            End Get
            Set(ByVal value As Date)
                _OC_PODate = value
            End Set
        End Property
        Public Property OC_Qty() As Integer
            Get
                Return _OC_Qty
            End Get
            Set(ByVal value As Integer)
                _OC_Qty = value
            End Set
        End Property
        Public Property OC_NoSendQty() As String
            Get
                Return _OC_NoSendQty
            End Get
            Set(ByVal value As String)
                _OC_NoSendQty = value
            End Set
        End Property
        Public Property OC_Spare() As Double
            Get
                Return _OC_Spare
            End Get
            Set(ByVal value As Double)
                _OC_Spare = value
            End Set
        End Property
        Public Property OC_Remark() As String
            Get
                Return _OC_Remark
            End Get
            Set(ByVal value As String)
                _OC_Remark = value
            End Set
        End Property
        Public Property OC_Index() As String
            Get
                Return _OC_Index
            End Get
            Set(ByVal value As String)
                _OC_Index = value
            End Set
        End Property
        Public Property OC_AddDate() As Date
            Get
                Return _OC_AddDate
            End Get
            Set(ByVal value As Date)
                _OC_AddDate = value
            End Set
        End Property
        Public Property OC_AddUser() As String
            Get
                Return _OC_AddUser
            End Get
            Set(ByVal value As String)
                _OC_AddUser = value
            End Set
        End Property
        Public Property OC_ModifyDate() As Date
            Get
                Return _OC_ModifyDate
            End Get
            Set(ByVal value As Date)
                _OC_ModifyDate = value
            End Set
        End Property
        Public Property OC_ModifyUser() As String
            Get
                Return _OC_ModifyUser
            End Get
            Set(ByVal value As String)
                _OC_ModifyUser = value
            End Set
        End Property
    End Class
End Namespace

