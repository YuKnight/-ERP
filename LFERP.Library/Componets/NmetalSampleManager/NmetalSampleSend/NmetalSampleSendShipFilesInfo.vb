Namespace LFERP.Library.NmetalSampleManager.NmetalSampleSend
    Public Class NmetalSampleSendShipFilesInfo
        Private _AutoID As Double
        Private _SP_ID As String
        Private _SP_Qty As Integer
        Private _PM_M_Code As String
        Private _BoxID As String
        Private _PartName As String
        Private _PalletID As String
        Private _Weighing As Double
        Private _AddUserID As String
        Private _AddDate As Date
        Private _ModifyUserID As String
        Private _ModifyDate As Date
        Private _CO_ID As String
        Private _CheckBit As Boolean
        Private _CheckDate As Date
        Private _CheckRemark As String
        Private _Code_ID As String
        Private _LC As String
        Private _QPN As String
        Private _Addressee As String
        Private _Project As String
        Private _Handle As String
        Private _SP_CusterID As String
        Private _SP_SendDate As Date
        Sub New()
            _AutoID = 0
            _SP_ID = Nothing
            _SP_Qty = 0
            _BoxID = Nothing
            _PartName = Nothing
            _PalletID = Nothing
            _Weighing = Nothing
            _AddUserID = Nothing
            _AddDate = Nothing
            _ModifyUserID = Nothing
            _ModifyDate = Nothing
            _CO_ID = Nothing
            _CheckBit = Nothing
            _CheckDate = Nothing
            _CheckRemark = Nothing
            _PM_M_Code = Nothing
            _Code_ID = Nothing
            _LC = Nothing
            _QPN = Nothing
            _Addressee = Nothing
            _Project = Nothing
            _Handle = Nothing
            _SP_CusterID = Nothing
            _SP_SendDate = Nothing
        End Sub
        Public Property SP_SendDate() As Date
            Get
                Return _SP_SendDate
            End Get
            Set(ByVal value As Date)
                _SP_SendDate = value
            End Set
        End Property
        Public Property SP_CusterID() As String
            Get
                Return _SP_CusterID
            End Get
            Set(ByVal value As String)
                _SP_CusterID = value
            End Set
        End Property
        Public Property Addressee() As String
            Get
                Return _Addressee
            End Get
            Set(ByVal value As String)
                _Addressee = value
            End Set
        End Property
        Public Property Project() As String
            Get
                Return _Project
            End Get
            Set(ByVal value As String)
                _Project = value
            End Set
        End Property
        Public Property Handle() As String
            Get
                Return _Handle
            End Get
            Set(ByVal value As String)
                _Handle = value
            End Set
        End Property
        Public Property QPN() As String
            Get
                Return _QPN
            End Get
            Set(ByVal value As String)
                _QPN = value
            End Set
        End Property
        Public Property LC() As String
            Get
                Return _LC
            End Get
            Set(ByVal value As String)
                _LC = value
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
        Public Property AutoID() As Double
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Double)
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
        Public Property SP_Qty() As Integer
            Get
                Return _SP_Qty
            End Get
            Set(ByVal value As Integer)
                _SP_Qty = value
            End Set
        End Property

        Public Property BoxID() As String
            Get
                Return _BoxID
            End Get
            Set(ByVal value As String)
                _BoxID = value
            End Set
        End Property
        Public Property PartName() As String
            Get
                Return _PartName
            End Get
            Set(ByVal value As String)
                _PartName = value
            End Set
        End Property
        Public Property PalletID() As String
            Get
                Return _PalletID
            End Get
            Set(ByVal value As String)
                _PalletID = value
            End Set
        End Property
        Public Property Weighing() As Double
            Get
                Return _Weighing
            End Get
            Set(ByVal value As Double)
                _Weighing = value
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
        Public Property AddDate() As Date
            Get
                Return _AddDate
            End Get
            Set(ByVal value As Date)
                _AddDate = value
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
        Public Property ModifyDate() As Date
            Get
                Return _ModifyDate
            End Get
            Set(ByVal value As Date)
                _ModifyDate = value
            End Set
        End Property
        Public Property CO_ID() As String
            Get
                Return _CO_ID
            End Get
            Set(ByVal value As String)
                _CO_ID = value
            End Set
        End Property
        Public Property CheckBit() As String
            Get
                Return _CheckBit
            End Get
            Set(ByVal value As String)
                _CheckBit = value
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

    End Class
End Namespace