
Namespace LFERP.DataSetting


    Public Class EmployeInfo
        Private _Employe_ID As String
        Private _Employe_Name As String

        Sub New()
            _Employe_ID = ""
            _Employe_Name = ""
        End Sub


        Public Property Employe_ID() As String
            Get
                Return _Employe_ID
            End Get
            Set(ByVal value As String)
                _Employe_ID = value
            End Set
        End Property


        Public Property Employe_Name() As String
            Get
                Return _Employe_Name
            End Get
            Set(ByVal value As String)
                _Employe_Name = value
            End Set
        End Property


    End Class


End Namespace