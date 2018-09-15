<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.login = New System.Windows.Forms.Button()
        Me.password = New System.Windows.Forms.TextBox()
        Me.userName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(16, 42)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(59, 13)
        Me.label2.TabIndex = 9
        Me.label2.Text = "Password :"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(16, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(66, 13)
        Me.label1.TabIndex = 8
        Me.label1.Text = "User Name :"
        '
        'login
        '
        Me.login.Location = New System.Drawing.Point(304, 65)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(75, 23)
        Me.login.TabIndex = 7
        Me.login.Text = "Login"
        Me.login.UseVisualStyleBackColor = True
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(138, 39)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(241, 20)
        Me.password.TabIndex = 6
        '
        'userName
        '
        Me.userName.Location = New System.Drawing.Point(138, 12)
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(241, 20)
        Me.userName.TabIndex = 5
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 103)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.login)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.userName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents login As Button
    Private WithEvents password As TextBox
    Private WithEvents userName As TextBox
End Class
