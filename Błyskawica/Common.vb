Imports System.Security.Cryptography
Imports System.IO
Imports System.Text

Class CbItem
  Private FID As Integer, FNazwa As String, FKod As String
  Sub New(ByVal ID As Integer, ByVal Nazwa As String)
    FID = ID
    FNazwa = Nazwa
  End Sub
  Sub New(ByVal Kod As String, ByVal Nazwa As String)
    FKod = Kod
    FNazwa = Nazwa
  End Sub

  Public Property Nazwa() As String
    Get
      Nazwa = FNazwa
    End Get
    Set(ByVal value As String)
      FNazwa = value
    End Set
  End Property
  Public Property Kod() As String
    Get
      Kod = FKod
    End Get
    Set(ByVal value As String)
      FKod = value
    End Set
  End Property

  Public Property ID() As Integer
    Get
      ID = FID
    End Get
    Set(ByVal value As Integer)
      FID = value
    End Set
  End Property

  Public Overrides Function ToString() As String
    ToString = FNazwa
  End Function
End Class

Public Class DataBaseAction
    Public Function Connection(ByVal Server$, ByVal Baza$, ByVal User$, ByVal Password$) As MySqlConnection
        'Dim N As New Net
        Dim Conn As New MySqlConnection
        Try
            Conn.ConnectionString = "server=" & Server & ";user id=" & User & ";" & "password=" & Password & ";database=" & Baza 'ConnectionString(Server, Baza, User, Password)
            Conn.Open()

        Catch err As MySqlException
            Select Case err.Number
                Case 0
                    MessageBox.Show("Nie można połączyć się z serwerem." & vbCr & "Skontaktuj się z administratorem serwera.")
                Case 1044
                    'MessageBox.Show("Baza danych '" + Baza + "' nie istnieje w podanej lokalizacji - '" + Server + "'." + vbCr + "Skontaktuj się z administratorem serwera baz danych MySQL.")
                    MessageBox.Show(err.Message)
                Case 1045
                    MessageBox.Show("Błędna nazwa użytkownika i (lub) hasło." & vbCr & "Wpisz poprawną nazwę i spróbuj jeszcze raz.")
                Case Else
                    MessageBox.Show("Nie można uzyskać połączenia: " & vbCr & err.Message)
            End Select
        End Try
        Return Conn

    End Function

  Public Overloads Sub ApplyChanges(ByVal SQLString As String)
    Dim cmd As MySqlCommand = CreateCommand(SQLString)
    Try
      cmd.ExecuteNonQuery()
    Catch err As MySqlException
      Select Case err.Number
        Case 1451
          MessageBox.Show("Nie można usunąć lub zaktualizować rekordu nadrzędnego" & vbCr & "z powodu istniejącej relacji między tabelami." & vbCr & "Musisz najpierw usunąć lub zaktualizować rekordy z nim powiązane.")
        Case 1062
          MessageBox.Show("Wprowadzona wartość już istnieje w bazie danych.")
        Case Else
          MessageBox.Show(err.Number & vbCr & err.Message)
      End Select
    End Try
  End Sub
  Public Overloads Sub ApplyChanges(ByVal SQLString As String, ByVal Transaction As MySqlTransaction)
    Dim cmd As MySqlCommand = CreateCommand(SQLString)
    cmd.Transaction = Transaction
    Try
      cmd.ExecuteNonQuery()
    Catch err As MySqlException
      SharedException.GenerateError(err.Number, err.Message)

    End Try
  End Sub
  Public Overloads Sub ApplyChanges(ByVal cmd As MySqlCommand)
    Try
      cmd.ExecuteNonQuery()
    Catch err As MySqlException
      SharedException.GenerateError(err.Number, err.Message)
    End Try
  End Sub
  Public Overloads Sub ApplyChanges(ByVal cmd As MySqlCommand, ByVal Import As Boolean)
    Try
      cmd.ExecuteNonQuery()
    Catch err As MySqlException
      If Import Then
        SharedException.GenerateError(err.Number, err.Message)
      Else
        MessageBox.Show(err.Message)
      End If
    End Try
  End Sub
  Public Function ComputeRecords(ByVal SQLString As String) As Integer
    Try
      Dim CMD As MySqlCommand = CreateCommand(SQLString)
      If CMD.ExecuteScalar IsNot DBNull.Value Then
        Return CType(CMD.ExecuteScalar(), Integer)
      Else
        Return 0
      End If
    Catch err As MySqlException
      MessageBox.Show(err.Number & vbCr & err.Message)
    End Try
  End Function
  Public Function CreateCommand(ByVal SQLString As String) As MySqlCommand
    Dim Cmd As New MySqlCommand(SQLString, GlobalValues.gblConn)
    Try
      Cmd.CommandType = CommandType.Text
    Catch err As MySqlException
      MessageBox.Show(err.Number & vbCr & err.Message)
    End Try
    Return Cmd
  End Function
  Public Function GetDataTable(ByVal SQLString As String) As DataTable
    Dim Adapter As MySqlDataAdapter = SetAdapter(SQLString)
    Dim DT As New DataTable
    Try
      Adapter.Fill(DT)
    Catch err As MySqlException
      MessageBox.Show(err.Message)
    Catch err As Exception
      MessageBox.Show(err.Message)
    End Try
    Return DT
  End Function
  Public Function GetDataSet(ByVal SQLString As String) As DataSet
    Dim Adapter As MySqlDataAdapter = SetAdapter(SQLString)
    Dim Ds As New DataSet
    Try
      Adapter.Fill(Ds)
    Catch err As MySqlException
      MessageBox.Show(err.Message)
    Catch err As Exception
      MessageBox.Show(err.Message)
    End Try
    Return Ds
  End Function
  Public Function GetReader(ByVal SQLString As String) As MySqlDataReader
    Dim Reader As MySqlDataReader = Nothing
    Dim Cmd As MySqlCommand = CreateCommand(SQLString)
    Try
      Reader = Cmd.ExecuteReader()
    Catch err As MySqlException
      MessageBox.Show(err.Number & vbCr & err.Message)
    End Try
    Return Reader
  End Function
  Public Function GetLastInsertedID() As String
    Try
      Dim cmd As MySqlCommand = CreateCommand("Select LAST_INSERT_ID();")
      Return cmd.ExecuteScalar().ToString
    Catch err As MySqlException
      MessageBox.Show(err.Number & vbCr & err.Message)
      Return ""
    End Try
  End Function
  Public Function GetMaxValue(ByVal SQLString As String) As Integer
    Try
      Dim cmd As MySqlCommand = CreateCommand(SQLString)
      If cmd.ExecuteScalar Is DBNull.Value Then Return 0
      Return CType(cmd.ExecuteScalar(), Integer)
    Catch err As MySqlException
      MessageBox.Show(err.Number & vbCr & err.Message)
    End Try
  End Function

  Public Function SetAdapter(ByVal SQLString As String) As MySqlDataAdapter
    Dim Adapter As New MySqlDataAdapter
    Try
      Adapter.SelectCommand = CreateCommand(SQLString)
    Catch err As MySqlException
      MessageBox.Show(err.Number & vbCr & err.Message)
    End Try
    Return Adapter
  End Function
