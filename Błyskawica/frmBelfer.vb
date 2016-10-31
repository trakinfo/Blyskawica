Public Class frmUser
  Private dtUsers As DataTable
  Public Sub AddUser()
    Dim HashHelper As New HashHelper, DBA As New DataBaseAction, U As New UsersSQL, dlgAddNew As New dlgUser
    Try
      For Each i As Integer In [Enum].GetValues(GetType(GlobalValues.Role))
        dlgAddNew.cbRola.Items.Add(New CbItem(i, [Enum].GetName(GetType(GlobalValues.Role), i)))
      Next
      If dlgAddNew.ShowDialog = Windows.Forms.DialogResult.OK Then
        Dim SaltedPasswordHash As Byte()
        SaltedPasswordHash = HashHelper.CreateDBPassword(dlgAddNew.txtPassword.Text)
        Dim cmd As MySqlCommand = DBA.CreateCommand(U.InsertUser())

        cmd.Parameters.AddWithValue("?Password", SaltedPasswordHash)
        cmd.Parameters.AddWithValue("?Nick", dlgAddNew.txtLogin.Text)
        cmd.Parameters.AddWithValue("?Nazwisko", dlgAddNew.txtNazwisko.Text)
        cmd.Parameters.AddWithValue("?Imie", dlgAddNew.txtImie.Text)
        cmd.Parameters.AddWithValue("?Role", CType(dlgAddNew.cbRola.SelectedItem, CbItem).ID)

        cmd.ExecuteNonQuery()
        Me.lvUsers.Items.Clear()
        Me.GetData()
        Dim SH As New SeekHelper
        SH.FindListViewItem(Me.lvUsers, DBA.GetLastInsertedID)
      End If
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

  Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
    Me.Close()
  End Sub

  Private Sub cmdAddNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNewUser.Click
    Me.AddUser()
  End Sub

  Private Sub frmUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.ListViewConfig(Me.lvUsers)
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
      .Columns.Add("Login", 150, HorizontalAlignment.Left)
      .Columns.Add("Nazwisko i imię", 200, HorizontalAlignment.Left)
      .Columns.Add("Rola", 100, HorizontalAlignment.Left)
    End With
  End Sub


  Private Sub GetData()
    Dim DBA As New DataBaseAction, U As New UsersSQL
    dtUsers = DBA.GetDataTable(U.SelectUsers)
    For Each row As DataRow In dtUsers.Rows
      Me.lvUsers.Items.Add(row.Item(0).ToString)
      Me.lvUsers.Items(Me.lvUsers.Items.Count - 1).SubItems.Add(row.Item(1).ToString)
      Me.lvUsers.Items(Me.lvUsers.Items.Count - 1).SubItems.Add([Enum].GetName(GetType(GlobalValues.Role), CType(row.Item(2), Integer)))
    Next
    lblRecord.Text = "0 z " & lvUsers.Items.Count
    lvUsers.Columns(1).Width = CInt(IIf(lvUsers.Items.Count > 16, 131, 150))
    Me.lvUsers.Enabled = CType(IIf(Me.lvUsers.Items.Count > 0, True, False), Boolean)

  End Sub
  Private Sub GetDetails(ByVal Name As String)
    Try
      lblRecord.Text = lvUsers.SelectedItems(0).Index + 1 & " z " & lvUsers.Items.Count

      With dtUsers.Select("Nick='" & Name & "'")(0)
        lblUser.Text = .Item(3).ToString
        lblIP.Text = .Item(4).ToString
        lblData.Text = .Item(5).ToString
      End With
    Catch err As Exception
      MessageBox.Show(err.Message)
    End Try
  End Sub

  Private Sub lvUsers_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvUsers.DoubleClick
    Me.EditData()
  End Sub

  Private Sub lvUsers_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvUsers.ItemSelectionChanged
    Me.ClearDetails()
    If e.IsSelected Then
      GetDetails(e.Item.Text)
      EnableButtons(True)
    Else
      EnableButtons(False)
    End If
  End Sub
  Private Sub EnableButtons(ByVal Value As Boolean)
    Me.cmdDelete.Enabled = Value
    Me.cmdEdit.Enabled = Value
  End Sub
  Private Sub ClearDetails()
    lblRecord.Text = "0 z " & lvUsers.Items.Count

    Me.lblUser.Text = ""
    Me.lblData.Text = ""
    Me.lblIP.Text = ""
  End Sub
  Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
    Dim DBA As New DataBaseAction, DeletedIndex As Integer, U As New UsersSQL
    For Each Item As ListViewItem In Me.lvUsers.SelectedItems
      DeletedIndex = Item.Index
      Dim cmd As MySqlCommand = DBA.CreateCommand(U.DeleteUser)
      cmd.Parameters.AddWithValue("?Name", item.Text)
      cmd.ExecuteNonQuery()
      'DBA.ApplyChanges(U.DeleteUser(Item.Text))
    Next
    Me.EnableButtons(False)
    lvUsers.Items.Clear()
    Me.GetData()
    Dim SH As New SeekHelper
    SH.FindRemovedListViewItemIndex(Me.lvUsers, DeletedIndex)
  End Sub

  Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
    Me.EditData()
  End Sub
  Private Sub EditData()
    Dim dlgEdit As New dlgUser
    Try
      With dlgEdit
        .Text = "Edycja danych użytkownika"
        .txtLogin.Text = Me.lvUsers.SelectedItems(0).Text
        .txtNazwisko.Text = Me.lvUsers.SelectedItems(0).SubItems(1).Text.Split(" ".ToCharArray)(0).ToString
        .txtImie.Text = Me.lvUsers.SelectedItems(0).SubItems(1).Text.Split(" ".ToCharArray)(1).ToString
        For Each i As Integer In [Enum].GetValues(GetType(GlobalValues.Role))
          .cbRola.Items.Add(New CbItem(i, [Enum].GetName(GetType(GlobalValues.Role), i)))
        Next
        Dim SH As New SeekHelper
        SH.FindComboItem(.cbRola, Me.lvUsers.SelectedItems(0).SubItems(2).Text)
        .txtLogin.Enabled = False
        .lblPassword.Enabled = False
        .lblPassword2.Enabled = False
        .txtPassword.Enabled = False
        .txtPassword1.Enabled = False
        .OK_Button.Text = "Zapisz"
        '.Icon = gblAppIcon
        If dlgEdit.ShowDialog = Windows.Forms.DialogResult.OK Then
          Dim DBA As New DataBaseAction, IdUser As String, U As New UsersSQL
          IdUser = Me.lvUsers.SelectedItems(0).Text
          Dim cmd As MySqlCommand = DBA.CreateCommand(U.UpdateUser())

          cmd.Parameters.AddWithValue("?Nazwisko", .txtNazwisko.Text)
          cmd.Parameters.AddWithValue("?Imie", .txtImie.Text)
          cmd.Parameters.AddWithValue("?Role", CType(.cbRola.SelectedItem, CbItem).ID)
          cmd.Parameters.AddWithValue("?User", GlobalValues.gblUserName)
          cmd.Parameters.AddWithValue("?ComputerIP", GlobalValues.gblIP)
          cmd.Parameters.AddWithValue("?Name", IdUser)

          cmd.ExecuteNonQuery()
          Me.lvUsers.Items.Clear()
          Me.GetData()

          'Dim SH As New SeekHelper
          SH.FindListViewItem(Me.lvUsers, IdUser)
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

  Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
    Dim LinePen As New Pen(Color.White, 1)
    e.Graphics.DrawLine(LinePen, New Point(0, Me.Panel1.Height - 7), New Point(Me.Panel1.Width - 1, Me.Panel1.Height - 7))

  End Sub
End Class

Public Class UsersSQL
  Public Function SelectUsers() As String
    Return "SELECT u.`Nick`, Concat_WS(' ',u.Nazwisko,u.Imie) AS Belfer,u.`Role`, u.`User`, u.`ComputerIP`, u.`Version` FROM `user` u WHERE u.Nick<>'Admin';"
  End Function
  Public Function InsertUser() As String
    Return "INSERT INTO user (Nick,Nazwisko,Imie,Password,Role,User,ComputerIP,Version) VALUES (?Nick,?Nazwisko,?Imie,?Password,?Role,'" + GlobalValues.gblUserName + "','" + GlobalValues.gblIP + "',NULL);"
  End Function
  Public Function DeleteUser() As String
    Return "DELETE FROM user WHERE Nick=?Name;"
  End Function
  Public Function UpdatePassword() As String
    Return "UPDATE user SET Password=?Password WHERE Nick=?Name;"
  End Function
  Public Function UpdateUser() As String
    Return "UPDATE user SET Nazwisko=?Nazwisko,Imie=?Imie,Role=?Role,User=?User,ComputerIP=?ComputerIP,Version=NULL WHERE Nick=?Name;"
  End Function
End Class