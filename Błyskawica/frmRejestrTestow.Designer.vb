<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRejestrTestow
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
    Me.lvRejestr = New ListviewWithTooltip.ListViewWithTooltip
    Me.Panel2 = New System.Windows.Forms.Panel
    Me.Label14 = New System.Windows.Forms.Label
    Me.Label12 = New System.Windows.Forms.Label
    Me.lblData = New System.Windows.Forms.Label
    Me.lblIP = New System.Windows.Forms.Label
    Me.lblUser = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.cmdClose = New System.Windows.Forms.Button
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.Label8 = New System.Windows.Forms.Label
    Me.lblRecord = New System.Windows.Forms.Label
    Me.cmdEdit = New System.Windows.Forms.Button
    Me.cmdDelete = New System.Windows.Forms.Button
    Me.cmdAddNew = New System.Windows.Forms.Button
    Me.cmdAktywacja = New System.Windows.Forms.Button
    Me.Label1 = New System.Windows.Forms.Label
    Me.cbPrzedmiot = New System.Windows.Forms.ComboBox
    Me.lvPytania = New ListviewWithTooltip.ListViewWithTooltip
    Me.Panel3 = New System.Windows.Forms.Panel
    Me.Label2 = New System.Windows.Forms.Label
    Me.lblRecord1 = New System.Windows.Forms.Label
    Me.cmdDeletePytanie = New System.Windows.Forms.Button
    Me.cmdAddPytanie = New System.Windows.Forms.Button
    Me.cmdUp = New System.Windows.Forms.Button
    Me.cmdDown = New System.Windows.Forms.Button
    Me.Panel2.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.Panel3.SuspendLayout()
    Me.SuspendLayout()
    '
    'lvRejestr
    '
    Me.lvRejestr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lvRejestr.Location = New System.Drawing.Point(12, 39)
    Me.lvRejestr.Name = "lvRejestr"
    Me.lvRejestr.Size = New System.Drawing.Size(794, 164)
    Me.lvRejestr.TabIndex = 0
    Me.lvRejestr.UseCompatibleStateImageBehavior = False
    Me.lvRejestr.View = System.Windows.Forms.View.Details
    '
    'Panel2
    '
    Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel2.Controls.Add(Me.Label14)
    Me.Panel2.Controls.Add(Me.Label12)
    Me.Panel2.Controls.Add(Me.lblData)
    Me.Panel2.Controls.Add(Me.lblIP)
    Me.Panel2.Controls.Add(Me.lblUser)
    Me.Panel2.Controls.Add(Me.Label3)
    Me.Panel2.Location = New System.Drawing.Point(12, 533)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(881, 28)
    Me.Panel2.TabIndex = 32
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Enabled = False
    Me.Label14.Location = New System.Drawing.Point(598, 6)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(72, 13)
    Me.Label14.TabIndex = 169
    Me.Label14.Text = "Data modyfik."
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Enabled = False
    Me.Label12.Location = New System.Drawing.Point(293, 6)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(31, 13)
    Me.Label12.TabIndex = 168
    Me.Label12.Text = "Nr IP"
    '
    'lblData
    '
    Me.lblData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblData.Enabled = False
    Me.lblData.Location = New System.Drawing.Point(676, 1)
    Me.lblData.Name = "lblData"
    Me.lblData.Size = New System.Drawing.Size(202, 23)
    Me.lblData.TabIndex = 167
    Me.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblIP
    '
    Me.lblIP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblIP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblIP.Enabled = False
    Me.lblIP.Location = New System.Drawing.Point(330, 1)
    Me.lblIP.Name = "lblIP"
    Me.lblIP.Size = New System.Drawing.Size(262, 23)
    Me.lblIP.TabIndex = 165
    Me.lblIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblUser
    '
    Me.lblUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblUser.Enabled = False
    Me.lblUser.Location = New System.Drawing.Point(83, 1)
    Me.lblUser.Name = "lblUser"
    Me.lblUser.Size = New System.Drawing.Size(204, 23)
    Me.lblUser.TabIndex = 166
    Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Enabled = False
    Me.Label3.Location = New System.Drawing.Point(3, 6)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(74, 13)
    Me.Label3.TabIndex = 164
    Me.Label3.Text = "Zmodyfikował"
    '
    'cmdClose
    '
    Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdClose.Location = New System.Drawing.Point(812, 473)
    Me.cmdClose.Name = "cmdClose"
    Me.cmdClose.Size = New System.Drawing.Size(81, 23)
    Me.cmdClose.TabIndex = 33
    Me.cmdClose.Text = "&Zamknij"
    Me.cmdClose.UseVisualStyleBackColor = True
    '
    'Panel1
    '
    Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel1.Controls.Add(Me.Label8)
    Me.Panel1.Controls.Add(Me.lblRecord)
    Me.Panel1.Location = New System.Drawing.Point(12, 206)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(881, 26)
    Me.Panel1.TabIndex = 34
    '
    'Label8
    '
    Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(3, 6)
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
    Me.lblRecord.Location = New System.Drawing.Point(54, 6)
    Me.lblRecord.Name = "lblRecord"
    Me.lblRecord.Size = New System.Drawing.Size(61, 13)
    Me.lblRecord.TabIndex = 146
    Me.lblRecord.Text = "lblRecord"
    '
    'cmdEdit
    '
    Me.cmdEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdEdit.Enabled = False
    Me.cmdEdit.Location = New System.Drawing.Point(812, 68)
    Me.cmdEdit.Name = "cmdEdit"
    Me.cmdEdit.Size = New System.Drawing.Size(81, 23)
    Me.cmdEdit.TabIndex = 37
    Me.cmdEdit.Text = "&Edytuj test"
    Me.cmdEdit.UseVisualStyleBackColor = True
    '
    'cmdDelete
    '
    Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdDelete.Enabled = False
    Me.cmdDelete.Location = New System.Drawing.Point(812, 97)
    Me.cmdDelete.Name = "cmdDelete"
    Me.cmdDelete.Size = New System.Drawing.Size(81, 23)
    Me.cmdDelete.TabIndex = 36
    Me.cmdDelete.Text = "&Usuń test"
    Me.cmdDelete.UseVisualStyleBackColor = True
    '
    'cmdAddNew
    '
    Me.cmdAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdAddNew.Enabled = False
    Me.cmdAddNew.Location = New System.Drawing.Point(812, 39)
    Me.cmdAddNew.Name = "cmdAddNew"
    Me.cmdAddNew.Size = New System.Drawing.Size(81, 23)
    Me.cmdAddNew.TabIndex = 35
    Me.cmdAddNew.Text = "&Nowy test"
    Me.cmdAddNew.UseVisualStyleBackColor = True
    '
    'cmdAktywacja
    '
    Me.cmdAktywacja.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdAktywacja.Enabled = False
    Me.cmdAktywacja.Location = New System.Drawing.Point(812, 126)
    Me.cmdAktywacja.Name = "cmdAktywacja"
    Me.cmdAktywacja.Size = New System.Drawing.Size(81, 23)
    Me.cmdAktywacja.TabIndex = 38
    Me.cmdAktywacja.Text = "&Aktywacja"
    Me.cmdAktywacja.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 15)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(53, 13)
    Me.Label1.TabIndex = 39
    Me.Label1.Text = "Przedmiot"
    '
    'cbPrzedmiot
    '
    Me.cbPrzedmiot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbPrzedmiot.Enabled = False
    Me.cbPrzedmiot.FormattingEnabled = True
    Me.cbPrzedmiot.Location = New System.Drawing.Point(71, 12)
    Me.cbPrzedmiot.Name = "cbPrzedmiot"
    Me.cbPrzedmiot.Size = New System.Drawing.Size(421, 21)
    Me.cbPrzedmiot.TabIndex = 40
    '
    'lvPytania
    '
    Me.lvPytania.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lvPytania.Location = New System.Drawing.Point(12, 235)
    Me.lvPytania.Name = "lvPytania"
    Me.lvPytania.Size = New System.Drawing.Size(794, 263)
    Me.lvPytania.TabIndex = 41
    Me.lvPytania.UseCompatibleStateImageBehavior = False
    Me.lvPytania.View = System.Windows.Forms.View.Details
    '
    'Panel3
    '
    Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3.Controls.Add(Me.Label2)
    Me.Panel3.Controls.Add(Me.lblRecord1)
    Me.Panel3.Location = New System.Drawing.Point(12, 502)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(881, 26)
    Me.Panel3.TabIndex = 42
    '
    'Label2
    '
    Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(3, 6)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(45, 13)
    Me.Label2.TabIndex = 145
    Me.Label2.Text = "Rekord:"
    '
    'lblRecord1
    '
    Me.lblRecord1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblRecord1.AutoSize = True
    Me.lblRecord1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
    Me.lblRecord1.ForeColor = System.Drawing.Color.Red
    Me.lblRecord1.Location = New System.Drawing.Point(54, 6)
    Me.lblRecord1.Name = "lblRecord1"
    Me.lblRecord1.Size = New System.Drawing.Size(68, 13)
    Me.lblRecord1.TabIndex = 146
    Me.lblRecord1.Text = "lblRecord1"
    '
    'cmdDeletePytanie
    '
    Me.cmdDeletePytanie.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdDeletePytanie.Enabled = False
    Me.cmdDeletePytanie.Location = New System.Drawing.Point(812, 267)
    Me.cmdDeletePytanie.Name = "cmdDeletePytanie"
    Me.cmdDeletePytanie.Size = New System.Drawing.Size(81, 23)
    Me.cmdDeletePytanie.TabIndex = 44
    Me.cmdDeletePytanie.Text = "Usuń pytanie"
    Me.cmdDeletePytanie.UseVisualStyleBackColor = True
    '
    'cmdAddPytanie
    '
    Me.cmdAddPytanie.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdAddPytanie.Enabled = False
    Me.cmdAddPytanie.Location = New System.Drawing.Point(812, 238)
    Me.cmdAddPytanie.Name = "cmdAddPytanie"
    Me.cmdAddPytanie.Size = New System.Drawing.Size(81, 23)
    Me.cmdAddPytanie.TabIndex = 43
    Me.cmdAddPytanie.Text = "Dodaj pytanie"
    Me.cmdAddPytanie.UseVisualStyleBackColor = True
    '
    'cmdUp
    '
    Me.cmdUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdUp.Enabled = False
    Me.cmdUp.Location = New System.Drawing.Point(812, 321)
    Me.cmdUp.Name = "cmdUp"
    Me.cmdUp.Size = New System.Drawing.Size(81, 36)
    Me.cmdUp.TabIndex = 45
    Me.cmdUp.Text = "Przesuń w górę"
    Me.cmdUp.UseVisualStyleBackColor = True
    '
    'cmdDown
    '
    Me.cmdDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdDown.Enabled = False
    Me.cmdDown.Location = New System.Drawing.Point(812, 363)
    Me.cmdDown.Name = "cmdDown"
    Me.cmdDown.Size = New System.Drawing.Size(81, 35)
    Me.cmdDown.TabIndex = 46
    Me.cmdDown.Text = "Przesuń w dół"
    Me.cmdDown.UseVisualStyleBackColor = True
    '
    'frmRejestrTestow
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(905, 569)
    Me.Controls.Add(Me.cmdDown)
    Me.Controls.Add(Me.cmdUp)
    Me.Controls.Add(Me.cmdDeletePytanie)
    Me.Controls.Add(Me.cmdAddPytanie)
    Me.Controls.Add(Me.Panel3)
    Me.Controls.Add(Me.lvPytania)
    Me.Controls.Add(Me.cbPrzedmiot)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.cmdAktywacja)
    Me.Controls.Add(Me.cmdEdit)
    Me.Controls.Add(Me.cmdDelete)
    Me.Controls.Add(Me.cmdAddNew)
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.cmdClose)
    Me.Controls.Add(Me.Panel2)
    Me.Controls.Add(Me.lvRejestr)
    Me.Name = "frmRejestrTestow"
    Me.Text = "Rejestr testów"
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.Panel3.ResumeLayout(False)
    Me.Panel3.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lvRejestr As ListviewWithTooltip.ListViewWithTooltip
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents lblData As System.Windows.Forms.Label
  Friend WithEvents lblIP As System.Windows.Forms.Label
  Friend WithEvents lblUser As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents cmdClose As System.Windows.Forms.Button
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents lblRecord As System.Windows.Forms.Label
  Friend WithEvents cmdEdit As System.Windows.Forms.Button
  Friend WithEvents cmdDelete As System.Windows.Forms.Button
  Friend WithEvents cmdAddNew As System.Windows.Forms.Button
  Friend WithEvents cmdAktywacja As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cbPrzedmiot As System.Windows.Forms.ComboBox
  Friend WithEvents lvPytania As ListviewWithTooltip.ListViewWithTooltip
  Friend WithEvents Panel3 As System.Windows.Forms.Panel
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents lblRecord1 As System.Windows.Forms.Label
  Friend WithEvents cmdDeletePytanie As System.Windows.Forms.Button
  Friend WithEvents cmdAddPytanie As System.Windows.Forms.Button
  Friend WithEvents cmdUp As System.Windows.Forms.Button
  Friend WithEvents cmdDown As System.Windows.Forms.Button
End Class