End Class


Class FillComboBox
  Public Overloads Sub AddComboBoxComplexItems(ByRef ctlName As ComboBox, ByVal SelectString As String, Optional ByVal Kod As Boolean = False)
    Dim Reader As MySqlDataReader = Nothing
    Dim DBA As New DataBaseAction
    Try
      Reader = DBA.GetReader(SelectString)
      While Reader.Read()
        If Kod = True Then
          ctlName.Items.Add(New CbItem(CStr(Reader.Item(0)), Reader.Item(1).ToString))
        Else
          ctlName.Items.Add(New CbItem(CInt(Reader.Item(0)), Reader.Item(1).ToString))
        End If
      End While
    Catch err As MySqlException
      MessageBox.Show(err.Message)
    Finally
      Reader.Close()
    End Try
  End Sub

  Public Sub AddComboBoxSimpleItems(ByRef ctlName As ComboBox, ByVal SelectString As String)
    Dim Reader As MySqlDataReader = Nothing
    Dim DBA As New DataBaseAction
    Try
      Reader = DBA.GetReader(SelectString)
      Dim i As Integer = 0
      While Reader.Read()
        ctlName.Items.Add(New CbItem(i, Reader.Item(0).ToString))
        i += 1
      End While
    Catch err As MySqlException
      MessageBox.Show(err.Message)
    Finally
      Reader.Close()
    End Try
  End Sub
  Public Sub AddListBoxComplexItems(ByRef ctlName As ListBox, ByVal SelectString As String)
    Dim Reader As MySqlDataReader = Nothing
    Dim DBA As New DataBaseAction
    Try
      Reader = DBA.GetReader(SelectString)
      While Reader.Read()
        ctlName.Items.Add(New CbItem(CInt(Reader.Item(0)), Reader.Item(1).ToString))
      End While
    Catch err As MySqlException
      MessageBox.Show(err.Message)
    Finally
      Reader.Close()
    End Try
  End Sub
