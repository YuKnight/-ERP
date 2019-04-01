Namespace LFERP.Library.MrpManager.MrpBomChange
    Public Class MrpBomChangeEntryInfo

        Private _AutoID As Decimal
        Private _ChangeOrderNo As String
        Private _EntryID As Int64
        Private _ChangeType As String
        Private _M_Code As String
        Private _PS_NO As String 
        Private _Mount As Int64
        Private _Tmrtc As Int64
        Private _UnitQty As Decimal
        Private _LossRate As Decimal
        Private _Remarks As String
        Private _Bom_Code As String
        Private _Bom_MID As Decimal

        Private _PS_Name As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _Bom_Name As String
        Private _Bom_Gauge As String
        Private _Bom_Unit As String
        Private _BomAddVersion As Boolean
        Private _BomVersion As String
        Private _AlterType As Integer
        Private _DisableTactic As Integer
        Private _ChangeTypeName As String
        Private _AlterTypeName As String
        Private _DisableTacticName As String

        Public Sub New()
            _AutoID = 0
            _ChangeOrderNo = Nothing
            _EntryID = 0
            _ChangeType = Nothing
            _M_Code = Nothing
            _PS_NO = Nothing 
            _Mount = 0
            _Tmrtc = 0
            _UnitQty = 0
            _LossRate = 0
            _Remarks = Nothing
            _Bom_Code = Nothing
            _Bom_MID = -1

            _PS_Name = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _Bom_Name = Nothing
            _Bom_Gauge = Nothing
            _Bom_Unit = Nothing
            _BomAddVersion = True
            _BomVersion = Nothing
            _AlterType = -1
            _DisableTactic = -1
            _ChangeTypeName = Nothing
            _AlterTypeName = Nothing
            _DisableTacticName = Nothing
        End Sub
       
        Public Property AutoID() As Decimal
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Decimal)
                _AutoID = value
            End Set
        End Property
        Public Property ChangeOrderNo() As String
            Get
                Return _ChangeOrderNo
            End Get
            Set(ByVal value As String)
                _ChangeOrderNo = value
            End Set
        End Property
        Public Property EntryID() As Int64
            Get
                Return _EntryID
            End Get
            Set(ByVal value As Int64)
                _EntryID = value
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
        Public Property M_Code() As String
            Get
                Return _M_Code
            End Get
            Set(ByVal value As String)
                _M_Code = value
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
        Public Property Mount() As Int64
            Get
                Return _Mount
            End Get
            Set(ByVal value As Int64)
                _Mount = value
            End Set
        End Property
        Public Property Tmrtc() As Int64
            Get
                Return _Tmrtc
            End Get
            Set(ByVal value As Int64)
                _Tmrtc = value
            End Set
        End Property
        Public Property UnitQty() As Decimal
            Get
                Return _UnitQty
            End Get
            Set(ByVal value As Decimal)
                _UnitQty = value
            End Set
        End Property
        Public Property LossRate() As Decimal
            Get
                Return _LossRate
            End Get
            Set(ByVal value As Decimal)
                _LossRate = value
            End Set
        End Property
        Public Property Remarks() As String
            Get
                Return _Remarks
            End Get
            Set(ByVal value As String)
                _Remarks = value
            End Set
        End Property
        Public Property Bom_Code() As String
            Get
                Return _Bom_Code
            End Get
            Set(ByVal value As String)
                _Bom_Code = value
            End Set
        End Property
        Public Property Bom_MID() As Decimal
            Get
                Return _Bom_MID
            End Get
            Set(ByVal value As Decimal)
                _Bom_MID = value
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
        Public Property M_Unit() As String
            Get
                Return _M_Unit
            End Get
            Set(ByVal value As String)
                _M_Unit = value
            End Set
        End Property

        Public Property Bom_Name() As String
            Get
                Return _Bom_Name
            End Get
            Set(ByVal value As String)
                _Bom_Name = value
            End Set
        End Property
        Public Property Bom_Gauge() As String
            Get
                Return _Bom_Gauge
            End Get
            Set(ByVal value As String)
                _Bom_Gauge = value
            End Set
        End Property
        Public Property Bom_Unit() As String
            Get
                Return _Bom_Unit
            End Get
            Set(ByVal value As String)
                _Bom_Unit = value
            End Set
        End Property
        Public Property BomAddVersion() As Boolean
            Get
                Return _BomAddVersion
            End Get
            Set(ByVal value As Boolean)
                _BomAddVersion = value
            End Set
        End Property

        Public Property BomVersion() As String
            Get
                Return _BomVersion
            End Get
            Set(ByVal value As String)
                _BomVersion = value
            End Set
        End Property

        Public Property AlterType() As Integer
            Get
                Return _AlterType
            End Get
            Set(ByVal value As Integer)
                _AlterType = value
            End Set
        End Property
        Public Property DisableTactic() As Integer
            Get
                Return _DisableTactic
            End Get
            Set(ByVal value As Integer)
                _DisableTactic = value
            End Set
        End Property
        Public Property ChangeTypeName() As String
            Get
                Return _ChangeTypeName
            End Get
            Set(ByVal value As String)
                _ChangeTypeName = value
            End Set
        End Property
        Public Property AlterTypeName() As String
            Get
                Return _AlterTypeName
            End Get
            Set(ByVal value As String)
                _AlterTypeName = value
            End Set
        End Property
        Public Property DisableTacticName() As String
            Get
                Return _DisableTacticName
            End Get
            Set(ByVal value As String)
                _DisableTacticName = value
            End Set
        End Property
    End Class
End Namespace