Imports System.Windows.Forms

Public Class dlgAnswersByQuestion
  Private DT As DataTable
  'Public QuestionID As String
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

  Private Sub dlgAnswersByQuestion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.ListViewConfig(Me.lvOdp)
    lblRecord.Text = ""
    FetchData(SharedQuestion.QuestionID)
    'GetAnswer(SharedQuestion.QuestionID)
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
      .Columns.Add("Treść odpowiedzi", 749, HorizontalAlignment.Left)
      .Columns.Add("Punktacja", 100, HorizontalAlignment.Center)
    End With
  End Sub
  Private Sub FetchData(ByVal IdPytanie As String)
    Dim DBA As New DataBaseAction, P As New PytaniaSQL
    DT = DBA.GetDataTable(P.SelectOdpByPytanie(IdPytanie))
    GetAnswer(IdPytanie)
  End Sub
  Private Sub GetAnswer(ByVal IdPytanie As String)
    lvOdp.Items.Clear()
    For Each row As DataRow In DT.Rows
      Me.lvOdp.Items.Add(row.Item(0).ToString)
      Me.lvOdp.Items(Me.lvOdp.Items.Count - 1).SubItems.Add(row.Item(1).ToString)
      Me.lvOdp.Items(Me.lvOdp.Items.Count - 1).SubItems.Add(row.Item(2).ToString)
    Next
    lblRecord.Text = "0 z " & lvOdp.Items.Count
    lvOdp.Columns(1).Width = CInt(IIf(lvOdp.Items.Count > 8, 730, 749))
    Me.lvOdp.Enabled = CType(IIf(Me.lvOdp.Items.Count > 0, True, False), Boolean)

  End Sub
  Private Sub GetADetails(ByVal IdOdp As String)
    Try
      lblRecord.Text = lvOdp.SelectedItems(0).Index + 1 & " z " & lvOdp.Items.Count

      With DT.Select("ID=" & IdOdp)(0)
        lblUser.Text = .Item(3).ToString
        lblIP.Text = .Item(4).ToString
        lblData.Text = .Item(5).ToString
      End With
    Catch err As Exception
      MessageBox.Show(err.Message)
    End Try
  End Sub
  Private Sub ClearAnswerDetails()
    lblRecord.Text = "0 z " & lvOdp.Items.Count
    ClearDetails()
  End Sub
  Private Sub ClearDetails()
    Me.lblUser.Text = ""
    Me.lblData.Text = ""
    Me.lblIP.Text = ""
  End Sub
  Private Sub lvUsers_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvOdp.ItemSelectionChanged
    Me.ClearAnswerDetails()
    If e.IsSelected Then
      GetADetails(e.Item.Text)
      EnableAnswerButtons(True)
    Else
      EnableAnswerButtons(False)
    End If
  End Sub
  Private Sub EnableAnswerButtons(ByVal Value As Boolean)
    Me.cmdDeleteOdp.Enabled = Value
    Me.cmdEditOdp.Enabled = Value
  End Sub
  Private Sub AddNewAnswer()
    Dim dlgAddNew As New dlgAnswer
    With dlgAddNew
      AddHandler dlgAddNew.NewAdded, AddressOf NewAnswerAdded
      AddHandler dlgAddNew.FormClosed, AddressOf EnableCmdAddNew
      .nudPunktacja.Maximum = SharedQuestion.LimitPunktow
      .nudPunktacja.Value = SharedQuestion.LimitPunktow
      .Owner = Me
      .Show()
      .txtTresc.Focus()
    End With
  End Sub
  Private Sub NewAnswerAdded(ByVal sender As Object, ByVal InsertedID As Long)
    lvOdp.Items.Clear()
    FetchData(SharedQuestion.QuestionID)
    Dim SH As New SeekHelper
    SH.FindListViewItem(Me.lvOdp, InsertedID.ToString)
  End Sub
  Private Sub EnableCmdAddNew(ByVal sender As Object, ByVal e As FormClosedEventArgs)
    Me.cmdAddOdp.Enabled = True
  End Sub

  Private Sub cmdAddOdp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddOdp.Click
    AddNewAnswer()
  End Sub
  Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeleteOdp.Click
    Dim DBA As New DataBaseAction, DeletedIndex As Integer, P As New PytaniaSQL

    For Each Item As ListViewItem In Me.lvOdp.SelectedItems
      DeletedIndex = Item.Index
      DBA.ApplyChanges(P.DeleteItem("odpowiedz", Item.Text))
    Next
    EnableAnswerButtons(False)
    lvOdp.Items.Clear()
    FetchData(SharedQuestion.QuestionID)

    Dim SH As New SeekHelper
    SH.FindRemovedListViewItemIndex(Me.lvOdp, DeletedIndex)

  End Sub
  Private Sub EditAnswerData()
    Dim dlgEdit As New dlgAnswer
    Try
      With dlgEdit
        .Text = "Edycja pytania"
        .txtTresc.Text = Me.lvOdp.SelectedItems(0).SubItems(1).Text
        .nudPunktacja.Maximum = CType(IIf(CType(lvOdp.SelectedItems(0).SubItems(2).Text, Integer) > 0, CType(lvOdp.SelectedItems(0).SubItems(2).Text, Integer) + SharedQuestion.LimitPunktow, 0), Integer)
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
          lvOdp.Items.Clear()
          FetchData(SharedQuestion.QuestionID)
          Dim SH As New SeekHelper
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


  Private Sub Panel2_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint
    Dim LinePen As New Pen(Color.White, 1)
    e.Graphics.DrawLine(LinePen, New Point(0, Me.Panel2.Height - 7), New Point(Me.Panel2.Width - 1, Me.Panel2.Height - 7))
  End Sub
End Class
