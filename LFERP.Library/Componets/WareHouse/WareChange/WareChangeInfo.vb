
Namespace LFERP.Library.WareHouse.WareChange

    Public Class WareChangeInfo


        Private _IndexNo As String
        Private _C_ChangeNO As String
        Private _M_Code As String
        Private _WH_ID As String
        Private _WI_Qty As Double
        Private _C_Qty As Double
        Private _C_Date As Date
        Private _C_Action As String
        Private _C_Remark As String
        Private _C_Check As Boolean
        Private _C_CheckAction As String
        Private _C_CheckRemark As String
        Private _C_CheckDate As Date
        Private _C_ReCheck As Boolean
        Private _C_ReCheckDate As Date
        Private _C_ReCheckAction As String
        Private _C_ReCheckRemark As String


        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _ActionName As String
        Private _CheckActionName As String
        Private _ReCheckActionName As String
        Private _WH_Name As String
        Private _WH_PName As String

        Sub New()

            _IndexNo = 0
            _C_ChangeNO = Nothing
            _M_Code = Nothing
            _WH_ID = Nothing
            _WI_Qty = 0
            _C_Qty = 0
            _C_Date = Nothing
            _C_Action = Nothing
            _C_Remark = Nothing
            _C_Check = False
            _C_CheckAction = Nothing
            _C_CheckRemark = Nothing
            _C_CheckDate = Nothing

            _C_ReCheck = False
            _C_ReCheckDate = Nothing
            _C_ReCheckAction = Nothing
            _C_ReCheckRemark = Nothing


            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _ActionName = Nothing
            _CheckActionName = Nothing
            _ReCheckActionName = Nothing

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


        Public Property WH_ID() As String
            Get
                Return _WH_ID
            End Get
            Set(ByVal value As String)
                _WH_ID = value
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
        ''' 原倉庫數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property WI_Qty() As Double
            Get
                Return _WI_Qty
            End Get
            Set(ByVal value As Double)
                _WI_Qty = value
            End Set
        End Property
        ''' <summary>
        ''' 現更改后倉庫數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property C_Qty() As Double
            Get
                Return _C_Qty
            End Get
            Set(ByVal value As Double)
                _C_Qty = value
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

        Public Property C_CheckDate() As Date
            Get
                Return _C_CheckDate
            End Get
            Set(ByVal value As Date)
                _C_CheckDate = value
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

        Public Property C_ReCheck() As Boolean
            Get
                Return _C_ReCheck
            End Get
            Set(ByVal value As Boolean)
                _C_ReCheck = value
            End Set
        End Property
        Public Property C_ReCheckDate() As Date
            Get
                Return _C_ReCheckDate
            End Get
            Set(ByVal value As Date)
                _C_ReCheckDate = value
            End Set
        End Property
        Public Property C_ReCheckAction() As String
            Get
                Return _C_ReCheckAction
            End Get
            Set(ByVal value As String)
                _C_ReCheckAction = value
            End Set
        End Property
        Public Property C_ReCheckRemark() As String
            Get
                Return _C_ReCheckRemark
            End Get
            Set(ByVal value As String)
                _C_ReCheckRemark = value
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
        Public Property IndexNo() As String
            Get
                Return _IndexNo
            End Get
            Set(ByVal value As String)
                _IndexNo = value
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
        Public Property ReCheckActionName() As String
            Get
                Return _ReCheckActionName
            End Get
            Set(ByVal value As String)
                _ReCheckActionName = value
            End Set
        End Property
    End Class




End Namespace


