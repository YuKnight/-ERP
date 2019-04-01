Namespace LFERP.Library.KnifeWare
    Public Class KnifeWareOutInfo
        Private _WO_NUM As String
        Private _WO_ID As String

        Private _AP_NO As String   '申領單號
        Private _WO_Type As String  '出庫類型
        Private _OP_NO As String   '單號(生產出貨/生產開料)

        Private _M_Code As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _M_Price As Double
        Private _WO_Qty As Double
        Private _WO_AddDate As Date
        Private _WH_ID As String
        Private _OS_BatchID As String
        Private _WO_Action As String
        Private _WO_EditDate As Date
        Private _WO_Remark As String
        Private _DPT_ID As String

        Private _WO_PerID As String
        Private _WO_PerName As String

        Private _WO_Check As Boolean
        Private _WO_CheckAction As String
        Private _WO_CheckDate As Date
        Private _WO_CheckRemark As String
        Private _WO_ActionName As String
        Private _WO_CheckActionName As String


        Private _WO_ReCheck As Boolean
        Private _WO_ReCheckAction As String
        Private _WO_ReCheckDate As Date
        Private _WO_ReCheckRemark As String
        Private _KnifeType As String


        Private _WH_Name As String
        Private _WH_PName As String     '上一級倉庫名稱
        Private _DPT_Name As String
        Private _DPT_PName As String    '上一級部門名稱

        Private _WO_AddDate1 As Date '導出查詢所用
        Private _WO_AddDate2 As Date

        Private _OutGetQty As Double
        Private _OutGetQty1 As Double

        Private _M_ID As String
        Private _Temp_Code As String
        Private _WO_EndQty As Double
        Private _strDate As String  '年月--記錄出庫月份匯總信息()

        Private _TypeAllName As String  '物料類別
        Private _M_Currency As String   '幣別
        Private _AllQty As Double
        Private _WH_AllName As String    '完整倉庫名稱

        Private _SumHKD As Double
        Private _HKDRate As Double
        Private _WO_PerNameS As String '白名單子表姓名

        Public Sub New()

            _WO_NUM = Nothing
            _WO_ID = Nothing

            _WO_Type = Nothing
            _AP_NO = Nothing
            _OP_NO = Nothing

            _M_Code = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _M_Price = 0
            _WO_Qty = 0
            _WO_AddDate = Nothing
            _WH_ID = Nothing
            _OS_BatchID = Nothing
            _WO_Action = Nothing
            _WO_EditDate = Nothing
            _WO_Remark = Nothing
            _DPT_ID = Nothing
            _WO_Check = False
            _WO_CheckAction = Nothing
            _WO_CheckDate = Nothing
            _WO_CheckRemark = Nothing
            _WO_PerID = Nothing
            _WO_PerName = Nothing
            _WO_ActionName = Nothing
            _WO_CheckActionName = Nothing

            _WH_Name = Nothing
            _WH_PName = Nothing
            _DPT_Name = Nothing

            _WO_AddDate1 = Nothing
            _WO_AddDate2 = Nothing

            _OutGetQty = 0
            _OutGetQty1 = 0

            _WO_ReCheck = False
            _WO_ReCheckDate = Nothing
            _WO_ReCheckAction = Nothing
            _WO_ReCheckRemark = Nothing
            _KnifeType = Nothing

            '--------------------------申領單信息
            _M_ID = Nothing
            _Temp_Code = Nothing
            '-------------------------------
            _WO_EndQty = 0
            _strDate = Nothing

            _TypeAllName = Nothing
            _M_Currency = Nothing
            _AllQty = 0
            _WH_AllName = Nothing

            _SumHKD = 0
            _HKDRate = 0

            _WO_PerNameS = Nothing
        End Sub

        Public Property HKDRate() As Double
            Get
                Return _HKDRate
            End Get
            Set(ByVal value As Double)
                _HKDRate = value
            End Set
        End Property

        Public Property SumHKD() As Double
            Get
                Return _SumHKD
            End Get
            Set(ByVal value As Double)
                _SumHKD = value
            End Set
        End Property


        ''SumHKD

        ''' <summary>
        ''' 唯一編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property WO_NUM() As String
            Get
                Return _WO_NUM
            End Get
            Set(ByVal value As String)
                _WO_NUM = value
            End Set
        End Property


        ''' <summary>
        ''' 出庫編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property WO_ID() As String
            Get
                Return _WO_ID
            End Get
            Set(ByVal value As String)
                _WO_ID = value
            End Set
        End Property

        Public Property WO_Type() As String
            Get
                Return _WO_Type
            End Get
            Set(ByVal value As String)
                _WO_Type = value
            End Set
        End Property

        Public Property KnifeType() As String
            Get
                Return _KnifeType
            End Get
            Set(ByVal value As String)
                _KnifeType = value
            End Set
        End Property

        Public Property AP_NO() As String
            Get
                Return _AP_NO
            End Get
            Set(ByVal value As String)
                _AP_NO = value
            End Set
        End Property
        Public Property OP_NO() As String
            Get
                Return _OP_NO
            End Get
            Set(ByVal value As String)
                _OP_NO = value
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

        Public Property M_Price() As Double
            Get
                Return _M_Price
            End Get
            Set(ByVal value As Double)
                _M_Price = value
            End Set
        End Property

        Public Property WO_Qty() As Double
            Get
                Return _WO_Qty
            End Get
            Set(ByVal value As Double)
                _WO_Qty = value
            End Set
        End Property
        Public Property WO_AddDate() As Date
            Get
                Return _WO_AddDate
            End Get
            Set(ByVal value As Date)
                _WO_AddDate = value
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
        Public Property OS_BatchID() As String
            Get
                Return _OS_BatchID
            End Get
            Set(ByVal value As String)
                _OS_BatchID = value
            End Set
        End Property
        Public Property WO_Action() As String
            Get
                Return _WO_Action
            End Get
            Set(ByVal value As String)
                _WO_Action = value
            End Set
        End Property
        Public Property WO_EditDate() As Date
            Get
                Return _WO_EditDate
            End Get
            Set(ByVal value As Date)
                _WO_EditDate = value
            End Set
        End Property
        Public Property WO_Remark() As String
            Get
                Return _WO_Remark
            End Get
            Set(ByVal value As String)
                _WO_Remark = value
            End Set
        End Property
        Public Property DPT_ID() As String
            Get
                Return _DPT_ID
            End Get
            Set(ByVal value As String)
                _DPT_ID = value
            End Set
        End Property
        Public Property WO_Check() As Boolean
            Get
                Return _WO_Check
            End Get
            Set(ByVal value As Boolean)
                _WO_Check = value
            End Set
        End Property
        Public Property WO_CheckAction() As String
            Get
                Return _WO_CheckAction
            End Get
            Set(ByVal value As String)
                _WO_CheckAction = value
            End Set
        End Property
        Public Property WO_CheckDate() As Date
            Get
                Return _WO_CheckDate
            End Get
            Set(ByVal value As Date)
                _WO_CheckDate = value
            End Set
        End Property
        Public Property WO_CheckRemark() As String
            Get
                Return _WO_CheckRemark
            End Get
            Set(ByVal value As String)
                _WO_CheckRemark = value
            End Set
        End Property
        Public Property WO_PerName() As String
            Get
                Return _WO_PerName
            End Get
            Set(ByVal value As String)
                _WO_PerName = value
            End Set
        End Property
        Public Property WO_PerID() As String
            Get
                Return _WO_PerID
            End Get
            Set(ByVal value As String)
                _WO_PerID = value
            End Set
        End Property

        Public Property WO_ActionName() As String
            Get
                Return _WO_ActionName
            End Get
            Set(ByVal value As String)
                _WO_ActionName = value
            End Set
        End Property
        Public Property WO_CheckActionName() As String
            Get
                Return _WO_CheckActionName
            End Get
            Set(ByVal value As String)
                _WO_CheckActionName = value
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

        Public Property DPT_Name() As String
            Get
                Return _DPT_Name
            End Get
            Set(ByVal value As String)
                _DPT_Name = value
            End Set
        End Property

        Public Property DPT_PName() As String
            Get
                Return _DPT_PName
            End Get
            Set(ByVal value As String)
                _DPT_PName = value
            End Set
        End Property


        Public Property WO_AddDate1() As Date
            Get
                Return _WO_AddDate1
            End Get
            Set(ByVal value As Date)
                _WO_AddDate1 = value
            End Set
        End Property
        Public Property WO_AddDate2() As Date
            Get
                Return _WO_AddDate2
            End Get
            Set(ByVal value As Date)
                _WO_AddDate2 = value
            End Set
        End Property

        Public Property OutGetQty() As Double
            Get
                Return _OutGetQty
            End Get
            Set(ByVal value As Double)
                _OutGetQty = value
            End Set

        End Property
        Public Property OutGetQty1() As Double
            Get
                Return _OutGetQty1
            End Get
            Set(ByVal value As Double)
                _OutGetQty1 = value
            End Set

        End Property

        Public Property WO_ReCheck() As Boolean
            Get
                Return _WO_ReCheck
            End Get
            Set(ByVal value As Boolean)
                _WO_ReCheck = value
            End Set
        End Property
        Public Property WO_ReCheckDate() As Date
            Get
                Return _WO_ReCheckDate
            End Get
            Set(ByVal value As Date)
                _WO_ReCheckDate = value
            End Set
        End Property
        Public Property WO_ReCheckAction() As String
            Get
                Return _WO_ReCheckAction
            End Get
            Set(ByVal value As String)
                _WO_ReCheckAction = value
            End Set
        End Property
        Public Property WO_ReCheckRemark() As String
            Get
                Return _WO_ReCheckRemark
            End Get
            Set(ByVal value As String)
                _WO_ReCheckRemark = value
            End Set
        End Property

        Public Property M_ID() As String
            Get
                Return _M_ID
            End Get
            Set(ByVal value As String)
                _M_ID = value
            End Set
        End Property
        Public Property Temp_Code() As String
            Get
                Return _Temp_Code
            End Get
            Set(ByVal value As String)
                _Temp_Code = value
            End Set
        End Property
        Public Property WO_EndQty() As Double
            Get
                Return _WO_EndQty
            End Get
            Set(ByVal value As Double)
                _WO_EndQty = value
            End Set
        End Property
        Public Property strDate() As String
            Get
                Return _strDate
            End Get
            Set(ByVal value As String)
                _strDate = value
            End Set
        End Property
        Public Property TypeAllName() As String
            Get
                Return _TypeAllName
            End Get
            Set(ByVal value As String)
                _TypeAllName = value
            End Set
        End Property
        Public Property M_Currency() As String
            Get
                Return _M_Currency
            End Get
            Set(ByVal value As String)
                _M_Currency = value
            End Set
        End Property
        Public Property AllQty() As Double
            Get
                Return _AllQty
            End Get
            Set(ByVal value As Double)
                _AllQty = value
            End Set
        End Property

        Public Property WH_AllName() As String
            Get
                Return _WH_AllName
            End Get
            Set(ByVal value As String)
                _WH_AllName = value
            End Set
        End Property

        Public Property WO_PerNameS() As String
            Get
                Return _WO_PerNameS
            End Get
            Set(ByVal value As String)
                _WO_PerNameS = value
            End Set
        End Property

    End Class
End Namespace
