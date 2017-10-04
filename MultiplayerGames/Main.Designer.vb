<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.cmdHangman = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdHangman
        '
        Me.cmdHangman.Location = New System.Drawing.Point(105, 39)
        Me.cmdHangman.Name = "cmdHangman"
        Me.cmdHangman.Size = New System.Drawing.Size(75, 23)
        Me.cmdHangman.TabIndex = 0
        Me.cmdHangman.Text = "Hangman"
        Me.cmdHangman.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.cmdHangman)
        Me.Name = "frmMain"
        Me.Text = "Games"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdHangman As Button
End Class
