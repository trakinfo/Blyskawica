<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWyniki
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
    Me.Label1 = New System.Windows.Forms.Label
    Me.cbTest = New System.Windows.Forms.ComboBox
    Me.lvStudent = New System.Windows.Forms.ListView
    Me.lvWersja = New ListviewWithTooltip.ListViewWithTooltip
    Me.tvOdp = New System.Windows.Forms.TreeView
    Me.cbGrupa = New System.Windows.Forms.ComboBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.cmdClose = New System.Windows.Forms.Button
    Me.cmdPrint = New System.Windows.Forms.Button
    Me.Panel2 = New System.Windows.Forms.Panel
    Me.Label14 = New System.Windows.Forms.Label
    Me.Label12 = New System.Windows.Forms.Label
    Me.lblData = New System.Windows.Forms.Label
    Me.lblIP = New System.Windows.Forms.Label
    Me.lblUser = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.cbPrzedmiot = New System.Windows.Forms.ComboBox
    Me.Label4 = New System.Windows.Forms.Label
    Me.cmdDelete = New System.Windows.Forms.Button
    Me.Panel2.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(459, 15)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(28, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Test"
    '
    'cbTest
    '
    Me.cbTest.DropDownHeight = 350
    Me.cbTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbTest.Enabled = False
    Me.cbTest.FormattingEnabled = True
    Me.cbTest.IntegralHeight = False
    Me.cbTest.Location = New System.Drawing.Point(493, 12)
    Me.cbTest.Name = "cbTest"
    Me.cbTest.Size = New System.Drawing.Size(452, 21)
    Me.cbTest.TabIndex = 41
    '
    'lvStudent
    '
    Me.lvStudent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lvStudent.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
    Me.lvStudent.HideSelection = False
    Me.lvStudent.Location = New System.Drawing.Point(12, 39)
    Me.lvStudent.MultiSelect = False
    Me.lvStudent.Name = "lvStudent"
    Me.lvStudent.Size = New System.Drawing.Size(160, 489)
    Me.lvStudent.TabIndex = 42
    Me.lvStudent.UseCompatibleStateImageBehavior = False
    '
    'lvWersja
    '
    Me.lvWersja.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lvWersja.Enabled = False
    Me.lvWersja.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
    Me.lvWersja.HideSelection = False
    Me.lvWersja.Location = New System.Drawing.Point(178, 39)
    Me.lvWersja.MultiSelect = False
    Me.lvWersja.Name = "lvWersja"
    Me.lvWersja.Size = New System.Drawing.Size(686, 122)
    Me.lvWersja.TabIndex = 43
    Me.lvWersja.UseCompatibleStateImageBehavior = False
    Me.lvWersja.View = System.Windows.Forms.View.Details
    '
    'tvOdp
    '
    Me.tvOdp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.tvOdp.Enabled = False
    Me.tvOdp.FullRowSelect = True
    Me.tvOdp.Location = New System.Drawing.Point(178, 167)
    Me.tvOdp.Name = "tvOdp"
    Me.tvOdp.Size = New System.Drawing.Size(686, 361)
    Me.tvOdp.TabIndex = 44
    '
    'cbGrupa
    '
    Me.cbGrupa.DropDownHeight = 350
    Me.cbGrupa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbGrupa.FormattingEnabled = True
    Me.cbGrupa.IntegralHeight = False
    Me.cbGrupa.Location = New System.Drawing.Point(51, 12)
    Me.cbGrupa.Name = "cbGrupa"
    Me.cbGrupa.Size = New System.Drawing.Size(84, 21)
    Me.cbGrupa.TabIndex = 45
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(9, 15)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(36, 13)
    Me.Label2.TabIndex = 46
    Me.Label2.Text = "Grupa"
    '
    'cmdClose
    '
    Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdClose.Location = New System.Drawing.Point(870, 505)
    Me.cmdClose.Name = "cmdClose"
    Me.cmdClose.Size = New System.Drawing.Size(75, 23)
    Me.cmdClose.TabIndex = 47
    Me.cmdClose.Text = "&Zamknij"
    Me.cmdClose.UseVisualStyleBackColor = True
    '
    'cmdPrint
    '
    Me.cmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdPrint.Enabled = False
    Me.cmdPrint.Location = New System.Drawing.Point(870, 39)
    Me.cmdPrint.Name = "cmdPrint"
    Me.cmdPrint.Size = New System.Drawing.Size(75, 23)
    Me.cmdPrint.TabIndex = 48
    Me.cmdPrint.Text = "Drukuj"
    Me.cmdPrint.UseVisualStyleBackColor = True
    '
    'Panel2
    '
    Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.Panel2.Controls.Add(Me.Label14)
    Me.Panel2.Controls.Add(Me.Label12)
    Me.Panel2.Controls.Add(Me.lblData)
    Me.Panel2.Controls.Add(Me.lblIP)
    Me.Panel2.Controls.Add(Me.lblUser)
    Me.Panel2.Controls.Add(Me.Label3)
    Me.Panel2.Location = New System.Drawing.Point(12, 534)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(933, 28)
    Me.Panel2.TabIndex = 49
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
    Me.lblData.Size = New System.Drawing.Size(254, 23)
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
    'cbPrzedmiot
    '
    Me.cbPrzedmiot.DropDownHeight = 350
    Me.cbPrzedmiot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbPrzedmiot.Enabled = False
    Me.cbPrzedmiot.FormattingEnabled = True
    Me.cbPrzedmiot.IntegralHeight = False
    Me.cbPrzedmiot.Location = New System.Drawing.Point(200, 12)
    Me.cbPrzedmiot.Name = "cbPrzedmiot"
    Me.cbPrzedmiot.Size = New System.Drawing.Size(253, 21)
    Me.cbPrzedmiot.TabIndex = 50
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(141, 15)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(53, 13)
    Me.Label4.TabIndex = 51
    Me.Label4.Text = "Przedmiot"
    '
    'cmdDelete
    '
    Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdDelete.Enabled = False
    Me.cmdDelete.Location = New System.Drawing.Point(870, 68)
    Me.cmdDelete.Name = "cmdDelete"
    Me.cmdDelete.Size = New System.Drawing.Size(75, 23)
    Me.cmdDelete.TabIndex = 52
    Me.cmdDelete.Text = "Usuń"
    Me.cmdDelete.UseVisualStyleBackColor = True
    '
    'frmWyniki
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(957, 569)
    Me.Controls.Add(Me.cmdDelete)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.cbPrzedmiot)
    Me.Controls.Add(Me.Panel2)
    Me.Controls.Add(Me.cmdPrint)
    Me.Controls.Add(Me.cmdClose)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.cbGrupa)
    Me.Controls.Add(Me.tvOdp)
    Me.Controls.Add(Me.lvWersja)
    Me.Controls.Add(Me.lvStudent)
    Me.Controls.Add(Me.cbTest)
    Me.Controls.Add(Me.Label1)
    Me.Name = "frmWyniki"
    Me.ShowIcon = False
    Me.Text = "Rejestr wyników"
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cbTest As System.Windows.Forms.ComboBox
  Friend WithEvents lvStudent As System.Windows.Forms.ListView
  Friend WithEvents lvWersja As ListviewWithTooltip.ListViewWithTooltip
  Friend WithEvents tvOdp As System.Windows.Forms.TreeView
  Friend WithEvents cbGrupa As System.Windows.Forms.ComboBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents cmdClose As System.Windows.Forms.Button
  Friend WithEvents cmdPrint As System.Windows.Forms.Button
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents lblData As System.Windows.Forms.Label
  Friend WithEvents lblIP As System.Windows.Forms.Label
  Friend WithEvents lblUser As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents cbPrzedmiot As System.Windows.Forms.ComboBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents cmdDelete As System.Windows.Forms.Button
End Class
