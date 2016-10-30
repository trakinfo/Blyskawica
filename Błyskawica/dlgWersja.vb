Imports System.Windows.Forms
Imports System.Security.Principal
Public Class dlgWersja
  Private DS As DataSet
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    'Me.DialogResult = System.Windows.Forms.DialogResult.OK
    'Me.Close()
    Dim dlg As New dlgPassword
    With dlg
      If .ShowDialog = Windows.Forms.DialogResult.OK Then
        Dim R As New Rijndael
        If String.Compare(.txtPassword.Text, R.Decrypt(DS.Tables(0).Select("ID=" & lvTest.SelectedItems(0).Text)(0).Item(3).ToString)) = 0 Then
          If AddNew() Then
            Dim dlgOpen As New dlgOpenTest
            With dlgOpen
              .Text += " - " & lvTest.SelectedItems(0).SubItems(1).Text
              .lblStart.Text = Date.Now.ToShortTimeString
              .lblStop.Text = Date.Now.AddMinutes(CType(lblLimitCzasu.Text, Double)).ToShortTimeString
              .lblTimeLeft.Text = lblLimitCzasu.Text
              If .ShowDialog(Me) = DialogResult.OK Then
                txtWynik.Text = .Score.ToString
                txtOcena.Text = GetGrade(CType(txtWynik.Text, Single))
              End If

            End With
          Else
            MessageBox.Show("Nie udało się utworzyć wersji testu. Powiadom nauczyciela!")
          End If
        Else
          MessageBox.Show("Nieprawidłowe hasło!", "Hasło", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
      End If
    End With
  End Sub
  Private Function GetGrade(ByVal Score As Single) As String
    For Each Row As DataRow In DS.Tables(1).Select("NazwaKryterium='" & DS.Tables(0).Select("ID=" & lvTest.SelectedItems(0).Text)(0).Item("NazwaKryterium").ToString & "'") 'DS.Tables(1).Rows
      If Score >= CType(Row.Item(1), Single) And Score <= CType(Row.Item(2), Single) Then
        Return Row.Item(3).ToString
      End If
    Next
    Return ""
  End Function
  Public Function AddNew() As Boolean
    Dim MySQLTrans As MySqlTransaction
    Dim DBA As New DataBaseAction, W As New WersjaSQL
    Dim cmd As MySqlCommand = DBA.CreateCommand(W.InsertWersja)
    MySQLTrans = GlobalValues.gblConn.BeginTransaction()
    cmd.Transaction = MySQLTrans

    Try
      Dim R As New Rijndael

      cmd.Parameters.AddWithValue("?Nazwa", CType(cbStudent.SelectedItem, CbItem).Nazwa & " <" & Date.Now.ToString & ">")
      cmd.Parameters.AddWithValue("?CzasRozpoczecia", Date.Now)
      cmd.Parameters.AddWithValue("?IdStudentTest", SharedVersion.IdStudentTest)
      cmd.Parameters.AddWithValue("?User", txtUser.Text)
      cmd.Parameters.AddWithValue("?ComputerIP", GlobalValues.gblIP)
      cmd.ExecuteNonQuery()
      SharedVersion.VersionID = cmd.LastInsertedId
      MySQLTrans.Commit()
      Return True
    Catch err As MySqlException
      MySQLTrans.Rollback()
      SharedVersion.VersionID = Nothing
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

  Private Sub dlgWersja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    lblTypTestu.Text = ""
    lblLimitCzasu.Text = ""
    txtUser.Text = GetLoggedUser()
    SharedVersion.UserName = txtUser.Text
    txtIP.Text = GlobalValues.gblIP & " (" & GlobalValues.gblHostName & ")"
    Me.ListViewConfig(Me.lvTest)
    ListViewConfig(lvKryteria)

    Dim FCB As New FillComboBox, W As New WersjaSQL
    FCB.AddComboBoxComplexItems(cbKlasa, W.SelectKlasa, True)
    If cbKlasa.Items.Count > 0 Then cbKlasa.Enabled = True
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
      If lv.Name = "lvTest" Then
        .Columns.Add("Nazwa testu", 594, HorizontalAlignment.Left)
      Else
        .Columns.Add("Minimum", 150, HorizontalAlignment.Center)
        .Columns.Add("Maksimum", 150, HorizontalAlignment.Center)
        .Columns.Add("Ocena", 294, HorizontalAlignment.Left)
      End If
    End With
  End Sub
  Private Sub FetchData(ByVal IdStudent As String)
    Dim DBA As New DataBaseAction, W As New WersjaSQL
    DS = DBA.GetDataSet(W.SelectTest(IdStudent) & W.SelectKryteria())
  End Sub
  Private Sub GetData()
    lvTest.Items.Clear()
    For Each row As DataRow In DS.Tables(0).Rows
      Me.lvTest.Items.Add(row.Item(0).ToString)
      Me.lvTest.Items(Me.lvTest.Items.Count - 1).SubItems.Add(row.Item(1).ToString)
    Next
    lvTest.Columns(1).Width = CInt(IIf(lvTest.Items.Count > 10, 575, 594))
    Me.lvTest.Enabled = CType(IIf(Me.lvTest.Items.Count > 0, True, False), Boolean)

  End Sub
  Private Sub GetCriteria()
    lvKryteria.Items.Clear()
    For Each row As DataRow In DS.Tables(1).Select("NazwaKryterium='" & DS.Tables(0).Select("ID=" & lvTest.SelectedItems(0).Text)(0).Item("NazwaKryterium").ToString & "'")
      Me.lvKryteria.Items.Add(row.Item(0).ToString)
      Me.lvKryteria.Items(Me.lvKryteria.Items.Count - 1).SubItems.Add(row.Item(1).ToString)
      Me.lvKryteria.Items(Me.lvKryteria.Items.Count - 1).SubItems.Add(row.Item(2).ToString)
      Me.lvKryteria.Items(Me.lvKryteria.Items.Count - 1).SubItems.Add(row.Item(3).ToString)
    Next
    lvKryteria.Columns(3).Width = CInt(IIf(lvKryteria.Items.Count > 10, 275, 294))
    Me.lvKryteria.Enabled = CType(IIf(Me.lvKryteria.Items.Count > 0, True, False), Boolean)

  End Sub
  Private Function GetLoggedUser() As String
    Dim ID As WindowsIdentity
    ID = WindowsIdentity.GetCurrent
    Return ID.Name
  End Function

  Private Sub cbKlasa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbKlasa.SelectedIndexChanged
    txtWynik.Text = ""
    txtOcena.Text = ""
    cbStudent.Items.Clear()
    Dim FCB As New FillComboBox, W As New WersjaSQL
    FCB.AddComboBoxComplexItems(cbStudent, W.SelectStudent(CType(cbKlasa.SelectedItem, CbItem).Kod))
    cbStudent.Enabled = CType(IIf(cbStudent.Items.Count > 0, True, False), Boolean)
  End Sub

  Private Sub cbStudent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbStudent.SelectedIndexChanged
    txtWynik.Text = ""
    txtOcena.Text = ""
    FetchData(CType(cbStudent.SelectedItem, CbItem).ID.ToString)
    lvKryteria.Items.Clear()
    GetData()
  End Sub

  Private Sub lvTest_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvTest.DoubleClick
    OK_Button_Click(sender, e)
  End Sub

  Private Sub lvTest_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvTest.ItemSelectionChanged
    lvKryteria.Items.Clear()
    txtWynik.Text = ""
    txtOcena.Text = ""
    lblLimitCzasu.Text = ""
    lblTypTestu.Text = ""
    If e.IsSelected Then
      SharedVersion.TestID = CType(e.Item.Text, Integer)
      SharedVersion.LimitOdp = CType(DS.Tables(0).Select("ID=" & e.Item.Text)(0).Item(5), Integer)
      SharedVersion.IdStudentTest = CType(DS.Tables(0).Select("ID=" & e.Item.Text)(0).Item(7), Integer)
      GetCriteria()
      lblLimitCzasu.Text = DS.Tables(0).Select("ID=" & e.Item.Text)(0).Item("LimitCzasu").ToString
      SharedVersion.TypTestu = CType(DS.Tables(0).Select("ID=" & e.Item.Text)(0).Item("WyborWielokrotny"), GlobalValues.TypTestu)
      lblTypTestu.Text = SharedVersion.TypTestu.ToString   'CType(DS.Tables(0).Select("ID=" & e.Item.Text)(0).Item("WyborWielokrotny"), GlobalValues.TypTestu).ToString
      OK_Button.Enabled = True
    Else
      OK_Button.Enabled = False
    End If
  End Sub

  Private Sub dlgWersja_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    Dim LinePen As New Pen(Color.White, 1)
    e.Graphics.DrawLine(LinePen, New Point(2, 440), New Point(623, 440))
  End Sub
End Class

Public Class WersjaSQL
  Public Function SelectTest(ByVal IdStudent As String) As String
    Return "SELECT t.ID,t.Nazwa,t.LimitCzasu,t.Haslo,t.NazwaKryterium,t.LimitOdpowiedzi,t.WyborWielokrotny,st.ID AS IdStudentTest FROM test t INNER JOIN student_test st ON t.ID=st.IdTest WHERE st.IdStudent='" & IdStudent & "' AND t.Status=1 Order BY t.IdPrzedmiot,t.Version;"
  End Function
  Public Function SelectKryteria() As String
    Return "SELECT ID,Min,Max,Ocena,NazwaKryterium FROM kryterium k ORDER BY NazwaKryterium,Min;"
  End Function
  Public Function SelectKlasa() As String
    Return "SELECT KodKlasy,Nazwa FROM klasa ORDER BY KodKlasy;"
  End Function
  Public Function SelectStudent(ByVal Klasa As String) As String
    Return "SELECT ID,Concat_WS(' ',Nazwisko,Imie) AS Student FROM student WHERE Klasa='" & Klasa & "' ORDER BY Nazwisko,Imie;"
  End Function
  Public Function InsertWersja() As String
    Return "INSERT INTO wersja (Nazwa,CzasRozpoczecia,IdStudentTest,User,ComputerIP,Version) VALUES (?Nazwa,?CzasRozpoczecia,?IdStudentTest,?User,?ComputerIP,NULL);"
  End Function
  Public Function SelectPytanie(ByVal IdTest As String) As String
    Return "SELECT p.ID,p.Tresc FROM pytanie p,test_pytanie tp WHERE p.ID=tp.IdPytanie AND tp.IdTest='" & IdTest & "' Order By tp.NrPytania;"
  End Function
  'Public Function SelectAnswer(ByVal IdTest As String) As String
  '  Return "SELECT o.ID,o.TrescOdpowiedzi,o.Punktacja,o.IdPytanie FROM odpowiedz o WHERE o.IdPytanie IN (SELECT IdPytanie FROM test_pytanie WHERE IdTest=" & IdTest & ");"
  'End Function
  Public Function UpdateWersja(ByVal IdWersja As Long) As String
    Return "UPDATE wersja SET Score=?Score,CzasZakonczenia=?CzasZakonczenia,Version=NULL WHERE ID=" & IdWersja & ";"
  End Function
  Public Function InsertWynik() As String
    Return "INSERT INTO wynik (IdOdpowiedz,IdWersja,User,ComputerIP,Version) VALUES (?IdOdpowiedz,?IdWersja,?User,?ComputerIP,NULL);"
  End Function
  Public Function SelectWrongAnswer(ByVal IdPytanie As String, ByVal Limit As String) As String
    Return "SELECT o.ID,o.TrescOdpowiedzi,o.Punktacja,o.IdPytanie FROM odpowiedz o WHERE o.IdPytanie=" & IdPytanie & " AND o.Punktacja<=0 ORDER BY Rand() Limit " & Limit & ";"
  End Function
  Public Function SelectCorrectAnswer(ByVal IdPytanie As String, ByVal Limit As String) As String
    Return "SELECT o.ID,o.TrescOdpowiedzi,o.Punktacja,o.IdPytanie FROM odpowiedz o WHERE o.IdPytanie=" & IdPytanie & " AND o.Punktacja>0 ORDER BY Rand() Limit " & Limit & ";"
  End Function
  Public Function CountCorrectAnswers(ByVal IdPytanie As String) As String
    Return "SELECT COUNT(*) FROM odpowiedz WHERE IdPytanie=" & IdPytanie & " AND Punktacja>0;"
  End Function
  'Public Overloads Function SelectCorrectAnswer(ByVal IdTest As String, ByVal Limit As String) As String
  '  Return "SELECT o.ID,o.TrescOdpowiedzi,o.Punktacja,o.IdPytanie FROM odpowiedz o WHERE o.IdPytanie IN (SELECT IdPytanie FROM test_pytanie WHERE IdTest=" & IdTest & ") AND o.Punktacja>0  ORDER BY Rand() Limit " & Limit & ";"
  'End Function
End Class