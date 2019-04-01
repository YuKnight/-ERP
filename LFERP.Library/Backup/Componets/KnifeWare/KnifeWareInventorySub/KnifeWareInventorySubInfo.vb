Namespace LFERP.Library.KnifeWare
    Public Class KnifeWareInventorySubInfo
        Private _Type3ID As String
        Private _Type3Name As String
        Private _WH_ID As String
        Private _WI_SQty As Double
        Private _WI_SReQty As Double

        Private _WI_QtyAll As Double

        Private _M_Code As String
        Private _M_Name As String
        Private _M_Gauge As String
        Private _Type1ID As String
        Private _Type1Name As String
        Private _Type2ID As String
        Private _Type2Name As String
        Private _B_Qty As Double

        Private _WI_All As Double
        Private _WI_Qty As Double
        Private _WI_SafeQty As Double
        Private _WI_UserID As String
        Private _WI_EditDate As Date
        Private _WI_UsableQty As Double
        Private _PM_M_Name As String
        Private _WH_Name As String
        Private _M_Unit As String

        Private _B_Date As String
        Private _R_Date As String
        Private _NO_ReturnSum As Double
        Private _WI_NOReturn As Double

        '--------------------------- 
        Private _KnNO As String               '單號
        Private _TypeB As String              '類型
        Private _KnQty As Double              '數量
        Private _KnDate As Date               '日期
        Private _KnType As String             '屬性
        Private _KnInfo As String             '備註
        Private _BackUpTime As String         '備份時間


        Sub New()
            _Type3ID = Nothing
            _Type3Name = Nothing
            _WH_ID = Nothing
            _WI_SQty = 0
            _WI_SReQty = 0
            _WI_QtyAll = 0

            _M_Code = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing
            _Type1ID = Nothing
            _Type1Name = Nothing
            _Type2ID = Nothing
            _Type2Name = Nothing

            _B_Qty = 0

            _B_Date = Nothing
            _R_Date = Nothing
            _NO_ReturnSum = 0
            _WI_NOReturn = 0


            _KnNO = Nothing
            _TypeB = Nothing
            _KnDate = Nothing
            _KnType = Nothing
            _KnInfo = Nothing
            _BackUpTime = Nothing
        End Sub

        Public Property WI_NOReturn() As Double
            Get
                Return _WI_NOReturn
            End Get
            Set(ByVal value As Double)
                _WI_NOReturn = value
            End Set
        End Property

        Public Property NO_ReturnSum() As Double
            Get
                Return _NO_ReturnSum
            End Get
            Set(ByVal value As Double)
                _NO_ReturnSum = value
            End Set
        End Property

        Public Property B_Date() As String
            Get
                Return _B_Date
            End Get
            Set(ByVal value As String)
                _B_Date = value
            End Set
        End Property
        Public Property R_Date() As String
            Get
                Return _R_Date
            End Get
            Set(ByVal value As String)
                _R_Date = value
            End Set
        End Property

        Public Property Type3ID() As String
            Get
                Return _Type3ID
            End Get
            Set(ByVal value As String)
                _Type3ID = value
            End Set
        End Property

        Public Property Type3Name() As String
            Get
                Return _Type3Name
            End Get
            Set(ByVal value As String)
                _Type3Name = value
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

        Public Property WI_SQty() As Double
            Get
                Return _WI_SQty
            End Get
            Set(ByVal value As Double)
                _WI_SQty = value
            End Set
        End Property

        Public Property WI_SReQty() As Double
            Get
                Return _WI_SReQty
            End Get
            Set(ByVal value As Double)
                _WI_SReQty = value
            End Set
        End Property


        Public Property WI_QtyAll() As Double
            Get
                Return _WI_QtyAll
            End Get
            Set(ByVal value As Double)
                _WI_QtyAll = value
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

        Public Property Type1ID() As String
            Get
                Return _Type1ID
            End Get
            Set(ByVal value As String)
                _Type1ID = value
            End Set
        End Property


        Public Property Type1Name() As String
            Get
                Return _Type1Name
            End Get
            Set(ByVal value As String)
                _Type1Name = value
            End Set
        End Property

        Public Property Type2ID() As String
            Get
                Return _Type2ID
            End Get
            Set(ByVal value As String)
                _Type2ID = value
            End Set
        End Property

        Public Property Type2Name() As String
            Get
                Return _Type2Name
            End Get
            Set(ByVal value As String)
                _Type2Name = value
            End Set
        End Property

        Public Property B_Qty() As String
            Get
                Return _B_Qty
            End Get
            Set(ByVal value As String)
                _B_Qty = value
            End Set
        End Property


        Public Property WI_All() As Double
            Get
                Return _WI_All
            End Get
            Set(ByVal value As Double)
                _WI_All = value
            End Set
        End Property
        Public Property WI_Qty() As Double
            Get
                Return _WI_Qty
            End Get
            Set(ByVal value As Double)
                _WI_Qty = value
            End Set
        End Property
        Public Property WI_SafeQty() As Double
            Get
                Return _WI_SafeQty
            End Get
            Set(ByVal value As Double)
                _WI_SafeQty = value
            End Set
        End Property
        Public Property WI_UserID() As Double
            Get
                Return _WI_UserID
            End Get
            Set(ByVal value As Double)
                _WI_UserID = value
            End Set
        End Property
        Public Property WI_EditDate() As Date
            Get
                Return _WI_EditDate
            End Get
            Set(ByVal value As Date)
                _WI_EditDate = value
            End Set
        End Property
        Public Property WI_UsableQty() As Double
            Get
                Return _WI_UsableQty
            End Get
            Set(ByVal value As Double)
                _WI_UsableQty = value
            End Set
        End Property
        Public Property PM_M_Name() As String
            Get
                Return _PM_M_Name
            End Get
            Set(ByVal value As String)
                _PM_M_Name = value
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

        Public Property M_Unit() As String
            Get
                Return _M_Unit
            End Get
            Set(ByVal value As String)
                _M_Unit = value
            End Set
        End Property

#Region "屬性"
        ''' <summary>
        ''' 單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property KnNO() As String
            Get
                Return _KnNO
            End Get
            Set(ByVal value As String)
                _KnNO = value
            End Set
        End Property

        ''' <summary>
        ''' 類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property TypeB() As String
            Get
                Return _TypeB
            End Get
            Set(ByVal value As String)
                _TypeB = value
            End Set
        End Property

        ''' <summary>
        ''' 日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property KnDate() As Date
            Get
                Return _KnDate
            End Get
            Set(ByVal value As Date)
                _KnDate = value
            End Set
        End Property

        ''' <summary>
        ''' 刀具屬性
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property KnType() As String
            Get
                Return _KnType
            End Get
            Set(ByVal value As String)
                _KnType = value
            End Set
        End Property

        ''' <summary>
        ''' 備註信息
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property KnInfo() As String
            Get
                Return _KnInfo
            End Get
            Set(ByVal value As String)
                _KnInfo = value
            End Set
        End Property

        ''' <summary>
        ''' 刀具數量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property KnQty() As Double
            Get
                Return _KnQty
            End Get
            Set(ByVal value As Double)
                _KnQty = value
            End Set
        End Property

        Public Property BackUpTime() As String
            Get
                Return _BackUpTime
            End Get
            Set(ByVal value As String)
                _BackUpTime = value
            End Set
        End Property
#End Region

    End Class
End Namespace