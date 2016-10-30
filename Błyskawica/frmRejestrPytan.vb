Public Class frmRejestrPytan
  Private DS As DataSet
  'Public Event LimitPunktowChanged()
  Private Sub frmRejestrPytan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.ListViewConfig(Me.lvRejestr)
    Me.ListViewConfig(Me.lvOdp)
    lblRecord.Text = ""
    lblRecord1.Text = ""
    Dim FCB As New FillComboBox, T As New TestSQL
    FCB.AddComboBoxComplexItems(cbPrzedmiot, T.SelectPrzedmiot)
    If cbPrzedmiot.Items.Count > 0 Then
      Dim SH As New SeekHelper
      SH.FindComboItem(cbPrzedmiot, CInt(SH.GetDefault(T.SelectDefault("przedmiot"))))
      cbPrzedmiot.Enabled = True
    End If
    'SH.FindComboItem(cbPrzedmiot, CInt(SH.GetDefault(T.SelectDefault("przedmiot"))))
    'cbPrzedmiot.Enabled = CType(IIf(cbPrzedmiot.Items.Count > 0, True, False), Boolean)

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
      If lv.Name = "lvRejestr" Then
        .Columns.Add("Treść pytania", 627, HorizontalAlignment.Left)
        .Columns.Add("Właściciel", 120, HorizontalAlignment.Center)
        .Columns.Add("Status", 80, HorizontalAlignment.Center)
      Else
        .Columns.Add("Treść odpowiedzi", 727, HorizontalAlignment.Left)
        .Columns.Add("Punktacja", 100, HorizontalAlignment.Center)
      End If
    End With
  End Sub
  Private Sub FetchData(ByVal IdModul As String)
    Dim DBA As New DataBaseAction, P As New PytaniaSQL
    DS = DBA.GetDataSet(P.SelectPytanie(IdModul) & P.SelectOdp(IdModul))

  End Sub
  Private Sub GetData()
    lvRejestr.Items.Clear()
    For Each Row As DataRow In DS.Tables(0).Rows
      If DS.Tables(1).Select("IdPytanie=" & Row.Item(0).ToString).GetLength(0) < 1 Then
        AddItem(lvRejestr, Row, Color.Red, lvRejestr.BackColor, lvRejestr.Font)
      Else
        If DS.Tables(1).Select("Punktacja>0 AND IdPytanie=" & Row.Item(0).ToString).GetLength(0) > 0 Then
          If CType(DS.Tables(1).Compute("SUM(Punktacja)", "Punktacja>0 AND IdPytanie=" & Row.Item(0).ToString), Integer) < 100 Then
            AddItem(lvRejestr, Row, Color.Peru, lvRejestr.BackColor, lvRejestr.Font)
          Else
            AddItem(lvRejestr, Row, lvRejestr.ForeColor, lvRejestr.BackColor, lvRejestr.Font)
          End If
        Else
          AddItem(lvRejestr, Row, Color.Peru, lvRejestr.BackColor, lvRejestr.Font)
        End If
      End If
    Next
    lblRecord.Text = "0 z " & lvRejestr.Items.Count
    lvRejestr.Columns(1).Width = CInt(IIf(lvRejestr.Items.Count > 19, 608, 627))
    Me.lvRejestr.Enabled = CType(IIf(Me.lvRejestr.Items.Count > 0, True, False), Boolean)

  End Sub
  Private Sub AddItem(ByVal LV As ListView, ByVal Row As DataRow, ByVal ForeColor As Color, ByVal BackColor As Color, ByVal ItemFont As Font)
    LV.Items.Add(Row.Item(0).ToString).UseItemStyleForSubItems = False
    LV.Items(LV.Items.Count - 1).SubItems.Add(Row.Item(1).ToString, ForeColor, BackColor, ItemFont)
    LV.Items(LV.Items.Count - 1).SubItems.Add(Row.Item(2).ToString, ForeColor, BackColor, ItemFont)
    LV.Items(LV.Items.Count - 1).SubItems.Add([Enum].GetName(GetType(GlobalValues.TestAccess), CType(Row.Item(3), Integer)), ForeColor, BackColor, ItemFont)
  End Sub
  Private Sub GetAnswer(ByVal IdPytanie As String)
    lvOdp.Items.Clear()
    For Each row As DataRow In DS.Tables(1).Select("IdPytanie=" & IdPytanie)
      Me.lvOdp.Items.Add(row.Item(0).ToString)
      Me.lvOdp.Items(Me.lvOdp.Items.Count - 1).SubItems.Add(row.Item(1).ToString)
      Me.lvOdp.Items(Me.lvOdp.Items.Count - 1).SubItems.Add(row.Item(2).ToString)
    Next
    lblRecord1.Text = "0 z " & lvOdp.Items.Count
    lvOdp.Columns(1).Width = CInt(IIf(lvOdp.Items.Count > 8, 708, 727))
    Me.lvOdp.Enabled = CType(IIf(Me.lvOdp.Items.Count > 0, True, False), Boolean)

  End Sub
  Private Sub GetQDetails(ByVal IdPytanie As String)
    Try
      lblRecord.Text = lvRejestr.SelectedItems(0).Index + 1 & " z " & lvRejestr.Items.Count
      lblRecord1.Text = "0 z " & lvOdp.Items.Count

      With DS.Tables(0).Select("ID='" & IdPytanie & "'")(0)
        lblUser.Text = .Item(4).ToString
        lblIP.Text = .Item(5).ToString
        lblData.Text = .Item(6).ToString
      End With
    Catch err As Exception
      MessageBox.Show(err.Message)
    End Try
  End Sub
  Private Sub GetADetails(ByVal IdOdp As String)
    Try
      lblRecord1.Text = lvOdp.SelectedItems(0).Index + 1 & " z " & lvOdp.Items.Count
      'lblRecord1.Text = "0 z " & lvOdp.Items.Count

      With DS.Tables(1).Select("ID='" & IdOdp & "'")(0)
        lblUser.Text = .Item(3).ToString
        lblIP.Text = .Item(4).ToString
        lblData.Text = .Item(5).ToString
      End With
    Catch err As Exception
      MessageBox.Show(err.Message)
    End Try
  End Sub
  Private Sub EnableQuestionButtons(ByVal Value As Boolean)
    Me.cmdDelete.Enabled = Value
    Me.cmdEdit.Enabled = Value
    cmdAddOdp.Enabled = Value
  End Sub
  Private Sub EnableAnswerButtons(ByVal Value As Boolean)
    Me.cmdDeleteOdp.Enabled = Value
    Me.cmdEditOdp.Enabled = Value
    'cmdAddOdp.Enabled = Value
  End Sub
  Private Sub ClearQuestionDetails()
    lblRecord.Text = "0 z " & lvRejestr.Items.Count
    lblRecord1.Text = "0 z " & lvOdp.Items.Count
    ClearDetails()
    'Me.lblUser.Text = ""
    'Me.lblData.Text = ""
    'Me.lblIP.Text = ""
  End Sub
  Private Sub ClearAnswerDetails()
    'lblRecord.Text = "0 z " & lvRejestr.Items.Count
    lblRecord1.Text = "0 z " & lvOdp.Items.Count
    ClearDetails()
  End Sub
  Private Sub ClearDetails()
    Me.lblUser.Text = ""
    Me.lblData.Text = ""
    Me.lblIP.Text = ""
  End Sub

  Private Sub lvRejestr_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvRejestr.DoubleClick
    EditData()
  End Sub

  Private Sub lvOdp_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvOdp.DoubleClick
    EditAnswerData()
  End Sub
  Private Sub lvUsers_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvRejestr.ItemSelectionChanged, lvOdp.ItemSelectionChanged
    If CType(sender, ListView).Name = "lvRejestr" Then
      Me.ClearQuestionDetails()
      If e.IsSelected Then
        'e.Item.ForeColor = Color.Red
        SharedQuestion.LimitPunktow = 100 - CType(IIf(DS.Tables(1).Select("Punktacja>0 AND IdPytanie=" & e.Item.Text).GetLength(0) > 0, DS.Tables(1).Compute("SUM(Punktacja)", "Punktacja>0 AND IdPytanie=" & e.Item.Text), 0), Integer)
        SharedQuestion.LimitPunktowChange(Me)
        SharedQuestion.QuestionID = e.Item.Text
        GetAnswer(e.Item.Text)
        GetQDetails(e.Item.Text)
        EnableQuestionButtons(True)
      Else
        lvOdp.Items.Clear()
        EnableQuestionButtons(False)
        EnableAnswerButtons(False)
      End If
    Else
      ClearAnswerDetails()
      If e.IsSelected Then
        GetADetails(e.Item.Text)
        EnableAnswerButtons(True)
      Else
        EnableAnswerButtons(False)
      End If
    End If
  End Sub
  Private Sub AddNewAnswer()
    Dim dlgAddNew As New dlgAnswer
    'Dim FCB As New FillComboBox, SH As New SeekHelper, P As New PytaniaSQL
    With dlgAddNew
      AddHandler dlgAddNew.NewAdded, AddressOf NewAnswerAdded
      AddHandler dlgAddNew.FormClosed, AddressOf EnableCmdAddNewQ
      .nudPunktacja.Maximum = SharedQuestion.LimitPunktow
      .nudPunktacja.Value = SharedQuestion.LimitPunktow
      .Owner = Me
      .Show()
      .txtTresc.Focus()
      'Me.cmdAddNew.Enabled = False
    End With
  End Sub
  Private Sub NewAnswerAdded(ByVal sender As Object, ByVal InsertedID As Long)
    lvOdp.Items.Clear()
    lvRejestr.Items.Clear()
    FetchData(CType(cbModul.SelectedItem, CbItem).ID.ToString)
    GetData()
    GetAnswer(SharedQuestion.QuestionID)
    Dim SH As New SeekHelper
    SH.FindListViewItem(lvRejestr, SharedQuestion.QuestionID)
    SH.FindListViewItem(Me.lvOdp, InsertedID.ToString)
  End Sub
  Private Sub EnableCmdAddNewQ(ByVal sender As Object, ByVal e As FormClosedEventArgs)
    Me.cmdAddOdp.Enabled = True
  End Sub
  Private Sub EnableCmdAddNew(ByVal sender As Object, ByVal e As FormClosedEventArgs)
    Me.cmdAddNew.Enabled = True
  End Sub
  Private Sub AddNew()
    Dim dlgAddNew As New dlgQuestion
    With dlgAddNew
      AddHandler dlgAddNew.NewAdded, AddressOf NewAdded
      AddHandler dlgAddNew.FormClosed, AddressOf EnableCmdAddNew
      .Owner = Me
      .Show()
      .txtTresc.Focus()
      'Me.cmdAddNew.Enabled = False
    End With
  End Sub
  Private Sub NewAdded(ByVal sender As Object, ByVal InsertedID As Long)
    lvRejestr.Items.Clear()
    lvOdp.Items.Clear()
    FetchData(CType(cbModul.SelectedItem, CbItem).ID.ToString)
    GetData()
    Dim SH As New SeekHelper
    SH.FindListViewItem(Me.lvRejestr, InsertedID.ToString)
    GetAnswer(SharedQuestion.QuestionID)
    SH.FindListViewItem(Me.lvOdp, InsertedID.ToString)
  End Sub
  Private Sub cbPrzedmiot_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPrzedmiot.SelectedIndexChanged
    cbModul.Items.Clear()
    Dim FCB As New FillComboBox, T As New TestSQL
    FCB.AddComboBoxComplexItems(cbModul, T.SelectModul(CType(cbPrzedmiot.SelectedItem, CbItem).ID.ToString))
    cbModul.Enabled = CType(IIf(cbPrzedmiot.Text.Length > 0, True, False), Boolean)
  End Sub

  Private Sub cbModul_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbModul.SelectedIndexChanged
    FetchData(CType(cbModul.SelectedItem, CbItem).ID.ToString)
    SharedQuestion.ModuleID = CType(cbModul.SelectedItem, CbItem).ID.ToString
    lvOdp.Items.Clear()
    GetData()
    cmdAddNew.Enabled = CType(IIf(cbModul.Text.Length > 0, True, False), Boolean)
    cmdAddOdp.Enabled = False
  End Sub

  Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
    Close()
  End Sub

  Private Sub cmdAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click
    AddNew()
  End Sub

  Private Sub cmdAddOdp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddOdp.Click
    AddNewAnswer()
  End Sub
  Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click, cmdDeleteOdp.Click
    Dim DBA As New DataBaseAction, DeletedIndex As Integer, P As New PytaniaSQL
    If CType(sender, Button).Name = "cmdDelete" Then
      For Each Item As ListViewItem In Me.lvRejestr.SelectedItems
        DeletedIndex = Item.Index
        DBA.ApplyChanges(P.DeleteItem("pytanie", Item.Text))
      Next
    Else
      For Each Item As ListViewItem In Me.lvOdp.SelectedItems
        DeletedIndex = Item.Index
        DBA.ApplyChanges(P.DeleteItem("odpowiedz", Item.Text))
      Next

    End If
    Me.EnableQuestionButtons(False)
    EnableAnswerButtons(False)
    lvRejestr.Items.Clear()
    lvOdp.Items.Clear()
    FetchData(CType(cbModul.SelectedItem, CbItem).ID.ToString)
    Me.GetData()
    Dim SH As New SeekHelper
    If CType(sender, Button).Name = "cmdDelete" Then
      SH.FindRemovedListViewItemIndex(Me.lvRejestr, DeletedIndex)
      'SharedQuestion.QuestionID = lvRejestr.Items(0).Text
    Else
      SH.FindListViewItem(lvRejestr, SharedQuestion.QuestionID)
      GetAnswer(SharedQuestion.QuestionID)
      SH.FindRemovedListViewItemIndex(Me.lvOdp, DeletedIndex)

    End If

  End Sub

  Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
    Me.EditData()
  End Sub
  Private Sub EditData()
    Dim dlgEdit As New dlgQuestion
    Try
      With dlgEdit
        .Text = "Edycja pytania"
        .txtTresc.Text = Me.lvRejestr.SelectedItems(0).SubItems(1).Text
        .chkPrivate.Checked = CType(IIf(lvRejestr.SelectedItems(0).SubItems(3).Text = [Enum].GetName(GetType(GlobalValues.TestAccess), 1), 1, 0), Boolean)
        .OK_Button.Text = "Zapisz"
        .Icon = GlobalValues.gblAppIcon
        If .ShowDialog = Windows.Forms.DialogResult.OK Then
          Dim DBA As New DataBaseAction, IdPytanie As String, P As New PytaniaSQL
          IdPytanie = Me.lvRejestr.SelectedItems(0).Text
          Dim cmd As MySqlCommand = DBA.CreateCommand(P.UpdatePytanie(IdPytanie))

          cmd.Parameters.AddWithValue("?Tresc", .txtTresc.Text)
          cmd.Parameters.AddWithValue("?Private", .chkPrivate.CheckState)
          'cmd.Parameters.AddWithValue("?Role", CType(.cbRola.SelectedItem, CbItem).ID)
          cmd.Parameters.AddWithValue("?User", GlobalValues.gblUserName)
          cmd.Parameters.AddWithValue("?IP", GlobalValues.gblIP)

          cmd.ExecuteNonQuery()
          Me.lvRejestr.Items.Clear()
          lvOdp.Items.Clear()
          FetchData(CType(cbModul.SelectedItem, CbItem).ID.ToString)

          Me.GetData()

          Dim SH As New SeekHelper
          SH.FindListViewItem(Me.lvRejestr, IdPytanie)
        End If
      End With
    Catch err As MySqlException
      Select Case err.Number
        Case 1062
          MessageBox.Show("Podany użytkownik już istnieje." + vbNewLine + "Spróbuj innej nazwy.")
        Case Else
          MessageBox.Show(err.Message + vbNewLine + "Numer błędu: " + err.Number.ToString)
      End Select
    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
  End Sub

  Private Sub EditAnswerData()
    Dim dlgEdit As New dlgAnswer
    Try
      With dlgEdit
        .Text = "Edycja pytania"
        .txtTresc.Text = Me.lvOdp.SelectedItems(0).SubItems(1).Text
        '.nudPunktacja.Maximum = CType(IIf(CType(lvOdp.SelectedItems(0).SubItems(2).Text, Integer) > 0, CType(lvOdp.SelectedItems(0).SubItems(2).Text, Integer) + SharedQuestion.LimitPunktow, 0), Integer) 'SharedQuestion.LimitPunktow
        .nudPunktacja.Maximum = CType(IIf(CType(lvOdp.SelectedItems(0).SubItems(2).Text, Integer) >= SharedQuestion.LimitPunktow, CType(lvOdp.SelectedItems(0).SubItems(2).Text, Integer) + SharedQuestion.LimitPunktow, SharedQuestion.LimitPunktow), Integer) 'SharedQuestion.LimitPunktow
        .nudPunktacja.Value = CType(lvOdp.SelectedItems(0).SubItems(2).Text, Integer)
        .OK_Button.Text = "Zapisz"
        .Icon = GlobalValues.gblAppIcon
        If .ShowDialog = Windows.Forms.DialogResult.OK Then
          Dim DBA As New DataBaseAction, IdAnswer As String, P As New PytaniaSQL
          IdAnswer = Me.lvOdp.SelectedItems(0).Text
          Dim cmd As MySqlCommand = DBA.CreateCommand(P.UpdateOdp(IdAnswer))

          cmd.Parameters.AddWithValue("?Tresc", .txtTresc.Text)
          cmd.Parameters.AddWithValue("?Punktacja", CType(.nudPunktacja.Value, Int16))
          cmd.Parameters.AddWithValue("?User", GlobalValues.gblUserName)
          cmd.Parameters.AddWithValue("?IP", GlobalValues.gblIP)

          cmd.ExecuteNonQuery()
          Me.lvRejestr.Items.Clear()
          lvOdp.Items.Clear()
          FetchData(CType(cbModul.SelectedItem, CbItem).ID.ToString)
          Me.GetData()
          Dim SH As New SeekHelper
          SH.FindListViewItem(Me.lvRejestr, SharedQuestion.QuestionID)
          GetAnswer(SharedQuestion.QuestionID)
          SH.FindListViewItem(lvOdp, IdAnswer)
        End If
      End With
    Catch err As MySqlException
      Select Case err.Number
        Case 1062
          MessageBox.Show("Podany użytkownik już istnieje." + vbNewLine + "Spróbuj innej nazwy.")
        Case Else
          MessageBox.Show(err.Message + vbNewLine + "Numer błędu: " + err.Number.ToString)
      End Select
    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
  End Sub

  Private Sub cmdEditOdp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditOdp.Click
    EditAnswerData()
  End Sub

  Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint, Panel2.Paint
    Dim LinePen As New Pen(Color.White, 1)
    e.Graphics.DrawLine(LinePen, New Point(0, CType(sender, Panel).Height - 6), New Point(CType(sender, Panel).Width - 1, CType(sender, Panel).Height - 6))

  End Sub
