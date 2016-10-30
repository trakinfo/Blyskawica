Public Class frmRejestrTestow
  Private DS As DataSet, QuestionID As String

  Private Sub frmUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.ListViewConfig(Me.lvRejestr)
    ListViewConfig(lvPytania)
    lblRecord.Text = ""
    lblRecord1.Text = ""
    Dim FCB As New FillComboBox, T As New TestSQL
    FCB.AddComboBoxComplexItems(cbPrzedmiot, T.SelectPrzedmiot)
    If cbPrzedmiot.Items.Count > 0 Then
      Dim SH As New SeekHelper
      SH.FindComboItem(cbPrzedmiot, CInt(SH.GetDefault(T.SelectDefault("przedmiot"))))
      cbPrzedmiot.Enabled = True
    End If
    'Me.GetData()
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
        .Columns.Add("Nazwa testu", 290, HorizontalAlignment.Left)
        .Columns.Add("Wybór", 70, HorizontalAlignment.Center)
        .Columns.Add("limit czasu", 70, HorizontalAlignment.Center)
        .Columns.Add("limit odp.", 70, HorizontalAlignment.Center)
        .Columns.Add("Status", 70, HorizontalAlignment.Center)
        .Columns.Add("Hasło", 80, HorizontalAlignment.Left)
        .Columns.Add("Kryteria", 139, HorizontalAlignment.Left)
      Else
        .Columns.Add("Pytanie", 689, HorizontalAlignment.Left)
        .Columns.Add("NrPytania", 100, HorizontalAlignment.Center)
      End If
    End With
  End Sub

  Private Sub FetchData(ByVal IdPrzedmiot As String)
    Dim DBA As New DataBaseAction, T As New TestSQL
    DS = DBA.GetDataSet(T.SelectTest(IdPrzedmiot) & T.SelectPytanieByTest(IdPrzedmiot) & T.SelectAnswer(IdPrzedmiot))
  End Sub
  Private Sub GetData()
    'Dim DBA As New DataBaseAction, T As New TestSQL
    'dtTesty = DBA.GetDataTable(T.SelectTest(IdPrzedmiot))
    Dim R As New Rijndael
    lvRejestr.Items.Clear()
    lvPytania.Items.Clear()
    lvPytania.Enabled = False
    For Each row As DataRow In DS.Tables(0).Rows
      If DS.Tables(1).Select("IdTest=" & row.Item(0).ToString).GetLength(0) < 1 Then
        Me.lvRejestr.Items.Add(row.Item(0).ToString).UseItemStyleForSubItems = False
        Me.lvRejestr.Items(Me.lvRejestr.Items.Count - 1).SubItems.Add(row.Item(1).ToString, Color.Red, lvRejestr.BackColor, lvRejestr.Font)
        Me.lvRejestr.Items(Me.lvRejestr.Items.Count - 1).SubItems.Add([Enum].GetName(GetType(GlobalValues.TypTestu), CType(row.Item(2), Integer)), Color.Red, lvRejestr.BackColor, lvRejestr.Font)
        Me.lvRejestr.Items(Me.lvRejestr.Items.Count - 1).SubItems.Add(row.Item(3).ToString, Color.Red, lvRejestr.BackColor, lvRejestr.Font)
        Me.lvRejestr.Items(Me.lvRejestr.Items.Count - 1).SubItems.Add(row.Item(4).ToString, Color.Red, lvRejestr.BackColor, lvRejestr.Font)
        Me.lvRejestr.Items(Me.lvRejestr.Items.Count - 1).SubItems.Add([Enum].GetName(GetType(GlobalValues.Status), CType(row.Item(5), Integer)), Color.Red, lvRejestr.BackColor, lvRejestr.Font)
        Me.lvRejestr.Items(Me.lvRejestr.Items.Count - 1).SubItems.Add(R.Decrypt(row.Item(6).ToString), Color.Red, lvRejestr.BackColor, lvRejestr.Font)
        Me.lvRejestr.Items(Me.lvRejestr.Items.Count - 1).SubItems.Add(row.Item(7).ToString, Color.Red, lvRejestr.BackColor, lvRejestr.Font)
      Else
        Me.lvRejestr.Items.Add(row.Item(0).ToString)
        Me.lvRejestr.Items(Me.lvRejestr.Items.Count - 1).SubItems.Add(row.Item(1).ToString)
        Me.lvRejestr.Items(Me.lvRejestr.Items.Count - 1).SubItems.Add([Enum].GetName(GetType(GlobalValues.TypTestu), CType(row.Item(2), Integer)))
        Me.lvRejestr.Items(Me.lvRejestr.Items.Count - 1).SubItems.Add(row.Item(3).ToString)
        Me.lvRejestr.Items(Me.lvRejestr.Items.Count - 1).SubItems.Add(row.Item(4).ToString)
        Me.lvRejestr.Items(Me.lvRejestr.Items.Count - 1).SubItems.Add([Enum].GetName(GetType(GlobalValues.Status), CType(row.Item(5), Integer)))
        Me.lvRejestr.Items(Me.lvRejestr.Items.Count - 1).SubItems.Add(R.Decrypt(row.Item(6).ToString))
        Me.lvRejestr.Items(Me.lvRejestr.Items.Count - 1).SubItems.Add(row.Item(7).ToString, Color.Red, lvRejestr.BackColor, lvRejestr.Font)
      End If
    Next
    lblRecord.Text = "0 z " & lvRejestr.Items.Count
    lvRejestr.Columns(7).Width = CInt(IIf(lvRejestr.Items.Count > 10, 120, 139))
    Me.lvRejestr.Enabled = CType(IIf(Me.lvRejestr.Items.Count > 0, True, False), Boolean)

  End Sub
  Private Sub GetQuestion(ByVal IdTest As String)
    lvPytania.Items.Clear()
    For Each row As DataRow In DS.Tables(1).Select("IdTest=" & IdTest)
      If DS.Tables(2).Select("IdPytanie=" & row.Item(0).ToString).GetLength(0) < 2 Then
        Me.lvPytania.Items.Add(row.Item(0).ToString).UseItemStyleForSubItems = False
        Me.lvPytania.Items(Me.lvPytania.Items.Count - 1).SubItems.Add(row.Item(1).ToString, Color.Red, lvPytania.BackColor, lvPytania.Font)
        Me.lvPytania.Items(Me.lvPytania.Items.Count - 1).SubItems.Add(row.Item(2).ToString, Color.Red, lvPytania.BackColor, lvPytania.Font)
      Else
        If DS.Tables(2).Select("Punktacja>0 AND IdPytanie=" & row.Item(0).ToString).GetLength(0) > 0 AndAlso CType(DS.Tables(2).Compute("SUM(Punktacja)", "Punktacja>0 AND IdPytanie=" & row.Item(0).ToString), Integer) < 100 Then

          Me.lvPytania.Items.Add(row.Item(0).ToString).UseItemStyleForSubItems = False
          Me.lvPytania.Items(Me.lvPytania.Items.Count - 1).SubItems.Add(row.Item(1).ToString, Color.Peru, lvPytania.BackColor, lvPytania.Font)
          Me.lvPytania.Items(Me.lvPytania.Items.Count - 1).SubItems.Add(row.Item(2).ToString, Color.Peru, lvPytania.BackColor, lvPytania.Font)
        Else
          Me.lvPytania.Items.Add(row.Item(0).ToString)
          Me.lvPytania.Items(Me.lvPytania.Items.Count - 1).SubItems.Add(row.Item(1).ToString)
          Me.lvPytania.Items(Me.lvPytania.Items.Count - 1).SubItems.Add(row.Item(2).ToString)
        End If
      End If

    Next
    lblRecord1.Text = "0 z " & lvPytania.Items.Count
    lvPytania.Columns(1).Width = CInt(IIf(lvPytania.Items.Count > 17, 670, 689))
    Me.lvPytania.Enabled = CType(IIf(Me.lvPytania.Items.Count > 0, True, False), Boolean)

  End Sub
  'Private Sub AddItem(ByVal LV As ListView, ByVal Row As DataRow, ByVal ForeColor As Color, ByVal BackColor As Color, ByVal ItemFont As Font)
  '  LV.Items.Add(Row.Item(0).ToString).UseItemStyleForSubItems = False
  '  LV.Items(LV.Items.Count - 1).SubItems.Add(Row.Item(1).ToString, ForeColor, BackColor, ItemFont)
  '  LV.Items(LV.Items.Count - 1).SubItems.Add(Row.Item(2).ToString, ForeColor, BackColor, ItemFont)
  '  LV.Items(LV.Items.Count - 1).SubItems.Add([Enum].GetName(GetType(GlobalValues.TestAccess), CType(Row.Item(3), Integer)), ForeColor, BackColor, ItemFont)
  'End Sub
  Private Sub GetDetails(ByVal IdTest As String)
    Try
      lblRecord.Text = lvRejestr.SelectedItems(0).Index + 1 & " z " & lvRejestr.Items.Count

      With DS.Tables(0).Select("ID='" & IdTest & "'")(0)
        lblUser.Text = .Item(8).ToString
        lblIP.Text = .Item(9).ToString
        lblData.Text = .Item(10).ToString
      End With
    Catch err As Exception
      MessageBox.Show(err.Message)
    End Try
  End Sub
  'Private Sub GetQDetails(ByVal IdTest As String)
  '  Try
  '    lblRecord1.Text = lvPytania.SelectedItems(0).Index + 1 & " z " & lvPytania.Items.Count
  '    With DS.Tables(1).Select("ID='" & IdTest & "'")(0)
  '      lblUser.Text = .Item(3).ToString
  '      lblIP.Text = .Item(4).ToString
  '      lblData.Text = .Item(5).ToString
  '    End With
  '  Catch err As Exception
  '    MessageBox.Show(err.Message)
  '  End Try
  'End Sub

  Private Sub lvUsers_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvRejestr.DoubleClick
    Me.EditData()
  End Sub

  Private Sub lvUsers_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvRejestr.ItemSelectionChanged
    Me.ClearDetails()
    lvPytania.Items.Clear()
    cmdUp.Enabled = False
    cmdDown.Enabled = False

    If e.IsSelected Then
      SharedTest.TestID = e.Item.Text
      GetQuestion(e.Item.Text)
      GetDetails(e.Item.Text)
      cmdAktywacja.Text = IIf(e.Item.SubItems(5).Text = "Aktywny", "Deaktywacja", "Aktywacja").ToString
      EnableButtons(True)
      Me.cmdDelete.Enabled = CType(IIf(CType(DS.Tables(0).Select("ID='" & e.Item.Text & "'")(0).Item(11), GlobalValues.Privilege) = GlobalValues.Privilege.Owner, True, False), Boolean)

    Else
      EnableButtons(False)
    End If
  End Sub
  Private Sub EnableButtons(ByVal Value As Boolean)
    Me.cmdDelete.Enabled = Value
    Me.cmdEdit.Enabled = Value
    cmdAktywacja.Enabled = Value
    cmdAddPytanie.Enabled = Value
  End Sub
  Private Sub ClearDetails()
    lblRecord.Text = "0 z " & lvRejestr.Items.Count

    Me.lblUser.Text = ""
    Me.lblData.Text = ""
    Me.lblIP.Text = ""
  End Sub

  Private Sub cbPrzedmiot_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPrzedmiot.SelectedIndexChanged
    'GetData(CType(cbPrzedmiot.SelectedItem, CbItem).ID.ToString)
    EnableButtons(False)
    cmdDeletePytanie.Enabled = False
    cmdUp.Enabled = False
    cmdDown.Enabled = False

    FetchData(CType(cbPrzedmiot.SelectedItem, CbItem).ID.ToString)
    SharedTest.PrzedmiotID = CType(cbPrzedmiot.SelectedItem, CbItem).ID.ToString
    'lvPytania.Items.Clear()
    GetData()
    cmdAddNew.Enabled = CType(IIf(cbPrzedmiot.Text.Length > 0, True, False), Boolean)
    'cmdAddPytanie.Enabled = False

  End Sub

  Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
    Me.Close()
  End Sub
  Private Sub AddNew()
    Dim dlgAddNew As New dlgTest
    Dim FCB As New FillComboBox, T As New TestSQL, SH As New SeekHelper
    With dlgAddNew
      FCB.AddComboBoxSimpleItems(.cbKryteria, T.SelectKryteria)
      'SH.FindComboItem(.cbKryteria, 0)
      .Owner = Me
      .Show()
      .txtNazwa.Focus()
      AddHandler dlgAddNew.NewAdded, AddressOf NewAdded
      AddHandler dlgAddNew.FormClosed, AddressOf EnableCmdAddNew
      Me.cmdAddNew.Enabled = False
    End With
  End Sub
  Private Sub NewAdded(ByVal sender As Object, ByVal InsertedID As String)
    lvRejestr.Items.Clear()
    lvPytania.Items.Clear()
    FetchData(CType(cbPrzedmiot.SelectedItem, CbItem).ID.ToString)
    GetData()
    Dim SH As New SeekHelper
    SH.FindListViewItem(Me.lvRejestr, InsertedID)
  End Sub

  Private Sub EnableCmdAddNew(ByVal sender As Object, ByVal e As FormClosedEventArgs)
    Me.cmdAddNew.Enabled = True
  End Sub

  Private Sub cmdAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click
    AddNew()
  End Sub
  Private Sub AddQuestion()
    Dim dlgAddNew As New dlgTestQuestion
    Dim FCB As New FillComboBox, SH As New SeekHelper, T As New TestSQL
    With dlgAddNew
      FCB.AddComboBoxComplexItems(.cbModul, T.SelectModul(CType(cbPrzedmiot.SelectedItem, CbItem).ID.ToString))
      .cbModul.Enabled = CType(IIf(.cbModul.Items.Count > 0, True, False), Boolean)
      .Owner = Me
      'MessageBox.Show(CType(DS.Tables(1).Compute("Max(NrPytania)", "IdTest=" & SharedTest.TestID), String))
      If DS.Tables(1).Select("IdTest=" & SharedTest.TestID).GetLength(0) > 0 Then
        .QuestionNr = CType(DS.Tables(1).Compute("Max(NrPytania)", "IdTest=" & SharedTest.TestID), Byte)
      Else
        .QuestionNr = 0
      End If
      .Show()
      AddHandler dlgAddNew.NewAdded, AddressOf NewQuestionAdded
      AddHandler dlgAddNew.FormClosed, AddressOf EnableCmdAddNew
      'Me.cmdAddNew.Enabled = False
    End With

  End Sub
  Private Sub NewQuestionAdded(ByVal sender As Object, ByVal InsertedID As String)
    'lvRejestr.Items.Clear()
    'lvPytania.Items.Clear()
    FetchData(CType(cbPrzedmiot.SelectedItem, CbItem).ID.ToString)
    GetData()
    Dim SH As New SeekHelper
    SH.FindListViewItem(Me.lvRejestr, SharedTest.TestID)
    SH.FindListViewItem(lvPytania, InsertedID)
  End Sub
  Private Sub cmdAddPytanie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddPytanie.Click
    AddQuestion()
  End Sub

  Private Sub lvPytania_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvPytania.DoubleClick
    Dim dlg As New dlgAnswersByQuestion
    With dlg
      'Dim P As New PytaniaSQL
      SharedQuestion.QuestionID = lvPytania.SelectedItems(0).Text
      .txtQuestion.Text = lvPytania.SelectedItems(0).SubItems(1).Text
      dlg.Owner = Me
      dlg.ShowDialog()
    End With
  End Sub

  Private Sub lvPytania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvPytania.ItemSelectionChanged
    If e.IsSelected Then
      QuestionID = e.Item.Text
      cmdDeletePytanie.Enabled = CType(IIf(CType(DS.Tables(0).Select("ID='" & SharedTest.TestID & "'")(0).Item(11), GlobalValues.Privilege) = GlobalValues.Privilege.Owner, True, False), Boolean)
      lblRecord1.Text = lvPytania.SelectedItems(0).Index + 1 & " z " & lvPytania.Items.Count
      If e.ItemIndex > 0 AndAlso e.ItemIndex < e.Item.ListView.Items.Count - 1 Then
        cmdUp.Enabled = True
        cmdDown.Enabled = True
      ElseIf e.ItemIndex = 0 AndAlso e.Item.ListView.Items.Count = 1 Then
        cmdUp.Enabled = False
        cmdDown.Enabled = False
      ElseIf e.ItemIndex = 0 AndAlso e.Item.ListView.Items.Count > 0 Then
        cmdUp.Enabled = False
        cmdDown.Enabled = True
      ElseIf e.ItemIndex = e.Item.ListView.Items.Count - 1 AndAlso e.Item.ListView.Items.Count > 1 Then
        cmdUp.Enabled = True
        cmdDown.Enabled = False
      End If
    Else
      QuestionID = Nothing
      cmdDeletePytanie.Enabled = False
      cmdUp.Enabled = False
      cmdDown.Enabled = False
      lblRecord1.Text = "0 z " & lvPytania.Items.Count
    End If
  End Sub

  Private Sub cmdDeletePytanie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeletePytanie.Click
    Dim DBA As New DataBaseAction, DeletedIndex As Integer, T As New TestSQL

    For Each Item As ListViewItem In Me.lvPytania.SelectedItems
      DeletedIndex = Item.Index
      DBA.ApplyChanges(T.DeletePytanie(SharedTest.TestID, Item.Text))
    Next

    'Me.EnableQuestionButtons(False)
    EnableButtons(False)

    lvRejestr.Items.Clear()
    lvPytania.Items.Clear()
    FetchData(CType(cbPrzedmiot.SelectedItem, CbItem).ID.ToString)
    Me.GetData()
    Dim SH As New SeekHelper
    SH.FindListViewItem(Me.lvRejestr, SharedTest.TestID)
    SH.FindRemovedListViewItemIndex(Me.lvPytania, DeletedIndex)

  End Sub

  Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
    Dim DBA As New DataBaseAction, DeletedIndex As Integer, T As New TestSQL

    For Each Item As ListViewItem In Me.lvRejestr.SelectedItems
      DeletedIndex = Item.Index
      DBA.ApplyChanges(T.DeleteTest(Item.Text))
    Next

    'Me.EnableQuestionButtons(False)
    EnableButtons(False)
    cmdDeletePytanie.Enabled = False
    lvRejestr.Items.Clear()
    lvPytania.Items.Clear()
    FetchData(CType(cbPrzedmiot.SelectedItem, CbItem).ID.ToString)
    Me.GetData()
    Dim SH As New SeekHelper
    SH.FindRemovedListViewItemIndex(Me.lvRejestr, DeletedIndex)

  End Sub

  Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
    EditData()
  End Sub
  Private Sub EditData()
    Dim dlgEdit As New dlgTest
    Dim FCB As New FillComboBox, T As New TestSQL

    Try
      With dlgEdit
        .Text = "Edycja testu"
        .txtNazwa.Text = Me.lvRejestr.SelectedItems(0).SubItems(1).Text
        .chkMultiChoice.CheckState = CType(IIf(lvRejestr.SelectedItems(0).SubItems(2).Text = [Enum].GetName(GetType(GlobalValues.TypTestu), GlobalValues.TypTestu.Wielokrotny), 1, 0), CheckState)
        .nudLimitCzasu.Value = CType(lvRejestr.SelectedItems(0).SubItems(3).Text, Integer)
        .nudLimitOdp.Value = CType(lvRejestr.SelectedItems(0).SubItems(4).Text, Integer)
        .txtPassword.Text = Me.lvRejestr.SelectedItems(0).SubItems(6).Text
        FCB.AddComboBoxSimpleItems(.cbKryteria, T.SelectKryteria)
        If Me.lvRejestr.SelectedItems(0).SubItems(7).Text.Length > 0 Then
          Dim SH As New SeekHelper
          SH.FindComboItem(.cbKryteria, Me.lvRejestr.SelectedItems(0).SubItems(7).Text)
          cbPrzedmiot.Enabled = True
        End If

        .OK_Button.Text = "Zapisz"
        .Icon = GlobalValues.gblAppIcon
        If .ShowDialog = Windows.Forms.DialogResult.OK Then
          Dim DBA As New DataBaseAction, IdTest As String ', T As New TestSQL
          IdTest = Me.lvRejestr.SelectedItems(0).Text
          Dim cmd As MySqlCommand = DBA.CreateCommand(T.UpdateTest(IdTest, CType(IIf(.cbKryteria.Text.Length > 0, False, True), Boolean)))
          Dim R As New Rijndael

          cmd.Parameters.AddWithValue("?Nazwa", .txtNazwa.Text)
          cmd.Parameters.AddWithValue("?LimitCzasu", CType(.nudLimitCzasu.Value, Byte))
          cmd.Parameters.AddWithValue("?LimitOdpowiedzi", CType(.nudLimitOdp.Value, Byte))
          cmd.Parameters.AddWithValue("?WyborWielokrotny", CType(.chkMultiChoice.CheckState, Byte))
          cmd.Parameters.AddWithValue("?Haslo", R.Encrypt(.txtPassword.Text))
          'cmd.Parameters.AddWithValue("?NazwaKryterium", IIf(.cbKryteria.Text.Length > 0, .cbKryteria.Text, "").ToString)
          If .cbKryteria.Text.Length > 0 Then cmd.Parameters.AddWithValue("?NazwaKryterium", .cbKryteria.Text)

          cmd.Parameters.AddWithValue("?User", GlobalValues.gblUserName)
          cmd.Parameters.AddWithValue("?IP", GlobalValues.gblIP)

          cmd.ExecuteNonQuery()
          Me.lvRejestr.Items.Clear()
          lvPytania.Items.Clear()
          FetchData(CType(cbPrzedmiot.SelectedItem, CbItem).ID.ToString)
          Me.GetData()
          Dim SH As New SeekHelper
          SH.FindListViewItem(Me.lvRejestr, SharedTest.TestID)
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


  Private Sub cmdAktywacja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAktywacja.Click
    Try
      Dim DBA As New DataBaseAction, T As New TestSQL
      Dim cmd As MySqlCommand = DBA.CreateCommand(T.UpdateStatus(SharedTest.TestID))
      cmd.Parameters.AddWithValue("?Status", CType(IIf(CType(DS.Tables(0).Select("ID=" & SharedTest.TestID)(0).Item(5), Integer) = 1, 0, 1), Integer))
      cmd.Parameters.AddWithValue("?User", GlobalValues.gblUserName)
      cmd.Parameters.AddWithValue("?IP", GlobalValues.gblIP)

      cmd.ExecuteNonQuery()
      Me.lvRejestr.Items.Clear()
      lvPytania.Items.Clear()
      FetchData(CType(cbPrzedmiot.SelectedItem, CbItem).ID.ToString)
      Me.GetData()
      Dim SH As New SeekHelper
      SH.FindListViewItem(Me.lvRejestr, SharedTest.TestID)

    Catch mex As MySqlException
      MessageBox.Show(mex.Message)
    End Try

  End Sub

  Private Sub cmdUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUp.Click, cmdDown.Click
    Dim DBA As New DataBaseAction, T As New TestSQL
    Dim MySQLTrans As MySqlTransaction
    MySQLTrans = GlobalValues.gblConn.BeginTransaction()

    If CType(sender, Button).Name = "cmdUp" Then
      Dim cmd As MySqlCommand = DBA.CreateCommand(T.UpdateQuestionNumber(lvPytania.Items(lvPytania.SelectedItems(0).Index - 1).Text, SharedTest.TestID))
      cmd.Transaction = MySQLTrans
      Dim cmd1 As MySqlCommand = DBA.CreateCommand(T.UpdateQuestionNumber(lvPytania.SelectedItems(0).Text, SharedTest.TestID))
      cmd1.Transaction = MySQLTrans
      Try
        cmd.Parameters.AddWithValue("?NrPytania", lvPytania.SelectedItems(0).SubItems(2).Text)
        cmd.Parameters.AddWithValue("?User", GlobalValues.gblUserName)
        cmd.Parameters.AddWithValue("?IP", GlobalValues.gblIP)
        cmd.ExecuteNonQuery()

        cmd1.Parameters.AddWithValue("?NrPytania", CType(lvPytania.SelectedItems(0).SubItems(2).Text, Byte) - 1)
        cmd1.Parameters.AddWithValue("?User", GlobalValues.gblUserName)
        cmd1.Parameters.AddWithValue("?IP", GlobalValues.gblIP)
        cmd1.ExecuteNonQuery()
        MySQLTrans.Commit()
        Me.lvRejestr.Items.Clear()
        lvPytania.Items.Clear()
        FetchData(CType(cbPrzedmiot.SelectedItem, CbItem).ID.ToString)
        Me.GetData()
        Dim SH As New SeekHelper
        SH.FindListViewItem(Me.lvRejestr, SharedTest.TestID)
        SH.FindListViewItem(lvPytania, QuestionID)
      Catch mex As MySqlException
        MySQLTrans.Rollback()
        MessageBox.Show(mex.Message)
      End Try

    Else
      Dim cmd As MySqlCommand = DBA.CreateCommand(T.UpdateQuestionNumber(lvPytania.Items(lvPytania.SelectedItems(0).Index + 1).Text, SharedTest.TestID))
      cmd.Transaction = MySQLTrans
      Dim cmd1 As MySqlCommand = DBA.CreateCommand(T.UpdateQuestionNumber(lvPytania.SelectedItems(0).Text, SharedTest.TestID))
      cmd1.Transaction = MySQLTrans
      Try
        cmd.Parameters.AddWithValue("?NrPytania", lvPytania.SelectedItems(0).SubItems(2).Text)
        cmd.Parameters.AddWithValue("?User", GlobalValues.gblUserName)
        cmd.Parameters.AddWithValue("?IP", GlobalValues.gblIP)
        cmd.ExecuteNonQuery()

        cmd1.Parameters.AddWithValue("?NrPytania", CType(lvPytania.SelectedItems(0).SubItems(2).Text, Byte) + 1)
        cmd1.Parameters.AddWithValue("?User", GlobalValues.gblUserName)
        cmd1.Parameters.AddWithValue("?IP", GlobalValues.gblIP)
        cmd1.ExecuteNonQuery()
        MySQLTrans.Commit()
        Me.lvRejestr.Items.Clear()
        lvPytania.Items.Clear()
        FetchData(CType(cbPrzedmiot.SelectedItem, CbItem).ID.ToString)
        Me.GetData()
        Dim SH As New SeekHelper
        SH.FindListViewItem(Me.lvRejestr, SharedTest.TestID)
        SH.FindListViewItem(lvPytania, QuestionID)
      Catch mex As MySqlException
        MySQLTrans.Rollback()
        MessageBox.Show(mex.Message)
      End Try
    End If

  End Sub

  Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint, Panel3.Paint
    Dim LinePen As New Pen(Color.White, 1)
    e.Graphics.DrawLine(LinePen, New Point(0, CType(sender, Panel).Height - 4), New Point(CType(sender, Panel).Width - 1, CType(sender, Panel).Height - 4))

  End Sub
