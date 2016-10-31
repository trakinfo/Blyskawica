Public Class frmPrzedmiot
  Private DS As DataSet
  Private Sub frmPrzedmiot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.ListViewConfig(lvPrzedmiot)
    ListViewConfig(lvModul)
    lblRecord.Text = ""
    lblRecord1.Text = ""
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
      .Columns.Add("ID", 0, HorizontalAlignment.Left)
      If lv.Name = "lvPrzedmiot" Then
        .Columns.Add("Nazwa przedmiotu", 198, HorizontalAlignment.Left)
        .Columns.Add("Domyślnie", 70, HorizontalAlignment.Center)
      Else
        .Columns.Add("Nazwa modułu", 537, HorizontalAlignment.Left)
      End If
    End With
  End Sub
  Private Sub FetchData()
    Dim DBA As New DataBaseAction, P As New PrzedmiotSQL
    DS = DBA.GetDataSet(P.SelectPrzedmiot & P.SelectModul)
  End Sub
  Private Sub GetData()
    lvPrzedmiot.Items.Clear()
    For Each row As DataRow In DS.Tables(0).Rows
      Me.lvPrzedmiot.Items.Add(row.Item(0).ToString)
      Me.lvPrzedmiot.Items(Me.lvPrzedmiot.Items.Count - 1).SubItems.Add(row.Item(1).ToString)
      Me.lvPrzedmiot.Items(Me.lvPrzedmiot.Items.Count - 1).SubItems.Add(IIf(row.Item(2).ToString = "0", "Nie", "Tak").ToString)
    Next
    lblRecord.Text = "0 z " & lvPrzedmiot.Items.Count
    lvPrzedmiot.Columns(1).Width = CInt(IIf(lvPrzedmiot.Items.Count > 32, 180, 198))
    Me.lvPrzedmiot.Enabled = CType(IIf(Me.lvPrzedmiot.Items.Count > 0, True, False), Boolean)

  End Sub
  Private Sub GetModule(ByVal IdPrzedmiot As String)
    lvModul.Items.Clear()
    For Each row As DataRow In DS.Tables(1).Select("IdPrzedmiot=" & IdPrzedmiot)
      Me.lvModul.Items.Add(row.Item(0).ToString)
      Me.lvModul.Items(Me.lvModul.Items.Count - 1).SubItems.Add(row.Item(1).ToString)
    Next
    lblRecord1.Text = "0 z " & lvModul.Items.Count
    lvModul.Columns(1).Width = CInt(IIf(lvModul.Items.Count > 32, 519, 537))
    Me.lvModul.Enabled = CType(IIf(Me.lvModul.Items.Count > 0, True, False), Boolean)

  End Sub
  Private Sub GetDetails(ByVal IdPrzedmiot As String)
    Try
      lblRecord.Text = lvPrzedmiot.SelectedItems(0).Index + 1 & " z " & lvPrzedmiot.Items.Count

      With DS.Tables(0).Select("ID='" & IdPrzedmiot & "'")(0)
        lblUser.Text = .Item(3).ToString
        lblIP.Text = .Item(4).ToString
        lblData.Text = .Item(5).ToString
      End With
    Catch err As Exception
      MessageBox.Show(err.Message)
    End Try
  End Sub
  Private Sub GetMDetails(ByVal IdPrzedmiot As String)
    Try
      lblRecord1.Text = lvModul.SelectedItems(0).Index + 1 & " z " & lvModul.Items.Count
      With DS.Tables(1).Select("ID='" & IdPrzedmiot & "'")(0)
        lblUser.Text = .Item(3).ToString
        lblIP.Text = .Item(4).ToString
        lblData.Text = .Item(5).ToString
      End With
    Catch err As Exception
      MessageBox.Show(err.Message)
    End Try
  End Sub
  Private Sub ClearDetails()
    lblRecord.Text = "0 z " & lvPrzedmiot.Items.Count

    Me.lblUser.Text = ""
    Me.lblData.Text = ""
    Me.lblIP.Text = ""
  End Sub
  Private Sub ClearMDetails()
    lblRecord1.Text = "0 z " & lvModul.Items.Count

    Me.lblUser.Text = ""
    Me.lblData.Text = ""
    Me.lblIP.Text = ""
  End Sub
  Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
    Close()
  End Sub

  Private Sub lvPrzedmiot_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvPrzedmiot.DoubleClick
    EditData()
  End Sub

  Private Sub lvPrzedmiot_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvPrzedmiot.ItemSelectionChanged
    Me.ClearDetails()
    lvModul.Items.Clear()
    EnableMButtons(False)
    If e.IsSelected Then
      SharedPrzedmiot.PrzedmiotID = e.Item.Text
      GetDetails(e.Item.Text)
      GetModule(e.Item.Text)
      EnableButtons(True)

    Else
      EnableButtons(False)
    End If
  End Sub

  Private Sub lvModul_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvModul.DoubleClick
    EditModule()
  End Sub
  Private Sub lvModul_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvModul.ItemSelectionChanged
    Me.ClearMDetails()
    'lvModul.Items.Clear()
    If e.IsSelected Then
      SharedPrzedmiot.ModulID = e.Item.Text
      GetMDetails(e.Item.Text)
      'GetModule(e.Item.Text)
      EnableMButtons(True)

    Else
      EnableMButtons(False)
    End If
  End Sub
  Private Sub EnableButtons(ByVal Value As Boolean)
    Me.cmdDelete.Enabled = Value
    Me.cmdEdit.Enabled = Value
    cmdAddNewModul.Enabled = Value
  End Sub
  Private Sub EnableMButtons(ByVal Value As Boolean)
    Me.cmdDeleteModul.Enabled = Value
    Me.cmdEditModul.Enabled = Value
  End Sub
  Private Sub AddNew()
    Dim dlgAddNew As New dlgPrzedmiot
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
    lvPrzedmiot.Items.Clear()
    lvModul.Items.Clear()
    FetchData()
    GetData()
    Dim SH As New SeekHelper
    SH.FindListViewItem(Me.lvPrzedmiot, InsertedID)
  End Sub

  Private Sub EnableCmdAddNew(ByVal sender As Object, ByVal e As FormClosedEventArgs)
    Me.cmdAddNew.Enabled = True
  End Sub

  Private Sub cmdAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click
    AddNew()
  End Sub
  Private Sub AddModule()
    Dim dlgAddNew As New dlgModul
    With dlgAddNew
      .Owner = Me
      .Show()
      .txtNazwa.Focus()
      AddHandler dlgAddNew.NewAdded, AddressOf NewModuleAdded
      'AddHandler dlgAddNew.FormClosed, AddressOf EnableCmdAddNew
      Me.cmdAddNewModul.Enabled = False
    End With

  End Sub
  Private Sub NewModuleAdded(ByVal sender As Object, ByVal InsertedID As String)
    'lvRejestr.Items.Clear()
    'lvPytania.Items.Clear()
    FetchData()
    GetData()
    Dim SH As New SeekHelper
    SH.FindListViewItem(Me.lvPrzedmiot, SharedPrzedmiot.PrzedmiotID)
    SH.FindListViewItem(lvModul, InsertedID)
  End Sub
  Private Sub EnableCmdAddNewModul(ByVal sender As Object, ByVal e As FormClosedEventArgs)
    Me.cmdAddNewModul.Enabled = True
  End Sub

  Private Sub cmdAddNewModul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNewModul.Click
    AddModule()
  End Sub

  Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
    EditData()
  End Sub
  Private Sub EditData()
    Dim dlgEdit As New dlgPrzedmiot
    Dim MySQLTrans As MySqlTransaction = Nothing
    Try
      With dlgEdit
        .Text = "Edycja przedmiotu"
        .txtNazwa.Text = Me.lvPrzedmiot.SelectedItems(0).SubItems(1).Text
        .chkIsDefault.Checked = CType(IIf(lvPrzedmiot.SelectedItems(0).SubItems(2).Text = "Tak", True, False), Boolean)
        .OK_Button.Text = "Zapisz"
        .Icon = GlobalValues.gblAppIcon
        If .ShowDialog = Windows.Forms.DialogResult.OK Then
          Dim DBA As New DataBaseAction, P As New PrzedmiotSQL
          Dim cmd As MySqlCommand = DBA.CreateCommand(P.UpdatePrzedmiot(SharedPrzedmiot.PrzedmiotID))
          MySQLTrans = GlobalValues.gblConn.BeginTransaction()
          cmd.Transaction = MySQLTrans

          cmd.Parameters.AddWithValue("?Nazwa", .txtNazwa.Text)
          'cmd.Parameters.AddWithValue("?IsDefault", .chkIsDefault.CheckState)
          cmd.Parameters.AddWithValue("?User", GlobalValues.gblUserName)
          cmd.Parameters.AddWithValue("?IP", GlobalValues.gblIP)

          cmd.ExecuteNonQuery()
          If CType(IIf(lvPrzedmiot.SelectedItems(0).SubItems(2).Text = "Tak", True, False), Boolean) <> .chkIsDefault.Checked Then
            cmd.CommandText = P.ResetDefault
            cmd.ExecuteNonQuery()
            cmd.CommandText = P.SetDefault(SharedPrzedmiot.PrzedmiotID)
            cmd.ExecuteNonQuery()
          End If
          MySQLTrans.Commit()

          Me.lvPrzedmiot.Items.Clear()
          lvModul.Items.Clear()
          FetchData()
          Me.GetData()
          Dim SH As New SeekHelper
          SH.FindListViewItem(Me.lvPrzedmiot, SharedPrzedmiot.PrzedmiotID)
        End If
      End With
    Catch err As MySqlException
      MySQLTrans.Rollback()

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
  Private Sub EditModule()
    Dim dlgEdit As New dlgModul
    Try
      With dlgEdit
        .Text = "Edycja modułu"
        .txtNazwa.Text = Me.lvModul.SelectedItems(0).SubItems(1).Text
        .OK_Button.Text = "Zapisz"
        .Icon = GlobalValues.gblAppIcon
        If .ShowDialog = Windows.Forms.DialogResult.OK Then
          Dim DBA As New DataBaseAction, P As New PrzedmiotSQL
          Dim cmd As MySqlCommand = DBA.CreateCommand(P.UpdateModul(SharedPrzedmiot.ModulID))

          cmd.Parameters.AddWithValue("?Nazwa", .txtNazwa.Text)
          cmd.Parameters.AddWithValue("?User", GlobalValues.gblUserName)
          cmd.Parameters.AddWithValue("?IP", GlobalValues.gblIP)

          cmd.ExecuteNonQuery()
          Me.lvPrzedmiot.Items.Clear()
          lvModul.Items.Clear()
          FetchData()
          Me.GetData()
          Dim SH As New SeekHelper
          SH.FindListViewItem(Me.lvPrzedmiot, SharedPrzedmiot.PrzedmiotID)
          SH.FindListViewItem(lvModul, SharedPrzedmiot.ModulID)
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

  Private Sub cmdEditModul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditModul.Click
    EditModule()
  End Sub


  Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click, cmdDeleteModul.Click
    Dim DBA As New DataBaseAction, P As New PrzedmiotSQL, DeletedIndex As Integer
    If CType(sender, Button).Name = "cmdDelete" Then
      For Each Item As ListViewItem In Me.lvPrzedmiot.SelectedItems
        DeletedIndex = Item.Index
        DBA.ApplyChanges(P.DeleteItem("przedmiot", Item.Text))
      Next
    Else
      For Each Item As ListViewItem In Me.lvModul.SelectedItems
        DeletedIndex = Item.Index
        DBA.ApplyChanges(P.DeleteItem("modul", Item.Text))
      Next

    End If

    EnableButtons(False)
    cmdDelete.Enabled = False
    lvPrzedmiot.Items.Clear()
    lvModul.Items.Clear()
    FetchData()
    Me.GetData()
    Dim SH As New SeekHelper
    If CType(sender, Button).Name = "cmdDelete" Then
      SH.FindRemovedListViewItemIndex(Me.lvPrzedmiot, DeletedIndex)
    Else
      SH.FindListViewItem(lvPrzedmiot, SharedPrzedmiot.PrzedmiotID)
      GetModule(SharedPrzedmiot.PrzedmiotID)
      SH.FindRemovedListViewItemIndex(lvModul, DeletedIndex)

    End If
  End Sub

  Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
    Dim LinePen As New Pen(Color.White, 1)
    e.Graphics.DrawLine(LinePen, New Point(0, Me.Panel1.Height - 54), New Point(Me.Panel1.Width - 1, Me.Panel1.Height - 54))

  End Sub
