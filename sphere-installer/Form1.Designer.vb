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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblWelcomeText = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblGreenResetText = New System.Windows.Forms.Label()
        Me.lblGreenResetTitle = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblWikimediaLink1 = New System.Windows.Forms.LinkLabel()
        Me.lblConnectSerialText = New System.Windows.Forms.Label()
        Me.lblConnectSerialTitle = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblPickCOMTitle = New System.Windows.Forms.Label()
        Me.lblPickCOMText = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblBeginTitle = New System.Windows.Forms.Label()
        Me.lblBeginText = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnToggleSerialLog = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSerial = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.serMain = New System.IO.Ports.SerialPort(Me.components)
        Me.lblSearchStatus = New System.Windows.Forms.Label()
        Me.btnLoadPorts = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblCompleteTitle = New System.Windows.Forms.Label()
        Me.lblCompleteText = New System.Windows.Forms.Label()
        Me.lblSphereLink = New System.Windows.Forms.LinkLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.picUSBMini = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picGreenReset = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUSBMini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGreenReset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblWelcome)
        Me.Panel1.Controls.Add(Me.lblWelcomeText)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(503, 448)
        Me.Panel1.TabIndex = 0
        '
        'lblWelcome
        '
        Me.lblWelcome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(12, 12)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(331, 24)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome to the sphere-installer setup!"
        '
        'lblWelcomeText
        '
        Me.lblWelcomeText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWelcomeText.Location = New System.Drawing.Point(16, 40)
        Me.lblWelcomeText.Name = "lblWelcomeText"
        Me.lblWelcomeText.Size = New System.Drawing.Size(474, 116)
        Me.lblWelcomeText.TabIndex = 1
        Me.lblWelcomeText.Text = resources.GetString("lblWelcomeText.Text")
        '
        'btnNext
        '
        Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext.Location = New System.Drawing.Point(409, 459)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "&Next >"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrev.Enabled = False
        Me.btnPrev.Location = New System.Drawing.Point(328, 459)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(75, 23)
        Me.btnPrev.TabIndex = 2
        Me.btnPrev.Text = "< &Previous"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(247, 459)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.picGreenReset)
        Me.Panel2.Controls.Add(Me.lblGreenResetText)
        Me.Panel2.Controls.Add(Me.lblGreenResetTitle)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(503, 448)
        Me.Panel2.TabIndex = 4
        Me.Panel2.Visible = False
        '
        'lblGreenResetText
        '
        Me.lblGreenResetText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGreenResetText.Location = New System.Drawing.Point(12, 40)
        Me.lblGreenResetText.Name = "lblGreenResetText"
        Me.lblGreenResetText.Size = New System.Drawing.Size(471, 82)
        Me.lblGreenResetText.TabIndex = 1
        Me.lblGreenResetText.Text = resources.GetString("lblGreenResetText.Text")
        '
        'lblGreenResetTitle
        '
        Me.lblGreenResetTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGreenResetTitle.AutoSize = True
        Me.lblGreenResetTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreenResetTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblGreenResetTitle.Name = "lblGreenResetTitle"
        Me.lblGreenResetTitle.Size = New System.Drawing.Size(288, 24)
        Me.lblGreenResetTitle.TabIndex = 0
        Me.lblGreenResetTitle.Text = "Step 1: Green Reset your Sphere"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.Window
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblWikimediaLink1)
        Me.Panel3.Controls.Add(Me.lblConnectSerialText)
        Me.Panel3.Controls.Add(Me.lblConnectSerialTitle)
        Me.Panel3.Controls.Add(Me.picUSBMini)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(503, 448)
        Me.Panel3.TabIndex = 5
        Me.Panel3.Visible = False
        '
        'lblWikimediaLink1
        '
        Me.lblWikimediaLink1.AutoSize = True
        Me.lblWikimediaLink1.Location = New System.Drawing.Point(4, 430)
        Me.lblWikimediaLink1.Name = "lblWikimediaLink1"
        Me.lblWikimediaLink1.Size = New System.Drawing.Size(154, 13)
        Me.lblWikimediaLink1.TabIndex = 3
        Me.lblWikimediaLink1.TabStop = True
        Me.lblWikimediaLink1.Text = "Image via Wikimedia Commons"
        '
        'lblConnectSerialText
        '
        Me.lblConnectSerialText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblConnectSerialText.Location = New System.Drawing.Point(16, 40)
        Me.lblConnectSerialText.Name = "lblConnectSerialText"
        Me.lblConnectSerialText.Size = New System.Drawing.Size(474, 82)
        Me.lblConnectSerialText.TabIndex = 1
        Me.lblConnectSerialText.Text = resources.GetString("lblConnectSerialText.Text")
        '
        'lblConnectSerialTitle
        '
        Me.lblConnectSerialTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblConnectSerialTitle.AutoSize = True
        Me.lblConnectSerialTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnectSerialTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblConnectSerialTitle.Name = "lblConnectSerialTitle"
        Me.lblConnectSerialTitle.Size = New System.Drawing.Size(253, 24)
        Me.lblConnectSerialTitle.TabIndex = 0
        Me.lblConnectSerialTitle.Text = "Step 2: Connect your Sphere"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.LinkLabel1)
        Me.Panel4.Controls.Add(Me.btnLoadPorts)
        Me.Panel4.Controls.Add(Me.lblSearchStatus)
        Me.Panel4.Controls.Add(Me.lblPickCOMTitle)
        Me.Panel4.Controls.Add(Me.lblPickCOMText)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(503, 448)
        Me.Panel4.TabIndex = 24
        Me.Panel4.Visible = False
        '
        'lblPickCOMTitle
        '
        Me.lblPickCOMTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPickCOMTitle.AutoSize = True
        Me.lblPickCOMTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPickCOMTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblPickCOMTitle.Name = "lblPickCOMTitle"
        Me.lblPickCOMTitle.Size = New System.Drawing.Size(199, 24)
        Me.lblPickCOMTitle.TabIndex = 0
        Me.lblPickCOMTitle.Text = "Step 3: Your COM port"
        '
        'lblPickCOMText
        '
        Me.lblPickCOMText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPickCOMText.Location = New System.Drawing.Point(16, 40)
        Me.lblPickCOMText.Name = "lblPickCOMText"
        Me.lblPickCOMText.Size = New System.Drawing.Size(474, 116)
        Me.lblPickCOMText.TabIndex = 1
        Me.lblPickCOMText.Text = resources.GetString("lblPickCOMText.Text")
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.SystemColors.Window
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.lblBeginTitle)
        Me.Panel5.Controls.Add(Me.lblBeginText)
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(503, 448)
        Me.Panel5.TabIndex = 25
        Me.Panel5.Visible = False
        '
        'lblBeginTitle
        '
        Me.lblBeginTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBeginTitle.AutoSize = True
        Me.lblBeginTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeginTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblBeginTitle.Name = "lblBeginTitle"
        Me.lblBeginTitle.Size = New System.Drawing.Size(200, 24)
        Me.lblBeginTitle.TabIndex = 0
        Me.lblBeginTitle.Text = "Step 4: Ready to begin"
        '
        'lblBeginText
        '
        Me.lblBeginText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBeginText.Location = New System.Drawing.Point(16, 40)
        Me.lblBeginText.Name = "lblBeginText"
        Me.lblBeginText.Size = New System.Drawing.Size(474, 63)
        Me.lblBeginText.TabIndex = 1
        Me.lblBeginText.Text = resources.GetString("lblBeginText.Text")
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.SystemColors.Window
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.btnToggleSerialLog)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.txtSerial)
        Me.Panel6.Controls.Add(Me.txtStatus)
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(503, 448)
        Me.Panel6.TabIndex = 26
        Me.Panel6.Visible = False
        '
        'btnToggleSerialLog
        '
        Me.btnToggleSerialLog.Location = New System.Drawing.Point(408, 410)
        Me.btnToggleSerialLog.Name = "btnToggleSerialLog"
        Me.btnToggleSerialLog.Size = New System.Drawing.Size(75, 23)
        Me.btnToggleSerialLog.TabIndex = 4
        Me.btnToggleSerialLog.Text = "Show Serial"
        Me.btnToggleSerialLog.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Step 5: Installing"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point(16, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(474, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Please wait, installing sphere-installer.."
        '
        'txtSerial
        '
        Me.txtSerial.Location = New System.Drawing.Point(19, 67)
        Me.txtSerial.Multiline = True
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Size = New System.Drawing.Size(471, 337)
        Me.txtSerial.TabIndex = 3
        Me.txtSerial.Visible = False
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(19, 68)
        Me.txtStatus.Multiline = True
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(471, 336)
        Me.txtStatus.TabIndex = 2
        '
        'serMain
        '
        '
        'lblSearchStatus
        '
        Me.lblSearchStatus.AutoSize = True
        Me.lblSearchStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchStatus.Location = New System.Drawing.Point(19, 160)
        Me.lblSearchStatus.Name = "lblSearchStatus"
        Me.lblSearchStatus.Size = New System.Drawing.Size(166, 24)
        Me.lblSearchStatus.TabIndex = 2
        Me.lblSearchStatus.Text = "Status: Searching.."
        '
        'btnLoadPorts
        '
        Me.btnLoadPorts.Location = New System.Drawing.Point(407, 409)
        Me.btnLoadPorts.Name = "btnLoadPorts"
        Me.btnLoadPorts.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadPorts.TabIndex = 3
        Me.btnLoadPorts.Text = "Refresh"
        Me.btnLoadPorts.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 418)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(201, 13)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Forum: How to install Gadget Serial driver"
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.SystemColors.Window
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.PictureBox2)
        Me.Panel7.Controls.Add(Me.lblSphereLink)
        Me.Panel7.Controls.Add(Me.lblCompleteTitle)
        Me.Panel7.Controls.Add(Me.lblCompleteText)
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(503, 448)
        Me.Panel7.TabIndex = 27
        Me.Panel7.Visible = False
        '
        'lblCompleteTitle
        '
        Me.lblCompleteTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCompleteTitle.AutoSize = True
        Me.lblCompleteTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompleteTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblCompleteTitle.Name = "lblCompleteTitle"
        Me.lblCompleteTitle.Size = New System.Drawing.Size(187, 24)
        Me.lblCompleteTitle.TabIndex = 0
        Me.lblCompleteTitle.Text = "Installation Complete!"
        '
        'lblCompleteText
        '
        Me.lblCompleteText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCompleteText.Location = New System.Drawing.Point(16, 40)
        Me.lblCompleteText.Name = "lblCompleteText"
        Me.lblCompleteText.Size = New System.Drawing.Size(474, 82)
        Me.lblCompleteText.TabIndex = 1
        Me.lblCompleteText.Text = resources.GetString("lblCompleteText.Text")
        '
        'lblSphereLink
        '
        Me.lblSphereLink.AutoSize = True
        Me.lblSphereLink.Location = New System.Drawing.Point(7, 418)
        Me.lblSphereLink.Name = "lblSphereLink"
        Me.lblSphereLink.Size = New System.Drawing.Size(208, 13)
        Me.lblSphereLink.TabIndex = 2
        Me.lblSphereLink.TabStop = True
        Me.lblSphereLink.Text = "Visit the Ninja Sphere Labs in your browser"
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.sphere_installer.My.Resources.Resources.PayPal_Donate_Button
        Me.PictureBox2.Location = New System.Drawing.Point(383, 386)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(99, 47)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'picUSBMini
        '
        Me.picUSBMini.Image = Global.sphere_installer.My.Resources.Resources.USB_Mini
        Me.picUSBMini.Location = New System.Drawing.Point(-1, 106)
        Me.picUSBMini.Name = "picUSBMini"
        Me.picUSBMini.Size = New System.Drawing.Size(512, 342)
        Me.picUSBMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picUSBMini.TabIndex = 2
        Me.picUSBMini.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = Global.sphere_installer.My.Resources.Resources.greenreset
        Me.PictureBox1.Location = New System.Drawing.Point(348, 297)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'picGreenReset
        '
        Me.picGreenReset.Image = Global.sphere_installer.My.Resources.Resources._5D3_4439
        Me.picGreenReset.Location = New System.Drawing.Point(-1, 106)
        Me.picGreenReset.Name = "picGreenReset"
        Me.picGreenReset.Size = New System.Drawing.Size(512, 341)
        Me.picGreenReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picGreenReset.TabIndex = 2
        Me.picGreenReset.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 494)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grayda's sphere-installer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUSBMini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGreenReset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblWelcomeText As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblGreenResetText As System.Windows.Forms.Label
    Friend WithEvents lblGreenResetTitle As System.Windows.Forms.Label
    Friend WithEvents picGreenReset As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents picUSBMini As System.Windows.Forms.PictureBox
    Friend WithEvents lblConnectSerialText As System.Windows.Forms.Label
    Friend WithEvents lblConnectSerialTitle As System.Windows.Forms.Label
    Friend WithEvents lblWikimediaLink1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblPickCOMTitle As System.Windows.Forms.Label
    Friend WithEvents lblPickCOMText As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblBeginTitle As System.Windows.Forms.Label
    Friend WithEvents lblBeginText As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtSerial As System.Windows.Forms.TextBox
    Friend WithEvents btnToggleSerialLog As System.Windows.Forms.Button
    Friend WithEvents serMain As System.IO.Ports.SerialPort
    Friend WithEvents lblSearchStatus As System.Windows.Forms.Label
    Friend WithEvents btnLoadPorts As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents lblCompleteTitle As System.Windows.Forms.Label
    Friend WithEvents lblCompleteText As System.Windows.Forms.Label
    Friend WithEvents lblSphereLink As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
