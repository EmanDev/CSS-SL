Imports MetroFramework

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Please only use the fixes if srcds.exe is not launching properly", "SRCDS Fixes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.StyleManager = MetroStyleManager1
        MinimizeBox = False
        MaximizeBox = False
        MetroButton2.Enabled = False
        Me.ShowInTaskbar = False
        Me.ShowIcon = False
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Form4.Show()
    End Sub
End Class