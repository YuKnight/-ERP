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
        Private _MPI_CreateUserName As String
        Private _MPI_ModifyUserName As String
        Private _MrpPurchaseID As String
        Private _M_Name As String
        Private _M_Source As String
        Private _M_Unit As String
        Private _M_Gauge As String
        Private _MPI_NeedDate As Date
        Private _S_Supplier As String
        Private _S_SupplierName As String
        Private _MPI_Remark As String
        Private _ForecastDate As Date
        Private _UnitPrice As String
        Public Sub New()
            _ForecastDate = Nothing
            _MPI_Remark = Nothing
            _M_Name = Nothing
            _M_Source = Nothing
            _M_Unit = Nothing
            _M_Gauge = Nothing
            _MRP_ID = Nothing
            _M_Code = Nothing
            _MPI_NeedQty = 0
            _MPI_CreateUserID = Nothing
            _MPI_CreateDate = Nothing
            _MPI_ModifyUserID = Nothing
            _MPI_ModifyDate = Nothing
            _AutoID = Nothing
            _MPI_CreateUserName = Nothing
            _MPI_ModifyUserName = Nothing
            _MrpPurchaseID = Nothing
            _MPI_NeedDate = Nothing
            _S_Supplier = Nothing
            _S_SupplierName = Nothing
            _UnitPrice = 0
        End Sub
        Public Property UnitPrice() As Decimal
            Get
                Return _UnitPrice
            End Get
            Set(ByVal value As Decimal)
                _UnitPrice = value
            End Set
        End Property
        Public Property ForecastDate() As Date
            Get
                Return _ForecastDate
            End Get
            Set(ByVal value As Date)
                _ForecastDate = value
            End Set
        End Property
        Public Property MPI_Remark() As String
            Get
                Return _MPI_Remark
            End Get
            Set(ByVal value As String)
                _MPI_Remark = value
            End Set
        End Property


        Public Property S_Supplier() As String
            Get
                Return _S_Supplier
            End Get
            Set(ByVal value As String)
                _S_Supplier = value
            End Set
        End Property
        Public Property S_SupplierName() As String
            Get
                Return _S_SupplierName
            End Get
            Set(ByVal value As String)
                _S_SupplierName = value
            End Set
        End Property
        Public Property MPI_NeedDate() As Date
            Get
                Return _MPI_NeedDate
            End Get
            Set(ByVal value As Date)
                _MPI_NeedDate = value
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
        Public Property M_Source() As String
            Get
                Return _M_Source
            End Get
            Set(ByVal value As String)
                _M_Source = value
            End Set
        End Property
        Public Property M_Unit() As String
            Get
                Return _M_Unit
            End Get
            Set(ByVal value As String)
                _M_Unit = value
            End Set
        End Property
        Public Property M_Gauge() As String
            Get
                Return _M_Gauge
            End Get
            Set(ByVal value As String)
                _M_Gauge = value
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

        Public Property MPI_ModifyDate() As Date
            Get
                Return _MPI_ModifyDate
            End Get
            Set(ByVal value As Date)
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
        Public Property MPI_CreateUserName() As String
            Get
                Return _MPI_CreateUserName
            End Get
            Set(ByVal value As String)
                _MPI_CreateUserName = value
            End Set
        End Property
        Public Property MPI_ModifyUserName() As String
            Get
                Return _MPI_ModifyUserName
            End Get
            Set(ByVal value As String)
                _MPI_ModifyUserName = value
            End Set
        End Property




    End Class
End Namespace

