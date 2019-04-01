Namespace LFERP.Library.ProductionKaiLiaoReturn
    Public Class ProductionKaiLiaoReturnInfo
        Private _AutoID As String
        Private _R_NO As String
        Private _WH_ID As String
        Private _C_NO As String
        Private _M_Code As String

        Private _RQty As Double
        Private _RRemark As String
        Private _RAction As String
        Private _RDate As String
        Private _RCheck As Boolean

        Private _RCheckAction As String
        Private _RCheckDate As String
        Private _RCheckRemark As String
        Private _R_ActQty As Double

        '------------------------------------
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _WH_Name As String
        Private _WH_PName As String

        Private _RActionName As String
        Private _RCheckActionName As String

        Private _RC_Action As String
        Private _RC_Dep As String
        Private _PM_Type As String
        Private _PM_M_Code As String
        Private _Pro_Type As String

        Private _FacName As String
        Private _BriName As String

        Private _KailiaoAutoID As String

        Sub New()
            _AutoID = Nothing

            _R_NO = Nothing
            _WH_ID = Nothing
            _C_NO = Nothing
            _M_Code = Nothing

            _RQty = 0
            _RRemark = Nothing
            _RAction = Nothing
            _RDate = Nothing
            _RCheck = False

            _RCheckAction = Nothing
            _RCheckDate = Nothing
            _RCheckRemark = Nothing
            _R_ActQty = 0

            '------------------------------------
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _WH_Name = Nothing
            _WH_PName = Nothing

            _RActionName = Nothing
            _RCheckActionName = Nothing

            _RC_Action = Nothing
            _RC_Dep = Nothing
            _PM_Type = Nothing
            _PM_M_Code = Nothing
            _Pro_Type = Nothing

            _FacName = Nothing
            _BriName = Nothing

            _KailiaoAutoID = Nothing

        End Sub

        Public Property KailiaoAutoID() As String
            Get
                Return _KailiaoAutoID
            End Get
            Set(ByVal value As String)
                _KailiaoAutoID = value
            End Set
        End Property

        Public Property RC_Action() As String
            Get
                Return _RC_Action
            End Get
            Set(ByVal value As String)
                _RC_Action = value
            End Set
        End Property


        Public Property RC_Dep() As String
            Get
                Return _RC_Dep
            End Get
            Set(ByVal value As String)
                _RC_Dep = value
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


        Public Property PM_M_Code() As String
            Get
                Return _PM_M_Code
            End Get
            Set(ByVal value As String)
                _PM_M_Code = value
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


        Public Property FacName() As String
            Get
                Return _FacName
            End Get
            Set(ByVal value As String)
                _FacName = value
            End Set
        End Property

        Public Property BriName() As String
            Get
                Return _BriName
            End Get
            Set(ByVal value As String)
                _BriName = value
            End Set
        End Property


        ''----------------------------------------------
        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property

        Public Property R_NO() As String
            Get
                Return _R_NO
            End Get
            Set(ByVal value As String)
                _R_NO = value
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

        Public Property C_NO() As String
            Get
                Return _C_NO
            End Get
            Set(ByVal value As String)
                _C_NO = value
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

        Public Property RQty() As Double
            Get
                Return _RQty
            End Get
            Set(ByVal value As Double)
                _RQty = value
            End Set
        End Property


        Public Property RRemark() As String
            Get
                Return _RRemark
            End Get
            Set(ByVal value As String)
                _RRemark = value
            End Set
        End Property


        Public Property RAction() As String
            Get
                Return _RAction
            End Get
            Set(ByVal value As String)
                _RAction = value
            End Set
        End Property

        Public Property RDate() As String
            Get
                Return _RDate
            End Get
            Set(ByVal value As String)
                _RDate = value
            End Set
        End Property

        Public Property RCheck() As Boolean
            Get
                Return _RCheck
            End Get
            Set(ByVal value As Boolean)
                _RCheck = value
            End Set
        End Property


        Public Property RCheckDate() As String
            Get
                Return _RCheckDate
            End Get
            Set(ByVal value As String)
                _RCheckDate = value
            End Set
        End Property

        Public Property RCheckAction() As String
            Get
                Return _RCheckAction
            End Get
            Set(ByVal value As String)
                _RCheckAction = value
            End Set
        End Property

        Public Property RCheckRemark() As String
            Get
                Return _RCheckRemark
            End Get
            Set(ByVal value As String)
                _RCheckRemark = value
            End Set
        End Property


        Public Property R_ActQty() As Double
            Get
                Return _R_ActQty
            End Get
            Set(ByVal value As Double)
                _R_ActQty = value
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


        Public Property RActionName() As String
            Get
                Return _RActionName
            End Get
            Set(ByVal value As String)
                _RActionName = value
            End Set
        End Property

        Public Property RCheckActionName() As String
            Get
                Return _RCheckActionName
            End Get
            Set(ByVal value As String)
                _RCheckActionName = value
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


    End Class

End Namespace
