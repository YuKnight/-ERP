Namespace LFERP.Library.OutWards
    Public Class OutWardsInfo
        Private _AutoID As String
        Private _OW_NO As String
        Private _OS_BatchID As String
        Private _OM_ID As String
        Private _WH_ID As String

        Private _WH_Name As String
        Private _OW_Address As String
        Private _OW_Detail As String
        Private _OW_Remark As String
        Private _PM_M_Code As String

        Private _OW_Qty As Integer
        Private _OW_Date As Date
        Private _OW_AddUserID As String
        Private _OW_AddUserName As String
        Private _OW_AddDate As Date

        Private _OW_ModifyUserID As String
        Private _OW_ModifyDate As Date
        Private _OW_Check As Boolean
        Private _OW_CheckUserID As String
        Private _OW_CheckUserName As String

        Private _OW_CheckDate As Date
        Private _OM_CusterID As String
        Private _OM_CusterNO As String
        Private _OM_CusterPO As String
        Private _OM_OrderSpare As Single

        Private _OS_Plate As String
        Private _OS_NoSendQty As Integer
        Private _PI_Qty As Integer
        Private _C_EngName As String
        Private _C_ChsName As String

        Private _PM_JiYu As String
        Private _PM_Type As String
        Private _M_Code As String
        Private _M_Name As String
        Private _M_Gauge As String

        Private _M_Unit As String
        Private _OS_Sprace As Single

        Private _OC_ID As String
        Private _OC_Spare As Single
        Private _OC_AutoID As String
        Private _OC_NoSendQty As Integer
        Private _OC_CustomerID As String

        Private _OC_CustomerNO As String
        Private _OC_CustomerPO As String
        Private _OW_Sprace As Integer

        Private _Type3ID As String
        Private _Type2ID As String
        Private _Type1ID As String
        Private _Type3Name As String
        Private _Type2Name As String
        Private _Type1Name As String

        Sub New()

            _Type3ID = Nothing
            _Type2ID = Nothing
            _Type1ID = Nothing
            _Type3Name = Nothing
            _Type2Name = Nothing
            _Type1Name = Nothing


            _AutoID = Nothing
            _OW_NO = Nothing
            _OS_BatchID = Nothing
            _OM_ID = Nothing
            _WH_ID = Nothing

            _WH_Name = Nothing
            _OW_Address = Nothing
            _OW_Detail = Nothing
            _OW_Remark = Nothing
            _PM_M_Code = Nothing

            _OW_Qty = 0
            _OW_Date = Nothing
            _OW_AddUserID = Nothing
            _OW_AddUserName = Nothing
            _OW_AddDate = Nothing

            _OW_ModifyUserID = Nothing
            _OW_ModifyDate = Nothing
            _OW_Check = Nothing
            _OW_CheckUserID = Nothing
            _OW_CheckUserName = Nothing

            _OW_CheckDate = Nothing
            _OM_CusterID = Nothing
            _OM_CusterNO = Nothing
            _OM_CusterPO = Nothing
            _OM_OrderSpare = 0

            _OS_Plate = Nothing
            _OS_NoSendQty = 0
            _PI_Qty = 0
            _C_EngName = Nothing
            _C_ChsName = Nothing

            _PM_JiYu = Nothing
            _PM_Type = Nothing
            _M_Code = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing

            _M_Unit = Nothing
            _OS_Sprace = 0

            _OC_ID = Nothing
            _OC_Spare = 0
            _OC_AutoID = Nothing
            _OC_NoSendQty = 0
            _OC_CustomerID = Nothing

            _OC_CustomerNO = Nothing
            _OC_CustomerPO = Nothing
            _OW_Sprace = 0

        End Sub
        '_OW_Sprace

        Public Property OW_Sprace() As Integer
            Get
                Return _OW_Sprace
            End Get
            Set(ByVal value As Integer)
                _OW_Sprace = value
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
        Public Property OW_NO() As String
            Get
                Return _OW_NO
            End Get
            Set(ByVal value As String)
                _OW_NO = value
            End Set
        End Property
        Public Property OS_BatchID() As String
            Get
                Return _OS_BatchID
            End Get
            Set(ByVal value As String)
                _OS_BatchID = value
            End Set
        End Property
        Public Property OM_ID() As String
            Get
                Return _OM_ID
            End Get
            Set(ByVal value As String)
                _OM_ID = value
            End Set
        End Property
        Public Property WH_ID() As String
            Get
                Return _WH_ID
            End Get
            Set(ByVal value As String)
                _WH_ID = value
            End Set
        End Property

        Public Property WH_Name() As String
            Get
                Return _WH_Name
            End Get
            Set(ByVal value As String)
                _WH_Name = value
            End Set
        End Property
        Public Property OW_Address() As String
            Get
                Return _OW_Address
            End Get
            Set(ByVal value As String)
                _OW_Address = value
            End Set
        End Property
        Public Property OW_Detail() As String
            Get
                Return _OW_Detail
            End Get
            Set(ByVal value As String)
                _OW_Detail = value
            End Set
        End Property
        Public Property OW_Remark() As String
            Get
                Return _OW_Remark
            End Get
            Set(ByVal value As String)
                _OW_Remark = value
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

        Public Property OW_Qty() As Integer
            Get
                Return _OW_Qty
            End Get
            Set(ByVal value As Integer)
                _OW_Qty = value
            End Set
        End Property
        Public Property OW_Date() As Date
            Get
                Return _OW_Date
            End Get
            Set(ByVal value As Date)
                _OW_Date = value
            End Set
        End Property
        Public Property OW_AddUserID() As String
            Get
                Return _OW_AddUserID
            End Get
            Set(ByVal value As String)
                _OW_AddUserID = value
            End Set
        End Property
        Public Property OW_AddUserName() As String
            Get
                Return _OW_AddUserName
            End Get
            Set(ByVal value As String)
                _OW_AddUserName = value
            End Set
        End Property
        Public Property OW_AddDate() As Date
            Get
                Return _OW_AddDate
            End Get
            Set(ByVal value As Date)
                _OW_AddDate = value
            End Set
        End Property

        Public Property OW_ModifyUserID() As String
            Get
                Return _OW_ModifyUserID
            End Get
            Set(ByVal value As String)
                _OW_ModifyUserID = value
            End Set
        End Property
        Public Property OW_ModifyDate() As Date
            Get
                Return _OW_ModifyDate
            End Get
            Set(ByVal value As Date)
                _OW_ModifyDate = value
            End Set
        End Property
        Public Property OW_Check() As Boolean
            Get
                Return _OW_Check
            End Get
            Set(ByVal value As Boolean)
                _OW_Check = value
            End Set
        End Property
        Public Property OW_CheckUserID() As String
            Get
                Return _OW_CheckUserID
            End Get
            Set(ByVal value As String)
                _OW_CheckUserID = value
            End Set
        End Property
        Public Property OW_CheckUserName() As String
            Get
                Return _OW_CheckUserName
            End Get
            Set(ByVal value As String)
                _OW_CheckUserName = value
            End Set
        End Property

        Public Property OW_CheckDate() As Date
            Get
                Return _OW_CheckDate
            End Get
            Set(ByVal value As Date)
                _OW_CheckDate = value
            End Set
        End Property
        Public Property OM_CusterID() As String
            Get
                Return _OM_CusterID
            End Get
            Set(ByVal value As String)
                _OM_CusterID = value
            End Set
        End Property
        Public Property OM_CusterNO() As String
            Get
                Return _OM_CusterNO
            End Get
            Set(ByVal value As String)
                _OM_CusterNO = value
            End Set
        End Property
        Public Property OM_CusterPO() As String
            Get
                Return _OM_CusterPO
            End Get
            Set(ByVal value As String)
                _OM_CusterPO = value
            End Set
        End Property
        Public Property OM_OrderSpare() As Single
            Get
                Return _OM_OrderSpare
            End Get
            Set(ByVal value As Single)
                _OM_OrderSpare = value
            End Set
        End Property

        Public Property OS_Plate() As String
            Get
                Return _OS_Plate
            End Get
            Set(ByVal value As String)
                _OS_Plate = value
            End Set
        End Property
        Public Property OS_NoSendQty() As Integer
            Get
                Return _OS_NoSendQty
            End Get
            Set(ByVal value As Integer)
                _OS_NoSendQty = value
            End Set
        End Property
        Public Property PI_Qty() As Integer
            Get
                Return _PI_Qty
            End Get
            Set(ByVal value As Integer)
                _PI_Qty = value
            End Set
        End Property

        Public Property C_EngName() As String
            Get
                Return _C_EngName
            End Get
            Set(ByVal value As String)
                _C_EngName = value
            End Set
        End Property
        Public Property C_ChsName() As String
            Get
                Return _C_ChsName
            End Get
            Set(ByVal value As String)
                _C_ChsName = value
            End Set
        End Property
        Public Property PM_JiYu() As String
            Get
                Return _PM_JiYu
            End Get
            Set(ByVal value As String)
                _PM_JiYu = value
            End Set
        End Property
        Public Property PM_Type() As String
            Get
                Return _PM_Type
            End Get
            Set(ByVal value As String)
                _PM_Type = value
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
        Public Property M_Gauge() As String
            Get
                Return _M_Gauge
            End Get
            Set(ByVal value As String)
                _M_Gauge = value
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

        Public Property OS_Sprace() As Single
            Get
                Return _OS_Sprace
            End Get
            Set(ByVal value As Single)
                _OS_Sprace = value
            End Set
        End Property

        Public Property OC_ID() As String
            Get
                Return _OC_ID
            End Get
            Set(ByVal value As String)
                _OC_ID = value
            End Set
        End Property
        Public Property OC_Spare() As Single
            Get
                Return _OC_Spare
            End Get
            Set(ByVal value As Single)
                _OC_Spare = value
            End Set
        End Property

        Public Property OC_AutoID() As String
            Get
                Return _OC_AutoID
            End Get
            Set(ByVal value As String)
                _OC_AutoID = value
            End Set
        End Property

        Public Property OC_NoSendQty() As Integer
            Get
                Return _OC_NoSendQty
            End Get
            Set(ByVal value As Integer)
                _OC_NoSendQty = value
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

        Public Property OC_CustomerNO() As String
            Get
                Return _OC_CustomerNo
            End Get
            Set(ByVal value As String)
                _OC_CustomerNo = value
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

        ''------------------------------------

        Public Property Type3ID() As String
            Get
                Return _Type3ID
            End Get
            Set(ByVal value As String)
                _Type3ID = value
            End Set
        End Property

        Public Property Type2ID() As String
            Get
                Return _Type2ID
            End Get
            Set(ByVal value As String)
                _Type2ID = value
            End Set
        End Property

        Public Property Type1ID() As String
            Get
                Return _Type1ID
            End Get
            Set(ByVal value As String)
                _Type1ID = value
            End Set
        End Property

        Public Property Type3Name() As String
            Get
                Return _Type3Name
            End Get
            Set(ByVal value As String)
                _Type3Name = value
            End Set
        End Property

        Public Property Type2Name() As String
            Get
                Return _Type2Name
            End Get
            Set(ByVal value As String)
                _Type2Name = value
            End Set
        End Property

        Public Property Type1Name() As String
            Get
                Return _Type1Name
            End Get
            Set(ByVal value As String)
                _Type1Name = value
            End Set
        End Property

    End Class
End Namespace

