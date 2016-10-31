Imports System.Drawing.Printing

Public Class frmWyniki
  Private DS As DataSet, TypTestu As Byte
  Public Event NewRow()

  Private Sub frmWyniki_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.ListViewConfig(Me.lvStudent)
    ListViewConfig(lvWersja)
    Dim FCB As New FillComboBox, T As New TestSQL, W As New WynikiSQL
    FCB.AddComboBoxComplexItems(cbGrupa, W.SelectGroups, True)
    FCB.AddComboBoxComplexItems(cbPrzedmiot, T.SelectPrzedmiot)
    If cbPrzedmiot.Items.Count > 0 Then
      Dim SH As New SeekHelper
      SH.FindComboItem(cbPrzedmiot, CInt(SH.GetDefault(T.SelectDefault("przedmiot"))))
      'cbPrzedmiot.Enabled = True
    End If

  End Sub
  Private Sub ListViewConfig(ByVal lv As ListView)
    With lv
      .View = View.Details
      .FullRowSelect = True
      .GridLines = True
      '.MultiSelect = True
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
      If lv.Name = "lvWersja" Then
        .Columns.Add("Nazwa", 300, HorizontalAlignment.Left)
        .Columns.Add("Wynik", 75, HorizontalAlignment.Center)
        .Columns.Add("Ocena", 100, HorizontalAlignment.Left)
        .Columns.Add("Start", 103, HorizontalAlignment.Center)
        .Columns.Add("Koniec", 103, HorizontalAlignment.Center)
      Else
        .Columns.Add("Nazwisko i imię", 155, HorizontalAlignment.Left)
      End If
    End With
  End Sub
  Private Sub FetchData(ByVal IdStudent As String, ByVal IdTest As String)
    Dim DBA As New DataBaseAction, W As New WynikiSQL
    TypTestu = CType(DBA.ComputeRecords(W.SelectTestType(IdTest)), Byte)
    DS = DBA.GetDataSet(W.SelectVersionScores(IdStudent, IdTest) & W.SelectPytanie(IdTest) & W.SelectAnswer(IdStudent, IdTest) & W.SelectKryteria(IdTest))
  End Sub
  Private Sub cbPrzedmiot_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPrzedmiot.SelectedIndexChanged
    If cbGrupa.SelectedItem Is Nothing Then Exit Sub
    cbTest.Items.Clear()
    lvWersja.Items.Clear()
    lvWersja.Enabled = False
    tvOdp.Nodes.Clear()
    Dim FCB As New FillComboBox, W As New WynikiSQL
    FCB.AddComboBoxComplexItems(cbTest, W.SelectTests(CType(cbGrupa.SelectedItem, CbItem).Kod, CType(cbPrzedmiot.SelectedItem, CbItem).ID.ToString))
    cbTest.Enabled = CType(IIf(cbTest.Items.Count > 0, True, False), Boolean)
    cmdPrint.Enabled = False
    cmdPrint.Enabled = False
  End Sub
  Private Sub cbGrupa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbGrupa.SelectedIndexChanged
    Dim W As New WynikiSQL
    ClearDetails()
    cmdPrint.Enabled = False
    cmdDelete.Enabled = False
    cbPrzedmiot.Enabled = CType(IIf(cbPrzedmiot.Items.Count > 0, True, False), Boolean)
    GetStudent(CType(cbGrupa.SelectedItem, CbItem).Kod)
    If cbPrzedmiot.SelectedItem IsNot Nothing Then
      cbPrzedmiot_SelectedIndexChanged(sender, e)
    End If
  End Sub
  Private Sub GetStudent(ByVal Grupa As String)
    Dim W As New WynikiSQL, R As MySqlDataReader = Nothing, DBA As New DataBaseAction
    lvStudent.Items.Clear()
    Try
      R = DBA.GetReader(W.SelectStudent(Grupa))
      While R.Read
        Me.lvStudent.Items.Add(R.Item(0).ToString).UseItemStyleForSubItems = False
        Me.lvStudent.Items(Me.lvStudent.Items.Count - 1).SubItems.Add(R.Item(1).ToString)
      End While
      lvStudent.Columns(1).Width = CInt(IIf(lvStudent.Items.Count > 31, 136, 155))
      Me.lvStudent.Enabled = CType(IIf(Me.lvStudent.Items.Count > 0, True, False), Boolean)

    Catch mex As MySqlException
      MessageBox.Show(mex.Message)
    Catch ex As Exception
      MessageBox.Show(ex.Message)
    Finally
      R.Close()
    End Try

  End Sub
  Private Sub GetData() 'ByVal IdStudent As String)
    'lvWersja.Items.Clear()
    For Each row As DataRow In DS.Tables(0).Rows 'Select("IdStudent='" & IdStudent & "'")
      Me.lvWersja.Items.Add(row.Item(0).ToString)
      Me.lvWersja.Items(Me.lvWersja.Items.Count - 1).SubItems.Add(row.Item(1).ToString)
      Me.lvWersja.Items(Me.lvWersja.Items.Count - 1).SubItems.Add(row.Item(2).ToString)
      If row.Item(2).ToString.Length > 0 Then
        Me.lvWersja.Items(Me.lvWersja.Items.Count - 1).SubItems.Add(GetGrade(CType(row.Item(2).ToString, Single)))
      Else
        Me.lvWersja.Items(Me.lvWersja.Items.Count - 1).SubItems.Add("")

      End If
      Me.lvWersja.Items(Me.lvWersja.Items.Count - 1).SubItems.Add(row.Item(3).ToString)
      Me.lvWersja.Items(Me.lvWersja.Items.Count - 1).SubItems.Add(row.Item(4).ToString)
    Next
    lvWersja.Columns(1).Width = CInt(IIf(lvWersja.Items.Count > 7, 281, 300))
    Me.lvWersja.Enabled = CType(IIf(Me.lvWersja.Items.Count > 0, True, False), Boolean)

  End Sub
  Private Sub GetDetails(ByVal IdWersja As String)
    Try
      With DS.Tables(0).Select("ID='" & IdWersja & "'")(0)
        lblUser.Text = .Item(5).ToString
        lblIP.Text = .Item(6).ToString
        lblData.Text = .Item(7).ToString
      End With
    Catch err As Exception
      MessageBox.Show(err.Message)
    End Try
  End Sub
  Private Sub ClearDetails()
    Me.lblUser.Text = ""
    Me.lblData.Text = ""
    Me.lblIP.Text = ""
  End Sub

  Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
    Me.Close()
  End Sub

  Private Sub lvStudent_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvStudent.ItemSelectionChanged
    ClearDetails()
    cmdPrint.Enabled = False
    cmdDelete.Enabled = False
    tvOdp.Nodes.Clear()
    lvWersja.Items.Clear()
    lvWersja.Enabled = False
    If lvStudent.SelectedItems.Count > 0 Then
      If cbTest.SelectedItem IsNot Nothing Then
        FetchData(lvStudent.SelectedItems(0).Text, CType(cbTest.SelectedItem, CbItem).ID.ToString)
        'cbTest_SelectedIndexChanged(sender, Nothing)
        GetData()
      End If
    End If
  End Sub

  Private Sub cbTest_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTest.SelectedIndexChanged

    'lvWersja.Items.Clear()
    'tvOdp.Nodes.Clear()
    'FetchData(CType(cbGrupa.SelectedItem, CbItem).Kod, CType(cbTest.SelectedItem, CbItem).ID.ToString)
    'cmdPrint.Enabled = True
    lvStudent_ItemSelectionChanged(sender, Nothing)
    'Me.lvStudent.Enabled = CType(IIf(Me.lvStudent.Items.Count > 0, True, False), Boolean)
  End Sub

  Private Sub lvWersja_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvWersja.ItemSelectionChanged
    ClearDetails()
    If e.IsSelected Then
      FillTV() '(cbTest.Text)
      GetDetails(e.Item.Text)
      cmdPrint.Enabled = True
      cmdDelete.Enabled = True
    Else
      tvOdp.Nodes.Clear()
      tvOdp.Enabled = False
      cmdPrint.Enabled = False
      cmdDelete.Enabled = False
    End If
  End Sub
  Private Function GetGrade(ByVal Score As Single) As String
    For Each Row As DataRow In DS.Tables(3).Rows
      If Score >= CType(Row.Item(1), Single) And Score <= CType(Row.Item(2), Single) Then
        Return Row.Item(3).ToString
      End If
    Next
    Return ""
  End Function
  Private Sub FillTV() 'ByVal Test As String)
    Dim RootNode As New TreeNode("Wykaz odpowiedzi")
    tvOdp.Nodes.Add(RootNode)
    GetPytanie(RootNode)
    RootNode.Expand()
  End Sub
  Private Sub GetAnswer(ByVal Node As TreeNode, ByVal IdWersja As String)
    Try
      For Each Row As DataRow In DS.Tables(2).Select("IdPytanie=" & Node.Tag.ToString & " AND IdWersja=" & IdWersja)
        Dim NewNode As New TreeNode(Row.Item(1).ToString)
        NewNode.ForeColor = CType(IIf(CType(Row.Item(2), Int16) > 0, Color.Green, Color.Red), Color)
        Node.Nodes.Add(NewNode)
      Next
    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
  End Sub
  Private Sub GetPytanie(ByVal Node As TreeNode)
    Try
      For Each Row As DataRow In DS.Tables(1).Rows
        Dim NewNode As New TreeNode(Row.Item(1).ToString)
        NewNode.Tag = Row.Item(0)
        If DS.Tables(2).Select("IdPytanie=" & NewNode.Tag.ToString & " AND IdWersja=" & lvWersja.SelectedItems(0).Text).GetLength(0) > 0 Then
          If TypTestu = 1 Then
            NewNode.ForeColor = CType(IIf(CType(DS.Tables(2).Compute("SUM(Punktacja)", "IdPytanie=" & NewNode.Tag.ToString & " AND IdWersja=" & lvWersja.SelectedItems(0).Text), Single) = 100, tvOdp.ForeColor, Color.Red), System.Drawing.Color)

          Else
            NewNode.ForeColor = CType(IIf(CType(DS.Tables(2).Compute("SUM(Punktacja)", "IdPytanie=" & NewNode.Tag.ToString & " AND IdWersja=" & lvWersja.SelectedItems(0).Text), Single) > 0, tvOdp.ForeColor, Color.Red), System.Drawing.Color)
          End If

        Else
          NewNode.ForeColor = Color.Red
        End If
        Node.Nodes.Add(NewNode)
        NewNode.Nodes.Add("*")
      Next
      Me.tvOdp.Enabled = CType(IIf(Me.tvOdp.Nodes.Count > 0, True, False), Boolean)

    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
  End Sub

  Private Sub tvOdp_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles tvOdp.BeforeExpand
    If e.Node.Nodes(0).Text = "*" Then
      e.Node.Nodes.Clear()
      GetAnswer(e.Node, lvWersja.SelectedItems(0).Text)
      tvOdp.EndUpdate()

    End If
  End Sub

  Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
    Dim DBA As New DataBaseAction, DeletedIndex As Integer, W As New WynikiSQL

    For Each Item As ListViewItem In Me.lvWersja.SelectedItems
      DeletedIndex = Item.Index
      DBA.ApplyChanges(W.DeleteWersja(Item.Text))
    Next

    'Me.EnableQuestionButtons(False)
    'EnableButtons(False)
    cmdDelete.Enabled = False
    tvOdp.Nodes.Clear()
    lvWersja.Items.Clear()
    FetchData(lvStudent.SelectedItems(0).Text, CType(cbTest.SelectedItem, CbItem).ID.ToString)
    Me.GetData()
    Dim SH As New SeekHelper
    SH.FindRemovedListViewItemIndex(Me.lvWersja, DeletedIndex)
  End Sub

  Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
    Dim PP As New dlgPrintPreview, DsScores As New DataSet
    Dim DBA As New DataBaseAction, W As New WynikiSQL
    Dim ColWidth(4) As Single, Offset(3) As Integer, LevelMarker(1) As Boolean
    For i As Integer = 0 To 3
      Offset(i) = 0
    Next
    LevelMarker(0) = True : LevelMarker(1) = True
    ColWidth(0) = 293 : ColWidth(1) = 59 : ColWidth(2) = 110 : ColWidth(3) = 143 : ColWidth(4) = 143
    Dim Margins As New PrintVariables
    Margins.LeftMargin = 39
    Margins.RightMargin = 39
    DsScores.Tables.Add(DS.Tables(1).Copy)
    DsScores.Tables.Add(DS.Tables(2).Copy)
    PP.Doc = New PrintReport(DsScores)
    PP.Doc.Offset = Offset
    PP.Doc.ColWidth = ColWidth
    PP.Doc.PrintLevelMarker = LevelMarker
    'PP.Doc.PrintLevelMarker(1) = True
    AddHandler PP.Doc.PrintPage, AddressOf PrnDoc_PrintPage
    AddHandler NewRow, AddressOf PP.NewRow
    PP.Doc.ReportHeader = New String() {"Wyniki testu", lvStudent.SelectedItems(0).SubItems(1).Text}
    PP.ShowDialog()
  End Sub
  Public Sub PrnDoc_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs) 'Handles Doc.PrintPage
    Dim Doc As PrintReport = CType(sender, PrintReport)
    Dim x As Single = Doc.DefaultPageSettings.Margins.Left - Doc.DefaultPageSettings.PrintableArea.Left
    'Dim x As Single = Doc.DefaultPageSettings.Margins.Left - Doc.DefaultPageSettings.PrinterSettings.DefaultPageSettings.PrintableArea.Left
    Dim y As Single = Doc.DefaultPageSettings.Margins.Top - Doc.DefaultPageSettings.PrintableArea.Top
    Dim PrnVars As New PrintVariables
    Dim TextFont As Font = PrnVars.BaseFont
    Dim HeaderFont As Font = PrnVars.HeaderFont
    Dim LineHeight As Single = TextFont.GetHeight(e.Graphics)
    Dim HeaderLineHeight As Single = HeaderFont.GetHeight(e.Graphics)
    Doc.PageNumber += 1
    Doc.DrawText(e, "- " & Doc.PageNumber & " -", TextFont, x, Doc.DefaultPageSettings.PrintableArea.Top + LineHeight, Doc.ColWidth.Sum, LineHeight, 1, Brushes.Black, False)
    If Doc.PageNumber = 1 Then
      y += LineHeight
      Doc.DrawText(e, Doc.ReportHeader(0), HeaderFont, x, y, Doc.ColWidth.Sum, HeaderLineHeight, 1, Brushes.Black, False)
      y += LineHeight * 2
      Doc.DrawText(e, "Klasa: ", TextFont, x, y, Doc.ColWidth.Sum, HeaderLineHeight, 0, Brushes.Black, False)
      Doc.DrawText(e, cbGrupa.Text, New Font(TextFont, FontStyle.Bold), x + e.Graphics.MeasureString("Klasa: ", TextFont).Width, y, Doc.ColWidth.Sum - e.Graphics.MeasureString("Klasa: ", TextFont).Width, HeaderLineHeight, 0, Brushes.Black, False)
      'y += LineHeight
      Doc.DrawText(e, "Nazwisko i imię: ", TextFont, x + Doc.ColWidth.Sum - e.Graphics.MeasureString("Nazwisko i imię: ", TextFont).Width - e.Graphics.MeasureString(Doc.ReportHeader(1), New Font(TextFont, FontStyle.Bold)).Width, y, e.Graphics.MeasureString("Nazwisko i imię: ", TextFont).Width, HeaderLineHeight, 0, Brushes.Black, False)
      Doc.DrawText(e, Doc.ReportHeader(1), New Font(TextFont, FontStyle.Bold), x + Doc.ColWidth.Sum - e.Graphics.MeasureString(Doc.ReportHeader(1), New Font(TextFont, FontStyle.Bold)).Width, y, e.Graphics.MeasureString(Doc.ReportHeader(1), New Font(TextFont, FontStyle.Bold)).Width, HeaderLineHeight, 2, Brushes.Black, False)
      y += LineHeight
      Doc.DrawText(e, "Nazwa testu: ", TextFont, x, y, Doc.ColWidth.Sum, HeaderLineHeight, 0, Brushes.Black, False)
      Doc.DrawText(e, cbTest.Text, New Font(TextFont, FontStyle.Bold), x + e.Graphics.MeasureString("Nazwa testu: ", TextFont).Width, y, Doc.ColWidth.Sum, HeaderLineHeight, 0, Brushes.Black, False)
      'y += LineHeight
      Doc.DrawText(e, "Przedmiot: ", TextFont, x + Doc.ColWidth.Sum - e.Graphics.MeasureString("Przedmiot: ", TextFont).Width - e.Graphics.MeasureString(cbPrzedmiot.Text, New Font(TextFont, FontStyle.Bold)).Width, y, e.Graphics.MeasureString("Przedmiot: ", TextFont).Width, HeaderLineHeight, 0, Brushes.Black, False)
      Doc.DrawText(e, cbPrzedmiot.Text, New Font(TextFont, FontStyle.Bold), x + Doc.ColWidth.Sum - e.Graphics.MeasureString(cbPrzedmiot.Text, New Font(TextFont, FontStyle.Bold)).Width, y, e.Graphics.MeasureString(cbPrzedmiot.Text, New Font(TextFont, FontStyle.Bold)).Width, HeaderLineHeight, 2, Brushes.Black, False)
      y += LineHeight * 3

      Dim x1 As Single
      x1 = x
      Doc.DrawText(e, "Wersja", PrnVars.BoldFont, x1, y, Doc.ColWidth(0), LineHeight * 2, 1, Brushes.Black)
      x1 += Doc.ColWidth(0)
      Doc.DrawText(e, "Wynik", PrnVars.BoldFont, x1, y, Doc.ColWidth(1), LineHeight * 2, 1, Brushes.Black)
      x1 += Doc.ColWidth(1)
      Doc.DrawText(e, "Ocena", PrnVars.BoldFont, x1, y, Doc.ColWidth(2), LineHeight * 2, 1, Brushes.Black)
      x1 += Doc.ColWidth(2)
      Doc.DrawText(e, "Czas rozpoczęcia", PrnVars.BoldFont, x1, y, Doc.ColWidth(3), LineHeight * 2, 1, Brushes.Black)
      x1 += Doc.ColWidth(3)
      Doc.DrawText(e, "Czas zakończenia", PrnVars.BoldFont, x1, y, Doc.ColWidth(4), LineHeight * 2, 1, Brushes.Black)
      y += LineHeight * 2
    End If
    PrintScore(e, Doc, x, y, TextFont, LineHeight)

  End Sub
  Private Sub PrintScore(ByVal e As PrintPageEventArgs, ByVal Doc As PrintReport, ByVal x As Single, ByVal y As Single, ByVal TextFont As Font, ByVal LineHeight As Single)

    Dim x1 As Single = x
    If Doc.PageNumber = 1 Then
      Doc.DrawText(e, lvWersja.SelectedItems(0).SubItems(1).Text, TextFont, x1, y, Doc.ColWidth(0), LineHeight * 2, 0, Brushes.Black)
      x1 += Doc.ColWidth(0)
      Doc.DrawText(e, lvWersja.SelectedItems(0).SubItems(2).Text, TextFont, x1, y, Doc.ColWidth(1), LineHeight * 2, 1, Brushes.Black)
      x1 += Doc.ColWidth(1)
      Doc.DrawText(e, lvWersja.SelectedItems(0).SubItems(3).Text, TextFont, x1, y, Doc.ColWidth(2), LineHeight * 2, 1, Brushes.Black)
      x1 += Doc.ColWidth(2)
      Doc.DrawText(e, lvWersja.SelectedItems(0).SubItems(4).Text, TextFont, x1, y, Doc.ColWidth(3), LineHeight * 2, 1, Brushes.Black)
      x1 += Doc.ColWidth(3)
      Doc.DrawText(e, lvWersja.SelectedItems(0).SubItems(5).Text, TextFont, x1, y, Doc.ColWidth(4), LineHeight * 2, 1, Brushes.Black)
      y += LineHeight * 3
      x1 = x
      Doc.DrawText(e, "Wykaz odpowiedzi", New Font(TextFont, FontStyle.Bold), x1, y, Doc.ColWidth.Sum, LineHeight * 2, 1, Brushes.Black, False)
      y += LineHeight * 3

    End If

    Do Until (y + LineHeight * 2) > e.MarginBounds.Bottom Or Doc.Offset(0) > Doc.DS.Tables(0).Rows.Count - 1
      x1 = x
      Dim Indent As Single
      Indent = Math.Ceiling(CType(e.Graphics.MeasureString(Doc.Offset(0) + 1 & ") ", New Font(TextFont, FontStyle.Bold)).Width, Decimal))
      If Doc.PrintLevelMarker(0) Then Doc.DrawText(e, Doc.Offset(0) + 1 & ") ", New Font(TextFont, FontStyle.Bold), x1, y, e.MarginBounds.Width, LineHeight, 0, Brushes.Black, False)
      x1 += Indent
      Dim TextToPrint() As String = Doc.DS.Tables(0).Rows(Doc.Offset(0)).Item(1).ToString.Split(" "c) 'CType(InformationContents.ToArray(GetType(String)), String())

      Dim Line As New System.Text.StringBuilder ', idx As Integer = 0

      Do While (TextToPrint.GetUpperBound(0) >= Doc.Offset(2))
        Line.Append(TextToPrint(Doc.Offset(2)) & " ")
        If e.Graphics.MeasureString(Line.ToString.Trim, New Font(TextFont, FontStyle.Bold)).Width > (e.MarginBounds.Width - Indent) Then
          Line.Remove(Line.ToString.Length - TextToPrint(Doc.Offset(2)).Length - 1, TextToPrint(Doc.Offset(2)).Length)
          Doc.DrawText(e, Line.ToString.Trim, New Font(TextFont, FontStyle.Bold), x1, y, e.MarginBounds.Width - Indent, LineHeight, 0, Brushes.Black, False)
          y += LineHeight
          If (y + LineHeight) > e.MarginBounds.Bottom Then Exit Do
          Doc.Offset(2) -= 1
          Line = New System.Text.StringBuilder
        End If
        Doc.Offset(2) += 1
      Loop
      If (y + LineHeight) < e.MarginBounds.Bottom AndAlso Line.Length > 0 Then
        Doc.DrawText(e, Line.ToString.Trim(), New Font(TextFont, FontStyle.Bold), x1, y, e.MarginBounds.Width - Indent, LineHeight, 0, Brushes.Black, False)
        Doc.Offset(2) += 1
        y += LineHeight '* LineNumber
      Else
        If Line.Length > 0 Then Exit Do
      End If

      Do Until (y + LineHeight) > e.MarginBounds.Bottom Or Doc.Offset(1) > Doc.DS.Tables(1).Select("IdPytanie=" & Doc.DS.Tables(0).Rows(Doc.Offset(0)).Item(0).ToString & " AND IdWersja=" & lvWersja.SelectedItems(0).Text).GetUpperBound(0)
        x1 = x + Indent
        Dim SubIndent As Single = Math.Ceiling(CType(e.Graphics.MeasureString(Chr(97 + Doc.Offset(1)) & ") ", TextFont).Width, Decimal))
        If Doc.PrintLevelMarker(1) Then
          Doc.DrawText(e, Chr(97 + Doc.Offset(1)) & ") ", TextFont, x1, y, e.MarginBounds.Width - Indent, LineHeight, 0, Brushes.Black, False)
          'Doc.PrintAlfa = False
        End If
        x1 += SubIndent
        TextToPrint = Doc.DS.Tables(1).Select("IdPytanie=" & Doc.DS.Tables(0).Rows(Doc.Offset(0)).Item(0).ToString & " AND IdWersja=" & lvWersja.SelectedItems(0).Text)(Doc.Offset(1)).Item(1).ToString.Split(" "c)

        Line = New System.Text.StringBuilder
        Do While TextToPrint.GetUpperBound(0) >= Doc.Offset(3)
          Line.Append(TextToPrint(Doc.Offset(3)) & " ")
          If e.Graphics.MeasureString(Line.ToString.Trim, TextFont).Width > (e.MarginBounds.Width - Indent - SubIndent) Then
            Line.Remove(Line.ToString.Length - TextToPrint(Doc.Offset(3)).Length - 1, TextToPrint(Doc.Offset(3)).Length)
            Doc.DrawText(e, Line.ToString.Trim, TextFont, x1, y, e.MarginBounds.Width - Indent - SubIndent, LineHeight, 0, Brushes.Black, False)
            y += LineHeight
            If (y + LineHeight) > e.MarginBounds.Bottom Then Exit Do
            Doc.Offset(3) -= 1
            Line = New System.Text.StringBuilder
          End If
          Doc.Offset(3) += 1
        Loop
        If (y + LineHeight) < e.MarginBounds.Bottom AndAlso Line.Length > 0 Then
          Doc.DrawText(e, Line.ToString.Trim(), TextFont, x1, y, e.MarginBounds.Width - Indent - SubIndent, LineHeight, 0, Brushes.Black, False)
          Doc.Offset(3) = 0
          Doc.Offset(1) += 1
          Doc.PrintLevelMarker(1) = True
          y += LineHeight '* LineNumber
        Else
          Doc.PrintLevelMarker(1) = False
          If Line.Length > 0 Then Exit Do
        End If
      Loop
      'Doc.Offset(3) = 0
      y += LineHeight * CSng(0.5)
      If Doc.Offset(1) <= Doc.DS.Tables(1).Select("IdPytanie=" & Doc.DS.Tables(0).Rows(Doc.Offset(0)).Item(0).ToString & " AND IdWersja=" & lvWersja.SelectedItems(0).Text).GetUpperBound(0) Then
        Doc.PrintLevelMarker(0) = False
        Exit Do
      Else
        Doc.Offset(1) = 0
      End If
      Doc.Offset(2) = 0
      Doc.PrintLevelMarker(0) = True
      Doc.Offset(0) += 1
    Loop

    If Doc.Offset(0) <= Doc.DS.Tables(0).Rows.Count - 1 Then 'tvOdp.TopNode.Nodes.Count - 1 Then
      e.HasMorePages = True
      RaiseEvent NewRow()
    End If

  End Sub
 
