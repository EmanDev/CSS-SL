Imports MetroFramework
Imports System.Windows.Forms

Public Class Form1
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        OpenFileDialog1.ShowDialog()
        MetroTextBox1.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StyleManager = MetroStyleManager1
        MetroCheckBox1.Checked = My.Settings.checkbox
        MetroTextBox1.Text = My.Settings.textbox
    End Sub

    Private Sub MetroCheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles MetroCheckBox2.CheckedChanged
        If MetroCheckBox2.Checked Then
            MetroTextBox1.Enabled = False
        Else
            MetroTextBox1.Enabled = True
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
        If MetroCheckBox3.Checked Then
            MetroTextBox2.Text = "-console -game cstrike -autoupdate -port 27015 -tickrate 100 +sv_lan 1 +map de_dust +maxplayers 32"
        End If
        If MetroCheckBox3.Checked = False Then
            MetroTextBox2.Text = ""
        End If
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
            Dim sindex As Integer
            sindex = MetroComboBox1.SelectedIndex
            Dim sitem As Object
            sitem = MetroComboBox1.SelectedItem
            MetroTextBox2.Text = sitem
        End If
    End Sub

    Private Sub MetroCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles MetroCheckBox1.CheckedChanged

    End Sub

    Private Sub MetroLabel4_Click(sender As Object, e As EventArgs) Handles MetroLabel4.Click

    End Sub
    Private Sub MetroLink3_Click(sender As Object, e As EventArgs) Handles MetroLink3.Click
        Process.Start("https://github.com/EmanzzKie")
    End Sub

    Private Sub MetroLink2_Click(sender As Object, e As EventArgs) Handles MetroLink2.Click
        Process.Start("https://github.com/EmanzzKie/Counter-Strike--Source-Server-Launcher/issues")
    End Sub

    Private Sub MetroLink4_Click(sender As Object, e As EventArgs) Handles MetroLink4.Click
        Process.Start("http://emzzdroidpro.weebly.com/")
    End Sub

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
        Process.Start("https://github.com/EmanzzKie/Counter-Strike--Source-Server-Launcher/blob/master/Changelog.md")
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        My.Settings.checkbox = MetroCheckBox1.Checked
        My.Settings.textbox = MetroTextBox1.Text
        My.Settings.Save()
    End Sub
End Class
