Public Class frmKryteria
  Private DS As DataSet

  Private Sub frmUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.ListViewConfig(Me.lvNazwaKryterium)
    ListViewConfig(lvKryterium)
    lblRecord.Text = ""
    lblRecord1.Text = ""
    FetchData()
    Me.GetData()
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
      If lv.Name = "lvNazwaKryterium" Then
        .Columns.Add("Nazwa kryterium", 320, HorizontalAlignment.Left)
        .Columns.Add("Właściciel", 100, HorizontalAlignment.Center)
      Else
        .Columns.Add("ID", 0, HorizontalAlignment.Left)
        .Columns.Add("Minimum", 100, HorizontalAlignment.Center)
        .Columns.Add("Maksimum", 100, HorizontalAlignment.Center)
        .Columns.Add("Ocena", 220, HorizontalAlignment.Left)
      End If
    End With
  End Sub

  Private Sub FetchData()
    Dim DBA As New DataBaseAction, K As New KryteriaSQL
    DS = DBA.GetDataSet(K.SelectKryteria & K.SelectDetails & K.SelectOwner)
  End Sub
  Private Sub GetData()
    lvNazwaKryterium.Items.Clear()
    lvKryterium.Items.Clear()
    lvKryterium.Enabled = False
    For Each row As DataRow In DS.Tables(0).Rows
      If CType(row.Item(4), GlobalValues.Privilege) = GlobalValues.Privilege.Owner Then
        Me.lvNazwaKryterium.Items.Add(row.Item(0).ToString).UseItemStyleForSubItems = False
        Me.lvNazwaKryterium.Items(Me.lvNazwaKryterium.Items.Count - 1).SubItems.Add(DS.Tables(2).Select("Nazwa='" & row.Item(0).ToString & "'")(0).Item(0).ToString)
      Else
        Dim lvItem As New ListViewItem
        lvItem.Text = row.Item(0).ToString
        lvItem.SubItems.Add(DS.Tables(2).Select("Nazwa='" & row.Item(0).ToString & "'")(0).Item(0).ToString)
        lvItem.ForeColor = Color.Peru
        Me.lvNazwaKryterium.Items.Add(lvItem)
        
      End If
    Next
    lblRecord.Text = "0 z " & lvNazwaKryterium.Items.Count
    lvNazwaKryterium.Columns(0).Width = CInt(IIf(lvNazwaKryterium.Items.Count > 5, 301, 320))
    Me.lvNazwaKryterium.Enabled = CType(IIf(Me.lvNazwaKryterium.Items.Count > 0, True, False), Boolean)

  End Sub
  Private Sub GetItems(ByVal Nazwa As String)
    lvKryterium.Items.Clear()
    For Each row As DataRow In DS.Tables(1).Select("NazwaKryterium='" & Nazwa & "'")
      Me.lvKryterium.Items.Add(row.Item(0).ToString)
      Me.lvKryterium.Items(Me.lvKryterium.Items.Count - 1).SubItems.Add(row.Item(1).ToString)
      Me.lvKryterium.Items(Me.lvKryterium.Items.Count - 1).SubItems.Add(row.Item(2).ToString)
      Me.lvKryterium.Items(Me.lvKryterium.Items.Count - 1).SubItems.Add(row.Item(3).ToString)
    Next
    lblRecord1.Text = "0 z " & lvKryterium.Items.Count
    lvKryterium.Columns(3).Width = CInt(IIf(lvKryterium.Items.Count > 17, 201, 220))
    Me.lvKryterium.Enabled = CType(IIf(Me.lvKryterium.Items.Count > 0, True, False), Boolean)

  End Sub

  Private Sub GetDetails(ByVal Nazwa As String)
    Try
      lblRecord.Text = lvNazwaKryterium.SelectedItems(0).Index + 1 & " z " & lvNazwaKryterium.Items.Count

      With DS.Tables(0).Select("Nazwa='" & Nazwa & "'")(0)
        lblUser.Text = .Item(1).ToString
        lblIP.Text = .Item(2).ToString
        lblData.Text = .Item(3).ToString
      End With
    Catch err As Exception
      MessageBox.Show(err.Message)
    End Try
  End Sub
  Private Sub GetKDetails(ByVal ID As String)
    Try
      lblRecord1.Text = lvKryterium.SelectedItems(0).Index + 1 & " z " & lvKryterium.Items.Count
      With DS.Tables(1).Select("ID='" & ID & "'")(0)
        lblUser.Text = .Item(4).ToString
        lblIP.Text = .Item(5).ToString
        lblData.Text = .Item(6).ToString
      End With
    Catch err As Exception
      MessageBox.Show(err.Message)
    End Try
  End Sub

  Private Sub lvUsers_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvNazwaKryterium.DoubleClick
    Me.EditData()
  End Sub

  Private Sub lvUsers_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvNazwaKryterium.ItemSelectionChanged
    Me.ClearDetails()
    lvKryterium.Items.Clear()
    If e.IsSelected Then
      SharedKryterium.NazwaKryteriow = e.Item.Text
      GetItems(e.Item.Text)
      GetDetails(e.Item.Text)
      'EnableButtons(True)
      cmdEdit.Enabled = CType(IIf(CType(DS.Tables(0).Select("Nazwa='" & e.Item.Text & "'")(0).Item(4), GlobalValues.Privilege) = GlobalValues.Privilege.Owner, True, False), Boolean)
      Me.cmdDelete.Enabled = CType(IIf(CType(DS.Tables(0).Select("Nazwa='" & e.Item.Text & "'")(0).Item(4), GlobalValues.Privilege) = GlobalValues.Privilege.Owner, True, False), Boolean)
      cmdNewDetail.Enabled = CType(IIf(CType(DS.Tables(0).Select("Nazwa='" & e.Item.Text & "'")(0).Item(4), GlobalValues.Privilege) = GlobalValues.Privilege.Owner, True, False), Boolean)
    Else
      EnableButtons(False)
      cmdEditDetail.Enabled = False
      cmdDeleteDetail.Enabled = False
    End If
  End Sub
  Private Sub EnableButtons(ByVal Value As Boolean)
    Me.cmdDelete.Enabled = Value
    Me.cmdEdit.Enabled = Value
    cmdNewDetail.Enabled = Value
  End Sub
  Private Sub ClearDetails()
    lblRecord.Text = "0 z " & lvNazwaKryterium.Items.Count

    Me.lblUser.Text = ""
    Me.lblData.Text = ""
    Me.lblIP.Text = ""
  End Sub


  Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
    Me.Close()
  End Sub
  Private Sub AddNew()
    Dim dlgAddNew As New dlgKryteria
    Dim K As New KryteriaSQL
    With dlgAddNew
      .Owner = Me
      .Show()
      .txtNazwa.Focus()
      AddHandler dlgAddNew.NewAdded, AddressOf NewAdded
      AddHandler dlgAddNew.FormClosed, AddressOf EnableCmdAddNew
      Me.cmdAddNew.Enabled = False
    End With
  End Sub
  Private Sub NewAdded(ByVal sender As Object, ByVal InsertedID As String)
    lvNazwaKryterium.Items.Clear()
    lvKryterium.Items.Clear()
    FetchData()
    GetData()
    Dim SH As New SeekHelper
    SH.FindListViewItem(Me.lvNazwaKryterium, InsertedID)
  End Sub

  Private Sub EnableCmdAddNew(ByVal sender As Object, ByVal e As FormClosedEventArgs)
    Me.cmdAddNew.Enabled = True
  End Sub

  Private Sub cmdAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click
    AddNew()
  End Sub
  Private Sub AddDetail()
    Dim dlgAddNew As New dlgKryterium
    Dim K As New KryteriaSQL
    With dlgAddNew
      .Owner = Me
      If DS.Tables(1).Select("NazwaKryterium='" & SharedKryterium.NazwaKryteriow & "'").GetLength(0) > 0 Then
        'MessageBox.Show(CType(DS.Tables(1).Compute("Max(Max)", "NazwaKryterium='" & SharedKryterium.NazwaKryteriow & "'"), Short).ToString)
        .nudMin.Value = CType(DS.Tables(1).Compute("Max(Max)", "NazwaKryterium='" & SharedKryterium.NazwaKryteriow & "'"), Short)
        '.nudMin.Value = CType(IIf(.nudMin.Maximum <= CType(DS.Tables(1).Compute("Max(Max)", "NazwaKryterium='" & SharedKryterium.NazwaKryteriow & "'"), Short), 0, CType(DS.Tables(1).Compute("Max(Max)", "NazwaKryterium='" & SharedKryterium.NazwaKryteriow & "'"), Short) + 1), Short)
        .nudMax.Value = .nudMin.Value 'CType(IIf(.nudMax.Maximum <= .nudMin.Value, 0, .nudMin.Value), Short)
        '.nudMax.Value = CType(IIf(.nudMax.Maximum <= .nudMin.Value, 0, .nudMin.Value + 1), Short)

      End If
      .Show()
      AddHandler dlgAddNew.NewAdded, AddressOf NewDetailAdded
      AddHandler dlgAddNew.FormClosed, AddressOf EnableCmdAddNew
      'Me.cmdAddNew.Enabled = False
    End With

  End Sub
  Private Sub NewDetailAdded(ByVal sender As Object, ByVal InsertedID As String)
    FetchData()
    GetData()
    Dim SH As New SeekHelper
    SH.FindListViewItem(Me.lvNazwaKryterium, SharedKryterium.NazwaKryteriow)
    SH.FindListViewItem(lvKryterium, InsertedID)
  End Sub

  Private Sub lvPytania_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvKryterium.DoubleClick
    EditDetail()
  End Sub

  Private Sub lvPytania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvKryterium.ItemSelectionChanged
    ClearDetails()
    If e.IsSelected Then
      cmdEditDetail.Enabled = CType(IIf(CType(DS.Tables(0).Select("Nazwa='" & SharedKryterium.NazwaKryteriow & "'")(0).Item(4), GlobalValues.Privilege) = GlobalValues.Privilege.Owner, True, False), Boolean) 'True
      cmdDeleteDetail.Enabled = CType(IIf(CType(DS.Tables(0).Select("Nazwa='" & SharedKryterium.NazwaKryteriow & "'")(0).Item(4), GlobalValues.Privilege) = GlobalValues.Privilege.Owner, True, False), Boolean)
      GetKDetails(e.Item.Text)
      lblRecord1.Text = lvKryterium.SelectedItems(0).Index + 1 & " z " & lvKryterium.Items.Count
    Else
      cmdEditDetail.Enabled = False
      cmdDeleteDetail.Enabled = False
      lblRecord1.Text = "0 z " & lvKryterium.Items.Count
    End If
  End Sub

  Private Sub cmdDeletePytanie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeleteDetail.Click
    Dim DBA As New DataBaseAction, DeletedIndex As Integer, K As New KryteriaSQL

    For Each Item As ListViewItem In Me.lvKryterium.SelectedItems
      DeletedIndex = Item.Index
      DBA.ApplyChanges(K.DeleteKryterium(Item.Text))
    Next

    'Me.EnableQuestionButtons(False)
    EnableButtons(False)

    lvNazwaKryterium.Items.Clear()
    lvKryterium.Items.Clear()
    FetchData()
    Me.GetData()
    Dim SH As New SeekHelper
    SH.FindListViewItem(Me.lvNazwaKryterium, SharedKryterium.NazwaKryteriow)
    SH.FindRemovedListViewItemIndex(Me.lvKryterium, DeletedIndex)

  End Sub

  Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
    Dim DBA As New DataBaseAction, DeletedIndex As Integer, K As New KryteriaSQL

    For Each Item As ListViewItem In Me.lvNazwaKryterium.SelectedItems
      DeletedIndex = Item.Index
      DBA.ApplyChanges(K.DeleteNazwa(Item.Text))
    Next

    'Me.EnableQuestionButtons(False)
    EnableButtons(False)
    cmdDeleteDetail.Enabled = False
    lvNazwaKryterium.Items.Clear()
    lvKryterium.Items.Clear()
    FetchData()
    Me.GetData()
    Dim SH As New SeekHelper
    SH.FindRemovedListViewItemIndex(Me.lvNazwaKryterium, DeletedIndex)

  End Sub

  Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
    EditData()
  End Sub
  Private Sub EditData()
    Dim dlgEdit As New dlgKryteria
    Try
      With dlgEdit
        .Text = "Edycja nazwy kryteriów"
        .txtNazwa.Text = Me.lvNazwaKryterium.SelectedItems(0).Text
        .OK_Button.Text = "Zapisz"
        .Icon = GlobalValues.gblAppIcon
        If .ShowDialog = Windows.Forms.DialogResult.OK Then
          Dim DBA As New DataBaseAction, Nazwa As String, K As New KryteriaSQL
          Nazwa = Me.lvNazwaKryterium.SelectedItems(0).Text
          Dim cmd As MySqlCommand = DBA.CreateCommand(K.UpdateNazwa(Nazwa))

          cmd.Parameters.AddWithValue("?Nazwa", .txtNazwa.Text)
          cmd.Parameters.AddWithValue("?User", GlobalValues.gblUserName)
          cmd.Parameters.AddWithValue("?IP", GlobalValues.gblIP)

          cmd.ExecuteNonQuery()
          Me.lvNazwaKryterium.Items.Clear()
          lvKryterium.Items.Clear()
          FetchData()
          Me.GetData()
          Dim SH As New SeekHelper
          SH.FindListViewItem(Me.lvNazwaKryterium, SharedTest.TestID)
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
  Private Sub EditDetail()
    Dim dlgEdit As New dlgKryterium
    Try
      With dlgEdit
        .Text = "Edycja kryterium"
        .nudMin.Value = CType(Me.lvKryterium.SelectedItems(0).SubItems(1).Text, Decimal)
        .nudMax.Value = CType(Me.lvKryterium.SelectedItems(0).SubItems(2).Text, Decimal)
        .txtOcena.Text = Me.lvKryterium.SelectedItems(0).SubItems(3).Text
        .OK_Button.Text = "Zapisz"
        .Icon = GlobalValues.gblAppIcon
        If .ShowDialog = Windows.Forms.DialogResult.OK Then
          Dim DBA As New DataBaseAction, ID As String, K As New KryteriaSQL
          ID = Me.lvKryterium.SelectedItems(0).Text
          Dim cmd As MySqlCommand = DBA.CreateCommand(K.UpdateKryterium(ID))

          cmd.Parameters.AddWithValue("?Min", CType(.nudMin.Value, Single))
          cmd.Parameters.AddWithValue("?Max", CType(.nudMax.Value, Single))
          cmd.Parameters.AddWithValue("?Ocena", .txtOcena.Text)
          cmd.Parameters.AddWithValue("?User", GlobalValues.gblUserName)
          cmd.Parameters.AddWithValue("?IP", GlobalValues.gblIP)

          cmd.ExecuteNonQuery()
          Me.lvNazwaKryterium.Items.Clear()
          lvKryterium.Items.Clear()
          FetchData()
          Me.GetData()
          Dim SH As New SeekHelper
          SH.FindListViewItem(Me.lvNazwaKryterium, SharedKryterium.NazwaKryteriow)
          GetDetails(SharedKryterium.NazwaKryteriow)
          SH.FindListViewItem(Me.lvKryterium, ID)

        End If
      End With
    Catch err As MySqlException
      Select Case err.Number
        Case 1062
          MessageBox.Show(err.Message)
          MessageBox.Show("Podany użytkownik już istnieje." + vbNewLine + "Spróbuj innej nazwy.")
        Case Else
          MessageBox.Show(err.Message + vbNewLine + "Numer błędu: " + err.Number.ToString)
      End Select
    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
  End Sub

  Private Sub cmdNewDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewDetail.Click
    AddDetail()
  End Sub

  'Private Sub lvKryterium_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvKryterium.DoubleClick
  '  EditDetail()
  'End Sub

  Private Sub cmdEditDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditDetail.Click
    EditDetail()
  End Sub

  Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint, Panel3.Paint
    Dim LinePen As New Pen(Color.White, 1)
    e.Graphics.DrawLine(LinePen, New Point(0, CType(sender, Panel).Height - 4), New Point(CType(sender, Panel).Width - 1, CType(sender, Panel).Height - 4))
  End Sub

