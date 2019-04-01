Namespace LFERP.Library.MrpManager.Mrp_Info
    Public Class Mrp_DependentQtyInfo
        Private _MRP_ID As String

        Private _ParentGroup As String
        Private _GroupName As String
        Private _Item As String
        Private _M_LowestBomCode As Integer
        Private _LossRate As Decimal

        Private _PM_M_Code As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _Qty As Decimal
        Private _YearCount As Integer
        Private _WeekCount As Integer

        Private _OM_SendDate As Date
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
            _ParentGroup = Nothing
            _GroupName = Nothing
            _Item = Nothing
            _M_LowestBomCode = Nothing
            _LossRate = Nothing

            _PM_M_Code = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _Qty = Nothing
            _YearCount = Nothing
            _WeekCount = Nothing
            _OM_SendDate = Nothing

            _CreateUserID = Nothing
            _CreateDate = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing
            _CreateUserName = Nothing
            _ModifyUserName = Nothing
            _AutoID = Nothing
        End Sub
        Public Property YearCount() As Integer
            Get
                Return _YearCount
            End Get
            Set(ByVal value As Integer)
                _YearCount = value
            End Set
        End Property
        Public Property WeekCount() As Integer
            Get
                Return _WeekCount
            End Get
            Set(ByVal value As Integer)
                _WeekCount = value
            End Set
        End Property

        Public Property GroupName() As String
            Get
                Return _GroupName
            End Get
            Set(ByVal value As String)
                _GroupName = value
            End Set
        End Property
        Public Property ParentGroup() As String
            Get
                Return _ParentGroup
            End Get
            Set(ByVal value As String)
                _ParentGroup = value
            End Set
        End Property
        Public Property Item() As String
            Get
                Return _Item
            End Get
            Set(ByVal value As String)
                _Item = value
            End Set
        End Property
        Public Property M_LowestBomCode() As Integer
            Get
                Return _M_LowestBomCode
            End Get
            Set(ByVal value As Integer)
                _M_LowestBomCode = value
            End Set
        End Property
        Public Property LossRate() As Decimal
            Get
                Return _LossRate
            End Get
            Set(ByVal value As Decimal)
                _LossRate = value
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
        Public Property OM_SendDate() As Date
            Get
                Return _OM_SendDate
            End Get
            Set(ByVal value As Date)
                _OM_SendDate = value
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