End Class

Public Class TestSQL
  Public Function SelectTest(ByVal IdPrzedmiot As String) As String
    Return "SELECT t.ID,t.Nazwa,t.WyborWielokrotny,t.LimitCzasu,t.LimitOdpowiedzi,t.Status,t.Haslo,t.NazwaKryterium,t.User,t.ComputerIP,t.Version,ut.Privilege FROM test t INNER JOIN user_test ut ON t.ID=ut.IdTest WHERE IdPrzedmiot='" & IdPrzedmiot & "' AND ut.IdUser='" & GlobalValues.gblUserID & "' Order BY Nazwa;"
  End Function
  Public Function SelectPytanieByTest(ByVal IdPrzedmiot As String) As String
    Return "SELECT p.ID,p.Tresc,tp.NrPytania,tp.User,tp.ComputerIP,tp.Version,tp.Idtest FROM pytanie p INNER JOIN test_pytanie tp ON p.ID=tp.IdPytanie INNER JOIN test t ON tp.IdTest=t.ID WHERE t.IdPrzedmiot='" & IdPrzedmiot & "'ORDER BY tp.NrPytania,IdPytanie;"
  End Function
  Public Function SelectPytanie(ByVal IdPrzedmiot As String, ByVal IdTest As String) As String
    Return "SELECT p.ID,p.Tresc,u.Nick,p.IdModul,p.Version FROM pytanie p LEFT JOIN user u ON p.IdOwner=u.ID WHERE p.IdOwner=" & GlobalValues.gblUserID & " AND p.IdModul IN (SELECT ID FROM modul WHERE IdPrzedmiot='" & IdPrzedmiot & "') AND p.ID NOT IN (SELECT IdPytanie FROM test_pytanie WHERE IdTest=" & IdTest & ") UNION SELECT p.ID,p.Tresc,u.Nick,p.IdModul,p.Version FROM pytanie p LEFT JOIN user u ON  p.IdOwner=u.ID WHERE p.IdModul IN (SELECT ID FROM modul WHERE IdPrzedmiot='" & IdPrzedmiot & "') AND p.ID NOT IN (SELECT IdPytanie FROM test_pytanie WHERE IdTest=" & IdTest & ") AND p.private=0 ORDER BY Version;"
  End Function
  Public Function SelectAnswer(ByVal IdPrzedmiot As String) As String
    Return "SELECT o.ID,o.Punktacja,o.IdPytanie FROM odpowiedz o INNER JOIN pytanie p ON o.IdPytanie=p.ID WHERE p.IdModul IN (SELECT ID FROM modul m WHERE m.IdPrzedmiot=" & IdPrzedmiot & ");"
  End Function
  Public Function SelectPrzedmiot() As String
    Return "SELECT ID,Nazwa FROM przedmiot Order By Nazwa;"
  End Function
  Public Function SelectModul(ByVal IdPrzedmiot As String) As String
    Return "SELECT ID,Nazwa FROM modul WHERE IdPrzedmiot='" & IdPrzedmiot & "' ORDER BY Nazwa,Version;"
  End Function
  Public Function SelectKryteria() As String
    Return "SELECT Nazwa FROM kryteria Order By Nazwa;"
  End Function
  Public Function SelectDefault(ByVal Table As String) As String
    Return "SELECT ID FROM " & Table & " WHERE IsDefault=1;"
  End Function
  Public Function InsertTest(ByVal NullKryterium As Boolean) As String
    Return "INSERT INTO test(ID,Nazwa,IdPrzedmiot,LimitCzasu,LimitOdpowiedzi,WyborWielokrotny,Status,Haslo,NazwaKryterium,User,ComputerIP,Version) VALUES(NULL,?Nazwa,?IdPrzedmiot,?LimitCzasu,?LimitOdpowiedzi,?WyborWielokrotny,?Status,?Haslo," & IIf(NullKryterium, "NULL", "?NazwaKryterium").ToString & ",'" + GlobalValues.gblUserName + "','" + GlobalValues.gblIP + "',NULL);"
  End Function
  Public Function InsertPrzydzial() As String
    Return "INSERT INTO test_pytanie VALUES (?IdTest,?IdPytanie,?NrPytania,'" + GlobalValues.gblUserName + "','" + GlobalValues.gblIP + "',NULL);"
  End Function
  Public Function InsertOwnership() As String
    Return "INSERT INTO user_test VALUES(?IdUser,?IdTest,?Privilege,'" + GlobalValues.gblUserName + "','" + GlobalValues.gblIP + "',NULL);"
  End Function
  Public Function InsertPytanie() As String
    Return "INSERT INTO test_pytanie VALUES(?IdTest,?IdPytanie,?NrPytania,'" + GlobalValues.gblUserName + "','" + GlobalValues.gblIP + "',NULL);"
  End Function
  Public Function UpdateTest(ByVal IdTest As String, ByVal NullKryterium As Boolean) As String
    Return "UPDATE test SET Nazwa=?Nazwa,LimitCzasu=?LimitCzasu,LimitOdpowiedzi=?LimitOdpowiedzi,WyborWielokrotny=?WyborWielokrotny,Haslo=?Haslo,NazwaKryterium=" & IIf(NullKryterium, "NULL", "?NazwaKryterium").ToString & ",User=?User,ComputerIP=?IP,Version=NULL WHERE ID=" & IdTest
  End Function
  Public Function UpdateStatus(ByVal IdTest As String) As String
    Return "UPDATE test SET Status=?Status,User=?User,ComputerIP=?IP,Version=NULL WHERE ID=" & IdTest
  End Function
  Public Function UpdateQuestionNumber(ByVal IdPytanie As String, ByVal IdTest As String) As String
    Return "UPDATE test_pytanie SET NrPytania=?NrPytania,User=?User,ComputerIP=?IP,Version=NULL WHERE IdTest='" & IdTest & "' AND IdPytanie='" & IdPytanie & "';"
  End Function
  Public Function DeleteTest(ByVal IdTest As String) As String
    Return "DELETE FROM test WHERE ID=" & IdTest
  End Function
  Public Function DeletePytanie(ByVal IdTest As String, ByVal IdPytanie As String) As String
    Return "DELETE FROM test_pytanie WHERE IdTest='" & IdTest & "' AND IdPytanie='" & IdPytanie & "';"
  End Function

End Class