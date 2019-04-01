
Namespace LFERP.Library.Production.ProuctionWareOutB

    Public Class ProductionWareOutBInfo
        Private _AutoID As String
        Private _P_NO As String

        Private _P_WareIN As String
        Private _P_WareINName As String
        Private _Pro_TypeIN As String
        Private _PM_M_CodeIN As String
        Private _PM_TypeIN As String
        Private _M_CodeIN As String

        Private _P_WareOut As String
        Private _P_WareOutName As String
        Private _Pro_TypeOut As String
        Private _PM_M_CodeOut As String
        Private _PM_TypeOut As String
        Private _M_CodeOut As String

        Private _P_AddDate As Date
        Private _P_Action As String
        Private _P_Remark As String
        Private _P_ModifyDate As Date
        Private _P_ModifyAction As String

        Private _P_Check As Boolean
        Private _P_CheckDate As Date
        Private _P_CheckAction As String
        Private _P_CheckRemark As String

        Private _P_InCheck As Boolean
        Private _P_InCheckDate As Date
        Private _P_InCheckAction As String

        Private _P_ActionName As String
        Private _P_CheckActionName As String
        Private _P_InCheckActionName As String
        Private _P_ModifyActionName As String

        Private _PM_JiYuIn As String
        Private _PM_JiYuOut As String

        Private _P_Qty As Integer
        Private _P_EndINQty As Integer
        Private _P_EndOutQty As Integer



        Sub New()
            _AutoID = Nothing
            _P_NO = Nothing

            _P_WareIN = Nothing
            _P_WareINName = Nothing
            _Pro_TypeIN = Nothing
            _PM_M_CodeIN = Nothing
            _PM_TypeIN = Nothing
            _M_CodeIN = Nothing

            _P_WareOut = Nothing
            _P_WareOutName = Nothing
            _Pro_TypeOut = Nothing
            _PM_M_CodeOut = Nothing
            _PM_TypeOut = Nothing
            _M_CodeOut = Nothing

            _P_AddDate = Nothing
            _P_Action = Nothing
            _P_Remark = Nothing
            _P_ModifyDate = Nothing
            _P_ModifyAction = Nothing

            _P_Check = False
            _P_CheckDate = Nothing
            _P_CheckAction = Nothing
            _P_CheckRemark = Nothing

            _P_InCheck = False
            _P_InCheckDate = Nothing
            _P_InCheckAction = Nothing

            _P_ActionName = Nothing
            _P_CheckActionName = Nothing
            _P_InCheckActionName = Nothing
            _P_ModifyActionName = Nothing

            _PM_JiYuIn = Nothing
            _PM_JiYuOut = Nothing
            _P_Qty = 0
            _P_EndINQty = 0
            _P_EndOutQty = 0
        End Sub
        Public Property P_EndOutQty() As Integer
            Get
                Return _P_EndOutQty
            End Get
            Set(ByVal value As Integer)
                _P_EndOutQty = value
            End Set
        End Property
        Public Property P_EndINQty() As Integer
            Get
                Return _P_EndINQty
            End Get
            Set(ByVal value As Integer)
                _P_EndINQty = value
            End Set
        End Property
        Public Property P_Qty() As Integer
            Get
                Return _P_Qty
            End Get
            Set(ByVal value As Integer)
                _P_Qty = value
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

        Public Property P_NO() As String
            Get
                Return _P_NO
            End Get
            Set(ByVal value As String)
                _P_NO = value
            End Set
        End Property


        Public Property P_WareIN() As String
            Get
                Return _P_WareIN
            End Get
            Set(ByVal value As String)
                _P_WareIN = value
            End Set
        End Property
        Public Property P_WareINName() As String
            Get
                Return _P_WareINName
            End Get
            Set(ByVal value As String)
                _P_WareINName = value
            End Set
        End Property

        Public Property Pro_TypeIN() As String
            Get
                Return _Pro_TypeIN
            End Get
            Set(ByVal value As String)
                _Pro_TypeIN = value
            End Set
        End Property

        Public Property PM_M_CodeIN() As String
            Get
                Return _PM_M_CodeIN
            End Get
            Set(ByVal value As String)
                _PM_M_CodeIN = value
            End Set
        End Property

        Public Property PM_TypeIN() As String
            Get
                Return _PM_TypeIN
            End Get
            Set(ByVal value As String)
                _PM_TypeIN = value
            End Set
        End Property

        Public Property M_CodeIN() As String
            Get
                Return _M_CodeIN
            End Get
            Set(ByVal value As String)
                _M_CodeIN = value
            End Set
        End Property


        Public Property P_WareOut() As String
            Get
                Return _P_WareOut
            End Get
            Set(ByVal value As String)
                _P_WareOut = value
            End Set
        End Property
        Public Property P_WareOutName() As String
            Get
                Return _P_WareOutName
            End Get
            Set(ByVal value As String)
                _P_WareOutName = value
            End Set
        End Property

        Public Property Pro_TypeOut() As String
            Get
                Return _Pro_TypeOut
            End Get
            Set(ByVal value As String)
                _Pro_TypeOut = value
            End Set
        End Property

        Public Property PM_M_CodeOut() As String
            Get
                Return _PM_M_CodeOut
            End Get
            Set(ByVal value As String)
                _PM_M_CodeOut = value
            End Set
        End Property

        Public Property PM_TypeOut() As String
            Get
                Return _PM_TypeOut
            End Get
            Set(ByVal value As String)
                _PM_TypeOut = value
            End Set
        End Property


        Public Property M_CodeOut() As String
            Get
                Return _M_CodeOut
            End Get
            Set(ByVal value As String)
                _M_CodeOut = value
            End Set
        End Property



        Public Property P_AddDate() As Date
            Get
                Return _P_AddDate
            End Get
            Set(ByVal value As Date)
                _P_AddDate = value
            End Set
        End Property


        Public Property P_Action() As String
            Get
                Return _P_Action
            End Get
            Set(ByVal value As String)
                _P_Action = value
            End Set
        End Property

        Public Property P_Remark() As String
            Get
                Return _P_Remark
            End Get
            Set(ByVal value As String)
                _P_Remark = value
            End Set
        End Property


        Public Property P_ModifyDate() As Date
            Get
                Return _P_ModifyDate
            End Get
            Set(ByVal value As Date)
                _P_ModifyDate = value
            End Set
        End Property


        Public Property P_ModifyAction() As String
            Get
                Return _P_ModifyAction
            End Get
            Set(ByVal value As String)
                _P_ModifyAction = value
            End Set
        End Property


        Public Property P_Check() As Boolean
            Get
                Return _P_Check
            End Get
            Set(ByVal value As Boolean)
                _P_Check = value
            End Set
        End Property


        Public Property P_CheckDate() As Date
            Get
                Return _P_CheckDate
            End Get
            Set(ByVal value As Date)
                _P_CheckDate = value
            End Set
        End Property

        Public Property P_CheckAction() As String
            Get
                Return _P_CheckAction
            End Get
            Set(ByVal value As String)
                _P_CheckAction = value
            End Set
        End Property

        Public Property P_CheckRemark() As String
            Get
                Return _P_CheckRemark
            End Get
            Set(ByVal value As String)
                _P_CheckRemark = value
            End Set
        End Property

        Public Property P_InCheck() As Boolean
            Get
                Return _P_InCheck
            End Get
            Set(ByVal value As Boolean)
                _P_InCheck = value
            End Set
        End Property

        Public Property P_InCheckDate() As Date
            Get
                Return _P_InCheckDate
            End Get
            Set(ByVal value As Date)
                _P_InCheckDate = value
            End Set
        End Property


        Public Property P_InCheckAction() As String
            Get
                Return _P_InCheckAction
            End Get
            Set(ByVal value As String)
                _P_InCheckAction = value
            End Set
        End Property


        Public Property P_ActionName() As String
            Get
                Return _P_ActionName
            End Get
            Set(ByVal value As String)
                _P_ActionName = value
            End Set
        End Property

        Public Property P_CheckActionName() As String
            Get
                Return _P_CheckActionName
            End Get
            Set(ByVal value As String)
                _P_CheckActionName = value
            End Set
        End Property

        Public Property P_InCheckActionName() As String
            Get
                Return _P_InCheckActionName
            End Get
            Set(ByVal value As String)
                _P_InCheckActionName = value
            End Set
        End Property

        Public Property P_ModifyActionName() As String
            Get
                Return _P_ModifyActionName
            End Get
            Set(ByVal value As String)
                _P_ModifyActionName = value
            End Set
        End Property

        Public Property PM_JiYuIn() As String
            Get
                Return _PM_JiYuIn
            End Get
            Set(ByVal value As String)
                _PM_JiYuIn = value
            End Set
        End Property

        Public Property PM_JiYuOut() As String
            Get
                Return _PM_JiYuOut
            End Get
            Set(ByVal value As String)
                _PM_JiYuOut = value
            End Set
        End Property

    End Class

End Namespace