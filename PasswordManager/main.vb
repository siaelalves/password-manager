Public Class main

    Dim crypt As New Segurança.Criptografia
    Public Shared appFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & My.Application.Info.Title
    Public Shared login As String
    'Dim psw As String

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.Directory.Exists(appFolder) = False Then
            IO.Directory.CreateDirectory(appFolder)
        End If
        MsgBox(appFolder)
    End Sub
    Private Sub cmdAd_Click(sender As Object, e As EventArgs) Handles cmdAd.Click
        newPsw.txtDsc.Text = ""
        newPsw.txtPsw.Text = ""
        newPsw.chkEx.Checked = False
        '
        newPsw.openMode = newPsw.Modo.Add
        newPsw.ShowDialog()
    End Sub

    Private Sub cmdEd_Click(sender As Object, e As EventArgs) Handles cmdEd.Click
        If lstPsw.SelectedItems.Count > 0 Then
            newPsw.txtDsc.Text = lstPsw.SelectedItems(0).SubItems(0).Text
            newPsw.txtPsw.Text = lstPsw.SelectedItems(0).SubItems(1).Text
            newPsw.chkEx.Checked = False
            '
            newPsw.openMode = newPsw.Modo.Edit
            newPsw.ShowDialog()
        End If
    End Sub

    Private Sub cmdExc_Click(sender As Object, e As EventArgs) Handles cmdExc.Click
        If lstPsw.SelectedItems.Count > 0 Then
            lstPsw.SelectedItems(0).Remove()
        End If
    End Sub

End Class