End Class


Public Class HashHelper
  Private Const SaltLength As Integer = 4
  Public Function CreateDBPassword(ByVal Password As String) As Byte()
    Dim UnsaltedPassword() As Byte = CreatePasswordHash(Password)
    Dim SaltValue(SaltLength - 1) As Byte
    Dim Rng As New RNGCryptoServiceProvider
    Rng.GetBytes(SaltValue)
    Return CreateSaltedPassword(SaltValue, UnsaltedPassword)
  End Function
  Private Function CreatePasswordHash(ByVal Password As String) As Byte()
        Dim Sha1 As New SHA1Managed
        Dim b As Byte()
        b = System.Text.Encoding.UTF8.GetBytes(Password)
        Return Sha1.ComputeHash(System.Text.Encoding.UTF8.GetBytes(Password))
  End Function
  Private Function CreateSaltedPassword(ByVal SaltValue As Byte(), ByVal UnsaltedPassword() As Byte) As Byte()
    Dim RawSalted(UnsaltedPassword.Length + SaltValue.Length - 1) As Byte
    UnsaltedPassword.CopyTo(RawSalted, 0)
    SaltValue.CopyTo(RawSalted, UnsaltedPassword.Length)
    Dim Sha1 As New SHA1Managed
    Dim SaltedPassword() As Byte = Sha1.ComputeHash(RawSalted)
    Dim DbPassword(SaltedPassword.Length + SaltValue.Length - 1) As Byte
    SaltedPassword.CopyTo(DbPassword, 0)
    SaltValue.CopyTo(DbPassword, SaltedPassword.Length)
    Return DbPassword
  End Function
  Public Function ComparePasswords(ByVal StoredPassword() As Byte, ByVal SuppliedPassword As String) As Boolean
    Dim SaltValue(SaltLength - 1) As Byte
    Dim SaltOffset As Integer = StoredPassword.Length - SaltLength
    Dim i As Integer
    For i = 0 To SaltLength - 1
      SaltValue(i) = StoredPassword(SaltOffset + i)
    Next
    Dim HashedPassword As Byte() = CreatePasswordHash(SuppliedPassword)
    Dim SaltedPassword As Byte() = CreateSaltedPassword(SaltValue, HashedPassword)
    Return CompareByteArray(StoredPassword, SaltedPassword)
  End Function
  ' Compare the contents of two byte arrays.
  Private Function CompareByteArray(ByVal array1 As Byte(), ByVal array2 As Byte()) As Boolean
    If (array1.Length <> array2.Length) Then Return False
    Dim i As Integer
    For i = 0 To array1.Length - 1
      If Not array1(i).Equals(array2(i)) Then Return False
    Next
    Return True
  End Function
End Class

Public Class Net
  Public Function ComputerIP() As String
    Dim HostName, IPAddress As String
    HostName = System.Net.Dns.GetHostName
    IPAddress = System.Net.Dns.GetHostEntry(HostName).AddressList(0).ToString
    Return IPAddress
  End Function
  Public Function ComputerIPv4() As String
    'Dim HostName, IPAddress As String
    'HostName = System.Net.Dns.GetHostName
    'IPAddress = System.Net.Dns.GetHostEntry(HostName).AddressList(0).AddressFamily = InterNetwork
    'Return IPAddress
    Dim IPList As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName)

    For Each IPaddress In IPList.AddressList
      'Only return IPv4 routable IPs
      If (IPaddress.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork) Then
        Return IPaddress.ToString
      End If
    Next
    Return ""
  End Function
  Public Function ComputerName() As String
    Return System.Net.Dns.GetHostName()
  End Function
