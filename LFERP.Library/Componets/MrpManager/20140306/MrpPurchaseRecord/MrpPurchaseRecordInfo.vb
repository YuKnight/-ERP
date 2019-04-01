Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Namespace LFERP.Library.MrpManager.MrpPurchaseRecord
    Public Class MrpPurchaseRecordInfo
        Private _MrpPurchaseID As String
        Private _MRP_ID As String
        Private _MPP_CreateUserID As String
        Private _MPP_CreateDate As Date
        Private _MPP_ModifyUserID As String
        Private _MPP_ModifyDate As Date
        Private _CheckBit As Boolean
        Private _AutoID As Decimal
        Private _MPP_CreateUserName As String
        Private _MPP_ModifyUserName As String
        Private _MPP_CheckUserName As String
        Private _CheckRemark As String
        Private _MPP_CheckDate As Date
        Private _IsPurchase As Boolean
        Public Sub New()
            _MrpPurchaseID = Nothing
            _MRP_ID = Nothing
            _MPP_CreateUserID = Nothing
            _MPP_CreateDate = Nothing
            _MPP_ModifyUserID = Nothing
            _MPP_ModifyDate = Nothing
            _CheckBit = Nothing
            _AutoID = Nothing
            _MPP_CreateUserName = Nothing
            _MPP_ModifyUserName = Nothing
            _MPP_CheckUserName = Nothing
            _CheckRemark = Nothing
            _MPP_CheckDate = Nothing
            _IsPurchase = Nothing
        End Sub

        Public Property IsPurchase() As Boolean
            Get
                Return _IsPurchase
            End Get
            Set(ByVal value As Boolean)
                _IsPurchase = value
            End Set
        End Property
        Public Property CheckRemark() As String
            Get
                Return _CheckRemark
            End Get
            Set(ByVal value As String)
                _CheckRemark = value
            End Set
        End Property
        Public Property MPP_CheckDate() As Date
            Get
                Return _MPP_CheckDate
            End Get
            Set(ByVal value As Date)
                _MPP_CheckDate = value
            End Set
        End Property

        Public Property MPP_CheckUserName() As String
            Get
                Return _MPP_CheckUserName
            End Get
            Set(ByVal value As String)
                _MPP_CheckUserName = value
            End Set
        End Property
        Public Property MPP_CreateUserName() As String
            Get
                Return _MPP_CreateUserName
            End Get
            Set(ByVal value As String)
                _MPP_CreateUserName = value
            End Set
        End Property
        Public Property MPP_ModifyUserName() As String
            Get
                Return _MPP_ModifyUserName
            End Get
            Set(ByVal value As String)
                _MPP_ModifyUserName = value
            End Set
        End Property



        Public Property MrpPurchaseID() As String
            Get
                Return _MrpPurchaseID
            End Get
            Set(ByVal value As String)
                _MrpPurchaseID = value
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
End Namespace