Imports LFERP.Library.ProductionSchedule
Imports LFERP.Library.Product
Imports DevExpress.XtraScheduler
Imports LFERP.DataSetting
Imports System.IO

Public Class frmProductionSchedule1


    Dim ds As New DataSet
    'Dim dt As New DataTable
    Public Const aptDataResourceName As String = "appointments.xml"
    Public Const resDataResourceName As String = "resources.xml"
    'Public Shared InitialDate As DateTime = New DateTime(2005, 7, 13)

    Private Sub frmProductionSchedule1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CreateTable()
        LoadData()

        FillData(SchedulerControl1)

    End Sub

    Sub CreateTable()

        ds.Tables.Clear()
        With ds.Tables.Add("ProductionSchedule")

            .Columns.Add("PS_Date", GetType(String))
            .Columns.Add("PS_NO", GetType(String))
            .Columns.Add("Pro_Type", GetType(String))
            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("PM_Type", GetType(String))
            .Columns.Add("PS_DayNumber", GetType(Integer))
            .Columns.Add("FacName", GetType(String))

        End With

        'Me.SchedulerControl1.Storage.Appointments.DataSource = ds.Tables("ProductionSchedule")
        ''Me.SchedulerControl1.Storage.Appointments.DataMember = "ProductionSchedule"

        'Me.SchedulerControl1.Storage.Appointments.Mappings.Start = "PS_Date"
        'Me.SchedulerControl1.Storage.Appointments.Mappings.Subject = "PS_NO"
        'Me.SchedulerControl1.Storage.Appointments.Mappings.Status = "PS_NO"

    End Sub

    Sub LoadData()


        Dim psi As List(Of ProductionScheduleInfo)
        Dim psc As New ProductionScheduleControl

        psi = psc.ProductionSchedule_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        ds.Tables("ProductionSchedule").Clear()
        MsgBox(psi.Count)


        If psi.Count = 0 Then Exit Sub

        Dim i As Integer
        For i = 0 To psi.Count - 1
            Dim row As DataRow

            row = ds.Tables("ProductionSchedule").NewRow

            row("PS_Date") = psi(i).PS_Date
            row("PS_NO") = psi(i).PS_NO
            row("PS_DayNumber") = psi(i).PS_DayNumber
            row("Pro_Type") = psi(i).Pro_Type
            row("PM_M_Code") = psi(i).PM_M_Code
            row("PM_Type") = psi(i).PM_Type
            row("FacName") = psi(i).FacName

            ds.Tables("ProductionSchedule").Rows.Add(row)

        Next

    End Sub

    Public Shared Sub FillData(ByVal control As SchedulerControl)
        control.Storage.EnableReminders = False
        FillStorageData(control.Storage)
        'control.Start = InitialDate
        control.OptionsBehavior.ShowRemindersForm = False
    End Sub
    Public Shared Sub FillStorageData(ByVal storage As SchedulerStorage)

        'FillStorageCollection(storage.Resources.Items, resDataResourceName)
        FillStorageCollection(storage.Appointments.Items, aptDataResourceName)
    End Sub

    Private Shared Function GetResourceStream(ByVal resourceName As String) As Stream
        Return System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName)
    End Function

    Private Shared Sub FillStorageCollection(ByVal c As PersistentObjectCollection, ByVal resourceName As String)
        Dim stream As Stream = GetResourceStream(resourceName)
        c.ReadXml(stream)
        stream.Close()
    End Sub
    'Private Shared Function GetResourceStream(ByVal resourceName As String) As Stream
    '    Return System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName)
    'End Function
    'Private Shared Sub FillStorageCollection(ByVal c As PersistentObjectCollection, ByVal resourceName As String)
    '    Dim stream As stream = GetResourceStream(resourceName)
    '    c.ReadXml(stream)
    '    stream.Close()
    'End Sub
    Private Sub SchedulerControl1_EditAppointmentFormShowing(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.AppointmentFormEventArgs) Handles SchedulerControl1.EditAppointmentFormShowing
        Dim apt As Appointment = e.Appointment

        Dim psi As List(Of ProductionScheduleInfo)
        Dim psc As New ProductionScheduleControl

        psi = psc.ProductionSchedule_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, apt.Start, apt.Start, Nothing)


        Try
            If psi.Count = 0 Then
                e.Handled = True
                Exit Sub
            Else

                Dim i As Integer
                For i = 0 To psi.Count - 1

                    tempValue3 = psi(i).PS_NO

                Next
                tempValue2 = "µø¹Ï"
                e.DialogResult = frmProductionSchedule.ShowDialog
                e.Handled = True

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

      
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub


End Class