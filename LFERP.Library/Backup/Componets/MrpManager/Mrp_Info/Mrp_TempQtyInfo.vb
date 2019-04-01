Namespace LFERP.Library.MrpManager.Mrp_Info
    Public Class Mrp_TempQtyInfo
        Private _MRP_ID As String
        Private _BillsType As String
        Private _SingleNo As String
        Private _PM_M_Code As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _Qty As Decimal
        Private _TempDate As Date
        '--------------------------------------
        Private _CreateUserID As String
        Private _CreateDate As Date
        Private _ModifyUserID As String
        Private _ModifyDate As Date
        Private _CreateUserName As String
        Private _ModifyUserName As String
        Private _AutoID As Decimal

        Public Sub New()
            _MRP_ID = Nothing
            _BillsType = Nothing
            _SingleNo = Nothing
            _PM_M_Code = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _Qty = Nothing

            _TempDate = Nothing

            _CreateUserID = Nothing
            _CreateDate = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing
            _CreateUserName = Nothing
            _ModifyUserName = Nothing
            _AutoID = Nothing
        End Sub

        Public Property SingleNo() As String
            Get
                Return _SingleNo
            End Get
            Set(ByVal value As String)
                _SingleNo = value
            End Set
        End Property
        Public Property TempDate() As Date
            Get
                Return _TempDate
            End Get
            Set(ByVal value As Date)
                _TempDate = value
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

        Public Property Qty() As Decimal
            Get
                Return _Qty
            End Get
            Set(ByVal value As Decimal)
                _Qty = value
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
        Public Property M_Name() As String
            Get
                Return _M_Name
            End Get
            Set(ByVal value As String)
                _M_Name = value
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


        Public Property BillsType() As String
            Get
                Return _BillsType
            End Get
            Set(ByVal value As String)
                _BillsType = value
            End Set
        End Property

        '------------------------------------------
        Public Property AutoID() As Decimal
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Decimal)
                _AutoID = value
            End Set
        End Property
        Public Property ModifyUserName() As String
            Get
                Return _ModifyUserName
            End Get
            Set(ByVal value As String)
                _ModifyUserName = value
            End Set
        End Property

        Public Property CreateUserName() As String
            Get
                Return _CreateUserName
            End Get
            Set(ByVal value As String)
                _CreateUserName = value
            End Set
        End Property
        Public Property ModifyUserID() As String
            Get
                Return _ModifyUserID
            End Get
            Set(ByVal value As String)
                _ModifyUserID = value
            End Set
        End Property

        Public Property ModifyDate() As Date
            Get
                Return _ModifyDate
            End Get
            Set(ByVal value As Date)
                _ModifyDate = value
            End Set
        End Property


        Public Property CreateDate() As Date
            Get
                Return _CreateDate
            End Get
            Set(ByVal value As Date)
                _CreateDate = value
            End Set
        End Property

        Public Property CreateUserID() As String
            Get
                Return _CreateUserID
            End Get
            Set(ByVal value As String)
                _CreateUserID = value
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
    End Class
End Namespace