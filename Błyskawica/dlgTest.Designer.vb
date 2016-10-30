<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTest
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
    Me.nudLimitOdp = New System.Windows.Forms.NumericUpDown
    Me.Label6 = New System.Windows.Forms.Label
    Me.nudLimitCzasu = New System.Windows.Forms.NumericUpDown
    Me.Label9 = New System.Windows.Forms.Label
    Me.txtPassword = New System.Windows.Forms.TextBox
    Me.Label10 = New System.Windows.Forms.Label
    Me.txtNazwa = New System.Windows.Forms.TextBox
    Me.Label11 = New System.Windows.Forms.Label
    Me.chkMultiChoice = New System.Windows.Forms.CheckBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.cbKryteria = New System.Windows.Forms.ComboBox
    Me.TableLayoutPanel1.SuspendLayout()
    CType(Me.nudLimitOdp, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nudLimitCzasu, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(496, 101)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
    Me.TableLayoutPanel1.TabIndex = 6
    '
    'OK_Button
    '
    Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.OK_Button.Enabled = False
    Me.OK_Button.Location = New System.Drawing.Point(3, 3)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(67, 23)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "Zapisz"
    '
    'Cancel_Button
    '
    Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
    Me.Cancel_Button.Name = "Cancel_Button"
    Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
    Me.Cancel_Button.TabIndex = 1
    Me.Cancel_Button.Text = "Zamknij"
    '
    'nudLimitOdp
    '
    Me.nudLimitOdp.Location = New System.Drawing.Point(346, 38)
    Me.nudLimitOdp.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
    Me.nudLimitOdp.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
    Me.nudLimitOdp.Name = "nudLimitOdp"
    Me.nudLimitOdp.Size = New System.Drawing.Size(44, 20)
    Me.nudLimitOdp.TabIndex = 3
    Me.nudLimitOdp.Value = New Decimal(New Integer() {2, 0, 0, 0})
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(246, 40)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(94, 13)
    Me.Label6.TabIndex = 42
    Me.Label6.Text = "Liczba odpowiedzi"
    '
    'nudLimitCzasu
    '
    Me.nudLimitCzasu.Location = New System.Drawing.Point(598, 36)
    Me.nudLimitCzasu.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
    Me.nudLimitCzasu.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.nudLimitCzasu.Name = "nudLimitCzasu"
    Me.nudLimitCzasu.Size = New System.Drawing.Size(44, 20)
    Me.nudLimitCzasu.TabIndex = 4
    Me.nudLimitCzasu.Value = New Decimal(New Integer() {10, 0, 0, 0})
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(470, 38)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(122, 13)
    Me.Label9.TabIndex = 38
    Me.Label9.Text = "Limit czasu (w minutach)"
    '
    'txtPassword
    '
    Me.txtPassword.Location = New System.Drawing.Point(438, 12)
    Me.txtPassword.Name = "txtPassword"
    Me.txtPassword.Size = New System.Drawing.Size(204, 20)
    Me.txtPassword.TabIndex = 1
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(396, 15)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(36, 13)
    Me.Label10.TabIndex = 36
    Me.Label10.Text = "Hasło"
    '
    'txtNazwa
    '
    Me.txtNazwa.Location = New System.Drawing.Point(84, 12)
    Me.txtNazwa.Name = "txtNazwa"
    Me.txtNazwa.Size = New System.Drawing.Size(306, 20)
    Me.txtNazwa.TabIndex = 0
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Location = New System.Drawing.Point(12, 15)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(66, 13)
    Me.Label11.TabIndex = 34
    Me.Label11.Text = "Nazwa testu"
    '
    'chkMultiChoice
    '
    Me.chkMultiChoice.AutoSize = True
    Me.chkMultiChoice.Location = New System.Drawing.Point(15, 39)
    Me.chkMultiChoice.Name = "chkMultiChoice"
    Me.chkMultiChoice.Size = New System.Drawing.Size(149, 17)
    Me.chkMultiChoice.TabIndex = 2
    Me.chkMultiChoice.Text = "test wielokrotnego wyboru"
    Me.chkMultiChoice.UseVisualStyleBackColor = True
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 67)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(74, 13)
    Me.Label2.TabIndex = 44
    Me.Label2.Text = "Kryteria oceny"
    '
    'cbKryteria
    '
    Me.cbKryteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbKryteria.FormattingEnabled = True
    Me.cbKryteria.Location = New System.Drawing.Point(92, 64)
    Me.cbKryteria.Name = "cbKryteria"
    Me.cbKryteria.Size = New System.Drawing.Size(298, 21)
    Me.cbKryteria.TabIndex = 43
    '
    'dlgTest
    '
    Me.AcceptButton = Me.OK_Button
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.Cancel_Button
    Me.ClientSize = New System.Drawing.Size(654, 142)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.cbKryteria)
    Me.Controls.Add(Me.chkMultiChoice)
    Me.Controls.Add(Me.nudLimitOdp)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.nudLimitCzasu)
    Me.Controls.Add(Me.Label9)
    Me.Controls.Add(Me.txtPassword)
    Me.Controls.Add(Me.Label10)
    Me.Controls.Add(Me.txtNazwa)
    Me.Controls.Add(Me.Label11)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "dlgTest"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Nowy test"
    Me.TableLayoutPanel1.ResumeLayout(False)
    CType(Me.nudLimitOdp, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nudLimitCzasu, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents OK_Button As System.Windows.Forms.Button
  Friend WithEvents Cancel_Button As System.Windows.Forms.Button
  Friend WithEvents nudLimitOdp As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents nudLimitCzasu As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents txtPassword As System.Windows.Forms.TextBox
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents txtNazwa As System.Windows.Forms.TextBox
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents chkMultiChoice As System.Windows.Forms.CheckBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents cbKryteria As System.Windows.Forms.ComboBox

End Class
