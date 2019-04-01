Namespace LFERP.Library.PieceProcess
    Public Class PersonnelInfo
        Private _Per_NO As String  '個人員工
        Private _Per_Name As String
        Private _DepNO As String
        Private _Wg_NO As String
        Private _Wg_Name As String
        Private _Per_Pay As String
        Private _Per_Dismiss As Boolean
        Private _Per_Remark As String
        Private _Per_PayType As String
        Private _Per_AddDate As Date
        Private _Per_Action As String
        Private _Per_ActionName As String
        '........................................
        Private _PP_NO As String  '個人計件
        Private _PM_NO As String
        Private _PM_Num As String
        Private _PM_Name As String
        Private _PM_DepName As String
        Private _PS_NO As String
        Private _PP_Qty As String
        Private _PP_AddDate As Date
        Private _PP_Remark As String
        Private _PP_Action As String
        Private _PP_ActionName As String
        '............................................
        Private _PT_NO As String  '個人計時
        Private _PT_AddDate As Date
        Private _PT_EditDate As Date
        Private _PT_BeginDate As String
        Private _PT_EndDate As String
        Private _PT_QtyDate As String
        Private _PT_Remark As String
        Private _PT_Action As String
        Private _PT_ActionName As String

        Private _FacID As String
        Private _FacName As String
        Private _DepID As String
        Private _DepName As String
        Private _UserName As String
        Private _UserID As String
        Private _UserRank As String

        Private _ArtType As String

        Sub New()
            _Per_NO = Nothing
            _Per_Name = Nothing
            _DepNO = Nothing
            _Wg_NO = Nothing
            _Wg_Name = Nothing
            _Per_Pay = Nothing
            _Per_Dismiss = False
            _Per_Remark = Nothing
            _Per_PayType = Nothing
            _Per_AddDate = Nothing
            _Per_Action = Nothing
            _Per_ActionName = Nothing
            '...................................
            _PP_NO = Nothing
            _PM_NO = Nothing
            _PM_NUM = Nothing
            _PM_Name = Nothing
            _PM_DepName = Nothing
            _PS_NO = Nothing
            _PP_Qty = Nothing
            _PP_AddDate = Nothing
            _PP_Remark = Nothing
            _PP_Action = Nothing
            _PP_ActionName = Nothing

            '................................
            _PT_NO = Nothing
            _PT_AddDate = Nothing
            _PT_EditDate = Nothing
            _PT_BeginDate = Nothing
            _PT_EndDate = Nothing
            _PT_QtyDate = Nothing
            _PT_Remark = Nothing
            _PT_Action = Nothing
            _PT_ActionName = Nothing

            _FacID = Nothing
            _FacName = Nothing
            _DepID = Nothing
            _DepName = Nothing
            _UserName = Nothing
            _UserID = Nothing
            _UserRank = Nothing

            _ArtType = Nothing

        End Sub

        Public Property ArtType() As String
            Get
                Return _ArtType
            End Get
            Set(ByVal value As String)
                _ArtType = value
            End Set
        End Property



        Public Property Per_NO() As String
            Get
                Return _Per_NO
            End Get
            Set(ByVal value As String)
                _Per_NO = value
            End Set
        End Property
        Public Property Per_Name() As String
            Get
                Return _Per_Name
            End Get
            Set(ByVal value As String)
                _Per_Name = value
            End Set
        End Property
        Public Property DepNO() As String
            Get
                Return _DepNO
            End Get
            Set(ByVal value As String)
                _DepNO = value
            End Set
        End Property
        Public Property Wg_NO() As String
            Get
                Return _Wg_NO
            End Get
            Set(ByVal value As String)
                _Wg_NO = value
            End Set
        End Property
        Public Property Wg_Name() As String
            Get
                Return _Wg_Name
            End Get
            Set(ByVal value As String)
                _Wg_Name = value
            End Set
        End Property
        Public Property Per_Pay() As String
            Get
                Return _Per_Pay
            End Get
            Set(ByVal value As String)
                _Per_Pay = value
            End Set
        End Property
        Public Property Per_Dismiss() As Boolean
            Get
                Return _Per_Dismiss
            End Get
            Set(ByVal value As Boolean)
                _Per_Dismiss = value
            End Set
        End Property
        Public Property Per_Remark() As String
            Get
                Return _Per_Remark
            End Get
            Set(ByVal value As String)
                _Per_Remark = value
            End Set
        End Property
        Public Property Per_PayType() As String
            Get
                Return _Per_PayType
            End Get
            Set(ByVal value As String)
                _Per_PayType = value
            End Set
        End Property
        Public Property Per_AddDate() As Date
            Get
                Return _Per_AddDate
            End Get
            Set(ByVal value As Date)
                _Per_AddDate = value
            End Set
        End Property
        Public Property Per_Action() As String
            Get
                Return _Per_Action
            End Get
            Set(ByVal value As String)
                _Per_Action = value
            End Set
        End Property
        Public Property Per_ActionName() As String
            Get
                Return _Per_ActionName
            End Get
            Set(ByVal value As String)
                _Per_ActionName = value
            End Set
        End Property
        '..................................
        Public Property PP_NO() As String
            Get
                Return _PP_NO
            End Get
            Set(ByVal value As String)
                _PP_NO = value
            End Set
        End Property
        Public Property PM_NO() As String
            Get
                Return _PM_NO
            End Get
            Set(ByVal value As String)
                _PM_NO = value
            End Set
        End Property
        Public Property PM_Num() As String
            Get
                Return _PM_Num
            End Get
            Set(ByVal value As String)
                _PM_Num = value
            End Set
        End Property
        Public Property PM_Name() As String
            Get
                Return _PM_Name
            End Get
            Set(ByVal value As String)
                _PM_Name = value
            End Set
        End Property
        Public Property PM_DepName() As String
            Get
                Return _PM_DepName
            End Get
            Set(ByVal value As String)
                _PM_DepName = value
            End Set
        End Property
        Public Property PS_NO() As String
            Get
                Return _PS_NO
            End Get
            Set(ByVal value As String)
                _PS_NO = value
            End Set
        End Property
        Public Property PP_Qty() As String
            Get
                Return _PP_Qty
            End Get
            Set(ByVal value As String)
                _PP_Qty = value
            End Set
        End Property
        Public Property PP_AddDate() As Date
            Get
                Return _PP_AddDate
            End Get
            Set(ByVal value As Date)
                _PP_AddDate = value
            End Set
        End Property
        Public Property PP_Remark() As String
            Get
                Return _PP_Remark
            End Get
            Set(ByVal value As String)
                _PP_Remark = value
            End Set
        End Property
        Public Property PP_Action() As String
            Get
                Return _PP_Action
            End Get
            Set(ByVal value As String)
                _PP_Action = value
            End Set
        End Property
        Public Property PP_ActionName() As String
            Get
                Return _PP_ActionName
            End Get
            Set(ByVal value As String)
                _PP_ActionName = value
            End Set
        End Property
        '.................................
        Public Property PT_NO() As String
            Get
                Return _PT_NO
            End Get
            Set(ByVal value As String)
                _PT_NO = value
            End Set
        End Property
        Public Property PT_AddDate() As Date
            Get
                Return _PT_AddDate
            End Get
            Set(ByVal value As Date)
                _PT_AddDate = value
            End Set
        End Property
        Public Property PT_EditDate() As Date
            Get
                Return _PT_EditDate
            End Get
            Set(ByVal value As Date)
                _PT_EditDate = value
            End Set
        End Property
        Public Property PT_BeginDate() As String
            Get
                Return _PT_BeginDate
            End Get
            Set(ByVal value As String)
                _PT_BeginDate = value
            End Set
        End Property
        Public Property PT_EndDate() As String
            Get
                Return _PT_EndDate
            End Get
            Set(ByVal value As String)
                _PT_EndDate = value
            End Set
        End Property
        Public Property PT_QtyDate() As String
            Get
                Return _PT_QtyDate
            End Get
            Set(ByVal value As String)
                _PT_QtyDate = value
            End Set
        End Property
        Public Property PT_Remark() As String
            Get
                Return _PT_Remark
            End Get
            Set(ByVal value As String)
                _PT_Remark = value
            End Set
        End Property
        Public Property PT_Action() As String
            Get
                Return _PT_Action
            End Get
            Set(ByVal value As String)
                _PT_Action = value
            End Set
        End Property

        Public Property PT_ActionName() As String
            Get
                Return _PT_ActionName
            End Get
            Set(ByVal value As String)
                _PT_ActionName = value
            End Set
        End Property

        '................................................
        Public Property FacID() As String
            Get
                Return _FacID
            End Get
            Set(ByVal value As String)
                _FacID = value
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
        Public Property DepID() As String
            Get
                Return _DepID
            End Get
            Set(ByVal value As String)
                _DepID = value
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
        Public Property UserID() As String
            Get
                Return _UserID
            End Get
            Set(ByVal value As String)
                _UserID = value
            End Set
        End Property
        Public Property UserName() As String
            Get
                Return _UserName
            End Get
            Set(ByVal value As String)
                _UserName = value
            End Set
        End Property
        Public Property UserRank() As String
            Get
                Return _UserRank
            End Get
            Set(ByVal value As String)
                _UserRank = value
            End Set
        End Property


    End Class
End Namespace