End Class

Public Class KryteriaSQL
  Public Function SelectKryteria() As String
    Return "SELECT k.Nazwa,k.User,k.ComputerIP,k.Version,uk.Privilege FROM kryteria k INNER JOIN user_kryteria uk ON k.Nazwa=uk.Nazwa WHERE uk.IdUser='" & GlobalValues.gblUserID & "' Order BY Nazwa;"
  End Function
  Public Function SelectDetails() As String
    Return "SELECT k.ID,k.Min,k.Max,k.Ocena,k.User,k.ComputerIP,k.Version,k.NazwaKryterium FROM kryterium k ORDER BY k.NazwaKryterium,k.Min;"
  End Function
  Public Function SelectOwner() As String
    Return "SELECT u.Nick,uk.Nazwa FROM user u INNER JOIN user_kryteria uk ON uk.IdUser=u.ID WHERE uk.Privilege='2';"
  End Function
  Public Function InsertNazwa() As String
    Return "INSERT INTO kryteria VALUES(?Nazwa,'" + GlobalValues.gblUserName + "','" + GlobalValues.gblIP + "',NULL);"
  End Function
  Public Function InsertKryterium() As String
    Return "INSERT INTO kryterium VALUES(NULL,?NazwaKryterium,?Min,?Max,?Ocena,'" + GlobalValues.gblUserName + "','" + GlobalValues.gblIP + "',NULL);"
  End Function
  Public Function InsertOwnership() As String
    Return "INSERT INTO user_kryteria VALUES(?IdUser,?NazwaKryteriow,?Privilege,'" + GlobalValues.gblUserName + "','" + GlobalValues.gblIP + "',NULL);"
  End Function
  Public Function UpdateNazwa(ByVal Nazwa As String) As String
    Return "UPDATE kryteria SET Nazwa=?Nazwa,User=?User,ComputerIP=?IP,Version=NULL WHERE Nazwa='" & Nazwa & "';"
  End Function
  Public Function UpdateKryterium(ByVal ID As String) As String
    Return "UPDATE kryterium SET Min=?Min,Max=?Max,Ocena=?Ocena,User=?User,ComputerIP=?IP,Version=NULL WHERE ID='" & ID & "';"
  End Function
  Public Function DeleteNazwa(ByVal Nazwa As String) As String
    Return "DELETE FROM kryteria WHERE Nazwa='" & Nazwa & "';"
  End Function
  Public Function DeleteKryterium(ByVal ID As String) As String
    Return "DELETE FROM kryterium WHERE ID='" & ID & "';"
  End Function
End Class