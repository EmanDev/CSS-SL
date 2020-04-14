Imports MetroFramework
Imports System.Windows.Forms.CheckState
Imports System.Windows.Forms
Imports MetroFramework.Forms

' Form 2 Update: Improve If-Then-Else Statements for cleaner code
' Did not find any substitute for the If-Then-Else Functions will use the current one for the time being
' Report bugs through Form 1 > Report Bugs > Create an Issue
Public Class Form2
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        If MetroComboBox1.Text = "" Then
            MetroMessageBox.Show(Me, "Please select your theme.", "Theme Manager", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MetroComboBox1.Text = "Default" Then
                My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Default
                My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Default
                My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Default
                My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Default
            Else
                If MetroComboBox1.Text = "Light" Then
                    My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Light
                    My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Light
                    My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Light
                    My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Light
                Else
                    If MetroComboBox1.Text = "Dark" Then
                        My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                        My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                        My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                        My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StyleManager = MetroStyleManager1
        MinimizeBox = False
        MaximizeBox = False

        ' Avoid Bugs here through permissions
        MetroCheckBox1.Enabled = True
    End Sub

    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        If Not e.Cancel AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        End If

        'Form 2 Save Settings Function
        If MetroCheckBox1.Checked = True Then
            My.Settings.FormTheme1 = MetroComboBox1.Text
            My.Settings.FormStyle1 = MetroComboBox2.Text
            My.Settings.FCheck = True
            My.Settings.Save()
        Else
            My.Settings.FormTheme1 = "Default"
            My.Settings.FormStyle1 = "Default"
            My.Settings.FCheck = False
            My.Settings.Save()
        End If
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        If MetroComboBox2.Text = "" Then
            MetroMessageBox.Show(Me, "Please select your style.", "Theme Manager", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MetroComboBox2.Text = "Default" Then
                My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Default
                My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Default
                My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Default
                My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Default
            Else
                If MetroComboBox2.Text = "Black" Then
                    My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Black
                    My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Black
                    My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Black
                    My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Black
                Else
                    If MetroComboBox2.Text = "Silver" Then
                        My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Silver
                        My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Silver
                        My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Silver
                        My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Silver
                    Else
                        If MetroComboBox2.Text = "Blue" Then
                            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Blue
                            My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Blue
                            My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Blue
                            My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Blue
                        Else
                            If MetroComboBox2.Text = "Green" Then
                                My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Green
                                My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Green
                                My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Green
                                My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Green
                            Else
                                If MetroComboBox2.Text = "Lime" Then
                                    My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Lime
                                    My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Lime
                                    My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Lime
                                    My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Lime
                                Else
                                    If MetroComboBox2.Text = "Teal" Then
                                        My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Teal
                                        My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Teal
                                        My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Teal
                                        My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Teal
                                    Else
                                        If MetroComboBox2.Text = "Orange" Then
                                            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Orange
                                            My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Orange
                                            My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Orange
                                            My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Orange
                                        Else
                                            If MetroComboBox2.Text = "Brown" Then
                                                My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Brown
                                                My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Brown
                                                My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Brown
                                                My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Brown
                                            Else
                                                If MetroComboBox2.Text = "Pink" Then
                                                    My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Pink
                                                    My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Pink
                                                    My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Pink
                                                    My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Pink
                                                Else
                                                    If MetroComboBox2.Text = "Magenta" Then
                                                        My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Magenta
                                                        My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Magenta
                                                        My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Magenta
                                                        My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Magenta
                                                    Else
                                                        If MetroComboBox2.Text = "Purple" Then
                                                            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Purple
                                                            My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Purple
                                                            My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Purple
                                                            My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Purple
                                                        Else
                                                            If MetroComboBox2.Text = "Red" Then
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
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        If MetroComboBox3.Text = "" Then
            MetroMessageBox.Show(Me, "Please select your custom theme.", "Theme Manager", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MetroComboBox3.Text = "Default" Then
                MetroComboBox1.Text = "Default"
                MetroComboBox2.Text = "Default"
                My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Default
                My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Default
                My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Default
                My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Default
                My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Default
                My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Default
                My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Default
                My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Default
            Else
                If MetroComboBox3.Text = "Light + Black" Then
                    MetroComboBox1.Text = "Light"
                    MetroComboBox2.Text = "Black"
                    My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Light
                    My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Black
                    My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Light
                    My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Black
                    My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Light
                    My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Black
                    My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Light
                    My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Black
                Else
                    If MetroComboBox3.Text = "Light + Silver" Then
                        MetroComboBox1.Text = "Light"
                        MetroComboBox2.Text = "Silver"
                        My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Light
                        My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Silver
                        My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Light
                        My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Silver
                        My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Light
                        My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Silver
                        My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Light
                        My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Silver
                    Else
                        If MetroComboBox3.Text = "Light + Blue" Then
                            MetroComboBox1.Text = "Light"
                            MetroComboBox2.Text = "Blue"
                            My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Light
                            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Blue
                            My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Light
                            My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Blue
                            My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Light
                            My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Blue
                            My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Light
                            My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Blue
                        Else
                            If MetroComboBox3.Text = "Light + Green" Then
                                MetroComboBox1.Text = "Light"
                                MetroComboBox2.Text = "Green"
                                My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Green
                                My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Green
                                My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Green
                                My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Green
                            Else
                                If MetroComboBox3.Text = "Light + Lime" Then
                                    MetroComboBox1.Text = "Light"
                                    MetroComboBox2.Text = "Lime"
                                    My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                    My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Lime
                                    My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                    My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Lime
                                    My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                    My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Lime
                                    My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                    My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Lime
                                Else
                                    If MetroComboBox3.Text = "Light + Teal" Then
                                        MetroComboBox1.Text = "Light"
                                        MetroComboBox2.Text = "Teal"
                                        My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                        My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Teal
                                        My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                        My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Teal
                                        My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                        My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Teal
                                        My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                        My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Teal
                                    Else
                                        If MetroComboBox3.Text = "Light + Orange" Then
                                            MetroComboBox1.Text = "Light"
                                            MetroComboBox2.Text = "Orange"
                                            My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Orange
                                            My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                            My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Orange
                                            My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                            My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Orange
                                            My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                            My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Orange
                                        Else
                                            If MetroComboBox3.Text = "Light + Brown" Then
                                                MetroComboBox1.Text = "Light"
                                                MetroComboBox2.Text = "Brown"
                                                My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                                My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Brown
                                                My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                                My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Brown
                                                My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                                My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Brown
                                                My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                                My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Brown
                                            Else
                                                If MetroComboBox3.Text = "Light + Pink" Then
                                                    MetroComboBox1.Text = "Light"
                                                    MetroComboBox2.Text = "Pink"
                                                    My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                                    My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Pink
                                                    My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                                    My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Pink
                                                    My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                                    My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Pink
                                                    My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                                    My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Pink
                                                Else
                                                    If MetroComboBox3.Text = "Light + Magenta" Then
                                                        MetroComboBox1.Text = "Light"
                                                        MetroComboBox2.Text = "Magenta"
                                                        My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                                        My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Magenta
                                                        My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                                        My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Magenta
                                                        My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                                        My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Magenta
                                                        My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                                        My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Magenta
                                                    Else
                                                        If MetroComboBox3.Text = "Light + Purple" Then
                                                            MetroComboBox1.Text = "Light"
                                                            MetroComboBox2.Text = "Purple"
                                                            My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                                            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Purple
                                                            My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                                            My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Purple
                                                            My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                                            My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Purple
                                                            My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                                            My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Purple
                                                        Else
                                                            If MetroComboBox3.Text = "Light + Red" Then
                                                                MetroComboBox1.Text = "Light"
                                                                MetroComboBox2.Text = "Red"
                                                                My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                                                My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Red
                                                                My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                                                My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Red
                                                                My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                                                My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Red
                                                                My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                                                My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Red
                                                            Else
                                                                If MetroComboBox3.Text = "Light + Yellow" Then
                                                                    MetroComboBox1.Text = "Light"
                                                                    MetroComboBox2.Text = "Yellow"
                                                                    My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                                                    My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Yellow
                                                                    My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                                                    My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Yellow
                                                                    My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                                                    My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Yellow
                                                                    My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Light
                                                                    My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Yellow
                                                                Else
                                                                    If MetroComboBox3.Text = "Dark + Black" Then
                                                                        MetroComboBox1.Text = "Dark"
                                                                        MetroComboBox2.Text = "Black"
                                                                        My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                        My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Black
                                                                        My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                        My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Black
                                                                        My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                        My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Black
                                                                        My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                        My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Black
                                                                    Else
                                                                        If MetroComboBox3.Text = "Dark + Black" Then
                                                                            MetroComboBox1.Text = "Dark"
                                                                            MetroComboBox2.Text = "Black"
                                                                            My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Black
                                                                            My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                            My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Black
                                                                            My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                            My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Black
                                                                            My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                            My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Black
                                                                        Else
                                                                            If MetroComboBox3.Text = "Dark + Silver" Then
                                                                                MetroComboBox1.Text = "Dark"
                                                                                MetroComboBox2.Text = "Silver"
                                                                                My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Silver
                                                                                My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Silver
                                                                                My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Silver
                                                                                My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Silver
                                                                            Else
                                                                                If MetroComboBox3.Text = "Dark + Blue" Then
                                                                                    MetroComboBox1.Text = "Dark"
                                                                                    MetroComboBox2.Text = "Blue"
                                                                                    My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                    My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Blue
                                                                                    My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                    My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Blue
                                                                                    My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                    My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Blue
                                                                                    My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                    My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Blue
                                                                                Else
                                                                                    If MetroComboBox3.Text = "Dark + Green" Then
                                                                                        MetroComboBox1.Text = "Dark"
                                                                                        MetroComboBox2.Text = "Green"
                                                                                        My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                        My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Green
                                                                                        My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                        My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Green
                                                                                        My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                        My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Green
                                                                                        My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                        My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Green
                                                                                    Else
                                                                                        If MetroComboBox3.Text = "Dark + Lime" Then
                                                                                            MetroComboBox1.Text = "Dark"
                                                                                            MetroComboBox2.Text = "Lime"
                                                                                            My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Lime
                                                                                            My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                            My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Lime
                                                                                            My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                            My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Lime
                                                                                            My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                            My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Lime
                                                                                        Else
                                                                                            If MetroComboBox3.Text = "Dark + Teal" Then
                                                                                                MetroComboBox1.Text = "Dark"
                                                                                                MetroComboBox2.Text = "Teal"
                                                                                                My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Teal
                                                                                                My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Teal
                                                                                                My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Teal
                                                                                                My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Teal
                                                                                            Else
                                                                                                If MetroComboBox3.Text = "Dark + Orange" Then
                                                                                                    MetroComboBox1.Text = "Dark"
                                                                                                    MetroComboBox2.Text = "Orange"
                                                                                                    My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                    My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Orange
                                                                                                    My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                    My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Orange
                                                                                                    My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                    My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Orange
                                                                                                    My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                    My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Orange
                                                                                                Else
                                                                                                    If MetroComboBox3.Text = "Dark + Brown" Then
                                                                                                        MetroComboBox1.Text = "Dark"
                                                                                                        MetroComboBox2.Text = "Brown"
                                                                                                        My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                        My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Brown
                                                                                                        My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                        My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Brown
                                                                                                        My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                        My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Brown
                                                                                                        My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                        My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Brown
                                                                                                    Else
                                                                                                        If MetroComboBox3.Text = "Dark + Pink" Then
                                                                                                            MetroComboBox1.Text = "Dark"
                                                                                                            MetroComboBox2.Text = "Pink"
                                                                                                            My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Pink
                                                                                                            My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                            My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Pink
                                                                                                            My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                            My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Pink
                                                                                                            My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                            My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Pink
                                                                                                        Else
                                                                                                            If MetroComboBox3.Text = "Dark + Magenta" Then
                                                                                                                MetroComboBox1.Text = "Dark"
                                                                                                                MetroComboBox2.Text = "Magenta"
                                                                                                                My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                                My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Magenta
                                                                                                                My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                                My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Magenta
                                                                                                                My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                                My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Magenta
                                                                                                                My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                                My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Magenta
                                                                                                            Else
                                                                                                                If MetroComboBox3.Text = "Dark + Purple" Then
                                                                                                                    MetroComboBox1.Text = "Dark"
                                                                                                                    MetroComboBox2.Text = "Purple"
                                                                                                                    My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                                    My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Purple
                                                                                                                    My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                                    My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Purple
                                                                                                                    My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                                    My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Purple
                                                                                                                    My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                                    My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Purple
                                                                                                                Else
                                                                                                                    If MetroComboBox3.Text = "Dark + Red" Then
                                                                                                                        MetroComboBox1.Text = "Dark"
                                                                                                                        MetroComboBox2.Text = "Red"
                                                                                                                        My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                                        My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Red
                                                                                                                        My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                                        My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Red
                                                                                                                        My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                                        My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Red
                                                                                                                        My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                                        My.Forms.Form4.MetroStyleManager1.Style = MetroColorStyle.Red
                                                                                                                    Else
                                                                                                                        MetroComboBox1.Text = "Dark"
                                                                                                                        MetroComboBox2.Text = "Yellow"
                                                                                                                        My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                                        My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Yellow
                                                                                                                        My.Forms.Form2.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                                        My.Forms.Form2.MetroStyleManager1.Style = MetroColorStyle.Yellow
                                                                                                                        My.Forms.Form3.MetroStyleManager1.Theme = MetroThemeStyle.Dark
                                                                                                                        My.Forms.Form3.MetroStyleManager1.Style = MetroColorStyle.Yellow
                                                                                                                        My.Forms.Form4.MetroStyleManager1.Theme = MetroThemeStyle.Dark
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
    End Sub

    Private Sub MetroCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles MetroCheckBox1.CheckedChanged

    End Sub

    Private Sub MetroCheckBox2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
End Class