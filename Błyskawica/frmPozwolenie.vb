Public Class frmPozwolenie
  Private DS As DataSet, Filter As String = "Klasa LIKE '%'"

  Private Sub frmUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.ListViewConfig(Me.lvRejestr)
    ListViewConfig(lvStudent)
    lblRecord.Text = ""
    Dim FCB As New FillComboBox, T As New TestSQL
    FCB.AddComboBoxComplexItems(cbPrzedmiot, T.SelectPrzedmiot)
    If cbPrzedmiot.Items.Count > 0 Then
      Dim SH As New SeekHelper
      SH.FindComboItem(cbPrzedmiot, CInt(SH.GetDefault(T.SelectDefault("przedmiot"))))
      cbPrzedmiot.Enabled = True
    End If
    Dim SeekCriteria() As String = New String() {"Grupa", "Nazwisko i imię"}
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
        .Columns.Add("Nazwisko i imię", 575, HorizontalAlignment.Left)
        .Columns.Add("Klasa", 100, HorizontalAlignment.Center)
      End If
    End With
  End Sub

  Private Sub FetchData(ByVal IdPrzedmiot As String)
    Dim DBA As New DataBaseAction, P As New PozwoleniaSQL
    DS = DBA.GetDataSet(P.SelectTest(IdPrzedmiot) & P.SelectPermission)
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
  Private Sub GetStudent(ByVal IdTest As String)
    lvStudent.Items.Clear()
    'MessageBox.Show("IdTest=" & IdTest & " AND " & Filter)
    For i As Integer = 0 To DS.Tables(1).Select("IdTest=" & IdTest & " AND " & Filter).GetUpperBound(0) 'For Each row As DataRow In DS.Tables(1).Select("IdTest=" & IdTest)
      Me.lvStudent.Items.Add(DS.Tables(1).Select("IdTest=" & IdTest & " AND " & Filter)(i).Item(0).ToString)
      Me.lvStudent.Items(Me.lvStudent.Items.Count - 1).SubItems.Add(DS.Tables(1).Select("IdTest=" & IdTest & " AND " & Filter)(i).Item(1).ToString())
      Me.lvStudent.Items(Me.lvStudent.Items.Count - 1).SubItems.Add(DS.Tables(1).Select("IdTest=" & IdTest & " AND " & Filter)(i).Item(2).ToString())
    Next
    lblRecord.Text = "0 z " & lvStudent.Items.Count
    lvStudent.Columns(1).Width = CInt(IIf(lvStudent.Items.Count > 17, 556, 575))
    Me.lvStudent.Enabled = CType(IIf(Me.lvStudent.Items.Count > 0, True, False), Boolean)

  End Sub
  Private Sub GetDetails()
    Try
      lblRecord.Text = lvStudent.SelectedItems(0).Index + 1 & " z " & lvStudent.Items.Count

      With DS.Tables(1).Select("IdTest='" & SharedPermission.TestID & "'")(0)
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
    lvStudent.Items.Clear()
    cmdDelete.Enabled = False
    If e.IsSelected Then
      SharedPermission.TestID = CType(e.Item.Text, Integer)
      GetStudent(e.Item.Text)
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
    lblRecord.Text = "0 z " & lvStudent.Items.Count

    Me.lblUser.Text = ""
    Me.lblData.Text = ""
    Me.lblIP.Text = ""
  End Sub

  Private Sub cbPrzedmiot_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPrzedmiot.SelectedIndexChanged
    EnableButtons(False)
    FetchData(CType(cbPrzedmiot.SelectedItem, CbItem).ID.ToString)
    lvStudent.Items.Clear()
    GetData()
  End Sub
  Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
    Me.Close()
  End Sub
  Private Sub AddNew()
    Dim dlgAddNew As New dlgPermission
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
    lvStudent.Items.Clear()
    FetchData(CType(cbPrzedmiot.SelectedItem, CbItem).ID.ToString)
    GetData()
    Dim SH As New SeekHelper
    SH.FindListViewItem(Me.lvRejestr, SharedPermission.TestID.ToString)
    SH.FindListViewItem(lvStudent, InsertedID)
  End Sub

  'Private Sub EnableCmdAddNew(ByVal sender As Object, ByVal e As FormClosedEventArgs)
  '  Me.cmdAddNew.Enabled = True
  'End Sub

  Private Sub cmdAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click
    AddNew()
  End Sub
  Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
    Dim DBA As New DataBaseAction, DeletedIndex As Integer, P As New PozwoleniaSQL

    For Each Item As ListViewItem In Me.lvStudent.SelectedItems
      DeletedIndex = Item.Index
      DBA.ApplyChanges(P.DeletePermission(Item.Text))
      'DBA.ApplyChanges(P.DeletePermission(SharedPermission.TestID.ToString, Item.Text))
    Next

    'Me.EnableQuestionButtons(False)
    EnableButtons(False)
    'cmdDeletePytanie.Enabled = False
    lvRejestr.Items.Clear()
    lvStudent.Items.Clear()
    FetchData(CType(cbPrzedmiot.SelectedItem, CbItem).ID.ToString)
    Me.GetData()
    Dim SH As New SeekHelper
    SH.FindListViewItem(Me.lvRejestr, SharedPermission.TestID.ToString)
    SH.FindRemovedListViewItemIndex(lvStudent, DeletedIndex)
  End Sub

  Private Sub lvStudent_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvStudent.ItemSelectionChanged
    ClearDetails()
    If e.IsSelected Then
      GetDetails()
      cmdDelete.Enabled = True
    Else
      cmdDelete.Enabled = False
    End If
  End Sub

  Private Sub lvRejestr_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvStudent.Resize
    'MessageBox.Show(CType(sender, ListView).Width.ToString)
    If Not CType(sender, ListView).Created Then Exit Sub
    CType(sender, ListView).Columns(1).Width = CType(sender, ListView).Width - CType(sender, ListView).Columns(2).Width - 5
  End Sub

  'Private Sub lvRejestr_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvRejestr.SizeChanged, lvStudent.SizeChanged
  '  MessageBox.Show(CType(sender, ListView).Width.ToString)
  'End Sub
  Private Sub txtSeek_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSeek.TextChanged
    Select Case Me.cbSeek.Text
      Case "Grupa"
        Filter = "Klasa LIKE '" & IIf(Me.txtSeek.Text.Trim.Length > 0, Me.txtSeek.Text & "%'", Me.txtSeek.Text & "%'").ToString 'Me.txtSeek.Text & "%'"
      Case "Nazwisko i imię"
        Filter = "Student LIKE '" & Me.txtSeek.Text & "%'"
      
    End Select
    cmdDelete.Enabled = False
    GetStudent(SharedPermission.TestID.ToString)
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