End Class

Public Class Rijndael

  ' The key and initialization vector : change them for your application
  Private MyKey() As Byte = {12, 28, 36, 222, 45, 72, 10, 5, 97, 180, 52, 123, 37, 28, 255, 74}
  Private MyIV() As Byte = {2, 13, 28, 32, 20, 147, 252, 45, 63, 52, 96, 85, 42, 32, 159, 241}


  ' decrypts a string that was encrypted using the Encrypt method
  Public Function Decrypt(ByVal CipherText As String) As String 'Implements ICrypto.Decrypt
    Try
      Dim inBytes() As Byte = Convert.FromBase64String(CipherText)
      Dim mStream As New MemoryStream(inBytes, 0, inBytes.Length) ' instead of writing the decrypted text

      Dim aes As New RijndaelManaged()
      Dim cs As New CryptoStream(mStream, aes.CreateDecryptor(MyKey, MyIV), CryptoStreamMode.Read)
      Dim sr As New StreamReader(cs)

      Return sr.ReadToEnd()
    Catch ex As Exception
      MessageBox.Show(ex.Message)
      Return ""
      'Throw ex
    End Try
  End Function

  ' Encrypts a given string
  Public Function Encrypt(ByVal PlainText As String) As String
    Try

      Dim utf8 As New UTF8Encoding
      Dim inBytes() As Byte = utf8.GetBytes(PlainText) ' ascii encoding uses 7 
      'bytes for characters whereas the encryption uses 8 bytes, thus we use utf8
      Dim ms As New MemoryStream() 'instead of writing the encrypted 
      'string to a filestream, I will use a memorystream

      Dim aes As New RijndaelManaged()

      Dim cs As New CryptoStream(ms, aes.CreateEncryptor(MyKey, MyIV), CryptoStreamMode.Write)

      cs.Write(inBytes, 0, inBytes.Length) ' encrypt
      cs.FlushFinalBlock()

      Return Convert.ToBase64String(ms.GetBuffer(), 0, CType(ms.Length, Integer))
    Catch ex As Exception
      MessageBox.Show(ex.Message)
      Return ""
    End Try
  End Function

End Class

Public Class SeekHelper
  Public Sub FindListViewItem(ByVal LV As ListView, ByVal ItemText As String)
    If Not LV.FindItemWithText(ItemText) Is Nothing Then
      LV.Focus()
      LV.Items(LV.FindItemWithText(ItemText).Index).Selected = True
      LV.SelectedItems(0).EnsureVisible()
    End If
  End Sub
  Public Sub FindRemovedListViewItemIndex(ByVal LV As ListView, ByVal DeletedIndex As Integer)
    If LV.Items.Count > 0 Then
      LV.SelectedItems.Clear()
      LV.Select()
      If DeletedIndex = LV.Items.Count Then
        LV.Items(DeletedIndex - 1).Selected = True
      ElseIf DeletedIndex > LV.Items.Count Then
        LV.Items(LV.Items.Count - 1).Selected = True
      Else
        LV.Items(DeletedIndex).Selected = True
      End If
      LV.SelectedItems(0).EnsureVisible()
    End If
  End Sub
  Public Overloads Sub FindComboItem(ByVal CB As ComboBox, ByVal ItemText As String)
    For Each Item As CbItem In CB.Items
      If Item.Nazwa = ItemText Then
        CB.SelectedIndex = CB.Items.IndexOf(Item)
        Exit For
      End If
    Next
  End Sub

  Public Overloads Sub FindComboItem(ByVal CB As ComboBox, ByVal ItemID As Integer)
    For Each Item As CbItem In CB.Items
      If Item.ID = ItemID Then
        CB.SelectedIndex = CB.Items.IndexOf(Item)
        Exit For
      End If
    Next
  End Sub
  Public Function GetDefault(ByVal SelectString As String) As String
    Dim DBA As New DataBaseAction
    Try
      Dim cmd As MySqlCommand = DBA.CreateCommand(SelectString)
      If Len(CStr(cmd.ExecuteScalar())) = 0 Then
        Return CStr(-1)
      Else
        Return cmd.ExecuteScalar().ToString
      End If
    Catch err As MySqlException
      MessageBox.Show(err.Message)
      Return ""
    End Try
  End Function
End Class