End Class

Public Class PytaniaSQL
  Public Function SelectPytanie(ByVal IdModul As String) As String
    Return "SELECT p.ID,p.Tresc,u.Nick,p.Private,p.User,p.ComputerIP,p.Version FROM pytanie p LEFT JOIN user u ON  p.IdOwner=u.ID WHERE p.IdOwner=" & GlobalValues.gblUserID & " AND p.IdModul=" & IdModul & " UNION SELECT p.ID,p.Tresc,u.Nick,p.Private,p.User,p.ComputerIP,p.Version FROM pytanie p LEFT JOIN user u ON  p.IdOwner=u.ID WHERE p.IdModul=" & IdModul & " AND p.private=0 ORDER BY Version;"
  End Function
  Public Function SelectOdp(ByVal IdModul As String) As String
    Return "SELECT o.ID,o.TrescOdpowiedzi,o.Punktacja,o.User,o.ComputerIP,o.Version,o.IdPytanie FROM odpowiedz o INNER JOIN pytanie p ON o.IdPytanie=p.ID WHERE p.IdModul=" & IdModul & " ORDER BY o.Punktacja DESC,o.Version;"
  End Function
  Public Function SelectOdpByPytanie(ByVal IdPytanie As String) As String
    Return "SELECT o.ID,o.TrescOdpowiedzi,o.Punktacja,o.User,o.ComputerIP,o.Version FROM odpowiedz o WHERE o.IdPytanie=" & IdPytanie & " ORDER BY o.Punktacja DESC,o.Version;"
  End Function
  Public Function SelectSum(ByVal IdPytanie As String) As String
    Return "SELECT SUM(Punktacja) FROM odpowiedz WHERE IdPytanie='" & IdPytanie & "' AND Punktacja>0;"
  End Function
  Public Function InsertPytanie() As String
    Return "INSERT INTO pytanie VALUES (NULL,?Tresc,?IdModul,?IdOwner,?Private,'" + GlobalValues.gblUserName + "','" + GlobalValues.gblIP + "',NULL);"
  End Function
  Public Function InsertOdp() As String
    Return "INSERT INTO odpowiedz VALUES (NULL,?Tresc,?Punktacja,?IdPytanie,'" + GlobalValues.gblUserName + "','" + GlobalValues.gblIP + "',NULL);"
  End Function
  Public Function UpdatePytanie(ByVal IdPytanie As String) As String
    Return "UPDATE pytanie SET Tresc=?Tresc,Private=?Private,User=?User,ComputerIP=?IP WHERE ID=" & IdPytanie
  End Function
  Public Function UpdateOdp(ByVal IdOdp As String) As String
    Return "UPDATE odpowiedz SET TrescOdpowiedzi=?Tresc,Punktacja=?Punktacja,User=?User,ComputerIP=?IP WHERE ID=" & IdOdp
  End Function
  Public Function DeleteItem(ByVal T As String, ByVal ID As String) As String
    Return "DELETE FROM " & T & " WHERE ID=" & ID
  End Function
  'Public Function DeleteOdp(ByVal IdOdp As String) As String
  '  Return "DELETE FROM odpowiedz WHERE ID=" & IdOdp
  'End Function
End Class