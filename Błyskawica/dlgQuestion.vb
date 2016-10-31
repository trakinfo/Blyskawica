Imports System.Windows.Forms

Public Class dlgQuestion
  Public Event NewAdded(ByVal sender As Object, ByVal InsertedID As Long)
  'Private ModuleID As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    'Me.DialogResult = System.Windows.Forms.DialogResult.OK
    'Me.Close()
    If Me.Modal Then
      Me.DialogResult = Windows.Forms.DialogResult.OK
      Me.Close()
    Else
      If AddNew() Then
        txtTresc.Text = ""
        chkPrivate.Checked = False
        OK_Button.Enabled = False
      End If
      'End If
      'End If
    End If

    End Sub
  Public Function AddNew() As Boolean
    Dim MySQLTrans As MySqlTransaction
    Dim DBA As New DataBaseAction, P As New PytaniaSQL
    Dim cmd As MySqlCommand = DBA.CreateCommand(P.InsertPytanie)
    MySQLTrans = GlobalValues.gblConn.BeginTransaction()
    cmd.Transaction = MySQLTrans

    Try
      cmd.Parameters.AddWithValue("?Tresc", txtTresc.Text)
      cmd.Parameters.AddWithValue("?IdModul", SharedQuestion.ModuleID)
      cmd.Parameters.AddWithValue("?IdOwner", GlobalValues.gblUserID)
      cmd.Parameters.AddWithValue("?Private", chkPrivate.CheckState)
      cmd.ExecuteNonQuery()

      MySQLTrans.Commit()
      RaiseEvent NewAdded(Me, cmd.LastInsertedId)
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
      MySQLTrans.Rollback()
      MessageBox.Show(ex.Message)

    End Try
  End Function
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

  Private Sub dlgQuestion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'AddHandler SharedQuestion.OnModuleChange, AddressOf SetModuleID
  End Sub
  'Private Sub SetModuleID(ByVal sender As Object, ByVal ModuleID As String)
  '  ModuleID = ModuleID
  'End Sub

  Private Sub txtTresc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTresc.TextChanged
    OK_Button.Enabled = CType(IIf(txtTresc.Text.Length > 0, True, False), Boolean)
  End Sub
End Class
