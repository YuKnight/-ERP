Namespace LFERP.Library.Production.ProductionWareShipped


    Public Class ProductionWareShippedInfo

        Private _PWS_NO As String
        Private _PWS_WareID As String
        Private _PWS_DepID As String
        Private _PWS_Remark As String
        Private _PWS_SubNO As String
        Private _PWS_SubType As String
        Private _PWS_SubRemark As String
        Private _PM_M_Code As String
        Private _PWS_M_Code As String
        Private _PWS_Qty As Integer
        Private _PWS_Type As String
        Private _PWS_Action As String
        Private _PWS_AddDate As Date
        Private _PWS_Check As Boolean
        Private _PWS_CheckAction As String
        Private _PWS_CheckDate As Date
        Private _PWS_CheckRemark As String

        Private _PWS_OutName As String
        Private _PWS_DepName As String

        Private _M_Code As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _Qty As Integer
        Private _OutName As String
        Private _InName As String

        Private _PWS_ActionName As String
        Private _PWS_CheckActionName As String
        Private _FacName As String
        Private _FacID As String
        Private _PM_Type As String
        Private _PM_JiYu As String

        Private _PWS_InWareID As String
        Private _PWS_InName As String
        Private _PWS_InAction As String
        Private _PWS_InActionName As String
        Private _PWS_InAddDate As Date
        Private _PWS_InCheck As Boolean


        Private _PWS_EndQty As Double   ''       decimal(18, 3),--收料的節余
        Private _PWS_EndQty1 As Double        '' decimal(18, 3) --發料節余 
        Private _AutoID As String


        Sub New()
            _PWS_InName = Nothing
            _PWS_InWareID = Nothing
            _PWS_InAction = Nothing
            _PWS_InActionName = Nothing
            _PWS_InAddDate = Nothing
            _PWS_InCheck = Nothing


            _PM_JiYu = Nothing
            _PM_Type = Nothing

            _PWS_NO = Nothing
            _PWS_WareID = Nothing
            _PWS_DepID = Nothing
            _PWS_Remark = Nothing
            _PWS_SubNO = Nothing
            _PWS_SubType = Nothing
            _PWS_SubRemark = Nothing
            _PM_M_Code = Nothing
            _PWS_M_Code = Nothing
            _PWS_Qty = 0
            _Qty = 0
            _PWS_Type = Nothing
            _PWS_Action = Nothing
            _PWS_AddDate = Nothing
            _PWS_Check = False
            _PWS_CheckAction = Nothing
            _PWS_CheckDate = Nothing
            _PWS_CheckRemark = Nothing

            _M_Code = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing

            _M_Gauge = Nothing
            _M_Unit = Nothing

            _OutName = Nothing
            _InName = Nothing

            _PWS_OutName = Nothing
            _PWS_DepName = Nothing
            _FacName = Nothing
            _FacID = Nothing

            _PWS_EndQty = 0
            _PWS_EndQty1 = 0
            _AutoID = Nothing

        End Sub

        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property

        Public Property InName() As String
            Get
                Return _InName
            End Get
            Set(ByVal value As String)
                _InName = value
            End Set
        End Property
        Public Property OutName() As String
            Get
                Return _OutName
            End Get
            Set(ByVal value As String)
                _OutName = value
            End Set
        End Property
        Public Property PWS_InName() As String
            Get
                Return _PWS_InName
            End Get
            Set(ByVal value As String)
                _PWS_InName = value
            End Set
        End Property
        Public Property PWS_InWareID() As String
            Get
                Return _PWS_InWareID
            End Get
            Set(ByVal value As String)
                _PWS_InWareID = value
            End Set
        End Property
        Public Property PWS_InAction() As String
            Get
                Return _PWS_InAction
            End Get
            Set(ByVal value As String)
                _PWS_InAction = value
            End Set
        End Property
        Public Property PWS_InActionName() As String
            Get
                Return _PWS_InActionName
            End Get
            Set(ByVal value As String)
                _PWS_InActionName = value
            End Set
        End Property
        Public Property PWS_InAddDate() As Date
            Get
                Return _PWS_InAddDate
            End Get
            Set(ByVal value As Date)
                _PWS_InAddDate = value
            End Set
        End Property
        Public Property PWS_InCheck() As Boolean
            Get
                Return _PWS_InCheck
            End Get
            Set(ByVal value As Boolean)
                _PWS_InCheck = value
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

        ''' <summary>
        ''' TYPE3_ID 2012-7-20
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Type() As String
            Get
                Return _PM_Type
            End Get
            Set(ByVal value As String)
                _PM_Type = value
            End Set
        End Property
        Public Property PWS_NO() As String
            Get
                Return _PWS_NO
            End Get
            Set(ByVal value As String)
                _PWS_NO = value
            End Set
        End Property
        Public Property PWS_WareID() As String
            Get
                Return _PWS_WareID
            End Get
            Set(ByVal value As String)
                _PWS_WareID = value
            End Set
        End Property
        Public Property PWS_DepID() As String
            Get
                Return _PWS_DepID
            End Get
            Set(ByVal value As String)
                _PWS_DepID = value
            End Set
        End Property
        Public Property PWS_Remark() As String
            Get
                Return _PWS_Remark
            End Get
            Set(ByVal value As String)
                _PWS_Remark = value
            End Set
        End Property
        Public Property PWS_SubNO() As String
            Get
                Return _PWS_SubNO
            End Get
            Set(ByVal value As String)
                _PWS_SubNO = value
            End Set
        End Property
        Public Property PWS_SubType() As String
            Get
                Return _PWS_SubType
            End Get
            Set(ByVal value As String)
                _PWS_SubType = value
            End Set
        End Property
        Public Property PWS_SubRemark() As String
            Get
                Return _PWS_SubRemark
            End Get
            Set(ByVal value As String)
                _PWS_SubRemark = value
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
        Public Property PWS_M_Code() As String
            Get
                Return _PWS_M_Code
            End Get
            Set(ByVal value As String)
                _PWS_M_Code = value
            End Set
        End Property
        Public Property PWS_Type() As String
            Get
                Return _PWS_Type
            End Get
            Set(ByVal value As String)
                _PWS_Type = value
            End Set
        End Property
        Public Property PWS_Qty() As Integer
            Get
                Return _PWS_Qty
            End Get
            Set(ByVal value As Integer)
                _PWS_Qty = value
            End Set
        End Property
        Public Property Qty() As Integer
            Get
                Return _Qty
            End Get
            Set(ByVal value As Integer)
                _Qty = value
            End Set
        End Property
        Public Property PWS_Action() As String
            Get
                Return _PWS_Action
            End Get
            Set(ByVal value As String)
                _PWS_Action = value
            End Set
        End Property
        Public Property PWS_AddDate() As Date
            Get
                Return _PWS_AddDate
            End Get
            Set(ByVal value As Date)
                _PWS_AddDate = value
            End Set
        End Property

        Public Property PWS_OutName() As String
            Get
                Return _PWS_OutName
            End Get
            Set(ByVal value As String)
                _PWS_OutName = value
            End Set
        End Property
        Public Property PWS_DepName() As String
            Get
                Return _PWS_DepName
            End Get
            Set(ByVal value As String)
                _PWS_DepName = value
            End Set
        End Property


        Public Property PWS_Check() As Boolean
            Get
                Return _PWS_Check
            End Get
            Set(ByVal value As Boolean)
                _PWS_Check = value
            End Set
        End Property
        Public Property PWS_CheckAction() As String
            Get
                Return _PWS_CheckAction
            End Get
            Set(ByVal value As String)
                _PWS_CheckAction = value
            End Set
        End Property
        Public Property PWS_CheckDate() As Date
            Get
                Return _PWS_CheckDate
            End Get
            Set(ByVal value As Date)
                _PWS_CheckDate = value
            End Set
        End Property
        Public Property PWS_CheckRemark() As String
            Get
                Return _PWS_CheckRemark
            End Get
            Set(ByVal value As String)
                _PWS_CheckRemark = value
            End Set
        End Property

        '-------------------------------------------------------
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
        Public Property PWS_ActionName() As String
            Get
                Return _PWS_ActionName
            End Get
            Set(ByVal value As String)
                _PWS_ActionName = value
            End Set
        End Property
        Public Property PWS_CheckActionName() As String
            Get
                Return _PWS_CheckActionName
            End Get
            Set(ByVal value As String)
                _PWS_CheckActionName = value
            End Set
        End Property
        Public Property FacName() As String
            Get
                Return _FacName
            End Get
            Set(ByVal value As String)
                _FacName = value
            End Set
        End Property
        Public Property FacID() As String
            Get
                Return _FacID
            End Get
            Set(ByVal value As String)
                _FacID = value
            End Set
        End Property
        ''------------------------------------

        Public Property PWS_EndQty() As Double
            Get
                Return _PWS_EndQty
            End Get
            Set(ByVal value As Double)
                _PWS_EndQty = value
            End Set
        End Property

        Public Property PWS_EndQty1() As Double
            Get
                Return _PWS_EndQty1
            End Get
            Set(ByVal value As Double)
                _PWS_EndQty1 = value
            End Set
        End Property


    End Class
End Namespace