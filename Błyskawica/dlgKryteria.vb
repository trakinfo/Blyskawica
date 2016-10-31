Imports System.Windows.Forms

Public Class dlgKryteria
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
    Dim DBA As New DataBaseAction, K As New KryteriaSQL
    Dim cmd As MySqlCommand = DBA.CreateCommand(K.InsertNazwa)
    MySQLTrans = GlobalValues.gblConn.BeginTransaction()
    cmd.Transaction = MySQLTrans

    Try
      cmd.Parameters.AddWithValue("?Nazwa", txtNazwa.Text)
      cmd.Parameters.AddWithValue("?User", GlobalValues.gblUserName)
      cmd.Parameters.AddWithValue("?ComputerIP", GlobalValues.gblIP)
      cmd.ExecuteNonQuery()

      cmd.CommandText = K.InsertOwnership
      cmd.Parameters.AddWithValue("?IdUser", GlobalValues.gblUserID)
      cmd.Parameters.AddWithValue("?NazwaKryteriow", txtNazwa.Text)
      cmd.Parameters.AddWithValue("?Privilege", GlobalValues.Privilege.Owner)
      cmd.ExecuteNonQuery()

      MySQLTrans.Commit()
      RaiseEvent NewAdded(Me, txtNazwa.Text)
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

  Private Sub txtNazwa_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNazwa.Validating
    If txtNazwa.Text.Length > 45 Then
      MessageBox.Show("Zbyt długa nazwa. Nazwa może mieć maksymalnie 45 znaków.")
      e.Cancel = True
    End If
  End Sub
End Class
