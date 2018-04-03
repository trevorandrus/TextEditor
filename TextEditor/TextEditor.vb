Option Strict On

Imports System.IO
Public Class frmTextEditor
    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        MessageBox.Show("NETD-2202" + vbNewLine + "Lab #5" + vbNewLine + "T. Andrus")
    End Sub

    Private Sub mnuOpen_Click(sender As Object, e As EventArgs) Handles mnuOpen.Click


        Dim openFileDialog As New OpenFileDialog
        Dim fullFilePath As String = String.Empty
        Dim fileContent As String = String.Empty

        openFileDialog.Filter = "txt files (*.txt)|*.txt"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            fullFilePath = openFileDialog.FileName

            If File.Exists(fullFilePath) Then
                fileContent = OpenFile(fullFilePath)

                tbEntry.Text = fileContent
            End If
        End If
    End Sub



    Private Sub mnuCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click
        My.Computer.Clipboard.SetText(tbEntry.SelectedText)
    End Sub

    Private Sub mnuCut_Click(sender As Object, e As EventArgs) Handles mnuCut.Click
        My.Computer.Clipboard.SetText(tbEntry.SelectedText)
        tbEntry.SelectedText = ""
    End Sub
    Private Sub mnuPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click
        tbEntry.SelectedText = My.Computer.Clipboard.GetText()
    End Sub
    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click
        Dim saveFileDialog As New SaveFileDialog
        Dim fullFilePath As String = String.Empty

        saveFileDialog.Filter = "txt files (*.txt)|*.txt"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then


            fullFilePath = saveFileDialog.FileName


            Save(fullFilePath)

        End If
    End Sub

    Private Sub mnuSaveAs_Click(sender As Object, e As EventArgs) Handles mnuSaveAs.Click
        Dim saveFileDialog As New SaveFileDialog
        Dim fullFilePath As String = String.Empty

        saveFileDialog.Filter = "txt files (*.txt)|*.txt"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then

            fullFilePath = saveFileDialog.FileName


            Save(fullFilePath)

        End If
    End Sub

    Private Sub mnuNew_Click(sender As Object, e As EventArgs) Handles mnuNew.Click
        tbEntry.Clear()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub
    Private Sub Save(fullFilePath As String)

        Dim fileStream As New FileStream(fullFilePath, FileMode.Create, FileAccess.Write)

        Dim writeStream As New StreamWriter(fileStream)

        writeStream.Write(tbEntry.Text)

        writeStream.Close()


    End Sub
    Private Function OpenFile(filePath As String) As String

        Dim fileContent As String = String.Empty
        Dim fileStream As New FileStream(filePath, FileMode.Open, FileAccess.Read)

        Dim readStream As New StreamReader(fileStream)

        fileContent = readStream.ReadToEnd()

        readStream.Close()

        Return fileContent

    End Function


End Class
