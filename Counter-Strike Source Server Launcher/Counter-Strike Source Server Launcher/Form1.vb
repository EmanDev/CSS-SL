Imports MetroFramework
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Windows.Forms.CheckState

'Notes:
'Do some cleanup and reduce IF expresions
'fix some bugs
Public Class Form1
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim path As New Object
        path = MetroTextBox1
        OpenFileDialog1.ShowDialog()
        path.text = OpenFileDialog1.FileName
        'Original Code Below
        'Change to original if errors/bugs occurs
        'OpenFileDialog1.ShowDialog()
        'MetroTextBox1.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        M01e.StyleManager = MetroStyleManager1
        MetroTextBox1.WaterMark = "srcds.exe location"
        MetroTextBox2.WaterMark = "Parameters"
        If MetroCheckbox1.Checked = True Then
            MetroTextBox1.Text = My.Settings.path
        End If
        'form2 saving theme porperties
        Dim themeset As New Object
        themeset = My.Forms.Form2.MetroCheckBox1
    End Sub

    Private Sub MetroCheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles MetroCheckbox2.CheckedChanged
        Dim ReadOnlyMode As New Object
        ReadOnlyMode = MetroCheckbox2
        Dim path As New Object
        path = MetroTextBox1
        If ReadOnlyMode.checked Then
            path.readonly = True
        Else
            path.readonly = False
        End If
        'Original Code Below
        'Change to original if errors/bugs occurs
        'If MetroCheckbox2.Checked Then
        'MetroTextBox1.ReadOnly = True
        'Else
        'MetroTextBox1.ReadOnly = False
        'End If
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        Form2.Show()
    End Sub

    Private Sub MetroCheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles MetroCheckBox3.CheckedChanged
        Dim dpm As New Object
        dpm = MetroCheckBox3
        If dpm.checked Then
            MetroTextBox2.Text = "-console -game cstrike -autoupdate -port 27015 -tickrate 100 +sv_lan 1 +map de_dust +maxplayers 32"
        Else
            dpm.checked = False
            MetroTextBox2.Text = ""
        End If
        'Original code below
        'Change to original if error/bugs occurs
        'If MetroCheckBox3.Checked = True Then
        'MetroTextBox2.Text = "-console -game cstrike -autoupdate -port 27015 -tickrate 100 +sv_lan 1 +map de_dust +maxplayers 32"
        'Else
        'MetroCheckBox3.Checked = False
        'MetroTextBox2.Text = ""
        'End If
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim srcds As New ProcessStartInfo
        srcds.FileName = MetroTextBox1.Text
        srcds.Arguments = MetroTextBox2.Text
        srcds.UseShellExecute = True
        Dim proc As Process = Process.Start(srcds)
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        If MetroComboBox1.SelectedIndex > -1 Then
            MetroCheckBox3.Checked = False
            Dim sindex As Integer
            sindex = MetroComboBox1.SelectedIndex
            Dim sitem As Object
            sitem = MetroComboBox1.SelectedItem
            MetroTextBox2.Text = sitem
        End If
    End Sub

    Private Sub MetroCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles MetroCheckbox1.CheckedChanged

    End Sub

    Private Sub MetroLabel4_Click(sender As Object, e As EventArgs) Handles MetroLabel4.Click

    End Sub
    Private Sub MetroLink3_Click(sender As Object, e As EventArgs) Handles MetroLink3.Click
        Process.Start("https://github.com/EmanDev")
    End Sub

    Private Sub MetroLink4_Click(sender As Object, e As EventArgs) Handles MetroLink4.Click
        Process.Start("http://themonochrome.weebly.com/")
    End Sub

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
        Process.Start("https://github.com/EmanDev/Counter-Strike--Source-Server-Launcher/blob/master/Changelog.md")
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        Process.Start("https://github.com/EmanDev/Counter-Strike--Source-Server-Launcher/issues")
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'form1 on-closing saving properties
        If MetroCheckbox1.Checked = True Then
            My.Settings.path = MetroTextBox1.Text
            My.Settings.Save()
        End If
        'form2 on-closing saving properties
        If My.Forms.Form2.MetroCheckBox1.Checked = True Then
            My.Settings.OPtheme1 = My.Forms.Form2.MetroComboBox1.Text
            My.Settings.THs1 = My.Forms.Form2.MetroComboBox3.Text
            My.Settings.style1 = My.Forms.Form2.MetroComboBox2.Text
            My.Settings.Save()
        End If
        If My.Forms.Form2.MetroCheckBox2.Checked = True Then
            My.Forms.Form2.MetroButton1.PerformClick()
            My.Forms.Form2.MetroButton2.PerformClick()
            My.Forms.Form2.MetroButton3.PerformClick()
            My.Settings.Save()
        End If
    End Sub
End Class
