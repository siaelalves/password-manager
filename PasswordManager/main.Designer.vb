<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.components = New System.ComponentModel.Container()
        Me.lstPsw = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdAd = New System.Windows.Forms.Button()
        Me.cmdEd = New System.Windows.Forms.Button()
        Me.cmdExc = New System.Windows.Forms.Button()
        Me.mn1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnAd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnEx = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnEd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mn1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstPsw
        '
        Me.lstPsw.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lstPsw.ContextMenuStrip = Me.mn1
        Me.lstPsw.FullRowSelect = True
        Me.lstPsw.GridLines = True
        Me.lstPsw.Location = New System.Drawing.Point(12, 39)
        Me.lstPsw.Margin = New System.Windows.Forms.Padding(1)
        Me.lstPsw.Name = "lstPsw"
        Me.lstPsw.Size = New System.Drawing.Size(422, 295)
        Me.lstPsw.TabIndex = 0
        Me.lstPsw.UseCompatibleStateImageBehavior = False
        Me.lstPsw.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Descrição"
        Me.ColumnHeader1.Width = 211
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Senha"
        Me.ColumnHeader2.Width = 205
        '
        'cmdAd
        '
        Me.cmdAd.Location = New System.Drawing.Point(10, 10)
        Me.cmdAd.Margin = New System.Windows.Forms.Padding(1)
        Me.cmdAd.Name = "cmdAd"
        Me.cmdAd.Size = New System.Drawing.Size(75, 23)
        Me.cmdAd.TabIndex = 1
        Me.cmdAd.Text = "&Adicionar"
        Me.cmdAd.UseVisualStyleBackColor = True
        '
        'cmdEd
        '
        Me.cmdEd.Location = New System.Drawing.Point(87, 10)
        Me.cmdEd.Margin = New System.Windows.Forms.Padding(1)
        Me.cmdEd.Name = "cmdEd"
        Me.cmdEd.Size = New System.Drawing.Size(75, 23)
        Me.cmdEd.TabIndex = 2
        Me.cmdEd.Text = "&Editar"
        Me.cmdEd.UseVisualStyleBackColor = True
        '
        'cmdExc
        '
        Me.cmdExc.Location = New System.Drawing.Point(166, 10)
        Me.cmdExc.Name = "cmdExc"
        Me.cmdExc.Size = New System.Drawing.Size(75, 23)
        Me.cmdExc.TabIndex = 3
        Me.cmdExc.Text = "E&xcluir"
        Me.cmdExc.UseVisualStyleBackColor = True
        '
        'mn1
        '
        Me.mn1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnAd, Me.mnEd, Me.mnEx})
        Me.mn1.Name = "mn1"
        Me.mn1.Size = New System.Drawing.Size(169, 70)
        '
        'mnAd
        '
        Me.mnAd.Name = "mnAd"
        Me.mnAd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnAd.Size = New System.Drawing.Size(168, 22)
        Me.mnAd.Text = "Adicionar"
        '
        'mnEx
        '
        Me.mnEx.Name = "mnEx"
        Me.mnEx.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.mnEx.Size = New System.Drawing.Size(168, 22)
        Me.mnEx.Text = "Excluir"
        '
        'mnEd
        '
        Me.mnEd.Name = "mnEd"
        Me.mnEd.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.mnEd.Size = New System.Drawing.Size(168, 22)
        Me.mnEd.Text = "Editar"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 346)
        Me.Controls.Add(Me.cmdExc)
        Me.Controls.Add(Me.cmdEd)
        Me.Controls.Add(Me.cmdAd)
        Me.Controls.Add(Me.lstPsw)
        Me.MaximizeBox = False
        Me.Name = "main"
        Me.Text = "Gerenciador de Senhas"
        Me.mn1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstPsw As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdAd As System.Windows.Forms.Button
    Friend WithEvents cmdEd As System.Windows.Forms.Button
    Friend WithEvents cmdExc As System.Windows.Forms.Button
    Friend WithEvents mn1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnAd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnEd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnEx As System.Windows.Forms.ToolStripMenuItem

End Class
