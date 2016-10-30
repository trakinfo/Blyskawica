Imports System.Windows.Forms

Public Class dlgImportStudent

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    'Me.DialogResult = System.Windows.Forms.DialogResult.OK
    'Me.Close()
    'Me.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.OK_Button.Enabled = False
    Me.Cancel_Button.Enabled = False
    Me.cmdFileDialog.Enabled = False
    Me.ControlBox = False
    Me.txtDetails.Text = ""
    Dim I As New ImportStudent
    I.ReadXmlData(txtFile.Text)
    Me.OK_Button.Enabled = True
    Me.Cancel_Button.Enabled = True
    Me.cmdFileDialog.Enabled = True
    Me.ControlBox = True
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

  Private Sub dlgImportStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    AddHandler SharedImport.OnRecordForward, AddressOf RefreshMe
    AddHandler SharedImport.OnpbMaxValueChange, AddressOf pbMaxValue_Change
    AddHandler SharedImport.OnRoutineChange, AddressOf GetInfo
    'AddHandler SharedExport.OnDetailedRoutineChange, AddressOf GetExtendedInfo
    lblTotal.Text = ""
    RefreshMe()
    pbMaxValue_Change()
  End Sub
  Private Sub RefreshMe()
    Me.pbExport.Value = SharedImport.pbValue
    Me.lblSuccess.Text = SharedImport.SuccessValue.ToString
    Me.lblError.Text = SharedImport.ErrorValue.ToString
    GetExtendedInfo()
    Me.Refresh()
  End Sub
  Private Sub pbMaxValue_Change()
    pbExport.Value = 0
    Me.pbExport.Maximum = SharedImport.pbMaxValue
    lblInfo.Text = SharedImport.InfoValue
    'lblTotal.Text = SharedImport.TotalValue.ToString
  End Sub
  Private Sub GetInfo()
    lblInfo.Text = SharedImport.InfoValue
    'txtDetails.Text += SharedExport.InfoValue & vbNewLine
    GetExtendedInfo()
  End Sub
  Private Sub GetExtendedInfo()
    'lblInfo.Text = SharedExport.InfoValue
    txtDetails.Text += SharedImport.ExtendedInfoValue & vbNewLine
  End Sub

  Private Sub cmdFileDialog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFileDialog.Click
    Dim dlgOpen As New OpenFileDialog
    With dlgOpen
      .InitialDirectory = Application.StartupPath
      .Multiselect = False
      .Filter = "Wszystkie pliki (*.*)|*.*|Pliki xml (*.xml)|*.xml"
      If .ShowDialog() = Windows.Forms.DialogResult.OK Then
        Me.txtFile.Text = .FileName
        Dim xmlDoc As New System.Xml.XmlDocument
        xmlDoc.Load(txtFile.Text)
        'Dim TotalNumber As Integer = 0
        SharedImport.TotalValue = 0
        For Each Node As System.Xml.XmlNode In xmlDoc.DocumentElement.ChildNodes
          SharedImport.TotalValue += Node.ChildNodes.Count
        Next
        lblTotal.Text = SharedImport.TotalValue.ToString
      End If
    End With
  End Sub

  Private Sub txtFile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFile.TextChanged
    Me.OK_Button.Enabled = CType(IIf(txtFile.Text.Length > 0, True, False), Boolean)
  End Sub
End Class
