﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudent
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
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
    Me.lvStudent = New ListviewWithTooltip.ListViewWithTooltip
    Me.lvKlasa = New ListviewWithTooltip.ListViewWithTooltip
    Me.cmdEditStudent = New System.Windows.Forms.Button
    Me.cmdDeleteStudent = New System.Windows.Forms.Button
    Me.cmdAddNewStudent = New System.Windows.Forms.Button
    Me.cmdEdit = New System.Windows.Forms.Button
    Me.cmdDelete = New System.Windows.Forms.Button
    Me.cmdAddNew = New System.Windows.Forms.Button
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
    Me.Label8 = New System.Windows.Forms.Label
    Me.lblRecord = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.lblRecord1 = New System.Windows.Forms.Label
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
    Me.lblData = New System.Windows.Forms.Label
    Me.lblUser = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.lblIP = New System.Windows.Forms.Label
    Me.Label12 = New System.Windows.Forms.Label
    Me.Label14 = New System.Windows.Forms.Label
    Me.cmdClose = New System.Windows.Forms.Button
    Me.TableLayoutPanel2.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.TableLayoutPanel3.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel2.ColumnCount = 2
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.77483!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.22516!))
    Me.TableLayoutPanel2.Controls.Add(Me.lvStudent, 0, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.lvKlasa, 0, 0)
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 1
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(515, 479)
    Me.TableLayoutPanel2.TabIndex = 181
    '
    'lvStudent
    '
    Me.lvStudent.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lvStudent.Location = New System.Drawing.Point(176, 3)
    Me.lvStudent.Name = "lvStudent"
    Me.lvStudent.Size = New System.Drawing.Size(336, 473)
    Me.lvStudent.TabIndex = 2
    Me.lvStudent.UseCompatibleStateImageBehavior = False
    Me.lvStudent.View = System.Windows.Forms.View.Details
    '
    'lvKlasa
    '
    Me.lvKlasa.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lvKlasa.Location = New System.Drawing.Point(3, 3)
    Me.lvKlasa.Name = "lvKlasa"
    Me.lvKlasa.Size = New System.Drawing.Size(167, 473)
    Me.lvKlasa.TabIndex = 1
    Me.lvKlasa.UseCompatibleStateImageBehavior = False
    Me.lvKlasa.View = System.Windows.Forms.View.Details
    '
    'cmdEditStudent
    '
    Me.cmdEditStudent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdEditStudent.Enabled = False
    Me.cmdEditStudent.Location = New System.Drawing.Point(524, 181)
    Me.cmdEditStudent.Name = "cmdEditStudent"
    Me.cmdEditStudent.Size = New System.Drawing.Size(100, 23)
    Me.cmdEditStudent.TabIndex = 187
    Me.cmdEditStudent.Text = "&Edytuj ucznia"
    Me.cmdEditStudent.UseVisualStyleBackColor = True
    '
    'cmdDeleteStudent
    '
    Me.cmdDeleteStudent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdDeleteStudent.Enabled = False
    Me.cmdDeleteStudent.Location = New System.Drawing.Point(524, 210)
    Me.cmdDeleteStudent.Name = "cmdDeleteStudent"
    Me.cmdDeleteStudent.Size = New System.Drawing.Size(100, 23)
    Me.cmdDeleteStudent.TabIndex = 186
    Me.cmdDeleteStudent.Text = "&Usuń ucznia"
    Me.cmdDeleteStudent.UseVisualStyleBackColor = True
    '
    'cmdAddNewStudent
    '
    Me.cmdAddNewStudent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdAddNewStudent.Enabled = False
    Me.cmdAddNewStudent.Location = New System.Drawing.Point(524, 152)
    Me.cmdAddNewStudent.Name = "cmdAddNewStudent"
    Me.cmdAddNewStudent.Size = New System.Drawing.Size(100, 23)
    Me.cmdAddNewStudent.TabIndex = 185
    Me.cmdAddNewStudent.Text = "Nowy &uczeń"
    Me.cmdAddNewStudent.UseVisualStyleBackColor = True
    '
    'cmdEdit
    '
    Me.cmdEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdEdit.Enabled = False
    Me.cmdEdit.Location = New System.Drawing.Point(524, 41)
    Me.cmdEdit.Name = "cmdEdit"
    Me.cmdEdit.Size = New System.Drawing.Size(100, 23)
    Me.cmdEdit.TabIndex = 184
    Me.cmdEdit.Text = "&Edytuj grupę"
    Me.cmdEdit.UseVisualStyleBackColor = True
    '
    'cmdDelete
    '
    Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdDelete.Enabled = False
    Me.cmdDelete.Location = New System.Drawing.Point(524, 70)
    Me.cmdDelete.Name = "cmdDelete"
    Me.cmdDelete.Size = New System.Drawing.Size(100, 23)
    Me.cmdDelete.TabIndex = 183
    Me.cmdDelete.Text = "&Usuń grupę"
    Me.cmdDelete.UseVisualStyleBackColor = True
    '
    'cmdAddNew
    '
    Me.cmdAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdAddNew.Location = New System.Drawing.Point(524, 12)
    Me.cmdAddNew.Name = "cmdAddNew"
    Me.cmdAddNew.Size = New System.Drawing.Size(100, 23)
    Me.cmdAddNew.TabIndex = 182
    Me.cmdAddNew.Text = "&Nowa grupa"
    Me.cmdAddNew.UseVisualStyleBackColor = True
    '
    'Panel1
    '
    Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel1.Controls.Add(Me.TableLayoutPanel3)
    Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
    Me.Panel1.Location = New System.Drawing.Point(3, 485)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(621, 82)
    Me.Panel1.TabIndex = 188
    '
    'TableLayoutPanel3
    '
    Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel3.ColumnCount = 4
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.99796!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.79226!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.7943!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.82281!))
    Me.TableLayoutPanel3.Controls.Add(Me.Label8, 0, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.lblRecord, 1, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.Label1, 2, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.lblRecord1, 3, 0)
    Me.TableLayoutPanel3.Location = New System.Drawing.Point(8, 0)
    Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
    Me.TableLayoutPanel3.RowCount = 1
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel3.Size = New System.Drawing.Size(491, 25)
    Me.TableLayoutPanel3.TabIndex = 173
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label8.Location = New System.Drawing.Point(3, 0)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(47, 25)
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
    Me.lblRecord.Location = New System.Drawing.Point(56, 0)
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
    Me.Label1.Location = New System.Drawing.Point(162, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(46, 25)
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
    Me.lblRecord1.Location = New System.Drawing.Point(214, 0)
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
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.578558!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.50832!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.78743!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.878!))
    Me.TableLayoutPanel1.Controls.Add(Me.lblData, 5, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.lblUser, 1, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.lblIP, 3, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Label12, 2, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Label14, 4, 0)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 41)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(621, 28)
    Me.TableLayoutPanel1.TabIndex = 172
    '
    'lblData
    '
    Me.lblData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblData.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lblData.Enabled = False
    Me.lblData.Location = New System.Drawing.Point(483, 0)
    Me.lblData.Name = "lblData"
    Me.lblData.Size = New System.Drawing.Size(135, 28)
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
    Me.lblUser.Size = New System.Drawing.Size(138, 28)
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
    Me.lblIP.Location = New System.Drawing.Point(267, 0)
    Me.lblIP.Name = "lblIP"
    Me.lblIP.Size = New System.Drawing.Size(131, 28)
    Me.lblIP.TabIndex = 165
    Me.lblIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label12.Enabled = False
    Me.Label12.Location = New System.Drawing.Point(227, 0)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(34, 28)
    Me.Label12.TabIndex = 168
    Me.Label12.Text = "Nr IP"
    Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label14.Enabled = False
    Me.Label14.Location = New System.Drawing.Point(404, 0)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(73, 28)
    Me.Label14.TabIndex = 169
    Me.Label14.Text = "Data modyfik."
    Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'cmdClose
    '
    Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdClose.Location = New System.Drawing.Point(524, 456)
    Me.cmdClose.Name = "cmdClose"
    Me.cmdClose.Size = New System.Drawing.Size(100, 23)
    Me.cmdClose.TabIndex = 189
    Me.cmdClose.Text = "&Zamknij"
    Me.cmdClose.UseVisualStyleBackColor = True
    '
    'frmStudent
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(636, 569)
    Me.Controls.Add(Me.cmdClose)
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.cmdEditStudent)
    Me.Controls.Add(Me.cmdDeleteStudent)
    Me.Controls.Add(Me.cmdAddNewStudent)
    Me.Controls.Add(Me.cmdEdit)
    Me.Controls.Add(Me.cmdDelete)
    Me.Controls.Add(Me.cmdAddNew)
    Me.Controls.Add(Me.TableLayoutPanel2)
    Me.Name = "frmStudent"
    Me.Text = "Uczniowie"
    Me.TableLayoutPanel2.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.TableLayoutPanel3.ResumeLayout(False)
    Me.TableLayoutPanel3.PerformLayout()
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents lvStudent As ListviewWithTooltip.ListViewWithTooltip
  Friend WithEvents lvKlasa As ListviewWithTooltip.ListViewWithTooltip
  Friend WithEvents cmdEditStudent As System.Windows.Forms.Button
  Friend WithEvents cmdDeleteStudent As System.Windows.Forms.Button
  Friend WithEvents cmdAddNewStudent As System.Windows.Forms.Button
  Friend WithEvents cmdEdit As System.Windows.Forms.Button
  Friend WithEvents cmdDelete As System.Windows.Forms.Button
  Friend WithEvents cmdAddNew As System.Windows.Forms.Button
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents lblRecord As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents lblRecord1 As System.Windows.Forms.Label
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents lblData As System.Windows.Forms.Label
  Friend WithEvents lblUser As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents lblIP As System.Windows.Forms.Label
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents cmdClose As System.Windows.Forms.Button
End Class
