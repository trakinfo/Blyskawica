Imports System.Windows.Forms

Public Class dlgPermission
  Private DS As DataSet
  Public Event NewAdded(ByVal sender As Object, ByVal InsertedID As String)

  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    'Me.DialogResult = System.Windows.Forms.DialogResult.OK
    'Me.Close()
    'If AddNew() Then
    '  'OK_Button.Enabled = False
    'End If
    AddNew()
  End Sub

  Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Close()
  End Sub
  Private Sub frmPrzedmiot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.ListViewConfig(lvKlasa)
    ListViewConfig(lvStudent)
    FetchData()
    GetData()
  End Sub
  Private Sub ListViewConfig(ByVal lv As ListView)
    With lv
      .View = View.Details
      .FullRowSelect = True
      .GridLines = True
      .MultiSelect = True
      .AllowColumnReorder = False
      .AutoResizeColumns(0)
      .HideSelection = False
      '.HoverSelection = True
      .HeaderStyle = ColumnHeaderStyle.Nonclickable
      AddColumns(lv)
      .Items.Clear()
      .Enabled = False
    End With
  End Sub
  Private Sub AddColumns(ByVal lv As ListView)
    With lv
      If lv.Name = "lvKlasa" Then
        .Columns.Add("KodKlasy", 50, HorizontalAlignment.Center)
        .Columns.Add("Nazwa grupy", 112, HorizontalAlignment.Center)
      Else
        .Columns.Add("ID", 0, HorizontalAlignment.Left)
        .Columns.Add("Nazwisko i imię", 331, HorizontalAlignment.Left)
      End If
    End With
  End Sub
  Private Sub FetchData()
    Dim DBA As New DataBaseAction, P As New PozwoleniaSQL
    DS = DBA.GetDataSet(P.SelectKlasa & P.SelectStudent(SharedPermission.TestID.ToString))
  End Sub
  Private Sub GetData()
    lvKlasa.Items.Clear()
    For Each row As DataRow In DS.Tables(0).Rows
      Me.lvKlasa.Items.Add(row.Item(0).ToString)
      Me.lvKlasa.Items(Me.lvKlasa.Items.Count - 1).SubItems.Add(row.Item(1).ToString)
    Next
    lvKlasa.Columns(1).Width = CInt(IIf(lvKlasa.Items.Count > 32, 94, 112))
    Me.lvKlasa.Enabled = CType(IIf(Me.lvKlasa.Items.Count > 0, True, False), Boolean)

  End Sub
  Private Sub GetStudent(ByVal KodKlasy As String)
    lvStudent.Items.Clear()
    For Each row As DataRow In DS.Tables(1).Select("Klasa='" & KodKlasy & "'")
      Me.lvStudent.Items.Add(row.Item(0).ToString)
      Me.lvStudent.Items(Me.lvStudent.Items.Count - 1).SubItems.Add(row.Item(1).ToString)
    Next
    lvStudent.Columns(1).Width = CInt(IIf(lvStudent.Items.Count > 32, 313, 331))
    Me.lvStudent.Enabled = CType(IIf(Me.lvStudent.Items.Count > 0, True, False), Boolean)

  End Sub
  Public Function AddNew() As Boolean
    Dim MySQLTrans As MySqlTransaction, IdStudent As String = "0", idx As Integer = 0
    Dim DBA As New DataBaseAction, P As New PozwoleniaSQL, SH As New SeekHelper
    MySQLTrans = GlobalValues.gblConn.BeginTransaction()

    Try
      For Each Item As ListViewItem In lvStudent.SelectedItems
        Dim cmd As MySqlCommand = DBA.CreateCommand(P.InsertPermission)
        cmd.Transaction = MySQLTrans
        IdStudent = Item.Text
        cmd.Parameters.AddWithValue("?IdStudent", Item.Text)
        cmd.Parameters.AddWithValue("?IdTest", SharedPermission.TestID)
        cmd.Parameters.AddWithValue("?User", GlobalValues.gblUserName)
        cmd.Parameters.AddWithValue("?ComputerIP", GlobalValues.gblIP)
        cmd.ExecuteNonQuery()
        idx = Item.Index
        Item.Remove()
        DS.Tables(1).Rows.Remove(DS.Tables(1).Select("ID=" & IdStudent)(0))
        SH.FindRemovedListViewItemIndex(lvStudent, idx) 'CType(IdStudent, Integer))
      Next
      MySQLTrans.Commit()
      RaiseEvent NewAdded(Me, IdStudent)
      Return True
    Catch err As MySqlException
      MySQLTrans.Rollback()
      GetStudent(lvKlasa.SelectedItems(0).Text)
      Select Case err.Number
        'Case 1062
        '  MessageBox.Show("Podany użytkownik już istnieje." + vbNewLine + "Spróbuj innej nazwy.")
        Case Else
          MessageBox.Show(err.Message + vbNewLine + "Numer błędu: " + err.Number.ToString)
      End Select
    Catch ex As Exception
      MySQLTrans.Rollback()
      MessageBox.Show(ex.Message)

    End Try
  End Function

  Private Sub lvKlasa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvKlasa.ItemSelectionChanged
    lvStudent.Items.Clear()
    If e.IsSelected Then GetStudent(e.Item.Text)
  End Sub

  Private Sub lvStudent_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvStudent.DoubleClick
    AddNew()
  End Sub

  Private Sub lvStudent_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvStudent.ItemSelectionChanged
    OK_Button.Enabled = CType(IIf(e.IsSelected, True, False), Boolean)
  End Sub

End Class
