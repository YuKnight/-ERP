Namespace LFERP.Library.SampleManager.SampleSend
    Public Class SampleSendBackInfo
        Private _AutoID As Double
        Private _SB_ID As String
        Private _SO_ID As String
        Private _SS_Edition As String
        Private _SB_Qty As Int64
        Private _SB_CusterID As String
        Private _PM_M_Code As String
        Private _Code_ID As String
        Private _ClientBarcode As String
        Private _D_ID As String

        Private _PS_NO As String
        Private _D_Dep As String
        Private _PS_Name As String
        Private _SB_Remark As String
        Private _SB_SendBackDate As DateTime
        Private _SB_AddUserID As String
        Private _SB_AddDate As DateTime
        Private _SB_ModifyUserID As String
        Private _SB_ModifyDate As DateTime
        Private _SB_CheckUserID As String
        Private _SB_Check As Boolean
        Private _SB_CheckDate As DateTime
        Private _SB_CheckRemark As String
        Private _SE_TypeName As String
        Private _SO_SampleID As String

        Public Sub New()
            _AutoID = 0
            _SB_ID = Nothing
            _SO_ID = Nothing
            _SS_Edition = Nothing
            _SB_Qty = 0
            _SB_CusterID = Nothing
            _PM_M_Code = Nothing
            _Code_ID = Nothing
            _ClientBarcode = Nothing
            _D_ID = Nothing
            _PS_NO = Nothing
            _SB_Remark = Nothing
            _SB_SendBackDate = Nothing
            _SB_AddUserID = Nothing
            _SB_AddDate = Nothing
            _SB_ModifyUserID = Nothing
            _SB_ModifyDate = Nothing
            _SB_CheckUserID = Nothing
            _SB_Check = False
            _SB_CheckDate = Nothing
            _SB_CheckRemark = Nothing
            _D_Dep = Nothing
            _PS_Name = Nothing
            _SE_TypeName = Nothing
            _SO_SampleID = Nothing
        End Sub
        Public Property ClientBarcode() As String
            Get
                Return _ClientBarcode
            End Get
            Set(ByVal value As String)
                _ClientBarcode = value
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
        Public Property SE_TypeName() As String
            Get
                Return _SE_TypeName
            End Get
            Set(ByVal value As String)
                _SE_TypeName = value
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
        Public Property PS_Name() As String
            Get
                Return _PS_Name
            End Get
            Set(ByVal value As String)
                _PS_Name = value
            End Set
        End Property
        Public Property AutoID() As Double
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Double)
                _AutoID = value
            End Set
        End Property
        Public Property SB_ID() As String
            Get
                Return _SB_ID
            End Get
            Set(ByVal value As String)
                _SB_ID = value
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
        Public Property SS_Edition() As String
            Get
                Return _SS_Edition
            End Get
            Set(ByVal value As String)
                _SS_Edition = value
            End Set
        End Property
        Public Property SB_Qty() As Int64
            Get
                Return _SB_Qty
            End Get
            Set(ByVal value As Int64)
                _SB_Qty = value
            End Set
        End Property
        Public Property SB_CusterID() As String
            Get
                Return _SB_CusterID
            End Get
            Set(ByVal value As String)
                _SB_CusterID = value
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
        Public Property Code_ID() As String
            Get
                Return _Code_ID
            End Get
            Set(ByVal value As String)
                _Code_ID = value
            End Set
        End Property
        Public Property D_ID() As String
            Get
                Return _D_ID
            End Get
            Set(ByVal value As String)
                _D_ID = value
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
        Public Property SB_Remark() As String
            Get
                Return _SB_Remark
            End Get
            Set(ByVal value As String)
                _SB_Remark = value
            End Set
        End Property
        Public Property SB_SendBackDate() As DateTime
            Get
                Return _SB_SendBackDate
            End Get
            Set(ByVal value As DateTime)
                _SB_SendBackDate = value
            End Set
        End Property
        Public Property SB_AddUserID() As String
            Get
                Return _SB_AddUserID
            End Get
            Set(ByVal value As String)
                _SB_AddUserID = value
            End Set
        End Property
        Public Property SB_AddDate() As DateTime
            Get
                Return _SB_AddDate
            End Get
            Set(ByVal value As DateTime)
                _SB_AddDate = value
            End Set
        End Property
        Public Property SB_ModifyUserID() As String
            Get
                Return _SB_ModifyUserID
            End Get
            Set(ByVal value As String)
                _SB_ModifyUserID = value
            End Set
        End Property
        Public Property SB_ModifyDate() As DateTime
            Get
                Return _SB_ModifyDate
            End Get
            Set(ByVal value As DateTime)
                _SB_ModifyDate = value
            End Set
        End Property
        Public Property SB_CheckUserID() As String
            Get
                Return _SB_CheckUserID
            End Get
            Set(ByVal value As String)
                _SB_CheckUserID = value
            End Set
        End Property
        Public Property SB_Check() As Boolean
            Get
                Return _SB_Check
            End Get
            Set(ByVal value As Boolean)
                _SB_Check = value
            End Set
        End Property
        Public Property SB_CheckDate() As DateTime
            Get
                Return _SB_CheckDate
            End Get
            Set(ByVal value As DateTime)
                _SB_CheckDate = value
            End Set
        End Property
        Public Property SB_CheckRemark() As String
            Get
                Return _SB_CheckRemark
            End Get
            Set(ByVal value As String)
                _SB_CheckRemark = value
            End Set
        End Property

    End Class
End Namespace