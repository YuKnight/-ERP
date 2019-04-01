

Namespace LFERP.Library.ProductionKaiLiao

    Public Class ProductionKaiLiaoInfo

        Private _IndexNo As Integer
        Private _C_NO As String
        Private _WH_ID As String
        Private _Pro_Type As String
        Private _PM_M_Code As String
        Private _PM_Type As String
        Private _PS_Dep As String
        Private _PS_Action As String
        Private _C_Qty As Double
        Private _C_Weight As Double
        Private _C_Action As String
        Private _C_Remark As String
        Private _C_AddDate As Date
        Private _M_Code As String
        Private _C_Cishu As Integer
        Private _C_Type As String
        Private _C_Check As Boolean
        Private _C_CheckAction As String
        Private _C_CheckRemark As String
        Private _C_ReCheck As Boolean

        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _DPT_Name As String
        Private _FacName As String
        Private _FacID As String
        Private _WH_Name As String
        Private _WH_PName As String
        Private _CheckActionName As String
        Private _C_Number As String
        Private _OM_ID As String
        Private _OS_BatchID As String
        Private _BadQty As Integer
        Private _FP_NO As String

        '------------------------------------針對開料實際使用明細記錄情況表(主要針對開料--原材料情況)

        Private _KL_NO As String
        Private _M_Type As String  '區分原材料,配件等
        Private _KL_Qty As Integer
        Private _KL_TheoryWeight As Double
        Private _KL_ActualWeight As Double
        Private _KL_Action As String
        Private _KL_Date As Date
        Private _KL_Check As Boolean
        Private _KaiLiaoActionName As String

        '-----------------------------------
        Private _PM_JiYu As String
        Private _PM_M_Gauge As String
        Private _PM_M_Name As String


        Sub New()

            _PM_JiYu = Nothing
            _PM_M_Gauge = Nothing
            _PM_M_Name = Nothing

            _IndexNo = 0
            _C_NO = Nothing
            _WH_ID = Nothing
            _Pro_Type = Nothing
            _PM_M_Code = Nothing
            _PM_Type = Nothing
            _PS_Dep = Nothing
            _PS_Action = Nothing
            _C_Qty = 0
            _C_Weight = 0
            _C_Action = Nothing
            _C_Remark = Nothing
            _C_AddDate = Nothing
            _M_Code = Nothing
            _C_Cishu = 0
            _C_Type = Nothing
            _C_Check = False
            _C_CheckAction = Nothing
            _C_CheckRemark = Nothing
            _C_ReCheck = False

            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _DPT_Name = Nothing
            _FacName = Nothing
            _FacID = Nothing
            _C_Number = Nothing

            _WH_Name = Nothing
            _WH_PName = Nothing
            _CheckActionName = Nothing

            _OM_ID = Nothing
            _OS_BatchID = Nothing
            _BadQty = Nothing
            _FP_NO = Nothing
            '------------------------------
            _KL_NO = Nothing
            _M_Type = Nothing
            _KL_Qty = 0
            _KL_TheoryWeight = Nothing
            _KL_ActualWeight = Nothing
            _KL_Action = Nothing
            _KL_Date = Nothing
            _KL_Check = False
            _KaiLiaoActionName = Nothing
            '------------------------------
        End Sub '
        Public Property BadQty() As Integer
            Get
                Return _BadQty
            End Get
            Set(ByVal value As Integer)
                _BadQty = value
            End Set
        End Property
        Public Property FP_NO() As String
            Get
                Return _FP_NO
            End Get
            Set(ByVal value As String)
                _FP_NO = value
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
        Public Property C_Number() As String
            Get
                Return _C_Number
            End Get
            Set(ByVal value As String)
                _C_Number = value
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

        Public Property IndexNo() As Integer
            Get
                Return _IndexNo
            End Get
            Set(ByVal value As Integer)
                _IndexNo = value
            End Set
        End Property
        Public Property C_NO() As String
            Get
                Return _C_NO
            End Get
            Set(ByVal value As String)
                _C_NO = value
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
        Public Property Pro_Type() As String
            Get
                Return _Pro_Type
            End Get
            Set(ByVal value As String)
                _Pro_Type = value
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
        Public Property PM_Type() As String
            Get
                Return _PM_Type
            End Get
            Set(ByVal value As String)
                _PM_Type = value
            End Set
        End Property
        Public Property PS_Dep() As String
            Get
                Return _PS_Dep
            End Get
            Set(ByVal value As String)
                _PS_Dep = value
            End Set
        End Property
        Public Property PS_Action() As String
            Get
                Return _PS_Action
            End Get
            Set(ByVal value As String)
                _PS_Action = value
            End Set
        End Property
        Public Property C_Qty() As Double
            Get
                Return _C_Qty
            End Get
            Set(ByVal value As Double)
                _C_Qty = value
            End Set
        End Property
        Public Property C_Weight() As Double
            Get
                Return _C_Weight
            End Get
            Set(ByVal value As Double)
                _C_Weight = value
            End Set
        End Property
        Public Property C_Action() As String
            Get
                Return _C_Action
            End Get
            Set(ByVal value As String)
                _C_Action = value
            End Set
        End Property
        Public Property C_Remark() As String
            Get
                Return _C_Remark
            End Get
            Set(ByVal value As String)
                _C_Remark = value
            End Set
        End Property
        Public Property C_AddDate() As Date
            Get
                Return _C_AddDate
            End Get
            Set(ByVal value As Date)
                _C_AddDate = value
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
        Public Property C_Cishu() As Integer
            Get
                Return _C_Cishu
            End Get
            Set(ByVal value As Integer)
                _C_Cishu = value
            End Set
        End Property
        Public Property C_Type() As String
            Get
                Return _C_Type
            End Get
            Set(ByVal value As String)
                _C_Type = value
            End Set
        End Property
        Public Property C_Check() As Boolean
            Get
                Return _C_Check
            End Get
            Set(ByVal value As Boolean)
                _C_Check = value
            End Set
        End Property
        Public Property C_CheckAction() As String
            Get
                Return _C_CheckAction
            End Get
            Set(ByVal value As String)
                _C_CheckAction = value
            End Set
        End Property
        Public Property C_CheckRemark() As String
            Get
                Return _C_CheckRemark
            End Get
            Set(ByVal value As String)
                _C_CheckRemark = value
            End Set
        End Property

        Public Property C_ReCheck() As Boolean
            Get
                Return _C_ReCheck
            End Get
            Set(ByVal value As Boolean)
                _C_ReCheck = value
            End Set
        End Property
        '--------------------------------
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
        Public Property DPT_Name() As String
            Get
                Return _DPT_Name
            End Get
            Set(ByVal value As String)
                _DPT_Name = value
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

        Public Property WH_Name() As String
            Get
                Return _WH_Name
            End Get
            Set(ByVal value As String)
                _WH_Name = value
            End Set
        End Property
        Public Property WH_PName() As String
            Get
                Return _WH_PName
            End Get
            Set(ByVal value As String)
                _WH_PName = value
            End Set
        End Property
        Public Property CheckActionName() As String
            Get
                Return _CheckActionName
            End Get
            Set(ByVal value As String)
                _CheckActionName = value
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

        Public Property PM_M_Gauge() As String
            Get
                Return _PM_M_Gauge
            End Get
            Set(ByVal value As String)
                _PM_M_Gauge = value
            End Set
        End Property

        Public Property PM_M_Name() As String
            Get
                Return _PM_M_Name
            End Get
            Set(ByVal value As String)
                _PM_M_Name = value
            End Set
        End Property

        '---------------------------------------------
