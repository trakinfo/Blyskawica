
Public Class GlobalValues
  Public Enum Role
    Administrator = 4
    Edytor = 2
    Student = 1
  End Enum
  Public Enum Status
    Aktywny = 1
    Nieaktywny = 0
  End Enum
  Public Enum Privilege
    Edytor = 1
    Owner = 2
  End Enum
  Public Enum TypTestu
    Wielokrotny = 1
    Jednokrotny = 0
  End Enum
  Public Enum TestAccess
    prywatny = 1
    publiczny = 0
  End Enum

  Public Shared gblConn As MySqlConnection = Nothing
  Public Shared gblUserName, gblIP, gblHostName As String, gblUserID As Integer ', gblAdmin As Boolean, 
  Public Shared gblRole As Role
  Public Shared gblAppIcon As New System.Drawing.Icon(Application.StartupPath & "\piorun.ico")

End Class


Public Class SharedImport
  Public Shared pbValue, pbMaxValue, SuccessValue, ErrorValue, TotalValue As Integer, InfoValue, ExtendedInfoValue As String
  Public Shared Event OnRecordForward()
  Public Shared Event OnpbMaxValueChange()
  Public Shared Event OnRoutineChange()
  Shared Sub RoutineChange()
    RaiseEvent OnRoutineChange()
  End Sub
  Shared Sub pbMaxValueChange()
    RaiseEvent OnpbMaxValueChange()
  End Sub
  Shared Sub RecordForward()
    RaiseEvent OnRecordForward()
  End Sub
End Class


Public Class SharedExport
  Public Shared pbValue, pbMaxValue, SuccessValue, ErrorValue, TotalValue As Integer, InfoValue, ExtendedInfoValue As String
  Public Shared Event OnRecordForward()
  Public Shared Event OnpbMaxValueChange()
  Public Shared Event OnRoutineChange()
  Public Shared Event OnDetailedRoutineChange()
  Shared Sub DetailedRoutineChange()
    RaiseEvent OnDetailedRoutineChange()
  End Sub
  Shared Sub RoutineChange()
    RaiseEvent OnRoutineChange()
  End Sub
  Shared Sub pbMaxValueChange()
    RaiseEvent OnpbMaxValueChange()
  End Sub
  Shared Sub RecordForward()
    RaiseEvent OnRecordForward()
  End Sub
End Class


Public Class SharedException
  Public Shared ErrorMessage As String, ErrorNumber As Integer
  Public Shared Event OnErrorGenerate()

  Shared Sub GenerateError(ByVal errNumber As Integer, ByVal errMessage As String)
    ErrorMessage = errMessage
    ErrorNumber = errNumber
    RaiseEvent OnErrorGenerate()
  End Sub

End Class


Public Class SharedQuestion
  Public Shared ModuleID, QuestionID As String, LimitPunktow As Integer
  Public Shared Event OnLimitPunktowChange(ByVal sender As Object)
  Shared Sub LimitPunktowChange(ByVal sender As Object)
    RaiseEvent OnLimitPunktowChange(sender)
  End Sub
End Class

Public Class SharedTest
  Public Shared TestID, PrzedmiotID As String

End Class


Public Class SharedPrzedmiot
  Public Shared PrzedmiotID, ModulID As String
End Class

Public Class SharedStudent
  Public Shared KodKlasy, StudentID As String
End Class

Public Class SharedPermission
  Public Shared TestID As Integer
End Class

Public Class SharedVersion
  Public Shared TestID, IdStudentTest, LimitOdp As Integer, VersionID As Long, UserName As String, TypTestu As GlobalValues.TypTestu
End Class

Public Class SharedKryterium
  Public Shared NazwaKryteriow As String
End Class

Public Class SharedPrivilege
  Public Shared TestID As Integer
End Class