Imports System.Xml
Imports System.IO
Public Class ImportStudent
  Public Sub ReadXmlData(ByVal FileName As String)
    Dim xmlDoc As New XmlDocument
    Dim MySQLTrans As MySqlTransaction
    Dim DBA As New DataBaseAction, S As New StudentSQL
    MySQLTrans = GlobalValues.gblConn.BeginTransaction()

    Try
      xmlDoc.Load(FileName)
      Dim Node As XmlNode
      Node = xmlDoc.DocumentElement
      Dim DT As DataTable = DBA.GetDataTable("SELECT CONCAT_WS(' ',Nazwisko,Imie) AS Student,Klasa FROM student;")
      For Each Node In xmlDoc.DocumentElement.ChildNodes()
        SharedImport.ExtendedInfoValue = "Klasa " & Node.Attributes(0).Value
        SharedImport.pbValue = 0
        SharedImport.pbMaxValue = Node.ChildNodes.Count
        SharedImport.pbMaxValueChange()
        SharedImport.InfoValue = "Klasa " & Node.Attributes(0).Value
        SharedImport.RoutineChange()
        Dim cmd As MySqlCommand = DBA.CreateCommand(S.InsertKlasa)
        cmd.Transaction = MySQLTrans
        If DBA.ComputeRecords("SELECT COUNT(KodKlasy) FROM klasa WHERE KodKlasy='" & String.Concat(Node.Attributes(0).Value, 1) & "';") < 1 Then
          cmd.Parameters.AddWithValue("?KodKlasy", String.Concat(Node.Attributes(0).Value, 1))
          cmd.Parameters.AddWithValue("?Nazwa", Node.Attributes(0).Value)
          cmd.Parameters.AddWithValue("?User", GlobalValues.gblUserName)
          cmd.Parameters.AddWithValue("?ComputerIP", GlobalValues.gblIP)
          cmd.ExecuteNonQuery()
        End If
        For Each subNode As XmlNode In Node
          'MessageBox.Show(String.Concat(subNode.Attributes(0).Value, " ", subNode.Attributes(1).Value) & "' AND Klasa='" & String.Concat(Node.Attributes(0).Value, 1) & "'")
          If DT.Select("Student='" & String.Concat(subNode.Attributes(0).Value, " ", subNode.Attributes(1).Value) & "' AND Klasa='" & String.Concat(Node.Attributes(0).Value, 1) & "'").GetLength(0) < 1 Then
            Dim cmdStudent As MySqlCommand = DBA.CreateCommand(S.InsertStudent)
            cmdStudent.Transaction = MySQLTrans
            cmdStudent.Parameters.AddWithValue("?Nazwisko", subNode.Attributes(0).Value)
            cmdStudent.Parameters.AddWithValue("?Imie", subNode.Attributes(1).Value)
            cmdStudent.Parameters.AddWithValue("?Klasa", String.Concat(Node.Attributes(0).Value, 1))
            cmdStudent.Parameters.AddWithValue("?User", GlobalValues.gblUserName)
            cmdStudent.Parameters.AddWithValue("?ComputerIP", GlobalValues.gblIP)
            cmdStudent.ExecuteNonQuery()
            'SharedImport.pbValue += 1
            SharedImport.SuccessValue += 1
            SharedImport.ExtendedInfoValue = String.Concat(subNode.Attributes(0).Value, " ", subNode.Attributes(1).Value, " - zaimportowano")
          Else
            'SharedImport.pbValue += 1
            SharedImport.ExtendedInfoValue = String.Concat(subNode.Attributes(0).Value, " ", subNode.Attributes(1).Value, " - uczeń istnieje w bazie danych")
            SharedImport.ErrorValue += 1
            'SharedImport.RecordForward()
          End If
          SharedImport.pbValue += 1
          SharedImport.RecordForward()
        Next
      Next
      MySQLTrans.Commit()
      If SharedImport.ErrorValue > 0 Then
        MessageBox.Show("Wystąpiły błędy importu." & vbNewLine & "Rekordy odrzucone: " & SharedImport.ErrorValue.ToString)
      Else
        MessageBox.Show("Import zakończony powodzeniem")
      End If
      SharedImport.SuccessValue = 0
      SharedImport.ErrorValue = 0
      SharedImport.TotalValue = 0
      SharedImport.pbValue = 0
      SharedImport.InfoValue = ""
      SharedImport.ExtendedInfoValue = ""
      SharedImport.RoutineChange()
    Catch MySqlex As MySqlException
      MySQLTrans.Rollback()
      MessageBox.Show(MySqlex.Message)
      Exit Sub
    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub
End Class
