<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prnPrintScore
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
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
    Me.OK_Button = New System.Windows.Forms.Button
    Me.Cancel_Button = New System.Windows.Forms.Button
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.pvWydruk = New System.Windows.Forms.PrintPreviewControl
    Me.gbZoom = New System.Windows.Forms.GroupBox
    Me.nudZoom = New System.Windows.Forms.NumericUpDown
    Me.tbZoom = New System.Windows.Forms.TrackBar
    Me.gbZakres = New System.Windows.Forms.GroupBox
    Me.cbStudent = New System.Windows.Forms.ComboBox
    Me.rbSelectedStudent = New System.Windows.Forms.RadioButton
    Me.rbAllStudents = New System.Windows.Forms.RadioButton
    Me.cbGrupa = New System.Windows.Forms.ComboBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.cbTest = New System.Windows.Forms.ComboBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.cbPrzedmiot = New System.Windows.Forms.ComboBox
    Me.chkAnswers = New System.Windows.Forms.CheckBox
    Me.gbOpcje = New System.Windows.Forms.GroupBox
    Me.chkPageBreak = New System.Windows.Forms.CheckBox
    Me.TableLayoutPanel1.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.gbZoom.SuspendLayout()
    CType(Me.nudZoom, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.tbZoom, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbZakres.SuspendLayout()
    Me.gbOpcje.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(598, 597)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(312, 29)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'OK_Button
    '
    Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
    Me.OK_Button.Location = New System.Drawing.Point(3, 3)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(150, 23)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "OK"
    '
    'Cancel_Button
    '
    Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Cancel_Button.Location = New System.Drawing.Point(159, 3)
    Me.Cancel_Button.Name = "Cancel_Button"
    Me.Cancel_Button.Size = New System.Drawing.Size(150, 23)
    Me.Cancel_Button.TabIndex = 1
    Me.Cancel_Button.Text = "Anuluj"
    '
    'Panel1
    '
    Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel1.Controls.Add(Me.pvWydruk)
    Me.Panel1.Location = New System.Drawing.Point(0, 0)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(589, 636)
    Me.Panel1.TabIndex = 1
    '
    'pvWydruk
    '
    Me.pvWydruk.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pvWydruk.Location = New System.Drawing.Point(0, 0)
    Me.pvWydruk.Name = "pvWydruk"
    Me.pvWydruk.Size = New System.Drawing.Size(589, 636)
    Me.pvWydruk.TabIndex = 2
    Me.pvWydruk.UseAntiAlias = True
    '
    'gbZoom
    '
    Me.gbZoom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbZoom.Controls.Add(Me.nudZoom)
    Me.gbZoom.Controls.Add(Me.tbZoom)
    Me.gbZoom.Location = New System.Drawing.Point(598, 323)
    Me.gbZoom.Name = "gbZoom"
    Me.gbZoom.Size = New System.Drawing.Size(312, 65)
    Me.gbZoom.TabIndex = 25
    Me.gbZoom.TabStop = False
    Me.gbZoom.Text = "Powiększenie"
    '
    'nudZoom
    '
    Me.nudZoom.Location = New System.Drawing.Point(240, 19)
    Me.nudZoom.Maximum = New Decimal(New Integer() {400, 0, 0, 0})
    Me.nudZoom.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
    Me.nudZoom.Name = "nudZoom"
    Me.nudZoom.Size = New System.Drawing.Size(66, 20)
    Me.nudZoom.TabIndex = 158
    Me.nudZoom.Value = New Decimal(New Integer() {100, 0, 0, 0})
    '
    'tbZoom
    '
    Me.tbZoom.LargeChange = 10
    Me.tbZoom.Location = New System.Drawing.Point(6, 19)
    Me.tbZoom.Maximum = 400
    Me.tbZoom.Minimum = 50
    Me.tbZoom.Name = "tbZoom"
    Me.tbZoom.Size = New System.Drawing.Size(226, 45)
    Me.tbZoom.TabIndex = 6
    Me.tbZoom.TickFrequency = 10
    Me.tbZoom.Value = 100
    '
    'gbZakres
    '
    Me.gbZakres.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbZakres.Controls.Add(Me.cbStudent)
    Me.gbZakres.Controls.Add(Me.rbSelectedStudent)
    Me.gbZakres.Controls.Add(Me.rbAllStudents)
    Me.gbZakres.Enabled = False
    Me.gbZakres.Location = New System.Drawing.Point(598, 120)
    Me.gbZakres.Name = "gbZakres"
    Me.gbZakres.Size = New System.Drawing.Size(312, 87)
    Me.gbZakres.TabIndex = 26
    Me.gbZakres.TabStop = False
    Me.gbZakres.Text = "Zakres wydruku"
    '
    'cbStudent
    '
    Me.cbStudent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cbStudent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cbStudent.DropDownHeight = 500
    Me.cbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbStudent.Enabled = False
    Me.cbStudent.FormattingEnabled = True
    Me.cbStudent.IntegralHeight = False
    Me.cbStudent.Location = New System.Drawing.Point(25, 60)
    Me.cbStudent.Name = "cbStudent"
    Me.cbStudent.Size = New System.Drawing.Size(287, 21)
    Me.cbStudent.TabIndex = 2
    '
    'rbSelectedStudent
    '
    Me.rbSelectedStudent.AutoSize = True
    Me.rbSelectedStudent.Location = New System.Drawing.Point(6, 42)
    Me.rbSelectedStudent.Name = "rbSelectedStudent"
    Me.rbSelectedStudent.Size = New System.Drawing.Size(99, 17)
    Me.rbSelectedStudent.TabIndex = 1
    Me.rbSelectedStudent.Text = "Wybrany uczeń"
    Me.rbSelectedStudent.UseVisualStyleBackColor = True
    '
    'rbAllStudents
    '
    Me.rbAllStudents.AutoSize = True
    Me.rbAllStudents.Checked = True
    Me.rbAllStudents.Location = New System.Drawing.Point(6, 19)
    Me.rbAllStudents.Name = "rbAllStudents"
    Me.rbAllStudents.Size = New System.Drawing.Size(117, 17)
    Me.rbAllStudents.TabIndex = 0
    Me.rbAllStudents.TabStop = True
    Me.rbAllStudents.Text = "Wszyscy uczniowie"
    Me.rbAllStudents.UseVisualStyleBackColor = True
    '
    'cbGrupa
    '
    Me.cbGrupa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbGrupa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cbGrupa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cbGrupa.DropDownHeight = 500
    Me.cbGrupa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbGrupa.Enabled = False
    Me.cbGrupa.FormattingEnabled = True
    Me.cbGrupa.IntegralHeight = False
    Me.cbGrupa.Location = New System.Drawing.Point(654, 66)
    Me.cbGrupa.Name = "cbGrupa"
    Me.cbGrupa.Size = New System.Drawing.Size(76, 21)
    Me.cbGrupa.TabIndex = 2
    '
    'Label1
    '
    Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(612, 69)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(36, 13)
    Me.Label1.TabIndex = 27
    Me.Label1.Text = "Grupa"
    '
    'Label2
    '
    Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(620, 42)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(28, 13)
    Me.Label2.TabIndex = 28
    Me.Label2.Text = "Test"
    '
    'cbTest
    '
    Me.cbTest.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbTest.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cbTest.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cbTest.DropDownHeight = 500
    Me.cbTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbTest.Enabled = False
    Me.cbTest.FormattingEnabled = True
    Me.cbTest.IntegralHeight = False
    Me.cbTest.Location = New System.Drawing.Point(654, 39)
    Me.cbTest.Name = "cbTest"
    Me.cbTest.Size = New System.Drawing.Size(256, 21)
    Me.cbTest.TabIndex = 29
    '
    'Label3
    '
    Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(595, 15)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(53, 13)
    Me.Label3.TabIndex = 30
    Me.Label3.Text = "Przedmiot"
    '
    'cbPrzedmiot
    '
    Me.cbPrzedmiot.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbPrzedmiot.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cbPrzedmiot.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cbPrzedmiot.DropDownHeight = 500
    Me.cbPrzedmiot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbPrzedmiot.Enabled = False
    Me.cbPrzedmiot.FormattingEnabled = True
    Me.cbPrzedmiot.IntegralHeight = False
    Me.cbPrzedmiot.Location = New System.Drawing.Point(654, 12)
    Me.cbPrzedmiot.Name = "cbPrzedmiot"
    Me.cbPrzedmiot.Size = New System.Drawing.Size(256, 21)
    Me.cbPrzedmiot.TabIndex = 31
    '
    'chkAnswers
    '
    Me.chkAnswers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.chkAnswers.AutoSize = True
    Me.chkAnswers.Location = New System.Drawing.Point(6, 19)
    Me.chkAnswers.Name = "chkAnswers"
    Me.chkAnswers.Size = New System.Drawing.Size(113, 17)
    Me.chkAnswers.TabIndex = 32
    Me.chkAnswers.Text = "Drukuj odpowiedzi"
    Me.chkAnswers.UseVisualStyleBackColor = True
    '
    'gbOpcje
    '
    Me.gbOpcje.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbOpcje.Controls.Add(Me.chkPageBreak)
    Me.gbOpcje.Controls.Add(Me.chkAnswers)
    Me.gbOpcje.Location = New System.Drawing.Point(598, 231)
    Me.gbOpcje.Name = "gbOpcje"
    Me.gbOpcje.Size = New System.Drawing.Size(312, 67)
    Me.gbOpcje.TabIndex = 33
    Me.gbOpcje.TabStop = False
    Me.gbOpcje.Text = "Opcje"
    '
    'chkPageBreak
    '
    Me.chkPageBreak.AutoSize = True
    Me.chkPageBreak.Location = New System.Drawing.Point(6, 42)
    Me.chkPageBreak.Name = "chkPageBreak"
    Me.chkPageBreak.Size = New System.Drawing.Size(176, 17)
    Me.chkPageBreak.TabIndex = 33
    Me.chkPageBreak.Text = "Każdy uczeń na osobnej stronie"
    Me.chkPageBreak.UseVisualStyleBackColor = True
    '
    'prnPrintScore
    '
    Me.AcceptButton = Me.OK_Button
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.Cancel_Button
    Me.ClientSize = New System.Drawing.Size(922, 638)
    Me.Controls.Add(Me.gbOpcje)
    Me.Controls.Add(Me.cbPrzedmiot)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.cbTest)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.cbGrupa)
    Me.Controls.Add(Me.gbZakres)
    Me.Controls.Add(Me.gbZoom)
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MinimizeBox = False
    Me.Name = "prnPrintScore"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Drukowanie wyników"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.gbZoom.ResumeLayout(False)
    Me.gbZoom.PerformLayout()
    CType(Me.nudZoom, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.tbZoom, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbZakres.ResumeLayout(False)
    Me.gbZakres.PerformLayout()
    Me.gbOpcje.ResumeLayout(False)
    Me.gbOpcje.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents OK_Button As System.Windows.Forms.Button
  Friend WithEvents Cancel_Button As System.Windows.Forms.Button
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents pvWydruk As System.Windows.Forms.PrintPreviewControl
  Friend WithEvents gbZoom As System.Windows.Forms.GroupBox
  Friend WithEvents nudZoom As System.Windows.Forms.NumericUpDown
  Friend WithEvents tbZoom As System.Windows.Forms.TrackBar
  Friend WithEvents gbZakres As System.Windows.Forms.GroupBox
  Friend WithEvents rbSelectedStudent As System.Windows.Forms.RadioButton
  Friend WithEvents rbAllStudents As System.Windows.Forms.RadioButton
  Friend WithEvents cbGrupa As System.Windows.Forms.ComboBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents cbTest As System.Windows.Forms.ComboBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents cbPrzedmiot As System.Windows.Forms.ComboBox
  Friend WithEvents cbStudent As System.Windows.Forms.ComboBox
  Friend WithEvents chkAnswers As System.Windows.Forms.CheckBox
  Friend WithEvents gbOpcje As System.Windows.Forms.GroupBox
  Friend WithEvents chkPageBreak As System.Windows.Forms.CheckBox

End Class
