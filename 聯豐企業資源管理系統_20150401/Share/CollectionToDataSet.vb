Imports System.Data
Imports System.Reflection

Public Class CollectionToDataSet

    Private _collection As ICollection
    Private _propertyCollection() As PropertyInfo = Nothing
    Private _ds As DataSet
    Private _tablename As String

    Private ReadOnly Property PropertyCollection() As PropertyInfo()
        Get
            If _propertyCollection Is Nothing Then
                _propertyCollection = GetPropertyCollection()
            End If
            Return _propertyCollection
        End Get
    End Property

    Private Function GetPropertyCollection() As PropertyInfo()

        If (_collection.Count > 0) Then
            Dim enumerator As IEnumerator = _collection.GetEnumerator()
            enumerator.MoveNext()
            Return enumerator.Current.GetType().GetProperties()
        Else
            Return Nothing
        End If
    End Function

    'Public Function CreateDataSet() As DataSet
    '    Dim ds As DataSet = New DataSet("GridDataSet")
    '    ds.Tables.Add(FillDataTable())
    '    Return ds
    'End Function

    ''' <summary>
    ''' 將中間層的List類型轉換為DataSet類型
    ''' </summary>
    ''' <param name="dsSet">指定的DataSet</param>
    ''' <param name="dsTableName">需要建立的表名</param>
    ''' <param name="Coll">中間層獲取的List</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CollToDataSet(ByVal dsSet As DataSet, ByVal dsTableName As String, ByVal Coll As ICollection) As Boolean
        Try
            _ds = dsSet
            _tablename = dsTableName
            _collection = Coll
            _ds.Tables.Add(FillDataTable())
            CollToDataSet = True
        Catch ex As Exception
            CollToDataSet = False
            'MsgBox(ex.Message)
        End Try


    End Function

    Private Function FillDataTable() As DataTable
        On Error Resume Next
        Dim enumerator As IEnumerator = _collection.GetEnumerator()
        Dim dt As DataTable = CreateDataTable()
        While enumerator.MoveNext()
            dt.Rows.Add(FillDataRow(dt.NewRow(), enumerator.Current))
        End While
        Return dt
    End Function

    Private Function FillDataRow(ByRef dataRow As DataRow, ByRef p As Object) As DataRow
        For Each pi As PropertyInfo In PropertyCollection
            dataRow(pi.Name.ToString()) = pi.GetValue(p, Nothing)
        Next
        Return dataRow
    End Function

    Private Function CreateDataTable() As DataTable
        Dim dt As DataTable = New DataTable(_tablename)
        For Each pi As PropertyInfo In PropertyCollection
            If pi.PropertyType.ToString = "System.Byte[]" Then
                dt.Columns.Add(pi.Name.ToString(), GetType(Byte()))
            Else
                dt.Columns.Add(pi.Name.ToString())
            End If

        Next
        Return dt
    End Function

    'Public Sub New(ByRef coll As ICollection)
    '    _collection = coll
    'End Sub


End Class