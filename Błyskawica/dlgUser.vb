Imports System.Windows.Forms

Public Class dlgUser
  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    If System.String.Compare(Me.txtPassword.Text, Me.txtPassword1.Text, False) <> 0 Then
      MessageBox.Show("Wartości pól 'Hasło' i 'Powtórz hasło' muszą być takie same!")
      Me.txtPassword1.Focus()
    Else
      Me.DialogResult = System.Windows.Forms.DialogResult.OK
      Me.Close()
    End If
  End Sub

  Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Close()
  End Sub

  Private Sub txtNazwa_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLogin.TextChanged
    If Me.txtLogin.Text.Length < 1 Then
      Me.OK_Button.Enabled = False
    Else
      Me.OK_Button.Enabled = True
    End If

  End Sub
  'Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
  '    Me.DialogResult = System.Windows.Forms.DialogResult.OK
  '    Me.Close()
  'End Sub

  'Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
  '    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
  '    Me.Close()
  'End Sub

  'Private Sub dlgUser_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
  '  For Each i As Integer In [Enum].GetValues(GetType(GlobalValues.Role))
  '    cbRola.Items.Add(New CbItem(i, [Enum].GetName(GetType(GlobalValues.Role), i)))
  '  Next
  'End Sub

  'Private Sub cbRola_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRola.SelectedIndexChanged
  '  MessageBox.Show(CType(cbRola.SelectedItem, CbItem).ID.ToString)
  'End Sub
End Class
