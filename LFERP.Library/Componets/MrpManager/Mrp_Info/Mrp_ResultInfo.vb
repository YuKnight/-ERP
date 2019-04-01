Namespace LFERP.Library.MrpManager.Mrp_Info

    Public Class Mrp_ResultInfo
        Private _MRP_ID As String
        '-------------------------------------
        Private _FPlanOrderNo As String
        Private _FSourceID As String
        Private _FPlanBeginDate As Date
        Private _FPlanEndDate As Date
        Private _FNeedDate As Date
        Private _FItemType As String
        Private _FAuxNeedQty As Decimal
        Private _FAuxPlanQty As Decimal
        Private _FTranType As String
        Private _FMrpDate As Date
        Private _FStatus As String
        Private _FMrpClosed As String
        Private _FType As String
        '-------------------------------------
        Private _SoureType As String
        Private _PM_M_Code As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
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

            _FPlanOrderNo = Nothing
            _FSourceID = Nothing
            _FPlanBeginDate = Nothing
            _FPlanEndDate = Nothing
            _FNeedDate = Nothing
            _FItemType = Nothing
            _FAuxNeedQty = Nothing
            _FAuxPlanQty = Nothing
            _FTranType = Nothing
            _FMrpDate = Nothing
            _FStatus = Nothing
            _FMrpClosed = Nothing
            _FType = Nothing
            _SoureType = Nothing

            _PM_M_Code = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing


            _CreateUserID = Nothing
            _CreateDate = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing
            _CreateUserName = Nothing
            _ModifyUserName = Nothing
            _AutoID = Nothing
        End Sub
        Public Property SoureType() As String
            Get
                Return _SoureType
            End Get
            Set(ByVal value As String)
                _SoureType = value
            End Set
        End Property

        Public Property FType() As String
            Get
                Return _FType
            End Get
            Set(ByVal value As String)
                _FType = value
            End Set
        End Property

        Public Property FMrpClosed() As String
            Get
                Return _FMrpClosed
            End Get
            Set(ByVal value As String)
                _FMrpClosed = value
            End Set
        End Property

        Public Property FStatus() As String
            Get
                Return _FStatus
            End Get
            Set(ByVal value As String)
                _FStatus = value
            End Set
        End Property

        Public Property FMrpDate() As Date
            Get
                Return _FMrpDate
            End Get
            Set(ByVal value As Date)
                _FMrpDate = value
            End Set
        End Property

        Public Property FTranType() As String
            Get
                Return _FTranType
            End Get
            Set(ByVal value As String)
                _FTranType = value
            End Set
        End Property

        Public Property FAuxNeedQty() As Decimal
            Get
                Return _FAuxNeedQty
            End Get
            Set(ByVal value As Decimal)
                _FAuxNeedQty = value
            End Set
        End Property

        Public Property FAuxPlanQty() As Decimal
            Get
                Return _FAuxPlanQty
            End Get
            Set(ByVal value As Decimal)
                _FAuxPlanQty = value
            End Set
        End Property


        Public Property FItemType() As String
            Get
                Return _FItemType
            End Get
            Set(ByVal value As String)
                _FItemType = value
            End Set
        End Property
        Public Property FNeedDate() As Date
            Get
                Return _FNeedDate
            End Get
            Set(ByVal value As Date)
                _FNeedDate = value
            End Set
        End Property

        Public Property FPlanEndDate() As Date
            Get
                Return _FPlanEndDate
            End Get
            Set(ByVal value As Date)
                _FPlanEndDate = value
            End Set
        End Property
        Public Property FPlanBeginDate() As Date
            Get
                Return _FPlanBeginDate
            End Get
            Set(ByVal value As Date)
                _FPlanBeginDate = value
            End Set
        End Property

        Public Property FPlanOrderNo() As String
            Get
                Return _FPlanOrderNo
            End Get
            Set(ByVal value As String)
                _FPlanOrderNo = value
            End Set
        End Property
        Public Property FSourceID() As String
            Get
                Return _FSourceID
            End Get
            Set(ByVal value As String)
                _FSourceID = value
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