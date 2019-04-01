Namespace LFERP.Library.Outward.OutwardAcceptance

    Public Class OutwardAcceptanceInfo

        Private _A_NO As String
        Private _A_AcceptanceNO As String
        Private _WH_ID As String
        Private _O_NO As String
        Private _A_SendNO As String
        Private _A_SendType As String
        Private _M_Code As String
        Private _OS_BatchID As String
        Private _PM_M_Code As String
        Private _A_Qty As Double
        Private _A_SendDate As Date
        Private _A_Ver As Integer
        Private _S_Supplier As String
        Private _A_Remark As String
        Private _A_Action As String
        Private _A_Detail As String
        Private _A_UpdateDate As String
        Private _A_QtyType As String
        Private _OS_ItemType As String    '加工類型  代號

        '--------------------------------------------------- 基本信息
        Private _A_Check As Boolean
        Private _A_CheckAction As String
        Private _A_CheckDate As Date
        Private _A_CheckRemark As String
        '--------------------------------------------------審核
        Private _A_AccCheck As Boolean
        Private _A_AccCheckAction As String
        Private _A_AccCheckRemark As String
        Private _A_AccCheckDate As Date
        Private _A_AccCheckType As String

        '-------------------------------------復核
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _SupplierName As String
        Private _WH_Name As String
        Private _ItemType As String   '加工類型  名稱


        Sub New()
            _A_NO = Nothing
            _A_AcceptanceNO = Nothing
            _WH_ID = Nothing
            _O_NO = Nothing
            _A_SendNO = Nothing
            _A_SendType = Nothing
            _M_Code = Nothing
            _OS_BatchID = Nothing
            _PM_M_Code = Nothing
            _A_Qty = 0
            _A_SendDate = Nothing
            _A_Ver = 0
            _S_Supplier = Nothing
            _A_Action = Nothing
            _A_Remark = Nothing
            _A_Detail = Nothing
            _A_UpdateDate = Nothing
            _A_QtyType = Nothing
            _OS_ItemType = Nothing
            '---------------------------------------------------
            _A_Check = False
            _A_CheckDate = Nothing
            _A_CheckAction = Nothing
            _A_CheckRemark = Nothing
            '---------------------------------------------------
            _A_AccCheck = False
            _A_AccCheckDate = Nothing
            _A_AccCheckAction = Nothing
            _A_AccCheckRemark = Nothing
            _A_AccCheckType = Nothing

            '---------------------------------------------------
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _WH_Name = Nothing
            _ItemType = Nothing
            _SupplierName = Nothing

        End Sub
        ''' <summary>
        ''' 驗收流水號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_NO() As String
            Get
                Return _A_NO
            End Get
            Set(ByVal value As String)
                _A_NO = value
            End Set
        End Property
        ''' <summary>
        ''' 驗收單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_AcceptanceNO() As String
            Get
                Return _A_AcceptanceNO
            End Get
            Set(ByVal value As String)
                _A_AcceptanceNO = value
            End Set
        End Property
        ''' <summary>
        ''' 倉庫代號
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
        ''' 送貨單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_SendNO() As String
            Get
                Return _A_SendNO
            End Get
            Set(ByVal value As String)
                _A_SendNO = value
            End Set
        End Property
        ''' <summary>
        ''' 送貨類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_SendType() As String
            Get
                Return _A_SendType
            End Get
            Set(ByVal value As String)
                _A_SendType = value
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
        '''  批次編號
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
        ''' 送貨數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_Qty() As Double
            Get
                Return _A_Qty
            End Get
            Set(ByVal value As Double)
                _A_Qty = value
            End Set
        End Property
        ''' <summary>
        ''' 送貨日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_SendDate() As Date
            Get
                Return _A_SendDate
            End Get
            Set(ByVal value As Date)
                _A_SendDate = value
            End Set
        End Property
        ''' <summary>
        ''' 版本號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_Ver() As Integer
            Get
                Return _A_Ver
            End Get
            Set(ByVal value As Integer)
                _A_Ver = value
            End Set
        End Property
        ''' <summary>
        ''' 供應商代號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property S_Supplier() As String
            Get
                Return _S_Supplier
            End Get
            Set(ByVal value As String)
                _S_Supplier = value
            End Set
        End Property
        ''' <summary>
        ''' 操作員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_Action() As String
            Get
                Return _A_Action
            End Get
            Set(ByVal value As String)
                _A_Action = value
            End Set
        End Property
        ''' <summary>
        ''' 備註
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_Remark() As String
            Get
                Return _A_Remark
            End Get
            Set(ByVal value As String)
                _A_Remark = value
            End Set
        End Property
        ''' <summary>
        ''' 狀態
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_Detail() As String
            Get
                Return _A_Detail
            End Get
            Set(ByVal value As String)
                _A_Detail = value
            End Set
        End Property
        ''' <summary>
        ''' 修改日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_UpdateDate() As Date
            Get
                Return _A_UpdateDate
            End Get
            Set(ByVal value As Date)
                _A_UpdateDate = value
            End Set
        End Property
        ''' <summary>
        ''' 送貨數量類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_QtyType() As String
            Get
                Return _A_QtyType
            End Get
            Set(ByVal value As String)
                _A_QtyType = value
            End Set
        End Property

        Public Property A_Check() As Boolean
            Get
                Return _A_Check
            End Get
            Set(ByVal value As Boolean)
                _A_Check = value
            End Set
        End Property
        Public Property A_CheckDate() As Date
            Get
                Return _A_CheckDate
            End Get
            Set(ByVal value As Date)
                _A_CheckDate = value
            End Set
        End Property
        Public Property A_CheckAction() As String
            Get
                Return _A_CheckAction
            End Get
            Set(ByVal value As String)
                _A_CheckAction = value
            End Set
        End Property
        Public Property A_CheckRemark() As String
            Get
                Return _A_CheckRemark
            End Get
            Set(ByVal value As String)
                _A_CheckRemark = value
            End Set
        End Property
        Public Property A_AccCheck() As Boolean
            Get
                Return _A_AccCheck
            End Get
            Set(ByVal value As Boolean)
                _A_AccCheck = value
            End Set
        End Property
        Public Property A_AccCheckAction() As String
            Get
                Return _A_AccCheckAction
            End Get
            Set(ByVal value As String)
                _A_AccCheckAction = value
            End Set
        End Property
        Public Property A_AccCheckDate() As Date
            Get
                Return _A_AccCheckDate
            End Get
            Set(ByVal value As Date)
                _A_AccCheckDate = value
            End Set
        End Property
        Public Property A_AccCheckRemark() As String
            Get
                Return _A_AccCheckRemark
            End Get
            Set(ByVal value As String)
                _A_AccCheckRemark = value
            End Set
        End Property
        Public Property A_AccCheckType() As String
            Get
                Return _A_AccCheckType
            End Get
            Set(ByVal value As String)
                _A_AccCheckType = value
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
        Public Property SupplierName() As String
            Get
                Return _SupplierName
            End Get
            Set(ByVal value As String)
                _SupplierName = value
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
        Public Property OS_ItemType() As String
            Get
                Return _OS_ItemType
            End Get
            Set(ByVal value As String)
                _OS_ItemType = value
            End Set
        End Property
        Public Property ItemType() As String
            Get
                Return _ItemType
            End Get
            Set(ByVal value As String)
                _ItemType = value
            End Set
        End Property

    End Class


End Namespace
