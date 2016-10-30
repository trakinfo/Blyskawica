Imports System.Windows.Forms

Public Class dlgKryterium
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
        If nudMin.Maximum > nudMax.Value Then
          nudMin.Value = nudMax.Value
          'nudMax.Value = nudMin.Value

        End If
        txtOcena.Text = ""
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
    Dim cmd As MySqlCommand = DBA.CreateCommand(K.InsertKryterium)
    MySQLTrans = GlobalValues.gblConn.BeginTransaction()
    cmd.Transaction = MySQLTrans

    Try
      cmd.Parameters.AddWithValue("?NazwaKryterium", SharedKryterium.NazwaKryteriow)
      cmd.Parameters.AddWithValue("?Min", CType(nudMin.Value, Single))
      cmd.Parameters.AddWithValue("?Max", CType(nudMax.Value, Single))
      cmd.Parameters.AddWithValue("?Ocena", txtOcena.Text)
      cmd.Parameters.AddWithValue("?User", GlobalValues.gblUserName)
      cmd.Parameters.AddWithValue("?ComputerIP", GlobalValues.gblIP)
      cmd.ExecuteNonQuery()

      MySQLTrans.Commit()
      RaiseEvent NewAdded(Me, cmd.LastInsertedId.ToString)
      nudMin.Focus()
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

  Private Sub txtNazwa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOcena.TextChanged
    OK_Button.Enabled = CType(IIf(txtOcena.Text.Length > 0, True, False), Boolean)
  End Sub
  Private Sub txtNazwa_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtOcena.Validating
    If txtOcena.Text.Length > 45 Then
      MessageBox.Show("Zbyt długa nazwa. Nazwa może mieć maksymalnie 45 znaków.")
      e.Cancel = True
    End If
  End Sub
End Class
