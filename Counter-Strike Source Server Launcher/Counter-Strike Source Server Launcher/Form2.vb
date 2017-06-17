Imports MetroFramework
Imports System.Windows.Forms.CheckState
Imports System.Windows.Forms
Imports MetroFramework.Forms

'Notes Field
'Bugs: White Style and its forecolors.
Public Class Form2
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        'New properties
        'Constructing
        'If MetroComboBox1.SelectedIndex > -1 Then
        'Dim sindex As New Integer
        'sindex = MetroComboBox1.SelectedIndex
        'Dim sitem As Object
        'sitem = MetroComboBox1.SelectedItem
        'insert code here for theme changes
        'MetroComboBox1.SelectedItem.ToString()
        'End If
        'Old properties
        'This part must reduce "IF" expressions
        If MetroComboBox1.Text = "" Then
            'MessageBox.Show("Please select your theme", "Theme Manager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            MetroMessageBox.Show(Me, "Please select your theme.", "Theme Manager", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        If MetroComboBox1.Text = "Dark" Then
            My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Dark
            MetroStyleManager1.Theme = MetroThemeStyle.Dark
        End If
        If MetroComboBox1.Text = "Light" Then
            My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Light
            MetroStyleManager1.Theme = MetroThemeStyle.Light
        End If
        If MetroComboBox1.Text = "Default" Then
            My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Default
            MetroStyleManager1.Theme = MetroThemeStyle.Default
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StyleManager = MetroStyleManager1
        MinimizeBox = False
        MaximizeBox = False
        MetroCheckBox1.Enabled = True
    End Sub

    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        If Not e.Cancel AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        If MetroComboBox2.Text = "" Then
            MetroMessageBox.Show(Me, "Please select your style.", "Theme Manager", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        'This part must have at least fewer codes than the original
        'Must Reduce "IF" expressions
        'Will modify, as soon as I have the time
        If MetroComboBox2.Text = "Default" Then
            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Default
            MetroStyleManager1.Style = MetroColorStyle.Default
        End If
        If MetroComboBox2.Text = "Black" Then
            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Black
            MetroStyleManager1.Style = MetroColorStyle.Black
        End If
        If MetroComboBox2.Text = "White" Then
            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.White
            MetroStyleManager1.Style = MetroColorStyle.White
        End If
        If MetroComboBox2.Text = "Silver" Then
            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Silver
            MetroStyleManager1.Style = MetroColorStyle.Silver
        End If
        If MetroComboBox2.Text = "Blue" Then
            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Blue
            MetroStyleManager1.Style = MetroColorStyle.Blue
        End If
        If MetroComboBox2.Text = "Green" Then
            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Green
            MetroStyleManager1.Style = MetroColorStyle.Green
        End If
        If MetroComboBox2.Text = "Lime" Then
            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Lime
            MetroStyleManager1.Style = MetroColorStyle.Lime
        End If
        If MetroComboBox2.Text = "Teal" Then
            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Teal
            MetroStyleManager1.Style = MetroColorStyle.Teal
        End If
        If MetroComboBox2.Text = "Orange" Then
            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Orange
            MetroStyleManager1.Style = MetroColorStyle.Orange
        End If
        If MetroComboBox2.Text = "Brown" Then
            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Brown
            MetroStyleManager1.Style = MetroColorStyle.Brown
        End If
        If MetroComboBox2.Text = "Pink" Then
            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Magenta
            MetroStyleManager1.Style = MetroColorStyle.Magenta
        End If
        If MetroComboBox2.Text = "Magenta" Then
            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Pink
            MetroStyleManager1.Style = MetroColorStyle.Pink
        End If
        If MetroComboBox2.Text = "Purple" Then
            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Purple
            MetroStyleManager1.Style = MetroColorStyle.Purple
        End If
        If MetroComboBox2.Text = "Red" Then
            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Red
            MetroStyleManager1.Style = MetroColorStyle.Red
        End If
        If MetroComboBox2.Text = "Yellow" Then
            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Yellow
            MetroStyleManager1.Style = MetroColorStyle.Yellow
        End If
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        If MetroComboBox3.Text = "" Then
            MetroMessageBox.Show(Me, "Please select your custom theme.", "Theme Manager", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        If MetroComboBox3.Text = "Dark + White" Then
            My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Dark
            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.White
            MetroStyleManager1.Theme = MetroThemeStyle.Dark
            MetroStyleManager1.Style = MetroColorStyle.White
        Else
            MetroComboBox3.Text = "Default"
            My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Default
            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Default
            MetroStyleManager1.Theme = MetroThemeStyle.Default
            MetroStyleManager1.Style = MetroColorStyle.Default
        End If
    End Sub

    Private Sub MetroComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox2.SelectedIndexChanged

    End Sub

    Private Sub MetroCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles MetroCheckBox1.CheckedChanged

    End Sub
End Class
'report if there are errors in assigning codes
' Form1 > Options Tab > Report Bug