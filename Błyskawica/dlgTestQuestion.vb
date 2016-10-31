Imports System.Windows.Forms

Public Class dlgTestQuestion
  Public Event NewAdded(ByVal sender As Object, ByVal InsertedID As String)
  Private DT As DataTable
  Public QuestionNr As Byte

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    'Me.DialogResult = System.Windows.Forms.DialogResult.OK
    'Me.Close()
    If AddQuestion() Then
      For Each item As ListViewItem In lvRejestr.SelectedItems
        item.Remove()
      Next
      OK_Button.Enabled = False
    End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

  Private Sub dlgTestQuestion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.ListViewConfig(Me.lvRejestr)

    lblRecord.Text = ""

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
      .Columns.Add("Treść pytania", 707, HorizontalAlignment.Left)
      .Columns.Add("Właściciel", 120, HorizontalAlignment.Center)
      '.Columns.Add("Status", 80, HorizontalAlignment.Center)
    End With
  End Sub
  Private Sub FetchData(ByVal IdPrzedmiot As String)
    Dim DBA As New DataBaseAction, T As New TestSQL
    DT = DBA.GetDataTable(T.SelectPytanie(IdPrzedmiot, SharedTest.TestID))
  End Sub
  Private Sub GetData(ByVal IdModul As String)
    lvRejestr.Items.Clear()
    For Each row As DataRow In DT.Select("IdModul=" & IdModul)
      Me.lvRejestr.Items.Add(row.Item(0).ToString)
      Me.lvRejestr.Items(Me.lvRejestr.Items.Count - 1).SubItems.Add(row.Item(1).ToString)
      Me.lvRejestr.Items(Me.lvRejestr.Items.Count - 1).SubItems.Add(row.Item(2).ToString)
    Next
    lblRecord.Text = "0 z " & lvRejestr.Items.Count
    lvRejestr.Columns(1).Width = CInt(IIf(lvRejestr.Items.Count > 27, 688, 707))
    Me.lvRejestr.Enabled = CType(IIf(Me.lvRejestr.Items.Count > 0, True, False), Boolean)
  End Sub
  Private Sub cbModul_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbModul.SelectedIndexChanged
    FetchData(SharedTest.PrzedmiotID)
    GetData(CType(cbModul.SelectedItem, CbItem).ID.ToString)
  End Sub

  Private Sub lvRejestr_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvRejestr.DoubleClick
    OK_Button_Click(sender, e)
  End Sub
  Private Sub lvUsers_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvRejestr.ItemSelectionChanged
    If e.IsSelected Then
      OK_Button.Enabled = True
      lblRecord.Text = lvRejestr.SelectedItems(0).Index + 1 & " z " & lvRejestr.Items.Count
    Else
      OK_Button.Enabled = False
      lblRecord.Text = "0 z " & lvRejestr.Items.Count
    End If
  End Sub
  Public Function AddQuestion() As Boolean
    Dim MySQLTrans As MySqlTransaction
    Dim DBA As New DataBaseAction, T As New TestSQL ', HashHelper As New HashHelper
    MySQLTrans = GlobalValues.gblConn.BeginTransaction()
    Try
      Dim QuestionID As String = "0"

      For Each Item As ListViewItem In lvRejestr.SelectedItems
        QuestionNr += CByte(1)
        Dim cmd As MySqlCommand = DBA.CreateCommand(T.InsertPytanie)
        cmd.Transaction = MySQLTrans
        cmd.Parameters.AddWithValue("?IdTest", SharedTest.TestID)
        cmd.Parameters.AddWithValue("?IdPytanie", Item.Text)
        cmd.Parameters.AddWithValue("?NrPytania", QuestionNr)
        QuestionID = Item.Text
        cmd.ExecuteNonQuery()
      Next
      MySQLTrans.Commit()
      RaiseEvent NewAdded(Me, QuestionID)
      Return True
    Catch err As MySqlException
      MySQLTrans.Rollback()
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

  Private Sub lvRejestr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvRejestr.SelectedIndexChanged

  End Sub

  Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
    Dim LinePen As New Pen(Color.White, 1)
    e.Graphics.DrawLine(LinePen, New Point(0, Me.Panel1.Height - 7), New Point(Me.Panel1.Width - 1, Me.Panel1.Height - 7))

  End Sub
End Class

