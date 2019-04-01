Namespace LFERP.Library.SampleManager.SampleDivert
    Public Class SampleDivertInfo
        Private _AutoID As String
        Private _SD_ID As String
        Private _Code_ID As String
        Private _SD_OutSO_ID As String
        Private _SD_OutD_ID As String

        Private _SD_OutPS_NO As String
        Private _SD_InSO_ID As String
        Private _SD_InD_ID As String
        Private _SD_InPS_NO As String
        Private _SD_Qty As Integer

        Private _SD_Check As Boolean
        Private _SD_CheckDate As Date
        Private _SD_CheckAction As String
        Private _SD_CheckRemark As String
        Private _SD_CardID As String

        Private _SD_Remark As String
        Private _SD_AddUserID As String
        Private _SD_AddDate As Date
        Private _SD_ModifyUserID As String
        Private _SD_ModifyDate As Date

        Private _SD_CheckActionName As String
        Private _SD_AddUserName As String
        Private _SD_ModifyUserName As String

        Private _SD_OutPS_Name As String
        Private _SD_InPS_Name As String
        Private _SD_OutD_Name As String
        Private _SD_InD_Name As String

        Private _OutSO_SampleID As String
        Private _InSO_SampleID As String
        Private _OutPM_M_Code As String
        Private _InPM_M_Code As String
        Private _ClientBarcode As String



        Public Sub New()
            _AutoID = Nothing
            _SD_ID = Nothing
            _Code_ID = Nothing
            _SD_OutSO_ID = Nothing
            _SD_OutD_ID = Nothing

            _SD_OutPS_NO = Nothing
            _SD_InSO_ID = Nothing
            _SD_InD_ID = Nothing
            _SD_InPS_NO = Nothing
            _SD_Qty = 0

            _SD_Check = False
            _SD_CheckDate = Nothing
            _SD_CheckAction = Nothing
            _SD_CheckRemark = Nothing
            _SD_CardID = Nothing

            _SD_Remark = Nothing
            _SD_AddUserID = Nothing
            _SD_AddDate = Nothing
            _SD_ModifyUserID = Nothing
            _SD_ModifyDate = Nothing

            '----------------
            _SD_CheckActionName = Nothing
            _SD_AddUserName = Nothing
            _SD_ModifyUserName = Nothing

            _SD_OutPS_Name = Nothing
            _SD_InPS_Name = Nothing
            _SD_OutD_Name = Nothing
            _SD_InD_Name = Nothing

            _OutSO_SampleID = Nothing
            _InSO_SampleID = Nothing
            _OutPM_M_Code = Nothing
            _InPM_M_Code = Nothing

            _ClientBarcode = Nothing



        End Sub
        Public Property ClientBarcode() As String
            Get
                Return _ClientBarcode
            End Get
            Set(ByVal value As String)
                _ClientBarcode = value
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

        Public Property SD_ID() As String
            Get
                Return _SD_ID
            End Get
            Set(ByVal value As String)
                _SD_ID = value
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

        Public Property SD_OutSO_ID() As String
            Get
                Return _SD_OutSO_ID
            End Get
            Set(ByVal value As String)
                _SD_OutSO_ID = value
            End Set
        End Property


        Public Property SD_OutD_ID() As String
            Get
                Return _SD_OutD_ID
            End Get
            Set(ByVal value As String)
                _SD_OutD_ID = value
            End Set
        End Property

        '------------------------------
        Public Property SD_OutPS_NO() As String
            Get
                Return _SD_OutPS_NO
            End Get
            Set(ByVal value As String)
                _SD_OutPS_NO = value
            End Set
        End Property

        Public Property SD_InSO_ID() As String
            Get
                Return _SD_InSO_ID
            End Get
            Set(ByVal value As String)
                _SD_InSO_ID = value
            End Set
        End Property

        Public Property SD_InD_ID() As String
            Get
                Return _SD_InD_ID
            End Get
            Set(ByVal value As String)
                _SD_InD_ID = value
            End Set
        End Property


        Public Property SD_InPS_NO() As String
            Get
                Return _SD_InPS_NO
            End Get
            Set(ByVal value As String)
                _SD_InPS_NO = value
            End Set
        End Property


        Public Property SD_Qty() As Integer
            Get
                Return _SD_Qty
            End Get
            Set(ByVal value As Integer)
                _SD_Qty = value
            End Set
        End Property


        '---------------------------------
        Public Property SD_Check() As Boolean
            Get
                Return _SD_Check
            End Get
            Set(ByVal value As Boolean)
                _SD_Check = value
            End Set
        End Property

        Public Property SD_CheckDate() As Date
            Get
                Return _SD_CheckDate
            End Get
            Set(ByVal value As Date)
                _SD_CheckDate = value
            End Set
        End Property


        Public Property SD_CheckAction() As String
            Get
                Return _SD_CheckAction
            End Get
            Set(ByVal value As String)
                _SD_CheckAction = value
            End Set
        End Property


        Public Property SD_CheckRemark() As String
            Get
                Return _SD_CheckRemark
            End Get
            Set(ByVal value As String)
                _SD_CheckRemark = value
            End Set
        End Property

        Public Property SD_CardID() As String
            Get
                Return _SD_CardID
            End Get
            Set(ByVal value As String)
                _SD_CardID = value
            End Set
        End Property


        ''------------
        Public Property SD_Remark() As String
            Get
                Return _SD_Remark
            End Get
            Set(ByVal value As String)
                _SD_Remark = value
            End Set
        End Property

        Public Property SD_AddUserID() As String
            Get
                Return _SD_AddUserID
            End Get
            Set(ByVal value As String)
                _SD_AddUserID = value
            End Set
        End Property


        Public Property SD_AddDate() As Date
            Get
                Return _SD_AddDate
            End Get
            Set(ByVal value As Date)
                _SD_AddDate = value
            End Set
        End Property


        Public Property SD_ModifyUserID() As String
            Get
                Return _SD_ModifyUserID
            End Get
            Set(ByVal value As String)
                _SD_ModifyUserID = value
            End Set
        End Property

        Public Property SD_ModifyDate() As Date
            Get
                Return _SD_ModifyDate
            End Get
            Set(ByVal value As Date)
                _SD_ModifyDate = value
            End Set
        End Property

        '-------------
        Public Property SD_CheckActionName() As String
            Get
                Return _SD_CheckActionName
            End Get
            Set(ByVal value As String)
                _SD_CheckActionName = value
            End Set
        End Property


        Public Property SD_AddUserName() As String
            Get
                Return _SD_AddUserName
            End Get
            Set(ByVal value As String)
                _SD_AddUserName = value
            End Set
        End Property


        Public Property SD_ModifyUserName() As String
            Get
                Return _SD_ModifyUserName
            End Get
            Set(ByVal value As String)
                _SD_ModifyUserName = value
            End Set
        End Property

        ''--------------------------------------

        Public Property SD_OutPS_Name() As String
            Get
                Return _SD_OutPS_Name
            End Get
            Set(ByVal value As String)
                _SD_OutPS_Name = value
            End Set
        End Property


        Public Property SD_InPS_Name() As String
            Get
                Return _SD_InPS_Name
            End Get
            Set(ByVal value As String)
                _SD_InPS_Name = value
            End Set
        End Property


        Public Property SD_OutD_Name() As String
            Get
                Return _SD_OutD_Name
            End Get
            Set(ByVal value As String)
                _SD_OutD_Name = value
            End Set
        End Property


        Public Property SD_InD_Name() As String
            Get
                Return _SD_InD_Name
            End Get
            Set(ByVal value As String)
                _SD_InD_Name = value
            End Set
        End Property

        '---------------------------------------------------------------

        Public Property OutSO_SampleID() As String
            Get
                Return _OutSO_SampleID
            End Get
            Set(ByVal value As String)
                _OutSO_SampleID = value
            End Set
        End Property

        Public Property InSO_SampleID() As String
            Get
                Return _InSO_SampleID
            End Get
            Set(ByVal value As String)
                _InSO_SampleID = value
            End Set
        End Property

        Public Property OutPM_M_Code() As String
            Get
                Return _OutPM_M_Code
            End Get
            Set(ByVal value As String)
                _OutPM_M_Code = value
            End Set
        End Property

        Public Property InPM_M_Code() As String
            Get
                Return _InPM_M_Code
            End Get
            Set(ByVal value As String)
                _InPM_M_Code = value
            End Set
        End Property
    End Class

End Namespace
