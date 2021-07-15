<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newPsw
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDsc = New System.Windows.Forms.TextBox()
        Me.txtPsw = New System.Windows.Forms.MaskedTextBox()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdCnc = New System.Windows.Forms.Button()
        Me.chkEx = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descrição:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Senha:"
        '
        'txtDsc
        '
        Me.txtDsc.Location = New System.Drawing.Point(12, 29)
        Me.txtDsc.Name = "txtDsc"
        Me.txtDsc.Size = New System.Drawing.Size(369, 20)
        Me.txtDsc.TabIndex = 2
        '
        'txtPsw
        '
        Me.txtPsw.Location = New System.Drawing.Point(12, 83)
        Me.txtPsw.Name = "txtPsw"
        Me.txtPsw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPsw.Size = New System.Drawing.Size(369, 20)
        Me.txtPsw.TabIndex = 3
        '
        'cmdOK
        '
        Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdOK.Location = New System.Drawing.Point(225, 109)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 4
        Me.cmdOK.Text = "&OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdCnc
        '
        Me.cmdCnc.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCnc.Location = New System.Drawing.Point(306, 109)
        Me.cmdCnc.Name = "cmdCnc"
        Me.cmdCnc.Size = New System.Drawing.Size(75, 23)
        Me.cmdCnc.TabIndex = 5
        Me.cmdCnc.Text = "&Cancelar"
        Me.cmdCnc.UseVisualStyleBackColor = True
        '
        'chkEx
        '
        Me.chkEx.AutoSize = True
        Me.chkEx.Location = New System.Drawing.Point(12, 109)
        Me.chkEx.Name = "chkEx"
        Me.chkEx.Size = New System.Drawing.Size(83, 17)
        Me.chkEx.TabIndex = 6
        Me.chkEx.Text = "Exibir senha"
        Me.chkEx.UseVisualStyleBackColor = True
        '
        'newPsw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 146)
        Me.Controls.Add(Me.chkEx)
        Me.Controls.Add(Me.cmdCnc)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.txtPsw)
        Me.Controls.Add(Me.txtDsc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "newPsw"
        Me.Text = "Nova senha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDsc As System.Windows.Forms.TextBox
    Friend WithEvents txtPsw As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents cmdCnc As System.Windows.Forms.Button
    Friend WithEvents chkEx As System.Windows.Forms.CheckBox
End Class
