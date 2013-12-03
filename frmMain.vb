Public Class frmMain

#Region "Form"
    Dim aboutBox As New frmAbout

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tsCBinvalid.SelectedIndex = 14
        tsCBvalid.SelectedIndex = 14
    End Sub

    Private Sub cmAbout_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmAbout.ButtonClick
        Me.Enabled = False
        Me.Opacity = 0.8
        aboutBox.ShowDialog()
        Me.Opacity = 1
        Me.Enabled = True
    End Sub

    Private Sub tgbHashSource_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHashSource.CheckedChanged
        If chkHashSource.Checked Then
            txtHashSource.PasswordChar = "●"c
        Else
            txtHashSource.PasswordChar = Nothing
        End If
    End Sub

    Private Sub chkAEStxtKey_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAEStxtKey.CheckedChanged
        If chkAEStxtKey.Checked Then
            txtAEStxtKey.PasswordChar = "●"c
        Else
            txtAEStxtKey.PasswordChar = Nothing
        End If
    End Sub

    Private Sub chkFile_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFile.CheckedChanged
        If chkFile.Checked Then
            txtFileEncPass.PasswordChar = "●"c
            txtFileEncCon.Enabled = True
            txtFileDecPass.PasswordChar = "●"c
        Else
            txtFileEncPass.PasswordChar = Nothing
            txtFileEncCon.Enabled = False
            txtFileDecPass.PasswordChar = Nothing
        End If
    End Sub
#End Region

#Region "Form -> Context Menu"

#Region "Read Only"
    Dim lastcmReadOnlyTxtBox As Object = Nothing
    Private Sub cmdReadOnlyCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReadOnlyCopy.Click
        lastcmReadOnlyTxtBox.Copy()
    End Sub

    Private Sub cmReadonlyCopyAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmReadonlyCopyAll.Click
        My.Computer.Clipboard.SetText(lastcmReadOnlyTxtBox.Text)
    End Sub

    Private Sub cmtxt_Text_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtMD5.MouseUp, txtInt.MouseUp, txtsha1.MouseUp, txtsha256.MouseUp, _
    txtsha384.MouseUp, txtsha512.MouseUp, txtROTe.MouseUp, txtAEStxtFin.MouseUp
        lastcmReadOnlyTxtBox = sender
        cmdReadOnlyCopy.Enabled = sender.SelectionLength > 0
    End Sub
#End Region

#Region "Standard Textbox"
    Dim lastcmText As Object = Nothing
    Private Sub cmTextundo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmTextundo.Click
        lastcmText.Undo()
    End Sub

    Private Sub cmTextcut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmTextcut.Click
        lastcmText.Cut()
    End Sub

    Private Sub cmTextcopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmTextcopy.Click
        lastcmText.Copy()
    End Sub

    Private Sub cmTextcopyall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmTextcopyall.Click
        My.Computer.Clipboard.SetText(lastcmText.Text)
    End Sub

    Private Sub cmTextpaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmTextpaste.Click
        lastcmText.Paste()
    End Sub

    Private Sub cmTextdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmTextdel.Click
        Try
            lastcmText.Text = lastcmText.Text.Remove(lastcmText.SelectionStart, lastcmText.SelectionLength)
        Catch
        End Try
    End Sub

    Private Sub cmTextselectall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmTextselectall.Click
        lastcmText.SelectAll()
    End Sub

    Private Sub cmText_Textbox_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtB64source.MouseUp, txtB64encoded.MouseUp, txtHashSource.MouseUp, _
    txtROTs.MouseUp, txtLuhnNumber.MouseUp, txtUnsecEncoded.MouseUp, txtUnsecSource.MouseUp, txtAEStxtSource.MouseUp
        lastcmText = sender
        cmTextundo.Enabled = sender.CanUndo
        cmTextcopy.Enabled = sender.SelectionLength > 0
        cmTextpaste.Enabled = My.Computer.Clipboard.ContainsText
        cmTextdel.Enabled = sender.SelectionLength > 0
    End Sub
