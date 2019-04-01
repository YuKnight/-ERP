Namespace LFERP.Library.ProductionField
    Public Class ProductionFieldBadnessCauseInfo
        Private _PB_ID As String        '不良原因編號
        Private _Pro_Type As String        '工藝類型
        Private _PM_M_Code As String    '產品編號
        Private _PM_Type As String        '配件名稱
        Private _Pro_NO As String      '工序編號

        Private _PS_Name As String      '工序名稱
        Private _PB_Cause As String   '不良原因
        Private _PB_Explain As String  '說明
        Private _PB_AddUserID As String     '添加人
        Private _PB_AddDate As Date         '添加時間


        Sub New()
            _PB_ID = Nothing
            _Pro_Type = Nothing
            _PM_M_Code = Nothing
            _PM_Type = Nothing
            _Pro_NO = Nothing

            _PS_Name = Nothing
            _PB_Cause = Nothing
            _PB_Explain = Nothing
            _PB_AddUserID = Nothing
            _PB_AddDate = Nothing
        End Sub

        Public Property PB_ID() As String
            Get
                Return _PB_ID
            End Get
            Set(ByVal value As String)
                _PB_ID = value
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

        Public Property PS_Name() As String
            Get
                Return _PS_Name
            End Get
            Set(ByVal value As String)
                _PS_Name = value
            End Set
        End Property

        Public Property PB_Cause() As String
            Get
                Return _PB_Cause
            End Get
            Set(ByVal value As String)
                _PB_Cause = value
            End Set
        End Property

        Public Property PB_Explain() As String
            Get
                Return _PB_Explain
            End Get
            Set(ByVal value As String)
                _PB_Explain = value
            End Set
        End Property

        Public Property PB_AddUserID() As String
            Get
                Return _PB_AddUserID
            End Get
            Set(ByVal value As String)
                _PB_AddUserID = value
            End Set
        End Property

        Public Property PB_AddDate() As String
            Get
                Return _PB_AddDate
            End Get
            Set(ByVal value As String)
                _PB_AddDate = value
            End Set
        End Property
    End Class

End Namespace

