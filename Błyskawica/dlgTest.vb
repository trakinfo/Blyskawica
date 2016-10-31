Imports System.Windows.Forms

Public Class dlgTest
  Public Event NewAdded(ByVal sender As Object, ByVal InsertedID As String)
  Public InRefresh As Boolean = False ', TypTestu As Byte = 0

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    'Me.DialogResult = System.Windows.Forms.DialogResult.OK
    'Me.Close()
    If Me.Modal Then
      Me.DialogResult = Windows.Forms.DialogResult.OK
      Me.Close()
    Else
      If AddNew() Then
        txtNazwa.Text = ""
        txtPassword.Text = ""
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
  Public Function AddNew() As Boolean
    Dim MySQLTrans As MySqlTransaction
    Dim DBA As New DataBaseAction, T As New TestSQL ', HashHelper As New HashHelper
    Dim cmd As MySqlCommand = DBA.CreateCommand(T.InsertTest(CType(IIf(cbKryteria.Text.Length > 0, False, True), Boolean)))
    MySQLTrans = GlobalValues.gblConn.BeginTransaction()
    cmd.Transaction = MySQLTrans

    Try
      Dim R As New Rijndael

      cmd.Parameters.AddWithValue("?Nazwa", txtNazwa.Text)
      cmd.Parameters.AddWithValue("?WyborWielokrotny", CType(chkMultiChoice.CheckState, Integer))
      cmd.Parameters.AddWithValue("?IdPrzedmiot", SharedTest.PrzedmiotID)
      cmd.Parameters.AddWithValue("?LimitCzasu", CInt(nudLimitCzasu.Value))
      cmd.Parameters.AddWithValue("?LimitOdpowiedzi", CInt(nudLimitOdp.Value))
      cmd.Parameters.AddWithValue("?Status", 0)
      cmd.Parameters.AddWithValue("?Haslo", R.Encrypt(txtPassword.Text))
      If cbKryteria.Text.Length > 0 Then cmd.Parameters.AddWithValue("?NazwaKryterium", cbKryteria.Text)
      cmd.ExecuteNonQuery()

      cmd.CommandText = T.InsertOwnership
      cmd.Parameters.AddWithValue("?IdUser", GlobalValues.gblUserID)
      cmd.Parameters.AddWithValue("?IdTest", cmd.LastInsertedId)
      cmd.Parameters.AddWithValue("?Privilege", GlobalValues.Privilege.Owner)
      cmd.ExecuteNonQuery()

      MySQLTrans.Commit()
      RaiseEvent NewAdded(Me, cmd.LastInsertedId.ToString)
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

  'Private Sub rbJednokrotny_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  If Not Me.Created Then Exit Sub
  '  If CType(sender, RadioButton).Checked Then
  '    TypTestu = CType(CType(sender, RadioButton).Tag, Byte)
  '  End If

  'End Sub

  Private Sub dlgTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

  End Sub

  Private Sub txtNazwa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNazwa.TextChanged
    If Not InRefresh Then
      OK_Button.Enabled = CType(IIf(txtNazwa.Text.Trim.Length < 1, False, True), Boolean)
      'cmdAdd.Enabled = True

    End If

  End Sub

End Class
