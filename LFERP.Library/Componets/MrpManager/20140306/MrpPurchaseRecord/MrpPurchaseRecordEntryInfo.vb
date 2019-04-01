Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Namespace LFERP.Library.MrpManager.MrpPurchaseRecord
    Public Class MrpPurchaseRecordEntryInfo
        Private _MRP_ID As String
        Private _M_Code As String
        Private _MPI_NeedQty As Decimal
        Private _MPI_CreateUserID As String
        Private _MPI_CreateDate As Date
        Private _MPI_ModifyUserID As String
        Private _MPI_ModifyDate As Date
        Private _AutoID As Decimal
        Private _MP_CreateUserName As String
        Private _MP_ModifyUserName As String
        Private _MrpPurchaseID As String
        Public Sub New()
            _MRP_ID = Nothing
            _M_Code = Nothing
            _MPI_NeedQty = Nothing
            _MPI_CreateUserID = Nothing
            _MPI_CreateDate = Nothing
            _MPI_ModifyUserID = Nothing
            _MPI_ModifyDate = Nothing
            _AutoID = Nothing
            _MP_CreateUserName = Nothing
            _MP_ModifyUserName = Nothing
            _MrpPurchaseID = Nothing
        End Sub
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
        Public Property M_Code() As String
            Get
                Return _M_Code
            End Get
            Set(ByVal value As String)
                _M_Code = value
            End Set
        End Property

        Public Property MPI_NeedQty() As Decimal
            Get
                Return _MPI_NeedQty
            End Get
            Set(ByVal value As Decimal)
                _MPI_NeedQty = value
            End Set
        End Property

        Public Property MPI_CreateUserID() As String
            Get
                Return _MPI_CreateUserID
            End Get
            Set(ByVal value As String)
                _MPI_CreateUserID = value
            End Set
        End Property

        Public Property MPI_CreateDate() As Date
            Get
                Return _MPI_CreateDate
            End Get
            Set(ByVal value As Date)
                _MPI_CreateDate = value
            End Set
        End Property

        Public Property MPI_ModifyUserID() As String
            Get
                Return _MPI_ModifyUserID
            End Get
            Set(ByVal value As String)
                _MPI_ModifyUserID = value
            End Set
        End Property

        Public Property MPI_ModifyDate() As String
            Get
                Return _MPI_ModifyDate
            End Get
            Set(ByVal value As String)
                _MPI_ModifyDate = value
            End Set
        End Property
        Public Property AutoID() As Decimal
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Decimal)
                _AutoID = value
            End Set
        End Property
        Public Property MP_CreateUserName() As String
            Get
                Return _MP_CreateUserName
            End Get
            Set(ByVal value As String)
                _MP_CreateUserName = value
            End Set
        End Property
        Public Property MP_ModifyUserName() As String
            Get
                Return _MP_ModifyUserName
            End Get
            Set(ByVal value As String)
                _MP_ModifyUserName = value
            End Set
        End Property




    End Class
End Namespace

