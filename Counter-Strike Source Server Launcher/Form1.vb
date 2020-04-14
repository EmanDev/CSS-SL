Imports MetroFramework
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Windows.Forms.CheckState
Imports System.IO

' Form 1 Update: Added Save and Load Functions
' Fixed Text bugs in the App
' Report bugs through Form 1 > Report Bugs > Create an Issue
Public Class Form1
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim path As New Object
        path = MetroTextBox1
        OpenFileDialog1.ShowDialog()
        path.text = OpenFileDialog1.FileName
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StyleManager = MetroStyleManager1
        MetroTextBox1.WaterMark = "srcds.exe location"
        MetroTextBox2.WaterMark = "Parameters"

        'Strict Chronological Order of Functions

        'Form 1 Settings Load Function
        If MetroCheckbox1.Checked = True Then
            MetroTextBox1.Text = My.Settings.path
        End If

        'Form 2 Settings Load Function
        If My.Settings.FCheck = True Then
            My.Forms.Form2.MetroCheckBox1.Checked = True

            If My.Forms.Form2.MetroCheckBox1.Checked = True Then
                My.Forms.Form2.MetroComboBox1.Text = My.Settings.FormTheme1
                My.Forms.Form2.MetroComboBox2.Text = My.Settings.FormStyle1

                'Themes = DARK LIGHT
                If My.Forms.Form2.MetroComboBox1.Text = "Light" Then
                    My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Light
                    My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Light
                    My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Light
                    My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Light
                Else
                    If My.Forms.Form2.MetroComboBox1.Text = "Dark" Then
                        My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                        My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                        My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                        My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                    Else
                        My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Default
                        My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Default
                        My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Default
                        My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Default
                    End If
                End If

                'Styles = BLACK SILVER BLUE GREEN LIME TEAL ORANGE BROWN PINK MAGENTA PURPLE RED YELLOW
                If My.Forms.Form2.MetroComboBox2.Text = "Default" Then
                    My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Default
                    My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Default
                    My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Default
                    My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Default
                Else
                    If My.Forms.Form2.MetroComboBox2.Text = "Black" Then
                        My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Black
                        My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Black
                        My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Black
                        My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Black
                    Else
                        If My.Forms.Form2.MetroComboBox2.Text = "Blue" Then
                            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Blue
                            My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Blue
                            My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Blue
                            My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Blue
                        Else
                            If My.Forms.Form2.MetroComboBox2.Text = "Silver" Then
                                My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Silver
                                My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Silver
                                My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Silver
                                My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Silver
                            Else
                                If My.Forms.Form2.MetroComboBox2.Text = "Green" Then
                                    My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Green
                                    My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Green
                                    My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Green
                                    My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Green
                                Else
                                    If My.Forms.Form2.MetroComboBox2.Text = "Lime" Then
                                        My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Lime
                                        My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Lime
                                        My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Lime
                                        My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Lime
                                    Else
                                        If My.Forms.Form2.MetroComboBox2.Text = "Teal" Then
                                            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Teal
                                            My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Teal
                                            My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Teal
                                            My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Teal
                                        Else
                                            If My.Forms.Form2.MetroComboBox2.Text = "Orange" Then
                                                My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Orange
                                                My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Orange
                                                My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Orange
                                                My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Orange
                                            Else
                                                If My.Forms.Form2.MetroComboBox2.Text = "Brown" Then
                                                    My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Brown
                                                    My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Brown
                                                    My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Brown
                                                    My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Brown
                                                Else
                                                    If My.Forms.Form2.MetroComboBox2.Text = "Pink" Then
                                                        My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Pink
                                                        My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Pink
                                                        My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Pink
                                                        My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Pink
                                                    Else
                                                        If My.Forms.Form2.MetroComboBox2.Text = "Magenta" Then
                                                            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Magenta
                                                            My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Magenta
                                                            My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Magenta
                                                            My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Magenta
                                                        Else
                                                            If My.Forms.Form2.MetroComboBox2.Text = "Purple" Then
                                                                My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Purple
                                                                My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Purple
                                                                My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Purple
                                                                My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Purple
                                                            Else
                                                                If My.Forms.Form2.MetroComboBox2.Text = "Red" Then
                                                                    My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Red
                                                                    My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Red
                                                                    My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Red
                                                                    My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Red
                                                                Else
                                                                    My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Yellow
                                                                    My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Yellow
                                                                    My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Yellow
                                                                    My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Yellow
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Else
            'Load DEFAULT (Good as New) Function
            My.Forms.Form2.MetroCheckBox1.Checked = False
            My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Default
            My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Default
            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Default
            My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Default
            My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Default
            My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Default
            My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Default
            My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Default
        End If

        'Theme & Style Manager Function Load
        My.Forms.Form2.MetroComboBox3.Text = My.Settings.FormTheme1 & " + " & My.Settings.FormStyle1

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
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim where As String = MetroTextBox1.Text
        Dim exactWhere As String = where.Substring(0, where.LastIndexOf("\"))
        If MetroTextBox1.Text = exactWhere + "\srcds.exe" Then
            Dim srcds As New ProcessStartInfo
            srcds.FileName = MetroTextBox1.Text
            srcds.Arguments = MetroTextBox2.Text
            srcds.UseShellExecute = True
            Dim proc As Process = Process.Start(srcds)
        Else
            MessageBox.Show("Please properly locate srcds.exe", "Error locating SRCDS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        If MetroComboBox1.SelectedIndex > -1 Then
            MetroCheckBox3.Checked = False
            Dim sindex As Integer
            sindex = MetroComboBox1.SelectedIndex
            Dim sitem As Object
            sitem = MetroComboBox1.SelectedItem
            MetroTextBox2.Text = sitem
        Else
            MessageBox.Show("Please select a parameter", "Counter-Strike: Source Server Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        Process.Start("https://emandev.github.io/")
    End Sub

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
        Process.Start("https://github.com/EmanDev/css-sl/commits/master")
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        Process.Start("https://github.com/EmanDev/css-sl/issues")
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'form1 on-closing saving properties
        If MetroCheckbox1.Checked = True Then
            My.Settings.path = MetroTextBox1.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub MetroTile3_Click(sender As Object, e As EventArgs) Handles MetroTile3.Click
        If MetroTextBox1.Text = "" Then
            MessageBox.Show("Error locating srcds folder.", "Error on Path", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Form3.Show()
        End If
    End Sub
End Class
