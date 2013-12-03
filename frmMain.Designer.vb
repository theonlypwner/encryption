<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tcEncryption = New System.Windows.Forms.TabControl()
        Me.PgHome = New System.Windows.Forms.TabPage()
        Me.grpLuhm = New System.Windows.Forms.GroupBox()
        Me.lblLuhm = New System.Windows.Forms.Label()
        Me.grpUnsec = New System.Windows.Forms.GroupBox()
        Me.lblUnsec = New System.Windows.Forms.Label()
        Me.grpROT = New System.Windows.Forms.GroupBox()
        Me.lblROT = New System.Windows.Forms.Label()
        Me.grpHashes = New System.Windows.Forms.GroupBox()
        Me.lblHashes = New System.Windows.Forms.Label()
        Me.grpB64 = New System.Windows.Forms.GroupBox()
        Me.lblB64 = New System.Windows.Forms.Label()
        Me.grpAES = New System.Windows.Forms.GroupBox()
        Me.lblAES = New System.Windows.Forms.Label()
        Me.PgFile = New System.Windows.Forms.TabPage()
        Me.chkFile = New System.Windows.Forms.CheckBox()
        Me.tcAESfile = New System.Windows.Forms.TabControl()
        Me.tpAESfileEnc = New System.Windows.Forms.TabPage()
        Me.btnFileEnc = New System.Windows.Forms.Button()
        Me.btnFileEncDest = New System.Windows.Forms.Button()
        Me.btnFileEncBrowse = New System.Windows.Forms.Button()
        Me.txtFileEncCon = New System.Windows.Forms.TextBox()
        Me.txtFileEncPass = New System.Windows.Forms.TextBox()
        Me.txtFileEncDest = New System.Windows.Forms.TextBox()
        Me.txtFileEncSource = New System.Windows.Forms.TextBox()
        Me.lblEncCon = New System.Windows.Forms.Label()
        Me.lblEncDest = New System.Windows.Forms.Label()
        Me.lblEncKey = New System.Windows.Forms.Label()
        Me.lblEncSource = New System.Windows.Forms.Label()
        Me.tpAESfileDec = New System.Windows.Forms.TabPage()
        Me.btnFileDec = New System.Windows.Forms.Button()
        Me.btnFileDecDest = New System.Windows.Forms.Button()
        Me.btnFileDecBrowse = New System.Windows.Forms.Button()
        Me.txtFileDecPass = New System.Windows.Forms.TextBox()
        Me.txtFileDecDest = New System.Windows.Forms.TextBox()
        Me.txtFileDecSource = New System.Windows.Forms.TextBox()
        Me.lblDecDest = New System.Windows.Forms.Label()
        Me.lblDecPass = New System.Windows.Forms.Label()
        Me.lblDecSource = New System.Windows.Forms.Label()
        Me.tabicons = New System.Windows.Forms.ImageList(Me.components)
        Me.PgAES = New System.Windows.Forms.TabPage()
        Me.btnAEStxtDec = New System.Windows.Forms.Button()
        Me.btnAEStxtEnc = New System.Windows.Forms.Button()
        Me.chkAEStxtKey = New System.Windows.Forms.CheckBox()
        Me.txtAEStxtKey = New System.Windows.Forms.TextBox()
        Me.grpAEStxtEncoded = New System.Windows.Forms.GroupBox()
        Me.txtAEStxtFin = New System.Windows.Forms.TextBox()
        Me.cmsReadOnly = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdReadOnlyCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmReadonlyCopyAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpAEStxtSource = New System.Windows.Forms.GroupBox()
        Me.txtAEStxtSource = New System.Windows.Forms.TextBox()
        Me.cmText = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmTextundo = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmTextsep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmTextcut = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmTextcopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmTextcopyall = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmTextpaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmTextdel = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmTextsep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmTextselectall = New System.Windows.Forms.ToolStripMenuItem()
        Me.PgB64 = New System.Windows.Forms.TabPage()
        Me.numB64rounds = New System.Windows.Forms.NumericUpDown()
        Me.lblB64e = New System.Windows.Forms.Label()
        Me.txtB64encoded = New System.Windows.Forms.TextBox()
        Me.lblB64d = New System.Windows.Forms.Label()
        Me.txtB64source = New System.Windows.Forms.TextBox()
        Me.btnB64Decode = New System.Windows.Forms.Button()
        Me.btnB64Encode = New System.Windows.Forms.Button()
        Me.PgHash = New System.Windows.Forms.TabPage()
        Me.chkHashSource = New System.Windows.Forms.CheckBox()
        Me.txtInt = New System.Windows.Forms.TextBox()
        Me.chkHash64 = New System.Windows.Forms.CheckBox()
        Me.txtMD5 = New System.Windows.Forms.TextBox()
        Me.grpSHA = New System.Windows.Forms.GroupBox()
        Me.txtsha512 = New System.Windows.Forms.TextBox()
        Me.lblsha512 = New System.Windows.Forms.Label()
        Me.txtsha384 = New System.Windows.Forms.TextBox()
        Me.lblsha384 = New System.Windows.Forms.Label()
        Me.txtsha256 = New System.Windows.Forms.TextBox()
        Me.txtsha1 = New System.Windows.Forms.TextBox()
        Me.lblsha256 = New System.Windows.Forms.Label()
        Me.lblsha1 = New System.Windows.Forms.Label()
        Me.lblHASHint = New System.Windows.Forms.Label()
        Me.lblMD5 = New System.Windows.Forms.Label()
        Me.lblHashSource = New System.Windows.Forms.Label()
        Me.txtHashSource = New System.Windows.Forms.TextBox()
        Me.PgROT13 = New System.Windows.Forms.TabPage()
        Me.numROTn = New System.Windows.Forms.NumericUpDown()
        Me.lblROTe = New System.Windows.Forms.Label()
        Me.txtROTe = New System.Windows.Forms.TextBox()
        Me.lblROTs = New System.Windows.Forms.Label()
        Me.txtROTs = New System.Windows.Forms.TextBox()
        Me.PgUnSecure = New System.Windows.Forms.TabPage()
        Me.numUnsec = New System.Windows.Forms.NumericUpDown()
        Me.lblUnsecE = New System.Windows.Forms.Label()
        Me.txtUnsecEncoded = New System.Windows.Forms.TextBox()
        Me.lblUnsecp = New System.Windows.Forms.Label()
        Me.txtUnsecSource = New System.Windows.Forms.TextBox()
        Me.btnUnsecDecode = New System.Windows.Forms.Button()
        Me.btnUnsecEncode = New System.Windows.Forms.Button()
        Me.PgLuhn = New System.Windows.Forms.TabPage()
        Me.grpResults = New System.Windows.Forms.GroupBox()
        Me.chkLuhn = New System.Windows.Forms.CheckBox()
        Me.pbLuhn = New System.Windows.Forms.ProgressBar()
        Me.grpCalculations = New System.Windows.Forms.GroupBox()
        Me.lblLuhnExp = New System.Windows.Forms.Label()
        Me.lblLuhnNum = New System.Windows.Forms.Label()
        Me.grpNumber = New System.Windows.Forms.GroupBox()
        Me.txtLuhnNumber = New System.Windows.Forms.MaskedTextBox()
        Me.tsLuhn = New System.Windows.Forms.ToolStrip()
        Me.tslLuhnTs = New System.Windows.Forms.ToolStripLabel()
        Me.tssLuhn1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsSBvalid = New System.Windows.Forms.ToolStripSplitButton()
        Me.tsCBvalid = New System.Windows.Forms.ToolStripComboBox()
        Me.tsSBinvalid = New System.Windows.Forms.ToolStripSplitButton()
        Me.tsCBinvalid = New System.Windows.Forms.ToolStripComboBox()
        Me.statstrip = New System.Windows.Forms.StatusStrip()
        Me.cmAbout = New System.Windows.Forms.ToolStripSplitButton()
        Me.OptimizedForToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsXPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DPI100125ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.progress = New System.Windows.Forms.ToolStripProgressBar()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.fbd = New System.Windows.Forms.FolderBrowserDialog()
        Me.tcEncryption.SuspendLayout()
        Me.PgHome.SuspendLayout()
        Me.grpLuhm.SuspendLayout()
        Me.grpUnsec.SuspendLayout()
        Me.grpROT.SuspendLayout()
        Me.grpHashes.SuspendLayout()
        Me.grpB64.SuspendLayout()
        Me.grpAES.SuspendLayout()
        Me.PgFile.SuspendLayout()
        Me.tcAESfile.SuspendLayout()
        Me.tpAESfileEnc.SuspendLayout()
        Me.tpAESfileDec.SuspendLayout()
        Me.PgAES.SuspendLayout()
        Me.grpAEStxtEncoded.SuspendLayout()
        Me.cmsReadOnly.SuspendLayout()
        Me.grpAEStxtSource.SuspendLayout()
        Me.cmText.SuspendLayout()
        Me.PgB64.SuspendLayout()
        CType(Me.numB64rounds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PgHash.SuspendLayout()
        Me.grpSHA.SuspendLayout()
        Me.PgROT13.SuspendLayout()
        CType(Me.numROTn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PgUnSecure.SuspendLayout()
        CType(Me.numUnsec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PgLuhn.SuspendLayout()
        Me.grpResults.SuspendLayout()
        Me.grpCalculations.SuspendLayout()
        Me.grpNumber.SuspendLayout()
        Me.tsLuhn.SuspendLayout()
        Me.statstrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcEncryption
        '
        Me.tcEncryption.Controls.Add(Me.PgHome)
        Me.tcEncryption.Controls.Add(Me.PgFile)
        Me.tcEncryption.Controls.Add(Me.PgAES)
        Me.tcEncryption.Controls.Add(Me.PgB64)
        Me.tcEncryption.Controls.Add(Me.PgHash)
        Me.tcEncryption.Controls.Add(Me.PgROT13)
        Me.tcEncryption.Controls.Add(Me.PgUnSecure)
        Me.tcEncryption.Controls.Add(Me.PgLuhn)
        Me.tcEncryption.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcEncryption.ImageList = Me.tabicons
        Me.tcEncryption.Location = New System.Drawing.Point(0, 0)
        Me.tcEncryption.Margin = New System.Windows.Forms.Padding(4)
        Me.tcEncryption.Name = "tcEncryption"
        Me.tcEncryption.SelectedIndex = 0
        Me.tcEncryption.Size = New System.Drawing.Size(733, 398)
        Me.tcEncryption.TabIndex = 0
        '
        'PgHome
        '
        Me.PgHome.Controls.Add(Me.grpLuhm)
        Me.PgHome.Controls.Add(Me.grpUnsec)
        Me.PgHome.Controls.Add(Me.grpROT)
        Me.PgHome.Controls.Add(Me.grpHashes)
        Me.PgHome.Controls.Add(Me.grpB64)
        Me.PgHome.Controls.Add(Me.grpAES)
        Me.PgHome.ImageKey = "house.png"
        Me.PgHome.Location = New System.Drawing.Point(4, 27)
        Me.PgHome.Margin = New System.Windows.Forms.Padding(4)
        Me.PgHome.Name = "PgHome"
        Me.PgHome.Padding = New System.Windows.Forms.Padding(4)
        Me.PgHome.Size = New System.Drawing.Size(725, 367)
        Me.PgHome.TabIndex = 2
        Me.PgHome.Text = "Home"
        Me.PgHome.UseVisualStyleBackColor = True
        '
        'grpLuhm
        '
        Me.grpLuhm.Controls.Add(Me.lblLuhm)
        Me.grpLuhm.Location = New System.Drawing.Point(486, 172)
        Me.grpLuhm.Name = "grpLuhm"
        Me.grpLuhm.Size = New System.Drawing.Size(236, 160)
        Me.grpLuhm.TabIndex = 5
        Me.grpLuhm.TabStop = False
        Me.grpLuhm.Text = "Luhn"
        '
        'lblLuhm
        '
        Me.lblLuhm.AutoSize = True
        Me.lblLuhm.Location = New System.Drawing.Point(40, 46)
        Me.lblLuhm.Name = "lblLuhm"
        Me.lblLuhm.Size = New System.Drawing.Size(157, 80)
        Me.lblLuhm.TabIndex = 1
        Me.lblLuhm.Text = "Check a number with" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the Luhn Algorithm," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "used for validating" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "credit cards"
        Me.lblLuhm.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grpUnsec
        '
        Me.grpUnsec.Controls.Add(Me.lblUnsec)
        Me.grpUnsec.Location = New System.Drawing.Point(247, 172)
        Me.grpUnsec.Name = "grpUnsec"
        Me.grpUnsec.Size = New System.Drawing.Size(236, 160)
        Me.grpUnsec.TabIndex = 4
        Me.grpUnsec.TabStop = False
        Me.grpUnsec.Text = "Unsecure"
        '
        'lblUnsec
        '
        Me.lblUnsec.AutoSize = True
        Me.lblUnsec.Location = New System.Drawing.Point(53, 46)
        Me.lblUnsec.Name = "lblUnsec"
        Me.lblUnsec.Size = New System.Drawing.Size(131, 80)
        Me.lblUnsec.TabIndex = 1
        Me.lblUnsec.Text = "Encodes text in" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "9 different ways," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "which all decode" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "back to the same"
        Me.lblUnsec.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grpROT
        '
        Me.grpROT.Controls.Add(Me.lblROT)
        Me.grpROT.Location = New System.Drawing.Point(8, 172)
        Me.grpROT.Name = "grpROT"
        Me.grpROT.Size = New System.Drawing.Size(236, 160)
        Me.grpROT.TabIndex = 3
        Me.grpROT.TabStop = False
        Me.grpROT.Text = "Rotate"
        '
        'lblROT
        '
        Me.lblROT.AutoSize = True
        Me.lblROT.Location = New System.Drawing.Point(32, 46)
        Me.lblROT.Name = "lblROT"
        Me.lblROT.Size = New System.Drawing.Size(173, 80)
        Me.lblROT.TabIndex = 1
        Me.lblROT.Text = "Rotates your text's" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "alphabetical characters" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "by a certain number" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(To decode use" & _
    " 26-n)"
        Me.lblROT.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grpHashes
        '
        Me.grpHashes.Controls.Add(Me.lblHashes)
        Me.grpHashes.Location = New System.Drawing.Point(486, 7)
        Me.grpHashes.Name = "grpHashes"
        Me.grpHashes.Size = New System.Drawing.Size(236, 160)
        Me.grpHashes.TabIndex = 2
        Me.grpHashes.TabStop = False
        Me.grpHashes.Text = "Hashes"
        '
        'lblHashes
        '
        Me.lblHashes.AutoSize = True
        Me.lblHashes.Location = New System.Drawing.Point(17, 56)
        Me.lblHashes.Name = "lblHashes"
        Me.lblHashes.Size = New System.Drawing.Size(202, 60)
        Me.lblHashes.TabIndex = 1
        Me.lblHashes.Text = "Hashes your text into" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a .NET Integer hash, MD5," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and SHA (1, 256, 384, 512)"
        Me.lblHashes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grpB64
        '
        Me.grpB64.Controls.Add(Me.lblB64)
        Me.grpB64.Location = New System.Drawing.Point(247, 7)
        Me.grpB64.Name = "grpB64"
        Me.grpB64.Size = New System.Drawing.Size(236, 160)
        Me.grpB64.TabIndex = 1
        Me.grpB64.TabStop = False
        Me.grpB64.Text = "Base 64"
        '
        'lblB64
        '
        Me.lblB64.AutoSize = True
        Me.lblB64.Location = New System.Drawing.Point(56, 56)
        Me.lblB64.Name = "lblB64"
        Me.lblB64.Size = New System.Drawing.Size(124, 60)
        Me.lblB64.TabIndex = 1
        Me.lblB64.Text = "Encode/Decode" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Base 64" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(multiple times)"
        Me.lblB64.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grpAES
        '
        Me.grpAES.Controls.Add(Me.lblAES)
        Me.grpAES.Location = New System.Drawing.Point(8, 7)
        Me.grpAES.Name = "grpAES"
        Me.grpAES.Size = New System.Drawing.Size(236, 160)
        Me.grpAES.TabIndex = 0
        Me.grpAES.TabStop = False
        Me.grpAES.Text = "AES"
        '
        'lblAES
        '
        Me.lblAES.AutoSize = True
        Me.lblAES.Location = New System.Drawing.Point(36, 56)
        Me.lblAES.Name = "lblAES"
        Me.lblAES.Size = New System.Drawing.Size(165, 60)
        Me.lblAES.TabIndex = 0
        Me.lblAES.Text = "AES (Rijndael) can be" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "used to encrypt both" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "text and files"
        Me.lblAES.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PgFile
        '
        Me.PgFile.Controls.Add(Me.chkFile)
        Me.PgFile.Controls.Add(Me.tcAESfile)
        Me.PgFile.ImageKey = "page_key.png"
        Me.PgFile.Location = New System.Drawing.Point(4, 27)
        Me.PgFile.Name = "PgFile"
        Me.PgFile.Size = New System.Drawing.Size(725, 367)
        Me.PgFile.TabIndex = 6
        Me.PgFile.Text = "File"
        Me.PgFile.UseVisualStyleBackColor = True
        '
        'chkFile
        '
        Me.chkFile.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkFile.AutoSize = True
        Me.chkFile.Checked = True
        Me.chkFile.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFile.Location = New System.Drawing.Point(669, 2)
        Me.chkFile.Name = "chkFile"
        Me.chkFile.Size = New System.Drawing.Size(49, 30)
        Me.chkFile.TabIndex = 17
        Me.chkFile.Text = "●●●"
        Me.chkFile.UseVisualStyleBackColor = True
        '
        'tcAESfile
        '
        Me.tcAESfile.Controls.Add(Me.tpAESfileEnc)
        Me.tcAESfile.Controls.Add(Me.tpAESfileDec)
        Me.tcAESfile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcAESfile.ImageList = Me.tabicons
        Me.tcAESfile.Location = New System.Drawing.Point(0, 0)
        Me.tcAESfile.Name = "tcAESfile"
        Me.tcAESfile.SelectedIndex = 0
        Me.tcAESfile.Size = New System.Drawing.Size(725, 367)
        Me.tcAESfile.TabIndex = 0
        '
        'tpAESfileEnc
        '
        Me.tpAESfileEnc.Controls.Add(Me.btnFileEnc)
        Me.tpAESfileEnc.Controls.Add(Me.btnFileEncDest)
        Me.tpAESfileEnc.Controls.Add(Me.btnFileEncBrowse)
        Me.tpAESfileEnc.Controls.Add(Me.txtFileEncCon)
        Me.tpAESfileEnc.Controls.Add(Me.txtFileEncPass)
        Me.tpAESfileEnc.Controls.Add(Me.txtFileEncDest)
        Me.tpAESfileEnc.Controls.Add(Me.txtFileEncSource)
        Me.tpAESfileEnc.Controls.Add(Me.lblEncCon)
        Me.tpAESfileEnc.Controls.Add(Me.lblEncDest)
        Me.tpAESfileEnc.Controls.Add(Me.lblEncKey)
        Me.tpAESfileEnc.Controls.Add(Me.lblEncSource)
        Me.tpAESfileEnc.ImageKey = "key_add.png"
        Me.tpAESfileEnc.Location = New System.Drawing.Point(4, 27)
        Me.tpAESfileEnc.Name = "tpAESfileEnc"
        Me.tpAESfileEnc.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAESfileEnc.Size = New System.Drawing.Size(717, 336)
        Me.tpAESfileEnc.TabIndex = 0
        Me.tpAESfileEnc.Text = "Encrypt"
        Me.tpAESfileEnc.UseVisualStyleBackColor = True
        '
        'btnFileEnc
        '
        Me.btnFileEnc.Enabled = False
        Me.btnFileEnc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.89076!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFileEnc.Location = New System.Drawing.Point(614, 203)
        Me.btnFileEnc.Name = "btnFileEnc"
        Me.btnFileEnc.Size = New System.Drawing.Size(92, 57)
        Me.btnFileEnc.TabIndex = 5
        Me.btnFileEnc.Text = "Encrypt"
        Me.btnFileEnc.UseVisualStyleBackColor = True
        '
        'btnFileEncDest
        '
        Me.btnFileEncDest.Enabled = False
        Me.btnFileEncDest.Location = New System.Drawing.Point(614, 79)
        Me.btnFileEncDest.Name = "btnFileEncDest"
        Me.btnFileEncDest.Size = New System.Drawing.Size(92, 42)
        Me.btnFileEncDest.TabIndex = 2
        Me.btnFileEncDest.Text = "Change"
        Me.btnFileEncDest.UseVisualStyleBackColor = True
        '
        'btnFileEncBrowse
        '
        Me.btnFileEncBrowse.Location = New System.Drawing.Point(614, 45)
        Me.btnFileEncBrowse.Name = "btnFileEncBrowse"
        Me.btnFileEncBrowse.Size = New System.Drawing.Size(92, 28)
        Me.btnFileEncBrowse.TabIndex = 1
        Me.btnFileEncBrowse.Text = "Browse"
        Me.btnFileEncBrowse.UseVisualStyleBackColor = True
        '
        'txtFileEncCon
        '
        Me.txtFileEncCon.Location = New System.Drawing.Point(124, 239)
        Me.txtFileEncCon.Name = "txtFileEncCon"
        Me.txtFileEncCon.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtFileEncCon.Size = New System.Drawing.Size(484, 25)
        Me.txtFileEncCon.TabIndex = 4
        '
        'txtFileEncPass
        '
        Me.txtFileEncPass.Location = New System.Drawing.Point(124, 199)
        Me.txtFileEncPass.Name = "txtFileEncPass"
        Me.txtFileEncPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtFileEncPass.Size = New System.Drawing.Size(484, 25)
        Me.txtFileEncPass.TabIndex = 3
        '
        'txtFileEncDest
        '
        Me.txtFileEncDest.Location = New System.Drawing.Point(124, 92)
        Me.txtFileEncDest.Name = "txtFileEncDest"
        Me.txtFileEncDest.ReadOnly = True
        Me.txtFileEncDest.Size = New System.Drawing.Size(484, 25)
        Me.txtFileEncDest.TabIndex = 2
        Me.txtFileEncDest.TabStop = False
        '
        'txtFileEncSource
        '
        Me.txtFileEncSource.Location = New System.Drawing.Point(124, 45)
        Me.txtFileEncSource.Name = "txtFileEncSource"
        Me.txtFileEncSource.ReadOnly = True
        Me.txtFileEncSource.Size = New System.Drawing.Size(484, 25)
        Me.txtFileEncSource.TabIndex = 1
        Me.txtFileEncSource.TabStop = False
        Me.txtFileEncSource.Text = "Click Browse"
        '
        'lblEncCon
        '
        Me.lblEncCon.AutoSize = True
        Me.lblEncCon.Location = New System.Drawing.Point(38, 242)
        Me.lblEncCon.Name = "lblEncCon"
        Me.lblEncCon.Size = New System.Drawing.Size(68, 20)
        Me.lblEncCon.TabIndex = 1
        Me.lblEncCon.Text = "Confirm:"
        '
        'lblEncDest
        '
        Me.lblEncDest.AutoSize = True
        Me.lblEncDest.Location = New System.Drawing.Point(11, 92)
        Me.lblEncDest.Name = "lblEncDest"
        Me.lblEncDest.Size = New System.Drawing.Size(94, 20)
        Me.lblEncDest.TabIndex = 1
        Me.lblEncDest.Text = "Destination:"
        '
        'lblEncKey
        '
        Me.lblEncKey.AutoSize = True
        Me.lblEncKey.Location = New System.Drawing.Point(26, 199)
        Me.lblEncKey.Name = "lblEncKey"
        Me.lblEncKey.Size = New System.Drawing.Size(79, 20)
        Me.lblEncKey.TabIndex = 0
        Me.lblEncKey.Text = "Passsord:"
        '
        'lblEncSource
        '
        Me.lblEncSource.AutoSize = True
        Me.lblEncSource.Location = New System.Drawing.Point(42, 45)
        Me.lblEncSource.Name = "lblEncSource"
        Me.lblEncSource.Size = New System.Drawing.Size(64, 20)
        Me.lblEncSource.TabIndex = 0
        Me.lblEncSource.Text = "Source:"
        '
        'tpAESfileDec
        '
        Me.tpAESfileDec.Controls.Add(Me.btnFileDec)
        Me.tpAESfileDec.Controls.Add(Me.btnFileDecDest)
        Me.tpAESfileDec.Controls.Add(Me.btnFileDecBrowse)
        Me.tpAESfileDec.Controls.Add(Me.txtFileDecPass)
        Me.tpAESfileDec.Controls.Add(Me.txtFileDecDest)
        Me.tpAESfileDec.Controls.Add(Me.txtFileDecSource)
        Me.tpAESfileDec.Controls.Add(Me.lblDecDest)
        Me.tpAESfileDec.Controls.Add(Me.lblDecPass)
        Me.tpAESfileDec.Controls.Add(Me.lblDecSource)
        Me.tpAESfileDec.ImageKey = "key_delete.png"
        Me.tpAESfileDec.Location = New System.Drawing.Point(4, 27)
        Me.tpAESfileDec.Name = "tpAESfileDec"
        Me.tpAESfileDec.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAESfileDec.Size = New System.Drawing.Size(717, 336)
        Me.tpAESfileDec.TabIndex = 1
        Me.tpAESfileDec.Text = "Decrypt"
        Me.tpAESfileDec.UseVisualStyleBackColor = True
        '
        'btnFileDec
        '
        Me.btnFileDec.Enabled = False
        Me.btnFileDec.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.89076!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFileDec.Location = New System.Drawing.Point(614, 190)
        Me.btnFileDec.Name = "btnFileDec"
        Me.btnFileDec.Size = New System.Drawing.Size(92, 57)
        Me.btnFileDec.TabIndex = 4
        Me.btnFileDec.Text = "Decrypt"
        Me.btnFileDec.UseVisualStyleBackColor = True
        '
        'btnFileDecDest
        '
        Me.btnFileDecDest.Enabled = False
        Me.btnFileDecDest.Location = New System.Drawing.Point(614, 87)
        Me.btnFileDecDest.Name = "btnFileDecDest"
        Me.btnFileDecDest.Size = New System.Drawing.Size(92, 42)
        Me.btnFileDecDest.TabIndex = 2
        Me.btnFileDecDest.Text = "Change"
        Me.btnFileDecDest.UseVisualStyleBackColor = True
        '
        'btnFileDecBrowse
        '
        Me.btnFileDecBrowse.Location = New System.Drawing.Point(614, 53)
        Me.btnFileDecBrowse.Name = "btnFileDecBrowse"
        Me.btnFileDecBrowse.Size = New System.Drawing.Size(92, 28)
        Me.btnFileDecBrowse.TabIndex = 1
        Me.btnFileDecBrowse.Text = "Browse"
        Me.btnFileDecBrowse.UseVisualStyleBackColor = True
        '
        'txtFileDecPass
        '
        Me.txtFileDecPass.Location = New System.Drawing.Point(124, 207)
        Me.txtFileDecPass.Name = "txtFileDecPass"
        Me.txtFileDecPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtFileDecPass.Size = New System.Drawing.Size(484, 25)
        Me.txtFileDecPass.TabIndex = 3
        '
        'txtFileDecDest
        '
        Me.txtFileDecDest.Location = New System.Drawing.Point(124, 100)
        Me.txtFileDecDest.Name = "txtFileDecDest"
        Me.txtFileDecDest.ReadOnly = True
        Me.txtFileDecDest.Size = New System.Drawing.Size(484, 25)
        Me.txtFileDecDest.TabIndex = 2
        Me.txtFileDecDest.TabStop = False
        '
        'txtFileDecSource
        '
        Me.txtFileDecSource.Location = New System.Drawing.Point(124, 53)
        Me.txtFileDecSource.Name = "txtFileDecSource"
        Me.txtFileDecSource.ReadOnly = True
        Me.txtFileDecSource.Size = New System.Drawing.Size(484, 25)
        Me.txtFileDecSource.TabIndex = 1
        Me.txtFileDecSource.TabStop = False
        Me.txtFileDecSource.Text = "Click Browse"
        '
        'lblDecDest
        '
        Me.lblDecDest.AutoSize = True
        Me.lblDecDest.Location = New System.Drawing.Point(11, 100)
        Me.lblDecDest.Name = "lblDecDest"
        Me.lblDecDest.Size = New System.Drawing.Size(94, 20)
        Me.lblDecDest.TabIndex = 6
        Me.lblDecDest.Text = "Destination:"
        '
        'lblDecPass
        '
        Me.lblDecPass.AutoSize = True
        Me.lblDecPass.Location = New System.Drawing.Point(26, 207)
        Me.lblDecPass.Name = "lblDecPass"
        Me.lblDecPass.Size = New System.Drawing.Size(79, 20)
        Me.lblDecPass.TabIndex = 4
        Me.lblDecPass.Text = "Passsord:"
        '
        'lblDecSource
        '
        Me.lblDecSource.AutoSize = True
        Me.lblDecSource.Location = New System.Drawing.Point(42, 53)
        Me.lblDecSource.Name = "lblDecSource"
        Me.lblDecSource.Size = New System.Drawing.Size(64, 20)
        Me.lblDecSource.TabIndex = 5
        Me.lblDecSource.Text = "Source:"
        '
        'tabicons
        '
        Me.tabicons.ImageStream = CType(resources.GetObject("tabicons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.tabicons.TransparentColor = System.Drawing.Color.Transparent
        Me.tabicons.Images.SetKeyName(0, "house.png")
        Me.tabicons.Images.SetKeyName(1, "arrow_merge.png")
        Me.tabicons.Images.SetKeyName(2, "arrow_switch.png")
        Me.tabicons.Images.SetKeyName(3, "lock_open.png")
        Me.tabicons.Images.SetKeyName(4, "link.png")
        Me.tabicons.Images.SetKeyName(5, "arrow_rotate_clockwise.png")
        Me.tabicons.Images.SetKeyName(6, "page_key.png")
        Me.tabicons.Images.SetKeyName(7, "application_form_magnify.png")
        Me.tabicons.Images.SetKeyName(8, "key_add.png")
        Me.tabicons.Images.SetKeyName(9, "key_delete.png")
        '
        'PgAES
        '
        Me.PgAES.Controls.Add(Me.btnAEStxtDec)
        Me.PgAES.Controls.Add(Me.btnAEStxtEnc)
        Me.PgAES.Controls.Add(Me.chkAEStxtKey)
        Me.PgAES.Controls.Add(Me.txtAEStxtKey)
        Me.PgAES.Controls.Add(Me.grpAEStxtEncoded)
        Me.PgAES.Controls.Add(Me.grpAEStxtSource)
        Me.PgAES.ImageKey = "link.png"
        Me.PgAES.Location = New System.Drawing.Point(4, 27)
        Me.PgAES.Margin = New System.Windows.Forms.Padding(4)
        Me.PgAES.Name = "PgAES"
        Me.PgAES.Padding = New System.Windows.Forms.Padding(4)
        Me.PgAES.Size = New System.Drawing.Size(725, 367)
        Me.PgAES.TabIndex = 4
        Me.PgAES.Text = "AES"
        Me.PgAES.UseVisualStyleBackColor = True
        '
        'btnAEStxtDec
        '
        Me.btnAEStxtDec.Location = New System.Drawing.Point(629, 3)
        Me.btnAEStxtDec.Name = "btnAEStxtDec"
        Me.btnAEStxtDec.Size = New System.Drawing.Size(88, 34)
        Me.btnAEStxtDec.TabIndex = 18
        Me.btnAEStxtDec.Text = "Decode"
        Me.btnAEStxtDec.UseVisualStyleBackColor = True
        '
        'btnAEStxtEnc
        '
        Me.btnAEStxtEnc.Location = New System.Drawing.Point(538, 3)
        Me.btnAEStxtEnc.Name = "btnAEStxtEnc"
        Me.btnAEStxtEnc.Size = New System.Drawing.Size(85, 34)
        Me.btnAEStxtEnc.TabIndex = 17
        Me.btnAEStxtEnc.Text = "Encode"
        Me.btnAEStxtEnc.UseVisualStyleBackColor = True
        '
        'chkAEStxtKey
        '
        Me.chkAEStxtKey.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkAEStxtKey.AutoSize = True
        Me.chkAEStxtKey.Location = New System.Drawing.Point(479, 3)
        Me.chkAEStxtKey.Name = "chkAEStxtKey"
        Me.chkAEStxtKey.Size = New System.Drawing.Size(49, 30)
        Me.chkAEStxtKey.TabIndex = 16
        Me.chkAEStxtKey.Text = "●●●"
        Me.chkAEStxtKey.UseVisualStyleBackColor = True
        '
        'txtAEStxtKey
        '
        Me.txtAEStxtKey.Location = New System.Drawing.Point(15, 7)
        Me.txtAEStxtKey.Name = "txtAEStxtKey"
        Me.txtAEStxtKey.Size = New System.Drawing.Size(517, 25)
        Me.txtAEStxtKey.TabIndex = 4
        Me.txtAEStxtKey.Text = "Key"
        '
        'grpAEStxtEncoded
        '
        Me.grpAEStxtEncoded.Controls.Add(Me.txtAEStxtFin)
        Me.grpAEStxtEncoded.Location = New System.Drawing.Point(365, 41)
        Me.grpAEStxtEncoded.Name = "grpAEStxtEncoded"
        Me.grpAEStxtEncoded.Size = New System.Drawing.Size(353, 291)
        Me.grpAEStxtEncoded.TabIndex = 0
        Me.grpAEStxtEncoded.TabStop = False
        Me.grpAEStxtEncoded.Text = "Encrypted/Decrypted"
        '
        'txtAEStxtFin
        '
        Me.txtAEStxtFin.ContextMenuStrip = Me.cmsReadOnly
        Me.txtAEStxtFin.Location = New System.Drawing.Point(7, 26)
        Me.txtAEStxtFin.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAEStxtFin.Multiline = True
        Me.txtAEStxtFin.Name = "txtAEStxtFin"
        Me.txtAEStxtFin.ReadOnly = True
        Me.txtAEStxtFin.Size = New System.Drawing.Size(339, 292)
        Me.txtAEStxtFin.TabIndex = 3
        '
        'cmsReadOnly
        '
        Me.cmsReadOnly.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdReadOnlyCopy, Me.cmReadonlyCopyAll})
        Me.cmsReadOnly.Name = "cmsReadOnly"
        Me.cmsReadOnly.Size = New System.Drawing.Size(215, 52)
        '
        'cmdReadOnlyCopy
        '
        Me.cmdReadOnlyCopy.Image = CType(resources.GetObject("cmdReadOnlyCopy.Image"), System.Drawing.Image)
        Me.cmdReadOnlyCopy.Name = "cmdReadOnlyCopy"
        Me.cmdReadOnlyCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.cmdReadOnlyCopy.Size = New System.Drawing.Size(214, 24)
        Me.cmdReadOnlyCopy.Text = "&Copy Selected"
        '
        'cmReadonlyCopyAll
        '
        Me.cmReadonlyCopyAll.Image = CType(resources.GetObject("cmReadonlyCopyAll.Image"), System.Drawing.Image)
        Me.cmReadonlyCopyAll.Name = "cmReadonlyCopyAll"
        Me.cmReadonlyCopyAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmReadonlyCopyAll.Size = New System.Drawing.Size(214, 24)
        Me.cmReadonlyCopyAll.Text = "Copy &All"
        '
        'grpAEStxtSource
        '
        Me.grpAEStxtSource.Controls.Add(Me.txtAEStxtSource)
        Me.grpAEStxtSource.Location = New System.Drawing.Point(8, 41)
        Me.grpAEStxtSource.Name = "grpAEStxtSource"
        Me.grpAEStxtSource.Size = New System.Drawing.Size(351, 291)
        Me.grpAEStxtSource.TabIndex = 0
        Me.grpAEStxtSource.TabStop = False
        Me.grpAEStxtSource.Text = "Source"
        '
        'txtAEStxtSource
        '
        Me.txtAEStxtSource.ContextMenuStrip = Me.cmText
        Me.txtAEStxtSource.Location = New System.Drawing.Point(7, 26)
        Me.txtAEStxtSource.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAEStxtSource.Multiline = True
        Me.txtAEStxtSource.Name = "txtAEStxtSource"
        Me.txtAEStxtSource.Size = New System.Drawing.Size(337, 257)
        Me.txtAEStxtSource.TabIndex = 3
        '
        'cmText
        '
        Me.cmText.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmTextundo, Me.cmTextsep1, Me.cmTextcut, Me.cmTextcopy, Me.cmTextcopyall, Me.cmTextpaste, Me.cmTextdel, Me.cmTextsep2, Me.cmTextselectall})
        Me.cmText.Name = "cmText"
        Me.cmText.Size = New System.Drawing.Size(217, 184)
        '
        'cmTextundo
        '
        Me.cmTextundo.Image = CType(resources.GetObject("cmTextundo.Image"), System.Drawing.Image)
        Me.cmTextundo.Name = "cmTextundo"
        Me.cmTextundo.ShortcutKeyDisplayString = ""
        Me.cmTextundo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.cmTextundo.Size = New System.Drawing.Size(216, 24)
        Me.cmTextundo.Text = "Undo"
        '
        'cmTextsep1
        '
        Me.cmTextsep1.Name = "cmTextsep1"
        Me.cmTextsep1.Size = New System.Drawing.Size(213, 6)
        '
        'cmTextcut
        '
        Me.cmTextcut.Image = CType(resources.GetObject("cmTextcut.Image"), System.Drawing.Image)
        Me.cmTextcut.Name = "cmTextcut"
        Me.cmTextcut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.cmTextcut.Size = New System.Drawing.Size(216, 24)
        Me.cmTextcut.Text = "Cut"
        '
        'cmTextcopy
        '
        Me.cmTextcopy.Image = CType(resources.GetObject("cmTextcopy.Image"), System.Drawing.Image)
        Me.cmTextcopy.Name = "cmTextcopy"
        Me.cmTextcopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.cmTextcopy.Size = New System.Drawing.Size(216, 24)
        Me.cmTextcopy.Text = "Copy Selected"
        '
        'cmTextcopyall
        '
        Me.cmTextcopyall.Image = CType(resources.GetObject("cmTextcopyall.Image"), System.Drawing.Image)
        Me.cmTextcopyall.Name = "cmTextcopyall"
        Me.cmTextcopyall.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.cmTextcopyall.Size = New System.Drawing.Size(216, 24)
        Me.cmTextcopyall.Text = "Copy All"
        '
        'cmTextpaste
        '
        Me.cmTextpaste.Image = CType(resources.GetObject("cmTextpaste.Image"), System.Drawing.Image)
        Me.cmTextpaste.Name = "cmTextpaste"
        Me.cmTextpaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.cmTextpaste.Size = New System.Drawing.Size(216, 24)
        Me.cmTextpaste.Text = "Paste"
        '
        'cmTextdel
        '
        Me.cmTextdel.Image = CType(resources.GetObject("cmTextdel.Image"), System.Drawing.Image)
        Me.cmTextdel.Name = "cmTextdel"
        Me.cmTextdel.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.cmTextdel.Size = New System.Drawing.Size(216, 24)
        Me.cmTextdel.Text = "Delete"
        '
        'cmTextsep2
        '
        Me.cmTextsep2.Name = "cmTextsep2"
        Me.cmTextsep2.Size = New System.Drawing.Size(213, 6)
        '
        'cmTextselectall
        '
        Me.cmTextselectall.Image = CType(resources.GetObject("cmTextselectall.Image"), System.Drawing.Image)
        Me.cmTextselectall.Name = "cmTextselectall"
        Me.cmTextselectall.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.cmTextselectall.Size = New System.Drawing.Size(216, 24)
        Me.cmTextselectall.Text = "Select All"
        '
        'PgB64
        '
        Me.PgB64.Controls.Add(Me.numB64rounds)
        Me.PgB64.Controls.Add(Me.lblB64e)
        Me.PgB64.Controls.Add(Me.txtB64encoded)
        Me.PgB64.Controls.Add(Me.lblB64d)
        Me.PgB64.Controls.Add(Me.txtB64source)
        Me.PgB64.Controls.Add(Me.btnB64Decode)
        Me.PgB64.Controls.Add(Me.btnB64Encode)
        Me.PgB64.ImageKey = "arrow_switch.png"
        Me.PgB64.Location = New System.Drawing.Point(4, 27)
        Me.PgB64.Margin = New System.Windows.Forms.Padding(4)
        Me.PgB64.Name = "PgB64"
        Me.PgB64.Padding = New System.Windows.Forms.Padding(4)
        Me.PgB64.Size = New System.Drawing.Size(725, 367)
        Me.PgB64.TabIndex = 1
        Me.PgB64.Text = "Base 64"
        Me.PgB64.UseVisualStyleBackColor = True
        '
        'numB64rounds
        '
        Me.numB64rounds.Location = New System.Drawing.Point(673, 4)
        Me.numB64rounds.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numB64rounds.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numB64rounds.Name = "numB64rounds"
        Me.numB64rounds.Size = New System.Drawing.Size(44, 25)
        Me.numB64rounds.TabIndex = 11
        Me.numB64rounds.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblB64e
        '
        Me.lblB64e.AutoSize = True
        Me.lblB64e.Location = New System.Drawing.Point(377, 11)
        Me.lblB64e.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblB64e.Name = "lblB64e"
        Me.lblB64e.Size = New System.Drawing.Size(73, 20)
        Me.lblB64e.TabIndex = 5
        Me.lblB64e.Text = "Encoded"
        '
        'txtB64encoded
        '
        Me.txtB64encoded.ContextMenuStrip = Me.cmText
        Me.txtB64encoded.Location = New System.Drawing.Point(381, 39)
        Me.txtB64encoded.Margin = New System.Windows.Forms.Padding(4)
        Me.txtB64encoded.Multiline = True
        Me.txtB64encoded.Name = "txtB64encoded"
        Me.txtB64encoded.Size = New System.Drawing.Size(340, 292)
        Me.txtB64encoded.TabIndex = 4
        '
        'lblB64d
        '
        Me.lblB64d.AutoSize = True
        Me.lblB64d.Location = New System.Drawing.Point(8, 11)
        Me.lblB64d.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblB64d.Name = "lblB64d"
        Me.lblB64d.Size = New System.Drawing.Size(74, 20)
        Me.lblB64d.TabIndex = 3
        Me.lblB64d.Text = "Decoded"
        '
        'txtB64source
        '
        Me.txtB64source.ContextMenuStrip = Me.cmText
        Me.txtB64source.Location = New System.Drawing.Point(4, 39)
        Me.txtB64source.Margin = New System.Windows.Forms.Padding(4)
        Me.txtB64source.Multiline = True
        Me.txtB64source.Name = "txtB64source"
        Me.txtB64source.Size = New System.Drawing.Size(340, 292)
        Me.txtB64source.TabIndex = 2
        '
        'btnB64Decode
        '
        Me.btnB64Decode.Image = CType(resources.GetObject("btnB64Decode.Image"), System.Drawing.Image)
        Me.btnB64Decode.Location = New System.Drawing.Point(351, 223)
        Me.btnB64Decode.Name = "btnB64Decode"
        Me.btnB64Decode.Size = New System.Drawing.Size(25, 25)
        Me.btnB64Decode.TabIndex = 7
        Me.btnB64Decode.UseVisualStyleBackColor = True
        '
        'btnB64Encode
        '
        Me.btnB64Encode.Image = CType(resources.GetObject("btnB64Encode.Image"), System.Drawing.Image)
        Me.btnB64Encode.Location = New System.Drawing.Point(351, 105)
        Me.btnB64Encode.Name = "btnB64Encode"
        Me.btnB64Encode.Size = New System.Drawing.Size(25, 25)
        Me.btnB64Encode.TabIndex = 6
        Me.btnB64Encode.UseVisualStyleBackColor = True
        '
        'PgHash
        '
        Me.PgHash.Controls.Add(Me.chkHashSource)
        Me.PgHash.Controls.Add(Me.txtInt)
        Me.PgHash.Controls.Add(Me.chkHash64)
        Me.PgHash.Controls.Add(Me.txtMD5)
        Me.PgHash.Controls.Add(Me.grpSHA)
        Me.PgHash.Controls.Add(Me.lblHASHint)
        Me.PgHash.Controls.Add(Me.lblMD5)
        Me.PgHash.Controls.Add(Me.lblHashSource)
        Me.PgHash.Controls.Add(Me.txtHashSource)
        Me.PgHash.ImageKey = "arrow_merge.png"
        Me.PgHash.Location = New System.Drawing.Point(4, 27)
        Me.PgHash.Margin = New System.Windows.Forms.Padding(4)
        Me.PgHash.Name = "PgHash"
        Me.PgHash.Padding = New System.Windows.Forms.Padding(4)
        Me.PgHash.Size = New System.Drawing.Size(725, 367)
        Me.PgHash.TabIndex = 0
        Me.PgHash.Text = "Hashes"
        Me.PgHash.UseVisualStyleBackColor = True
        '
        'chkHashSource
        '
        Me.chkHashSource.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkHashSource.AutoSize = True
        Me.chkHashSource.Location = New System.Drawing.Point(579, 298)
        Me.chkHashSource.Name = "chkHashSource"
        Me.chkHashSource.Size = New System.Drawing.Size(112, 30)
        Me.chkHashSource.TabIndex = 15
        Me.chkHashSource.Text = "Mask Source"
        Me.chkHashSource.UseVisualStyleBackColor = True
        '
        'txtInt
        '
        Me.txtInt.ContextMenuStrip = Me.cmsReadOnly
        Me.txtInt.Font = New System.Drawing.Font("Corbel", 8.25!)
        Me.txtInt.Location = New System.Drawing.Point(488, 64)
        Me.txtInt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInt.Name = "txtInt"
        Me.txtInt.ReadOnly = True
        Me.txtInt.Size = New System.Drawing.Size(228, 21)
        Me.txtInt.TabIndex = 6
        Me.txtInt.Text = "757602046"
        '
        'chkHash64
        '
        Me.chkHash64.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkHash64.AutoSize = True
        Me.chkHash64.Location = New System.Drawing.Point(435, 298)
        Me.chkHash64.Name = "chkHash64"
        Me.chkHash64.Size = New System.Drawing.Size(78, 30)
        Me.chkHash64.TabIndex = 7
        Me.chkHash64.Text = "Base 64"
        Me.chkHash64.UseVisualStyleBackColor = True
        '
        'txtMD5
        '
        Me.txtMD5.ContextMenuStrip = Me.cmsReadOnly
        Me.txtMD5.Font = New System.Drawing.Font("Corbel", 8.25!)
        Me.txtMD5.Location = New System.Drawing.Point(488, 32)
        Me.txtMD5.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMD5.Name = "txtMD5"
        Me.txtMD5.ReadOnly = True
        Me.txtMD5.Size = New System.Drawing.Size(228, 21)
        Me.txtMD5.TabIndex = 5
        Me.txtMD5.Text = "d41d8cd98f00b204e9800998ecf8427e"
        '
        'grpSHA
        '
        Me.grpSHA.Controls.Add(Me.txtsha512)
        Me.grpSHA.Controls.Add(Me.lblsha512)
        Me.grpSHA.Controls.Add(Me.txtsha384)
        Me.grpSHA.Controls.Add(Me.lblsha384)
        Me.grpSHA.Controls.Add(Me.txtsha256)
        Me.grpSHA.Controls.Add(Me.txtsha1)
        Me.grpSHA.Controls.Add(Me.lblsha256)
        Me.grpSHA.Controls.Add(Me.lblsha1)
        Me.grpSHA.Location = New System.Drawing.Point(410, 92)
        Me.grpSHA.Margin = New System.Windows.Forms.Padding(4)
        Me.grpSHA.Name = "grpSHA"
        Me.grpSHA.Padding = New System.Windows.Forms.Padding(4)
        Me.grpSHA.Size = New System.Drawing.Size(306, 199)
        Me.grpSHA.TabIndex = 4
        Me.grpSHA.TabStop = False
        Me.grpSHA.Text = "SHA"
        '
        'txtsha512
        '
        Me.txtsha512.ContextMenuStrip = Me.cmsReadOnly
        Me.txtsha512.Font = New System.Drawing.Font("Corbel", 8.25!)
        Me.txtsha512.Location = New System.Drawing.Point(71, 167)
        Me.txtsha512.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsha512.Name = "txtsha512"
        Me.txtsha512.ReadOnly = True
        Me.txtsha512.Size = New System.Drawing.Size(228, 21)
        Me.txtsha512.TabIndex = 14
        Me.txtsha512.Text = "z4PhNX7vuL3xVChQ1m2AB9Yg5AULVxXcg/SpIdNs6c5H0NE8XYXysP+DGNKHfuwvY7kxvUdBeoGlODJ6+" & _
    "SfaPg=="
        '
        'lblsha512
        '
        Me.lblsha512.AutoSize = True
        Me.lblsha512.Location = New System.Drawing.Point(23, 167)
        Me.lblsha512.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsha512.Name = "lblsha512"
        Me.lblsha512.Size = New System.Drawing.Size(36, 20)
        Me.lblsha512.TabIndex = 13
        Me.lblsha512.Text = "512"
        '
        'txtsha384
        '
        Me.txtsha384.ContextMenuStrip = Me.cmsReadOnly
        Me.txtsha384.Font = New System.Drawing.Font("Corbel", 8.25!)
        Me.txtsha384.Location = New System.Drawing.Point(70, 123)
        Me.txtsha384.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsha384.Name = "txtsha384"
        Me.txtsha384.ReadOnly = True
        Me.txtsha384.Size = New System.Drawing.Size(228, 21)
        Me.txtsha384.TabIndex = 12
        Me.txtsha384.Text = "OLBgp1GsljhM2TJ+sbHjaiH9txEUvgdDTAzHv2P24donTt6/529l+9Ua0vFImLlb"
        '
        'lblsha384
        '
        Me.lblsha384.AutoSize = True
        Me.lblsha384.Location = New System.Drawing.Point(22, 123)
        Me.lblsha384.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsha384.Name = "lblsha384"
        Me.lblsha384.Size = New System.Drawing.Size(36, 20)
        Me.lblsha384.TabIndex = 11
        Me.lblsha384.Text = "384"
        '
        'txtsha256
        '
        Me.txtsha256.ContextMenuStrip = Me.cmsReadOnly
        Me.txtsha256.Font = New System.Drawing.Font("Corbel", 8.25!)
        Me.txtsha256.Location = New System.Drawing.Point(70, 76)
        Me.txtsha256.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsha256.Name = "txtsha256"
        Me.txtsha256.ReadOnly = True
        Me.txtsha256.Size = New System.Drawing.Size(228, 21)
        Me.txtsha256.TabIndex = 10
        Me.txtsha256.Text = "47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU="
        '
        'txtsha1
        '
        Me.txtsha1.ContextMenuStrip = Me.cmsReadOnly
        Me.txtsha1.Font = New System.Drawing.Font("Corbel", 8.25!)
        Me.txtsha1.Location = New System.Drawing.Point(70, 29)
        Me.txtsha1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsha1.Name = "txtsha1"
        Me.txtsha1.ReadOnly = True
        Me.txtsha1.Size = New System.Drawing.Size(228, 21)
        Me.txtsha1.TabIndex = 9
        Me.txtsha1.Text = "2jmj7l5rSw0yVb/vlWAYkK/YBwk="
        '
        'lblsha256
        '
        Me.lblsha256.AutoSize = True
        Me.lblsha256.Location = New System.Drawing.Point(22, 76)
        Me.lblsha256.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsha256.Name = "lblsha256"
        Me.lblsha256.Size = New System.Drawing.Size(36, 20)
        Me.lblsha256.TabIndex = 8
        Me.lblsha256.Text = "256"
        '
        'lblsha1
        '
        Me.lblsha1.AutoSize = True
        Me.lblsha1.Location = New System.Drawing.Point(42, 29)
        Me.lblsha1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsha1.Name = "lblsha1"
        Me.lblsha1.Size = New System.Drawing.Size(18, 20)
        Me.lblsha1.TabIndex = 7
        Me.lblsha1.Text = "1"
        '
        'lblHASHint
        '
        Me.lblHASHint.AutoSize = True
        Me.lblHASHint.Location = New System.Drawing.Point(440, 64)
        Me.lblHASHint.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHASHint.Name = "lblHASHint"
        Me.lblHASHint.Size = New System.Drawing.Size(34, 20)
        Me.lblHASHint.TabIndex = 3
        Me.lblHASHint.Text = "INT"
        '
        'lblMD5
        '
        Me.lblMD5.AutoSize = True
        Me.lblMD5.Location = New System.Drawing.Point(431, 32)
        Me.lblMD5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMD5.Name = "lblMD5"
        Me.lblMD5.Size = New System.Drawing.Size(43, 20)
        Me.lblMD5.TabIndex = 2
        Me.lblMD5.Text = "MD5"
        '
        'lblHashSource
        '
        Me.lblHashSource.AutoSize = True
        Me.lblHashSource.Location = New System.Drawing.Point(4, 4)
        Me.lblHashSource.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHashSource.Name = "lblHashSource"
        Me.lblHashSource.Size = New System.Drawing.Size(60, 20)
        Me.lblHashSource.TabIndex = 1
        Me.lblHashSource.Text = "Source"
        '
        'txtHashSource
        '
        Me.txtHashSource.ContextMenuStrip = Me.cmText
        Me.txtHashSource.Location = New System.Drawing.Point(8, 32)
        Me.txtHashSource.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHashSource.Multiline = True
        Me.txtHashSource.Name = "txtHashSource"
        Me.txtHashSource.Size = New System.Drawing.Size(394, 299)
        Me.txtHashSource.TabIndex = 0
        '
        'PgROT13
        '
        Me.PgROT13.Controls.Add(Me.numROTn)
        Me.PgROT13.Controls.Add(Me.lblROTe)
        Me.PgROT13.Controls.Add(Me.txtROTe)
        Me.PgROT13.Controls.Add(Me.lblROTs)
        Me.PgROT13.Controls.Add(Me.txtROTs)
        Me.PgROT13.ImageKey = "arrow_rotate_clockwise.png"
        Me.PgROT13.Location = New System.Drawing.Point(4, 27)
        Me.PgROT13.Name = "PgROT13"
        Me.PgROT13.Size = New System.Drawing.Size(725, 367)
        Me.PgROT13.TabIndex = 5
        Me.PgROT13.Text = "Rotate"
        Me.PgROT13.UseVisualStyleBackColor = True
        '
        'numROTn
        '
        Me.numROTn.Location = New System.Drawing.Point(677, 3)
        Me.numROTn.Maximum = New Decimal(New Integer() {26, 0, 0, 0})
        Me.numROTn.Name = "numROTn"
        Me.numROTn.Size = New System.Drawing.Size(44, 25)
        Me.numROTn.TabIndex = 10
        Me.numROTn.Value = New Decimal(New Integer() {13, 0, 0, 0})
        '
        'lblROTe
        '
        Me.lblROTe.AutoSize = True
        Me.lblROTe.Location = New System.Drawing.Point(367, 9)
        Me.lblROTe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblROTe.Name = "lblROTe"
        Me.lblROTe.Size = New System.Drawing.Size(103, 20)
        Me.lblROTe.TabIndex = 9
        Me.lblROTe.Text = "Transformed:"
        '
        'txtROTe
        '
        Me.txtROTe.ContextMenuStrip = Me.cmsReadOnly
        Me.txtROTe.Location = New System.Drawing.Point(371, 37)
        Me.txtROTe.Margin = New System.Windows.Forms.Padding(4)
        Me.txtROTe.Multiline = True
        Me.txtROTe.Name = "txtROTe"
        Me.txtROTe.ReadOnly = True
        Me.txtROTe.Size = New System.Drawing.Size(350, 294)
        Me.txtROTe.TabIndex = 8
        '
        'lblROTs
        '
        Me.lblROTs.AutoSize = True
        Me.lblROTs.Location = New System.Drawing.Point(9, 9)
        Me.lblROTs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblROTs.Name = "lblROTs"
        Me.lblROTs.Size = New System.Drawing.Size(169, 20)
        Me.lblROTs.TabIndex = 7
        Me.lblROTs.Text = "Source [Skip] {Inverse}"
        '
        'txtROTs
        '
        Me.txtROTs.ContextMenuStrip = Me.cmText
        Me.txtROTs.Location = New System.Drawing.Point(4, 37)
        Me.txtROTs.Margin = New System.Windows.Forms.Padding(4)
        Me.txtROTs.Multiline = True
        Me.txtROTs.Name = "txtROTs"
        Me.txtROTs.Size = New System.Drawing.Size(350, 294)
        Me.txtROTs.TabIndex = 6
        '
        'PgUnSecure
        '
        Me.PgUnSecure.Controls.Add(Me.numUnsec)
        Me.PgUnSecure.Controls.Add(Me.lblUnsecE)
        Me.PgUnSecure.Controls.Add(Me.txtUnsecEncoded)
        Me.PgUnSecure.Controls.Add(Me.lblUnsecp)
        Me.PgUnSecure.Controls.Add(Me.txtUnsecSource)
        Me.PgUnSecure.Controls.Add(Me.btnUnsecDecode)
        Me.PgUnSecure.Controls.Add(Me.btnUnsecEncode)
        Me.PgUnSecure.ImageKey = "lock_open.png"
        Me.PgUnSecure.Location = New System.Drawing.Point(4, 27)
        Me.PgUnSecure.Margin = New System.Windows.Forms.Padding(4)
        Me.PgUnSecure.Name = "PgUnSecure"
        Me.PgUnSecure.Padding = New System.Windows.Forms.Padding(4)
        Me.PgUnSecure.Size = New System.Drawing.Size(725, 367)
        Me.PgUnSecure.TabIndex = 3
        Me.PgUnSecure.Text = "Unsecure"
        Me.PgUnSecure.UseVisualStyleBackColor = True
        '
        'numUnsec
        '
        Me.numUnsec.Location = New System.Drawing.Point(676, 10)
        Me.numUnsec.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.numUnsec.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numUnsec.Name = "numUnsec"
        Me.numUnsec.Size = New System.Drawing.Size(42, 25)
        Me.numUnsec.TabIndex = 18
        Me.numUnsec.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblUnsecE
        '
        Me.lblUnsecE.AutoSize = True
        Me.lblUnsecE.Location = New System.Drawing.Point(378, 14)
        Me.lblUnsecE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUnsecE.Name = "lblUnsecE"
        Me.lblUnsecE.Size = New System.Drawing.Size(206, 20)
        Me.lblUnsecE.TabIndex = 15
        Me.lblUnsecE.Text = "Encoded (Unsecure Cipher)"
        '
        'txtUnsecEncoded
        '
        Me.txtUnsecEncoded.ContextMenuStrip = Me.cmText
        Me.txtUnsecEncoded.Location = New System.Drawing.Point(382, 42)
        Me.txtUnsecEncoded.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnsecEncoded.Multiline = True
        Me.txtUnsecEncoded.Name = "txtUnsecEncoded"
        Me.txtUnsecEncoded.Size = New System.Drawing.Size(340, 292)
        Me.txtUnsecEncoded.TabIndex = 14
        '
        'lblUnsecp
        '
        Me.lblUnsecp.AutoSize = True
        Me.lblUnsecp.Location = New System.Drawing.Point(9, 14)
        Me.lblUnsecp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUnsecp.Name = "lblUnsecp"
        Me.lblUnsecp.Size = New System.Drawing.Size(259, 20)
        Me.lblUnsecp.TabIndex = 13
        Me.lblUnsecp.Text = "Decoded (Plain-Text, use Alphabet)"
        '
        'txtUnsecSource
        '
        Me.txtUnsecSource.ContextMenuStrip = Me.cmText
        Me.txtUnsecSource.Location = New System.Drawing.Point(5, 42)
        Me.txtUnsecSource.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnsecSource.Multiline = True
        Me.txtUnsecSource.Name = "txtUnsecSource"
        Me.txtUnsecSource.Size = New System.Drawing.Size(340, 292)
        Me.txtUnsecSource.TabIndex = 12
        '
        'btnUnsecDecode
        '
        Me.btnUnsecDecode.Image = CType(resources.GetObject("btnUnsecDecode.Image"), System.Drawing.Image)
        Me.btnUnsecDecode.Location = New System.Drawing.Point(352, 226)
        Me.btnUnsecDecode.Name = "btnUnsecDecode"
        Me.btnUnsecDecode.Size = New System.Drawing.Size(25, 25)
        Me.btnUnsecDecode.TabIndex = 17
        Me.btnUnsecDecode.UseVisualStyleBackColor = True
        '
        'btnUnsecEncode
        '
        Me.btnUnsecEncode.Image = CType(resources.GetObject("btnUnsecEncode.Image"), System.Drawing.Image)
        Me.btnUnsecEncode.Location = New System.Drawing.Point(352, 108)
        Me.btnUnsecEncode.Name = "btnUnsecEncode"
        Me.btnUnsecEncode.Size = New System.Drawing.Size(25, 25)
        Me.btnUnsecEncode.TabIndex = 16
        Me.btnUnsecEncode.UseVisualStyleBackColor = True
        '
        'PgLuhn
        '
        Me.PgLuhn.Controls.Add(Me.grpResults)
        Me.PgLuhn.Controls.Add(Me.grpCalculations)
        Me.PgLuhn.Controls.Add(Me.grpNumber)
        Me.PgLuhn.Controls.Add(Me.tsLuhn)
        Me.PgLuhn.ImageKey = "application_form_magnify.png"
        Me.PgLuhn.Location = New System.Drawing.Point(4, 27)
        Me.PgLuhn.Name = "PgLuhn"
        Me.PgLuhn.Size = New System.Drawing.Size(725, 367)
        Me.PgLuhn.TabIndex = 7
        Me.PgLuhn.Text = "Luhn"
        Me.PgLuhn.UseVisualStyleBackColor = True
        '
        'grpResults
        '
        Me.grpResults.Controls.Add(Me.chkLuhn)
        Me.grpResults.Controls.Add(Me.pbLuhn)
        Me.grpResults.Location = New System.Drawing.Point(310, 39)
        Me.grpResults.Name = "grpResults"
        Me.grpResults.Size = New System.Drawing.Size(407, 80)
        Me.grpResults.TabIndex = 5
        Me.grpResults.TabStop = False
        Me.grpResults.Text = "Results"
        '
        'chkLuhn
        '
        Me.chkLuhn.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkLuhn.AutoSize = True
        Me.chkLuhn.Enabled = False
        Me.chkLuhn.Location = New System.Drawing.Point(291, 30)
        Me.chkLuhn.Name = "chkLuhn"
        Me.chkLuhn.Size = New System.Drawing.Size(96, 30)
        Me.chkLuhn.TabIndex = 4
        Me.chkLuhn.Text = "Invalid (00)"
        Me.chkLuhn.UseVisualStyleBackColor = True
        '
        'pbLuhn
        '
        Me.pbLuhn.Location = New System.Drawing.Point(6, 27)
        Me.pbLuhn.Maximum = 10
        Me.pbLuhn.Name = "pbLuhn"
        Me.pbLuhn.Size = New System.Drawing.Size(279, 41)
        Me.pbLuhn.Step = 1
        Me.pbLuhn.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbLuhn.TabIndex = 2
        '
        'grpCalculations
        '
        Me.grpCalculations.Controls.Add(Me.lblLuhnExp)
        Me.grpCalculations.Controls.Add(Me.lblLuhnNum)
        Me.grpCalculations.Location = New System.Drawing.Point(8, 125)
        Me.grpCalculations.Name = "grpCalculations"
        Me.grpCalculations.Size = New System.Drawing.Size(709, 207)
        Me.grpCalculations.TabIndex = 4
        Me.grpCalculations.TabStop = False
        Me.grpCalculations.Text = "Example"
        '
        'lblLuhnExp
        '
        Me.lblLuhnExp.AutoSize = True
        Me.lblLuhnExp.Location = New System.Drawing.Point(21, 57)
        Me.lblLuhnExp.Name = "lblLuhnExp"
        Me.lblLuhnExp.Size = New System.Drawing.Size(555, 120)
        Me.lblLuhnExp.TabIndex = 1
        Me.lblLuhnExp.Text = resources.GetString("lblLuhnExp.Text")
        '
        'lblLuhnNum
        '
        Me.lblLuhnNum.AutoSize = True
        Me.lblLuhnNum.Font = New System.Drawing.Font("Agency FB", 19.96639!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLuhnNum.ForeColor = System.Drawing.Color.GreenYellow
        Me.lblLuhnNum.Location = New System.Drawing.Point(296, 15)
        Me.lblLuhnNum.Name = "lblLuhnNum"
        Me.lblLuhnNum.Size = New System.Drawing.Size(95, 33)
        Me.lblLuhnNum.TabIndex = 0
        Me.lblLuhnNum.Text = "1234567&9"
        '
        'grpNumber
        '
        Me.grpNumber.Controls.Add(Me.txtLuhnNumber)
        Me.grpNumber.Location = New System.Drawing.Point(8, 39)
        Me.grpNumber.Name = "grpNumber"
        Me.grpNumber.Size = New System.Drawing.Size(296, 80)
        Me.grpNumber.TabIndex = 3
        Me.grpNumber.TabStop = False
        Me.grpNumber.Text = "Number"
        '
        'txtLuhnNumber
        '
        Me.txtLuhnNumber.ContextMenuStrip = Me.cmText
        Me.txtLuhnNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.15126!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLuhnNumber.Location = New System.Drawing.Point(6, 27)
        Me.txtLuhnNumber.Mask = "0000000000000000"
        Me.txtLuhnNumber.Name = "txtLuhnNumber"
        Me.txtLuhnNumber.Size = New System.Drawing.Size(284, 36)
        Me.txtLuhnNumber.TabIndex = 1
        '
        'tsLuhn
        '
        Me.tsLuhn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslLuhnTs, Me.tssLuhn1, Me.tsSBvalid, Me.tsSBinvalid})
        Me.tsLuhn.Location = New System.Drawing.Point(0, 0)
        Me.tsLuhn.Name = "tsLuhn"
        Me.tsLuhn.Size = New System.Drawing.Size(725, 26)
        Me.tsLuhn.TabIndex = 0
        '
        'tslLuhnTs
        '
        Me.tslLuhnTs.Name = "tslLuhnTs"
        Me.tslLuhnTs.Size = New System.Drawing.Size(158, 23)
        Me.tslLuhnTs.Text = "Luhn Algorithm Checker"
        '
        'tssLuhn1
        '
        Me.tssLuhn1.Name = "tssLuhn1"
        Me.tssLuhn1.Size = New System.Drawing.Size(6, 26)
        '
        'tsSBvalid
        '
        Me.tsSBvalid.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsCBvalid})
        Me.tsSBvalid.Image = CType(resources.GetObject("tsSBvalid.Image"), System.Drawing.Image)
        Me.tsSBvalid.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSBvalid.Name = "tsSBvalid"
        Me.tsSBvalid.Size = New System.Drawing.Size(131, 23)
        Me.tsSBvalid.Text = "Generate Valid"
        '
        'tsCBvalid
        '
        Me.tsCBvalid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tsCBvalid.Items.AddRange(New Object() {"2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16"})
        Me.tsCBvalid.Name = "tsCBvalid"
        Me.tsCBvalid.Size = New System.Drawing.Size(121, 27)
        '
        'tsSBinvalid
        '
        Me.tsSBinvalid.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsCBinvalid})
        Me.tsSBinvalid.Image = CType(resources.GetObject("tsSBinvalid.Image"), System.Drawing.Image)
        Me.tsSBinvalid.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSBinvalid.Name = "tsSBinvalid"
        Me.tsSBinvalid.Size = New System.Drawing.Size(141, 23)
        Me.tsSBinvalid.Text = "Generate Invalid"
        '
        'tsCBinvalid
        '
        Me.tsCBinvalid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tsCBinvalid.Items.AddRange(New Object() {"2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16"})
        Me.tsCBinvalid.Name = "tsCBinvalid"
        Me.tsCBinvalid.Size = New System.Drawing.Size(121, 27)
        '
        'statstrip
        '
        Me.statstrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmAbout, Me.progress})
        Me.statstrip.Location = New System.Drawing.Point(0, 373)
        Me.statstrip.Name = "statstrip"
        Me.statstrip.Padding = New System.Windows.Forms.Padding(1, 0, 18, 0)
        Me.statstrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.statstrip.Size = New System.Drawing.Size(733, 25)
        Me.statstrip.SizingGrip = False
        Me.statstrip.TabIndex = 1
        Me.statstrip.Text = "StatusStrip1"
        '
        'cmAbout
        '
        Me.cmAbout.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptimizedForToolStripMenuItem})
        Me.cmAbout.Image = CType(resources.GetObject("cmAbout.Image"), System.Drawing.Image)
        Me.cmAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmAbout.Name = "cmAbout"
        Me.cmAbout.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmAbout.Size = New System.Drawing.Size(79, 23)
        Me.cmAbout.Text = "About"
        '
        'OptimizedForToolStripMenuItem
        '
        Me.OptimizedForToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WindowsXPToolStripMenuItem, Me.DPI100125ToolStripMenuItem})
        Me.OptimizedForToolStripMenuItem.Image = CType(resources.GetObject("OptimizedForToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OptimizedForToolStripMenuItem.Name = "OptimizedForToolStripMenuItem"
        Me.OptimizedForToolStripMenuItem.Size = New System.Drawing.Size(156, 24)
        Me.OptimizedForToolStripMenuItem.Text = "Designed for"
        '
        'WindowsXPToolStripMenuItem
        '
        Me.WindowsXPToolStripMenuItem.Image = CType(resources.GetObject("WindowsXPToolStripMenuItem.Image"), System.Drawing.Image)
        Me.WindowsXPToolStripMenuItem.Name = "WindowsXPToolStripMenuItem"
        Me.WindowsXPToolStripMenuItem.Size = New System.Drawing.Size(158, 24)
        Me.WindowsXPToolStripMenuItem.Text = "Windows"
        '
        'DPI100125ToolStripMenuItem
        '
        Me.DPI100125ToolStripMenuItem.Image = CType(resources.GetObject("DPI100125ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DPI100125ToolStripMenuItem.Name = "DPI100125ToolStripMenuItem"
        Me.DPI100125ToolStripMenuItem.Size = New System.Drawing.Size(158, 24)
        Me.DPI100125ToolStripMenuItem.Text = "DPI 100-125"
        '
        'progress
        '
        Me.progress.Name = "progress"
        Me.progress.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always
        Me.progress.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.progress.Size = New System.Drawing.Size(125, 19)
        Me.progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.progress.Value = 100
        '
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 398)
        Me.Controls.Add(Me.statstrip)
        Me.Controls.Add(Me.tcEncryption)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.89076!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Victor's Encryption Tools"
        Me.tcEncryption.ResumeLayout(False)
        Me.PgHome.ResumeLayout(False)
        Me.grpLuhm.ResumeLayout(False)
        Me.grpLuhm.PerformLayout()
        Me.grpUnsec.ResumeLayout(False)
        Me.grpUnsec.PerformLayout()
        Me.grpROT.ResumeLayout(False)
        Me.grpROT.PerformLayout()
        Me.grpHashes.ResumeLayout(False)
        Me.grpHashes.PerformLayout()
        Me.grpB64.ResumeLayout(False)
        Me.grpB64.PerformLayout()
        Me.grpAES.ResumeLayout(False)
        Me.grpAES.PerformLayout()
        Me.PgFile.ResumeLayout(False)
        Me.PgFile.PerformLayout()
        Me.tcAESfile.ResumeLayout(False)
        Me.tpAESfileEnc.ResumeLayout(False)
        Me.tpAESfileEnc.PerformLayout()
        Me.tpAESfileDec.ResumeLayout(False)
        Me.tpAESfileDec.PerformLayout()
        Me.PgAES.ResumeLayout(False)
        Me.PgAES.PerformLayout()
        Me.grpAEStxtEncoded.ResumeLayout(False)
        Me.grpAEStxtEncoded.PerformLayout()
        Me.cmsReadOnly.ResumeLayout(False)
        Me.grpAEStxtSource.ResumeLayout(False)
        Me.grpAEStxtSource.PerformLayout()
        Me.cmText.ResumeLayout(False)
        Me.PgB64.ResumeLayout(False)
        Me.PgB64.PerformLayout()
        CType(Me.numB64rounds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PgHash.ResumeLayout(False)
        Me.PgHash.PerformLayout()
        Me.grpSHA.ResumeLayout(False)
        Me.grpSHA.PerformLayout()
        Me.PgROT13.ResumeLayout(False)
        Me.PgROT13.PerformLayout()
        CType(Me.numROTn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PgUnSecure.ResumeLayout(False)
        Me.PgUnSecure.PerformLayout()
        CType(Me.numUnsec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PgLuhn.ResumeLayout(False)
        Me.PgLuhn.PerformLayout()
        Me.grpResults.ResumeLayout(False)
        Me.grpResults.PerformLayout()
        Me.grpCalculations.ResumeLayout(False)
        Me.grpCalculations.PerformLayout()
        Me.grpNumber.ResumeLayout(False)
        Me.grpNumber.PerformLayout()
        Me.tsLuhn.ResumeLayout(False)
        Me.tsLuhn.PerformLayout()
        Me.statstrip.ResumeLayout(False)
        Me.statstrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tcEncryption As System.Windows.Forms.TabControl
    Friend WithEvents PgHash As System.Windows.Forms.TabPage
    Friend WithEvents PgB64 As System.Windows.Forms.TabPage
    Friend WithEvents statstrip As System.Windows.Forms.StatusStrip
    Friend WithEvents PgHome As System.Windows.Forms.TabPage
    Friend WithEvents PgAES As System.Windows.Forms.TabPage
    Friend WithEvents lblHashSource As System.Windows.Forms.Label
    Friend WithEvents txtHashSource As System.Windows.Forms.TextBox
    Friend WithEvents lblHASHint As System.Windows.Forms.Label
    Friend WithEvents lblMD5 As System.Windows.Forms.Label
    Friend WithEvents grpSHA As System.Windows.Forms.GroupBox
    Friend WithEvents txtMD5 As System.Windows.Forms.TextBox
    Friend WithEvents txtInt As System.Windows.Forms.TextBox
    Friend WithEvents txtsha512 As System.Windows.Forms.TextBox
    Friend WithEvents lblsha512 As System.Windows.Forms.Label
    Friend WithEvents txtsha384 As System.Windows.Forms.TextBox
    Friend WithEvents lblsha384 As System.Windows.Forms.Label
    Friend WithEvents txtsha256 As System.Windows.Forms.TextBox
    Friend WithEvents txtsha1 As System.Windows.Forms.TextBox
    Friend WithEvents lblsha256 As System.Windows.Forms.Label
    Friend WithEvents lblsha1 As System.Windows.Forms.Label
    Friend WithEvents chkHash64 As System.Windows.Forms.CheckBox
    Friend WithEvents tabicons As System.Windows.Forms.ImageList
    Friend WithEvents lblB64e As System.Windows.Forms.Label
    Friend WithEvents txtB64encoded As System.Windows.Forms.TextBox
    Friend WithEvents lblB64d As System.Windows.Forms.Label
    Friend WithEvents txtB64source As System.Windows.Forms.TextBox
    Friend WithEvents btnB64Encode As System.Windows.Forms.Button
    Friend WithEvents btnB64Decode As System.Windows.Forms.Button
    Friend WithEvents PgROT13 As System.Windows.Forms.TabPage
    Friend WithEvents PgFile As System.Windows.Forms.TabPage
    Friend WithEvents cmAbout As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents lblROTe As System.Windows.Forms.Label
    Friend WithEvents txtROTe As System.Windows.Forms.TextBox
    Friend WithEvents lblROTs As System.Windows.Forms.Label
    Friend WithEvents txtROTs As System.Windows.Forms.TextBox
    Friend WithEvents numROTn As System.Windows.Forms.NumericUpDown
    Friend WithEvents numB64rounds As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkHashSource As System.Windows.Forms.CheckBox
    Friend WithEvents cmsReadOnly As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdReadOnlyCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmReadonlyCopyAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmText As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmTextundo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmTextsep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmTextcut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmTextcopyall As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmTextcopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmTextpaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmTextsep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmTextselectall As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmTextdel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptimizedForToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsXPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DPI100125ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PgLuhn As System.Windows.Forms.TabPage
    Friend WithEvents grpLuhm As System.Windows.Forms.GroupBox
    Friend WithEvents grpUnsec As System.Windows.Forms.GroupBox
    Friend WithEvents grpROT As System.Windows.Forms.GroupBox
    Friend WithEvents grpHashes As System.Windows.Forms.GroupBox
    Friend WithEvents grpB64 As System.Windows.Forms.GroupBox
    Friend WithEvents grpAES As System.Windows.Forms.GroupBox
    Friend WithEvents lblAES As System.Windows.Forms.Label
    Friend WithEvents lblLuhm As System.Windows.Forms.Label
    Friend WithEvents lblUnsec As System.Windows.Forms.Label
    Friend WithEvents lblROT As System.Windows.Forms.Label
    Friend WithEvents lblHashes As System.Windows.Forms.Label
    Friend WithEvents lblB64 As System.Windows.Forms.Label
    Friend WithEvents tsLuhn As System.Windows.Forms.ToolStrip
    Friend WithEvents tslLuhnTs As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tssLuhn1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsSBvalid As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tsSBinvalid As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tsCBvalid As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tsCBinvalid As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents txtLuhnNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents grpNumber As System.Windows.Forms.GroupBox
    Friend WithEvents pbLuhn As System.Windows.Forms.ProgressBar
    Friend WithEvents grpResults As System.Windows.Forms.GroupBox
    Friend WithEvents chkLuhn As System.Windows.Forms.CheckBox
    Friend WithEvents grpCalculations As System.Windows.Forms.GroupBox
    Friend WithEvents lblLuhnNum As System.Windows.Forms.Label
    Friend WithEvents lblLuhnExp As System.Windows.Forms.Label
    Friend WithEvents progress As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents PgUnSecure As System.Windows.Forms.TabPage
    Friend WithEvents numUnsec As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnUnsecDecode As System.Windows.Forms.Button
    Friend WithEvents btnUnsecEncode As System.Windows.Forms.Button
    Friend WithEvents lblUnsecE As System.Windows.Forms.Label
    Friend WithEvents txtUnsecEncoded As System.Windows.Forms.TextBox
    Friend WithEvents lblUnsecp As System.Windows.Forms.Label
    Friend WithEvents txtUnsecSource As System.Windows.Forms.TextBox
    Friend WithEvents grpAEStxtEncoded As System.Windows.Forms.GroupBox
    Friend WithEvents grpAEStxtSource As System.Windows.Forms.GroupBox
    Friend WithEvents txtAEStxtKey As System.Windows.Forms.TextBox
    Friend WithEvents txtAEStxtFin As System.Windows.Forms.TextBox
    Friend WithEvents txtAEStxtSource As System.Windows.Forms.TextBox
    Friend WithEvents chkAEStxtKey As System.Windows.Forms.CheckBox
    Friend WithEvents btnAEStxtDec As System.Windows.Forms.Button
    Friend WithEvents btnAEStxtEnc As System.Windows.Forms.Button
    Friend WithEvents tcAESfile As System.Windows.Forms.TabControl
    Friend WithEvents tpAESfileEnc As System.Windows.Forms.TabPage
    Friend WithEvents tpAESfileDec As System.Windows.Forms.TabPage
    Friend WithEvents chkFile As System.Windows.Forms.CheckBox
    Friend WithEvents lblEncCon As System.Windows.Forms.Label
    Friend WithEvents lblEncDest As System.Windows.Forms.Label
    Friend WithEvents lblEncKey As System.Windows.Forms.Label
    Friend WithEvents lblEncSource As System.Windows.Forms.Label
    Friend WithEvents txtFileEncCon As System.Windows.Forms.TextBox
    Friend WithEvents txtFileEncPass As System.Windows.Forms.TextBox
    Friend WithEvents txtFileEncDest As System.Windows.Forms.TextBox
    Friend WithEvents txtFileEncSource As System.Windows.Forms.TextBox
    Friend WithEvents btnFileEnc As System.Windows.Forms.Button
    Friend WithEvents btnFileEncDest As System.Windows.Forms.Button
    Friend WithEvents btnFileEncBrowse As System.Windows.Forms.Button
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents fbd As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnFileDec As System.Windows.Forms.Button
    Friend WithEvents btnFileDecDest As System.Windows.Forms.Button
    Friend WithEvents btnFileDecBrowse As System.Windows.Forms.Button
    Friend WithEvents txtFileDecPass As System.Windows.Forms.TextBox
    Friend WithEvents txtFileDecDest As System.Windows.Forms.TextBox
    Friend WithEvents txtFileDecSource As System.Windows.Forms.TextBox
    Friend WithEvents lblDecDest As System.Windows.Forms.Label
    Friend WithEvents lblDecPass As System.Windows.Forms.Label
    Friend WithEvents lblDecSource As System.Windows.Forms.Label

End Class
