Imports System.Windows.Forms

Public Class dlgPrzedmiot
  Public Event NewAdded(ByVal sender As Object, ByVal InsertedID As String)
  'Private IsDefault As Boolean
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    'Me.DialogResult = System.Windows.Forms.DialogResult.OK
    'Me.Close()
    If Me.Modal Then
      Me.DialogResult = Windows.Forms.DialogResult.OK
      Me.Close()
    Else
      If AddNew() Then
        txtNazwa.Text = ""
        chkIsDefault.Checked = False
        OK_Button.Enabled = False
      End If
    End If
  End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
  Public Function AddNew() As Boolean
    Dim MySQLTrans As MySqlTransaction
    Dim DBA As New DataBaseAction, P As New PrzedmiotSQL
    Dim cmd As MySqlCommand = DBA.CreateCommand(P.InsertPrzedmiot)
    MySQLTrans = GlobalValues.gblConn.BeginTransaction()
    cmd.Transaction = MySQLTrans

    Try
      cmd.Parameters.AddWithValue("?Nazwa", txtNazwa.Text)
      'cmd.Parameters.AddWithValue("?IsDefault", chkIsDefault.CheckState)
      cmd.Parameters.AddWithValue("?User", GlobalValues.gblUserName)
      cmd.Parameters.AddWithValue("?ComputerIP", GlobalValues.gblIP)
      cmd.ExecuteNonQuery()
      Dim InsertedID As String = cmd.LastInsertedId.ToString
      If chkIsDefault.Checked Then
        cmd.CommandText = P.ResetDefault
        cmd.ExecuteNonQuery()
        cmd.CommandText = P.SetDefault(InsertedID)
        cmd.ExecuteNonQuery()
      End If
      MySQLTrans.Commit()
      RaiseEvent NewAdded(Me, InsertedID)
      txtNazwa.Focus()
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

  Private Sub txtNazwa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNazwa.TextChanged
    OK_Button.Enabled = CType(IIf(txtNazwa.Text.Length > 0, True, False), Boolean)
  End Sub
End Class
