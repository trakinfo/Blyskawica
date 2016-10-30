Imports System.Windows.Forms

Public Class dlgAnswer
  Public Event NewAdded(ByVal sender As Object, ByVal InsertedID As Long)
  'Private QuestionID As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    'Me.DialogResult = System.Windows.Forms.DialogResult.OK
    'Me.Close()
    If Me.Modal Then
      Me.DialogResult = Windows.Forms.DialogResult.OK
      Me.Close()
    Else
      If AddNew() Then
        txtTresc.Text = ""
        'chkPrivate.Checked = False
        nudPunktacja.Maximum = SharedQuestion.LimitPunktow
        nudPunktacja.Value = SharedQuestion.LimitPunktow
        OK_Button.Enabled = False
      End If
      'End If
      'End If
    End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
  Private Sub txtTresc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTresc.TextChanged
    OK_Button.Enabled = CType(IIf(txtTresc.Text.Length > 0, True, False), Boolean)
  End Sub
  Public Function AddNew() As Boolean
    Dim MySQLTrans As MySqlTransaction
    Dim DBA As New DataBaseAction, P As New PytaniaSQL
    Dim cmd As MySqlCommand = DBA.CreateCommand(P.InsertOdp)
    MySQLTrans = GlobalValues.gblConn.BeginTransaction()
    cmd.Transaction = MySQLTrans

    Try
      cmd.Parameters.AddWithValue("?Tresc", txtTresc.Text)
      cmd.Parameters.AddWithValue("?Punktacja", CType(nudPunktacja.Value, Integer))
      cmd.Parameters.AddWithValue("?IdPytanie", SharedQuestion.QuestionID)
      'cmd.Parameters.AddWithValue("?Private", chkPrivate.CheckState)
      cmd.ExecuteNonQuery()

      MySQLTrans.Commit()
      RaiseEvent NewAdded(Me, cmd.LastInsertedId)
      SharedQuestion.LimitPunktow = 100 - DBA.ComputeRecords(P.SelectSum(SharedQuestion.QuestionID))
      txtTresc.Focus()
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
      'MySQLTrans.Rollback()
      MessageBox.Show(ex.Message)

    End Try
  End Function

  Private Sub dlgAnswer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    AddHandler SharedQuestion.OnLimitPunktowChange, AddressOf LimitPunktowChanged
  End Sub
  Private Sub LimitPunktowChanged(ByVal sender As Object)
    nudPunktacja.Maximum = SharedQuestion.LimitPunktow
    nudPunktacja.Value = SharedQuestion.LimitPunktow
  End Sub

End Class
