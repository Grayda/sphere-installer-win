Imports System.IO.Ports
Imports System.Management

' This is the sphere-installer installer which installs sphere-installer onto your sphere. Got it?

Public Class frmMain
    ' What step we're at. 
    Dim panelNumber As Integer = 0

    ' What has been read from the serial port
    Dim readBuffer As String
    ' Stuff we want to write to the log
    Dim statusText As String
    ' Are we at the first command prompt (that is, have we sent a command before?)
    Dim firstPrompt As Boolean = True
    ' Is the driver installing? If true, stops us from going past the installation step
    Dim installing As Boolean = False
    ' Have we finished installing? If we have, we can go back and forth throughout the steps without reinstalling
    Dim installed As Boolean = False
    ' Which COM port is our Sphere plugged into?
    Dim COMPort As String

    ' I dunno.
    Public Delegate Sub StringSubPointer(ByVal Buffer As String)

    ' Loop through the all available ports and look for our Sphere
    Sub loadPorts()

        ' Management class lets us work with various advanced system information
        Dim mc As ManagementClass
        Dim mo As ManagementObject
        Dim moc As ManagementObjectCollection

        ' We want to work with the serial port 
        mc = New ManagementClass("Win32_SerialPort")
        moc = mc.GetInstances()

        ' Loop through the objects in Win32_SerialPort
        For Each mo In moc
            ' If the port is valid
            If mo.Item("Status").ToString = "OK" Then
                ' If the port's description matches our Sphere's identifier, then that's our Sphere!
                If mo.Item("Description") = "ELMO GMAS" Then
                    ' Set COMPort to this port name (e.g. COM5)
                    COMPort = mo.Item("DeviceID")
                    ' Allow the user to continue
                    btnNext.Enabled = True
                    ' Tell them we've found something
                    lblSearchStatus.Text = "Status: Sphere found on " & COMPort
                    ' Quit, as we're not interested in anything else
                    Exit Sub
                End If
            End If
        Next

        ' This code doesn't run unless no Sphere is found.
        lblSearchStatus.Text = "Status: No Sphere found!"
        ' Because nothing was found, don't let the user continue
        btnNext.Enabled = False
        
    End Sub

    Private Sub btnPortRefresh_Click(sender As Object, e As EventArgs)
        ' Load our ports again
        loadPorts()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to quit?", vbYesNo) = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    ' Here's where the first part of the magic is. This hides and shows the various Panel controls based on what panel we're up to.
    Sub NextPanel()
        Select Case panelNumber
            Case 0
                ' If we're at panelNumber 0
                btnPrev.Enabled = True
                ' Hide panel 1, show panel 2
                Panel1.Visible = False
                Panel2.Visible = True
                ' Repeat ad-nauseum
            Case 1
                Panel2.Visible = False
                Panel3.Visible = True
            Case 2
                Panel3.Visible = False
                Panel4.Visible = True
                btnNext.Enabled = False
                loadPorts()
            Case 3
                Panel4.Visible = False
                Panel5.Visible = True
            Case 4
                Panel5.Visible = False
                Panel6.Visible = True
                btnNext.Enabled = False
                beginInstall()
            Case 5
                Panel6.Visible = False
                Panel7.Visible = True
                ' Last step? Change the Next button to say Finish
                btnNext.Text = "&Finish"
            Case 6
                End

        End Select
        panelNumber += 1
        Me.Text = panelNumber
    End Sub

    Sub PrevPanel()
        Select Case panelNumber
            Case 0
                ' Can't do it!
            Case 1
                btnPrev.Enabled = False

                Panel1.Visible = True
                Panel2.Visible = False
            Case 2
                Panel2.Visible = True
                Panel3.Visible = False
            Case 3
                Panel3.Visible = True
                Panel4.Visible = False
                btnNext.Enabled = True
            Case 4
                Panel4.Visible = True
                Panel5.Visible = False
            Case 5
                Panel5.Visible = True
                Panel6.Visible = False
                btnNext.Enabled = True
            Case 6
                Panel6.Visible = True
                Panel7.Visible = False
                ' Last step? Change the Finish back to Next
                btnNext.Text = "&Next >"
        End Select
        panelNumber -= 1
        Me.Text = panelNumber
    End Sub

    ' Now begins the magic! This opens up our COM port and starts writing
    Sub beginInstall()
        Try
            ' If we're not open and we're not installing
            If serMain.IsOpen = False And installing = False Then
                installing = True
                serMain.BaudRate = 9600
                serMain.PortName = COMPort

                serMain.Open()

                ' When first starting a session via COM port, the nothing appears until you press Enter.
                serMain.WriteLine(vbCrLf)
                serMain.WriteLine(vbCrLf)

                ' If we've already installed, don't worry about disabling the button, as this script won't install twice
            ElseIf installed = True Then
                btnNext.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Unable to open the COM port. Are there any other apps that are using the port (e.g. PuTTY)?")
        End Try
    End Sub



    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        NextPanel()
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        PrevPanel()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BringToFront()
    End Sub

    ' This is in its own sub because apparently the serial port stuff runs on its own thread and
    ' therefore doesn't have access to the UI thread. This bridges the gap
    Public Sub DoUpdate(ByVal sender As Object, ByVal e As System.EventArgs)
        txtSerial.AppendText(readBuffer & vbNewLine)
    End Sub


    Public Sub DoLog(ByVal sender As Object, ByVal e As System.EventArgs)
        If statusText <> "" Then txtStatus.AppendText(">" & statusText & vbNewLine)
    End Sub

    Private Sub lblWikimediaLink1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblWikimediaLink1.LinkClicked
        Process.Start("http://commons.wikimedia.org/wiki/File:USB-2.0-Mini-B-Stecker.jpg")
    End Sub

    Private Sub btnToggleSerialLog_Click(sender As Object, e As EventArgs) Handles btnToggleSerialLog.Click
        ' Toggles between showing "Show Log" and "Show Serial"
        If txtStatus.Visible = True Then
            txtStatus.Visible = Not txtStatus.Visible
            txtSerial.Visible = Not txtSerial.Visible
            btnToggleSerialLog.Text = "Show Log"
        Else
            txtStatus.Visible = Not txtStatus.Visible
            txtSerial.Visible = Not txtSerial.Visible
            btnToggleSerialLog.Text = "Show Serial"
        End If
    End Sub

    ' Here's where the bulk of the magic happens. When stuff comes through on the serial port, we check what the data is, then do stuff.
    Private Sub serMain_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles serMain.DataReceived
        If serMain.IsOpen Then
            Try
                ' Reads all the data we've got coming
                readBuffer = serMain.ReadExisting()

                ' status() is shorthand for readBuffer.Contains()
                ' If the serial port data contains the phrase "ninjasphere login:", we're waiting to log in
                If status("ninjasphere login:") = True Then
                    ' So we send the username to the Sphere
                    serMain.WriteLine(My.Settings.sphereUsername)
                    statusText = "Sphere has asked for a username. We're sending " & My.Settings.sphereUsername

                    ' Password? Send the one we've got stored
                ElseIf status("Password:") Then
                    serMain.WriteLine(My.Settings.spherePassword)
                    statusText = "Sphere has asked for password. We're sending " & My.Settings.spherePassword

                    ' Wrong password? We're done. 
                ElseIf status("Login incorrect") = True Then
                    statusText = "Login to Sphere failed! Please contact " & My.Settings.scriptAuthor & " for assistance!"
                    serMain.Close()

                    ' Something failed? We're done.
                ElseIf status("failed") = True Then
                    statusText = "Installation failed (other general failure). Please contact " & My.Settings.scriptAuthor & " for assistance!"

                    ' Have we got a command prompt, and this is the first time we're seeing the prompt?
                ElseIf status("ninja@ninjasphere:~$") = True And firstPrompt = True Then
                    statusText = "Sphere is ready to accept commands, sending command to download sphere-installer"
                    ' Here's the command we're going to send. 
                    Dim wgetstr As String = "wget -qO- " & My.Settings.scriptBaseURL & "/" & My.Settings.scriptAuthor & "/" & My.Settings.projectName & "/" & "releases/download" & "/" & My.Settings.scriptVersion & "/" & My.Settings.scriptName & " | bash"
                    serMain.WriteLine(wgetstr)
                    ' I don't know why we wait a second, we just do, okay?
                    Threading.Thread.Sleep(1000)
                    firstPrompt = False

                    ' sudo prompt? Send the password
                ElseIf status("[sudo] password for " & My.Settings.sphereUsername & ":") = True Then
                    serMain.WriteLine(My.Settings.spherePassword)
                    statusText = "Sphere has asked for password for super user rights. Sending " & My.Settings.spherePassword

                    ' Installation complete?
                ElseIf status("Installation complete. Please visit the labs page to find the driver installer page!") = True Then
                    statusText = "Installation complete! Sphere will now reboot. When it's done, please visit the labs page to find sphere-installer!"
                    Me.Invoke(New EventHandler(AddressOf EnableNext))
                    installing = False
                    installed = True
                    serMain.WriteLine("sudo reboot")
                    serMain.Close()

                    ' 200 OK = we've started downloading the driver binary
                ElseIf status("200 OK") = True Then
                    statusText = "Starting download of sphere-installer from " & My.Settings.scriptBaseURL

                    ' Installation of .deb file has started
                ElseIf status("Installing package..") = True Then
                    statusText = "Installing sphere-installer. "
                ElseIf status("25%") = True Then
                    statusText = "25% complete"
                ElseIf status("50%") = True Then
                    statusText = "50% complete"
                ElseIf status("75%") = True Then
                    statusText = "75% complete"
                ElseIf status("99%") = True Then
                    statusText = "99% complete"

                    ' Uh oh, spaghetti-o's!
                ElseIf status("404 Not Found") Then
                    statusText = "Driver download failed! File wasn't found on the remote server"
                End If

                ' These lines let us call DoUpdate and DoLog, which have access to the UI thread
                Me.Invoke(New EventHandler(AddressOf DoUpdate))
                Me.Invoke(New EventHandler(AddressOf DoLog))
                statusText = ""
            Catch ex As Exception
                MsgBox("read " & ex.Message)
            End Try
        End If
    End Sub

    Function status(text As String) As Boolean
        Return readBuffer.Contains(text)
    End Function

    Private Sub btnPortRefresh_Click_1(sender As Object, e As EventArgs)
        loadPorts()
    End Sub

    ' This is similar to DoLog and DoStatus. Serialport's DataReceived thread can't touch the UI, so this is our proxy
    Private Sub EnableNext()
        btnNext.Enabled = True
    End Sub

    Private Sub btnLoadPorts_Click(sender As Object, e As EventArgs) Handles btnLoadPorts.Click
        loadPorts()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://discuss.ninjablocks.com/t/howto-setup-a-windows-pc-to-connect-to-a-ninja-sphere-via-usb/3259")
    End Sub

    Private Sub lblSphereLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblSphereLink.LinkClicked
        Process.Start("http://ninjasphere.local")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=7T7LPMSWDV9NE")
    End Sub
End Class
