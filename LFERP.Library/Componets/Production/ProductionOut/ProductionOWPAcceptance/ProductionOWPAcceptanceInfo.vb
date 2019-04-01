Namespace LFERP.Library.ProductionOWPAcceptance


    Public Class ProductionOWPAcceptanceInfo

        Private _A_AcceptanceNO As String ' *  nvarchar(50)              /驗收編號
        Private _A_NO As String '              *  nvarchar(50)              /驗收流水號
        Private _O_NO As String '              *  nvarchar(50)              /外發單號
        Private _ASend_NO As String '          *  nvarchar(50)              /送貨單號
        Private _DPT_ID As String '            *  nvarchar(50)              /外發部門ID 此處固定為外發部
        Private _PM_M_Code As String '         *  nvarchar(50)              /產品名稱
        Private _PM_Type As String '           *  nvarchar(50)              /類型
        Private _PS_NO As String '             *  nvarchar(50)              /外發工序
        Private _S_Supplier As String '        *  nvarchar(5)               /供貨商編號
        Private _A_OK_Qty As Double '           *  real                  /驗收ok數量
        Private _A_QQ_Qty As Double '         *  real                  /驗收前Q數量
        Private _A_TC_Qty As Double '         *  real                  /驗收退次數量'
        Private _A_QT_Qty As Double '         *  real                  /驗收其它數量
        Private _A_Ver As Integer '          *  real                  /記錄操作次數
        Private _A_Detail As String '          *  nvarchar(50)              /操作類型(暫收/驗收)
        Private _A_Action As String '          *  nvarchar(50)              /暫收人編號
        Private _A_SendDate As String '        *  datetime                  /記錄添加時間
        Private _A_Remark As String '          *  nvarchar(max)             /操作備注
        Private _A_Check As Boolean '           *  bit                 /審核否
        Private _A_CheckAction As String '     *  nvarchar(50)        /審核人ID
        Private _A_CheckDate As String '      *  datetime            /審核時間
        Private _A_CheckRemark As String '     *  nvarchar(max)       /審核備注
        Private _A_AccCheck As Boolean '        *  bit                      /復審核否
        Private _A_AccCheckAction As String ' *  nvarchar(50)             /復審核人ID
        Private _A_AccCheckDate As String '    *  datetime                 /復審核時間
        Private _A_ACCCheckRemark As String '  *  nvarchar(max)            /復審核備注
        Private _A_AccCheckType As String '    *  nvarchar(30)             /復審核備注類型(無效,確認無誤,待復)
        Private _A_UpdateDate As String '      *  datetime                 /修改日期
        Private _PS_NO_Next As String '收料工序，即下一工序

        ''其它表中的數據
        Private _A_ActionName As String
        Private _A_CheckActionName As String
        Private _A_AccCheckActionName As String
        Private _A_PS_Name As String
        Private _A_SupplierName As String
        Private _A_PS_Name_Next As String

        Private _OPAutoID As String ''外發單中的自動編號ID
        Private _PO_NoSendQty As Int32  ''外發單中未交數

        ''加讀取下工序
        Private _Pro_NO As String
        Private _PS_Num As String    ''工序序號
        Private _PS_Enable As String '是否啟用用

        Private _A_OW_Do As String '加工要求
        Private _PM_JiYu As String



        Sub New()

            _PM_JiYu = Nothing
            _A_AcceptanceNO = Nothing
            _A_NO = Nothing '              *  nvarchar(50)              /驗收編號
            _O_NO = Nothing '              *  nvarchar(50)              /外發單號
            _ASend_NO = Nothing '          *  nvarchar(50)              /送貨單號
            _DPT_ID = Nothing '            *  nvarchar(50)              /外發部門ID 此處固定為外發部
            _PM_M_Code = Nothing '         *  nvarchar(50)              /產品名稱
            _PM_Type = Nothing '           *  nvarchar(50)              /類型
            _PS_NO = Nothing '             *  nvarchar(50)              /外發工序
            _S_Supplier = Nothing '        *  nvarchar(5)               /供貨商編號
            _A_OK_Qty = 0 '           *  real                  /驗收ok數量
            _A_QQ_Qty = 0 '         *  real                  /驗收前Q數量
            _A_TC_Qty = 0 '         *  real                  /驗收退次數量'
            _A_QT_Qty = 0 '         *  real                  /驗收其它數量
            _A_Ver = 0 '          *  real                  /記錄操作次數
            _A_Detail = Nothing '          *  nvarchar(50)              /操作類型(暫收/驗收)
            _A_Action = Nothing '          *  nvarchar(50)              /暫收人編號
            _A_SendDate = Nothing '        *  datetime                  /記錄添加時間
            _A_Remark = Nothing '          *  nvarchar(max)             /操作備注
            _A_Check = False '           *  bit                 /審核否
            _A_CheckAction = Nothing '     *  nvarchar(50)        /審核人ID
            _A_CheckDate = Nothing '      *  datetime            /審核時間
            _A_CheckRemark = Nothing '     *  nvarchar(max)       /審核備注
            _A_AccCheck = False  '        *  bit                      /復審核否
            _A_AccCheckAction = Nothing ' *  nvarchar(50)             /復審核人ID
            _A_AccCheckDate = Nothing '    *  datetime                 /復審核時間
            _A_ACCCheckRemark = Nothing '  *  nvarchar(max)            /復審核備注
            _A_AccCheckType = Nothing '    *  nvarchar(30)             /復審核備注類型(無效,確認無誤,待復)
            _A_UpdateDate = Nothing '      *  datetime                 /修改日期
            _PS_NO_Next = Nothing

            ''其它表中的數據
            _A_ActionName = Nothing
            _A_CheckActionName = Nothing
            _A_AccCheckActionName = Nothing
            _A_PS_Name = Nothing
            _A_SupplierName = Nothing
            _A_PS_Name_Next = Nothing

            _OPAutoID = Nothing ''外發單中的自動編號ID
            _PO_NoSendQty = 0

            _A_OW_Do = Nothing '加工要求
        End Sub

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
        ''' 加工要求
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_OW_Do() As String
            Get
                Return _A_OW_Do
            End Get
            Set(ByVal value As String)
                _A_OW_Do = value
            End Set
        End Property

        ''' <summary>
        ''' 驗收編號
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
        Public Property ASend_NO() As String
            Get
                Return _ASend_NO
            End Get
            Set(ByVal value As String)
                _ASend_NO = value
            End Set
        End Property
        ''' <summary>
        ''' 發部門ID 此處固定為外發部
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DPT_ID() As String
            Get
                Return _DPT_ID
            End Get
            Set(ByVal value As String)
                _DPT_ID = value
            End Set
        End Property
        ''' <summary>
        ''' 產品名稱
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
        ''' 類型
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
        ''' 外發工序
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
        ''' 供貨商編號
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
        ''' 驗收ok數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_OK_Qty() As Double
            Get
                Return _A_OK_Qty
            End Get
            Set(ByVal value As Double)
                _A_OK_Qty = value
            End Set
        End Property
        ''' <summary>
        ''' /驗收前Q數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_QQ_Qty() As Double
            Get
                Return _A_QQ_Qty
            End Get
            Set(ByVal value As Double)
                _A_QQ_Qty = value
            End Set
        End Property
        ''' <summary>
        ''' 驗收退次數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_TC_Qty() As Double
            Get
                Return _A_TC_Qty
            End Get
            Set(ByVal value As Double)
                _A_TC_Qty = value
            End Set
        End Property
        ''' <summary>
        ''' 驗收其它數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_QT_Qty() As Double
            Get
                Return _A_QT_Qty
            End Get
            Set(ByVal value As Double)
                _A_QT_Qty = value
            End Set
        End Property
        ''' <summary>
        ''' 記錄操作次數
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_Ver() As Double
            Get
                Return _A_Ver
            End Get
            Set(ByVal value As Double)
                _A_Ver = value
            End Set
        End Property
        ''' <summary>
        ''' 操作類型(暫收/驗收)
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
        ''' 暫收人編號
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
        ''' 記錄添加時間
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_SendDate() As String
            Get
                Return _A_SendDate
            End Get
            Set(ByVal value As String)
                _A_SendDate = value
            End Set
        End Property
        ''' <summary>
        ''' 操作備注
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
        ''' 審核否 (驗收)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_Check() As Boolean
            Get
                Return _A_Check
            End Get
            Set(ByVal value As Boolean)
                _A_Check = value
            End Set
        End Property
        ''' <summary>
        ''' 審核人ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_CheckAction() As String
            Get
                Return _A_CheckAction
            End Get
            Set(ByVal value As String)
                _A_CheckAction = value
            End Set
        End Property
        ''' <summary>
        ''' 審核時間
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_CheckDate() As String
            Get
                Return _A_CheckDate
            End Get
            Set(ByVal value As String)
                _A_CheckDate = value
            End Set
        End Property
        ''' <summary>
        ''' 審核備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_CheckRemark() As String
            Get
                Return _A_CheckRemark
            End Get
            Set(ByVal value As String)
                _A_CheckRemark = value
            End Set
        End Property
        ''' <summary>
        ''' 復審核否
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_AccCheck() As Boolean
            Get
                Return _A_AccCheck
            End Get
            Set(ByVal value As Boolean)
                _A_AccCheck = value
            End Set
        End Property
        ''' <summary>
        ''' 復審核人ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_AccCheckAction() As String
            Get
                Return _A_AccCheckAction
            End Get
            Set(ByVal value As String)
                _A_AccCheckAction = value
            End Set
        End Property
        ''' <summary>
        ''' 復審核時間
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_AccCheckDate() As String
            Get
                Return _A_AccCheckDate
            End Get
            Set(ByVal value As String)
                _A_AccCheckDate = value
            End Set
        End Property
        ''' <summary>
        ''' 復審核備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_ACCCheckRemark() As String
            Get
                Return _A_ACCCheckRemark
            End Get
            Set(ByVal value As String)
                _A_ACCCheckRemark = value
            End Set
        End Property

        ''' <summary>
        ''' 復審核備注類型(無效,確認無誤,待復)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_AccCheckType() As String
            Get
                Return _A_AccCheckType
            End Get
            Set(ByVal value As String)
                _A_AccCheckType = value
            End Set
        End Property
        ''' <summary>
        ''' 修改日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_UpdateDate() As String
            Get
                Return _A_UpdateDate
            End Get
            Set(ByVal value As String)
                _A_UpdateDate = value
            End Set
        End Property


        ''其它表中的數據
        '_A_ActionName = Nothing
        '_A_CheckActionName = Nothing
        '_A_AccCheckActionName = Nothing
        '_A_PS_Name = Nothing
        '_A_S_SupplierName = Nothing
        Public Property A_ActionName() As String
            Get
                Return _A_ActionName
            End Get
            Set(ByVal value As String)
                _A_ActionName = value
            End Set
        End Property

        Public Property A_CheckActionName() As String
            Get
                Return _A_CheckActionName
            End Get
            Set(ByVal value As String)
                _A_CheckActionName = value
            End Set
        End Property

        Public Property A_AccCheckActionName() As String
            Get
                Return _A_AccCheckActionName
            End Get
            Set(ByVal value As String)
                _A_AccCheckActionName = value
            End Set
        End Property

        Public Property A_PS_Name() As String
            Get
                Return _A_PS_Name
            End Get
            Set(ByVal value As String)
                _A_PS_Name = value
            End Set
        End Property

        Public Property A_SupplierName() As String
            Get
                Return _A_SupplierName
            End Get
            Set(ByVal value As String)
                _A_SupplierName = value
            End Set
        End Property
        ''' <summary>
        ''' 外發單中編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OPAutoID() As String
            Get
                Return _OPAutoID
            End Get
            Set(ByVal value As String)
                _OPAutoID = value
            End Set
        End Property '


        ''' <summary>
        ''' 外發單中未交數
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PO_NoSendQty() As Int32
            Get
                Return _PO_NoSendQty
            End Get
            Set(ByVal value As Int32)
                _PO_NoSendQty = value
            End Set
        End Property '


        ''' <summary>
        ''' 工序編號
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
        End Property '
        ''' <summary>
        ''' '加讀取下工序
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
        ''' 是否起用
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_Enable() As String
            Get
                Return _PS_Enable
            End Get
            Set(ByVal value As String)
                _PS_Enable = value
            End Set
        End Property


        ''' <summary>
        ''' 驗收時的下一工序名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A_PS_Name_Next() As String
            Get
                Return _A_PS_Name_Next
            End Get
            Set(ByVal value As String)
                _A_PS_Name_Next = value
            End Set
        End Property

        ''' <summary>
        ''' 下一工序編號 下一工序
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_NO_Next() As String
            Get
                Return _PS_NO_Next
            End Get
            Set(ByVal value As String)
                _PS_NO_Next = value
            End Set
        End Property
    End Class
End Namespace