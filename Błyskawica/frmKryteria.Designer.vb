<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKryteria
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
    Me.lvNazwaKryterium = New ListviewWithTooltip.ListViewWithTooltip
    Me.cmdAddNew = New System.Windows.Forms.Button
    Me.cmdDelete = New System.Windows.Forms.Button
    Me.cmdEdit = New System.Windows.Forms.Button
    Me.cmdClose = New System.Windows.Forms.Button
    Me.lvKryterium = New ListviewWithTooltip.ListViewWithTooltip
    Me.lblRecord = New System.Windows.Forms.Label
    Me.Label8 = New System.Windows.Forms.Label
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.Panel2 = New System.Windows.Forms.Panel
    Me.Label14 = New System.Windows.Forms.Label
    Me.Label12 = New System.Windows.Forms.Label
    Me.lblData = New System.Windows.Forms.Label
    Me.lblIP = New System.Windows.Forms.Label
    Me.lblUser = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.Panel3 = New System.Windows.Forms.Panel
    Me.Label1 = New System.Windows.Forms.Label
    Me.lblRecord1 = New System.Windows.Forms.Label
    Me.cmdEditDetail = New System.Windows.Forms.Button
    Me.cmdDeleteDetail = New System.Windows.Forms.Button
    Me.cmdNewDetail = New System.Windows.Forms.Button
    Me.Panel1.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.Panel3.SuspendLayout()
    Me.SuspendLayout()
    '
    'lvNazwaKryterium
    '
    Me.lvNazwaKryterium.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lvNazwaKryterium.Location = New System.Drawing.Point(12, 12)
    Me.lvNazwaKryterium.Name = "lvNazwaKryterium"
    Me.lvNazwaKryterium.Size = New System.Drawing.Size(425, 108)
    Me.lvNazwaKryterium.TabIndex = 42
    Me.lvNazwaKryterium.UseCompatibleStateImageBehavior = False
    Me.lvNazwaKryterium.View = System.Windows.Forms.View.Details
    '
    'cmdAddNew
    '
    Me.cmdAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdAddNew.Location = New System.Drawing.Point(443, 12)
    Me.cmdAddNew.Name = "cmdAddNew"
    Me.cmdAddNew.Size = New System.Drawing.Size(100, 23)
    Me.cmdAddNew.TabIndex = 46
    Me.cmdAddNew.Text = "&Nowy zestaw"
    Me.cmdAddNew.UseVisualStyleBackColor = True
    '
    'cmdDelete
    '
    Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdDelete.Enabled = False
    Me.cmdDelete.Location = New System.Drawing.Point(443, 70)
    Me.cmdDelete.Name = "cmdDelete"
    Me.cmdDelete.Size = New System.Drawing.Size(100, 23)
    Me.cmdDelete.TabIndex = 47
    Me.cmdDelete.Text = "&Usuń zestaw"
    Me.cmdDelete.UseVisualStyleBackColor = True
    '
    'cmdEdit
    '
    Me.cmdEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdEdit.Enabled = False
    Me.cmdEdit.Location = New System.Drawing.Point(443, 41)
    Me.cmdEdit.Name = "cmdEdit"
    Me.cmdEdit.Size = New System.Drawing.Size(100, 23)
    Me.cmdEdit.TabIndex = 48
    Me.cmdEdit.Text = "&Edytuj zestaw"
    Me.cmdEdit.UseVisualStyleBackColor = True
    '
    'cmdClose
    '
    Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdClose.Location = New System.Drawing.Point(443, 389)
    Me.cmdClose.Name = "cmdClose"
    Me.cmdClose.Size = New System.Drawing.Size(100, 23)
    Me.cmdClose.TabIndex = 49
    Me.cmdClose.Text = "&Zamknij"
    Me.cmdClose.UseVisualStyleBackColor = True
    '
    'lvKryterium
    '
    Me.lvKryterium.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lvKryterium.Location = New System.Drawing.Point(12, 150)
    Me.lvKryterium.Name = "lvKryterium"
    Me.lvKryterium.Size = New System.Drawing.Size(425, 262)
    Me.lvKryterium.TabIndex = 50
    Me.lvKryterium.UseCompatibleStateImageBehavior = False
    Me.lvKryterium.View = System.Windows.Forms.View.Details
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
    'Panel1
    '
    Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel1.Controls.Add(Me.Label8)
    Me.Panel1.Controls.Add(Me.lblRecord)
    Me.Panel1.Location = New System.Drawing.Point(12, 122)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(531, 26)
    Me.Panel1.TabIndex = 43
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
    Me.Panel2.Location = New System.Drawing.Point(12, 443)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(530, 60)
    Me.Panel2.TabIndex = 51
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Enabled = False
    Me.Label14.Location = New System.Drawing.Point(5, 37)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(72, 13)
    Me.Label14.TabIndex = 169
    Me.Label14.Text = "Data modyfik."
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Enabled = False
    Me.Label12.Location = New System.Drawing.Point(272, 6)
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
    Me.lblData.Location = New System.Drawing.Point(83, 32)
    Me.lblData.Name = "lblData"
    Me.lblData.Size = New System.Drawing.Size(183, 23)
    Me.lblData.TabIndex = 167
    Me.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblIP
    '
    Me.lblIP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblIP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblIP.Enabled = False
    Me.lblIP.Location = New System.Drawing.Point(309, 1)
    Me.lblIP.Name = "lblIP"
    Me.lblIP.Size = New System.Drawing.Size(218, 23)
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
    Me.lblUser.Size = New System.Drawing.Size(183, 23)
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
    'Panel3
    '
    Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3.Controls.Add(Me.Label1)
    Me.Panel3.Controls.Add(Me.lblRecord1)
    Me.Panel3.Location = New System.Drawing.Point(12, 414)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(531, 26)
    Me.Panel3.TabIndex = 52
    '
    'Label1
    '
    Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(3, 6)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(45, 13)
    Me.Label1.TabIndex = 145
    Me.Label1.Text = "Rekord:"
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
    'cmdEditDetail
    '
    Me.cmdEditDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdEditDetail.Enabled = False
    Me.cmdEditDetail.Location = New System.Drawing.Point(443, 179)
    Me.cmdEditDetail.Name = "cmdEditDetail"
    Me.cmdEditDetail.Size = New System.Drawing.Size(100, 23)
    Me.cmdEditDetail.TabIndex = 55
    Me.cmdEditDetail.Text = "Edytuj składnik"
    Me.cmdEditDetail.UseVisualStyleBackColor = True
    '
    'cmdDeleteDetail
    '
    Me.cmdDeleteDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdDeleteDetail.Enabled = False
    Me.cmdDeleteDetail.Location = New System.Drawing.Point(443, 208)
    Me.cmdDeleteDetail.Name = "cmdDeleteDetail"
    Me.cmdDeleteDetail.Size = New System.Drawing.Size(100, 23)
    Me.cmdDeleteDetail.TabIndex = 54
    Me.cmdDeleteDetail.Text = "Usuń składnik"
    Me.cmdDeleteDetail.UseVisualStyleBackColor = True
    '
    'cmdNewDetail
    '
    Me.cmdNewDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdNewDetail.Enabled = False
    Me.cmdNewDetail.Location = New System.Drawing.Point(443, 150)
    Me.cmdNewDetail.Name = "cmdNewDetail"
    Me.cmdNewDetail.Size = New System.Drawing.Size(100, 23)
    Me.cmdNewDetail.TabIndex = 53
    Me.cmdNewDetail.Text = "Dodaj składnik"
    Me.cmdNewDetail.UseVisualStyleBackColor = True
    '
    'frmKryteria
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(555, 511)
    Me.Controls.Add(Me.cmdEditDetail)
    Me.Controls.Add(Me.cmdDeleteDetail)
    Me.Controls.Add(Me.cmdNewDetail)
    Me.Controls.Add(Me.Panel3)
    Me.Controls.Add(Me.Panel2)
    Me.Controls.Add(Me.lvKryterium)
    Me.Controls.Add(Me.cmdClose)
    Me.Controls.Add(Me.cmdEdit)
    Me.Controls.Add(Me.cmdDelete)
    Me.Controls.Add(Me.cmdAddNew)
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.lvNazwaKryterium)
    Me.Name = "frmKryteria"
    Me.Text = "Kryteria ocen"
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.Panel3.ResumeLayout(False)
    Me.Panel3.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents lvNazwaKryterium As ListviewWithTooltip.ListViewWithTooltip
  Friend WithEvents cmdAddNew As System.Windows.Forms.Button
  Friend WithEvents cmdDelete As System.Windows.Forms.Button
  Friend WithEvents cmdEdit As System.Windows.Forms.Button
  Friend WithEvents cmdClose As System.Windows.Forms.Button
  Friend WithEvents lvKryterium As ListviewWithTooltip.ListViewWithTooltip
  Friend WithEvents lblRecord As System.Windows.Forms.Label
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents lblData As System.Windows.Forms.Label
  Friend WithEvents lblIP As System.Windows.Forms.Label
  Friend WithEvents lblUser As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Panel3 As System.Windows.Forms.Panel
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents lblRecord1 As System.Windows.Forms.Label
  Friend WithEvents cmdEditDetail As System.Windows.Forms.Button
  Friend WithEvents cmdDeleteDetail As System.Windows.Forms.Button
  Friend WithEvents cmdNewDetail As System.Windows.Forms.Button
End Class
