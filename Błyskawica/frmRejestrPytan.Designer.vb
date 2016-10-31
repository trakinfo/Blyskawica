<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRejestrPytan
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
    Me.cbModul = New System.Windows.Forms.ComboBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.lvRejestr = New ListviewWithTooltip.ListViewWithTooltip
    Me.cmdEdit = New System.Windows.Forms.Button
    Me.cmdDelete = New System.Windows.Forms.Button
    Me.cmdAddNew = New System.Windows.Forms.Button
    Me.cmdClose = New System.Windows.Forms.Button
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.Label8 = New System.Windows.Forms.Label
    Me.lblRecord = New System.Windows.Forms.Label
    Me.lvOdp = New ListviewWithTooltip.ListViewWithTooltip
    Me.cmdEditOdp = New System.Windows.Forms.Button
    Me.cmdDeleteOdp = New System.Windows.Forms.Button
    Me.cmdAddOdp = New System.Windows.Forms.Button
    Me.Panel2 = New System.Windows.Forms.Panel
    Me.Label3 = New System.Windows.Forms.Label
    Me.lblRecord1 = New System.Windows.Forms.Label
    Me.Label14 = New System.Windows.Forms.Label
    Me.Label12 = New System.Windows.Forms.Label
    Me.lblData = New System.Windows.Forms.Label
    Me.lblIP = New System.Windows.Forms.Label
    Me.lblUser = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
    Me.Panel1.SuspendLayout()
    Me.Panel2.SuspendLayout()
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
    Me.cbPrzedmiot.Size = New System.Drawing.Size(252, 21)
    Me.cbPrzedmiot.TabIndex = 0
    '
    'cbModul
    '
    Me.cbModul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbModul.Enabled = False
    Me.cbModul.FormattingEnabled = True
    Me.cbModul.Location = New System.Drawing.Point(373, 12)
    Me.cbModul.Name = "cbModul"
    Me.cbModul.Size = New System.Drawing.Size(485, 21)
    Me.cbModul.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 15)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(53, 13)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Przedmiot"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(329, 15)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(38, 13)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Moduł"
    '
    'lvRejestr
    '
    Me.lvRejestr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lvRejestr.Location = New System.Drawing.Point(12, 39)
    Me.lvRejestr.Name = "lvRejestr"
    Me.lvRejestr.Size = New System.Drawing.Size(846, 277)
    Me.lvRejestr.TabIndex = 4
    Me.lvRejestr.UseCompatibleStateImageBehavior = False
    Me.lvRejestr.View = System.Windows.Forms.View.Details
    '
    'cmdEdit
    '
    Me.cmdEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdEdit.Enabled = False
    Me.cmdEdit.Location = New System.Drawing.Point(870, 68)
    Me.cmdEdit.Name = "cmdEdit"
    Me.cmdEdit.Size = New System.Drawing.Size(75, 23)
    Me.cmdEdit.TabIndex = 40
    Me.cmdEdit.Text = "&Edytuj"
    Me.cmdEdit.UseVisualStyleBackColor = True
    '
    'cmdDelete
    '
    Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdDelete.Enabled = False
    Me.cmdDelete.Location = New System.Drawing.Point(870, 97)
    Me.cmdDelete.Name = "cmdDelete"
    Me.cmdDelete.Size = New System.Drawing.Size(75, 23)
    Me.cmdDelete.TabIndex = 39
    Me.cmdDelete.Text = "&Usuń"
    Me.cmdDelete.UseVisualStyleBackColor = True
    '
    'cmdAddNew
    '
    Me.cmdAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdAddNew.Enabled = False
    Me.cmdAddNew.Location = New System.Drawing.Point(870, 39)
    Me.cmdAddNew.Name = "cmdAddNew"
    Me.cmdAddNew.Size = New System.Drawing.Size(75, 23)
    Me.cmdAddNew.TabIndex = 38
    Me.cmdAddNew.Text = "&Dodaj"
    Me.cmdAddNew.UseVisualStyleBackColor = True
    '
    'cmdClose
    '
    Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdClose.Location = New System.Drawing.Point(870, 532)
    Me.cmdClose.Name = "cmdClose"
    Me.cmdClose.Size = New System.Drawing.Size(75, 23)
    Me.cmdClose.TabIndex = 41
    Me.cmdClose.Text = "&Zamknij"
    Me.cmdClose.UseVisualStyleBackColor = True
    '
    'Panel1
    '
    Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel1.Controls.Add(Me.Label8)
    Me.Panel1.Controls.Add(Me.lblRecord)
    Me.Panel1.Location = New System.Drawing.Point(12, 318)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(933, 30)
    Me.Panel1.TabIndex = 42
    '
    'Label8
    '
    Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(3, 8)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(45, 13)
    Me.Label8.TabIndex = 145
    Me.Label8.Text = "Rekord:"
    '
    'lblRecord
    '
    Me.lblRecord.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblRecord.AutoSize = True
    Me.lblRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
    Me.lblRecord.ForeColor = System.Drawing.Color.Red
    Me.lblRecord.Location = New System.Drawing.Point(54, 8)
    Me.lblRecord.Name = "lblRecord"
    Me.lblRecord.Size = New System.Drawing.Size(61, 13)
    Me.lblRecord.TabIndex = 146
    Me.lblRecord.Text = "lblRecord"
    '
    'lvOdp
    '
    Me.lvOdp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lvOdp.Location = New System.Drawing.Point(12, 354)
    Me.lvOdp.Name = "lvOdp"
    Me.lvOdp.Size = New System.Drawing.Size(846, 137)
    Me.lvOdp.TabIndex = 43
    Me.lvOdp.UseCompatibleStateImageBehavior = False
    Me.lvOdp.View = System.Windows.Forms.View.Details
    '
    'cmdEditOdp
    '
    Me.cmdEditOdp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdEditOdp.Enabled = False
    Me.cmdEditOdp.Location = New System.Drawing.Point(870, 387)
    Me.cmdEditOdp.Name = "cmdEditOdp"
    Me.cmdEditOdp.Size = New System.Drawing.Size(75, 23)
    Me.cmdEditOdp.TabIndex = 46
    Me.cmdEditOdp.Text = "&Edytuj"
    Me.cmdEditOdp.UseVisualStyleBackColor = True
    '
    'cmdDeleteOdp
    '
    Me.cmdDeleteOdp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdDeleteOdp.Enabled = False
    Me.cmdDeleteOdp.Location = New System.Drawing.Point(870, 416)
    Me.cmdDeleteOdp.Name = "cmdDeleteOdp"
    Me.cmdDeleteOdp.Size = New System.Drawing.Size(75, 23)
    Me.cmdDeleteOdp.TabIndex = 45
    Me.cmdDeleteOdp.Text = "&Usuń"
    Me.cmdDeleteOdp.UseVisualStyleBackColor = True
    '
    'cmdAddOdp
    '
    Me.cmdAddOdp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdAddOdp.Enabled = False
    Me.cmdAddOdp.Location = New System.Drawing.Point(870, 358)
    Me.cmdAddOdp.Name = "cmdAddOdp"
    Me.cmdAddOdp.Size = New System.Drawing.Size(75, 23)
    Me.cmdAddOdp.TabIndex = 44
    Me.cmdAddOdp.Text = "&Dodaj"
    Me.cmdAddOdp.UseVisualStyleBackColor = True
    '
    'Panel2
    '
    Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel2.Controls.Add(Me.Label3)
    Me.Panel2.Controls.Add(Me.lblRecord1)
    Me.Panel2.Location = New System.Drawing.Point(12, 494)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(933, 30)
    Me.Panel2.TabIndex = 148
    '
    'Label3
    '
    Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(3, 7)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(45, 13)
    Me.Label3.TabIndex = 145
    Me.Label3.Text = "Rekord:"
    '
    'lblRecord1
    '
    Me.lblRecord1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblRecord1.AutoSize = True
    Me.lblRecord1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
    Me.lblRecord1.ForeColor = System.Drawing.Color.Red
    Me.lblRecord1.Location = New System.Drawing.Point(54, 7)
    Me.lblRecord1.Name = "lblRecord1"
    Me.lblRecord1.Size = New System.Drawing.Size(68, 13)
    Me.lblRecord1.TabIndex = 146
    Me.lblRecord1.Text = "lblRecord1"
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label14.Enabled = False
    Me.Label14.Location = New System.Drawing.Point(563, 0)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(72, 28)
    Me.Label14.TabIndex = 169
    Me.Label14.Text = "Data modyfik."
    Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label12.Enabled = False
    Me.Label12.Location = New System.Drawing.Point(290, 0)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(32, 28)
    Me.Label12.TabIndex = 168
    Me.Label12.Text = "Nr IP"
    Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblData
    '
    Me.lblData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblData.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lblData.Enabled = False
    Me.lblData.Location = New System.Drawing.Point(641, 0)
    Me.lblData.Name = "lblData"
    Me.lblData.Size = New System.Drawing.Size(208, 28)
    Me.lblData.TabIndex = 167
    Me.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblIP
    '
    Me.lblIP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblIP.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lblIP.Enabled = False
    Me.lblIP.Location = New System.Drawing.Point(328, 0)
    Me.lblIP.Name = "lblIP"
    Me.lblIP.Size = New System.Drawing.Size(229, 28)
    Me.lblIP.TabIndex = 165
    Me.lblIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblUser
    '
    Me.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblUser.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lblUser.Enabled = False
    Me.lblUser.Location = New System.Drawing.Point(83, 0)
    Me.lblUser.Name = "lblUser"
    Me.lblUser.Size = New System.Drawing.Size(201, 28)
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
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel1.ColumnCount = 6
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.90815!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.045278!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.5304!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.21992!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.29625!))
    Me.TableLayoutPanel1.Controls.Add(Me.lblData, 5, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.lblUser, 1, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.lblIP, 3, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Label12, 2, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Label14, 4, 0)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 529)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(852, 28)
    Me.TableLayoutPanel1.TabIndex = 170
    '
    'frmRejestrPytan
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(957, 563)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Controls.Add(Me.Panel2)
    Me.Controls.Add(Me.cmdEditOdp)
    Me.Controls.Add(Me.cmdDeleteOdp)
    Me.Controls.Add(Me.cmdAddOdp)
    Me.Controls.Add(Me.lvOdp)
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.cmdClose)
    Me.Controls.Add(Me.cmdEdit)
    Me.Controls.Add(Me.cmdDelete)
    Me.Controls.Add(Me.cmdAddNew)
    Me.Controls.Add(Me.lvRejestr)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.cbModul)
    Me.Controls.Add(Me.cbPrzedmiot)
    Me.Name = "frmRejestrPytan"
    Me.Text = "Rejestr pytań"
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cbPrzedmiot As System.Windows.Forms.ComboBox
  Friend WithEvents cbModul As System.Windows.Forms.ComboBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents lvRejestr As ListviewWithTooltip.ListViewWithTooltip
  Friend WithEvents cmdEdit As System.Windows.Forms.Button
  Friend WithEvents cmdDelete As System.Windows.Forms.Button
  Friend WithEvents cmdAddNew As System.Windows.Forms.Button
  Friend WithEvents cmdClose As System.Windows.Forms.Button
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents lblRecord As System.Windows.Forms.Label
  Friend WithEvents lvOdp As ListviewWithTooltip.ListViewWithTooltip
  Friend WithEvents cmdEditOdp As System.Windows.Forms.Button
  Friend WithEvents cmdDeleteOdp As System.Windows.Forms.Button
  Friend WithEvents cmdAddOdp As System.Windows.Forms.Button
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents lblRecord1 As System.Windows.Forms.Label
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents lblData As System.Windows.Forms.Label
  Friend WithEvents lblIP As System.Windows.Forms.Label
  Friend WithEvents lblUser As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
