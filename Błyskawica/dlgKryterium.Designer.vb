<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgKryterium
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
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.nudMin = New System.Windows.Forms.NumericUpDown
    Me.nudMax = New System.Windows.Forms.NumericUpDown
    Me.txtOcena = New System.Windows.Forms.TextBox
    Me.TableLayoutPanel1.SuspendLayout()
    CType(Me.nudMin, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nudMax, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(143, 69)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
    Me.TableLayoutPanel1.TabIndex = 3
    '
    'OK_Button
    '
    Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.OK_Button.Enabled = False
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
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(150, 14)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(57, 13)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Maksimum"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 14)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(48, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Minimum"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 41)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(39, 13)
    Me.Label3.TabIndex = 3
    Me.Label3.Text = "Ocena"
    '
    'nudMin
    '
    Me.nudMin.DecimalPlaces = 2
    Me.nudMin.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
    Me.nudMin.Location = New System.Drawing.Point(66, 12)
    Me.nudMin.Name = "nudMin"
    Me.nudMin.Size = New System.Drawing.Size(78, 20)
    Me.nudMin.TabIndex = 0
    '
    'nudMax
    '
    Me.nudMax.DecimalPlaces = 2
    Me.nudMax.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
    Me.nudMax.Location = New System.Drawing.Point(213, 12)
    Me.nudMax.Name = "nudMax"
    Me.nudMax.Size = New System.Drawing.Size(78, 20)
    Me.nudMax.TabIndex = 1
    '
    'txtOcena
    '
    Me.txtOcena.Location = New System.Drawing.Point(66, 38)
    Me.txtOcena.Name = "txtOcena"
    Me.txtOcena.Size = New System.Drawing.Size(225, 20)
    Me.txtOcena.TabIndex = 2
    '
    'dlgKryterium
    '
    Me.AcceptButton = Me.OK_Button
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.Cancel_Button
    Me.ClientSize = New System.Drawing.Size(301, 110)
    Me.Controls.Add(Me.txtOcena)
    Me.Controls.Add(Me.nudMax)
    Me.Controls.Add(Me.nudMin)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "dlgKryterium"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Nowe kryterium"
    Me.TableLayoutPanel1.ResumeLayout(False)
    CType(Me.nudMin, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nudMax, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents OK_Button As System.Windows.Forms.Button
  Friend WithEvents Cancel_Button As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents nudMin As System.Windows.Forms.NumericUpDown
  Friend WithEvents nudMax As System.Windows.Forms.NumericUpDown
  Friend WithEvents txtOcena As System.Windows.Forms.TextBox

End Class
