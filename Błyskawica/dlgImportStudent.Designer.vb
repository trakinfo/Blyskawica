<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgImportStudent
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
    Me.lblInfo = New System.Windows.Forms.Label
    Me.lblError = New System.Windows.Forms.Label
    Me.lblSuccess = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.lblTotal = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.pbExport = New System.Windows.Forms.ProgressBar
    Me.txtDetails = New System.Windows.Forms.TextBox
    Me.Label6 = New System.Windows.Forms.Label
    Me.cmdFileDialog = New System.Windows.Forms.Button
    Me.txtFile = New System.Windows.Forms.TextBox
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
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(351, 416)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'OK_Button
    '
    Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.OK_Button.Enabled = False
    Me.OK_Button.Location = New System.Drawing.Point(3, 3)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(67, 23)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "&Importuj"
    '
    'Cancel_Button
    '
    Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
    Me.Cancel_Button.Name = "Cancel_Button"
    Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
    Me.Cancel_Button.TabIndex = 1
    Me.Cancel_Button.Text = "&Zamknij"
    '
    'lblInfo
    '
    Me.lblInfo.AutoSize = True
    Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(238, Byte))
    Me.lblInfo.ForeColor = System.Drawing.Color.DimGray
    Me.lblInfo.Location = New System.Drawing.Point(9, 93)
    Me.lblInfo.Name = "lblInfo"
    Me.lblInfo.Size = New System.Drawing.Size(42, 13)
    Me.lblInfo.TabIndex = 74
    Me.lblInfo.Text = "lblInfo"
    '
    'lblError
    '
    Me.lblError.AutoSize = True
    Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
    Me.lblError.ForeColor = System.Drawing.Color.Red
    Me.lblError.Location = New System.Drawing.Point(263, 156)
    Me.lblError.Name = "lblError"
    Me.lblError.Size = New System.Drawing.Size(47, 13)
    Me.lblError.TabIndex = 73
    Me.lblError.Text = "lblError"
    '
    'lblSuccess
    '
    Me.lblSuccess.AutoSize = True
    Me.lblSuccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
    Me.lblSuccess.ForeColor = System.Drawing.Color.Green
    Me.lblSuccess.Location = New System.Drawing.Point(105, 156)
    Me.lblSuccess.Name = "lblSuccess"
    Me.lblSuccess.Size = New System.Drawing.Size(68, 13)
    Me.lblSuccess.TabIndex = 72
    Me.lblSuccess.Text = "lblSuccess"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(210, 156)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(47, 13)
    Me.Label4.TabIndex = 71
    Me.Label4.Text = "Błędów:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(9, 156)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(80, 13)
    Me.Label3.TabIndex = 70
    Me.Label3.Text = "Zaimportowano"
    '
    'lblTotal
    '
    Me.lblTotal.AutoSize = True
    Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
    Me.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaption
    Me.lblTotal.Location = New System.Drawing.Point(160, 59)
    Me.lblTotal.Name = "lblTotal"
    Me.lblTotal.Size = New System.Drawing.Size(49, 13)
    Me.lblTotal.TabIndex = 69
    Me.lblTotal.Text = "lblTotal"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
    Me.Label2.Location = New System.Drawing.Point(12, 59)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(142, 13)
    Me.Label2.TabIndex = 68
    Me.Label2.Text = "Rekordów do przetworzenia:"
    '
    'pbExport
    '
    Me.pbExport.Location = New System.Drawing.Point(12, 118)
    Me.pbExport.Name = "pbExport"
    Me.pbExport.Size = New System.Drawing.Size(482, 23)
    Me.pbExport.Step = 1
    Me.pbExport.Style = System.Windows.Forms.ProgressBarStyle.Continuous
    Me.pbExport.TabIndex = 67
    '
    'txtDetails
    '
    Me.txtDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtDetails.Location = New System.Drawing.Point(12, 186)
    Me.txtDetails.Multiline = True
    Me.txtDetails.Name = "txtDetails"
    Me.txtDetails.ReadOnly = True
    Me.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.txtDetails.Size = New System.Drawing.Size(482, 224)
    Me.txtDetails.TabIndex = 66
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(12, 15)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(24, 13)
    Me.Label6.TabIndex = 77
    Me.Label6.Text = "Plik"
    '
    'cmdFileDialog
    '
    Me.cmdFileDialog.Location = New System.Drawing.Point(463, 10)
    Me.cmdFileDialog.Name = "cmdFileDialog"
    Me.cmdFileDialog.Size = New System.Drawing.Size(31, 23)
    Me.cmdFileDialog.TabIndex = 76
    Me.cmdFileDialog.Text = "..."
    Me.cmdFileDialog.UseVisualStyleBackColor = True
    '
    'txtFile
    '
    Me.txtFile.Enabled = False
    Me.txtFile.Location = New System.Drawing.Point(42, 12)
    Me.txtFile.Name = "txtFile"
    Me.txtFile.Size = New System.Drawing.Size(415, 20)
    Me.txtFile.TabIndex = 75
    '
    'dlgImportStudent
    '
    Me.AcceptButton = Me.OK_Button
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.Cancel_Button
    Me.ClientSize = New System.Drawing.Size(509, 457)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.cmdFileDialog)
    Me.Controls.Add(Me.txtFile)
    Me.Controls.Add(Me.lblInfo)
    Me.Controls.Add(Me.lblError)
    Me.Controls.Add(Me.lblSuccess)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.lblTotal)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.pbExport)
    Me.Controls.Add(Me.txtDetails)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "dlgImportStudent"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Import danych uczniów"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
  Friend WithEvents Cancel_Button As System.Windows.Forms.Button
  Friend WithEvents lblInfo As System.Windows.Forms.Label
  Friend WithEvents lblError As System.Windows.Forms.Label
  Friend WithEvents lblSuccess As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents lblTotal As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents pbExport As System.Windows.Forms.ProgressBar
  Friend WithEvents txtDetails As System.Windows.Forms.TextBox
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents cmdFileDialog As System.Windows.Forms.Button
  Friend WithEvents txtFile As System.Windows.Forms.TextBox

End Class
