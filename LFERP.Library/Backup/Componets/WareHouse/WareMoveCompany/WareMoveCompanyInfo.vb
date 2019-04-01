Namespace LFERP.Library.WareHouse.WareMoveCompany
    Public Class WareMoveCompanyInfo

        Private _AutoID As String
        Private _MC_Num As String
        Private _MC_NO As String
        Private _MC_OUT_Company As String
        Private _MC_OUT_WHID As String

        Private _MC_IN_Company As String
        Private _MC_IN_WHID As String
        Private _M_Code As String
        Private _MC_Qty As Double
        Private _MC_AddAction As String

        Private _MC_AddActionName As String
        Private _MC_AddDate As String
        Private _MC_Remark As String
        Private _MC_Check As Boolean
        Private _MC_CheckAction As String

        Private _MC_CheckActionName As String
        Private _MC_CheckDate As String
        Private _MC_CheckRemark As String
        Private _MC_InCheck As Boolean
        Private _MC_InAction As String

        Private _MC_InActionName As String
        Private _MC_InDate As String
        Private _MC_InRemark As String
        Private _MC_OUT_EndQty As Double
        Private _MC_IN_EndQty As Double

        Private _MC_OUT_WHName As String
        Private _MC_IN_WHName As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String

        Private _ServerIP As String
        Private _DataBaseName As String
        Private _UserID As String
        Private _PassWord As String

        '2014-04-01    ダ�@
        Private _WTypeID As String
        Private _WTypeName As String

        Private _MC_Type As String


        Public Sub New()

            _AutoID = Nothing
            _MC_Num = Nothing
            _MC_NO = Nothing
            _MC_OUT_Company = Nothing
            _MC_OUT_WHID = Nothing

            _MC_IN_Company = Nothing
            _MC_IN_WHID = Nothing
            _M_Code = Nothing
            _MC_Qty = 0
            _MC_AddAction = Nothing

            _MC_AddActionName = Nothing
            _MC_AddDate = Nothing
            _MC_Remark = Nothing
            _MC_Check = False
            _MC_CheckAction = Nothing

            _MC_CheckActionName = Nothing
            _MC_CheckDate = Nothing
            _MC_CheckRemark = Nothing
            _MC_InCheck = False
            _MC_InAction = Nothing

            _MC_InActionName = Nothing
            _MC_InDate = Nothing
            _MC_InRemark = Nothing
            _MC_OUT_EndQty = 0
            _MC_IN_EndQty = 0

            _MC_OUT_WHName = Nothing
            _MC_IN_WHName = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing

            _M_Unit = Nothing

            _ServerIP = Nothing
            _DataBaseName = Nothing
            _UserID = Nothing
            _PassWord = Nothing


            '2014-04-01    ダ�@
            _WTypeID = Nothing
            _WTypeName = Nothing
            _MC_Type = Nothing

        End Sub

        Public Property M_Unit() As String
            Get
                Return _M_Unit
            End Get
            Set(ByVal value As String)
                _M_Unit = value
            End Set
        End Property


        Public Property ServerIP() As String
            Get
                Return _ServerIP
            End Get
            Set(ByVal value As String)
                _ServerIP = value
            End Set
        End Property

        Public Property UserID() As String
            Get
                Return _UserID
            End Get
            Set(ByVal value As String)
                _UserID = value
            End Set
        End Property


        Public Property DataBaseName() As String
            Get
                Return _DataBaseName
            End Get
            Set(ByVal value As String)
                _DataBaseName = value
            End Set
        End Property


        Public Property PassWord() As String
            Get
                Return _PassWord
            End Get
            Set(ByVal value As String)
                _PassWord = value
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

        Public Property MC_Num() As String
            Get
                Return _MC_Num
            End Get
            Set(ByVal value As String)
                _MC_Num = value
            End Set
        End Property


        Public Property MC_NO() As String
            Get
                Return _MC_NO
            End Get
            Set(ByVal value As String)
                _MC_NO = value
            End Set
        End Property

        Public Property MC_OUT_Company() As String
            Get
                Return _MC_OUT_Company
            End Get
            Set(ByVal value As String)
                _MC_OUT_Company = value
            End Set
        End Property

        Public Property MC_OUT_WHID() As String
            Get
                Return _MC_OUT_WHID
            End Get
            Set(ByVal value As String)
                _MC_OUT_WHID = value
            End Set
        End Property
        '---------------------------------------------------
        Public Property MC_IN_Company() As String
            Get
                Return _MC_IN_Company
            End Get
            Set(ByVal value As String)
                _MC_IN_Company = value
            End Set
        End Property

        Public Property MC_IN_WHID() As String
            Get
                Return _MC_IN_WHID
            End Get
            Set(ByVal value As String)
                _MC_IN_WHID = value
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

        Public Property MC_Qty() As Double
            Get
                Return _MC_Qty
            End Get
            Set(ByVal value As Double)
                _MC_Qty = value
            End Set
        End Property


        Public Property MC_AddAction() As String
            Get
                Return _MC_AddAction
            End Get
            Set(ByVal value As String)
                _MC_AddAction = value
            End Set
        End Property

        '-------------------------------------------------------------------------
        Public Property MC_AddActionName() As String
            Get
                Return _MC_AddActionName
            End Get
            Set(ByVal value As String)
                _MC_AddActionName = value
            End Set
        End Property


        Public Property MC_AddDate() As String
            Get
                Return _MC_AddDate
            End Get
            Set(ByVal value As String)
                _MC_AddDate = value
            End Set
        End Property

        Public Property MC_Remark() As String
            Get
                Return _MC_Remark
            End Get
            Set(ByVal value As String)
                _MC_Remark = value
            End Set
        End Property

        Public Property MC_Check() As Boolean
            Get
                Return _MC_Check
            End Get
            Set(ByVal value As Boolean)
                _MC_Check = value
            End Set
        End Property


        Public Property MC_CheckAction() As String
            Get
                Return _MC_CheckAction
            End Get
            Set(ByVal value As String)
                _MC_CheckAction = value
            End Set
        End Property
        '------------------------------------------

        Public Property MC_CheckActionName() As String
            Get
                Return _MC_CheckActionName
            End Get
            Set(ByVal value As String)
                _MC_CheckActionName = value
            End Set
        End Property


        Public Property MC_CheckDate() As String
            Get
                Return _MC_CheckDate
            End Get
            Set(ByVal value As String)
                _MC_CheckDate = value
            End Set
        End Property


        Public Property MC_CheckRemark() As String
            Get
                Return _MC_CheckRemark
            End Get
            Set(ByVal value As String)
                _MC_CheckRemark = value
            End Set
        End Property


        Public Property MC_InCheck() As Boolean
            Get
                Return _MC_InCheck
            End Get
            Set(ByVal value As Boolean)
                _MC_InCheck = value
            End Set
        End Property

        Public Property MC_InAction() As String
            Get
                Return _MC_InAction
            End Get
            Set(ByVal value As String)
                _MC_InAction = value
            End Set
        End Property
        '------------------------------------------
        Public Property MC_InActionName() As String
            Get
                Return _MC_InActionName
            End Get
            Set(ByVal value As String)
                _MC_InActionName = value
            End Set
        End Property

        Public Property MC_InDate() As String
            Get
                Return _MC_InDate
            End Get
            Set(ByVal value As String)
                _MC_InDate = value
            End Set
        End Property

        Public Property MC_InRemark() As String
            Get
                Return _MC_InRemark
            End Get
            Set(ByVal value As String)
                _MC_InRemark = value
            End Set
        End Property

        Public Property MC_OUT_EndQty() As Double
            Get
                Return _MC_OUT_EndQty
            End Get
            Set(ByVal value As Double)
                _MC_OUT_EndQty = value
            End Set
        End Property

        Public Property MC_IN_EndQty() As Double
            Get
                Return _MC_IN_EndQty
            End Get
            Set(ByVal value As Double)
                _MC_IN_EndQty = value
            End Set
        End Property

        Public Property MC_OUT_WHName() As String
            Get
                Return _MC_OUT_WHName
            End Get
            Set(ByVal value As String)
                _MC_OUT_WHName = value
            End Set
        End Property

        Public Property MC_IN_WHName() As String
            Get
                Return _MC_IN_WHName
            End Get
            Set(ByVal value As String)
                _MC_IN_WHName = value
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

        '2014-04-01  ダ�@
        Public Property WTypeID() As String
            Get
                Return _WTypeID
            End Get
            Set(ByVal value As String)
                _WTypeID = value
            End Set
        End Property

        '2014-04-01  ダ�@
        Public Property WTypeName() As String
            Get
                Return _WTypeName
            End Get
            Set(ByVal value As String)
                _WTypeName = value
            End Set
        End Property

        '2014-04-01  ダ�@
        Public Property MC_Type() As String
            Get
                Return _MC_Type
            End Get
            Set(ByVal value As String)
                _MC_Type = value
            End Set
        End Property


    End Class
End Namespace
