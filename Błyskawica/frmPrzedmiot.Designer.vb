<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrzedmiot
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
    Me.cmdEdit = New System.Windows.Forms.Button
    Me.cmdDelete = New System.Windows.Forms.Button
    Me.cmdAddNew = New System.Windows.Forms.Button
    Me.cmdEditModul = New System.Windows.Forms.Button
    Me.cmdDeleteModul = New System.Windows.Forms.Button
    Me.cmdAddNewModul = New System.Windows.Forms.Button
    Me.cmdClose = New System.Windows.Forms.Button
    Me.lblRecord = New System.Windows.Forms.Label
    Me.Label8 = New System.Windows.Forms.Label
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
    Me.lvModul = New ListviewWithTooltip.ListViewWithTooltip
    Me.lvPrzedmiot = New ListviewWithTooltip.ListViewWithTooltip
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
    Me.Label1 = New System.Windows.Forms.Label
    Me.lblRecord1 = New System.Windows.Forms.Label
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
    Me.lblData = New System.Windows.Forms.Label
    Me.lblUser = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.lblIP = New System.Windows.Forms.Label
    Me.Label12 = New System.Windows.Forms.Label
    Me.Label14 = New System.Windows.Forms.Label
    Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.TableLayoutPanel2.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.TableLayoutPanel3.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.TableLayoutPanel4.SuspendLayout()
    Me.SuspendLayout()
    '
    'cmdEdit
    '
    Me.cmdEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdEdit.Enabled = False
    Me.cmdEdit.Location = New System.Drawing.Point(845, 41)
    Me.cmdEdit.Name = "cmdEdit"
    Me.cmdEdit.Size = New System.Drawing.Size(100, 23)
    Me.cmdEdit.TabIndex = 174
    Me.cmdEdit.Text = "&Edytuj przedmiot"
    Me.cmdEdit.UseVisualStyleBackColor = True
    '
    'cmdDelete
    '
    Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdDelete.Enabled = False
    Me.cmdDelete.Location = New System.Drawing.Point(845, 70)
    Me.cmdDelete.Name = "cmdDelete"
    Me.cmdDelete.Size = New System.Drawing.Size(100, 23)
    Me.cmdDelete.TabIndex = 173
    Me.cmdDelete.Text = "&Usuń przedmiot"
    Me.cmdDelete.UseVisualStyleBackColor = True
    '
    'cmdAddNew
    '
    Me.cmdAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdAddNew.Location = New System.Drawing.Point(845, 12)
    Me.cmdAddNew.Name = "cmdAddNew"
    Me.cmdAddNew.Size = New System.Drawing.Size(100, 23)
    Me.cmdAddNew.TabIndex = 172
    Me.cmdAddNew.Text = "&Nowy przedmiot"
    Me.cmdAddNew.UseVisualStyleBackColor = True
    '
    'cmdEditModul
    '
    Me.cmdEditModul.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdEditModul.Enabled = False
    Me.cmdEditModul.Location = New System.Drawing.Point(845, 181)
    Me.cmdEditModul.Name = "cmdEditModul"
    Me.cmdEditModul.Size = New System.Drawing.Size(100, 23)
    Me.cmdEditModul.TabIndex = 177
    Me.cmdEditModul.Text = "&Edytuj moduł"
    Me.cmdEditModul.UseVisualStyleBackColor = True
    '
    'cmdDeleteModul
    '
    Me.cmdDeleteModul.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdDeleteModul.Enabled = False
    Me.cmdDeleteModul.Location = New System.Drawing.Point(845, 210)
    Me.cmdDeleteModul.Name = "cmdDeleteModul"
    Me.cmdDeleteModul.Size = New System.Drawing.Size(100, 23)
    Me.cmdDeleteModul.TabIndex = 176
    Me.cmdDeleteModul.Text = "&Usuń moduł"
    Me.cmdDeleteModul.UseVisualStyleBackColor = True
    '
    'cmdAddNewModul
    '
    Me.cmdAddNewModul.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdAddNewModul.Enabled = False
    Me.cmdAddNewModul.Location = New System.Drawing.Point(845, 152)
    Me.cmdAddNewModul.Name = "cmdAddNewModul"
    Me.cmdAddNewModul.Size = New System.Drawing.Size(100, 23)
    Me.cmdAddNewModul.TabIndex = 175
    Me.cmdAddNewModul.Text = "&Nowy moduł"
    Me.cmdAddNewModul.UseVisualStyleBackColor = True
    '
    'cmdClose
    '
    Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdClose.Location = New System.Drawing.Point(845, 456)
    Me.cmdClose.Name = "cmdClose"
    Me.cmdClose.Size = New System.Drawing.Size(100, 23)
    Me.cmdClose.TabIndex = 178
    Me.cmdClose.Text = "&Zamknij"
    Me.cmdClose.UseVisualStyleBackColor = True
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
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel2.ColumnCount = 2
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.77483!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.22516!))
    Me.TableLayoutPanel2.Controls.Add(Me.lvModul, 0, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.lvPrzedmiot, 0, 0)
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 3)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 1
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(827, 479)
    Me.TableLayoutPanel2.TabIndex = 180
    '
    'lvModul
    '
    Me.lvModul.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lvModul.Location = New System.Drawing.Point(282, 3)
    Me.lvModul.Name = "lvModul"
    Me.lvModul.Size = New System.Drawing.Size(542, 473)
    Me.lvModul.TabIndex = 2
    Me.lvModul.UseCompatibleStateImageBehavior = False
    Me.lvModul.View = System.Windows.Forms.View.Details
    '
    'lvPrzedmiot
    '
    Me.lvPrzedmiot.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lvPrzedmiot.Location = New System.Drawing.Point(3, 3)
    Me.lvPrzedmiot.Name = "lvPrzedmiot"
    Me.lvPrzedmiot.Size = New System.Drawing.Size(273, 473)
    Me.lvPrzedmiot.TabIndex = 1
    Me.lvPrzedmiot.UseCompatibleStateImageBehavior = False
    Me.lvPrzedmiot.View = System.Windows.Forms.View.Details
    '
    'Panel1
    '
    Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel1.Controls.Add(Me.TableLayoutPanel3)
    Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
    Me.Panel1.Location = New System.Drawing.Point(3, 485)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(951, 82)
    Me.Panel1.TabIndex = 181
    '
    'TableLayoutPanel3
    '
    Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel3.ColumnCount = 4
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.354916!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.41727!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.257521!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.20578!))
    Me.TableLayoutPanel3.Controls.Add(Me.Label8, 0, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.lblRecord, 1, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.Label1, 2, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.lblRecord1, 3, 0)
    Me.TableLayoutPanel3.Location = New System.Drawing.Point(8, 0)
    Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
    Me.TableLayoutPanel3.RowCount = 1
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel3.Size = New System.Drawing.Size(831, 25)
    Me.TableLayoutPanel3.TabIndex = 173
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label1.Location = New System.Drawing.Point(290, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(45, 25)
    Me.Label1.TabIndex = 148
    Me.Label1.Text = "Rekord:"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblRecord1
    '
    Me.lblRecord1.AutoSize = True
    Me.lblRecord1.Dock = System.Windows.Forms.DockStyle.Left
    Me.lblRecord1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
    Me.lblRecord1.ForeColor = System.Drawing.Color.Red
    Me.lblRecord1.Location = New System.Drawing.Point(341, 0)
    Me.lblRecord1.Name = "lblRecord1"
    Me.lblRecord1.Size = New System.Drawing.Size(68, 25)
    Me.lblRecord1.TabIndex = 147
    Me.lblRecord1.Text = "lblRecord1"
    Me.lblRecord1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(8, 44)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(939, 28)
    Me.TableLayoutPanel1.TabIndex = 172
    '
    'lblData
    '
    Me.lblData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblData.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lblData.Enabled = False
    Me.lblData.Location = New System.Drawing.Point(706, 0)
    Me.lblData.Name = "lblData"
    Me.lblData.Size = New System.Drawing.Size(230, 28)
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
    Me.lblUser.Size = New System.Drawing.Size(225, 28)
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
    Me.lblIP.Location = New System.Drawing.Point(357, 0)
    Me.lblIP.Name = "lblIP"
    Me.lblIP.Size = New System.Drawing.Size(256, 28)
    Me.lblIP.TabIndex = 165
    Me.lblIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label12.Enabled = False
    Me.Label12.Location = New System.Drawing.Point(314, 0)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(37, 28)
    Me.Label12.TabIndex = 168
    Me.Label12.Text = "Nr IP"
    Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label14.Enabled = False
    Me.Label14.Location = New System.Drawing.Point(619, 0)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(81, 28)
    Me.Label14.TabIndex = 169
    Me.Label14.Text = "Data modyfik."
    Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'TableLayoutPanel4
    '
    Me.TableLayoutPanel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel4.ColumnCount = 6
    Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
    Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.90815!))
    Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.045278!))
    Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.5304!))
    Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.21992!))
    Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.29625!))
    Me.TableLayoutPanel4.Controls.Add(Me.Label2, 5, 0)
    Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
    Me.TableLayoutPanel4.RowCount = 1
    Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel4.Size = New System.Drawing.Size(200, 100)
    Me.TableLayoutPanel4.TabIndex = 0
    '
    'Label2
    '
    Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label2.Enabled = False
    Me.Label2.Location = New System.Drawing.Point(169, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(28, 100)
    Me.Label2.TabIndex = 167
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label3
    '
    Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label3.Enabled = False
    Me.Label3.Location = New System.Drawing.Point(83, 0)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(221, 28)
    Me.Label3.TabIndex = 166
    Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'frmPrzedmiot
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(957, 569)
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.TableLayoutPanel2)
    Me.Controls.Add(Me.cmdClose)
    Me.Controls.Add(Me.cmdEditModul)
    Me.Controls.Add(Me.cmdDeleteModul)
    Me.Controls.Add(Me.cmdAddNewModul)
    Me.Controls.Add(Me.cmdEdit)
    Me.Controls.Add(Me.cmdDelete)
    Me.Controls.Add(Me.cmdAddNew)
    Me.Name = "frmPrzedmiot"
    Me.Text = "Przedmioty nauczania"
    Me.TableLayoutPanel2.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.TableLayoutPanel3.ResumeLayout(False)
    Me.TableLayoutPanel3.PerformLayout()
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    Me.TableLayoutPanel4.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents cmdEdit As System.Windows.Forms.Button
  Friend WithEvents cmdDelete As System.Windows.Forms.Button
  Friend WithEvents cmdAddNew As System.Windows.Forms.Button
  Friend WithEvents cmdEditModul As System.Windows.Forms.Button
  Friend WithEvents cmdDeleteModul As System.Windows.Forms.Button
  Friend WithEvents cmdAddNewModul As System.Windows.Forms.Button
  Friend WithEvents cmdClose As System.Windows.Forms.Button
  Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents lvModul As ListviewWithTooltip.ListViewWithTooltip
  Friend WithEvents lvPrzedmiot As ListviewWithTooltip.ListViewWithTooltip
  Friend WithEvents lblRecord As System.Windows.Forms.Label
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents lblData As System.Windows.Forms.Label
  Friend WithEvents lblUser As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents lblIP As System.Windows.Forms.Label
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents lblRecord1 As System.Windows.Forms.Label
  Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
