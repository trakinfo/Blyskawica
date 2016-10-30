Imports System.Windows.Forms

Public Class dlgPrivilege

  Private DS As DataSet
  Public Event NewAdded(ByVal sender As Object, ByVal InsertedID As String)

  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    AddNew()
  End Sub

  Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Close()
  End Sub
  Private Sub frmPrzedmiot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    ListViewConfig(lvUser)
    FetchData()
    GetUser()
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
      .Columns.Add("ID", 0, HorizontalAlignment.Left)
      .Columns.Add("Login", 100, HorizontalAlignment.Left)
      .Columns.Add("Nazwisko i imię", 231, HorizontalAlignment.Left)
    End With
  End Sub
  Private Sub FetchData()
    Dim DBA As New DataBaseAction, P As New PrawaSQL
    DS = DBA.GetDataSet(P.SelectUser(SharedPrivilege.TestID.ToString))
  End Sub

  Private Sub GetUser()
    lvUser.Items.Clear()
    For Each row As DataRow In DS.Tables(0).Rows
      Me.lvUser.Items.Add(row.Item(0).ToString)
      Me.lvUser.Items(Me.lvUser.Items.Count - 1).SubItems.Add(row.Item(1).ToString)
      Me.lvUser.Items(Me.lvUser.Items.Count - 1).SubItems.Add(row.Item(2).ToString)
    Next
    lvUser.Columns(2).Width = CInt(IIf(lvUser.Items.Count > 32, 213, 231))
    Me.lvUser.Enabled = CType(IIf(Me.lvUser.Items.Count > 0, True, False), Boolean)

  End Sub
  Public Function AddNew() As Boolean
    Dim MySQLTrans As MySqlTransaction, IdUser As String = "0"
    Dim DBA As New DataBaseAction, P As New PrawaSQL, SH As New SeekHelper
    MySQLTrans = GlobalValues.gblConn.BeginTransaction()

    Try
      For Each Item As ListViewItem In lvUser.SelectedItems
        Dim cmd As MySqlCommand = DBA.CreateCommand(P.InsertPrivilege)
        cmd.Transaction = MySQLTrans
        IdUser = Item.Text
        cmd.Parameters.AddWithValue("?IdUser", Item.Text)
        cmd.Parameters.AddWithValue("?IdTest", SharedPrivilege.TestID)
        cmd.Parameters.AddWithValue("?Privilege", 1)
        cmd.Parameters.AddWithValue("?User", GlobalValues.gblUserName)
        cmd.Parameters.AddWithValue("?ComputerIP", GlobalValues.gblIP)
        cmd.ExecuteNonQuery()
        Item.Remove()
        SH.FindRemovedListViewItemIndex(lvUser, CType(IdUser, Integer))
      Next
      MySQLTrans.Commit()
      RaiseEvent NewAdded(Me, IdUser)
      Return True
    Catch err As MySqlException
      MySQLTrans.Rollback()
      GetUser()
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

  Private Sub lvStudent_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvUser.ItemSelectionChanged
    OK_Button.Enabled = CType(IIf(e.IsSelected, True, False), Boolean)
  End Sub

End Class
