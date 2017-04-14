Imports MetroFramework
Public Class Form2
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        If MetroComboBox1.Text = "" Then
            MessageBox.Show("Please select your theme", "Theme Manager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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

    End Sub

    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        If Not e.Cancel AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
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
        If MetroComboBox3.Text = "Dark + White" Then
            My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Dark
            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.White
            MetroStyleManager1.Theme = MetroThemeStyle.Dark
            MetroStyleManager1.Style = MetroColorStyle.White
        End If
        If MetroComboBox3.Text = "Default" Then
            My.Forms.Form1.MetroStyleManager1.Theme = MetroThemeStyle.Default
            My.Forms.Form1.MetroStyleManager1.Style = MetroColorStyle.Default
            MetroStyleManager1.Theme = MetroThemeStyle.Default
            MetroStyleManager1.Style = MetroColorStyle.Default
        End If
    End Sub

    Private Sub MetroComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox2.SelectedIndexChanged

    End Sub
End Class