End Class

Public Class WynikiSQL
  Public Overloads Function SelectTests(ByVal Grupa As String, ByVal Przedmiot As String) As String
    Return "Select DISTINCT t.ID,t.Nazwa FROM test t INNER JOIN student_test st ON t.ID=st.IdTest WHERE st.IdStudent IN (Select ID FROM student WHERE Klasa='" & Grupa & "') AND t.IdPrzedmiot=" & Przedmiot & " ORDER BY t.Nazwa;"
  End Function
  Public Overloads Function SelectTests(ByVal Przedmiot As String) As String
    Return "Select DISTINCT t.ID,t.Nazwa FROM test t WHERE t.IdPrzedmiot='" & Przedmiot & "' ORDER BY t.Nazwa;"
  End Function
  Public Function SelectGroups() As String
    Return "Select KodKlasy,Nazwa FROM klasa Order by KodKlasy;"
  End Function
  Public Function SelectGroupsByTest(ByVal IdTest As String) As String
    Return "SELECT DISTINCT k.KodKlasy,k.Nazwa FROM student s INNER JOIN klasa k ON s.Klasa=k.KodKlasy INNER JOIN student_test st ON st.IdStudent=s.ID WHERE st.IdTest='" & IdTest & "' Order by k.KodKlasy;"
  End Function

  Public Function SelectVersionScores(ByVal IdStudent As String, ByVal IdTest As String) As String
    Return "SELECT w.ID,w.Nazwa,w.Score,w.CzasRozpoczecia,w.CzasZakonczenia,w.User,w.ComputerIP,w.Version FROM wersja w INNER JOIN student_test st ON w.IdStudentTest=st.ID WHERE st.IdTest='" & IdTest & "' AND st.IdStudent='" & IdStudent & "';"
  End Function
  Public Function SelectVersionScoresByGroup(ByVal GroupCode As String, ByVal IdTest As String) As String
    Return "SELECT w.ID,w.Nazwa,w.Score,w.CzasRozpoczecia,w.CzasZakonczenia,w.User,w.ComputerIP,w.Version,st.IdStudent FROM wersja w INNER JOIN student_test st ON w.IdStudentTest=st.ID WHERE st.IdTest='" & IdTest & "' AND st.IdStudent IN (SELECT ID FROM student s WHERE Klasa='" & GroupCode & "');"
  End Function
  Public Function SelectStudent(ByVal Klasa As String) As String
    Return "Select ID, CONCAT_WS(' ',Nazwisko,Imie) AS Student FROM student WHERE Klasa='" & Klasa & "' Order by Klasa,Nazwisko,Imie;"
  End Function
  Public Function SelectKryteria(ByVal IdTest As String) As String
    Return "SELECT ID,Min,Max,Ocena FROM kryterium k WHERE k.NazwaKryterium IN (SELECT t.NazwaKryterium FROM test t WHERE ID='" & IdTest & "') ORDER BY NazwaKryterium,Min;"
  End Function
  Public Function SelectPytanie(ByVal IdTest As String) As String
    Return "SELECT p.ID,p.Tresc FROM pytanie p INNER JOIN test_pytanie tp ON p.ID=tp.IdPytanie WHERE tp.IdTest='" & IdTest & "' ORDER BY tp.NrPytania;"
  End Function
  Public Function SelectAnswer(ByVal IdStudent As String, ByVal Test As String) As String
    Return "SELECT o.ID,o.TrescOdpowiedzi,o.Punktacja,o.IdPytanie,w.IdWersja FROM wersja wer INNER JOIN wynik w ON wer.ID=w.IdWersja INNER JOIN odpowiedz o ON o.ID=w.IdOdpowiedz INNER JOIN student_test st ON wer.IdStudentTest=st.ID WHERE st.IdTest='" & Test & "' AND st.IdStudent='" & IdStudent & "';"
  End Function
  Public Function SelectAnswerByGroup(ByVal GroupCode As String, ByVal Test As String) As String
    Return "SELECT o.ID,o.TrescOdpowiedzi,o.Punktacja,o.IdPytanie,w.IdWersja,st.IdStudent FROM wersja wer INNER JOIN wynik w ON wer.ID=w.IdWersja INNER JOIN odpowiedz o ON o.ID=w.IdOdpowiedz INNER JOIN student_test st ON wer.IdStudentTest=st.ID WHERE st.IdTest='" & Test & "' AND st.IdStudent IN (SELECT ID FROM student s WHERE Klasa='" & GroupCode & "');"
  End Function

  Public Function SelectTestType(ByVal ID As String) As String
    Return "SELECT WyborWielokrotny FROM test WHERE ID=" & ID & ";"
  End Function
  Public Function DeleteWersja(ByVal IdWersja As String) As String
    Return "DELETE FROM wersja WHERE ID=" & IdWersja & ";"
  End Function
End Class