#End Region

#End Region

#Region "Byte <-> String"
    ''' <summary>
    ''' Converts an array of bytes to a lowercase hex string
    ''' </summary>
    ''' <param name="bytes">The byte array</param>
    Function BytesToHex(ByVal bytes As Byte()) As String
        Return BitConverter.ToString(bytes).Replace("-"c, "").ToLower()
    End Function

    ''' <summary>
    ''' Converts an array of bytes to a string
    ''' </summary>
    ''' <param name="bytes">The byte array</param>
    Function BytesToString(ByVal bytes As Byte()) As String
        Return UnicodeEncoding.UTF8.GetString(bytes)
    End Function

    ''' <summary>
    ''' Converts an a string to array of bytes
    ''' </summary>
    ''' <param name="str">The string</param>
    Function StringToBytes(ByVal str As String) As Byte()
        If str = Nothing Then
            Return New Byte() {}
        Else
            Return UnicodeEncoding.UTF8.GetBytes(str)
        End If
    End Function
#End Region

#Region "AES Key Generation"
    Function CreateKey(ByVal passphrase As String) As Byte()
        Dim chrData() As Char = passphrase.ToCharArray
        Dim intLength As Integer = chrData.GetUpperBound(0)
        Dim bytDataToHash(intLength) As Byte
        For i As Integer = 0 To intLength
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next
        Dim SHA512 As New SHA512Managed
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        ' 32 bytes = 32 * 8 = 256 bits
        Dim bytKey(31) As Byte
        For i As Integer = 0 To 31
            bytKey(i) = bytResult(i)
        Next
        Return bytKey
    End Function

    Function CreateIV(ByVal passphrase As String) As Byte()
        Dim chrData() As Char = passphrase.ToCharArray
        Dim intLength As Integer = chrData.GetUpperBound(0)
        Dim bytDataToHash(intLength) As Byte
        For i As Integer = 0 To intLength
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next
        Dim SHA512 As New SHA512Managed
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        Dim bytIV(15) As Byte
        ' 16 bytes = (47 - 32 + 1) * 8 = 128 bits
        For i As Integer = 32 To 47
            bytIV(i - 32) = bytResult(i)
        Next
        Return bytIV
    End Function
#End Region

#Region "File Tab"

