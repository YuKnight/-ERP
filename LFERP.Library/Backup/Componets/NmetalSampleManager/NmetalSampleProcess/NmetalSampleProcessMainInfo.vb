Imports System

Namespace LFERP.Library.NmetalSampleManager.NmetalSampleProcessMain

    Public Class NmetalSampleProcessMainInfo
        Private _PM_M_Code As String
        Private _Pro_NO As String
        Private _M_Code As String
        Private _Pro_Type As String
        Private _Type3ID As String
        Private _PM_Type As String
        Private _Pro_Weight As String
        Private _Pro_Remark As String
        Private _Pro_Action As String
        Private _Pro_AddDate As String
        Private _Pro_Check As String
        Private _Pro_Describe As String
        Private _M_CodeMouldNO As String
        Private _Pro_Rate As String
        Private _Pro_CheckAction As String
        Private _Pro_CheckDate As String
        Private _Pro_CheckRemark As String
        Private _Auto_ID As String
        Private _PS_Num As String
        Private _D_Name As String
        Private _PS_Name As String
        Private _PS_Type As String
        Private _PS_Weight As String
        Private _PS_Remark As String
        Private _PS_OutPut As String
        Private _PS_Enable As String
        Private _PS_NO As String
        Private _PS_Check As String
        Private _SO_CusterNo As String
        Private _D_Dep As String
        Private _PS_File As String
        Private _SO_SampleID As String
        Private _PS_BarCodeBit As Boolean
        Private _UseCount As Integer
        Private _SWI_Qty As Integer
        Private _PS_ShowReportBit As Boolean
        Private _PS_OtherWeight As Decimal       '張偉  2014-07-07  新增重量


        Public Sub New()
            _PM_M_Code = Nothing
            _Pro_NO = Nothing
            _M_Code = Nothing
            _Pro_Type = Nothing
            _Type3ID = Nothing
            _PM_Type = Nothing
            _Pro_Weight = Nothing
            _Pro_Remark = Nothing
            _Pro_Action = Nothing
            _Pro_AddDate = Nothing
            _Pro_Check = 0
            _Pro_Describe = Nothing
            _M_CodeMouldNO = Nothing
            _Pro_Rate = Nothing
            _Pro_CheckAction = Nothing
            _Pro_CheckDate = Nothing
            _Pro_CheckRemark = Nothing
            _Auto_ID = Nothing
            _PS_Num = Nothing
            _D_Name = Nothing
            _PS_Name = Nothing
            _PS_Type = Nothing
            _PS_Weight = Nothing
            _PS_Remark = Nothing
            _PS_OutPut = Nothing
            _PS_Enable = 0
            _PS_NO = Nothing
            _PS_Check = 0
            _SO_CusterNo = Nothing
            _D_Dep = Nothing
            _PS_File = Nothing
            _SO_SampleID = Nothing
            _PS_BarCodeBit = Nothing
            _UseCount = Nothing
            _SWI_Qty = Nothing
            _PS_ShowReportBit = Nothing
            _PS_OtherWeight = Nothing
        End Sub
        Public Property PS_ShowReportBit() As Boolean
            Get
                Return _PS_ShowReportBit
            End Get
            Set(ByVal value As Boolean)
                _PS_ShowReportBit = value
            End Set
        End Property
        Public Property SWI_Qty() As Integer
            Get
                Return _SWI_Qty
            End Get
            Set(ByVal value As Integer)
                _SWI_Qty = value
            End Set
        End Property
        Public Property UseCount() As Integer
            Get
                Return _UseCount
            End Get
            Set(ByVal value As Integer)
                _UseCount = value
            End Set
        End Property
        Public Property PS_BarCodeBit() As Boolean
            Get
                Return _PS_BarCodeBit
            End Get
            Set(ByVal value As Boolean)
                _PS_BarCodeBit = value
            End Set
        End Property
        Public Property SO_SampleID() As String
            Get
                Return _SO_SampleID
            End Get
            Set(ByVal value As String)
                _SO_SampleID = value
            End Set
        End Property

        Public Property PS_File() As String
            Get
                Return _PS_File
            End Get
            Set(ByVal value As String)
                _PS_File = value
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
        Public Property PM_M_Code() As String
            Get
                Return _PM_M_Code
            End Get
            Set(ByVal value As String)
                _PM_M_Code = value
            End Set
        End Property

        Public Property Pro_NO() As String
            Get
                Return _Pro_NO
            End Get
            Set(ByVal value As String)
                _Pro_NO = value
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

        Public Property Pro_Type() As String
            Get
                Return _Pro_Type
            End Get
            Set(ByVal value As String)
                _Pro_Type = value
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

        Public Property PM_Type() As String
            Get
                Return _PM_Type
            End Get
            Set(ByVal value As String)
                _PM_Type = value
            End Set
        End Property

        Public Property Pro_Weight() As String
            Get
                Return _Pro_Weight
            End Get
            Set(ByVal value As String)
                _Pro_Weight = value
            End Set
        End Property

        Public Property Pro_Remark() As String
            Get
                Return _Pro_Remark
            End Get
            Set(ByVal value As String)
                _Pro_Remark = value
            End Set
        End Property

        Public Property Pro_Action() As String
            Get
                Return _Pro_Action
            End Get
            Set(ByVal value As String)
                _Pro_Action = value
            End Set
        End Property

        Public Property Pro_AddDate() As String
            Get
                Return _Pro_AddDate
            End Get
            Set(ByVal value As String)
                _Pro_AddDate = value
            End Set
        End Property

        Public Property Pro_Check() As Boolean
            Get
                Return _Pro_Check
            End Get
            Set(ByVal value As Boolean)
                _Pro_Check = value
            End Set
        End Property

        Public Property Pro_Describe() As String
            Get
                Return _Pro_Describe
            End Get
            Set(ByVal value As String)
                _Pro_Describe = value
            End Set
        End Property

        Public Property M_CodeMouldNO() As String
            Get
                Return _M_CodeMouldNO
            End Get
            Set(ByVal value As String)
                _M_CodeMouldNO = value
            End Set
        End Property

        Public Property Pro_Rate() As String
            Get
                Return _Pro_Rate
            End Get
            Set(ByVal value As String)
                _Pro_Rate = value
            End Set
        End Property

        Public Property Pro_CheckAction() As String
            Get
                Return _Pro_CheckAction
            End Get
            Set(ByVal value As String)
                _Pro_CheckAction = value
            End Set
        End Property

        Public Property Pro_CheckDate() As String
            Get
                Return _Pro_CheckDate
            End Get
            Set(ByVal value As String)
                _Pro_CheckDate = value
            End Set
        End Property

        Public Property Pro_CheckRemark() As String
            Get
                Return _Pro_CheckRemark
            End Get
            Set(ByVal value As String)
                _Pro_CheckRemark = value
            End Set
        End Property

        Public Property Auto_ID() As String
            Get
                Return _Auto_ID
            End Get
            Set(ByVal value As String)
                _Auto_ID = value
            End Set
        End Property

        Public Property PS_Num() As String
            Get
                Return _PS_Num
            End Get
            Set(ByVal value As String)
                _PS_Num = value
            End Set
        End Property

        Public Property D_Name() As String
            Get
                Return _D_Name
            End Get
            Set(ByVal value As String)
                _D_Name = value
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

        Public Property PS_Type() As String
            Get
                Return _PS_Type
            End Get
            Set(ByVal value As String)
                _PS_Type = value
            End Set
        End Property

        Public Property PS_Weight() As String
            Get
                Return _PS_Weight
            End Get
            Set(ByVal value As String)
                _PS_Weight = value
            End Set
        End Property

        Public Property PS_Remark() As String
            Get
                Return _PS_Remark
            End Get
            Set(ByVal value As String)
                _PS_Remark = value
            End Set
        End Property

        Public Property PS_OutPut() As String
            Get
                Return _PS_OutPut
            End Get
            Set(ByVal value As String)
                _PS_OutPut = value
            End Set
        End Property

        Public Property PS_Enable() As Boolean
            Get
                Return _PS_Enable
            End Get
            Set(ByVal value As Boolean)
                _PS_Enable = value
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

        Public Property PS_Check() As Boolean
            Get
                Return _PS_Check
            End Get
            Set(ByVal value As Boolean)
                _PS_Check = value
            End Set
        End Property

        Public Property SO_CusterNo() As String
            Get
                Return _SO_CusterNo
            End Get
            Set(ByVal value As String)
                _SO_CusterNo = value
            End Set
        End Property
        Public Property PS_OtherWeight() As Decimal
            Get
                Return _PS_OtherWeight

            End Get
            Set(ByVal value As Decimal)
                _PS_OtherWeight = value
            End Set
        End Property
    End Class


End Namespace