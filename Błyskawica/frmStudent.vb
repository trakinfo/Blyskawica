Public Class frmStudent
  Private DS As DataSet
  Private Sub frmPrzedmiot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.ListViewConfig(lvKlasa)
    ListViewConfig(lvStudent)
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
    Dim DBA As New DataBaseAction, S As New StudentSQL
    DS = DBA.GetDataSet(S.SelectKlasa & S.SelectStudent)
  End Sub
  Private Sub GetData()
    lvKlasa.Items.Clear()
    For Each row As DataRow In DS.Tables(0).Rows
      Me.lvKlasa.Items.Add(row.Item(0).ToString)
      Me.lvKlasa.Items(Me.lvKlasa.Items.Count - 1).SubItems.Add(row.Item(1).ToString)
      'Me.lvKlasa.Items(Me.lvKlasa.Items.Count - 1).SubItems.Add(IIf(row.Item(2).ToString = "0", "Nie", "Tak").ToString)
    Next
    lblRecord.Text = "0 z " & lvKlasa.Items.Count
    lvKlasa.Columns(1).Width = CInt(IIf(lvKlasa.Items.Count > 32, 94, 112))
    Me.lvKlasa.Enabled = CType(IIf(Me.lvKlasa.Items.Count > 0, True, False), Boolean)

  End Sub
  Private Sub GetStudent(ByVal KodKlasy As String)
    lvStudent.Items.Clear()
    For Each row As DataRow In DS.Tables(1).Select("Klasa='" & KodKlasy & "'")
      Me.lvStudent.Items.Add(row.Item(0).ToString)
      Me.lvStudent.Items(Me.lvStudent.Items.Count - 1).SubItems.Add(row.Item(1).ToString)
    Next
    lblRecord1.Text = "0 z " & lvStudent.Items.Count
    lvStudent.Columns(1).Width = CInt(IIf(lvStudent.Items.Count > 32, 313, 331))
    Me.lvStudent.Enabled = CType(IIf(Me.lvStudent.Items.Count > 0, True, False), Boolean)

  End Sub
  Private Sub GetDetails(ByVal KodKlasy As String)
    Try
      lblRecord.Text = lvKlasa.SelectedItems(0).Index + 1 & " z " & lvKlasa.Items.Count

      With DS.Tables(0).Select("KodKlasy='" & KodKlasy & "'")(0)
        lblUser.Text = .Item(2).ToString
        lblIP.Text = .Item(3).ToString
        lblData.Text = .Item(4).ToString
      End With
    Catch err As Exception
      MessageBox.Show(err.Message)
    End Try
  End Sub
  Private Sub GetSDetails(ByVal ID As String)
    Try
      lblRecord1.Text = lvStudent.SelectedItems(0).Index + 1 & " z " & lvStudent.Items.Count
      With DS.Tables(1).Select("ID='" & ID & "'")(0)
        lblUser.Text = .Item(2).ToString
        lblIP.Text = .Item(3).ToString
        lblData.Text = .Item(4).ToString
      End With
    Catch err As Exception
      MessageBox.Show(err.Message)
    End Try
  End Sub
  Private Sub ClearDetails()
    lblRecord.Text = "0 z " & lvKlasa.Items.Count

    Me.lblUser.Text = ""
    Me.lblData.Text = ""
    Me.lblIP.Text = ""
  End Sub
  Private Sub ClearSDetails()
    lblRecord1.Text = "0 z " & lvStudent.Items.Count

    Me.lblUser.Text = ""
    Me.lblData.Text = ""
    Me.lblIP.Text = ""
  End Sub
  Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
    Close()
  End Sub

  Private Sub lvPrzedmiot_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvKlasa.DoubleClick
    EditData()
  End Sub

  Private Sub lvPrzedmiot_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvKlasa.ItemSelectionChanged
    Me.ClearDetails()
    lvStudent.Items.Clear()
    EnableSButtons(False)
    If e.IsSelected Then
      SharedStudent.KodKlasy = e.Item.Text
      GetDetails(e.Item.Text)
      GetStudent(e.Item.Text)
      EnableButtons(True)

    Else
      EnableButtons(False)
    End If
  End Sub

  Private Sub lvModul_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvStudent.DoubleClick
    EditStudent()
  End Sub
  Private Sub lvModul_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvStudent.ItemSelectionChanged
    Me.ClearSDetails()
    'lvModul.Items.Clear()
    If e.IsSelected Then
      SharedStudent.StudentID = e.Item.Text
      GetSDetails(e.Item.Text)
      'GetModule(e.Item.Text)
      EnableSButtons(True)

    Else
      EnableSButtons(False)
    End If
  End Sub
  Private Sub EnableButtons(ByVal Value As Boolean)
    Me.cmdDelete.Enabled = Value
    Me.cmdEdit.Enabled = Value
    cmdAddNewStudent.Enabled = Value
  End Sub
  Private Sub EnableSButtons(ByVal Value As Boolean)
    Me.cmdDeleteStudent.Enabled = Value
    Me.cmdEditStudent.Enabled = Value
  End Sub
  Private Sub AddNew()
    Dim dlgAddNew As New dlgKlasa
    Dim FCB As New FillComboBox ', SH As New SeekHelper, P As New PrzedmiotSQL
    With dlgAddNew
      .Owner = Me
      .Show()
      .txtKod.Focus()
      AddHandler dlgAddNew.NewAdded, AddressOf NewAdded
      AddHandler dlgAddNew.FormClosed, AddressOf EnableCmdAddNew
      Me.cmdAddNew.Enabled = False
    End With
  End Sub
  Private Sub NewAdded(ByVal sender As Object, ByVal InsertedID As String)
    lvKlasa.Items.Clear()
    lvStudent.Items.Clear()
    FetchData()
    GetData()
    Dim SH As New SeekHelper
    SH.FindListViewItem(Me.lvKlasa, InsertedID)
  End Sub

  Private Sub EnableCmdAddNew(ByVal sender As Object, ByVal e As FormClosedEventArgs)
    Me.cmdAddNew.Enabled = True
  End Sub

  Private Sub cmdAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click
    AddNew()
  End Sub
  Private Sub AddStudent()
    Dim dlgAddNew As New dlgStudent
    With dlgAddNew
      .Owner = Me
      .Show()
      .txtNazwisko.Focus()
      AddHandler dlgAddNew.NewAdded, AddressOf NewStudentAdded
      'AddHandler dlgAddNew.FormClosed, AddressOf EnableCmdAddNew
      Me.cmdAddNewStudent.Enabled = False
    End With

  End Sub
  Private Sub NewStudentAdded(ByVal sender As Object, ByVal InsertedID As String)
    'lvRejestr.Items.Clear()
    'lvPytania.Items.Clear()
    FetchData()
    GetData()
    Dim SH As New SeekHelper
    SH.FindListViewItem(Me.lvKlasa, SharedStudent.KodKlasy)
    SH.FindListViewItem(lvStudent, InsertedID)
  End Sub
  Private Sub EnableCmdAddNewStudent(ByVal sender As Object, ByVal e As FormClosedEventArgs)
    Me.cmdAddNewStudent.Enabled = True
  End Sub

  Private Sub cmdAddNewModul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNewStudent.Click
    AddStudent()
  End Sub

  Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
    EditData()
  End Sub
  Private Sub EditData()
    Dim dlgEdit As New dlgKlasa
    Dim MySQLTrans As MySqlTransaction = Nothing
    Try
      With dlgEdit
        .Text = "Edycja grupy"
        .txtKod.Text = Me.lvKlasa.SelectedItems(0).Text
        .txtNazwa.Text = Me.lvKlasa.SelectedItems(0).SubItems(1).Text
        .OK_Button.Text = "Zapisz"
        .Icon = GlobalValues.gblAppIcon
        If .ShowDialog = Windows.Forms.DialogResult.OK Then
          Dim DBA As New DataBaseAction, S As New StudentSQL
          Dim cmd As MySqlCommand = DBA.CreateCommand(S.UpdateKlasa(SharedStudent.KodKlasy))
          MySQLTrans = GlobalValues.gblConn.BeginTransaction()
          cmd.Transaction = MySQLTrans

          cmd.Parameters.AddWithValue("?Nazwa", .txtNazwa.Text)
          cmd.Parameters.AddWithValue("?KodKlasy", .txtKod.Text)
          cmd.Parameters.AddWithValue("?User", GlobalValues.gblUserName)
          cmd.Parameters.AddWithValue("?IP", GlobalValues.gblIP)

          cmd.ExecuteNonQuery()
        End If
        MySQLTrans.Commit()

        Me.lvKlasa.Items.Clear()
        lvStudent.Items.Clear()
        FetchData()
        Me.GetData()
        Dim SH As New SeekHelper
        SH.FindListViewItem(Me.lvKlasa, SharedStudent.KodKlasy)

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
  Private Sub EditStudent()
    Dim dlgEdit As New dlgStudent
    Try
      With dlgEdit
        .Text = "Edycja danych ucznia"
        .txtNazwisko.Text = Me.lvStudent.SelectedItems(0).SubItems(1).Text.Split(" ".ToCharArray)(0).ToString
        .txtImie.Text = Me.lvStudent.SelectedItems(0).SubItems(1).Text.Split(" ".ToCharArray)(1).ToString
        .OK_Button.Text = "Zapisz"
        .Icon = GlobalValues.gblAppIcon
        If .ShowDialog = Windows.Forms.DialogResult.OK Then
          Dim DBA As New DataBaseAction, S As New StudentSQL
          Dim cmd As MySqlCommand = DBA.CreateCommand(S.UpdateStudent(SharedStudent.StudentID))

          cmd.Parameters.AddWithValue("?Nazwisko", .txtNazwisko.Text)
          cmd.Parameters.AddWithValue("?Imie", .txtImie.Text)
          cmd.Parameters.AddWithValue("?User", GlobalValues.gblUserName)
          cmd.Parameters.AddWithValue("?IP", GlobalValues.gblIP)

          cmd.ExecuteNonQuery()
          Me.lvKlasa.Items.Clear()
          lvStudent.Items.Clear()
          FetchData()
          Me.GetData()
          Dim SH As New SeekHelper
          SH.FindListViewItem(Me.lvKlasa, SharedStudent.KodKlasy)
          SH.FindListViewItem(lvStudent, SharedStudent.StudentID)
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

  Private Sub cmdEditModul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditStudent.Click
    EditStudent()
  End Sub


  Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click, cmdDeleteStudent.Click
    Dim DBA As New DataBaseAction, S As New StudentSQL, DeletedIndex As Integer
    If CType(sender, Button).Name = "cmdDelete" Then
      For Each Item As ListViewItem In Me.lvKlasa.SelectedItems
        DeletedIndex = Item.Index
        DBA.ApplyChanges(S.DeleteKlasa(Item.Text))
      Next
    Else
      For Each Item As ListViewItem In Me.lvStudent.SelectedItems
        DeletedIndex = Item.Index
        DBA.ApplyChanges(S.DeleteStudent(Item.Text))
      Next

    End If

    EnableButtons(False)
    cmdDelete.Enabled = False
    lvKlasa.Items.Clear()
    lvStudent.Items.Clear()
    FetchData()
    Me.GetData()
    Dim SH As New SeekHelper
    If CType(sender, Button).Name = "cmdDelete" Then
      SH.FindRemovedListViewItemIndex(Me.lvKlasa, DeletedIndex)
    Else
      SH.FindListViewItem(lvKlasa, SharedStudent.KodKlasy)
      GetStudent(SharedStudent.KodKlasy)
      SH.FindRemovedListViewItemIndex(lvStudent, DeletedIndex)

    End If
  End Sub

  Private Sub lvKlasa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvKlasa.SelectedIndexChanged

  End Sub

  Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
    Dim LinePen As New Pen(Color.White, 1)
    e.Graphics.DrawLine(LinePen, New Point(0, Me.Panel1.Height - 54), New Point(Me.Panel1.Width - 1, Me.Panel1.Height - 54))

  End Sub
