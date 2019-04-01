Public Class MrpPurchOrderInfo
    Private _MrpPurchID As String
    Private _MRP_ID As String
    Private _MPP_CreateUserID As String
    Private _MPP_CreateDate As Date
    Private _MPP_ModifyUserID As String
    Private _MPP_ModifyDate As Date
    Private _CheckBit As Boolean
    Private _AutoID As Decimal
    Public Sub New()
        _MrpPurchID = Nothing
        _MRP_ID = Nothing
        _MPP_CreateUserID = Nothing
        _MPP_CreateDate = Nothing
        _MPP_ModifyUserID = Nothing
        _MPP_ModifyDate = Nothing
        _CheckBit = Nothing
        _AutoID = Nothing
    End Sub
    Public Property MrpPurchID() As String
        Get
            Return _MrpPurchID
        End Get
        Set(ByVal value As String)
            _MrpPurchID = value
        End Set
    End Property
    Public Property MRP_ID() As String
        Get
            Return _MRP_ID
        End Get
        Set(ByVal value As String)
            _MRP_ID = value
        End Set
    End Property
    Public Property MPP_CreateUserID() As String
        Get
            Return _MPP_CreateUserID
        End Get
        Set(ByVal value As String)
            _MPP_CreateUserID = value
        End Set
    End Property
    Public Property MPP_CreateDate() As String
        Get
            Return _MPP_CreateDate
        End Get
        Set(ByVal value As String)
            _MPP_CreateDate = value
        End Set
    End Property
    Public Property MPP_ModifyUserID() As String
        Get
            Return _MPP_ModifyUserID
        End Get
        Set(ByVal value As String)
            _MPP_ModifyUserID = value
        End Set
    End Property
    Public Property MPP_ModifyDate() As String
        Get
            Return _MPP_ModifyDate
        End Get
        Set(ByVal value As String)
            _MPP_ModifyDate = value
        End Set
    End Property
    Public Property CheckBit() As String
        Get
            Return _CheckBit
        End Get
        Set(ByVal value As String)
            _CheckBit = value
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
