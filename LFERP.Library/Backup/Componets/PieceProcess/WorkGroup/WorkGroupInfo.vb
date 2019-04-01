Namespace LFERP.Library.PieceProcess
    Public Class WorkGroupInfo

        Private _Wg_NO As String
        Private _Wg_Name As String
        Private _Wg_Manager As String
        Private _DepNO As String
        Private _Wg_Remark As String
        Private _Wg_AddDate As Date
        Private _Wg_Action As String
        Private _Wg_ActionName As String
        '........................................
        Private _PG_NO As String
        Private _PM_NO As String
        Private _PM_Num As String
        Private _PM_Name As String
        Private _PM_DepName As String
        Private _PG_AddDate As Date
        Private _PG_Qty As String
        Private _PG_Remark As String
        Private _PG_Factor As String
        Private _PG_Action As String
        Private _PG_ActionName As String
        '............................................
        Private _PT_NO As String
        Private _Per_NO As String
        Private _Per_Name As String
        Private _PT_AddDate As Date
        Private _PT_EditDate As Date
        Private _PT_BeginDate As String
        Private _PT_EndDate As String
        Private _PT_QtyTime As String
        Private _PT_Remark As String
        Private _PT_Action As String
        Private _PT_ActionName As String

        Private _FacID As String
        Private _FacName As String
        Private _DepID As String
        Private _DepName As String

        Sub New()
            _Wg_NO = Nothing
            _Wg_Name = Nothing
            _Wg_Manager = Nothing
            _DepNO = Nothing
            _Wg_Remark = Nothing
            _Wg_AddDate = Nothing
            _Wg_Action = Nothing
            _Wg_ActionName = Nothing

            '...................................
            _PG_NO = Nothing
            _PM_NO = Nothing
            _PM_Num = Nothing
            _PM_Name = Nothing
            _PM_DepName = Nothing
            _PG_AddDate = Nothing
            _PG_Qty = Nothing
            _PG_Remark = Nothing
            _PG_Factor = Nothing
            _PG_Action = Nothing
            _PG_ActionName = Nothing
            '................................
            _PT_NO = Nothing
            _Per_NO = Nothing
            _Per_Name = Nothing
            _PT_AddDate = Nothing
            _PT_BeginDate = Nothing
            _PT_EndDate = Nothing
            _PT_QtyTime = Nothing
            _PT_Remark = Nothing
            _PT_Action = Nothing
            _PT_ActionName = Nothing

            _FacID = Nothing
            _FacName = Nothing
            _DepID = Nothing
            _DepName = Nothing
        End Sub
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
        Public Property Wg_Manager() As String
            Get
                Return _Wg_Manager
            End Get
            Set(ByVal value As String)
                _Wg_Manager = value
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
        Public Property Wg_Remark() As String
            Get
                Return _Wg_Remark
            End Get
            Set(ByVal value As String)
                _Wg_Remark = value
            End Set
        End Property
        Public Property Wg_AddDate() As Date
            Get
                Return _Wg_AddDate
            End Get
            Set(ByVal value As Date)
                _Wg_AddDate = value
            End Set
        End Property
        Public Property Wg_Action() As String
            Get
                Return _Wg_Action
            End Get
            Set(ByVal value As String)
                _Wg_Action = value
            End Set
        End Property
        Public Property Wg_ActionName() As String
            Get
                Return _Wg_ActionName
            End Get
            Set(ByVal value As String)
                _Wg_ActionName = value
            End Set
        End Property
        '.............................................

        Public Property PG_NO() As String
            Get
                Return _PG_NO
            End Get
            Set(ByVal value As String)
                _PG_NO = value
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
        Public Property PG_AddDate() As Date
            Get
                Return _PG_AddDate
            End Get
            Set(ByVal value As Date)
                _PG_AddDate = value
            End Set
        End Property
        Public Property PG_Qty() As String
            Get
                Return _PG_Qty
            End Get
            Set(ByVal value As String)
                _PG_Qty = value
            End Set
        End Property
        Public Property PG_Remark() As String
            Get
                Return _PG_Remark
            End Get
            Set(ByVal value As String)
                _PG_Remark = value
            End Set
        End Property
        Public Property PG_Factor() As String
            Get
                Return _PG_Factor
            End Get
            Set(ByVal value As String)
                _PG_Factor = value
            End Set
        End Property
        Public Property PG_Action() As String
            Get
                Return _PG_Action
            End Get
            Set(ByVal value As String)
                _PG_Action = value
            End Set
        End Property
        Public Property PG_ActionName() As String
            Get
                Return _PG_ActionName
            End Get
            Set(ByVal value As String)
                _PG_ActionName = value
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
        Public Property PT_QtyTime() As String
            Get
                Return _PT_QtyTime
            End Get
            Set(ByVal value As String)
                _PT_QtyTime = value
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
    End Class
End Namespace