#Region "Commons"

    Dim strFileToEncrypt As String
    Dim strEncryptOut As String
    Dim strFileToDecrypt As String
    Dim strDecryptOut As String

    Enum CryptoAction
        Encrypt = 1
        Decrypt = 2
    End Enum

    Sub AesFileAction(ByVal strInputFile As String, ByVal strOutputFile As String, _
        ByVal bytKey() As Byte, ByVal bytIV() As Byte, ByVal Direction As CryptoAction)
        Dim fsInput = New System.IO.FileStream(strInputFile, FileMode.Open, FileAccess.Read)
        Dim fsOutput = New System.IO.FileStream(strOutputFile, FileMode.OpenOrCreate, FileAccess.Write)
        Try
            fsOutput.SetLength(0)
            Dim bytBuffer(4096) As Byte ' Buffers a block of bytes for processing
            Dim lngBytesProcessed As Long = 0 ' Running count of bytes processed
            Dim lngFileLength As Long = fsInput.Length ' File Length
            Dim intBytesInCurrentBlock As Integer ' Bytes being processed right now
            Dim csCryptoStream As CryptoStream = Nothing
            Dim cspRijndael As New RijndaelManaged
            Select Case Direction
                Case CryptoAction.Encrypt
                    csCryptoStream = New CryptoStream(fsOutput, cspRijndael.CreateEncryptor( _
                    bytKey, bytIV), CryptoStreamMode.Write)
                Case CryptoAction.Decrypt
                    csCryptoStream = New CryptoStream(fsOutput, cspRijndael.CreateDecryptor( _
                    bytKey, bytIV), CryptoStreamMode.Write)
            End Select
            Dim percentDone As Integer = 0
            While lngBytesProcessed < lngFileLength
                intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 4096)
                csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
                lngBytesProcessed += intBytesInCurrentBlock
                percentDone = lngBytesProcessed / lngFileLength * 100
                progress.Value = percentDone
            End While
            csCryptoStream.Close()
            fsInput.Close()
            fsOutput.Close()
            Dim fileToDelete As FileInfo = Nothing
            If Direction = CryptoAction.Encrypt Then fileToDelete = New FileInfo(strFileToEncrypt)
            If Direction = CryptoAction.Decrypt Then fileToDelete = New FileInfo(strFileToDecrypt)
            fileToDelete.Delete()
            If Direction = CryptoAction.Encrypt Then
                MsgBox("Encryption Complete" & Environment.NewLine & Environment.NewLine & "Total bytes processed: " & _
                lngBytesProcessed, 64, "Done")
                txtFileEncSource.Text = "Click Browse"
                txtFileEncDest.Text = ""
                txtFileEncPass.Text = ""
                txtFileEncCon.Text = ""
                btnFileEncDest.Enabled = False
                btnFileEnc.Enabled = False
            Else
                MsgBox("Decryption Complete" & Environment.NewLine & Environment.NewLine & "Total bytes processed: " & _
                lngBytesProcessed.ToString, 64, "Done")
                txtFileDecSource.Text = "Click Browse"
                txtFileDecDest.Text = ""
                txtFileDecPass.Text = ""
                btnFileDecDest.Enabled = False
                btnFileDec.Enabled = False
            End If
        Catch When Err.Number = 53 'FILE NOT FOUND
            MsgBox("The file was not found during the process", 48, "Invalid Path or Filename")
        Catch ' ALL OTHER ERORS
            fsInput.Close()
            fsOutput.Close()
            If Direction = CryptoAction.Encrypt Then
                Dim fileDelete As New FileInfo(txtFileEncDest.Text)
                fileDelete.Delete()
                txtFileEncPass.Text = ""
                txtFileEncCon.Text = ""
                MsgBox("This file cannot be encrypted", 48, "Invalid File")
            Else
                Dim fileDelete As New FileInfo(txtFileDecDest.Text)
                fileDelete.Delete()
                txtFileDecPass.Text = ""
                MsgBox("Please check to make sure that you entered the correct password." _
                       , 48, "Invalid Password")
            End If
        End Try
    End Sub
#End Region

