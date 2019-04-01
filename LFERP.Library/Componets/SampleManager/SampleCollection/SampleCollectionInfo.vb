Namespace LFERP.Library.SampleManager.SampleCollection
    Public Class SampleCollectionInfo
        Private _AutoID As String
        Private _Code_ID As String
        Private _Qty As Integer
        Private _StatusType As String
        Private _StatusTypeName As String
        Private _Remark As String
        Private _PM_M_Code As String

        Private _AddUserID As String
        Private _AddUserName As String
        Private _AddDate As Date
        Private _ModifyUserID As String
        Private _ModifyDate As Date

        Private _PM_Type As String
        Private _SO_ID As String
        Private _SS_Edition As String
        Private _SP_ID As String
        Private _ClientBarcode As String
        Private _BarcodeType As String
        Private _D_ID As String
        Private _D_Dep As String
        Private _BitAuto As Boolean

        ''進度跟
        Private _ID As String
        Private _Type As String
        Private _SO_SampleID As String
        Private _BarCode As String

        '2014-04-18  姚駿
        Private _CodeCount As String
        Private _SE_InTime As String
        Private _IntSecond As String




        Public Sub New()
            _AutoID = Nothing
            _Code_ID = Nothing
            _Qty = Nothing
            _StatusType = Nothing
            _StatusTypeName = Nothing
            _Remark = Nothing
            _PM_M_Code = Nothing

            _AddUserID = Nothing
            _AddDate = Nothing
            _AddUserName = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing

            _PM_Type = Nothing
            _SO_ID = Nothing
            _SS_Edition = Nothing
            _SP_ID = Nothing
            _ClientBarcode = Nothing
            _BarcodeType = Nothing
            _D_ID = Nothing
            _D_Dep = Nothing
            _BitAuto = Nothing

            _ID = Nothing
            _Type = Nothing
            _SO_SampleID = Nothing
            _BarCode = Nothing

            '2014-04-18  姚駿
            _CodeCount = Nothing
            _SE_InTime = Nothing
            _intSecond = Nothing



        End Sub
        Public Property BarCode() As String
            Get
                Return _BarCode
            End Get
            Set(ByVal value As String)
                _BarCode = value
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
        Public Property BitAuto() As Boolean
            Get
                Return _BitAuto
            End Get
            Set(ByVal value As Boolean)
                _BitAuto = value
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
        Public Property D_ID() As String
            Get
                Return _D_ID
            End Get
            Set(ByVal value As String)
                _D_ID = value
            End Set
        End Property
        Public Property ClientBarcode() As String
            Get
                Return _ClientBarcode
            End Get
            Set(ByVal value As String)
                _ClientBarcode = value
            End Set
        End Property
        Public Property BarcodeType() As String
            Get
                Return _BarcodeType
            End Get
            Set(ByVal value As String)
                _BarcodeType = value
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
        Public Property SP_ID() As String
            Get
                Return _SP_ID
            End Get
            Set(ByVal value As String)
                _SP_ID = value
            End Set
        End Property
        Public Property ID() As String
            Get
                Return _ID
            End Get
            Set(ByVal value As String)
                _ID = value
            End Set
        End Property


        Public Property Type() As String
            Get
                Return _Type
            End Get
            Set(ByVal value As String)
                _Type = value
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

        Public Property PM_M_Code() As String
            Get
                Return _PM_M_Code
            End Get
            Set(ByVal value As String)
                _PM_M_Code = value
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

        Public Property Code_ID() As String
            Get
                Return _Code_ID
            End Get
            Set(ByVal value As String)
                _Code_ID = value
            End Set
        End Property
        Public Property Qty() As Integer
            Get
                Return _Qty
            End Get
            Set(ByVal value As Integer)
                _Qty = value
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
        Public Property StatusTypeName() As String
            Get
                Return _StatusTypeName
            End Get
            Set(ByVal value As String)
                _StatusTypeName = value
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
        Public Property AddUserID() As String
            Get
                Return _AddUserID
            End Get
            Set(ByVal value As String)
                _AddUserID = value
            End Set
        End Property
        Public Property ModifyUserID() As String
            Get
                Return _ModifyUserID
            End Get
            Set(ByVal value As String)
                _ModifyUserID = value
            End Set
        End Property

        Public Property AddDate() As Date
            Get
                Return _AddDate
            End Get
            Set(ByVal value As Date)
                _AddDate = value
            End Set
        End Property
        Public Property AddUserName() As String
            Get
                Return _AddUserName
            End Get
            Set(ByVal value As String)
                _AddUserName = value
            End Set
        End Property
        Public Property ModifyDate() As Date
            Get
                Return _ModifyDate
            End Get
            Set(ByVal value As Date)
                _ModifyDate = value
            End Set
        End Property

        '2014-04-18  姚駿
        Public Property CodeCount() As String
            Get
                Return _CodeCount
            End Get
            Set(ByVal value As String)
                _CodeCount = value
            End Set
        End Property

        ''' <summary>
        ''' 收料確認時間
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property SE_InTime() As String
            Get
                Return _SE_InTime
            End Get
            Set(ByVal value As String)
                _SE_InTime = value
            End Set
        End Property

        Public Property IntSecond() As String
            Get
                Return _intSecond
            End Get
            Set(ByVal value As String)
                _intSecond = value
            End Set
        End Property



    End Class

End Namespace

