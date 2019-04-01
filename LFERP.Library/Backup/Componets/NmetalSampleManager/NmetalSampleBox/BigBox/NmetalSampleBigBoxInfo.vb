Namespace LFERP.Library.NmetalSampleBigBox
    Public Class NmetalSampleBigBoxInfo
#Region "緩存參數"
        Private _AutoID As String
        Private _BigBoxID As String
        Private _BigBoxNum As String
        Private _SmallBoxID As String
        Private _Customer As String
        Private _PartNumber As String
        Private _ProductionPlace As String
        Private _Supplier As String
        Private _BigBoxDate As String
        Private _SmallBoxCount As String
        Private _SmallBoxWeight As String
        Private _SmallBoxNum As String
        Private _BigBoxAddAction As String
        Private _BigBoxAddDate As String
        Private _BigBoxRemark As String
        Private _Remark As String
        Private _BigBoxCheckAction As String
        Private _BigBoxCheck As Boolean
        Private _BigBoxCheckDate As String
        Private _BigBoxCheckRemark As String

        Private _SO_SampleID As String
        Private _PK_ID As String
        Private _D_Dep As String

        Private _ActionName As String
        Private _CheckActionName As String
        Private _BitNeed As Boolean

        Private _BigRemark As String

        Private _SmallBoxName As String
        Private _ClientNumber As String
        Private _SmallBoxType As String
        Private _SmallBoxMatrial As String

#End Region

#Region "構造函數"
        Public Sub New()
            _AutoID = Nothing
            _BigBoxID = Nothing
            _BigBoxNum = Nothing
            _SmallBoxID = Nothing
            _Customer = Nothing
            _PartNumber = Nothing
            _ProductionPlace = Nothing
            _Supplier = Nothing
            _BigBoxDate = Nothing
            _SmallBoxCount = Nothing
            _SmallBoxWeight = Nothing
            _SmallBoxNum = Nothing
            _BigBoxAddAction = Nothing
            _BigBoxAddDate = Nothing
            _BigBoxRemark = Nothing
            _Remark = Nothing
            _BigBoxCheckAction = Nothing
            _BigBoxCheck = Nothing
            _BigBoxCheckDate = Nothing
            _BigBoxCheckRemark = Nothing

            _SO_SampleID = Nothing
            _PK_ID = Nothing
            _D_Dep = Nothing

            _ActionName = Nothing
            _CheckActionName = Nothing
            _BitNeed = Nothing

            _BigRemark = Nothing

            _SmallBoxName = Nothing
            _ClientNumber = Nothing
            _SmallBoxType = Nothing
            _SmallBoxMatrial = Nothing

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

        Public Property BigBoxID() As String
            Get
                Return _BigBoxID
            End Get
            Set(ByVal value As String)
                _BigBoxID = value
            End Set
        End Property

        Public Property BigBoxNum() As String
            Get
                Return _BigBoxNum
            End Get
            Set(ByVal value As String)
                _BigBoxNum = value
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

        Public Property Customer() As String
            Get
                Return _Customer
            End Get
            Set(ByVal value As String)
                _Customer = value
            End Set
        End Property

        Public Property PartNumber() As String
            Get
                Return _PartNumber
            End Get
            Set(ByVal value As String)
                _PartNumber = value
            End Set
        End Property

        Public Property ProductionPlace() As String
            Get
                Return _ProductionPlace
            End Get
            Set(ByVal value As String)
                _ProductionPlace = value
            End Set
        End Property

        Public Property Supplier() As String
            Get
                Return _Supplier
            End Get
            Set(ByVal value As String)
                _Supplier = value
            End Set
        End Property

        Public Property BigBoxDate() As String
            Get
                Return _BigBoxDate
            End Get
            Set(ByVal value As String)
                _BigBoxDate = value
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

        Public Property SmallBoxWeight() As String
            Get
                Return _SmallBoxWeight
            End Get
            Set(ByVal value As String)
                _SmallBoxWeight = value
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

        Public Property BigBoxAddAction() As String
            Get
                Return _BigBoxAddAction
            End Get
            Set(ByVal value As String)
                _BigBoxAddAction = value
            End Set
        End Property

        Public Property BigBoxAddDate() As String
            Get
                Return _BigBoxAddDate
            End Get
            Set(ByVal value As String)
                _BigBoxAddDate = value
            End Set
        End Property

        Public Property BigBoxRemark() As String
            Get
                Return _BigBoxRemark
            End Get
            Set(ByVal value As String)
                _BigBoxRemark = value
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

        Public Property BigBoxCheckAction() As String
            Get
                Return _BigBoxCheckAction
            End Get
            Set(ByVal value As String)
                _BigBoxCheckAction = value
            End Set
        End Property

        Public Property BigBoxCheck() As Boolean
            Get
                Return _BigBoxCheck
            End Get
            Set(ByVal value As Boolean)
                _BigBoxCheck = value
            End Set
        End Property

        Public Property BigBoxCheckDate() As String
            Get
                Return _BigBoxCheckDate
            End Get
            Set(ByVal value As String)
                _BigBoxCheckDate = value
            End Set
        End Property

        Public Property BigBoxCheckRemark() As String
            Get
                Return _BigBoxCheckRemark
            End Get
            Set(ByVal value As String)
                _BigBoxCheckRemark = value
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

        Public Property BitNeed() As Boolean
            Get
                Return _BitNeed
            End Get
            Set(ByVal value As Boolean)
                _BitNeed = value
            End Set
        End Property

        Public Property BigRemark() As String
            Get
                Return _BigRemark
            End Get
            Set(ByVal value As String)
                _BigRemark = value
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

#End Region
    End Class
End Namespace

