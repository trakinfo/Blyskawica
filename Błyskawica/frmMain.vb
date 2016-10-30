Public Class frmMain

  Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    CloseConnection()
    'tmConn.Stop()
  End Sub

  Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.Text = Me.Text + " - ver. " + My.Application.Info.Version.ToString
    statConn.Text = ""
    statUser.Text = ""
    statRola.Text = ""
    statTryb.Text = "Test"
    Connect()
  End Sub
  Private Sub Connect()
    Try
      Dim DBA As New DataBaseAction, R As New Rijndael
      'R.Encrypt("belfer")

      GlobalValues.gblConn = DBA.Connection(My.Settings.ServerIP, My.Settings.DBName, My.Settings.SysUser, R.Decrypt(My.Settings.SysPassword))


      If GlobalValues.gblConn.State = ConnectionState.Open Then
        Me.statConn.Text = "Połączony"
        Dim N As New Net
        GlobalValues.gblIP = N.ComputerIPv4 'N.ComputerIP
        GlobalValues.gblHostName = N.ComputerName
        'Login()
        'MenuOrganizujNauczyciele_Click(Me, Nothing)
      Else
        If SetConnectParams() Then
          Connect()
        Else
          'Me.Close()
          Me.Dispose(True)
        End If
      End If

    Catch mex As MySqlException
      MessageBox.Show(mex.Message)
    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
  End Sub
  Private Function SetConnectParams() As Boolean
    Dim dlgConnect As New dlgConnect, R As New Rijndael
    With dlgConnect
      .txtSerwerIP.Text = My.Settings.ServerIP
      .txtDBName.Text = My.Settings.DBName
      .txtUserName.Text = My.Settings.SysUser
      .txtPassword.Text = R.Decrypt(My.Settings.SysPassword)
    End With
    If dlgConnect.ShowDialog = Windows.Forms.DialogResult.OK Then
      With dlgConnect
        My.Settings.ServerIP = .txtSerwerIP.Text
        My.Settings.DBName = .txtDBName.Text
        My.Settings.SysUser = .txtUserName.Text
        My.Settings.SysPassword = R.Encrypt(.txtPassword.Text)
        My.Settings.Save()
        Return True
      End With
    Else

    End If
    Return False
  End Function
  Private Sub CloseConnection()
    If Not IsNothing(GlobalValues.gblConn) Then
      If GlobalValues.gblConn.State <> ConnectionState.Closed Then
        GlobalValues.gblConn.Close()
        statConn.Text = "Rozłączony"
      End If
    End If
  End Sub
  Private Sub CheckUser(ByVal UserName As String, ByVal Password As String)
    Dim DBA As New DataBaseAction, R As MySqlDataReader = Nothing, HH As New HashHelper
    Try
      Dim cmd As MySqlCommand = DBA.CreateCommand("SELECT u.`Role`,u.`Password`,u.ID FROM `user` u WHERE u.`Nick`=?UserName;")
      cmd.Parameters.AddWithValue("?UserName", UserName)
      R = cmd.ExecuteReader()
      'R = DBA.GetReader("SELECT u.`Role`,u.`Password`,u.ID FROM `user` u WHERE u.`Nick`='" + UserName + "';")
      If R.HasRows Then
        R.Read()
        If HH.ComparePasswords(CType(R.Item(1), Byte()), Password) Then
          GlobalValues.gblUserName = UserName
          GlobalValues.gblUserID = CType(R.Item("ID"), Integer)
          GlobalValues.gblRole = CType(R.Item("Role"), GlobalValues.Role)
          statTryb.Text = "Generator testów" '[Enum].GetName(GetType(GlobalValues.Role), GlobalValues.gblRole)
          statUser.Text = UserName
          statRola.Text = [Enum].GetName(GetType(GlobalValues.Role), GlobalValues.gblRole)
          MenuPlikZaloguj.Enabled = False
          MenuPlikWyloguj.Enabled = True
          If GlobalValues.gblRole = 4 Then
            EnableAdminMenu(True)
          ElseIf GlobalValues.gblRole = 2 Then
            EnableEditMenu(True)
          Else
            EnableMenu(True)
          End If
        Else
          MessageBox.Show("Podane hasło jest nieprawidłowe lub użytkownik nie istnieje!", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
          R.Close()
          Login()
        End If
      Else
        R.Close()
        MessageBox.Show("Podane hasło jest nieprawidłowe lub użytkownik nie istnieje!", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Login()
      End If
    Catch ex As MySqlException
      MessageBox.Show(ex.Message)
    Finally
      R.Close()
    End Try

  End Sub
  Private Sub Login()
    Dim dlgLogin As New dlgLogin
    If dlgLogin.ShowDialog = Windows.Forms.DialogResult.OK Then
      With dlgLogin
        My.Settings.UserName = .txtUserName.Text
        My.Settings.Save()
        CheckUser(.txtUserName.Text, .txtPassword.Text)
      End With
    Else
      'Application.Exit()
    End If

  End Sub
  Private Sub LogOut()
    GlobalValues.gblUserName = ""
    GlobalValues.gblRole = Nothing
    Me.statUser.Text = ""
    statRola.Text = ""
    statTryb.Text = "Test"
    EnableAdminMenu(False)
    MenuPlikZaloguj.Enabled = True
    MenuPlikWyloguj.Enabled = False
    'Login()
  End Sub
  Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
    Dim About As New AboutBlyskawica

    With About
      .Icon = GlobalValues.gblAppIcon
      .StartPosition = FormStartPosition.CenterScreen
      .ShowDialog()
    End With
  End Sub
  Private Sub EnableAdminMenu(ByVal Value As Boolean)
    OrganizujToolStripMenuItem.Enabled = Value
    MenuUstawieniaConnectionParams.Enabled = Value
    EnableAdminCommands(Value)
    EnableEditMenu(Value)
  End Sub
  Private Sub EnableEditMenu(ByVal Value As Boolean)
    TestyToolStripMenuItem.Enabled = Value
    UstawieniaToolStripMenuItem.Enabled = Value
    MenuUstawieniaChangePassword.Enabled = Value
    EnableEditCommands(Value)
    EnableMenu(Value)
  End Sub
  Private Sub EnableMenu(ByVal value As Boolean)
    WynikiToolStripMenuItem.Enabled = value
  End Sub
  Private Sub EnableAdminCommands(ByVal Value As Boolean)
    cmdStudents.Enabled = Value
  End Sub
  Private Sub EnableEditCommands(ByVal Value As Boolean)
    cmdTest.Enabled = Value
    cmdPytania.Enabled = Value
    cmdWyniki.Enabled = Value
    cmdPrintScores.Enabled = Value
    cmdPozwolenia.Enabled = Value
    cmdUprawnienia.Enabled = Value
  End Sub
  Private Sub MenuPlikZaloguj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuPlikZaloguj.Click
    Login()
  End Sub

  Private Sub MenuOrganizujNauczyciele_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuOrganizujUsers.Click
    Dim frmUsers As New frmUser
    With frmUsers
      .Icon = GlobalValues.gblAppIcon
      '.MdiParent = Me
      .Owner = Me
      .MaximizeBox = False
      .StartPosition = FormStartPosition.CenterScreen
      .ShowDialog()
    End With

  End Sub

  Private Sub MenuPlikWyloguj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuPlikWyloguj.Click
    LogOut()
  End Sub

  Private Sub MenuUstawieniaConnectionParams_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuUstawieniaConnectionParams.Click
    If SetConnectParams() Then
      If MessageBox.Show("Aktywacja nowych parametrów połączenia wymaga rozłączenia i ponownego połączenia z serwerem baz danych." & vbCr & "Czy chcesz zrestartować połączenie? Jeśli nie, to nowe ustawienia zostaną aktywowane dopiero po ponownym uruchomieniu programu.", Application.ProductName, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
        CloseConnection()
        Connect()
      End If
    End If
  End Sub

  Private Sub MenuUstawieniaChangePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuUstawieniaChangePassword.Click
    If GlobalValues.gblRole = GlobalValues.Role.Administrator Then
      Me.ChangePassword()
    Else
      Me.ChangePassword(GlobalValues.gblUserName)
    End If
  End Sub
  Private Overloads Sub ChangePassword(ByVal Name As String)
    Dim HashHelper As New HashHelper, DBA As New DataBaseAction, U As New UsersSQL, dlgPassword As New dlgChangePassword
    With dlgPassword
      .Icon = GlobalValues.gblAppIcon
      .Text = "Zmiana hasła - tryb użytkownika"
      .txtLogin.Text = Name
      .txtLogin.Enabled = False
      .lblLogin.Enabled = False
      .OK_Button.Text = "Zmień"

      If .ShowDialog = Windows.Forms.DialogResult.OK Then
        Try
          Dim SaltedPasswordHash As Byte()
          SaltedPasswordHash = HashHelper.CreateDBPassword(dlgPassword.txtPassword.Text)
          Dim cmd As MySqlCommand = DBA.CreateCommand(U.UpdatePassword())
          cmd.Parameters.AddWithValue("?Password", SaltedPasswordHash)
          cmd.Parameters.AddWithValue("?Name", Name)
          cmd.ExecuteNonQuery()
          MessageBox.Show("Hasło zostało zmienione")
        Catch mex As MySqlException
          MessageBox.Show("Wystąpił błąd:" + vbNewLine + mex.Message)
        Catch ex As Exception
          MessageBox.Show("Wystąpił błąd:" + vbNewLine + ex.Message)
        End Try
      End If
    End With
  End Sub
  Private Overloads Sub ChangePassword()
    Dim HashHelper As New HashHelper, DBA As New DataBaseAction, U As New UsersSQL, dlgPassword As New dlgChangePassword
    With dlgPassword
      .Text = "Zmiana hasła - tryb administratora"
      .txtLogin.Enabled = False
      .txtLogin.Visible = False
      .OK_Button.Text = "Zmień"
      Dim cbNazwa As New ComboBox
      cbNazwa.Name = "cbNazwa"
      cbNazwa.Location = .txtLogin.Location
      cbNazwa.Width = .txtLogin.Width
      cbNazwa.DropDownStyle = ComboBoxStyle.DropDownList
      cbNazwa.Parent = dlgPassword
      Dim FCB As New FillComboBox
      FCB.AddComboBoxSimpleItems(cbNazwa, U.SelectUsers)
      AddHandler cbNazwa.SelectedIndexChanged, AddressOf cbNazwa_SelectedIndexChanged

      .Controls.Add(cbNazwa)

      If .ShowDialog = Windows.Forms.DialogResult.OK Then
        Try
          Dim SaltedPasswordHash As Byte()
          SaltedPasswordHash = HashHelper.CreateDBPassword(.txtPassword.Text)
          Dim cmd As MySqlCommand = DBA.CreateCommand(U.UpdatePassword())
          cmd.Parameters.AddWithValue("?Password", SaltedPasswordHash)
          cmd.Parameters.AddWithValue("?Name", cbNazwa.Text)
          cmd.ExecuteNonQuery()
          MessageBox.Show("Hasło zostało zmienione")

        Catch mex As MySqlException
          MessageBox.Show("Wystąpił błąd:" + vbNewLine + mex.Message)
        Catch ex As Exception
          MessageBox.Show("Wystąpił błąd:" + vbNewLine + ex.Message)

        End Try

      End If
    End With
  End Sub
  Private Sub cbNazwa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Dim cbNazwa As ComboBox = CType(sender, ComboBox)
    Dim dlgPassword As Form = cbNazwa.FindForm()
    dlgPassword.Controls("tlpButtons").Controls("Ok_button").Enabled = True
  End Sub

  Private Sub MenuTestyRejestr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuTestyRejestrTestow.Click
    Dim frmRejestr As New frmRejestrTestow
    With frmRejestr
      .Icon = GlobalValues.gblAppIcon
      '.MdiParent = Me
      .Owner = Me
      .MaximizeBox = True
      .StartPosition = FormStartPosition.CenterScreen
      .ShowDialog()
    End With
  End Sub

  Private Sub MenuTestyRejestrPytan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuTestyRejestrPytan.Click
    Dim frmRejestr As New frmRejestrPytan
    With frmRejestr
      .Icon = GlobalValues.gblAppIcon
      '.MdiParent = Me
      .Owner = Me
      .MaximizeBox = True
      .StartPosition = FormStartPosition.CenterScreen
      .ShowDialog()
    End With

  End Sub

  Private Sub MenuOrganizujPrzedmioty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuOrganizujPrzedmioty.Click
    Dim frmPrzedmiot As New frmPrzedmiot
    With frmPrzedmiot
      .Icon = GlobalValues.gblAppIcon
      '.MdiParent = Me
      .Owner = Me
      .MaximizeBox = True
      .StartPosition = FormStartPosition.CenterScreen
      .ShowDialog()
    End With

  End Sub

  Private Sub MenuOrganizujUczniowie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuOrganizujUczniowie.Click
    Dim frmStudent As New frmStudent
    With frmStudent
      .Icon = GlobalValues.gblAppIcon
      '.MdiParent = Me
      .Owner = Me
      .MaximizeBox = True
      .StartPosition = FormStartPosition.CenterScreen
      .ShowDialog()
    End With
  End Sub

  Private Sub MenuOrganizujImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuOrganizujImport.Click
    Dim dlg As New dlgImportStudent
    With dlg
      .Icon = GlobalValues.gblAppIcon
      '.MdiParent = Me
      .Owner = Me
      '.MaximizeBox = True
      .StartPosition = FormStartPosition.CenterScreen
      .ShowDialog()
    End With

  End Sub

  Private Sub MenuTestyPozwolenia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuTestyPozwolenia.Click
    Dim frm As New frmPozwolenie
    With frm
      .Icon = GlobalValues.gblAppIcon
      '.MdiParent = Me
      .Owner = Me
      .MaximizeBox = True
      .StartPosition = FormStartPosition.CenterScreen
      .ShowDialog()
    End With
  End Sub

  Private Sub MenuPlikOpenTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuPlikOpenTest.Click
    Dim dlg As New dlgWersja
    With dlg
      .Icon = GlobalValues.gblAppIcon
      '.MdiParent = Me
      .Owner = Me
      '.MaximizeBox = True
      .StartPosition = FormStartPosition.CenterScreen
      .ShowDialog()
    End With
  End Sub

  Private Sub cmdSoluteTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSoluteTest.Click
    MenuPlikOpenTest_Click(sender, e)
  End Sub

  Private Sub MenuTestyKryteria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuTestyKryteria.Click
    Dim frm As New frmKryteria
    With frm
      .Icon = GlobalValues.gblAppIcon
      '.MdiParent = Me
      .Owner = Me
      .MaximizeBox = True
      .StartPosition = FormStartPosition.CenterScreen
      .ShowDialog()
    End With
  End Sub

  Private Sub cmdPozwolenia_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPozwolenia.Click
    MenuTestyPozwolenia_Click(sender, e)
  End Sub

  Private Sub cmdPytania_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPytania.Click
    MenuTestyRejestrPytan_Click(sender, e)

  End Sub

  Private Sub cmdStudents_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdStudents.Click
    MenuOrganizujUczniowie_Click(sender, e)
  End Sub

  Private Sub cmdTest_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdTest.Click
    MenuTestyRejestr_Click(sender, e)

  End Sub

  Private Sub cmdWyniki_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWyniki.Click
    MenuWynikiRejestr_Click(sender, e)
  End Sub

  Private Sub MenuWynikiRejestr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuWynikiRejestr.Click
    Dim frm As New frmWyniki
    With frm
      .Icon = GlobalValues.gblAppIcon
      '.MdiParent = Me
      .Owner = Me
      .MaximizeBox = True
      .StartPosition = FormStartPosition.CenterScreen
      .ShowDialog()
    End With
  End Sub

  Private Sub MenuPlikZamknij_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuPlikZamknij.Click
    Me.Dispose(True)
  End Sub

  Private Sub MenuTestyUprawnienia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuTestyUprawnienia.Click
    Dim frm As New frmPrawa
    With frm
      .Icon = GlobalValues.gblAppIcon
      '.MdiParent = Me
      .Owner = Me
      .MaximizeBox = True
      .StartPosition = FormStartPosition.CenterScreen
      .ShowDialog()
    End With
  End Sub

  Private Sub cmdUprawnienia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUprawnienia.Click
    MenuTestyUprawnienia_Click(sender, e)
  End Sub

  Private Sub MenuWynikiWydruk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuWynikiWydruk.Click
    Dim frm As New prnPrintScore
    With frm
      .Icon = GlobalValues.gblAppIcon
      '.MdiParent = Me
      .Owner = Me
      .MaximizeBox = True
      .StartPosition = FormStartPosition.CenterScreen
      .ShowDialog()
    End With

  End Sub

  Private Sub cmdPrintScores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintScores.Click
    MenuWynikiWydruk_Click(sender, e)
  End Sub
End Class