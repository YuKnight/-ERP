Namespace LFERP.Library.SampleManager.SampleOrdersMain
    Public Class SampleOrdersMainInfo
        Private _AutoId As Integer
        Private _SO_ID As String
        Private _SO_SampleID As String
        Private _SO_CusterID As String
        Private _SO_CusterPO As String
        Private _SO_CusterNo As String
        Private _PM_M_Code As String
        Private _M_Code As String
        Private _SO_SendDate As String
        Private _SO_PoDate As String
        Private _SO_OrderQty As Integer
        Private _SO_NoSendQty As Integer
        Private _SO_Completion As String
        Private _SO_Remark As String
        Private _SO_Gauge As String
        Private _CO_ID As String
        Private _SO_State As String
        Private _SO_CheckDate As Date
        Private _SO_CheckUserID As String
        Private _SO_Check As Boolean
        Private _SO_Closed As Boolean
        Private _SO_AddUserID As String
        Private _SO_AddDate As Date
        Private _SO_ModifyUserID As String
        Private _SO_ModifyDate As Date
        Private _M_Name As String
        Private _SO_CheckUserName As String
        Private _SO_addUserName As String
        Private _SO_ModifyUserName As String
        Private _SO_CheckRemark As String
        Private _SS_Edition As String
        Private _SO_No As String
        '-------
        Private _CO_No As String
        Private _SO_Price As Double
        Private _SO_PriceUine As String
        Private _SS_Remark As String
        Private _SO_Rank As String
        Private _SO_CreateDate As Date
        Private _SWI_Qty As Integer
        Private _SS_Price As Double
        '--------------------------
        Private _TID As String
        Private _TName As String
        Private _TType As String
        Private _TEnable As Boolean
        '--------------------------
        Private _MaterialTypeID As String
        Private _SampTypeID As String
        Private _MaterialTypeName As String
        Private _SampTypeName As String
        Private _M_Code_Type As String
        Private _TMaterialType As String
        Private _SO_OrdersType As String




        Public Sub New()

            _AutoId = 0
            _SO_ID = Nothing
            _SO_SampleID = Nothing
            _SO_CusterID = Nothing
            _SO_CusterPO = Nothing
            _SO_CusterNo = Nothing
            _PM_M_Code = Nothing
            _M_Code = Nothing
            _SO_SendDate = Nothing
            _SO_PoDate = Nothing
            _SO_OrderQty = 0
            _SO_NoSendQty = 0
            _SO_Completion = Nothing
            _SO_Gauge = Nothing
            _CO_ID = Nothing
            _SO_State = Nothing
            _SO_Remark = Nothing
            _SO_CheckDate = Nothing
            _SO_CheckUserID = Nothing
            _SO_Check = False
            _SO_AddUserID = Nothing
            _SO_AddDate = Nothing
            _SO_ModifyUserID = Nothing
            _SO_ModifyDate = Nothing
            _M_Name = Nothing
            _SO_CheckUserName = Nothing
            _SO_addUserName = Nothing
            _SO_ModifyUserName = Nothing
            _SO_CheckRemark = Nothing
            _SS_Edition = Nothing
            _SO_No = Nothing
            _SO_Closed = Nothing


            _TID = Nothing
            _TName = Nothing
            _TType = Nothing
            _TEnable = False
            _MaterialTypeID = Nothing
            _SampTypeID = Nothing
            _MaterialTypeName = Nothing
            _SampTypeName = Nothing
            _M_Code_Type = Nothing
            _TMaterialType = Nothing
            _SO_OrdersType = Nothing


        End Sub
        Public Property SO_OrdersType() As String
            Get
                Return _SO_OrdersType
            End Get
            Set(ByVal value As String)
                _SO_OrdersType = value
            End Set
        End Property
        Public Property TMaterialType() As String
            Get
                Return _TMaterialType
            End Get
            Set(ByVal value As String)
                _TMaterialType = value
            End Set
        End Property

        Public Property M_Code_Type() As String
            Get
                Return _M_Code_Type
            End Get
            Set(ByVal value As String)
                _M_Code_Type = value
            End Set
        End Property
        Public Property SO_SampleID() As String
            Get
                Return _SO_SampleID
            End Get
            Set(ByVal value As String)
                _SO_SampleID = value
            End Set
        End Property
        Public Property TID() As String
            Get
                Return _TID
            End Get
            Set(ByVal value As String)
                _TID = value
            End Set
        End Property

        Public Property TName() As String
            Get
                Return _TName
            End Get
            Set(ByVal value As String)
                _TName = value
            End Set
        End Property


        Public Property TType() As String
            Get
                Return _TType
            End Get
            Set(ByVal value As String)
                _TType = value
            End Set
        End Property

        Public Property TEnable() As Boolean
            Get
                Return _TEnable
            End Get
            Set(ByVal value As Boolean)
                _TEnable = value
            End Set
        End Property


        Public Property MaterialTypeID() As String
            Get
                Return _MaterialTypeID
            End Get
            Set(ByVal value As String)
                _MaterialTypeID = value
            End Set
        End Property

        Public Property SampTypeID() As String
            Get
                Return _SampTypeID
            End Get
            Set(ByVal value As String)
                _SampTypeID = value
            End Set
        End Property

        Public Property MaterialTypeName() As String
            Get
                Return _MaterialTypeName
            End Get
            Set(ByVal value As String)
                _MaterialTypeName = value
            End Set
        End Property

        Public Property SampTypeName() As String
            Get
                Return _SampTypeName
            End Get
            Set(ByVal value As String)
                _SampTypeName = value
            End Set
        End Property
        '---------------------------------------------------------------------------
        Public Property SO_Closed() As Boolean
            Get
                Return _SO_Closed
            End Get
            Set(ByVal value As Boolean)
                _SO_Closed = value
            End Set
        End Property
        Public Property SO_No() As String
            Get
                Return _SO_No
            End Get
            Set(ByVal value As String)
                _SO_No = value
            End Set
        End Property
        Public Property SS_Edition() As String
            Get
                Return _SS_Edition
            End Get
            Set(ByVal value As String)
                _SS_Edition = value
            End Set
        End Property
        Public Property SO_CusterID() As String
            Get
                Return _SO_CusterID
            End Get
            Set(ByVal value As String)
                _SO_CusterID = value
            End Set
        End Property
        Public Property SO_CheckRemark() As String
            Get
                Return _SO_CheckRemark
            End Get
            Set(ByVal value As String)
                _SO_CheckRemark = value
            End Set
        End Property
        Public Property SO_ID() As String
            Get
                Return _SO_ID
            End Get
            Set(ByVal value As String)
                _SO_ID = value
            End Set
        End Property
        Public Property SO_CusterPO() As String
            Get
                Return _SO_CusterPO
            End Get
            Set(ByVal value As String)
                _SO_CusterPO = value
            End Set
        End Property
        Public Property SO_CusterNo() As String
            Get
                Return _SO_CusterNo
            End Get
            Set(ByVal value As String)
                _SO_CusterNo = value
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
        Public Property SO_Completion() As String
            Get
                Return _SO_Completion
            End Get
            Set(ByVal value As String)
                _SO_Completion = value
            End Set
        End Property
        Public Property SO_Gauge() As String
            Get
                Return _SO_Gauge
            End Get
            Set(ByVal value As String)
                _SO_Gauge = value
            End Set
        End Property
        Public Property CO_ID() As String
            Get
                Return _CO_ID
            End Get
            Set(ByVal value As String)
                _CO_ID = value
            End Set
        End Property
        Public Property SO_State() As String
            Get
                Return _SO_State
            End Get
            Set(ByVal value As String)
                _SO_State = value
            End Set
        End Property
        Public Property SO_CheckUserID() As String
            Get
                Return _SO_CheckUserID
            End Get
            Set(ByVal value As String)
                _SO_CheckUserID = value
            End Set
        End Property
        Public Property SO_AddUserID() As String
            Get
                Return _SO_AddUserID
            End Get
            Set(ByVal value As String)
                _SO_AddUserID = value
            End Set
        End Property
        Public Property SO_Remark() As String
            Get
                Return _SO_Remark
            End Get
            Set(ByVal value As String)
                _SO_Remark = value
            End Set
        End Property
        Public Property SO_ModifyUserID() As String
            Get
                Return _SO_ModifyUserID
            End Get
            Set(ByVal value As String)
                _SO_ModifyUserID = value
            End Set
        End Property

        Public Property SO_PoDate() As String
            Get
                Return _SO_PoDate
            End Get
            Set(ByVal value As String)
                _SO_PoDate = value
            End Set
        End Property
        Public Property SO_CheckDate() As Date
            Get
                Return _SO_CheckDate
            End Get
            Set(ByVal value As Date)
                _SO_CheckDate = value
            End Set
        End Property
        Public Property SO_SendDate() As String
            Get
                Return _SO_SendDate
            End Get
            Set(ByVal value As String)
                _SO_SendDate = value
            End Set
        End Property
        Public Property SO_AddDate() As Date
            Get
                Return _SO_AddDate
            End Get
            Set(ByVal value As Date)
                _SO_AddDate = value
            End Set
        End Property
        Public Property SO_ModifyDate() As Date
            Get
                Return _SO_ModifyDate
            End Get
            Set(ByVal value As Date)
                _SO_ModifyDate = value
            End Set
        End Property
        Public Property SO_NoSendQty() As Integer
            Get
                Return _SO_NoSendQty
            End Get
            Set(ByVal value As Integer)
                _SO_NoSendQty = value
            End Set
        End Property
        Public Property SO_OrderQty() As Integer
            Get
                Return _SO_OrderQty
            End Get
            Set(ByVal value As Integer)
                _SO_OrderQty = value
            End Set
        End Property

        Public Property AutoID() As Integer
            Get
                Return _AutoId
            End Get
            Set(ByVal value As Integer)
                _AutoId = value
            End Set
        End Property
        Public Property SO_Check() As Boolean
            Get
                Return _SO_Check
            End Get
            Set(ByVal value As Boolean)
                _SO_Check = value
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
        Public Property SO_CheckUserName() As String
            Get
                Return _SO_CheckUserName
            End Get
            Set(ByVal value As String)
                _SO_CheckUserName = value
            End Set
        End Property
        Public Property SO_addUserName() As String
            Get
                Return _SO_addUserName
            End Get
            Set(ByVal value As String)
                _SO_addUserName = value
            End Set
        End Property
        Public Property SO_ModifyUserName() As String
            Get
                Return _SO_ModifyUserName
            End Get
            Set(ByVal value As String)
                _SO_ModifyUserName = value
            End Set
        End Property

        Public Property CO_No() As String
            Get
                Return _CO_No
            End Get
            Set(ByVal value As String)
                _CO_No = value
            End Set
        End Property
        Public Property SO_Price() As Double
            Get
                Return _SO_Price
            End Get
            Set(ByVal value As Double)
                _SO_Price = value
            End Set
        End Property
        Public Property SO_PriceUine() As String
            Get
                Return _SO_PriceUine
            End Get
            Set(ByVal value As String)
                _SO_PriceUine = value
            End Set
        End Property
        Public Property SS_Remark() As String
            Get
                Return _SS_Remark
            End Get
            Set(ByVal value As String)
                _SS_Remark = value
            End Set
        End Property
        Public Property SO_Rank() As String
            Get
                Return _SO_Rank
            End Get
            Set(ByVal value As String)
                _SO_Rank = value
            End Set
        End Property
        Public Property SO_CreateDate() As Date
            Get
                Return _SO_CreateDate
            End Get
            Set(ByVal value As Date)
                _SO_CreateDate = value
            End Set
        End Property
        Public Property SWI_Qty() As Integer
            Get
                Return _SWI_Qty
            End Get
            Set(ByVal value As Integer)
                _SWI_Qty = value
            End Set
        End Property
        Public Property SS_Price() As Double
            Get
                Return _SS_Price
            End Get
            Set(ByVal value As Double)
                _SS_Price = value
            End Set
        End Property



    End Class








End Namespace