End Class


Public Class PrzedmiotSQL
  Public Function SelectPrzedmiot() As String
    Return "SELECT ID,Nazwa,IsDefault,User,ComputerIP,Version FROM przedmiot ORDER BY Nazwa;"
  End Function
  Public Function SelectModul() As String
    Return "SELECT ID,Nazwa,IdPrzedmiot,User,ComputerIP,Version FROM modul ORDER BY IdPrzedmiot,Nazwa;"
  End Function
  Public Function InsertPrzedmiot() As String
    Return "INSERT INTO przedmiot VALUES(NULL,?Nazwa,0,?User,?ComputerIP,Null);"
  End Function
  Public Function InsertModul() As String
    Return "INSERT INTO modul VALUES(NULL,?Nazwa,?IdPrzedmiot,?User,?ComputerIP,Null);"
  End Function
  Public Function UpdatePrzedmiot(ByVal IdPrzedmiot As String) As String
    Return "UPDATE przedmiot SET Nazwa=?Nazwa,User=?User,ComputerIP=?IP,Version=Null WHERE ID='" & IdPrzedmiot & "';"
  End Function
  Public Function ResetDefault() As String
    Return "Update przedmiot SET IsDefault=0;"
  End Function
  Public Function SetDefault(ByVal ID As String) As String
    Return "Update przedmiot SET IsDefault=1 WHERE ID='" & ID & "';"
  End Function
  Public Function UpdateModul(ByVal IdModul As String) As String
    Return "UPDATE modul SET Nazwa=?Nazwa,User=?User,ComputerIP=?IP,Version=Null WHERE ID='" & IdModul & "';"
  End Function
  Public Function DeleteItem(ByVal Table As String, ByVal ID As String) As String
    Return "DELETE FROM " & Table & " WHERE ID='" & ID & "';"
  End Function
End Class