
Namespace LFERP.Library.ProductProcess


    Public Class ProductComplaintMainInfo

        Private _PC_NO As String
        Private _Pro_NO As String
        Private _PM_M_Code As String
        Private _PC_Remark As String
        Private _PC_Action As String
        Private _PC_AddDate As Date
        Private _PC_EditDate As Date

        Private _PS_Num As String
        Private _PS_NO As String
        Private _PS_Name As String
        Private _D_Name As String
        Private _PS_Question As String
        Private _PS_Photo As Byte()

        Private _IndexNO As Integer

        Private _ActionName As String

        Private _D_ID As String
        Private _D_Dep As String


        Sub New()

            _PC_NO = Nothing
            _Pro_NO = Nothing
            _PM_M_Code = Nothing
            _PC_Remark = Nothing
            _PC_Action = Nothing
            _PC_AddDate = Nothing
            _PC_EditDate = Nothing
            _PS_Photo = Nothing

            _PS_Num = Nothing
            _PS_NO = Nothing
            _PS_Name = Nothing
            _D_Name = Nothing
            _PS_Question = Nothing


            _IndexNO = 0

            _ActionName = Nothing
            _D_ID = Nothing
            _D_Dep = Nothing

        End Sub

        Public Property PC_NO() As String
            Get
                Return _PC_NO
            End Get
            Set(ByVal value As String)
                _PC_NO = value
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
        Public Property PM_M_Code() As String
            Get
                Return _PM_M_Code
            End Get
            Set(ByVal value As String)
                _PM_M_Code = value
            End Set
        End Property
        Public Property PC_Remark() As String
            Get
                Return _PC_Remark
            End Get
            Set(ByVal value As String)
                _PC_Remark = value
            End Set
        End Property
        Public Property PC_Action() As String
            Get
                Return _PC_Action
            End Get
            Set(ByVal value As String)
                _PC_Action = value
            End Set
        End Property
        Public Property PC_AddDate() As Date
            Get
                Return _PC_AddDate
            End Get
            Set(ByVal value As Date)
                _PC_AddDate = value
            End Set
        End Property
        Public Property PC_EditDate() As Date
            Get
                Return _PC_EditDate
            End Get
            Set(ByVal value As Date)
                _PC_EditDate = value
            End Set
        End Property
        Public Property PS_Photo() As Byte()
            Get
                Return _PS_Photo
            End Get
            Set(ByVal value As Byte())
                _PS_Photo = value
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
        Public Property D_Name() As String
            Get
                Return _D_Name
            End Get
            Set(ByVal value As String)
                _D_Name = value
            End Set
        End Property
        Public Property PS_Question() As String
            Get
                Return _PS_Question
            End Get
            Set(ByVal value As String)
                _PS_Question = value
            End Set
        End Property
        Public Property IndexNO() As Integer
            Get
                Return _IndexNO
            End Get
            Set(ByVal value As Integer)
                _IndexNO = value
            End Set
        End Property

        Public Property ActionName() As String
            Get
                Return _ActionName
            End Get
            Set(ByVal value As String)
                _ActionName = value
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
        Public Property D_Dep() As String
            Get
                Return _D_Dep
            End Get
            Set(ByVal value As String)
                _D_Dep = value
            End Set
        End Property

    End Class
End Namespace