#Region "Encrypt Tab"
    Private Sub btnFileEncBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFileEncBrowse.Click
        ofd.FileName = ""
        ofd.InitialDirectory = Environment.GetFolderPath(16)
        ofd.Title = "Choose a file to encrypt"
        ofd.Filter = "All Files (*.*) | *.*"
        If ofd.ShowDialog = 1 Then
            strFileToEncrypt = ofd.FileName
            txtFileEncSource.Text = strFileToEncrypt
            Dim ipos As Integer = strFileToEncrypt.LastIndexOf("\"c) + 1
            strEncryptOut = strFileToEncrypt.Substring(ipos)
            Dim LIO = strEncryptOut.LastIndexOf("."c)
            strEncryptOut = strEncryptOut.Remove(strEncryptOut.LastIndexOf("."c), 1)
            strEncryptOut = strEncryptOut.Insert(LIO, "_")
            txtFileEncDest.Text = strFileToEncrypt.Substring(0, ipos) & strEncryptOut & ".crypt"
            btnFileEnc.Enabled = True
            btnFileEncDest.Enabled = True
        End If
    End Sub

    Private Sub btnFileEncDest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFileEncDest.Click
        fbd.Description = "Select the folder to place the encrypted file into"
        If fbd.ShowDialog = 1 Then
            txtFileEncDest.Text = fbd.SelectedPath & "\" & strEncryptOut & ".crypt"
        End If
    End Sub

    Private Sub btnFileEnc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFileEnc.Click
        If txtFileEncCon.Text = txtFileEncPass.Text Or Not chkFile.Checked Then
            Dim fi As New FileInfo(strFileToEncrypt)
            AesFileAction(strFileToEncrypt, txtFileEncDest.Text, CreateKey(txtFileEncPass.Text), CreateIV(txtFileEncPass.Text), CryptoAction.Encrypt)
        Else
            MsgBox("Please re-enter your password", 48, "Password Mismatch")
            txtFileEncCon.Text = ""
        End If
    End Sub
#End Region

#Region "Decrypt Tab"
    Private Sub btnFileDecBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFileDecBrowse.Click
        ofd.FileName = ""
        ofd.InitialDirectory = Environment.GetFolderPath(16)
        ofd.Title = "Choose a file to decrypt"
        ofd.Filter = "Encrypted Files (*.crypt) | *.crypt"
        If ofd.ShowDialog = 1 Then
            strFileToDecrypt = ofd.FileName
            txtFileDecSource.Text = strFileToDecrypt
            Dim iPos As Integer = strFileToDecrypt.LastIndexOf("\"c)
            ' Output = Remove the last 6 characters (.crypt) of the source encrypted file
            strDecryptOut = strFileToDecrypt.Substring(0, strFileToDecrypt.Length - 6)
            Dim S = strFileToDecrypt.Substring(0, iPos + 1)
            strDecryptOut = strDecryptOut.Substring(iPos + 1)
            Dim LIO = strDecryptOut.LastIndexOf("_"c)
            txtFileDecDest.Text = S + strDecryptOut.Remove(LIO, 1).Insert(LIO, ".")
            btnFileDecDest.Enabled = True
            btnFileDec.Enabled = True
        End If
    End Sub

    Private Sub btnFileDecDest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFileDecDest.Click
        fbd.Description = "Select a folder to place the decrypted file in"
        If fbd.ShowDialog = 1 Then
            Dim LIO = strDecryptOut.LastIndexOf("_"c)
            txtFileDecDest.Text = fbd.SelectedPath + "\" + strDecryptOut.Remove(LIO, 1).Insert( _
            LIO, ".")
        End If
    End Sub

    Private Sub btnFileDec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFileDec.Click
        AesFileAction(strFileToDecrypt, txtFileDecDest.Text, CreateKey(txtFileDecPass.Text), _
            CreateIV(txtFileDecPass.Text), CryptoAction.Decrypt)
    End Sub
#End Region

#End Region

#Region "AES Tab"
    Private Sub btnAEStxtEnc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAEStxtEnc.Click
        Dim rijndael As New RijndaelManaged
        Dim encryptor As ICryptoTransform = rijndael.CreateEncryptor(CreateKey(txtAEStxtKey.Text), CreateIV(txtAEStxtKey.Text))
        Dim ToEncrypt = txtAEStxtSource.Text
        Dim plainData As Byte() = StringToBytes(ToEncrypt)
        Dim encryptedData As Byte()
        Using memoryStream As New MemoryStream()
            Using cryptoStream As New CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write)
                cryptoStream.Write(plainData, 0, plainData.Length)
                cryptoStream.FlushFinalBlock()
            End Using
            encryptedData = memoryStream.ToArray()
        End Using
        txtAEStxtFin.Text = Convert.ToBase64String(encryptedData)
    End Sub

    Private Sub btnAEStxtDec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAEStxtDec.Click
        Try
            Dim rijndael As New RijndaelManaged()
            Dim decryptor As ICryptoTransform = rijndael.CreateDecryptor(CreateKey(txtAEStxtKey.Text), CreateIV(txtAEStxtKey.Text))
            Dim decrypted As Byte()
            Dim memoryStream As New MemoryStream()
            Dim cryptoStream As New CryptoStream(memoryStream, decryptor, CryptoStreamMode.Write)
            cryptoStream.Write(Convert.FromBase64String(txtAEStxtSource.Text), 0, Convert.FromBase64String(txtAEStxtSource.Text).Length)
            cryptoStream.FlushFinalBlock()
            decrypted = memoryStream.ToArray()
            txtAEStxtFin.Text = BytesToString(decrypted)
        Catch
            txtAEStxtFin.Text = "Passphrase Invalid"
        End Try
    End Sub
