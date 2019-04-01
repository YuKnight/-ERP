Namespace LFERP.Library.Orders
    Public Class OrdersBomInfo
        Private _OS_BatchID As String
        Private _M_Code As String
        Private _OB_PID As String
        Private _OB_Key As String
        Private _OB_Qty As String
        Private _OB_MainQty As String
        Private _OB_Price As String
        Private _OB_Supplier As String
        Private _OB_SupplierNo As String
        Private _OB_Product As String
        Private _OB_ProductNo As String
        Private _OB_ProductRemark As String
        Private _OB_AccountCheck As String
        Private _OB_AccountRemark As String
        Private _OB_Make As String
        Private _OB_MakeRemark As String
        Private _OB_ID As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _PM_LVL As String
        Private _M_SupplierName As String

        Private _M_CodeType As String
        Private _M_CodeMouldNO As String
        Private _OB_MakeDepartment As String
        Private _OB_MModeCusterNO As String
        Private _OS_ProductAction As String

        Private _PM_M_Code As String
        Private _OS_AddDate As String
        Private _OS_EditDate As String
        Private _OS_Check As Boolean

        Private _AutoID As Integer
        Private _M_Weight As String  '@ 2013/4/17　添加
        Private _M_Unit As String       '@ 2013/4/17　添加

        Public Sub New()
            _OS_BatchID = Nothing
            _M_Code = Nothing
            _OB_PID = Nothing
            _OB_Key = Nothing
            _OB_Qty = Nothing
            _OB_MainQty = Nothing
            _OB_Price = Nothing
            _OB_Supplier = Nothing
            _OB_SupplierNo = Nothing
            _OB_Product = Nothing
            _OB_ProductNo = Nothing
            _OB_ProductRemark = Nothing
            _OB_AccountCheck = Nothing
            _OB_AccountRemark = Nothing
            _OB_Make = Nothing
            _OB_MakeRemark = Nothing
            _OB_ID = Nothing

            _M_Name = Nothing
            _M_Gauge = Nothing
            _PM_LVL = Nothing
            _M_SupplierName = Nothing


            _M_CodeType = Nothing
            _M_CodeMouldNO = Nothing
            _OB_MakeDepartment = Nothing
            _OB_MModeCusterNO = Nothing
            _OS_ProductAction = Nothing

            _PM_M_Code = Nothing
            _OS_AddDate = Nothing
            _OS_EditDate = Nothing
            _OS_Check = False

            _AutoID = 0
            _M_Weight = Nothing
            _M_Unit = Nothing
        End Sub


        ''' <summary>
        ''' 生產批次
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
        ''' 物料編號
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
        ''' OB_PID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OB_PID() As String
            Get
                Return _OB_PID
            End Get
            Set(ByVal value As String)
                _OB_PID = value
            End Set
        End Property


        ''' <summary>
        ''' OB_Key
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OB_Key() As String
            Get
                Return _OB_Key
            End Get
            Set(ByVal value As String)
                _OB_Key = value
            End Set
        End Property


        ''' <summary>
        ''' 用量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OB_Qty() As String
            Get
                Return _OB_Qty
            End Get
            Set(ByVal value As String)
                _OB_Qty = value
            End Set
        End Property


        ''' <summary>
        ''' 總用量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OB_MainQty() As String
            Get
                Return _OB_MainQty
            End Get
            Set(ByVal value As String)
                _OB_MainQty = value
            End Set
        End Property


        ''' <summary>
        ''' 單價
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OB_Price() As String
            Get
                Return _OB_Price
            End Get
            Set(ByVal value As String)
                _OB_Price = value
            End Set
        End Property


        ''' <summary>
        ''' 供應商代號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OB_Supplier() As String
            Get
                Return _OB_Supplier
            End Get
            Set(ByVal value As String)
                _OB_Supplier = value
            End Set
        End Property


        ''' <summary>
        ''' 供應商編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OB_SupplierNo() As String
            Get
                Return _OB_SupplierNo
            End Get
            Set(ByVal value As String)
                _OB_SupplierNo = value
            End Set
        End Property


        ''' <summary>
        ''' 採購狀況
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OB_Product() As String
            Get
                Return _OB_Product
            End Get
            Set(ByVal value As String)
                _OB_Product = value
            End Set
        End Property



        ''' <summary>
        ''' 採購單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OB_ProductNo() As String
            Get
                Return _OB_ProductNo
            End Get
            Set(ByVal value As String)
                _OB_ProductNo = value
            End Set
        End Property


        ''' <summary>
        ''' 採購備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OB_ProductRemark() As String
            Get
                Return _OB_ProductRemark
            End Get
            Set(ByVal value As String)
                _OB_ProductRemark = value
            End Set
        End Property



        ''' <summary>
        ''' 會計部審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OB_AccountCheck() As String
            Get
                Return _OB_AccountCheck
            End Get
            Set(ByVal value As String)
                _OB_AccountCheck = value
            End Set
        End Property



        ''' <summary>
        ''' 會計部審核備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OB_AccountRemark() As String
            Get
                Return _OB_AccountRemark
            End Get
            Set(ByVal value As String)
                _OB_AccountRemark = value
            End Set
        End Property

        ''' <summary>
        ''' 再加工
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OB_Make() As String
            Get
                Return _OB_Make
            End Get
            Set(ByVal value As String)
                _OB_Make = value
            End Set
        End Property



        ''' <summary>
        ''' 加工要求
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OB_MakeRemark() As String
            Get
                Return _OB_MakeRemark
            End Get
            Set(ByVal value As String)
                _OB_MakeRemark = value
            End Set
        End Property



        ''' <summary>
        ''' 序號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OB_ID() As String
            Get
                Return _OB_ID
            End Get
            Set(ByVal value As String)
                _OB_ID = value
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
        ''' 序號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_LVL() As String
            Get
                Return _PM_LVL
            End Get
            Set(ByVal value As String)
                _PM_LVL = value
            End Set
        End Property

        ''' <summary>
        ''' 供應商名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_SupplierName() As String
            Get
                Return _M_SupplierName
            End Get
            Set(ByVal value As String)
                _M_SupplierName = value
            End Set
        End Property
        ''' <summary>
        ''' 配件類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_CodeType() As String
            Get
                Return _M_CodeType
            End Get
            Set(ByVal value As String)
                _M_CodeType = value
            End Set
        End Property
        ''' <summary>
        ''' 模具編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_CodeMouldNO() As String
            Get
                Return _M_CodeMouldNO
            End Get
            Set(ByVal value As String)
                _M_CodeMouldNO = value
            End Set
        End Property
        ''' <summary>
        ''' 加工部門
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OB_MakeDepartment() As String
            Get
                Return _OB_MakeDepartment
            End Get
            Set(ByVal value As String)
                _OB_MakeDepartment = value
            End Set
        End Property
        ''' <summary>
        ''' 配件客戶編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property OB_MModeCusterNO() As String
            Get
                Return _OB_MModeCusterNO
            End Get
            Set(ByVal value As String)
                _OB_MModeCusterNO = value
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
        Public Property OS_ProductAction() As String

            Get
                Return _OS_ProductAction
            End Get
            Set(ByVal value As String)
                _OS_ProductAction = value
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
        Public Property OS_AddDate() As String
            Get
                Return _OS_AddDate
            End Get
            Set(ByVal value As String)
                _OS_AddDate = value
            End Set
        End Property
        Public Property OS_EditDate() As String
            Get
                Return _OS_EditDate
            End Get
            Set(ByVal value As String)
                _OS_EditDate = value
            End Set
        End Property
        Public Property OS_Check() As Boolean
            Get
                Return _OS_Check
            End Get
            Set(ByVal value As Boolean)
                _OS_Check = value
            End Set
        End Property

        Public Property M_Weight() As String
            Get
                Return _M_Weight
            End Get
            Set(ByVal value As String)
                _M_Weight = value
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
    End Class
End Namespace
