Namespace LFERP.Library.MrpManager.BomPartReplace
    Public Class BomPartReplaceInfo

        Private _AutoID As Decimal
        Private _PartReplaceNumber As String
        Private _OldPartNumber As String
        Private _OldPart_M_Name As String
        Private _OldPart_M_Gauge As String
        Private _OldPart_M_Unit As String
        Private _OldPart_SoureName As String
        '------------------------
        Private _NewPartNumber As String
        Private _NewPart_M_Name As String
        Private _NewPart_M_Gauge As String
        Private _NewPart_M_Unit As String
        Private _NewPart_SoureName As String
        '-----------------------------
        Private _TwoWayReplace As Boolean
        Private _EffectiveDate As String
        Private _BOMNumber As String
        Private _BOMAutoID As Decimal
        Private _OldQty As Decimal
        Private _NewQty As Decimal
        Private _Status As Boolean
        Private _Percentage As Decimal
        Private _Remark As String
        Private _CreateUserID As String
        Private _CreateUserName As String
        Private _CreateDate As String
        Private _ModifyUserID As String
        Private _ModifyUserName As String
        Private _ModifyDate As String
        '-------------------------------
        Private _CheckBit As Boolean
        Private _CheckUserID As String
        Private _CheckUserName As String
        Private _CheckDate As String
        Private _CheckRemark As String
        Public Sub New()
            _AutoID = 0
            _PartReplaceNumber = Nothing
            _OldPartNumber = Nothing
            _OldPart_M_Name = Nothing
            _OldPart_M_Gauge = Nothing
            _OldPart_M_Unit = Nothing
            _OldPart_SoureName = Nothing
            '---------------------
            _NewPartNumber = Nothing
            _NewPart_M_Name = Nothing
            _NewPart_M_Gauge = Nothing
            _NewPart_M_Unit = Nothing
            _NewPart_SoureName = Nothing
            '--------------------
            _TwoWayReplace = False
            _EffectiveDate = Nothing
            _BOMNumber = Nothing
            _BOMAutoID = Nothing
            _OldQty = 0
            _NewQty = 0
            _Status = False
            _Percentage = Nothing
            _Remark = Nothing
            _CreateUserID = Nothing
            _CreateUserName = Nothing
            _CreateDate = Nothing
            _ModifyUserID = Nothing
            _ModifyUserName = Nothing
            _ModifyDate = Nothing
            '------------------
            _CheckBit = False
            _CheckUserID = Nothing
            _CheckUserName = Nothing
            _CheckDate = Nothing
            _CheckRemark = Nothing

        End Sub
        Public Property AutoID() As Decimal
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Decimal)
                _AutoID = value
            End Set
        End Property
        Public Property PartReplaceNumber() As String
            Get
                Return _PartReplaceNumber
            End Get
            Set(ByVal value As String)
                _PartReplaceNumber = value
            End Set
        End Property
        Public Property OldPartNumber() As String
            Get
                Return _OldPartNumber
            End Get
            Set(ByVal value As String)
                _OldPartNumber = value
            End Set
        End Property
        Public Property OldPart_M_Name() As String
            Get
                Return _OldPart_M_Name
            End Get
            Set(ByVal value As String)
                _OldPart_M_Name = value
            End Set
        End Property
        Public Property OldPart_M_Gauge() As String
            Get
                Return _OldPart_M_Gauge
            End Get
            Set(ByVal value As String)
                _OldPart_M_Gauge = value
            End Set
        End Property
        Public Property OldPart_M_Unit() As String
            Get
                Return _OldPart_M_Unit
            End Get
            Set(ByVal value As String)
                _OldPart_M_Unit = value
            End Set
        End Property
        Public Property OldPart_SoureName() As String
            Get
                Return _OldPart_SoureName
            End Get
            Set(ByVal value As String)
                _OldPart_SoureName = value
            End Set
        End Property
        Public Property NewPartNumber() As String
            Get
                Return _NewPartNumber
            End Get
            Set(ByVal value As String)
                _NewPartNumber = value
            End Set
        End Property
        Public Property NewPart_M_Name() As String
            Get
                Return _NewPart_M_Name
            End Get
            Set(ByVal value As String)
                _NewPart_M_Name = value
            End Set
        End Property
        Public Property NewPart_M_Gauge() As String
            Get
                Return _NewPart_M_Gauge
            End Get
            Set(ByVal value As String)
                _NewPart_M_Gauge = value
            End Set
        End Property
        Public Property NewPart_M_Unit() As String
            Get
                Return _NewPart_M_Unit
            End Get
            Set(ByVal value As String)
                _NewPart_M_Unit = value
            End Set
        End Property
        Public Property NewPart_SoureName() As String
            Get
                Return _NewPart_SoureName
            End Get
            Set(ByVal value As String)
                _NewPart_SoureName = value
            End Set
        End Property
        Public Property TwoWayReplace() As Boolean
            Get
                Return _TwoWayReplace
            End Get
            Set(ByVal value As Boolean)
                _TwoWayReplace = value
            End Set
        End Property
        Public Property EffectiveDate() As String
            Get
                Return _EffectiveDate
            End Get
            Set(ByVal value As String)
                _EffectiveDate = value
            End Set
        End Property
        Public Property BOMNumber() As String
            Get
                Return _BOMNumber
            End Get
            Set(ByVal value As String)
                _BOMNumber = value
            End Set
        End Property
        Public Property BOMAutoID() As Decimal
            Get
                Return _BOMAutoID
            End Get
            Set(ByVal value As Decimal)
                _BOMAutoID = value
            End Set
        End Property
        Public Property OldQty() As Decimal
            Get
                Return _OldQty
            End Get
            Set(ByVal value As Decimal)
                _OldQty = value
            End Set
        End Property
        Public Property NewQty() As Decimal
            Get
                Return _NewQty
            End Get
            Set(ByVal value As Decimal)
                _NewQty = value
            End Set
        End Property
        Public Property Status() As Boolean
            Get
                Return _Status
            End Get
            Set(ByVal value As Boolean)
                _Status = value
            End Set
        End Property
        Public Property Percentage() As Decimal
            Get
                Return _Percentage
            End Get
            Set(ByVal value As Decimal)
                _Percentage = value
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
        Public Property CreateUserID() As String
            Get
                Return _CreateUserID
            End Get
            Set(ByVal value As String)
                _CreateUserID = value
            End Set
        End Property
        Public Property ModifyUserName() As String
            Get
                Return _ModifyUserName
            End Get
            Set(ByVal value As String)
                _ModifyUserName = value
            End Set
        End Property
        Public Property CreateDate() As String
            Get
                Return _CreateDate
            End Get
            Set(ByVal value As String)
                _CreateDate = value
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
        Public Property CreateUserName() As String
            Get
                Return _CreateUserName
            End Get
            Set(ByVal value As String)
                _CreateUserName = value
            End Set
        End Property
        Public Property ModifyDate() As String
            Get
                Return _ModifyDate
            End Get
            Set(ByVal value As String)
                _ModifyDate = value
            End Set
        End Property
        '----------------------
        Public Property CheckBit() As Boolean
            Get
                Return _CheckBit
            End Get
            Set(ByVal value As Boolean)
                _CheckBit = value
            End Set
        End Property

        Public Property CheckUserName() As String
            Get
                Return _CheckUserName
            End Get
            Set(ByVal value As String)
                _CheckUserName = value
            End Set
        End Property
        Public Property CheckDate() As String
            Get
                Return _CheckDate
            End Get
            Set(ByVal value As String)
                _CheckDate = value
            End Set
        End Property
        Public Property CheckUserID() As String
            Get
                Return _CheckUserID
            End Get
            Set(ByVal value As String)
                _CheckUserID = value
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