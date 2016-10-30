<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgWersja
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
    Me.Label1 = New System.Windows.Forms.Label
    Me.cbStudent = New System.Windows.Forms.ComboBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.txtUser = New System.Windows.Forms.TextBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.cbKlasa = New System.Windows.Forms.ComboBox
    Me.Label4 = New System.Windows.Forms.Label
    Me.txtIP = New System.Windows.Forms.TextBox
    Me.lvTest = New ListviewWithTooltip.ListViewWithTooltip
    Me.lvKryteria = New ListviewWithTooltip.ListViewWithTooltip
    Me.Label6 = New System.Windows.Forms.Label
    Me.Label7 = New System.Windows.Forms.Label
    Me.txtWynik = New System.Windows.Forms.TextBox
    Me.Label8 = New System.Windows.Forms.Label
    Me.txtOcena = New System.Windows.Forms.TextBox
    Me.Label9 = New System.Windows.Forms.Label
    Me.Label5 = New System.Windows.Forms.Label
    Me.lblTypTestu = New System.Windows.Forms.Label
    Me.lblLimitCzasu = New System.Windows.Forms.Label
    Me.TableLayoutPanel1.SuspendLayout()
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
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(15, 479)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(599, 29)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'OK_Button
    '
    Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
    Me.OK_Button.Enabled = False
    Me.OK_Button.Location = New System.Drawing.Point(3, 3)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(293, 23)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "Start"
    '
    'Cancel_Button
    '
    Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Cancel_Button.Location = New System.Drawing.Point(302, 3)
    Me.Cancel_Button.Name = "Cancel_Button"
    Me.Cancel_Button.Size = New System.Drawing.Size(294, 23)
    Me.Cancel_Button.TabIndex = 1
    Me.Cancel_Button.Text = "Zamknij"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(207, 41)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(79, 13)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Nazwisko i imię"
    '
    'cbStudent
    '
    Me.cbStudent.DropDownHeight = 350
    Me.cbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbStudent.Enabled = False
    Me.cbStudent.FormattingEnabled = True
    Me.cbStudent.IntegralHeight = False
    Me.cbStudent.Location = New System.Drawing.Point(292, 38)
    Me.cbStudent.Name = "cbStudent"
    Me.cbStudent.Size = New System.Drawing.Size(322, 21)
    Me.cbStudent.TabIndex = 41
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 15)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(62, 13)
    Me.Label2.TabIndex = 42
    Me.Label2.Text = "Użytkownik"
    '
    'txtUser
    '
    Me.txtUser.Enabled = False
    Me.txtUser.Location = New System.Drawing.Point(80, 12)
    Me.txtUser.Name = "txtUser"
    Me.txtUser.Size = New System.Drawing.Size(206, 20)
    Me.txtUser.TabIndex = 43
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 41)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(36, 13)
    Me.Label3.TabIndex = 44
    Me.Label3.Text = "Grupa"
    '
    'cbKlasa
    '
    Me.cbKlasa.DropDownHeight = 350
    Me.cbKlasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbKlasa.FormattingEnabled = True
    Me.cbKlasa.IntegralHeight = False
    Me.cbKlasa.Location = New System.Drawing.Point(80, 38)
    Me.cbKlasa.Name = "cbKlasa"
    Me.cbKlasa.Size = New System.Drawing.Size(121, 21)
    Me.cbKlasa.TabIndex = 45
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(294, 15)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(29, 13)
    Me.Label4.TabIndex = 46
    Me.Label4.Text = "Host"
    '
    'txtIP
    '
    Me.txtIP.Enabled = False
    Me.txtIP.Location = New System.Drawing.Point(329, 12)
    Me.txtIP.Name = "txtIP"
    Me.txtIP.Size = New System.Drawing.Size(285, 20)
    Me.txtIP.TabIndex = 47
    '
    'lvTest
    '
    Me.lvTest.Location = New System.Drawing.Point(15, 65)
    Me.lvTest.Name = "lvTest"
    Me.lvTest.Size = New System.Drawing.Size(599, 164)
    Me.lvTest.TabIndex = 48
    Me.lvTest.UseCompatibleStateImageBehavior = False
    Me.lvTest.View = System.Windows.Forms.View.Details
    '
    'lvKryteria
    '
    Me.lvKryteria.Location = New System.Drawing.Point(15, 235)
    Me.lvKryteria.Name = "lvKryteria"
    Me.lvKryteria.Size = New System.Drawing.Size(599, 164)
    Me.lvKryteria.TabIndex = 49
    Me.lvKryteria.UseCompatibleStateImageBehavior = False
    Me.lvKryteria.View = System.Windows.Forms.View.Details
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(12, 408)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(59, 13)
    Me.Label6.TabIndex = 50
    Me.Label6.Text = "Limit czasu"
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(73, 408)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(67, 13)
    Me.Label7.TabIndex = 54
    Me.Label7.Text = "(w minutach)"
    '
    'txtWynik
    '
    Me.txtWynik.BackColor = System.Drawing.SystemColors.Info
    Me.txtWynik.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
    Me.txtWynik.ForeColor = System.Drawing.Color.Firebrick
    Me.txtWynik.Location = New System.Drawing.Point(146, 449)
    Me.txtWynik.Name = "txtWynik"
    Me.txtWynik.ReadOnly = True
    Me.txtWynik.Size = New System.Drawing.Size(99, 20)
    Me.txtWynik.TabIndex = 56
    Me.txtWynik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(12, 452)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(128, 13)
    Me.Label8.TabIndex = 55
    Me.Label8.Text = "Uzyskana liczba punktów"
    '
    'txtOcena
    '
    Me.txtOcena.BackColor = System.Drawing.SystemColors.Info
    Me.txtOcena.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
    Me.txtOcena.ForeColor = System.Drawing.Color.Firebrick
    Me.txtOcena.Location = New System.Drawing.Point(360, 449)
    Me.txtOcena.Name = "txtOcena"
    Me.txtOcena.ReadOnly = True
    Me.txtOcena.Size = New System.Drawing.Size(254, 20)
    Me.txtOcena.TabIndex = 58
    Me.txtOcena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(315, 452)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(39, 13)
    Me.Label9.TabIndex = 57
    Me.Label9.Text = "Ocena"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(419, 408)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(62, 13)
    Me.Label5.TabIndex = 60
    Me.Label5.Text = "Typ wyboru"
    '
    'lblTypTestu
    '
    Me.lblTypTestu.AutoSize = True
    Me.lblTypTestu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
    Me.lblTypTestu.ForeColor = System.Drawing.Color.Firebrick
    Me.lblTypTestu.Location = New System.Drawing.Point(487, 406)
    Me.lblTypTestu.Name = "lblTypTestu"
    Me.lblTypTestu.Size = New System.Drawing.Size(80, 15)
    Me.lblTypTestu.TabIndex = 61
    Me.lblTypTestu.Text = "lblTypTestu"
    '
    'lblLimitCzasu
    '
    Me.lblLimitCzasu.AutoSize = True
    Me.lblLimitCzasu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
    Me.lblLimitCzasu.ForeColor = System.Drawing.Color.Firebrick
    Me.lblLimitCzasu.Location = New System.Drawing.Point(146, 406)
    Me.lblLimitCzasu.Name = "lblLimitCzasu"
    Me.lblLimitCzasu.Size = New System.Drawing.Size(94, 15)
    Me.lblLimitCzasu.TabIndex = 62
    Me.lblLimitCzasu.Text = "lblLimitCzasu"
    '
    'dlgWersja
    '
    Me.AcceptButton = Me.OK_Button
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.Cancel_Button
    Me.ClientSize = New System.Drawing.Size(626, 520)
    Me.Controls.Add(Me.lblLimitCzasu)
    Me.Controls.Add(Me.lblTypTestu)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.txtOcena)
    Me.Controls.Add(Me.Label9)
    Me.Controls.Add(Me.txtWynik)
    Me.Controls.Add(Me.Label8)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.lvKryteria)
    Me.Controls.Add(Me.lvTest)
    Me.Controls.Add(Me.txtIP)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.cbKlasa)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.txtUser)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.cbStudent)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "dlgWersja"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Wybór testu"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents OK_Button As System.Windows.Forms.Button
  Friend WithEvents Cancel_Button As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cbStudent As System.Windows.Forms.ComboBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtUser As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents cbKlasa As System.Windows.Forms.ComboBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents txtIP As System.Windows.Forms.TextBox
  Friend WithEvents lvTest As ListviewWithTooltip.ListViewWithTooltip
  Friend WithEvents lvKryteria As ListviewWithTooltip.ListViewWithTooltip
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents txtWynik As System.Windows.Forms.TextBox
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents txtOcena As System.Windows.Forms.TextBox
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents lblTypTestu As System.Windows.Forms.Label
  Friend WithEvents lblLimitCzasu As System.Windows.Forms.Label

End Class
