
Namespace LFERP.Library.Production.ProductionFieldReturnMaterial
    Public Class ProductionFieldReturnMaterialInfo
        Private _AutoID As String
        Private _R_NO As String
        Private _Pro_Type As String
        Private _PM_M_Code As String
        Private _PM_Type As String

        Private _DepID As String
        Private _PS_NO As String

        Private _RQty As Int32
        Private _RWeight As Double
        Private _WH_ID As String
        Private _M_Code As String
        Private _RDate As String

        Private _RAction As String
        Private _RRemark As String
        Private _RCheck As Boolean
        Private _RCheckDate As String
        Private _RCheckAction As String

        Private _RCheckReamrk As String
        Private _RInCheck As Boolean
        Private _RIncheckDate As String
        Private _RIncheckAction As String
        Private _RIncheckRemark As String

        Private _EndRQty As Int32
        Private _EndRWeight As Double

        '---------------------------------------------------
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String
        Private _WH_Name As String
        Private _WH_PName As String

        Private _RActionName As String
        Private _RCheckActionName As String
        Private _RIncheckActionName As String
        Private _PS_Name As String
        Private _DepName As String

        Private _FP_NO As String
        Private _FP_Num As String
        Private _TuiLiao As Int16
        Private _EndRQty1 As Int16

        Sub New()
           
            _AutoID = Nothing
            _R_NO = Nothing
            _Pro_Type = Nothing
            _PM_M_Code = Nothing
            _PM_Type = Nothing

            _DepID = Nothing
            _PS_NO = Nothing

            _RQty = 0
            _RWeight = 0
            _WH_ID = Nothing
            _M_Code = Nothing
            _RDate = Nothing

            _RAction = Nothing
            _RRemark = Nothing
            _RCheck = False
            _RCheckDate = Nothing
            _RCheckAction = Nothing

            _RCheckReamrk = Nothing
            _RInCheck = False
            _RIncheckDate = Nothing
            _RIncheckAction = Nothing
            _RIncheckRemark = Nothing

            _EndRQty = 0
            _EndRWeight = 0

            '---------------------------------------------------
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing
            _WH_Name = Nothing
            _WH_PName = Nothing

            _RActionName = Nothing
            _RCheckActionName = Nothing
            _RIncheckActionName = Nothing
            _PS_Name = Nothing
            _DepName = Nothing


            _FP_NO = Nothing
            _FP_Num = Nothing
            _TuiLiao = 0
            _EndRQty1 = 0

        End Sub

        Public Property EndRQty1() As Int16
            Get
                Return _EndRQty1
            End Get
            Set(ByVal value As Int16)
                _EndRQty1 = value
            End Set
        End Property

        Public Property FP_NO() As String
            Get
                Return _FP_NO
            End Get
            Set(ByVal value As String)
                _FP_NO = value
            End Set
        End Property


        Public Property FP_Num() As String
            Get
                Return _FP_Num
            End Get
            Set(ByVal value As String)
                _FP_Num = value
            End Set
        End Property

        Public Property TuiLiao() As Int16
            Get
                Return _TuiLiao
            End Get
            Set(ByVal value As Int16)
                _TuiLiao = value
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

        Public Property R_NO() As String
            Get
                Return _R_NO
            End Get
            Set(ByVal value As String)
                _R_NO = value
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

        Public Property DepID() As String
            Get
                Return _DepID
            End Get
            Set(ByVal value As String)
                _DepID = value
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




        Public Property RQty() As Int32
            Get
                Return _RQty
            End Get
            Set(ByVal value As Int32)
                _RQty = value
            End Set
        End Property



        Public Property RWeight() As Double
            Get
                Return _RWeight
            End Get
            Set(ByVal value As Double)
                _RWeight = value
            End Set
        End Property


        Public Property WH_ID() As String
            Get
                Return _WH_ID
            End Get
            Set(ByVal value As String)
                _WH_ID = value
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


        Public Property RDate() As String
            Get
                Return _RDate
            End Get
            Set(ByVal value As String)
                _RDate = value
            End Set
        End Property


        Public Property RAction() As String
            Get
                Return _RAction
            End Get
            Set(ByVal value As String)
                _RAction = value
            End Set
        End Property


        Public Property RRemark() As String
            Get
                Return _RRemark
            End Get
            Set(ByVal value As String)
                _RRemark = value
            End Set
        End Property


        Public Property RCheck() As Boolean
            Get
                Return _RCheck
            End Get
            Set(ByVal value As Boolean)
                _RCheck = value
            End Set
        End Property

        Public Property RCheckDate() As String
            Get
                Return _RCheckDate
            End Get
            Set(ByVal value As String)
                _RCheckDate = value
            End Set
        End Property


        Public Property RCheckAction() As String
            Get
                Return _RCheckAction
            End Get
            Set(ByVal value As String)
                _RCheckAction = value
            End Set
        End Property


        Public Property RCheckReamrk() As String
            Get
                Return _RCheckReamrk
            End Get
            Set(ByVal value As String)
                _RCheckReamrk = value
            End Set
        End Property


        Public Property RInCheck() As Boolean
            Get
                Return _RInCheck
            End Get
            Set(ByVal value As Boolean)
                _RInCheck = value
            End Set
        End Property


        Public Property RIncheckDate() As String
            Get
                Return _RIncheckDate
            End Get
            Set(ByVal value As String)
                _RIncheckDate = value
            End Set
        End Property


        Public Property RIncheckAction() As String
            Get
                Return _RIncheckAction
            End Get
            Set(ByVal value As String)
                _RIncheckAction = value
            End Set
        End Property

        Public Property RIncheckRemark() As String
            Get
                Return _RIncheckRemark
            End Get
            Set(ByVal value As String)
                _RIncheckRemark = value
            End Set
        End Property

        Public Property EndRQty() As Int32
            Get
                Return _EndRQty
            End Get
            Set(ByVal value As Int32)
                _EndRQty = value
            End Set
        End Property

        Public Property EndRWeight() As Double
            Get
                Return _EndRWeight
            End Get
            Set(ByVal value As Double)
                _EndRWeight = value
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

        Public Property WH_Name() As String
            Get
                Return _WH_Name
            End Get
            Set(ByVal value As String)
                _WH_Name = value
            End Set
        End Property


        Public Property WH_PName() As String
            Get
                Return _WH_PName
            End Get
            Set(ByVal value As String)
                _WH_PName = value
            End Set
        End Property


        Public Property RActionName() As String
            Get
                Return _RActionName
            End Get
            Set(ByVal value As String)
                _RActionName = value
            End Set
        End Property


        Public Property RCheckActionName() As String
            Get
                Return _RCheckActionName
            End Get
            Set(ByVal value As String)
                _RCheckActionName = value
            End Set
        End Property


        Public Property RIncheckActionName() As String
            Get
                Return _RIncheckActionName
            End Get
            Set(ByVal value As String)
                _RIncheckActionName = value
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



        Public Property DepName() As String
            Get
                Return _DepName
            End Get
            Set(ByVal value As String)
                _DepName = value
            End Set
        End Property




    End Class
End Namespace
