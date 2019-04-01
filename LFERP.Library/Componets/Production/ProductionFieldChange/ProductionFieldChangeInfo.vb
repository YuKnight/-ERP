
Namespace LFERP.Library.ProductionFieldChange

    Public Class ProductionFieldChangeInfo

        Private _IndexNO As String
        Private _PC_NO As String
        Private _Pro_Type As String
        Private _PM_M_Code As String
        Private _PM_Type As String
        Private _Pro_NO As String
        Private _DepID As String
        Private _PC_Type As String
        Private _PC_Qty As Single
        Private _PC_ReQty As Single
        Private _PC_Action As String
        Private _PC_Date As Date
        Private _PC_Remark As String
        Private _PC_Check As Boolean
        Private _PC_CheckAction As String
        Private _PC_CheckDate As Date
        Private _PC_CheckRemark As String
        Private _CardID As String

        Private _PS_Name As String
        Private _DepName As String
        Private _FacName As String
        Private _ActionName As String
        Private _CheckActionName As String

        Private _WI_Qty As Single  '當前部門倉庫數量
        Private _FP_NO As String

        Private _PM_JiYu As String

        Sub New()

            _PM_JiYu = Nothing
            _IndexNO = 1
            _PC_NO = Nothing
            _Pro_Type = Nothing
            _PM_M_Code = Nothing
            _PM_Type = Nothing
            _Pro_NO = Nothing
            _DepID = Nothing
            _PC_Type = Nothing
            _PC_Qty = 0
            _PC_ReQty = 0
            _PC_Action = Nothing
            _PC_Date = Nothing
            _PC_Remark = Nothing
            _PC_Check = False
            _PC_CheckAction = Nothing
            _PC_CheckDate = Nothing
            _PC_CheckRemark = Nothing
            _CardID = Nothing

            _PS_Name = Nothing
            _DepName = Nothing
            _FacName = Nothing
            _ActionName = Nothing
            _CheckActionName = Nothing
            _WI_Qty = 0
            _FP_NO = Nothing
        End Sub



        Public Property PM_JiYu() As String
            Get
                Return _PM_JiYu
            End Get
            Set(ByVal value As String)
                _PM_JiYu = value
            End Set
        End Property

        Public Property IndexNO() As String
            Get
                Return _IndexNO
            End Get
            Set(ByVal value As String)
                _IndexNO = value
            End Set
        End Property
        Public Property PC_NO() As String
            Get
                Return _PC_NO
            End Get
            Set(ByVal value As String)
                _PC_NO = value
            End Set
        End Property
        Public Property Pro_Type() As String
            Get
                Return _Pro_Type
            End Get
            Set(ByVal value As String)
                _Pro_Type = value
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
        Public Property DepID() As String
            Get
                Return _DepID
            End Get
            Set(ByVal value As String)
                _DepID = value
            End Set
        End Property

        Public Property PC_Type() As String
            Get
                Return _PC_Type
            End Get
            Set(ByVal value As String)
                _PC_Type = value
            End Set
        End Property
        Public Property PC_Qty() As Single
            Get
                Return _PC_Qty
            End Get
            Set(ByVal value As Single)
                _PC_Qty = value
            End Set
        End Property
        Public Property PC_ReQty() As Single
            Get
                Return _PC_ReQty
            End Get
            Set(ByVal value As Single)
                _PC_ReQty = value
            End Set
        End Property
        Public Property PC_Action() As String
            Get
                Return _PC_Action
            End Get
            Set(ByVal value As String)
                _PC_Action = value
            End Set
        End Property
        Public Property PC_Date() As Date
            Get
                Return _PC_Date
            End Get
            Set(ByVal value As Date)
                _PC_Date = value
            End Set
        End Property
        Public Property PC_Remark() As String
            Get
                Return _PC_Remark
            End Get
            Set(ByVal value As String)
                _PC_Remark = value
            End Set
        End Property
        Public Property PC_Check() As Boolean
            Get
                Return _PC_Check
            End Get
            Set(ByVal value As Boolean)
                _PC_Check = value
            End Set
        End Property
        Public Property PC_CheckAction() As String
            Get
                Return _PC_CheckAction
            End Get
            Set(ByVal value As String)
                _PC_CheckAction = value
            End Set
        End Property
        Public Property PC_CheckDate() As Date
            Get
                Return _PC_CheckDate
            End Get
            Set(ByVal value As Date)
                _PC_CheckDate = value
            End Set
        End Property
        Public Property PC_CheckRemark() As String
            Get
                Return _PC_CheckRemark
            End Get
            Set(ByVal value As String)
                _PC_CheckRemark = value
            End Set
        End Property
        Public Property CardID() As String
            Get
                Return _CardID
            End Get
            Set(ByVal value As String)
                _CardID = value
            End Set
        End Property

        '-----------------------------------------------
        Public Property PS_Name() As String
            Get
                Return _PS_Name
            End Get
            Set(ByVal value As String)
                _PS_Name = value
            End Set
        End Property
        Public Property DepName() As String
            Get
                Return _DepName
            End Get
            Set(ByVal value As String)
                _DepName = value
            End Set
        End Property
        Public Property FacName() As String
            Get
                Return _FacName
            End Get
            Set(ByVal value As String)
                _FacName = value
            End Set
        End Property
        Public Property ActionName() As String
            Get
                Return _ActionName
            End Get
            Set(ByVal value As String)
                _ActionName = value
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
        Public Property WI_Qty() As Single
            Get
                Return _WI_Qty
            End Get
            Set(ByVal value As Single)
                _WI_Qty = value
            End Set
        End Property
        Public Property FP_NO() As String
            Get
                Return _FP_NO
            End Get
            Set(ByVal value As String)
                _FP_NO = value
            End Set
        End Property
        '-----------------------------------------------
    End Class

End Namespace