#End Region

#Region "Base 64 Tab"
    Private Sub btnB64Encode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnB64Encode.Click
        txtB64encoded.Text = txtB64source.Text
        For i = 1 To numB64rounds.Value
            txtB64encoded.Text = Convert.ToBase64String(StringToBytes(txtB64encoded.Text))
        Next
    End Sub

    Private Sub btnB64Decode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnB64Decode.Click
        Try
            txtB64source.Text = txtB64encoded.Text
            For i = 1 To numB64rounds.Value
                txtB64source.Text = BytesToString(Convert.FromBase64String(txtB64source.Text))
            Next
        Catch
            txtB64source.Text = "Invalid Base 64 Formatted String!"
        End Try
    End Sub
#End Region

#Region "Hashes Tab"
    Private Sub txtHashSource_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHashSource.TextChanged
        txtInt.Text = txtHashSource.Text.GetHashCode().ToString() ' .NET Integer Hash Function
        Dim bytes As Byte() = StringToBytes(txtHashSource.Text) ' Convert text source into a byte array
        Dim md5 As New MD5CryptoServiceProvider
        Dim md5bytes As Byte() = md5.ComputeHash(bytes) ' Compute the MD5 hash
        md5.Clear() ' Clear the resources used
        txtMD5.Text = BytesToHex(md5bytes) ' Show the hash
        toggleHashB64(Me, Nothing) ' Compute SHA hashes
    End Sub

    Private Sub toggleHashB64(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHash64.CheckedChanged
        Dim bytes As Byte() = StringToBytes(txtHashSource.Text) ' Convert text source into byte array
        Dim shaenc1 As New SHA1Managed ' SHA1
        Dim shaenc384 As New SHA384Managed ' SHA384
        Dim shaenc512 As New SHA512Managed ' SHA512
        Dim shaenc256 As New SHA256Managed ' SHA256
        If chkHash64.Checked Then
            txtsha1.Text = Convert.ToBase64String(shaenc1.ComputeHash(bytes))
            txtsha256.Text = Convert.ToBase64String(shaenc256.ComputeHash(bytes))
            txtsha384.Text = Convert.ToBase64String(shaenc384.ComputeHash(bytes))
            txtsha512.Text = Convert.ToBase64String(shaenc512.ComputeHash(bytes))
        Else
            txtsha1.Text = BytesToHex(shaenc1.ComputeHash(bytes))
            txtsha256.Text = BytesToHex(shaenc256.ComputeHash(bytes))
            txtsha384.Text = BytesToHex(shaenc384.ComputeHash(bytes))
            txtsha512.Text = BytesToHex(shaenc512.ComputeHash(bytes))
        End If
    End Sub
#End Region

#Region "Rotate Tab"
    Private Sub updateROT_event(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtROTs.TextChanged, numROTn.ValueChanged
        txtROTe.Text = Nothing
        Dim skip As Boolean = False
        Dim inverse As Boolean = False
        For Each c In txtROTs.Text.ToCharArray
            If c = "["c Then
                skip = True
            ElseIf c = "]"c Then
                skip = False
            ElseIf c = "{"c Then
                inverse = True
            ElseIf c = "}"c Then
                inverse = False
            End If
            If skip Then
                txtROTe.Text &= c
            Else
                If inverse Then
                    txtROTe.Text &= ROT(c, 26 - numROTn.Value)
                Else
                    txtROTe.Text &= ROT(c, numROTn.Value)
                End If
            End If
        Next
    End Sub

    Function ROT(ByVal _chr As Char, ByVal amount As Integer) As Char
        Dim alpha As String = "abcdefghijklmnopqrstuvwxyz"
        Dim Index = alpha.IndexOf(Char.ToLower(_chr))
        If Index = -1 Then
            Return _chr
        ElseIf Char.IsUpper(_chr) Then
            alpha = alpha.ToUpper
        End If
        Return alpha.Chars((Index + amount) Mod 26)
    End Function
#End Region

#Region "Unsecure Tab"
    Private Sub btnUnsecEncode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnsecEncode.Click
        Dim buffer As String = "==Type " & numUnsec.Value & "==" & Environment.NewLine
        Dim buffer2 As String = Nothing
        For Each _chr In txtUnsecSource.Text
            buffer2 &= ChrW(AscW(_chr) + numUnsec.Value)
        Next
        buffer &= Convert.ToBase64String(StringToBytes(buffer2)) & Environment.NewLine & "==End Data=="
        txtUnsecEncoded.Text = buffer
    End Sub

    Private Sub btnUnsecDecode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnsecDecode.Click
        Try
            Dim key As Integer = txtUnsecEncoded.Text.Substring(7, 1) ' "==Type " is 7 chars long
            Dim buffer As String = BytesToString(Convert.FromBase64String( _
            txtUnsecEncoded.Text.Substring(12, txtUnsecEncoded.TextLength - 26))) ' 7 + # + == + Environment.NewLine = 7 + 5 = 12
            txtUnsecSource.Text = Nothing
            For Each _chr In buffer
                txtUnsecSource.Text &= ChrW(AscW(_chr) - key)
            Next
        Catch
            txtUnsecSource.Text = "Invalid Data"
        End Try
    End Sub
#End Region

#Region "Luhm Algorithm Tab"

    Private Sub txtLuhnNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLuhnNumber.TextChanged
        Luhn(txtLuhnNumber.Text)
    End Sub

    Private Sub tsSBvalid_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSBvalid.ButtonClick
        Dim rand As New Random
        Dim buffer As String = Nothing
        ' Make a random number
        For i = 2 To CInt(tsCBvalid.Text)
            buffer &= rand.Next(0, 9)
        Next
        Dim check As Integer = 10 - Luhn(buffer & "0")
        If check = 10 Then
            check = 0
        End If
        txtLuhnNumber.Text = buffer & check
        Luhn(txtLuhnNumber.Text)
    End Sub

    Private Sub tsSBinvalid_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSBinvalid.ButtonClick
        Dim rand As New Random
        Dim buffer As String = Nothing
        ' Make a random number
        For i = 2 To CInt(tsCBinvalid.Text)
            buffer &= rand.Next(0, 9)
        Next
        Dim check_disallowed As Integer = 10 - Luhn(buffer & "0")
        If check_disallowed = 10 Then
            check_disallowed = 0
        End If
        ' Generate some other digit
        Dim check As Integer = rand.Next(0, 8)
        If check >= check_disallowed Then
            check += 1
        End If
        txtLuhnNumber.Text = buffer & check
        Luhn(txtLuhnNumber.Text)
    End Sub

    Private DoubleDigitalRootTable() As Integer = {0, 2, 4, 6, 8, 1, 3, 5, 7, 9}

    Function Luhn(ByVal numbers As String) As Integer
        Dim sum As Integer = numbers.Chars(numbers.Length - 1).ToString
        Dim toggle = False
        For i = 2 To numbers.Length
            Dim cd = numbers.Chars(numbers.Length - i)
            Dim number As Integer = cd.ToString
            toggle = Not toggle
            If toggle Then
                number = DoubleDigitalRootTable(number)
            End If
            sum += number
        Next
        LuhnResults(sum)
        Return sum Mod 10
    End Function

    Sub LuhnResults(ByVal int As Integer)
        pbLuhn.Value = 10 - (int Mod 10)
        chkLuhn.Checked = (int Mod 10 = 0)
        If Not chkLuhn.Checked Then
            chkLuhn.Text = "Invalid"
        Else
            chkLuhn.Text = "Valid"
        End If
        chkLuhn.Text &= " (" & int.ToString.PadLeft(2, "0"c) & ")"
    End Sub
#End Region

End Class