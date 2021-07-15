Public Class newPsw

    Public openMode As Modo
    Dim crypt As New Segurança.Criptografia

    Enum Modo
        Add = 0
        Edit = 1
    End Enum

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        If openMode = Modo.Add Then
            ' Guardar senha em arquivo
            'IO.File.AppendAllText(main.appFolder & "\" & "chvs.ps", _
            'main.login & ":" & crypt.Criptografar(txtDsc.text) 
            '
            Dim lst As New ListViewItem
            lst.Text = txtDsc.Text
            lst.SubItems.Add(txtPsw.Text)
            main.lstPsw.Items.Add(lst)
            '
            MsgBox(crypt.Criptografar(txtPsw.Text))
            '
            Me.Close()
            '
        ElseIf openMode = Modo.Edit Then
            main.lstPsw.SelectedItems(0).SubItems(0).Text = txtDsc.Text
            main.lstPsw.SelectedItems(0).SubItems(1).Text = txtPsw.Text
            Me.Close()
            '
        End If
    End Sub

    Private Sub chkEx_CheckedChanged(sender As Object, e As EventArgs) Handles chkEx.CheckedChanged
        If chkEx.Checked = True Then
            txtPsw.PasswordChar = ""
        Else
            txtPsw.PasswordChar = "*"
        End If
    End Sub

    Private Sub newPsw_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtDsc.Focus()
    End Sub
End Class