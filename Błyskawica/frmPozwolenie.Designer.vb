<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPozwolenie
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
    Me.cbPrzedmiot = New System.Windows.Forms.ComboBox
    Me.lblPrzedmiot = New System.Windows.Forms.Label
    Me.lvRejestr = New ListviewWithTooltip.ListViewWithTooltip
    Me.lvStudent = New ListviewWithTooltip.ListViewWithTooltip
    Me.cmdDelete = New System.Windows.Forms.Button
    Me.cmdAddNew = New System.Windows.Forms.Button
    Me.cmdClose = New System.Windows.Forms.Button
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
    Me.Label8 = New System.Windows.Forms.Label
    Me.lblRecord = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.cbSeek = New System.Windows.Forms.ComboBox
    Me.txtSeek = New System.Windows.Forms.TextBox
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
    Me.lblData = New System.Windows.Forms.Label
    Me.lblUser = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.lblIP = New System.Windows.Forms.Label
    Me.Label12 = New System.Windows.Forms.Label
    Me.Label14 = New System.Windows.Forms.Label
    Me.Panel1.SuspendLayout()
    Me.TableLayoutPanel3.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'cbPrzedmiot
    '
    Me.cbPrzedmiot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbPrzedmiot.Enabled = False
    Me.cbPrzedmiot.FormattingEnabled = True
    Me.cbPrzedmiot.Location = New System.Drawing.Point(71, 12)
    Me.cbPrzedmiot.Name = "cbPrzedmiot"
    Me.cbPrzedmiot.Size = New System.Drawing.Size(421, 21)
    Me.cbPrzedmiot.TabIndex = 42
    '
    'lblPrzedmiot
    '
    Me.lblPrzedmiot.AutoSize = True
    Me.lblPrzedmiot.Location = New System.Drawing.Point(12, 15)
    Me.lblPrzedmiot.Name = "lblPrzedmiot"
    Me.lblPrzedmiot.Size = New System.Drawing.Size(53, 13)
    Me.lblPrzedmiot.TabIndex = 41
    Me.lblPrzedmiot.Text = "Przedmiot"
    '
    'lvRejestr
    '
    Me.lvRejestr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lvRejestr.Location = New System.Drawing.Point(12, 39)
    Me.lvRejestr.Name = "lvRejestr"
    Me.lvRejestr.Size = New System.Drawing.Size(680, 164)
    Me.lvRejestr.TabIndex = 43
    Me.lvRejestr.UseCompatibleStateImageBehavior = False
    Me.lvRejestr.View = System.Windows.Forms.View.Details
    '
    'lvStudent
    '
    Me.lvStudent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lvStudent.Location = New System.Drawing.Point(12, 209)
    Me.lvStudent.Name = "lvStudent"
    Me.lvStudent.Size = New System.Drawing.Size(680, 276)
    Me.lvStudent.TabIndex = 44
    Me.lvStudent.UseCompatibleStateImageBehavior = False
    Me.lvStudent.View = System.Windows.Forms.View.Details
    '
    'cmdDelete
    '
    Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdDelete.Enabled = False
    Me.cmdDelete.Location = New System.Drawing.Point(698, 68)
    Me.cmdDelete.Name = "cmdDelete"
    Me.cmdDelete.Size = New System.Drawing.Size(75, 23)
    Me.cmdDelete.TabIndex = 47
    Me.cmdDelete.Text = "&Odbierz"
    Me.cmdDelete.UseVisualStyleBackColor = True
    '
    'cmdAddNew
    '
    Me.cmdAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdAddNew.Enabled = False
    Me.cmdAddNew.Location = New System.Drawing.Point(698, 39)
    Me.cmdAddNew.Name = "cmdAddNew"
    Me.cmdAddNew.Size = New System.Drawing.Size(75, 23)
    Me.cmdAddNew.TabIndex = 46
    Me.cmdAddNew.Text = "&Nadaj"
    Me.cmdAddNew.UseVisualStyleBackColor = True
    '
    'cmdClose
    '
    Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdClose.Location = New System.Drawing.Point(698, 456)
    Me.cmdClose.Name = "cmdClose"
    Me.cmdClose.Size = New System.Drawing.Size(75, 23)
    Me.cmdClose.TabIndex = 174
    Me.cmdClose.Text = "&Zamknij"
    Me.cmdClose.UseVisualStyleBackColor = True
    '
    'Panel1
    '
    Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel1.Controls.Add(Me.TableLayoutPanel3)
    Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
    Me.Panel1.Location = New System.Drawing.Point(4, 485)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(778, 82)
    Me.Panel1.TabIndex = 182
    '
    'TableLayoutPanel3
    '
    Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel3.ColumnCount = 5
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.74004!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.72117!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.78826!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.75052!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320.0!))
    Me.TableLayoutPanel3.Controls.Add(Me.Label8, 0, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.lblRecord, 1, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.Label1, 2, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.cbSeek, 3, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.txtSeek, 4, 0)
    Me.TableLayoutPanel3.Location = New System.Drawing.Point(8, 4)
    Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
    Me.TableLayoutPanel3.RowCount = 1
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel3.Size = New System.Drawing.Size(766, 25)
    Me.TableLayoutPanel3.TabIndex = 173
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label8.Location = New System.Drawing.Point(3, 0)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(46, 25)
    Me.Label8.TabIndex = 148
    Me.Label8.Text = "Rekord:"
    Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblRecord
    '
    Me.lblRecord.AutoSize = True
    Me.lblRecord.Dock = System.Windows.Forms.DockStyle.Left
    Me.lblRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
    Me.lblRecord.ForeColor = System.Drawing.Color.Red
    Me.lblRecord.Location = New System.Drawing.Point(55, 0)
    Me.lblRecord.Name = "lblRecord"
    Me.lblRecord.Size = New System.Drawing.Size(61, 25)
    Me.lblRecord.TabIndex = 147
    Me.lblRecord.Text = "lblRecord"
    Me.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label1.Location = New System.Drawing.Point(183, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(51, 25)
    Me.Label1.TabIndex = 148
    Me.Label1.Text = "Filtruj wg"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'cbSeek
    '
    Me.cbSeek.Dock = System.Windows.Forms.DockStyle.Fill
    Me.cbSeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbSeek.FormattingEnabled = True
    Me.cbSeek.Location = New System.Drawing.Point(240, 3)
    Me.cbSeek.Name = "cbSeek"
    Me.cbSeek.Size = New System.Drawing.Size(202, 21)
    Me.cbSeek.TabIndex = 149
    '
    'txtSeek
    '
    Me.txtSeek.Dock = System.Windows.Forms.DockStyle.Fill
    Me.txtSeek.Location = New System.Drawing.Point(448, 3)
    Me.txtSeek.Name = "txtSeek"
    Me.txtSeek.Size = New System.Drawing.Size(315, 20)
    Me.txtSeek.TabIndex = 150
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel1.ColumnCount = 6
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.65598!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.122449!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.86297!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.80758!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.29625!))
    Me.TableLayoutPanel1.Controls.Add(Me.lblData, 5, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.lblUser, 1, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.lblIP, 3, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Label12, 2, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Label14, 4, 0)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(8, 44)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(766, 28)
    Me.TableLayoutPanel1.TabIndex = 172
    '
    'lblData
    '
    Me.lblData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblData.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lblData.Enabled = False
    Me.lblData.Location = New System.Drawing.Point(580, 0)
    Me.lblData.Name = "lblData"
    Me.lblData.Size = New System.Drawing.Size(183, 28)
    Me.lblData.TabIndex = 167
    Me.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblUser
    '
    Me.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblUser.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lblUser.Enabled = False
    Me.lblUser.Location = New System.Drawing.Point(83, 0)
    Me.lblUser.Name = "lblUser"
    Me.lblUser.Size = New System.Drawing.Size(170, 28)
    Me.lblUser.TabIndex = 166
    Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label4
    '
    Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.Label4.AutoSize = True
    Me.Label4.Enabled = False
    Me.Label4.Location = New System.Drawing.Point(3, 0)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(74, 28)
    Me.Label4.TabIndex = 164
    Me.Label4.Text = "Zmodyfikował"
    Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblIP
    '
    Me.lblIP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblIP.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lblIP.Enabled = False
    Me.lblIP.Location = New System.Drawing.Point(301, 0)
    Me.lblIP.Name = "lblIP"
    Me.lblIP.Size = New System.Drawing.Size(192, 28)
    Me.lblIP.TabIndex = 165
    Me.lblIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label12.Enabled = False
    Me.Label12.Location = New System.Drawing.Point(259, 0)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(36, 28)
    Me.Label12.TabIndex = 168
    Me.Label12.Text = "Nr IP"
    Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label14.Enabled = False
    Me.Label14.Location = New System.Drawing.Point(499, 0)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(75, 28)
    Me.Label14.TabIndex = 169
    Me.Label14.Text = "Data modyfik."
    Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'frmPozwolenie
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(785, 569)
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.cmdClose)
    Me.Controls.Add(Me.cmdDelete)
    Me.Controls.Add(Me.cmdAddNew)
    Me.Controls.Add(Me.lvStudent)
    Me.Controls.Add(Me.lvRejestr)
    Me.Controls.Add(Me.cbPrzedmiot)
    Me.Controls.Add(Me.lblPrzedmiot)
    Me.Name = "frmPozwolenie"
    Me.Text = "Pozwolenia"
    Me.Panel1.ResumeLayout(False)
    Me.TableLayoutPanel3.ResumeLayout(False)
    Me.TableLayoutPanel3.PerformLayout()
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cbPrzedmiot As System.Windows.Forms.ComboBox
  Friend WithEvents lblPrzedmiot As System.Windows.Forms.Label
  Friend WithEvents lvRejestr As ListviewWithTooltip.ListViewWithTooltip
  Friend WithEvents lvStudent As ListviewWithTooltip.ListViewWithTooltip
  Friend WithEvents cmdDelete As System.Windows.Forms.Button
  Friend WithEvents cmdAddNew As System.Windows.Forms.Button
  Friend WithEvents cmdClose As System.Windows.Forms.Button
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents lblRecord As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents lblData As System.Windows.Forms.Label
  Friend WithEvents lblUser As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents lblIP As System.Windows.Forms.Label
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents cbSeek As System.Windows.Forms.ComboBox
  Friend WithEvents txtSeek As System.Windows.Forms.TextBox
End Class
