Imports System.Runtime.InteropServices
Imports System.Text

Public Class ApiDisplay

    <DllImport("vfd216c.dll", EntryPoint:="com_init", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function com_init(ByVal intPort As Integer, ByVal baud As Integer) As Boolean

    End Function

    <DllImport("vfd216c.dll", EntryPoint:="com_exit", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function com_exit() As Boolean

    End Function

    <DllImport("vfd216c.dll", EntryPoint:="com_send", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function com_send(ByVal tlen As Long, ByVal tbuf As String) As Boolean

    End Function

    <DllImport("vfd216c.dll", EntryPoint:="clear_vfd", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function clear_vfd() As Boolean

    End Function

    <DllImport("vfd216c.dll", EntryPoint:="display_stop", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function display_stop() As Boolean

    End Function

    <DllImport("vfd216c.dll", EntryPoint:="display_wellcome", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function display_wellcome() As Boolean

    End Function

    <DllImport("vfd216c.dll", EntryPoint:="display_num1", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function display_num1(ByVal tbuf As String) As Boolean

    End Function

    <DllImport("vfd216c.dll", EntryPoint:="display_num2", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function display_num2(ByVal tbuf As String) As Boolean

    End Function

    <DllImport("vfd216c.dll", EntryPoint:="display_nums", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function display_nums(ByVal tbuf As String) As Boolean

    End Function

    <DllImport("vfd216c.dll", EntryPoint:="display_moveleft", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function display_moveleft(ByVal tbuf As String) As Boolean

    End Function

    <DllImport("vfd216c.dll", EntryPoint:="display_movelefts", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function display_movelefts(ByVal tbuf As String) As Boolean

    End Function

    <DllImport("vfd216c.dll", EntryPoint:="display_time", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function display_time(ByVal tbuf As String) As Boolean

    End Function

    <DllImport("vfd216c.dll", EntryPoint:="cancel_mark", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function cancel_mark() As Boolean

    End Function

    <DllImport("vfd216c.dll", EntryPoint:="update_mark", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function update_mark(ByVal tbuf As String) As Boolean

    End Function

    <DllImport("vfd216c.dll", EntryPoint:="display_lf", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function display_lf() As Boolean

    End Function

    <DllImport("vfd216c.dll", EntryPoint:="display_cr", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function display_cr() As Boolean

    End Function

    <DllImport("vfd216c.dll", EntryPoint:="setup_cursor", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function setup_cursor(ByVal xy As Integer) As Boolean

    End Function

    <DllImport("vfd216c.dll", EntryPoint:="mode_dc1", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function mode_dc1() As Boolean

    End Function

    <DllImport("vfd216c.dll", EntryPoint:="mode_dc2", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function mode_dc2() As Boolean

    End Function

    <DllImport("vfd216c.dll", EntryPoint:="display_dot", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function display_dot(ByVal xlen As Integer, ByVal dotbuf As String) As Boolean

    End Function





End Class

