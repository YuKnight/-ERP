

Namespace LFERP.Library.Outward

    Public Class OutwardChangeInfo

        Private _AutoID As String
        Private _OC_NO As String
        Private _O_NO As String
        Private _OS_BatchID As String
        Private _PM_M_Code As String
        Private _M_Code As String
        Private _OS_Qty As Double
        Private _OS_NoSendQty As Double
        Private _OC_Qty As Double
        Private _OC_Reason As String
        Private _OC_Action As String
        Private _OC_AddDate As Date
        Private _OC_EditDate As Date
        Private _OC_Remark As String
        Private _OC_Check As Boolean
        Private _OC_CheckAction As String
        Private _OC_CheckDate As Date
        Private _OC_CheckRemark As String

        Private _M_Name As String
        Private _M_Gauge As String
        Private _ActionName As String
        Private _CheckActionName As String


        Sub New()

            _AutoID = Nothing
            _OC_NO = Nothing
            _O_NO = Nothing
            _OS_BatchID = Nothing
            _PM_M_Code = Nothing
            _M_Code = Nothing
            _OS_Qty = 0
            _OS_NoSendQty = 0
            _OC_Qty = 0
            _OC_Reason = Nothing
            _OC_Action = Nothing
            _OC_AddDate = Nothing
            _OC_EditDate = Nothing
            _OC_Remark = Nothing
            _OC_Check = False
            _OC_CheckAction = Nothing
            _OC_CheckDate = Nothing
            _OC_CheckRemark = Nothing

            _M_Name = Nothing
            _M_Gauge = Nothing
            _ActionName = Nothing
            _CheckActionName = Nothing

        End Sub

        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property
        ''' <summary>
        ''' 外發更改單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OC_NO() As String
            Get
                Return _OC_NO
            End Get
            Set(ByVal value As String)
                _OC_NO = value
            End Set
        End Property
        ''' <summary>
        ''' 外發單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property O_NO() As String
            Get
                Return _O_NO
            End Get
            Set(ByVal value As String)
                _O_NO = value
            End Set
        End Property
        ''' <summary>
        ''' 批次
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
        ''' 聯豐編號
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
        ''' 外發數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_Qty() As Double
            Get
                Return _OS_Qty
            End Get
            Set(ByVal value As Double)
                _OS_Qty = value
            End Set
        End Property
        ''' <summary>
        ''' 外發未交數
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OS_NoSendQty() As Double
            Get
                Return _OS_NoSendQty
            End Get
            Set(ByVal value As Double)
                _OS_NoSendQty = value
            End Set
        End Property
        ''' <summary>
        ''' 更改後數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OC_Qty() As Double
            Get
                Return _OC_Qty
            End Get
            Set(ByVal value As Double)
                _OC_Qty = value
            End Set
        End Property
        ''' <summary>
        ''' 更改原因
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OC_Reason() As String
            Get
                Return _OC_Reason
            End Get
            Set(ByVal value As String)
                _OC_Reason = value
            End Set
        End Property
        ''' <summary>
        ''' 操作員工號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OC_Action() As String
            Get
                Return _OC_Action

            End Get
            Set(ByVal value As String)
                _OC_Action = value
            End Set
        End Property
        ''' <summary>
        ''' 添加日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OC_AddDate() As Date
            Get
                Return _OC_AddDate
            End Get
            Set(ByVal value As Date)
                _OC_AddDate = value
            End Set
        End Property
        ''' <summary>
        ''' 修改日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OC_EditDate() As Date
            Get
                Return _OC_EditDate
            End Get
            Set(ByVal value As Date)
                _OC_EditDate = value
            End Set
        End Property
        ''' <summary>
        ''' 更改單備註
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OC_Remark() As String
            Get
                Return _OC_Remark
            End Get
            Set(ByVal value As String)
                _OC_Remark = value
            End Set
        End Property
        ''' <summary>
        ''' 審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OC_Check() As Boolean
            Get
                Return _OC_Check
            End Get
            Set(ByVal value As Boolean)
                _OC_Check = value
            End Set
        End Property
        ''' <summary>
        ''' 審核員工號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OC_CheckAction() As String
            Get
                Return _OC_CheckAction
            End Get
            Set(ByVal value As String)
                _OC_CheckAction = value
            End Set
        End Property
        ''' <summary>
        ''' 審核日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OC_CheckDate() As Date
            Get
                Return _OC_CheckDate
            End Get
            Set(ByVal value As Date)
                _OC_CheckDate = value
            End Set
        End Property
        ''' <summary>
        ''' 審核備註
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OC_CheckRemark() As String
            Get
                Return _OC_CheckRemark
            End Get
            Set(ByVal value As String)
                _OC_CheckRemark = value
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
        ''' 更改單審核員
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
    End Class

End Namespace


