
Namespace LFERP.Library.WareHouse.WareQCRecover

    Public Class WareQCRecoverInfo

        Private _AutoID As String
        Private _WQR_NO As String
        Private _WQS_NO As String
        Private _M_Code As String
        Private _WQR_Qty As Single
        Private _WH_ID As String
        Private _WQR_Date As Date
        Private _WQR_Action As String
        Private _WQR_Check As Boolean
        Private _WQR_Remark As String
        Private _WQR_CheckAction As String

        Private _M_Name As String
        Private _M_Gauge As String
        Private _UserName As String
        Private _WH_Name As String

        Sub New()

            _AutoID = Nothing
            _WQR_NO = Nothing
            _WQS_NO = Nothing
            _M_Code = Nothing
            _WQR_Qty = 0
            _WH_ID = Nothing
            _WQR_Date = Nothing
            _WQR_Action = Nothing
            _WQR_Check = False
            _WQR_Remark = Nothing
            _WQR_CheckAction = Nothing

            _M_Name = Nothing
            _M_Gauge = Nothing
            _UserName = Nothing
            _WH_Name = Nothing

        End Sub
        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property
        Public Property WQR_NO() As String
            Get
                Return _WQR_NO
            End Get
            Set(ByVal value As String)
                _WQR_NO = value
            End Set
        End Property
        Public Property WQS_NO() As String
            Get
                Return _WQS_NO
            End Get
            Set(ByVal value As String)
                _WQS_NO = value
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
        Public Property WQR_Qty() As Single
            Get
                Return _WQR_Qty
            End Get
            Set(ByVal value As Single)
                _WQR_Qty = value
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
        Public Property WQR_Date() As Date
            Get
                Return _WQR_Date
            End Get
            Set(ByVal value As Date)
                _WQR_Date = value
            End Set
        End Property
        Public Property WQR_Action() As String
            Get
                Return _WQR_Action
            End Get
            Set(ByVal value As String)
                _WQR_Action = value
            End Set
        End Property
        Public Property WQR_Check() As Boolean
            Get
                Return _WQR_Check
            End Get
            Set(ByVal value As Boolean)
                _WQR_Check = value
            End Set
        End Property
        Public Property WQR_CheckAction() As String
            Get
                Return _WQR_CheckAction
            End Get
            Set(ByVal value As String)
                _WQR_CheckAction = value
            End Set
        End Property
        Public Property WQR_Remark() As String
            Get
                Return _WQR_Remark
            End Get
            Set(ByVal value As String)
                _WQR_Remark = value
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
        Public Property UserName() As String
            Get
                Return _UserName
            End Get
            Set(ByVal value As String)
                _UserName = value
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

    End Class

End Namespace


