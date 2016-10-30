Public Class frmPrawa
  Private DS As DataSet, Filter As String = "Nick LIKE '%'"

  Private Sub frmUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.ListViewConfig(Me.lvRejestr)
    ListViewConfig(lvUser)
    lblRecord.Text = ""
    Dim FCB As New FillComboBox, T As New TestSQL
    FCB.AddComboBoxComplexItems(cbPrzedmiot, T.SelectPrzedmiot)
    If cbPrzedmiot.Items.Count > 0 Then
      Dim SH As New SeekHelper
      SH.FindComboItem(cbPrzedmiot, CInt(SH.GetDefault(T.SelectDefault("przedmiot"))))
      cbPrzedmiot.Enabled = True
    End If
    Dim SeekCriteria() As String = New String() {"Login", "Nazwisko i imię"}
    Me.cbSeek.Items.AddRange(SeekCriteria)
    Me.cbSeek.SelectedIndex = 0

    'Me.GetData()
  End Sub
  Private Sub ListViewConfig(ByVal lv As ListView)
    With lv
      .View = View.Details
      .FullRowSelect = True
      .GridLines = True
      .MultiSelect = True
      .AllowColumnReorder = False
      .AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
      '.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent)
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
      If lv.Name = "lvRejestr" Then
        .Columns.Add("Nazwa testu", 675, HorizontalAlignment.Left)
      Else
        .Columns.Add("Login", 100, HorizontalAlignment.Left)
        .Columns.Add("Nazwisko i imię", 575, HorizontalAlignment.Left)
      End If
    End With
  End Sub

  Private Sub FetchData(ByVal IdPrzedmiot As String)
    Dim DBA As New DataBaseAction, P As New PrawaSQL
    DS = DBA.GetDataSet(P.SelectTest(IdPrzedmiot) & P.SelectPrivilege)
  End Sub
  Private Sub GetData()
    lvRejestr.Items.Clear()

    For Each row As DataRow In DS.Tables(0).Rows
      'DS.Tables(0).Select(Filter)(i).Item(1).ToString()
      Me.lvRejestr.Items.Add(row.Item(0).ToString)
      Me.lvRejestr.Items(Me.lvRejestr.Items.Count - 1).SubItems.Add(row.Item(1).ToString)
    Next
    'lblRecord.Text = "0 z " & lvRejestr.Items.Count
    lvRejestr.Columns(1).Width = CInt(IIf(lvRejestr.Items.Count > 10, 656, 675))
    Me.lvRejestr.Enabled = CType(IIf(Me.lvRejestr.Items.Count > 0, True, False), Boolean)

  End Sub
  Private Sub GetUser(ByVal IdTest As String)
    lvUser.Items.Clear()
    'MessageBox.Show("IdTest=" & IdTest & " AND " & Filter)
    For i As Integer = 0 To DS.Tables(1).Select("IdTest=" & IdTest & " AND " & Filter).GetUpperBound(0) 'For Each row As DataRow In DS.Tables(1).Select("IdTest=" & IdTest)
      Me.lvUser.Items.Add(DS.Tables(1).Select("IdTest=" & IdTest & " AND " & Filter)(i).Item(0).ToString)
      Me.lvUser.Items(Me.lvUser.Items.Count - 1).SubItems.Add(DS.Tables(1).Select("IdTest=" & IdTest & " AND " & Filter)(i).Item(1).ToString())
      Me.lvUser.Items(Me.lvUser.Items.Count - 1).SubItems.Add(DS.Tables(1).Select("IdTest=" & IdTest & " AND " & Filter)(i).Item(2).ToString())
    Next
    lblRecord.Text = "0 z " & lvUser.Items.Count
    lvUser.Columns(2).Width = CInt(IIf(lvUser.Items.Count > 17, 556, 575))
    Me.lvUser.Enabled = CType(IIf(Me.lvUser.Items.Count > 0, True, False), Boolean)

  End Sub
  Private Sub GetDetails()
    Try
      lblRecord.Text = lvUser.SelectedItems(0).Index + 1 & " z " & lvUser.Items.Count

      With DS.Tables(1).Select("IdTest='" & SharedPrivilege.TestID & "'")(0)
        lblUser.Text = .Item(3).ToString
        lblIP.Text = .Item(4).ToString
        lblData.Text = .Item(5).ToString
      End With
    Catch err As Exception
      MessageBox.Show(err.Message)
    End Try
  End Sub

  Private Sub lvRejestr_ClientSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvRejestr.ClientSizeChanged
    If Not CType(sender, ListView).Created Then Exit Sub
    'lvRejestr.Columns(1).Width = 100
    CType(sender, ListView).AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize)
  End Sub

  Private Sub lvUsers_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvRejestr.ItemSelectionChanged
    Me.ClearDetails()
    lvUser.Items.Clear()
    cmdDelete.Enabled = False
    If e.IsSelected Then
      SharedPrivilege.TestID = CType(e.Item.Text, Integer)
      GetUser(SharedPrivilege.TestID.ToString)
      'GetDetails(e.Item.Text)
      EnableButtons(True)
    Else
      EnableButtons(False)
    End If
  End Sub
  Private Sub EnableButtons(ByVal Value As Boolean)
    'Me.cmdDelete.Enabled = Value
    cmdAddNew.Enabled = Value
  End Sub
  Private Sub ClearDetails()
    lblRecord.Text = "0 z " & lvUser.Items.Count

    Me.lblUser.Text = ""
    Me.lblData.Text = ""
    Me.lblIP.Text = ""
  End Sub

  Private Sub cbPrzedmiot_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPrzedmiot.SelectedIndexChanged
    EnableButtons(False)
    FetchData(CType(cbPrzedmiot.SelectedItem, CbItem).ID.ToString)
    lvUser.Items.Clear()
    GetData()
  End Sub
  Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
    Me.Close()
  End Sub
  Private Sub AddNew()
    Dim dlgAddNew As New dlgPrivilege
    With dlgAddNew
      AddHandler .NewAdded, AddressOf NewAdded
      'AddHandler .FormClosed, AddressOf EnableCmdAddNew
      .Owner = Me
      'Me.cmdAddNew.Enabled = False
      .ShowDialog()
    End With
  End Sub
  Private Sub NewAdded(ByVal sender As Object, ByVal InsertedID As String)
    lvRejestr.Items.Clear()
    lvUser.Items.Clear()
    FetchData(CType(cbPrzedmiot.SelectedItem, CbItem).ID.ToString)
    GetData()
    Dim SH As New SeekHelper
    SH.FindListViewItem(Me.lvRejestr, SharedPrivilege.TestID.ToString)
    SH.FindListViewItem(lvUser, InsertedID)
  End Sub

  'Private Sub EnableCmdAddNew(ByVal sender As Object, ByVal e As FormClosedEventArgs)
  '  Me.cmdAddNew.Enabled = True
  'End Sub

  Private Sub cmdAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click
    AddNew()
  End Sub
  Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
    Dim DBA As New DataBaseAction, DeletedIndex As Integer, P As New PrawaSQL

    For Each Item As ListViewItem In Me.lvUser.SelectedItems
      DeletedIndex = Item.Index
      DBA.ApplyChanges(P.DeletePrivilege(SharedPrivilege.TestID.ToString, Item.Text))
    Next

    'Me.EnableQuestionButtons(False)
    EnableButtons(False)
    'cmdDeletePytanie.Enabled = False
    lvRejestr.Items.Clear()
    lvUser.Items.Clear()
    FetchData(CType(cbPrzedmiot.SelectedItem, CbItem).ID.ToString)
    Me.GetData()
    Dim SH As New SeekHelper
    SH.FindListViewItem(Me.lvRejestr, SharedPrivilege.TestID.ToString)
    SH.FindRemovedListViewItemIndex(lvUser, DeletedIndex)
  End Sub

  Private Sub lvStudent_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvUser.ItemSelectionChanged
    ClearDetails()
    If e.IsSelected Then
      GetDetails()
      cmdDelete.Enabled = True
    Else
      cmdDelete.Enabled = False
    End If
  End Sub

  Private Sub lvRejestr_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvUser.Resize
    'MessageBox.Show(CType(sender, ListView).Width.ToString)
    If Not CType(sender, ListView).Created Then Exit Sub
    CType(sender, ListView).Columns(1).Width = CType(sender, ListView).Width - CType(sender, ListView).Columns(2).Width - 5
  End Sub

  Private Sub txtSeek_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSeek.TextChanged
    Select Case Me.cbSeek.Text
      Case "Login"
        Filter = "Nick LIKE '" & IIf(Me.txtSeek.Text.Trim.Length > 0, Me.txtSeek.Text & "%'", Me.txtSeek.Text & "%'").ToString 'Me.txtSeek.Text & "%'"
      Case "Nazwisko i imię"
        Filter = "User LIKE '" & Me.txtSeek.Text & "%'"

    End Select
    cmdDelete.Enabled = False
    GetUser(SharedPrivilege.TestID.ToString)
    'Me.RefreshData()
  End Sub
  Private Sub cbSeek_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSeek.SelectedIndexChanged
    Me.txtSeek.Text = ""
    Me.txtSeek.Focus()
  End Sub

  Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
    Dim LinePen As New Pen(Color.White, 1)
    e.Graphics.DrawLine(LinePen, New Point(0, Me.Panel1.Height - 49), New Point(Me.Panel1.Width - 1, Me.Panel1.Height - 49))

  End Sub
