Namespace LFERP.Library.KnifeWare
    Public Class KnifeBorrowInfo
        Private _AutoID As Int32      '自動編號ID
        Private _B_Num As String     '借刀流水號
        Private _B_NO As String     '借刀單號
        Private _M_Code As String     '刀具編碼
        Private _WH_ID As String     '倉庫代號
        Private _BPer_ID As String     '借刀人
        Private _BPer_Name As String     '借刀姓名
        Private _B_Qty As Double      '借刀數
        Private _R_Qty As Double     '還刀數
        Private _B_Date As Date     '借刀日期
        Private _R_Date As String     '還刀日期
        Private _B_Action As String     '操作員
        Private _B_Remark As String     '備注
        Private _G_NO As String     '組別編號
        Private _B_Type As String     '發刀屬性
        Private _M_Name As String     '刀具名稱---------------
        Private _WH_Name As String     '倉庫名稱
        Private _WH_PName As String     '父倉庫名稱
        Private _B_ActionName As String     '操作員名稱
        Private _G_Name As String     '組別名稱
        Private _B_EndQty As Double
        Private _M_Gauge As String
        Private _NOReturn As Double
        Private _B_AllEndQty As Double
        Private _Type3ID As String
        Private _Type3Name As String
        Private _M_Unit As String

        '2014-05-28  姚駿
        Private _FacName As String
        Private _DepName As String



        Sub New()
            _AutoID = 0
            _B_Num = Nothing
            _B_NO = Nothing
            _M_Code = Nothing
            _WH_ID = Nothing
            _BPer_ID = Nothing
            _BPer_Name = Nothing
            _B_Qty = 0
            _R_Qty = 0
            _B_Date = Nothing
            _R_Date = Nothing
            _B_Action = Nothing
            _B_Remark = Nothing
            _G_NO = Nothing
            _B_Type = Nothing
            _M_Name = Nothing
            _WH_Name = Nothing
            _WH_PName = Nothing
            _B_ActionName = Nothing
            _G_Name = Nothing
            _B_EndQty = 0
            _M_Gauge = Nothing
            _NOReturn = 0
            _B_AllEndQty = 0

            _Type3ID = Nothing
            _Type3Name = Nothing
            _M_Unit = Nothing

            '2014-05-28  姚駿
            _FacName = Nothing
            _DepName = Nothing
         
        End Sub

        Public Property M_Unit() As String
            Get
                Return _M_Unit
            End Get
            Set(ByVal value As String)
                _M_Unit = value
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


        Public Property B_AllEndQty() As Double
            Get
                Return _B_AllEndQty
            End Get
            Set(ByVal value As Double)
                _B_AllEndQty = value
            End Set
        End Property


        Public Property NOReturn() As Double
            Get
                Return _NOReturn
            End Get
            Set(ByVal value As Double)
                _NOReturn = value
            End Set
        End Property
        ''' <summary>
        ''' 自動編號ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property AutoID() As Int32
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Int32)
                _AutoID = value
            End Set
        End Property


        ''' <summary>
        ''' 借刀流水號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property B_Num() As String
            Get
                Return _B_Num
            End Get
            Set(ByVal value As String)
                _B_Num = value
            End Set
        End Property


        ''' <summary>
        ''' 借刀單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property B_NO() As String
            Get
                Return _B_NO
            End Get
            Set(ByVal value As String)
                _B_NO = value
            End Set
        End Property


        ''' <summary>
        ''' 刀具編碼
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Code() As String
            Get
                Return _M_Code
            End Get
            Set(ByVal value As String)
                _M_Code = value
            End Set
        End Property


        ''' <summary>
        ''' 倉庫代號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property WH_ID() As String
            Get
                Return _WH_ID
            End Get
            Set(ByVal value As String)
                _WH_ID = value
            End Set
        End Property


        ''' <summary>
        ''' 借刀人
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property BPer_ID() As String
            Get
                Return _BPer_ID
            End Get
            Set(ByVal value As String)
                _BPer_ID = value
            End Set
        End Property


        ''' <summary>
        ''' 借刀姓名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property BPer_Name() As String
            Get
                Return _BPer_Name
            End Get
            Set(ByVal value As String)
                _BPer_Name = value
            End Set
        End Property


        ''' <summary>
        ''' 借刀數
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property B_Qty() As Double
            Get
                Return _B_Qty
            End Get
            Set(ByVal value As Double)
                _B_Qty = value
            End Set
        End Property


        ''' <summary>
        ''' 還刀數
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_Qty() As Double
            Get
                Return _R_Qty
            End Get
            Set(ByVal value As Double)
                _R_Qty = value
            End Set
        End Property


        ''' <summary>
        ''' 借刀日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property B_Date() As Date
            Get
                Return _B_Date
            End Get
            Set(ByVal value As Date)
                _B_Date = value
            End Set
        End Property


        ''' <summary>
        ''' 還刀日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property R_Date() As String
            Get
                Return _R_Date
            End Get
            Set(ByVal value As String)
                _R_Date = value
            End Set
        End Property


        ''' <summary>
        ''' 操作員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property B_Action() As String
            Get
                Return _B_Action
            End Get
            Set(ByVal value As String)
                _B_Action = value
            End Set
        End Property


        ''' <summary>
        ''' 備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property B_Remark() As String
            Get
                Return _B_Remark
            End Get
            Set(ByVal value As String)
                _B_Remark = value
            End Set
        End Property


        ''' <summary>
        ''' 組別編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property G_NO() As String
            Get
                Return _G_NO
            End Get
            Set(ByVal value As String)
                _G_NO = value
            End Set
        End Property


        ''' <summary>
        ''' 發刀屬性
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property B_Type() As String
            Get
                Return _B_Type
            End Get
            Set(ByVal value As String)
                _B_Type = value
            End Set
        End Property


        ''' <summary>
        ''' 刀具名稱---------------
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Name() As String
            Get
                Return _M_Name
            End Get
            Set(ByVal value As String)
                _M_Name = value
            End Set
        End Property


        ''' <summary>
        ''' 倉庫名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property WH_Name() As String
            Get
                Return _WH_Name
            End Get
            Set(ByVal value As String)
                _WH_Name = value
            End Set
        End Property


        ''' <summary>
        ''' 父倉庫名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property WH_PName() As String
            Get
                Return _WH_PName
            End Get
            Set(ByVal value As String)
                _WH_PName = value
            End Set
        End Property


        ''' <summary>
        ''' 操作員名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property B_ActionName() As String
            Get
                Return _B_ActionName
            End Get
            Set(ByVal value As String)
                _B_ActionName = value
            End Set
        End Property


        ''' <summary>
        ''' 組別名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property G_Name() As String
            Get
                Return _G_Name
            End Get
            Set(ByVal value As String)
                _G_Name = value
            End Set
        End Property

        '
        Public Property B_EndQty() As Double
            Get
                Return _B_EndQty
            End Get
            Set(ByVal value As Double)
                _B_EndQty = value
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

        Public Property FacName() As String
            Get
                Return _FacName
            End Get
            Set(ByVal value As String)
                _FacName = value
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
