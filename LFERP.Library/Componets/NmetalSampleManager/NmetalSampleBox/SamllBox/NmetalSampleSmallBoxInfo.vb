Namespace LFERP.Library.NmetalSampleSamllBox

    Public Class NmetalSampleSmallBoxInfo

#Region "緩存參數"
        Private _AutoID As String
        Private _SmallBoxID As String
        Private _SmallBoxNum As String
        Private _SO_ID As String
        Private _Code_ID As String
        Private _PM_M_Code As String
        Private _StatusType As String
        Private _SmallBoxName As String
        Private _ClientNumber As String
        Private _SmallBoxType As String
        Private _SmallBoxMatrial As String
        Private _SmallBoxCount As String
        Private _SmallBoxRemark As String
        Private _Remark As String
        Private _SmallBoxAddAction As String
        Private _SmallBoxAddDate As String
        Private _SmallBoxCheck As Boolean
        Private _SmallBoxCheckAction As String
        Private _SmallBoxCheckDate As String
        Private _SmallBoxCheckRemark As String

        Private _SO_SampleID As String
        Private _PK_ID As String
        Private _D_Dep As String

        Private _ActionName As String
        Private _CheckActionName As String
        Private _DepName As String
        Private _SmallBoxWeight As String

        Private _SO_CusterID As String

#End Region

#Region "構造函數"
        Public Sub New()
            _AutoID = Nothing
            _SmallBoxID = Nothing
            _SmallBoxNum = Nothing
            _SO_ID = Nothing
            _Code_ID = Nothing
            _PM_M_Code = Nothing
            _StatusType = Nothing
            _SmallBoxName = Nothing
            _ClientNumber = Nothing
            _SmallBoxType = Nothing
            _SmallBoxMatrial = Nothing
            _SmallBoxCount = Nothing
            _SmallBoxRemark = Nothing
            _Remark = Nothing
            _SmallBoxAddAction = Nothing
            _SmallBoxAddDate = Nothing
            _SmallBoxCheck = Nothing
            _SmallBoxCheckAction = Nothing
            _SmallBoxCheckDate = Nothing
            _SmallBoxCheckRemark = Nothing

            _SO_SampleID = Nothing
            _PK_ID = Nothing
            _D_Dep = Nothing

            _ActionName = Nothing
            _CheckActionName = Nothing

            _DepName = Nothing
            _SmallBoxWeight = Nothing
            _SO_CusterID = Nothing
        End Sub
#End Region

#Region "屬性"
        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property

        Public Property SmallBoxID() As String
            Get
                Return _SmallBoxID
            End Get
            Set(ByVal value As String)
                _SmallBoxID = value
            End Set
        End Property

        Public Property SmallBoxNum() As String
            Get
                Return _SmallBoxNum
            End Get
            Set(ByVal value As String)
                _SmallBoxNum = value
            End Set
        End Property

        Public Property SO_ID() As String
            Get
                Return _SO_ID
            End Get
            Set(ByVal value As String)
                _SO_ID = value
            End Set
        End Property

        Public Property Code_ID() As String
            Get
                Return _Code_ID
            End Get
            Set(ByVal value As String)
                _Code_ID = value
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

        Public Property StatusType() As String
            Get
                Return _StatusType
            End Get
            Set(ByVal value As String)
                _StatusType = value
            End Set
        End Property

        Public Property SmallBoxName() As String
            Get
                Return _SmallBoxName
            End Get
            Set(ByVal value As String)
                _SmallBoxName = value
            End Set
        End Property

        Public Property ClientNumber() As String
            Get
                Return _ClientNumber
            End Get
            Set(ByVal value As String)
                _ClientNumber = value
            End Set
        End Property

        Public Property SmallBoxType() As String
            Get
                Return _SmallBoxType
            End Get
            Set(ByVal value As String)
                _SmallBoxType = value
            End Set
        End Property

        Public Property SmallBoxMatrial() As String
            Get
                Return _SmallBoxMatrial
            End Get
            Set(ByVal value As String)
                _SmallBoxMatrial = value
            End Set
        End Property

        Public Property SmallBoxCount() As String
            Get
                Return _SmallBoxCount
            End Get
            Set(ByVal value As String)
                _SmallBoxCount = value
            End Set
        End Property

        Public Property SmallBoxRemark() As String
            Get
                Return _SmallBoxRemark
            End Get
            Set(ByVal value As String)
                _SmallBoxRemark = value
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

        Public Property SmallBoxAddAction() As String
            Get
                Return _SmallBoxAddAction
            End Get
            Set(ByVal value As String)
                _SmallBoxAddAction = value
            End Set
        End Property

        Public Property SmallBoxAddDate() As String
            Get
                Return _SmallBoxAddDate
            End Get
            Set(ByVal value As String)
                _SmallBoxAddDate = value
            End Set
        End Property

        Public Property SmallBoxCheck() As Boolean
            Get
                Return _SmallBoxCheck
            End Get
            Set(ByVal value As Boolean)
                _SmallBoxCheck = value
            End Set
        End Property

        Public Property SmallBoxCheckAction() As String
            Get
                Return _SmallBoxCheckAction
            End Get
            Set(ByVal value As String)
                _SmallBoxCheckAction = value
            End Set
        End Property

        Public Property SmallBoxCheckDate() As String
            Get
                Return _SmallBoxCheckDate
            End Get
            Set(ByVal value As String)
                _SmallBoxCheckDate = value
            End Set
        End Property

        Public Property SmallBoxCheckRemark() As String
            Get
                Return _SmallBoxCheckRemark
            End Get
            Set(ByVal value As String)
                _SmallBoxCheckRemark = value
            End Set
        End Property

        Public Property SO_SampleID() As String
            Get
                Return _SO_SampleID
            End Get
            Set(ByVal value As String)
                _SO_SampleID = value
            End Set
        End Property

        Public Property PK_ID() As String
            Get
                Return _PK_ID
            End Get
            Set(ByVal value As String)
                _PK_ID = value
            End Set
        End Property

        Public Property D_Dep() As String
            Get
                Return _D_Dep
            End Get
            Set(ByVal value As String)
                _D_Dep = value
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

        Public Property DepName() As String
            Get
                Return _DepName
            End Get
            Set(ByVal value As String)
                _DepName = value
            End Set
        End Property

        Public Property SmallBoxWeight() As String
            Get
                Return _SmallBoxWeight
            End Get
            Set(ByVal value As String)
                _SmallBoxWeight = value
            End Set
        End Property

        Public Property SO_CusterID() As String
            Get
                Return _SO_CusterID
            End Get
            Set(ByVal value As String)
                _SO_CusterID = value
            End Set
        End Property

#End Region

    End Class
End Namespace