End Class


Public Class StudentSQL
  Public Function SelectKlasa() As String
    Return "SELECT KodKlasy,Nazwa,User,ComputerIP,Version FROM klasa ORDER BY KodKlasy,Nazwa;"
  End Function
  Public Function SelectStudent() As String
    Return "SELECT ID,CONCAT_WS(' ',Nazwisko,Imie) as Student,Klasa,User,ComputerIP,Version FROM student ORDER BY Klasa,Nazwisko,Imie;"
  End Function
  Public Function InsertKlasa() As String
    Return "INSERT INTO klasa VALUES(?KodKlasy,?Nazwa,?User,?ComputerIP,Null);"
  End Function
  Public Function InsertStudent() As String
    'Return "INSERT INTO student VALUES(NULL,?Nazwisko,?Imie,?Klasa,'" & GlobalValues.gblUserName & "','" & GlobalValues.gblIP & "',Null);"
    Return "INSERT INTO student VALUES(NULL,?Nazwisko,?Imie,?Klasa,?User,?ComputerIP,Null);"

  End Function
  Public Function UpdateKlasa(ByVal KodKlasy As String) As String
    Return "UPDATE klasa SET KodKlasy=?KodKlasy,Nazwa=?Nazwa,User=?User,ComputerIP=?IP,Version=Null WHERE KodKlasy='" & KodKlasy & "';"
  End Function
  'Public Function ResetDefault() As String
  '  Return "Update przedmiot SET IsDefault=0;"
  'End Function
  'Public Function SetDefault(ByVal ID As String) As String
  '  Return "Update przedmiot SET IsDefault=1 WHERE ID='" & ID & "';"
  'End Function
  Public Function UpdateStudent(ByVal IdStudent As String) As String
    Return "UPDATE student SET Nazwisko=?Nazwisko,Imie=?Imie,User=?User,ComputerIP=?IP,Version=Null WHERE ID='" & IdStudent & "';"
  End Function
  Public Function DeleteKlasa(ByVal KodKlasy As String) As String
    Return "DELETE FROM klasa WHERE KodKlasy='" & KodKlasy & "';"
  End Function
  Public Function DeleteStudent(ByVal ID As String) As String
    Return "DELETE FROM student WHERE ID='" & ID & "';"
  End Function
End Class