Public Class PozwoleniaSQL
  Public Function SelectTest(ByVal IdPrzedmiot As String) As String
    Return "SELECT t.ID,t.Nazwa FROM test t INNER JOIN user_test ut ON t.ID=ut.IdTest WHERE IdPrzedmiot='" & IdPrzedmiot & "' AND ut.IdUser='" & GlobalValues.gblUserID & "' Order BY t.Version;"
  End Function
  Public Function SelectPermission() As String
    Return "SELECT st.ID,Concat_WS(' ',s.Nazwisko,s.Imie) AS Student,s.Klasa,st.User,st.ComputerIP,st.Version,st.IdTest FROM student s INNER JOIN student_test st ON s.ID=st.IdStudent ORDER BY s.Klasa,s.Nazwisko,s.Imie;"
  End Function
  Public Function DeletePermission(ByVal ID As String) As String
    Return "DELETE FROM student_test WHERE ID=" & ID & ";"
  End Function
  'Public Function DeletePermission(ByVal IdTest As String, ByVal IdStudent As String) As String
  '  Return "DELETE FROM student_test WHERE IdTest=" & IdTest & " AND IdStudent=" & IdStudent & ";"
  'End Function  
  Public Function SelectKlasa() As String
    Return "SELECT KodKlasy,Nazwa FROM klasa ORDER BY KodKlasy,Nazwa;"
  End Function
  Public Function SelectStudent(ByVal IdTest As String) As String
    Return "SELECT ID,CONCAT_WS(' ',Nazwisko,Imie) as Student,Klasa FROM student WHERE ID NOT IN (SELECT IdStudent FROM student_test WHERE IdTest=" & IdTest & ") ORDER BY Klasa,Nazwisko,Imie;"
  End Function
  Public Function InsertPermission() As String
    Return "INSERT INTO student_test VALUES (NULL,?IdStudent,?IdTest,?User,?ComputerIP,NULL);"
  End Function
End Class