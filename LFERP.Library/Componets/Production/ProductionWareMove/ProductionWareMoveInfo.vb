

Namespace LFERP.Library.ProductionWareMove


    Public Class ProductionWareMoveInfo

        Private _AutoID As String
        Private _PWM_NO As String
        Private _PH_OutID As String
        Private _PH_InID As String
        Private _PWM_Type As String
        Private _PM_M_Code As String
        Private _M_Code As String
        Private _PWM_Qty As Integer
        Private _PWM_AddDate As Date
        Private _PWM_ModifyDate As Date
        Private _PWM_ModifyUserID As String
        Private _PWM_Property As String
        Private _PWM_Remark As String
        Private _PWM_OutCheck As Boolean
        Private _PWM_InCheck As Boolean
        Private _PWM_InAction As String
        Private _PWM_InDate As Date
        Private _PWM_OutAction As String
        Private _PWM_Check As Boolean
        Private _PWM_CheckAction As String
        Private _PWM_CheckDate As Date
        Private _PWM_CheckRemark As String

        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _InActionName As String
        Private _OutActionName As String
        Private _CheckActionName As String
        Private _PH_InName As String
        Private _PH_OutName As String


        Sub New()
            _AutoID = Nothing
            _PWM_NO = Nothing
            _PH_OutID = Nothing
            _PH_InID = Nothing
            _PWM_Type = Nothing
            _PM_M_Code = Nothing
            _M_Code = Nothing
            _PWM_Qty = 0
            _PWM_AddDate = Nothing
            _PWM_ModifyDate = Nothing
            _PWM_ModifyUserID = Nothing
            _PWM_Property = Nothing
            _PWM_Remark = Nothing
            _PWM_InCheck = False
            _PWM_InDate = Nothing
            _PWM_OutCheck = False
            _PWM_InAction = Nothing
            _PWM_OutAction = Nothing
            _PWM_Check = False
            _PWM_CheckAction = Nothing
            _PWM_CheckDate = Nothing
            _PWM_CheckRemark = Nothing

            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _InActionName = Nothing
            _OutActionName = Nothing
            _CheckActionName = Nothing
            _PH_OutName = Nothing
            _PH_InName = Nothing

        End Sub

        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property
        Public Property PWM_NO() As String
            Get
                Return _PWM_NO
            End Get
            Set(ByVal value As String)
                _PWM_NO = value
            End Set
        End Property
        Public Property PH_OutID() As String
            Get
                Return _PH_OutID
            End Get
            Set(ByVal value As String)
                _PH_OutID = value
            End Set
        End Property
        Public Property PH_InID() As String
            Get
                Return _PH_InID
            End Get
            Set(ByVal value As String)
                _PH_InID = value
            End Set
        End Property
        Public Property PWM_Type() As String
            Get
                Return _PWM_Type
            End Get
            Set(ByVal value As String)
                _PWM_Type = value
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
        Public Property M_Code() As String
            Get
                Return _M_Code
            End Get
            Set(ByVal value As String)
                _M_Code = value
            End Set
        End Property
        Public Property PWM_Qty() As Integer
            Get
                Return _PWM_Qty
            End Get
            Set(ByVal value As Integer)
                _PWM_Qty = value
            End Set
        End Property
        Public Property PWM_AddDate() As Date
            Get
                Return _PWM_AddDate
            End Get
            Set(ByVal value As Date)
                _PWM_AddDate = value
            End Set
        End Property
        Public Property PWM_ModifyDate() As Date
            Get
                Return _PWM_ModifyDate
            End Get
            Set(ByVal value As Date)
                _PWM_ModifyDate = value
            End Set
        End Property
        Public Property PWM_ModifyUserID() As String
            Get
                Return _PWM_ModifyUserID
            End Get
            Set(ByVal value As String)
                _PWM_ModifyUserID = value
            End Set
        End Property
        Public Property PWM_Property() As String
            Get
                Return _PWM_Property
            End Get
            Set(ByVal value As String)
                _PWM_Property = value
            End Set
        End Property
        Public Property PWM_Remark() As String
            Get
                Return _PWM_Remark
            End Get
            Set(ByVal value As String)
                _PWM_Remark = value
            End Set
        End Property
        Public Property PWM_InCheck() As Boolean
            Get
                Return _PWM_InCheck
            End Get
            Set(ByVal value As Boolean)
                _PWM_InCheck = value
            End Set
        End Property
        Public Property PWM_OutCheck() As Boolean
            Get
                Return _PWM_OutCheck
            End Get
            Set(ByVal value As Boolean)
                _PWM_OutCheck = value
            End Set
        End Property
        Public Property PWM_InAction() As String
            Get
                Return _PWM_InAction
            End Get
            Set(ByVal value As String)
                _PWM_InAction = value
            End Set
        End Property
        Public Property PWM_InDate() As Date
            Get
                Return _PWM_InDate
            End Get
            Set(ByVal value As Date)
                _PWM_InDate = value
            End Set
        End Property
        Public Property PWM_OutAction() As String
            Get
                Return _PWM_OutAction
            End Get
            Set(ByVal value As String)
                _PWM_OutAction = value
            End Set
        End Property
        Public Property PWM_Check() As Boolean
            Get
                Return _PWM_Check
            End Get
            Set(ByVal value As Boolean)
                _PWM_Check = value
            End Set
        End Property
        Public Property PWM_CheckAction() As String
            Get
                Return _PWM_CheckAction
            End Get
            Set(ByVal value As String)
                _PWM_CheckAction = value
            End Set
        End Property
        Public Property PWM_CheckDate() As Date
            Get
                Return _PWM_CheckDate
            End Get
            Set(ByVal value As Date)
                _PWM_CheckDate = value
            End Set
        End Property
        Public Property PWM_CheckRemark() As String
            Get
                Return _PWM_CheckRemark
            End Get
            Set(ByVal value As String)
                _PWM_CheckRemark = value
            End Set
        End Property

        '-------------------------------------------------------

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
        Public Property InActionName() As String
            Get
                Return _InActionName
            End Get
            Set(ByVal value As String)
                _InActionName = value
            End Set
        End Property
        Public Property OutActionName() As String
            Get
                Return _OutActionName
            End Get
            Set(ByVal value As String)
                _OutActionName = value
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
        Public Property PH_InName() As String
            Get
                Return _PH_InName
            End Get
            Set(ByVal value As String)
                _PH_InName = value
            End Set
        End Property
        Public Property PH_OutName() As String
            Get
                Return _PH_OutName
            End Get
            Set(ByVal value As String)
                _PH_OutName = value
            End Set
        End Property

    End Class

End Namespace