End Class

Public Class PrawaSQL
  Public Function SelectTest(ByVal IdPrzedmiot As String) As String
    Return "SELECT t.ID,t.Nazwa FROM test t INNER JOIN user_test ut ON t.ID=ut.IdTest WHERE IdPrzedmiot='" & IdPrzedmiot & "' AND ut.IdUser='" & GlobalValues.gblUserID & "' AND ut.Privilege=2 Order BY t.Version;"
  End Function
  Public Function SelectPrivilege() As String
    Return "SELECT u.ID,u.Nick,Concat_WS(' ',u.Nazwisko,u.Imie) AS User,ut.User,ut.ComputerIP,ut.Version,ut.IdTest FROM user u INNER JOIN user_test ut ON u.ID=ut.IdUser WHERE ut.IdUser<>'" & GlobalValues.gblUserID & "';"
  End Function
  Public Function DeletePrivilege(ByVal IdTest As String, ByVal IdUser As String) As String
    Return "DELETE FROM user_test WHERE IdTest=" & IdTest & " AND IdUser=" & IdUser & ";"
  End Function

  Public Function SelectUser(ByVal IdTest As String) As String
    Return "SELECT ID,Nick,CONCAT_WS(' ',Nazwisko,Imie) as User FROM user WHERE ID NOT IN (SELECT IdUser FROM user_test WHERE IdTest=" & IdTest & ") ORDER BY Nick,Nazwisko,Imie;"
  End Function
  Public Function InsertPrivilege() As String
    Return "INSERT INTO user_test VALUES (?IdUser,?IdTest,?Privilege,?User,?ComputerIP,NULL);"
  End Function
End Class