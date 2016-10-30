Imports System.Windows.Forms
Imports System.Drawing.Printing
Public Class prnPrintScore
  Public WithEvents Doc As New PrintReport(New DataSet)
  'Public Event NewRow()
  Private Function GetGrade(ByVal Score As Single) As String
    For Each Row As DataRow In Doc.DS.Tables(4).Rows
      If Score >= CType(Row.Item(1), Single) And Score <= CType(Row.Item(2), Single) Then
        Return Row.Item(3).ToString
      End If
    Next
    Return ""
  End Function

  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    'Me.DialogResult = System.Windows.Forms.DialogResult.OK
    Dim prnDlg As New PrintDialog
    prnDlg.AllowSomePages = False
    prnDlg.PrinterSettings.FromPage = 1
    prnDlg.PrinterSettings.ToPage = 1

    If prnDlg.ShowDialog = Windows.Forms.DialogResult.OK Then
      Me.Doc.PageNumber = 0
      pvWydruk.Document.DefaultPageSettings.PrinterSettings.Copies = prnDlg.PrinterSettings.Copies
      Me.pvWydruk.Document.DefaultPageSettings.PrinterSettings.FromPage = prnDlg.PrinterSettings.FromPage
      Me.pvWydruk.Document.DefaultPageSettings.PrinterSettings.ToPage = prnDlg.PrinterSettings.ToPage
      Me.pvWydruk.Document.DefaultPageSettings.PrinterSettings.PrinterName = prnDlg.PrinterSettings.PrinterName
      Me.pvWydruk.Document.Print()
    End If
    'Me.Dispose(True)
  End Sub

  Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Dispose(True)
  End Sub
  Private Sub FetchData(ByVal GroupCode As String, ByVal IdTest As String)
    Dim DBA As New DataBaseAction, W As New WynikiSQL
    Doc.DS = DBA.GetDataSet(W.SelectStudent(GroupCode) & W.SelectVersionScoresByGroup(GroupCode, IdTest) & W.SelectPytanie(IdTest) & W.SelectAnswerByGroup(GroupCode, IdTest) & W.SelectKryteria(IdTest))
  End Sub
  Private Sub nudZoom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudZoom.ValueChanged
    If Not Me.Created Then Exit Sub
    tbZoom.Value = CType(nudZoom.Value, Integer)
    Me.pvWydruk.Zoom = nudZoom.Value * 0.01
    Me.Doc.PageNumber = 0
  End Sub
  Private Sub tbZoom_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbZoom.Scroll
    nudZoom.Value = tbZoom.Value
    Me.pvWydruk.Zoom = tbZoom.Value * 0.01
    Me.Doc.PageNumber = 0

  End Sub

  Private Sub dlgPrintPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Dim FCB As New FillComboBox, T As New TestSQL, W As New WynikiSQL
    FCB.AddComboBoxComplexItems(cbPrzedmiot, T.SelectPrzedmiot)
    If cbPrzedmiot.Items.Count > 0 Then
      Dim SH As New SeekHelper
      SH.FindComboItem(cbPrzedmiot, CInt(SH.GetDefault(T.SelectDefault("przedmiot"))))
      cbPrzedmiot.Enabled = True
    End If
    Dim Margins As New PrintVariables
    Margins.LeftMargin = 39
    Margins.RightMargin = 39
    Doc.DefaultPageSettings.Margins.Left = Margins.LeftMargin
    Doc.DefaultPageSettings.Margins.Right = Margins.RightMargin

    Dim ColWidth(4) As Single, LevelMarker(1) As Boolean
    ColWidth(0) = 293 : ColWidth(1) = 59 : ColWidth(2) = 110 : ColWidth(3) = 143 : ColWidth(4) = 143
    Doc.ColWidth = ColWidth
    LevelMarker(0) = True
    LevelMarker(1) = True
    Doc.PrintLevelMarker = LevelMarker
    Dim TableHeader(4) As String
    TableHeader(0) = "Wersja" : TableHeader(1) = "Wynik" : TableHeader(2) = "Ocena" : TableHeader(3) = "Czas rozpoczęcia" : TableHeader(4) = "Czas zakończenia"
    Doc.TableHeader = TableHeader
    Doc.ReportHeader = New String() {"", "", ""}
    Doc.DS.Tables.Add()
    Doc.DS.Tables.Add()
    Dim Offset(6) As Integer
    For i As Integer = 0 To Offset.GetLength(0) - 1
      Offset(i) = 0
    Next
    Doc.Offset = Offset


    pvWydruk.Document = Doc
    pvWydruk.Zoom = nudZoom.Value * 0.01
    'pvWydruk.InvalidatePreview()
  End Sub


  Private Sub pvWydruk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pvWydruk.Click
    If (Control.ModifierKeys And Keys.Shift) = 0 Then
      If nudZoom.Maximum >= pvWydruk.Zoom * 100 * 2.0 Then
        pvWydruk.Zoom = pvWydruk.Zoom * 2.0
        nudZoom.Value = CType(pvWydruk.Zoom * 100, Decimal)

      End If
    Else
      If nudZoom.Minimum <= pvWydruk.Zoom * 100 / 2.0 Then
        pvWydruk.Zoom = pvWydruk.Zoom / 2.0
        nudZoom.Value = CType(pvWydruk.Zoom * 100, Decimal)
      End If
    End If
  End Sub
  Private Sub cbPrzedmiot_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPrzedmiot.SelectedIndexChanged
    'If cbGrupa.SelectedItem Is Nothing Then Exit Sub
    cbTest.Items.Clear()
    cbGrupa.SelectedItem = Nothing
    cbGrupa.Enabled = False
    Dim FCB As New FillComboBox, W As New WynikiSQL
    FCB.AddComboBoxComplexItems(cbTest, W.SelectTests(CType(cbPrzedmiot.SelectedItem, CbItem).ID.ToString))
    cbTest.Enabled = CType(IIf(cbTest.Items.Count > 0, True, False), Boolean)
    cbGrupa_SelectedIndexChanged(cbGrupa, e)
  End Sub
  Private Sub cbGrupa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbGrupa.SelectedIndexChanged
    Dim W As New WynikiSQL, FCB As New FillComboBox
    If cbGrupa.SelectedItem IsNot Nothing Then
      cbStudent.Items.Clear()
      FCB.AddComboBoxComplexItems(cbStudent, W.SelectStudent(CType(cbGrupa.SelectedItem, CbItem).Kod))
      FetchData(CType(cbGrupa.SelectedItem, CbItem).Kod, CType(cbTest.SelectedItem, CbItem).ID.ToString)
      gbZakres.Enabled = True
      Doc.ReportHeader = New String() {cbPrzedmiot.Text, Me.cbTest.Text, Me.cbGrupa.Text}

      rbAllStudents_CheckedChanged(IIf(rbAllStudents.Checked, rbAllStudents, rbSelectedStudent), e)

    Else
      gbZakres.Enabled = False
      cbStudent.SelectedItem = Nothing
    End If
  End Sub


  Private Sub rbAllStudents_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAllStudents.CheckedChanged, rbSelectedStudent.CheckedChanged
    If Me.Created AndAlso CType(sender, RadioButton).Checked Then
      Me.pvWydruk.Rows = 1
      Me.Doc.PageNumber = 0
      If CType(sender, RadioButton).Name = "rbSelectedStudent" Then
        Me.cbStudent.Enabled = True
        chkPageBreak.Enabled = False
        Doc.GroupHeader = New String() {cbStudent.Text}
      Else
        Me.cbStudent.Enabled = False
        chkPageBreak.Enabled = True
        Doc.GroupHeader = Nothing
      End If
      pvWydruk.InvalidatePreview()
    End If
  End Sub

  Private Sub cbTest_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTest.SelectedIndexChanged
    Dim FCB As New FillComboBox, W As New WynikiSQL
    cbGrupa.Items.Clear()
    FCB.AddComboBoxComplexItems(cbGrupa, W.SelectGroupsByTest(CType(cbTest.SelectedItem, CbItem).ID.ToString), True)
    cbGrupa.Enabled = CType(IIf(cbGrupa.Items.Count > 0, True, False), Boolean)
    cbGrupa_SelectedIndexChanged(cbGrupa, e)
  End Sub

  Private Sub cbStudent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbStudent.SelectedIndexChanged
    rbAllStudents_CheckedChanged(rbSelectedStudent, e)
  End Sub
  Public Sub PrnDoc_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs) Handles Doc.PrintPage
    'Dim Doc As PrintReport = CType(sender, PrintReport)
    Dim x As Single = Doc.DefaultPageSettings.Margins.Left - Doc.DefaultPageSettings.PrintableArea.Left
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
      Doc.DrawText(e, "Wyniki testu - klasa " & Doc.ReportHeader(2), HeaderFont, x, y, Doc.ColWidth.Sum, HeaderLineHeight, 1, Brushes.Black, False)
      y += LineHeight * 2
      Doc.DrawText(e, "Nazwa testu: ", TextFont, x, y, Doc.ColWidth.Sum, HeaderLineHeight, 0, Brushes.Black, False)
      Doc.DrawText(e, Doc.ReportHeader(1), New Font(TextFont, FontStyle.Bold), x + e.Graphics.MeasureString("Nazwa testu: ", TextFont).Width, y, Doc.ColWidth.Sum, HeaderLineHeight, 0, Brushes.Black, False)
      'y += LineHeight
      Doc.DrawText(e, "Przedmiot: ", TextFont, x + Doc.ColWidth.Sum - e.Graphics.MeasureString("Przedmiot: ", TextFont).Width - e.Graphics.MeasureString(cbPrzedmiot.Text, New Font(TextFont, FontStyle.Bold)).Width, y, e.Graphics.MeasureString("Przedmiot: ", TextFont).Width, HeaderLineHeight, 0, Brushes.Black, False)
      Doc.DrawText(e, Doc.ReportHeader(0), New Font(TextFont, FontStyle.Bold), x + Doc.ColWidth.Sum - e.Graphics.MeasureString(cbPrzedmiot.Text, New Font(TextFont, FontStyle.Bold)).Width, y, e.Graphics.MeasureString(cbPrzedmiot.Text, New Font(TextFont, FontStyle.Bold)).Width, HeaderLineHeight, 2, Brushes.Black, False)
      y += LineHeight * CSng(1.5)
      e.Graphics.DrawLine(Pens.Black, x, y, x + Doc.ColWidth.Sum, y)
      y += LineHeight * 2

    End If
    If Me.rbAllStudents.Checked Then
      PrintAllStudentScores(e, x, y, TextFont, LineHeight)
    Else
      PrintStudentScore(e, x, y, TextFont, LineHeight)
    End If
  End Sub
  Private Sub PrintTableHeader(ByVal e As PrintPageEventArgs, ByVal x As Single, ByRef y As Single, ByVal TextFont As Font, ByVal LineHeight As Single)
    For i As Integer = 0 To Doc.TableHeader.GetUpperBound(0)
      Doc.DrawText(e, Doc.TableHeader(i), New Font(TextFont, FontStyle.Bold), x, y, Doc.ColWidth(i), LineHeight * 2, 1, Brushes.Black)
      x += Doc.ColWidth(i)
    Next
    y += LineHeight * 2

  End Sub
  Private Sub PrintAllStudentScores(ByVal e As PrintPageEventArgs, ByVal x As Single, ByVal y As Single, ByVal TextFont As Font, ByVal LineHeight As Single)

    Dim x1 As Single = x
    Do Until (y + LineHeight) > e.MarginBounds.Bottom Or Doc.Offset(0) > Doc.DS.Tables(0).Rows.Count - 1
      If Doc.DS.Tables(1).Select("IdStudent='" & Doc.DS.Tables(0).Rows(Doc.Offset(0)).Item(0).ToString & "'").Count > 0 Then
        x1 = x

        Doc.DrawText(e, Doc.DS.Tables(0).Rows(Doc.Offset(0)).Item(1).ToString, New Font("Arial", 11, FontStyle.Bold), x1, y, e.MarginBounds.Width, New Font("Arial", 11, FontStyle.Bold).GetHeight(e.Graphics), 0, Brushes.Black, False)
        y += LineHeight * CSng(1.5)
        If chkAnswers.Checked = False Then PrintTableHeader(e, x, y, TextFont, LineHeight)


        'dokończyć()
        'poprawić drukowanie nagłówków czyli nazwisk przed każdą wersją i nową stroną
        'zrobić sterowanie wydrukiem pytań i odpowiedzi


        Do Until (y + LineHeight) > e.MarginBounds.Bottom Or Doc.Offset(1) > Doc.DS.Tables(1).Select("IdStudent='" & Doc.DS.Tables(0).Rows(Doc.Offset(0)).Item(0).ToString & "'").GetUpperBound(0)
          x1 = x
          If chkAnswers.Checked Then PrintTableHeader(e, x, y, TextFont, LineHeight)

          Doc.DrawText(e, Doc.DS.Tables(1).Select("IdStudent='" & Doc.DS.Tables(0).Rows(Doc.Offset(0)).Item(0).ToString & "'")(Doc.Offset(1)).Item("Nazwa").ToString, TextFont, x1, y, Doc.ColWidth(0), LineHeight * CSng(1.5), 0, Brushes.Black)
          x1 += Doc.ColWidth(0)
          Doc.DrawText(e, Doc.DS.Tables(1).Select("IdStudent='" & Doc.DS.Tables(0).Rows(Doc.Offset(0)).Item(0).ToString & "'")(Doc.Offset(1)).Item("Score").ToString, TextFont, x1, y, Doc.ColWidth(1), LineHeight * CSng(1.5), 1, Brushes.Black)
          x1 += Doc.ColWidth(1)
          Doc.DrawText(e, GetGrade(CType(Doc.DS.Tables(1).Select("IdStudent='" & Doc.DS.Tables(0).Rows(Doc.Offset(0)).Item(0).ToString & "'")(Doc.Offset(1)).Item("Score"), Single)), TextFont, x1, y, Doc.ColWidth(2), LineHeight * CSng(1.5), 1, Brushes.Black)
          x1 += Doc.ColWidth(2)
          Doc.DrawText(e, Doc.DS.Tables(1).Select("IdStudent='" & Doc.DS.Tables(0).Rows(Doc.Offset(0)).Item(0).ToString & "'")(Doc.Offset(1)).Item("CzasRozpoczecia").ToString, TextFont, x1, y, Doc.ColWidth(3), LineHeight * CSng(1.5), 1, Brushes.Black)
          x1 += Doc.ColWidth(3)

          Doc.DrawText(e, Doc.DS.Tables(1).Select("IdStudent='" & Doc.DS.Tables(0).Rows(Doc.Offset(0)).Item(0).ToString & "'")(Doc.Offset(1)).Item("CzasZakonczenia").ToString, TextFont, x1, y, Doc.ColWidth(4), LineHeight * CSng(1.5), 1, Brushes.Black)

          y += LineHeight * CSng(1.5)

          '------------------------------------ Wydruk pytań i odpowiedzi --------------------------------------------

          If chkAnswers.Checked Then
            If Doc.Offset(2) = 0 Then
              Doc.DrawText(e, "Wykaz odpowiedzi", New Font(TextFont, FontStyle.Bold), x1, y, Doc.ColWidth.Sum, LineHeight * 2, 1, Brushes.Black, False)
              y += LineHeight * 2
            End If

            '------------------------- Początek petli dla tabeli 2 zawierajacej pytania ---------------------------------------

            Do Until (y + LineHeight) > e.MarginBounds.Bottom Or Doc.Offset(2) > Doc.DS.Tables(2).Rows.Count - 1

              Dim Indent As Single
              Indent = Math.Ceiling(CType(e.Graphics.MeasureString(Doc.Offset(2) + 1 & ") ", New Font(TextFont, FontStyle.Bold)).Width, Decimal))
              If Doc.PrintLevelMarker(0) AndAlso Doc.Offset(5) = 0 Then Doc.DrawText(e, Doc.Offset(2) + 1 & ") ", New Font(TextFont, FontStyle.Bold), x1, y, e.MarginBounds.Width, LineHeight, 0, Brushes.Black, False)
              x1 += Indent

              '---------------------------------- Wydruk treści pytania -------------------------------------------------
              If Doc.Offset(5) = 0 Then
                Dim TextToPrint() As String = Doc.DS.Tables(3).Rows(Doc.Offset(2)).Item(1).ToString.Split(" "c)

                Dim Line As New System.Text.StringBuilder

                Do While (TextToPrint.GetUpperBound(0) >= Doc.Offset(4)) 'Pętla tworząca linię tekstu do wydruku treści pytania
                  Line.Append(TextToPrint(Doc.Offset(3)) & " ")
                  If e.Graphics.MeasureString(Line.ToString.Trim, New Font(TextFont, FontStyle.Bold)).Width > (e.MarginBounds.Width - Indent) Then
                    Line.Remove(Line.ToString.Length - TextToPrint(Doc.Offset(4)).Length - 1, TextToPrint(Doc.Offset(4)).Length)
                    Doc.DrawText(e, Line.ToString.Trim, New Font(TextFont, FontStyle.Bold), x1, y, e.MarginBounds.Width - Indent, LineHeight, 0, Brushes.Black, False)
                    y += LineHeight
                    If (y + LineHeight) > e.MarginBounds.Bottom Then Exit Do 'Wyjdź z pętli tworzącej linię tekstu
                    Doc.Offset(4) -= 1 'Zmniejszenie licznika słów treści pytania z powodu usunięcia słowa z linii tekstu
                    Line = New System.Text.StringBuilder
                  End If
                  Doc.Offset(4) += 1 'Zwiększenie licznika słów treści pytania
                Loop 'Koniec pętli tworzącej linię tekstu dla pytania
                Doc.PrintLevelMarker(0) = False
                If (y + LineHeight) < e.MarginBounds.Bottom AndAlso Line.Length > 0 Then
                  Doc.DrawText(e, Line.ToString.Trim(), New Font(TextFont, FontStyle.Bold), x1, y, e.MarginBounds.Width - Indent, LineHeight, 0, Brushes.Black, False)
                  'Doc.PrintLevelMarker(0) = True
                  y += LineHeight
                Else
                  If Line.Length > 0 Then Exit Do 'Wyjdź z pętli drukującej treść pytania
                End If
              End If


              '--------------------------------------- Wydruk treści odpowiedzi --------------------------------------------
              '------------------------- Początek pętli dla tabeli 3 zawierającej odpowiedzi --------------------------------

              Do Until (y + LineHeight) > e.MarginBounds.Bottom Or Doc.Offset(3) > Doc.DS.Tables(3).Select("IdPytanie=" & Doc.DS.Tables(2).Rows(Doc.Offset(2)).Item(0).ToString & " AND IdWersja=" & Doc.DS.Tables(1).Select("IdStudent='" & Doc.DS.Tables(0).Rows(Doc.Offset(0)).Item(0).ToString & "'")(Doc.Offset(1)).Item(0).ToString).GetUpperBound(0)
                x1 = x + Indent
                Dim SubIndent As Single = Math.Ceiling(CType(e.Graphics.MeasureString(Chr(97 + Doc.Offset(3)) & ") ", TextFont).Width, Decimal))
                If Doc.PrintLevelMarker(1) Then
                  Doc.DrawText(e, Chr(97 + Doc.Offset(2)) & ") ", TextFont, x1, y, e.MarginBounds.Width - Indent, LineHeight, 0, Brushes.Black, False)
                End If
                x1 += SubIndent
                Dim TextToPrint() As String = Doc.DS.Tables(3).Select("IdPytanie=" & Doc.DS.Tables(2).Rows(Doc.Offset(2)).Item(0).ToString & " AND IdWersja=" & Doc.DS.Tables(1).Select("IdStudent='" & Doc.DS.Tables(0).Rows(Doc.Offset(0)).Item(0).ToString & "'")(Doc.Offset(1)).Item(0).ToString)(Doc.Offset(3)).Item(1).ToString.Split(" "c)

                Dim Line As New System.Text.StringBuilder
                Line = New System.Text.StringBuilder
                Do While TextToPrint.GetUpperBound(0) >= Doc.Offset(5) 'Pętla tworząca linię tekstu odpowiedzi
                  Line.Append(TextToPrint(Doc.Offset(5)) & " ")
                  If e.Graphics.MeasureString(Line.ToString.Trim, TextFont).Width > (e.MarginBounds.Width - Indent - SubIndent) Then
                    Line.Remove(Line.ToString.Length - TextToPrint(Doc.Offset(5)).Length - 1, TextToPrint(Doc.Offset(5)).Length)
                    Doc.DrawText(e, Line.ToString.Trim, TextFont, x1, y, e.MarginBounds.Width - Indent - SubIndent, LineHeight, 0, Brushes.Black, False)
                    y += LineHeight
                    If (y + LineHeight) > e.MarginBounds.Bottom Then Exit Do
                    Doc.Offset(5) -= 1 'Zmniejszenie licznika słów treści odpowiedzi
                    Line = New System.Text.StringBuilder
                  End If
                  Doc.Offset(5) += 1 'Zwiększenie licznika słów treści odpowiedzi
                Loop 'Koniec pętli tworzącej linię tekstu odpowiedzi
                If (y + LineHeight) < e.MarginBounds.Bottom AndAlso Line.Length > 0 Then
                  Doc.DrawText(e, Line.ToString.Trim(), TextFont, x1, y, e.MarginBounds.Width - Indent - SubIndent, LineHeight, 0, Brushes.Black, False)
                  Doc.Offset(5) = 0 'Reset licznika słów treści odpowiedzi
                  Doc.Offset(3) += 1 'Zwiększenie licznika odpowiedzi
                  Doc.PrintLevelMarker(1) = True
                  y += LineHeight '* LineNumber
                Else
                  'Doc.PrintLevelMarker(0) = False
                  Doc.PrintLevelMarker(1) = False
                  If Line.Length > 0 Then Exit Do
                End If
              Loop 'Koniec pętli dla tabeli 3 zawierającej odpowiedzi

              If Doc.Offset(3) <= Doc.DS.Tables(3).Select("IdPytanie=" & Doc.DS.Tables(2).Rows(Doc.Offset(2)).Item(0).ToString & " AND IdWersja=" & Doc.DS.Tables(1).Select("IdStudent='" & Doc.DS.Tables(0).Rows(Doc.Offset(0)).Item(0).ToString & "'")(Doc.Offset(1)).Item(0).ToString).GetUpperBound(0) Then
                Exit Do 'Wyjdź z pętli drukującej treść pytania
              Else
                Doc.PrintLevelMarker(0) = True
                Doc.Offset(3) = 0 'Reset licznika odpowiedzi
                Doc.Offset(4) = 0 'Reset licznika słów treści pytania
                x1 = x
                If Doc.Offset(5) = 0 Then Doc.Offset(2) += 1 'Zwiększenie licznika pytań
              End If
            Loop 'Koniec pętli dla tabeli 2 zawierającej pytania

            If Doc.Offset(2) <= Doc.DS.Tables(2).Rows.Count - 1 Then
              'Doc.PrintLevelMarker(0) = False
              Exit Do 'Wyjdź z pętli drukującej wersje odpowiedzi
            Else
              Doc.Offset(2) = 0 'Reset licznika pytań
            End If
            y += LineHeight * 2
          End If
          Doc.Offset(1) += 1
        Loop
        y += LineHeight

        If Doc.Offset(1) <= Doc.DS.Tables(1).Select("IdStudent='" & Doc.DS.Tables(0).Rows(Doc.Offset(0)).Item(0).ToString & "'").GetUpperBound(0) Then
          'Me.PrintGroupHeader = False
          Exit Do
        Else
          Doc.Offset(1) = 0
          'Me.PrintGroupHeader = True
        End If
        Doc.Offset(0) += 1
        If Me.chkPageBreak.Checked Then Exit Do
      Else
        Doc.Offset(0) += 1
      End If
    Loop
    If Doc.Offset(0) <= Doc.DS.Tables(0).Rows.Count - 1 AndAlso Doc.DS.Tables(1).Select("IdStudent='" & Doc.DS.Tables(0).Rows(Doc.Offset(0)).Item(0).ToString & "'").Count > 0 Then
      e.HasMorePages = True
      pvWydruk.Rows += 1
    Else
      Doc.Offset(0) = 0
    End If
  End Sub
  Private Sub PrintStudentScore(ByVal e As PrintPageEventArgs, ByVal x As Single, ByVal y As Single, ByVal TextFont As Font, ByVal LineHeight As Single)

    Dim x1 As Single = x


    'y += LineHeight * 2
    If cbStudent.Text.Length > 0 Then
      If Doc.PageNumber = 1 Then
        Doc.DrawText(e, Doc.GroupHeader(0), New Font("Arial", 11, FontStyle.Bold), x1, y, e.MarginBounds.Width, New Font("Arial", 11, FontStyle.Bold).GetHeight(e.Graphics), 0, Brushes.Black, False)
        y += LineHeight * CSng(1.5)
        If chkAnswers.Checked = False Then PrintTableHeader(e, x, y, TextFont, LineHeight)
        'y += LineHeight * CSng(1.5)
      End If
      '------------------------------------------ Wydruk wersji odpowiedzi ------------------------------------------

      Do Until (y + LineHeight) > e.MarginBounds.Bottom Or Doc.Offset(0) > Doc.DS.Tables(1).Select("IdStudent='" & CType(cbStudent.SelectedItem, CbItem).ID.ToString & "'").GetUpperBound(0)
        If Doc.Offset(1) = 0 Then
          If chkAnswers.Checked Then PrintTableHeader(e, x, y, TextFont, LineHeight)
          Doc.DrawText(e, Doc.DS.Tables(1).Select("IdStudent='" & CType(cbStudent.SelectedItem, CbItem).ID.ToString & "'")(Doc.Offset(0)).Item("Nazwa").ToString, TextFont, x1, y, Doc.ColWidth(0), LineHeight * CSng(1.5), 0, Brushes.Black)
          x1 += Doc.ColWidth(0)
          Doc.DrawText(e, Doc.DS.Tables(1).Select("IdStudent='" & CType(cbStudent.SelectedItem, CbItem).ID.ToString & "'")(Doc.Offset(0)).Item("Score").ToString, TextFont, x1, y, Doc.ColWidth(1), LineHeight * CSng(1.5), 1, Brushes.Black)
          x1 += Doc.ColWidth(1)
          Doc.DrawText(e, GetGrade(CType(Doc.DS.Tables(1).Select("IdStudent='" & CType(cbStudent.SelectedItem, CbItem).ID.ToString & "'")(Doc.Offset(0)).Item("Score"), Single)), TextFont, x1, y, Doc.ColWidth(2), LineHeight * CSng(1.5), 1, Brushes.Black)
          x1 += Doc.ColWidth(2)
          Doc.DrawText(e, Doc.DS.Tables(1).Select("IdStudent='" & CType(cbStudent.SelectedItem, CbItem).ID.ToString & "'")(Doc.Offset(0)).Item("CzasRozpoczecia").ToString, TextFont, x1, y, Doc.ColWidth(3), LineHeight * CSng(1.5), 1, Brushes.Black)
          x1 += Doc.ColWidth(3)

          Doc.DrawText(e, Doc.DS.Tables(1).Select("IdStudent='" & CType(cbStudent.SelectedItem, CbItem).ID.ToString & "'")(Doc.Offset(0)).Item("CzasZakonczenia").ToString, TextFont, x1, y, Doc.ColWidth(4), LineHeight * CSng(1.5), 1, Brushes.Black)
          x1 = x
          y += LineHeight * CSng(1.5)
        End If

        '------------------------------------ Wydruk pytań i odpowiedzi --------------------------------------------

        If chkAnswers.Checked Then
          If Doc.Offset(1) = 0 Then
            Doc.DrawText(e, "Wykaz odpowiedzi", New Font(TextFont, FontStyle.Bold), x1, y, Doc.ColWidth.Sum, LineHeight * 2, 1, Brushes.Black, False)
            y += LineHeight * 2
          End If

          '------------------------- Początek petli dla tabeli 2 zawierajacej pytania ---------------------------------------

          Do Until (y + LineHeight) > e.MarginBounds.Bottom Or Doc.Offset(1) > Doc.DS.Tables(2).Rows.Count - 1

            Dim Indent As Single
            Indent = Math.Ceiling(CType(e.Graphics.MeasureString(Doc.Offset(1) + 1 & ") ", New Font(TextFont, FontStyle.Bold)).Width, Decimal))
            If Doc.PrintLevelMarker(0) AndAlso Doc.Offset(4) = 0 Then Doc.DrawText(e, Doc.Offset(1) + 1 & ") ", New Font(TextFont, FontStyle.Bold), x1, y, e.MarginBounds.Width, LineHeight, 0, Brushes.Black, False)
            x1 += Indent

            '---------------------------------- Wydruk treści pytania -------------------------------------------------
            If Doc.Offset(4) = 0 Then
              Dim TextToPrint() As String = Doc.DS.Tables(2).Rows(Doc.Offset(1)).Item(1).ToString.Split(" "c)

              Dim Line As New System.Text.StringBuilder

              Do While (TextToPrint.GetUpperBound(0) >= Doc.Offset(3)) 'Pętla tworząca linię tekstu do wydruku treści pytania
                Line.Append(TextToPrint(Doc.Offset(3)) & " ")
                If e.Graphics.MeasureString(Line.ToString.Trim, New Font(TextFont, FontStyle.Bold)).Width > (e.MarginBounds.Width - Indent) Then
                  Line.Remove(Line.ToString.Length - TextToPrint(Doc.Offset(3)).Length - 1, TextToPrint(Doc.Offset(3)).Length)
                  Doc.DrawText(e, Line.ToString.Trim, New Font(TextFont, FontStyle.Bold), x1, y, e.MarginBounds.Width - Indent, LineHeight, 0, Brushes.Black, False)
                  y += LineHeight
                  If (y + LineHeight) > e.MarginBounds.Bottom Then Exit Do 'Wyjdź z pętli tworzącej linię tekstu
                  Doc.Offset(3) -= 1 'Zmniejszenie licznika słów treści pytania z powodu usunięcia słowa z linii tekstu
                  Line = New System.Text.StringBuilder
                End If
                Doc.Offset(3) += 1 'Zwiększenie licznika słów treści pytania
              Loop 'Koniec pętli tworzącej linię tekstu dla pytania
              Doc.PrintLevelMarker(0) = False
              If (y + LineHeight) < e.MarginBounds.Bottom AndAlso Line.Length > 0 Then
                Doc.DrawText(e, Line.ToString.Trim(), New Font(TextFont, FontStyle.Bold), x1, y, e.MarginBounds.Width - Indent, LineHeight, 0, Brushes.Black, False)
                'Doc.PrintLevelMarker(0) = True
                y += LineHeight
              Else
                If Line.Length > 0 Then Exit Do 'Wyjdź z pętli drukującej treść pytania
              End If
            End If


            '--------------------------------------- Wydruk treści odpowiedzi --------------------------------------------
            '------------------------- Początek pętli dla tabeli 3 zawierającej odpowiedzi --------------------------------

            Do Until (y + LineHeight) > e.MarginBounds.Bottom Or Doc.Offset(2) > Doc.DS.Tables(3).Select("IdPytanie=" & Doc.DS.Tables(2).Rows(Doc.Offset(1)).Item(0).ToString & " AND IdWersja=" & Doc.DS.Tables(1).Select("IdStudent='" & CType(cbStudent.SelectedItem, CbItem).ID.ToString & "'")(Doc.Offset(0)).Item(0).ToString).GetUpperBound(0)
              x1 = x + Indent
              Dim SubIndent As Single = Math.Ceiling(CType(e.Graphics.MeasureString(Chr(97 + Doc.Offset(2)) & ") ", TextFont).Width, Decimal))
              If Doc.PrintLevelMarker(1) Then
                Doc.DrawText(e, Chr(97 + Doc.Offset(2)) & ") ", TextFont, x1, y, e.MarginBounds.Width - Indent, LineHeight, 0, Brushes.Black, False)
              End If
              x1 += SubIndent
              Dim TextToPrint() As String = Doc.DS.Tables(3).Select("IdPytanie=" & Doc.DS.Tables(2).Rows(Doc.Offset(1)).Item(0).ToString & " AND IdWersja=" & Doc.DS.Tables(1).Select("IdStudent='" & CType(cbStudent.SelectedItem, CbItem).ID.ToString & "'")(Doc.Offset(0)).Item(0).ToString)(Doc.Offset(2)).Item(1).ToString.Split(" "c)

              Dim Line As New System.Text.StringBuilder
              Line = New System.Text.StringBuilder
              Do While TextToPrint.GetUpperBound(0) >= Doc.Offset(4) 'Pętla tworząca linię tekstu odpowiedzi
                Line.Append(TextToPrint(Doc.Offset(4)) & " ")
                If e.Graphics.MeasureString(Line.ToString.Trim, TextFont).Width > (e.MarginBounds.Width - Indent - SubIndent) Then
                  Line.Remove(Line.ToString.Length - TextToPrint(Doc.Offset(4)).Length - 1, TextToPrint(Doc.Offset(4)).Length)
                  Doc.DrawText(e, Line.ToString.Trim, TextFont, x1, y, e.MarginBounds.Width - Indent - SubIndent, LineHeight, 0, Brushes.Black, False)
                  y += LineHeight
                  If (y + LineHeight) > e.MarginBounds.Bottom Then Exit Do
                  Doc.Offset(4) -= 1 'Zmniejszenie licznika słów treści odpowiedzi
                  Line = New System.Text.StringBuilder
                End If
                Doc.Offset(4) += 1 'Zwiększenie licznika słó treści odpowiedzi
              Loop 'Koniec pętli tworzącej linię tekstu odpowiedzi
              If (y + LineHeight) < e.MarginBounds.Bottom AndAlso Line.Length > 0 Then
                Doc.DrawText(e, Line.ToString.Trim(), TextFont, x1, y, e.MarginBounds.Width - Indent - SubIndent, LineHeight, 0, Brushes.Black, False)
                Doc.Offset(4) = 0 'Reset licznika słów treści odpowiedzi
                Doc.Offset(2) += 1 'Zwiększenie licznika odpowiedzi
                Doc.PrintLevelMarker(1) = True
                y += LineHeight '* LineNumber
              Else
                'Doc.PrintLevelMarker(0) = False
                Doc.PrintLevelMarker(1) = False
                If Line.Length > 0 Then Exit Do
              End If
            Loop 'Koniec pętli dla tabeli 3 zawierającej odpowiedzi

            If Doc.Offset(2) <= Doc.DS.Tables(3).Select("IdPytanie=" & Doc.DS.Tables(2).Rows(Doc.Offset(1)).Item(0).ToString & " AND IdWersja=" & Doc.DS.Tables(1).Select("IdStudent='" & CType(cbStudent.SelectedItem, CbItem).ID.ToString & "'")(Doc.Offset(0)).Item(0).ToString).GetUpperBound(0) Then
              Exit Do 'Wyjdź z pętli drukującej treść pytania
            Else
              Doc.PrintLevelMarker(0) = True
              Doc.Offset(2) = 0 'Reset licznika odpowiedzi
              Doc.Offset(3) = 0 'Reset licznika słów treści pytania
              x1 = x
              If Doc.Offset(4) = 0 Then Doc.Offset(1) += 1 'Zwiększenie licznika pytań
            End If
          Loop 'Koniec pętli dla tabeli 2 zawierającej pytania

          If Doc.Offset(1) <= Doc.DS.Tables(2).Rows.Count - 1 Then
            'Doc.PrintLevelMarker(0) = False
            Exit Do 'Wyjdź z pętli drukującej wersje odpowiedzi
          Else
            Doc.Offset(1) = 0 'Reset licznika pytań
          End If
          y += LineHeight * 2
        End If
        'Doc.Offset(2) = 0
        Doc.Offset(0) += 1
      Loop 'Koniec pętli dla tabeli 1 zawierającej wersje odpowiedzi
      If Doc.Offset(0) <= Doc.DS.Tables(1).Select("IdStudent='" & CType(cbStudent.SelectedItem, CbItem).ID.ToString & "'").GetUpperBound(0) Then
        e.HasMorePages = True
        pvWydruk.Rows += 1
      Else
        'Doc.Lp = 0
        Doc.Offset(0) = 0
      End If
    End If
  End Sub

  Private Sub chkAnswers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAnswers.CheckedChanged, chkPageBreak.CheckedChanged
    Me.pvWydruk.Rows = 1
    Me.Doc.PageNumber = 0
    pvWydruk.InvalidatePreview()
  End Sub
End Class
