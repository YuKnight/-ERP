Namespace LFERP.Library.Production.ProuctionWareOut


    Public Class ProductionWareOutInfo

        Private _PWO_NO As String
        Private _PWO_WareID As String
        Private _PWO_DepID As String
        Private _PWO_Remark As String
        Private _PWO_SubNO As String
        Private _PWO_SubType As String
        Private _PWO_SubRemark As String
        Private _PM_M_Code As String
        Private _PWO_M_Code As String
        Private _PWO_Qty As Integer
        Private _PWO_Type As String
        Private _PWO_Action As String
        Private _PWO_AddDate As Date
        Private _PWO_Check As Boolean
        Private _PWO_CheckAction As String
        Private _PWO_CheckDate As Date
        Private _PWO_CheckRemark As String

        Private _PWO_OutName As String
        Private _PWO_DepName As String

        Private _M_Code As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _M_Unit As String

        Private _PWO_ActionName As String
        Private _PWO_CheckActionName As String
        Private _FacName As String
        Private _FacID As String
        Private _PM_Type As String
        Private _PM_JiYu As String



        Sub New()
            _PM_JiYu = Nothing
            _PM_Type = Nothing

            _PWO_NO = Nothing
            _PWO_WareID = Nothing
            _PWO_DepID = Nothing
            _PWO_Remark = Nothing
            _PWO_SubNO = Nothing
            _PWO_SubType = Nothing
            _PWO_SubRemark = Nothing
            _PM_M_Code = Nothing
            _PWO_M_Code = Nothing
            _PWO_Qty = 0
            _PWO_Type = Nothing
            _PWO_Action = Nothing
            _PWO_AddDate = Nothing
            _PWO_Check = False
            _PWO_CheckAction = Nothing
            _PWO_CheckDate = Nothing
            _PWO_CheckRemark = Nothing

            _M_Code = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _M_Unit = Nothing

            _M_Gauge = Nothing
            _M_Unit = Nothing

            _PWO_OutName = Nothing
            _PWO_DepName = Nothing
            _FacName = Nothing
            _FacID = Nothing

        End Sub


        Public Property PM_JiYu() As String
            Get
                Return _PM_JiYu
            End Get
            Set(ByVal value As String)
                _PM_JiYu = value
            End Set
        End Property

        ''' <summary>
        ''' TYPE3_ID 2012-7-20
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Type() As String
            Get
                Return _PM_Type
            End Get
            Set(ByVal value As String)
                _PM_Type = value
            End Set
        End Property
        Public Property PWO_NO() As String
            Get
                Return _PWO_NO
            End Get
            Set(ByVal value As String)
                _PWO_NO = value
            End Set
        End Property
        Public Property PWO_WareID() As String
            Get
                Return _PWO_WareID
            End Get
            Set(ByVal value As String)
                _PWO_WareID = value
            End Set
        End Property
        Public Property PWO_DepID() As String
            Get
                Return _PWO_DepID
            End Get
            Set(ByVal value As String)
                _PWO_DepID = value
            End Set
        End Property
        Public Property PWO_Remark() As String
            Get
                Return _PWO_Remark
            End Get
            Set(ByVal value As String)
                _PWO_Remark = value
            End Set
        End Property
        Public Property PWO_SubNO() As String
            Get
                Return _PWO_SubNO
            End Get
            Set(ByVal value As String)
                _PWO_SubNO = value
            End Set
        End Property
        Public Property PWO_SubType() As String
            Get
                Return _PWO_SubType
            End Get
            Set(ByVal value As String)
                _PWO_SubType = value
            End Set
        End Property
        Public Property PWO_SubRemark() As String
            Get
                Return _PWO_SubRemark
            End Get
            Set(ByVal value As String)
                _PWO_SubRemark = value
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
        Public Property PWO_M_Code() As String
            Get
                Return _PWO_M_Code
            End Get
            Set(ByVal value As String)
                _PWO_M_Code = value
            End Set
        End Property
        Public Property PWO_Type() As String
            Get
                Return _PWO_Type
            End Get
            Set(ByVal value As String)
                _PWO_Type = value
            End Set
        End Property
        Public Property PWO_Qty() As Integer
            Get
                Return _PWO_Qty
            End Get
            Set(ByVal value As Integer)
                _PWO_Qty = value
            End Set
        End Property
        Public Property PWO_Action() As String
            Get
                Return _PWO_Action
            End Get
            Set(ByVal value As String)
                _PWO_Action = value
            End Set
        End Property
        Public Property PWO_AddDate() As Date
            Get
                Return _PWO_AddDate
            End Get
            Set(ByVal value As Date)
                _PWO_AddDate = value
            End Set
        End Property

        Public Property PWO_OutName() As String
            Get
                Return _PWO_OutName
            End Get
            Set(ByVal value As String)
                _PWO_OutName = value
            End Set
        End Property
        Public Property PWO_DepName() As String
            Get
                Return _PWO_DepName
            End Get
            Set(ByVal value As String)
                _PWO_DepName = value
            End Set
        End Property


        Public Property PWO_Check() As Boolean
            Get
                Return _PWO_Check
            End Get
            Set(ByVal value As Boolean)
                _PWO_Check = value
            End Set
        End Property
        Public Property PWO_CheckAction() As String
            Get
                Return _PWO_CheckAction
            End Get
            Set(ByVal value As String)
                _PWO_CheckAction = value
            End Set
        End Property
        Public Property PWO_CheckDate() As Date
            Get
                Return _PWO_CheckDate
            End Get
            Set(ByVal value As Date)
                _PWO_CheckDate = value
            End Set
        End Property
        Public Property PWO_CheckRemark() As String
            Get
                Return _PWO_CheckRemark
            End Get
            Set(ByVal value As String)
                _PWO_CheckRemark = value
            End Set
        End Property

        '-------------------------------------------------------
        Public Property M_Code() As String
            Get
                Return _M_Code
            End Get
            Set(ByVal value As String)
                _M_Code = value
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
        Public Property PWO_ActionName() As String
            Get
                Return _PWO_ActionName
            End Get
            Set(ByVal value As String)
                _PWO_ActionName = value
            End Set
        End Property
        Public Property PWO_CheckActionName() As String
            Get
                Return _PWO_CheckActionName
            End Get
            Set(ByVal value As String)
                _PWO_CheckActionName = value
            End Set
        End Property
        Public Property FacName() As String
            Get
                Return _FacName
            End Get
            Set(ByVal value As String)
                _FacName = value
            End Set
        End Property
        Public Property FacID() As String
            Get
                Return _FacID
            End Get
            Set(ByVal value As String)
                _FacID = value
            End Set
        End Property

    End Class
End Namespace