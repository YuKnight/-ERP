
Namespace LFERP.Library.NmetalSampleManager.NmetalSamplePace
    Public Class NmetalSamplePaceQueryInfo
        Private _SO_ID As String
        Private _SE_OutD_Dep As String
        Private _SE_OutPS_Name As String
        Private _SE_OutTime As String
        Private _SE_InD_Dep As String
        Private _SE_InPS_Name As String
        Private _SE_InTime As String
        Private _SE_InCheck As Boolean
        Private _SE_InCheckActionName As String
        Private _Code_ID As String
        Private _SE_OutCardIDName As String
        Private _SE_InCardIDName As String
        Private _SE_TypeName As String
        Private _SE_ID As String
        Private _SO_SampleID As String

        Private _OutQtying As Int16
        Private _InQtying As Int16
        Private _OutWeighing As Decimal
        Private _InWeighing As Decimal

        Private _OutQty As Integer
        Private _OutWeight As Decimal
        Private _InQty As Integer
        Private _InWeight As Decimal

        Private _OutEndQty As Int16
        Private _OutEndWeight As Decimal
        Private _OutWightChaYi As Decimal

        '2014-07-24  Mark 
        Private _D_ID As String
        Private _D_Dep As String
        Private _IWeight As Decimal
        Private _TWeight As Decimal
        Private _StatusType As String

        Private _PS_NO As String
        Private _PS_Name As String
        Private _PM_M_Code As String
        Private _SO_SampeleID As String
        Private _SE_Type As String

        Private _SE_InD_ID As String
        Private _SE_OutPS_NO As String
        Private _SE_OutD_ID As String
        Private _SE_InPS_NO As String
        Private _OutWeighingEnd As Decimal
        Private _StatusTypeName As String

 


        Public Sub New()
            _SO_ID = Nothing
            _SE_OutD_Dep = Nothing
            _SE_OutPS_Name = Nothing
            _SE_OutTime = Nothing
            _SE_InD_Dep = Nothing
            _SE_InPS_Name = Nothing
            _SE_InTime = Nothing
            _SE_InCheck = Nothing
            _SE_InCheckActionName = Nothing
            _Code_ID = Nothing
            _SE_OutCardIDName = Nothing
            _SE_InCardIDName = Nothing
            _SE_TypeName = Nothing
            _SE_ID = Nothing
            _SO_SampleID = Nothing

            _OutQtying = 0
            _InQtying = 0
            _OutWeighing = 0
            _InWeighing = 0

            _OutQty = 0
            _OutWeight = 0
            _InQty = 0
            _InWeight = 0

            _OutEndQty = 0
            _OutEndWeight = 0
            _OutWightChaYi = 0

            '2014-07-24 Mark
            _D_ID = Nothing
            _D_Dep = Nothing
            _IWeight = 0
            _TWeight = 0
            _StatusType = Nothing

            _PS_NO = Nothing
            _PS_Name = Nothing
            _PM_M_Code = Nothing
            _SO_SampeleID = Nothing
            _SE_Type = Nothing

            _SE_InD_ID = Nothing
            _SE_OutPS_NO = Nothing
            _SE_OutD_ID = Nothing
            _SE_InPS_NO = Nothing
            _OutWeighingEnd = 0

            _StatusTypeName = Nothing

        End Sub

        Public Property OutWightChaYi() As Decimal
            Get
                Return _OutWightChaYi
            End Get
            Set(ByVal value As Decimal)
                _OutWightChaYi = value
            End Set
        End Property


        Public Property OutEndWeight() As Decimal
            Get
                Return _OutEndWeight
            End Get
            Set(ByVal value As Decimal)
                _OutEndWeight = value
            End Set
        End Property


        Public Property OutEndQty() As Int16
            Get
                Return _OutEndQty
            End Get
            Set(ByVal value As Int16)
                _OutEndQty = value
            End Set
        End Property

        '------------------------------------------

        Public Property OutQty() As Integer
            Get
                Return _OutQty
            End Get
            Set(ByVal value As Integer)
                _OutQty = value
            End Set
        End Property

        Public Property OutWeight() As Decimal
            Get
                Return _OutWeight
            End Get
            Set(ByVal value As Decimal)
                _OutWeight = value
            End Set
        End Property

        Public Property InQty() As Integer
            Get
                Return _InQty
            End Get
            Set(ByVal value As Integer)
                _InQty = value
            End Set
        End Property


        Public Property InWeight() As Decimal
            Get
                Return _InWeight
            End Get
            Set(ByVal value As Decimal)
                _InWeight = value
            End Set
        End Property

        Public Property OutQtying() As Integer
            Get
                Return _OutQtying
            End Get
            Set(ByVal value As Integer)
                _OutQtying = value
            End Set
        End Property

        Public Property InQtying() As Integer
            Get
                Return _InQtying
            End Get
            Set(ByVal value As Integer)
                _InQtying = value
            End Set
        End Property

        Public Property InWeighing() As Decimal
            Get
                Return _InWeighing
            End Get
            Set(ByVal value As Decimal)
                _InWeighing = value
            End Set
        End Property

        Public Property OutWeighing() As Decimal
            Get
                Return _OutWeighing
            End Get
            Set(ByVal value As Decimal)
                _OutWeighing = value
            End Set
        End Property

        '------------------------------------------


        Public Property SO_SampleID() As String
            Get
                Return _SO_SampleID
            End Get
            Set(ByVal value As String)
                _SO_SampleID = value
            End Set
        End Property
        Public Property SE_ID() As String
            Get
                Return _SE_ID
            End Get
            Set(ByVal value As String)
                _SE_ID = value
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
        Public Property SE_InCardIDName() As String
            Get
                Return _SE_InCardIDName
            End Get
            Set(ByVal value As String)
                _SE_InCardIDName = value
            End Set
        End Property

        Public Property SE_OutCardIDName() As String
            Get
                Return _SE_OutCardIDName
            End Get
            Set(ByVal value As String)
                _SE_OutCardIDName = value
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
        Public Property SE_OutD_Dep() As String
            Get
                Return _SE_OutD_Dep
            End Get
            Set(ByVal value As String)
                _SE_OutD_Dep = value
            End Set
        End Property
        Public Property SE_OutPS_Name() As String
            Get
                Return _SE_OutPS_Name
            End Get
            Set(ByVal value As String)
                _SE_OutPS_Name = value
            End Set
        End Property
        Public Property SE_OutTime() As String
            Get
                Return _SE_OutTime
            End Get
            Set(ByVal value As String)
                _SE_OutTime = value
            End Set
        End Property
        Public Property SE_InD_Dep() As String
            Get
                Return _SE_InD_Dep
            End Get
            Set(ByVal value As String)
                _SE_InD_Dep = value
            End Set
        End Property
        Public Property SE_InPS_Name() As String
            Get
                Return _SE_InPS_Name
            End Get
            Set(ByVal value As String)
                _SE_InPS_Name = value
            End Set
        End Property

        Public Property SE_InTime() As String
            Get
                Return _SE_InTime
            End Get
            Set(ByVal value As String)
                _SE_InTime = value
            End Set
        End Property
        Public Property SE_InCheck() As Boolean
            Get
                Return _SE_InCheck
            End Get
            Set(ByVal value As Boolean)
                _SE_InCheck = value
            End Set
        End Property
        Public Property SE_InCheckActionName() As String
            Get
                Return _SE_InCheckActionName
            End Get
            Set(ByVal value As String)
                _SE_InCheckActionName = value
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

        '2014-04-24  Mark
        Public Property D_ID() As String
            Get
                Return _D_ID
            End Get
            Set(ByVal value As String)
                _D_ID = value
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

        Public Property IWeight() As Decimal
            Get
                Return _IWeight
            End Get
            Set(ByVal value As Decimal)
                _IWeight = value
            End Set
        End Property
        Public Property TWeight() As Decimal
            Get
                Return _TWeight
            End Get
            Set(ByVal value As Decimal)
                _TWeight = value
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
        Public Property PS_NO() As String
            Get
                Return _PS_NO
            End Get
            Set(ByVal value As String)
                _PS_NO = value
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
        Public Property PM_M_Code() As String
            Get
                Return _PM_M_Code
            End Get
            Set(ByVal value As String)
                _PM_M_Code = value
            End Set
        End Property

        Public Property SO_SampeleID() As String
            Get
                Return _SO_SampeleID
            End Get
            Set(ByVal value As String)
                _SO_SampeleID = value
            End Set
        End Property
        Public Property SE_Type() As String
            Get
                Return _SE_Type
            End Get
            Set(ByVal value As String)
                _SE_Type = value
            End Set
        End Property
        Public Property SE_InD_ID() As String
            Get
                Return _SE_InD_ID
            End Get
            Set(ByVal value As String)
                _SE_InD_ID = value
            End Set
        End Property
        Public Property SE_OutPS_NO() As String
            Get
                Return _SE_OutPS_NO
            End Get
            Set(ByVal value As String)
                _SE_OutPS_NO = value
            End Set
        End Property
        Public Property SE_OutD_ID() As String
            Get
                Return _SE_OutD_ID
            End Get
            Set(ByVal value As String)
                _SE_OutD_ID = value
            End Set
        End Property

        Public Property SE_InPS_NO() As String
            Get
                Return _SE_InPS_NO
            End Get
            Set(ByVal value As String)
                _SE_InPS_NO = value
            End Set
        End Property
        Public Property OutWeighingEnd() As Decimal
            Get
                Return _OutWeighingEnd
            End Get
            Set(ByVal value As Decimal)
                _OutWeighingEnd = value
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
    End Class
End Namespace