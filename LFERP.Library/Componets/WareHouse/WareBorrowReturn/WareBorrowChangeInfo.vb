Namespace LFERP.Library.WareHouse.WareBorrowChange


    Public Class WareBorrowChangeInfo


        Private _AutoID As String
        Private _M_Code As String
        Private _WB_PerID As String
        Private _WB_NUM As String

        Private _QtyS As Int32
        Private _QtyE As Int32
        Private _ChangeType As String
        Private _Remark As String

        Private _ChageDate As Date
        Private _ChangeAction As String
        Private _SumQty As Int32
        Private _ChangeActionName As String

        Private _ChangeNo As String
        Private _M_Name As String
        Private _M_Gauge As String

        '2014-02-15 «ÀÂ@---------------------------
        Private _Check As Boolean
        Private _CheckAction As String
        Private _CheckDate As Date
        Private _CheckRemark As String
        Private _CheckActionName As String
        '------------------------------------------


        Sub New()
            _AutoID = Nothing
            _M_Code = Nothing
            _WB_PerID = Nothing
            _WB_NUM = Nothing

            _QtyS = 0
            _QtyE = 0
            _ChangeType = Nothing
            _Remark = Nothing

            _ChageDate = Nothing
            _ChangeAction = Nothing
            _SumQty = 0

            _ChangeActionName = Nothing
            _ChangeNo = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing

            '2014-02-15 «ÀÂ@---------------------------
            _Check = False
            _CheckAction = Nothing
            _CheckDate = Nothing
            _CheckRemark = Nothing
            _CheckActionName = Nothing
            '------------------------------------------

        End Sub

        Public Property M_Gauge() As String
            Get
                Return _M_Gauge
            End Get
            Set(ByVal value As String)
                _M_Gauge = value
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

        Public Property ChangeNo() As String
            Get
                Return _ChangeNo
            End Get
            Set(ByVal value As String)
                _ChangeNo = value
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

        Public Property M_Code() As String
            Get
                Return _M_Code
            End Get
            Set(ByVal value As String)
                _M_Code = value
            End Set
        End Property


        Public Property WB_PerID() As String
            Get
                Return _WB_PerID
            End Get
            Set(ByVal value As String)
                _WB_PerID = value
            End Set
        End Property

        Public Property WB_NUM() As String
            Get
                Return _WB_NUM
            End Get
            Set(ByVal value As String)
                _WB_NUM = value
            End Set
        End Property

        Public Property QtyS() As Int32
            Get
                Return _QtyS
            End Get
            Set(ByVal value As Int32)
                _QtyS = value
            End Set
        End Property


        Public Property QtyE() As Int32
            Get
                Return _QtyE
            End Get
            Set(ByVal value As Int32)
                _QtyE = value
            End Set
        End Property

        Public Property ChangeType() As String
            Get
                Return _ChangeType
            End Get
            Set(ByVal value As String)
                _ChangeType = value
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

        Public Property ChageDate() As Date
            Get
                Return _ChageDate
            End Get
            Set(ByVal value As Date)
                _ChageDate = value
            End Set
        End Property

        Public Property ChangeAction() As String
            Get
                Return _ChangeAction
            End Get
            Set(ByVal value As String)
                _ChangeAction = value
            End Set
        End Property

        Public Property SumQty() As String
            Get
                Return _SumQty
            End Get
            Set(ByVal value As String)
                _SumQty = value
            End Set
        End Property

        Public Property ChangeActionName() As String
            Get
                Return _ChangeActionName
            End Get
            Set(ByVal value As String)
                _ChangeActionName = value
            End Set
        End Property

        '2014-02-15 «ÀÂ@---------------------------
        Public Property Check() As Boolean
            Get
                Return _Check
            End Get
            Set(ByVal value As Boolean)
                _Check = value
            End Set
        End Property

        Public Property CheckAction() As String
            Get
                Return _CheckAction
            End Get
            Set(ByVal value As String)
                _CheckAction = value
            End Set
        End Property
        Public Property CheckDate() As Date
            Get
                Return _CheckDate
            End Get
            Set(ByVal value As Date)
                _CheckDate = value
            End Set
        End Property
        Public Property CheckRemark() As String
            Get
                Return _CheckRemark
            End Get
            Set(ByVal value As String)
                _CheckRemark = value
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
        '------------------------------------------
    End Class


End Namespace