#Region "開料耗用記錄信息"
        Public Property KL_NO() As String
            Get
                Return _KL_NO
            End Get
            Set(ByVal value As String)
                _KL_NO = value
            End Set
        End Property
        Public Property KL_Qty() As Integer
            Get
                Return _KL_Qty
            End Get
            Set(ByVal value As Integer)
                _KL_Qty = value
            End Set
        End Property
        Public Property KL_TheoryWeight() As Double
            Get
                Return _KL_TheoryWeight
            End Get
            Set(ByVal value As Double)
                _KL_TheoryWeight = value
            End Set
        End Property
        Public Property KL_ActualWeight() As Double
            Get
                Return _KL_ActualWeight
            End Get
            Set(ByVal value As Double)
                _KL_ActualWeight = value
            End Set
        End Property
        Public Property KL_Action() As String
            Get
                Return _KL_Action
            End Get
            Set(ByVal value As String)
                _KL_Action = value
            End Set
        End Property
        Public Property KL_Date() As Date
            Get
                Return _KL_Date
            End Get
            Set(ByVal value As Date)
                _KL_Date = value
            End Set
        End Property
        Public Property KL_Check() As Boolean
            Get
                Return _KL_Check
            End Get
            Set(ByVal value As Boolean)
                _KL_Check = value
            End Set
        End Property
        Public Property KaiLiaoActionName() As String
            Get
                Return _KaiLiaoActionName
            End Get
            Set(ByVal value As String)
                _KaiLiaoActionName = value
            End Set
        End Property
        Public Property M_Type() As String
            Get
                Return _M_Type
            End Get
            Set(ByVal value As String)
                _M_Type = value
            End Set
        End Property
#End Region
        '---------------------------------------------
    End Class

End Namespace

