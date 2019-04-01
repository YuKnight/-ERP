Imports system.Runtime.InteropServices

Public Class ReadWriteCard
    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode, pack:=4)> _
    Public Structure info       'ReadICCard¨ç¼Æ°Ñ¼Æ

        Public CardNo As Byte()
        Public CardName As Byte()
        Public Money As Long
        Public Times As Long
        Public Ver As Long

    End Structure


    Public Class readwriteDll
        <DllImport("EastRiver.dll", EntryPoint:="OpenCommPort", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
             Public Shared Function OpenCommPort(ByVal port As Integer, ByVal RaudRate As Integer) As IntPtr
        End Function
        <DllImport("EastRiver.dll", EntryPoint:="CloseCommPort", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
            Public Shared Function CloseCommPort(ByVal port As Integer) As Boolean
        End Function

        <DllImport("EastRiver.dll", EntryPoint:="CallClock", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function CallClock(ByVal hport As IntPtr, ByVal Clock_id As Integer) As Boolean
        End Function

        <DllImport("EastRiver.dll", EntryPoint:="ReadICCard", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function ReadICCard(ByVal hport As IntPtr, ByVal CardNo As Byte(), ByVal CardName As Byte(), ByRef Money As Integer, ByRef Times As Integer, ByRef ver As Integer) As Boolean
        End Function
        <DllImport("EastRiver.dll", EntryPoint:="SetSecurityCode", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
       Public Shared Function SetSecurityCode(ByVal hport As IntPtr, ByVal oldSecurity As String, ByVal newSecurity As String) As Boolean
        End Function
        <DllImport("EastRiver.dll", EntryPoint:="WriteICCardPassWord", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
       Public Shared Function WriteICCardPassWord(ByVal hPort As Long, ByVal PassWord As String, Optional ByVal Block As Integer = -1) As Boolean
        End Function

    End Class


End Class
