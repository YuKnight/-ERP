Imports System.Data.Common

Namespace LFERP.Library.ProductionPiecePayWGAdjust
    Public Class ProductionPiecePayWGAdjustInfo
        Private _AutoID As String
        Private _OUT_G_NO As String
        Private _OUT_FacID As String
        Private _OUT_DepID As String
        Private _IN_G_NO As String

        Private _IN_FacID As String
        Private _IN_DepID As String
        Private _Amount As Double

        Private _Ad_YYMM As String
        Private _Ad_Reason As String
        Private _AddUserID As String
        Private _AddDate As Date

        Private _Ad_Check As Boolean
        Private _Ad_CheckDate As String
        Private _Ad_CheckUserID As String

        Private _OUT_G_Name As String
        Private _OUT_FacName As String
        Private _OUT_DepName As String

        Private _IN_G_Name As String
        Private _IN_FacName As String
        Private _IN_DepName As String

        Private _AddUserIDName As String
        Private _Ad_CheckUserName As String


        Sub New()
            _AutoID = Nothing
            _OUT_G_NO = Nothing
            _OUT_FacID = Nothing
            _OUT_DepID = Nothing
            _IN_G_NO = Nothing

            _IN_FacID = Nothing
            _IN_DepID = Nothing
            _Amount = 0

            _Ad_YYMM = Nothing
            _Ad_Reason = Nothing
            _AddUserID = Nothing
            _AddDate = Nothing


            _Ad_Check = False
            _Ad_CheckDate = Nothing
            _Ad_CheckUserID = Nothing

            _OUT_G_Name = Nothing
            _OUT_FacName = Nothing
            _OUT_DepName = Nothing

            _IN_G_Name = Nothing
            _IN_FacName = Nothing
            _OUT_DepName = Nothing

            _IN_G_Name = Nothing
            _IN_FacName = Nothing
            _IN_DepName = Nothing

            _AddUserIDName = Nothing
            _Ad_CheckUserName = Nothing

        End Sub


        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property


        Public Property OUT_G_NO() As String
            Get
                Return _OUT_G_NO
            End Get
            Set(ByVal value As String)
                _OUT_G_NO = value
            End Set
        End Property


        Public Property OUT_FacID() As String
            Get
                Return _OUT_FacID
            End Get
            Set(ByVal value As String)
                _OUT_FacID = value
            End Set
        End Property

        Public Property OUT_DepID() As String
            Get
                Return _OUT_DepID
            End Get
            Set(ByVal value As String)
                _OUT_DepID = value
            End Set
        End Property

        Public Property IN_G_NO() As String
            Get
                Return _IN_G_NO
            End Get
            Set(ByVal value As String)
                _IN_G_NO = value
            End Set
        End Property

        Public Property IN_FacID() As String
            Get
                Return _IN_FacID
            End Get
            Set(ByVal value As String)
                _IN_FacID = value
            End Set
        End Property

        Public Property IN_DepID() As String
            Get
                Return _IN_DepID
            End Get
            Set(ByVal value As String)
                _IN_DepID = value
            End Set
        End Property

        Public Property Amount() As Double
            Get
                Return _Amount
            End Get
            Set(ByVal value As Double)
                _Amount = value
            End Set
        End Property

        Public Property Ad_YYMM() As String
            Get
                Return _Ad_YYMM
            End Get
            Set(ByVal value As String)
                _Ad_YYMM = value
            End Set
        End Property

        Public Property Ad_Reason() As String
            Get
                Return _Ad_Reason
            End Get
            Set(ByVal value As String)
                _Ad_Reason = value
            End Set
        End Property

        Public Property AddUserID() As String
            Get
                Return _AddUserID
            End Get
            Set(ByVal value As String)
                _AddUserID = value
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

        Public Property Ad_Check() As Boolean
            Get
                Return _Ad_Check
            End Get
            Set(ByVal value As Boolean)
                _Ad_Check = value
            End Set
        End Property

        Public Property Ad_CheckDate() As String
            Get
                Return _Ad_CheckDate
            End Get
            Set(ByVal value As String)
                _Ad_CheckDate = value
            End Set
        End Property

        Public Property Ad_CheckUserID() As String
            Get
                Return _Ad_CheckUserID
            End Get
            Set(ByVal value As String)
                _Ad_CheckUserID = value
            End Set
        End Property

        Public Property OUT_G_Name() As String
            Get
                Return _OUT_G_Name
            End Get
            Set(ByVal value As String)
                _OUT_G_Name = value
            End Set
        End Property

        Public Property OUT_FacName() As String
            Get
                Return _OUT_FacName
            End Get
            Set(ByVal value As String)
                _OUT_FacName = value
            End Set
        End Property

        Public Property OUT_DepName() As String
            Get
                Return _OUT_DepName
            End Get
            Set(ByVal value As String)
                _OUT_DepName = value
            End Set
        End Property

        Public Property IN_G_Name() As String
            Get
                Return _IN_G_Name
            End Get
            Set(ByVal value As String)
                _IN_G_Name = value
            End Set
        End Property

        Public Property IN_FacName() As String
            Get
                Return _IN_FacName
            End Get
            Set(ByVal value As String)
                _IN_FacName = value
            End Set
        End Property

        Public Property IN_DepName() As String
            Get
                Return _IN_DepName
            End Get
            Set(ByVal value As String)
                _IN_DepName = value
            End Set
        End Property

        Public Property AddUserIDName() As String
            Get
                Return _AddUserIDName
            End Get
            Set(ByVal value As String)
                _AddUserIDName = value
            End Set
        End Property

        Public Property Ad_CheckUserName() As String
            Get
                Return _Ad_CheckUserName
            End Get
            Set(ByVal value As String)
                _Ad_CheckUserName = value
            End Set
        End Property

    End Class
End Namespace

