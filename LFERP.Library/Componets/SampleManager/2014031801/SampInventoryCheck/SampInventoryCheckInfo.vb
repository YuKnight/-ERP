

Namespace LFERP.Library.SampleManager.SampInventoryCheck
    Public Class SampInventoryCheckInfo
        Private _AutoID As String
        Private _CheckNO As String
        Private _Code_ID As String
        Private _Qty As Int32
        Private _CheckDate As Date

        Private _CheckAction As String
        Private _CheckActionName As String

        Private _Remark As String

        Private _CCheck As Boolean
        Private _CCheckAction As String
        Private _CCheckDate As Date
        Private _CCheckActionName As String

        Private _AnalysisCheck As Boolean
        Private _AnalysisAction As String
        Private _AnalysisDate As Date
        Private _AnalysisActionName As String

        Private _Status As String

        Private _InVentQty As Int32
        Private _QtyReal As Int32
        Private _D_ID As String
        Private _D_Dep As String

        ''¥[ªì¨Ï¤Æ
        Private _OutD_ID As String
        Private _InD_ID As String
        Private _OutPS_NO As String
        Private _InPS_NO As String
        Private _AddDate As Date
        Private _AddAction As String

        Private _OutD_ID_Name As String
        Private _InD_ID_Name As String
        Private _OutPS_Name As String
        Private _InPS_Name As String
        Private _AddActionName As String

        Public Sub New()
            _AutoID = Nothing
            _CheckNO = Nothing
            _Code_ID = Nothing
            _Qty = 0
            _CheckDate = Nothing

            _CheckAction = Nothing
            _CheckActionName = Nothing
            _CCheckActionName = Nothing

            _AnalysisCheck = Nothing
            _AnalysisDate = Nothing
            _AnalysisAction = Nothing
            _AnalysisActionName = Nothing

            _Remark = Nothing

            _CCheck = False
            _CCheckAction = Nothing
            _CCheckDate = Nothing

            _Status = Nothing
            _InVentQty = 0
            _QtyReal = 0
            _D_ID = Nothing
            _D_Dep = Nothing


            _OutD_ID = Nothing
            _InD_ID = Nothing
            _OutPS_NO = Nothing
            _InPS_NO = Nothing
            _AddDate = Nothing
            _AddAction = Nothing

            _OutD_ID_Name = Nothing
            _InD_ID_Name = Nothing
            _OutPS_Name = Nothing
            _InPS_Name = Nothing
            _AddActionName = Nothing

        End Sub


        Public Property OutD_ID() As String
            Get
                Return _OutD_ID
            End Get
            Set(ByVal value As String)
                _OutD_ID = value
            End Set
        End Property


        Public Property InD_ID() As String
            Get
                Return _InD_ID
            End Get
            Set(ByVal value As String)
                _InD_ID = value
            End Set
        End Property

        Public Property OutPS_NO() As String
            Get
                Return _OutPS_NO
            End Get
            Set(ByVal value As String)
                _OutPS_NO = value
            End Set
        End Property


        Public Property InPS_NO() As String
            Get
                Return _InPS_NO
            End Get
            Set(ByVal value As String)
                _InPS_NO = value
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


        Public Property AddAction() As String
            Get
                Return _AddAction
            End Get
            Set(ByVal value As String)
                _AddAction = value
            End Set
        End Property


        Public Property OutD_ID_Name() As String
            Get
                Return _OutD_ID_Name
            End Get
            Set(ByVal value As String)
                _OutD_ID_Name = value
            End Set
        End Property


        Public Property InD_ID_Name() As String
            Get
                Return _InD_ID_Name
            End Get
            Set(ByVal value As String)
                _InD_ID_Name = value
            End Set
        End Property


        Public Property OutPS_Name() As String
            Get
                Return _OutPS_Name
            End Get
            Set(ByVal value As String)
                _OutPS_Name = value
            End Set
        End Property

        Public Property InPS_Name() As String
            Get
                Return _InPS_Name
            End Get
            Set(ByVal value As String)
                _InPS_Name = value
            End Set
        End Property


        Public Property AddActionName() As String
            Get
                Return _AddActionName
            End Get
            Set(ByVal value As String)
                _AddActionName = value
            End Set
        End Property

        '--------------------------------------------------------------------



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
        Public Property AnalysisDate() As Date
            Get
                Return _AnalysisDate
            End Get
            Set(ByVal value As Date)
                _AnalysisDate = value
            End Set
        End Property

        Public Property AnalysisCheck() As Boolean
            Get
                Return _AnalysisCheck
            End Get
            Set(ByVal value As Boolean)
                _AnalysisCheck = value
            End Set
        End Property
        Public Property AnalysisAction() As String
            Get
                Return _AnalysisAction
            End Get
            Set(ByVal value As String)
                _AnalysisAction = value
            End Set
        End Property
        Public Property AnalysisActionName() As String
            Get
                Return _AnalysisActionName
            End Get
            Set(ByVal value As String)
                _AnalysisActionName = value
            End Set
        End Property
        Public Property Status() As String
            Get
                Return _Status
            End Get
            Set(ByVal value As String)
                _Status = value
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

        Public Property CheckNO() As String
            Get
                Return _CheckNO
            End Get
            Set(ByVal value As String)
                _CheckNO = value
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

        Public Property Qty() As Int32
            Get
                Return _Qty
            End Get
            Set(ByVal value As Int32)
                _Qty = value
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

        Public Property CheckAction() As String
            Get
                Return _CheckAction
            End Get
            Set(ByVal value As String)
                _CheckAction = value
            End Set
        End Property

        Public Property CheckActionName() As String
            Get
                Return _CheckActionName
            End Get
            Set(ByVal value As String)
                _CheckActionName = value
            End Set
        End Property

        Public Property CCheckActionName() As String
            Get
                Return _CCheckActionName
            End Get
            Set(ByVal value As String)
                _CCheckActionName = value
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

        Public Property CCheck() As Boolean
            Get
                Return _CCheck
            End Get
            Set(ByVal value As Boolean)
                _CCheck = value
            End Set
        End Property

        Public Property CCheckAction() As String
            Get
                Return _CCheckAction
            End Get
            Set(ByVal value As String)
                _CCheckAction = value
            End Set
        End Property

        Public Property CCheckDate() As Date
            Get
                Return _CCheckDate
            End Get
            Set(ByVal value As Date)
                _CCheckDate = value
            End Set
        End Property

        Public Property InVentQty() As Int32
            Get
                Return _InVentQty
            End Get
            Set(ByVal value As Int32)
                _InVentQty = value
            End Set
        End Property

        Public Property QtyReal() As Int32
            Get
                Return _QtyReal
            End Get
            Set(ByVal value As Int32)
                _QtyReal = value
            End Set
        End Property



    End Class
End Namespace
