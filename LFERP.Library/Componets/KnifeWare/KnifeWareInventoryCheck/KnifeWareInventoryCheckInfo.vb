Namespace LFERP.Library.KnifeWareInventoryCheck

    Public Class KnifeWareInventoryCheckInfo


        Private _WIC_NO As String
        Private _M_Code As String
        Private _DepotNO As String
        Private _WIC_NewQty As Decimal
        Private _WIC_OldQty As Decimal
        Private _WIC_Difference As Decimal
        Private _WIC_Process As String
        Private _WIC_Type As String
        'Private _WIC_Date As Date

        Private _WIC_Date As String                 '2014-07-29  Mark
        Private _WIC_Remark As String
        Private _WIC_Action As String

        Private _WIC_Check As Boolean
        Private _WIC_CheckAction As String
        Private _WIC_CheckType As String
        Private _WIC_CheckRemark As String

        Private _ActionName As String
        Private _CheckActionName As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _WH_Name As String
        Private _WH_Pname As String

        Private _InputType As String
        Private _Remark As String
        Private _WIC_KnifeKType As String
        Private _WIC_PDType As String

        Private _M_Unit As String


        Public Sub New()
            _WIC_NO = Nothing
            _M_Code = Nothing
            _DepotNO = Nothing
            _WIC_NewQty = 0
            _WIC_OldQty = 0
            _WIC_Difference = 0
            _WIC_Process = Nothing
            _WIC_Type = Nothing
            _WIC_Date = Nothing
            _WIC_Remark = Nothing
            _WIC_Action = Nothing

            _WIC_Check = Nothing
            _WIC_CheckAction = Nothing
            _WIC_CheckType = Nothing
            _WIC_CheckRemark = Nothing

            _ActionName = Nothing
            _CheckActionName = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _WH_Name = Nothing
            _WH_Pname = Nothing

            _InputType = Nothing
            _Remark = Nothing
            _WIC_KnifeKType = Nothing
            _WIC_PDType = Nothing
            _M_Unit = Nothing

        End Sub

        Public Property M_Unit() As String
            Get
                Return _M_Unit
            End Get
            Set(ByVal value As String)
                _M_Unit = value
            End Set
        End Property


        Public Property WIC_PDType() As String
            Get
                Return _WIC_PDType
            End Get
            Set(ByVal value As String)
                _WIC_PDType = value
            End Set
        End Property


        Public Property WIC_KnifeKType() As String
            Get
                Return _WIC_KnifeKType
            End Get
            Set(ByVal value As String)
                _WIC_KnifeKType = value
            End Set
        End Property


        Public Property InputType() As String
            Get
                Return _InputType
            End Get
            Set(ByVal value As String)
                _InputType = value
            End Set
        End Property

        Public Property Remark() As String
            Get
                Return _Remark
            End Get
            Set(ByVal value As String)
                _Remark = value
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

        Public Property WH_Pname() As String
            Get
                Return _WH_Pname
            End Get
            Set(ByVal value As String)
                _WH_Pname = value
            End Set
        End Property
        ''' <summary>
        ''' 盤點單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property WIC_NO() As String
            Get
                Return _WIC_NO
            End Get
            Set(ByVal value As String)
                _WIC_NO = value
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
        ''' 倉庫代號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DepotNO() As String
            Get
                Return _DepotNO
            End Get
            Set(ByVal value As String)
                _DepotNO = value
            End Set
        End Property

        ''' <summary>
        ''' 實盤數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property WIC_NewQty() As Decimal
            Get
                Return _WIC_NewQty
            End Get
            Set(ByVal value As Decimal)
                _WIC_NewQty = value
            End Set
        End Property

        ''' <summary>
        ''' 庫存數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property WIC_OldQty() As Decimal
            Get
                Return _WIC_OldQty
            End Get
            Set(ByVal value As Decimal)
                _WIC_OldQty = value
            End Set
        End Property

        ''' <summary>
        ''' 差異數
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property WIC_Difference() As Decimal
            Get
                Return _WIC_Difference
            End Get
            Set(ByVal value As Decimal)
                _WIC_Difference = value
            End Set
        End Property

        ''' <summary>
        ''' 是否處理
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property WIC_Process() As String
            Get
                Return _WIC_Process
            End Get
            Set(ByVal value As String)
                _WIC_Process = value
            End Set
        End Property

        ''' <summary>
        ''' 類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property WIC_Type() As String
            Get
                Return _WIC_Type
            End Get
            Set(ByVal value As String)
                _WIC_Type = value
            End Set
        End Property
        '''' <summary>
        '''' 盤點日期
        '''' </summary>
        '''' <value></value>
        '''' <returns></returns>
        '''' <remarks></remarks>
        'Public Property WIC_Date() As Date
        '    Get
        '        Return _WIC_Date
        '    End Get
        '    Set(ByVal value As Date)
        '        _WIC_Date = value
        '    End Set
        'End Property

        ''' <summary>
        ''' 盤點日期
        ''' 2014-07-29
        ''' Mark
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property WIC_Date() As String
            Get
                Return _WIC_Date
            End Get
            Set(ByVal value As String)
                _WIC_Date = value
            End Set
        End Property


        ''' <summary>
        ''' 主表備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property WIC_Remark() As String
            Get
                Return _WIC_Remark
            End Get
            Set(ByVal value As String)
                _WIC_Remark = value
            End Set
        End Property


        ''' <summary>
        ''' 盤點員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property WIC_Action() As String
            Get
                Return _WIC_Action
            End Get
            Set(ByVal value As String)
                _WIC_Action = value
            End Set
        End Property

        ''' <summary>
        ''' 審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property WIC_Check() As Boolean
            Get
                Return _WIC_Check
            End Get
            Set(ByVal value As Boolean)
                _WIC_Check = value
            End Set
        End Property


        ''' <summary>
        ''' 審核員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property WIC_CheckAction() As String
            Get
                Return _WIC_CheckAction
            End Get
            Set(ByVal value As String)
                _WIC_CheckAction = value
            End Set
        End Property

        ''' <summary>
        ''' 審核類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property WIC_CheckType() As String
            Get
                Return _WIC_CheckType
            End Get
            Set(ByVal value As String)
                _WIC_CheckType = value
            End Set
        End Property

        ''' <summary>
        ''' 審核備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property WIC_CheckRemark() As String
            Get
                Return _WIC_CheckRemark
            End Get
            Set(ByVal value As String)
                _WIC_CheckRemark = value
            End Set
        End Property
        ''' <summary>
        ''' 盤點員
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
    End Class
End Namespace

