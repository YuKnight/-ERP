Namespace LFERP.Library.Production.ProductionOutWard

    Public Class ProductionOutWardInfo

        Private _AutoID As String
        Private _OW_Type As String

        Private _OW_ID As String
        Private _OW_Date As Date
        Private _OW_TO As String
        Private _OW_From As String
        Private _OW_Driver As String
        Private _OW_IN As String
        Private _OW_Out As String
        Private _OW_Weight As Single
        Private _OW_Qty As Single
        Private _OW_Remark As String
        Private _OW_Action As String
        Private _OW_Check As Boolean
        Private _OW_CheckDate As Date
        Private _OW_CheckRemark As String
        Private _OW_CheckAction As String
        Private _PM_M_Code As String
        Private _PM_Type As String
        Private _Pro_NO As String
        Private _OW_Do As String
        Private _OW_Return As String
        Private _OW_Reason As String
        Private _OW_Detail As String

        Private _OW_Unit As String

        Private _PS_Name As String
        Private _ActionName As String
        Private _CheckActionName As String
        Private _PM_JiYu As String


        Sub New()

            _PM_JiYu = Nothing

            _AutoID = 0
            _OW_Type = Nothing
            _OW_ID = Nothing
            _OW_Date = Nothing
            _OW_TO = Nothing
            _OW_From = Nothing
            _OW_Driver = Nothing
            _OW_IN = Nothing
            _OW_Out = Nothing
            _OW_Weight = 0
            _OW_Qty = 0
            _OW_Remark = Nothing
            _OW_Check = False
            _OW_CheckDate = Nothing
            _OW_CheckRemark = Nothing
            _OW_CheckAction = Nothing
            _PM_M_Code = Nothing
            _PM_Type = Nothing
            _Pro_NO = Nothing
            _OW_Do = Nothing
            _OW_Return = Nothing
            _OW_Reason = Nothing
            _OW_Detail = Nothing

            _OW_Unit = Nothing
            _PS_Name = Nothing
            _ActionName = Nothing
            _CheckActionName = Nothing

        End Sub

        Public Property PM_JiYu() As String
            Get
                Return _PM_JiYu
            End Get
            Set(ByVal value As String)
                _PM_JiYu = value
            End Set
        End Property
        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property
        Public Property OW_Type() As String
            Get
                Return _OW_Type
            End Get
            Set(ByVal value As String)
                _OW_Type = value
            End Set
        End Property
        Public Property OW_ID() As String
            Get
                Return _OW_ID
            End Get
            Set(ByVal value As String)
                _OW_ID = value
            End Set
        End Property
        Public Property OW_Date() As Date
            Get
                Return _OW_Date
            End Get
            Set(ByVal value As Date)
                _OW_Date = value
            End Set
        End Property
        Public Property OW_TO() As String
            Get
                Return _OW_TO
            End Get
            Set(ByVal value As String)
                _OW_TO = value
            End Set
        End Property
        Public Property OW_From() As String
            Get
                Return _OW_From
            End Get
            Set(ByVal value As String)
                _OW_From = value
            End Set
        End Property
        Public Property OW_Driver() As String
            Get
                Return _OW_Driver
            End Get
            Set(ByVal value As String)
                _OW_Driver = value
            End Set
        End Property
        Public Property OW_IN() As String
            Get
                Return _OW_IN
            End Get
            Set(ByVal value As String)
                _OW_IN = value
            End Set
        End Property
        Public Property OW_Out() As String
            Get
                Return _OW_Out
            End Get
            Set(ByVal value As String)
                _OW_Out = value
            End Set
        End Property
        Public Property OW_Weight() As Single
            Get
                Return _OW_Weight
            End Get
            Set(ByVal value As Single)
                _OW_Weight = value
            End Set
        End Property
        Public Property OW_Qty() As Single
            Get
                Return _OW_Qty
            End Get
            Set(ByVal value As Single)
                _OW_Qty = value
            End Set
        End Property
        Public Property OW_Remark() As String
            Get
                Return _OW_Remark
            End Get
            Set(ByVal value As String)
                _OW_Remark = value
            End Set
        End Property
        Public Property OW_Action() As String
            Get
                Return _OW_Action
            End Get
            Set(ByVal value As String)
                _OW_Action = value
            End Set
        End Property
        Public Property OW_Check() As Boolean
            Get
                Return _OW_Check
            End Get
            Set(ByVal value As Boolean)
                _OW_Check = value
            End Set
        End Property
        Public Property OW_CheckDate() As Date
            Get
                Return _OW_CheckDate
            End Get
            Set(ByVal value As Date)
                _OW_CheckDate = value
            End Set
        End Property
        Public Property OW_CheckAction() As String
            Get
                Return _OW_CheckAction
            End Get
            Set(ByVal value As String)
                _OW_CheckAction = value
            End Set
        End Property
        Public Property OW_CheckRemark() As String
            Get
                Return _OW_CheckRemark
            End Get
            Set(ByVal value As String)
                _OW_CheckRemark = value
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
        Public Property PM_Type() As String
            Get
                Return _PM_Type
            End Get
            Set(ByVal value As String)
                _PM_Type = value
            End Set
        End Property
        Public Property Pro_NO() As String
            Get
                Return _Pro_NO
            End Get
            Set(ByVal value As String)
                _Pro_NO = value
            End Set
        End Property
        Public Property OW_Do() As String
            Get
                Return _OW_Do
            End Get
            Set(ByVal value As String)
                _OW_Do = value
            End Set
        End Property
        Public Property OW_Return() As String
            Get
                Return _OW_Return
            End Get
            Set(ByVal value As String)
                _OW_Return = value
            End Set
        End Property
        Public Property OW_Reason() As String
            Get
                Return _OW_Reason
            End Get
            Set(ByVal value As String)
                _OW_Reason = value
            End Set
        End Property
        Public Property OW_Detail() As String
            Get
                Return _OW_Detail
            End Get
            Set(ByVal value As String)
                _OW_Detail = value
            End Set
        End Property

        Public Property PS_Name() As String
            Get
                Return _PS_Name
            End Get
            Set(ByVal value As String)
                _PS_Name = value
            End Set
        End Property
        Public Property ActionName() As String
            Get
                Return _ActionName
            End Get
            Set(ByVal value As String)
                _CheckActionName = value
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
        Public Property OW_Unit() As String
            Get
                Return _OW_Unit
            End Get
            Set(ByVal value As String)
                _OW_Unit = value
            End Set
        End Property
    End Class

End Namespace


