<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAnswersByQuestion
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
    Me.lvOdp = New ListviewWithTooltip.ListViewWithTooltip
    Me.cmdEditOdp = New System.Windows.Forms.Button
    Me.cmdDeleteOdp = New System.Windows.Forms.Button
    Me.cmdAddOdp = New System.Windows.Forms.Button
    Me.Panel2 = New System.Windows.Forms.Panel
    Me.Label3 = New System.Windows.Forms.Label
    Me.lblRecord = New System.Windows.Forms.Label
    Me.txtQuestion = New System.Windows.Forms.TextBox
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
    Me.lblData = New System.Windows.Forms.Label
    Me.lblUser = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.lblIP = New System.Windows.Forms.Label
    Me.Label12 = New System.Windows.Forms.Label
    Me.Label14 = New System.Windows.Forms.Label
    Me.TableLayoutPanel1.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.TableLayoutPanel2.SuspendLayout()
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
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(801, 392)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'OK_Button
    '
    Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.OK_Button.Location = New System.Drawing.Point(3, 3)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(67, 23)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "OK"
    '
    'Cancel_Button
    '
    Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
    Me.Cancel_Button.Name = "Cancel_Button"
    Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
    Me.Cancel_Button.TabIndex = 1
    Me.Cancel_Button.Text = "Anuluj"
    '
    'lvOdp
    '
    Me.lvOdp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lvOdp.Location = New System.Drawing.Point(12, 89)
    Me.lvOdp.Name = "lvOdp"
    Me.lvOdp.Size = New System.Drawing.Size(854, 232)
    Me.lvOdp.TabIndex = 44
    Me.lvOdp.UseCompatibleStateImageBehavior = False
    Me.lvOdp.View = System.Windows.Forms.View.Details
    '
    'cmdEditOdp
    '
    Me.cmdEditOdp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdEditOdp.Enabled = False
    Me.cmdEditOdp.Location = New System.Drawing.Point(872, 118)
    Me.cmdEditOdp.Name = "cmdEditOdp"
    Me.cmdEditOdp.Size = New System.Drawing.Size(75, 23)
    Me.cmdEditOdp.TabIndex = 49
    Me.cmdEditOdp.Text = "&Edytuj"
    Me.cmdEditOdp.UseVisualStyleBackColor = True
    '
    'cmdDeleteOdp
    '
    Me.cmdDeleteOdp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdDeleteOdp.Enabled = False
    Me.cmdDeleteOdp.Location = New System.Drawing.Point(872, 147)
    Me.cmdDeleteOdp.Name = "cmdDeleteOdp"
    Me.cmdDeleteOdp.Size = New System.Drawing.Size(75, 23)
    Me.cmdDeleteOdp.TabIndex = 48
    Me.cmdDeleteOdp.Text = "&Usuń"
    Me.cmdDeleteOdp.UseVisualStyleBackColor = True
    '
    'cmdAddOdp
    '
    Me.cmdAddOdp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdAddOdp.Location = New System.Drawing.Point(872, 89)
    Me.cmdAddOdp.Name = "cmdAddOdp"
    Me.cmdAddOdp.Size = New System.Drawing.Size(75, 23)
    Me.cmdAddOdp.TabIndex = 47
    Me.cmdAddOdp.Text = "&Dodaj"
    Me.cmdAddOdp.UseVisualStyleBackColor = True
    '
    'Panel2
    '
    Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel2.Controls.Add(Me.Label3)
    Me.Panel2.Controls.Add(Me.lblRecord)
    Me.Panel2.Location = New System.Drawing.Point(12, 324)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(933, 30)
    Me.Panel2.TabIndex = 149
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
    'lblRecord
    '
    Me.lblRecord.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblRecord.AutoSize = True
    Me.lblRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
    Me.lblRecord.ForeColor = System.Drawing.Color.Red
    Me.lblRecord.Location = New System.Drawing.Point(54, 7)
    Me.lblRecord.Name = "lblRecord"
    Me.lblRecord.Size = New System.Drawing.Size(61, 13)
    Me.lblRecord.TabIndex = 146
    Me.lblRecord.Text = "lblRecord"
    '
    'txtQuestion
    '
    Me.txtQuestion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtQuestion.Enabled = False
    Me.txtQuestion.Location = New System.Drawing.Point(12, 12)
    Me.txtQuestion.Multiline = True
    Me.txtQuestion.Name = "txtQuestion"
    Me.txtQuestion.ReadOnly = True
    Me.txtQuestion.Size = New System.Drawing.Size(935, 71)
    Me.txtQuestion.TabIndex = 2
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel2.ColumnCount = 6
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.90815!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.045278!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.5304!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.21992!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.29625!))
    Me.TableLayoutPanel2.Controls.Add(Me.lblData, 5, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.lblUser, 1, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.lblIP, 3, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.Label12, 2, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.Label14, 4, 0)
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 358)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 1
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(935, 28)
    Me.TableLayoutPanel2.TabIndex = 171
    '
    'lblData
    '
    Me.lblData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblData.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lblData.Enabled = False
    Me.lblData.Location = New System.Drawing.Point(704, 0)
    Me.lblData.Name = "lblData"
    Me.lblData.Size = New System.Drawing.Size(228, 28)
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
    Me.lblUser.Size = New System.Drawing.Size(224, 28)
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
    Me.lblIP.Location = New System.Drawing.Point(356, 0)
    Me.lblIP.Name = "lblIP"
    Me.lblIP.Size = New System.Drawing.Size(255, 28)
    Me.lblIP.TabIndex = 165
    Me.lblIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label12.Enabled = False
    Me.Label12.Location = New System.Drawing.Point(313, 0)
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
    Me.Label14.Location = New System.Drawing.Point(617, 0)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(81, 28)
    Me.Label14.TabIndex = 169
    Me.Label14.Text = "Data modyfik."
    Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'dlgAnswersByQuestion
    '
    Me.AcceptButton = Me.OK_Button
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.Cancel_Button
    Me.ClientSize = New System.Drawing.Size(959, 433)
    Me.Controls.Add(Me.TableLayoutPanel2)
    Me.Controls.Add(Me.Panel2)
    Me.Controls.Add(Me.cmdEditOdp)
    Me.Controls.Add(Me.txtQuestion)
    Me.Controls.Add(Me.cmdDeleteOdp)
    Me.Controls.Add(Me.cmdAddOdp)
    Me.Controls.Add(Me.lvOdp)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MinimizeBox = False
    Me.Name = "dlgAnswersByQuestion"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Odpowiedzi"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.TableLayoutPanel2.ResumeLayout(False)
    Me.TableLayoutPanel2.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents OK_Button As System.Windows.Forms.Button
  Friend WithEvents Cancel_Button As System.Windows.Forms.Button
  Friend WithEvents lvOdp As ListviewWithTooltip.ListViewWithTooltip
  Friend WithEvents cmdEditOdp As System.Windows.Forms.Button
  Friend WithEvents cmdDeleteOdp As System.Windows.Forms.Button
  Friend WithEvents cmdAddOdp As System.Windows.Forms.Button
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents lblRecord As System.Windows.Forms.Label
  Friend WithEvents txtQuestion As System.Windows.Forms.TextBox
  Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents lblData As System.Windows.Forms.Label
  Friend WithEvents lblUser As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents lblIP As System.Windows.Forms.Label
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents Label14 As System.Windows.Forms.Label

End Class
