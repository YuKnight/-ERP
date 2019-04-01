Namespace LFERP.Library.Delivery

    Public Class DeliveryInfo

        Private _DN_ID As String
        Private _DN_Date As Date
        Private _DN_Remark As String
        Private _DN_Action As String
        Private _WH_ID As String
        Private _DN_CusterNO As String
        Private _DN_Type As String
        Private _DN_Charge As String
        Private _DN_Invoice As Boolean
        Private _DN_Return As Boolean
        Private _DN_Check As Boolean
        Private _DN_CheckDate As Date
        Private _DN_CheckAction As String
        Private _DN_CheckRemark As String
        Private _DN_AccCheck As Boolean
        Private _DN_AccCheckAction As String
        Private _DN_AccCheckType As String
        Private _DN_AccCheckDate As Date
        Private _DN_AccCheckRemark As String

        Private _P_NO As String
        Private _DNS_NO As String
        Private _P_Type As String
        Private _OS_BatchID As String
        Private _M_Code As String
        Private _DN_Qty As Double
        Private _DN_SP As Double
        Private _DN_Help As String
        Private _R_NO As String

        Private _DS_Qty As Double
        Private _DS_SP As Double

        Private _M_Name As String
        Private _M_Gauge As String
        Private _ActionName As String
        Private _CheckActionName As String
        Private _AccCheckActionName As String

        Private _AutoID As Integer
        Private _IndexNO As Integer
        Private _IndexNum As Integer
        Private _WH_Name As String


        Sub New()

            _DN_ID = Nothing
            _DN_Date = Nothing
            _DN_Remark = Nothing
            _DN_Action = Nothing
            _WH_ID = Nothing
            _DN_CusterNO = Nothing
            _DN_Type = Nothing
            _DN_Charge = Nothing
            _DN_Invoice = False
            _DN_Return = False
            _DN_Check = False
            _DN_CheckDate = Nothing
            _DN_CheckAction = Nothing
            _DN_CheckRemark = Nothing
            _DN_AccCheck = False
            _DN_AccCheckAction = Nothing
            _DN_AccCheckType = Nothing
            _DN_AccCheckDate = Nothing
            _DN_AccCheckRemark = Nothing

            _P_NO = Nothing
            _DNS_NO = Nothing
            _P_Type = Nothing
            _OS_BatchID = Nothing
            _M_Code = Nothing
            _DN_Qty = 0
            _DN_SP = 0
            _DN_Help = Nothing
            _R_NO = Nothing

            _DS_Qty = 0
            _DS_SP = 0

            _M_Name = Nothing
            _M_Gauge = Nothing

            _ActionName = Nothing
            _CheckActionName = Nothing
            _AccCheckActionName = Nothing

            _IndexNO = 0
            _AutoID = 0
            _IndexNum = 0
            _WH_Name = Nothing

        End Sub
        ''' <summary>
        ''' 送貨單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DN_ID() As String
            Get
                Return _DN_ID
            End Get
            Set(ByVal value As String)
                _DN_ID = value
            End Set
        End Property
        ''' <summary>
        '''送貨日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DN_Date() As Date
            Get
                Return _DN_Date
            End Get
            Set(ByVal value As Date)
                _DN_Date = value
            End Set
        End Property
        ''' <summary>
        ''' 備註
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DN_Remark() As String
            Get
                Return _DN_Remark
            End Get
            Set(ByVal value As String)
                _DN_Remark = value
            End Set
        End Property
        ''' <summary>
        ''' 操作員ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DN_Action() As String
            Get
                Return _DN_Action
            End Get
            Set(ByVal value As String)
                _DN_Action = value
            End Set
        End Property
        ''' <summary>
        '''倉庫編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property WH_ID() As String
            Get
                Return _WH_ID
            End Get
            Set(ByVal value As String)
                _WH_ID = value
            End Set
        End Property
        ''' <summary>
        ''' 客戶代號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DN_CusterNO() As String
            Get
                Return _DN_CusterNO
            End Get
            Set(ByVal value As String)
                _DN_CusterNO = value
            End Set
        End Property
        ''' <summary>
        ''' 送貨類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DN_Type() As String
            Get
                Return _DN_Type
            End Get
            Set(ByVal value As String)
                _DN_Type = value
            End Set
        End Property
        ''' <summary>
        '''收費類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DN_Charge() As String
            Get
                Return _DN_Charge
            End Get
            Set(ByVal value As String)
                _DN_Charge = value
            End Set
        End Property
        ''' <summary>
        ''' 是否已開發票
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DN_Invoice() As Boolean
            Get
                Return _DN_Invoice
            End Get
            Set(ByVal value As Boolean)
                _DN_Invoice = value
            End Set
        End Property
        ''' <summary>
        ''' 是否退貨
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DN_Return() As Boolean
            Get
                Return _DN_Return
            End Get
            Set(ByVal value As Boolean)
                _DN_Return = value
            End Set
        End Property
        ''' <summary>
        ''' 審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DN_Check() As Boolean
            Get
                Return _DN_Check
            End Get
            Set(ByVal value As Boolean)
                _DN_Check = value
            End Set
        End Property
        ''' <summary>
        ''' 審核員ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DN_CheckAction() As String
            Get
                Return _DN_CheckAction
            End Get
            Set(ByVal value As String)
                _DN_CheckAction = value
            End Set
        End Property
        ''' <summary>
        ''' 審核日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DN_CheckDate() As Date
            Get
                Return _DN_CheckDate
            End Get
            Set(ByVal value As Date)
                _DN_CheckDate = value
            End Set
        End Property
        ''' <summary>
        ''' 審核備註
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DN_CheckRemark() As String
            Get
                Return _DN_CheckRemark
            End Get
            Set(ByVal value As String)
                _DN_CheckRemark = value
            End Set
        End Property
        ''' <summary>
        ''' 復核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DN_AccCheck() As Boolean
            Get
                Return _DN_AccCheck
            End Get
            Set(ByVal value As Boolean)
                _DN_AccCheck = value
            End Set
        End Property
        ''' <summary>
        ''' 復核日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DN_AccCheckDate() As Date
            Get
                Return _DN_AccCheckDate
            End Get
            Set(ByVal value As Date)
                _DN_AccCheckDate = value
            End Set
        End Property
        ''' <summary>
        ''' 復核員ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DN_AccCheckAction() As String
            Get
                Return _DN_AccCheckAction
            End Get
            Set(ByVal value As String)
                _DN_AccCheckAction = value
            End Set
        End Property
        ''' <summary>
        ''' 復核類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DN_AccCheckType() As String
            Get
                Return _DN_AccCheckType
            End Get
            Set(ByVal value As String)
                _DN_AccCheckType = value
            End Set
        End Property
        ''' <summary>
        ''' 復核備註
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DN_AccCheckRemark() As String
            Get
                Return _DN_AccCheckRemark
            End Get
            Set(ByVal value As String)
                _DN_AccCheckRemark = value
            End Set
        End Property
        ''' <summary>
        ''' 裝箱編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property P_NO() As String
            Get
                Return _P_NO
            End Get
            Set(ByVal value As String)
                _P_NO = value
            End Set
        End Property
        ''' <summary>
        ''' 送貨項目編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DNS_NO() As String
            Get
                Return _DNS_NO
            End Get
            Set(ByVal value As String)
                _DNS_NO = value
            End Set
        End Property
        ''' <summary>
        ''' 裝箱類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property P_Type() As String
            Get
                Return _P_Type
            End Get
            Set(ByVal value As String)
                _P_Type = value
            End Set
        End Property
        ''' <summary>
        ''' 批次編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_BatchID() As String
            Get
                Return _OS_BatchID
            End Get
            Set(ByVal value As String)
                _OS_BatchID = value
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
        ''' 送貨數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DN_Qty() As Double
            Get
                Return _DN_Qty
            End Get
            Set(ByVal value As Double)
                _DN_Qty = value
            End Set
        End Property
        ''' <summary>
        ''' 送貨士啤
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DN_SP() As Double
            Get
                Return _DN_SP
            End Get
            Set(ByVal value As Double)
                _DN_SP = value
            End Set
        End Property
        ''' <summary>
        '''說明
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DN_Help() As String
            Get
                Return _DN_Help
            End Get
            Set(ByVal value As String)
                _DN_Help = value
            End Set
        End Property
        ''' <summary>
        ''' 退貨單號（針對送貨類型為返修時）
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_NO() As String
            Get
                Return _R_NO
            End Get
            Set(ByVal value As String)
                _R_NO = value
            End Set
        End Property
        ''' <summary>
        ''' 送貨配件表數量（針對B類型）
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DS_Qty() As Double
            Get
                Return _DS_Qty
            End Get
            Set(ByVal value As Double)
                _DS_Qty = value
            End Set
        End Property
        ''' <summary>
        ''' 送貨配件表士啤
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DS_SP() As Double
            Get
                Return _DS_SP
            End Get
            Set(ByVal value As Double)
                _DS_SP = value
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
        ''' 操作員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property ActionName() As String
            Get
                Return _ActionName
            End Get
            Set(ByVal value As String)
                _ActionName = value
            End Set
        End Property
        ''' <summary>
        ''' 審核員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CheckActionName() As String
            Get
                Return _CheckActionName
            End Get
            Set(ByVal value As String)
                _CheckActionName = value
            End Set
        End Property
        ''' <summary>
        ''' 復核員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property AccCheckActionName() As String
            Get
                Return _AccCheckActionName
            End Get
            Set(ByVal value As String)
                _AccCheckActionName = value
            End Set
        End Property

        ''' <summary>
        ''' 自動流水號
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
        Public Property AutoID() As Integer
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Integer)
                _AutoID = value
            End Set
        End Property
        Public Property IndexNum() As Integer
            Get
                Return _IndexNum
            End Get
            Set(ByVal value As Integer)
                _IndexNum = value
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
    End Class


End Namespace


