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
        Private _MPP_CheckUserID As String
        Private _MPP_Remark As String
        Private _PurchaseDate As Date
        Private _PurchaseUserID As String
        Private _PurchaseUserName As String
        Private _IsUrgent As Boolean
        Private _PurchaseDepartment As String
        Private _PurchaseDepartName As String
        Private _WareHouseID As String
        Private _WareHouseName As String
        Public Sub New()
            _PurchaseDate = Nothing
            _PurchaseUserID = Nothing
            _PurchaseUserName = Nothing
            _IsUrgent = Nothing
            _PurchaseDepartment = Nothing
            _PurchaseDepartName = Nothing

            _MPP_Remark = Nothing
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
            _MPP_CheckUserID = Nothing
            _CheckRemark = Nothing
            _MPP_CheckDate = Nothing
            _IsPurchase = Nothing
            _WareHouseID = Nothing
            _WareHouseName = Nothing
        End Sub

        Public Property PurchaseDate() As Date
            Get
                Return _PurchaseDate
            End Get
            Set(ByVal value As Date)
                _PurchaseDate = value
            End Set
        End Property
        Public Property PurchaseUserID() As String
            Get
                Return _PurchaseUserID
            End Get
            Set(ByVal value As String)
                _PurchaseUserID = value
            End Set
        End Property
        Public Property PurchaseUserName() As String
            Get
                Return _PurchaseUserName
            End Get
            Set(ByVal value As String)
                _PurchaseUserName = value
            End Set
        End Property
        Public Property IsUrgent() As Boolean
            Get
                Return _IsUrgent
            End Get
            Set(ByVal value As Boolean)
                _IsUrgent = value
            End Set
        End Property
        Public Property PurchaseDepartment() As String
            Get
                Return _PurchaseDepartment
            End Get
            Set(ByVal value As String)
                _PurchaseDepartment = value
            End Set
        End Property
        Public Property PurchaseDepartName() As String
            Get
                Return _PurchaseDepartName
            End Get
            Set(ByVal value As String)
                _PurchaseDepartName = value
            End Set
        End Property

        Public Property MPP_Remark() As String
            Get
                Return _MPP_Remark
            End Get
            Set(ByVal value As String)
                _MPP_Remark = value
            End Set
        End Property
        Public Property MPP_CheckUserID() As String
            Get
                Return _MPP_CheckUserID
            End Get
            Set(ByVal value As String)
                _MPP_CheckUserID = value
            End Set
        End Property
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
        Public Property MPP_CreateDate() As Date
            Get
                Return _MPP_CreateDate
            End Get
            Set(ByVal value As Date)
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
        Public Property MPP_ModifyDate() As Date
            Get
                Return _MPP_ModifyDate
            End Get
            Set(ByVal value As Date)
                _MPP_ModifyDate = value
            End Set
        End Property
        Public Property CheckBit() As Boolean
            Get
                Return _CheckBit
            End Get
            Set(ByVal value As Boolean)
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
        Public Property WareHouseID() As String
            Get
                Return _WareHouseID
            End Get
            Set(ByVal value As String)
                _WareHouseID = value
            End Set
        End Property
        Public Property WareHouseName() As String
            Get
                Return _WareHouseName
            End Get
            Set(ByVal value As String)
                _WareHouseName = value
            End Set
        End Property
    End Class
End Namespace