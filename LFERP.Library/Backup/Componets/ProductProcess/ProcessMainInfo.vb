Namespace LFERP.Library.ProductProcess
    Public Class ProcessMainInfo
        Private _PM_M_Code As String
        Private _Pro_NO As String
        Private _M_Code As String

        Private _Pro_Type As String
        Private _Type3ID As String
        Private _PM_Type As String
        Private _Pro_Weight As String
        Private _Pro_Remark As String
        Private _Pro_Describe As String
        Private _Pro_Photo As Byte()
        Private _Pro_Action As String
        Private _Pro_AddDate As Date
        Private _Pro_EditDate As Date
        Private _Pro_Check As Boolean
        Private _Pro_CheckDate As Date
        Private _Pro_CheckRemark As String
        Private _Pro_CheckAction As String
        Private _Pro_Rate As Double

        Private _PS_NO As String
        Private _PS_Num As String
        Private _D_Name As String
        Private _PS_Name As String
        Private _PS_Type As String
        Private _PS_Remark As String
        Private _PS_Check As Boolean
        Private _IndexNO As Integer
        Private _PS_PaiXu As String
        Private _PS_Enable As Boolean
        Private _PS_OutPut As String
        Private _PS_Weight As Double

        Private _Check As String

        Private _M_Name As String
        Private _M_Unit As String
        Private _M_Gauge As String
        Private _CustomerNO As String
        Private _PM_JiYu As String
        Private _ActionName As String
        Private _CheckActionName As String


        Private _D_ID As String
        Private _D_Type As String
        Private _D_Dep As String

        Private _Pro_M_NO As String '產品工序單號
        Private _PieceBit As Boolean
        Private _PM_ProcessType As String



        Sub New()
            _PM_M_Code = Nothing
            _Pro_NO = Nothing
            _M_Code = Nothing

            _CustomerNO = Nothing
            _PM_JiYu = Nothing

            _Pro_Type = Nothing
            _Type3ID = Nothing
            _PM_Type = Nothing
            _Pro_Weight = Nothing
            _Pro_Remark = Nothing
            _Pro_Describe = Nothing
            _Pro_Photo = Nothing
            _Pro_Action = Nothing
            _Pro_AddDate = Nothing
            _Pro_EditDate = Nothing
            _Pro_Check = False
            _Pro_CheckDate = Nothing
            _Pro_CheckRemark = Nothing
            _Pro_CheckAction = Nothing
            _Pro_Rate = Nothing

            _PS_NO = Nothing
            _PS_Num = Nothing

            _D_Name = Nothing
            _PS_Remark = Nothing
            _PS_Name = Nothing
            _PS_Type = Nothing
            _PS_Check = False
            _IndexNO = 0
            _Check = Nothing
            _PS_PaiXu = Nothing
            _PS_Enable = False
            _PS_OutPut = Nothing
            _PS_Weight = 0

            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _ActionName = Nothing
            _CheckActionName = Nothing

            _D_ID = Nothing
            _D_Type = Nothing
            _D_Dep = Nothing

            _Pro_M_NO = Nothing
            _PieceBit = Nothing
            _PM_ProcessType = Nothing
        End Sub
        ''' <summary>
        ''' 產品編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_ProcessType() As String
            Get
                Return _PM_ProcessType
            End Get
            Set(ByVal value As String)
                _PM_ProcessType = value
            End Set
        End Property
        ''' <summary>
        ''' 產品編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PieceBit() As Boolean
            Get
                Return _PieceBit
            End Get
            Set(ByVal value As Boolean)
                _PieceBit = value
            End Set
        End Property
        ''' <summary>
        ''' 產品編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_M_Code() As String
            Get
                Return _PM_M_Code
            End Get
            Set(ByVal value As String)
                _PM_M_Code = value
            End Set
        End Property
        ''' <summary>
        ''' 工藝流程單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Pro_NO() As String
            Get
                Return _Pro_NO
            End Get
            Set(ByVal value As String)
                _Pro_NO = value
            End Set
        End Property
        ''' <summary>
        ''' 物料編碼
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Code() As String
            Get
                Return _M_Code
            End Get
            Set(ByVal value As String)
                _M_Code = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' 單位
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Unit() As String
            Get
                Return _M_Unit
            End Get
            Set(ByVal value As String)
                _M_Unit = value
            End Set
        End Property
        ''' <summary>
        ''' 客戶代號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CustomerNO() As String
            Get
                Return _CustomerNO
            End Get
            Set(ByVal value As String)
                _CustomerNO = value
            End Set
        End Property
        ''' <summary>
        ''' 機玉
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_JiYu() As String
            Get
                Return _PM_JiYu
            End Get
            Set(ByVal value As String)
                _PM_JiYu = value
            End Set
        End Property
        ''' <summary>
        ''' 工藝分類
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Pro_Type() As String
            Get
                Return _Pro_Type
            End Get
            Set(ByVal value As String)
                _Pro_Type = value
            End Set
        End Property
        ''' <summary>
        ''' '重量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Pro_Weight() As String
            Get
                Return _Pro_Weight
            End Get
            Set(ByVal value As String)
                _Pro_Weight = value
            End Set
        End Property

        ''' <summary>
        ''' 產品類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Property Type3ID() As String
            Get
                Return _Type3ID
            End Get
            Set(ByVal value As String)
                _Type3ID = value
            End Set
        End Property
        ''' <summary>
        ''' 類別
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
        ''' <summary>
        ''' 比例
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Pro_Rate() As Double
            Get
                Return _Pro_Rate
            End Get
            Set(ByVal value As Double)
                _Pro_Rate = value
            End Set
        End Property

        ''' <summary>
        ''' 備註
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Pro_Remark() As String
            Get
                Return _Pro_Remark
            End Get
            Set(ByVal value As String)
                _Pro_Remark = value
            End Set
        End Property
        ''' <summary>
        ''' 描述
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Pro_Describe() As String
            Get
                Return _Pro_Describe
            End Get
            Set(ByVal value As String)
                _Pro_Describe = value
            End Set
        End Property
        ''' <summary>
        ''' 操作員ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Pro_Action() As String
            Get
                Return _Pro_Action
            End Get
            Set(ByVal value As String)
                _Pro_Action = value
            End Set
        End Property
        ''' <summary>
        ''' 圖片（轉化為二進制保存）
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Pro_Photo() As Byte()
            Get
                Return _Pro_Photo
            End Get
            Set(ByVal value As Byte())
                _Pro_Photo = value
            End Set
        End Property
        ''' <summary>
        ''' 建立日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Pro_AddDate() As Date
            Get
                Return _Pro_AddDate
            End Get
            Set(ByVal value As Date)
                _Pro_AddDate = value
            End Set
        End Property
        ''' <summary>
        ''' 修改日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Pro_EditDate() As Date
            Get
                Return _Pro_EditDate
            End Get
            Set(ByVal value As Date)
                _Pro_EditDate = value
            End Set
        End Property
        ''' <summary>
        ''' 審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Pro_Check() As Boolean
            Get
                Return _Pro_Check
            End Get
            Set(ByVal value As Boolean)
                _Pro_Check = value
            End Set
        End Property
        ''' <summary>
        ''' 審核日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Pro_CheckDate() As Date
            Get
                Return _Pro_CheckDate
            End Get
            Set(ByVal value As Date)
                _Pro_CheckDate = value
            End Set
        End Property
        ''' <summary>
        ''' 審核備註
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Pro_CheckRemark() As String
            Get
                Return _Pro_CheckRemark
            End Get
            Set(ByVal value As String)
                _Pro_CheckRemark = value
            End Set
        End Property
        ''' <summary>
        ''' 審核員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Pro_CheckAction() As String
            Get
                Return _Pro_CheckAction
            End Get
            Set(ByVal value As String)
                _Pro_CheckAction = value
            End Set
        End Property
        ''' <summary>
        ''' 工序編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_NO() As String
            Get
                Return _PS_NO
            End Get
            Set(ByVal value As String)
                _PS_NO = value
            End Set
        End Property
        ''' <summary>
        ''' 序號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_Num() As String
            Get
                Return _PS_Num
            End Get
            Set(ByVal value As String)
                _PS_Num = value
            End Set
        End Property

        ''' <summary>
        ''' 部門（文字）
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property D_Name() As String
            Get
                Return _D_Name
            End Get
            Set(ByVal value As String)
                _D_Name = value
            End Set
        End Property
        ''' <summary>
        ''' 工序名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_Name() As String
            Get
                Return _PS_Name
            End Get
            Set(ByVal value As String)
                _PS_Name = value
            End Set
        End Property
        ''' <summary>
        ''' 注意事項
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_Remark() As String
            Get
                Return _PS_Remark
            End Get
            Set(ByVal value As String)
                _PS_Remark = value
            End Set
        End Property
        ''' <summary>
        '''工序流水號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property IndexNO() As Integer
            Get
                Return _IndexNO
            End Get
            Set(ByVal value As Integer)
                _IndexNO = value
            End Set
        End Property
        ''' <summary>
        ''' 物料名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Name() As String
            Get
                Return _M_Name
            End Get
            Set(ByVal value As String)
                _M_Name = value
            End Set
        End Property
        ''' <summary>
        ''' 物料規格
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Gauge() As String
            Get
                Return _M_Gauge
            End Get
            Set(ByVal value As String)
                _M_Gauge = value
            End Set
        End Property

        ''' <summary>
        ''' 子表審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Check() As String
            Get
                Return _Check
            End Get
            Set(ByVal value As String)
                _Check = value
            End Set
        End Property

        ''' <summary>
        ''' 部門ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property D_ID() As String
            Get
                Return _D_ID
            End Get
            Set(ByVal value As String)
                _D_ID = value
            End Set
        End Property
        ''' <summary>
        ''' 部門類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property D_Type() As String
            Get
                Return _D_Type
            End Get
            Set(ByVal value As String)
                _D_Type = value
            End Set
        End Property

        Public Property D_Dep() As String
            Get
                Return _D_Dep
            End Get
            Set(ByVal value As String)
                _D_Dep = value
            End Set
        End Property
        Public Property ActionName() As String
            Get
                Return _ActionName
            End Get
            Set(ByVal value As String)
                _ActionName = value
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
        Public Property PS_Check() As Boolean
            Get
                Return _PS_Check
            End Get
            Set(ByVal value As Boolean)
                _PS_Check = value
            End Set
        End Property
        Public Property PS_PaiXu() As String
            Get
                Return _PS_PaiXu
            End Get
            Set(ByVal value As String)
                _PS_PaiXu = value
            End Set
        End Property
        Public Property PS_Enable() As Boolean
            Get
                Return _PS_Enable
            End Get
            Set(ByVal value As Boolean)
                _PS_Enable = value
            End Set
        End Property
        Public Property PS_OutPut() As String
            Get
                Return _PS_OutPut
            End Get
            Set(ByVal value As String)
                _PS_OutPut = value
            End Set
        End Property

        Public Property Pro_M_NO() As String
            Get
                Return _Pro_M_NO
            End Get
            Set(ByVal value As String)
                _Pro_M_NO = value
            End Set
        End Property
        Public Property PS_Weight() As Double
            Get
                Return _PS_Weight
            End Get
            Set(ByVal value As Double)
                _PS_Weight = value
            End Set
        End Property
        Public Property PS_Type() As String
            Get
                Return _PS_Type

            End Get
            Set(ByVal value As String)
                _PS_Type = value
            End Set
        End Property

    End Class

End Namespace

