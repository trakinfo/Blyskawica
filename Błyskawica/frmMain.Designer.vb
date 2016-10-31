<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
    Me.MainMenuToolStrip = New System.Windows.Forms.MenuStrip
    Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuPlikOpenTest = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.MenuPlikZaloguj = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuPlikWyloguj = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
    Me.MenuPlikZamknij = New System.Windows.Forms.ToolStripMenuItem
    Me.OrganizujToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuOrganizujUczniowie = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuOrganizujPrzedmioty = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
    Me.MenuOrganizujUsers = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
    Me.MenuOrganizujImport = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuOrganizujExport = New System.Windows.Forms.ToolStripMenuItem
    Me.TestyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuTestyRejestrTestow = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuTestyRejestrPytan = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
    Me.MenuTestyUprawnienia = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuTestyPozwolenia = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
    Me.MenuTestyImport = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuTestyExport = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
    Me.MenuTestyKryteria = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuTestyKryteriaPrawa = New System.Windows.Forms.ToolStripMenuItem
    Me.WynikiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuWynikiRejestr = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuWynikiAnaliza = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
    Me.MenuWynikiWydruk = New System.Windows.Forms.ToolStripMenuItem
    Me.UstawieniaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuUstawieniaConnectionParams = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuUstawieniaChangePassword = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuUstawieniaOpcje = New System.Windows.Forms.ToolStripMenuItem
    Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.MainStatus = New System.Windows.Forms.StatusStrip
    Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
    Me.statTryb = New System.Windows.Forms.ToolStripStatusLabel
    Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
    Me.statConn = New System.Windows.Forms.ToolStripStatusLabel
    Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
    Me.statUser = New System.Windows.Forms.ToolStripStatusLabel
    Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel
    Me.statRola = New System.Windows.Forms.ToolStripStatusLabel
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
    Me.cmdUprawnienia = New System.Windows.Forms.Button
    Me.cmdPytania = New System.Windows.Forms.Button
    Me.cmdPrintScores = New System.Windows.Forms.Button
    Me.cmdWyniki = New System.Windows.Forms.Button
    Me.cmdTest = New System.Windows.Forms.Button
    Me.cmdStudents = New System.Windows.Forms.Button
    Me.cmdPozwolenia = New System.Windows.Forms.Button
    Me.cmdSoluteTest = New System.Windows.Forms.Button
    Me.MainMenuToolStrip.SuspendLayout()
    Me.MainStatus.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'MainMenuToolStrip
    '
    Me.MainMenuToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.OrganizujToolStripMenuItem, Me.TestyToolStripMenuItem, Me.WynikiToolStripMenuItem, Me.UstawieniaToolStripMenuItem, Me.AboutToolStripMenuItem})
    Me.MainMenuToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
    Me.MainMenuToolStrip.Location = New System.Drawing.Point(0, 0)
    Me.MainMenuToolStrip.Name = "MainMenuToolStrip"
    Me.MainMenuToolStrip.ShowItemToolTips = True
    Me.MainMenuToolStrip.Size = New System.Drawing.Size(719, 24)
    Me.MainMenuToolStrip.TabIndex = 1
    Me.MainMenuToolStrip.Text = "MenuStrip1"
    '
    'StartToolStripMenuItem
    '
    Me.StartToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuPlikOpenTest, Me.ToolStripSeparator1, Me.MenuPlikZaloguj, Me.MenuPlikWyloguj, Me.ToolStripSeparator2, Me.MenuPlikZamknij})
    Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
    Me.StartToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
    Me.StartToolStripMenuItem.Text = "&Start"
    '
    'MenuPlikOpenTest
    '
    Me.MenuPlikOpenTest.Name = "MenuPlikOpenTest"
    Me.MenuPlikOpenTest.Size = New System.Drawing.Size(146, 22)
    Me.MenuPlikOpenTest.Text = "&Rozwiąż test"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(143, 6)
    '
    'MenuPlikZaloguj
    '
    Me.MenuPlikZaloguj.Name = "MenuPlikZaloguj"
    Me.MenuPlikZaloguj.Size = New System.Drawing.Size(146, 22)
    Me.MenuPlikZaloguj.Text = "Za&loguj"
    '
    'MenuPlikWyloguj
    '
    Me.MenuPlikWyloguj.Enabled = False
    Me.MenuPlikWyloguj.Name = "MenuPlikWyloguj"
    Me.MenuPlikWyloguj.Size = New System.Drawing.Size(146, 22)
    Me.MenuPlikWyloguj.Text = "&Wyloguj"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(143, 6)
    '
    'MenuPlikZamknij
    '
    Me.MenuPlikZamknij.Name = "MenuPlikZamknij"
    Me.MenuPlikZamknij.Size = New System.Drawing.Size(146, 22)
    Me.MenuPlikZamknij.Text = "&Zamknij"
    '
    'OrganizujToolStripMenuItem
    '
    Me.OrganizujToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuOrganizujUczniowie, Me.MenuOrganizujPrzedmioty, Me.ToolStripSeparator3, Me.MenuOrganizujUsers, Me.ToolStripSeparator4, Me.MenuOrganizujImport, Me.MenuOrganizujExport})
    Me.OrganizujToolStripMenuItem.Enabled = False
    Me.OrganizujToolStripMenuItem.Name = "OrganizujToolStripMenuItem"
    Me.OrganizujToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
    Me.OrganizujToolStripMenuItem.Text = "&Organizuj"
    '
    'MenuOrganizujUczniowie
    '
    Me.MenuOrganizujUczniowie.Name = "MenuOrganizujUczniowie"
    Me.MenuOrganizujUczniowie.Size = New System.Drawing.Size(189, 22)
    Me.MenuOrganizujUczniowie.Text = "Rejestr &Uczniów"
    '
    'MenuOrganizujPrzedmioty
    '
    Me.MenuOrganizujPrzedmioty.Name = "MenuOrganizujPrzedmioty"
    Me.MenuOrganizujPrzedmioty.Size = New System.Drawing.Size(189, 22)
    Me.MenuOrganizujPrzedmioty.Text = "Przedmioty nauczania"
    '
    'ToolStripSeparator3
    '
    Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
    Me.ToolStripSeparator3.Size = New System.Drawing.Size(186, 6)
    '
    'MenuOrganizujUsers
    '
    Me.MenuOrganizujUsers.Name = "MenuOrganizujUsers"
    Me.MenuOrganizujUsers.Size = New System.Drawing.Size(189, 22)
    Me.MenuOrganizujUsers.Text = "U&żytkownicy"
    '
    'ToolStripSeparator4
    '
    Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
    Me.ToolStripSeparator4.Size = New System.Drawing.Size(186, 6)
    '
    'MenuOrganizujImport
    '
    Me.MenuOrganizujImport.Name = "MenuOrganizujImport"
    Me.MenuOrganizujImport.Size = New System.Drawing.Size(189, 22)
    Me.MenuOrganizujImport.Text = "Import uczniów"
    '
    'MenuOrganizujExport
    '
    Me.MenuOrganizujExport.Name = "MenuOrganizujExport"
    Me.MenuOrganizujExport.Size = New System.Drawing.Size(189, 22)
    Me.MenuOrganizujExport.Text = "&Eksport uczniów"
    '
    'TestyToolStripMenuItem
    '
    Me.TestyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuTestyRejestrTestow, Me.MenuTestyRejestrPytan, Me.ToolStripSeparator5, Me.MenuTestyUprawnienia, Me.MenuTestyPozwolenia, Me.ToolStripSeparator6, Me.MenuTestyImport, Me.MenuTestyExport, Me.ToolStripSeparator7, Me.MenuTestyKryteria, Me.MenuTestyKryteriaPrawa})
    Me.TestyToolStripMenuItem.Enabled = False
    Me.TestyToolStripMenuItem.Name = "TestyToolStripMenuItem"
    Me.TestyToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
    Me.TestyToolStripMenuItem.Text = "&Testy"
    '
    'MenuTestyRejestrTestow
    '
    Me.MenuTestyRejestrTestow.Name = "MenuTestyRejestrTestow"
    Me.MenuTestyRejestrTestow.Size = New System.Drawing.Size(227, 22)
    Me.MenuTestyRejestrTestow.Text = "Rejestr &testów"
    '
    'MenuTestyRejestrPytan
    '
    Me.MenuTestyRejestrPytan.Name = "MenuTestyRejestrPytan"
    Me.MenuTestyRejestrPytan.Size = New System.Drawing.Size(227, 22)
    Me.MenuTestyRejestrPytan.Text = "Rejestr &pytań"
    '
    'ToolStripSeparator5
    '
    Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
    Me.ToolStripSeparator5.Size = New System.Drawing.Size(224, 6)
    '
    'MenuTestyUprawnienia
    '
    Me.MenuTestyUprawnienia.Name = "MenuTestyUprawnienia"
    Me.MenuTestyUprawnienia.Size = New System.Drawing.Size(227, 22)
    Me.MenuTestyUprawnienia.Text = "&Uprawnienia"
    '
    'MenuTestyPozwolenia
    '
    Me.MenuTestyPozwolenia.Name = "MenuTestyPozwolenia"
    Me.MenuTestyPozwolenia.Size = New System.Drawing.Size(227, 22)
    Me.MenuTestyPozwolenia.Text = "Po&zwolenia"
    '
    'ToolStripSeparator6
    '
    Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
    Me.ToolStripSeparator6.Size = New System.Drawing.Size(224, 6)
    '
    'MenuTestyImport
    '
    Me.MenuTestyImport.Name = "MenuTestyImport"
    Me.MenuTestyImport.Size = New System.Drawing.Size(227, 22)
    Me.MenuTestyImport.Text = "&Import z xml"
    '
    'MenuTestyExport
    '
    Me.MenuTestyExport.Name = "MenuTestyExport"
    Me.MenuTestyExport.Size = New System.Drawing.Size(227, 22)
    Me.MenuTestyExport.Text = "&Eksport do xml"
    '
    'ToolStripSeparator7
    '
    Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
    Me.ToolStripSeparator7.Size = New System.Drawing.Size(224, 6)
    '
    'MenuTestyKryteria
    '
    Me.MenuTestyKryteria.Name = "MenuTestyKryteria"
    Me.MenuTestyKryteria.Size = New System.Drawing.Size(227, 22)
    Me.MenuTestyKryteria.Text = "&Kryteria ocen"
    '
    'MenuTestyKryteriaPrawa
    '
    Me.MenuTestyKryteriaPrawa.Enabled = False
    Me.MenuTestyKryteriaPrawa.Name = "MenuTestyKryteriaPrawa"
    Me.MenuTestyKryteriaPrawa.Size = New System.Drawing.Size(227, 22)
    Me.MenuTestyKryteriaPrawa.Text = "Udostępnianie kryteriów ocen"
    '
    'WynikiToolStripMenuItem
    '
    Me.WynikiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuWynikiRejestr, Me.MenuWynikiAnaliza, Me.ToolStripSeparator8, Me.MenuWynikiWydruk})
    Me.WynikiToolStripMenuItem.Enabled = False
    Me.WynikiToolStripMenuItem.Name = "WynikiToolStripMenuItem"
    Me.WynikiToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
    Me.WynikiToolStripMenuItem.Text = "&Wyniki"
    '
    'MenuWynikiRejestr
    '
    Me.MenuWynikiRejestr.Name = "MenuWynikiRejestr"
    Me.MenuWynikiRejestr.Size = New System.Drawing.Size(166, 22)
    Me.MenuWynikiRejestr.Text = "&Rejestr wyników"
    '
    'MenuWynikiAnaliza
    '
    Me.MenuWynikiAnaliza.Name = "MenuWynikiAnaliza"
    Me.MenuWynikiAnaliza.Size = New System.Drawing.Size(166, 22)
    Me.MenuWynikiAnaliza.Text = "Analiza wyników"
    '
    'ToolStripSeparator8
    '
    Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
    Me.ToolStripSeparator8.Size = New System.Drawing.Size(163, 6)
    '
    'MenuWynikiWydruk
    '
    Me.MenuWynikiWydruk.Name = "MenuWynikiWydruk"
    Me.MenuWynikiWydruk.Size = New System.Drawing.Size(166, 22)
    Me.MenuWynikiWydruk.Text = "&Wydruk wyników"
    '
    'UstawieniaToolStripMenuItem
    '
    Me.UstawieniaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuUstawieniaConnectionParams, Me.MenuUstawieniaChangePassword, Me.MenuUstawieniaOpcje})
    Me.UstawieniaToolStripMenuItem.Enabled = False
    Me.UstawieniaToolStripMenuItem.Name = "UstawieniaToolStripMenuItem"
    Me.UstawieniaToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
    Me.UstawieniaToolStripMenuItem.Text = "&Ustawienia"
    '
    'MenuUstawieniaConnectionParams
    '
    Me.MenuUstawieniaConnectionParams.Enabled = False
    Me.MenuUstawieniaConnectionParams.Name = "MenuUstawieniaConnectionParams"
    Me.MenuUstawieniaConnectionParams.Size = New System.Drawing.Size(261, 22)
    Me.MenuUstawieniaConnectionParams.Text = "&Parametry połączenia z bazą danych"
    '
    'MenuUstawieniaChangePassword
    '
    Me.MenuUstawieniaChangePassword.Enabled = False
    Me.MenuUstawieniaChangePassword.Name = "MenuUstawieniaChangePassword"
    Me.MenuUstawieniaChangePassword.Size = New System.Drawing.Size(261, 22)
    Me.MenuUstawieniaChangePassword.Text = "Zmiana &hasła użytkownika"
    '
    'MenuUstawieniaOpcje
    '
    Me.MenuUstawieniaOpcje.Enabled = False
    Me.MenuUstawieniaOpcje.Name = "MenuUstawieniaOpcje"
    Me.MenuUstawieniaOpcje.Size = New System.Drawing.Size(261, 22)
    Me.MenuUstawieniaOpcje.Text = "Opcje"
    '
    'AboutToolStripMenuItem
    '
    Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
    Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
    Me.AboutToolStripMenuItem.Text = "O &programie"
    '
    'MainStatus
    '
    Me.MainStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel3, Me.statTryb, Me.ToolStripStatusLabel1, Me.statConn, Me.ToolStripStatusLabel2, Me.statUser, Me.ToolStripStatusLabel4, Me.statRola})
    Me.MainStatus.Location = New System.Drawing.Point(0, 244)
    Me.MainStatus.Name = "MainStatus"
    Me.MainStatus.Size = New System.Drawing.Size(719, 22)
    Me.MainStatus.TabIndex = 2
    Me.MainStatus.Text = "StatusStrip1"
    '
    'ToolStripStatusLabel3
    '
    Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
    Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(63, 17)
    Me.ToolStripStatusLabel3.Text = "Tryb pracy:"
    '
    'statTryb
    '
    Me.statTryb.AutoSize = False
    Me.statTryb.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
    Me.statTryb.ForeColor = System.Drawing.Color.Maroon
    Me.statTryb.Name = "statTryb"
    Me.statTryb.Size = New System.Drawing.Size(120, 17)
    Me.statTryb.Text = "StatTryb"
    Me.statTryb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'ToolStripStatusLabel1
    '
    Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
    Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(42, 17)
    Me.ToolStripStatusLabel1.Text = "Status:"
    '
    'statConn
    '
    Me.statConn.AutoSize = False
    Me.statConn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
    Me.statConn.ForeColor = System.Drawing.Color.Green
    Me.statConn.Margin = New System.Windows.Forms.Padding(0, 3, 10, 2)
    Me.statConn.Name = "statConn"
    Me.statConn.Size = New System.Drawing.Size(90, 17)
    Me.statConn.Text = "statConn"
    Me.statConn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.statConn.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
    '
    'ToolStripStatusLabel2
    '
    Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
    Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(65, 17)
    Me.ToolStripStatusLabel2.Text = "Użytkownik:"
    '
    'statUser
    '
    Me.statUser.AutoSize = False
    Me.statUser.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
    Me.statUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.statUser.Name = "statUser"
    Me.statUser.Size = New System.Drawing.Size(150, 17)
    Me.statUser.Text = "statUser"
    Me.statUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'ToolStripStatusLabel4
    '
    Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
    Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(32, 17)
    Me.ToolStripStatusLabel4.Text = "Rola:"
    '
    'statRola
    '
    Me.statRola.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
    Me.statRola.ForeColor = System.Drawing.Color.Orange
    Me.statRola.Name = "statRola"
    Me.statRola.Size = New System.Drawing.Size(55, 17)
    Me.statRola.Text = "statRola"
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 5
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.cmdUprawnienia, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.cmdPytania, 2, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.cmdPrintScores, 4, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.cmdWyniki, 3, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.cmdTest, 0, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.cmdStudents, 0, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.cmdPozwolenia, 4, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.cmdSoluteTest, 1, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 2
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(719, 220)
    Me.TableLayoutPanel1.TabIndex = 3
    '
    'cmdUprawnienia
    '
    Me.cmdUprawnienia.BackColor = System.Drawing.Color.Green
    Me.cmdUprawnienia.Dock = System.Windows.Forms.DockStyle.Fill
    Me.cmdUprawnienia.Enabled = False
    Me.cmdUprawnienia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
    Me.cmdUprawnienia.ForeColor = System.Drawing.Color.Gold
    Me.cmdUprawnienia.Location = New System.Drawing.Point(3, 3)
    Me.cmdUprawnienia.Name = "cmdUprawnienia"
    Me.cmdUprawnienia.Size = New System.Drawing.Size(137, 104)
    Me.cmdUprawnienia.TabIndex = 18
    Me.cmdUprawnienia.Text = "Uprawnienia do testów"
    Me.cmdUprawnienia.UseVisualStyleBackColor = False
    '
    'cmdPytania
    '
    Me.cmdPytania.BackColor = System.Drawing.Color.Green
    Me.cmdPytania.Dock = System.Windows.Forms.DockStyle.Fill
    Me.cmdPytania.Enabled = False
    Me.cmdPytania.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
    Me.cmdPytania.ForeColor = System.Drawing.Color.Gold
    Me.cmdPytania.Location = New System.Drawing.Point(289, 113)
    Me.cmdPytania.Name = "cmdPytania"
    Me.cmdPytania.Size = New System.Drawing.Size(137, 104)
    Me.cmdPytania.TabIndex = 17
    Me.cmdPytania.Text = "Rejestr pytań"
    Me.cmdPytania.UseVisualStyleBackColor = False
    '
    'cmdPrintScores
    '
    Me.cmdPrintScores.BackColor = System.Drawing.Color.Green
    Me.cmdPrintScores.Dock = System.Windows.Forms.DockStyle.Fill
    Me.cmdPrintScores.Enabled = False
    Me.cmdPrintScores.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
    Me.cmdPrintScores.ForeColor = System.Drawing.Color.Gold
    Me.cmdPrintScores.Location = New System.Drawing.Point(575, 113)
    Me.cmdPrintScores.Name = "cmdPrintScores"
    Me.cmdPrintScores.Size = New System.Drawing.Size(141, 104)
    Me.cmdPrintScores.TabIndex = 16
    Me.cmdPrintScores.Text = "Wydruk wyników"
    Me.cmdPrintScores.UseVisualStyleBackColor = False
    '
    'cmdWyniki
    '
    Me.cmdWyniki.BackColor = System.Drawing.Color.Green
    Me.cmdWyniki.Dock = System.Windows.Forms.DockStyle.Fill
    Me.cmdWyniki.Enabled = False
    Me.cmdWyniki.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
    Me.cmdWyniki.ForeColor = System.Drawing.Color.Gold
    Me.cmdWyniki.Location = New System.Drawing.Point(432, 113)
    Me.cmdWyniki.Name = "cmdWyniki"
    Me.cmdWyniki.Size = New System.Drawing.Size(137, 104)
    Me.cmdWyniki.TabIndex = 15
    Me.cmdWyniki.Text = "Rejestr wyników"
    Me.cmdWyniki.UseVisualStyleBackColor = False
    '
    'cmdTest
    '
    Me.cmdTest.BackColor = System.Drawing.Color.Green
    Me.cmdTest.Dock = System.Windows.Forms.DockStyle.Fill
    Me.cmdTest.Enabled = False
    Me.cmdTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
    Me.cmdTest.ForeColor = System.Drawing.Color.Gold
    Me.cmdTest.Location = New System.Drawing.Point(146, 113)
    Me.cmdTest.Name = "cmdTest"
    Me.cmdTest.Size = New System.Drawing.Size(137, 104)
    Me.cmdTest.TabIndex = 14
    Me.cmdTest.Text = "Rejestr testów"
    Me.cmdTest.UseVisualStyleBackColor = False
    '
    'cmdStudents
    '
    Me.cmdStudents.BackColor = System.Drawing.Color.Green
    Me.cmdStudents.Dock = System.Windows.Forms.DockStyle.Fill
    Me.cmdStudents.Enabled = False
    Me.cmdStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
    Me.cmdStudents.ForeColor = System.Drawing.Color.Gold
    Me.cmdStudents.Location = New System.Drawing.Point(3, 113)
    Me.cmdStudents.Name = "cmdStudents"
    Me.cmdStudents.Size = New System.Drawing.Size(137, 104)
    Me.cmdStudents.TabIndex = 13
    Me.cmdStudents.Text = "Rejestr uczniów"
    Me.cmdStudents.UseVisualStyleBackColor = False
    '
    'cmdPozwolenia
    '
    Me.cmdPozwolenia.BackColor = System.Drawing.Color.Green
    Me.cmdPozwolenia.Dock = System.Windows.Forms.DockStyle.Fill
    Me.cmdPozwolenia.Enabled = False
    Me.cmdPozwolenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
    Me.cmdPozwolenia.ForeColor = System.Drawing.Color.Gold
    Me.cmdPozwolenia.Location = New System.Drawing.Point(575, 3)
    Me.cmdPozwolenia.Name = "cmdPozwolenia"
    Me.cmdPozwolenia.Size = New System.Drawing.Size(141, 104)
    Me.cmdPozwolenia.TabIndex = 12
    Me.cmdPozwolenia.Text = "Pozwolenia odczytu"
    Me.cmdPozwolenia.UseVisualStyleBackColor = False
    '
    'cmdSoluteTest
    '
    Me.cmdSoluteTest.BackColor = System.Drawing.Color.Beige
    Me.TableLayoutPanel1.SetColumnSpan(Me.cmdSoluteTest, 3)
    Me.cmdSoluteTest.Dock = System.Windows.Forms.DockStyle.Fill
    Me.cmdSoluteTest.Font = New System.Drawing.Font("Impact", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
    Me.cmdSoluteTest.ForeColor = System.Drawing.Color.Firebrick
    Me.cmdSoluteTest.Location = New System.Drawing.Point(146, 3)
    Me.cmdSoluteTest.Name = "cmdSoluteTest"
    Me.cmdSoluteTest.Size = New System.Drawing.Size(423, 104)
    Me.cmdSoluteTest.TabIndex = 4
    Me.cmdSoluteTest.Text = "ROZWIĄŻ TEST"
    Me.cmdSoluteTest.UseVisualStyleBackColor = False
    '
    'frmMain
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(719, 266)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Controls.Add(Me.MainStatus)
    Me.Controls.Add(Me.MainMenuToolStrip)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MainMenuStrip = Me.MainMenuToolStrip
    Me.MaximizeBox = False
    Me.Name = "frmMain"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Błyskawica - tester wiedzy teoretycznej"
    Me.MainMenuToolStrip.ResumeLayout(False)
    Me.MainMenuToolStrip.PerformLayout()
    Me.MainStatus.ResumeLayout(False)
    Me.MainStatus.PerformLayout()
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents MainMenuToolStrip As System.Windows.Forms.MenuStrip
  Friend WithEvents MainStatus As System.Windows.Forms.StatusStrip
  Friend WithEvents StartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuPlikZamknij As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuPlikOpenTest As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents MenuPlikZaloguj As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuPlikWyloguj As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents OrganizujToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuOrganizujUczniowie As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuOrganizujImport As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuOrganizujExport As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuOrganizujUsers As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents TestyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents WynikiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents statConn As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents statUser As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents statTryb As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents UstawieniaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuUstawieniaConnectionParams As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuUstawieniaChangePassword As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuTestyRejestrTestow As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents MenuTestyImport As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuTestyExport As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents MenuTestyUprawnienia As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuWynikiRejestr As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuWynikiWydruk As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents MenuTestyKryteria As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuTestyRejestrPytan As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents cmdSoluteTest As System.Windows.Forms.Button
  Friend WithEvents MenuOrganizujPrzedmioty As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuWynikiAnaliza As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents MenuUstawieniaOpcje As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MenuTestyPozwolenia As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents cmdPrintScores As System.Windows.Forms.Button
  Friend WithEvents cmdWyniki As System.Windows.Forms.Button
  Friend WithEvents cmdTest As System.Windows.Forms.Button
  Friend WithEvents cmdStudents As System.Windows.Forms.Button
  Friend WithEvents cmdPozwolenia As System.Windows.Forms.Button
  Friend WithEvents cmdUprawnienia As System.Windows.Forms.Button
  Friend WithEvents cmdPytania As System.Windows.Forms.Button
  Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents statRola As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents MenuTestyKryteriaPrawa As System.Windows.Forms.ToolStripMenuItem
End Class
