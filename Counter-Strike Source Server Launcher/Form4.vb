Imports MetroFramework
Imports System.IO
Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StyleManager = MetroStyleManager1

        MaximizeBox = False
        MinimizeBox = False
        MetroTextBox1.Enabled = False
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim srcdsPath As New Object
        srcdsPath = Path.GetDirectoryName(Form1.OpenFileDialog1.FileName)
        SaveFromResources(srcdsPath, My.Resources.rev)
    End Sub

    Public Sub SaveFromResources(ByVal FilePath As String, ByVal File As Object)
        Dim FByte As String = File
        Dim Source As String = "\\rev.ini"
        Dim SourceDirectory As String = Path.GetDirectoryName(Form1.OpenFileDialog1.FileName)
        Dim revSource As String = SourceDirectory + Source
        If System.IO.File.Exists(revSource) Then
            MessageBox.Show("Fix has already been applied! If error occur please verify your server files.", "SRCDS Fixes: Error Reading Application ID", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            My.Computer.FileSystem.WriteAllText(FilePath + "\\rev.ini", FByte, True)
            MessageBox.Show("Fix has been applied!", "SRCDS Fixes: Error Reading Application ID", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class