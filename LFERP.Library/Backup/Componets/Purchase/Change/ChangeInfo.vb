
Namespace LFERP.Library.Purchase.Change

    Public Class ChangeInfo

        Private _C_ChangeNO As String
        Private _C_Type As String
        Private _PM_NO As String
        Private _M_Code As String
        Private _C_NoSendQty As Double
        Private _C_Price As Double
        Private _C_Date As Date
        Private _C_Remark As String
        Private _C_Action As String
        Private _C_Check As Boolean
        Private _C_CheckDate As Date
        Private _C_CheckType As String
        Private _C_CheckRemark As String
        Private _C_CheckAction As String

        Private _C_Reason As String
        Private _PM_Qty As Double
        Private _PM_PurchaseQty As Double

        Private _M_Gauge As String
        Private _M_Name As String
        Private _M_Unit As String
        Private _ActionName As String
        Private _CheckActionName As String

        Private _IndexNO As String


        Private _C_Date1 As String
        Private _C_Date2 As String
        Private _S_Supplier As String
        Private _S_SupplierName As String

        Private _C_Qty As Double  '更改后未交數


        Sub New()

            _C_ChangeNO = Nothing
            _C_Type = Nothing
            _PM_NO = Nothing
            _M_Code = Nothing
            _C_NoSendQty = 0
            _C_Price = 0
            _C_Date = Nothing
            _C_Remark = Nothing
            _C_Action = Nothing

            _C_Reason = Nothing
            _PM_Qty = 0
            _PM_PurchaseQty = 0

            _C_Check = False
            _C_CheckDate = Nothing
            _C_CheckType = Nothing
            _C_CheckRemark = Nothing
            _C_CheckAction = Nothing

            _M_Gauge = Nothing
            _M_Name = Nothing
            _M_Unit = Nothing

            _ActionName = Nothing
            _CheckActionName = Nothing

            _IndexNO = 0
            _S_Supplier = Nothing

            _C_Date1 = Nothing
            _C_Date2 = Nothing

            _S_Supplier = Nothing
            _S_SupplierName = Nothing

            _C_Qty = 0
        End Sub
        ''' <summary>
        ''' 更改單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property C_ChangeNO() As String
            Get
                Return _C_ChangeNO
            End Get
            Set(ByVal value As String)
                _C_ChangeNO = value
            End Set
        End Property
        ''' <summary>
        ''' 更改單類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property C_Type() As String
            Get
                Return _C_Type
            End Get
            Set(ByVal value As String)
                _C_Type = value
            End Set
        End Property
        ''' <summary>
        ''' 採購單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_NO() As String
            Get
                Return _PM_NO
            End Get
            Set(ByVal value As String)
                _PM_NO = value
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
        ''' 更改后未交數
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property C_NoSendQty() As Double
            Get
                Return _C_NoSendQty
            End Get
            Set(ByVal value As Double)
                _C_NoSendQty = value
            End Set
        End Property
        ''' <summary>
        ''' 單價
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property C_Price() As Double
            Get
                Return _C_Price
            End Get
            Set(ByVal value As Double)
                _C_Price = value
            End Set
        End Property
        ''' <summary>
        ''' 備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property C_Remark() As String
            Get
                Return _C_Remark
            End Get
            Set(ByVal value As String)
                _C_Remark = value
            End Set
        End Property
        ''' <summary>
        ''' 更改日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property C_Date() As Date
            Get
                Return _C_Date
            End Get
            Set(ByVal value As Date)
                _C_Date = value
            End Set
        End Property
        ''' <summary>
        ''' 操作人（工號）
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property C_Action() As String
            Get
                Return _C_Action
            End Get
            Set(ByVal value As String)
                _C_Action = value
            End Set
        End Property
        ''' <summary>
        ''' 審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property C_Check() As Boolean
            Get
                Return _C_Check
            End Get
            Set(ByVal value As Boolean)
                _C_Check = value
            End Set
        End Property
        ''' <summary>
        ''' 審核日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property C_CheckDate() As Date
            Get
                Return _C_CheckDate
            End Get
            Set(ByVal value As Date)
                _C_CheckDate = value
            End Set
        End Property
        ''' <summary>
        ''' 審核類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property C_CheckType() As String
            Get
                Return _C_CheckType
            End Get
            Set(ByVal value As String)
                _C_CheckType = value
            End Set
        End Property
        ''' <summary>
        ''' 審核備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property C_CheckRemark() As String
            Get
                Return _C_CheckRemark
            End Get
            Set(ByVal value As String)
                _C_CheckRemark = value
            End Set
        End Property
        ''' <summary>
        ''' 審核人（工號）
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property C_CheckAction() As String
            Get
                Return _C_CheckAction
            End Get
            Set(ByVal value As String)
                _C_CheckAction = value
            End Set
        End Property
        '-------------------------------------------------------------------------------------
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
        ''' 操作人（姓名）
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
        ''' 審核人（姓名）
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
        ''' 更改單流水號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property IndexNO() As String
            Get
                Return _IndexNO
            End Get
            Set(ByVal value As String)
                _IndexNO = value
            End Set
        End Property

        Public Property C_Reason() As String
            Get
                Return _C_Reason
            End Get
            Set(ByVal value As String)
                _C_Reason = value
            End Set
        End Property
        Public Property PM_Qty() As Double
            Get
                Return _PM_Qty
            End Get
            Set(ByVal value As Double)
                _PM_Qty = value
            End Set
        End Property
        Public Property PM_PurchaseQty() As Double
            Get
                Return _PM_PurchaseQty
            End Get
            Set(ByVal value As Double)
                _PM_PurchaseQty = value
            End Set
        End Property
        Public Property S_Supplier() As String
            Get
                Return _S_Supplier
            End Get
            Set(ByVal value As String)
                _S_Supplier = value
            End Set
        End Property
        Public Property S_SupplierName() As String
            Get
                Return _S_SupplierName
            End Get
            Set(ByVal value As String)
                _S_SupplierName = value
            End Set
        End Property
        ''' <summary>
        ''' 導出日期1
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property C_Date1() As String
            Get
                Return _C_Date1
            End Get
            Set(ByVal value As String)
                _C_Date1 = value
            End Set
        End Property
        ''' <summary>
        ''' 導出日期2
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property C_Date2() As String
            Get
                Return _C_Date2
            End Get
            Set(ByVal value As String)
                _C_Date2 = value
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
    End Class
End Namespace


