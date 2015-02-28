Public Class Form1




    Private Sub ClearClipboard_Click(sender As Object, e As EventArgs) Handles ClearClipboard.Click
        Clipboard.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Pasted.Text = Clipboard.GetText()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clipboard.SetText(Copyed.Text())
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Save file dialog
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Open file dialog
        OpenFileDialog1.ShowDialog()

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim writer As New IO.StreamWriter(SaveFileDialog1.FileName)
        writer.Write(Pasted.Text)
        writer.Close()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim reader As New IO.StreamReader(OpenFileDialog1.FileName)
        Copyed.Text = reader.ReadToEnd
        reader.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim webAddress As String = "http://www.amatzen.dk/"
        Process.Start(webAddress)
    End Sub
End Class
