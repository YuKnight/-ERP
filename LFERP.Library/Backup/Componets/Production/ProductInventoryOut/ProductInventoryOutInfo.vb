Namespace LFERP.Library.Production.ProductInventoryOut
    Public Class ProductInventoryOutInfo
#Region "緩存私有變量"
        Private _AutoID As Int32                                     '自動編碼
        Private _PO_NO As String                                      '出庫編號
        Private _Pro_Type As String                                   '工藝類型
        Private _PM_M_Code As String                                  '產品編號
        Private _PM_Type As String                                    '類別
        Private _M_Code As String                                     '物料編碼
        Private _WH_ID As String                                      '倉庫編號
        Private _PO_Qty As Double                                     '數量
        Private _PO_Action As String                                  '操作人
        Private _PO_Date As Date                                      '出庫日期
        Private _PO_Remark As String                                  '備註
        Private _PO_Check As Boolean                                  '審核
        Private _PO_CheckAction As String                             '審核人
        Private _PO_CheckDate As Date                                 '審核日期
        Private _PO_CheckRemark As String                             '審核備註
        Private _PO_EndQty As Double                                 '結餘數
        Private _M_Name As String                                     '名稱
        Private _M_Gauge As String                                    '規格
        Private _M_Unit As String                                     '單位
        Private _PWS_OutName As String                                '倉庫名稱
        Private _PM_JiYu As String                                    '別名
        Private _PWS_ActionName As String                             '操作人名
        Private _PWS_CheckActionName As String                        '審核操作人名

#End Region

#Region "構造函數"
        Sub New()
            _AutoID = 0
            _PO_Qty = 0
            _PO_EndQty = 0

            _PO_NO = Nothing
            _Pro_Type = Nothing
            _PM_M_Code = Nothing
            _PM_Type = Nothing
            _Pro_Type = Nothing
            _M_Code = Nothing
            _PO_Action = Nothing
            _PO_Date = Nothing
            _PO_Remark = Nothing
            _PO_Check = Nothing
            _PO_CheckAction = Nothing
            _PO_CheckRemark = Nothing
            _PO_CheckDate = Nothing
            _PO_Date = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _PWS_OutName = Nothing
            _PM_JiYu = Nothing

            _PO_Check = False

            _PWS_ActionName = Nothing
            _PWS_CheckActionName = Nothing

        End Sub
#End Region

#Region "屬性"
        ''' <summary>
        ''' 自動編碼
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property AutoID() As Int32
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Int32)
                _AutoID = value
            End Set
        End Property
        ''' <summary>
        ''' 出庫編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PO_NO() As String
            Get
                Return _PO_NO
            End Get
            Set(ByVal value As String)
                _PO_NO = value
            End Set
        End Property
        ''' <summary>
        ''' 工藝類型
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
        ''' 倉庫編號
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
        ''' 數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PO_Qty() As Double
            Get
                Return _PO_Qty
            End Get
            Set(ByVal value As Double)
                _PO_Qty = value
            End Set
        End Property
        ''' <summary>
        ''' 操作人
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PO_Action() As String
            Get
                Return _PO_Action
            End Get
            Set(ByVal value As String)
                _PO_Action = value
            End Set
        End Property
        ''' <summary>
        ''' 備註
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PO_Remark() As String
            Get
                Return _PO_Remark
            End Get
            Set(ByVal value As String)
                _PO_Remark = value
            End Set
        End Property
        ''' <summary>
        ''' 審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PO_Check() As Boolean                  '
            Get
                Return _PO_Check
            End Get
            Set(ByVal value As Boolean)
                _PO_Check = value
            End Set
        End Property

        ''' <summary>
        ''' 審核人
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PO_CheckAction() As String
            Get
                Return _PO_CheckAction
            End Get
            Set(ByVal value As String)
                _PO_CheckAction = value
            End Set
        End Property

        ''' <summary>
        ''' 審核日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PO_CheckDate() As Date                '
            Get
                Return _PO_CheckDate
            End Get
            Set(ByVal value As Date)
                _PO_CheckDate = value
            End Set
        End Property

        ''' <summary>
        ''' 審核備註
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PO_CheckRemark() As String
            Get
                Return _PO_CheckRemark
            End Get
            Set(ByVal value As String)
                _PO_CheckRemark = value
            End Set
        End Property

        ''' <summary>
        ''' 結餘數
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PO_EndQty() As Double
            Get
                Return _PO_EndQty
            End Get
            Set(ByVal value As Double)
                _PO_EndQty = value
            End Set
        End Property

        ''' <summary>
        ''' 日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PO_Date() As Date
            Get
                Return _PO_Date
            End Get
            Set(ByVal value As Date)
                _PO_Date = value
            End Set
        End Property
        ''' <summary>
        ''' 名稱
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
        ''' 規格
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
        ''' 倉庫名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PWS_OutName() As String
            Get
                Return _PWS_OutName
            End Get
            Set(ByVal value As String)
                _PWS_OutName = value
            End Set
        End Property

        ''' <summary>
        ''' 別名
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
        ''' 操作人名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PWS_ActionName() As String
            Get
                Return _PWS_ActionName
            End Get
            Set(ByVal value As String)
                _PWS_ActionName = value
            End Set
        End Property
        ''' <summary>
        ''' 審核操作人名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PWS_CheckActionName() As String
            Get
                Return _PWS_CheckActionName
            End Get
            Set(ByVal value As String)
                _PWS_CheckActionName = value
            End Set
        End Property

#End Region



    End Class
End Namespace
