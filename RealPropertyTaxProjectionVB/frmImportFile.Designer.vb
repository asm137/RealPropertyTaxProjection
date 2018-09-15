<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportFile
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
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.radioButton2 = New System.Windows.Forms.RadioButton()
        Me.radioButton1 = New System.Windows.Forms.RadioButton()
        Me.btnSelectImportFile = New System.Windows.Forms.Button()
        Me.btnImportFile = New System.Windows.Forms.Button()
        Me.txtSourceFilePath = New System.Windows.Forms.TextBox()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(101, 74)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(13, 13)
        Me.label2.TabIndex = 12
        Me.label2.Text = "0"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 74)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(83, 13)
        Me.label1.TabIndex = 11
        Me.label1.Text = "Records found: "
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.radioButton2)
        Me.groupBox1.Controls.Add(Me.radioButton1)
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(396, 43)
        Me.groupBox1.TabIndex = 10
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "What to do with the imported data?"
        '
        'radioButton2
        '
        Me.radioButton2.AutoSize = True
        Me.radioButton2.Location = New System.Drawing.Point(201, 20)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(78, 17)
        Me.radioButton2.TabIndex = 1
        Me.radioButton2.TabStop = True
        Me.radioButton2.Text = "New Batch"
        Me.radioButton2.UseVisualStyleBackColor = True
        '
        'radioButton1
        '
        Me.radioButton1.AutoSize = True
        Me.radioButton1.Location = New System.Drawing.Point(7, 20)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(139, 17)
        Me.radioButton1.TabIndex = 0
        Me.radioButton1.TabStop = True
        Me.radioButton1.Text = "Append to Existing Data"
        Me.radioButton1.UseVisualStyleBackColor = True
        '
        'btnSelectImportFile
        '
        Me.btnSelectImportFile.Location = New System.Drawing.Point(252, 133)
        Me.btnSelectImportFile.Name = "btnSelectImportFile"
        Me.btnSelectImportFile.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectImportFile.TabIndex = 9
        Me.btnSelectImportFile.Text = "..."
        Me.btnSelectImportFile.UseVisualStyleBackColor = True
        '
        'btnImportFile
        '
        Me.btnImportFile.Location = New System.Drawing.Point(333, 133)
        Me.btnImportFile.Name = "btnImportFile"
        Me.btnImportFile.Size = New System.Drawing.Size(75, 23)
        Me.btnImportFile.TabIndex = 8
        Me.btnImportFile.Text = "Import"
        Me.btnImportFile.UseVisualStyleBackColor = True
        '
        'txtSourceFilePath
        '
        Me.txtSourceFilePath.Location = New System.Drawing.Point(12, 107)
        Me.txtSourceFilePath.Name = "txtSourceFilePath"
        Me.txtSourceFilePath.Size = New System.Drawing.Size(396, 20)
        Me.txtSourceFilePath.TabIndex = 7
        '
        'openFileDialog1
        '
        Me.openFileDialog1.FileName = "openFileDialog1"
        '
        'frmImportFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 166)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.btnSelectImportFile)
        Me.Controls.Add(Me.btnImportFile)
        Me.Controls.Add(Me.txtSourceFilePath)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImportFile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import Building Data Records"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents radioButton2 As RadioButton
    Private WithEvents radioButton1 As RadioButton
    Private WithEvents btnSelectImportFile As Button
    Private WithEvents btnImportFile As Button
    Private WithEvents txtSourceFilePath As TextBox
    Private WithEvents openFileDialog1 As OpenFileDialog
End Class
