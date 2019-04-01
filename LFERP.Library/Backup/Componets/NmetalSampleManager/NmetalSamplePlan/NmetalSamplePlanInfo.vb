Namespace LFERP.Library.NmetalSampleManager.NmetalSamplePlan

    Public Class NmetalSamplePlanInfo
        Private _AutoID As String
        Private _SP_ID As String
        Private _SO_ID As String
        Private _SS_Edition As String
        Private _SP_StartDate As String
        Private _SP_EndDate As String
        Private _SP_Remark As String
        Private _SP_AddUserID As String
        Private _SP_AddUserName As String
        Private _SP_AddDate As String
        Private _SP_ModifyUserID As String
        Private _SP_ModifyDate As String
        Private _PM_M_Code As String
        Private _M_Code As String
        Private _M_Name As String
        Private _SO_Closed As Boolean
        Private _SO_OrderQty As Integer
        Private _SO_SampleID As String


        Public Sub New()
            _AutoID = Nothing
            _SP_ID = Nothing
            _SO_ID = Nothing
            _SS_Edition = Nothing
            _SP_StartDate = Nothing
            _SP_EndDate = Nothing
            _SP_Remark = Nothing
            _SP_AddUserID = Nothing
            _SP_AddDate = Nothing
            _SP_ModifyUserID = Nothing
            _SP_ModifyDate = Nothing
            _PM_M_Code = Nothing
            _M_Code = Nothing
            _M_Name = Nothing
            _SP_AddUserName = Nothing
            _SO_Closed = Nothing
            _SO_OrderQty = 0
            _SO_SampleID = Nothing
        End Sub
        Public Property SO_SampleID() As String
            Get
                Return _SO_SampleID
            End Get
            Set(ByVal value As String)
                _SO_SampleID = value
            End Set
        End Property
        Public Property SO_OrderQty() As Integer
            Get
                Return _SO_OrderQty
            End Get
            Set(ByVal value As Integer)
                _SO_OrderQty = value
            End Set
        End Property
        Public Property SO_Closed() As Boolean
            Get
                Return _SO_Closed
            End Get
            Set(ByVal value As Boolean)
                _SO_Closed = value
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
        Public Property M_Code() As String
            Get
                Return _M_Code
            End Get
            Set(ByVal value As String)
                _M_Code = value
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
        Public Property SO_ID() As String
            Get
                Return _SO_ID
            End Get
            Set(ByVal value As String)
                _SO_ID = value
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
        Public Property SP_ID() As String
            Get
                Return _SP_ID
            End Get
            Set(ByVal value As String)
                _SP_ID = value
            End Set
        End Property
        Public Property SS_Edition() As String
            Get
                Return _SS_Edition
            End Get
            Set(ByVal value As String)
                _SS_Edition = value
            End Set
        End Property
        Public Property SP_Remark() As String
            Get
                Return _SP_Remark
            End Get
            Set(ByVal value As String)
                _SP_Remark = value
            End Set
        End Property
        Public Property SP_AddUserID() As String
            Get
                Return _SP_AddUserID
            End Get
            Set(ByVal value As String)
                _SP_AddUserID = value
            End Set
        End Property
        Public Property SP_ModifyUserID() As String
            Get
                Return _SP_ModifyUserID
            End Get
            Set(ByVal value As String)
                _SP_ModifyUserID = value
            End Set
        End Property
        Public Property SP_StartDate() As String
            Get
                Return _SP_StartDate
            End Get
            Set(ByVal value As String)
                _SP_StartDate = value
            End Set
        End Property
        Public Property SP_EndDate() As String
            Get
                Return _SP_EndDate
            End Get
            Set(ByVal value As String)
                _SP_EndDate = value
            End Set
        End Property
        Public Property SP_AddDate() As String
            Get
                Return _SP_AddDate
            End Get
            Set(ByVal value As String)
                _SP_AddDate = value
            End Set
        End Property
        Public Property SP_AddUserName() As String
            Get
                Return _SP_AddUserName
            End Get
            Set(ByVal value As String)
                _SP_AddUserName = value
            End Set
        End Property
        Public Property SP_ModifyDate() As String
            Get
                Return _SP_ModifyDate
            End Get
            Set(ByVal value As String)
                _SP_ModifyDate = value
            End Set
        End Property
    End Class

End Namespace

